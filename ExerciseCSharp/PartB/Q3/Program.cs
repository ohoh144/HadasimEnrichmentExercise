using System;
using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
namespace Q3
{
    class Program
    {
        static void ProcessNumbers()
        {
            List <double> numbers = new List <double> ();
            double sum = 0;
            int count = 0, positives = 0;
            double input = double.Parse(Console.ReadLine());
            while (input != -1)
            {
                sum += input;
                count++;
                if (input > 0)
                    positives++;
                int pos = 0;
                while (pos < numbers.Count && numbers[pos] < input)
                    pos++;
                numbers.Insert(pos, input);
                input = double.Parse(Console.ReadLine());
            }
            if (count == 0) return;
            Console.WriteLine("Average: " + (sum / count));
            Console.WriteLine("Positive count: " + positives);
            Console.WriteLine("Sorted numbers: " + string.Join(" ", numbers));
        }
        static void Main(string[] args)
        {
            ProcessNumbers();
            Console.ReadLine(); //Keep console window open to view the result
        }

    }
}
