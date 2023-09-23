namespace NWindBackward.Models
{
    public class RepositoryEmployee
    {
        //constructor based dependency injection we are not creating objects
        /// <summary>
        /// we used to create obj by depency injection
        /// //not useing static
        /// </summary>
        /// <returns></returns>
        private NorthwindContext _context;//you will get null pointer exception when context is not intatiated
        public RepositoryEmployee(NorthwindContext context)
        {
            _context = context;
        }
        public List<Employee> AllEmployees()
        {
            return _context.Employees.ToList();
        }
    }
}
