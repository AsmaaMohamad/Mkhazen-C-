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

    public partial class billsalesfrm : Form
    {
        Context context = new Context();
        double totalPrice = 0.0;
        double paiedPrice = 0.0;
        double productPrice = 0.0;
        public billsalesfrm()
        {
            InitializeComponent();
            var catgry = context.Category.Select(cat => cat.Name).ToList();
            foreach (var item in catgry)
            {
                catcmbo.Items.Add(item);
            }
            var cust = context.Customers.Select(cus => cus.Name).ToList();
            foreach (var item in cust)
            {
                cust_cmbo.Items.Add(item);
            }
            var rep = context.Representative.Select(r => r.Name).ToList();
            foreach (var item in rep)
            {
                representer_combo.Items.Add(item);
            }
            radioButton1.Checked =true;
        }


        private void billsalesfrm_Load(object sender, EventArgs e)
        {
           
        }

        private void Delete_btn_Click(object sender, EventArgs e)
        {

        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void insert_btn_Click(object sender, EventArgs e)
        {
           
            var r1 = representer_combo.SelectedItem.ToString();
            var r = context.Representative.Where(re => re.Name == r1).Select(d => d.ID).FirstOrDefault();
            var c1 = cust_cmbo.SelectedItem.ToString();
            var c = context.Customers.Where(cust => cust.Name == c1).Select(d => d.ID).FirstOrDefault();
            SalesBill salesBill = new SalesBill()
            {
                Rep_id = r,
                cust_id=c,
               date=bill_date.Value
               ,rmain=double.Parse( remin_lable.Text),
               paid=paiedPrice,
               cost=totalPrice
            };
            context.sellBill.Add(salesBill);
            context.SaveChanges();
            MessageBox.Show("تم اضافة فاتورة ");

            SalesBill_Product salesBill_Product = new SalesBill_Product();
            var num = context.sellBill.Max(item => item.ID);
           

            foreach (var item in prouducts)
            {
                salesBill_Product.prdct_id = item.PrdID;
                salesBill_Product.salesBill_id = num;
                salesBill_Product.Quantity = item.Quantity;
                context.SalesBill_Products.Add(salesBill_Product);
                context.SaveChanges();
            }
            clearBillFormFields();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }
        public void clear()
        {
            quantity_textbox.Text = string.Empty;
            productcombo.ResetText();
            catcmbo.ResetText();
        }
        public void clearBillFormFields()
        {
            
            paid_textbox.Text = string.Empty;
            price_lable.Text = string.Empty;
            remin_lable.Text = string.Empty;
            
            
            representer_combo.ResetText();
            cust_cmbo.ResetText();



        }
        List<buyBillProuduct> prouducts = new List<buyBillProuduct>();
        private void Button1_Click(object sender, EventArgs e)
        {
            var r1 = productcombo.SelectedItem.ToString();
            var p = context.prouduct.Where(re => re.Name == r1).Select(d => d.ID).FirstOrDefault();
            buyBillProuduct prouduct = new buyBillProuduct
            {
                PrdID = p,
                Name= productcombo.Text,
                Quantity = int.Parse(quantity_textbox.Text)
            };
            prouducts.Add(prouduct);
            if (radioButton1.Checked)
            {
                var price = context.prouduct.Where(c => c.Name == productcombo.Text).Select(pr => pr.retrialPrice).FirstOrDefault();
                productPrice = price;
             
            }
            else if(radioButton2.Checked)
            {
                var price = context.prouduct.Where(c => c.Name == productcombo.Text).Select(pr => pr.wholesalePrice).FirstOrDefault();

                productPrice = price;
            
            }
            totalPrice += prouduct.Quantity * productPrice;
            price_lable.Text = totalPrice.ToString();

            
            var source = new BindingSource();
            source.DataSource = prouducts;
            prouduct_gridView.DataSource = source;
            clear();



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
                paiedPrice = double.Parse(paid_textbox.Text);
                remin_lable.Text = (totalPrice - paiedPrice).ToString();
            }
            catch
            {

            }
            
            
        }
    }
}
