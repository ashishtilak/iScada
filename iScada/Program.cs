using System;
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

            // load config file using xml
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.Load(AppDomain.CurrentDomain.SetupInformation.ConfigurationFile);
            XmlNode node = xmlDoc.SelectSingleNode("configuration/userSettings/iScada.Properties.Settings/setting[@name='testSetting']/value");

            string str = node.InnerText;
            if (str != String.Empty)
            {
                // connection string exist, load main form
                Application.Run(new frmTry());
            }
            else
            {
                // connection string does not exist, load config form
                Application.Run(new frmConnStr());
                Application.Run(new frmTry());
            }
        }
    }
}