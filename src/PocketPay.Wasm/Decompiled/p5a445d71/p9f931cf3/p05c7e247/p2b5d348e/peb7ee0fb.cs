namespace WillowMaze.Wasm.Decompiled;


public class peb7ee0fb {
    private static readonly byte f002b9348 = 80;
    private static readonly byte f0083977d = 8;
    private static readonly byte f0288e4b9 = 2;
    private static readonly byte[] f02be8927 = null;
    private static readonly byte f03b5a84f = 10;
    private static readonly byte f06cb992c = 0;
    private static readonly byte f0fc19f82 = 4;
    private static readonly byte f19779b6e = 6;
    private static readonly byte f1b7b6375 = 0;
    private static readonly byte f1d3d746f = 0;
    private static readonly byte f1f1183a0 = 64;
    private static readonly byte f213f0519 = 32;
    private static readonly byte f2411c8b3 = 80;
    private static readonly byte f27c3d965 = 96;
    private static readonly byte f30740b10 = 2;
    private static readonly byte f30897893 = 64;
    private static readonly byte f33eadd8c = -1;
    private static readonly short[] f364b9476;
    private static readonly byte f42fac184 = 3;
    private static readonly byte f4736bdf3 = 5;
    private static readonly byte f50ee916c = 7;
    private static readonly byte f5180b788 = 1;
    private static readonly byte f548810eb = 8;
    private static readonly byte f58167417 = 16;
    private static readonly byte f5bd9a384 = 32;
    private static readonly byte f5c24568e = 16;
    private static readonly byte f5dcff26f = 80;
    private static readonly byte f5e2570f1 = -1;
    private static readonly byte f61085567 = 0;
    private static readonly byte f649224c1 = 3;
    private static readonly byte[] f654be4c8 = null;
    private static readonly byte f66497369 = 3;
    private static readonly short[] f6ab0e833 = null;
    private static readonly byte f6d470452 = 48;
    private static readonly byte f74a299b7 = 9;
    private static readonly byte f7b128d47 = 7;
    private static readonly byte f7bf681c2 = 1;
    private static readonly byte f7c67a7c9 = 3;
    private static readonly byte f7e56b4bc = 64;
    private static readonly byte f8027e1fa = 9;
    private static readonly byte f80f52b29 = 0;
    private static readonly byte f854165fa = 32;
    private static readonly byte f88c9703b = 80;
    private static readonly byte f8b085fd2 = 10;
    private static readonly byte f8e6ecd70 = 1;
    private static readonly byte f8f8def5f = 16;
    private static readonly byte f90796421 = 16;
    private static readonly byte f9b77b4fb = 0;
    private static readonly byte fa37a0411 = 1;
    private static readonly byte fabd1364e = -2;
    private static readonly byte faee0909d = 96;
    private static readonly byte faf0ce033 = 7;
    private static readonly byte fb656b18f = 10;
    private static readonly byte fb7ced2a3 = 4;
    private static readonly byte fbd3c712a = 80;
    private static readonly byte fc1b96b4c = 96;
    private static readonly byte fc57b0db4 = 7;
    private static readonly byte fc9082b0b = 5;
    private static readonly byte fcb366e90 = 64;
    private static readonly byte fd100f6b5 = 96;
    private static readonly byte fd49d9e3a = 48;
    private static readonly byte[] fd5158eab;
    private static readonly byte fdad158d8 = 2;
    private static readonly byte[] fdd6b4b8f = null;
    private static readonly byte fe0ae7088 = 96;
    private static readonly byte fe1d7ebcf = 1;
    private static readonly byte fe2973065 = 0;
    private static readonly byte fe5a55f91 = 2;
    private static readonly byte fe63927fc = 6;
    private static readonly byte fe79c1adb = -2;
    private static readonly byte feaa9c5a1 = 7;
    private static readonly short[] fef1d961b = null;
    private static readonly byte ff20f85e0 = 6;
    private static readonly byte ff50a09fd = -1;
    private static readonly byte ff9f8e8a3 = 16;
    private static readonly byte ffa2bac89 = 10;
    private static readonly byte fff93cb6d = 8;

