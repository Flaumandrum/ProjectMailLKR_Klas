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
    public partial class FrmTonen : Form
    {
        public FrmTonen()
        {
            InitializeComponent();
            
        }

        private void btnAnnuleren_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void rdbAllesTonen_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAllesTonen.Checked) { 
                cmbLeerkracht.Visible = false;
                lblTonen.Visible = false;
            }
        }

        private void rdbSpecifiekeLeerkracht_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbSpecifiekeLeerkracht.Checked)
            {
                cmbLeerkracht.Visible = true;
                lblTonen.Visible = true;
            }
        }

        private void FrmTonen_Load(object sender, EventArgs e)
        {
            rdbAllesTonen.Checked = true;
            cmbLeerkracht.Visible = false;
            lblTonen.Visible = false;
            VullenCmb();
        }

        private void VullenCmb ()
        {
            // vraag de lijst met de namen op van de personen
            List<String> ontvNamen = Program.GetPersonen();

            // maak de combobox leeg 
            cmbLeerkracht.Items.Clear();

            // vul de combobox
            foreach (String s in ontvNamen)
            {
                cmbLeerkracht.Items.Add(s);
            }
        }

        private void btnBevestigen_Click(object sender, EventArgs e)
        {
            // welke keuze is gemaakt 
            if (rdbAllesTonen.Checked)
            {
                txtTonen.Text = Program.AllesTonen();
            }
            else 
            {
                //fout controle
                if (cmbLeerkracht.SelectedIndex != -1)
                {
                    txtTonen.Text = Program.GetGegevensPersoon(cmbLeerkracht.SelectedIndex);
                }
                else
                {
                    //foutmelding
                    MessageBox.Show("U moet een leerkracht selecteren", "Error 135", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
