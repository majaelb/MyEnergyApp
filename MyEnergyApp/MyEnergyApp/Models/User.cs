using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyEnergyApp.Models
{
    internal class User
    {
        //En collection/klass för användardata - user
        //En collection/klass - dailyevents - varje gång ett resultat sparas skapas en ny post. UserId ska finnas med, som är Guid Id
        public Guid Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? UserName { get; set; }
        public string? PassWord { get; set; } //Kan man ha password kopplat till dokumentDB?
        public int DailyBudget { get; set; }
        public List<EnergyBudget>? DailyBudgetContent { get; set; }
        

    }
}
