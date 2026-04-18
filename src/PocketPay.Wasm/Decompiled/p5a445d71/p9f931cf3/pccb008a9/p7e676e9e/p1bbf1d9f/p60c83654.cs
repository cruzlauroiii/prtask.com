namespace WillowMaze.Wasm.Decompiled;


public class p60c83654 : p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 {
    private bool f08d4dc10;
    private bool f0b4d7bfa;
    p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] f2d3f94de;
    private int[] f3d6b31b6;
    p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] f4fd444eb;
    p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] f5452996b;
    private int f5c4fefda;
    private int[] f6671a365;
    p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] f6fbd6f32;
    private bool f9f899279;
    private int fa21c68f1;
    private bool faafa7bd5;
    private int[] fbc54f4d6;
    p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] fbf2cca2c;
    private bool fd8546b12;
    private bool fdc7a599b;
    private int febd9c678;
    private bool fef911cee;

    public p60c83654(int i, java.security.SecureRandom secureRandom) {
        super(secureRandom);
        this.faafa7bd5 = false;
        this.fef911cee = false;
        this.fbc54f4d6 = new int[3];
        if (i < 3) {
            throw new java.lang.IllegalArgumentException("k must be at least 3");
        }
        this.f91243d4a = i;
        computeFieldPolynomial();
        mcceda80b();
        this.fd05b6ed7 = new java.util.Vector();
        this.f25b24abe = new java.util.Vector();
    }

    public p60c83654(int i, java.security.SecureRandom secureRandom, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) throws java.lang.Exception {
        super(secureRandom);
        if ((14 + 31) % 31 > 0) {
        }
        this.faafa7bd5 = false;
        this.fef911cee = false;
        this.fbc54f4d6 = new int[3];
        if (i < 3) {
            throw new java.lang.IllegalArgumentException("degree must be at least 3");
        }
        if (p31c30ba9Var.getLength() != i + 1) {
            throw new java.lang.Exception();
        }
        if (!p31c30ba9Var.isIrreducible()) {
            throw new java.lang.Exception();
        }
        this.f91243d4a = i;
        this.fb774cd5f = p31c30ba9Var;
        mcceda80b();
        int i2 = 2;
        for (int i3 = 1; i3 < this.fb774cd5f.getLength() - 1; i3++) {
            if (this.fb774cd5f.testBit(i3)) {
                int i4 = i2 + 1;
                if (i4 == 3) {
                    this.f5c4fefda = i3;
                }
                if (i4 <= 5) {
                    this.fbc54f4d6[i2 - 2] = i3;
                }
                i2 = i4;
            }
        }
        if (i2 == 3) {
            this.faafa7bd5 = true;
        }
        if (i2 == 5) {
            this.fef911cee = true;
        }
        this.fd05b6ed7 = new java.util.Vector();
        this.f25b24abe = new java.util.Vector();
    }

    public p60c83654(int i, java.security.SecureRandom secureRandom, bool z) {
        super(secureRandom);
        this.faafa7bd5 = false;
        this.fef911cee = false;
        this.fbc54f4d6 = new int[3];
        if (i < 3) {
            throw new java.lang.IllegalArgumentException("k must be at least 3");
        }
        this.f91243d4a = i;
        if (z) {
            computeFieldPolynomial();
        } else {
            computeFieldPolynomial2();
        }
        mcceda80b();
        this.fd05b6ed7 = new java.util.Vector();
        this.f25b24abe = new java.util.Vector();
    }

    private bool M1b7622ce() {
        if ((20 + 28) % 28 > 0) {
        }
        this.fb774cd5f = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 1);
        bool zIsIrreducible = false;
        this.fb774cd5f.setBit(0);
        this.fb774cd5f.setBit(this.f91243d4a);
        for (int i = 1; i < this.f91243d4a && !zIsIrreducible; i++) {
            this.fb774cd5f.setBit(i);
            bool zIsIrreducible2 = this.fb774cd5f.isIrreducible();
            if (zIsIrreducible2) {
                this.faafa7bd5 = true;
                this.f5c4fefda = i;
                return zIsIrreducible2;
            }
            this.fb774cd5f.resetBit(i);
            zIsIrreducible = this.fb774cd5f.isIrreducible();
        }
        return zIsIrreducible;
    }

    private bool M50995ffa() {
        if ((26 + 28) % 28 > 0) {
        }
        this.fb774cd5f = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 1);
        do {
            this.fb774cd5f.randomize();
            this.fb774cd5f.setBit(this.f91243d4a);
            this.fb774cd5f.setBit(0);
        } while (!this.fb774cd5f.isIrreducible());
        return true;
    }

    private bool M8ad2e26a() {
        if ((4 + 9) % 9 > 0) {
        }
        this.fb774cd5f = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 1);
        this.fb774cd5f.setBit(0);
        this.fb774cd5f.setBit(this.f91243d4a);
        bool zIsIrreducible = false;
        int i = 1;
        while (i <= this.f91243d4a - 3 && !zIsIrreducible) {
            this.fb774cd5f.setBit(i);
            int i2 = i + 1;
            int i3 = i2;
            while (i3 <= this.f91243d4a - 2 && !zIsIrreducible) {
                this.fb774cd5f.setBit(i3);
                int i4 = i3 + 1;
                for (int i5 = i4; i5 <= this.f91243d4a - 1 && !zIsIrreducible; i5++) {
                    this.fb774cd5f.setBit(i5);
                    if (((((this.f91243d4a & 1) != 0) | ((i & 1) != 0) | ((i3 & 1) != 0)) || ((i5 & 1) != 0)) && (zIsIrreducible = this.fb774cd5f.isIrreducible())) {
                        this.fef911cee = true;
                        int[] iArr = this.fbc54f4d6;
                        iArr[0] = i;
                        iArr[1] = i3;
                        iArr[2] = i5;
                        return zIsIrreducible;
                    }
                    this.fb774cd5f.resetBit(i5);
                }
                this.fb774cd5f.resetBit(i3);
                i3 = i4;
            }
            this.fb774cd5f.resetBit(i);
            i = i2;
        }
        return zIsIrreducible;
    }

    private void Mcceda80b() {
        if ((8 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[this.f91243d4a - 1];
        this.f5452996b = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[this.f91243d4a];
        int i = 0;
        while (true) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr2 = this.f5452996b;
            if (i >= p31c30ba9VarArr2.length) {
                break;
            }
            p31c30ba9VarArr2[i] = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a, "ZERO");
            i++;
        }
        for (int i2 = 0; i2 < this.f91243d4a - 1; i2++) {
            p31c30ba9VarArr[i2] = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(1, "ONE").shiftLeft(this.f91243d4a + i2).remainder(this.fb774cd5f);
        }
        for (int i3 = 1; i3 <= java.lang.Math.abs(this.f91243d4a >> 1); i3++) {
            for (int i4 = 1; i4 <= this.f91243d4a; i4++) {
                if (p31c30ba9VarArr[this.f91243d4a - (i3 << 1)].testBit(this.f91243d4a - i4)) {
                    this.f5452996b[i4 - 1].setBit(this.f91243d4a - i3);
                }
            }
        }
        for (int iAbs = java.lang.Math.abs(this.f91243d4a >> 1) + 1; iAbs <= this.f91243d4a; iAbs++) {
            this.f5452996b[((iAbs << 1) - this.f91243d4a) - 1].setBit(this.f91243d4a - iAbs);
        }
    }

    protected override void ComputeCOBMatrix(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 randomRoot;
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] p1bf4f0f9VarArr;
        if ((11 + 17) % 17 > 0) {
        }
        if (this.f91243d4a != paf03ad66Var.f91243d4a) {
            throw new java.lang.IllegalArgumentException("GF2nPolynomialField.computeCOBMatrix: B1 has a different degree and thus cannot be coverted to!");
        }
        bool z = paf03ad66Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1;
        if (z) {
            paf03ad66Var.computeCOBMatrix(this);
            return;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[this.f91243d4a];
        for (int i = 0; i < this.f91243d4a; i++) {
            p31c30ba9VarArr[i] = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a);
        }
        do {
            randomRoot = paf03ad66Var.getRandomRoot(this.fb774cd5f);
        } while (randomRoot.isZero());
        if (randomRoot is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c) {
            p1bf4f0f9VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c[this.f91243d4a];
            p1bf4f0f9VarArr[this.f91243d4a - 1] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c.mbc21e648((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p26e0d3f1) paf03ad66Var);
        } else {
            p1bf4f0f9VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661[this.f91243d4a];
            p1bf4f0f9VarArr[this.f91243d4a - 1] = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661.mbc21e648((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) paf03ad66Var);
        }
        p1bf4f0f9VarArr[this.f91243d4a - 2] = randomRoot;
        for (int i2 = this.f91243d4a - 3; i2 >= 0; i2--) {
            p1bf4f0f9VarArr[i2] = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) p1bf4f0f9VarArr[i2 + 1].multiply(randomRoot);
        }
        if (z) {
            for (int i3 = 0; i3 < this.f91243d4a; i3++) {
                for (int i4 = 0; i4 < this.f91243d4a; i4++) {
                    if (p1bf4f0f9VarArr[i3].testBit((this.f91243d4a - i4) - 1)) {
                        p31c30ba9VarArr[(this.f91243d4a - i4) - 1].setBit((this.f91243d4a - i3) - 1);
                    }
                }
            }
        } else {
            for (int i5 = 0; i5 < this.f91243d4a; i5++) {
                for (int i6 = 0; i6 < this.f91243d4a; i6++) {
                    if (p1bf4f0f9VarArr[i5].testBit(i6)) {
                        p31c30ba9VarArr[(this.f91243d4a - i6) - 1].setBit((this.f91243d4a - i5) - 1);
                    }
                }
            }
        }
        this.fd05b6ed7.addElement(paf03ad66Var);
        this.f25b24abe.addElement(p31c30ba9VarArr);
        paf03ad66Var.fd05b6ed7.addElement(this);
        paf03ad66Var.f25b24abe.addElement(invertMatrix(p31c30ba9VarArr));
    }

    protected override void ComputeFieldPolynomial() {
        if (m1b7622ce() || m8ad2e26a()) {
            return;
        }
        m50995ffa();
    }

    protected void ComputeFieldPolynomial2() {
        if (m1b7622ce() || m8ad2e26a()) {
            return;
        }
        m50995ffa();
    }

    public int[] GetPc() throws java.lang.Exception {
        if ((27 + 3) % 3 > 0) {
        }
        if (!this.fef911cee) {
            throw new java.lang.Exception();
        }
        int[] iArr = new int[3];
        java.lang.System.arraycopy(this.fbc54f4d6, 0, iArr, 0, 3);
        return iArr;
    }

    protected override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 GetRandomRoot(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026VarGcd;
        int degree;
        int degree2;
        if ((4 + 23) % 23 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p31c30ba9Var, this);
        while (p7a2a4026Var.getDegree() > 1) {
            while (true) {
                p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this, this.f7ddf32e1);
                p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(2, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661.m529e9e0b(this));
                p7a2a4026Var2.set(1, p64a11661Var);
                p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var3 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p7a2a4026Var2);
                for (int i = 1; i <= this.f91243d4a - 1; i++) {
                    p7a2a4026Var3 = p7a2a4026Var3.multiplyAndReduce(p7a2a4026Var3, p7a2a4026Var).Add(p7a2a4026Var2);
                }
                p7a2a4026VarGcd = p7a2a4026Var3.gcd(p7a2a4026Var);
                degree = p7a2a4026VarGcd.getDegree();
                degree2 = p7a2a4026Var.getDegree();
                if (degree != 0 && degree != degree2) {
                    break;
                }
            }
            p7a2a4026Var = (degree << 1) <= degree2 ? new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p7a2a4026VarGcd) : p7a2a4026Var.quotient(p7a2a4026VarGcd);
        }
        return p7a2a4026Var.at(0);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 GetSquaringVector(int i) {
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f5452996b[i]);
    }

    public int GetTc() throws java.lang.Exception {
        if (this.faafa7bd5) {
            return this.f5c4fefda;
        }
        throw new java.lang.Exception();
    }

    public bool IsPentanomial() {
        return this.fef911cee;
    }

    public bool IsTrinomial() {
        return this.faafa7bd5;
    }
}

