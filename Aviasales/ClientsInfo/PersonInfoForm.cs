using Aviasales.Auxiliary_class;
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

namespace Aviasales.ClientsInfo
{
    public partial class PersonInfoForm : Form
    {
        public PersonInfoForm()
        {
            InitializeComponent();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
            Application.Exit();
        }

        //private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        //{
        //    this.Validate();
        //    this.usersBindingSource.EndEdit();
        //    this.tableAdapterManager.UpdateAll(this.aviasalesDataSet);

        //}

        private void button1_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(TextBoxSeries.Text)) || (String.IsNullOrEmpty(TextBoxNumber.Text)))
            {
                MessageBox.Show("Обязательно укажите серию и номер вашего паспорта." +
                    "\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var series = TextBoxSeries.Text;
                var number = TextBoxNumber.Text;
                dataGridView1.DataSource = new CommandsForSQL().
                    FillDataGridView($@"select * from Users where Passport_Series = '{series}' 
and Passport_Number = '{number}'");

            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text) ||
           (String.IsNullOrEmpty(textBox2.Text) ||
           (String.IsNullOrEmpty(textBox3.Text) ||
           (String.IsNullOrEmpty(textBox4.Text) ||
           (String.IsNullOrEmpty(textBox5.Text) ||
           (String.IsNullOrEmpty(textBox7.Text) ||
           (String.IsNullOrEmpty(textBox6.Text))))))))
            {
                MessageBox.Show("Обязательно введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox7.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Некорректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Некорректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox4.Text) || textBox4.Text != TextBoxNumber.Text)
            {
                MessageBox.Show("Некорректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Некорректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox6.Text) || textBox6.Text != TextBoxSeries.Text)
            {
                MessageBox.Show("Некорректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand($@"UPDATE Users SET User_ID = @User_ID, First_Name = @First_Name, 
Second_Name = @Second_Name, Last_Name = @Last_Name , Passport_Series = @Passport_Series, Passport_Number = @Passport_Number, 
Passport_date = @Passport_date
WHERE User_ID = @User_ID", connection);


            command.Parameters.AddWithValue("User_ID", textBox7.Text);
            command.Parameters.AddWithValue("First_Name", textBox1.Text);
            command.Parameters.AddWithValue("Second_Name", textBox2.Text);
            command.Parameters.AddWithValue("Last_Name", textBox5.Text);
            command.Parameters.AddWithValue("Passport_Series", textBox6.Text);
            command.Parameters.AddWithValue("Passport_Number", textBox4.Text);
            command.Parameters.AddWithValue("Passport_date", textBox3.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString() + "команда по изменению выполнена");
            connection.Close();
        }
    }
}
