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
    public partial class Ticket : Form
    {
        public Ticket()
        {
            InitializeComponent();
        }

        private void ticketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aviasalesDataSet);

        }

        private void Ticket_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.aviasalesDataSet.Ticket);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainForm();
            form1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int id = -1;
            if
            (((DataRowView)ticketBindingSource.Current)["User_ID"].ToString() !=
            "")
            {
                id =
                (int)(((DataRowView)ticketBindingSource.Current)["User_ID"]);
            }
            id = Users.fs.ShowSelectForm(id);
            if (id >= 0)
            {
                MessageBox.Show(id.ToString());
                ((DataRowView)ticketBindingSource.Current)["User_ID"]
                = id;
                ticketBindingSource.EndEdit();


            }
        }
    }
}
