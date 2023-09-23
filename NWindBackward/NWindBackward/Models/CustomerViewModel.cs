using Microsoft.AspNetCore.Mvc.Rendering;

namespace NWindBackward.Models
{
    public class CustomerViewModel
    {
        public int Id { get; set; }
        public readonly List<SelectListItem> CustomerNamesList;

        public CustomerViewModel(List<Customer> customers)
        {
            CustomerNamesList = new List<SelectListItem>();
            foreach (var customer in customers)
            {
                CustomerNamesList.Add(new SelectListItem
                {
                    Text = customer.ContactName,
                    Value = customer.CustomerId.ToString()
                });
            }
        }
    }
}
