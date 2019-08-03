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
    public partial class permession : Form
    {
        Context context = new Context();
        public permession()
        {
            InitializeComponent();
        }

        private void permession_Load(object sender, EventArgs e)
        {
            var s = context.Category.Select(c => c.Name).ToList();
            foreach (var item in s)
            {
                catcmbo.Items.Add(item);
            }
            var rep = context.Representative.Select(c => c.Name).ToList();
            foreach (var item in rep)
            {
                representer_combo.Items.Add(item);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void remainderlbl_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void remin_lable_Click(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
        List<buyBillProuduct> prouducts = new List<buyBillProuduct>();
        private void Button1_Click(object sender, EventArgs e)
        {
            var prd = context.prouduct.Where(pr => pr.Name == productcombo.Text).Select(v => v).FirstOrDefault();
            int quantity = int.Parse(quantity_textbox.Text);
            if (prd.Quantity < quantity)
            {
                MessageBox.Show("المنتج غير موجود ");
            }
            else
            {
                if (prd.Name == productcombo.Text)
                {
                    var oldprd = context.prouduct.Where(pr => pr.Name == productcombo.Text).Select(v => v).FirstOrDefault();
                    oldprd.Quantity -= int.Parse(quantity_textbox.Text);
                    context.SaveChanges();

                    buyBillProuduct buyBillProuduct = new buyBillProuduct();
                    buyBillProuduct.PrdID = oldprd.ID;
                    buyBillProuduct.Quantity= int.Parse(quantity_textbox.Text);
                    buyBillProuduct.Name = oldprd.Name;

                    prouducts.Add(buyBillProuduct);

                    var quary = (from p in context.prouduct
                                 select new { p.ID, p.Name, p.wholesalePrice, p.retrialPrice, p.Quantity, p.cat_id });
                    dataGridView1.DataSource = quary.ToList();
                }
                else
                {
                    MessageBox.Show("المنتج غير موجود ");
                }
            }
            clearFormFields();
            }
        public void clearFormFields()
        {
            quantity_textbox.Text = string.Empty;
            productcombo.ResetText();
            catcmbo.ResetText();

        }

        private void Catcmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            var c = context.Category.Where(f => f.Name == catcmbo.Text).Select(s => s.ID).FirstOrDefault();
            var prd = context.prouduct.Where(w => w.cat_id == c).Select(p => p.Name).ToList();

            productcombo.DataSource = prd;
        }

      public void  clearBillFormFields()
        {
            representer_combo.ResetText();
        }
        private void Insert_btn_Click(object sender, EventArgs e)
        {
            var s1 = representer_combo.Text;
            var s = context.Representative.Where(re => re.Name == s1).Select(d => d.ID).FirstOrDefault();
            ReceivePermission Permission = new ReceivePermission()
            {
                date = bill_date.Value,
                rep_id = s

            };


            context.receivePermissions.Add(Permission);
            context.SaveChanges();
            MessageBox.Show("تم اضافة فاتورة ");
            clearBillFormFields();
           

            var num = context.receivePermissions.Max(item=>item.ID);
          
         
            foreach (var item in prouducts)
            {
                RecivePermtionProduct recivePermtionProduct = new RecivePermtionProduct();
                recivePermtionProduct.prdct_id = item.PrdID;
                recivePermtionProduct.recivePermtion_id = num;
                recivePermtionProduct.Quantity = item.Quantity;
                context.recivePermtionProducts.Add(recivePermtionProduct);
                context.SaveChanges();
            }
           

        }
       
    }
}
