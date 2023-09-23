using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using NuGet.Protocol.Core.Types;
using NWindBackward.Models;

namespace NWindBackward.Controllers
{
    public class OrderController : Controller
    {
        private RepositoryOrders _repositoryOrders;
        public OrderController(RepositoryOrders repository)
        {
            _repositoryOrders = repository;
        }
        public ActionResult Index()
        {
            List<int> orderIds = _repositoryOrders.GetAllOrderId();
            OrderIdsViewModel idsViewModel = new OrderIdsViewModel(orderIds);
            return View(idsViewModel);
        }
        public ActionResult Details(int id)
        {
            /*Order order = _repositoryOrders.FindOrderByID(id);
            return View(order);*/
            Order order = _repositoryOrders.FindOrderByID(id); //order id get
            List<OrderDetail> detail = _repositoryOrders.FindOrderDetailByOrderId(id); // for those orderdetails
            ViewData["OrderDetails"] = detail;// view will be bound to order by we need to show those order details  so we use ViewData here
            return View(order);

        }
    }
}