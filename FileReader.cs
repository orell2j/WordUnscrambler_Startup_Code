using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WordUnscrambler
{
    class FileReader
    {
        public string[] Read(string filename)
        {
            // Your Code here!
            try
            {
                content = File.ReadAllLines(filename);

            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return content;
        }
    }
}
