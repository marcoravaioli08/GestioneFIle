using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestioneFile
{
    internal class Write
    {
        private string testo;
        StreamWriter sw;

        public class1()
        {
            sw = new StreamWriter("info.txt");
        }

        public void ScriviFile(string t)
        {
            testo = t;
            sw.WriteLine(testo);
            sw.Close();
        }
    }
}
