
using System.Runtime.Serialization;

namespace SaleClassLibrary
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int CustomerId { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

        [DataMember]
        public string Address { get; set; }

        [DataMember]
        public string EmailId { get; set; }
    }
}
