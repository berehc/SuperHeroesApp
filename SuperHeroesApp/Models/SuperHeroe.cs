using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroe
    {
        public int Id;
        public string Name;
        public string SecretIdentity;
        public string City;
        public List<SuperPower> SuperPowers;
        public bool CanFly;

        public SuperHeroe()
        {
            Id = 1;
            SuperPowers = new List<SuperPower>();
            CanFly = false;
        }

        public string UsingSuperPowers()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in SuperPowers)
            {
                sb.AppendLine($"{Name} is using {item.Name} super power");
            }

            return sb.ToString();
        }
    }
}
