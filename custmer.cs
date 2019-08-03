using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makhazen
{
   
    public partial class custmerfrm : Form
    {
        Context context = new Context();
        public custmerfrm()
        {
            InitializeComponent();
        }

        private void update_customerbtn_Click(object sender, EventArgs e)
        {

            
            var q= (from c in context.Customers
                          where c.Name == customerNameText.Text
                          select c).FirstOrDefault();
            q.ID =int.Parse( custmeridText.Text);
            q.Name = customerNameText.Text;
            q.phone = customerphoneText.Text;
            q.Address = customeraddrssText.Text;
            context.SaveChanges();
            MessageBox.Show("تم التعديل");
            var quary = (from c in context.Customers
                         select new { c.ID, c.Name, c.phone, c.Address });
            customerData.DataSource = quary.ToList();
            clearFormFields();
        }

        private void Customerinsert_btn_Click(object sender, EventArgs e)
        {
            Customer cust = new Customer
            {
                //ID = int.Parse(custmeridText.Text),
                Name = customerNameText.Text,
                phone = customerphoneText.Text,
                Address = customeraddrssText.Text,


            };

            context.Customers.Add(cust);
            context.SaveChanges();
            MessageBox.Show("تمت الاضافة");
            var quary = (from c in context.Customers
                         select new {c.ID,c.Name,c.phone,c.Address });
            customerData.DataSource = quary.ToList();
            clearFormFields();

        }

        public void clearFormFields()
        {
            custmeridText.Text = string.Empty;
            customerNameText.Text = string.Empty;
            customerphoneText.Text = string.Empty;
            customeraddrssText.Text = string.Empty;
            //insert.Text = "Save";
            //delete_customerbtn.Enabled = false;

        }
        private void Backbtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            var quary = (from c in context.Customers
                         select new { c.ID, c.Name, c.phone, c.Address });
            customerData.DataSource = quary.ToList();
            clearFormFields();


        }

        private void CustomerData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void CustomerData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int c = customerData.CurrentRow.Index;
                DataGridViewRow row = this.customerData.Rows[e.RowIndex];
                custmeridText.Text = row.Cells["ID"].Value.ToString();
                customerNameText.Text = row.Cells["Name"].Value.ToString();
                customerphoneText.Text = row.Cells["phone"].Value.ToString();
                customeraddrssText.Text = row.Cells["Address"].Value.ToString();



            }
        }

        private void Delete_customerbtn_Click(object sender, EventArgs e)
        { 
            var q = (from c in context.Customers
                     where c.ID.ToString()==custmeridText.Text
                     select c).FirstOrDefault();
            context.Customers.Remove(q);
            context.SaveChanges();
            MessageBox.Show("تم الحذف");
            var quary = (from c in context.Customers
                         select new { c.ID, c.Name, c.phone, c.Address });
            customerData.DataSource = quary.ToList();
            clearFormFields();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
