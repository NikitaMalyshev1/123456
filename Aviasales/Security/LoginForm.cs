using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviasales.Security
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void SignOnlabel_Click(object sender, EventArgs e)
        {
            Sign_on_Form sign_on_Form = new Sign_on_Form();
            this.Hide();
            sign_on_Form.ShowDialog();
            Application.Exit();
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            var login = textBoxLogin.Text;
            var pass = textBoxPassword.Text;
            var con = new ConnectWithMSSQL();
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string check = $"select UserLogin, UserPassword from Persons where UserLogin = '{login}' and UserPassword = '{pass}'";

            SqlCommand cmd = new SqlCommand(check, con.SqlConnectionState());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {

                RolesForLoginForm user = new RolesForLoginForm();
                user.GetRole(login, pass);
                MainForm form1  = new MainForm();
                this.Hide();
                form1.ShowDialog();
                Application.Exit();


            }
            else
                MessageBox.Show("Такого пользователя не существует или некорректно введены данные!!!");
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxLogin.MaxLength = 40;
            textBoxPassword.MaxLength = 32;
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
