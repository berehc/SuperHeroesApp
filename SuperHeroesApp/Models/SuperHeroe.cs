using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperHeroesApp.Models
{
    class SuperHeroe : Hero
    {
        private string _Name;
        public int Id;
        public override string Name
        {
            get { return _Name; }

            set { _Name = value.Trim(); }
        }

        public string NameSecretIdentity
        {
            get { return $"{Name} ({SecretIdentity})"; }
        }
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
                sb.AppendLine($"{NameSecretIdentity} is using {item.Name} super power");
            }

            return sb.ToString();
        }

        public override string SaveTheWorld()
        {
            return $"{NameSecretIdentity} has saved the world";
        }

        public override string SaveTheEarth()
        {
            //    return base.SaveTheEarth();

            return $"{NameSecretIdentity} has saved the earth";
        }


    }
}
