using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SkyrimAlchemy;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //double fullRunTime = PotionSpeedTest(100);
            List<Potion> potions = GetAllPotions();
            Potion mvp = potions[0];

            int dummy = 0;

            //List<string> ingStrList = new List<string>() { "Bear Claws",
            //"Bee",
            //"Beehive Husk",
            //"Honeycomb",
            //"Human Heart",
            //"Ice Wraith Teeth",
            //"Imp Stool",
            //"Lavender",
            //"Luna Moth Wing",
            //"Namira's Rot",
            //"Nightshade",
            //"Nirnroot",
            //"Purple Mountain Flower",
            //"Red Mountain Flower",
            //"Sabre Cat Tooth"
            //};
            List<string> ingStrList = new List<string>() {
                "Abecean Longfin"
                ,"Blue Butterfly Wing"
                ,"Blue Mountain Flower"
                ,"Bone Meal"
                ,"Cyrodilic Spadetail"
                ,"Dragon's Tongue"
                ,"Fly Amanita"
                ,"Hanging Moss"
                ,"Lavender"
                ,"Luna Moth Wing"
                ,"Nightshade"
                ,"Purple Mountain Flower"
            };

            //Ingredient ingredient_a = Ingredient.GetIngredient("Falmer Ear"),
            //    ingredient_b = Ingredient.GetIngredient("Human Heart");

            //Potion potion = new Potion(
            //    ingredient_a: Ingredient.GetIngredient("Beehive Husk"),
            //    ingredient_b: Ingredient.GetIngredient("Nightshade"),
            //    alchemySkill: 100,
            //    fortifyAlchemy: 0,
            //    alchemistPerk: 0,
            //    physicianPerk: false,
            //    benefactorPerk: false,
            //    poisonerPerk: false,
            //    seekerOfShadows: false,
            //    purity: false
            //    );

            List<Potion> potionSearch = Potion.GetPotions(ingStrList,
                alchemySkill: 100,
                fortifyAlchemy: 1194248,
                alchemistPerk: 0,
                physicianPerk: false,
                benefactorPerk: false,
                poisonerPerk: false,
                seekerOfShadows: false,
                purity: false);

            potionSearch.Sort();
            potionSearch.Reverse();

            //var search = new List<Potion>(potions.Where(p => p.ingredients.Any(i => i.name == "Beehive Husk") && p.ingredients.Count == 2));

            //Potion randomPotion = potions[new Random().Next(potions.Count)];
            //Potion searchResult = search[4];
            //var value = searchResult.Value;

            //foreach (Potion potion in search)
            //    Console.WriteLine(GetPotionAsDebugString(potion)+"\n\n");

            int dummy1 = 0;
        }


        static double PotionSpeedTest(int count)
        {
            List<double> times = new List<double>();
            for (int i = 0; i < count; i++)
            {
                Console.Write("\rTest #" + Convert.ToString(i + 1) + "/" + Convert.ToString(count));
                times.Add(PotionSpeedTest());
            }
            Console.WriteLine();
            return times.Sum() / (double)times.Count;
        }
        ///Gets time in seconds to mix all possible potions
        static double PotionSpeedTest()
        {
            System.Diagnostics.Stopwatch stopwatch = new System.Diagnostics.Stopwatch();
            stopwatch.Start();

            GetAllPotions();

            stopwatch.Stop();
            TimeSpan elapsed = stopwatch.Elapsed;
            return elapsed.TotalSeconds;
        }
        static List<Potion> GetAllPotions()
        {
            List<Potion> allPotions = new List<Potion>();
            for (int i = 0; i < Ingredient.ingredients.Count; i++)
                for (int j = i + 1; j < Ingredient.ingredients.Count; j++)
                    for (int k = j; k < Ingredient.ingredients.Count; k++)
                    {
                        Potion p = new Potion(
                                ingredient_a: Ingredient.ingredients[i],
                                ingredient_b: Ingredient.ingredients[j],
                                ingredient_c: Ingredient.ingredients[k],
                                alchemySkill: 100,
                                fortifyAlchemy: 0,
                                alchemistPerk: 0,
                                physicianPerk: false,
                                benefactorPerk: false,
                                poisonerPerk: false,
                                seekerOfShadows: false,
                                purity: false
                                );
                        if (p.IsValid)
                        {
                            allPotions.Add(p);
                        }
                    }
            allPotions.Sort();
            allPotions.Reverse();
            return allPotions;
        }
    }
}
