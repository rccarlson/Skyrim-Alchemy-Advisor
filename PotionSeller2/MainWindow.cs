using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotionSeller2
{
    public partial class MainWindow : Form
    {
        EffectBrowser effectBrowser = new EffectBrowser("effects");
        IngredientBrowser IngredientBrowser = new IngredientBrowser("ingredients");
        public MainWindow()
        {
            InitializeComponent();

            //Init ingredients and potions
            foreach (Ingredient ingredient in IngredientBrowser.GetAllIngredients())
                ingredientBox.Items.Add(ingredient);
            foreach (Effect effect in effectBrowser.GetAllEffects())
                effectBox.Items.Add(effect);

            //Init perks
            for (int i = 100; i > 0; i--)
                alchemySkill.Items.Add(i);
            fortifyAlchemyLevel.Items.Add("1%");
            fortifyAlchemyLevel.Items.Add("0%");

            LoadInventory();

        }

        private void CalculateButton_Click(object sender, EventArgs e)
        {
            CalculatePotions();
        }
        void CalculatePotionsAsync()
        {
            this.Invoke(new MethodInvoker(CalculatePotions));
        }
        void CalculatePotions()
        {
            SaveInventory();
            
            //Calculate potions
            List<Ingredient> checkedIngredients = new List<Ingredient>(ingredientBox.CheckedItems.Cast<Ingredient>());
            List<Potion> potions = Potion.GetAllPotions(checkedIngredients);

            //Populate search results with unique effect combinations
            searchResultBox.Items.Clear();
            potions.ForEach(p => searchResultBox.Items.Add(p.ToString()));

            //Get unique effect strings and sort by number of effects
            List<Potion> uniqueEffectPotions = new List<Potion>(potions.Distinct(new PotionEffectComparer()));
            bool madeChange;
            do
            {
                madeChange = false;
                for(int i=0;i<uniqueEffectPotions.Count;i++)
                    for(int j = i + 1; j < uniqueEffectPotions.Count; j++)
                        if(uniqueEffectPotions[i].effects.Count() < uniqueEffectPotions[j].effects.Count())
                        {
                            Potion temp = uniqueEffectPotions[i];
                            uniqueEffectPotions[i] = uniqueEffectPotions[j];
                            uniqueEffectPotions[j] = temp;
                            madeChange = true;
                        }
            } while (madeChange == true);
            searchResultBox.Items.Clear();
            uniqueEffectPotions.ForEach(p => searchResultBox.Items.Add(Effect.GetEffectString(p.effects)));


        }

        #region INVENTORY STORAGE
        /// <summary>
        /// Saves inventory preferances to storage
        /// </summary>
        void SaveInventory()
        {
            //Clear application settings
            PotionSeller2.Properties.Settings.Default.Ingredients.Clear();

            //Save items to settings
            foreach (Ingredient ingredient in ingredientBox.CheckedItems)
            {
                PotionSeller2.Properties.Settings.Default.Ingredients.Add(ingredient.name);
            }
            PotionSeller2.Properties.Settings.Default.Save();
        }
        /// <summary>
        /// Loads inventory preferences from storage
        /// </summary>
        void LoadInventory()
        {
            //PotionSeller2.Properties.Settings.Default.Reload();
            try
            {
                foreach (string ingredientName in PotionSeller2.Properties.Settings.Default.Ingredients)
                {
                    for (int i = 0; i < ingredientBox.Items.Count; i++)
                    {
                        if (ingredientName == ((Ingredient)ingredientBox.Items[i]).name)
                        {
                            ingredientBox.SetItemChecked(i, true);
                        }
                    }
                }
            }
            catch
            {
                PotionSeller2.Properties.Settings.Default.Reset();
            }
        }

        #endregion

        private void fortifyAlchemyLevel_TextChanged(object sender, EventArgs e)
        {
            string contentString = fortifyAlchemyLevel.Text.Replace("%", "");
            int contentValue = Convert.ToInt32(contentString);
            //fortifyAlchemyLevel.Items.Clear();
            for (int i = contentValue + 3; i >= contentValue - 1 && i>=0; i--)
                fortifyAlchemyLevel.Items.Add(Convert.ToString(i) + "%");
            int dummy = 0;
        }
    }
}
