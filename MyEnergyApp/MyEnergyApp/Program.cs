using Google.Apis.Services;
using Google.Apis.Util;
using Google.Apis.YouTube.v3;
using MyEnergyApp.API;
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
            var youtube = new YouTubeService();
            var uri = youtube.BaseUri;
            Console.WriteLine(uri);


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


            EnergyBudget energy = new();
            foreach (var item in energy.BudgetPoints)
            {
                Console.WriteLine(item.Key + ": " + item.Value.Name + " - " + item.Value.Value + " points");
            }

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