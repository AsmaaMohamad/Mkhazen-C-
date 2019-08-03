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

    public partial class productfrm : Form
    {
        Context context = new Context();
        //int d;
        
        public productfrm()
        {
            InitializeComponent();
            //categorycmbo.ValueMember = "ID";
            //categorycmbo.DisplayMember = "Name";
            //var s = (from c in context.Category
            //         where c.ID == (int)categorycmbo.SelectedValue
            //         select c.ID);
            var s =context.Category.Select(c => c.Name).ToList();
            foreach(var item in s )
            {
                categorycmbo.Items.Add(item);
            }
        }

        private void productfrm_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditPrdct_Click(object sender, EventArgs e)
        {
            string cat_name = categorycmbo.SelectedText;
            var quary = (from p in context.Category
                         where p.Name == cat_name
                         select p.ID).FirstOrDefault();
            
            var quary2 = (from p in context.prouduct
                         where p.Name== prdctName.Text
            select p).FirstOrDefault();
            //  Prouduct prdct = new Prouduct();
            quary2.ID = int.Parse(prdctid.Text);
            quary2.Name = prdctName.Text;
            quary2.wholesalePrice = double.Parse(prdctpric.Text);
            quary2.Quantity = int.Parse(prdctqnt.Text);
            quary2.expireDate = dateTimePicker1.Value;
         
          //  context.prouduct.AddOrUpdate(prdct);
            context.SaveChanges();
            MessageBox.Show("تم التعديل");
            var quary1 = (from p in context.prouduct
                         select new { p.ID, p.Name, p.wholesalePrice, p.Quantity, p.cat_id,p.expireDate });
            prodctGridData.DataSource = quary1.ToList();
            clearFormFields();
        }

        private void AddPrdct_Click(object sender, EventArgs e)
        {
            var c1 = categorycmbo.SelectedItem.ToString();
            var c = context.Category.Where(cs => cs.Name == c1).Select(d => d.ID).FirstOrDefault();
            Prouduct prdct = new Prouduct
            {
                //ID = int.Parse(prdctid.Text),
                Name = prdctName.Text,
                wholesalePrice = double.Parse(prdctpric.Text),
                retrialPrice = double.Parse(prdctpricetxt2.Text),
                Quantity = int.Parse(prdctqnt.Text),
                cat_id = c,
                expireDate = dateTimePicker1.Value
            };

            context.prouduct.Add(prdct);
            context.SaveChanges();
            MessageBox.Show("تمت الاضافة");
            var quary = (from p in context.prouduct
                         select new { p.ID, p.Name, p.wholesalePrice,p.retrialPrice, p.Quantity, p.cat_id ,p.expireDate});
            prodctGridData.DataSource = quary.ToList();
            clearFormFields();

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
        public void clearFormFields()
        {
            prdctid.Text = string.Empty;
            prdctName.Text = string.Empty;
            prdctqnt.Text = string.Empty;
            prdctpric.Text = string.Empty;
            prdctpricetxt2.Text = string.Empty;
            categorycmbo.Items.Clear();
            categorycmbo.ResetText();
            

        }

        private void ProdctGridData_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          
            if (e.RowIndex >= 0)
            {

                DataGridViewRow row = this.prodctGridData.Rows[e.RowIndex];
                int id =int.Parse( row.Cells["cat_id"].Value.ToString());
                var quary= (from p in context.Category
                            where p.ID==id
                            select p.Name ).FirstOrDefault();

                prdctid.Text = row.Cells["ID"].Value.ToString();
                prdctName.Text = row.Cells["Name"].Value.ToString();
                prdctpric.Text = row.Cells["wholesalePrice"].Value.ToString();
                prdctpricetxt2.Text = row.Cells["retrialPrice"].Value.ToString();
                prdctqnt.Text = row.Cells["Quantity"].Value.ToString();
                dateTimePicker1.Value =DateTime.Parse( row.Cells["expireDate"].Value.ToString());
                categorycmbo.SelectedText=quary.ToString();
            }
        }

        private void DeletPrdct_Click(object sender, EventArgs e)
        {
            var q = (from p in context.prouduct
                     where p.ID.ToString() == prdctid.Text
                     select p).FirstOrDefault();
            context.prouduct.Remove(q);
            context.SaveChanges();
            MessageBox.Show("تم الحذف");
            var quary = (from p in context.prouduct
                         select new {p.ID,p.Name,p.wholesalePrice,p.retrialPrice, p.Quantity,p.cat_id,p.expireDate});
            prodctGridData.DataSource = quary.ToList();
            clearFormFields();
        }

        private void Show_Click(object sender, EventArgs e)
        {
            var quary = (from p in context.prouduct
                         select new {p.ID,p.Name,p.wholesalePrice,p.retrialPrice, p.Quantity,p.cat_id,p.expireDate});
            prodctGridData.DataSource = quary.ToList();
        }

        private void PrdctQuntity_Click(object sender, EventArgs e)
        {

        }

        private void categorycmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var s = (from c in context.Category
            //         where c.ID == (int)categorycmbo.SelectedValue
            //         select c.ID);
            //d= int.Parse(s.ToString());


        }

        private void Productname_Click(object sender, EventArgs e)
        {

        }

        private void Prdctpric_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProdctGridData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
