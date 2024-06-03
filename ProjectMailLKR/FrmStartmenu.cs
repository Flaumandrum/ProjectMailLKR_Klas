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
    public partial class FrmStartmenu : Form
    {
        public FrmStartmenu()
        {
            InitializeComponent();
        }

        private void btnTonen_Click(object sender, EventArgs e)
        {
            // Form aanmaken
            FrmTonen nieuwform = new FrmTonen();

            // Oud form hiden
            Hide();

            // Nieuw form openen
            nieuwform.ShowDialog();

            // Oud form showen
            Show();
        }

        private void btnAfsluiten_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnInvoer_Click(object sender, EventArgs e)
        {
            // Form aanmaken
            FrmInvoeren nieuwform = new FrmInvoeren();

            // Oud form hiden
            Hide();

            // Nieuw form openen
            nieuwform.ShowDialog();

            // Oud form showen
            Show();
        }
    }
}
