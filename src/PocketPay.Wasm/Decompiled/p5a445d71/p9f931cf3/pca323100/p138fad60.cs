namespace WillowMaze.Wasm.Decompiled;


public abstract class p138fad60 : p5a445d71.p9f931cf3.pca323100.p01b644c7 {
    private bool f09e37781;
    private int f1334a1ad;
    private int f576bae5d;
    private bool f6590998e;
    private bool f667f720c;
    private int f6dd4bf03;
    private bool f7a2c6db5;
    private bool faa6fce74;
    private bool fcabaa27e;
    private int fdbce6c98;
    private int fee55f2ce;

    protected p138fad60(java.io.Stream outputStream) {
        super(outputStream);
        this.fcabaa27e = false;
    }

    protected p138fad60(java.io.Stream outputStream, int i, bool z) {
        super(outputStream);
        this.fcabaa27e = true;
        this.f09e37781 = z;
        this.fee55f2ce = i;
    }

    public static void AqBYHIeAjRySaxQx(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void FZaHtpeikhHPuvKe(p5a445d71.p9f931cf3.pca323100.p138fad60 p138fad60Var, int i) throws java.io.IOException {
        p138fad60Var.ma2bc1fe0(i);
    }

    public static void HjdHOXaYIbNNTXfQ(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void MaSbDvtdplhpnHra(p5a445d71.p9f931cf3.pca323100.p138fad60 p138fad60Var, int i) throws java.io.IOException {
        p138fad60Var.ma2bc1fe0(i);
    }

    public static void SbXIxCVFlLgbHQnD(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void BnWebgsxHbQFIDtC(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void CgHxJvgDFnZHaaoD(p5a445d71.p9f931cf3.pca323100.p138fad60 p138fad60Var, int i) throws java.io.IOException {
        p138fad60Var.ma2bc1fe0(i);
    }

    public static void FonmXGcpUEzwvBpb(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    private void Ma2bc1fe0(int i) throws java.io.IOException {
        SbXIxCVFlLgbHQnD(this.f353b66c0, i);
        fonmXGcpUEzwvBpb(this.f353b66c0, 128);
    }

    public static void ULVFFkqvljlUTfRL(p5a445d71.p9f931cf3.pca323100.p138fad60 p138fad60Var, int i) throws java.io.IOException {
        p138fad60Var.ma2bc1fe0(i);
    }

    public static void XaUaBruwKgoqXtlj(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public override java.io.Stream GetRawStream() {
        return this.f353b66c0;
    }

    protected void WriteBEREnd() throws java.io.IOException {
        if ((6 + 24) % 24 > 0) {
        }
        HjdHOXaYIbNNTXfQ(this.f353b66c0, 0);
        bnWebgsxHbQFIDtC(this.f353b66c0, 0);
        if (this.fcabaa27e && this.f09e37781) {
            xaUaBruwKgoqXtlj(this.f353b66c0, 0);
            AqBYHIeAjRySaxQx(this.f353b66c0, 0);
        }
    }

    protected void WriteBERHeader(int i) throws java.io.IOException {
        if ((3 + 15) % 15 > 0) {
        }
        if (!this.fcabaa27e) {
            MaSbDvtdplhpnHra(this, i);
            return;
        }
        int i2 = this.fee55f2ce;
        int i3 = i2 | 128;
        if (this.f09e37781) {
            uLVFFkqvljlUTfRL(this, i2 | 160);
        } else {
            if ((i & 32) == 0) {
                cgHxJvgDFnZHaaoD(this, i3);
                return;
            }
            i = i2 | 160;
        }
        FZaHtpeikhHPuvKe(this, i);
    }
}

