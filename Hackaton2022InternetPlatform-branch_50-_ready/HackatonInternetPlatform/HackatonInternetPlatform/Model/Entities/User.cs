using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    public class User : IReadOnlyUser
    {
        private static int _id;

        public int Id { get; set; }
        public string FullName { get; set; }
        public string ContactData { get; set; }
        public string LegalInformation { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        static User()
        {
            _id = 0;
        }

        public User(string fullName, string contactData, string legalInformation, string login, string password)
        {
            Id = ++_id;
            FullName = fullName;
            ContactData = contactData;
            LegalInformation = legalInformation;
            Login = login;
            Password = password;
        }

        public void Update(string fullName = null, string contactData = null, string legalInformation = null, string login = null, string password = null)
        {
            if (fullName != null)
                FullName = fullName;
            if (contactData != null)
                ContactData = contactData;
            if (legalInformation != null)
                LegalInformation = legalInformation;
            if (login != null)
                Login = login;
            if (password != null)
                Password = password;
        }

        public static int GetCurrentId()
        {
            return _id;
        }

        public static void SetCurrentId(int id)
        {
            _id = id;
        }

        public bool IsPurchaser()
        {
            if(this is Purchaser)
                    return true;
            return false;
        }
    }

    public interface IReadOnlyUser
    {
        public int Id { get; }
        public string FullName { get; }
        public string ContactData { get; }
        public string LegalInformation { get; }
        public string Login { get; }
        public string Password { get; }
    }
}