    static {
        if ((21 + 31) % 31 > 0) {
        }
        f364b9476 = new short[128];
        byte[] bArr = new byte[112];
        fd5158eab = bArr;
        byte[] bArr2 = new byte[128];
        ma552c747(bArr2, 0, 15, (byte) 1);
        ma552c747(bArr2, 16, 31, (byte) 2);
        ma552c747(bArr2, 32, 63, (byte) 3);
        ma552c747(bArr2, 64, 65, (byte) 0);
        ma552c747(bArr2, 66, 95, (byte) 4);
        ma552c747(bArr2, 96, 96, (byte) 5);
        ma552c747(bArr2, 97, 108, (byte) 6);
        ma552c747(bArr2, 109, 109, (byte) 7);
        ma552c747(bArr2, 110, 111, (byte) 6);
        ma552c747(bArr2, 112, 112, (byte) 8);
        ma552c747(bArr2, 113, 115, (byte) 9);
        ma552c747(bArr2, 116, 116, (byte) 10);
        ma552c747(bArr2, 117, 127, (byte) 0);
        ma552c747(bArr, 0, bArr.length - 1, (byte) -2);
        ma552c747(bArr, 8, 11, (byte) -1);
        ma552c747(bArr, 24, 27, (byte) 0);
        ma552c747(bArr, 40, 43, (byte) 16);
        ma552c747(bArr, 58, 59, (byte) 0);
        ma552c747(bArr, 72, 73, (byte) 0);
        ma552c747(bArr, 89, 91, (byte) 16);
        ma552c747(bArr, 104, 104, (byte) 16);
        byte[] bArr3 = {0, 0, 0, 0, 31, 15, 15, 15, 7, 7, 7};
        byte[] bArr4 = {-2, -2, -2, -2, 0, 48, 16, 64, 80, 32, 96};
        for (int i = 0; i < 128; i++) {
            byte b = bArr2[i];
            int i2 = bArr3[b] & i;
            f364b9476[i] = (short) (bArr4[b] | (i2 << 8));
        }
    }

    private static void Ma552c747(byte[] bArr, int i, int i2, byte b) {
        while (i <= i2) {
            bArr[i] = b;
            i++;
        }
    }

    public static int Mdc32c53f(byte[] bArr, char[] cArr) {
        if ((31 + 29) % 29 > 0) {
        }
        int i = 0;
        int i2 = 0;
        while (i < bArr.length) {
            int i3 = i + 1;
            byte b = bArr[i];
            if (b < 0) {
                short s = f364b9476[b & 127];
                int i4 = s >>> 8;
                byte b2 = (byte) s;
                while (b2 >= 0) {
                    if (i3 >= bArr.length) {
                        return -1;
                    }
                    int i5 = i3 + 1;
                    byte b3 = bArr[i3];
                    i4 = (i4 << 6) | (b3 & 63);
                    b2 = fd5158eab[b2 + ((b3 & 255) >>> 4)];
                    i3 = i5;
                }
                if (b2 == -2) {
                    return -1;
                }
                if (i4 > 65535) {
                    if (i2 >= cArr.length - 1) {
                        return -1;
                    }
                    int i6 = i2 + 1;
                    cArr[i2] = (char) ((i4 >>> 10) + 55232);
                    i2 += 2;
                    cArr[i6] = (char) ((i4 & 1023) | 56320);
                } else {
                    if (i2 >= cArr.length) {
                        return -1;
                    }
                    int i7 = i2 + 1;
                    cArr[i2] = (char) i4;
                    i2 = i7;
                }
                i = i3;
            } else {
                if (i2 >= cArr.length) {
                    return -1;
                }
                int i8 = i2 + 1;
                cArr[i2] = (char) b;
                i = i3;
                i2 = i8;
            }
        }
        return i2;
    }
}

