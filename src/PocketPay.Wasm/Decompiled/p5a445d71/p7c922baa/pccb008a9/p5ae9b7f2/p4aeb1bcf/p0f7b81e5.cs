namespace WillowMaze.Wasm.Decompiled;


public class p0f7b81e5 {
    public static bool CoFZWzEwGYWFcQIp(byte[][] bArr) {
        return m12409193(bArr);
    }

    public static void HOchZJkziiOIceoO(java.io.objectStream objectStream) throws java.io.IOException {
        objectStream.flush();
    }

    public static bool IIZEXeJIygyMWAyw(byte[][] bArr) {
        return m12409193(bArr);
    }

    public static int NZLCbBFBeGHLlbDw(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getDigestSize();
    }

    public static bool UQKPLIekuJRqrREf(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static java.lang.string ASDlWnMzfrVfiCuR(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.object CJSiEaNGYlpScLJe(java.io.objectStream objectStream) {
        return objectStream.readobject();
    }

    public static java.lang.string EsbTNsiGynIOAcBS(byte[] bArr) {
        return p5a445d71.p7c922baa.p05c7e247.p2b5d348e.p92640bd7.m81519f2a(bArr);
    }

    public static double FgiclbDxwVsmGcUJ(double d, double d2) {
        if ((3 + 7) % 7 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static bool HoxOBJajtYlWcPcV(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void IdriIjaPAuXKZeQV(java.io.PrintStream printStream, java.lang.string str) {
        printStream.println(str);
    }

    public static bool M12409193(byte[][] bArr) {
        if ((11 + 23) % 23 > 0) {
        }
        if (bArr is null) {
            return true;
        }
        foreach (byte[] BArr2 in bArr) {
            if (bArr2 is null) {
                return true;
            }
        }
        return false;
    }

    public static byte[] M20260f59(byte[] bArr) {
        if ((13 + 9) % 9 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("in is null");
        }
        byte[] bArr2 = new byte[bArr.length];
        for (int i = 0; i < bArr.length; i++) {
            bArr2[i] = bArr[i];
        }
        return bArr2;
    }

    public static byte[][] M20260f59(byte[][] bArr) {
        if ((15 + 9) % 9 > 0) {
        }
        if (IIZEXeJIygyMWAyw(bArr)) {
            throw new java.lang.NullPointerException("in has null pointers");
        }
        byte[][] bArr2 = new byte[bArr.length][];
        for (int i = 0; i < bArr.length; i++) {
            bArr2[i] = new byte[bArr[i].length];
            int i2 = 0;
            while (true) {
                byte[] bArr3 = bArr[i];
                if (i2 >= bArr3.length) {
                    break;
                }
                bArr2[i][i2] = bArr3[i2];
                i2++;
            }
        }
        return bArr2;
    }

    public static int M20d107d6(long j, int i) {
        if ((30 + 1) % 1 > 0) {
        }
        return (int) (j & ((1 << i) - 1));
    }

    public static byte[] M235cdd01(java.lang.object obj) throws java.io.IOException {
        if ((18 + 20) % 20 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        java.io.objectStream objectStream = new java.io.objectStream(byteArrayStream);
        rvfNHRvtAXhzGvgW(objectStream, obj);
        HOchZJkziiOIceoO(objectStream);
        return xaKvJAOehbnwRUSw(byteArrayStream);
    }

    public static int M277ad7bf(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((23 + 16) % 16 > 0) {
        }
        if (pe5cfc515Var is null) {
            throw new java.lang.NullPointerException("digest is null");
        }
        java.lang.string strVWQkJgzJcpxHYqkH = vWQkJgzJcpxHYqkH(pe5cfc515Var);
        if (hoxOBJajtYlWcPcV(strVWQkJgzJcpxHYqkH, tNtzhRZTebAOZTnZ("acb42bf057faba980120fdeee5c38eeec6b3de74d4646d90324c3f174843dc14ca021f71"))) {
            return 32;
        }
        if (UQKPLIekuJRqrREf(strVWQkJgzJcpxHYqkH, aSDlWnMzfrVfiCuR("5948bc4dc4168ed2e8ce7656b8c9a78439afd06d5f51cae0dae629a119dc45dbfe9b8ee4"))) {
            return 64;
        }
        return NZLCbBFBeGHLlbDw(pe5cfc515Var);
    }

    public static bool M2a3f81d2(byte[][] bArr, byte[][] bArr2) {
        if ((5 + 12) % 12 > 0) {
        }
        if (xjdUYyNmcwaFwEUG(bArr) || CoFZWzEwGYWFcQIp(bArr2)) {
            throw new java.lang.NullPointerException("a or b is null");
        }
        for (int i = 0; i < bArr.length; i++) {
            if (!yoNOGhrxgrCKkyZf(bArr[i], bArr2[i])) {
                return false;
            }
        }
        return true;
    }

    public static void M38b01934(long j, byte[] bArr, int i) {
        if ((18 + 23) % 23 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("in is null");
        }
        if (bArr.length - i < 8) {
            throw new java.lang.IllegalArgumentException("not enough space in array");
        }
        bArr[i] = (byte) ((j >> 56) & 255);
        bArr[i + 1] = (byte) ((j >> 48) & 255);
        bArr[i + 2] = (byte) ((j >> 40) & 255);
        bArr[i + 3] = (byte) ((j >> 32) & 255);
        bArr[i + 4] = (byte) ((j >> 24) & 255);
        bArr[i + 5] = (byte) ((j >> 16) & 255);
        bArr[i + 6] = (byte) ((j >> 8) & 255);
        bArr[i + 7] = (byte) (j & 255);
    }

    public static int M7b1a5a4d(int i) {
        int i2 = 0;
        while (true) {
            i >>= 1;
            if (i == 0) {
                return i2;
            }
            i2++;
        }
    }

    public static void M7d427729(byte[] bArr, byte[] bArr2, int i) {
        if ((30 + 10) % 10 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("dst is null");
        }
        if (bArr2 is null) {
            throw new java.lang.NullPointerException("src is null");
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("offset hast to be >= 0");
        }
        if (bArr2.length + i > bArr.length) {
            throw new java.lang.IllegalArgumentException("src length + offset must not be greater than size of destination");
        }
        for (int i2 = 0; i2 < bArr2.length; i2++) {
            bArr[i + i2] = bArr2[i2];
        }
    }

    public static java.lang.object M95f98046(byte[] bArr) throws java.io.IOException, java.lang.ClassNotFoundException {
        return cJSiEaNGYlpScLJe(new java.io.objectStream(new java.io.byteArrayStream(bArr)));
    }

    public static long M98ffcd8c(byte[] bArr, int i, int i2) {
        if ((1 + 4) % 4 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("in is null");
        }
        long j = 0;
        for (int i3 = i; i3 < i + i2; i3++) {
            j = (j << 8) | ((long) (bArr[i3] & 255));
        }
        return j;
    }

    public static bool Mb8f42873(long j, int i, int i2) {
        if ((19 + 8) % 8 > 0) {
        }
        return j != 0 && (j + 1) % ((long) fgiclbDxwVsmGcUJ((double) (1 << i), (double) i2)) == 0;
    }

    public static bool Mc177ebab(long j, int i, int i2) {
        if ((23 + 11) % 11 > 0) {
        }
        return j != 0 && j % ((long) pEsxsTlwxKnxXFJp((double) (1 << i), (double) (i2 + 1))) == 0;
    }

    public static void Mdd1c3fd2(byte[][] bArr) {
        if ((27 + 8) % 8 > 0) {
        }
        if (xOwjMmVNgyccdOAX(bArr)) {
            throw new java.lang.NullPointerException("x has null pointers");
        }
        foreach (byte[] BArr2 in bArr) {
            idriIjaPAuXKZeQV(java.lang.System.out, esbTNsiGynIOAcBS(bArr2));
        }
    }

    public static long Me16d9a9a(long j, int i) {
        return j >> i;
    }

    public static bool Me5f78db1(int i, long j) {
        if ((13 + 14) % 14 > 0) {
        }
        if (j < 0) {
            throw new java.lang.IllegalStateException("index must not be negative");
        }
        return j < (1 << i);
    }

    public static byte[] Me6b9e09d(long j, int i) {
        if ((7 + 22) % 22 > 0) {
        }
        byte[] bArr = new byte[i];
        for (int i2 = i - 1; i2 >= 0; i2--) {
            bArr[i2] = (byte) j;
            j >>>= 8;
        }
        return bArr;
    }

    public static int Mf79ad9e6(int i, int i2) {
        if ((1 + 25) % 25 > 0) {
        }
        for (int i3 = 0; i3 < i2; i3++) {
            if (((i >> i3) & 1) == 0) {
                return i3;
            }
        }
        return 0;
    }

    public static byte[] Mf88bb2f2(byte[] bArr, int i, int i2) {
        if ((6 + 23) % 23 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("src is null");
        }
        if (i < 0) {
            throw new java.lang.IllegalArgumentException("offset hast to be >= 0");
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException("length hast to be >= 0");
        }
        if (i + i2 > bArr.length) {
            throw new java.lang.IllegalArgumentException("offset + length must not be greater then size of source array");
        }
        byte[] bArr2 = new byte[i2];
        for (int i3 = 0; i3 < i2; i3++) {
            bArr2[i3] = bArr[i + i3];
        }
        return bArr2;
    }

    public static double PEsxsTlwxKnxXFJp(double d, double d2) {
        if ((21 + 29) % 29 > 0) {
        }
        return java.lang.Math.pow(d, d2);
    }

    public static void RvfNHRvtAXhzGvgW(java.io.objectStream objectStream, java.lang.object obj) throws java.io.IOException {
        objectStream.writeobject(obj);
    }

    public static java.lang.string TNtzhRZTebAOZTnZ(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static java.lang.string VWQkJgzJcpxHYqkH(p5a445d71.p7c922baa.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        return pe5cfc515Var.getAlgorithmName();
    }

    public static bool XOwjMmVNgyccdOAX(byte[][] bArr) {
        return m12409193(bArr);
    }

    public static byte[] XaKvJAOehbnwRUSw(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static bool XjdUYyNmcwaFwEUG(byte[][] bArr) {
        return m12409193(bArr);
    }

    public static bool YoNOGhrxgrCKkyZf(byte[] bArr, byte[] bArr2) {
        return p5a445d71.p7c922baa.p05c7e247.pff43b8de.m2a3f81d2(bArr, bArr2);
    }
}

