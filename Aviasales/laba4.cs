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

namespace Aviasales
{
    public partial class laba4 : Form
    {
        public laba4()
        {
            InitializeComponent();
        }
        DataTable FillDataGridView(string sqlSelect)
        {
            //Создаем объект connection класса SqlConnection для соединения с БД
            //CafeConnectionString – строка описания соединения с источником данных

            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            //Создаем объект command для SQL команды
            SqlCommand command = connection.CreateCommand();
            //Заносим текст SQL запроса через параметр sqlSelect
            command.CommandText = sqlSelect;
            //Создаем объект adapter класса SqlDataAdapter
            SqlDataAdapter adapter = new SqlDataAdapter();
            //Задаем адаптеру нужную команду, в данном случае команду Select
            adapter.SelectCommand = command;
            //Создаем объект table для последующего отображения результата запроса
            DataTable table = new DataTable();
            //заполним набор данных результатом запроса
            adapter.Fill(table);
            return table;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FillDataGridView("SELECT * FROM Line_Avia");
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FillDataGridView(@"SELECT Service_ID, Service_Name AS 'Использованный сервис', 
HTTP AS 'Сайт сервиса' FROM Service");
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = FillDataGridView(@"SELECT  Last_Name+' '+ First_Name+ ' ' + Second_Name as 'ФИО пользователя', 
CONVERT(VARCHAR(4), Passport_Series) + ' ' + CONVERT(VARCHAR(6), Passport_Number) as 
'Пасспортные данные', Users.Passport_date  as 'Дата выдачи паспорта'
FROM Users INNER JOIN Ticket ON Ticket.User_ID =
Users.User_ID");
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if ((String.IsNullOrEmpty(textBox2.Text)) || (String.IsNullOrEmpty(textBox7.Text)))
            {
                MessageBox.Show("Обязательно укажите пункт направления и пункт прибытия." +
                    "\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }
            if (checkBox1.Checked && String.IsNullOrEmpty(textBox3.Text))
            {
                MessageBox.Show("Не указана цена", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                checkBox1.Checked = false;
                return;
            }
            string sqlSelect = "";
            if (radioButton6.Checked)
             

                sqlSelect = @"SELECT Max_Count_of_people as Вместительность_самолета, Line_Avia.Сity_From as Пункт_отправления, Line_Avia.City_To as Пункт_назначения,
Air_Carrier as Авиакомпания, Total as Стоимость_билета, 
sum(USER_ID) as 'Кол-во_купленных_билетов' 
FROM Ticket,Line_Avia, Passenger_data WHERE Ticket.ID_Line = Line_Avia.ID_Line AND Line_Avia.Сity_From = @City_From 
AND
Line_Avia.City_To = @City_To
GROUP by Max_Count_of_people, Air_Carrier, Total, Сity_From, City_To";

            
                   else
                   if (radioButton7.Checked)

                sqlSelect = @"SELECT sum(USER_ID) as 'Кол-во_купленных_билетов',Line_Avia.Сity_From as Пункт_отправления, Line_Avia.City_To as Пункт_назначения,
Air_Carrier as Авиакомпания, Max_Count_of_people as Вместительность_самолета, Total as Стоимость_билета
 
FROM Ticket,Line_Avia, Passenger_data WHERE Ticket.ID_Line = Line_Avia.ID_Line AND Line_Avia.Сity_From = @City_From 
AND
Line_Avia.City_To = @City_To
GROUP by Max_Count_of_people, Air_Carrier, Total, Сity_From, City_To";
            
                        else
                            if (radioButton8.Checked)
                sqlSelect = @"SELECT Line_Avia.Сity_From as Пункт_отправления, Line_Avia.City_To as Пункт_назначения, sum(USER_ID) as 'Кол-во_купленных_билетов',
Air_Carrier as Авиакомпания, Max_Count_of_people as Вместительность_самолета, Total as Стоимость_билета
 
FROM Ticket,Line_Avia, Passenger_data WHERE Ticket.ID_Line = Line_Avia.ID_Line AND Line_Avia.Сity_From = @City_From 
AND
Line_Avia.City_To = @City_To
GROUP by Max_Count_of_people, Air_Carrier, Total, Сity_From, City_To";
           
            else
            {
                MessageBox.Show("Выберите способ сортировки информации о билетах");
                return;
            }
            if (checkBox1.Checked)
               sqlSelect += " HAVING Total >@amount";
            if (checkBox2.Checked)
               sqlSelect += " ORDER BY Total desc";
            SqlConnection connection = new
           SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            command.Parameters.AddWithValue("@City_From", textBox2.Text);
            command.Parameters.AddWithValue("@City_To", textBox7.Text);
            command.Parameters.AddWithValue("@amount", textBox3.Text);
            if (checkBox2.Checked)
                try
                {
                    MessageBox.Show("Nice");
                }
                catch
                {
                    MessageBox.Show("Прогресс в условии должен быть задан числом", "ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    checkBox2.Checked = false;
                    return;
                }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView3.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!",
           "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }





        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Обязательно укажите id направления",
                "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string sqlSelect = "";
            if (radioButton4.Checked)
            {

               sqlSelect = @"SELECT ID_Line, Air_Carrier, Max_Count_of_people FROM Line_Avia
WHERE ID_Line IN (SELECT ID_Line FROM Passenger_data WHERE Service_ID IN 
(SELECT Service_ID FROM Service WHERE Service_Name = @Air_Carrier))"; 
            }

            else
            if (radioButton5.Checked)
                sqlSelect = @"SELECT * FROM Line_Avia
WHERE Max_Count_of_people > (SELECT AVG(Max_Count_of_people) FROM Line_Avia WHERE Air_Carrier = @Air_Carrier);";
            else
            {
                MessageBox.Show("Не выбрали вид подзапроса", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            SqlConnection connection = new
            SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            SqlCommand command = connection.CreateCommand();
            command.CommandText = sqlSelect;
            try
            {
                command.Parameters.AddWithValue("@Air_Carrier", SqlDbType.Int).Value = (textBox1.Text);
            }
            catch
            {
                MessageBox.Show("id направления не соответствует числовому формату", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
            }
            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.SelectCommand = command;
            DataTable table = new DataTable();
            adapter.Fill(table);
            dataGridView2.DataSource = table;
            if (table.Rows.Count == 0) MessageBox.Show("Нет значений!", "Информация", 
                MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            dataGridView4.DataSource = FillDataGridView("SELECT * FROM Service");
        }





        #region Функция для добавления
        void Insert()
        {
            if (String.IsNullOrEmpty(textBox4.Text) ||
           (String.IsNullOrEmpty(textBox5.Text) ||
           (String.IsNullOrEmpty(textBox6.Text))))
            {
                MessageBox.Show("Обязательно введите все данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox4.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID сервиса!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

           
            if (String.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Некоректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            
            if (String.IsNullOrEmpty(textBox5.Text))
            {
                MessageBox.Show("Некорректное значение!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();
           
            SqlCommand command = new SqlCommand($@"INSERT INTO [Service] (Service_ID, Service_Name, HTTP) VALUES (@Service_ID, @Service_Name, @HTTP)", connection);

            
            command.Parameters.AddWithValue("Service_ID", textBox4.Text);
            command.Parameters.AddWithValue("Service_Name", textBox5.Text);
            command.Parameters.AddWithValue("HTTP", textBox6.Text);
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }
        #endregion

        void Delete()
        {
            if (String.IsNullOrEmpty(textBox4.Text)) 
            {
                MessageBox.Show("Обязательно введите данные", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox4.Text, out _))
            {
                MessageBox.Show("Некоректное значение ID сервиса!", "Внимание",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();
            SqlCommand command = new SqlCommand($@"DELETE FROM Service WHERE  Service_ID = @Service_ID", connection);

            command.Parameters.AddWithValue("Service_ID", textBox4.Text);
           
            MessageBox.Show(command.ExecuteNonQuery().ToString());
            connection.Close();
            button3_Click(this, EventArgs.Empty);
        }
    


        void Update()
        {
            if (String.IsNullOrEmpty(textBox4.Text))
            {
                MessageBox.Show("Требуется указать id изменяемого сервиса", 
                    "Внимание", MessageBoxButtons.OK,
                MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(textBox4.Text, out _))
            {
                MessageBox.Show("Некоректное значение id!", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
          
            string sqlUpdate = "";

            if ((!String.IsNullOrEmpty(textBox5.Text)) && (!String.IsNullOrEmpty(textBox6.Text)))
            {
                 sqlUpdate = "UPDATE Service SET Service_Name = @Service_Name, HTTP = @HTTP WHERE Service_ID = @Service_ID";
            }
            else
            {
                if (!String.IsNullOrEmpty(textBox5.Text))
                {
                    sqlUpdate = "UPDATE Service SET Service_Name = @Service_Name WHERE Service_ID = @Service_ID";
                }
                if (!String.IsNullOrEmpty(textBox6.Text))
                {
                    sqlUpdate = "UPDATE Service SET HTTP = @HTTP WHERE Service_ID = @Service_ID";
                }
            }

            

            SqlConnection connection = new SqlConnection(Properties.Settings.Default.AviasalesConnectionString);
            connection.Open();
            SqlCommand command = connection.CreateCommand();
            string sqlValues = "";
            if(!String.IsNullOrEmpty(textBox4.Text))
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




        private void button4_Click(object sender, EventArgs e)
        {
            if(radioButton9.Checked == true)
            {
                Insert();
                MessageBox.Show("Добавление данных выполнено");
            }

            if (radioButton10.Checked == true)
            {
                Delete();
                MessageBox.Show("Удаление данных выполнено");
            }

            if (radioButton11.Checked == true)
            {
                Update();
                
            }
        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
