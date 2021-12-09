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
    public partial class frmStaff : Form
    {
        public DataRow rStaff { set; get; } = null;
        int idRole = 0;
        DataTable dt = null;
        DataTable dt2 = null;
        private int iMode = 0;

        public NpgsqlConnection conn { set; get; }

        public frmStaff()
        {
            InitializeComponent();
        }

        private void AddRoles(int i)
        {
            cmbRole.Items.Clear();

            cmbRole.Items.Add("Специалист");
            cmbRole.Items.Add("Регистратрура");

            if (i != 1)
            {
                cmbRole.Items.Add("Администратор");
            }
        }

        private void Show()
        {
            this.dataGridView.SelectionChanged -= new System.EventHandler(this.dataGridView_SelectionChanged);
            DataSet ds = ClassMy.SelectStaff("",false);
            dt = ds.Tables[0];
            dataGridView.DataSource = dt;
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
        }

        private void frmStaff_Load(object sender, EventArgs e)
        {
            Show();
            AddRoles(0);

            DataTable dt2 = ClassMy.SelectSpec(true).Tables[0];
            cmbSpec.DataSource = dt2;
            cmbSpec.DisplayMember = "NameSpecialization";
            cmbSpec.ValueMember = "idSpecialization";

            dataGridView.DataSource = dt;

            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView.AllowDrop = false;
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToDeleteRows = false;

            dataGridView.Columns.Remove("Fio");
        
            DataGridViewCellStyle st = new DataGridViewCellStyle();
            st.SelectionBackColor = Color.Blue;

            dataGridView.DefaultCellStyle = st;

            
            dataGridView.Columns[0].Width = 70;
            dataGridView.Columns[0].HeaderText = "ID сотр.";

            dataGridView.Columns[1].Width = 100;
            dataGridView.Columns[1].HeaderText = "Фамилия";

            dataGridView.Columns[2].Width = 100;
            dataGridView.Columns[2].HeaderText = "Имя";

            dataGridView.Columns[3].Width = 100;
            dataGridView.Columns[3].HeaderText = "Отчество";

            dataGridView.Columns[4].Width = 100;
            dataGridView.Columns[4].HeaderText = "ID спец";

            dataGridView.Columns[5].Width = 100;
            dataGridView.Columns[5].HeaderText = "Login";

            dataGridView.Columns[6].Width = 100;
            dataGridView.Columns[6].HeaderText = "Специализация";
            
            this.dataGridView.SelectionChanged += new System.EventHandler(this.dataGridView_SelectionChanged);
            if (dt.Rows.Count>0)
                dataGridView.CurrentCell = dataGridView.Rows[0].Cells[0];
            dataGridView.Focus();
        }


        private void dataGridView_SelectionChanged(object sender, EventArgs e)
        {

            DataGridViewRow r = this.dataGridView.CurrentRow;
           
            if (r == null)
                return;
            
            long i = Convert.ToInt64(r.Cells[4].Value);
            cmbSpec.SelectedValue = i;
            
            lblID.Text = r.Cells[0].Value.ToString();
            txtFam.Text = r.Cells[1].Value.ToString();
            txtNam.Text = r.Cells[2].Value.ToString();
            txtOtc.Text = r.Cells[3].Value.ToString();
            txtLogin.Text = r.Cells[5].Value.ToString();
            lblID2.Text = r.Cells[4].Value.ToString();
        }

        private void создатьЗаписьОСотрудникеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iMode = 1;
            txtNam.Enabled = true;
            txtFam.Enabled = true;
            txtOtc.Enabled = true;
            cmbSpec.Enabled = true;
            cmbRole.Enabled = true;

            btnDo.Enabled = true;
            
            txtNam.Text = "";
            txtFam.Text = "";
            txtOtc.Text = "";

            txtLogin.Enabled = true;
            txtLogin.Text = "";

            lblID.Text = "";
            lblID2.Text = "";

            AddRoles(1);         
        }

        private void изменитьЗаписьОСотрудникеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            iMode = 2;
            txtNam.Enabled = true;
            txtFam.Enabled = true;
            txtOtc.Enabled = true;
            btnDo.Enabled = true;
            cmbSpec.Enabled= true;
            cmbRole.Enabled = true;

            AddRoles(2);
        }

        private void удалитьЗаписьОСотрудникеToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DialogResult res = MessageBox.Show("Удалять запись о сотрудние ?", "Подтвердите удаление", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (res == DialogResult.Yes)
            {
                ClassMy.DeleteStaff(Convert.ToInt64(lblID.Text));
                Show();
            }

        }

        private void btnDo_Click(object sender, EventArgs e)
        {
            doSave();
        }


        private void doSave()
        {
            try
            {
                if (cmbRole.SelectedIndex == -1)
                {
                    MessageBox.Show("Выберите роль");
                    return;
                }

                idRole = cmbRole.SelectedIndex;
                // создание
                if (iMode == 1)
                {
                    long i = ClassMy.InsertStaff( txtFam.Text, txtNam.Text, txtOtc.Text, txtLogin.Text, Convert.ToInt64(lblID2.Text),txtPsw.Text.Trim(), idRole);
                }

                // изменение
                if (iMode == 2)
                {
                    idRole=cmbRole.SelectedIndex;   
                    ClassMy.UpdateStaff(Convert.ToInt64(lblID.Text), txtFam.Text, txtNam.Text, txtOtc.Text, txtLogin.Text, Convert.ToInt64(lblID2.Text),idRole);
                }
                
                Show();
                
                txtNam.Enabled = false;
                txtFam.Enabled = false;
                txtOtc.Enabled = false;
                cmbSpec.Enabled = false;

                btnDo.Enabled = false;

                txtLogin.Enabled = false;
                
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            };
        }

        private void cmbSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbSpec.SelectedValue!=null)
                    lblID2.Text = cmbSpec.SelectedValue.ToString();
            }
            catch { }   
        }

        private void txtLogin_GotFocus(object sender, EventArgs e)
        {
            if (txtLogin.Text.Trim() == "")
                txtLogin.Text = ClassMy.Translit(txtFam.Text);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
