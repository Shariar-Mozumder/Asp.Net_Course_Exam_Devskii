using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    public class FrequencyCounter
    {
        public string Count(string text)
        {
            
            string outputstr="";
            string outputstr1="";
            string str = text.ToLower();
             while(str.Length > 0)
             {
              outputstr = str[0] + "-";
              int cal=0;
              for(int j=0; j<str.Length; j++)
              {
                 if (str[0] == str[j])
                 {
                    cal++;
                }
              }
               outputstr = outputstr + cal + ",";
              str = str.Replace(str[0].ToString(), string.Empty);

             outputstr1 = outputstr1 + outputstr;


              }

             string result = outputstr1.Substring(0, outputstr1.Length - 1);

             //Console.Write(outputstr1);
            return result;
        }
    }
}
