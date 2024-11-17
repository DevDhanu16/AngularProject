using StoreManagementApi.Entity;

namespace StoreManagementApi.Contracts
{
    public interface ICustomer
    {
        string? CustomerActions(CustomerModel customer);
        string ExcelExport(List<CustomerModel> exclModel);
    }
}