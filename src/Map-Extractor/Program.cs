using GeoAPI;
using NetTopologySuite;
using System;
using System.Windows.Forms;

namespace Map_Extractor
{
    internal static class Program
    {
        /// <summary>  
        /// アプリケーションのメイン エントリ ポイントです。  
        /// </summary>  
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Source());
        }
    }
}
