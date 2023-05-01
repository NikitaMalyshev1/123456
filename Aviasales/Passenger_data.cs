using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Aviasales
{
    public partial class Passenger_data : Form
    {
        public Passenger_data()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainForm();
            form1.Show();
        }

        private void passenger_dataBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.passenger_dataBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aviasalesDataSet);

        }

        private void Passenger_data_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Passenger_data". При необходимости она может быть перемещена или удалена.
            this.passenger_dataTableAdapter.Fill(this.aviasalesDataSet.Passenger_data);

        }
    }
}
