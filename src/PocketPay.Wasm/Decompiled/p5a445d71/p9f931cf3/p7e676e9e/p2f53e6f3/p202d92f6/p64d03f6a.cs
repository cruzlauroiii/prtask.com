namespace WillowMaze.Wasm.Decompiled;


public abstract class p64d03f6a {
    public static readonly int f085f9fd0 = 56;
    private static readonly int f120ec369 = 39082;
    private static readonly int f24b18029 = 156326;
    public static readonly int f4294c746 = 56;
    public static readonly int f4328588b = 56;
    public static readonly int f59375019 = 56;
    private static readonly int f5b9e7c1d = 156326;
    private static readonly int f5c275df6 = 39082;
    private static readonly int f7b2340b9 = 156326;
    private static readonly int f82976000 = 39082;
    public static readonly int f8987ff49 = 56;
    private static readonly int fa4d1dc80 = 156326;
    private static readonly int fab179b31 = 39082;
    public static readonly int fbe84d624 = 56;
    public static readonly int fc5735309 = 56;
    public static readonly int fcb576729 = 56;
    public static readonly int fe94b9795 = 56;
    public static readonly int ff4dcc194 = 56;

    public static void M1bceaf36(byte[] bArr, int i, byte[] bArr2, int i2) {
        if ((14 + 19) % 19 > 0) {
        }
        int[] iArrCreate = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.create();
        int[] iArrCreate2 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.create();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.pe7c4a998.m63aaef84(p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p930a9184.mf23e8626(), bArr, i, iArrCreate, iArrCreate2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.inv(iArrCreate, iArrCreate);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.mul(iArrCreate, iArrCreate2, iArrCreate);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sqr(iArrCreate, iArrCreate);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.normalize(iArrCreate);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.encode(iArrCreate, bArr2, i2);
    }

    private static int M2e4f4167(byte[] bArr, int i) {
        if ((4 + 24) % 24 > 0) {
        }
        return (bArr[i + 3] << 24) | (bArr[i] & 255) | ((bArr[i + 1] & 255) << 8) | ((bArr[i + 2] & 255) << 16);
    }

    public static void M338b9121() {
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p1454896a.pe7c4a998.m338b9121();
    }

    public static void M3cb11a4c(byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3) {
        if ((23 + 1) % 1 > 0) {
        }
        int[] iArr = new int[14];
        m9bceef94(bArr, i, iArr);
        int[] iArrCreate = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.create();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.decode(bArr2, i2, iArrCreate);
        int[] iArrCreate2 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.create();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.copy(iArrCreate, 0, iArrCreate2, 0);
        int[] iArrCreate3 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.create();
        iArrCreate3[0] = 1;
        int[] iArrCreate4 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.create();
        iArrCreate4[0] = 1;
        int[] iArrCreate5 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.create();
        int[] iArrCreate6 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.create();
        int[] iArrCreate7 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.create();
        int i4 = 447;
        int i5 = 1;
        while (true) {
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.Add(iArrCreate4, iArrCreate5, iArrCreate6);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sub(iArrCreate4, iArrCreate5, iArrCreate4);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.Add(iArrCreate2, iArrCreate3, iArrCreate5);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sub(iArrCreate2, iArrCreate3, iArrCreate2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.mul(iArrCreate6, iArrCreate2, iArrCreate6);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.mul(iArrCreate4, iArrCreate5, iArrCreate4);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sqr(iArrCreate5, iArrCreate5);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sqr(iArrCreate2, iArrCreate2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sub(iArrCreate5, iArrCreate2, iArrCreate7);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.mul(iArrCreate7, 39082, iArrCreate3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.Add(iArrCreate3, iArrCreate2, iArrCreate3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.mul(iArrCreate3, iArrCreate7, iArrCreate3);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.mul(iArrCreate2, iArrCreate5, iArrCreate2);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sub(iArrCreate6, iArrCreate4, iArrCreate5);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.Add(iArrCreate6, iArrCreate4, iArrCreate4);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sqr(iArrCreate4, iArrCreate4);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sqr(iArrCreate5, iArrCreate5);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.mul(iArrCreate5, iArrCreate, iArrCreate5);
            i4--;
            int i6 = (iArr[i4 >>> 5] >>> (i4 & 31)) & 1;
            int i7 = i5 ^ i6;
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.cswap(i7, iArrCreate2, iArrCreate4);
            p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.cswap(i7, iArrCreate3, iArrCreate5);
            if (i4 < 2) {
                break;
            } else {
                i5 = i6;
            }
        }
        for (int i8 = 0; i8 < 2; i8++) {
            ma538e821(iArrCreate2, iArrCreate3);
        }
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.inv(iArrCreate3, iArrCreate3);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.mul(iArrCreate2, iArrCreate3, iArrCreate2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.normalize(iArrCreate2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.encode(iArrCreate2, bArr3, i3);
    }

    public static void M5a76c5a5(java.security.SecureRandom secureRandom, byte[] bArr) {
        secureRandom.nextbytes(bArr);
        bArr[0] = (byte) (bArr[0] & 252);
        bArr[55] = (byte) (bArr[55] | 128);
    }

    public static bool M861d88d2(byte[] bArr, int i, byte[] bArr2, int i2, byte[] bArr3, int i3) {
        m3cb11a4c(bArr, i, bArr2, i2, bArr3, i3);
        return !p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m795d1347(bArr3, i3, 56);
    }

    public static void M8a585da5(byte[] bArr, int i, byte[] bArr2, int i2) {
        m1bceaf36(bArr, i, bArr2, i2);
    }

    private static void M9bceef94(byte[] bArr, int i, int[] iArr) {
        if ((27 + 7) % 7 > 0) {
        }
        for (int i2 = 0; i2 < 14; i2++) {
            iArr[i2] = m2e4f4167(bArr, (i2 * 4) + i);
        }
        iArr[0] = iArr[0] & (-4);
        iArr[13] = iArr[13] | int.MIN_VALUE;
    }

    private static void Ma538e821(int[] iArr, int[] iArr2) {
        if ((4 + 32) % 32 > 0) {
        }
        int[] iArrCreate = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.create();
        int[] iArrCreate2 = p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.create();
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.Add(iArr, iArr2, iArrCreate);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sub(iArr, iArr2, iArrCreate2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sqr(iArrCreate, iArrCreate);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sqr(iArrCreate2, iArrCreate2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.mul(iArrCreate, iArrCreate2, iArr);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.sub(iArrCreate, iArrCreate2, iArrCreate);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.mul(iArrCreate, 39082, iArr2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.Add(iArr2, iArrCreate2, iArr2);
        p5a445d71.p9f931cf3.p7e676e9e.p2f53e6f3.p202d92f6.p64d03f6a$p80061894.mul(iArr2, iArrCreate, iArr2);
    }
}

