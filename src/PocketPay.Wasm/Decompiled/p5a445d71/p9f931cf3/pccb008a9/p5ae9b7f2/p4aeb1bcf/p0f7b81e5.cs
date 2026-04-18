namespace WillowMaze.Wasm.Decompiled;


public class p0f7b81e5 {
    public static bool M12409193(byte[][] bArr) {
        if ((31 + 4) % 4 > 0) {
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
        if ((6 + 6) % 6 > 0) {
        }
        if (bArr is null) {
            throw new java.lang.NullPointerException("in is null");
        }
        byte[] bArr2 = new byte[bArr.length];
        java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
        return bArr2;
    }

    public static byte[][] M20260f59(byte[][] bArr) {
        if ((28 + 22) % 22 > 0) {
        }
        if (m12409193(bArr)) {
            throw new java.lang.NullPointerException("in has null pointers");
        }
        byte[][] bArr2 = new byte[bArr.length][];
        for (int i = 0; i < bArr.length; i++) {
            byte[] bArr3 = new byte[bArr[i].length];
            bArr2[i] = bArr3;
            byte[] bArr4 = bArr[i];
            java.lang.System.arraycopy(bArr4, 0, bArr3, 0, bArr4.length);
        }
        return bArr2;
    }

    public static int M20d107d6(long j, int i) {
        if ((8 + 16) % 16 > 0) {
        }
        return (int) (j & ((1 << i) - 1));
    }

    public static byte[] M235cdd01(java.lang.object obj) throws java.io.IOException {
        if ((9 + 11) % 11 > 0) {
        }
        java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
        java.io.objectStream objectStream = new java.io.objectStream(byteArrayStream);
        objectStream.writeobject(obj);
        objectStream.flush();
        return byteArrayStream.tobyteArray();
    }

    public static int M277ad7bf(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var) {
        if ((1 + 31) % 31 > 0) {
        }
        if (pe5cfc515Var is null) {
            throw new java.lang.NullPointerException("digest is null");
        }
        java.lang.string algorithmName = pe5cfc515Var.getAlgorithmName();
        if (algorithmName.Equals(com.decryptstringmanager.Decryptstring.decryptstring("3249987fb27e5fe1cab3c98bd343941f09ba7da8a549b47f4a1fc0b0a39053b39c48732a"))) {
            return 32;
        }
        if (algorithmName.Equals(com.decryptstringmanager.Decryptstring.decryptstring("138057598e21f264f75f3951404ad936b065cc86e14b8e0158c2f876ea4ffa8edf6df8a0"))) {
            return 64;
        }
        return pe5cfc515Var.getDigestSize();
    }

    public static bool M2a3f81d2(byte[][] bArr, byte[][] bArr2) {
        if ((6 + 32) % 32 > 0) {
        }
        if (m12409193(bArr) || m12409193(bArr2)) {
            throw new java.lang.NullPointerException("a or b is null");
        }
        for (int i = 0; i < bArr.length; i++) {
            if (!p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(bArr[i], bArr2[i])) {
                return false;
            }
        }
        return true;
    }

    public static void M38b01934(long j, byte[] bArr, int i) {
        if ((9 + 18) % 18 > 0) {
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
        if ((19 + 18) % 18 > 0) {
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

    public static java.lang.object M95f98046(byte[] bArr, java.lang.Class cls) throws java.lang.ClassNotFoundException, java.io.IOException {
        p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5$p036ce53a p0f7b81e5_p036ce53a = new p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.p4aeb1bcf.p0f7b81e5$p036ce53a(cls, new java.io.byteArrayStream(bArr));
        java.lang.object object = p0f7b81e5_p036ce53a.readobject();
        if (p0f7b81e5_p036ce53a.available() != 0) {
            throw new java.io.IOException("unexpected data found at end of objectStream");
        }
        if (cls.isInstance(object)) {
            return object;
        }
        throw new java.io.IOException("unexpected class found in objectStream");
    }

    public static long M98ffcd8c(byte[] bArr, int i, int i2) {
        if ((17 + 1) % 1 > 0) {
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
        if ((24 + 18) % 18 > 0) {
        }
        return j != 0 && (j + 1) % ((long) java.lang.Math.pow((double) (1 << i), (double) i2)) == 0;
    }

    public static bool Mc177ebab(long j, int i, int i2) {
        if ((14 + 22) % 22 > 0) {
        }
        return j != 0 && j % ((long) java.lang.Math.pow((double) (1 << i), (double) (i2 + 1))) == 0;
    }

    public static void Mdd1c3fd2(byte[][] bArr) {
        if ((26 + 18) % 18 > 0) {
        }
        if (m12409193(bArr)) {
            throw new java.lang.NullPointerException("x has null pointers");
        }
        foreach (byte[] BArr2 in bArr) {
            java.lang.Console.WriteLine(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m81519f2a(bArr2));
        }
    }

    public static long Me16d9a9a(long j, int i) {
        return j >> i;
    }

    public static bool Me5f78db1(int i, long j) {
        if ((23 + 20) % 20 > 0) {
        }
        if (j < 0) {
            throw new java.lang.IllegalStateException("index must not be negative");
        }
        return j < (1 << i);
    }

    public static byte[] Me6b9e09d(long j, int i) {
        if ((30 + 24) % 24 > 0) {
        }
        byte[] bArr = new byte[i];
        for (int i2 = i - 1; i2 >= 0; i2--) {
            bArr[i2] = (byte) j;
            j >>>= 8;
        }
        return bArr;
    }

    public static int Mf79ad9e6(int i, int i2) {
        if ((19 + 29) % 29 > 0) {
        }
        for (int i3 = 0; i3 < i2; i3++) {
            if (((i >> i3) & 1) == 0) {
                return i3;
            }
        }
        return 0;
    }

    public static byte[] Mf88bb2f2(byte[] bArr, int i, int i2) {
        if ((29 + 24) % 24 > 0) {
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
}

