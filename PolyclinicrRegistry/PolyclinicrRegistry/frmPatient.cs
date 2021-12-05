
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
    public partial class frmPatient : Form
    {
        public bool bSelect { set; get; } = false;
        int iMode = 0;
        int iFind = 0;
        string sFind = "";
        DataTable dt = null;
        
        public Patient patient { set; get; }  
        
        public frmPatient()
        {
            InitializeComponent();
        }

        private void Show()
        {
            this.dataGridView.SelectionChanged -= new System.EventHandler(this.dataGridView_SelectionChanged);
            DataSet ds = ClassMy.SelectPatient(iFind, sFind);
            dt = ds.Tables[0];
            dataGridView.DataSource = dt;
            
            if (dt.Rows.Count > 0)  
                dataGridView.Rows[0].Selected = true;

            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
        }

        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow r = this.dataGridView.CurrentRow;
                if (r == null)
                    return;
                lblID.Text = r.Cells[0].Value.ToString();
                txtFam.Text = r.Cells[1].Value.ToString();
                txtNam.Text = r.Cells[2].Value.ToString();
                txtOtc.Text = r.Cells[3].Value.ToString();
            
                txtPolice.Text = r.Cells[4].Value.ToString();
                txtPhone.Text = r.Cells[7].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }

        }


        private void frmPatient_Load(object sender, EventArgs e)
        {
            try
            {
                Show();
                // показывать 
                выбратьПациентаToolStripMenuItem.Visible = bSelect;

                dataGridView.DataSource = dt;

                dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                //dataGridView.SelectionMode = DataGridViewSelectionMode.ColumnHeaderSelect;

                dataGridView.AllowDrop = false;
                dataGridView.AllowUserToAddRows = false;
                dataGridView.AllowUserToDeleteRows = false;


                DataGridViewCellStyle st = new DataGridViewCellStyle();
                st.SelectionBackColor = Color.Blue;

                dataGridView.DefaultCellStyle = st;


                dataGridView.Columns[0].Width = 50;
                dataGridView.Columns[0].HeaderText = "ID.";

                dataGridView.Columns[1].Width = 100;
                dataGridView.Columns[1].HeaderText = "Фамилия";

                dataGridView.Columns[2].Width = 100;
                dataGridView.Columns[2].HeaderText = "Имя";

                dataGridView.Columns[3].Width = 100;
                dataGridView.Columns[3].HeaderText = "Отчество";

                dataGridView.Columns[4].Width = 100;
                dataGridView.Columns[4].HeaderText = "Полис";

                dataGridView.Columns[5].Width = 100;
                dataGridView.Columns[5].HeaderText = "Д/р.";

                dataGridView.Columns[6].Width = 70;
                dataGridView.Columns[6].HeaderText = "Пол";

                dataGridView.Columns[7].Width = 100;
                dataGridView.Columns[7].HeaderText = "Телефон";

                this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
                if (dt.Rows.Count > 0)
                    dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
                dataGridView.Focus();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void новыйПациентToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iMode = 1;
            g2.Enabled = true;
            btnDo.Enabled = true;
            txtFam.Text = "";
            txtNam.Text = "";
            txtOtc.Text = "";
            txtPhone.Text = "";
            txtPolice.Text = "";
            dtpBirth.Value = Convert.ToDateTime("01.01.1900");
        }

        private void изменитьСведенияПоПациентуToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iMode = 2;
            g2.Enabled = true;
            btnDo.Enabled = true;
        }

        private void удалитьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void поискToolStripMenuItem_Click(object sender, EventArgs e)
        {
            g3.Enabled = true;
        }

        private void r4_CheckedChanged(object sender, EventArgs e)
        {
            dtpFind.Enabled = true;
            txtFind.Enabled = false;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            if (r3.Checked==true)
            {
                iFind = 1;
                sFind=txtFind.Text;
            }

            if (r4.Checked == true)
            {
                iFind = 2;
                sFind = dtpFind.Value.ToShortDateString();
            }

            if (r5.Checked == true)
            {
                iFind = 3;
                sFind = txtFind.Text;
            }
            
            Show();
            
            txtFind.Text = "";
            dtpFind.Value = Convert.ToDateTime("01.01.1900");
            g3.Enabled = false;
        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFam.Text.Trim()=="")
                {
                    MessageBox.Show("Пустое поле фамилии");
                    return;
                }
                if (txtNam.Text.Trim() == "")
                {
                    MessageBox.Show("Пустое поле имени");
                    return;
                }
                if (txtPhone.Text.Trim() == "")
                {
                    MessageBox.Show("Пустое поле телефона");
                    return;
                }
                if (txtPolice.Text.Trim() == "")
                {
                    MessageBox.Show("Пустое поле полиса");
                    return;
                }

                // создание
                if (iMode == 1)
                {
                    bool sex = false;
                    sex = r1.Checked;
                    long i = ClassMy.InsertPatient(txtFam.Text.Trim(), txtNam.Text.Trim(), txtOtc.Text.Trim(), dtpBirth.Value, sex, txtPolice.Text.Trim(), txtPhone.Text.Trim());
                }

                // изменение - сделать


                g2.Enabled = false;
                btnDo.Enabled = false;

                Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dtpFind_ValueChanged(object sender, EventArgs e)
        {

        }

        private void r3_CheckedChanged(object sender, EventArgs e)
        {
            dtpFind.Enabled = false;
            txtFind.Enabled = true;
        }

        private void r5_CheckedChanged(object sender, EventArgs e)
        {
            dtpFind.Enabled = false;
            txtFind.Enabled = true;

        }

        private void выбратьПациентаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                patient.idPatient = Convert.ToInt64(lblID.Text);
                patient.Fio = txtFam.Text.Trim() + " " + txtNam.Text.Trim() + " " + txtOtc.Text.Trim();
                DialogResult = DialogResult.OK;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
