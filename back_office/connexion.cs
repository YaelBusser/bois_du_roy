using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace back_office
{
    public partial class connexion : Form
    {
        DataView dv;
        Users dt_users;
        public connexion()
        {
            InitializeComponent();
            dt_users = new Users();
            dv = new DataView(dt_users.GetUsers());
            dgv_users.DataSource = dv;
        }


        private void MdpConnexion_Enter(object sender, EventArgs e)
        {
            // The password character is an asterisk.
            mdpConnexion.PasswordChar = '*';
            mdpConnexion.MaxLength = 16;
        }

        private void Btn_connexion_Click(object sender, EventArgs e)
        {
         
        }
    }
}
