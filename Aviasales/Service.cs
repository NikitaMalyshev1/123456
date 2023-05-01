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
    public partial class Service : Form
    {
        public Service()
        {
            InitializeComponent();
        }

        private void serviceBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.serviceBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aviasalesDataSet);

        }

        private void Service_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.aviasalesDataSet.Service);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainForm();
            form1.Show();
        }
    }
}
