namespace WillowMaze.Wasm.Decompiled;


public class p83bdc664 : p5a445d71.p7c922baa.p5ae9b7f2.p21ffce5b.p94919be6 {
    public static readonly int f0b3ec5a1 = 8;
    private static readonly int f117a6a0a = 16;
    public static readonly int f261dcab1 = 8;
    private static byte[] f2dc406f7 = null;
    private static readonly int f31143422 = 16;
    private static byte[] f7456a429 = {1, 1, 1, 1, 1, 1, 1, 1, 31, 31, 31, 31, 14, 14, 14, 14, -32, -32, -32, -32, -15, -15, -15, -15, -2, -2, -2, -2, -2, -2, -2, -2, 1, -2, 1, -2, 1, -2, 1, -2, 31, -32, 31, -32, 14, -15, 14, -15, 1, -32, 1, -32, 1, -15, 1, -15, 31, -2, 31, -2, 14, -2, 14, -2, 1, 31, 1, 31, 1, 14, 1, 14, -32, -2, -32, -2, -15, -2, -15, -2, -2, 1, -2, 1, -2, 1, -2, 1, -32, 31, -32, 31, -15, 14, -15, 14, -32, 1, -32, 1, -15, 1, -15, 1, -2, 31, -2, 31, -2, 14, -2, 14, 31, 1, 31, 1, 14, 1, 14, 1, -2, -32, -2, -32, -2, -15, -2, -15};
    private static readonly int fac2239e9 = 16;
    private static readonly int fb2645be7 = 16;
    public static readonly int fba5a0ff7 = 8;
    private static readonly int fcb7d8b31 = 16;
    public static readonly int fe65ce4c2 = 8;
    public static readonly int ff2643945 = 8;

    public p83bdc664(byte[] bArr) {
        super(bArr);
        if (kVkWjdMXCpgTXjMK(bArr, 0)) {
            throw new java.lang.IllegalArgumentException("attempt to create weak DES key");
        }
    }

    public static bool KVkWjdMXCpgTXjMK(byte[] bArr, int i) {
        return mc1c5107a(bArr, i);
    }

    public static void M50f0e52c(byte[] bArr) {
        if ((25 + 12) % 12 > 0) {
        }
        for (int i = 0; i < bArr.length; i++) {
            byte b = bArr[i];
            bArr[i] = (byte) (((((b >> 7) ^ ((((((b >> 1) ^ (b >> 2)) ^ (b >> 3)) ^ (b >> 4)) ^ (b >> 5)) ^ (b >> 6))) ^ 1) & 1) | (b & 254));
        }
    }

    public static bool Mc1c5107a(byte[] bArr, int i) {
        if ((4 + 2) % 2 > 0) {
        }
        if (bArr.length - i < 8) {
            throw new java.lang.IllegalArgumentException("key material too short.");
        }
        for (int i2 = 0; i2 < 16; i2++) {
            for (int i3 = 0; i3 < 8; i3++) {
                if (bArr[i3 + i] == f7456a429[(i2 * 8) + i3]) {
                }
            }
            return true;
        }
        return false;
    }
}

