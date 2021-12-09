using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyclinicrRegistry
{
    public partial class frmSheduleRecept : Form
    {
        public bool bMode { set; get; } =false;   // выдача - прием
        public DataRow rStaff { set; get; }
        long idStaff = 0;
        long idSheduleReception = 0;
        DateTime DateOP = Convert.ToDateTime("01.01.1900");
        DataTable dt = null;
        public NpgsqlConnection conn { set; get; }
        public frmSheduleRecept()
        {
            InitializeComponent();
        }

        private void frmSheduleRecept_Load(object sender, EventArgs e)
        {
            
            if (bMode==false)
            {
                Text = "Выдача талонов на прием. Список талонов.";
                btnDo.Visible = false;
                rb1.Visible = false;
                rb2.Visible = false;
                rb3.Visible = false;

            }
            else
            {
                Text = "Прием специалиста. Очередь пациентов.";
                idStaff = Convert.ToInt64(rStaff["idStaff"]);
                contextMenuStrip1.Enabled = false;
        
            }

            Show();

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView.AllowDrop = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;
            
            dataGridView.Columns[0].Width = 70;
            dataGridView.Columns[0].HeaderText = "ID";

            dataGridView.Columns[1].Width = 70;
            dataGridView.Columns[1].HeaderText = "Дата";

            dataGridView.Columns[2].Width = 70;
            dataGridView.Columns[2].HeaderText = "Время";

            dataGridView.Columns[3].Width = 120;
            dataGridView.Columns[3].HeaderText = "Врач";

            dataGridView.Columns[4].Width = 120;
            dataGridView.Columns[4].HeaderText = "Спец.";

            dataGridView.Columns[5].Width = 120;
            dataGridView.Columns[5].HeaderText = "Пациент";

            dataGridView.Columns[6].Width = 120;
            dataGridView.Columns[6].HeaderText = "Регистратор";

            dataGridView.Columns[7].Width = 70;
            dataGridView.Columns[7].HeaderText = "Завершен";

            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            dataGridView.Focus();

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewRow r = this.dataGridView.CurrentRow;
            if (r == null)
                return;

            idSheduleReception = Convert.ToInt64(r.Cells[0].Value);
        }
        private void Show()
        {
            this.dataGridView.SelectionChanged -= new System.EventHandler(this.dataGridView_SelectionChanged);
            
            DataSet ds = null;
            if (bMode==false)
                ds = ClassMy.SelectSheduleRecept(idStaff);
            else
            {
                if (rb1.Checked==true)
                    ds = ClassMy.SelectSheduleRecept( idStaff,2);
                if (rb2.Checked == true)
                    ds = ClassMy.SelectSheduleRecept( idStaff, 1);
                if (rb3.Checked == true)
                    ds = ClassMy.SelectSheduleRecept( idStaff, 0);
            }

            dt = ds.Tables[0];
            dataGridView.DataSource = dt;

            if (dt.Rows.Count > 0)
            {
                dataGridView.Rows[0].Selected = true;
            }
            
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
        }

        private void новыйТалонНаПриемКВрачуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTicket frm = new frmTicket();
            frm.bMode = false;
            frm.ShowDialog();
            frm.Dispose();
            if (frm.DialogResult==DialogResult.OK)
            {
                Show();
            }

        }

        private void chkDtp_CheckedChanged(object sender, EventArgs e)
        {
            Show();
        }

        private void печатьТалонаНаПриемToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doPrint();
        }

        private void doPrint()
        {
            if (idSheduleReception == 0)
                return;
            ClassMy.PrintTicket(idSheduleReception);
        }

        private void редактированиеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (idSheduleReception == 0)
                return;

            frmTicket frm = new frmTicket();
            frm.bMode = false;
            frm.idSheduleRecept = idSheduleReception;
            frm.ShowDialog();
            if (frm.DialogResult == DialogResult.OK)
            {
                Show();
            }
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            if (idSheduleReception == 0)
                return;
            frmTicket frm = new frmTicket();
            frm.idSheduleRecept = idSheduleReception;
            frm.bMode = true;
            frm.ShowDialog();
            Show();
            
 
        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            Show();
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            Show();
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            Show();
        }

    }
}
