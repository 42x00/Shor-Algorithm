namespace Quantum.QShor
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Diagnostics;

	operation Set(desired: Result, q1: Qubit) : ()
	{
		body
		{
			let current = M(q1);

			if (desired != current)
			{
				X(q1); // reverse
			}
		}
	}

	operation U(x : Int, y : Qubit[], N : Int) : () // U|y> = |xy mod N>
	{
        body
		{
            ModularMultiplyByConstantLE(x, N, LittleEndian(y));
        }
    }

    operation BellTest() : (Result, Result)
	{
		body
		{
			// 用于保存量子位状态的可变局部变量
			mutable s1 = Zero;
			mutable s2 = Zero;

			// 分配两个量子位
			using (qubits = Qubit[2])
			{
				// 将第一个量子位执行阿达马门实现状态叠加
				H(qubits[0]);

				// 通过可控非门将两个量子进行纠缠
				CNOT(qubits[0], qubits[1]);

				// 测量两个量子位的状态
				set s1 = M(qubits[0]);
				set s2 = M(qubits[1]);

				// 释放量子位前需要将其重置0状态
				Set(Zero, qubits[0]);
				Set(Zero, qubits[1]);
			}

			// 返回两个量子位的状态
			return (s1, s2);
		}
	}
}
