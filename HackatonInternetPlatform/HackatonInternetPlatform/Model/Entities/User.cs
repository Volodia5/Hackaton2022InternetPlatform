﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    internal class User
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string ContactData { get; set; }
        public string LegalInformation { get; set; }

        public User(string fullName, string contactData, string legalInformation)
        {
            FullName = fullName;
            ContactData = contactData;
            LegalInformation = legalInformation;
        }

        //public string Login { get; set; }
        //                                      ???
        //public string Password { get; set; }
    }
}
