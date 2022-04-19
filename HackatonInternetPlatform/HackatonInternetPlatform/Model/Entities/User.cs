using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    internal class User
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

        public void Update()
        {

        }
    }
}
