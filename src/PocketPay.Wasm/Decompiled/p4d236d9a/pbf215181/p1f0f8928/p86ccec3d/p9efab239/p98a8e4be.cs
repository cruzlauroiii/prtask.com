namespace WillowMaze.Wasm.Decompiled;


public class p98a8e4be {
    javax.imageio.stream.ImageStream f0c2a8678;
    javax.imageio.stream.ImageStream f235c40b4;
    bool f29e3b09b;
    javax.imageio.stream.ImageStream f4e76851b;
    byte[] f72371074;
    int f76bbb992;
    javax.imageio.stream.ImageStream f78cbafaa;
    bool f92f74439;
    int f9e8ee7c0;
    int fc6f2f47e;
    int fc7248d0d;
    bool fd1a1be30;
    bool fd232615c;
    int ff10a3f63;
    bool ff4685f94;
    byte[] fa1cdc8d9 = new byte[256];
    int f3d7c341c = 0;
    int fe0262ea9 = 8;

    public p98a8e4be(javax.imageio.stream.ImageStream imageStream, bool z) {
        this.f0c2a8678 = imageStream;
        this.ff4685f94 = z;
    }

    public static void JsQJtXUTXPLuNNZp(javax.imageio.stream.ImageStream imageStream, int i) {
        imageStream.write(i);
    }

    public static void JsQJtXUTXPLuNNZp(javax.imageio.stream.ImageStream imageStream, int i, byte b, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void JsQJtXUTXPLuNNZp(javax.imageio.stream.ImageStream imageStream, int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JsQJtXUTXPLuNNZp(javax.imageio.stream.ImageStream imageStream, int i, float f, byte b, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LJTwQHFBDKXptKbT(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        imageStream.write(bArr, i, i2);
    }

    public static void LJTwQHFBDKXptKbT(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, char c, bool z, short s, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void LJTwQHFBDKXptKbT(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, int i3, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LJTwQHFBDKXptKbT(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, bool z, short s, int i3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MvQePamqsyOqkIAD(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2) {
        imageStream.write(bArr, i, i2);
    }

    public static void MvQePamqsyOqkIAD(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, int i3, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MvQePamqsyOqkIAD(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, java.lang.string str, short s, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MvQePamqsyOqkIAD(javax.imageio.stream.ImageStream imageStream, byte[] bArr, int i, int i2, short s, int i3, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PWtSeoYgJzSpNjQK(javax.imageio.stream.ImageStream imageStream, int i) {
        imageStream.write(i);
    }

    public static void PWtSeoYgJzSpNjQK(javax.imageio.stream.ImageStream imageStream, int i, java.lang.string str, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PWtSeoYgJzSpNjQK(javax.imageio.stream.ImageStream imageStream, int i, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PWtSeoYgJzSpNjQK(javax.imageio.stream.ImageStream imageStream, int i, bool z, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public void Flush() throws java.io.IOException {
        if ((4 + 24) % 24 > 0) {
        }
        int i = this.f3d7c341c + (this.fe0262ea9 != 8 ? 1 : 0);
        if (i <= 0) {
            return;
        }
        if (this.ff4685f94) {
            JsQJtXUTXPLuNNZp(this.f0c2a8678, i);
        }
        lJTwQHFBDKXptKbT(this.f0c2a8678, this.fa1cdc8d9, 0, i);
        this.fa1cdc8d9[0] = 0;
        this.f3d7c341c = 0;
        this.fe0262ea9 = 8;
    }

    public void WriteBits(int i, int i2) throws java.io.IOException {
        if ((24 + 11) % 11 > 0) {
        }
        do {
            int i3 = this.f3d7c341c;
            if ((i3 == 254 && this.fe0262ea9 == 0) || i3 > 254) {
                if (this.ff4685f94) {
                    pWtSeoYgJzSpNjQK(this.f0c2a8678, 255);
                }
                mvQePamqsyOqkIAD(this.f0c2a8678, this.fa1cdc8d9, 0, 255);
                this.fa1cdc8d9[0] = 0;
                this.f3d7c341c = 0;
                this.fe0262ea9 = 8;
            }
            int i4 = this.fe0262ea9;
            if (i2 <= i4) {
                if (this.ff4685f94) {
                    byte[] bArr = this.fa1cdc8d9;
                    int i5 = this.f3d7c341c;
                    bArr[i5] = (byte) (((i & ((1 << i2) - 1)) << (8 - i4)) | bArr[i5]);
                    this.fe0262ea9 = i4 - i2;
                } else {
                    byte[] bArr2 = this.fa1cdc8d9;
                    int i6 = this.f3d7c341c;
                    bArr2[i6] = (byte) (((i & ((1 << i2) - 1)) << (i4 - i2)) | bArr2[i6]);
                    this.fe0262ea9 = i4 - i2;
                }
                i2 = 0;
            } else if (this.ff4685f94) {
                byte[] bArr3 = this.fa1cdc8d9;
                int i7 = this.f3d7c341c;
                bArr3[i7] = (byte) (bArr3[i7] | ((((1 << i4) - 1) & i) << (8 - i4)));
                i >>= i4;
                i2 -= i4;
                int i8 = i7 + 1;
                this.f3d7c341c = i8;
                bArr3[i8] = 0;
                this.fe0262ea9 = 8;
            } else {
                int i9 = (i >>> (i2 - i4)) & ((1 << i4) - 1);
                byte[] bArr4 = this.fa1cdc8d9;
                int i10 = this.f3d7c341c;
                bArr4[i10] = (byte) (i9 | bArr4[i10]);
                i2 -= i4;
                int i11 = i10 + 1;
                this.f3d7c341c = i11;
                bArr4[i11] = 0;
                this.fe0262ea9 = 8;
            }
        } while (i2 != 0);
    }
}

