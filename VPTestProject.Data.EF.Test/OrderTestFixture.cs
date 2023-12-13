using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VPTestProject.Data.EF.Models.Models;

namespace VPTestProject.Data.EF.Test
{
    public class OrderTestFixture : IDisposable
    {
        public EfDatabaseContext EfDatabaseContext { get; private set; } = new EfDatabaseContext();
        private readonly Guid _customerId = Guid.NewGuid();
        public OrderTestFixture()
        {
            var customer = new Customer
            {
                    Id = _customerId,
                    FirstName = "John",
                    LastName = "Smith2"
             };

            EfDatabaseContext.Add(customer);
        }
        public void Dispose()
        {
            EfDatabaseContext.Dispose();
        }
    }
}
