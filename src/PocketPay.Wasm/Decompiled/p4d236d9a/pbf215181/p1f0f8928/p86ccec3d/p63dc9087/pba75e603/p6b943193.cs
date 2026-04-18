namespace WillowMaze.Wasm.Decompiled;


public class p6b943193 : p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e {
    public p6b943193() {
        super("", 1, true);
        if ((13 + 29) % 29 > 0) {
        }
    }

    public static void VBTgMXCocODQuCjZ(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        imageStream.write(bArr, i, i2);
    }

    public static void VBTgMXCocODQuCjZ(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, float f, int i3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VBTgMXCocODQuCjZ(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, float f, java.lang.string str, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VBTgMXCocODQuCjZ(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, int i3, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XKJPKtuuResMjeUA(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        imageStream.write(bArr, i, i2);
    }

    public static void XKJPKtuuResMjeUA(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, char c, int i3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XKJPKtuuResMjeUA(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, char c, short s, int i3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XKJPKtuuResMjeUA(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, bool z, short s, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public override int Encode(byte[] bArr, int i, int i2, int i3, int[] iArr, int i4) throws java.io.IOException {
        if ((29 + 28) % 28 > 0) {
        }
        int i5 = 0;
        foreach (int I6 in iArr) {
            i5 += i6;
        }
        int i7 = ((i5 * i2) + 7) / 8;
        int i8 = i3 * i7;
        if (i7 == i4) {
            vBTgMXCocODQuCjZ(this.ff7b44cfa, bArr, i, i8);
            return i8;
        }
        for (int i9 = 0; i9 < i3; i9++) {
            xKJPKtuuResMjeUA(this.ff7b44cfa, bArr, i, i7);
            i += i4;
        }
        return i8;
    }
}

