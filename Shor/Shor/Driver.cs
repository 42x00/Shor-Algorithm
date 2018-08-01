using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.Simulation.Simulators;
using System;

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

        class fraction
        {
            long nume, deno;
            public fraction()
            {
                this.nume = 0;
                this.deno = 1;
            }
            public fraction(long nume, long deno)
            {
                this.nume = nume;
                this.deno = deno;
            }
            public void reduce()
            {
                long g = gcd(this.nume, this.deno);
                this.nume /= g;
                this.deno /= g;
            }
            static public fraction operator+(fraction a, fraction b)
            {
                fraction res = new fraction();
                res.deno = a.deno * b.deno;
                res.nume = a.nume * b.deno + b.nume * a.deno;
                res.reduce();
                return res;
            }
        }

        static bool isSquare(long x)
        {
            long s = (long)Math.Sqrt(x);
            return s * s == x;
        }

        static void CFE(long n)
        {
            long[] P = new long[10000001], Q = new long[10000001], a = new long[10000001], p = new long[10000001];
            P[0] = 0;
            Q[0] = 1;
            a[0] = (long)Math.Floor(Math.Sqrt(n));
            p[0] = a[0];
            for (int i = 1; i <= 10000000; i++)
            {
                P[i] = a[i - 1] * Q[i - 1] - P[i - 1];
                Q[i] = (n - P[i] * P[i]) / Q[i - 1];
                a[i] = (long)Math.Floor((P[i] + Math.Sqrt(n)) * 1.0 / Q[i]);
                if (i == 1) p[i] = a[i] * p[i - 1] % n;
                else p[i] = (a[i] * p[i - 1] + p[i - 2]) % n;
                if ((i & 1) == 0 && isSquare(Q[i]))
                {
                    long s = (long)Math.Sqrt(Q[i]);
                    long p1 = gcd(p[i - 1] - s, n), p2 = gcd(p[i - 1] + s, n);
                    if (p1 != 1 && p2 != 1)
                    {
                        Console.WriteLine($"{n} = {p1} * {p2}");
                        return;
                    }
                    // Console.WriteLine($"{P[i]} {Q[i]} {a[i]} {p[i]}");
                }
            }
        }

        static long Qfactorize(long N)
        {
            Random ran = new Random();

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

        static void Main(string[] args)
		{
            Console.WriteLine($"Please input an odd number ...");
            long N = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine($"Fatorizing using Continued Fraction Expansion ...");
            CFE(N);
            Console.WriteLine($"Fatorizing using Shor Quantum Algorithm ...");
            long p = Qfactorize(N);
            Console.WriteLine($"{N} = {p} * {N / p}");
            Console.WriteLine($"Press any key to exit ...");
            Console.ReadKey();
		}
	}
}