using MoneyTrackAPI.Entities;

namespace MoneyTrackAPI.Services
{
    public interface ITypeExpenseService
    {
        Task<TypeExpense> GetTypeExpense(string? id, string? cd);
        Task<IEnumerable<TypeExpense>> GetAllTypeExpenses();
    }
}
