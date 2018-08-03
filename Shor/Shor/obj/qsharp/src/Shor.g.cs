#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.QShor", "QFT (qb : Qubit[]) : ()", new string[] { "Adjoint" }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 575L, 24L, 31L)]
[assembly: OperationDeclaration("Quantum.QShor", "Ux (x : Qubit[], a : Int, N : Int) : ()", new string[] { "Controlled" }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 1735L, 66L, 49L)]
[assembly: OperationDeclaration("Quantum.QShor", "MeasureReg1 (Qb : Qubit[]) : Int[]", new string[] { }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 2365L, 90L, 46L)]
[assembly: OperationDeclaration("Quantum.QShor", "OrderFinding (a : Int, N : Int) : Int[]", new string[] { }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 2674L, 105L, 50L)]
[assembly: FunctionDeclaration("Quantum.QShor", "Power (a : Double, k : Int) : Double", new string[] { }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 206L, 8L, 11L)]
[assembly: FunctionDeclaration("Quantum.QShor", "PowerInt (a : Int, k : Int) : Int", new string[] { }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 383L, 16L, 11L)]
[assembly: FunctionDeclaration("Quantum.QShor", "modExp (x1 : Int, j1 : Int, N : Int) : Int", new string[] { }, "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs", 1874L, 73L, 11L)]
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
#line 9 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var ans = 1D;
#line 10 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(1L, k))
            {
#line 11 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                ans = (ans * a);
            }

#line 13 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
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
#line 17 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var ans = 1L;
#line 18 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(1L, k))
            {
#line 19 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                ans = (ans * a);
            }

#line 21 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
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
#line 26 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var n = qb.Count;
#line 27 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var pi = MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance);
#line 28 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var exp2 = new QArray<Double>((n + 1L));
#line 29 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, n))
            {
#line 30 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                exp2[i] = Power.Apply((2D, i));
            }

#line 33 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, (n - 1L)))
            {
#line 34 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                MicrosoftQuantumPrimitiveH.Apply(qb[i]);
#line 35 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                foreach (var j in new Range((i + 1L), (n - 1L)))
                {
                }
            }

#line 40 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, ((n / 2L) - 1L)))
            {
#line 41 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                MicrosoftQuantumPrimitiveSWAP.Apply((qb[i], qb[((n - 1L) - i)]));
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override Func<QArray<Qubit>, QVoid> AdjointBody => (__in) =>
        {
            var qb = __in;
#line 45 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var n = qb.Count;
#line 46 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var pi = MicrosoftQuantumExtensionsMathPI.Apply(QVoid.Instance);
#line 47 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var exp2 = new QArray<Double>((n + 1L));
#line 48 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, n))
            {
#line 49 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                exp2[i] = Power.Apply((2D, i));
            }

#line 52 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, ((n / 2L) - 1L)))
            {
#line 53 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                MicrosoftQuantumPrimitiveSWAP.Apply((qb[((n - 1L) - i)], qb[i]));
            }

#line 56 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var cnt in new Range(0L, (n - 1L)))
            {
#line 57 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                var i = ((n - 1L) - cnt);
#line 58 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                foreach (var j in new Range(0L, (cnt - 1L)))
                {
                }

#line 61 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
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
#line 68 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
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
        String ICallable.FullName => "Quantum.QShor.modExp";
        public override Func<(Int64,Int64,Int64), Int64> Body => (__in) =>
        {
            var (x1,j1,N) = __in;
#line 74 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var j = j1;
#line 75 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var ans = 1L;
#line 76 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var x = x1;
#line 77 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, 20L))
            {
#line 78 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                if ((j == 0L))
                {
#line 79 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                    return ans;
                }

#line 81 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                if (((j % 2L) == 1L))
                {
#line 82 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                    ans = ((ans * x) % N);
                }

#line 84 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                x = ((x * x) % N);
#line 85 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                j = (j / 2L);
            }

#line 87 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
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
            return __m__.Run<modExp, (Int64,Int64,Int64), Int64>((x1, j1, N));
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
#line 92 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var t = 7L;
#line 93 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var res = new QArray<Int64>(t);
#line 94 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, (t - 1L)))
            {
#line 95 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                if ((M.Apply(Qb[i]) == Result.One))
                {
#line 96 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                    res[i] = 1L;
                }
                else
                {
#line 98 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                    res[i] = 0L;
                }
            }

#line 101 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
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

        protected ICallable<(Int64,Int64,Int64), Int64> modExp
        {
            get;
            set;
        }

        public override Func<(Int64,Int64), QArray<Int64>> Body => (__in) =>
        {
            var (a,N) = __in;
#line 107 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var L = 5L;
#line 108 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var t = 7L;
#line 109 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var res = new QArray<Int64>(t);
#line 110 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var qs = Allocate.Apply((L + t));
#line 111 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var x = qs?.Slice(new Range(0L, (t - 1L)));
#line 112 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            var y = qs?.Slice(new Range(t, ((L + t) - 1L)));
#line 114 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, (t - 1L)))
            {
#line 115 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                MicrosoftQuantumPrimitiveH.Apply(x[i]);
            }

#line 118 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            MicrosoftQuantumPrimitiveX.Apply(y[0L]);
#line 120 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            foreach (var i in new Range(0L, (t - 1L)))
            {
#line 121 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                var r = ((t - 1L) - i);
#line 122 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
                Ux.Controlled.Apply((new QArray<Qubit>()
                {x[i]}, (y, modExp.Apply((a, PowerInt.Apply((2L, r)), N)), N)));
            }

#line 125 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            QFT.Adjoint.Apply(x);
#line 127 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            res = MeasureReg1.Apply(x);
            //for(i in 0..t-1){
            //    if(M(x[i]) == One){
            //        set res[i] = 1;
            //    }else{
            //        set res[i] = 0;
            //    }
            //}
#line 135 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            ResetAll.Apply(qs);
#line hidden
            Release.Apply(qs);
#line 137 "C:\\Users\\lenovo\\Desktop\\ProjectQ\\Shor-Algorithm\\Shor\\Shor\\Shor.qs"
            return res;
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.MeasureReg1 = this.Factory.Get<ICallable<QArray<Qubit>, QArray<Int64>>>(typeof(Quantum.QShor.MeasureReg1));
            this.PowerInt = this.Factory.Get<ICallable<(Int64,Int64), Int64>>(typeof(Quantum.QShor.PowerInt));
            this.QFT = this.Factory.Get<IAdjointable<QArray<Qubit>>>(typeof(Quantum.QShor.QFT));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.ResetAll = this.Factory.Get<ICallable<QArray<Qubit>, QVoid>>(typeof(Microsoft.Quantum.Primitive.ResetAll));
            this.Ux = this.Factory.Get<IControllable<(QArray<Qubit>,Int64,Int64)>>(typeof(Quantum.QShor.Ux));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
            this.modExp = this.Factory.Get<ICallable<(Int64,Int64,Int64), Int64>>(typeof(Quantum.QShor.modExp));
        }

        public override IApplyData __dataIn((Int64,Int64) data) => new In(data);
        public override IApplyData __dataOut(QArray<Int64> data) => data;
        public static System.Threading.Tasks.Task<QArray<Int64>> Run(IOperationFactory __m__, Int64 a, Int64 N)
        {
            return __m__.Run<OrderFinding, (Int64,Int64), QArray<Int64>>((a, N));
        }
    }
}