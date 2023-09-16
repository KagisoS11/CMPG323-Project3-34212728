using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderRepository : GenericRepository<Order>, IOrderRepository
    {
        protected readonly SuperStoreContext _context =new SuperStoreContext();

        public IEnumerable<Order> GetAll()
        {
            return _context.Orders.ToList();
        }

        public OrderRepository(SuperStoreContext context) : base(context)
        {
            _context = context;
        }

        public Order GetMostRecentOrder()
        {
            return _context.Orders.OrderByDescending(Orders => Order.CreatedDate).FirstOrDefault();
        }
    }
}
