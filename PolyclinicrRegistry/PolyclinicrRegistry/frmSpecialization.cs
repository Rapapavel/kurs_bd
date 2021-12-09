using AdyLibTextColumn;
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
    public partial class frmSpecialization : Form

    {
        private int iMode = 0;    
        DataTable dt = null;
        public frmSpecialization()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            txtName.Enabled = false;
            txtName.ForeColor = Color.Black;
            btnDo.Enabled = true;

            if (iMode == 2)
            {
                ClassMy.UpdateSpec( Convert.ToInt64(lblID.Text), txtName.Text);

            }

            if (iMode == 1)
            {
                long id = ClassMy.InsertSpec(txtName.Text);
            }

            Show();
        }

        private void Show()
        {
            this.dataGridView.SelectionChanged -= new System.EventHandler(this.dataGridView_SelectionChanged);
            DataSet ds = ClassMy.SelectSpec();
            DataTable dt = ds.Tables[0];
            dataGridView.DataSource = dt;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
        }


        private void frmSpecialization_Load(object sender, EventArgs e)
        {
            Show();

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                
            dataGridView.AllowDrop = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.Columns[0].Width = 70;
            dataGridView.Columns[0].HeaderText = "ID";

            dataGridView.Columns[1].Width = 200;
            dataGridView.Columns[1].HeaderText = "Специальность";
            
            
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            dataGridView.Focus();

        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewRow r = this.dataGridView.CurrentRow;
            if (r == null)
                return;
            
            lblID.Text = r.Cells[0].Value.ToString();
            txtName.Text = r.Cells[1].Value.ToString();
        }

        private void создатьНовуюСпециальностьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iMode = 1;
            txtName.Text = "";
            txtName.Enabled = true;
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
            DialogResult res = MessageBox.Show("Удалять запись о специализации ?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                ClassMy.DeleteSpec(Convert.ToInt64(lblID.Text));
                Show();
            }
        }
    }
}
