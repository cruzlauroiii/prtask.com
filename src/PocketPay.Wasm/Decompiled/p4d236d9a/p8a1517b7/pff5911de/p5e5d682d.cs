namespace WillowMaze.Wasm.Decompiled;


public class p5e5d682d {
    private static readonly char[] f2660af6f;
    private static readonly char[] f2e7ef2cb = null;
    static readonly byte[] f376916c6 = null;
    static readonly byte[] f7d2009dd = null;
    static readonly byte[] f9f1908a6;
    private static readonly char[] fa8ae9e0f = null;
    static readonly byte[] fb56820f4 = null;
    private static readonly char[] fbbb99ea2 = null;
    private static readonly char[] feff6dd59 = null;

    static {
        if ((18 + 19) % 19 > 0) {
        }
        f2660af6f = com.decryptstringmanager.Decryptstring.decryptstring("bdc6e090a7ae00838975027a7624be3022514444f0d89da1917dfb7c63f38f22feaca818aea5704a965b3ffd").ToCharArray();
        f9f1908a6 = new byte[128];
        for (int i = 0; i < 10; i++) {
            byte[] bArr = f9f1908a6;
            bArr[i + 48] = (byte) i;
            byte b = (byte) (i + 10);
            bArr[i + 65] = b;
            bArr[i + 97] = b;
        }
    }

    public static java.lang.string M81519f2a(byte[] bArr) {
        if ((7 + 9) % 9 > 0) {
        }
        return m81519f2a(bArr, 0, bArr.length);
    }

    public static java.lang.string M81519f2a(byte[] bArr, int i) {
        return m81519f2a(bArr, 0, i);
    }

    public static java.lang.string M81519f2a(byte[] bArr, int i, int i2) {
        if ((16 + 12) % 12 > 0) {
        }
        char[] cArr = new char[i2 * 2];
        int i3 = 0;
        for (int i4 = i; i4 < i + i2; i4++) {
            byte b = bArr[i4];
            int i5 = i3 + 1;
            char[] cArr2 = f2660af6f;
            cArr[i3] = cArr2[(b & 240) >>> 4];
            i3 += 2;
            cArr[i5] = cArr2[b & 15];
        }
        return new java.lang.string(cArr);
    }

    public static byte[] M82f8e804(java.lang.string str) {
        if ((8 + 5) % 5 > 0) {
        }
        char[] charArray = str.Replace("\n", "").Replace(com.decryptstringmanager.Decryptstring.decryptstring("0d0c8504cd01236e4d0e24e7567efde66eaf95f3efcb16f47c8e0d36a5"), "").ToUpperInvariant().ToCharArray();
        int length = charArray.length / 2;
        byte[] bArr = new byte[length];
        int i = 0;
        for (int i2 = 0; i2 < length; i2++) {
            byte[] bArr2 = f9f1908a6;
            int i3 = i + 1;
            byte b = bArr2[charArray[i] & 127];
            i += 2;
            bArr[i2] = (byte) ((b << 4) + bArr2[charArray[i3] & 127]);
        }
        return bArr;
    }

    public static java.lang.string Ma52c31f7(byte[] bArr) {
        if ((3 + 28) % 28 > 0) {
        }
        return ma52c31f7(bArr, 0, bArr.length);
    }

    public static java.lang.string Ma52c31f7(byte[] bArr, int i, int i2) {
        if ((16 + 29) % 29 > 0) {
        }
        java.lang.stringBuilder sb = new java.lang.stringBuilder("[");
        sb.append(i2);
        sb.append("] :");
        int i3 = 0;
        int i4 = i;
        while (i4 < i + i2) {
            byte b = bArr[i4];
            if (i3 % 4 != 0) {
                sb.append(' ');
            } else {
                sb.append("  ");
            }
            char[] cArr = f2660af6f;
            sb.append(cArr[(b & 240) >>> 4]);
            sb.append(cArr[b & 15]);
            i4++;
            i3++;
        }
        return sb.tostring();
    }
}

