using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    [Serializable]
    internal class Request
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string ProductType { get; set; }
        public int Cost { get; set; }
        public char Currency { get; set; }
        public string PayMethod { get; set; }
        public string DeliveryAdress { get; set; }
    }
}
