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
    public partial class finishedproduct : Form
    { Context Context = new Context();
        public finishedproduct()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            var q1 = int.Parse(textBox1.Text);
            var q = from c in Context.prouduct where (c.Quantity < q1) select c;
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
