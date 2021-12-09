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
    public partial class frmStaffList : Form
    {
        long idStaff = 0;
        DataTable dt = null;

        DataTable dt1 = null;
        DataTable dt2 = null;
        DataTable dt3 = null;

        public frmStaffList()
        {
            InitializeComponent();
        }

        private void cmbStaff_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show2();
        }

        private void frmStaffList_Load(object sender, EventArgs e)
        {
            this.cmbStaff.SelectedIndexChanged -= new System.EventHandler(this.cmbStaff_SelectedIndexChanged);
            Show();
            Show2();


            this.cmbStaff.SelectedIndexChanged += new System.EventHandler(this.cmbStaff_SelectedIndexChanged);
        }

        private void Show()
        {
            dt = ClassMy.SelectStaff("",true).Tables[0];
            cmbStaff.DataSource = dt;
            cmbStaff.DisplayMember = "Fio";
            cmbStaff.ValueMember = "idStaff";

            idStaff = Convert.ToInt64(cmbStaff.SelectedValue);
        }

        private void Show2()
        {
            
            idStaff = Convert.ToInt64(cmbStaff.SelectedValue);

            dt1 = ClassMy.SelectStaffList(idStaff, false).Tables[0];
            lst1.DataSource = dt1;
            lst1.DisplayMember = "TimeStart";
            lst1.DisplayMember = "TimeStart";

            dt2 = ClassMy.SelectStaffList(idStaff, true).Tables[0];
            lst2.DataSource = dt2;
            lst2.DisplayMember = "TimeStart";
            lst2.DisplayMember = "TimeStart";

            dt3 = ClassMy.SelectOffice().Tables[0];
            cmbOffice.DataSource = dt3;
            cmbOffice.DisplayMember = "Number";
            cmbOffice.ValueMember = "idOffice";

            DataSet ds = ClassMy.SelectStaff4ID(idStaff);
            if (ds != null)
            {
                if (ds.Tables[0].Rows.Count==1)
                {
                    DataRow r = ds.Tables[0].Rows[0];
                    if (!(r["Office"] is DBNull))
                    {
                        cmbOffice.Text= r["Office"].ToString();
                    }
                    else
                    {
                        cmbOffice.Text = "";
                    }

                    if (!(r["bMode"] is DBNull))
                    {
                        if (Convert.ToBoolean(r["bMode"]) == true)
                            rb2.Checked = true;
                        else
                            rb1.Checked = true;
                    }
                    else
                    {
                        rb1.Checked = false;
                        rb2.Checked = false;
                    }
                }

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ( (rb1.Checked==false) && (rb2.Checked==false) )
            {
                MessageBox.Show("Выберите вариант смен");
                return;
            }
            long id = Convert.ToInt64(cmbOffice.SelectedValue);
            ClassMy.CreateStaffList(idStaff, rb2.Checked, id);
            
            Show2();

        }
    }
}
