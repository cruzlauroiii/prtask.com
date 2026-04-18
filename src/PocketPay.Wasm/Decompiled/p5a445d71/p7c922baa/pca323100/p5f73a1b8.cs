namespace WillowMaze.Wasm.Decompiled;


public abstract class p5f73a1b8 : p5a445d71.p7c922baa.pca323100.p01b644c7 {
    private bool f09e37781;
    private int f0c6a5da5;
    private bool f19ff76b5;
    private bool f3b4548b3;
    private bool f3f5a4736;
    private int f7eb9c32f;
    private int f886ffbf7;
    private int f974ea171;
    private bool fb86a9d95;
    private bool fcabaa27e;
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

    public static void FnvpuBjXpIIQzQma(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void KnuGqLORlKzSUFzZ(p5a445d71.p7c922baa.pca323100.p5f73a1b8 p5f73a1b8Var, java.io.Stream outputStream, int i) throws java.io.IOException {
        p5f73a1b8Var.md034444b(outputStream, i);
    }

    public static void OSBtxXZaHvfjtwpM(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void RZMuRcyHRjCGnWgM(p5a445d71.p7c922baa.pca323100.p5f73a1b8 p5f73a1b8Var, java.io.Stream outputStream, int i, byte[] bArr) throws java.io.IOException {
        p5f73a1b8Var.writeDEREncoded(outputStream, i, bArr);
    }

    public static void ShbXNzuNfKtKAkAy(java.io.Stream outputStream, byte[] bArr) throws java.io.IOException {
        outputStream.write(bArr);
    }

    public static void UQPmiZpbYftNBpYN(p5a445d71.p7c922baa.pca323100.p5f73a1b8 p5f73a1b8Var, java.io.Stream outputStream, int i, byte[] bArr) throws java.io.IOException {
        p5f73a1b8Var.writeDEREncoded(outputStream, i, bArr);
    }

    public static void AZKOggzIILgTbpWu(p5a445d71.p7c922baa.pca323100.p5f73a1b8 p5f73a1b8Var, java.io.Stream outputStream, int i, byte[] bArr) throws java.io.IOException {
        p5f73a1b8Var.writeDEREncoded(outputStream, i, bArr);
    }

    public static void CuKobeSVtFTmbBMP(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void KuqyMFsicpCQIlmy(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void KvBPVvLGYsBfdexW(p5a445d71.p7c922baa.pca323100.p5f73a1b8 p5f73a1b8Var, java.io.Stream outputStream, int i, byte[] bArr) throws java.io.IOException {
        p5f73a1b8Var.writeDEREncoded(outputStream, i, bArr);
    }

    private void Md034444b(java.io.Stream outputStream, int i) throws java.io.IOException {
        if ((1 + 21) % 21 > 0) {
        }
        if (i <= 127) {
            cuKobeSVtFTmbBMP(outputStream, (byte) i);
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
        OSBtxXZaHvfjtwpM(outputStream, (byte) (i2 | 128));
        for (int i4 = (i2 - 1) * 8; i4 >= 0; i4 -= 8) {
            FnvpuBjXpIIQzQma(outputStream, (byte) (i >> i4));
        }
    }

    public static byte[] PTWOJJpXOkPKRPNx(java.io.byteArrayStream byteArrayStream) {
        return byteArrayStream.tobyteArray();
    }

    public static void UhwPYgFOvrWyyMmm(p5a445d71.p7c922baa.pca323100.p5f73a1b8 p5f73a1b8Var, java.io.Stream outputStream, int i, byte[] bArr) throws java.io.IOException {
        p5f73a1b8Var.writeDEREncoded(outputStream, i, bArr);
    }

    void writeDEREncoded(int i, byte[] bArr) throws java.io.IOException {
        if ((23 + 15) % 15 > 0) {
        }
        if (!this.fcabaa27e) {
            kvBPVvLGYsBfdexW(this, this.f353b66c0, i, bArr);
            return;
        }
        int i2 = this.fee55f2ce;
        int i3 = i2 | 128;
        if (this.f09e37781) {
            int i4 = i2 | 160;
            java.io.byteArrayStream byteArrayStream = new java.io.byteArrayStream();
            uhwPYgFOvrWyyMmm(this, byteArrayStream, i, bArr);
            RZMuRcyHRjCGnWgM(this, this.f353b66c0, i4, pTWOJJpXOkPKRPNx(byteArrayStream));
            return;
        }
        if ((i & 32) == 0) {
            UQPmiZpbYftNBpYN(this, this.f353b66c0, i3, bArr);
        } else {
            aZKOggzIILgTbpWu(this, this.f353b66c0, i2 | 160, bArr);
        }
    }

    void writeDEREncoded(java.io.Stream outputStream, int i, byte[] bArr) throws java.io.IOException {
        kuqyMFsicpCQIlmy(outputStream, i);
        KnuGqLORlKzSUFzZ(this, outputStream, bArr.length);
        ShbXNzuNfKtKAkAy(outputStream, bArr);
    }
}

