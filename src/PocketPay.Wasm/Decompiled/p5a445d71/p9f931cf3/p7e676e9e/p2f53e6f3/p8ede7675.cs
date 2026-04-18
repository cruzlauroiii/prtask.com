namespace WillowMaze.Wasm.Decompiled;


public class p8ede7675 {
    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M00df1f7b(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint) {
        if ((9 + 13) % 13 > 0) {
        }
        java.math.Bigint bigintAbs = bigint.abs();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f infinity = p53a5793fVar.getCurve().getInfinity();
        int iBitLength = bigintAbs.bitLength();
        if (iBitLength > 0) {
            if (bigintAbs.testBit(0)) {
                infinity = p53a5793fVar;
            }
            for (int i = 1; i < iBitLength; i++) {
                p53a5793fVar = p53a5793fVar.twice();
                if (bigintAbs.testBit(i)) {
                    infinity = infinity.Add(p53a5793fVar);
                }
            }
        }
        return bigint.signum() >= 0 ? infinity : infinity.negate();
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M089abbbd(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, java.math.Bigint[] bigintArr, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p95daf4ef p95daf4efVar) {
        if ((1 + 31) % 31 > 0) {
        }
        java.math.Bigint order = p53a5793fVarArr[0].getCurve().getOrder();
        int length = p53a5793fVarArr.length;
        int i = length << 1;
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[i];
        int i2 = 0;
        for (int i3 = 0; i3 < length; i3++) {
            java.math.Bigint[] bigintArrDecomposeScalar = p95daf4efVar.decomposeScalar(bigintArr[i3].mod(order));
            int i4 = i2 + 1;
            bigintArr2[i2] = bigintArrDecomposeScalar[0];
            i2 += 2;
            bigintArr2[i4] = bigintArrDecomposeScalar[1];
        }
        if (p95daf4efVar.hasEfficientPointDictionary()) {
            return m430f948b(p95daf4efVar, p53a5793fVarArr, bigintArr2);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[i];
        int i5 = 0;
        for (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar : p53a5793fVarArr) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarM5de19734 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc896a941.m5de19734(p95daf4efVar, p53a5793fVar);
            int i6 = i5 + 1;
            p53a5793fVarArr2[i5] = p53a5793fVar;
            i5 += 2;
            p53a5793fVarArr2[i6] = p53a5793fVarM5de19734;
        }
        return m430f948b(p53a5793fVarArr2, bigintArr2);
    }

    public static void M166474f7(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr, int i, int i2) {
        m166474f7(p5a196a0aVarArr, i, i2, null);
    }

    public static void M166474f7(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr, int i, int i2, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar) {
        if ((15 + 22) % 22 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[i2];
        int i3 = 0;
        p5a196a0aVarArr2[0] = p5a196a0aVarArr[i];
        while (true) {
            int i4 = i3 + 1;
            if (i4 >= i2) {
                break;
            }
            p5a196a0aVarArr2[i4] = p5a196a0aVarArr2[i3].multiply(p5a196a0aVarArr[i + i4]);
            i3 = i4;
        }
        if (p5a196a0aVar is not null) {
            p5a196a0aVarArr2[i3] = p5a196a0aVarArr2[i3].multiply(p5a196a0aVar);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarInvert = p5a196a0aVarArr2[i3].invert();
        while (i3 > 0) {
            int i5 = i3 - 1;
            int i6 = i3 + i;
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar2 = p5a196a0aVarArr[i6];
            p5a196a0aVarArr[i6] = p5a196a0aVarArr2[i5].multiply(p5a196a0aVarInvert);
            p5a196a0aVarInvert = p5a196a0aVarInvert.multiply(p5a196a0aVar2);
            i3 = i5;
        }
        p5a196a0aVarArr[i] = p5a196a0aVarInvert;
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M1937fd79(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2, java.math.Bigint bigint2) {
        if ((12 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p53a5793fVar.getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f infinity = curve.getInfinity();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarAdd = p53a5793fVar.Add(p53a5793fVar2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarSubtract = p53a5793fVar.subtract(p53a5793fVar2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[4];
        p53a5793fVarArr[0] = p53a5793fVar2;
        p53a5793fVarArr[1] = p53a5793fVarSubtract;
        p53a5793fVarArr[2] = p53a5793fVar;
        p53a5793fVarArr[3] = p53a5793fVarAdd;
        curve.normalizeAll(p53a5793fVarArr);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[9];
        p53a5793fVarArr2[0] = p53a5793fVarArr[3].negate();
        p53a5793fVarArr2[1] = p53a5793fVarArr[2].negate();
        p53a5793fVarArr2[2] = p53a5793fVarArr[1].negate();
        p53a5793fVarArr2[3] = p53a5793fVarArr[0].negate();
        p53a5793fVarArr2[4] = infinity;
        p53a5793fVarArr2[5] = p53a5793fVarArr[0];
        p53a5793fVarArr2[6] = p53a5793fVarArr[1];
        p53a5793fVarArr2[7] = p53a5793fVarArr[2];
        p53a5793fVarArr2[8] = p53a5793fVarArr[3];
        byte[] bArrMd6dd47b0 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.md6dd47b0(bigint, bigint2);
        int length = bArrMd6dd47b0.length;
        while (true) {
            length--;
            if (length < 0) {
                return infinity;
            }
            byte b = bArrMd6dd47b0[length];
            infinity = infinity.twicePlus(p53a5793fVarArr2[(((b << 24) >> 28) * 3) + 4 + ((b << 28) >> 28)]);
        }
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M226e8dbb(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2, java.math.Bigint bigint2) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMa2ca2a71;
        if ((13 + 11) % 11 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p53a5793fVar.getCurve();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMa15c73e8 = ma15c73e8(curve, p53a5793fVar2);
        if ((curve is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97) && ((p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa$p7979ad97) curve).isKoblitz()) {
            p53a5793fVarMa2ca2a71 = p53a5793fVar.multiply(bigint).Add(p53a5793fVarMa15c73e8.multiply(bigint2));
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 endomorphism = curve.getEndomorphism();
            if (endomorphism is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p95daf4ef) {
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[2];
                p53a5793fVarArr[0] = p53a5793fVar;
                p53a5793fVarArr[1] = p53a5793fVarMa15c73e8;
                java.math.Bigint[] bigintArr = new java.math.Bigint[2];
                bigintArr[0] = bigint;
                bigintArr[1] = bigint2;
                p53a5793fVarMa2ca2a71 = m089abbbd(p53a5793fVarArr, bigintArr, (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p95daf4ef) endomorphism);
            } else {
                p53a5793fVarMa2ca2a71 = ma2ca2a71(p53a5793fVar, bigint, p53a5793fVarMa15c73e8, bigint2);
            }
        }
        return m6cd93198(p53a5793fVarMa2ca2a71);
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M330e984b(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2, java.math.Bigint bigint2) {
        return m6cd93198(m1937fd79(p53a5793fVar, bigint, ma15c73e8(p53a5793fVar.getCurve(), p53a5793fVar2), bigint2));
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M430f948b(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 pcb03a157Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, java.math.Bigint[] bigintArr) {
        if ((24 + 21) % 21 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr2 = p53a5793fVarArr;
        int length = p53a5793fVarArr2.length;
        int i = length << 1;
        bool[] zArr = new bool[i];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12[] p66539f12VarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12[i];
        byte[][] bArr = new byte[i][];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5da251d0 pointDictionary = pcb03a157Var.getPointDictionary();
        int i2 = 0;
        while (i2 < length) {
            int i3 = i2 << 1;
            int i4 = i3 + 1;
            java.math.Bigint bigint = bigintArr[i3];
            zArr[i3] = bigint.signum() < 0;
            java.math.Bigint bigintAbs = bigint.abs();
            java.math.Bigint bigint2 = bigintArr[i4];
            zArr[i4] = bigint2.signum() < 0;
            java.math.Bigint bigintAbs2 = bigint2.abs();
            int iMfdc6a455 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mfdc6a455(java.lang.Math.max(bigintAbs.bitLength(), bigintAbs2.bitLength()), 8);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr2[i2];
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12VarM338b9121 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m338b9121(p53a5793fVar, iMfdc6a455, true);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12VarM3dd07358 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m3dd07358(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc896a941.m5de19734(pcb03a157Var, p53a5793fVar), pointDictionary, p66539f12VarM338b9121, true);
            int iMin = java.lang.Math.min(8, p66539f12VarM338b9121.getWidth());
            int iMin2 = java.lang.Math.min(8, p66539f12VarM3dd07358.getWidth());
            p66539f12VarArr[i3] = p66539f12VarM338b9121;
            p66539f12VarArr[i4] = p66539f12VarM3dd07358;
            bArr[i3] = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m06c03009(iMin, bigintAbs);
            bArr[i4] = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m06c03009(iMin2, bigintAbs2);
            i2++;
            p53a5793fVarArr2 = p53a5793fVarArr;
        }
        return m430f948b(zArr, p66539f12VarArr, bArr);
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M430f948b(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, java.math.Bigint[] bigintArr) {
        if ((4 + 28) % 28 > 0) {
        }
        int length = p53a5793fVarArr.length;
        bool[] zArr = new bool[length];
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12[] p66539f12VarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12[length];
        byte[][] bArr = new byte[length][];
        for (int i = 0; i < length; i++) {
            java.math.Bigint bigint = bigintArr[i];
            zArr[i] = bigint.signum() < 0;
            java.math.Bigint bigintAbs = bigint.abs();
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12VarM338b9121 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m338b9121(p53a5793fVarArr[i], p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mfdc6a455(bigintAbs.bitLength(), 8), true);
            int iMin = java.lang.Math.min(8, p66539f12VarM338b9121.getWidth());
            p66539f12VarArr[i] = p66539f12VarM338b9121;
            bArr[i] = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m06c03009(iMin, bigintAbs);
        }
        return m430f948b(zArr, p66539f12VarArr, bArr);
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M430f948b(bool[] zArr, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12[] p66539f12VarArr, byte[][] bArr) {
        if ((10 + 28) % 28 > 0) {
        }
        int length = bArr.length;
        int iMax = 0;
        foreach (byte[] BArr2 in bArr) {
            iMax = java.lang.Math.max(iMax, bArr2.length);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f infinity = p66539f12VarArr[0].getPreComp()[0].getCurve().getInfinity();
        int i = iMax - 1;
        int i2 = 0;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarTimesPow2 = infinity;
        while (i >= 0) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarAdd = infinity;
            for (int i3 = 0; i3 < length; i3++) {
                byte[] bArr3 = bArr[i3];
                byte b = i >= bArr3.length ? (byte) 0 : bArr3[i];
                if (b != 0) {
                    int iAbs = java.lang.Math.abs((int) b);
                    p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12Var = p66539f12VarArr[i3];
                    p53a5793fVarAdd = p53a5793fVarAdd.Add(((b < 0) != zArr[i3] ? p66539f12Var.getPreCompNeg() : p66539f12Var.getPreComp())[iAbs >>> 1]);
                }
            }
            if (p53a5793fVarAdd != infinity) {
                if (i2 > 0) {
                    p53a5793fVarTimesPow2 = p53a5793fVarTimesPow2.timesPow2(i2);
                    i2 = 0;
                }
                p53a5793fVarTimesPow2 = p53a5793fVarTimesPow2.twicePlus(p53a5793fVarAdd);
            } else {
                i2++;
            }
            i--;
        }
        return i2 <= 0 ? p53a5793fVarTimesPow2 : p53a5793fVarTimesPow2.timesPow2(i2);
    }

    public static bool M54e7ca5f(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        return ma5181170(pa827ecfaVar.getField());
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M6cd93198(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if (p53a5793fVar.isValidPartial()) {
            return p53a5793fVar;
        }
        throw new java.lang.IllegalStateException("Invalid result");
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M71990e37(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, java.math.Bigint[] bigintArr) {
        if ((31 + 25) % 25 > 0) {
        }
        if (p53a5793fVarArr is not null && bigintArr is not null && p53a5793fVarArr.length == bigintArr.length) {
            if (p53a5793fVarArr.length >= 1) {
                int length = p53a5793fVarArr.length;
                if (length == 1) {
                    return p53a5793fVarArr[0].multiply(bigintArr[0]);
                }
                if (length == 2) {
                    return m226e8dbb(p53a5793fVarArr[0], bigintArr[0], p53a5793fVarArr[1], bigintArr[1]);
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar = p53a5793fVarArr[0];
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p53a5793fVar.getCurve();
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr2 = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[length];
                p53a5793fVarArr2[0] = p53a5793fVar;
                for (int i = 1; i < length; i++) {
                    p53a5793fVarArr2[i] = ma15c73e8(curve, p53a5793fVarArr[i]);
                }
                p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 endomorphism = curve.getEndomorphism();
                return !(endomorphism is p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p95daf4ef) ? m6cd93198(m430f948b(p53a5793fVarArr2, bigintArr)) : m6cd93198(m089abbbd(p53a5793fVarArr2, bigintArr, (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.p95daf4ef) endomorphism));
            }
        }
        throw new java.lang.IllegalArgumentException("point and scalar arrays should be non-null, and of equal, non-zero, length");
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M843c6e90(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2, java.math.Bigint bigint2) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMultiply;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarMultiply2;
        if ((18 + 17) % 17 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p53a5793fVar.getCurve();
        int iM0d042c55 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p000b55e9.m0d042c55(curve);
        if (bigint.bitLength() > iM0d042c55 || bigint2.bitLength() > iM0d042c55) {
            throw new java.lang.IllegalStateException("fixed-point comb doesn't support scalars larger than the curve order");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610 p63c38610VarM338b9121 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p000b55e9.m338b9121(p53a5793fVar);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p63c38610 p63c38610VarM338b91212 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p000b55e9.m338b9121(p53a5793fVar2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p2980d84f lookupTable = p63c38610VarM338b9121.getLookupTable();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p2980d84f lookupTable2 = p63c38610VarM338b91212.getLookupTable();
        int width = p63c38610VarM338b9121.getWidth();
        if (width == p63c38610VarM338b91212.getWidth()) {
            int i = ((iM0d042c55 + width) - 1) / width;
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f infinity = curve.getInfinity();
            int i2 = width * i;
            int[] iArrM1712f3b8 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1712f3b8(i2, bigint);
            int[] iArrM1712f3b82 = p5a445d71.p9f931cf3.p7e676e9e.pbdd166af.p07f2a27c.m1712f3b8(i2, bigint2);
            int i3 = i2 - 1;
            for (int i4 = 0; i4 < i; i4++) {
                int i5 = 0;
                int i6 = 0;
                for (int i7 = i3 - i4; i7 >= 0; i7 -= i) {
                    int i8 = i7 >>> 5;
                    int i9 = i7 & 31;
                    int i10 = iArrM1712f3b8[i8] >>> i9;
                    i5 = ((i5 ^ (i10 >>> 1)) << 1) ^ i10;
                    int i11 = iArrM1712f3b82[i8] >>> i9;
                    i6 = ((i6 ^ (i11 >>> 1)) << 1) ^ i11;
                }
                infinity = infinity.twicePlus(lookupTable.lookupVar(i5).Add(lookupTable2.lookupVar(i6)));
            }
            p53a5793fVarMultiply = infinity.Add(p63c38610VarM338b9121.getOffset());
            p53a5793fVarMultiply2 = p63c38610VarM338b91212.getOffset();
        } else {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81 p90de1a81Var = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p90de1a81();
            p53a5793fVarMultiply = p90de1a81Var.multiply(p53a5793fVar, bigint);
            p53a5793fVarMultiply2 = p90de1a81Var.multiply(p53a5793fVar2, bigint2);
        }
        return p53a5793fVarMultiply.Add(p53a5793fVarMultiply2);
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f M8afe0ebe(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if (p53a5793fVar.isValid()) {
            return p53a5793fVar;
        }
        throw new java.lang.IllegalStateException("Invalid point");
    }

    public static bool M9758923d(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        return mdf46482f(pa827ecfaVar.getField());
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Ma15c73e8(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if (pa827ecfaVar.Equals(p53a5793fVar.getCurve())) {
            return pa827ecfaVar.importPoint(p53a5793fVar);
        }
        throw new java.lang.IllegalArgumentException("Point must be on the same curve");
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Ma2ca2a71(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar2, java.math.Bigint bigint2) {
        if ((19 + 13) % 13 > 0) {
        }
        bool z = bigint.signum() < 0;
        bool z2 = bigint2.signum() < 0;
        java.math.Bigint bigintAbs = bigint.abs();
        java.math.Bigint bigintAbs2 = bigint2.abs();
        int iMfdc6a455 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mfdc6a455(bigintAbs.bitLength(), 8);
        int iMfdc6a4552 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mfdc6a455(bigintAbs2.bitLength(), 8);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12VarM338b9121 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m338b9121(p53a5793fVar, iMfdc6a455, true);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12VarM338b91212 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m338b9121(p53a5793fVar2, iMfdc6a4552, true);
        int iM0d042c55 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p000b55e9.m0d042c55(p53a5793fVar.getCurve());
        if (!z && !z2 && bigint.bitLength() <= iM0d042c55 && bigint2.bitLength() <= iM0d042c55 && p66539f12VarM338b9121.isPromoted() && p66539f12VarM338b91212.isPromoted()) {
            return m843c6e90(p53a5793fVar, bigint, p53a5793fVar2, bigint2);
        }
        int iMin = java.lang.Math.min(8, p66539f12VarM338b9121.getWidth());
        int iMin2 = java.lang.Math.min(8, p66539f12VarM338b91212.getWidth());
        return ma2ca2a71(!z ? p66539f12VarM338b9121.getPreComp() : p66539f12VarM338b9121.getPreCompNeg(), !z ? p66539f12VarM338b9121.getPreCompNeg() : p66539f12VarM338b9121.getPreComp(), p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m06c03009(iMin, bigintAbs), !z2 ? p66539f12VarM338b91212.getPreComp() : p66539f12VarM338b91212.getPreCompNeg(), !z2 ? p66539f12VarM338b91212.getPreCompNeg() : p66539f12VarM338b91212.getPreComp(), p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m06c03009(iMin2, bigintAbs2));
    }

    static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Ma2ca2a71(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pcb03a157 pcb03a157Var, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar, java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((9 + 20) % 20 > 0) {
        }
        bool z = bigint.signum() < 0;
        bool z2 = bigint2.signum() < 0;
        java.math.Bigint bigintAbs = bigint.abs();
        java.math.Bigint bigintAbs2 = bigint2.abs();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12VarM338b9121 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m338b9121(p53a5793fVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.mfdc6a455(java.lang.Math.max(bigintAbs.bitLength(), bigintAbs2.bitLength()), 8), true);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p66539f12 p66539f12VarM3dd07358 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m3dd07358(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p97faaa2a.pc896a941.m5de19734(pcb03a157Var, p53a5793fVar), pcb03a157Var.getPointDictionary(), p66539f12VarM338b9121, true);
        int iMin = java.lang.Math.min(8, p66539f12VarM338b9121.getWidth());
        int iMin2 = java.lang.Math.min(8, p66539f12VarM3dd07358.getWidth());
        return ma2ca2a71(!z ? p66539f12VarM338b9121.getPreComp() : p66539f12VarM338b9121.getPreCompNeg(), !z ? p66539f12VarM338b9121.getPreCompNeg() : p66539f12VarM338b9121.getPreComp(), p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m06c03009(iMin, bigintAbs), !z2 ? p66539f12VarM3dd07358.getPreComp() : p66539f12VarM3dd07358.getPreCompNeg(), !z2 ? p66539f12VarM3dd07358.getPreCompNeg() : p66539f12VarM3dd07358.getPreComp(), p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pb7728374.m06c03009(iMin2, bigintAbs2));
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Ma2ca2a71(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr2, byte[] bArr, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr3, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f[] p53a5793fVarArr4, byte[] bArr2) {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarAdd;
        if ((28 + 14) % 14 > 0) {
        }
        int iMax = java.lang.Math.max(bArr.length, bArr2.length);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f infinity = p53a5793fVarArr[0].getCurve().getInfinity();
        int i = iMax - 1;
        int i2 = 0;
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarTwicePlus = infinity;
        while (i >= 0) {
            byte b = i >= bArr.length ? (byte) 0 : bArr[i];
            byte b2 = i >= bArr2.length ? (byte) 0 : bArr2[i];
            if ((b | b2) != 0) {
                if (b == 0) {
                    p53a5793fVarAdd = infinity;
                } else {
                    p53a5793fVarAdd = infinity.Add((b >= 0 ? p53a5793fVarArr : p53a5793fVarArr2)[java.lang.Math.abs((int) b) >>> 1]);
                }
                if (b2 != 0) {
                    p53a5793fVarAdd = p53a5793fVarAdd.Add((b2 >= 0 ? p53a5793fVarArr3 : p53a5793fVarArr4)[java.lang.Math.abs((int) b2) >>> 1]);
                }
                if (i2 > 0) {
                    p53a5793fVarTwicePlus = p53a5793fVarTwicePlus.timesPow2(i2);
                    i2 = 0;
                }
                p53a5793fVarTwicePlus = p53a5793fVarTwicePlus.twicePlus(p53a5793fVarAdd);
            } else {
                i2++;
            }
            i--;
        }
        return i2 <= 0 ? p53a5793fVarTwicePlus : p53a5793fVarTwicePlus.timesPow2(i2);
    }

    public static bool Ma5181170(p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 pe4575263Var) {
        return pe4575263Var.getDimension() == 1;
    }

    public static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f Mcff1d00d(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVar) {
        if (pa827ecfaVar.Equals(p53a5793fVar.getCurve())) {
            return pa827ecfaVar.decodePoint(p53a5793fVar.getEncoded(false));
        }
        throw new java.lang.IllegalArgumentException("Point must be on the same curve");
    }

    public static bool Mdf46482f(p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.pe4575263 pe4575263Var) {
        if ((20 + 22) % 22 > 0) {
        }
        return pe4575263Var.getDimension() > 1 && pe4575263Var.getcharistic().Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f0f82d86a) && (pe4575263Var is p5a445d71.p9f931cf3.p7e676e9e.p06e3d36f.p7f9339ec);
    }
}

