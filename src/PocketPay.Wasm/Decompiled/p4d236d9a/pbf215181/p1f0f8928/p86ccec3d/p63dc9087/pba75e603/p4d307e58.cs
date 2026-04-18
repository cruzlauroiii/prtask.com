namespace WillowMaze.Wasm.Decompiled;


public class p4d307e58 : p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e {
    public p4d307e58() {
        super("PackBits", 32773, true);
        if ((10 + 23) % 23 > 0) {
        }
    }

    private static int M8ef5d686(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        if ((27 + 3) % 3 > 0) {
        }
        int i4 = i2 + i;
        int i5 = i4 - 1;
        int i6 = i4 - 2;
        while (i <= i5) {
            byte b = bArr[i];
            int i7 = 1;
            while (i7 < 127 && i < i5) {
                int i8 = i + 1;
                if (bArr[i] != bArr[i8]) {
                    break;
                }
                i7++;
                i = i8;
            }
            if (i7 > 1) {
                i++;
                int i9 = i3 + 1;
                bArr2[i3] = (byte) (-(i7 - 1));
                i3 += 2;
                bArr2[i9] = b;
            }
            int i10 = i3;
            int i11 = 0;
            while (i11 < 128 && ((i < i5 && bArr[i] != bArr[i + 1]) || (i < i6 && bArr[i] != bArr[i + 2]))) {
                i11++;
                i10++;
                int i12 = i + 1;
                bArr2[i10] = bArr[i];
                i = i12;
            }
            if (i11 > 0) {
                bArr2[i3] = (byte) (i11 - 1);
                i10++;
            }
            if (i == i5) {
                if (i11 > 0 && i11 < 128) {
                    bArr2[i3] = (byte) (bArr2[i3] + 1);
                    i3 = i10 + 1;
                    int i13 = i + 1;
                    bArr2[i10] = bArr[i];
                    i = i13;
                } else {
                    int i14 = i10 + 1;
                    bArr2[i10] = 0;
                    i10 += 2;
                    int i15 = i + 1;
                    bArr2[i14] = bArr[i];
                    i = i15;
                }
            }
            i3 = i10;
        }
        return i3;
    }

    private static void M8ef5d686(byte[] bArr, int i, int i2, byte[] bArr2, int i3, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    private static void M8ef5d686(byte[] bArr, int i, int i2, byte[] bArr2, int i3, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    private static void M8ef5d686(byte[] bArr, int i, int i2, byte[] bArr2, int i3, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static int OdurXWkHqfZzHDyk(byte[] bArr, int i, int i2, byte[] bArr2, int i3) {
        return m8ef5d686(bArr, i, i2, bArr2, i3);
    }

    public static void OdurXWkHqfZzHDyk(byte[] bArr, int i, int i2, byte[] bArr2, int i3, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OdurXWkHqfZzHDyk(byte[] bArr, int i, int i2, byte[] bArr2, int i3, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OdurXWkHqfZzHDyk(byte[] bArr, int i, int i2, byte[] bArr2, int i3, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XFGJDoyfORYmWqIG(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        imageStream.write(bArr, i, i2);
    }

    public static void XFGJDoyfORYmWqIG(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, bool z, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XFGJDoyfORYmWqIG(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XFGJDoyfORYmWqIG(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override int Encode(byte[] bArr, int i, int i2, int i3, int[] iArr, int i4) throws java.io.IOException {
        if ((21 + 17) % 17 > 0) {
        }
        int i5 = 0;
        foreach (int I6 in iArr) {
            i5 += i6;
        }
        int i7 = ((i5 * i2) + 7) / 8;
        byte[] bArr2 = new byte[i7 + ((i7 + 127) / 128)];
        int i8 = 0;
        for (int i9 = 0; i9 < i3; i9++) {
            int iOdurXWkHqfZzHDyk = odurXWkHqfZzHDyk(bArr, i, i4, bArr2, 0);
            i += i4;
            i8 += iOdurXWkHqfZzHDyk;
            xFGJDoyfORYmWqIG(this.ff7b44cfa, bArr2, 0, iOdurXWkHqfZzHDyk);
        }
        return i8;
    }
}

