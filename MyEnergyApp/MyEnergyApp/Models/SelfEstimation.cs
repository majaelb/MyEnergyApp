using MyEnergyApp.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnergyApp.Models
{
    internal class SelfEstimation
    {
        public int Score { get; set; }
        public string? Result { get; set; }

        public List<string>? EstimationQuestions { get; set; } 
        public SelfEstimation()
        {

        }

        public SelfEstimation(int score, string result)
        {
            Score = score;
            Result = result;
        }

        
    }
}
