using System;

namespace Points2D3D
{
    //use this as extra practice
    public class Program
    {
        public static void Main(String[] args)
        {
            Point2D p1 = new Point2D();
            Point2D p2 = new Point2D(7, 5);
            Point2D p3 = new Point2D(-2, 4);
            Point2D p4 = new Point2D(7, 5);

            Console.WriteLine("p1 = {0}", p1);
            Console.WriteLine("p2 = {0}", p2);
            Console.WriteLine("p3 = {0}", p3);
            Console.WriteLine("p4 = {0}", p4);

            Console.WriteLine("p2 == p3? {0}", p2 == p3);
            Console.WriteLine("p2.Equals(p3)? {0}", p2.Equals(p3));
            Console.WriteLine("p2 == p4? {0}", p2 == p4);
            Console.WriteLine("p2.Equals(p4)? {0}", p2.Equals(p4));

            Console.WriteLine("========");

            Point3D p5 = new Point3D();
            Point3D p6 = new Point3D(7, 5, 12);
            Point3D p7 = new Point3D(-2, 4, -4);
            Point3D p8 = new Point3D(7, 5, 12);

            Console.WriteLine("p5 = {0}", p5);
            Console.WriteLine("p6 = {0}", p6);
            Console.WriteLine("p7 = {0}", p7);
            Console.WriteLine("p8 = {0}", p8);

            Console.WriteLine("p6 == p7? {0}", p6 == p7);
            Console.WriteLine("p6.Equals(p7)? {0}", p6.Equals(p7));
            Console.WriteLine("p6 == p8? {0}", p6 == p8);
            Console.WriteLine("p6.Equals(p8)? {0}", p6.Equals(p8));

            Console.WriteLine("========");
        }
    }

    public class Point2D
    {
        public int X { get; set; }
        public int Y { get; set; }  

        public Point2D()
        {
            // your code here
            X = 0;
            Y = 0;
        }


        public Point2D(int x, int y)
        {
            // your code here
            X = x;
            Y = y;
        }

        // your code here
        public override string ToString()
        {
            return $"({X} , {Y})";
        }

        public override bool Equals(object o)
        {
            return ;
        }

    }

    public class Point3D : Point2D
    {
        public Point3D()
        {
            // your code here
        }
        public Point3D(int x, int y, int z) : base(x, y)
        {
            // your code here
        }

        // your code here
    }

}
