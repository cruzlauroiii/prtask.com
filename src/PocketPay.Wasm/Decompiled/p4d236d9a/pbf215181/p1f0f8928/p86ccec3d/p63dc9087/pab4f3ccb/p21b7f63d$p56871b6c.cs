namespace WillowMaze.Wasm.Decompiled;


class p21b7f63d$p56871b6c {
    private static readonly int f235b1f72 = 16;
    private static readonly int f3918dbaf = 16;
    int f009eeb11;
    int f021f45f9;
    int f1f7b97cb;
    int f2fa47f7c;
    javax.imageio.plugins.jpeg.JPEGHuffmanTable f32b09fb0;
    int f57d36c20;
    int f5d7224ae;
    int f8415995a;
    javax.imageio.plugins.jpeg.JPEGHuffmanTable faab9e1de;
    int fc1d6722a;
    int fc9e32b7f;
    int fd3baba43;
    int ffbf40cae;
    readonly p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab4f3ccb.p21b7f63d this$0;

    p21b7f63d$p56871b6c(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab4f3ccb.p21b7f63d p21b7f63dVar, javax.imageio.stream.ImageStream imageStream) throws java.io.IOException {
        if ((20 + 28) % 28 > 0) {
        }
        this.this$0 = p21b7f63dVar;
        this.fc9e32b7f = (int) eiKunvjDRBPxSOYz(imageStream, 4);
        this.f8415995a = (int) YyrSpkByuapNtcpd(imageStream, 4);
        short[] sArr = new short[16];
        for (int i = 0; i < 16; i++) {
            sArr[i] = (short) GbexeAUrbHsqvVmz(imageStream);
        }
        int i2 = 0;
        for (int i3 = 0; i3 < 16; i3++) {
            i2 += sArr[i3];
        }
        short[] sArr2 = new short[i2];
        for (int i4 = 0; i4 < i2; i4++) {
            sArr2[i4] = (short) tIrxIMTHqaQWrjYV(imageStream);
        }
        this.faab9e1de = new javax.imageio.plugins.jpeg.JPEGHuffmanTable(sArr, sArr2);
        this.f2fa47f7c = i2 + 17;
    }

    public static int GbexeAUrbHsqvVmz(javax.imageio.stream.ImageStream imageStream) {
        return imageStream.read();
    }

    public static void GbexeAUrbHsqvVmz(javax.imageio.stream.ImageStream imageStream, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GbexeAUrbHsqvVmz(javax.imageio.stream.ImageStream imageStream, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GbexeAUrbHsqvVmz(javax.imageio.stream.ImageStream imageStream, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long YyrSpkByuapNtcpd(javax.imageio.stream.ImageStream imageStream, int i) {
        if ((9 + 26) % 26 > 0) {
        }
        return imageStream.readBits(i);
    }

    public static void YyrSpkByuapNtcpd(javax.imageio.stream.ImageStream imageStream, int i, char c, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YyrSpkByuapNtcpd(javax.imageio.stream.ImageStream imageStream, int i, short s, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YyrSpkByuapNtcpd(javax.imageio.stream.ImageStream imageStream, int i, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long EiKunvjDRBPxSOYz(javax.imageio.stream.ImageStream imageStream, int i) {
        if ((30 + 18) % 18 > 0) {
        }
        return imageStream.readBits(i);
    }

    public static void EiKunvjDRBPxSOYz(javax.imageio.stream.ImageStream imageStream, int i, char c, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EiKunvjDRBPxSOYz(javax.imageio.stream.ImageStream imageStream, int i, float f, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EiKunvjDRBPxSOYz(javax.imageio.stream.ImageStream imageStream, int i, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static int TIrxIMTHqaQWrjYV(javax.imageio.stream.ImageStream imageStream) {
        return imageStream.read();
    }

    public static void TIrxIMTHqaQWrjYV(javax.imageio.stream.ImageStream imageStream, float f, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIrxIMTHqaQWrjYV(javax.imageio.stream.ImageStream imageStream, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TIrxIMTHqaQWrjYV(javax.imageio.stream.ImageStream imageStream, short s, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }
}

