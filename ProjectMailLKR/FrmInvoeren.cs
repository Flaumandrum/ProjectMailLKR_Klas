using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectMailLKR
{
    public partial class FrmInvoeren : Form
    {
        public FrmInvoeren()
        {
            InitializeComponent();
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnToevoegen_Click(object sender, EventArgs e)
        {
            //fout controle
            if(txtVoornaam.Text != "" && txtAchternaam.Text != "")
            {
                // stuur het door naar de functie
                Program.PersoonToevoegen(txtVoornaam.Text, txtAchternaam.Text);

                // Begeleiden gebruiker
                MessageBox.Show("Deze persoon werd toegevoegd", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Reset form
                txtVoornaam.Text = "";
                txtAchternaam.Text = "";

            }
            else
            {
                //foutmelding
                MessageBox.Show("U moet alle velden invullen.", "Error 784", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
