using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SkyrimPotionWindow
{
    public partial class PercentUpDown : NumericUpDown
    {
        public PercentUpDown()
        {
            InitializeComponent();
            base.Maximum = int.MaxValue;
        }
        protected override void UpdateEditText()
        {
            this.Text = Convert.ToString(this.Value) + '%';
        }
    }
}
