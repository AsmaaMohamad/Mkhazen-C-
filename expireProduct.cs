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
   
    public partial class expireProduct : Form
    {
        Context context = new Context();
        public expireProduct()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //var d1 = context.prouduct.Select(d => d.expireDate).FirstOrDefault();
            var d2 = DateTime.Now;
                var q = from p in context.prouduct where(p.expireDate<d2)  select p;
                dataGridView1.DataSource = q.ToList();
            

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            reports reports = new reports();
            reports.Show();
            this.Hide();
        }
    }
}
