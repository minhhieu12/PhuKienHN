using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace PHUKIENHN.Class
{
    class XULYBANG: DataTable
    {
        #region Fields
        //HIHI
        public static string cnnStr = "Data Source=NGHIAPH\\SQLEXPRESS;Initial Catalog=PHUKIENHN;Integrated Security=True";
        private static SqlConnection _cnn;
        private SqlDataAdapter _da = new SqlDataAdapter();
        private string _query;
        private string _name;
        #endregion
        #region Properties
        public string query
        {
            get { return _query; }
            set { _query = value; }
        }
        public string name
        {
            get { return _name; }
            set { _name = value; }
        }
        public int getCount
        {
            get { return this.DefaultView.Count; }
        }
        #endregion
        #region Constructors
        public XULYBANG() : base() { }
        public XULYBANG(string pName)
        {
            _name = pName;
            docBang();
        }
        public XULYBANG(string pName, string pQuery)
        {
            _name = pName;
            _query = pQuery;
            docBang();
        }
        #endregion
        #region Methods
        public void docBang()
        {
            if (_query == null)
                _query = "Select * from " + _name;
            if (_cnn == null)
                _cnn = new SqlConnection(cnnStr);
            try
            {
                _da = new SqlDataAdapter(_query, _cnn);
                _da.FillSchema(this, SchemaType.Mapped);
                _da.Fill(this);
                _da.RowUpdated += new SqlRowUpdatedEventHandler(da_RowUpdate);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
        public Boolean ghi()
        {
            Boolean result = true;
            try
            {
                _da.Update(this);
                this.AcceptChanges();
            }
            catch(SqlException ex)
            {
                this.RejectChanges();
                result = false;
                throw ex;
            }
            return result;
        }
        public void LocDL(string pDK)
        {
            try
            {
                this.DefaultView.RowFilter = pDK;
            }
            catch(SqlException ex)
            {
                throw ex;
            }
        }
        public static int TruyVan(string pQuery)
        {
            if(_cnn == null)
            {
                _cnn = new SqlConnection(cnnStr);
            }
            try
            {
                SqlCommand cmd = new SqlCommand(pQuery, _cnn);
                _cnn.Open();
                int result = cmd.ExecuteNonQuery();
                _cnn.Close();
                return result;
            }
            catch
            {
                return -1;
            }
        }
        public static Object TruyVanGT(String pQuery)
        {
            if(_cnn == null)
            {
                _cnn = new SqlConnection(cnnStr);
            }
            try
            {
                SqlCommand cmd = new SqlCommand(pQuery, _cnn);
                _cnn.Open();
                Object result = cmd.ExecuteScalar();
                _cnn.Close();
                return result;
            }
            catch
            {
                return null;
            }
        }
        public static Object StoreProduce(string nameProc, SqlParameter[] p)
        {
            if(_cnn == null)
            {
                _cnn = new SqlConnection(cnnStr);
            }
            try
            {
                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = nameProc;
                cmd.Parameters.AddRange(p);
                _cnn.Open();
                Object result = cmd.ExecuteScalar();
                _cnn.Close();
                return result;
            }
            catch
            {
                return null;
            }
        }
        #endregion
        #region Events
        private void da_RowUpdate(Object sender, SqlRowUpdatedEventArgs e)
        {
            if(this.PrimaryKey[0].AutoIncrement)
            {
                if((e.Status == UpdateStatus.Continue) && (e.StatementType == StatementType.Insert))
                {
                    SqlCommand cmd = new SqlCommand("Select @@IDENTITY", _cnn);
                    e.Row.ItemArray[0] = cmd.ExecuteScalar();
                    e.Row.AcceptChanges();
                }
            }
        }
        #endregion
    }
}
