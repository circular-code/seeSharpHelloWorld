using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        //[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Unicode)]
        //[return: MarshalAs(UnmanagedType.U4)]
        //private static extern uint MessageBoxTimeout(IntPtr hwnd, [MarshalAs(UnmanagedType.LPWStr)] string text, [MarshalAs(UnmanagedType.LPWStr)] string title, [MarshalAs(UnmanagedType.U4)] uint type, Int16 wLanguageId, Int32 milliseconds);

        //static void Main(string[] args)
        //{
        //    try
        //    {
        //        Temperatur a = new Temperatur(5);
        //        Temperatur b = new Temperatur(6);

        //        Temperatur c = a + 8;

        //        Console.WriteLine(c["Steph"]);

        //        MessageBoxTimeout(IntPtr.Zero, "Hello.", "Haha", 0, 0, 10000);
        //    }
        //    catch (Exception e)
        //    {
        //        Console.WriteLine($"Whoops. Fehler passier: {e.Message}.");
        //    }
        //}

        static void Main(string[] args)
        {
            Console.WriteLine("CLASS STUFF");


            var car1 = new Car();
            Console.WriteLine(car1.Color);
            car1.Honk();

            var car2 = new Car("Purple");
            Console.WriteLine(car2.Color);

            var car3 = new Car();
            car3.Paint();
            car3.LowerPrice(1);
            Console.WriteLine(car3.Color);
            Console.WriteLine(car3.Price);
            Console.WriteLine(car3.Brand);

            Console.WriteLine(car3);

            Console.WriteLine("STRUCT STUFF");

            Book book1 = new Book();
            Book book2 = new Book("red");

            Console.WriteLine(book1.Color);
            Console.WriteLine(book2.Color);

            Book book3;
            Book book4;

            book4.Color = "purple";

            //geht nicht
            //Console.WriteLine(book3.Color);
            Console.WriteLine(book4.Color);

            short i = 50;
            Console.WriteLine(i);

            Console.WriteLine("Beliebige Taste drücken um das Programm zu beenden.");
            Console.ReadKey();
        }
    }
}
