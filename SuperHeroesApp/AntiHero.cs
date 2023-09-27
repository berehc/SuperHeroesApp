using SuperHeroesApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp
{
    internal class AntiHero : SuperHeroe
    {
        public string DoAntiHeroAction(string action)
        {
            return $"Antihero {Name} has done: {action}";
        }
    }
}
