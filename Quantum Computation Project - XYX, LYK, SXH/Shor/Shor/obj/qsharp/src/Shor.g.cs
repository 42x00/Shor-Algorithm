#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.QShor", "QFT (qb : Qubit[]) : ()", new string[] { "Adjoint" }, "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 585L, 25L, 31L)]
[assembly: OperationDeclaration("Quantum.QShor", "Ux (x : Qubit[], a : Int, N : Int) : ()", new string[] { "Controlled" }, "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 1812L, 71L, 49L)]
[assembly: OperationDeclaration("Quantum.QShor", "MeasureReg1 (Qb : Qubit[]) : Int[]", new string[] { }, "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 2473L, 96L, 46L)]
[assembly: OperationDeclaration("Quantum.QShor", "OrderFinding (a : Int, N : Int) : Int[]", new string[] { }, "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 2767L, 111L, 50L)]
[assembly: FunctionDeclaration("Quantum.QShor", "Power (a : Double, k : Int) : Double", new string[] { }, "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 199L, 8L, 11L)]
[assembly: FunctionDeclaration("Quantum.QShor", "PowerInt (a : Int, k : Int) : Int", new string[] { }, "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 368L, 16L, 11L)]
[assembly: FunctionDeclaration("Quantum.QShor", "ModularExp (x1 : Int, j1 : Int, N : Int) : Int", new string[] { }, "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 1995L, 79L, 11L)]
#line hidden
namespace Quantum.QShor
{
    public class Power : Operation<(Double,Int64), Double>, ICallable
    {
        public Power(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Double,Int64)>, IApplyData
        {
            public In((Double,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "Power";
        String ICallable.FullName => "Quantum.QShor.Power";
        public override Func<(Double,Int64), Double> Body => (__in) =>
        {
            var (a,k) = __in;
#line 9 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var ans = 1D;
#line 10 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(1L, k))
            {
#line 11 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                ans = (ans * a);
            }

#line 13 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            return ans;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Double,Int64) data) => new In(data);
        public override IApplyData __dataOut(Double data) => new QTuple<Double>(data);
        public static System.Threading.Tasks.Task<Double> Run(IOperationFactory __m__, Double a, Int64 k)
        {
            return __m__.Run<Power, (Double,Int64), Double>((a, k));
        }
    }

    public class PowerInt : Operation<(Int64,Int64), Int64>, ICallable
    {
        public PowerInt(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "PowerInt";
        String ICallable.FullName => "Quantum.QShor.PowerInt";
        public override Func<(Int64,Int64), Int64> Body => (__in) =>
        {
            var (a,k) = __in;
#line 17 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var ans = 1L;
#line 18 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(1L, k))
            {
#line 19 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                ans = (ans * a);
            }

#line 21 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            return ans;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 a, Int64 k)
        {
            return __m__.Run<PowerInt, (Int64,Int64), Int64>((a, k));
        }
    }

    public class QFT : Adjointable<QArray<Qubit>>, ICallable
    {
        public QFT(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "QFT";
        String ICallable.FullName => "Quantum.QShor.QFT";
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

        protected ICallable<(Double,Int64), Double> Power
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
            var qb = __in;
#line 27 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var n = qb.Count;
#line 28 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var exp2 = new QArray<Double>((n + 1L));
#line 29 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, n))
            {
#line 30 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                exp2[i] = Power.Apply((2D, i));
            }

#line 33 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var pi = MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance);
#line 34 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, (n - 1L)))
            {
#line 35 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                MicrosoftQuantumPrimitiveH.Apply(qb[i]);
#line 36 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                foreach (var j in new Range((i + 1L), (n - 1L)))
                {
                }
            }

            //Reverse the output bits
#line 42 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, ((n / 2L) - 1L)))
            {
#line 43 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                MicrosoftQuantumPrimitiveSWAP.Apply((qb[i], qb[((n - 1L) - i)]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var qb = __in;
#line 49 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var n = qb.Count;
#line 50 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var exp2 = new QArray<Double>((n + 1L));
#line 51 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, n))
            {
#line 52 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                exp2[i] = Power.Apply((2D, i));
            }

#line 55 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var pi = MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance);
#line 56 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, ((n / 2L) - 1L)))
            {
#line 57 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                MicrosoftQuantumPrimitiveSWAP.Apply((qb[((n - 1L) - i)], qb[i]));
            }

#line 60 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var cnt in new Range(0L, (n - 1L)))
            {
#line 61 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                var i = ((n - 1L) - cnt);
#line 62 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                foreach (var j in new Range(0L, (cnt - 1L)))
                {
                }

#line 65 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                MicrosoftQuantumPrimitiveH.Apply(qb[i]);
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MicrosoftQuantumExtensionsMathPI = this.Factory.Get<ICallable<QVoid, Double>>(typeof(Microsoft.Quantum.Extensions.Math.PI));
            this.Power = this.Factory.Get<ICallable<(Double,Int64), Double>>(typeof(Quantum.QShor.Power));
            this.MicrosoftQuantumPrimitiveSWAP = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.SWAP));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, QArray<Qubit> qb)
        {
            return __m__.Run<QFT, QArray<Qubit>, QVoid>(qb);
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
        String ICallable.FullName => "Quantum.QShor.Ux";
        protected IUnitary<(Int64,Int64,Microsoft.Quantum.Canon.LittleEndian)> MicrosoftQuantumCanonModularMultiplyByConstantLE
        {
            get;
            set;
        }

        public override Func<(QArray<Qubit>,Int64,Int64), QVoid> Body => (__in) =>
        {
            var (x,a,N) = __in;
#line 73 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Apply((a, N, new Microsoft.Quantum.Canon.LittleEndian(x)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<(QArray<Qubit>,(QArray<Qubit>,Int64,Int64)), QVoid> ControlledBody => (__in) =>
        {
            var (controlQubits,(x,a,N)) = __in;
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Controlled.Apply((controlQubits, (a, N, new Microsoft.Quantum.Canon.LittleEndian(x))));
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

    public class ModularExp : Operation<(Int64,Int64,Int64), Int64>, ICallable
    {
        public ModularExp(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,Int64,Int64)>, IApplyData
        {
            public In((Int64,Int64,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "ModularExp";
        String ICallable.FullName => "Quantum.QShor.ModularExp";
        public override Func<(Int64,Int64,Int64), Int64> Body => (__in) =>
        {
            var (x1,j1,N) = __in;
#line 80 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var j = j1;
#line 81 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var ans = 1L;
#line 82 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var x = x1;
#line 83 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, 20L))
            {
#line 84 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                if ((j == 0L))
                {
#line 85 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                    return ans;
                }

#line 87 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                if (((j % 2L) == 1L))
                {
#line 88 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                    ans = ((ans * x) % N);
                }

#line 90 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                x = ((x * x) % N);
#line 91 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                j = (j / 2L);
            }

#line 93 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            return ans;
        }

        ;
        public override void Init()
        {
        }

        public override IApplyData __dataIn((Int64,Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(Int64 data) => new QTuple<Int64>(data);
        public static System.Threading.Tasks.Task<Int64> Run(IOperationFactory __m__, Int64 x1, Int64 j1, Int64 N)
        {
            return __m__.Run<ModularExp, (Int64,Int64,Int64), Int64>((x1, j1, N));
        }
    }

    public class MeasureReg1 : Operation<QArray<Qubit>, QArray<Int64>>, ICallable
    {
        public MeasureReg1(IOperationFactory m) : base(m)
        {
        }

        String ICallable.Name => "MeasureReg1";
        String ICallable.FullName => "Quantum.QShor.MeasureReg1";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        public override Func<QArray<Qubit>, QArray<Int64>> Body => (__in) =>
        {
            var Qb = __in;
#line 98 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var t = 7L;
#line 99 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var res = new QArray<Int64>(t);
#line 100 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, (t - 1L)))
            {
#line 101 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                if ((M.Apply(Qb[i]) == Result.One))
                {
#line 102 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                    res[i] = 1L;
                }
                else
                {
#line 104 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                    res[i] = 0L;
                }
            }

#line 107 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
        }

        public override IApplyData __dataIn(QArray<Qubit> data) => data;
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, QArray<Qubit> Qb)
        {
            return __m__.Run<MeasureReg1, QArray<Qubit>, QArray<Int64>>(Qb);
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
        String ICallable.FullName => "Quantum.QShor.OrderFinding";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveH
        {
            get;
            set;
        }

        protected ICallable<QArray<Qubit>, QArray<Int64>> MeasureReg1
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64,Int64), Int64> ModularExp
        {
            get;
            set;
        }

        protected ICallable<(Int64,Int64), Int64> PowerInt
        {
            get;
            set;
        }

        protected IAdjointable<QArray<Qubit>> QFT
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

        public override Func<(Int64,Int64), QArray<Int64>> Body => (__in) =>
        {
            var (a,N) = __in;
            //
            // |0>————— [H] ———*—— [inv-QFT] ————— [M]
            //                 | 
            // |0>—— [X]————[x^j % N] ————————————— 
            //
#line 118 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var L = 5L;
#line 119 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var t = 7L;
#line 120 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var Approx = new QArray<Int64>(t);
#line 121 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var qb = Allocate.Apply((L + t));
#line 122 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var x = qb?.Slice(new Range(0L, (t - 1L)));
#line 123 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var y = qb?.Slice(new Range(t, ((L + t) - 1L)));
#line 125 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, (t - 1L)))
            {
#line 126 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                MicrosoftQuantumPrimitiveH.Apply(x[i]);
            }

#line 128 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            MicrosoftQuantumPrimitiveX.Apply(y[0L]);
#line 130 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, (t - 1L)))
            {
#line 131 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                var r = ((t - 1L) - i);
#line 132 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                Ux.Controlled.Apply((new QArray<Qubit>()
                {x[i]}, (y, ModularExp.Apply((a, PowerInt.Apply((2L, r)), N)), N)));
            }

#line 135 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            QFT.Adjoint.Apply(x);
#line 137 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            Approx = MeasureReg1.Apply(x);
#line 138 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            ResetAll.Apply(qb);
#line hidden
            Release.Apply(qb);
#line 140 "D:\\LYK\\Class\\量子计算\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            return Approx;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MeasureReg1 = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Int64>>>(typeof(Quantum.QShor.MeasureReg1));
            this.ModularExp = this.Factory.Get<ICallable<(Int64,Int64,Int64), Int64>>(typeof(Quantum.QShor.ModularExp));
            this.PowerInt = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Quantum.QShor.PowerInt));
            this.QFT = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(Quantum.QShor.QFT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Ux = this.Factory.Get<IControllable<(QArray<Qubit>,Int64,Int64)>>(typeof(Quantum.QShor.Ux));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 a, Int64 N)
        {
            return __m__.Run<OrderFinding, (Int64,Int64), QArray<Int64>>((a, N));
        }
    }
}