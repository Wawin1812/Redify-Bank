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
    public partial class ReadifyHome : Form
    {
        public ReadifyHome()
        {
            InitializeComponent();
        }

        private void OpenSummary(object sender, EventArgs e)
        {
            try
            {
                Accounts acc = new Accounts();
                acc.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString(), "Error");
            }
        }
    }
}
