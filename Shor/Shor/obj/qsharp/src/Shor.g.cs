#pragma warning disable 1591
using System;
using Microsoft.Quantum.Primitive;
using Microsoft.Quantum.Simulation.Core;
using Microsoft.Quantum.MetaData.Attributes;

[assembly: OperationDeclaration("Quantum.QShor", "Set (desired : Result, q1 : Qubit) : ()", new string[] { }, "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs", 203L, 8L, 2L)]
[assembly: OperationDeclaration("Quantum.QShor", "U (x : Int, y : Qubit[], N : Int) : ()", new string[] { }, "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs", 389L, 20L, 70L)]
[assembly: OperationDeclaration("Quantum.QShor", "BellTest () : (Result, Result)", new string[] { }, "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs", 545L, 29L, 2L)]
#line hidden
namespace Quantum.QShor
{
    public class Set : Operation<(Result,Qubit), QVoid>, ICallable
    {
        public Set(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Result,Qubit)>, IApplyData
        {
            public In((Result,Qubit) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits
            {
                get
                {
                    yield return Data.Item2;
                }
            }
        }

        String ICallable.Name => "Set";
        String ICallable.FullName => "Quantum.QShor.Set";
        protected ICallable<Qubit, Result> M
        {
            get;
            set;
        }

        protected IUnitary<Qubit> MicrosoftQuantumPrimitiveX
        {
            get;
            set;
        }

        public override Func<(Result,Qubit), QVoid> Body => (__in) =>
        {
            var (desired,q1) = __in;
#line 11 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            var current = M.Apply(q1);
#line 13 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            if ((desired != current))
            {
#line 15 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
                MicrosoftQuantumPrimitiveX.Apply(q1);
                // reverse
                ;
            }

#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.MicrosoftQuantumPrimitiveX = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.X));
        }

        public override IApplyData __dataIn((Result,Qubit) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Result desired, Qubit q1)
        {
            return __m__.Run<Set, (Result,Qubit), QVoid>((desired, q1));
        }
    }

    public class U : Operation<(Int64,QArray<Qubit>,Int64), QVoid>, ICallable
    {
        public U(IOperationFactory m) : base(m)
        {
        }

        public class In : QTuple<(Int64,QArray<Qubit>,Int64)>, IApplyData
        {
            public In((Int64,QArray<Qubit>,Int64) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => ((IApplyData)Data.Item2)?.Qubits;
        }

        String ICallable.Name => "U";
        String ICallable.FullName => "Quantum.QShor.U";
        protected IUnitary<(Int64,Int64,Microsoft.Quantum.Canon.LittleEndian)> MicrosoftQuantumCanonModularMultiplyByConstantLE
        {
            get;
            set;
        }

        public override Func<(Int64,QArray<Qubit>,Int64), QVoid> Body => (__in) =>
        {
            var (x,y,N) = __in;
#line 24 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            MicrosoftQuantumCanonModularMultiplyByConstantLE.Apply((x, N, new Microsoft.Quantum.Canon.LittleEndian(y)));
#line hidden
            return QVoid.Instance;
        }

        ;
        public override void Init()
        {
            this.MicrosoftQuantumCanonModularMultiplyByConstantLE = this.Factory.Get<IUnitary<(Int64,Int64,Microsoft.Quantum.Canon.LittleEndian)>>(typeof(Microsoft.Quantum.Canon.ModularMultiplyByConstantLE));
        }

        public override IApplyData __dataIn((Int64,QArray<Qubit>,Int64) data) => new In(data);
        public override IApplyData __dataOut(QVoid data) => data;
        public static System.Threading.Tasks.Task<QVoid> Run(IOperationFactory __m__, Int64 x, QArray<Qubit> y, Int64 N)
        {
            return __m__.Run<U, (Int64,QArray<Qubit>,Int64), QVoid>((x, y, N));
        }
    }

    public class BellTest : Operation<QVoid, (Result,Result)>, ICallable
    {
        public BellTest(IOperationFactory m) : base(m)
        {
        }

        public class Out : QTuple<(Result,Result)>, IApplyData
        {
            public Out((Result,Result) data) : base(data)
            {
            }

            System.Collections.Generic.IEnumerable<Qubit> IApplyData.Qubits => null;
        }

        String ICallable.Name => "BellTest";
        String ICallable.FullName => "Quantum.QShor.BellTest";
        protected Allocate Allocate
        {
            get;
            set;
        }

        protected IUnitary<(Qubit,Qubit)> MicrosoftQuantumPrimitiveCNOT
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

        protected ICallable<(Result,Qubit), QVoid> Set
        {
            get;
            set;
        }

        public override Func<QVoid, (Result,Result)> Body => (__in) =>
        {
            // 用于保存量子位状态的可变局部变量
#line 33 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            var s1 = Result.Zero;
#line 34 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            var s2 = Result.Zero;
            // 分配两个量子位
#line 37 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            var qubits = Allocate.Apply(2L);
            // 将第一个量子位执行阿达马门实现状态叠加
#line 40 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            MicrosoftQuantumPrimitiveH.Apply(qubits[0L]);
            // 通过可控非门将两个量子进行纠缠
#line 43 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            MicrosoftQuantumPrimitiveCNOT.Apply((qubits[0L], qubits[1L]));
            // 测量两个量子位的状态
#line 46 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            s1 = M.Apply(qubits[0L]);
#line 47 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            s2 = M.Apply(qubits[1L]);
            // 释放量子位前需要将其重置0状态
#line 50 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            Set.Apply((Result.Zero, qubits[0L]));
#line 51 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            Set.Apply((Result.Zero, qubits[1L]));
#line hidden
            Release.Apply(qubits);
            // 返回两个量子位的状态
#line 55 "C:\\Users\\DELL\\Desktop\\Shor\\Shor\\Shor\\Shor.qs"
            return (s1, s2);
        }

        ;
        public override void Init()
        {
            this.Allocate = this.Factory.Get<Allocate>(typeof(Microsoft.Quantum.Primitive.Allocate));
            this.MicrosoftQuantumPrimitiveCNOT = this.Factory.Get<IUnitary<(Qubit,Qubit)>>(typeof(Microsoft.Quantum.Primitive.CNOT));
            this.MicrosoftQuantumPrimitiveH = this.Factory.Get<IUnitary<Qubit>>(typeof(Microsoft.Quantum.Primitive.H));
            this.M = this.Factory.Get<ICallable<Qubit, Result>>(typeof(Microsoft.Quantum.Primitive.M));
            this.Release = this.Factory.Get<Release>(typeof(Microsoft.Quantum.Primitive.Release));
            this.Set = this.Factory.Get<ICallable<(Result,Qubit), QVoid>>(typeof(Quantum.QShor.Set));
        }

        public override IApplyData __dataIn(QVoid data) => data;
        public override IApplyData __dataOut((Result,Result) data) => new Out(data);
        public static System.Threading.Tasks.Task<(Result,Result)> Run(IOperationFactory __m__)
        {
            return __m__.Run<BellTest, QVoid, (Result,Result)>(QVoid.Instance);
        }
    }
}