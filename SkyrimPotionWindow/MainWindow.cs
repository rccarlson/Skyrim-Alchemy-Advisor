using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SkyrimAlchemy;

//this.Invoke(new MethodInvoker(delegate {  }));
//%userprofile%\appdata\local\EagleBirdman\Skyrim_Potion_Calculator._Url_fyj1gw2zmf0ykcwvtupbojryc4wsqa4l\1.0.0.0

namespace SkyrimPotionWindow
{
    public partial class MainWindow : Form
    {
        bool loading = true;
        public MainWindow()
        {
            InitializeComponent();

            searchProgressBar.Visible = false;

            LoadAll();

            ClearResults();

            backgroundSettingSaver.RunWorkerAsync();

            searchResultUpdater.RunWorkerAsync();

            autoSearchWorker.RunWorkerAsync();

            loading = false;
        }

        #region SAVE/LOAD
        void LoadIngredients()
        {
            //Initialize Properties
            if (Properties.Settings.Default.SelectedIngredients == null)
            {
                Console.WriteLine("Ingredients Setting not found. Initializing...");
                Properties.Settings.Default.SelectedIngredients = new System.Collections.Specialized.StringCollection();
            }

            var collection = Properties.Settings.Default.SelectedIngredients;

            //load all ingredients to UI
            ownedIngredientBox.Items.AddRange(Ingredient.ingredients.ToArray());

            //Get all ingredient names
            List<string> ingredientStringList = Ingredient.ingredients
                .Select(i => i.name)
                .ToList();

            //check all items from settings
            foreach (string ingredient in collection.Cast<string>().ToList())
            {
                int index = ingredientStringList.IndexOf(ingredient);
                if (index >= 0)
                    ownedIngredientBox.SetItemChecked(index, true);
            }

        }
        void SaveIngredients(bool writeToDisk = false)
        {
            List<Ingredient> checkedIngredients = null;
            this.Invoke(new MethodInvoker(delegate
            {
                checkedIngredients = ownedIngredientBox.CheckedItems.Cast<Ingredient>().ToList();
            }));

            Properties.Settings.Default.SelectedIngredients.Clear();
            Properties.Settings.Default.SelectedIngredients.AddRange(checkedIngredients.Select(i => i.name).ToArray());
            if (writeToDisk)
                Properties.Settings.Default.Save();
        }

        void LoadEffects()
        {
            //Initialize Effects
            if (Properties.Settings.Default.SelectedEffects == null)
            {
                Console.WriteLine("Effects Setting not found. Initializing...");
                Properties.Settings.Default.SelectedEffects = new System.Collections.Specialized.StringCollection();
            }

            var collection = Properties.Settings.Default.SelectedEffects;

            //load all effect names
            List<string> effectNames = new List<string>();
            Ingredient.ingredients.ForEach(i =>
            {
                i.effects.ForEach(e =>
                {
                    if (!effectNames.Any(inc => inc == e.name))
                    {
                        //if unique effect name
                        effectNames.Add(e.name);
                    }
                });
            });
            effectNames.Sort();
            desiredEffectBox.Items.AddRange(effectNames.ToArray());

            //check all items from settings
            foreach (string effect in collection.Cast<string>().ToList())
            {
                int index = effectNames.IndexOf(effect);
                if (index >= 0)
                    desiredEffectBox.SetItemChecked(index, true);
            }

        }
        void SaveEffects(bool writeToDisk = false)
        {
            List<string> checkedEffects = null;
            this.Invoke(new MethodInvoker(delegate
            {
                checkedEffects = desiredEffectBox.CheckedItems.Cast<string>().ToList();
            }));

            Properties.Settings.Default.SelectedEffects.Clear();
            Properties.Settings.Default.SelectedEffects.AddRange(checkedEffects.ToArray());
            if (writeToDisk)
                Properties.Settings.Default.Save();
        }

