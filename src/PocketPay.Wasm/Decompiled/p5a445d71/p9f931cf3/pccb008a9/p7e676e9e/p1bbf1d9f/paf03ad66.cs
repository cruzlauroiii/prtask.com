namespace WillowMaze.Wasm.Decompiled;


public abstract class paf03ad66 {
    protected int f0ae15a68;
    protected java.util.Vector f0fe53aa4;
    protected java.util.Vector f1d136e9e;
    protected java.util.Vector f25b24abe;
    protected java.util.Vector f3f818be6;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 f41e73ac6;
    protected java.util.Vector f5b243a9f;
    protected java.util.Vector f5dd1b039;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 f675ea464;
    protected java.util.Vector f773787d2;
    protected readonly java.security.SecureRandom f7ddf32e1;
    protected int f91243d4a;
    protected int fa0a82c33;
    protected readonly java.security.SecureRandom faf7eefa7;
    protected p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 fb774cd5f;
    protected int fcb402a6a;
    protected java.util.Vector fd05b6ed7;
    protected java.util.Vector fdf6f734e;
    protected java.util.Vector fe288a878;

    protected paf03ad66(java.security.SecureRandom secureRandom) {
        this.f7ddf32e1 = secureRandom;
    }

    protected abstract void ComputeCOBMatrix(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var);

    protected abstract void ComputeFieldPolynomial();

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Convert(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) throws java.lang.Exception {
        if ((12 + 7) % 7 > 0) {
        }
        if (paf03ad66Var != this && !this.fb774cd5f.Equals(paf03ad66Var.fb774cd5f)) {
            if (this.f91243d4a != paf03ad66Var.f91243d4a) {
                throw new java.lang.Exception("GF2nField.convert: B1 has a different degree and thus cannot be coverted to!");
            }
            int iIndexOf = this.fd05b6ed7.IndexOf(paf03ad66Var);
            if (iIndexOf == -1) {
                computeCOBMatrix(paf03ad66Var);
                iIndexOf = this.fd05b6ed7.IndexOf(paf03ad66Var);
            }
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[]) this.f25b24abe.elementAt(iIndexOf);
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var2 = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) p1bf4f0f9Var.clone();
            if (p1bf4f0f9Var2 is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) {
                ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) p1bf4f0f9Var2).reverseOrder();
            }
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a, p1bf4f0f9Var2.toFlexiBigInt());
            p31c30ba9Var.expandN(this.f91243d4a);
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a);
            for (int i = 0; i < this.f91243d4a; i++) {
                if (p31c30ba9Var.vectorMult(p31c30ba9VarArr[i])) {
                    p31c30ba9Var2.setBit((this.f91243d4a - 1) - i);
                }
            }
            if (paf03ad66Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) {
                return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) paf03ad66Var, p31c30ba9Var2);
            }
            if (!(paf03ad66Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1)) {
                throw new java.lang.Exception("GF2nField.convert: B1 must be an instance of GF2nPolynomialField or GF2nONBField!");
            }
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) paf03ad66Var, p31c30ba9Var2.toFlexiBigInt());
            p2939c56cVar.reverseOrder();
            return p2939c56cVar;
        }
        return (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) p1bf4f0f9Var.clone();
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((3 + 4) % 4 > 0) {
        }
        if (obj is null || !(obj is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66)) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66) obj;
        if (paf03ad66Var.f91243d4a != this.f91243d4a || !this.fb774cd5f.Equals(paf03ad66Var.fb774cd5f)) {
            return false;
        }
        if ((this is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) && !(paf03ad66Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654)) {
            return false;
        }
        return !(this is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) || (paf03ad66Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1);
    }

    public readonly int GetDegree() {
        return this.f91243d4a;
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 GetFieldPolynomial() {
        if (this.fb774cd5f is null) {
            computeFieldPolynomial();
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.fb774cd5f);
    }

    protected abstract p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 GetRandomRoot(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var);

    public int HashCode() {
        return this.f91243d4a + this.fb774cd5f.GetHashCode();
    }

    protected readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] InvertMatrix(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr) {
        if ((28 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[p31c30ba9VarArr.length];
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr3 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[p31c30ba9VarArr.length];
        int i = 0;
        for (int i2 = 0; i2 < this.f91243d4a; i2++) {
            p31c30ba9VarArr2[i2] = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9VarArr[i2]);
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a);
            p31c30ba9VarArr3[i2] = p31c30ba9Var;
            p31c30ba9Var.setBit((this.f91243d4a - 1) - i2);
        }
        while (true) {
            int i3 = this.f91243d4a;
            if (i >= i3 - 1) {
                for (int i4 = i3 - 1; i4 > 0; i4--) {
                    for (int i5 = i4 - 1; i5 >= 0; i5--) {
                        if (p31c30ba9VarArr2[i5].testBit((this.f91243d4a - 1) - i4)) {
                            p31c30ba9VarArr2[i5].addToThis(p31c30ba9VarArr2[i4]);
                            p31c30ba9VarArr3[i5].addToThis(p31c30ba9VarArr3[i4]);
                        }
                    }
                }
                return p31c30ba9VarArr3;
            }
            int i6 = i;
            while (true) {
                int i7 = this.f91243d4a;
                if (i6 >= i7 || p31c30ba9VarArr2[i6].testBit((i7 - 1) - i)) {
                    break;
                }
                i6++;
            }
            if (i6 >= this.f91243d4a) {
                throw new java.lang.Exception("GF2nField.invertMatrix: Matrix cannot be inverted!");
            }
            if (i != i6) {
                p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = p31c30ba9VarArr2[i];
                p31c30ba9VarArr2[i] = p31c30ba9VarArr2[i6];
                p31c30ba9VarArr2[i6] = p31c30ba9Var2;
                p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = p31c30ba9VarArr3[i];
                p31c30ba9VarArr3[i] = p31c30ba9VarArr3[i6];
                p31c30ba9VarArr3[i6] = p31c30ba9Var3;
            }
            int i8 = i + 1;
            int i9 = i8;
            while (true) {
                int i10 = this.f91243d4a;
                if (i9 >= i10) {
                    break;
                }
                if (p31c30ba9VarArr2[i9].testBit((i10 - 1) - i)) {
                    p31c30ba9VarArr2[i9].addToThis(p31c30ba9VarArr2[i]);
                    p31c30ba9VarArr3[i9].addToThis(p31c30ba9VarArr3[i]);
                }
                i9++;
            }
            i = i8;
        }
    }
}

