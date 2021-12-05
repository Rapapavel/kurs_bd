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
    public partial class frmOffice : Form
    {
        int iMode = 0;
        public frmOffice()
        {
            InitializeComponent();
        }

        private void Show()
        {
            this.dataGridView.SelectionChanged -= new System.EventHandler(this.dataGridView_SelectionChanged);
            DataSet ds = ClassMy.SelectOffice();
            DataTable dt = ds.Tables[0];
            dataGridView.DataSource = dt;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewRow r = this.dataGridView.CurrentRow;
            if (r == null)
                return;

            lblID.Text = r.Cells[0].Value.ToString();
            txtName.Text = r.Cells[1].Value.ToString();
        }
        private void frmOffice_Load(object sender, EventArgs e)
        {
            Show();

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dataGridView.AllowDrop = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.Columns[0].Width = 70;
            dataGridView.Columns[0].HeaderText = "ID";

            dataGridView.Columns[1].Width = 70;
            dataGridView.Columns[1].HeaderText = "Кабинет";


            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            dataGridView.Focus();
        }

        private void создатьНовуюСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iMode = 1;
            txtName.Enabled = true;
            txtName.Text = "";
            lblID.Text = "";
            btnDo.Enabled = true;
        }

        private void изменитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iMode = 2;
            txtName.Enabled = true;
            btnDo.Enabled = true;
        }

        private void удалитьСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iMode = 3;
            txtName.Enabled = true;
            btnDo.Enabled = true;
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtName.ForeColor = Color.Black;
            btnDo.Enabled = true;
            if (iMode == 1)
            {
                long i = ClassMy.InsertOffice(txtName.Text);

            }
            if (iMode == 2)
            {
                ClassMy.UpdateSpec(Convert.ToInt64(lblID.Text), txtName.Text);

            }
            Show();
        }
    }
}
