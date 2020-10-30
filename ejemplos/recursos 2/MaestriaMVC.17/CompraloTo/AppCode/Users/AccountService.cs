using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;

using CompraloTo.DB;
using CompraloTo.Domain;

namespace CompraloTo.ViewModels
{
    public interface IAccountService
    {
        bool ValidateUser(string email, string password, bool persist);
        bool IsAuthenticated { get; }
        bool IsInRoles(string roles);
        void LogOut();

        string CurrentLanguage { get; }
        void SetCurrentLanguage(string langCode);
        string[] GetAvailableLanguages();
        void EnableCulture();

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




        public string CurrentLanguage
        {
            get
            {
                if(HttpContext.Current.Request.Cookies["langCode"] == null)
                {
                    string temp = "es";
                    string[] langs = HttpContext.Current.Request.UserLanguages;
                    if (langs != null && langs.Length > 0)
                    {
                        string[] tokens = langs[0].Split('-');
                        return tokens[0];
                    }

                    return temp;
                }
                return HttpContext.Current.Request.Cookies["langCode"].Value;
            }
        }


        public string[] GetAvailableLanguages()
        {
            return new string[] { "en", "es" };
        }


        public void SetCurrentLanguage(string langCode)
        {
            if (HttpContext.Current.Request.Cookies["langCode"] == null)
            {
                HttpContext.Current.Request.Cookies.Add(new HttpCookie("langCode", langCode));
                HttpContext.Current.Response.Cookies.Add(new HttpCookie("langCode", langCode));
            }
            else
            {
                HttpContext.Current.Request.Cookies["langCode"].Value = langCode;
                HttpContext.Current.Response.Cookies["langCode"].Value = langCode;
            }

            EnableCulture();
        }


        public void EnableCulture()
        {
            System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo(this.CurrentLanguage);

            culture.NumberFormat.CurrencyDecimalSeparator = ",";
            culture.NumberFormat.CurrencyGroupSeparator = ".";
            culture.NumberFormat.CurrencySymbol = "€";
            culture.NumberFormat.CurrencyPositivePattern = 1;
            culture.NumberFormat.CurrencyNegativePattern = 5;

            culture.DateTimeFormat.LongDatePattern = "dd/MM/yyyy HH:mm:ss";
            culture.DateTimeFormat.ShortDatePattern = "dd/MM/yyyy";

            System.Globalization.CultureInfo.CurrentCulture = culture;
            System.Globalization.CultureInfo.CurrentUICulture = culture;
        }
    }
}