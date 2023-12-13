using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using VPTestProject.Data.EF.Dto;
using VPTestProject.Data.EF.Models;
using VPTestProject.Data.EF.Models.Models;
using VPTestProject.Data.EF.Requests;
using VPTestProject.Data.EF.Response;

namespace VPTestProject.Data.EF.Mapping
{
    public class MapperConfig
    {
        public static Mapper InitializeAutomapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<ProductDto, Product>();
                cfg.CreateMap<CustomerDto, Customer>();
                cfg.CreateMap<Product, ProductDto>();
                cfg.CreateMap<Customer, CustomerDto>();
                cfg.CreateMap<SaveOrderRequest, Order>();
                cfg.CreateMap<Order, OrderResponse>();
            });

            var mapper = new Mapper(config);
            return mapper;
        }
    }
}
