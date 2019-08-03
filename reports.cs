using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makhazen
{
    public partial class reports : Form
    {
        public reports()
        {
            InitializeComponent();
        }

        private void Report_product_Click(object sender, EventArgs e)
        {
            productremain productremain = new productremain();
            productremain.Show();
            this.Hide();
        }

        private void MoveMonth_Click(object sender, EventArgs e)
        {
            finishedproduct finishedproduct = new finishedproduct();
            finishedproduct.Show();
            this.Hide();
        }

        private void DayMove_Click(object sender, EventArgs e)
        {

            billReports bill = new billReports();
            bill.Show();
            this.Hide();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            expireProduct expire = new expireProduct();
            expire.Show();
            this.Hide();
        }
    }
}
