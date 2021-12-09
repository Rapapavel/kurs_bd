using Microsoft.Win32;
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
using static PolyclinicrRegistry.ClassMy;

namespace PolyclinicrRegistry
{
    public partial class frmLogin : Form
    {
       // private RegistryKey key = null;
        public SqlConnection connMy = null;
        public DataRow rStaff { set; get; }
        public frmLogin()
        {
            InitializeComponent();
        }

        private void  connect()
        {
            connMy = new SqlConnection(ClassMy.ConnectString); 
            DataSet ds = ClassMy.SelectStaffLogin(txtLogin.Text);
            
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtPsw.Text == "")
                {
                    doLog("Пароль пустой");
                    return;
                }
                // запомнил на все время
                string sConnect = @"SERVER=DESKTOP-7FFP3BG\SQLEXPRESS;UID=" + txtLogin.Text.Trim() + ";PWD=" + txtPsw.Text.Trim() + ";DATABASE=polyclinic";
                
                ClassMy.ConnectString = sConnect;
                DataSet ds = ClassMy.SelectStaffLogin(txtLogin.Text);
                if (ds != null)
                {
                    if (ds.Tables[0].Rows.Count == 1)
                    {
                        doLog("Успешный вход");
                        rStaff = ds.Tables[0].Rows[0];
                        doLog("Пользователь найден");
                        doLog("Окно закроется само ...");
                        btnConnect.Enabled = false;
                        btnCancel.Enabled = false;
                        timer1.Interval = 2000;
                        timer1.Enabled = true;
                        timer1.Start();
                    }
                    else
                    {
                        doLog("Ошибка имени или пароля");
                        Close();
                    }
                }
            }
            catch
            {
                doLog("Ошибка имени или пароля");
                Close();
            }
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
           Close();
        }

        private void doLog(string s)
        {
            lst.Items.Add(s);
            int i = lst.Items.Count;
            if (i > 0)
            {
                lst.SelectedIndex = i - 1;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;

        }

       
    }
}
