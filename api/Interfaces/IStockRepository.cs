using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using api.Dtos.Stock;
using api.Models;

namespace api.Interfaces
{
    public interface IStockRepository
    {
        Task<List<Stocks>> GetAllAsync();
        Task<Stocks?> GetIdByAsync(int id);
        Task<Stocks> CreateAsync(Stocks stockModel);
        Task<Stocks?> UpdateAsync(int id, UpdateStockRequestDto stockDto);
        Task<Stocks?> DeleteAsync(int id);
        Task<bool> ExistStock(int id);
        
    }
}