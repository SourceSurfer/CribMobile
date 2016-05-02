using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ErrorWriteLog;
using Java.Util.Concurrent.Atomic;
using Mono.Data.Sqlite;
using SQLite;

namespace CribMobile
{
    internal enum Lang
    {
        Russian = 1,
        English = 2
    }

    internal class KeyWrd
    {
      //  private DataSet dataSet;
       // internal Button[] btnCategory;
        //  private readonly SqlCom _sqlCom = new SqlCom();

        /*  private class SqlCom
          {
              protected internal readonly string selCAT =
                  " SELECT * FROM tblKWÑATEGORY WHERE LANGID = 1  ;  SELECT * FROM tblKWÑATEGORY WHERE LANGID = 2 ; ";

              protected internal readonly string selSUBCAT =
                  "select KEYWRDSUBCATID , NAMESUBCAT FROM tblKWSUBCATEGORY WHERE KEYWRDCATID = {0} ";

              protected internal readonly string selKeyWordfrnCat =
                  "select KEYWRDID , WORD FROM tblKEYWORDS where tblKEYWORDS.KEYWRDCATID = {0} ";

              protected internal readonly string InsertCat =
                  " INSERT INTO tblKWÑATEGORY ( LANGID , NAMECAT) VALUES( @LANGID , @NAMECAT ) ";

              protected internal readonly string InsertSubCat =
                  "INSERT INTO tblKWSUBCATEGORY ( LANGID , KEYWRDCATID,  NAMESUBCAT ) VALUES ( @LANGID , @KEYWRDCATID , @NAMESUBCAT )";

              protected internal readonly string InsertLang =
                  " INSERT INTO tblLANGUAGE ( LANGUAGE ) VALUES ( @LANGUAGE )  ";

              protected internal readonly string selCategory =
                  " select KEYWRDCATID , NAMECAT from tblKWÑATEGORY WHERE LANGID = {0} ";

              protected internal readonly string selKeyWordfrmSubCat =
                  "select WORD , KEYWRDID FROM tblKEYWORDS where tblKEYWORDS.KEYWRDSUBCATID = {0} ";


              protected internal readonly string selDescriptKeyWrd =
                  " select KEYWRDESCRIPTION FROM tblKEYWORDS where tblKEYWORDS.KEYWRDID = {0} ";

              protected internal readonly string delTblCategory =
                  "Delete from tblKWÑATEGORY";

              protected internal readonly string InsertKEYWORDS =
                  "INSERT INTO tblKEYWORDS ( KEYWRDCATID, KEYWRDSUBCATID, WORD, KEYWRDESCRIPTION ) VALUES ( @KEYWRDCATID, @KEYWRDSUBCATID ,@WORD, @KEYWRDESCRIPTION) ";
          }*/

       
      /*  internal void FillCat()
        {
            var canEng = new string[11]
            {
                "Types", "Modifiers", "Statement Keywords", "Method Parameters", "Namespace Keywords",
                "Operator Keywords", "Conversion Keywords",
                "Access Keywords", "Literal Keywords", "Contextual Keywords", "Query Keywords(LINQ)"
            };
            ClearDB(_sqlCom.delTblCategory);
            for (var i = 0; i < canEng.Length; i++)
            {
                using (var con = new SqliteConnection((DataBase.connectionString)))
                {
                    con.Open();
                    using (var _cmd = con.CreateCommand())
                    {
                        try
                        {
                            _cmd.CommandText = _sqlCom.InsertCat;
                            _cmd.CommandType = CommandType.Text;
                            _cmd.Parameters.Add("@LANGID", DbType.Int16);
                            _cmd.Parameters.Add("@NAMECAT", DbType.String);

                            _cmd.Parameters["@NAMECAT"].Value = canEng[i];
                            _cmd.Parameters["@LANGID"].Value = 1;

                            _cmd.ExecuteNonQuery();

                        }
                        catch (SQLiteException ex)
                        {
                            ErrorWriter.WriteToLog(ex.Message + " " + ex.Data + " " + DateTime.Now);
                        }
                        finally
                        {
                            con.Close();
                        }
                    }
                }
            }
        }*/


       /* private DataSet GetDataSet(string _CommandTex)
        {
            using (var con = new SqliteConnection((DataBase.connectionString)))
            {
                con.Open();
                using (var _cmd = con.CreateCommand())
                {
                    try
                    {
                        _cmd.CommandText = _CommandTex;
                        _cmd.CommandType = CommandType.Text;
                        var _adapter = new SqliteDataAdapter(_cmd);
                        dataSet = new DataSet();
                        _adapter.Fill(dataSet);
                        return dataSet;
                    }
                    catch (SQLiteException ex)
                    {
                       ErrorWriter.WriteToLog(ex.Message);
                    }
                    return dataSet;
                }
            }
        }*/


     /*   internal void FillbtnCat(Lang lang)
        {
             switch (lang)
             {
                 case Lang.Russian:
                     dataSet = GetDataSet(string.Format(_sqlCom.selCategory, 1));
                     break;

                 case Lang.English:
                    dataSet = GetDataSet(string.Format(_sqlCom.selCategory, 2));
                    break;
             }

             for (int i = 0; dataSet.Tables[0].Rows.Count > i; i++)
             {
                btnCategory[i].Text = dataSet.Tables[0].Rows[i][1].ToString();
             }
        }*/
    
       


        /*  private void ClearDB(string _CommandTex)
          {
              using (var con = new SqliteConnection((DataBase.connectionString)))
              {
                  con.Open();
                  using (var _cmd = con.CreateCommand())
                  {
                      try
                      {
                          _cmd.CommandText = _CommandTex;
                          _cmd.CommandType = CommandType.Text;
                          _cmd.ExecuteNonQuery();

                      }
                      catch (SQLiteException ex)
                      {
                          ErrorWriter.WriteToLog(ex.Message);
                      }
                  }
              }
          }*/
    }

}

    
