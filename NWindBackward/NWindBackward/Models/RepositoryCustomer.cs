namespace NWindBackward.Models
{
    public class RepositoryCustomer
    {
        private readonly NorthwindContext _context;
        public RepositoryCustomer(NorthwindContext context)
        {
            _context = context;
        }
        public List<Customer> GetAllCustomer()
        {
            return _context.Customers.ToList();
        }
        public List<int> GetAllCustomerId()
        {
            return (from c in _context.Customers select int.Parse(c.CustomerId)).ToList();
        }
        public Customer GetCustomerByID(string id)
        {
            var customer = _context.Customers.Find(id);
            return customer;
        }
        public List<Order> FindOrdersByCustomerID(string CustomerID)
        {
            return _context.Orders.Where(o => o.CustomerId == CustomerID).ToList();
        }
    }
}
