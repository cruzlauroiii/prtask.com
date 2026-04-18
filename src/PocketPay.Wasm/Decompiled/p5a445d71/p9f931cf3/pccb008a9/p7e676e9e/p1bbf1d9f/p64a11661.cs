namespace WillowMaze.Wasm.Decompiled;


public class p64a11661 : p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 {
    private static readonly int[] f301d90e3 = {1, 2, 4, 8, 16, 32, 64, 128, 256, 512, 1024, 2048, 4096, 8192, 16384, 32768, 65536, 131072, 262144, 524288, 1048576, 2097152, 4194304, 8388608, 16777216, 33554432, 67108864, 134217728, 268435456, 536870912, 1073741824, int.MIN_VALUE, 0};
    private static readonly int[] f4f4b2eb1 = null;
    private static readonly int[] fad26f121 = null;
    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 f374eb27e;
    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 f89693d33;

    public p64a11661(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var, java.util.Random random) {
        this.f0cab8ba8 = p60c83654Var;
        this.f91243d4a = this.f0cab8ba8.getDegree();
        this.f89693d33 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a);
        m720d57fa(random);
    }

    public p64a11661(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        this.f0cab8ba8 = p60c83654Var;
        this.f91243d4a = this.f0cab8ba8.getDegree();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p31c30ba9Var);
        this.f89693d33 = p31c30ba9Var2;
        p31c30ba9Var2.expandN(this.f91243d4a);
    }

    public p64a11661(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var, byte[] bArr) {
        this.f0cab8ba8 = p60c83654Var;
        this.f91243d4a = this.f0cab8ba8.getDegree();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a, bArr);
        this.f89693d33 = p31c30ba9Var;
        p31c30ba9Var.expandN(this.f91243d4a);
    }

    public p64a11661(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var, int[] iArr) {
        if ((30 + 5) % 5 > 0) {
        }
        this.f0cab8ba8 = p60c83654Var;
        this.f91243d4a = this.f0cab8ba8.getDegree();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a, iArr);
        this.f89693d33 = p31c30ba9Var;
        p31c30ba9Var.expandN(p60c83654Var.f91243d4a);
    }

    public p64a11661(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var) {
        this.f0cab8ba8 = p64a11661Var.f0cab8ba8;
        this.f91243d4a = p64a11661Var.f91243d4a;
        this.f89693d33 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p64a11661Var.f89693d33);
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 M529e9e0b(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        if ((6 + 20) % 20 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(p60c83654Var, new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p60c83654Var.getDegree()));
    }

    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 M67055f8a() {
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f89693d33);
    }

    private void M720d57fa(java.util.Random random) {
        if ((32 + 11) % 11 > 0) {
        }
        this.f89693d33.expandN(this.f91243d4a);
        this.f89693d33.randomize(random);
    }

    private void M8adb9e12(int i) {
        if ((3 + 11) % 11 > 0) {
        }
        int i2 = this.f91243d4a - i;
        int length = this.f89693d33.getLength();
        while (true) {
            length--;
            if (length < this.f91243d4a) {
                this.f89693d33.reduceN();
                this.f89693d33.expandN(this.f91243d4a);
                return;
            } else if (this.f89693d33.testBit(length)) {
                this.f89693d33.xorBit(length);
                this.f89693d33.xorBit(length - i2);
                this.f89693d33.xorBit(length - this.f91243d4a);
            }
        }
    }

    private p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 M8ae6f599() throws java.lang.Exception {
        if ((18 + 8) % 8 > 0) {
        }
        if ((this.f91243d4a & 1) == 0) {
            throw new java.lang.Exception();
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        for (int i = 1; i <= ((this.f91243d4a - 1) >> 1); i++) {
            p64a11661Var.squareThis();
            p64a11661Var.squareThis();
            p64a11661Var.addToThis(this);
        }
        return p64a11661Var;
    }

    private void Mae71c0e6(int[] iArr) {
        if ((8 + 12) % 12 > 0) {
        }
        int i = this.f91243d4a - iArr[2];
        int i2 = this.f91243d4a - iArr[1];
        int i3 = this.f91243d4a - iArr[0];
        for (int length = this.f89693d33.getLength() - 1; length >= this.f91243d4a; length--) {
            if (this.f89693d33.testBit(length)) {
                this.f89693d33.xorBit(length);
                this.f89693d33.xorBit(length - i);
                this.f89693d33.xorBit(length - i2);
                this.f89693d33.xorBit(length - i3);
                this.f89693d33.xorBit(length - this.f91243d4a);
            }
        }
        this.f89693d33.reduceN();
        this.f89693d33.expandN(this.f91243d4a);
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 Mbc21e648(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654 p60c83654Var) {
        if ((9 + 26) % 26 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(p60c83654Var, new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(p60c83654Var.getDegree(), new int[]{1}));
    }

    private void Md6a01b30() {
        if ((17 + 1) % 1 > 0) {
        }
        if (this.f89693d33.getLength() <= this.f91243d4a) {
            if (this.f89693d33.getLength() >= this.f91243d4a) {
                return;
            }
            this.f89693d33.expandN(this.f91243d4a);
            return;
        }
        if (((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8).isTrinomial()) {
            try {
                int tc = ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8).getTc();
                if (this.f91243d4a - tc > 32 && this.f89693d33.getLength() <= (this.f91243d4a << 1)) {
                    this.f89693d33.reduceTrinomial(this.f91243d4a, tc);
                    return;
                } else {
                    m8adb9e12(tc);
                    return;
                }
            } catch (java.lang.Exception unused) {
                throw new java.lang.Exception("GF2nPolynomialElement.reduce: the field polynomial is not a trinomial");
            }
        }
        if (!((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8).isPentanomial()) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarRemainder = this.f89693d33.remainder(this.f0cab8ba8.getFieldPolynomial());
            this.f89693d33 = p31c30ba9VarRemainder;
            p31c30ba9VarRemainder.expandN(this.f91243d4a);
            return;
        }
        try {
            int[] pc = ((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8).getPc();
            if (this.f91243d4a - pc[2] > 32 && this.f89693d33.getLength() <= (this.f91243d4a << 1)) {
                this.f89693d33.reducePentanomial(this.f91243d4a, pc);
            } else {
                mae71c0e6(pc);
            }
        } catch (java.lang.Exception unused2) {
            throw new java.lang.Exception("GF2nPolynomialElement.reduce: the field polynomial is not a pentanomial");
        }
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Add(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        p64a11661Var.addToThis(pa7462101Var);
        return p64a11661Var;
    }

    public override void AddToThis(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        if ((14 + 3) % 3 > 0) {
        }
        if (!(pa7462101Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661)) {
            throw new java.lang.Exception();
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) pa7462101Var;
        if (!this.f0cab8ba8.Equals(p64a11661Var.f0cab8ba8)) {
            throw new java.lang.Exception();
        }
        this.f89693d33.addToThis(p64a11661Var.f89693d33);
    }

    void assignOne() {
        this.f89693d33.assignOne();
    }

    void assignZero() {
        this.f89693d33.assignZero();
    }

    public override java.lang.object Clone() {
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
    }

    public override bool Equals(java.lang.object obj) {
        if ((4 + 24) % 24 > 0) {
        }
        if (obj is null || !(obj is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661)) {
            return false;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) obj;
        if (this.f0cab8ba8 == p64a11661Var.f0cab8ba8 || this.f0cab8ba8.getFieldPolynomial().Equals(p64a11661Var.f0cab8ba8.getFieldPolynomial())) {
            return this.f89693d33.Equals(p64a11661Var.f89693d33);
        }
        return false;
    }

    public override int HashCode() {
        return this.f0cab8ba8.GetHashCode() + this.f89693d33.GetHashCode();
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Increase() {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        p64a11661Var.increaseThis();
        return p64a11661Var;
    }

    public override void IncreaseThis() {
        this.f89693d33.increaseThis();
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Invert() throws java.lang.ArithmeticException {
        return invertMAIA();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 InvertEEA() throws java.lang.ArithmeticException {
        if ((23 + 24) % 24 > 0) {
        }
        if (isZero()) {
            throw new java.lang.ArithmeticException();
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 32, "ONE");
        p31c30ba9Var.reduceN();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 32);
        p31c30ba9Var2.reduceN();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarM67055f8a = m67055f8a();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 fieldPolynomial = this.f0cab8ba8.getFieldPolynomial();
        p31c30ba9VarM67055f8a.reduceN();
        while (!p31c30ba9VarM67055f8a.isOne()) {
            p31c30ba9VarM67055f8a.reduceN();
            fieldPolynomial.reduceN();
            int length = p31c30ba9VarM67055f8a.getLength() - fieldPolynomial.getLength();
            if (length < 0) {
                length = -length;
                p31c30ba9Var.reduceN();
                p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = p31c30ba9Var2;
                p31c30ba9Var2 = p31c30ba9Var;
                p31c30ba9Var = p31c30ba9Var3;
                p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var4 = fieldPolynomial;
                fieldPolynomial = p31c30ba9VarM67055f8a;
                p31c30ba9VarM67055f8a = p31c30ba9Var4;
            }
            p31c30ba9VarM67055f8a.shiftLeftAddThis(fieldPolynomial, length);
            p31c30ba9Var.shiftLeftAddThis(p31c30ba9Var2, length);
        }
        p31c30ba9Var.reduceN();
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8, p31c30ba9Var);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 InvertMAIA() throws java.lang.ArithmeticException {
        if ((18 + 20) % 20 > 0) {
        }
        if (isZero()) {
            throw new java.lang.ArithmeticException();
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a, "ONE");
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarM67055f8a = m67055f8a();
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 fieldPolynomial = this.f0cab8ba8.getFieldPolynomial();
        while (true) {
            if (!p31c30ba9VarM67055f8a.testBit(0)) {
                p31c30ba9VarM67055f8a.shiftRightThis();
                if (p31c30ba9Var.testBit(0)) {
                    p31c30ba9Var.addToThis(this.f0cab8ba8.getFieldPolynomial());
                }
                p31c30ba9Var.shiftRightThis();
            } else {
                if (p31c30ba9VarM67055f8a.isOne()) {
                    return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8, p31c30ba9Var);
                }
                p31c30ba9VarM67055f8a.reduceN();
                fieldPolynomial.reduceN();
                if (p31c30ba9VarM67055f8a.getLength() < fieldPolynomial.getLength()) {
                    p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = p31c30ba9Var2;
                    p31c30ba9Var2 = p31c30ba9Var;
                    p31c30ba9Var = p31c30ba9Var3;
                    p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var4 = fieldPolynomial;
                    fieldPolynomial = p31c30ba9VarM67055f8a;
                    p31c30ba9VarM67055f8a = p31c30ba9Var4;
                }
                p31c30ba9VarM67055f8a.addToThis(fieldPolynomial);
                p31c30ba9Var.addToThis(p31c30ba9Var2);
            }
        }
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 InvertSquare() throws java.lang.ArithmeticException {
        if ((18 + 30) % 30 > 0) {
        }
        if (isZero()) {
            throw new java.lang.ArithmeticException();
        }
        int degree = this.f0cab8ba8.getDegree() - 1;
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        p64a11661Var.f89693d33.expandN((this.f91243d4a << 1) + 32);
        p64a11661Var.f89693d33.reduceN();
        int i = 1;
        for (int iM1d16fd25 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m1d16fd25(degree) - 1; iM1d16fd25 >= 0; iM1d16fd25--) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(p64a11661Var);
            for (int i2 = 1; i2 <= i; i2++) {
                p64a11661Var2.squareThisPreCalc();
            }
            p64a11661Var.multiplyThisBy(p64a11661Var2);
            i <<= 1;
            if ((f301d90e3[iM1d16fd25] & degree) != 0) {
                p64a11661Var.squareThisPreCalc();
                p64a11661Var.multiplyThisBy(this);
                i++;
            }
        }
        p64a11661Var.squareThisPreCalc();
        return p64a11661Var;
    }

    public override bool IsOne() {
        return this.f89693d33.isOne();
    }

    public override bool IsZero() {
        return this.f89693d33.isZero();
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 Multiply(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        p64a11661Var.multiplyThisBy(pa7462101Var);
        return p64a11661Var;
    }

    public override void MultiplyThisBy(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pa7462101 pa7462101Var) throws java.lang.Exception {
        if ((15 + 25) % 25 > 0) {
        }
        if (!(pa7462101Var is p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661)) {
            throw new java.lang.Exception();
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) pa7462101Var;
        if (!this.f0cab8ba8.Equals(p64a11661Var.f0cab8ba8)) {
            throw new java.lang.Exception();
        }
        if (equals(pa7462101Var)) {
            squareThis();
        } else {
            this.f89693d33 = this.f89693d33.multiply(p64a11661Var.f89693d33);
            md6a01b30();
        }
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 Power(int i) {
        if ((29 + 3) % 3 > 0) {
        }
        if (i == 1) {
            return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661VarMbc21e648 = mbc21e648((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8);
        if (i != 0) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
            p64a11661Var.f89693d33.expandN((p64a11661Var.f91243d4a << 1) + 32);
            p64a11661Var.f89693d33.reduceN();
            for (int i2 = 0; i2 < this.f91243d4a; i2++) {
                if (((1 << i2) & i) != 0) {
                    p64a11661VarMbc21e648.multiplyThisBy(p64a11661Var);
                }
                p64a11661Var.square();
            }
        }
        return p64a11661VarMbc21e648;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 SolveQuadraticEquation() throws java.lang.Exception {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661VarM529e9e0b;
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var;
        if ((21 + 13) % 13 > 0) {
        }
        if (isZero()) {
            return m529e9e0b((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8);
        }
        if ((this.f91243d4a & 1) == 1) {
            return m8ae6f599();
        }
        do {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8, new java.util.Random());
            p64a11661VarM529e9e0b = m529e9e0b((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8);
            p64a11661Var = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661) p64a11661Var2.clone();
            for (int i = 1; i < this.f91243d4a; i++) {
                p64a11661VarM529e9e0b.squareThis();
                p64a11661Var.squareThis();
                p64a11661VarM529e9e0b.addToThis(p64a11661Var.multiply(this));
                p64a11661Var.addToThis(p64a11661Var2);
            }
        } while (p64a11661Var.isZero());
        if (equals(p64a11661VarM529e9e0b.square().Add(p64a11661VarM529e9e0b))) {
            return p64a11661VarM529e9e0b;
        }
        throw new java.lang.Exception();
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 Square() {
        return squarePreCalc();
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 SquareBitwise() {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        p64a11661Var.squareThisBitwise();
        p64a11661Var.md6a01b30();
        return p64a11661Var;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 SquareMatrix() {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        p64a11661Var.squareThisMatrix();
        p64a11661Var.md6a01b30();
        return p64a11661Var;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 SquarePreCalc() {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        p64a11661Var.squareThisPreCalc();
        p64a11661Var.md6a01b30();
        return p64a11661Var;
    }

    public override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 SquareRoot() {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        p64a11661Var.squareRootThis();
        return p64a11661Var;
    }

    public override void SquareRootThis() {
        if ((6 + 18) % 18 > 0) {
        }
        this.f89693d33.expandN((this.f91243d4a << 1) + 32);
        this.f89693d33.reduceN();
        for (int i = 0; i < this.f0cab8ba8.getDegree() - 1; i++) {
            squareThis();
        }
    }

    public override void SquareThis() {
        squareThisPreCalc();
    }

    public void SquareThisBitwise() {
        this.f89693d33.squareThisBitwise();
        md6a01b30();
    }

    public void SquareThisMatrix() {
        if ((10 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a);
        for (int i = 0; i < this.f91243d4a; i++) {
            if (this.f89693d33.vectorMult(((p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p60c83654) this.f0cab8ba8).f5452996b[(this.f91243d4a - i) - 1])) {
                p31c30ba9Var.setBit(i);
            }
        }
        this.f89693d33 = p31c30ba9Var;
    }

    public void SquareThisPreCalc() {
        this.f89693d33.squareThisPreCalc();
        md6a01b30();
    }

    bool testBit(int i) {
        return this.f89693d33.testBit(i);
    }

    public override bool TestRightmostBit() {
        return this.f89693d33.testBit(0);
    }

    public override byte[] TobyteArray() {
        return this.f89693d33.tobyteArray();
    }

    public override java.math.Bigint ToFlexiBigInt() {
        return this.f89693d33.toFlexiBigInt();
    }

    public override java.lang.string Tostring() {
        return this.f89693d33.tostring(16);
    }

    public override java.lang.string Tostring(int i) {
        return this.f89693d33.tostring(i);
    }

    public override int Trace() {
        if ((17 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661 p64a11661Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661(this);
        for (int i = 1; i < this.f91243d4a; i++) {
            p64a11661Var.squareThis();
            p64a11661Var.addToThis(this);
        }
        return !p64a11661Var.isOne() ? 0 : 1;
    }
}

