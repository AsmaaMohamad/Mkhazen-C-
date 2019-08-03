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
    public partial class CategoryForm : Form
    {
        Context context = new Context();
        public CategoryForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            Category cat = new Category
            {
               
                Name = name_txt.Text,
               


            };

            context.Category.Add(cat);
            context.SaveChanges();
            MessageBox.Show("تمت الاضافة");
            var quary = (from c in context.Category
                         select new { c.ID,c.Name });
            categoryData.DataSource = quary.ToList();

            clearFormFields();
        }
        public void clearFormFields()
        {
            idtxt.Text = string.Empty;
            name_txt.Text = string.Empty;
           

        }

        private void Show_Click(object sender, EventArgs e)
        {
            var quary = (from c in context.Category
                         select new { c.ID, c.Name });
            categoryData.DataSource = quary.ToList();
        }

        private void Update_btn_Click(object sender, EventArgs e)
        {
            Category cat = new Category
            {
                ID = int.Parse(idtxt.Text),
                Name = name_txt.Text,
             };

            context.Category.AddOrUpdate(cat);
            context.SaveChanges();
            MessageBox.Show("تم التعديل");
            var quary = (from c in context.Category
                         select new { c.ID, c.Name });
            categoryData.DataSource = quary.ToList();
            clearFormFields();
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {
            var q = (from c in context.Category
                     where c.ID.ToString() == idtxt.Text
                     select c).FirstOrDefault();
            context.Category.Remove(q);
            context.SaveChanges();
            MessageBox.Show("تم الحذف");
            var quary = (from c in context.Category
                         select new { c.ID, c.Name });
            categoryData.DataSource = quary.ToList();
            clearFormFields();
        }

        private void CategoryData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int c = categoryData.CurrentRow.Index;
                DataGridViewRow row = this.categoryData.Rows[e.RowIndex];
                idtxt.Text = row.Cells["ID"].Value.ToString();


                name_txt.Text = row.Cells["Name"].Value.ToString();
               



            }
        }
    }
}
