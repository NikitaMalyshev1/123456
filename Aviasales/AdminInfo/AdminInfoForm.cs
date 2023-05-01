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

namespace Aviasales.AdminInfo
{
    public partial class AdminInfoForm : Form
    {
        public AdminInfoForm()
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

        private void button5_Click(object sender, EventArgs e)
        {
            Line_Avia mainForm = new Line_Avia();
            mainForm.ShowDialog();
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Ticket mainForm = new Ticket();
            mainForm.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Users mainForm = new Users();
            mainForm.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Service mainForm = new Service();
            mainForm.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Passenger_data mainForm = new Passenger_data();
            mainForm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(!Line_AviaCheckBox.Checked && !TicketcheckBox.Checked && !DatacheckBox.Checked
                && !UserscheckBox.Checked && !ServicecheckBox.Checked)
            {
                MessageBox.Show("Обязательно выберите таблицу которую вы хотите изменить", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                if(radioButton1.Checked && Line_AviaCheckBox.Checked)
                {
                    Insert1();
                }
                if (radioButton1.Checked && DatacheckBox.Checked)
                {
                    Insert2();
                }
                if (radioButton1.Checked && TicketcheckBox.Checked)
                {
                    Insert3();
                }
                if (radioButton1.Checked && UserscheckBox.Checked)
                {
                    Insert4();
                    
                }
                if (radioButton1.Checked && ServicecheckBox.Checked)
                {
                    Insert5();
                }


                if (radioButton2.Checked && Line_AviaCheckBox.Checked)
                {
                    Update1();
                }
                if (radioButton2.Checked && DatacheckBox.Checked)
                {
                    Update2();
                }
                if (radioButton2.Checked && TicketcheckBox.Checked)
                {
                    Update3();
                }
                if (radioButton2.Checked && UserscheckBox.Checked)
                {
                    Update4();

                }
                if (radioButton2.Checked && ServicecheckBox.Checked)
                {
                    Update5();
                }

                if (radioButton3.Checked && Line_AviaCheckBox.Checked)
                {
                    Delete1();
                }
                if (radioButton3.Checked && DatacheckBox.Checked)
                {
                    Delete2();
                }
                if (radioButton3.Checked && TicketcheckBox.Checked)
                {
                    Delete3();
                }
                if (radioButton3.Checked && UserscheckBox.Checked)
                {
                    Delete4();

                }
                if (radioButton3.Checked && ServicecheckBox.Checked)
                {
                    Delete5();
                }


            }
        }

        #region Функция для добавления
        void Insert5()
        {
            if (String.IsNullOrEmpty(textBox1.Text) ||
           (String.IsNullOrEmpty(textBox2.Text) ||
           (String.IsNullOrEmpty(textBox3.Text))))
            {
                MessageBox.Show("Обязательно введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID сервиса!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Некорректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand($@"INSERT INTO [Service] (Service_ID, Service_Name, HTTP) VALUES (@Service_ID, @Service_Name, @HTTP)", connection);


            command.Parameters.AddWithValue("Service_ID", textBox1.Text);
            command.Parameters.AddWithValue("Service_Name", textBox2.Text);
            command.Parameters.AddWithValue("HTTP", textBox3.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            //button3_Click(this, EventArgs.Empty);
        }
        #endregion

        #region Функция для добавления
        void Insert2()
        {
            if (String.IsNullOrEmpty(textBox1.Text) ||
           (String.IsNullOrEmpty(textBox2.Text) ||
           (String.IsNullOrEmpty(textBox3.Text))))
            {
                MessageBox.Show("Обязательно введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID рейса!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID сервиса!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            

            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Некорректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand($@"INSERT INTO [Passenger_data] (ID_Line, Service_ID, Total) VALUES (@ID_Line, @Service_ID,  @Total)", connection);


            command.Parameters.AddWithValue("ID_Line", textBox1.Text);
            command.Parameters.AddWithValue("Service_ID", textBox2.Text);
            command.Parameters.AddWithValue("Total", textBox3.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }
        #endregion

        #region Функция для добавления
        void Insert3()
        {
            if (String.IsNullOrEmpty(textBox1.Text) ||
           (String.IsNullOrEmpty(textBox2.Text) ||
           (String.IsNullOrEmpty(textBox2.Text) ||
           (String.IsNullOrEmpty(textBox3.Text)))))
            {
                MessageBox.Show("Обязательно введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID билета!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID направления!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBox3.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID сервиса!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (!int.TryParse(textBox4.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID клиента!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand($@"INSERT INTO [Ticket] (Ticket_ID, ID_Line, Service_ID, User_ID) VALUES (@Ticket_ID, @ID_Line, @Service_ID,  @User_ID)", connection);

            command.Parameters.AddWithValue("Ticket_ID", textBox1.Text);
            command.Parameters.AddWithValue("ID_Line", textBox2.Text);
            command.Parameters.AddWithValue("Service_ID", textBox3.Text);
            command.Parameters.AddWithValue("User_ID", textBox4.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }
        #endregion


        void Insert4()
        {
            if (String.IsNullOrEmpty(textBox1.Text) ||
           (String.IsNullOrEmpty(textBox2.Text) ||
           (String.IsNullOrEmpty(textBox3.Text) ||
           (String.IsNullOrEmpty(textBox4.Text) ||
           (String.IsNullOrEmpty(textBox5.Text) ||
           (String.IsNullOrEmpty(textBox6.Text) ||
           (String.IsNullOrEmpty(textBox7.Text))))))))
            {
                MessageBox.Show("Обязательно введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID клиента!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox7.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand($@"INSERT INTO [Users] (User_ID, First_Name, Second_Name, Last_Name, Passport_Series, Pasport_Number, Passport_date)
VALUES (@User_ID, @First_Name, @Second_Name, @Last_Name, @Passport_Series, @Pasport_Number, @Passport_date)", connection);

            command.Parameters.AddWithValue("User_ID", textBox1.Text);
            command.Parameters.AddWithValue("First_Name", textBox2.Text);
            command.Parameters.AddWithValue("Second_Name", textBox3.Text);
            command.Parameters.AddWithValue("Last_Name", textBox4.Text);
            command.Parameters.AddWithValue("Passport_Series", textBox5.Text);
            command.Parameters.AddWithValue("Pasport_Number", textBox6.Text);
            command.Parameters.AddWithValue("Passport_date", textBox7.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }


        void Insert1()
        {
            if (String.IsNullOrEmpty(textBox1.Text) ||
           (String.IsNullOrEmpty(textBox2.Text) ||
           (String.IsNullOrEmpty(textBox3.Text) ||
           (String.IsNullOrEmpty(textBox4.Text) ||
           
           (String.IsNullOrEmpty(textBox5.Text))))))
            {
                MessageBox.Show("Обязательно введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID направления!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand($@"INSERT INTO [Line_Avia] 
(ID_Line, Сity_From, City_To, Air_Carrier, Max_Count_of_people)
VALUES (@ID_Line, @Сity_From, @City_To, @Air_Carrier, @Max_Count_of_people)", connection);

            command.Parameters.AddWithValue("ID_Line", textBox1.Text);
            command.Parameters.AddWithValue("Сity_From", textBox2.Text);
            command.Parameters.AddWithValue("City_To", textBox3.Text);
            command.Parameters.AddWithValue("Air_Carrier", textBox4.Text);
            command.Parameters.AddWithValue("Max_Count_of_people", textBox5.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }






        void Delete1()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Обязательно введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID направления!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand($@"DELETE FROM Line_Avia WHERE  ID_Line = @ID_Line", connection);

            command.Parameters.AddWithValue("ID_Line", textBox1.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }

        void Delete2()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Обязательно введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID направления!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Обязательно введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID сервиса!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand($@"DELETE FROM Passenger_data WHERE  ID_Line = @ID_Line, Sevice_ID = @Sevice_ID", connection);

            command.Parameters.AddWithValue("ID_Line", textBox1.Text);
            command.Parameters.AddWithValue("Sevice_ID", textBox2.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }

        void Delete3()
        {

            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Обязательно введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID билета!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Обязательно введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID направления!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Обязательно введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox3.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID сервиса!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand($@"DELETE FROM Ticket WHERE  ID_Line = @ID_Line, Sevice_ID = @Sevice_ID, Ticket_ID = @Ticket_ID", connection);
            command.Parameters.AddWithValue("Ticket_ID", textBox1.Text);
            command.Parameters.AddWithValue("ID_Line", textBox2.Text);
            command.Parameters.AddWithValue("Sevice_ID", textBox3.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }

        void Delete4()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Обязательно введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID клиента!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand($@"DELETE FROM Users WHERE  User_ID = @User_ID", connection);

            command.Parameters.AddWithValue("User_ID", textBox1.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }
        void Delete5()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Обязательно введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID сервиса!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand($@"DELETE FROM Service WHERE  Service_ID = @Service_ID", connection);

            command.Parameters.AddWithValue("Service_ID", textBox1.Text);

            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }



        void Update5()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Требуется указать id изменяемого сервиса",
                    "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение id!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "";

            if ((!String.IsNullOrEmpty(textBox2.Text)) && (!String.IsNullOrEmpty(textBox3.Text)))
            {
                sqlUpdate = "UPDATE Service SET Service_Name = @Service_Name, HTTP = @HTTP WHERE Service_ID = @Service_ID";
            }
            else
            {
                if (!String.IsNullOrEmpty(textBox2.Text))
                {
                    sqlUpdate = "UPDATE Service SET Service_Name = @Service_Name WHERE Service_ID = @Service_ID";
                }
                if (!String.IsNullOrEmpty(textBox3.Text))
                {
                    sqlUpdate = "UPDATE Service SET HTTP = @HTTP WHERE Service_ID = @Service_ID";
                }
            }



            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if (!String.IsNullOrEmpty(textBox4.Text))
                sqlValues += "Service_ID=@Service_ID,";
            if (!String.IsNullOrEmpty(textBox5.Text))
                sqlValues += "Service_Name=@Service_Name,";
            if (!String.IsNullOrEmpty(textBox6.Text))
                sqlValues += "HTTP=@HTTP,";

            command.CommandText = String.Format(sqlUpdate, sqlValues);
            if (!String.IsNullOrEmpty(textBox4.Text))
                command.Parameters.AddWithValue("@Service_ID", textBox4.Text);
            if (!String.IsNullOrEmpty(textBox5.Text))
                command.Parameters.AddWithValue("@Service_Name", textBox5.Text);
            //или другим способом, если необходимо явное указание типа данных
            if (!String.IsNullOrEmpty(textBox6.Text))
                command.Parameters.AddWithValue("@HTTP", textBox6.Text);

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Данные были успешно изменены");
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка выполнения запроса:\n" + err.Message,
                "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }



        void Update1()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Требуется указать id изменяемого направления",
                    "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение id!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "";

            
                sqlUpdate = "UPDATE Line_Avia SET Сity_From = @Сity_From, " +
                    "City_To = @City_To, Air_Carrier = @Air_Carrier, Max_Count_of_people = @Max_Count_of_people WHERE ID_Line = @ID_Line";


            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sqlUpdate, connection);

            command.Parameters.AddWithValue("ID_Line", textBox1.Text);
            command.Parameters.AddWithValue("Сity_From", textBox2.Text);
            command.Parameters.AddWithValue("City_To", textBox3.Text);
            command.Parameters.AddWithValue("Air_Carrier", textBox4.Text);
            command.Parameters.AddWithValue("Max_Count_of_people", textBox5.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }


        void Update2()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Требуется указать id изменяемого направления",
                    "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение id!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Требуется указать id сервиса",
                    "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Некоректное значение id!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "";


            sqlUpdate = "UPDATE Passenger_Data SET ID_Line = @ID_Line, " +
                "Service_ID = @Service_ID, Total = @Total WHERE ID_Line = @ID_Line and Service_ID = @Service_ID";


            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sqlUpdate, connection);

            command.Parameters.AddWithValue("ID_Line", textBox1.Text);
            command.Parameters.AddWithValue("Service_ID", textBox2.Text);
            command.Parameters.AddWithValue("Total", textBox3.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }

        void Update3()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Требуется указать id билета",
                    "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение id!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (String.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Требуется указать id изменяемого направления",
                    "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox2.Text, out _))
            {
                MessageBox.Show("Некоректное значение id!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Требуется указать id сервиса",
                    "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox3.Text, out _))
            {
                MessageBox.Show("Некоректное значение id!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "";


            sqlUpdate = "UPDATE Ticket SET Ticket_ID = @Ticket_ID, ID_Line = @ID_Line, " +
                "Service_ID = @Service_ID, User_ID = @User_ID WHERE ID_Line = @ID_Line and Service_ID = @Service_ID and Ticket_ID = @Ticket_ID";


            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sqlUpdate, connection);

            command.Parameters.AddWithValue("Ticket_ID", textBox1.Text);
            command.Parameters.AddWithValue("ID_Line", textBox2.Text);
            command.Parameters.AddWithValue("Service_ID", textBox3.Text);
            command.Parameters.AddWithValue("User_ID", textBox4.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }

        void Update4()
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Требуется указать id Пассажира",
                    "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox1.Text, out _))
            {
                MessageBox.Show("Некоректное значение id!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string sqlUpdate = "";


            sqlUpdate = "UPDATE Users SET User_ID = @User_ID, First_Name = @First_Name, Second_Name = @Second_Name," +
                " Last_Name = @Last_Name, Passport_Series = @Passport_Series, Pasport_Number = @Pasport_Number, " +
                "Passport_date = @Passport_date  WHERE User_ID = @User_ID";


            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(sqlUpdate, connection);

            command.Parameters.AddWithValue("User_ID", textBox1.Text);
            command.Parameters.AddWithValue("First_Name", textBox2.Text);
            command.Parameters.AddWithValue("Second_Name", textBox3.Text);
            command.Parameters.AddWithValue("Last_Name", textBox4.Text);
            command.Parameters.AddWithValue("Passport_Series", textBox5.Text);
            command.Parameters.AddWithValue("Pasport_Number", textBox6.Text);
            command.Parameters.AddWithValue("Passport_date", textBox7.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }


    }
}
