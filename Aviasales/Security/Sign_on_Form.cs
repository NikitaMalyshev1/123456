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
    public partial class Sign_on_Form : Form
    {
        public Sign_on_Form()
        {
            InitializeComponent();
        }

        private void SIgnOnbutton_Click(object sender, EventArgs e)
        {
            ConnectWithMSSQL connectWithMSSQL = new ConnectWithMSSQL();
            var login = textBoxLogin.Text;
            var pass = textBoxPassword.Text;
            var rep = textBoxRepeatPassword.Text;
            if (pass.Length < 4 || rep.Length < 4)
            {
                MessageBox.Show("Минимальная длина пароля 4 символа! Попробуйте ввести данные еще раз");
            }
            else
            {
                string check = "";
                SqlCommand sqlCommand = null;
                if (pass == rep)
                {
                    if (checkuser() == false)
                    {
                        check = $"insert into Persons(UserLogin, UserPassword) values ('{login}', '{pass}')";
                        sqlCommand = new SqlCommand(check, connectWithMSSQL.SqlConnectionState());

                        connectWithMSSQL.openConnection();
                        if (sqlCommand.ExecuteNonQuery() == 1)
                        {
                            MessageBox.Show("Аккаунт успешно создан");
                            LoginForm loginForm = new LoginForm();
                            this.Hide();
                            loginForm.ShowDialog();
                            Application.Exit();
                        }
                        else
                            MessageBox.Show("Error");
                        connectWithMSSQL.closeConnection();
                    }
                    else
                    {
                        MessageBox.Show("Это имя уже занято. Попробуйте другой логин!");
                    }
                }
                else MessageBox.Show("Введенные пароли не совпадают");
            }
        }

        private bool checkuser()
        {
            var login = textBoxLogin.Text;
            var pass = textBoxPassword.Text;
            var con = new ConnectWithMSSQL();

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable dt = new DataTable();
            string check = $"select UserLogin from Persons where UserLogin = '{login}'";
            SqlCommand cmd = new SqlCommand(check, con.SqlConnectionState());

            adapter.SelectCommand = cmd;
            adapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;

            }
            else
                return false;
        }

        private void Sign_on_Form_Load(object sender, EventArgs e)
        {
            textBoxPassword.PasswordChar = '*';
            textBoxLogin.MaxLength = 40;
            textBoxPassword.MaxLength = 32;
            textBoxRepeatPassword.PasswordChar = '*';
            textBoxPassword.MaxLength = 32;
        }
    }
}
