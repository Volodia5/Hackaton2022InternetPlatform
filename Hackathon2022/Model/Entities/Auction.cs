using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonInternetPlatform.Model
{
    [Serializable]
    public class Auction : IReadOnlyAuction
    {
        public List<Request> Requests { get; private set; }
    }

    public interface IReadOnlyAuction
    {
        public List<Request> Requests { get; }
    }
}
