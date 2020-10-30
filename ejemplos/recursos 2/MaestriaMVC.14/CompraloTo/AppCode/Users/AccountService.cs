using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using CompraloTo.DB;
using CompraloTo.Domain;
using System.Web.Security;

namespace CompraloTo.ViewModels
{
    public interface IAccountService
    {
        bool ValidateUser(string email, string password, bool persist);
        bool IsAuthenticated { get; }
        bool IsInRoles(string roles);

        void LogOut();
    }


    public class AccountService : IAccountService
    {
        private readonly IDbContext _context;

        public AccountService(IDbContext context)
        {
            _context = context;
        }

        public bool IsAuthenticated
        {
            get
            {
                return System.Threading.Thread.CurrentPrincipal.Identity.IsAuthenticated;
            }
        }



        public bool IsInRoles(string roles)
        {
            User user = GetUser();
            if (string.IsNullOrEmpty(roles))
                return true;

            string[] tokens = roles.Split(',');

            if (tokens.Contains(UserRole.Admin.ToString()) && user.role == UserRole.Admin)
                return true;
            else if (tokens.Contains(UserRole.Customer.ToString()) && user.role == UserRole.Customer)
                return true;

            return false;
        }



        private User _user;
        private User GetUser()
        {
            if (_user != null)
                return _user;

            if (!IsAuthenticated)
                throw new UnauthorizedAccessException();

            int userID = int.Parse(System.Threading.Thread.CurrentPrincipal.Identity.Name);
            _user = _context.Users().Where(u => u.ID == userID).FirstOrDefault();

            if (_user == null)
                throw new UnauthorizedAccessException();

            return _user;
        }


        public bool ValidateUser(string email, string password, bool persist)
        {
            _user =  _context.Users().Where(u => u.email == email && u.password == password && u.activated == true).FirstOrDefault();
            if (_user == null)
                return false;

            //authenticate to user
            FormsAuthentication.SetAuthCookie(_user.ID.ToString(), persist);

            return true;
        }


        public void LogOut()
        {
            FormsAuthentication.SignOut();
        }

    }
}