using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace FinalProject
{
    class Logger
    {
        static string folderName = "Logs";
        static Logger()
        {
            if (!Directory.Exists(folderName))
                Directory.CreateDirectory(folderName);
        }

        internal static void SaveLog(Exception ex)
        {

            string fileName = DateTime.Now.ToString("yyyy.MM.dd") + ".txt";
            string filePath = Path.Combine(folderName, fileName);


            using (StreamWriter sw = new StreamWriter(filePath, true))
                sw.WriteLine(ex.Message);
        }
    }
}
