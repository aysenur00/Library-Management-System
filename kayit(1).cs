using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Kütüphane
{
    class database
    {
        OleDbConnection oleCon = new OleDbConnection();
        OleDbDataAdapter oleDaAc = new OleDbDataAdapter();

        public static string isim = "";
        public static string soyisim = "";
        public static string email = "";

       private bool bCheckConnection = false;

        public void ConnectDB()
        {
            
            try
            {
                bCheckConnection = false;
                string sPath = System.Windows.Forms.Application.StartupPath.ToLower();
                string sConn = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|kullanici.accdb";
                
                if(oleCon.State == ConnectionState.Open)
                {
                    oleCon.Close();
                }
                oleCon.ConnectionString = sConn;
                oleCon.Open();
                bCheckConnection = true;
            }
            catch(Exception ex)
            {
                bCheckConnection = false;
                MessageBox.Show("Error : " + ex.Message.ToString(), "Msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public DataSet ShowData (string _sSql, string _sTable,DataSet _ds)
        {
            DataSet dsSet;
            if (!bCheckConnection)
            {
                ConnectDB();
            }
            try
            {
                _ds.Clear();
                oleDaAc = new OleDbDataAdapter(_sSql, oleCon);
                OleDbCommandBuilder builder = new OleDbCommandBuilder(oleDaAc);
                oleDaAc.Fill(_ds, _sTable);
                dsSet = _ds;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error : " + ex.Message.ToString(), "Msg", MessageBoxButtons.OK, MessageBoxIcon.Error);
                dsSet = null;
            }
            finally
            {
                bCheckConnection = false;
                oleCon.Close();
            }
            return dsSet;
        }
        public OleDbDataAdapter data
        {
            get
            {
                return oleDaAc;
            }
            set
            {
                oleDaAc = value;
            }
        }

        public void kayitgiris(TextBox _txtEnter,string _sMessage)
        {
            string sText = _txtEnter.Text.Trim();
            if (sText.Equals(_sMessage))
            {
                _txtEnter.Text = "";
            }
        }

        public void kayitkontrol(TextBox _txtLeave,string _sMessage)
        {
            string sText = _txtLeave.Text.Trim();
            if (sText.Equals(_sMessage) || _txtLeave.Text.Equals(""))
            {
                _txtLeave.Text = _sMessage;
                if (_txtLeave.Equals("Password"))
                {
                    _txtLeave.UseSystemPasswordChar = false;
                }
            }
        }
    }
}
