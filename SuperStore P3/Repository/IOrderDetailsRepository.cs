using Models;

namespace EcoPower_Logistics.Repository
{
    public interface IOrderDetailsRepository : IGenericRepository<OrderDetail>
    {
        OrderDetail GetMostRecentOrderDetail();
        OrderDetail GetOrderDetailById(Guid? id);
        IEnumerable<OrderDetail> GetAllOrderDetails();
        void AddOrderDetail(OrderDetail entity);
        void RemoveOrderDetail(OrderDetail entity);
        void UpdateOrderDetail(OrderDetail entity); 
    }
}
