using System.Collections.Generic;

namespace CompraloTo.ViewModels
{
    public interface ICustomerQueryService
    {
        CustomerDTO GetCustomerByID(int customerID);
        List<CustomerListDTO> GetCustomerList(GetCustomerListRequest request);
    }
}