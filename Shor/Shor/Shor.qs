namespace Quantum.QShor
{
    open Microsoft.Quantum.Primitive;
    open Microsoft.Quantum.Canon;
	open Microsoft.Quantum.Extensions.Diagnostics;
	open Microsoft.Quantum.Extensions.Math; 

	function Power(a : Double, k : Int) : (Double) {
        mutable ans = 1.0;
        for(i in 1..k){
            set ans = ans * a;
        }
        return ans;
    }

	function PowerInt(a : Int, k : Int) : (Int) {
        mutable ans = 1;
        for(i in 1..k){
            set ans = ans * a;
        }
        return ans;
    }

	operation QFT(qb: Qubit[]):(){
        body{
            let n = Length(qb);
            let pi = PI();
            mutable exp2 = new Double[n + 1];
            for(i in 0..n){
                set exp2[i] = Power(2.0, i);
            }

            for(i in 0..n-1){
                H(qb[i]);
                for(j in i+1..n-1){
                    (controlled R1)([qb[j]], (2*PI/exp2[j-i+1], qb[i]));
                }
            }

            for(i in 0..n/2 - 1){
                SWAP(qb[i], qb[n-1-i]);
            }
        }
        adjoint{
            let n = Length(qb);
            let pi = PI();
            mutable exp2 = new Double[n + 1];
            for(i in 0..n){
                set exp2[i] = Power(2.0, i);
            }

            for(i in 0..n/2 - 1){
                SWAP(qb[n-1-i], qb[i]);
            }

            for(cnt in 0..n-1){
                let i = n - 1 - cnt;
                for(j in 0..cnt - 1){
                    (controlled R1)([qb[n - 1 - j]], (-2*pi/exp2[cnt + 2], qb[i]));
                }
                H(qb[i]);
            }
        }
    }

	operation Ux(x : Qubit[], a : Int , N : Int):(){
        body{
            ModularMultiplyByConstantLE(a, N, LittleEndian(x));
        }
        controlled auto;
    }

	function modExp(x1 : Int , j1 : Int , N : Int):(Int){
            mutable j = j1;
            mutable ans = 1;
            mutable x = x1;
            for(i in 0..20){
                if(j == 0){
                    return ans;
                }
				if(j % 2 == 1){
                    set ans = ans * x % N;
                }
                set x = x * x % N;
                set j = j / 2;
            }
            return ans;
    }

	operation MeasureReg1(Qb : Qubit[]):(Int []){
		body{
			let t = 7;
			mutable res = new Int[t];
			for(i in 0..t - 1){
    	        if(M(Qb[i]) == One){
    	            set res[i] = 1;
    	        }else{
    	            set res[i] = 0;
    	        }
    	    }
			return res;
		}
	}

	operation OrderFinding(a : Int, N : Int):(Int[]){
        body{
            let L = 5;
            let t = 7;
            mutable res = new Int[t];
            using(qs = Qubit[L+t]){
                let x = qs[0..t-1];
                let y = qs[t..L+t-1];

                for(i in 0..t-1){
                    H(x[i]);
                }

                X(y[0]);

                for(i in 0..t-1){
                    let r = t - 1 - i;
                    (Controlled Ux)([x[i]], (y, modExp(a, PowerInt(2, r), N), N));
                }

                (Adjoint QFT)(x);

				set res = MeasureReg1(x);
                //for(i in 0..t-1){
                //    if(M(x[i]) == One){
                //        set res[i] = 1;
                //    }else{
                //        set res[i] = 0;
                //    }
                //}
                ResetAll(qs);
            }
            return res;
        }
    }

}
