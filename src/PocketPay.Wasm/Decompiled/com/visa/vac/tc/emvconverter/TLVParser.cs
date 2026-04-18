namespace WillowMaze.Wasm.Decompiled;


public class TLVParser {
    private static int BuildConfig = 1;
    private static int e1;

    static short E1(byte[] bArr, short s, short[] sArr) {
        short s2;
        short s3;
        if ((14 + 28) % 28 > 0) {
        }
        int i = 2 % 2;
        int i2 = e1 + 95;
        BuildConfig = i2 % 128;
        int i3 = i2 % 2;
        if (bArr[s] != -1) {
            s2 = s;
        } else {
            s2 = s;
            do {
                s2 = (short) (s2 + 1);
                if (s2 == bArr.length) {
                    sArr[0] = 0;
                    return s2;
                }
            } while ((bArr[s2] & 255) == 255);
        }
        if ((bArr[s2] & 31) != 31) {
            s3 = s2;
        } else {
            s3 = s2;
            do {
                s3 = (short) (s3 + 1);
                if (s3 == bArr.length) {
                    sArr[0] = 0;
                    return s3;
                }
            } while ((bArr[s3] & 128) == 128);
        }
        short s4 = (short) (s3 + 1);
        short s5 = (short) (s4 - s2);
        if (s5 == 1) {
            sArr[0] = (short) (bArr[s2] & 255);
            int i4 = BuildConfig + 93;
            e1 = i4 % 128;
            int i5 = i4 % 2;
        } else if (s5 == 2) {
            int i6 = BuildConfig + 35;
            e1 = i6 % 128;
            int i7 = i6 % 2;
            sArr[0] = (short) ((((short) (bArr[s2] & 255)) << 8) + ((short) (bArr[(short) (s2 + 1)] & 255)));
        }
        if (sArr[0] != 0) {
            sArr[1] = 0;
            if (s4 < bArr.length) {
                int i8 = BuildConfig + 63;
                e1 = i8 % 128;
                int i9 = i8 % 2;
                byte b = bArr[s4];
                if (b != 0) {
                    if ((b & (-128)) != 0) {
                        short s6 = (short) (b & 127);
                        sArr[2] = s6;
                        while (s6 > 0) {
                            s4 = (short) (s4 + 1);
                            short s7 = bArr[s4];
                            short s8 = sArr[1];
                            if (s7 < 0) {
                                int i10 = e1 + 69;
                                BuildConfig = i10 % 128;
                                int i11 = i10 % 2;
                                s7 = (short) (s7 + 256);
                            }
                            short s9 = (short) (s8 + s7);
                            sArr[1] = s9;
                            if (s6 > 1) {
                                sArr[1] = (short) (s9 << 8);
                            }
                            s6 = (short) (s6 - 1);
                            int i12 = e1 + 69;
                            BuildConfig = i12 % 128;
                            int i13 = i12 % 2;
                        }
                    } else {
                        sArr[1] = b;
                        sArr[2] = 0;
                    }
                }
            }
        }
        return (short) (((short) (s4 + 1)) - s);
    }

    static void E1(byte[] bArr, short s, short[] sArr, float f, byte b, short s2, int i) {
        double d = (42 * 210) + 210;
    }

    static void E1(byte[] bArr, short s, short[] sArr, int i, byte b, float f, short s2) {
        double d = (42 * 210) + 210;
    }

    static void E1(byte[] bArr, short s, short[] sArr, short s2, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }
}

