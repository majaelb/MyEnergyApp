using Google.Apis.Services;
using Google.Apis.Util;
using Google.Apis.YouTube.v3;

namespace MyEnergyApp
{
    internal class Program
    {
        static async Task Main(string[] args)
        {
            //EnergyBudget energy = new();
            //foreach (var item in energy.BudgetPoints)
            //{
            //    Console.WriteLine(item.Key + ": " + item.Value.Name + " - " + item.Value.Value + " points");
            //}
            bool searching = true;
            while (searching)
            {
                Console.Write("Vad vill du söka efter? ");
                string? search = Console.ReadLine();
                if (search == "STOP")
                {
                    searching = false;
                }
                else
                {
                    await Youtube.YouTubeService(search);
                }
            }
        }
    }
}