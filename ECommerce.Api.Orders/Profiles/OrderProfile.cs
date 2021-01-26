using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Api.Orders.Profiles
{
    public class OrderProfile : AutoMapper.Profile
    {
        public OrderProfile()
        {
            CreateMap<AppDbContext.Order, Models.Order>();
            CreateMap<AppDbContext.OrderItem, Models.OrderItem>();
        }
    }
}
