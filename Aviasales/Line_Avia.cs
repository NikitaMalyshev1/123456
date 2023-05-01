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

namespace Aviasales
{
    public partial class Line_Avia : Form
    {
        public Line_Avia()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        { 
            this.Hide();
            var form1 = new MainForm();
            form1.Show();
        }

        private void Line_Avia_Load(object sender, EventArgs e)
        {
            var comSQL = new CommandsForSQL();
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Line_Avia". При необходимости она может быть перемещена или удалена.
            this.line_AviaTableAdapter.Fill(this.aviasalesDataSet.Line_Avia);
//            if (RolesForLoginForm.currentRole == "Клиент")
//            {
//                line_AviaDataGridView.DataSource = comSQL.FillDataGridView(@"Select Сity_From as 'Пункт отправления', 
//City_To as 'Пункт назначения', Air_Carrier as 'Авиаперевозчик', Max_Count_of_people as 'Вместительность салона' from Line_Avia");
//            }
            //else
            //{
            //    dataGridViewPlayers.DataSource = FillDataGridView(@"Select Name_Player as 'Имя участника' from Player");
            //}
            //line_AviaDataGridView.DataSource = 
        }

        private void line_AviaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.line_AviaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aviasalesDataSet);

        }

    }
}
