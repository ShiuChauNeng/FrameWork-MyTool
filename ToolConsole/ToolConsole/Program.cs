using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            stopwatch.Stop();
            Console.Read();
        }
    }
}
