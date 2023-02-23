using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnergyApp.Models
{
    internal class DailyEvents
    {
        public int UserId { get; set; }
        public List<EnergyBudget>? ConsumedPointsPerDay { get; set; }
        public Dictionary<DateTime, SelfEstimation>? SelfEstimationResults { get; set; }
    }
}
