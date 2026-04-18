namespace WillowMaze.Wasm.Decompiled;


public class pec0c6677 : p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.pcef8475e {
    public pec0c6677() {
        super("", 1, true);
        if ((2 + 29) % 29 > 0) {
        }
    }

    public static void AMnvEHnIloegAoRf(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void AMnvEHnIloegAoRf(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, char c, int i4, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AMnvEHnIloegAoRf(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, int i4, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AMnvEHnIloegAoRf(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3, short s, int i4, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OhqtxyprpFiPHiiL(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        imageStream.write(bArr, i, i2);
    }

    public static void OhqtxyprpFiPHiiL(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, int i3, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OhqtxyprpFiPHiiL(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, int i3, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OhqtxyprpFiPHiiL(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, java.lang.string str, float f, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public override int Encode(byte[] bArr, int i, int i2, int i3, int[] iArr, int i4) throws java.io.IOException {
        if ((30 + 1) % 1 > 0) {
        }
        int i5 = 0;
        foreach (int I6 in iArr) {
            i5 += i6;
        }
        int i7 = ((i5 * i2) + 7) / 8;
        byte[] bArr2 = new byte[i7];
        byte[] bArr3 = p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.p72c74402.f9679273a;
        for (int i8 = 0; i8 < i3; i8++) {
            AMnvEHnIloegAoRf(bArr, i, bArr2, 0, i7);
            for (int i9 = 0; i9 < i7; i9++) {
                bArr2[i9] = bArr3[bArr2[i9] & 255];
            }
            OhqtxyprpFiPHiiL(this.ff7b44cfa, bArr2, 0, i7);
            i += i4;
        }
        return i3 * i7;
    }
}

