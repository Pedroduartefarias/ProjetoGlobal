﻿using System.Collections.Generic;
using System.Threading.Tasks;
using ProjetoGlobal.Models;

namespace ProjetoGlobal.Repositories
{
    public interface IProductRepository
    {
        Task<List<Product>> GetAllAsync();
        Task<Product> GetByIdAsync(string id);
        Task CreateAsync(Product product);
        Task UpdateAsync(string id, Product product);
        Task DeleteAsync(string id);
    }
}
