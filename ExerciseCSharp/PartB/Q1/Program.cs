using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        static int GetNumLength(int num)
        {
            return (int)Math.Log10(num) + 1;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(GetNumLength(85258));
            //Console.ReadLine(); //for seeing thr result so the consol won't shot down
        }
         
    }
}
