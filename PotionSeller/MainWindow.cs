using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PotionSeller
{
    public partial class MainWindow : Form
    {
        public readonly Ingredient[] ingredients;
        public readonly string[] effects;
        private Potion[] potions;
        public MainWindow()
        {
            //initialize database of ingredients and effects
            ingredients = GetIngredients("ingredients.txt").ToArray();
            effects = GetEffects(ingredients).ToArray();

            InitializeComponent();

            //Populate boxes
            foreach (Ingredient ingredient in ingredients)
                ingredientBox.Items.Add(ingredient);
            LoadInventory();
        }
        static List<Ingredient> GetIngredients(string filename)
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            using (FileStream file = new FileStream("ingredients.txt", FileMode.Open))
            using (StreamReader reader = new StreamReader(file))
            {
                reader.ReadLine();
                string line;
                while ((line=reader.ReadLine()) != null)
                {
                    ingredients.Add(new Ingredient(line));
                }
            }
            return ingredients;
        }
        static List<string> GetEffects(Ingredient[] ingredients)
        {
            List<string> effects = new List<string>();
            foreach (Ingredient ingredient in ingredients)
                foreach (string effect in ingredient.effects)
                    if (!effects.Contains(effect))
                        effects.Add(effect);
            effects.Sort();
            return effects;
        }

        private void CalculatePotions(object sender, EventArgs e)
        {
            SetEnabled(false);
            SaveInventory();
            potionListBox.Items.Clear();
            potionOptions.Items.Clear();

            //Get all possible potions
            List<Ingredient> checkedIngredients = new List<Ingredient>();
            foreach (Ingredient ingredient in ingredientBox.CheckedItems)
            {
                checkedIngredients.Add(ingredient);
            }
            List<Potion> potions = Potion.GetAllPossiblePotions(checkedIngredients.ToArray());
            this.potions = potions.ToArray();

            //Post unique potion types to the window
            List<string> uniqueEffects = Potion.GetUniqueEffects(potions);
            SortStringsByCommaCount(ref uniqueEffects);
            potionListBox.Items.AddRange(uniqueEffects.ToArray());

            SetEnabled(true);
        }
        void SaveInventory()
        {
            ////Clear application settings
            PotionSeller.Properties.Settings.Default.IngredientsInventory.Clear();

            //Save items to settings
            foreach (Ingredient ingredient in ingredientBox.CheckedItems)
            {
                PotionSeller.Properties.Settings.Default.IngredientsInventory.Add(ingredient.name);
            }
            PotionSeller.Properties.Settings.Default.Save();
        }
        void LoadInventory()
        {
            PotionSeller.Properties.Settings.Default.Reload();
            try
            {
                foreach (string ingredientName in PotionSeller.Properties.Settings.Default.IngredientsInventory)
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
                PotionSeller.Properties.Settings.Default.Reset();
            }
        }
        void SetEnabled(bool enabled)
        {
            calculatePotionsButton.Enabled = enabled;
            selectAllButton.Enabled = enabled;
            selectNoneButton.Enabled = enabled;
            ingredientBox.Enabled = enabled;
        }

        private void PotionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = (string)potionListBox.SelectedItem;
            potionOptions.Items.Clear();
            foreach(Potion potion in potions)
            {
                if(potion.ToString() == selection)
                {
                    potionOptions.Items.Add(potion.ingredients[0].name);
                    for(int i = 1; i < potion.ingredients.Count(); i++)
                    {
                        potionOptions.Items[potionOptions.Items.Count - 1].SubItems.Add(potion.ingredients[i].name);
                    }
                }
            }
        }

        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            SetAllIngredients(true);
        }
        private void SelectNoneButton_Click(object sender, EventArgs e)
        {
            SetAllIngredients(false);
        }
        void SetAllIngredients(bool check)
        {
            for(int i = 0; i < ingredientBox.Items.Count; i++)
                ingredientBox.SetItemChecked(i, check);
            potionListBox.Items.Clear();
            potionOptions.Items.Clear();
        }

        void SortStringsByCommaCount(ref List<string> vs)
        {
            List<int> count = new List<int>();
            vs.ForEach(c => count.Add(c.Count(ch => ch == ',')));
            bool changeMade;
            do
            {
                changeMade = false;
                for (int i = 0; i < vs.Count - 1; i++)
                {
                    if (count[i] < count[i+1])
                    {
                        //string swap
                        string temp = vs[i];
                        vs[i] = vs[i + 1];
                        vs[i + 1] = temp;
                        //count swap
                        int tempCount = count[i];
                        count[i] = count[i + 1];
                        count[i + 1] = tempCount;

                        changeMade = true;
                    }
                }
            } while (changeMade);
        }
    }
}
