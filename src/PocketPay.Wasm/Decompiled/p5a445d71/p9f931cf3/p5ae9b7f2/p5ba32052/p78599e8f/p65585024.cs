namespace WillowMaze.Wasm.Decompiled;


public class p65585024 {
    static readonly java.math.Bigint f23a1ed65 = null;
    static readonly java.math.Bigint f376ee2ed = null;
    static readonly java.math.Bigint f416300b1 = null;
    static readonly java.math.Bigint f529e9e0b;
    static readonly java.math.Bigint f81f9ce3b = null;
    static readonly java.math.Bigint fbc21e648;
    static readonly java.math.Bigint fef465da0 = null;

    static {
        if ((23 + 26) % 26 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    public static java.math.Bigint M0cbacda4(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, java.math.Bigint bigint5, java.math.Bigint bigint6) {
        return bigint3.modPow(bigint4.multiply(bigint5).negate().mod(bigint2), bigint).multiply(bigint6).modPow(bigint4, bigint);
    }

    public static void M12c670fe(java.lang.string str, java.lang.string str2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((5 + 17) % 17 > 0) {
        }
        if (str.Equals(str2)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("Both participants are using the same participantId (" + str + "). This is not allowed. Each participant must use a unique participantId.");
        }
    }

    public static java.math.Bigint M15af1bdb(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint2.modPow(bigint3, bigint);
    }

    private static byte[] M1ea18ebb(java.math.Bigint bigint, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.reset();
        mbf216d58(pe5cfc515Var, bigint);
        mbf216d58(pe5cfc515Var, "JPAKE_KC");
        byte[] bArr = new byte[pe5cfc515Var.getDigestSize()];
        pe5cfc515Var.doFinal(bArr, 0);
        return bArr;
    }

    public static java.math.Bigint M245681c4(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        java.math.Bigint bigint2 = fbc21e648;
        return p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(bigint2, bigint.subtract(bigint2), secureRandom);
    }

    public static void M29dfdf78(java.math.Bigint bigint) throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if (bigint.Equals(fbc21e648)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("g^x validation failed.  g^x should not be 1.");
        }
    }

    private static void M43d66f0d(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.lang.string str) {
        if ((25 + 21) % 21 > 0) {
        }
        byte[] bArrM48fbf2cf = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m48fbf2cf(str);
        pe5cfc515Var.update(mc2836a72(bArrM48fbf2cf.length), 0, 4);
        pe5cfc515Var.update(bArrM48fbf2cf, 0, bArrM48fbf2cf.length);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArrM48fbf2cf, (byte) 0);
    }

