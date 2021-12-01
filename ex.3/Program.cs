using System;

namespace task3
{
    using System;

    class Rectangle
    {
        private int width;
        private int height;
        public int Width { get => width; set => width = value; }
        public int Height { get => height; set => height = value; }
        public int GetRectangleArea()
        {
            return Width * Height;
        }
    }

    //квадрат наслідується від прямокутника!!!
    class Square : Rectangle
    {
        private int side;
        public new int Width { get => side; set => side = value; }
        public new int Height { get => side; set => side = value; }
        public new int GetRectangleArea()
        {
            return side * side;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rect = new Square();
            rect.Width = 5;
            rect.Height = 10; 
            Console.WriteLine(rect.GetRectangleArea());

            Console.ReadKey();
        }
    }
}
