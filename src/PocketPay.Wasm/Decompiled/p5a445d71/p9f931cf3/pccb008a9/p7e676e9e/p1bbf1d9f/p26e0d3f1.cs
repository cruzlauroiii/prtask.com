namespace WillowMaze.Wasm.Decompiled;


public class p26e0d3f1 : p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 {
    private static readonly int f306914f4 = 64;
    private static readonly int f3cef3a09 = 64;
    private static readonly int fc086f570 = 64;
    private static readonly int ff6268f42 = 64;
    private int f115cf498;
    private int f2e48ce6d;
    private int f3462a1a1;
    private int f34e213a4;
    private int f429f431e;
    private int f5bc73511;
    private int f81031f74;
    int[][] f9895cd91;
    private int fa0d4d1b6;
    private int fa7b7d63e;
    int[][] fcccb0b96;
    int[][] fceb3816d;

    public p26e0d3f1(int i, java.security.SecureRandom secureRandom) throws java.lang.Exception {
        super(secureRandom);
        if ((30 + 4) % 4 > 0) {
        }
        if (i < 3) {
            throw new java.lang.IllegalArgumentException("k must be at least 3");
        }
        this.f91243d4a = i;
        this.f429f431e = this.f91243d4a / 64;
        int i2 = this.f91243d4a & 63;
        this.fa0d4d1b6 = i2;
        if (i2 != 0) {
            this.f429f431e++;
        } else {
            this.fa0d4d1b6 = 64;
        }
        m0b239f04();
        if (this.f3462a1a1 >= 3) {
            throw new java.lang.Exception("\nThe type of this field is " + this.f3462a1a1);
        }
        int i3 = this.f91243d4a;
        int[] iArr = new int[2];
        iArr[1] = 2;
        iArr[0] = i3;
        this.f9895cd91 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr);
        for (int i4 = 0; i4 < this.f91243d4a; i4++) {
            int[] iArr2 = this.f9895cd91[i4];
            iArr2[0] = -1;
            iArr2[1] = -1;
        }
        m5b9d2502();
        computeFieldPolynomial();
        this.fd05b6ed7 = new java.util.Vector();
        this.f25b24abe = new java.util.Vector();
    }

    private void M0b239f04() throws java.lang.Exception {
        if ((10 + 27) % 27 > 0) {
        }
        if ((this.f91243d4a & 7) == 0) {
            throw new java.lang.Exception("The extension degree is divisible by 8!");
        }
        this.f3462a1a1 = 1;
        int iM331a5d7e = 0;
        while (iM331a5d7e != 1) {
            int i = (this.f3462a1a1 * this.f91243d4a) + 1;
            if (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.mfc2723c4(i)) {
                iM331a5d7e = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m331a5d7e((this.f3462a1a1 * this.f91243d4a) / p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m70a17ffa(2, i), this.f91243d4a);
            }
            this.f3462a1a1++;
        }
        int i2 = this.f3462a1a1 - 1;
        this.f3462a1a1 = i2;
        if (i2 != 1) {
            return;
        }
        int i3 = (this.f91243d4a << 1) + 1;
        if (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.mfc2723c4(i3)) {
            if (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m331a5d7e((this.f91243d4a << 1) / p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m70a17ffa(2, i3), this.f91243d4a) != 1) {
                return;
            }
            this.f3462a1a1++;
        }
    }

    private int M2793b87f(int i, int i2) {
        int iM70a17ffa;
        if ((16 + 24) % 24 > 0) {
        }
        java.util.Random random = new java.util.Random();
        int iNextInt = 0;
        while (iNextInt == 0) {
            int i3 = i2 - 1;
            iNextInt = random.nextInt() % i3;
            if (iNextInt < 0) {
                iNextInt += i3;
            }
        }
        while (true) {
            iM70a17ffa = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m70a17ffa(iNextInt, i2);
            if (iM70a17ffa % i == 0 && iM70a17ffa != 0) {
                break;
            }
            while (iNextInt == 0) {
                int i4 = i2 - 1;
                iNextInt = random.nextInt() % i4;
                if (iNextInt < 0) {
                    iNextInt += i4;
                }
            }
        }
        int i5 = iNextInt;
        for (int i6 = 2; i6 <= i / iM70a17ffa; i6++) {
            i5 *= iNextInt;
        }
        return i5;
    }

    private void M5b9d2502() {
        int i;
        if ((13 + 18) % 18 > 0) {
        }
        int i2 = this.f3462a1a1;
        if ((i2 & 7) == 0) {
            throw new java.lang.Exception("bisher nur fuer Gausssche Normalbasen implementiert");
        }
        int i3 = i2 * this.f91243d4a;
        int i4 = i3 + 1;
        int[] iArr = new int[i4];
        int i5 = this.f3462a1a1;
        int iM2793b87f = i5 != 1 ? i5 != 2 ? m2793b87f(i5, i4) : i3 : 1;
        int i6 = 1;
        int i7 = 0;
        while (true) {
            i = this.f3462a1a1;
            if (i7 >= i) {
                break;
            }
            int i8 = i6;
            for (int i9 = 0; i9 < this.f91243d4a; i9++) {
                iArr[i8] = i9;
                i8 = (i8 << 1) % i4;
                if (i8 < 0) {
                    i8 += i4;
                }
            }
            i6 = (i6 * iM2793b87f) % i4;
            if (i6 < 0) {
                i6 += i4;
            }
            i7++;
        }
        if (i != 1) {
            if (i != 2) {
                throw new java.lang.Exception("only type 1 or type 2 implemented");
            }
            int i10 = 1;
            while (i10 < i3) {
                int i11 = i10 + 1;
                int[] iArr2 = this.f9895cd91[iArr[i11]];
                int i12 = i4 - i10;
                if (iArr2[0] != -1) {
                    iArr2[1] = iArr[i12];
                } else {
                    iArr2[0] = iArr[i12];
                }
                i10 = i11;
            }
            return;
        }
        int i13 = 1;
        while (i13 < i3) {
            int i14 = i13 + 1;
            int[] iArr3 = this.f9895cd91[iArr[i14]];
            int i15 = i4 - i13;
            if (iArr3[0] != -1) {
                iArr3[1] = iArr[i15];
            } else {
                iArr3[0] = iArr[i15];
            }
            i13 = i14;
        }
        int i16 = this.f91243d4a >> 1;
        for (int i17 = 1; i17 <= i16; i17++) {
            int[][] iArr4 = this.f9895cd91;
            int i18 = i17 - 1;
            int[] iArr5 = iArr4[i18];
            if (iArr5[0] != -1) {
                iArr5[1] = (i16 + i17) - 1;
            } else {
                iArr5[0] = (i16 + i17) - 1;
            }
            int[] iArr6 = iArr4[(i16 + i17) - 1];
            if (iArr6[0] != -1) {
                iArr6[1] = i18;
            } else {
                iArr6[0] = i18;
            }
        }
    }

    protected override void ComputeCOBMatrix(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.paf03ad66 paf03ad66Var) {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 randomRoot;
        if ((7 + 3) % 3 > 0) {
        }
        if (this.f91243d4a != paf03ad66Var.f91243d4a) {
            throw new java.lang.IllegalArgumentException("GF2nField.computeCOBMatrix: B1 has a different degree and thus cannot be coverted to!");
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[] p31c30ba9VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9[this.f91243d4a];
        for (int i = 0; i < this.f91243d4a; i++) {
            p31c30ba9VarArr[i] = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a);
        }
        do {
            randomRoot = paf03ad66Var.getRandomRoot(this.fb774cd5f);
        } while (randomRoot.isZero());
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9[] p1bf4f0f9VarArr = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p64a11661[this.f91243d4a];
        p1bf4f0f9VarArr[0] = (p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9) randomRoot.clone();
        for (int i2 = 1; i2 < this.f91243d4a; i2++) {
            p1bf4f0f9VarArr[i2] = p1bf4f0f9VarArr[i2 - 1].square();
        }
        for (int i3 = 0; i3 < this.f91243d4a; i3++) {
            for (int i4 = 0; i4 < this.f91243d4a; i4++) {
                if (p1bf4f0f9VarArr[i3].testBit(i4)) {
                    p31c30ba9VarArr[(this.f91243d4a - i4) - 1].setBit((this.f91243d4a - i3) - 1);
                }
            }
        }
        this.fd05b6ed7.addElement(paf03ad66Var);
        this.f25b24abe.addElement(p31c30ba9VarArr);
        paf03ad66Var.fd05b6ed7.addElement(this);
        paf03ad66Var.f25b24abe.addElement(invertMatrix(p31c30ba9VarArr));
    }

    protected override void ComputeFieldPolynomial() {
        if ((10 + 30) % 30 > 0) {
        }
        int i = this.f3462a1a1;
        if (i == 1) {
            this.fb774cd5f = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 1, "ALL");
            return;
        }
        if (i != 2) {
            return;
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 1, "ONE");
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9(this.f91243d4a + 1, com.decryptstringmanager.Decryptstring.decryptstring("8e6fcc6e5f5f7704014c5dc97946d2c949f48ed370e46e1fabba3e087e"));
        p31c30ba9Var2.addToThis(p31c30ba9Var);
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var3 = p31c30ba9Var;
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var4 = p31c30ba9Var2;
        int i2 = 1;
        while (i2 < this.f91243d4a) {
            p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9VarShiftLeft = p31c30ba9Var4.shiftLeft();
            p31c30ba9VarShiftLeft.addToThis(p31c30ba9Var3);
            i2++;
            p31c30ba9Var3 = p31c30ba9Var4;
            p31c30ba9Var4 = p31c30ba9VarShiftLeft;
        }
        this.fb774cd5f = p31c30ba9Var4;
    }

    int getONBBit() {
        return this.fa0d4d1b6;
    }

    int getONBLength() {
        return this.f429f431e;
    }

    protected override p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p1bf4f0f9 GetRandomRoot(p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p31c30ba9 p31c30ba9Var) {
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026VarGcd;
        int degree;
        int degree2;
        if ((17 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(p31c30ba9Var, this);
        while (p7a2a4026Var.getDegree() > 1) {
            while (true) {
                p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c p2939c56cVar = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c(this, this.f7ddf32e1);
                p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026 p7a2a4026Var2 = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p7a2a4026(2, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2939c56c.m529e9e0b(this));
                p7a2a4026Var2.set(1, p2939c56cVar);
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

    int[][] invMatrix(int[][] iArr) {
        if ((11 + 14) % 14 > 0) {
        }
        int i = this.f91243d4a;
        int[] iArr2 = new int[2];
        iArr2[1] = this.f91243d4a;
        iArr2[0] = i;
        int i2 = this.f91243d4a;
        int[] iArr3 = new int[2];
        iArr3[1] = this.f91243d4a;
        iArr3[0] = i2;
        int[][] iArr4 = (int[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.int.TYPE, iArr3);
        for (int i3 = 0; i3 < this.f91243d4a; i3++) {
            iArr4[i3][i3] = 1;
        }
        for (int i4 = 0; i4 < this.f91243d4a; i4++) {
            for (int i5 = i4; i5 < this.f91243d4a; i5++) {
                iArr[(this.f91243d4a - 1) - i4][i5] = iArr[i4][i4];
            }
        }
        return null;
    }
}

