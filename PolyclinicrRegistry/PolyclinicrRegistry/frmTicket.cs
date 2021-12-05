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
    public partial class frmTicket : Form
    {
        public bool bMode { get; set; }
        DataRow rPatient=null;
        
        DataTable dt = null;
        DataTable dt2 = null;
        DataTable dt3 = null;
        DataTable dt4 = null;

        long idResult = 0;
        long idSpec = 0;
        long idStaff = 0;
        long idPatient = 0;
        long idSheduleStaff  = 0;
        public long idSheduleRecept { set; get; } = 0;
        public frmTicket()
        {
            InitializeComponent();
        }

        private void btnPatient_Click(object sender, EventArgs e)
        {
            Patient patient = new Patient();    
            frmPatient frm = new frmPatient();
            frm.patient = patient;
            frm.bSelect = true;
            frm.ShowDialog();  
            if (frm.DialogResult==DialogResult.OK)
            {
                patient = frm.patient;
                lblFio.Text = patient.Fio;
                idPatient = patient.idPatient;
            }
        }

        private void EvenDate()
        {
            int i = dtp.Value.Day;
            if (i % 2 == 0)
                lblEven.Text = "Четный день";
            else
                lblEven.Text = "Нечетный день";
        }

        private void frmTicket_Load(object sender, EventArgs e)
        {
            dt4 = ClassMy.SelectResult().Tables[0];
            cmbResult.DataSource = dt4;
            cmbResult.DisplayMember = "ResultComment";
            cmbResult.ValueMember = "idResult";

            this.cmbSpec.SelectedIndexChanged -= new System.EventHandler(this.cmbSpec_SelectedIndexChanged);
            dt = ClassMy.SelectSpec(true).Tables[0];
            cmbSpec.DataSource = dt;
            cmbSpec.DisplayMember = "NameSpecialization";
            cmbSpec.ValueMember = "idSpecialization";
            this.cmbSpec.SelectedIndexChanged += new System.EventHandler(this.cmbSpec_SelectedIndexChanged);

            // прием пациента
            if (bMode == true)
            {
                btnPrint.Text = "Печать заключения";
                rt.Enabled = true;
                chkClosed.Enabled = true;
                cmbResult.Enabled = true;

                cmbSpec.Enabled = false;
                cmbStuff.Enabled = false;
                cmbTime.Enabled = false;
                dtp.Enabled = false;
                btnPatient.Enabled = false;

            }

            // выдача талона
            else
            {
                rt.Enabled = false;
                chkClosed.Enabled = false;
                cmbResult.Enabled = false;
                

                chkClosed.Visible = false;
                cmbResult.Visible = false;
                rt.Visible = false;
                lbl.Visible = false;

            }

            if (idSheduleRecept == 0)
            {
                chkClosed.Checked = false;
                chkClosed.Enabled = false;
                cmbResult.SelectedValue = 1;
                cmbResult.Enabled = false;

                dtp.Value = DateTime.Today;
                dtp.MaxDate = DateTime.Today.AddDays(10);
                EvenDate();
            }
            else
            {
                
                dt3 = ClassMy.SelectResult().Tables[0];
                cmbResult.DataSource = dt3;
                cmbResult.DisplayMember = "ResultComment";
                cmbResult.ValueMember = "idResult";

          

                DataRow r = ClassMy.SelectSheduleRecept4ID(idSheduleRecept);

                idResult = Convert.ToInt64(r["idResult"]);
                //idSheduleStaff = Convert.ToInt64(r["idStaffList"]);
                // пациент
                idPatient = Convert.ToInt64(r["idPatient"]);
                lblFio.Text = r["FioPatient"].ToString().Trim();
                
                // специализация
                cmbSpec.SelectedValue = Convert.ToInt64(r["idSpecialization"]);
                idSpec = Convert.ToInt64(r["idSpecialization"]);

                // врач
                this.cmbStuff.SelectedIndexChanged -= new System.EventHandler(this.cmbStuff_SelectedIndexChanged);
                dt2 = ClassMy.SelectStaff4spec(idSpec).Tables[0];
                if (dt2.Rows.Count == 0)
                {
                    cmbStuff.DataSource = null;
                }
                else
                {
                    cmbStuff.DataSource = dt2;
                }
                cmbStuff.DisplayMember = "Fio";
                cmbStuff.ValueMember = "idStaff";
                this.cmbStuff.SelectedIndexChanged += new System.EventHandler(this.cmbStuff_SelectedIndexChanged);

                cmbStuff.SelectedValue = Convert.ToInt64(r["idStaffSpec"]);
                idStaff = Convert.ToInt64(r["idStaffSpec"]);

                // дата
                dtp.Value = Convert.ToDateTime(r["DateReception"]);

                EvenDate();
                Show2(true);
                
                // время
                idSheduleStaff = Convert.ToInt64(r["idSheduleStaff"]);

                cmbTime.SelectedValue = idSheduleStaff;

                cmbResult.SelectedValue = idResult;
                //chkClosed.Checked = false;
                //chkClosed.Enabled = true;
                //cmbResult.SelectedValue = 1;
                //cmbResult.Enabled = false;

                if (r["Comment"]!=null)
                    rt.Text = r["Comment"].ToString();
                chkClosed.Checked = Convert.ToBoolean(r["isClosed"]);

            }

            if (dt.Rows.Count > 0)
                cmbSpec.SelectedIndex = 0;
        }

        private void cmbSpec_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSpec.SelectedIndex == -1)
            {
                idSpec = 0;
                cmbStuff.DataSource = null;
                cmbStuff.DisplayMember = "Fio";
                cmbStuff.ValueMember = "idStaff";
                return;
            }

            idSpec = Convert.ToInt64(cmbSpec.SelectedValue);
            this.cmbStuff.SelectedIndexChanged -= new System.EventHandler(this.cmbStuff_SelectedIndexChanged);
            
            dt2 = ClassMy.SelectStaff4spec(idSpec).Tables[0];
            if (dt2.Rows.Count == 0)
            {
                cmbStuff.DataSource = null;
            }
            else
            {
                cmbStuff.DataSource = dt2;
            }
            cmbStuff.DisplayMember = "Fio";
            cmbStuff.ValueMember = "idStaff";

            this.cmbStuff.SelectedIndexChanged += new System.EventHandler(this.cmbStuff_SelectedIndexChanged);
        }

        private void cmbStuff_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStuff.SelectedIndex == -1)
            {
                idStaff = 0;
                lblStaff.Text = idStaff.ToString();
                return;
            }
            idStaff = Convert.ToInt64(cmbStuff.SelectedValue);
            lblStaff.Text = idStaff.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            doSave();
        }
        private void doSave()
        {
            
            // выдать талон
            if (bMode==false)
            {
                if (idPatient == 0)
                {
                    MessageBox.Show("Не выбран пациент");
                    return;
                }

                if (idStaff == 0)
                {
                    MessageBox.Show("Не выбран специалист");
                    return;
                }

                if (idSheduleStaff == 0)
                {
                    MessageBox.Show("Не выбрано время приема");
                    return;
                }

                idSheduleRecept = ClassMy.InsertSheduleRecept(idPatient, idSheduleStaff, dtp.Value);
                DialogResult = DialogResult.OK;
            }

            idResult = Convert.ToInt64(cmbResult.SelectedValue);
            
            ClassMy.UpdateSheduleRecept(idSheduleRecept, idPatient, idSheduleStaff, dtp.Value, chkClosed.Checked, idResult, rt.Text);
            MessageBox.Show("Сведения обновлены");
            
        }


        private void btn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (idSheduleRecept == 0)
                return;

            ClassMy.PrintResult(idSheduleRecept);
        }

        private void dtp_Leave(object sender, EventArgs e)
        {
            EvenDate();
            Show2();
        }

        private void Show2(bool bAll=false)
        {
             dt3 = ClassMy.SelectStaffList4Day(idStaff, dtp.Value, bAll ).Tables[0];
            
            if (dt3.Rows.Count>0)
                cmbTime.DataSource = dt3;
            else
                cmbTime.DataSource = null;

            cmbTime.DisplayMember = "TimeStart";
            cmbTime.ValueMember = "idStaffList";

        }

        private void cmbTime_Leave(object sender, EventArgs e)
        {
            if (cmbTime.SelectedIndex == -1)
                return;

            lblTime.Text = cmbTime.SelectedValue.ToString();
            idSheduleStaff = Convert.ToInt64(cmbTime.SelectedValue); 
        }

        private void cmbTime_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void cmbResult_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chkClosed_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
