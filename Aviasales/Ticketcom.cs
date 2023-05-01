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
    public partial class Ticketcom : Form
    {
        public Ticketcom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainForm();
            form1.Show();
        }
        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aviasalesDataSet);

        }

        private void Ticketcom_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.aviasalesDataSet.Ticket);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.aviasalesDataSet.Users);

        }
        string GetSelectedFieldName2()
        {
            return
            ticketDataGridView.Columns[3].DataPropertyName;
        }


        private void button2_Click(object sender, EventArgs e)
        {
                if (textBox1.Text == "")
                {
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int indexPos;
                try
                {
                    indexPos =
                    ticketBindingSource.Find(GetSelectedFieldName2(),
                    textBox1.Text);
                }
                catch (Exception err)
                {
                    MessageBox.Show("Ошибка поиска \n" + err.Message);
                    return;
                }
                if (indexPos > -1)
                    ticketBindingSource.Position = indexPos;
                else
                {
                    MessageBox.Show("Таких сотрудников нет", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ticketBindingSource.Position = 0;
                }
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                if (textBox1.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        ticketBindingSource.Filter =
                        GetSelectedFieldName2() + "='" + textBox1.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
            }
            else
                ticketBindingSource.Filter = "";
            if (ticketBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                ticketBindingSource.Filter = "";
                checkBox1.Checked = false;
            }
        }
    }
}
