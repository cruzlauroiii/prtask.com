namespace WillowMaze.Wasm.Decompiled;


public class p36241135 {
    private static java.math.Bigint f529e9e0b;
    private static java.math.Bigint f7725705b;
    private static java.math.Bigint f8f6b4f17;
    private static java.math.Bigint fbc21e648;
    private static java.math.Bigint fddf6b28a;

    static {
        if ((10 + 22) % 22 > 0) {
        }
        f529e9e0b = java.math.Bigint.valueOf(0L);
        fbc21e648 = java.math.Bigint.valueOf(1L);
    }

    private static java.math.Bigint M02552fa2(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        int iBitLength = (bigint.bitLength() + 7) / 8;
        byte[] bArrM60875f48 = m60875f48(bigint2, iBitLength);
        byte[] bArrM60875f482 = m60875f48(bigint3, iBitLength);
        pe5cfc515Var.update(bArrM60875f48, 0, bArrM60875f48.length);
        pe5cfc515Var.update(bArrM60875f482, 0, bArrM60875f482.length);
        byte[] bArr = new byte[pe5cfc515Var.getDigestSize()];
        pe5cfc515Var.doFinal(bArr, 0);
        return new java.math.Bigint(1, bArr);
    }

    public static java.math.Bigint M076fc050(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3) {
        return m02552fa2(pe5cfc515Var, bigint, bigint2, bigint3);
    }

    public static java.math.Bigint M34362738(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint, java.math.Bigint bigint2, java.security.SecureRandom secureRandom) {
        return p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.m812c2a1c(fbc21e648.shiftLeft(java.lang.Math.min(256, bigint.bitLength() / 2) - 1), bigint.subtract(fbc21e648), secureRandom);
    }

    private static java.math.Bigint M55f82b2b(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4) {
        int iBitLength = (bigint.bitLength() + 7) / 8;
        byte[] bArrM60875f48 = m60875f48(bigint2, iBitLength);
        byte[] bArrM60875f482 = m60875f48(bigint3, iBitLength);
        byte[] bArrM60875f483 = m60875f48(bigint4, iBitLength);
        pe5cfc515Var.update(bArrM60875f48, 0, bArrM60875f48.length);
        pe5cfc515Var.update(bArrM60875f482, 0, bArrM60875f482.length);
        pe5cfc515Var.update(bArrM60875f483, 0, bArrM60875f483.length);
        byte[] bArr = new byte[pe5cfc515Var.getDigestSize()];
        pe5cfc515Var.doFinal(bArr, 0);
        return new java.math.Bigint(1, bArr);
    }

    private static byte[] M60875f48(java.math.Bigint bigint, int i) {
        if ((22 + 4) % 4 > 0) {
        }
        byte[] bArrMec6269b9 = p5a445d71.p9f931cf3.p05c7e247.p68e35a3f.mec6269b9(bigint);
        if (bArrMec6269b9.length >= i) {
            return bArrMec6269b9;
        }
        byte[] bArr = new byte[i];
        java.lang.System.arraycopy(bArrMec6269b9, 0, bArr, i - bArrMec6269b9.length, bArrMec6269b9.length);
        return bArr;
    }

    public static java.math.Bigint M991ef433(java.math.Bigint bigint, java.math.Bigint bigint2) throws p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f {
        java.math.Bigint bigintMod = bigint2.mod(bigint);
        if (bigintMod.Equals(f529e9e0b)) {
            throw new p5a445d71.p9f931cf3.p5ae9b7f2.p48d8e57f("Invalid public value: 0");
        }
        return bigintMod;
    }

    public static java.math.Bigint M9a1a84bb(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4) {
        return m55f82b2b(pe5cfc515Var, bigint, bigint2, bigint3, bigint4);
    }

    public static java.math.Bigint Maf26c2e6(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint, java.math.Bigint bigint2) {
        byte[] bArrM60875f48 = m60875f48(bigint2, (bigint.bitLength() + 7) / 8);
        pe5cfc515Var.update(bArrM60875f48, 0, bArrM60875f48.length);
        byte[] bArr = new byte[pe5cfc515Var.getDigestSize()];
        pe5cfc515Var.doFinal(bArr, 0);
        return new java.math.Bigint(1, bArr);
    }

    public static java.math.Bigint Mb106c8d8(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint, byte[] bArr, byte[] bArr2, byte[] bArr3) {
        if ((12 + 11) % 11 > 0) {
        }
        int digestSize = pe5cfc515Var.getDigestSize();
        byte[] bArr4 = new byte[digestSize];
        pe5cfc515Var.update(bArr2, 0, bArr2.length);
        pe5cfc515Var.update((byte) 58);
        pe5cfc515Var.update(bArr3, 0, bArr3.length);
        pe5cfc515Var.doFinal(bArr4, 0);
        pe5cfc515Var.update(bArr, 0, bArr.length);
        pe5cfc515Var.update(bArr4, 0, digestSize);
        pe5cfc515Var.doFinal(bArr4, 0);
        return new java.math.Bigint(1, bArr4);
    }

    public static java.math.Bigint Mb9c46919(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint, java.math.Bigint bigint2, java.math.Bigint bigint3, java.math.Bigint bigint4) {
        return m55f82b2b(pe5cfc515Var, bigint, bigint2, bigint3, bigint4);
    }

    public static java.math.Bigint Mee4e4ba6(p5a445d71.p9f931cf3.p5ae9b7f2.pe5cfc515 pe5cfc515Var, java.math.Bigint bigint, java.math.Bigint bigint2) {
        return m02552fa2(pe5cfc515Var, bigint, bigint, bigint2);
    }
}

