#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.QShor1", "Ux (x : Qubit[], a : Int, N : Int) : ()", new string[] { "Controlled" }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs", 424L, 16L, 52L)]
[assembly: OperationDeclaration("Quantum.QShor1", "myQFT (qs : Qubit[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs", 657L, 26L, 5L)]
[assembly: OperationDeclaration("Quantum.QShor1", "OrderFinding (a : Int, N : Int) : Int[]", new string[] { }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs", 2393L, 90L, 53L)]
[assembly: OperationDeclaration("Quantum.QShor1", "MyTest () : Int[]", new string[] { }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs", 3557L, 135L, 34L)]
[assembly: OperationDeclaration("Quantum.QShor1", "FindSDivideR (a : Int, N : Int) : Int[]", new string[] { }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs", 3692L, 141L, 55L)]
[assembly: OperationDeclaration("Quantum.QShor1", "TestUx () : ()", new string[] { }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs", 3800L, 147L, 29L)]
[assembly: FunctionDeclaration("Quantum.QShor1", "PowerOfTwo (k : Int) : Double", new string[] { }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs", 213L, 7L, 14L)]
[assembly: FunctionDeclaration("Quantum.QShor1", "modExp (xx : Int, kk : Int, N : Int) : Int", new string[] { }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs", 1779L, 68L, 14L)]
[assembly: FunctionDeclaration("Quantum.QShor1", "Exp2 (x : Int, k : Int) : Int", new string[] { }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs", 2169L, 82L, 14L)]
#line hidden
namespace Quantum.QShor1
{
    public class PowerOfTwo : Operation<Int64, Double>, ICallable
    {
        public PowerOfTwo(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "PowerOfTwo";
        String ICallable.FullName => "Quantum.QShor1.PowerOfTwo";
        public override Func<Int64, Double> Body => (__in) =>
        {
            var k = __in;
#line 8 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var ans = 1D;
#line 9 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            foreach (var i in new Range(0L, (k - 1L)))
            {
#line 10 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                ans = (ans * 2D);
            }

#line 12 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            return ans;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn(Int64 data) => new QTuple<Int64>(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Int64 k)
        {
            return __m__.Run<PowerOfTwo, Int64, Double>(k);
        }
    }

    public class Ux : Controllable<(QArray<Qubit>,Int64,Int64)>, ICallable
    {
        public Ux(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(QArray<Qubit>,Int64,Int64)>, IApplyData
        {
            public In((QArray<Qubit>,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item1)?.Qubits;
        }

        String ICallable.Name => "Ux";
        String ICallable.FullName => "Quantum.QShor1.Ux";
        protected IUnitary<(Int64,Int64,Microsoft.Quantum.Canon.LittleEndian)> MicrosoftQuantumCanonModularMultiplyByConstantLE
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64,Int64), QVoid> Body => (__in) =>
        {
            var (x,a,N) = __in;
#line 19 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var qs = new Microsoft.Quantum.Canon.LittleEndian(x);
#line 20 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Apply((a, N, qs));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64,Int64)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(x,a,N)) = __in;
            var qs = new Microsoft.Quantum.Canon.LittleEndian(x);
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Controlled.Apply((controlQubits, (a, N, qs)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonModularMultiplyByConstantLE = this.Factory.Get<IUnitary<(Int64,Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.ModularMultiplyByConstantLE));
        }

        public override IApplyData __dataIn((QArray<Qubit>,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> x, Int64 a, Int64 N)
        {
            return __m__.Run<Ux, (QArray<Qubit>,Int64,Int64), QVoid>((x, a, N));
        }
    }

    public class myQFT : Adjointable<QArray<Qubit>>, ICallable
    {
        public myQFT(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "myQFT";
        String ICallable.FullName => "Quantum.QShor1.myQFT";
        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<QVoid, Double> MicrosoftQuantumExtensionsMathPI
        {
            get;
            set;
        }

        protected ICallable<Int64, Double> PowerOfTwo
        {
            get;
            set;
        }

        protected IUnitary<(Double,Qubit)> MicrosoftQuantumPrimitiveR1
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveSWAP
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QVoid> Body => (__in) =>
        {
            var qs = __in;
#line 28 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var n = qs.Count;
#line 29 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var exp2 = new QArray<Double>((n + 1L));
#line 30 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var pi = MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance);
#line 31 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            foreach (var i in new Range(0L, n))
            {
#line 32 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                exp2[i] = PowerOfTwo.Apply(i);
            }

#line 34 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            foreach (var i in new Range(0L, (n - 1L)))
            {
#line 35 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[i]);
#line 36 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                foreach (var j in new Range((i + 1L), (n - 1L)))
                {
#line 37 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                    MicrosoftQuantumPrimitiveR1.Controlled.Apply((new QArray<Qubit>()
                    {qs[j]}, (((2D * pi) / exp2[((j - i) + 1L)]), qs[i])));
                }
            }

#line 40 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            foreach (var i in new Range(0L, ((n / 2L) - 1L)))
            {
#line 41 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                MicrosoftQuantumPrimitiveSWAP.Apply((qs[i], qs[((n - 1L) - i)]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var qs = __in;
#line 46 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var n = qs.Count;
#line 47 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var exp2 = new QArray<Double>((n + 1L));
#line 48 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var pi = MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance);
#line 49 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            foreach (var i in new Range(0L, n))
            {
#line 50 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                exp2[i] = PowerOfTwo.Apply(i);
            }

#line 53 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            foreach (var i in new Range(0L, ((n / 2L) - 1L)))
            {
#line 54 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                MicrosoftQuantumPrimitiveSWAP.Apply((qs[i], qs[((n - 1L) - i)]));
            }

#line 56 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            foreach (var i in new Range(0L, (n - 1L)))
            {
#line 57 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                var x = ((n - 1L) - i);
#line 58 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                foreach (var j in new Range((x + 1L), (n - 1L)))
                {
#line 59 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                    var y = ((n + x) - j);
#line 60 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                    MicrosoftQuantumPrimitiveR1.Controlled.Apply((new QArray<Qubit>()
                    {qs[y]}, (((-(2D) * pi) / exp2[((y - x) + 1L)]), qs[x])));
                }

#line 62 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                MicrosoftQuantumPrimitiveH.Apply(qs[x]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.PowerOfTwo = this.Factory.Get<ICallable<Int64, Double>>(typeof(Quantum.QShor1.PowerOfTwo));
            this.MicrosoftQuantumPrimitiveR1 = this.Factory.Get<IUnitary<(Double,Qubit)>>(typeof(Microsoft.Quantum.Primitive.R1));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qs)
        {
            return __m__.Run<myQFT, QArray<Qubit>, QVoid>(qs);
        }
    }

    public class modExp : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public modExp(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "modExp";
        String ICallable.FullName => "Quantum.QShor1.modExp";
        public override Func<(Int64,Int64,Int64), Int64> Body => (__in) =>
        {
            var (xx,kk,N) = __in;
#line 69 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var k = kk;
#line 70 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var ans = 1L;
#line 71 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var x = xx;
#line 72 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var two = 1L;
#line 73 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            foreach (var i in new Range(0L, 20L))
            {
#line 74 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                if (((k % 2L) == 1L))
                {
#line 75 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                    ans = ((ans * x) % N);
                }

#line 77 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                x = ((x * x) % N);
#line 78 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                k = (k / 2L);
            }

#line 80 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            return ans;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 xx, Int64 kk, Int64 N)
        {
            return __m__.Run<modExp, (Int64,Int64,Int64), Int64>((xx, kk, N));
        }
    }

    public class Exp2 : Operation<(Int64,Int64), Int64>, ICallable
    {
        public Exp2(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Exp2";
        String ICallable.FullName => "Quantum.QShor1.Exp2";
        public override Func<(Int64,Int64), Int64> Body => (__in) =>
        {
            var (x,k) = __in;
#line 83 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var ans = 1L;
#line 84 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            foreach (var i in new Range(0L, (k - 1L)))
            {
#line 85 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                ans = (ans * x);
            }

#line 87 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            return ans;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 x, Int64 k)
        {
            return __m__.Run<Exp2, (Int64,Int64), Int64>((x, k));
        }
    }

    public class OrderFinding : Operation<(Int64,Int64), QArray<Int64>>, ICallable
    {
        public OrderFinding(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "OrderFinding";
        String ICallable.FullName => "Quantum.QShor1.OrderFinding";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> Exp2
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IControllable<(QArray<Qubit>,Int64,Int64)> Ux
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Int64), Int64> modExp
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> myQFT
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QArray<Int64>> Body => (__in) =>
        {
            var (a,N) = __in;
#line 92 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var L = 5L;
#line 93 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var t = 7L;
#line 94 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var res = new QArray<Int64>(t);
#line 95 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var qs = Allocate.Apply((L + t));
#line 96 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var x = qs?.Slice(new Range(0L, (t - 1L)));
#line 97 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var y = qs?.Slice(new Range(t, ((L + t) - 1L)));
#line 100 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            foreach (var i in new Range(0L, (t - 1L)))
            {
#line 101 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                MicrosoftQuantumPrimitiveH.Apply(x[i]);
            }

#line 105 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            MicrosoftQuantumPrimitiveX.Apply(y[0L]);
#line 107 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            foreach (var i in new Range(0L, (t - 1L)))
            {
#line 108 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                var r = ((t - 1L) - i);
#line 109 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                Ux.Controlled.Apply((new QArray<Qubit>()
                {x[i]}, (y, modExp.Apply((a, Exp2.Apply((2L, r)), N)), N)));
            }

            //Ux(y,modExp(a,2,N),N);
            //DumpMachine("deb.txt");
            //for(i in 0..t/2-1){
            //    SWAP(x[i],x[t-1-i]);
            //}
#line 119 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            myQFT.Adjoint.Apply(x);
            //(Adjoint QFT)(BigEndian(x));
#line 123 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            foreach (var i in new Range(0L, (t - 1L)))
            {
#line 124 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                if ((M.Apply(x[i]) == Result.One))
                {
#line 125 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                    res[i] = 1L;
                }
                else
                {
#line 127 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
                    res[i] = 0L;
                }
            }

#line 130 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            ResetAll.Apply(qs);
#line hidden
            Release.Apply(qs);
#line 132 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.Exp2 = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Quantum.QShor1.Exp2));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Ux = this.Factory.Get<IControllable<(QArray<Qubit>,Int64,Int64)>>(typeof(Quantum.QShor1.Ux));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.modExp = this.Factory.Get<ICallable<(Int64,Int64,Int64), Int64>>(typeof(Quantum.QShor1.modExp));
            this.myQFT = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(Quantum.QShor1.myQFT));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 a, Int64 N)
        {
            return __m__.Run<OrderFinding, (Int64,Int64), QArray<Int64>>((a, N));
        }
    }

    public class MyTest : Operation<QVoid, QArray<Int64>>, ICallable
    {
        public MyTest(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MyTest";
        String ICallable.FullName => "Quantum.QShor1.MyTest";
        protected ICallable<(Int64,Int64), QArray<Int64>> OrderFinding
        {
            get;
            set;
        }

        public override Func<QVoid, QArray<Int64>> Body => (__in) =>
        {
#line 138 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            return OrderFinding.Apply((5L, 21L));
        }

        ;
        public override void Init()
        {
            this.OrderFinding = this.Factory.Get<ICallable<(Int64,Int64), QArray<Int64>>>(typeof(Quantum.QShor1.OrderFinding));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__)
        {
            return __m__.Run<MyTest, QVoid, QArray<Int64>>(QVoid.Instance);
        }
    }

    public class FindSDivideR : Operation<(Int64,Int64), QArray<Int64>>, ICallable
    {
        public FindSDivideR(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "FindSDivideR";
        String ICallable.FullName => "Quantum.QShor1.FindSDivideR";
        protected ICallable<(Int64,Int64), QArray<Int64>> OrderFinding
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QArray<Int64>> Body => (__in) =>
        {
            var (a,N) = __in;
#line 143 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            return OrderFinding.Apply((a, N));
        }

        ;
        public override void Init()
        {
            this.OrderFinding = this.Factory.Get<ICallable<(Int64,Int64), QArray<Int64>>>(typeof(Quantum.QShor1.OrderFinding));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 a, Int64 N)
        {
            return __m__.Run<FindSDivideR, (Int64,Int64), QArray<Int64>>((a, N));
        }
    }

    public class TestUx : Operation<QVoid, QVoid>, ICallable
    {
        public TestUx(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "TestUx";
        String ICallable.FullName => "Quantum.QShor1.TestUx";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected ICallable MicrosoftQuantumExtensionsDiagnosticsDumpMachine
        {
            get;
            set;
        }

        protected ICallable<String, QVoid> Message
        {
            get;
            set;
        }

        protected Release Release
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QVoid> ResetAll
        {
            get;
            set;
        }

        protected IControllable<(QArray<Qubit>,Int64,Int64)> Ux
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<QVoid, QVoid> Body => (__in) =>
        {
#line 149 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            Message.Apply("hi");
#line 150 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            var qs = Allocate.Apply(4L);
#line 151 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            MicrosoftQuantumPrimitiveX.Apply(qs[2L]);
#line 152 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            MicrosoftQuantumPrimitiveX.Apply(qs[1L]);
#line 153 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            Ux.Apply((qs, 2L, 15L));
#line 154 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            MicrosoftQuantumExtensionsDiagnosticsDumpMachine.Apply("");
#line 155 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor1.qs"
            ResetAll.Apply(qs);
#line hidden
            Release.Apply(qs);
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumExtensionsDiagnosticsDumpMachine = this.Factory.Get<ICallable>(typeof(Microsoft.Quantum.Extensions.Diagnostics.DumpMachine<>));
            this.Message = this.Factory.Get<ICallable<String, QVoid>>(typeof(Microsoft.Quantum.Primitive.Message));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Ux = this.Factory.Get<IControllable<(QArray<Qubit>,Int64,Int64)>>(typeof(Quantum.QShor1.Ux));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__)
        {
            return __m__.Run<TestUx, QVoid, QVoid>(QVoid.Instance);
        }
    }
}