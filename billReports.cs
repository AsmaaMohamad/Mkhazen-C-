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
    public partial class billReports : Form
    {
        Context context = new Context();
        public billReports()
        {

            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem.ToString()=="فاتورة بيع")

            {
                var d1 = dateTimePicker1.Value;
                var d2 = dateTimePicker2.Value;
                var q1 = from b1 in context.sellBill where (b1.date >= d1 && b1.date <= d2) select b1;
                dataGridView1.DataSource = q1.ToList();
            }
            if (comboBox1.SelectedItem.ToString() == "فاتورة شراء")

            {
                var d1 = dateTimePicker1.Value;
                var d2 = dateTimePicker2.Value;
                var q1 = from b1 in context.receipt_To_Suppliers where (b1.date >= d1 && b1.date <= d2) select b1;
                dataGridView1.DataSource = q1.ToList();
            }
            if (comboBox1.SelectedItem.ToString() =="فاتورة اذن استلام")

            {
                var d1 = dateTimePicker1.Value;
                var d2 = dateTimePicker2.Value;
                var q1 = from b1 in context.receivePermissions where (b1.date >= d1 && b1.date <= d2) select b1;
                dataGridView1.DataSource = q1.ToList();
            }
        }
        List<string> b = new List<string> { "فاتورة شراء", "فاتورة بيع", "فاتورة اذن استلام", "فاتورة مرتجع بيع", "فاتورة مرتجع شراء", "فاتورة مرتجع اذن استلام" };
        private void BillReports_Load(object sender, EventArgs e)
        {
           
            foreach (var item in b)
            {
                comboBox1.Items.Add(item);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

            reports reports = new reports();
            reports.Show();
            this.Hide();
        }
    }
}
