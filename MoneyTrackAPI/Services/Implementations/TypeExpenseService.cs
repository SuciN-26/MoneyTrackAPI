using MoneyTrackAPI.Entities;

namespace MoneyTrackAPI.Services.Implementations
{
    public class TypeExpenseService : ITypeExpenseService
    {
        public Task<IEnumerable<TypeExpense>> GetAllTypeExpenses()
        {
            throw new NotImplementedException();
        }

        public Task<TypeExpense> GetTypeExpense(string? id, string? cd)
        {
            throw new NotImplementedException();
        }
    }
}
