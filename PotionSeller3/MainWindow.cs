using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PotionSeller3
{
    public partial class MainWindow : Form
    {
        List<Ingredient> ingredients = new List<Ingredient>();
        List<Effect> effects = new List<Effect>();
        public MainWindow()
        {
            InitializeComponent();
            //bool error = false;
            //try
            //{
                SetStatusText("Loading Effects...");
                LoadEffects();
            //}
            //catch(Exception e)
            //{
            //    error = true;
            //    SetStatusText("Error while loading effects");
            //}
            //try
            //{
                SetStatusText("Loading Ingredients...");
                LoadIngredients();
            //}
            //catch(Exception e)
            //{
            //    error = true;
            //    SetStatusText("Error while loading ingredients");
            //}
            //if (error)
            //{
            //    //TODO: load error handling
            //}
            //else
                SetStatusText("Finished Loading");

            Ingredient ingredient1 = Ingredient.GetIngredient("Blue Butterfly Wing");
            Ingredient ingredient2 = Ingredient.GetIngredient("Bone Meal");
            Potion potion = new Potion(ingredient1, ingredient2, ingredient1,
                alchemySkill: 28,
                fortifyAlchemy: 16,
                alchemistPerk: 20,
                physicianPerk: false,
                benefactorPerk: false,
                poisonerPerk: false,
                seekerOfShadows: false,
                purity: false);
            int dummy = 0;
        }
        #region LOADER FUNCTIONS
        public List<List<string>> LoadStringsFromFile(string filename, bool ignoreFirstLine = true)
        {
            List<List<string>> fileStrings = new List<List<string>>();
            using (System.IO.StreamReader fileStream = new System.IO.StreamReader(filename))
            {
                if (ignoreFirstLine)
                    fileStream.ReadLine();
                while (!fileStream.EndOfStream)
                {
                    string line = fileStream.ReadLine();
                    List<string> lineStrings = new List<string>();
                    for (int i = 0;//line.IndexOf('\t');
                        i >= 0 && i<line.Length;
                        i = line.IndexOf('\t', i+1))
                    {
                        int length = line.IndexOf('\t', i + 1) - i;
                        string lineString;

                        if (i + length < line.Length && length > 0)
                            lineString = line.Substring(i, length);
                        else
                            lineString = line.Substring(i);

                        lineStrings.Add(lineString.Trim());
                    }
                    fileStrings.Add(lineStrings);
                }
            }
            return fileStrings;
        }
        public void LoadIngredients()
        {
            //Ingredient	Primary Effect	Secondary Effect	Tertiary Effect	Quaternary Effect	Weight 	Value 	
            ingredients = new List<Ingredient>();
            List<List<string>> fileStrings = LoadStringsFromFile("ingredients.txt");
            foreach(List<string> lineStrings in fileStrings)
            {
                Ingredient ingredient = new Ingredient(lineStrings[0], lineStrings[1], lineStrings[2], lineStrings[3], lineStrings[4], lineStrings[5], lineStrings[6], lineStrings[7]);
                ingredients.Add(ingredient);
            }
            Ingredient.ingredientList = ingredients;

            foreach(Ingredient ingredient in ingredients)
                ingredientsCheckList.Items.Add(ingredient);
        }
        public void LoadEffects()
        {
            //Effect (ID)	Description	Base_Cost	Base_Mag	Base_Dur	Gold Value at 100 Skill
            effects = new List<Effect>();
            List<List<string>> fileStrings = LoadStringsFromFile("effects.txt");
            foreach(List<string> lineStrings in fileStrings)
            {
                Effect effect = new Effect(lineStrings[0], lineStrings[1], lineStrings[2], lineStrings[3], lineStrings[4], lineStrings[5], lineStrings[6], lineStrings[7], lineStrings[8]);
                effects.Add(effect);
            }
            Effect.effectList = effects;

            foreach (Effect effect in effects)
                desiredEffectCheckList.Items.Add(effect);
        }
        #endregion

        void SetStatusText(string text)
        {
            statusText.Text = text;
        }

        
    }
}
