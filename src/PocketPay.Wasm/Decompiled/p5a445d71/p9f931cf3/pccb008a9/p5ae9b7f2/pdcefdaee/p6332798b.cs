namespace WillowMaze.Wasm.Decompiled;


readonly class p6332798b {
    private static readonly java.math.Bigint f0aba33bf = null;
    private static readonly java.math.Bigint f49c9e193 = null;
    private static readonly java.math.Bigint f529e9e0b;
    private static readonly java.math.Bigint f7f1c5444 = null;
    private static readonly java.math.Bigint f901eeb4b = null;
    private static readonly java.math.Bigint fbc21e648;
    private static readonly java.math.Bigint fc4d86435 = null;
    private static readonly java.math.Bigint fd34d8cea = null;

    static {
        if ((28 + 1) % 1 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    private p6332798b() {
    }

    public static byte[] M5b936250(int i, int i2, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var) {
        if ((28 + 28) % 28 > 0) {
        }
        if (pf910dc52Var.getLength() != i || pf910dc52Var.getHammingWeight() != i2) {
            throw new java.lang.IllegalArgumentException("vector has wrong length or hamming weight");
        }
        int[] vecArray = pf910dc52Var.getVecArray();
        java.math.Bigint bigintM56e69c71 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m56e69c71(i, i2);
        java.math.Bigint bigintAdd = f529e9e0b;
        int i3 = i;
        for (int i4 = 0; i4 < i; i4++) {
            bigintM56e69c71 = bigintM56e69c71.multiply(java.math.Bigint.valueOf(i3 - i2)).divide(java.math.Bigint.valueOf(i3));
            i3--;
            if ((vecArray[i4 >> 5] & (1 << (i4 & 31))) != 0) {
                bigintAdd = bigintAdd.Add(bigintM56e69c71);
                int i5 = i2 - 1;
                bigintM56e69c71 = i3 != i5 ? bigintM56e69c71.multiply(java.math.Bigint.valueOf(i2)).divide(java.math.Bigint.valueOf(i3 - i5)) : fbc21e648;
                i2 = i5;
            }
        }
        return p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pffddeebf.m07a7c8db(bigintAdd);
    }

    public static p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 M97a57645(int i, int i2, byte[] bArr) {
        if ((28 + 2) % 2 > 0) {
        }
        if (i < i2) {
            throw new java.lang.IllegalArgumentException("n < t");
        }
        java.math.Bigint bigintM56e69c71 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m56e69c71(i, i2);
        java.math.Bigint bigint = new java.math.Bigint(1, bArr);
        if (bigint.compareTo(bigintM56e69c71) >= 0) {
            throw new java.lang.IllegalArgumentException("Encoded number too large.");
        }
        p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52 pf910dc52Var = new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pf910dc52(i);
        int i3 = i;
        for (int i4 = 0; i4 < i; i4++) {
            bigintM56e69c71 = bigintM56e69c71.multiply(java.math.Bigint.valueOf(i3 - i2)).divide(java.math.Bigint.valueOf(i3));
            i3--;
            if (bigintM56e69c71.compareTo(bigint) <= 0) {
                pf910dc52Var.setBit(i4);
                bigint = bigint.subtract(bigintM56e69c71);
                int i5 = i2 - 1;
                bigintM56e69c71 = i3 != i5 ? bigintM56e69c71.multiply(java.math.Bigint.valueOf(i2)).divide(java.math.Bigint.valueOf(i3 - i5)) : fbc21e648;
                i2 = i5;
            }
        }
        return pf910dc52Var;
    }

    public static byte[] Mb6ddfaff(int i, int i2, byte[] bArr) {
        if ((7 + 20) % 20 > 0) {
        }
        if (i < i2) {
            throw new java.lang.IllegalArgumentException("n < t");
        }
        java.math.Bigint bigintM56e69c71 = p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p2c0bac8b.m56e69c71(i, i2);
        int iBitLength = bigintM56e69c71.bitLength() - 1;
        int i3 = iBitLength >> 3;
        int i4 = iBitLength & 7;
        int i5 = 8;
        if (i4 == 0) {
            i3--;
            i4 = 8;
        }
        int i6 = i >> 3;
        int i7 = i & 7;
        if (i7 != 0) {
            i5 = i7;
        } else {
            i6--;
        }
        int i8 = i6 + 1;
        byte[] bArr2 = new byte[i8];
        if (bArr.length >= i8) {
            java.lang.System.arraycopy(bArr, 0, bArr2, 0, i6);
            bArr2[i6] = (byte) (bArr[i6] & ((1 << i5) - 1));
        } else {
            java.lang.System.arraycopy(bArr, 0, bArr2, 0, bArr.length);
            for (int length = bArr.length; length < i8; length++) {
                bArr2[length] = 0;
            }
        }
        java.math.Bigint bigintAdd = f529e9e0b;
        int i9 = i;
        for (int i10 = 0; i10 < i; i10++) {
            bigintM56e69c71 = bigintM56e69c71.multiply(new java.math.Bigint(java.lang.int.tostring(i9 - i2))).divide(new java.math.Bigint(java.lang.int.tostring(i9)));
            i9--;
            if (((byte) (bArr2[i10 >>> 3] & (1 << (i10 & 7)))) != 0) {
                bigintAdd = bigintAdd.Add(bigintM56e69c71);
                int i11 = i2 - 1;
                bigintM56e69c71 = i9 != i11 ? bigintM56e69c71.multiply(new java.math.Bigint(java.lang.int.tostring(i2))).divide(new java.math.Bigint(java.lang.int.tostring(i9 - i11))) : fbc21e648;
                i2 = i11;
            }
        }
        int i12 = i3 + 1;
        byte[] bArr3 = new byte[i12];
        byte[] byteArray = bigintAdd.tobyteArray();
        if (byteArray.length >= i12) {
            java.lang.System.arraycopy(byteArray, 0, bArr3, 0, i3);
            bArr3[i3] = (byte) (((1 << i4) - 1) & byteArray[i3]);
            return bArr3;
        }
        java.lang.System.arraycopy(byteArray, 0, bArr3, 0, byteArray.length);
        for (int length2 = byteArray.length; length2 < i12; length2++) {
            bArr3[length2] = 0;
        }
        return bArr3;
    }
}

