using Data;
using Models;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace EcoPower_Logistics.Repository
{
    public class CustomerRepository : GenericRepository<Customer> , ICustomerRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public IEnumerable<Customer> GetAll()
        {
            return _context.Customers.ToList();
        }

        public CustomerRepository(SuperStoreContext context) : base(context)
        {
            _context = context;
        }

        public Customer GetMostRecentCustomer()
        {
            return _context.Customers.OrderByDescending(Customer => Customer.CreatedDate).FirstOrDefault();
        }

        
    }
}
