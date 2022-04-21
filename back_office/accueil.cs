using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace back_office
{
    public partial class accueil : Form
    {
        public void loadForm(object Form)
        {
            if (this.blockAccueil.Controls.Count > 0)
            {
                this.blockAccueil.Controls.RemoveAt(0);
            }
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.blockAccueil.Controls.Add(f);
            this.blockAccueil.Tag = f;
            f.Show();
        }
        public accueil()
        {
            InitializeComponent();
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imgStats.Visible = false;
            filtresAccueil.Visible = false;
            loadForm(new stats());
        }
    }
}
