using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using System.Diagnostics.Eventing.Reader;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.CodeDom;
using System.Runtime.InteropServices;
using System.Xml;

namespace Trimetric.LifePartner.DAL
{

    // this type or class allows us to execute sql operations, developers can modify based on application requirement
    public abstract class BaseDAL : IDisposable
    {
        protected SqlConnection _sqlConnection;
        protected SqlDataReader _dataReader;
        // TODO: Get Connection string from config
        protected string _connString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=LifePartner;Data Source=LAPTOP-LNURBAR7\\SQLEXPRESS";
        // Method to read data
        protected  T  GetById<T>(string query) where T : class
        {
            using (_sqlConnection = new SqlConnection(_connString))
            {
                _sqlConnection.Open();
                SqlCommand command = new SqlCommand(query, _sqlConnection);
                using (SqlDataReader dataReader = command.ExecuteReader())
                {
                    T result = GetEntity<T>(dataReader);
                    if (result != null)
                    {
                        dataReader.Close();
                        _sqlConnection.Close();
                        Dispose();
                        return result;
                    }
                    throw new NotImplementedException();
                }
            }
        }

       
        protected void ExecuteCommand(string commandText)
        {
            using (_sqlConnection = new SqlConnection(_connString))
            {
                SqlCommand command = new SqlCommand { CommandType = CommandType.Text, CommandText = commandText, Connection = _sqlConnection };
                _sqlConnection.Open();
                command.ExecuteNonQuery();
                _sqlConnection.Close();
                //_sqlConnection.Dispose();
                Dispose();
            }
        }
        //protected void ExecuteStoredProceduce(string commandText)
        //{
        //    using (_sqlConnection = new SqlConnection(_connString))
        //    {
        //        SqlCommand command = new SqlCommand { CommandType = CommandType.StoredProcedure, CommandText = commandText, Connection = _sqlConnection };
        //        _sqlConnection.Open();
        //        command.ExecuteNonQuery();
        //        Dispose();

        //    }
        //}
        protected abstract T GetEntity<T>(SqlDataReader dataReader) where T : class; 


        public void Dispose()
        {
            if (_sqlConnection != null)
            {
                _sqlConnection.Close();
                _sqlConnection.Dispose();
            }
        }
    
    }
}