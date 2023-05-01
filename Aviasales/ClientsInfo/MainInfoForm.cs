using Aviasales.Auxiliary_class;
using Aviasales.Security;
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
    public partial class MainInfoForm : Form
    {
        public MainInfoForm()
        {
            InitializeComponent();
        }

        private void line_AviaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.line_AviaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aviasalesDataSet);

        }

        private void MainInfoForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Line_Avia". При необходимости она может быть перемещена или удалена.
            this.line_AviaTableAdapter.Fill(this.aviasalesDataSet.Line_Avia);

        }

        private void buttonSelect_Click(object sender, EventArgs e)
        {


            if ((String.IsNullOrEmpty(сity_FromTextBox.Text)) || (String.IsNullOrEmpty(city_ToTextBox.Text)))
            {
                MessageBox.Show("Обязательно укажите пункт отправления и пункт прибытия." +
                    "\nДопустим ввод первых символов.", "Внимание", MessageBoxButtons.OK,
               MessageBoxIcon.Warning);
                return;
            }
            else
            {
                var city_from = сity_FromTextBox.Text;
                var city_to = city_ToTextBox.Text;
                if (!checkBoxMoreInfo.Checked)
                {
                    
                    line_AviaDataGridView.DataSource = new CommandsForSQL().
                        FillDataGridView($@"select City_To as 'Пункт назначения', Сity_From as 'Пункт отправления', Air_Carrier as 'Авиаперевозчик', 
Max_Count_of_people as 'Вместительность самолета' from Line_Avia where Сity_From = '{city_from}' 
and City_To = '{city_to}'");
                }
                else
                {
                    line_AviaDataGridView.DataSource = new CommandsForSQL().
                        FillDataGridView($@"
                    select City_To as 'Пункт назначения', Сity_From as 'Пункт отправления', Air_Carrier as 'Авиаперевозчик', 
Max_Count_of_people as 'Вместительность самолета', Service_Name as 'Название компании', HTTP as 'Ссылка на сайт', 
Total as 'Цена билета' from
 Line_Avia, Service, Passenger_data
where Сity_From = '{city_from}'
and City_To = '{city_to}' and Passenger_data.ID_Line = Line_Avia.ID_Line and Passenger_data.Service_ID = Service.Service_ID");
                }
                

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.ShowDialog();
            Application.Exit();
        }
    }
}
