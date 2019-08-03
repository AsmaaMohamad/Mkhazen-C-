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
    public partial class receipt_to_suppliers : Form
    {
        Context context = new Context();
        double totalPrice = 0.0;
        //double paiedPrice = 0.0;
        //double productPrice = 0.0;
        public receipt_to_suppliers()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void receipt_to_suppliers_Load(object sender, EventArgs e)
        {
            var s = context.Category.Select(c => c.Name).ToList();
            foreach (var item in s)
            {
                catcmbo.Items.Add(item);
            }

            var sup= context.Supplier.Select(c => c.Name).ToList();
            foreach (var item in sup)
            {
                sup_cmbo.Items.Add(item);
            }
        }

        private void remainderlbl_Click(object sender, EventArgs e)
        {

        }

        private void remin_lable_Click(object sender, EventArgs e)
        {

        }

        private void paidlbl_Click(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }
        List<Prouduct> prouducts = new List<Prouduct>();
        private void add_prdct_Click(object sender, EventArgs e)
        {
            var c1 = catcmbo.SelectedItem.ToString();
            var c = context.Category.Where(cs => cs.Name == c1).Select(d => d.ID).FirstOrDefault();
            var prd = context.prouduct.Where(pr => pr.Name == productcombo.Text).Select(v => v.Name).FirstOrDefault();
            if(prd== productcombo.Text)
            {
                var oldprd = context.prouduct.Where(pr => pr.Name == productcombo.Text).Select(v => v).FirstOrDefault();
                oldprd.Quantity += int.Parse(quantity_textbox.Text);
                context.SaveChanges();
                var quary = (from p in context.prouduct
                             select new { p.ID, p.Name, p.wholesalePrice, p.retrialPrice, p.Quantity, p.cat_id });
                prduct_GridView1.DataSource = quary.ToList();
                int q= int.Parse(quantity_textbox.Text);
                totalPrice += q * oldprd.wholesalePrice;
                totalLabel.Text = totalPrice.ToString();
                prouducts.Add(oldprd);
                clearFormFields();
            }
            else
            {
                Prouduct prouduct = new Prouduct()
                {
                    Name = productcombo.Text,
                    Quantity = int.Parse(quantity_textbox.Text),
                    wholesalePrice = double.Parse(whalePrice_txt.Text),
                    retrialPrice = double.Parse(retrialPrice_txt.Text),
                    expireDate = DateTime.Now,
                    cat_id = c
                };
                context.prouduct.Add(prouduct);

                int q = int.Parse(quantity_textbox.Text);
                totalPrice += q * prouduct.wholesalePrice;
                totalLabel.Text = totalPrice.ToString();
                context.SaveChanges();
                MessageBox.Show("تم اضافة منتج ");
                var quary = (from p in context.prouduct
                             select new { p.ID, p.Name, p.wholesalePrice, p.retrialPrice, p.Quantity, p.cat_id });
                prduct_GridView1.DataSource = quary.ToList();
                prouducts.Add(prouduct);
                clearFormFields();

            }


        }
        public void clearFormFields()
        {
            quantity_textbox.Text = string.Empty;
            whalePrice_txt.Text = string.Empty;
            retrialPrice_txt.Text = string.Empty;
            productcombo.ResetText();
            catcmbo.ResetText();

        }

        private void Insert_btn_Click(object sender, EventArgs e)
        {
            var s1 = sup_cmbo.SelectedItem.ToString();
            var s = context.Supplier.Where(re => re.Name == s1).Select(d => d.ID).FirstOrDefault();
            Receipt_to_suppliers receipt = new Receipt_to_suppliers()
            {
                date=bill_date.Value,
                cost = double.Parse(totalLabel.Text),
                 paid =double.Parse(paid_textbox.Text),
                 rmain = double.Parse(reminLable.Text),
                 sup_id = s

            };
            var spr = context.Supplier.Where(re => re.Name == s1).Select(d => d).FirstOrDefault();
            spr.remin = double.Parse(reminLable.Text);
           
            context.receipt_To_Suppliers.Add(receipt);
            context.SaveChanges();
            MessageBox.Show("تم اضافة فاتورة ");
            clearBillFormFields();
            supplierBill_Product supplierBill_Product = new supplierBill_Product();

            var num = (from n in context.receipt_To_Suppliers
                       select n.ID).ToList().LastOrDefault();

            foreach (var item in prouducts)
            {
                supplierBill_Product.prdct_id = item.ID;
                supplierBill_Product.supBill_id = num;
                supplierBill_Product.Quantity = item.Quantity;
                context.supplierBill_Products.Add(supplierBill_Product);
                context.SaveChanges();
            }
           
        }
        public void clearBillFormFields()
        {
            quantity_textbox.Text = string.Empty;
            totalLabel.Text = string.Empty;
            paid_textbox.Text = string.Empty;
            retrialPrice_txt.Text = string.Empty;
            reminLable.Text = string.Empty;
            productcombo.ResetText();
            catcmbo.ResetText();
            sup_cmbo.ResetText();


        }

        private void Catcmbo_SelectedIndexChanged(object sender, EventArgs e)
        {
            //productcombo
            var c = context.Category.Where(f => f.Name == catcmbo.Text).Select(s => s.ID).FirstOrDefault();
            var prd = context.prouduct.Where(w => w.cat_id == c).Select(p => p.Name).ToList();

            productcombo.DataSource = prd;
        }

        private void Paid_textbox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double rmain = double.Parse(paid_textbox.Text);
                reminLable.Text = (totalPrice - rmain).ToString();
            }
            catch { }
           
        }

        private void GroupBox2_Enter(object sender, EventArgs e)
        {

        }
        

    }
}
