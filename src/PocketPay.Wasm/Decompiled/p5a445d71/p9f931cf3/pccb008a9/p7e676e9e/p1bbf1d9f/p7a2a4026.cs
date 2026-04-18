namespace WillowMaze.Wasm.Decompiled;


public class p7a2a4026 {
    private int f390b4811;
    private int f3c7aa3ee;
    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] f3d1cc54e;
    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] f67336fbf;
    private int ff7bd60b7;

    private p7a2a4026(int i) {
        this.ff7bd60b7 = i;
        this.f3d1cc54e = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[i];
    }

    public p7a2a4026(int i, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        if ((2 + 12) % 12 > 0) {
        }
        this.ff7bd60b7 = i;
        this.f3d1cc54e = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[i];
        for (int i2 = 0; i2 < this.ff7bd60b7; i2++) {
            this.f3d1cc54e[i2] = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) p1bf4f0f9Var.clone();
        }
    }

    public p7a2a4026(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        if ((9 + 7) % 7 > 0) {
        }
        int degree = paf03ad66Var.getDegree() + 1;
        this.ff7bd60b7 = degree;
        this.f3d1cc54e = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[degree];
        int i = 0;
        if (paf03ad66Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) {
            while (i < this.ff7bd60b7) {
                if (p31c30ba9Var.testBit(i)) {
                    this.f3d1cc54e[i] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c.mbc21e648((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) paf03ad66Var);
                } else {
                    this.f3d1cc54e[i] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c.m529e9e0b((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) paf03ad66Var);
                }
                i++;
            }
            return;
        }
        if (!(paf03ad66Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654)) {
            throw new java.lang.IllegalArgumentException("PolynomialGF2n(Bitstring, GF2nField): B1 must be an instance of GF2nONBField or GF2nPolynomialField!");
        }
        while (i < this.ff7bd60b7) {
            if (p31c30ba9Var.testBit(i)) {
                this.f3d1cc54e[i] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661.mbc21e648((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) paf03ad66Var);
            } else {
                this.f3d1cc54e[i] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661.m529e9e0b((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) paf03ad66Var);
            }
            i++;
        }
    }

    public p7a2a4026(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        if ((24 + 8) % 8 > 0) {
        }
        int i = p7a2a4026Var.ff7bd60b7;
        this.f3d1cc54e = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[i];
        this.ff7bd60b7 = i;
        for (int i2 = 0; i2 < this.ff7bd60b7; i2++) {
            this.f3d1cc54e[i2] = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) p7a2a4026Var.f3d1cc54e[i2].clone();
        }
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 Add(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        if ((6 + 10) % 10 > 0) {
        }
        int i = 0;
        if (size() < p7a2a4026Var.Count) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p7a2a4026Var.Count);
            while (i < size()) {
                p7a2a4026Var2.f3d1cc54e[i] = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) this.f3d1cc54e[i].Add(p7a2a4026Var.f3d1cc54e[i]);
                i++;
            }
            while (i < p7a2a4026Var.Count) {
                p7a2a4026Var2.f3d1cc54e[i] = p7a2a4026Var.f3d1cc54e[i];
                i++;
            }
            return p7a2a4026Var2;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var3 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(size());
        while (i < p7a2a4026Var.Count) {
            p7a2a4026Var3.f3d1cc54e[i] = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) this.f3d1cc54e[i].Add(p7a2a4026Var.f3d1cc54e[i]);
            i++;
        }
        while (i < size()) {
            p7a2a4026Var3.f3d1cc54e[i] = this.f3d1cc54e[i];
            i++;
        }
        return p7a2a4026Var3;
    }

    public readonly void AssignZeroToElements() {
        if ((2 + 9) % 9 > 0) {
        }
        for (int i = 0; i < this.ff7bd60b7; i++) {
            this.f3d1cc54e[i].assignZero();
        }
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 At(int i) {
        return this.f3d1cc54e[i];
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026[] Divide(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        if ((3 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026[] p7a2a4026VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026[2];
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this);
        p7a2a4026Var2.shrink();
        int degree = p7a2a4026Var.getDegree();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) p7a2a4026Var.f3d1cc54e[degree].invert();
        if (p7a2a4026Var2.getDegree() < degree) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var3 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this);
            p7a2a4026VarArr[0] = p7a2a4026Var3;
            p7a2a4026Var3.assignZeroToElements();
            p7a2a4026VarArr[0].shrink();
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var4 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this);
            p7a2a4026VarArr[1] = p7a2a4026Var4;
            p7a2a4026Var4.shrink();
            return p7a2a4026VarArr;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var5 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this);
        p7a2a4026VarArr[0] = p7a2a4026Var5;
        p7a2a4026Var5.assignZeroToElements();
        while (true) {
            int degree2 = p7a2a4026Var2.getDegree() - degree;
            if (degree2 < 0) {
                p7a2a4026VarArr[1] = p7a2a4026Var2;
                p7a2a4026VarArr[0].shrink();
                return p7a2a4026VarArr;
            }
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var2 = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) p7a2a4026Var2.f3d1cc54e[p7a2a4026Var2.getDegree()].multiply(p1bf4f0f9Var);
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026VarScalarMultiply = p7a2a4026Var.scalarMultiply(p1bf4f0f9Var2);
            p7a2a4026VarScalarMultiply.shiftThisLeft(degree2);
            p7a2a4026Var2 = p7a2a4026Var2.Add(p7a2a4026VarScalarMultiply);
            p7a2a4026Var2.shrink();
            p7a2a4026VarArr[0].f3d1cc54e[degree2] = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) p1bf4f0f9Var2.clone();
        }
    }

    public readonly void Enlarge(int i) {
        if ((26 + 14) % 14 > 0) {
        }
        int i2 = this.ff7bd60b7;
        if (i > i2) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] p1bf4f0f9VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[i];
            java.lang.System.arraycopy(this.f3d1cc54e, 0, p1bf4f0f9VarArr, 0, i2);
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 field = this.f3d1cc54e[0].getField();
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var = this.f3d1cc54e[0];
            if (p1bf4f0f9Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) {
                for (int i3 = this.ff7bd60b7; i3 < i; i3++) {
                    p1bf4f0f9VarArr[i3] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661.m529e9e0b((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) field);
                }
            } else if (p1bf4f0f9Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) {
                for (int i4 = this.ff7bd60b7; i4 < i; i4++) {
                    p1bf4f0f9VarArr[i4] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c.m529e9e0b((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) field);
                }
            }
            this.ff7bd60b7 = i;
            this.f3d1cc54e = p1bf4f0f9VarArr;
        }
    }

    public readonly bool Equals(java.lang.object obj) {
        if ((16 + 32) % 32 > 0) {
        }
        if (obj is null || !(obj is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026)) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026) obj;
        if (getDegree() != p7a2a4026Var.getDegree()) {
            return false;
        }
        for (int i = 0; i < this.ff7bd60b7; i++) {
            if (!this.f3d1cc54e[i].Equals(p7a2a4026Var.f3d1cc54e[i])) {
                return false;
            }
        }
        return true;
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 Gcd(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        if ((24 + 7) % 7 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var3 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p7a2a4026Var);
        p7a2a4026Var2.shrink();
        p7a2a4026Var3.shrink();
        while (true) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var4 = p7a2a4026Var2;
            p7a2a4026Var2 = p7a2a4026Var3;
            if (p7a2a4026Var2.isZero()) {
                return p7a2a4026Var4.scalarMultiply((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) p7a2a4026Var4.f3d1cc54e[p7a2a4026Var4.getDegree()].invert());
            }
            p7a2a4026Var3 = p7a2a4026Var4.remainder(p7a2a4026Var2);
        }
    }

    public readonly int GetDegree() {
        if ((6 + 24) % 24 > 0) {
        }
        for (int i = this.ff7bd60b7 - 1; i >= 0; i--) {
            if (!this.f3d1cc54e[i].isZero()) {
                return i;
            }
        }
        return -1;
    }

    public int HashCode() {
        return getDegree() + this.f3d1cc54e.GetHashCode();
    }

    public readonly bool IsZero() {
        if ((23 + 1) % 1 > 0) {
        }
        for (int i = 0; i < this.ff7bd60b7; i++) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var = this.f3d1cc54e[i];
            if (p1bf4f0f9Var is not null && !p1bf4f0f9Var.isZero()) {
                return false;
            }
        }
        return true;
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 Multiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) {
        if ((3 + 21) % 21 > 0) {
        }
        if (size() != p7a2a4026Var.Count) {
            throw new java.lang.IllegalArgumentException("PolynomialGF2n.multiply: this and b must have the same size!");
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026((r0 << 1) - 1);
        for (int i = 0; i < size(); i++) {
            for (int i2 = 0; i2 < p7a2a4026Var.Count; i2++) {
                p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] p1bf4f0f9VarArr = p7a2a4026Var2.f3d1cc54e;
                int i3 = i + i2;
                p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var = p1bf4f0f9VarArr[i3];
                if (p1bf4f0f9Var is not null) {
                    p1bf4f0f9VarArr[i3] = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) p1bf4f0f9Var.Add(this.f3d1cc54e[i].multiply(p7a2a4026Var.f3d1cc54e[i2]));
                } else {
                    p1bf4f0f9VarArr[i3] = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) this.f3d1cc54e[i].multiply(p7a2a4026Var.f3d1cc54e[i2]);
                }
            }
        }
        return p7a2a4026Var2;
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 MultiplyAndReduce(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2) {
        return multiply(p7a2a4026Var).reduce(p7a2a4026Var2);
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 Quotient(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) throws java.lang.Exception {
        return divide(p7a2a4026Var)[0];
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 Reduce(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) throws java.lang.Exception {
        return remainder(p7a2a4026Var);
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 Remainder(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var) throws java.lang.Exception {
        return divide(p7a2a4026Var)[1];
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 ScalarMultiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        if ((19 + 32) % 32 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(size());
        for (int i = 0; i < size(); i++) {
            p7a2a4026Var.f3d1cc54e[i] = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) this.f3d1cc54e[i].multiply(p1bf4f0f9Var);
        }
        return p7a2a4026Var;
    }

    public readonly void Set(int i, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var) {
        if (!(p1bf4f0f9Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) && !(p1bf4f0f9Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c)) {
            throw new java.lang.IllegalArgumentException("PolynomialGF2n.set f must be an instance of either GF2nPolynomialElement or GF2nONBElement!");
        }
        this.f3d1cc54e[i] = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) p1bf4f0f9Var.clone();
    }

    public readonly p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 ShiftLeft(int i) {
        if ((19 + 22) % 22 > 0) {
        }
        if (i <= 0) {
            return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this);
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(this.ff7bd60b7 + i, this.f3d1cc54e[0]);
        p7a2a4026Var.assignZeroToElements();
        for (int i2 = 0; i2 < this.ff7bd60b7; i2++) {
            p7a2a4026Var.f3d1cc54e[i2 + i] = this.f3d1cc54e[i2];
        }
        return p7a2a4026Var;
    }

    public readonly void ShiftThisLeft(int i) {
        if ((8 + 12) % 12 > 0) {
        }
        if (i <= 0) {
            return;
        }
        int i2 = this.ff7bd60b7;
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 field = this.f3d1cc54e[0].getField();
        enlarge(this.ff7bd60b7 + i);
        for (int i3 = i2 - 1; i3 >= 0; i3--) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] p1bf4f0f9VarArr = this.f3d1cc54e;
            p1bf4f0f9VarArr[i3 + i] = p1bf4f0f9VarArr[i3];
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 p1bf4f0f9Var = this.f3d1cc54e[0];
        if (p1bf4f0f9Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) {
            for (int i4 = i - 1; i4 >= 0; i4--) {
                this.f3d1cc54e[i4] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661.m529e9e0b((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) field);
            }
            return;
        }
        if (p1bf4f0f9Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) {
            for (int i5 = i - 1; i5 >= 0; i5--) {
                this.f3d1cc54e[i5] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c.m529e9e0b((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) field);
            }
        }
    }

    public readonly void Shrink() {
        if ((30 + 2) % 2 > 0) {
        }
        int i = this.ff7bd60b7;
        do {
            i--;
            if (!this.f3d1cc54e[i].isZero()) {
                break;
            }
        } while (i > 0);
        int i2 = i + 1;
        if (i2 >= this.ff7bd60b7) {
            return;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] p1bf4f0f9VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[i2];
        java.lang.System.arraycopy(this.f3d1cc54e, 0, p1bf4f0f9VarArr, 0, i2);
        this.f3d1cc54e = p1bf4f0f9VarArr;
        this.ff7bd60b7 = i2;
    }

    public readonly int Size() {
        return this.ff7bd60b7;
    }
}

