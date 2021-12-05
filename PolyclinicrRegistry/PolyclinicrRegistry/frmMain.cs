using Npgsql;
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

namespace PolyclinicrRegistry
{
    public partial class frmMain : Form
    {
        int idRole = -1;
        DataRow rStaff = null;
        public SqlConnection conn {set; get;}
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;

            timer1.Interval = 2000;
            timer1.Enabled = true;
            timer1.Start();

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            timer1.Stop();

            frmLogin frm = new frmLogin();
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                menuStrip1.Enabled = true;
                //conn = frm.conn;
                rStaff = frm.rStaff;
                string s = "Пользователь: " + rStaff["Surname"].ToString().Trim() + " " + rStaff["Name"].ToString().Trim() + " " + rStaff["Patronymic"].ToString().Trim();
                idRole = Convert.ToInt32(rStaff["idRole"]);
                
                switch (idRole)
                {
                    case 0:
                        s += ", специалист";
                        специальностиToolStripMenuItem.Enabled = false;
                        офисыToolStripMenuItem.Enabled=false;
                        штатноеРасписаниеСоставToolStripMenuItem.Enabled = false;
                        приемСпециалистаToolStripMenuItem.Enabled = false;

                        break;
                    case 1:
                        s += ", регистратор";
                        специальностиToolStripMenuItem.Enabled = false;
                        сотрудникиToolStripMenuItem.Enabled = false;
                        офисыToolStripMenuItem.Enabled = false;
                        //штатноеРасписаниеСоставToolStripMenuItem.Enabled = false;
                        расписаниеСпециалистовToolStripMenuItem.Enabled = false;

                        break;
                    case 2:
                        s += ", администратор";
                        приемСпециалистаToolStripMenuItem.Enabled = false;
                        расписаниеСпециалистовToolStripMenuItem.Enabled = false;
                        break;

                }
                toolStripStatusLabel1.Text = s;
            }
            else
                DialogResult = DialogResult.Cancel;

        }

        private void справочникиToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void специальностиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(rStaff["idRole"]) != 2)
            {
                MessageBox.Show("Только администратор", "Ограниичение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmSpecialization frm = new frmSpecialization();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void сотрудникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaff frm = new frmStaff();
            frm.rStaff = rStaff;
            frm.ShowDialog();
            frm.Dispose();
        }

        private void пациентыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(rStaff["idRole"])==2)
            {
                MessageBox.Show("Только для специалистов и сотрудников регистратуры", "Ограниичение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmPatient frm = new frmPatient();
            frm.ShowDialog();
            frm.Dispose();
        }

        // прием
        private void расписаниеСпециалистовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(rStaff["idRole"]) != 0)
            {
                MessageBox.Show("Прием осуществляет только специалист", "Ограниичение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmSheduleRecept frm = new frmSheduleRecept();
            frm.bMode = true;  // прием
            frm.rStaff = rStaff;
            //frm.conn = conn;

            frm.ShowDialog();
            frm.Dispose();
        }

        private void приемСпециалистаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(rStaff["idRole"])!=1)
            {
                MessageBox.Show("Выдачу талонов осуществляет только сотрудник регистратуры", "Ограниичение", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            frmSheduleRecept frm = new frmSheduleRecept();
            frm.bMode = false;  // для выдачи
            frm.rStaff = rStaff;
            //frm.conn = conn;

            frm.ShowDialog();
            frm.Dispose();

        }

        private void офисыToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOffice frm = new frmOffice();
            frm.ShowDialog();
            frm.Dispose();
        }

        private void штатноеРасписаниеСоставToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmStaffList frm = new frmStaffList();
            frm.ShowDialog();
            frm.Dispose();
        }
    }
}
