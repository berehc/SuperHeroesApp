using System.Security.Cryptography.X509Certificates;
using System.Text;
using SuperHeroesApp;
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

var regeneration = new SuperPower();
regeneration.Name = "Regeneration";
regeneration.Description = "The ability to regenerate organic material such as organs, bones, blood, etc";
regeneration.Level = PowerLevel.LevelThree;

var superman = new SuperHeroe();
var shazam = new SuperHeroe();

superman.Id = 1;
superman.Name = "      Superman   ";
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
string resultSaveTheWorld = superman.SaveTheWorld();
Console.WriteLine(resultSaveTheWorld);

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

var wolverine = new AntiHero();
wolverine.Id = 5;
wolverine.Name = "Wolverine";
wolverine.SecretIdentity = "Logan";
wolverine.CanFly = false;

List<SuperPower> wolverinePowers = new List<SuperPower>();
wolverinePowers.Add(superStrong);
wolverinePowers.Add(regeneration);
wolverine.SuperPowers = wolverinePowers;

string resultSuperWolverinePowers = wolverine.UsingSuperPowers();
Console.WriteLine(resultSuperWolverinePowers);

string antiHeroAction = wolverine.DoAntiHeroAction("Fight against police");
Console.WriteLine(antiHeroAction);

string resultWolverineSave = wolverine.SaveTheWorld();
Console.WriteLine(resultWolverineSave);
enum PowerLevel
{
    LevelOne,
    LevelTwo, 
    LevelThree
}