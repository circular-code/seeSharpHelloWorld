using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public struct Book
    {
        public string Color;

       // geht nicht
        //public Book()
        //{
        //    Color = "red";
        //}

        public Book(string paint)
        {
            Color = paint;
        }

        // geht nicht
        //~Book()
        //{
        //    Console.WriteLine("Goodbye");
        //}
    }

    public class Car
    {
        public int Price;
        public string Color;
        public string Brand;

        public void Honk()
        {
            Console.WriteLine("Tuut tuut i bims 1 Matze");
        }

        public Car()
        {
            Color = "red";
            Price = 12;
        }

        public Car(string color)
        {
            Color = color;
            Price = 12;
        }

        public void Paint()
        {
            Color = "blue";
        }

        public void LowerPrice(int price)
        {
            Price -= price;
        }

        public override string ToString()
        {
            return Color;
        }

        ~Car()
        {
            Console.WriteLine("Goodbye");
        }
    }
}
