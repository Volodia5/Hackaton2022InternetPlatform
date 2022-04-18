using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    [Serializable]
    internal class Purchaser : User
    {

        private List<Request>? _requests { get; set; }
        public Purchaser(string fullName, string contactData, string legalInformation, List<Request> requests) 
            : base(fullName, contactData, legalInformation)
        {
            FullName = fullName;
            ContactData = contactData;
            LegalInformation = legalInformation;
            _requests = requests;
        }
    }
}
