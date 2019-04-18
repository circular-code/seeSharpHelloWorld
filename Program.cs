using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
        //    uint a = 3;
        //    a *= a += ++a + a++;

        //    Console.WriteLine(a);
        //    Console.ReadKey();
        //}

        String[] values = { "160519", "   -322   ", "+4302", "430243024", "(100)" };

                foreach (var value in values)
                {

                    int count = 0;
                    int successCount = 0;

                    Console.WriteLine("TryParse " + value);

                    Stopwatch stopWatch = new Stopwatch();
                    stopWatch.Start();

                    while (count< 10000000)
                    {
                        count++;

                        bool success = Int32.TryParse(value, out int number);

                        if (success)
                        {
                            successCount++;
                        }
                    }

                    Console.WriteLine("Successfull Parses " + successCount);

                    stopWatch.Stop();
                    // Get the elapsed time as a TimeSpan value.
                    TimeSpan ts = stopWatch.Elapsed;

                    // Format and display the TimeSpan value.
                    string elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                        ts.Hours, ts.Minutes, ts.Seconds,
                        ts.Milliseconds / 10);
                    Console.WriteLine("RunTime " + elapsedTime + "\n");

                    count = 0;
                    successCount = 0;

                    Console.WriteLine("Parse " + value);

                    stopWatch = new Stopwatch();
                    stopWatch.Start();

                    while (count< 10000000)
                    {
                        count++;

                        try
                        {
                            int number = Int32.Parse(value);
                            successCount++;
                        }
                        catch
                        {
                            successCount--;
                        }

                    }

                    Console.WriteLine("Successfull Parses " + successCount);

                    stopWatch.Stop();
                    // Get the elapsed time as a TimeSpan value.
                    ts = stopWatch.Elapsed;

                    // Format and display the TimeSpan value.
                    elapsedTime = String.Format("{0:00}:{1:00}:{2:00}.{3:00}",
                    ts.Hours, ts.Minutes, ts.Seconds,
                    ts.Milliseconds / 10);
                    Console.WriteLine("RunTime " + elapsedTime + "\n");

                }

                Console.WriteLine("Press any key to exit.");
                Console.ReadKey();
            }
        }
    }
