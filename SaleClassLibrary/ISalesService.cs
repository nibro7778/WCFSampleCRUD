using System.Collections.Generic;
using System.ServiceModel;

namespace SaleClassLibrary
{
    [ServiceContract]
    interface ISalesService
    {
        [OperationContract]
        bool InsertCustomer(Customer obj);

        [OperationContract]
        List<Customer> GetAllCustomer();

        [OperationContract]
        bool DeleteCustomer(int cid);

        [OperationContract]
        bool UpdateCustomer(Customer obj);
    }
}
