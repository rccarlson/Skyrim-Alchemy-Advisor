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
            foreach (Ingredient ingredient in IngredientBrowser.GetAllIngredients())
                ingredientBox.Items.Add(ingredient);
            foreach (Effect effect in effectBrowser.GetAllEffects())
                effectBox.Items.Add(effect);

            Potion p = new Potion(new Ingredient[] { IngredientBrowser.GetAllIngredients()[1],
            IngredientBrowser.GetAllIngredients()[2],
            IngredientBrowser.GetAllIngredients()[4]});
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
            List<Ingredient> checkedIngredients = new List<Ingredient>(ingredientBox.CheckedItems.Cast<Ingredient>());
            List<Potion> potions = Potion.GetAllPotions(checkedIngredients);
        }
    }
}
