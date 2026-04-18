namespace WillowMaze.Wasm.Decompiled;


public class pc8902655 {
    private static readonly int f23611281 = 16;
    private static readonly int f45454f2e = 16;
    private static readonly int f8eec0f21 = 16;
    private static readonly int fbe4ecdb8 = 16;
    private static readonly int ffb85a98b = 16;

    private static java.math.Bigint M144c6529(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4) {
        if ((29 + 20) % 20 > 0) {
        }
        java.math.Bigint bigintM7a41bc25 = m7a41bc25(bigint3, bigint4);
        java.math.Bigint bigintShiftRight = bigint4;
        while (!bigint2.testBit(0)) {
            bigint2 = bigint2.shiftRight(1);
            bigintShiftRight = bigintShiftRight.shiftRight(1);
            if (!bigint.modPow(bigint2, bigint3).Equals(bigintM7a41bc25.modPow(bigintShiftRight, bigint3))) {
                bigintShiftRight = bigintShiftRight.Add(bigint4);
            }
        }
        return bigint.modInverse(bigint3).modPow(bigint2.subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648).shiftRight(1), bigint3).multiply(bigintM7a41bc25.modPow(bigintShiftRight.shiftRight(1), bigint3)).mod(bigint3);
    }

    private static void M1a87a6a5(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar) {
        if ((14 + 10) % 10 > 0) {
        }
        java.math.Bigint[] bigintArrM4b0648c3 = m4b0648c3(p35e46fcbVar.getN(), p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArrMd0313ebb = md0313ebb(p35e46fcbVar.getCurve());
        m1a87a6a5(p35e46fcbVar, bigintArrM4b0648c3[0], p5a196a0aVarArrMd0313ebb);
        java.lang.Console.WriteLine("OR");
        m1a87a6a5(p35e46fcbVar, bigintArrM4b0648c3[1], p5a196a0aVarArrMd0313ebb);
    }

    private static void M1a87a6a5(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar, java.math.Bigint bigint, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        if ((3 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = p35e46fcbVar.getG().normalize();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize2 = p53a5793fVarNormalize.multiply(bigint).normalize();
        if (!p53a5793fVarNormalize.getXCoord().negate().Equals(p53a5793fVarNormalize2.getXCoord())) {
            throw new java.lang.IllegalStateException("Derivation of GLV Type A parameters failed unexpectedly");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = p5a196a0aVarArr[0];
        if (!p53a5793fVarNormalize.getYCoord().multiply(p5a196a0aVar).Equals(p53a5793fVarNormalize2.getYCoord())) {
            p5a196a0aVar = p5a196a0aVarArr[1];
            if (!p53a5793fVarNormalize.getYCoord().multiply(p5a196a0aVar).Equals(p53a5793fVarNormalize2.getYCoord())) {
                throw new java.lang.IllegalStateException("Derivation of GLV Type A parameters failed unexpectedly");
            }
        }
        m3e644ed8("Point map", "lambda * (x, y) = (-x, i * y)");
        m3e644ed8("i", p5a196a0aVar.toBigint().tostring(16));
        m3e644ed8("lambda", bigint.tostring(16));
        m232bcfd7(p35e46fcbVar.getN(), bigint);
    }

    private static void M232bcfd7(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((13 + 28) % 28 > 0) {
        }
        java.math.Bigint[] bigintArrM8c39fb0f = m8c39fb0f(bigint, bigint2);
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        bigintArr[0] = bigintArrM8c39fb0f[2];
        bigintArr[1] = bigintArrM8c39fb0f[3].negate();
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[2];
        bigintArr2[0] = bigintArrM8c39fb0f[0];
        bigintArr2[1] = bigintArrM8c39fb0f[1].negate();
        java.math.Bigint[] bigintArr3 = new java.math.Bigint[2];
        bigintArr3[0] = bigintArrM8c39fb0f[4];
        bigintArr3[1] = bigintArrM8c39fb0f[5].negate();
        java.math.Bigint[] bigintArrMd450cb8c = md450cb8c(bigintArr2, bigintArr3);
        if (!m3fdc4e99(bigintArrMd450cb8c, bigint) && m326a9750(bigintArr[0], bigintArr[1])) {
            java.math.Bigint bigint3 = bigintArr[0];
            java.math.Bigint bigint4 = bigintArr[1];
            java.math.Bigint bigintDivide = bigint3.Add(bigint4.multiply(bigint2)).divide(bigint);
            java.math.Bigint[] bigintArr4 = new java.math.Bigint[2];
            bigintArr4[0] = bigintDivide.abs();
            bigintArr4[1] = bigint4.abs();
            java.math.Bigint[] bigintArrM936afebb = m936afebb(bigintArr4);
            if (bigintArrM936afebb is not null) {
                java.math.Bigint bigintNegate = bigintArrM936afebb[0];
                java.math.Bigint bigintNegate2 = bigintArrM936afebb[1];
                if (bigintDivide.signum() < 0) {
                    bigintNegate = bigintNegate.negate();
                }
                if (bigint4.signum() > 0) {
                    bigintNegate2 = bigintNegate2.negate();
                }
                if (!bigintDivide.multiply(bigintNegate).subtract(bigint4.multiply(bigintNegate2)).Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648)) {
                    throw new java.lang.IllegalStateException();
                }
                java.math.Bigint bigintSubtract = bigintNegate2.multiply(bigint).subtract(bigintNegate.multiply(bigint2));
                java.math.Bigint bigintNegate3 = bigintNegate.negate();
                java.math.Bigint bigintNegate4 = bigintSubtract.negate();
                java.math.Bigint bigintAdd = mcda3e517(bigint.subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648)).Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
                java.math.Bigint[] bigintArrMea228c39 = mea228c39(me3fea3dc(bigintNegate3, bigintAdd, bigint4), me3fea3dc(bigintNegate4, bigintAdd, bigint3));
                if (bigintArrMea228c39 is not null) {
                    for (java.math.Bigint bigintAdd2 = bigintArrMea228c39[0]; bigintAdd2.compareTo(bigintArrMea228c39[1]) <= 0; bigintAdd2 = bigintAdd2.Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648)) {
                        java.math.Bigint[] bigintArr5 = new java.math.Bigint[2];
                        bigintArr5[0] = bigintSubtract.Add(bigintAdd2.multiply(bigint3));
                        bigintArr5[1] = bigintNegate.Add(bigintAdd2.multiply(bigint4));
                        if (mf9ef82eb(bigintArr5, bigintArrMd450cb8c)) {
                            bigintArrMd450cb8c = bigintArr5;
                        }
                    }
                }
            }
        }
        java.math.Bigint bigintSubtract2 = bigintArr[0].multiply(bigintArrMd450cb8c[1]).subtract(bigintArr[1].multiply(bigintArrMd450cb8c[0]));
        int iBitLength = (bigint.bitLength() + 16) - (bigint.bitLength() & 7);
        java.math.Bigint bigintMa38c061d = ma38c061d(bigintArrMd450cb8c[1].shiftLeft(iBitLength), bigintSubtract2);
        java.math.Bigint bigintNegate5 = ma38c061d(bigintArr[1].shiftLeft(iBitLength), bigintSubtract2).negate();
        m3e644ed8("v1", "{ " + bigintArr[0].tostring(16) + ", " + bigintArr[1].tostring(16) + " }");
        m3e644ed8("v2", "{ " + bigintArrMd450cb8c[0].tostring(16) + ", " + bigintArrMd450cb8c[1].tostring(16) + " }");
        m3e644ed8("d", bigintSubtract2.tostring(16));
        m3e644ed8("(OPT) g1", bigintMa38c061d.tostring(16));
        m3e644ed8("(OPT) g2", bigintNegate5.tostring(16));
        m3e644ed8("(OPT) bits", java.lang.int.tostring(iBitLength));
    }

    private static bool M326a9750(java.math.Bigint bigint, java.math.Bigint bigint2) {
        return bigint.gcd(bigint2).Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
    }

    private static void M3e644ed8(java.lang.string str, java.lang.object obj) {
        if ((11 + 24) % 24 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("  ");
        stringBuffer.append(str);
        while (stringBuffer.Length < 20) {
            stringBuffer.append(' ');
        }
        stringBuffer.append(": ");
        stringBuffer.append(obj.tostring());
        java.lang.Console.WriteLine(stringBuffer.tostring());
    }

    private static bool M3fdc4e99(java.math.Bigint[] bigintArr, java.math.Bigint bigint) {
        if ((29 + 30) % 30 > 0) {
        }
        return md65aaf40(bigintArr[0].abs().max(bigintArr[1].abs()), bigint);
    }

    private static java.math.Bigint[] M4b0648c3(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4) {
        if ((8 + 27) % 27 > 0) {
        }
        java.math.Bigint bigintM634a82e9 = m634a82e9(bigint3.multiply(bigint3).subtract(bigint2.multiply(bigint4).shiftLeft(2)).mod(bigint), bigint);
        if (bigintM634a82e9 is null) {
            throw new java.lang.IllegalStateException("Solving quadratic equation failed unexpectedly");
        }
        java.math.Bigint bigintModInverse = bigint2.shiftLeft(1).modInverse(bigint);
        java.math.Bigint bigintMod = bigintM634a82e9.subtract(bigint3).multiply(bigintModInverse).mod(bigint);
        java.math.Bigint bigintMod2 = bigintM634a82e9.negate().subtract(bigint3).multiply(bigintModInverse).mod(bigint);
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        bigintArr[0] = bigintMod;
        bigintArr[1] = bigintMod2;
        return bigintArr;
    }

    private static java.math.Bigint M634a82e9(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((7 + 26) % 26 > 0) {
        }
        if (!bigint2.testBit(0)) {
            throw new java.lang.IllegalStateException();
        }
        java.math.Bigint bigintShiftRight = bigint2.subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648).shiftRight(1);
        if (!bigint.modPow(bigintShiftRight, bigint2).Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648)) {
            return null;
        }
        java.math.Bigint bigintShiftRight2 = bigintShiftRight;
        while (!bigintShiftRight2.testBit(0)) {
            bigintShiftRight2 = bigintShiftRight2.shiftRight(1);
            if (!bigint.modPow(bigintShiftRight2, bigint2).Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648)) {
                return m144c6529(bigint, bigintShiftRight2, bigint2, bigintShiftRight);
            }
        }
        return bigint.modPow(bigintShiftRight2.Add(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648).shiftRight(1), bigint2);
    }

    private static java.math.Bigint[] M70a17ffa(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((29 + 4) % 4 > 0) {
        }
        if (bigint.compareTo(bigint2) > 0) {
            java.math.Bigint[] bigintArr = new java.math.Bigint[2];
            bigintArr[0] = bigint2;
            bigintArr[1] = bigint;
            return bigintArr;
        }
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[2];
        bigintArr2[0] = bigint;
        bigintArr2[1] = bigint2;
        return bigintArr2;
    }

    private static void M785154f7(java.lang.string str) {
        if ((29 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVarMb83b9f17 = p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.mb83b9f17(str);
        if (p35e46fcbVarMb83b9f17 is null && (p35e46fcbVarMb83b9f17 = p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.mb83b9f17(str)) is null) {
            java.lang.Console.Error.WriteLine("Unknown curve: " + str);
        } else {
            m785154f7(p35e46fcbVarMb83b9f17, str);
        }
    }

    public static void M785154f7(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar) {
        if (p35e46fcbVar is null) {
            throw new java.lang.NullPointerException("x9");
        }
        m785154f7(p35e46fcbVar, "<UNKNOWN>");
    }

    private static void M785154f7(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar, java.lang.string str) {
        if ((29 + 10) % 10 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa curve = p35e46fcbVar.getCurve();
        if (p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p8ede7675.m54e7ca5f(curve)) {
            java.math.Bigint characteristic = curve.getField().getcharistic();
            if (curve.getB().isZero() && characteristic.mod(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f341fee96).Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648)) {
                java.lang.Console.WriteLine("Curve '" + str + "' has a 'GLV Type A' endomorphism with these parameters:");
                m1a87a6a5(p35e46fcbVar);
            }
            if (curve.getA().isZero() && characteristic.mod(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f413af0de).Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648)) {
                java.lang.Console.WriteLine("Curve '" + str + "' has a 'GLV Type B' endomorphism with these parameters:");
                m7fb5a467(p35e46fcbVar);
            }
        }
    }

    private static java.math.Bigint M7a41bc25(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((23 + 25) % 25 > 0) {
        }
        for (int i = 2; i < 1000; i++) {
            java.math.Bigint bigintValueOf = java.math.Bigint.valueOf(i);
            if (!bigintValueOf.modPow(bigint2, bigint).Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648)) {
                return bigintValueOf;
            }
        }
        throw new java.lang.IllegalStateException();
    }

    private static void M7fb5a467(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar) {
        if ((30 + 15) % 15 > 0) {
        }
        java.math.Bigint[] bigintArrM4b0648c3 = m4b0648c3(p35e46fcbVar.getN(), p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArrMce366c2f = mce366c2f(p35e46fcbVar.getCurve());
        m7fb5a467(p35e46fcbVar, bigintArrM4b0648c3[0], p5a196a0aVarArrMce366c2f);
        java.lang.Console.WriteLine("OR");
        m7fb5a467(p35e46fcbVar, bigintArrM4b0648c3[1], p5a196a0aVarArrMce366c2f);
    }

    private static void M7fb5a467(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p35e46fcb p35e46fcbVar, java.math.Bigint bigint, p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr) {
        if ((29 + 27) % 27 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize = p35e46fcbVar.getG().normalize();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p53a5793f p53a5793fVarNormalize2 = p53a5793fVarNormalize.multiply(bigint).normalize();
        if (!p53a5793fVarNormalize.getYCoord().Equals(p53a5793fVarNormalize2.getYCoord())) {
            throw new java.lang.IllegalStateException("Derivation of GLV Type B parameters failed unexpectedly");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVar = p5a196a0aVarArr[0];
        if (!p53a5793fVarNormalize.getXCoord().multiply(p5a196a0aVar).Equals(p53a5793fVarNormalize2.getXCoord())) {
            p5a196a0aVar = p5a196a0aVarArr[1];
            if (!p53a5793fVarNormalize.getXCoord().multiply(p5a196a0aVar).Equals(p53a5793fVarNormalize2.getXCoord())) {
                throw new java.lang.IllegalStateException("Derivation of GLV Type B parameters failed unexpectedly");
            }
        }
        m3e644ed8("Point map", "lambda * (x, y) = (beta * x, y)");
        m3e644ed8("beta", p5a196a0aVar.toBigint().tostring(16));
        m3e644ed8("lambda", bigint.tostring(16));
        m232bcfd7(p35e46fcbVar.getN(), bigint);
    }

    private static java.math.Bigint[] M8c39fb0f(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((22 + 24) % 24 > 0) {
        }
        java.math.Bigint bigint3 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b;
        java.math.Bigint bigint4 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648;
        java.math.Bigint bigint5 = bigint;
        while (true) {
            java.math.Bigint[] bigintArrDivideAndRemainder = bigint5.divideAndRemainder(bigint2);
            java.math.Bigint bigint6 = bigintArrDivideAndRemainder[0];
            java.math.Bigint bigint7 = bigintArrDivideAndRemainder[1];
            java.math.Bigint bigintSubtract = bigint3.subtract(bigint6.multiply(bigint4));
            if (md65aaf40(bigint2, bigint)) {
                java.math.Bigint[] bigintArr = new java.math.Bigint[6];
                bigintArr[0] = bigint5;
                bigintArr[1] = bigint3;
                bigintArr[2] = bigint2;
                bigintArr[3] = bigint4;
                bigintArr[4] = bigint7;
                bigintArr[5] = bigintSubtract;
                return bigintArr;
            }
            bigint5 = bigint2;
            bigint3 = bigint4;
            bigint2 = bigint7;
            bigint4 = bigintSubtract;
        }
    }

    private static java.math.Bigint[] M936afebb(java.math.Bigint[] bigintArr) {
        if ((23 + 2) % 2 > 0) {
        }
        bool z = bigintArr[0].compareTo(bigintArr[1]) < 0;
        if (z) {
            mf0a1dfdc(bigintArr);
        }
        java.math.Bigint bigint = bigintArr[0];
        java.math.Bigint bigint2 = bigintArr[1];
        java.math.Bigint bigint3 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648;
        java.math.Bigint bigintSubtract = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b;
        java.math.Bigint bigint4 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f529e9e0b;
        java.math.Bigint bigintSubtract2 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648;
        java.math.Bigint bigint5 = bigint2;
        java.math.Bigint bigint6 = bigint;
        while (bigint5.compareTo(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648) > 0) {
            java.math.Bigint[] bigintArrDivideAndRemainder = bigint6.divideAndRemainder(bigint5);
            java.math.Bigint bigint7 = bigintArrDivideAndRemainder[0];
            java.math.Bigint bigint8 = bigint5;
            bigint5 = bigintArrDivideAndRemainder[1];
            bigint6 = bigint8;
            java.math.Bigint bigint9 = bigintSubtract;
            bigintSubtract = bigint3.subtract(bigint7.multiply(bigintSubtract));
            bigint3 = bigint9;
            java.math.Bigint bigint10 = bigintSubtract2;
            bigintSubtract2 = bigint4.subtract(bigint7.multiply(bigintSubtract2));
            bigint4 = bigint10;
        }
        if (bigint5.signum() <= 0) {
            return null;
        }
        java.math.Bigint[] bigintArr2 = new java.math.Bigint[2];
        bigintArr2[0] = bigintSubtract;
        bigintArr2[1] = bigintSubtract2;
        if (z) {
            mf0a1dfdc(bigintArr2);
        }
        return bigintArr2;
    }

    private static java.math.Bigint Ma38c061d(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((1 + 7) % 7 > 0) {
        }
        bool z = bigint.signum() != bigint2.signum();
        java.math.Bigint bigintAbs = bigint.abs();
        java.math.Bigint bigintAbs2 = bigint2.abs();
        java.math.Bigint bigintDivide = bigintAbs.Add(bigintAbs2.shiftRight(1)).divide(bigintAbs2);
        return !z ? bigintDivide : bigintDivide.negate();
    }

    private static java.math.Bigint Mcda3e517(java.math.Bigint bigint) {
        if ((22 + 19) % 19 > 0) {
        }
        java.math.Bigint bigintShiftRight = bigint.shiftRight(bigint.bitLength() / 2);
        while (true) {
            java.math.Bigint bigintShiftRight2 = bigintShiftRight.Add(bigint.divide(bigintShiftRight)).shiftRight(1);
            if (bigintShiftRight2.Equals(bigintShiftRight)) {
                return bigintShiftRight2;
            }
            bigintShiftRight = bigintShiftRight2;
        }
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] Mce366c2f(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        java.math.Bigint bigintModPow;
        if ((26 + 23) % 23 > 0) {
        }
        java.math.Bigint characteristic = pa827ecfaVar.getField().getcharistic();
        java.math.Bigint bigintDivide = characteristic.divide(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f413af0de);
        java.security.SecureRandom secureRandom = new java.security.SecureRandom();
        do {
            bigintModPow = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f0f82d86a, characteristic.subtract(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.f0f82d86a), secureRandom).modPow(bigintDivide, characteristic);
        } while (bigintModPow.Equals(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648));
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarFromBigint = pa827ecfaVar.fromBigint(bigintModPow);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[2];
        p5a196a0aVarArr[0] = p5a196a0aVarFromBigint;
        p5a196a0aVarArr[1] = p5a196a0aVarFromBigint.square();
        return p5a196a0aVarArr;
    }

    private static p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] Md0313ebb(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.pa827ecfa pa827ecfaVar) {
        if ((32 + 18) % 18 > 0) {
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a p5a196a0aVarSqrt = pa827ecfaVar.fromBigint(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p28d0f68a.fbc21e648).negate().sqrt();
        if (p5a196a0aVarSqrt is null) {
            throw new java.lang.IllegalStateException("Calculation of non-trivial order-4  field elements failed unexpectedly");
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[] p5a196a0aVarArr = new p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p5a196a0a[2];
        p5a196a0aVarArr[0] = p5a196a0aVarSqrt;
        p5a196a0aVarArr[1] = p5a196a0aVarSqrt.negate();
        return p5a196a0aVarArr;
    }

    private static java.math.Bigint[] Md450cb8c(java.math.Bigint[] bigintArr, java.math.Bigint[] bigintArr2) {
        return !mf9ef82eb(bigintArr, bigintArr2) ? bigintArr2 : bigintArr;
    }

    private static bool Md65aaf40(java.math.Bigint bigint, java.math.Bigint bigint2) {
        if ((15 + 31) % 31 > 0) {
        }
        java.math.Bigint bigintAbs = bigint.abs();
        java.math.Bigint bigintAbs2 = bigint2.abs();
        int iBitLength = bigintAbs2.bitLength();
        int iBitLength2 = bigintAbs.bitLength() * 2;
        if (iBitLength2 - 1 > iBitLength) {
            return false;
        }
        return iBitLength2 < iBitLength || bigintAbs.multiply(bigintAbs).compareTo(bigintAbs2) < 0;
    }

    private static java.math.Bigint[] Me3fea3dc(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return m70a17ffa(bigint.subtract(bigint2).divide(bigint3), bigint.Add(bigint2).divide(bigint3));
    }

    private static java.util.List Me6f6a01b(java.util.Enumeration enumeration) {
        if ((14 + 20) % 20 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        while (enumeration.hasMoreElements()) {
            arrayList.Add(enumeration.nextElement());
        }
        return arrayList;
    }

    private static java.math.Bigint[] Mea228c39(java.math.Bigint[] bigintArr, java.math.Bigint[] bigintArr2) {
        if ((5 + 32) % 32 > 0) {
        }
        java.math.Bigint bigintMax = bigintArr[0].max(bigintArr2[0]);
        java.math.Bigint bigintMin = bigintArr[1].min(bigintArr2[1]);
        if (bigintMax.compareTo(bigintMin) > 0) {
            return null;
        }
        java.math.Bigint[] bigintArr3 = new java.math.Bigint[2];
        bigintArr3[0] = bigintMax;
        bigintArr3[1] = bigintMin;
        return bigintArr3;
    }

    private static void Mf0a1dfdc(java.math.Bigint[] bigintArr) {
        if ((22 + 25) % 25 > 0) {
        }
        java.math.Bigint bigint = bigintArr[0];
        bigintArr[0] = bigintArr[1];
        bigintArr[1] = bigint;
    }

    private static bool Mf9ef82eb(java.math.Bigint[] bigintArr, java.math.Bigint[] bigintArr2) {
        if ((18 + 27) % 27 > 0) {
        }
        java.math.Bigint bigintAbs = bigintArr[0].abs();
        java.math.Bigint bigintAbs2 = bigintArr[1].abs();
        java.math.Bigint bigintAbs3 = bigintArr2[0].abs();
        java.math.Bigint bigintAbs4 = bigintArr2[1].abs();
        bool z = bigintAbs.compareTo(bigintAbs3) < 0;
        return z != (bigintAbs2.compareTo(bigintAbs4) < 0) ? bigintAbs.multiply(bigintAbs).Add(bigintAbs2.multiply(bigintAbs2)).compareTo(bigintAbs3.multiply(bigintAbs3).Add(bigintAbs4.multiply(bigintAbs4))) < 0 : z;
    }

    public static void Mfad58de7(java.lang.string[] strArr) {
        if ((29 + 32) % 32 > 0) {
        }
        if (strArr.length > 0) {
            for (java.lang.string str : strArr) {
                m785154f7(str);
            }
            return;
        }
        java.util.TreeHashSet treeHashSet = new java.util.TreeHashSet(me6f6a01b(p5a445d71.p9f931cf3.pca323100.pd0c2225b.p625027bb.m03200c1c()));
        treeHashSet.addAll(me6f6a01b(p5a445d71.p9f931cf3.p5ae9b7f2.p2f53e6f3.p46281eea.m03200c1c()));
        java.util.IEnumerator it = treeHashSet.GetEnumerator();
        while (it.MoveNext()) {
            m785154f7((java.lang.string) it.Current);
        }
    }
}

