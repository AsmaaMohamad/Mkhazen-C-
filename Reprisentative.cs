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
    public partial class Reprisentative : Form
    {

        Context context = new Context();
        public Reprisentative()
        {
            InitializeComponent();
        }

        private void AddRep_Click(object sender, EventArgs e)
        {
            Representative rep = new Representative


            {
                //ID = int.Parse(repId.Text),
                Name = repnme.Text,
                phone = phonnume.Text,
                Address = repadress.Text
            };
            context.Representative.Add(rep);
            context.SaveChanges();
            MessageBox.Show("تمت الاضافة");
            var quary = (from r in context.Representative
                         select new {r.ID,r.Name,r.phone,r.Address });
            RepresentativeData.DataSource = quary.ToList();

            clearFormFields();
        }
        public void clearFormFields()
        {
            repId.Text = string.Empty;
            repnme.Text = string.Empty;
            phonnume.Text = string.Empty;
            repadress.Text = string.Empty;
            //insert.Text = "Save";
            //delete_customerbtn.Enabled = false;


        }
        private void Back_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            main.Show();
            this.Hide();
        }

        private void Reprisentative_Load(object sender, EventArgs e)
        {

        }

        private void editRep_Click(object sender, EventArgs e)
        {
            //Representative rep = new Representative


            //{
            //    ID = int.Parse(repId.Text),
            //    Name = repnme.Text,
            //    Address = repadress.Text,
            //    phone = phonnume.Text


            //};

            //context.Representative.AddOrUpdate(rep);
            var q = (from r in context.Representative
                     where r.Name == repnme.Text
                     select r).FirstOrDefault();
            q.ID = int.Parse(repId.Text);
            q.Name = repnme.Text;
            q.phone = phonnume.Text;
            q.Address = repadress.Text;
            context.SaveChanges();
            MessageBox.Show("تم التعديل");
            var quary = (from r in context.Representative
                         select new { r.ID, r.Name, r.phone, r.Address });
            RepresentativeData.DataSource = quary.ToList();

            clearFormFields();
        }

        private void deletrep_Click(object sender, EventArgs e)
        {
            var qery = (from r in context.Representative
                        where r.ID.ToString() == repId.Text
                        select r).FirstOrDefault();
            context.Representative.Remove(qery);
            context.SaveChanges();
            MessageBox.Show("تم الحذف");
            var quary = (from r in context.Representative
                         select new { r.ID, r.Name, r.phone, r.Address });
            RepresentativeData.DataSource = quary.ToList();

            clearFormFields();
        }

        private void show_Click(object sender, EventArgs e)
        {
            var quary = (from r in context.Representative
                         select new { r.ID, r.Name, r.phone, r.Address });
            RepresentativeData.DataSource = quary.ToList();

            clearFormFields();
        }

        private void RepresentativeData_CellDoubleClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                int r = RepresentativeData.CurrentRow.Index;
                DataGridViewRow row = this.RepresentativeData.Rows[e.RowIndex];
                repId.Text = row.Cells["ID"].Value.ToString();
                repnme.Text = row.Cells["Name"].Value.ToString();
                phonnume.Text = row.Cells["phone"].Value.ToString();
                repadress.Text = row.Cells["Address"].Value.ToString();



            }
        }
    }
}
