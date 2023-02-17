using Google.Apis.Services;
using Google.Apis.Util;
using Google.Apis.YouTube.v3;
using MyEnergyApp.Logic;
using MyEnergyApp.Models;

namespace MyEnergyApp
{
    internal class Program
    {
        //.NET 7?
        //Användare i dokumentDB, hur?
        static async Task Main(string[] args)
        {
            EnergyBudget energy = new();
            foreach (var item in energy.BudgetPoints)
            {
                Console.WriteLine(item.Key + ": " + item.Value.Name + " - " + item.Value.Value + " points");
            }
            //bool searching = true;
            //while (searching)
            //{
            //    Console.Write("Vad vill du söka efter? ");
            //    string? search = Console.ReadLine();
            //    if (search == "STOP")
            //    {
            //        searching = false;
            //    }
            //    else
            //    {
            //        await Youtube.YouTubeService(search);
            //    }
            //}

            SelfEstimation selfEstimation = new()
            {
                EstimationQuestions = await FileManager.SplitFileToStringListAsync("Skattningsformulär.txt")
            };

            foreach (var question in selfEstimation.EstimationQuestions)
            {
                Console.WriteLine(question);
            }



            LinksAndTips linksTips = new()
            {
                EnergyTips = await FileManager.SplitFileToStringListAsync("Energitips.txt"),
                Links = await FileManager.SplitFileToStringListAsync("Länkar.txt")
            };



            foreach (var link in linksTips.Links)
            {
                Console.WriteLine(link);
            }

            foreach (var tip in linksTips.EnergyTips)
            {
                Console.WriteLine(tip);
            }
        }
    }
}