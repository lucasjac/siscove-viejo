using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace SISCOVE___Todo_Envase
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                DatabaseCreation newDatabaseCreation = new DatabaseCreation();
                CreateDatabaseAccess newDatabase = new CreateDatabaseAccess();
                DataTable newDataTable = new DataTable();

                Thread newThread = new Thread(new ThreadStart(newFormSplash));
                newThread.Start();
                newDataTable = newDatabase.CheckDatabase();

                Thread.Sleep(5700);

                if (newDataTable.Rows.Count <= 0)
                {
                    newDatabaseCreation.MakeDatabase();
                    newDatabase.CreatePassword();
                }
                newThread.Abort();

                FormLogin newFormLogin = new FormLogin();
                newFormLogin.ShowDialog();

                if (newFormLogin.DialogResult == DialogResult.OK)
                {
                    Application.Run(new FormPrincipal());
                }
                else
                {
                    Application.Exit();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        static void newFormSplash()
        {
            Application.Run(new FormSplash());
        }
    }
}
