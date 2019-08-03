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
    public partial class login_frm : Form
    {
        Context context = new Context();
        public login_frm()
        {
            InitializeComponent();
           
        }

        private void Login_btn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
          
            var quary = context.user.Select(s => s).Where(s=>s.Name== user_txt.Text ).FirstOrDefault();
            string name = user_txt.Text;
            string password = pass_txt.Text;


            if (quary == null)
            {

                user_error.Show();
                user_error.Text = "اسم المستخدم غير صحيح";
                user_error.ForeColor = Color.Red;

            }
          else  if (name == quary.Name)
            {
                user_error.Hide();
                if (password == quary.Password)
                {
                    this.Hide();
                    main.Show();
                }
                else
                {

                    password_error.Show();
                    password_error.Text = "كلمة السر غير صحيحة";
                    password_error.ForeColor = Color.Red;
                }
            }
          






        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            this.Hide();
            register.Show();
        }
    }
}
