using GeekShopping.ProductAPI.Data.ValueObjects;
using System.Collections.Generic;

namespace GeekShopping.ProductAPI.Repository
{
    public interface IProductRepository
    {
        Task<IEnumerable<ProductVO>> FindAllAsync();
        Task<ProductVO> FindByIdAsync(Guid id);
        Task<ProductVO> Create(ProductVO product);
        Task<ProductVO> Update(ProductVO product);
        Task<bool> Delete(Guid id);
    }
}
