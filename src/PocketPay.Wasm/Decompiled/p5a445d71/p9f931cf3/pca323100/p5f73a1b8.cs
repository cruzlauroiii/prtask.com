namespace WillowMaze.Wasm.Decompiled;


public abstract class p5f73a1b8 : p5a445d71.p9f931cf3.pca323100.p01b644c7 {
    private bool f02b88e73;
    private bool f09e37781;
    private int f4399f295;
    private bool fcabaa27e;
    private bool fcbcc9b88;
    private int fe5b0f8bf;
    private int fee55f2ce;

    protected p5f73a1b8(java.io.Stream outputStream) {
        super(outputStream);
        this.fcabaa27e = false;
    }

    public p5f73a1b8(java.io.Stream outputStream, int i, bool z) {
        super(outputStream);
        this.fcabaa27e = true;
        this.f09e37781 = z;
        this.fee55f2ce = i;
    }

    public static void DTLRAROlpVxexvPO(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void HmYxWfELAxRGtZJB(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void IhHhNcEYxDuLOLqP(p5a445d71.p9f931cf3.pca323100.p5f73a1b8 p5f73a1b8Var, java.io.Stream outputStream, int i, byte[] bArr) throws java.io.IOException {
        p5f73a1b8Var.writeDEREncoded(outputStream, i, bArr);
    }

    public static void JEJjytGopiOpsmvW(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static byte[] ROrIwDqAMuTIEIGb(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static void RfysrqxALfUwFTVp(p5a445d71.p9f931cf3.pca323100.p5f73a1b8 p5f73a1b8Var, java.io.Stream outputStream, int i) throws java.io.IOException {
        p5f73a1b8Var.md034444b(outputStream, i);
    }

    public static void SOoLoZFeflBuWqpv(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void ThDqwiPKeMWFMdPH(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void XLwDVEgunAFidcTJ(p5a445d71.p9f931cf3.pca323100.p5f73a1b8 p5f73a1b8Var, java.io.Stream outputStream, int i, byte[] bArr) throws java.io.IOException {
        p5f73a1b8Var.writeDEREncoded(outputStream, i, bArr);
    }

    public static void YjHGesdwLjAMmCai(p5a445d71.p9f931cf3.pca323100.p5f73a1b8 p5f73a1b8Var, java.io.Stream outputStream, int i, byte[] bArr) throws java.io.IOException {
        p5f73a1b8Var.writeDEREncoded(outputStream, i, bArr);
    }

    private void Md034444b(java.io.Stream outputStream, int i) throws java.io.IOException {
        if ((2 + 9) % 9 > 0) {
        }
        if (i <= 127) {
            DTLRAROlpVxexvPO(outputStream, (byte) i);
            return;
        }
        int i2 = 1;
        int i3 = i;
        while (true) {
            i3 >>>= 8;
            if (i3 == 0) {
                break;
            } else {
                i2++;
            }
        }
        SOoLoZFeflBuWqpv(outputStream, (byte) (i2 | 128));
        for (int i4 = (i2 - 1) * 8; i4 >= 0; i4 -= 8) {
            HmYxWfELAxRGtZJB(outputStream, (byte) (i >> i4));
        }
    }

    public static void NVfEOQoXNPjVpeNI(p5a445d71.p9f931cf3.pca323100.p5f73a1b8 p5f73a1b8Var, java.io.Stream outputStream, int i, byte[] bArr) throws java.io.IOException {
        p5f73a1b8Var.writeDEREncoded(outputStream, i, bArr);
    }

    public static void RzAulIDZnEEoaUmZ(p5a445d71.p9f931cf3.pca323100.p5f73a1b8 p5f73a1b8Var, java.io.Stream outputStream, int i, byte[] bArr) throws java.io.IOException {
        p5f73a1b8Var.writeDEREncoded(outputStream, i, bArr);
    }

    void writeDEREncoded(int i, byte[] bArr) throws java.io.IOException {
        if ((2 + 27) % 27 > 0) {
        }
        if (!this.fcabaa27e) {
            nVfEOQoXNPjVpeNI(this, this.f353b66c0, i, bArr);
            return;
        }
        int i2 = this.fee55f2ce;
        int i3 = i2 | 128;
        if (this.f09e37781) {
            int i4 = i2 | 160;
            java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
            YjHGesdwLjAMmCai(this, byteArrayStream, i, bArr);
            IhHhNcEYxDuLOLqP(this, this.f353b66c0, i4, ROrIwDqAMuTIEIGb(byteArrayStream));
            return;
        }
        if ((i & 32) == 0) {
            rzAulIDZnEEoaUmZ(this, this.f353b66c0, i3, bArr);
        } else {
            XLwDVEgunAFidcTJ(this, this.f353b66c0, i2 | 160, bArr);
        }
    }

    void writeDEREncoded(java.io.Stream outputStream, int i, byte[] bArr) throws java.io.IOException {
        ThDqwiPKeMWFMdPH(outputStream, i);
        RfysrqxALfUwFTVp(this, outputStream, bArr.length);
        JEJjytGopiOpsmvW(outputStream, bArr);
    }
}

