using System.Linq;
using VPTestProject.Data.EF.Dto;

namespace VPTestProject.Data.EF.Helpers
{
    public class CustomerHelper
    {
        public CustomerDto CreateUpdateCustomer(CustomerDto customer, Models.Models.EfDatabaseContext _efDatabaseContext)
        {
            var existingCustomer = _efDatabaseContext.Customers.Where(x => x.Id == customer.Id).SingleOrDefault();

            // Newly Inserted Code
            var updatedCustomer = (CustomerDto)CheckUpdateObject(existingCustomer, customer);

            _efDatabaseContext.Entry(existingCustomer).CurrentValues.SetValues(updatedCustomer);

            return updatedCustomer;
        }

        private static object CheckUpdateObject(object originalObj, object updateObj)
        {
            foreach (var property in updateObj.GetType().GetProperties())
            {
                if (property.GetValue(updateObj, null) == null)
                {
                    property.SetValue(updateObj, originalObj.GetType().GetProperty(property.Name)
                    .GetValue(originalObj, null));
                }
            }
            return updateObj;
        }
    }
}
