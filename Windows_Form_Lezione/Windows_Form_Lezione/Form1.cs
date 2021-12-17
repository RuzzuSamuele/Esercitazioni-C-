using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Windows_Form_Lezione
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void ListaCittà_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string Text = ListaCittà.GetItemText(ListaCittà.SelectedItem);
            MessageBox.Show(Text);
        }

        private void buttonInvia_Click(object sender, EventArgs e)
        {
            string Nome = TextBox_Nome.Text;
            string Indirizzo = TextBox_Indirizzo.Text;

            MessageBox.Show(Nome + Indirizzo);
        }
    }
}
