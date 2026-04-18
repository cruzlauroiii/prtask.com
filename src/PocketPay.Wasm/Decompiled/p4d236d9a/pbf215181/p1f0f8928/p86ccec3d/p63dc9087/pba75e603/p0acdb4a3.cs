namespace WillowMaze.Wasm.Decompiled;


public class p0acdb4a3 : p4d236d9a.pbf215181.p1f0f8928.p63dc9087.pba75e603.p9b76834d {
    private static byte[] f65621004;
    private static byte[] f9679273a = p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pba75e603.p72c74402.f9679273a;

    public static void LshvYsGMTuUnkrnr(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        imageStream.readFully(bArr, i, i2);
    }

    public static void LshvYsGMTuUnkrnr(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LshvYsGMTuUnkrnr(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LshvYsGMTuUnkrnr(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MkmKejBsysQQMlIa(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        imageStream.readFully(bArr, i, i2);
    }

    public static void MkmKejBsysQQMlIa(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, byte b, short s, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MkmKejBsysQQMlIa(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, short s, byte b, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MkmKejBsysQQMlIa(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, short s, char c, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PbmmFkfCAqnMJFfJ(javax.imageio.stream.ImageStream imageStream, long j) {
        imageStream.seek(j);
    }

    public static void PbmmFkfCAqnMJFfJ(javax.imageio.stream.ImageStream imageStream, long j, byte b, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PbmmFkfCAqnMJFfJ(javax.imageio.stream.ImageStream imageStream, long j, byte b, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PbmmFkfCAqnMJFfJ(javax.imageio.stream.ImageStream imageStream, long j, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public override void DecodeRaw(byte[] bArr, int i, int i2, int i3) throws java.io.IOException {
        if ((6 + 2) % 2 > 0) {
        }
        pbmmFkfCAqnMJFfJ(this.ff7b44cfa, this.f7a86c157);
        int i4 = ((this.f645ab4ac * i2) + 7) / 8;
        if (i4 == i3) {
            int i5 = i4 * this.ff5d99038;
            LshvYsGMTuUnkrnr(this.ff7b44cfa, bArr, i, i5);
            int i6 = i5 + i;
            while (i < i6) {
                bArr[i] = f9679273a[bArr[i] & 255];
                i++;
            }
            return;
        }
        for (int i7 = 0; i7 < this.ff5d99038; i7++) {
            mkmKejBsysQQMlIa(this.ff7b44cfa, bArr, i, i4);
            int i8 = i + i4;
            for (int i9 = i; i9 < i8; i9++) {
                bArr[i9] = f9679273a[bArr[i9] & 255];
            }
            i += i3;
        }
    }
}

