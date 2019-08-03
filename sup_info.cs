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
    public partial class sup_info : Form
    {
        Context context = new Context();
        public sup_info()
        {
            InitializeComponent();
        }

        private void Sup_info_Load(object sender, EventArgs e)
        {
           
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            #region edit

            //Suppliers sup = new Suppliers
            //{
            //    ID = int.Parse(idtxt.Text),
            //    Name = name_txt.Text,
            //    phone = phonetxt.Text,
            //    Address = address_txt.Text


            //};
            //context.Supplier.AddOrUpdate(sup);
            //context.SaveChanges();
            //MessageBox.Show("تم التعديل");
            //var quary = (from c in context.Supplier
            //             select c);
            //supplierData.DataSource = quary.ToList();
            //clearFormFields(); 
            #endregion
            var q = (from s in context.Supplier
                     where s.Name == name_txt.Text
                     select s).FirstOrDefault();
            q.ID = int.Parse(idtxt.Text);
            q.Name = name_txt.Text;
            q.phone = phonetxt.Text;
            q.Address = address_txt.Text;
            context.SaveChanges();
            MessageBox.Show("تم التعديل");
            var quary = (from c in context.Supplier
                         select new { c.ID, c.Name, c.phone, c.Address });
              supplierData.DataSource = quary.ToList();
            clearFormFields();

        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            var q = (from c in context.Supplier
                     where c.ID.ToString() == idtxt.Text
                     select c).FirstOrDefault();
            context.Supplier.Remove(q);
            context.SaveChanges();
            MessageBox.Show("تم الحذف");
            var quary = (from s in context.Supplier
                         select new {s.ID,s.Name, s.phone, s.Address });
            supplierData.DataSource = quary.ToList();

            clearFormFields();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            Suppliers sup = new Suppliers
            {
               // ID = int.Parse(idtxt.Text),
                Name = name_txt.Text,
                phone = phonetxt.Text,
                Address = address_txt.Text


            };

            context.Supplier.Add(sup);
            context.SaveChanges();
            MessageBox.Show("تمت الاضافة");
            var quary = (from s in context.Supplier
                         select new {s.ID,s.Name, s.phone,s.Address});
            supplierData.DataSource = quary.ToList();
          
            clearFormFields();

        }
        public void clearFormFields()
        {
            idtxt.Text = string.Empty;
            name_txt.Text = string.Empty;
            phonetxt.Text = string.Empty;
            address_txt.Text = string.Empty;
            //insert.Text = "Save";
            //delete_customerbtn.Enabled = false;

        }

        private void SupplierData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int c = supplierData.CurrentRow.Index;
                DataGridViewRow row = this.supplierData.Rows[e.RowIndex];
                idtxt.Text = row.Cells["ID"].Value.ToString();
                name_txt.Text = row.Cells["Name"].Value.ToString();
                phonetxt.Text = row.Cells["phone"].Value.ToString();
                address_txt.Text = row.Cells["Address"].Value.ToString();



            }

        }

        private void Show_Click(object sender, EventArgs e)
        {
            var quary = (from s in context.Supplier
                         select new {s.ID,s.Name,s.phone,s.Address});
            supplierData.DataSource = quary.ToList();
        }
    }
}
