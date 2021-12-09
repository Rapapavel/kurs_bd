using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PolyclinicrRegistry

{
    public class Patient
    {
        public string Fio;
        public long idPatient;
    }



    public static class ClassMy
    {

        public static string Translit(string str)
        {
            string[] lat_up = { "A", "B", "V", "G", "D", "E", "Yo", "Zh", "Z", "I", "Y", "K", "L", "M", "N", "O", "P", "R", "S", "T", "U", "F", "Kh", "Ts", "Ch", "Sh", "Shch", "\"", "Y", "'", "E", "Yu", "Ya" };
            string[] lat_low = { "a", "b", "v", "g", "d", "e", "yo", "zh", "z", "i", "y", "k", "l", "m", "n", "o", "p", "r", "s", "t", "u", "f", "kh", "ts", "ch", "sh", "shch", "\"", "y", "'", "e", "yu", "ya" };
            string[] rus_up = { "А", "Б", "В", "Г", "Д", "Е", "Ё", "Ж", "З", "И", "Й", "К", "Л", "М", "Н", "О", "П", "Р", "С", "Т", "У", "Ф", "Х", "Ц", "Ч", "Ш", "Щ", "Ъ", "Ы", "Ь", "Э", "Ю", "Я" };
            string[] rus_low = { "а", "б", "в", "г", "д", "е", "ё", "ж", "з", "и", "й", "к", "л", "м", "н", "о", "п", "р", "с", "т", "у", "ф", "х", "ц", "ч", "ш", "щ", "ъ", "ы", "ь", "э", "ю", "я" };
            for (int i = 0; i <= 32; i++)
            {
                str = str.Replace(rus_up[i], lat_up[i]);
                str = str.Replace(rus_low[i], lat_low[i]);
            }
            return str;
        }

        public static string ConnectString { get; set; }


        public static DataSet SelectPatient(int i, string s)
        {
            DataSet ds = new DataSet("DS");
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_SelectPatient", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@i", SqlDbType.Int);
                sda.SelectCommand.Parameters["@i"].Value = i;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@s", SqlDbType.VarChar,100);
                sda.SelectCommand.Parameters["@s"].Value = s;

                sda.Fill(ds, "DS");
                sda.Dispose();
                conn.Close();

                return ds;
            }

            catch (SqlException e)
            {
                ds = null;
                return ds;
            }
            catch (Exception e)
            {
                ds = null;
                return ds;
            }
        }

        public static long InsertPatient(string Surname, string Name, string Patronymic, DateTime BirthDate, bool Sex, string Policy, string Phone)
        {
            long i = 0;
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlCommand cmdSel = new SqlCommand("sp_InsertPatient", conn)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };

                cmdSel.Parameters.Add("@SurName", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@SurName"].Value = Surname;

                cmdSel.Parameters.Add("@Name", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@Name"].Value = Name;

                cmdSel.Parameters.Add("@Patronymic", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@Patronymic"].Value = Patronymic;

                cmdSel.Parameters.Add("@Policy", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@Policy"].Value = Policy;

                cmdSel.Parameters.Add("@birthdate", SqlDbType.DateTime);
                cmdSel.Parameters["@birthdate"].Value = BirthDate;

                cmdSel.Parameters.Add("@sex", SqlDbType.Bit);
                cmdSel.Parameters["@sex"].Value = Sex;

                cmdSel.Parameters.Add("@idpatient", SqlDbType.BigInt);
                cmdSel.Parameters["@idpatient"].Direction = ParameterDirection.Output;

                cmdSel.Parameters.Add("@phone", SqlDbType.VarChar,10);
                cmdSel.Parameters["@phone"].Value = Phone;

                cmdSel.ExecuteNonQuery();
                i = Convert.ToInt64(cmdSel.Parameters["@idPatient"].Value);

                conn.Close();
                cmdSel.Dispose();
                conn = null;

                return i;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message); 
                return i;
            }

        }


        public static long InsertOffice (string Number)
        {
            long i = 0;
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlCommand cmdSel = new SqlCommand("sp_InsertOffice", conn)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };

                cmdSel.Parameters.Add("@Number", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@Number"].Value = Number;

                cmdSel.Parameters.Add("@idOffice", SqlDbType.BigInt);
                cmdSel.Parameters["@idOffice"].Direction = ParameterDirection.Output;

                cmdSel.ExecuteNonQuery();
                i = Convert.ToInt64(cmdSel.Parameters["@idOffice"].Value);

                conn.Close();
                cmdSel.Dispose();
                conn = null;

                return i;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return i;
            }

        }

        public static DataSet SelectOffice()
        {
            DataSet ds = new DataSet("DS");
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_SelectOffice", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;


                sda.Fill(ds, "DS");
                sda.Dispose();
                conn.Close();

                return ds;
            }

            catch (SqlException e)
            {
                ds = null;
                return ds;
            }
            catch (Exception e)
            {
                ds = null;
                return ds;
            }
        }


        public static DataSet SelectSpec(bool bOnlySpec=false)
        {
            DataSet ds = new DataSet("DS");
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_SelectSpec", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@bOnlySpec", SqlDbType.Bit);
                sda.SelectCommand.Parameters["@bOnlySpec"].Value = bOnlySpec;

                sda.Fill(ds, "DS");
                sda.Dispose();
                conn.Close();

                return ds;
            }

            catch (SqlException e)
            {
                ds = null;
                return ds;
            }
            catch (Exception e)
            {
                ds = null;
                return ds;
            }
        }

        public static DataSet SelectResult()
        {
            DataSet ds = new DataSet("DS");
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_SelectResult", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                sda.Fill(ds, "DS");
                sda.Dispose();
                conn.Close();

                return ds;
            }

            catch (SqlException e)
            {
                ds = null;
                return ds;
            }
            catch (Exception e)
            {
                ds = null;
                return ds;
            }
        }

        public static void UpdateSpec (long id, string spec)
        {
            string s = "";
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlCommand cmdSel = new SqlCommand("sp_UpdateSpec", conn)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };

                cmdSel.Parameters.Add("@id", SqlDbType.BigInt);
                cmdSel.Parameters["@id"].Value = id;

                cmdSel.Parameters.Add("@NameSpecialization", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@NameSpecialization"].Value = spec;

                cmdSel.ExecuteNonQuery();

                conn.Close();
                cmdSel.Dispose();
                conn = null;

                return;
            }

            catch (Exception e)
            {
                return;
            }

        }


        public static long InsertSpec(string spec)
        {
            long id = 0;
            string s = "";
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlCommand cmdSel = new SqlCommand("sp_InsertSpec", conn)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };

                cmdSel.Parameters.Add("@id", SqlDbType.BigInt);
                cmdSel.Parameters["@id"].Direction = ParameterDirection.Output;

                cmdSel.Parameters.Add("@NameSpec", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@NameSpec"].Value = spec;

                cmdSel.ExecuteNonQuery();
                id = Convert.ToInt64(cmdSel.Parameters["@id"].Value);

                conn.Close();
                cmdSel.Dispose();
                conn = null;

                return id;
            }

            catch (Exception e)
            {
                return id;
            }

        }

        public static void DeleteStaff(long idStaff)
        {

            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlCommand cmdSel = new SqlCommand("sp_DeleteStaff", conn)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };

                cmdSel.Parameters.Add("@idStaff", SqlDbType.BigInt);
                cmdSel.Parameters["@idStaff"].Value = idStaff;

                cmdSel.ExecuteNonQuery();

                conn.Close();
                cmdSel.Dispose();
                conn = null;

                return;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка удаления специалиста",MessageBoxButtons.OK,MessageBoxIcon.Error);
                return;
            }

        }

        public static void DeleteSpec(long idSpec)
        {

            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlCommand cmdSel = new SqlCommand("sp_DeleteSpec", conn)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };

                cmdSel.Parameters.Add("@id", SqlDbType.BigInt);
                cmdSel.Parameters["@id"].Value = idSpec;

                cmdSel.ExecuteNonQuery();

                conn.Close();
                cmdSel.Dispose();
                conn = null;

                return;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Ошибка удаления специалиста", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        public static void UpdateStaff(long id, string Surname,  string Name, string Patronymic, string LoginName, long idSpecialization, int idRole)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlCommand cmdSel = new SqlCommand("sp_UpdateStaff", conn)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };

                cmdSel.Parameters.Add("@idStaff", SqlDbType.BigInt);
                cmdSel.Parameters["@idStaff"].Value = id;

                cmdSel.Parameters.Add("@SurName", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@SurName"].Value = Surname;

                cmdSel.Parameters.Add("@Name", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@Name"].Value = Name;

                cmdSel.Parameters.Add("@Patronymic", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@Patronymic"].Value = Patronymic;

                cmdSel.Parameters.Add("@LoginStaff", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@LoginStaff"].Value = LoginName;

                cmdSel.Parameters.Add("@idSpecialization", SqlDbType.BigInt);
                cmdSel.Parameters["@idSpecialization"].Value = idSpecialization;

                cmdSel.Parameters.Add("@idRole", SqlDbType.Int);
                cmdSel.Parameters["@idRole"].Value = idRole;

                cmdSel.ExecuteNonQuery();

                conn.Close();
                cmdSel.Dispose();
                conn = null;

                return;
            }

            catch (Exception e)
            {
                return;
            }

        }

        public static long InsertStaff( string Surname, string Name, string Patronymic, string LoginName, long idSpecialization, string psw, int idRole)
        {
            long i = 0;
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlCommand cmdSel = new SqlCommand("sp_InsertStaff", conn)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };

                cmdSel.Parameters.Add("@idStaff", SqlDbType.BigInt);
                
                cmdSel.Parameters["@idStaff"].Direction = ParameterDirection.Output;

                cmdSel.Parameters.Add("@SurName", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@SurName"].Value = Surname;

                cmdSel.Parameters.Add("@Name", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@Name"].Value = Name;

                cmdSel.Parameters.Add("@Patronymic", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@Patronymic"].Value = Patronymic;

                cmdSel.Parameters.Add("@LoginStaff", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@LoginStaff"].Value = LoginName;

                cmdSel.Parameters.Add("@idSpecialization", SqlDbType.BigInt);
                cmdSel.Parameters["@idSpecialization"].Value = idSpecialization;

                cmdSel.Parameters.Add("@idRole", SqlDbType.Int);
                cmdSel.Parameters["@idRole"].Value = idRole;

                cmdSel.Parameters.Add("@psw", SqlDbType.VarChar, 100);
                cmdSel.Parameters["@psw"].Value = psw;

                cmdSel.ExecuteNonQuery();

                i = Convert.ToInt64(cmdSel.Parameters["@idStaff"].Value);

                conn.Close();
                cmdSel.Dispose();
                conn = null;

                return i;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return i;
            }

        }


        public static DataSet SelectStaff(string Fam="", bool bOnlySpec = false)
        {
            DataSet ds = new DataSet("DS");
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_SelectStaff", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@Fam", SqlDbType.VarChar,100);
                sda.SelectCommand.Parameters["@Fam"].Value = Fam;

                sda.SelectCommand.Parameters.Add("@b", SqlDbType.Bit);
                sda.SelectCommand.Parameters["@b"].Value = bOnlySpec;

                sda.Fill(ds, "DS");
                sda.Dispose();
                conn.Close();

                return ds;
            }

            catch (SqlException e)
            { 
                MessageBox.Show(e.Message);
                ds = null;
                return ds;
            }
            catch (Exception e)
            {
                ds = null;
                return ds;
            }
        }

        public static DataSet SelectStaff4ID(long idStaff)
        {
            DataSet ds = new DataSet("DS");
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_SelectStaff4id", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@idStaff", SqlDbType.BigInt);
                sda.SelectCommand.Parameters["@idStaff"].Value = idStaff;

                sda.Fill(ds, "DS");
                sda.Dispose();
                conn.Close();

                return ds;
            }

            catch (SqlException e)
            {
                ds = null;
                return ds;
            }
            catch (Exception e)
            {
                ds = null;
                return ds;
            }
        }


        public static DataSet SelectStaff4spec(long idSpec)
        {
            DataSet ds = new DataSet("DS");
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_SelectStaff4spec", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@idSpec", SqlDbType.BigInt);
                sda.SelectCommand.Parameters["@idSpec"].Value = idSpec;

                sda.Fill(ds, "DS");
                sda.Dispose();
                conn.Close();

                return ds;
            }

            catch (SqlException e)
            {
                ds = null;
                return ds;
            }
            catch (Exception e)
            {
                ds = null;
                return ds;
            }
        }


        public static DataSet SelectStaffList4Day(long idStaff, DateTime DateOP, bool bAll=false)
        {
            DataSet ds = new DataSet("DS");
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_SelectTime", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@idStaff", SqlDbType.BigInt);
                sda.SelectCommand.Parameters["@idStaff"].Value = idStaff;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@DateOP", SqlDbType.DateTime);
                sda.SelectCommand.Parameters["@DateOP"].Value = DateOP;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@bAll", SqlDbType.Bit);
                sda.SelectCommand.Parameters["@bAll"].Value = bAll;
                sda.Fill(ds, "DS");
                sda.Dispose();
                conn.Close();

                return ds;
            }

            catch (SqlException e)
            {
                ds = null;
                return ds;
            }
            catch (Exception e)
            {
                ds = null;
                return ds;
            }
        }



        public static DataSet SelectSheduleRecept(long idStaff, int isClosed=0)
        {
            DataSet ds = new DataSet("DS");
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_SelectSheduleRecept", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@idStaff", SqlDbType.BigInt);
                sda.SelectCommand.Parameters["@idStaff"].Value = idStaff;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@isClosed", SqlDbType.Int);
                sda.SelectCommand.Parameters["@isClosed"].Value = isClosed;

                sda.Fill(ds, "DS");
                sda.Dispose();
                conn.Close();

                return ds;
            }

            catch (SqlException e)
            {
                ds = null;
                return ds;
            }
            catch (Exception e)
            {
                ds = null;
                return ds;
            }
        }


        public static DataRow SelectSheduleRecept4ID(long idSheduleRecept)
        {
            DataRow r = null;
            DataSet ds = new DataSet("DS");
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_SelectSheduleRecept4ID", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@idSheduleRecept", SqlDbType.BigInt);
                sda.SelectCommand.Parameters["@idSheduleRecept"].Value = idSheduleRecept;


                sda.Fill(ds, "DS");
                if (ds.Tables[0].Rows.Count >0)
                {
                    r = ds.Tables[0].Rows[0];
                }

                sda.Dispose();
                conn.Close();

                return r;
            }

            catch (SqlException e)
            {
                r = null;
                return r;
            }
            catch (Exception e)
            {
                r = null;
                return r;
            }
        }

        public static DataSet SelectStaffList(long idStaff, bool bMode)
        {
            DataSet ds = new DataSet("DS");
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("sp_SelectStaffList", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@idStaff", SqlDbType.BigInt);
                sda.SelectCommand.Parameters["@idStaff"].Value = idStaff;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@bMode", SqlDbType.Bit);
                sda.SelectCommand.Parameters["@bMode"].Value = bMode;

                sda.Fill(ds, "DS");
                sda.Dispose();
                conn.Close();

                return ds;
            }

            catch (SqlException e)
            {
                ds = null;
                return ds;
            }
            catch (Exception e)
            {
                ds = null;
                return ds;
            }
        }

        public static DataSet SelectStaffLogin(string staff)
        {
            DataSet ds = new DataSet("DS");
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlDataAdapter sda = new SqlDataAdapter("sp_LoginStaff", conn);
                sda.SelectCommand.CommandType = CommandType.StoredProcedure;

                // значение параметра
                sda.SelectCommand.Parameters.Add("@LoginStaff", SqlDbType.VarChar,100);
                sda.SelectCommand.Parameters["@LoginStaff"].Value = staff;

                sda.Fill(ds, "DS");
                sda.Dispose();
                conn.Close();

                return ds;
            }

            catch (SqlException e)
            {
                ds = null;
                MessageBox.Show(e.Message);
                return ds;
            }
            catch (Exception e)
            {
                ds = null;
                MessageBox.Show(e.Message);
                return ds;
            }
        }

        public static long InsertSheduleRecept(long idPatient, long idSheduleStaff, DateTime DateReception)
        {
            long i = 0;
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlCommand cmdSel = new SqlCommand("sp_InsertSheduleRecept", conn)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };

                cmdSel.Parameters.Add("@idPatient", SqlDbType.BigInt);
                cmdSel.Parameters["@idPatient"].Value = idPatient;

                cmdSel.Parameters.Add("@idSheduleStaff", SqlDbType.BigInt);
                cmdSel.Parameters["@idSheduleStaff"].Value = idSheduleStaff;

                cmdSel.Parameters.Add("@DateReception", SqlDbType.DateTime);
                cmdSel.Parameters["@DateReception"].Value = DateReception;

                cmdSel.Parameters.Add("@idSheduleReception", SqlDbType.BigInt);
                cmdSel.Parameters["@idSheduleReception"].Direction = ParameterDirection.Output;

                cmdSel.ExecuteNonQuery();

                i = Convert.ToInt64(cmdSel.Parameters["@idSheduleReception"].Value);

                conn.Close();
                cmdSel.Dispose();
                conn = null;

                return i;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return i;
            }

        }

        public static void UpdateSheduleRecept(long idSheduleRecept, 
            long idPatient, long idSheduleStaff, 
            DateTime DateReception, bool isClosed, long idResult, string  Comment
            )
        {
            long i = 0;
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlCommand cmdSel = new SqlCommand("sp_UpdateSheduleRecept", conn)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };
                cmdSel.Parameters.Add("@idSheduleReception", SqlDbType.BigInt);
                cmdSel.Parameters["@idSheduleReception"].Value = idSheduleRecept;

                cmdSel.Parameters.Add("@idPatient", SqlDbType.BigInt);
                cmdSel.Parameters["@idPatient"].Value = idPatient;

                cmdSel.Parameters.Add("@idSheduleStaff", SqlDbType.BigInt);
                cmdSel.Parameters["@idSheduleStaff"].Value = idSheduleStaff;

                cmdSel.Parameters.Add("@isClosed", SqlDbType.Bit);
                cmdSel.Parameters["@isClosed"].Value = isClosed;

                cmdSel.Parameters.Add("@idResult", SqlDbType.BigInt);
                cmdSel.Parameters["@idResult"].Value = idResult;

                cmdSel.Parameters.Add("@DateReception", SqlDbType.DateTime);
                cmdSel.Parameters["@DateReception"].Value = DateReception;

                cmdSel.Parameters.Add("@Comment", SqlDbType.Text);
                cmdSel.Parameters["@Comment"].Value = Comment;

                cmdSel.ExecuteNonQuery();

                conn.Close();
                cmdSel.Dispose();
                conn = null;

                return;
            }

            catch (Exception e)
            {
                MessageBox.Show(e.Message);
                return;
            }

        }

        public static void CreateStaffList(long idStaff, bool bMode, long id)
        {
            try
            {
                SqlConnection conn = new SqlConnection(ConnectString);
                conn.Open();

                SqlCommand cmdSel = new SqlCommand("sp_CreateSheduleStaff", conn)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = 600
                };

                cmdSel.Parameters.Add("@idStaff", SqlDbType.BigInt);
                cmdSel.Parameters["@idStaff"].Value = idStaff;

                cmdSel.Parameters.Add("@bMode", SqlDbType.BigInt);
                cmdSel.Parameters["@bMode"].Value = bMode;

                cmdSel.Parameters.Add("@idOffice", SqlDbType.BigInt);
                cmdSel.Parameters["@idOffice"].Value = id;

                cmdSel.ExecuteNonQuery();

                conn.Close();
                cmdSel.Dispose();
                conn = null;

                return;
            }

            catch (Exception e)
            {
                return;
            }

        }


        public static void PrintTicket(long idShedule)
        {
            DataRow r = SelectSheduleRecept4ID(idShedule);
            string sfile = Path.GetTempPath() + @"\ticket.txt";
            StreamWriter f = new StreamWriter(sfile);
            f.WriteLine("Поликлиника № XXXXXXX");
            f.WriteLine("Талон на прием к врачу. ");
            f.WriteLine(" ");
            f.WriteLine("Дата приема:"+Convert.ToDateTime(r["DateReception"]).ToShortDateString());
            f.WriteLine("Время приема:" + r["TimeStart"].ToString());
            f.WriteLine(" ");
            f.WriteLine("Специалист:" + r["NameSpecialization"].ToString().Trim()+", "+ r["FioSpec"].ToString().Trim());
            f.WriteLine(" ");
            f.WriteLine("Пациент:" + r["FioPatient"].ToString().Trim());
            f.WriteLine(" ");
            f.WriteLine("Талон выдал:" + r["FioRegistr"].ToString().Trim());
            f.Flush();
            f.Close();
            Process.Start(sfile);


        }

        public static void PrintResult(long idShedule)
        {
            DataRow r = SelectSheduleRecept4ID(idShedule);
            string sfile = Path.GetTempPath() + @"\result.txt";
            StreamWriter f = new StreamWriter(sfile);
            f.WriteLine("Поликлиника № XXXXXXX");
            f.WriteLine("Заключение врача ");
            f.WriteLine(" ");
            f.WriteLine("Дата приема:" + Convert.ToDateTime(r["DateReception"]).ToShortDateString());
            f.WriteLine("Время приема:" + r["TimeStart"].ToString());
            f.WriteLine(" ");
            f.WriteLine("Специалист:" + r["NameSpecialization"].ToString().Trim() + ", " + r["FioSpec"].ToString().Trim());
            f.WriteLine(" ");
            f.WriteLine("Пациент:" + r["FioPatient"].ToString().Trim());
            f.WriteLine("Дата рождения:" + Convert.ToDateTime(r["BirthDate"]).ToShortDateString());
            f.WriteLine("Полис:" + r["Policy"].ToString().Trim());
            f.WriteLine(" ");
            f.WriteLine("Общее заключение:" + r["ResultComment"].ToString().Trim());
            f.WriteLine("Комментарии:" + r["Comment"].ToString().Trim());

            f.Flush();
            f.Close();
            Process.Start(sfile);


        }

    }
}
