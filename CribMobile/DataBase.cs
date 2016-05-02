using System.IO;
using Android.Database.Sqlite;
using Mono.Data.Sqlite;
using ErrorWriteLog;
using SQLite;
using System;
using System.Data;

namespace CribMobile
{

    //Íà áóäóùåå
    internal  class DataBase
    {

        private static readonly string connectFolder = System.Environment.GetFolderPath(System.Environment.SpecialFolder.MyDocuments);
        private static readonly string pathToDataBase = Path.Combine(connectFolder, "CribDB.db");
        internal static string connectionString = string.Format("Data Source={0};Version=3;", pathToDataBase);
        public SQLiteConnection Con;
        private  readonly SqlCommand Sqlcom = new SqlCommand();

        private class SqlCommand
        {
            #region Container

            
          

            protected internal readonly string createTblKeyWords =
                 "CREATE TABLE tblKEYWORDS( 'KEYWRDID' INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, " +
                " 'KEYWRDCATID' INTEGER NOT NULL , 'KEYWRDSUBCATID' INTEGER , 'WORD' varchar(50) NOT NULL, 'KEYWRDESCRIPTION' varchar(250) NULL)";


            protected internal readonly string createTblKWÑATEGORY =
              "CREATE TABLE tblKWÑATEGORY( 'KEYWRDCATID' INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL , 'LANGID' INTEGER NOT NULL , 'NAMECAT' varchar(50) NOT NULL )";

            protected internal readonly string createTblKWSUBCATEGORY =
                "CREATE TABLE tblKWSUBCATEGORY( 'KEYWRDSUBCATID' INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL , " +
                " 'KEYWRDCATID' INTEGER , 'LANGID' INTEGER NOT NULL , 'NAMESUBCAT' varchar(50) NOT NULL)";

            protected internal readonly string createTblLanguage =
                 "CREATE TABLE tblLANGUAGE('LONGUAGEID' INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL , 'LANGUAGE' varchar(10) NOT NULL)";

            protected internal readonly string ClearDB = " delete from tblPROPERTY; delete from tblCLASS ";

            protected internal readonly string SelectDG =
                "select propname as ÈìÿÏàðàìåòðà , propdescription as Îïèñàíèå, PROPEXAMPLE as Ïðèìåð from tblPROPERTY ";


            #endregion
        }

        internal  void CreateDB()
        {
            try
            {
                if (!File.Exists(pathToDataBase))
                {
                    
                    SqliteConnection.CreateFile(pathToDataBase);
                    Con = new SQLiteConnection($"Data Source = {pathToDataBase} ;");
                    CreateTable();
                  
                }
                else
                {
                   // Con = new SQLiteConnection($"Data Source={pathToDataBase}");
                    CreateTable();
                }
            }
            catch (SQLite.SQLiteException ex)
            {
                
                ErrorWriter.WriteToLog(ex.Message + " " + ex.Data + " " + DateTime.Now);
            }

           
        }

        private  void CreateTable()
        {
            #region CreateTable

            try
            {
                using (var Con = new SqliteConnection(connectionString))
                {
                    Con.Open();
                    using (var cmd = Con.CreateCommand())
                    {
                        cmd.CommandText = Sqlcom.createTblKeyWords;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = Con.CreateCommand())
                    {
                        cmd.CommandText = Sqlcom.createTblKWÑATEGORY;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }

                    using (var cmd = Con.CreateCommand())
                    {
                        cmd.CommandText = Sqlcom.createTblKWSUBCATEGORY;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                    using (var cmd = Con.CreateCommand())
                    {
                        cmd.CommandText = Sqlcom.createTblLanguage;
                        cmd.CommandType = CommandType.Text;
                        cmd.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
               ErrorWriter.WriteToLog(ex.Message + " " + ex.Data + " " + DateTime.Now);
            }

            #endregion
        }
    }
}
