using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Makhazen
{
    public partial class Register : Form
    {
        Context context = new Context();
        public Register()
        {
            InitializeComponent();
        }

        private void Register_btn_Click(object sender, EventArgs e)
        {
            string name = Register_user_txt.Text;
            string password = Register_pass_txt.Text;
            var quary = context.user.Select(s => s).Where(s => s.Name == Register_user_txt.Text).FirstOrDefault();

            Regex regex = new Regex("^[\u0621-\u064A ]+$");
            Regex rx = new Regex(@"[\d]{8}");
            if (quary != null)
            {
                MessageBox.Show(" المستخدم موجود بالفعل ");

            }
            else
            {
                if (!regex.IsMatch(name))
                {
                    MessageBox.Show("ضع اسم المستخدم في الصيغة الصحيحة في هيئة حروف فقط ");
                }

                else if (regex.IsMatch(name))
                {
                    if (!rx.IsMatch(password))
                    {

                        MessageBox.Show(" كلمة السر اقل من 8 ارقام");
                    }
                    else
                    {
                        MessageBox.Show("تمت الاصافة بنجاح ");
                        Users user1 = new Users { Name = name, Password = password };


                        context.user.Add(user1);

                        context.SaveChanges();
                        login_frm login = new login_frm();
                        login.Show();
                        this.Hide();
                    }
                }



            }
        }

        private void Register_user_txt_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
