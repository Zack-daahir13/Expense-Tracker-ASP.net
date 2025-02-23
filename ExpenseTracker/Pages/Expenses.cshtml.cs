using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ExpenseTracker.Pages
{
    public class ExpensesModel : PageModel
    {
      public List<Expense> Expenses { get; set; } = new List<Expense>();


        public void OnGet()
        {
            // Initialize the Expenses list or load from a data source
            Expenses = new List<Expense>
            {
                new Expense { Name = "Groceries", Amount = 50.75, Date = DateTime.Now.AddDays(-1).ToString("yyyy-MM-dd") },
                new Expense { Name = "Rent", Amount = 1200.00, Date = DateTime.Now.AddDays(-5).ToString("yyyy-MM-dd") }
            };
        }
    }

    public class Expense
    {
        public string Name { get; set; }
        public double Amount { get; set; }
        public string Date { get; set; }
    }
}