        void LoadParameters()
        {
            try
            {
                alchemySkillUpDown.Value = Properties.Settings.Default.AlchemySkill;
                fortifyAlchemyDomain.Value = Properties.Settings.Default.FortifyAlchemy;
                alchemistPerkComboBox.SelectedIndex = Properties.Settings.Default.AlchemistPerkLevel / 20;
                physicianPerkCheckBox.Checked = Properties.Settings.Default.PhysicianPerk;
                benefactorPerkCheckBox.Checked = Properties.Settings.Default.BenefactorPerk;
                poisonerPerkCheckBox.Checked = Properties.Settings.Default.PoisonerPerk;
                purityPerkCheckBox.Checked = Properties.Settings.Default.PurityPerk;
                seekerOfShadowsCheckBox.Checked = Properties.Settings.Default.SeekerOfShadows;
                autoSearchCheckBox.Checked = Properties.Settings.Default.AutoSearch;
            }
            catch { }
        }
        void SaveParameters(bool writeToDisk = false)
        {
            this.Invoke(new MethodInvoker(delegate
            {
                Properties.Settings.Default.AlchemySkill = (int)alchemySkillUpDown.Value;
                Properties.Settings.Default.FortifyAlchemy = (int)fortifyAlchemyDomain.Value;
                Properties.Settings.Default.AlchemistPerkLevel = Convert.ToInt32(alchemistPerkComboBox.Text.Replace('%', '\0'));
                //alchemistPerkCheckBox.Checked ?
                //Convert.ToInt32(alchemistPerkComboBox.Text.Replace('%', '\0'))
                //: 0;
                Properties.Settings.Default.PhysicianPerk = physicianPerkCheckBox.Checked;
                Properties.Settings.Default.BenefactorPerk = benefactorPerkCheckBox.Checked;
                Properties.Settings.Default.PoisonerPerk = poisonerPerkCheckBox.Checked;
                Properties.Settings.Default.PurityPerk = purityPerkCheckBox.Checked;
                Properties.Settings.Default.SeekerOfShadows = seekerOfShadowsCheckBox.Checked;
                Properties.Settings.Default.AutoSearch = autoSearchCheckBox.Checked;
            }));
            if (writeToDisk)
                Properties.Settings.Default.Save();
        }
        void SaveAll(bool writeToDisk = false)
        {
            Console.WriteLine("Saving " + (writeToDisk ? "to disk" : "without writing to disk") + "...");
            SaveIngredients(false);
            SaveEffects(false);
            SaveParameters(false);
            if (writeToDisk)
                Properties.Settings.Default.Save();
        }
        void LoadAll()
        {
            LoadIngredients();
            LoadEffects();
            LoadParameters();
        }
        #endregion

        void ClearResults()
        {
            resultEffectGroups.Items.Clear();
            searchResultIngredients.Items.Clear();
            potionDetailIngredients.Items.Clear();
            SetPotionDetail(null);
        }
        void SetPotionDetail(Potion potion)
        {
            if (potion == null)
            {
                potionDetailName.Text = "No Potion Selected";
                potionDetailDescription.Text = "";
                potionDetailValue.Text = "";
            }
            else
            {
                potionDetailName.Text = potion.Name;
                potionDetailDescription.Text = "Description: " + potion.Description;
                potionDetailValue.Text = "Value: " + Convert.ToString(potion.Value);
            }
        }

        #region SELECT ALL/NONE
        void SetAllChecked(CheckedListBox box, bool check)
        {
            for (int i = 0; i < box.Items.Count; i++)
                box.SetItemChecked(i, check);
        }

        private void SelectAllIngredients(object sender, LinkLabelLinkClickedEventArgs e) => SetAllChecked(ownedIngredientBox, true);
        private void SelectNoneIngredients(object sender, LinkLabelLinkClickedEventArgs e) => SetAllChecked(ownedIngredientBox, false);
        private void SelectAllEffects(object sender, LinkLabelLinkClickedEventArgs e) => SetAllChecked(desiredEffectBox, true);
        private void SelectNoneEffects(object sender, LinkLabelLinkClickedEventArgs e) => SetAllChecked(desiredEffectBox, false);

        #endregion

        #region SETTINGS INTERFACE
        List<T> GetCheckedItems<T>(CheckedListBox listBox)
        {
            List<T> checkedItems = new List<T>();
            for (int i = 0; i < listBox.Items.Count; i++)
            {
                if ((listBox.GetItemChecked(i) && i != listBox.SelectedIndex) ||
                    (!listBox.GetItemChecked(i) && i == listBox.SelectedIndex))
                {
                    checkedItems.Add((T)listBox.Items[i]);
                }
            }
            return checkedItems;
        }

        private void OwnedIngredientBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Update Settings to reflect user changes
            //var checkedStrings = GetCheckedItems<Ingredient>(ownedIngredientBox).Select(i => i.name);

