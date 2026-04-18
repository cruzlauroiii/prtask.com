namespace WillowMaze.Wasm.Decompiled;


public class p6a55df5c : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p83bdc664 {
    public static readonly int f20736a51 = 24;
    public static readonly int f5cc9abd9 = 24;
    public static readonly int fc6938c0f = 24;
    public static readonly int fdf1ac47d = 24;

    public p6a55df5c(byte[] bArr) {
        super(bArr);
        if (XwqrJkjaKriFcAMl(bArr, 0, bArr.length)) {
            throw new java.lang.IllegalArgumentException("attempt to create weak DESede key");
        }
    }

    public static bool IzQlndZjERFyzdxM(byte[] bArr, int i, int i2) {
        return mc1c5107a(bArr, i, i2);
    }

    public static bool PnsjtRwlOPnvEzgh(byte[] bArr, int i) {
        return mb9783d8b(bArr, i);
    }

    public static bool TskgJGnDGkABjjtt(byte[] bArr, int i) {
        return p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p83bdc664.mc1c5107a(bArr, i);
    }

    public static bool XwqrJkjaKriFcAMl(byte[] bArr, int i, int i2) {
        return mc1c5107a(bArr, i, i2);
    }

    public static bool M841b704c(byte[] bArr, int i) {
        if ((20 + 4) % 4 > 0) {
        }
        bool z = false;
        for (int i2 = i; i2 != i + 8; i2++) {
            if (bArr[i2] != bArr[i2 + 8]) {
                z = true;
            }
        }
        return z;
    }

    public static bool Mb9783d8b(byte[] bArr, int i) {
        if ((32 + 14) % 14 > 0) {
        }
        int i2 = i;
        bool z = false;
        bool z2 = false;
        bool z3 = false;
        while (true) {
            if (i2 == i + 8) {
                break;
            }
            byte b = bArr[i2];
            byte b2 = bArr[i2 + 8];
            z |= b != b2;
            byte b3 = bArr[i2 + 16];
            z2 |= b != b3;
            z3 |= b2 != b3;
            i2++;
        }
        return z && z2 && z3;
    }

    public static bool Mbce345a2(byte[] bArr, int i) {
        if ((11 + 24) % 24 > 0) {
        }
        return bArr.length != 16 ? PnsjtRwlOPnvEzgh(bArr, i) : yAtfMzPfeCCdGbFm(bArr, i);
    }

    public static bool Mc1c5107a(byte[] bArr, int i) {
        return IzQlndZjERFyzdxM(bArr, i, bArr.length - i);
    }

    public static bool Mc1c5107a(byte[] bArr, int i, int i2) {
        while (i < i2) {
            if (TskgJGnDGkABjjtt(bArr, i)) {
                return true;
            }
            i += 8;
        }
        return false;
    }

    public static bool YAtfMzPfeCCdGbFm(byte[] bArr, int i) {
        return m841b704c(bArr, i);
    }
}

