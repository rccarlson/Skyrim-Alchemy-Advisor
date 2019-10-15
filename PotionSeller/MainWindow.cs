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
        string potionListBoxLabel;
        public readonly Ingredient[] ingredients;
        public readonly string[] effects;
        private Potion[] potions;
        public MainWindow()
        {
            //initialize database of ingredients and effects
            ingredients = GetIngredients("ingredients.txt").ToArray();
            effects = GetEffects(ingredients).ToArray();

            InitializeComponent();
            potionListBoxLabel = potionLabel.Text;

            //Populate boxes
            foreach (Ingredient ingredient in ingredients)
                ingredientBox.Items.Add(ingredient);
            LoadInventory();
            foreach(string effect in effects)
                effectsBox.Items.Add(effect);

            //Start background worker
            liveUpdateWorker.RunWorkerAsync();
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

        private void CalculatePotionsClick(object sender, EventArgs e)
        {
            SetWindowEnabled(false);
            SaveInventory();
            //potionListBox.Items.Clear();
            //potionOptions.Items.Clear();

            CalculatePotions();

            SetWindowEnabled(true);
        }
        void CalculatePotions()
        {

            //Get all possible potions
            List<Ingredient> checkedIngredients = new List<Ingredient>();
            foreach (Ingredient ingredient in ingredientBox.CheckedItems)
            {
                checkedIngredients.Add(ingredient);
            }
            List<Potion> potions = Potion.GetAllPossiblePotions(checkedIngredients.ToArray());
            this.potions = potions.ToArray();

            //Update output window
            List<string> uniqueEffects = Potion.GetUniqueEffects(potions);
            if (effectsBox.CheckedItems.Count > 0)
            {
                //one or more items is selected in the effects box
                List<string> selectedEffects = new List<string>();
                foreach (string s in effectsBox.CheckedItems)
                    selectedEffects.Add(s);

                for (int i = uniqueEffects.Count - 1; i >= 0; i--)
                {
                    //remove all unique effects not satisfied by effectsBox
                    if (!Potion.AllEffectsPresent(uniqueEffects[i], selectedEffects))
                    {
                        //not all selected effects are present
                        uniqueEffects.RemoveAt(i);
                    }
                    else if (findEffectsExclusiveCheckBox.Checked && !Potion.AllEffectsPresentExclusive(uniqueEffects[i], selectedEffects))
                    {
                        //effect does not match checks
                        uniqueEffects.RemoveAt(i);
                    }
                }
            }
            SortStringsByCommaCount(ref uniqueEffects);
            //potionListBox.Items.Clear();
            //potionOptions.Items.Clear();
            //potionListBox.Items.AddRange(uniqueEffects.ToArray());
            //potionLabel.Text = potionListBoxLabel + " (" + Convert.ToString(potionListBox.Items.Count) + ")";
            this.Invoke(new MethodInvoker(potionListBox.Items.Clear));
            this.Invoke(new MethodInvoker(potionOptions.Items.Clear));
            this.Invoke(new MethodInvoker(delegate { potionListBox.Items.AddRange(uniqueEffects.ToArray()); }));

            this.Invoke(new MethodInvoker(delegate { potionLabel.Text = potionListBoxLabel + " (" + Convert.ToString(potionListBox.Items.Count) + ")"; }));


        }

        #region INVENTORY STORAGE
        /// <summary>
        /// Saves inventory preferances to storage
        /// </summary>
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
        /// <summary>
        /// Loads inventory preferences from storage
        /// </summary>
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
        #endregion
        void SetWindowEnabled(bool enabled)
        {
            //Buttons
            calculatePotionsButton.Enabled = enabled;
            selectAllButton.Enabled = enabled;
            selectNoneButton.Enabled = enabled;
            selectNoneEffectsButton.Enabled = enabled;
            //Lists
            ingredientBox.Enabled = enabled;
            effectsBox.Enabled = enabled;
            potionListBox.Enabled = enabled;
            //Checks
            findEffectsExclusiveCheckBox.Enabled = enabled;
        }

        private void PotionListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selection = (string)potionListBox.SelectedItem;
            potionOptions.Items.Clear();
            foreach(Potion potion in potions)
            {
                if (Potion.AllEffectsPresentExclusive(selection, potion.effects))
                {
                    potionOptions.Items.Add(potion.ingredients[0].name);
                    for(int i = 1; i < potion.ingredients.Count(); i++)
                    {
                        potionOptions.Items[potionOptions.Items.Count - 1].SubItems.Add(potion.ingredients[i].name);
                    }
                }
            }
        }

        #region SELECT ALL/NONE ACTIONS
        private void SelectAllButton_Click(object sender, EventArgs e)
        {
            SetAllIngredientsChecked(true);
        }
        private void SelectNoneButton_Click(object sender, EventArgs e)
        {
            SetAllIngredientsChecked(false);
        }
        private void selectNoneEffectsButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < effectsBox.Items.Count; i++)
                effectsBox.SetItemChecked(i, false);
            CalculatePotions();
        }
        #endregion

        void SetAllIngredientsChecked(bool check)
        {
            for(int i = 0; i < ingredientBox.Items.Count; i++)
                ingredientBox.SetItemChecked(i, check);
            potionListBox.Items.Clear();
            potionOptions.Items.Clear();
        }

        #region EFFECT PROCESSING
        static void SortStringsByCommaCount(ref List<string> vs)
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
        #endregion

        private void LiveUpdateWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            int hash = GetWindowCheckHash();
            do
            {
                int newHash = GetWindowCheckHash();
                if (hash != newHash)
                {
                    hash = newHash;
                    if (liveUpdateCheckBox.Checked)
                        CalculatePotions();
                }
                System.Threading.Thread.Sleep(100);
            } while (!this.IsDisposed);
        }
        private int GetWindowCheckHash()
        {
            return GetFormulaHash(new List<Ingredient>(ingredientBox.CheckedItems.Cast<Ingredient>()),
                new List<string>(effectsBox.CheckedItems.Cast<string>()));
        }
        private int GetFormulaHash(List<Ingredient> ingredients, List<string> effects)
        {
            int hash = 0;
            foreach (Ingredient ingredient in ingredients)
                hash ^= ingredient.name.GetHashCode();
            foreach (string s in effects)
                hash ^= s.GetHashCode();
            return hash;
        }
    }
}
