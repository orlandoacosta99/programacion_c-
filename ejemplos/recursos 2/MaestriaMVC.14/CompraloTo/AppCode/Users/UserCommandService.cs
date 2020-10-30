using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CompraloTo.DB;
using CompraloTo.Domain;

using CompraloTo.WebPortal;


namespace CompraloTo.ViewModels
{
    public interface IUserCommandService
    {
        bool UserNameExists(string userName);
        User RegisterUser(RegisterUserCommand cmd);
        void ActivateUser(ActivateUserCommand activateUserCommand);
    }


    public class UserCommandService : IUserCommandService
    {
        private readonly IDbContext _context;

        private readonly IEmailService _emailService;
        private readonly IEmailRenderer _emailRenderer;


        /// <summary>
        /// Constructor from IOC
        /// </summary>
        public UserCommandService(IDbContext context, IEmailService emailService, IEmailRenderer emailRenderer)
        {
            _context = context;
            _emailService = emailService;
            _emailRenderer = emailRenderer;
        }

        /// <summary>
        /// Returns true if the given user name already exists
        /// </summary>
        public bool UserNameExists(string userName)
        {
            return _context.Users().Where(u => u.email == userName).Count() > 0;
        }


        /// <summary>
        /// Register new user in database
        /// </summary>
        public User RegisterUser(RegisterUserCommand cmd)
        {
            Validate.IsFalse(UserNameExists(cmd.email), "Ya existe un usuario con ese email");

            User user = new User()
            {
                createDate = DateTime.Now,
                email = cmd.email,
                password = cmd.password,
                role = UserRole.Customer,
                token = Guid.NewGuid().ToString().Replace("-", ""),

                activated = false
            };

            _context.Add(user);

            _context.SaveChanges();

            //get email template
            string body = _emailRenderer.GetActivationTemplate(new ActivationEmailViewModel() {

                email = user.email,
                token = user.token,

            });


            //send email
            _emailService.SendEmail(new SendEmailCommand() {

                body = body,
                fromName = "CompraloTó",
                fromEmail = "noreply@compraloto.kka",
                subject = "Bienvenido a CompraloTó",
                toEmail = user.email,
                toName = user.email

            });


            return user;

        }

        /// <summary>
        /// Activate existing user in system
        /// </summary>
        public void ActivateUser(ActivateUserCommand cmd)
        {
            Validate.NotNull(cmd, "Invalid request");
            Validate.NotNullEmpty(cmd.token, "Invalid request");
            Validate.NotNullEmpty(cmd.email, "Invalid request");


            User user = _context.Users(true).Where(u => u.email == cmd.email && u.token == cmd.token).FirstOrDefault();

            //user not found
            Validate.NotNull(user, "Invalid request");

            //user already activated?
            Validate.IsTrue(user.activated == false, "User already activated");

            user.activated = true;


            user.token = Guid.NewGuid().ToString().Replace("-", "");


            _context.SaveChanges();

        }
    }
}