using ExpenseTracker.Models;

namespace ExpenseTracker.Services
{
    public class ExpenseService
    {
        private List<Expense> expenses = new();
        public List<Expense> GetExpenses() { return expenses; }

        public void AddExpense(Expense expense)
        {
            expenses.Add(expense);
        }

        public void DeleteExpense(int id)
        {
            expenses.RemoveAll(e=> e.Id == id);
        }

		public void UpdateExpense(Expense updatedExpense)
		{

			//find that expense in the list matching the id(can maybe make more efficient? in huge dddataset we'd be looking twice)
			var expense = expenses.FirstOrDefault(e => e.Id == updatedExpense.Id);
			//if that expense exists
			if (expense != null)
			{
				expense.Description = updatedExpense.Description;
				expense.Amount = updatedExpense.Amount;
				expense.Category = updatedExpense.Category;
				expense.Date = updatedExpense.Date;
			}
		}
	}
}
