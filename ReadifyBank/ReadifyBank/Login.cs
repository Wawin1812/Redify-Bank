using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReadifyBank
{
    public partial class Login : Form
    {
        GlobalSettings gs = new GlobalSettings();
        DAL dal = new DAL();

        public Login()
        {
            InitializeComponent();
        }

        private void LoginClick(object sender, EventArgs e)
        {
            Boolean valid_User = false;
            try
            {
                valid_User = dal.GetUser(Convert.ToInt64(custID.Text), pwd.Text);
                if (valid_User)
                {
                    gs.CustID = Convert.ToInt64(custID.Text);
                    ReadifyHome home = new ReadifyHome();
                    home.Show();
                }
                else
                {
                    MessageBox.Show("Invalid ID or Password", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
