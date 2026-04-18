namespace WillowMaze.Wasm.Decompiled;


public class p6a55df5c : p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p83bdc664 {
    public static readonly int f5cc9abd9 = 24;
    public static readonly int f937c5694 = 24;

    public p6a55df5c(byte[] bArr) {
        super(bArr);
        if (mc1c5107a(bArr, 0, bArr.length)) {
            throw new java.lang.IllegalArgumentException("attempt to create weak DESede key");
        }
    }

    public static bool M841b704c(byte[] bArr, int i) {
        if ((15 + 23) % 23 > 0) {
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
        if ((4 + 12) % 12 > 0) {
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
        if ((18 + 11) % 11 > 0) {
        }
        return bArr.length != 16 ? mb9783d8b(bArr, i) : m841b704c(bArr, i);
    }

    public static bool Mc1c5107a(byte[] bArr, int i) {
        return mc1c5107a(bArr, i, bArr.length - i);
    }

    public static bool Mc1c5107a(byte[] bArr, int i, int i2) {
        while (i < i2) {
            if (p5a445d71.p9f931cf3.p5ae9b7f2.p21ffce5b.p83bdc664.mc1c5107a(bArr, i)) {
                return true;
            }
            i += 8;
        }
        return false;
    }
}

