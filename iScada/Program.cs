using System;
using System.Diagnostics;
using System.Windows.Forms;
using System.Xml;

namespace iScada
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            try
            {
                // System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile)
                // load config file using xmldocument
                XmlDocument xmlDoc = new XmlDocument();

                // load from iScada.config situated where app.config should be
                xmlDoc.Load(System.IO.Path.GetDirectoryName(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile) + "\\iScada.config");
                
                // traverse to the path
                XmlNode node = xmlDoc.SelectSingleNode("configuration/userSettings/iScada.Properties.Settings/setting[@name='cnStr']/value");

                if (node != null)
                {
                    string str = node.InnerText;
                    if (str != String.Empty)
                    {
                        // connection string exist, store it in global variable and load main form


                        //string will be of following format
                        //server= localhost;port= 3306;userid= root;password= root;persistsecurityinfo=True;database=iscada;allowuservariables=True
                        //break all individual part and decrypt password and recreate the string
                        
                        string[] conn = str.Split(';');

                        string server= conn[0].Substring(7, conn[0].Length - 7).Trim();
                        string port = conn[1].Substring(5, conn[1].Length - 5).Trim();
                        string userId= conn[2].Substring(7, conn[2].Length - 7).Trim();
                        string password= conn[3].Substring(9, conn[3].Length - 9).Trim();

                        password = Encription.Decrypt(password);

                        str = "server= " + server + ";" +
                                "port= " + port+ ";" +
                                "userid= " + userId+ ";" +
                                "password= " + password+ ";" +
                                "persistsecurityinfo=True;database=iscada;allowuservariables=True";

                        //store to global variable
                        Globals.ConnectionString = str;
                        Application.Run(new frmMain());
                    }
                    else
                    {
                        // connection string does not exist, load config form
                        frmConnStr f = new frmConnStr();
                        Application.Run(f);
                        if (f.Result)
                            Application.Run(new frmMain());
                        else
                            Application.Exit();
                    }
                }
                else
                {
                    MessageBox.Show("Critical error: Configuration file missing.", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Application.Exit();
                }

            }
            catch (System.IO.FileNotFoundException e)
            {
                int line = (new StackTrace(e, true)).GetFrame(0).GetFileLineNumber();
                MessageBox.Show("Critical error: Configuration file missing. " + line.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Application.Exit();
            }
        }
    }
}