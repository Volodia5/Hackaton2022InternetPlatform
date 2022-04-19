﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    [Serializable]
    internal class Request
    {
        private static int _id;

        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }
        public string ProductType { get; set; }
        public int Cost { get; set; }
        public char Currency { get; set; }
        public string PayMethod { get; set; }
        public string DeliveryAdress { get; set; }
        public bool IsValid { get; set; }

        static Request()
        {
            _id = 0;
        }

        public Request(string name, int count, string productType, int cost, char currency, string payMethod, string deliveryAdress, bool isValid)
        {
            Id = ++_id;
            Name = name;
            Count = count;
            ProductType = productType;
            Cost = cost;
            Currency = currency;
            PayMethod = payMethod;
            DeliveryAdress = deliveryAdress;
            IsValid = isValid;
        }

        public void Update()
        {

        }
    }
}
