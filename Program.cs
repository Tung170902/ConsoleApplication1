using System;

namespace ConsoleApplication1
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello world");
            Console.WriteLine("Nhập vào 1 chuỗi: ");
            string s = Console.ReadLine();
            Console.WriteLine("s= " + s);
            Console.WriteLine("Nhập vào 1 số nguyên: ");
            int a;
            try
            {
                a = Convert.ToInt32(Console.ReadLine());
            }
            catch (Exception e)
            {
                a = 0;
            }

            Console.WriteLine("Số vừa nhập: " + a);
            if (CheckPrime(a))
            {
                Console.WriteLine(a + "là số nguyên tố");
            }
            else
            {
                Console.WriteLine(a + "không phải số nguyên tố");
            }
            
        }
        
        public static bool CheckPrime(int n)
        {
            if (n < 2) return false;
            if (n < 4) return true;
            for (int i = 2; i <= n; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

        
    }
}