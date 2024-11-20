using CinemaApplicationWEB.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CinemaApplicationWEB.Data.Services
{
	public interface IOrdersService
	{
		Task StoreOrderAsync(List<ShoppingCartItem> items, string userId, string userEmailAddress);
		Task<List<Order>> GetOrdersByUserAndRoleAsync(string userId, string userRole);
	}
}