            //Properties.Settings.Default.SelectedIngredients.Clear();
            //Properties.Settings.Default.SelectedIngredients.AddRange(checkedStrings.ToArray());

            //PrintStringCollection(Properties.Settings.Default.SelectedIngredients);
        }

        private void DesiredEffectBox_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            //Update Settings to reflect user changes
            var checkedStrings = GetCheckedItems<string>(desiredEffectBox);

            Properties.Settings.Default.SelectedEffects.Clear();
            Properties.Settings.Default.SelectedEffects.AddRange(checkedStrings.ToArray());

            PrintStringCollection(Properties.Settings.Default.SelectedEffects);
        }

        void PrintStringCollection(System.Collections.Specialized.StringCollection collection)
        {
            StringBuilder builder = new StringBuilder("Collection:");
            for (int i = 0; i < collection.Count; i++)
            {
                builder.Append('\t' + collection[i]);
            }
            Console.WriteLine(builder.ToString());
        }

        private void ParameterValueChanged(object sender, EventArgs e)
        {
#if DEBUG
            StringBuilder builder = new StringBuilder();
            builder.Append(Convert.ToString(sender));
            builder.Append(" value updated to ");
            if (sender is NumericUpDown)
                builder.Append(((NumericUpDown)sender).Value);
            else if (sender is ComboBox)
                builder.Append(((ComboBox)sender).Text);
            else if (sender is CheckBox)
                builder.Append(((CheckBox)sender).Checked ? "checked" : "unchecked");
            Console.WriteLine(builder.ToString());
#endif

        }
        #endregion

        #region AUTOSAVE
        private void BackgroundSettingSaver_DoWork(object sender, DoWorkEventArgs e)
        {
            System.Threading.Thread autosaveThread = new System.Threading.Thread(new System.Threading.ThreadStart(AutosaveLoop));
            System.Threading.Thread.Sleep(Properties.Settings.Default.IdleTimeout * 1000);
            try
            {
                autosaveThread.Start();
                while (!this.Disposing && !this.IsDisposed && !((BackgroundWorker)sender).CancellationPending)
                {
                    System.Threading.Thread.Sleep(100);
                }
                autosaveThread.Abort();
            }
            catch (System.InvalidOperationException exception) { }
        }
        private void AutosaveLoop()
        {
            Console.WriteLine("Autosave running...");
            while (true)
            {
                //Wait for input to turn active
                while (InputsIdle(Properties.Settings.Default.IdleTimeout * 1000)) { }

                //Wait for input to turn idle
                while (!InputsIdle(Properties.Settings.Default.IdleTimeout * 1000)) { }

                SaveAll(writeToDisk: true);
            }
        }

        private int GetListHash<T>(IEnumerable<T> arr)
        {
            int hash = 0;
            foreach (T i in arr)
                hash ^= i.GetHashCode();
            return hash;
        }
        private int GetInputHash()
        {
            int hash = 0;
            int itemID = 1;

            hash ^= GetListHash(ownedIngredientBox.CheckedItems.Cast<Ingredient>().Select(i => i.name));
            hash ^= GetListHash(desiredEffectBox.CheckedItems.Cast<string>().ToArray());

            if (alchemySkillUpDown.Focused)
                hash ^= alchemySkillUpDown.GetHashCode();
            else
                hash ^= alchemySkillUpDown.Value.GetHashCode();

            if (fortifyAlchemyDomain.Focused)
                hash ^= fortifyAlchemyDomain.GetHashCode();
            else
                hash ^= fortifyAlchemyDomain.Value.GetHashCode();

            hash ^= alchemistPerkComboBox.SelectedText.GetHashCode();

            hash ^= physicianPerkCheckBox.Checked ? (1 << itemID++) : 0;
            hash ^= benefactorPerkCheckBox.Checked ? (1 << itemID++) : 0;
            hash ^= poisonerPerkCheckBox.Checked ? (1 << itemID++) : 0;
            hash ^= purityPerkCheckBox.Checked ? (1 << itemID++) : 0;
            hash ^= autoSearchCheckBox.Checked ? (1 << itemID++) : 0;


            //Console.WriteLine("Input hash: "+Convert.ToString(hash));
            return hash;
        }
        private bool InputsIdle(int ms = 500)
        {
            try { 
            if (Created && !IsDisposed)
            {
                int hash = 0;
                if (!this.IsDisposed && !this.Disposing)
                    this.Invoke(new MethodInvoker(delegate { hash = GetInputHash(); }));
                System.Threading.Thread.Sleep(ms);

                int hash2 = 0;
                if (!this.IsDisposed && !this.Disposing)
                    this.Invoke(new MethodInvoker(delegate { hash2 = GetInputHash(); }));
#if DEBUG
                Console.WriteLine(hash == hash2 ? "Idle" : "Active");
#endif
                return hash == hash2;
            }
            else
                return false;
            }
            catch (System.InvalidOperationException exception) { }
            return false;
        }
        #endregion

        #region SEARCH
        Task<EffectGrouping> resultTask = null;
        EffectGrouping effectGrouping = null;
        int lastSearchInputHash = 0;
        System.Threading.CancellationTokenSource searchCancelToken = new System.Threading.CancellationTokenSource();
        private class EffectGrouping
        {
            public readonly List<string> effects = new List<string>();
            public readonly List<int> values = new List<int>();
            public readonly List<List<Potion>> potions = new List<List<Potion>>();
            int maxIndex = -1;
            public EffectGrouping() { }
            public EffectGrouping(List<Potion> potions)
            {
                foreach (Potion potion in potions)
                    Add(potion);
            }
            int IndexOfEffect(string effectString, int value)
            {
                for (int i = 0; i < effects.Count; i++)
                {
                    if (effects[i] == effectString && values[i] == value)
                    {
                        return i;
                    }
                }
                return -1;
            }
            public void Add(Potion potion)
            {
                string effectString = MainWindow.GetEffectGroupString(potion);
                int value = potion.Value;
                int index = IndexOfEffect(effectString, value);
                if (index < 0)
                {
                    effects.Add(effectString);
                    values.Add(value);
                    potions.Add(new List<Potion>() { potion });
                    maxIndex++;
                }
                else
                {
                    potions[index].Add(potion);
                }
            }
            public List<Potion> GetPotions(string effectString, int value)
            {
                int index = IndexOfEffect(effectString, value);
                if (index < 0)
                    return null;
                else
                {
                    return potions[index].OrderBy(l => l.ingredients.Count).ToList();
                }
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            Search(writeInputsToDisk: true, updateInPlace: false);
        }
        void Search(bool writeInputsToDisk, bool updateInPlace)
        {
            Console.WriteLine("Starting search...");
            SaveAll(writeToDisk: writeInputsToDisk);

            this.Invoke(new MethodInvoker(delegate
            {
                //If a task is currently running, cancel its token
                if (resultTask != null)
                    searchCancelToken.Cancel();
                //create a new cancellation token source
                searchCancelToken = new System.Threading.CancellationTokenSource();
                //Create a new task with a cancellation token
                resultTask = new Task<EffectGrouping>(() => GetPotions(searchCancelToken.Token));
                resultTask.Start();
                //Identify inputs in hash
                lastSearchInputHash = GetInputHash();
            }));
            Console.WriteLine("search started");
        }
        EffectGrouping GetPotions(System.Threading.CancellationToken token)
        {

            List<Ingredient> selectedIngredients = new List<Ingredient>();
            int alchemySkill = 0,
                fortifyAlchemy = 0,
                alchemistPerk = 0;
            bool physicianPerk = false,
                benefactorPerk = false,
                poisonerPerk = false,
                seekerOfShadows = false,
                purityPerk = false;
            this.Invoke(new MethodInvoker(delegate
            {
                selectedIngredients = ownedIngredientBox.CheckedItems.Cast<Ingredient>().ToList();
                alchemySkill = (int)alchemySkillUpDown.Value;
                fortifyAlchemy = (int)fortifyAlchemyDomain.Value;
                alchemistPerk = Convert.ToInt32(alchemistPerkComboBox.Text.Replace('%', '\0'));
                physicianPerk = physicianPerkCheckBox.Checked;
                benefactorPerk = benefactorPerkCheckBox.Checked;
                poisonerPerk = poisonerPerkCheckBox.Checked;
                seekerOfShadows = seekerOfShadowsCheckBox.Checked;
                purityPerk = purityPerkCheckBox.Checked;

                searchProgressBar.Maximum = (selectedIngredients.Count * (selectedIngredients.Count - 1) * (selectedIngredients.Count + 1)) / 6;
                searchProgressBar.Value = 0;
                searchProgressBar.Visible = true;
            }));


            EffectGrouping effectGrouping = new EffectGrouping();
            //Iterate through all possible potion mixes
            //Tetrahedral number of iterations
            //221815 iterations for 110 ingredients
            int count = 0,
                predictedTotalCount = (selectedIngredients.Count * (selectedIngredients.Count - 1) * (selectedIngredients.Count + 1)) / 6;
            for (int i = 0; i < selectedIngredients.Count && !token.IsCancellationRequested; i++)
            {
                for (int j = i + 1; j < selectedIngredients.Count; j++)
                {
                    for (int k = j; k < selectedIngredients.Count; k++)
                    {
                        Potion potion = new Potion(selectedIngredients[i], selectedIngredients[j], selectedIngredients[k]
                            , alchemySkill
                            , fortifyAlchemy
                            , alchemistPerk
                            , physicianPerk
                            , benefactorPerk
                            , poisonerPerk
                            , seekerOfShadows
                            , purityPerk);
                        if (potion.IsValid && potion.effects.Any(e=>desiredEffectBox.CheckedItems.Contains(e.name)))
                            effectGrouping.Add(potion);
                        count++;
                    }
                }
                this.Invoke(new MethodInvoker(delegate
                {
                    searchProgressBar.Value = count;
                }));
            }
            if (token.IsCancellationRequested)
                Console.WriteLine("Aborted search");
            this.Invoke(new MethodInvoker(delegate
            {
                searchProgressBar.Visible = false;
            }));
            return effectGrouping;
        }
        private void searchResultUpdater_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (!this.Disposing && !this.IsDisposed && !((BackgroundWorker)sender).CancellationPending)
                {
                    System.Threading.Thread.Sleep(100);
                    if (resultTask != null && resultTask.IsCompleted && !loading)
                    {
                        Console.WriteLine("Results available. Fetching...");

                        effectGrouping = resultTask.Result;
                        resultTask = null;

                        List<ListViewItem> items = new List<ListViewItem>();
                        for (int i = 0; i < effectGrouping.effects.Count; i++)
                            items.Add(new ListViewItem(new string[] { effectGrouping.effects[i], Convert.ToString(effectGrouping.values[i]) }));

                        items = items.OrderBy(i=>i.SubItems[0].Text).OrderBy(i => Convert.ToInt32(i.SubItems[1].Text)).ToList();
                        items.Reverse();

                        this.Invoke(new MethodInvoker(delegate
                        {
                            //ClearResults();
                            //resultEffectGroups.Items.AddRange(items.ToArray());
                            UpdateInPlace(resultEffectGroups, items);
                        }));
                    }
                }
            }
            catch (System.InvalidOperationException exception) { }
        }
        protected static string GetEffectGroupString(Potion potion)
        {
            StringBuilder builder = new StringBuilder();
            for (int i = 0; i < potion.effects.Count; i++)
            {
                if (i != 0)
                {
                    builder.Append(", ");
                }
                builder.Append(potion.effects[i].name);
            }
            return builder.ToString();
        }

        private void ResultEffectGroups_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            SetPotionDetail(null);
            if (effectGrouping != null && resultEffectGroups.SelectedItems.Count > 0)
            {
                List<Potion> potions = effectGrouping.GetPotions(resultEffectGroups.SelectedItems[0].SubItems[0].Text, Convert.ToInt32(resultEffectGroups.SelectedItems[0].SubItems[1].Text));
                foreach (Potion p in potions)
                {
                    items.Add(new ListViewItem(p.ingredients.Select(ingredient => ingredient.name).ToArray()));
                }
                SetPotionDetail(potions[0]);
            }
            searchResultIngredients.Items.Clear();
            searchResultIngredients.Items.AddRange(items.ToArray());
        }

        private void SearchResultIngredients_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<ListViewItem> items = new List<ListViewItem>();
            if (searchResultIngredients.SelectedItems.Count > 0)
            {
                //foreach (var item in searchResultIngredients.SelectedItems[0].SubItems.AsQueryable())
                for (int i = 0; i < searchResultIngredients.SelectedItems[0].SubItems.Count; i++)
                {
                    string s = searchResultIngredients.SelectedItems[0].SubItems[i].Text;
                    Ingredient ingredient = Ingredient.GetIngredient(s);
                    items.Add(new ListViewItem(new string[]
                    {
                        ingredient.name
                        ,Convert.ToString(ingredient.value)
                        ,Convert.ToString(ingredient.weight)
                        ,ingredient.obtained
                    }));
                }
            }

            potionDetailIngredients.Items.Clear();
            potionDetailIngredients.Items.AddRange(items.ToArray());
        }
        private void AutoSearchWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                while (!Disposing && !IsDisposed)
                {
                    System.Threading.Thread.Sleep(100);
                    int hash = 0;
                    this.Invoke(new MethodInvoker(delegate { hash = GetInputHash(); }));
                    if (autoSearchCheckBox.Checked && lastSearchInputHash!= hash)
                    {
                        //Auto search is on and input has changed since last search
                        Console.WriteLine("Running auto search");
                        Search(false, true);
                    }
                }
            }
            catch (System.InvalidOperationException exception) { }
        }

        /// <summary>
        /// Update <paramref name="listView"/> without removing any items that are still valid
        /// </summary>
        /// <param name="listView"><see cref="ListView"/> item to be updated</param>
        /// <param name="newItems">New items to be added</param>
        void UpdateInPlace(ListView listView, List<ListViewItem> newItems)
        {
#if DEBUG
            List<ListViewItem> originalItems = listView.Items.Cast<ListViewItem>().ToList();
#endif
            //Remove invalid extant items
            for (int i = listView.Items.Count - 1; i >= 0; i--)
            {
                bool stillValid = newItems.Any(item => item.SubItems[0].Text == listView.Items[i].SubItems[0].Text
                && item.SubItems[1].Text == listView.Items[i].SubItems[1].Text);
                if (!stillValid)
                {
                    listView.Items.RemoveAt(i);
                }
            }

            //Add new items
            for(int i = 0; i < newItems.Count; i++)
            {
                int listViewCount = listView.Items.Count;
                //if the listview has an item in index i that is not equal to the new item, insert the new item
                if (listViewCount > i && !(listView.Items[i].SubItems[0].Text == newItems[i].SubItems[0].Text
                    && listView.Items[i].SubItems[1].Text == newItems[i].SubItems[1].Text))
                    listView.Items.Insert(i, newItems[i]);
                //if the listview does not extend to this point, just add it to the end
                else if (listViewCount <= i)
                    listView.Items.Add(newItems[i]);
            }

            if(listView.Items.Count!=newItems.Count)
            {
                Console.WriteLine("INVALID UPDATE CREATED. GENERATED RESULT COUNT ("
                    + Convert.ToString(listView.Items.Count)
                    + ") DOES NOT EQUAL ACTUAL RESULT COUNT ("
                    + Convert.ToString(newItems.Count)
                    + ")");
#if DEBUG
                List<ListViewItem> failedToRemove = listView.Items.Cast<ListViewItem>().ToList()
                    .Where(item => !newItems
                        .Any(i => i.SubItems[0].Text == item.SubItems[0].Text && i.SubItems[1].Text == item.SubItems[1].Text))
                    .ToList();
                List<ListViewItem> failedToAdd = newItems.Where(item => !listView.Items.Cast<ListViewItem>().Any(i =>
                i.SubItems[0].Text == item.SubItems[0].Text && i.SubItems[1].Text == item.SubItems[1].Text
                )).ToList();
                List<ListViewItem> duplicateItems = listView.Items.Cast<ListViewItem>().Where(item =>
                listView.Items.Cast<ListViewItem>().Count(i =>
                i.SubItems[0].Text == item.SubItems[0].Text && i.SubItems[1].Text == item.SubItems[1].Text) > 1).ToList();
                List<ListViewItem> listViewAsList = listView.Items.Cast<ListViewItem>().ToList();
#endif
                int dummy = 0;
#if DEBUG
                listView.Items.Clear();
                listView.Items.AddRange(originalItems.ToArray());
                UpdateInPlace(listView, newItems);
#endif
            }
        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            //for(int i = 0; i < 50; i++)
            //{
            //    int index = random.Next(0, ownedIngredientBox.Items.Count);
            //    bool currChecked = ownedIngredientBox.GetItemChecked(index);
            //    ownedIngredientBox.SetItemChecked(index, !currChecked);
            //}
            for(int i = 0; i < ownedIngredientBox.Items.Count; i++)
            {
                ownedIngredientBox.SetItemChecked(i, random.Next() % 2 == 0);
            }
        }
    }
}
