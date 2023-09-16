using Data;
using Models;

namespace EcoPower_Logistics.Repository
{
    public class OrderDetailsRepository : GenericRepository<OrderDetail>, IOrderDetailsRepository
    {
        protected readonly SuperStoreContext _context = new SuperStoreContext();

        public object OrderDetials { get; private set; }

        public IEnumerable<OrderDetail> GetAll()
        {
            return _context.OrderDetails.ToList();
        }

        public OrderDetailsRepository(SuperStoreContext context) : base(context)
        {
            _context = context;
        }

        public OrderDetail GetMostRecentOrderDetail()
        {
            return _context.OrderDetails.OrderByDescending(OrderDetails => Order.CreatedDate).FirstOrDefault();
        }
    }
}
