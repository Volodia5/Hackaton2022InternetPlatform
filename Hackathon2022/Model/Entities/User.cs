using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    internal class User : IReadOnlyUser
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ContactData { get; set; }
        public string LegalInformation { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }

        public User(string fullName, string contactData, string legalInformation, string login, string password)
        {
            FullName = fullName;
            ContactData = contactData;
            LegalInformation = legalInformation;
            Login = login;
            Password = password;
        }

    }

    internal interface IReadOnlyUser
    {
        public int Id { get;}
        public string FullName { get;}
        public string ContactData { get;}
        public string LegalInformation { get;}
        public string Login { get;}
        public string Password { get;}
    }
}
