using Microsoft.EntityFrameworkCore;
using MoneyTrackAPI.Data;
using MoneyTrackAPI.Entities;

namespace MoneyTrackAPI.Repositories.Implementations
{
    public class TypeExpenseRepository : ITypeExpenseRepository
    {
        private readonly MoneyTrackDbContext _ctx;

        public TypeExpenseRepository(MoneyTrackDbContext ctx)
        {
            _ctx = ctx;
        }

        public async Task<IEnumerable<TypeExpense>> GetAllExpenses()
        {
            var typeExpenses = await _ctx.TypeExpenses.ToListAsync();

            return typeExpenses;
        }

        public Task<TypeExpense> GetDataType(string? id, string? cd)
        {
            throw new NotImplementedException();
        }
    }
}
