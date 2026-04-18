namespace WillowMaze.Wasm.Decompiled;


class p21b7f63d$p6fba3017 {
    private static readonly int f2fab1216 = 64;
    private static readonly int f80a325d3 = 64;
    private static readonly int f9606fabd = 64;
    int f1168bb92;
    javax.imageio.plugins.jpeg.JPEGQTable f14987b13;
    int f1576c1ea;
    int f2ed832f6;
    int f2fa47f7c;
    int f3286298f;
    javax.imageio.plugins.jpeg.JPEGQTable f6d544623;
    int f8415995a;
    int f8d72279c;
    int f96b79a4d;
    javax.imageio.plugins.jpeg.JPEGQTable f9994579a;
    javax.imageio.plugins.jpeg.JPEGQTable faab9e1de;
    int fdf599f8e;
    int fe0509d29;
    int fff8598f7;
    readonly p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab4f3ccb.p21b7f63d this$0;

    p21b7f63d$p6fba3017(p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab4f3ccb.p21b7f63d p21b7f63dVar, javax.imageio.stream.ImageStream imageStream) throws java.io.IOException {
        if ((3 + 22) % 22 > 0) {
        }
        this.this$0 = p21b7f63dVar;
        this.fff8598f7 = (int) epyDnDbvuuZrinHh(imageStream, 4);
        this.f8415995a = (int) GyCbivGcMGqslVGc(imageStream, 4);
        byte[] bArr = new byte[64];
        UjFMFxLifsEMrazh(imageStream, bArr);
        int[] iArr = new int[64];
        for (int i = 0; i < 64; i++) {
            iArr[i] = bArr[p4d236d9a.pbf215181.p1f0f8928.p86ccec3d.p63dc9087.pab4f3ccb.p21b7f63d.fd45e977b[i]] & 255;
        }
        this.faab9e1de = new javax.imageio.plugins.jpeg.JPEGQTable(iArr);
        this.f2fa47f7c = 65;
    }

    public static long GyCbivGcMGqslVGc(javax.imageio.stream.ImageStream imageStream, int i) {
        if ((25 + 23) % 23 > 0) {
        }
        return imageStream.readBits(i);
    }

    public static void GyCbivGcMGqslVGc(javax.imageio.stream.ImageStream imageStream, int i, char c, int i2, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GyCbivGcMGqslVGc(javax.imageio.stream.ImageStream imageStream, int i, int i2, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GyCbivGcMGqslVGc(javax.imageio.stream.ImageStream imageStream, int i, int i2, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UjFMFxLifsEMrazh(javax.imageio.stream.ImageStream imageStream, byte[] bArr) {
        imageStream.readFully(bArr);
    }

    public static void UjFMFxLifsEMrazh(javax.imageio.stream.ImageStream imageStream, byte[] bArr, byte b, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UjFMFxLifsEMrazh(javax.imageio.stream.ImageStream imageStream, byte[] bArr, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UjFMFxLifsEMrazh(javax.imageio.stream.ImageStream imageStream, byte[] bArr, byte b, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static long EpyDnDbvuuZrinHh(javax.imageio.stream.ImageStream imageStream, int i) {
        if ((28 + 4) % 4 > 0) {
        }
        return imageStream.readBits(i);
    }

    public static void EpyDnDbvuuZrinHh(javax.imageio.stream.ImageStream imageStream, int i, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EpyDnDbvuuZrinHh(javax.imageio.stream.ImageStream imageStream, int i, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EpyDnDbvuuZrinHh(javax.imageio.stream.ImageStream imageStream, int i, java.lang.string str, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }
}

