using System;

namespace T03_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int A = 4;
            int B = 23;
            int C = 12;
            int D = 44;
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine(D);
            B = C;
            C = A;
            A = D;
            D = B;
            Console.WriteLine(A);
            Console.WriteLine(B);
            Console.WriteLine(C);
            Console.WriteLine(D);

            Console.ReadKey();
        }
    }
}
