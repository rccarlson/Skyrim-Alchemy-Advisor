using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using SkyrimAlchemy;

namespace SkyrimPotionWindow
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            //load all ingredients
            ownedIngredientBox.Items.AddRange(Ingredient.ingredients.ToArray());

            //load all effect names
            List<string> effectNames = new List<string>();
            Ingredient.ingredients.ForEach(i =>
            {
                i.effects.ForEach(e =>
                {
                    if (!effectNames.Any(inc => inc == e.name)){//if unique effect
                        effectNames.Add(e.name);
                    }
                });
            });
            effectNames.Sort();
            desiredEffectBox.Items.AddRange(effectNames.ToArray());

            PopulateDomainItems(alchemySkillDomain, false, min: 15, max: 100, init: true);
            PopulateDomainItems(fortifyAlchemyDomain, true, min: 0, init: true);
            PopulateDomainItems(alchemistPerkDomain, true, min: 0, max: 100, init: true);
        }

        void PopulateDomainItems(DomainUpDown domain, bool appendPercent, int min = 0, int max = -1, bool init = false)
        {
            string current = domain.Text.Replace('%', '\0');
            int currValue = Convert.ToInt32(current);

            if (init)
            {
                if (max < 0 || currValue + 1 <= max)
                    domain.Items.Add(appendPercent ?
                        Convert.ToString(currValue + 1) + '%' :
                        Convert.ToString(currValue + 1));
                domain.Items.Add(appendPercent ?
                        Convert.ToString(currValue) + '%' :
                        Convert.ToString(currValue));
                if (currValue - 1 >= min)
                    domain.Items.Add(appendPercent ?
                        Convert.ToString(currValue - 1) + '%' :
                        Convert.ToString(currValue - 1));

                domain.SelectedItem = appendPercent ?
                    Convert.ToString(currValue) + '%' :
                    Convert.ToString(currValue);
            }
            else if (domain.SelectedIndex == 0)
            {
                //rising value

            }

            //domain.Items.Clear();
            //if (max < 0 || currValue + 1 <= max)
            //    domain.Items.Add(appendPercent?
            //        Convert.ToString(currValue + 1)+'%':
            //        Convert.ToString(currValue + 1));
            //domain.Items.Add(appendPercent ?
            //        Convert.ToString(currValue) + '%' :
            //        Convert.ToString(currValue));
            //if (currValue - 1 >= min)
            //    domain.Items.Add(appendPercent ?
            //        Convert.ToString(currValue - 1) + '%' :
            //        Convert.ToString(currValue - 1));

            //domain.SelectedItem = appendPercent ?
            //        Convert.ToString(currValue) + '%' :
            //        Convert.ToString(currValue);
        }

        private void UpdateDomainItems(object sender, EventArgs e = null)
        {
            if(sender== alchemySkillDomain)
                PopulateDomainItems((DomainUpDown)sender, false, min: 15, max: 100);
            else if(sender == fortifyAlchemyDomain)
                PopulateDomainItems((DomainUpDown)sender, true, min: 0);
            else if(sender == alchemistPerkDomain)
                PopulateDomainItems((DomainUpDown)sender, true, min: 0, max: 100);
        }
    }
}
