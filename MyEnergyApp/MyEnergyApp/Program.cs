namespace MyEnergyApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EnergyBudget energy = new();
            foreach (var item in energy.BudgetPoints)
            {
                Console.WriteLine(item.Key + ": " + item.Value.Name + " - " + item.Value.Value + " points");
            }
        }
    }
}