using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection.Metadata;

namespace ReviewOfInheritance
{

    interface IDrawable
    {
        void Draw();
        string Color { get; set; }

        int NumOfEdges { get; set; }
    }

    class Square : IDrawable
    {
        public string Color { get; set; }
        public int NumOfEdges { get; set; }

        public void Draw()
        {
            Console.WriteLine("Square");
        }

        public Square(string Color, int NumOfEdges)
        {
            this.Color = Color;
            this.NumOfEdges = NumOfEdges;
        }
    }

    class Circle : IDrawable
    {
        public string Color { get; set; }
        public int NumOfEdges { get; set; }

        public void Draw()
        {
            Console.WriteLine("Ciricle");
        }

        public Circle(string Color, int NumOfEdges)
        {
            this.Color = Color;
            this.NumOfEdges = NumOfEdges;
        }
    }

    class Triangle : IDrawable
    {

        public string Color { get; set; }
        public int NumOfEdges { get; set; }

        public void Draw()
        {
            Console.WriteLine("Triangle");
        }

        public Triangle(string Color, int NumOfEdges)
        {
            this.Color = Color;
            this.NumOfEdges = NumOfEdges;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            //Create 3 different car classes, Each with a name of a car brand (ie. Porsche) that inherits from ICar
            //IEngine, IWheels, IChasis -->ICar inherits from each one
            //IEngine --> Run function (print out the car engine type)
            //IWheels --> Wheel size, Color
            //IChasis --> Color, size



            //List of ICars and have one from each class
            //loop list and print out everything



            //Create an IDrawable interface
            //void Draw
            //Color
            //num of edges

            //Class for Square, Circle and Triangle


            //List of IDrawables
            //Circle, Square and Triangle in the list

            List<IDrawable> drawables = new List<IDrawable>();

            drawables.Add(new Triangle("red", 3));
            drawables.Add(new Circle("Orange", 0));
            drawables.Add(new Square("Purple", 4));
            //foreach(type name in listname//arrayname)
            foreach (var item in drawables)
            {
                item.Draw();
                Console.WriteLine($"{item.Color}");
                Console.WriteLine($"{item.NumOfEdges}");

            }

        }
    }
}
