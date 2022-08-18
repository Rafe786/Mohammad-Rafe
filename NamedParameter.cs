using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgranToUpload
{
    class NamedParameter
    {
        static void Display(int empNo, string empName, double empSal)
        {
             Console.WriteLine(empNo);
            Console.WriteLine(empName);
            Console.WriteLine(empSal);
         }
        static void Main32()
        {
            Display(empSal:21056.36,empNo:21,empName:"Rafe");
            Console.ReadLine();
        }
    }
}
