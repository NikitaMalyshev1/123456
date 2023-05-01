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
    public partial class Passengercom : Form
    {
        public Passengercom()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainForm();
            form1.Show(); 
        }

        private void ticketBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.ticketBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aviasalesDataSet);

        }

        private void Tickets_Communication_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Service". При необходимости она может быть перемещена или удалена.
            this.serviceTableAdapter.Fill(this.aviasalesDataSet.Service);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Line_Avia". При необходимости она может быть перемещена или удалена.
            this.line_AviaTableAdapter.Fill(this.aviasalesDataSet.Line_Avia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Passenger_data". При необходимости она может быть перемещена или удалена.
            this.passenger_dataTableAdapter.Fill(this.aviasalesDataSet.Passenger_data);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Ticket". При необходимости она может быть перемещена или удалена.
            this.ticketTableAdapter.Fill(this.aviasalesDataSet.Ticket);

        }


        string GetSelectedFieldName()
        {
            return
            ticketDataGridView.Columns[ticketDataGridView.CurrentCell.ColumnIndex].DataPropertyName;
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
                    ticketBindingSource.Find(GetSelectedFieldName(),
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
        string GetSelectedFieldName1()
        {
            return
            ticketDataGridView.Columns[3].DataPropertyName;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
                ticketBindingSource.Find(GetSelectedFieldName1(),
                textBox2.Text);
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


        string GetSelectedFieldName2()
        {
            return
            line_AviaDataGridView.Columns[1].DataPropertyName;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
                line_AviaBindingSource.Find(GetSelectedFieldName2(),
                textBox3.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                line_AviaBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                line_AviaBindingSource.Position = 0;
            }
        }


        string GetSelectedFieldName3()
        {
            return
            serviceDataGridView.Columns[1].DataPropertyName;
        }


        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox4.Text == "")
            {
                MessageBox.Show("Вы ничего не задали", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            int indexPos;
            try
            {
                indexPos =
                serviceBindingSource.Find(GetSelectedFieldName3(),
                textBox4.Text);
            }
            catch (Exception err)
            {
                MessageBox.Show("Ошибка поиска \n" + err.Message);
                return;
            }
            if (indexPos > -1)
                serviceBindingSource.Position = indexPos;
            else
            {
                MessageBox.Show("Таких сотрудников нет", "Внимание",
                MessageBoxButtons.OK, MessageBoxIcon.Information);
                serviceBindingSource.Position = 0;
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
                        GetSelectedFieldName() + "='" + textBox1.Text + "'";
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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox2.Checked)
            {
                if (textBox3.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        line_AviaBindingSource.Filter =
                        GetSelectedFieldName2() + "='" + textBox3.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
            }
            else
                line_AviaBindingSource.Filter = "";
            if (line_AviaBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                line_AviaBindingSource.Filter = "";
                checkBox2.Checked = false;
            }
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked)
            {
                if (textBox4.Text == "")
                    MessageBox.Show("Вы ничего не задали", "Внимание",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    try
                    {
                        serviceBindingSource.Filter =
                        GetSelectedFieldName3() + "='" + textBox4.Text + "'";
                    }
                    catch (Exception err)
                    {
                        MessageBox.Show("Ошибка фильтрации \n" +
                        err.Message);
                    }
            }
            else
                serviceBindingSource.Filter = "";
            if (serviceBindingSource.Count == 0)
            {
                MessageBox.Show("Нет таких");
                serviceBindingSource.Filter = "";
                checkBox3.Checked = false;
            }
        }

      
    }
}
