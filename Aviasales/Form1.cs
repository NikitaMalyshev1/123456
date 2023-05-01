using Aviasales.AdminInfo;
using Aviasales.ClientsInfo;
using Aviasales.Security;
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
    public partial class MainForm : Form
    {


        public MainForm()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            this.Hide();
            loginForm.ShowDialog();
            Application.Exit();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КИБЭВС, Малышев Никита Анатольевич, " +
                "группа 720 - 2, 2022", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оНасToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КИБЭВС, Малышев Никита Анатольевич, " +
                "группа 720 - 2, 2022", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void направлениеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var line_avia = new Line_Avia();
            line_avia.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КИБЭВС, Малышев Никита Анатольевич, " +
                 "группа 720 - 2, 2022", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("(C)ТУСУР, КИБЭВС, Малышев Никита Анатольевич, " +
                 "группа 720 - 2, 2022", "О программе", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void данныеОПассажирахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var passenger_data = new Passenger_data();
            passenger_data.Show();
        }

        private void сервисToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var service = new Service();
            service.Show();
        }

        private void билетыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ticket = new Ticket();
            ticket.Show();
        }

        private void пользователиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var users = new Users();
            users.Show();
        }


        private void связьЧерезДанныеОБилетахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var passcom = new Passengercom();
            passcom.Show();
        }

        private void связьЧерезДанныеОПассажирахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var ticketcom = new Ticketcom();
            ticketcom.Show();
        }

        private void формаДля4ЛабыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            var laba4 = new laba4();
            laba4.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void информацияОРейсахToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MainInfoForm mainForm = new MainInfoForm();
            this.Hide();
            mainForm.ShowDialog();
            Application.Exit();
        }

        private void поискСервисаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ServiceForm mainForm = new ServiceForm();
            this.Hide();
            mainForm.ShowDialog();
            Application.Exit();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void информацияОПользователеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PersonInfoForm mainForm = new PersonInfoForm();
            this.Hide();
            mainForm.ShowDialog();
            Application.Exit();
        }

        private void data3labaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (RolesForLoginForm.currentRole != "Клиент")
            {
                AdminInfoForm mainForm = new AdminInfoForm();
                this.Hide();
                mainForm.ShowDialog();
                Application.Exit();
            }
            else
            {
                MessageBox.Show("У вас недостаточно прав доступа для просмотра данной информации!!!");
            }
        }
    }
}
