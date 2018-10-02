using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace WebTest
{
    public enum EnumConnectionStringsKey
    {
        WebTestConnection
    }
}

namespace WebTest.Models
{
    public class _BaseModel
    {
        #region - Property -
        string _connectionStringWebTest;
        protected string ConnectionStringWebTest { get { return _connectionStringWebTest; } set { _connectionStringWebTest = value; } }
        #endregion

        public _BaseModel()
        {
            try
            {
                _connectionStringWebTest = ConfigurationManager.ConnectionStrings[EnumConnectionStringsKey.WebTestConnection.ToString()].ConnectionString;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}