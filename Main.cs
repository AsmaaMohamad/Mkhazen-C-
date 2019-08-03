using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makhazen
{
    public partial class Main : Form
    {
        //private int imgnumber = 1;
        public Main()
        {
            InitializeComponent();
        }
       
      
        private void Sup_btn_Click(object sender, EventArgs e)
        {
            sup_info sup_Info = new sup_info();
            sup_Info.Show();
            this.Hide();
        }

        private void Product_btn_Click(object sender, EventArgs e)
        {
            productfrm productfrm = new productfrm();
            productfrm.Show();
            this.Hide();
        }
        private void loadNextImg()
        {


            pictureBox1.ImageLocation = image[counter++];
            if (counter >= image.Length)
                counter = 0;


        }


        private void Represent_btn_Click(object sender, EventArgs e)
        {
            Reprisentative reprisentative = new Reprisentative();
            reprisentative.Show();
            this.Hide();
        }

        private void buybill_Click(object sender, EventArgs e)
        {
            billsalesfrm billsalesfrm = new billsalesfrm();
            billsalesfrm.Show();
            this.Hide();
        }

        private void Customer_btn_Click(object sender, EventArgs e)
        {
            custmerfrm custmerfrm = new custmerfrm();
            custmerfrm.Show();
            this.Hide();
        }

        private void Sellbill_Click(object sender, EventArgs e)
        {
            receipt_to_suppliers receipt = new receipt_to_suppliers();
            receipt.Show();
            this.Hide();
        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            reports reports = new reports();
            reports.Show();
            this.Hide();
        }

        private void Category_Click(object sender, EventArgs e)
        {
            CategoryForm category = new CategoryForm();
            category.Show();
            this.Hide();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try { loadNextImg(); } catch { }
            
        }
        string[] image = null;
        int counter = 0;
        private void Main_Load(object sender, EventArgs e)
        {
            try
            {
                string im = Path.Combine(System.IO.Path.GetFullPath(@"..\..\"), "Resources");
                image = Directory.GetFiles(im);
                Timer timer = new Timer();
                timer.Interval = 3000;
                timer.Tick += new EventHandler(timer1_Tick);
                timer.Start();
            }
            catch { }
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            permession permession = new permession();
            permession.Show();
            this.Hide();
        }

        private void Sellreturn_Click(object sender, EventArgs e)
        {
            receipt_return_to_suppliers receipt_Return = new receipt_return_to_suppliers();
            receipt_Return.Show();
            this.Hide();
        }

        private void Buyreturn_Click(object sender, EventArgs e)
        {

        }

        private void Button2_Click(object sender, EventArgs e)
        {

        }
    }
}
