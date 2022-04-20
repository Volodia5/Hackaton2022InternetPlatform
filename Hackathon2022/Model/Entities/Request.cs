using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    [Serializable]
    public class Request : IReadOnlyRequest
    {
        private static int _id;

        public int ID { get; private set; }
        public string Name { get; private set; }
        public int Count { get; private set; }
        public string ProductType { get; private set; }
        public int Cost { get; private set; }
        public char Currency { get; private set; }
        public string PayMethod { get; private set; }
        public string DeliveryAdress { get; private set; }
        public bool IsValid { get; private set; }

        static Request()
        {
            _id = 0;
        }

        public Request(string name, int count, string productType, int cost, char currency, string payMethod, string deliveryAdress, bool isValid)
        {
            ID = ++_id;
            Name = name;
            Count = count;
            ProductType = productType;
            Cost = cost;
            Currency = currency;
            PayMethod = payMethod;
            DeliveryAdress = deliveryAdress;
            IsValid = isValid;
        }

        public void Update(string name = null, int count = -1, string productType = null, int cost = -1, char currency = ' ', string payMethod = null, string deliveryAdress = null, bool isValid = false)
        {
            if (name != null)
                Name = name;
            if (count != -1)
                Count = count;
            if (productType != null)
                ProductType = productType;
            if (cost != -1)
                Cost = cost;
            if (currency != ' ')
                Currency = currency;
            if (payMethod != null)
                PayMethod = payMethod;
            if (deliveryAdress != null)
                DeliveryAdress = deliveryAdress;
            if (isValid != false)
                IsValid = isValid;
        }

        public static int GetCurrentId()
        {
            return _id;
        }

        public static void SetCurrentId(int id)
        {
            _id = id;
        }

        public void Open()
        {
            IsValid = true;
        }

        public void Close()
        {
            IsValid = false;
        }
    }

    public interface IReadOnlyRequest
    {
        public int ID { get; }
        public string Name { get; }
        public int Count { get; }
        public string ProductType { get; }
        public int Cost { get; }
        public char Currency { get; }
        public string PayMethod { get; }
        public string DeliveryAdress { get; }
        public bool IsValid { get; }
    }
}
