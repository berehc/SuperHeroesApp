using SuperHeroesApp.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp
{
    internal class PrintInfo
    {
        public void PrintSuperHero(ISuperHero superHero)
        {
            Console.WriteLine($"Id: {superHero.Id}");
            Console.WriteLine($"Name: {superHero.Name}");
            Console.WriteLine($"Secret Identity: {superHero.SecretIdentity}");
        }
    }
}
