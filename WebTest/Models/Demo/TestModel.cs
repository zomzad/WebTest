using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebTest.Models.Demo
{
    public class TestModel : DemoModel
    {
        #region MyRegion

        #endregion

        #region - 基本SQL語法執行 -
        /// <summary>
        /// 基本SQL語法執行
        /// </summary>
        public void BasicSQLCommExec()
        {
            try
            {
                //#region SELECT語法
                //var data = new DataTable();
                //var commandText = new StringBuilder(string.Join(Environment.NewLine, new object[]
                //{
                //    "SELECT * FROM UserInfo;"
                //}));

                //using (SqlConnection connection = new SqlConnection(ConnectionStringWebTest))
                //{
                //    using (SqlCommand cmd = new SqlCommand(commandText.ToString(), connection))
                //    {
                //        connection.Open();
                //        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                //        adapter.Fill(data);
                //    }
                //}

                //var name = data.Rows[0]["name"]; //Hsien

                //List<string> nameList = (from DataRow dr in data.Rows
                //                         select dr.Field<string>("name")).ToList(); // {Hsien, Hana}
                //#endregion

                //#region - UPADTE語法 -
                //string commandUpdateText = string.Join(Environment.NewLine,
                //    "UPDATE UserInfo",
                //    "   SET name = @newNM",
                //    " WHERE id = 1");

                //using (SqlConnection con = new SqlConnection(ConnectionStringWebTest))
                //{
                //    using (SqlCommand cmd = new SqlCommand(commandUpdateText, con))
                //    {
                //        con.Open();
                //        cmd.Parameters.AddWithValue("@newNM", "Hsein2");
                //        var updateResult = cmd.ExecuteNonQuery(); //會回傳受影響的列數
                //    }
                //}
                //#endregion

                //#region - INSERT語法 -
                //string commandInsertText = string.Join(Environment.NewLine,
                //    "INSERT INTO UserInfo (id,name) VALUES('3','ABC')");

                //using (SqlConnection con = new SqlConnection(ConnectionStringWebTest))
                //{
                //    using (SqlCommand cmd = new SqlCommand(commandInsertText, con))
                //    {
                //        con.Open();
                //        var oo = cmd.ExecuteNonQuery();
                //    }
                //}
                //#endregion
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
        #endregion
    }
}