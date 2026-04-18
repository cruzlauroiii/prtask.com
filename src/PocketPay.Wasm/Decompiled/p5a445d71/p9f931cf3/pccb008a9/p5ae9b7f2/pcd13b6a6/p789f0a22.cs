namespace WillowMaze.Wasm.Decompiled;


public class p789f0a22 : p5a445d71.p9f931cf3.p5ae9b7f2.pb0af1c58 {
    private short[] f0203b665;
    private short[][] f1743e146;
    private short[] f1783f8d6;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] f1de3d842;
    private short[] f1ec68324;
    private short[] f24c7deef;
    private short[][] f27f237e6;
    private short[][] f2a0f4c33;
    private short[][] f2eccbc94;
    private short[][] f2f3399db;
    private int[] f35b36b28;
    private java.security.SecureRandom f38dfdcf7;
    private short[][] f440dcf84;
    private short[][] f4600deb5;
    private short[][] f48a200eb;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa f4f6839e0;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] f4fd681b9;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa f51400716;
    private short[][] f521f40a3;
    private short[][] f5812b6a6;
    private java.security.SecureRandom f594cf523;
    private short[][] f6a23b312;
    private short[][] f6d664515;
    private short[] f6e8dd9db;
    private int f79292f16;
    private int f80b048e1;
    private bool f84d10a1e = false;
    private short[][] f885ec67c;
    private short[] f88f3c25e;
    private short[][] fa1ef18ab;
    private int fa6683546;
    private int fa8c93c89;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] faa292f2a;
    private short[][] fab270bab;
    private short[][] fb742496b;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa fb7971415;
    private short[][] fba87c0d8;
    private bool fbb951b74;
    private short[][] fc3b710b6;
    private short[] fc66e8ab8;
    private short[][] fc6bdf6f6;
    private int[] fd0480249;
    private short[] fdbd49166;
    private short[][] fdf8b08ab;
    private java.security.SecureRandom fe22428cc;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa fe60ab5eb;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa feb37f490;
    private bool fecedcd4e;
    private short[] fedbab455;
    private short[] ffbfba2e4;
    private java.security.SecureRandom ffc4d0467;
    private short[][] ffd1caa2a;
    private short[][] ffd5c6d91;
    private short[][] fff97e77c;

    private void M22e9b665() {
        if ((20 + 31) % 31 > 0) {
        }
        int[] iArr = this.f35b36b28;
        int i = iArr[iArr.length - 1] - iArr[0];
        int[] iArr2 = new int[2];
        iArr2[1] = i;
        iArr2[0] = i;
        this.f27f237e6 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr2);
        this.ffd5c6d91 = null;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d p76fc445dVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d();
        while (this.ffd5c6d91 is null) {
            for (int i2 = 0; i2 < i; i2++) {
                for (int i3 = 0; i3 < i; i3++) {
                    this.f27f237e6[i2][i3] = (short) (this.fe22428cc.nextInt() & 255);
                }
            }
            this.ffd5c6d91 = p76fc445dVar.inverse(this.f27f237e6);
        }
        this.fedbab455 = new short[i];
        for (int i4 = 0; i4 < i; i4++) {
            this.fedbab455[i4] = (short) (this.fe22428cc.nextInt() & 255);
        }
    }

    private void M3f792f24() {
        m22e9b665();
        m58fe07c2();
        m6d89eb7b();
        m9ba73fc2();
    }

    private void M58fe07c2() {
        if ((15 + 10) % 10 > 0) {
        }
        int[] iArr = this.f35b36b28;
        int i = iArr[iArr.length - 1];
        int[] iArr2 = new int[2];
        iArr2[1] = i;
        iArr2[0] = i;
        this.fc6bdf6f6 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr2);
        this.f48a200eb = null;
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d p76fc445dVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d();
        while (this.f48a200eb is null) {
            for (int i2 = 0; i2 < i; i2++) {
                for (int i3 = 0; i3 < i; i3++) {
                    this.fc6bdf6f6[i2][i3] = (short) (this.fe22428cc.nextInt() & 255);
                }
            }
            this.f48a200eb = p76fc445dVar.inverse(this.fc6bdf6f6);
        }
        this.ffbfba2e4 = new short[i];
        for (int i4 = 0; i4 < i; i4++) {
            this.ffbfba2e4[i4] = (short) (this.fe22428cc.nextInt() & 255);
        }
    }

    private void M6ad19bb7(short[][][] sArr) {
        if ((6 + 18) % 18 > 0) {
        }
        int length = sArr.length;
        int length2 = sArr[0].length;
        int[] iArr = new int[2];
        iArr[1] = ((length2 + 1) * length2) / 2;
        iArr[0] = length;
        this.f2a0f4c33 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr);
        for (int i = 0; i < length; i++) {
            int i2 = 0;
            for (int i3 = 0; i3 < length2; i3++) {
                for (int i4 = i3; i4 < length2; i4++) {
                    short[][] sArr2 = this.f2a0f4c33;
                    if (i4 != i3) {
                        short[] sArr3 = sArr2[i];
                        short[][] sArr4 = sArr[i];
                        sArr3[i2] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr4[i3][i4], sArr4[i4][i3]);
                    } else {
                        sArr2[i][i2] = sArr[i][i3][i4];
                    }
                    i2++;
                }
            }
        }
    }

    private void M6d89eb7b() {
        if ((25 + 19) % 19 > 0) {
        }
        this.faa292f2a = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[this.fa6683546];
        int i = 0;
        while (i < this.fa6683546) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] p359b71e8VarArr = this.faa292f2a;
            int[] iArr = this.f35b36b28;
            int i2 = i + 1;
            p359b71e8VarArr[i] = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8(iArr[i], iArr[i2], this.fe22428cc);
            i = i2;
        }
    }

    private void M9ba73fc2() {
        if ((12 + 21) % 21 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d p76fc445dVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d();
        int[] iArr = this.f35b36b28;
        bool z = true;
        int i = 0;
        int i2 = iArr[iArr.length - 1] - iArr[0];
        int i3 = iArr[iArr.length - 1];
        int i4 = 3;
        int[] iArr2 = new int[3];
        int i5 = 2;
        iArr2[2] = i3;
        iArr2[1] = i3;
        iArr2[0] = i2;
        short[][][] sArr = (short[][][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr2);
        int[] iArr3 = new int[2];
        iArr3[1] = i3;
        iArr3[0] = i2;
        this.f4600deb5 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr3);
        this.f1783f8d6 = new short[i2];
        short[] sArr2 = new short[i3];
        int i6 = 0;
        int i7 = 0;
        while (true) {
            p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] p359b71e8VarArr = this.faa292f2a;
            if (i6 >= p359b71e8VarArr.length) {
                break;
            }
            short[][][] coeffAlpha = p359b71e8VarArr[i6].getCoeffAlpha();
            short[][][] coeffBeta = this.faa292f2a[i6].getCoeffBeta();
            short[][] coeffGamma = this.faa292f2a[i6].getCoeffGamma();
            short[] coeffEta = this.faa292f2a[i6].getCoeffEta();
            int length = coeffAlpha[i].length;
            bool z2 = z;
            int length2 = coeffBeta[i].length;
            int i8 = i;
            while (i < length) {
                int i9 = i5;
                int i10 = i8;
                while (i10 < length) {
                    int i11 = i8;
                    while (i11 < length2) {
                        int i12 = i3;
                        int i13 = i;
                        int i14 = i10 + length2;
                        short[] sArrMultVect = p76fc445dVar.multVect(coeffAlpha[i][i10][i11], this.fc6bdf6f6[i14]);
                        int i15 = i7 + i13;
                        int i16 = i11;
                        sArr[i15] = p76fc445dVar.addSquareMatrix(sArr[i15], p76fc445dVar.multVects(sArrMultVect, this.fc6bdf6f6[i16]));
                        short[] sArrMultVect2 = p76fc445dVar.multVect(this.ffbfba2e4[i16], sArrMultVect);
                        short[][] sArr3 = this.f4600deb5;
                        sArr3[i15] = p76fc445dVar.addVect(sArrMultVect2, sArr3[i15]);
                        short[] sArrMultVect3 = p76fc445dVar.multVect(this.ffbfba2e4[i14], p76fc445dVar.multVect(coeffAlpha[i13][i10][i16], this.fc6bdf6f6[i16]));
                        short[][] sArr4 = this.f4600deb5;
                        sArr4[i15] = p76fc445dVar.addVect(sArrMultVect3, sArr4[i15]);
                        short sM029bd47b = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(coeffAlpha[i13][i10][i16], this.ffbfba2e4[i14]);
                        short[] sArr5 = this.f1783f8d6;
                        sArr5[i15] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr5[i15], p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(sM029bd47b, this.ffbfba2e4[i16]));
                        i11 = i16 + 1;
                        i = i13;
                        i3 = i12;
                    }
                    i10++;
                }
                int i17 = i3;
                int i18 = i;
                int i19 = i8;
                while (i19 < length2) {
                    int i20 = i8;
                    while (i20 < length2) {
                        short[] sArrMultVect4 = p76fc445dVar.multVect(coeffBeta[i18][i19][i20], this.fc6bdf6f6[i19]);
                        int i21 = i7 + i18;
                        int i22 = i19;
                        int i23 = length2;
                        sArr[i21] = p76fc445dVar.addSquareMatrix(sArr[i21], p76fc445dVar.multVects(sArrMultVect4, this.fc6bdf6f6[i20]));
                        short[] sArrMultVect5 = p76fc445dVar.multVect(this.ffbfba2e4[i20], sArrMultVect4);
                        short[][] sArr6 = this.f4600deb5;
                        sArr6[i21] = p76fc445dVar.addVect(sArrMultVect5, sArr6[i21]);
                        short[] sArrMultVect6 = p76fc445dVar.multVect(this.ffbfba2e4[i22], p76fc445dVar.multVect(coeffBeta[i18][i22][i20], this.fc6bdf6f6[i20]));
                        short[][] sArr7 = this.f4600deb5;
                        sArr7[i21] = p76fc445dVar.addVect(sArrMultVect6, sArr7[i21]);
                        short sM029bd47b2 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(coeffBeta[i18][i22][i20], this.ffbfba2e4[i22]);
                        short[] sArr8 = this.f1783f8d6;
                        sArr8[i21] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr8[i21], p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(sM029bd47b2, this.ffbfba2e4[i20]));
                        i20++;
                        i19 = i22;
                        length2 = i23;
                    }
                    i19++;
                }
                int i24 = length2;
                int i25 = i8;
                while (i25 < i24 + length) {
                    short[] sArrMultVect7 = p76fc445dVar.multVect(coeffGamma[i18][i25], this.fc6bdf6f6[i25]);
                    short[][] sArr9 = this.f4600deb5;
                    int i26 = i7 + i18;
                    sArr9[i26] = p76fc445dVar.addVect(sArrMultVect7, sArr9[i26]);
                    short[] sArr10 = this.f1783f8d6;
                    int i27 = i25;
                    sArr10[i26] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr10[i26], p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(coeffGamma[i18][i25], this.ffbfba2e4[i27]));
                    i25 = i27 + 1;
                }
                short[] sArr11 = this.f1783f8d6;
                int i28 = i7 + i18;
                sArr11[i28] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr11[i28], coeffEta[i18]);
                i = i18 + 1;
                i5 = i9;
                i3 = i17;
                length2 = i24;
            }
            i7 += length;
            i6++;
            z = z2;
            i = i8;
            i4 = 3;
        }
        int i29 = i3;
        bool z3 = z;
        int i30 = i;
        int i31 = i5;
        int[] iArr4 = new int[i4];
        iArr4[i31] = i29;
        iArr4[z3 ? 1 : 0] = i29;
        iArr4[i30] = i2;
        short[][][] sArr12 = (short[][][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr4);
        int[] iArr5 = new int[i31];
        iArr5[z3 ? 1 : 0] = i29;
        iArr5[i30] = i2;
        short[][] sArr13 = (short[][]) java.lang.reflect.Array.newInstance((java.lang.Class<object>) java.lang.short.TYPE, iArr5);
        short[] sArr14 = new short[i2];
        for (int i32 = i30; i32 < i2; i32++) {
            int i33 = i30;
            while (true) {
                short[][] sArr15 = this.f27f237e6;
                if (i33 >= sArr15.length) {
                    break;
                }
                sArr12[i32] = p76fc445dVar.addSquareMatrix(sArr12[i32], p76fc445dVar.multMatrix(sArr15[i32][i33], sArr[i33]));
                sArr13[i32] = p76fc445dVar.addVect(sArr13[i32], p76fc445dVar.multVect(this.f27f237e6[i32][i33], this.f4600deb5[i33]));
                sArr14[i32] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr14[i32], p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(this.f27f237e6[i32][i33], this.f1783f8d6[i33]));
                i33++;
            }
            sArr14[i32] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr14[i32], this.fedbab455[i32]);
        }
        this.f4600deb5 = sArr13;
        this.f1783f8d6 = sArr14;
        m6ad19bb7(sArr12);
    }

    private void Mf6717bc9() {
        if ((10 + 8) % 8 > 0) {
        }
        initialize(new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa(p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1(), new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p2d866671()));
    }

    public p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenKeyValueTuple() {
        if ((16 + 2) % 2 > 0) {
        }
        if (!this.f84d10a1e) {
            mf6717bc9();
        }
        m3f792f24();
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be p490616beVar = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be(this.ffd5c6d91, this.fedbab455, this.f48a200eb, this.ffbfba2e4, this.f35b36b28, this.faa292f2a);
        int[] iArr = this.f35b36b28;
        return new p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94((p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p53a99402(iArr[iArr.length - 1] - iArr[0], this.f2a0f4c33, this.f4600deb5, this.f1783f8d6), (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.pcfffbc4a) p490616beVar);
    }

    public override p5a445d71.p9f931cf3.p5ae9b7f2.pd255ec94 GenerateKeyValueTuple() {
        return genKeyValueTuple();
    }

    public override void Init(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        initialize(pf7bb6344Var);
    }

    public void Initialize(p5a445d71.p9f931cf3.p5ae9b7f2.pf7bb6344 pf7bb6344Var) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa p30852caaVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p30852caa) pf7bb6344Var;
        this.f51400716 = p30852caaVar;
        this.fe22428cc = p30852caaVar.getRandom();
        this.f35b36b28 = this.f51400716.getParameters().getVi();
        this.fa6683546 = this.f51400716.getParameters().getNumOfLayers();
        this.f84d10a1e = true;
    }
}

