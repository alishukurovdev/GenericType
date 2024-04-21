
using GenericTypeee.Models;

namespace GenericTypeee
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Wolf wolf = new Wolf
            {
                AvgLifeTime = 10,
                Gender = Gender.Male,
                Breed = "Lenkaran Wolf",
                HP = 100,
                IsPrideLeader = true,
                AttackDamage = 20
            };
            Elephant elephant = new Elephant
            {
                AvgLifeTime = 50,
                Gender = Gender.Female,
                Breed = "Masalli Elephant",
                HP = 200,
                Weight = 5000,
                IsTrained = true
            };
            Meat meat = new Meat { Calorie = 102, MeatType =TypeE.Beef }; //TypeE yazmaqimin sebebi Typen`i kitabxandan cagirirdi
            Console.WriteLine("Food name: "+  TypeE.Beef + ", " + "Food Calorie: "+meat.Calorie);
            Grass grass = new Grass { Calorie = 7, Name = "Elephant Grass" };
            Console.WriteLine("Food name: Grass" +", "+ "Food Calorie: " + grass.Calorie);

            ZooCage<Animal, Food> cage = new ZooCage<Animal, Food>
            {
                Animal = wolf,
                Food = meat
            };
            wolf.Hunt(elephant);

            Console.WriteLine($"Canavar HP: {wolf.HP}");
            Console.WriteLine($"Fil HP: {elephant.HP}");
        }
    }
}
