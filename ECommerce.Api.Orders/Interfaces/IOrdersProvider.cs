using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerce.Api.Orders.Interfaces
{
    /// <summary>
    /// Abstract Interface for Customers Order service with methods to retrieve Order Info. based on CustomerId 
    /// and the Order Item from the Order Entity.
    /// </summary>
    public interface IOrdersProvider
    {
        Task<(bool IsSuccess, IEnumerable<Models.Order> Orders, string ErrorMessage)> GetOrdersAsync(int customerId);
    }
}
