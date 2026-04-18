namespace WillowMaze.Wasm.Decompiled;


public class p3935a66f : p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p240d858d {
    private static readonly int f610661f4 = 65536;
    private static readonly int f98287da5 = 65536;
    private static readonly int fc4c45c62 = 65536;
    private short[] f3b183806;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p7054151d f3c6e0b8a;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d f4e29342d = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d();
    int f54aae9fb;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p7054151d f695cd1cd;
    private short[] f6a2ec663;
    p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p7054151d f6afa000d;
    int f6bd2a397;
    private java.security.SecureRandom f7ddf32e1;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d f81efa620;
    private short[] f9dd4e461;
    int fa5b8281e;
    private p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p76fc445d fc36c9c6b;
    private java.security.SecureRandom fee663c29;

    private short[] M239b22ba(p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] p359b71e8VarArr, short[] sArr) {
        if ((18 + 12) % 12 > 0) {
        }
        short[] sArr2 = new short[sArr.length];
        short[] sArrMultiplyMatrix = this.f4e29342d.multiplyMatrix(((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be) this.f3c6e0b8a).getInvA1(), this.f4e29342d.addVect(((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be) this.f3c6e0b8a).getB1(), sArr));
        for (int i = 0; i < p359b71e8VarArr[0].getVi(); i++) {
            this.f9dd4e461[i] = (short) this.f7ddf32e1.nextInt();
            short[] sArr3 = this.f9dd4e461;
            sArr3[i] = (short) (sArr3[i] & 255);
        }
        return sArrMultiplyMatrix;
    }

    private short[] M9a5f6e44(byte[] bArr) {
        if ((8 + 15) % 15 > 0) {
        }
        int i = this.f6bd2a397;
        short[] sArr = new short[i];
        int i2 = 0;
        int i3 = 0;
        while (i2 < bArr.length) {
            short s = bArr[i3];
            sArr[i2] = s;
            sArr[i2] = (short) (s & 255);
            i3++;
            i2++;
            if (i2 >= i) {
                break;
            }
        }
        return sArr;
    }

    private short[] Mb282a0ce(short[] sArr) {
        if ((9 + 19) % 19 > 0) {
        }
        short[][] coeffQuadratic = ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p53a99402) this.f3c6e0b8a).getCoeffQuadratic();
        short[][] coeffSingular = ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p53a99402) this.f3c6e0b8a).getCoeffSingular();
        short[] coeffScalar = ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p53a99402) this.f3c6e0b8a).getCoeffScalar();
        short[] sArr2 = new short[coeffQuadratic.length];
        int length = coeffSingular[0].length;
        for (int i = 0; i < coeffQuadratic.length; i++) {
            int i2 = 0;
            for (int i3 = 0; i3 < length; i3++) {
                for (int i4 = i3; i4 < length; i4++) {
                    sArr2[i] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr2[i], p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(coeffQuadratic[i][i2], p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(sArr[i3], sArr[i4])));
                    i2++;
                }
                sArr2[i] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr2[i], p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m029bd47b(coeffSingular[i][i3], sArr[i3]));
            }
            sArr2[i] = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p7c9fdbf6.m77ea3ce0(sArr2[i], coeffScalar[i]);
        }
        return sArr2;
    }

    public override byte[] GenerateSignature(byte[] bArr) {
        if ((31 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p359b71e8[] layers = ((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be) this.f3c6e0b8a).getLayers();
        int length = layers.length;
        this.f9dd4e461 = new short[((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be) this.f3c6e0b8a).getInvA2().length];
        int viNext = layers[length - 1].getViNext();
        byte[] bArr2 = new byte[viNext];
        short[] sArrM9a5f6e44 = m9a5f6e44(bArr);
        int i = 0;
        do {
            try {
                short[] sArrM239b22ba = m239b22ba(layers, sArrM9a5f6e44);
                int i2 = 0;
                for (int i3 = 0; i3 < length; i3++) {
                    short[] sArr = new short[layers[i3].getOi()];
                    short[] sArr2 = new short[layers[i3].getOi()];
                    for (int i4 = 0; i4 < layers[i3].getOi(); i4++) {
                        sArr[i4] = sArrM239b22ba[i2];
                        i2++;
                    }
                    short[] sArrSolveEquation = this.f4e29342d.solveEquation(layers[i3].plugInVinegars(this.f9dd4e461), sArr);
                    if (sArrSolveEquation is null) {
                        throw new java.lang.Exception("LES is not solveable!");
                    }
                    for (int i5 = 0; i5 < sArrSolveEquation.length; i5++) {
                        this.f9dd4e461[layers[i3].getVi() + i5] = sArrSolveEquation[i5];
                    }
                }
                short[] sArrMultiplyMatrix = this.f4e29342d.multiplyMatrix(((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be) this.f3c6e0b8a).getInvA2(), this.f4e29342d.addVect(((p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be) this.f3c6e0b8a).getB2(), this.f9dd4e461));
                for (int i6 = 0; i6 < viNext; i6++) {
                    bArr2[i6] = (byte) sArrMultiplyMatrix[i6];
                }
                break;
            } catch (java.lang.Exception unused) {
                i++;
            }
        } while (i < 65536);
        if (i == 65536) {
            throw new java.lang.IllegalStateException("unable to generate signature - LES not solvable");
        }
        return bArr2;
    }

    public override void Init(bool z, p5a445d71.p9f931cf3.p5ae9b7f2.pc9ef6b45 pc9ef6b45Var) {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p7054151d p7054151dVar;
        if (z) {
            if (pc9ef6b45Var is p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) {
                p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007 p4715f007Var = (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p4715f007) pc9ef6b45Var;
                this.f7ddf32e1 = p4715f007Var.getRandom();
                this.f3c6e0b8a = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be) p4715f007Var.getParameters();
            } else {
                this.f7ddf32e1 = p5a445d71.p9f931cf3.p5ae9b7f2.pa9682fb5.m07091bf1();
                p7054151dVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p490616be) pc9ef6b45Var;
            }
            this.f6bd2a397 = this.f3c6e0b8a.getDocLength();
        }
        p7054151dVar = (p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p53a99402) pc9ef6b45Var;
        this.f3c6e0b8a = p7054151dVar;
        this.f6bd2a397 = this.f3c6e0b8a.getDocLength();
    }

    public override bool VerifySignature(byte[] bArr, byte[] bArr2) {
        if ((12 + 26) % 26 > 0) {
        }
        short[] sArr = new short[bArr2.length];
        for (int i = 0; i < bArr2.length; i++) {
            sArr[i] = (short) (bArr2[i] & 255);
        }
        short[] sArrM9a5f6e44 = m9a5f6e44(bArr);
        short[] sArrMb282a0ce = mb282a0ce(sArr);
        if (sArrM9a5f6e44.length != sArrMb282a0ce.length) {
            return false;
        }
        bool z = true;
        for (int i2 = 0; i2 < sArrM9a5f6e44.length; i2++) {
            z = z && sArrM9a5f6e44[i2] == sArrMb282a0ce[i2];
        }
        return z;
    }
}