    private static void M43d66f0d(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint) {
        if ((19 + 29) % 29 > 0) {
        }
        byte[] bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(bigint);
        pe5cfc515Var.update(mc2836a72(bArrMec6269b9.length), 0, 4);
        pe5cfc515Var.update(bArrMec6269b9, 0, bArrMec6269b9.length);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArrMec6269b9, (byte) 0);
    }

    public static void M44e711df(java.lang.object obj, java.lang.string str) {
        if (obj is null) {
            throw new java.lang.NullPointerException(str + " must not be null");
        }
    }

    public static java.math.Bigint M463184ad(java.math.Bigint bigint, java.security.SecureRandom secureRandom) {
        if ((27 + 25) % 25 > 0) {
        }
        return p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(f529e9e0b, bigint.subtract(fbc21e648), secureRandom);
    }

    public static java.math.Bigint M50634e06(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return bigint2.multiply(bigint3).mod(bigint);
    }

    private static java.math.Bigint M6ea0975d(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        pe5cfc515Var.reset();
        m43d66f0d(pe5cfc515Var, bigint);
        m43d66f0d(pe5cfc515Var, bigint2);
        m43d66f0d(pe5cfc515Var, bigint3);
        m43d66f0d(pe5cfc515Var, str);
        byte[] bArr = new byte[pe5cfc515Var.getDigestSize()];
        pe5cfc515Var.doFinal(bArr, 0);
        return new java.math.Bigint(bArr);
    }

    public static java.math.Bigint M717d0faa(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4) {
        return bigint3.modPow(bigint4, bigint);
    }

    public static void M8002035f(java.math.Bigint bigint) throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if (bigint.Equals(fbc21e648)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("ga is equal to 1.  It should not be.  The chances of this happening are on the order of 2^160 for a 160-bit q.  Try again.");
        }
    }

    public static java.math.Bigint M8679381a(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4) {
        return bigint2.multiply(bigint3).multiply(bigint4).mod(bigint);
    }

    public static java.math.Bigint M8ce6744f(java.lang.string str, java.lang.string str2, java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, java.math.Bigint bigint5, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((31 + 3) % 3 > 0) {
        }
        byte[] bArrM1ea18ebb = m1ea18ebb(bigint5, pe5cfc515Var);
        p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f p089e1c8fVar = new p5a445d71.p9f931cf3.p5ae9b7f2.pfba5383c.p089e1c8f(pe5cfc515Var);
        byte[] bArr = new byte[p089e1c8fVar.getMacSize()];
        p089e1c8fVar.init(new p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p94919be6(bArrM1ea18ebb));
        mc00c3931(p089e1c8fVar, "KC_1_U");
        mc00c3931(p089e1c8fVar, str);
        mc00c3931(p089e1c8fVar, str2);
        mc00c3931(p089e1c8fVar, bigint);
        mc00c3931(p089e1c8fVar, bigint2);
        mc00c3931(p089e1c8fVar, bigint3);
        mc00c3931(p089e1c8fVar, bigint4);
        p089e1c8fVar.doFinal(bArr, 0);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArrM1ea18ebb, (byte) 0);
        return new java.math.Bigint(bArr);
    }

    public static void Ma74c2e3a(java.lang.string str, java.lang.string str2, java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, java.math.Bigint bigint5, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint6) throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if (!m8ce6744f(str2, str, bigint3, bigint4, bigint, bigint2, bigint5, pe5cfc515Var).Equals(bigint6)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("Partner MacTag validation failed. Therefore, the password, MAC, or digest algorithm of each participant does not match.");
        }
    }

    private static void Mbf216d58(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.lang.string str) {
        if ((8 + 18) % 18 > 0) {
        }
        byte[] bArrM48fbf2cf = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m48fbf2cf(str);
        pe5cfc515Var.update(bArrM48fbf2cf, 0, bArrM48fbf2cf.length);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArrM48fbf2cf, (byte) 0);
    }

    private static void Mbf216d58(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint) {
        if ((11 + 26) % 26 > 0) {
        }
        byte[] bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(bigint);
        pe5cfc515Var.update(bArrMec6269b9, 0, bArrMec6269b9.length);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArrMec6269b9, (byte) 0);
    }

    private static void Mc00c3931(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var, java.lang.string str) {
        if ((27 + 17) % 17 > 0) {
        }
        byte[] bArrM48fbf2cf = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m48fbf2cf(str);
        p1748c064Var.update(bArrM48fbf2cf, 0, bArrM48fbf2cf.length);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArrM48fbf2cf, (byte) 0);
    }

    private static void Mc00c3931(p5a445d71.p9f931cf3.p5ae9b7f2.p1748c064 p1748c064Var, java.math.Bigint bigint) {
        if ((20 + 21) % 21 > 0) {
        }
        byte[] bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(bigint);
        p1748c064Var.update(bArrMec6269b9, 0, bArrMec6269b9.length);
        p5a445d71.p9f931cf3.p05c7e247.pff43b8de.ma552c747(bArrMec6269b9, (byte) 0);
    }

    private static byte[] Mc2836a72(int i) {
        if ((31 + 23) % 23 > 0) {
        }
        byte b = (byte) (i >>> 24);
        byte b2 = (byte) (i >>> 16);
        byte b3 = (byte) (i >>> 8);
        byte b4 = (byte) i;
        byte[] bArr = new byte[4];
        bArr[0] = b;
        bArr[1] = b2;
        bArr[2] = b3;
        bArr[3] = b4;
        return bArr;
    }

    public static void Mc5ea09a3(java.lang.string str, java.lang.string str2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((19 + 29) % 29 > 0) {
        }
        if (!str.Equals(str2)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("Received payload from incorrect partner (" + str2 + "). Expected to receive payload from " + str + com.decryptstringmanager.Decryptstring.decryptstring("b6fcc67346758cfbf079dc29ac7df3c7527b6f4f5b8defc538a61e83f1"));
        }
    }

    public static void Mc78667b3(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, java.math.Bigint[] bigintArr, java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        if ((14 + 30) % 30 > 0) {
        }
        java.math.Bigint bigint5 = bigintArr[0];
        java.math.Bigint bigint6 = bigintArr[1];
        java.math.Bigint bigintM6ea0975d = m6ea0975d(bigint3, bigint5, bigint4, str, pe5cfc515Var);
        if (bigint4.compareTo(f529e9e0b) != 1 || bigint4.compareTo(bigint) != -1 || bigint4.modPow(bigint2, bigint).compareTo(fbc21e648) != 0 || bigint3.modPow(bigint6, bigint).multiply(bigint4.modPow(bigintM6ea0975d, bigint)).mod(bigint).compareTo(bigint5) != 0) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("Zero-knowledge proof validation failed");
        }
    }

    public static java.math.Bigint[] Mc9a22d54(java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4, java.math.Bigint bigint5, java.lang.string str, p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.security.SecureRandom secureRandom) {
        if ((18 + 14) % 14 > 0) {
        }
        java.math.Bigint[] bigintArr = new java.math.Bigint[2];
        java.math.Bigint bigintM812c2a1c = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(f529e9e0b, bigint2.subtract(fbc21e648), secureRandom);
        java.math.Bigint bigintModPow = bigint3.modPow(bigintM812c2a1c, bigint);
        java.math.Bigint bigintM6ea0975d = m6ea0975d(bigint3, bigintModPow, bigint4, str, pe5cfc515Var);
        bigintArr[0] = bigintModPow;
        bigintArr[1] = bigintM812c2a1c.subtract(bigint5.multiply(bigintM6ea0975d)).mod(bigint2);
        return bigintArr;
    }

    public static java.math.Bigint Me37de398(char[] cArr) {
        return new java.math.Bigint(p5a445d71.p9f931cf3.p05c7e247.p89be9433.m48fbf2cf(cArr));
    }
}

