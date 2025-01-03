using MoneyTrackAPI.Entities;

namespace MoneyTrackAPI.Repositories
{
    public interface ITypeExpenseRepository
    {
        Task<IEnumerable<TypeExpense>> GetAllExpenses();
        Task<TypeExpense> GetDataType(string? id, string? cd);
    }
}
