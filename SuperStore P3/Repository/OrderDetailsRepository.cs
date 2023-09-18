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

        public OrderDetailsRepository()
        {
        }

        public OrderDetail GetMostRecentOrderDetail()
        {
            return _context.OrderDetails.OrderByDescending(OrderDetails => Order.CreatedDate).FirstOrDefault();
        }

        public IEnumerable<OrderDetail> GetAllOrderDetails()
        {
            return GetAllOrderDetails().ToList();
        }

        public void AddOrderDetail(OrderDetail entity)
        {
            Add(entity);
        }

        public void RemoveOrderDetail(OrderDetail entity)
        {
            Remove(entity);
        }

        public void UpdateOrderDetail(OrderDetail entity)
        {
            Update(entity);
        }

        public OrderDetail GetOrderDetailById(Guid? id)
        {
            throw new NotImplementedException();
        }
    }
}
