using Cart.API.Entities;

namespace Cart.API.Repositories
{
    public interface ICartRepository
    {
        Task<ShoppingCart> GetCart(string userName);
        Task<ShoppingCart> UpdateCart(ShoppingCart basket);
        Task DeleteCart(string userName);
    }
}
