using Data;
using Models;
using System.Linq.Expressions;

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

        public Order GetOrderById(Guid? id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return GetAllOrders().ToList();
        }

        public void AddOrder(Order entity)
        {
            Add(entity); 
        }

        public void RemoveOrder(Order entity)
        {
            Remove(entity);
        }

        public void UpdateOrder(Order entity)
        {
            Update(entity);
        }
    }
}
