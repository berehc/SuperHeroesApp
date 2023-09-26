using System.Security.Cryptography.X509Certificates;
using System.Text;
using SuperHeroesApp.Models;

var flying = new SuperPower();
flying.Name = "Flying";
flying.Description = "Ability to fly and glide in the air";
flying.Level = PowerLevel.LevelTwo;

var superStrong = new SuperPower();
superStrong.Name = "Super Strong";
superStrong.Description = "";
superStrong.Level = PowerLevel.LevelThree;

var wisdom = new SuperPower();
wisdom.Name = "Wisdom";
wisdom.Description = "the ability to use your experience and knowledge in order to make sensible decisions or judgments";
wisdom.Level = PowerLevel.LevelThree;

var superSpeed = new SuperPower();
superSpeed.Name = "Super Speed";
superSpeed.Description = "";
superSpeed.Level = PowerLevel.LevelTwo;

var courage = new SuperPower();
courage.Name = "Courage";
courage.Description = "";
courage.Level = PowerLevel.LevelOne;

var superman = new SuperHeroe();
var shazam = new SuperHeroe();

superman.Id = 1;
superman.Name = "Superman";
superman.SecretIdentity = "Clark Kent";
superman.City = "Metropolis";
superman.CanFly = true;

List<SuperPower> supermanPowers = new List<SuperPower>();
supermanPowers.Add(flying);
supermanPowers.Add(superStrong);
supermanPowers.Add(superSpeed);
superman.SuperPowers = supermanPowers;

string resultSuperPowers = superman.UsingSuperPowers();
Console.WriteLine(resultSuperPowers);

shazam.Id= 2;
shazam.Name = "Shazam";
shazam.SecretIdentity = "William Joseph \"Billy\" Batson";
shazam.City = "Fawcett";
shazam.CanFly = false;

List<SuperPower> shazamPowers = new List<SuperPower>();
shazamPowers.Add(wisdom);
shazamPowers.Add(superSpeed);
shazamPowers.Add(courage);
shazam.SuperPowers = shazamPowers;

enum PowerLevel
{
    LevelOne,
    LevelTwo, 
    LevelThree
}