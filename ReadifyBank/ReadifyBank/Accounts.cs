using System;
using System.Data;
using System.Windows.Forms;

namespace ReadifyBank
{
    public partial class Accounts : Form
    {
        GlobalSettings gs = new GlobalSettings();
        DAL dal = new DAL();

        public Accounts()
        {
            InitializeComponent();
        }

        private void Accounts_Load(object sender, EventArgs e)
        {
            GetAccounts();
        }

        protected void GetAccounts()
        {
            DataSet ds = dal.GetAccounts(gs.CustID);
            cb_Accounts.DisplayMember = "AccNo";
            cb_Accounts.ValueMember = "AccNo";
            cb_Accounts.DataSource = ds.Tables[0];
        }
    }
}
