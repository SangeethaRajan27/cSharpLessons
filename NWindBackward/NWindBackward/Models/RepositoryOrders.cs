using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.CodeAnalysis.CSharp;
using Microsoft.EntityFrameworkCore;

namespace NWindBackward.Models
{
    public class RepositoryOrders
    {
        public NorthwindContext _context;
        public RepositoryOrders(NorthwindContext context)
        {
            _context = context;
        }
        public List<int> GetAllOrderId()
        {
            List<int> OrdersIDs = (from o in _context.Orders select o.OrderId).ToList(); //_context.Orders.Select(o => o.OrderId).ToList();
            return OrdersIDs;
        }
        public Order FindOrderByID(int id)
        {
            var orderById = _context.Orders.Find(id);
            return orderById;

        }
        public List<OrderDetail> FindOrderDetailByOrderId(int id)
        {
            /*Order order = _context.Orders.Find(id);
            return order.OrderDetails.ToList(); */

            //one to many  connection (order ->order details )
            //prev we are look for order with its id only
            // now we said to order and also include the child also ,after doing then we search
            List<Order> ordersWithOrderDetails = _context.Orders.Include(d => d.OrderDetails).ToList();
            Order order = ordersWithOrderDetails.FirstOrDefault(x => x.OrderId == id);
            return order.OrderDetails.ToList();
        }
    }
}

