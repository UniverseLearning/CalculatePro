using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalculatePro
{
    public partial class FormIndex : Form
    {
        public FormIndex()
        {
            InitializeComponent();
        }

        private void buttonCalculate_Click(object sender, EventArgs e)
        {
            FormCalculate form = new FormCalculate();
            form.ShowDialog();
        }

        private void buttonContract_Click(object sender, EventArgs e)
        {
            FormContract form = new FormContract();
            form.ShowDialog();
        }

        private void buttonMateriel_Click(object sender, EventArgs e)
        {
            FormMateriel form = new FormMateriel();
            form.ShowDialog();
        }
    }
}
