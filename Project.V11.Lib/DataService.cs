using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project.V11.Lib
{
    public class DataService
    {
        public int len = 0;
        public double[] LoadFromDataFile(string path)
        {

            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    len++;
                }
            }

            double[] numsArray = new double[len];

            int index = 0;
            using (StreamReader reader = new StreamReader(path))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    numsArray[index] = Convert.ToDouble(line);
                    index++;
                }
            }

            

            return numsArray;
        }
    }
}
