using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;

namespace Quantum.QShor
{
    class Driver
    {
        static long gcd(long x, long y)
        {
            if (x == 0) return y;
            if (y == 0) return x;
            return gcd(y, x % y);
        }

        static long qpow(long x, long y, long p)
        {
            if (y == 0) return 1;
            if (y == 1) return x % p;
            long t = qpow(x, y >> 1, p);
            if ((y & 1) == 1) return t * t % p * x % p;
            else return t * t % p;
        }

        static long findOrder(long x, long y)
        {
            long s = 1;
            for(long i=1;;i++)
            {
                s = s * x % y;
                if (s == 1) return i;
            }
        }

        static long QfindOrder(long x, long y)
        {
            return 1;
        }

        static long factorize(long N)
        {
            System.Random ran = new System.Random();

            while (true)
            {
                long a = ran.Next((int)(N - 3)) + 2;
                long g = gcd(a, N);
                if (g > 1) continue;
                long r = findOrder(a, N);
                if ((r & 1) == 1) continue;
                long y = (qpow(a, r / 2, N) + 1) % N;
                if (y == 0) continue;
                return gcd(y, N);
            }
        }
            
            static long Qfactorize(long N)
            {
                System.Random ran = new System.Random();

                while (true)
                {
                    long a = ran.Next((int)(N - 3)) + 2;
                    long g = gcd(a, N);
                    if (g > 1) continue;
                    long r = QfindOrder(a, N);
                    if ((r & 1) == 1) continue;
                    long y = (qpow(a, r / 2, N) + 1) % N;
                    if (y == 0) continue;
                    return gcd(y, N);
                }
            }

            static void Main(string[] args)
		    {
                System.Console.WriteLine($"Please input an odd number ...");
                long N = System.Convert.ToInt64(System.Console.ReadLine());
                long p = factorize(N);
                System.Console.WriteLine($"{N} = {p} * {N / p}");
                System.Console.WriteLine($"Press any key to exit...");
                System.Console.ReadKey();
		    }
	}
}