using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace SISCOVE___Todo_Envase
{
    public class DatabaseCreation
    {
        public void MakeDatabase()
        {
            try
            {
                string PathScriptDatabase = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resources\ScriptSISCOVEdatabase.sql";

                FileInfo FileDatabase = new FileInfo(PathScriptDatabase);
                string ConfiguredScriptDatabase = FileDatabase.OpenText().ReadToEnd().Replace("GO", "");

                string PathScriptTables = Path.GetDirectoryName(System.Reflection.Assembly.GetExecutingAssembly().Location) + @"\Resources\ScriptSISCOVEtable.sql";

                FileInfo FileTables = new FileInfo(PathScriptTables);
                string ConfiguredScriptTables = FileTables.OpenText().ReadToEnd().Replace("GO", "");

                CreateDatabaseAccess newDatabase = new CreateDatabaseAccess();
                newDatabase.CreateDatabase(ConfiguredScriptDatabase, ConfiguredScriptTables);
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }
        }
    }
}
