namespace homework6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int s=Area(5,3,4,1);
            Console.WriteLine(s);
        }
        public static int Area (int r)
        {
            int p = 3;
            int s = p * r * r;
            return s;
        }
        public static int Area(int a, int b)
        {
            int s = a * b;
            return s;
        }
        public static int Area(int a, int b, int c)
        {
            int s = 2 * (a * b + a * c + b * c);
            return s;
        }
        public static int Area(int a, int b, int c, int r)
        {
            int p = (a + b + c) / 2;
            int s= p * r;
            return s;
        }
    }
}
