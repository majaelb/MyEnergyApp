using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnergyApp.Models
{
    internal class EnergyBudget
    {
        public string? Name { get; set; }
        public int Value { get; set; }
        public Dictionary<int, EnergyBudget>? BudgetPoints { get; set; }

        private static readonly int _getOutOfBed = 1;
        private static readonly int _getDressed = 1;
        private static readonly int _takePills = 1;
        private static readonly int _watchTV = 1;
        private static readonly int _shower = 2;
        private static readonly int _makeupHair = 2;
        private static readonly int _surfInternet = 2;
        private static readonly int _readStudy = 2;
        private static readonly int _makeEatMeal = 3;
        private static readonly int _planAndSocialize = 3;
        private static readonly int _lightHousework = 3;
        private static readonly int _driveCar = 3;
        private static readonly int _work = 4;
        private static readonly int _goShopping = 4;
        private static readonly int _goToDoctor = 4;
        private static readonly int _exercise = 4;

        public EnergyBudget()
        {
            BudgetPoints = GetBudgetPoints();
        }
        public EnergyBudget(string? name, int value)
        {
            Name = name;
            Value = value;
        }
        private static Dictionary<int, EnergyBudget> GetBudgetPoints()
        {
            Dictionary<int, EnergyBudget> budgetPoints = new()
            {
                {1, new EnergyBudget("Get out of bed", _getOutOfBed) },
                {2, new EnergyBudget("Get dressed", _getDressed) },
                {3, new EnergyBudget("Take pills", _takePills) },
                {4, new EnergyBudget("Watch TV", _watchTV) },
                {5, new EnergyBudget("Shower", _shower) },
                {6, new EnergyBudget("Make up and hair", _makeupHair) },
                {7, new EnergyBudget("Surf the internet", _surfInternet) },
                {8, new EnergyBudget("Read or study", _readStudy) },
                {9, new EnergyBudget("Make and eat meal", _makeEatMeal) },
                {10, new EnergyBudget("Plan and socialize", _planAndSocialize) },
                {11, new EnergyBudget("Light housework", _lightHousework) },
                {12, new EnergyBudget("Drive car", _driveCar) },
                {13, new EnergyBudget("Work", _work) },
                {14, new EnergyBudget("Go shopping", _goShopping) },
                {15, new EnergyBudget("Go to doctor", _goToDoctor) },
                {16, new EnergyBudget("Exercise", _exercise) },
            };
            return budgetPoints;
        }
    }
}
