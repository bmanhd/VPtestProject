using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using FluentValidation;
using MediatR;
using VPTestProject.Data.EF.Helpers;
using VPTestProject.Data.EF.Mapping;
using VPTestProject.Data.EF.Models;
using VPTestProject.Data.EF.Models.Models;
using VPTestProject.Data.EF.Requests;
using VPTestProject.Data.EF.Response;
using VPTestProject.Data.EF.Validators;

namespace VPTestProject.Data.EF
{
    public class SaveOrderHandler : IRequestHandler<SaveOrderRequest, OrderResponse>
    {
        private EfDatabaseContext _efDatabaseContext;
        private readonly IValidator<SaveOrderRequest> _saveOrderRequestValidator;
        private readonly CustomerHelper _customerHelper;
        private Mapper _mapperConfig = MapperConfig.InitializeAutomapper();

        public SaveOrderHandler(EfDatabaseContext efDatabaseContext, CustomerHelper createCustomer, IValidator<SaveOrderRequest> saveOrderRequestValidator)
        {
            _efDatabaseContext = efDatabaseContext;
            _customerHelper = createCustomer;
            _saveOrderRequestValidator = saveOrderRequestValidator;
        }

        public async Task<OrderResponse> Handle(SaveOrderRequest request, CancellationToken cancellationToken)
        {
            _saveOrderRequestValidator.ValidateAndThrow(request);

            //Commented as wont work without real DB
            //await SaveCustomer(request, cancellationToken);

            //
            var orderToSave = _mapperConfig.Map<Order>(request);
            orderToSave.DateCreated = DateTime.Now;

            //as above, this will save changes
            //await _efDatabaseContext.SaveChangesAsync(cancellationToken);

            var response = _mapperConfig.Map<OrderResponse>(orderToSave);

            response.ProductCount = request.Products.Count;

            return response;
        }

        private async Task SaveCustomer(SaveOrderRequest request, CancellationToken cancellationToken)
        {
            var customer = _efDatabaseContext.Customers.FirstOrDefault(c => c.Id == request.Customer.Id);

            request.Customer = _customerHelper.CreateUpdateCustomer(request.Customer, _efDatabaseContext);            
        }
    }
}
