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
    public partial class Users : Form
    {
        static Users f;
        static public Users fs
        {
            get
            {
                if (f == null || f.IsDisposed) f = new Users();
                return f;
            }
        }

        public Users()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aviasalesDataSet);
        }

        private void Users_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "aviasalesDataSet.Users". При необходимости она может быть перемещена или удалена.
            this.usersTableAdapter.Fill(this.aviasalesDataSet.Users);
        }
        private void Users_Shown(object sender, EventArgs e)
        {
            usersBindingSource.Position =
            usersBindingSource.Find("User_ID", idCurrent);
        }
        public void ShowForm()
        {
            toolStripButtonOK.Visible = false;
            usersBindingSource.Position = 0;
            Show();
            Activate();
        }
        //переменная для текущего(выбранного) кода сотрудника
        int idCurrent = -1;
        public int ShowSelectForm(int id)
        {
            toolStripButtonOK.Visible = true;
            idCurrent = id;
            if (ShowDialog() == DialogResult.OK)
                return
                (int)((DataRowView)usersBindingSource.Current)["User_ID"];
            else
                return -1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            var form1 = new MainForm();
            form1.Show();
        }
        private void toolStripButtonOK_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }
    }
}
