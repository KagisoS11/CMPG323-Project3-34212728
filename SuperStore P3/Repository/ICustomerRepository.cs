using Models;

namespace EcoPower_Logistics.Repository
{
    public interface ICustomerRepository : IGenericRepository<Customer>
    {
        Customer GetMostRecentCustomer();
        Customer GetCustomerById(Guid? id);
        IEnumerable<Customer> GetAllCustomers();
        void AddCustomer(Customer entity);
        void RemoveCustomer(Customer entity);
        void UpdateCustomer(Customer entity);
    }
}
