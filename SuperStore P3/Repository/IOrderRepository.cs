using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IOrderRepository : IGenericRepository<Order>
    {
        Order GetMostRecentOrder();
        Order GetOrderById(Guid? id);
        IEnumerable<Order> GetAllOrders();
        void AddOrder(Order entity);
        void RemoveOrder(Order entity);
        void UpdateOrder(Order entity);
    }
}
