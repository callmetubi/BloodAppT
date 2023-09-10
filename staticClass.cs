using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BloodApp
{
    public static class staticClass
    {
        public static void İmageF(string sourceFile, string destinationFile)
        {
            try
            {
                File.Copy(sourceFile, destinationFile, true);//copying the selected file from a specific location to a different location
            }
            catch (IOException iox)
            {
                MessageBox.Show(iox.Message);
            }
        }
    }
}
