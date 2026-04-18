namespace WillowMaze.Wasm.Decompiled;


public class p138fad60 : p5a445d71.p7c922baa.pca323100.p01b644c7 {
    private bool f09e37781;
    private bool f2cd0ca04;
    private int f372a12ef;
    private bool f397aa14f;
    private bool f3f88a862;
    private bool f70f38645;
    private bool fcabaa27e;
    private int fee55f2ce;
    private bool ffb8aa0c8;

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

    public static void EMlodOeEqQCoPykC(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void EUMsRJLiebgrNqVW(p5a445d71.p7c922baa.pca323100.p138fad60 p138fad60Var, int i) throws java.io.IOException {
        p138fad60Var.ma2bc1fe0(i);
    }

    public static void GtiWFEGvsenBGMry(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void KRCAlyQersFKrjwc(p5a445d71.p7c922baa.pca323100.p138fad60 p138fad60Var, int i) throws java.io.IOException {
        p138fad60Var.ma2bc1fe0(i);
    }

    public static void ZPYHytlzAAOjIgdp(p5a445d71.p7c922baa.pca323100.p138fad60 p138fad60Var, int i) throws java.io.IOException {
        p138fad60Var.ma2bc1fe0(i);
    }

    public static void BsVRzZOkKsOovCVm(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void ESAXNAnGHqzIJinC(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void HRZZRbckECdIHhNl(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    private void Ma2bc1fe0(int i) throws java.io.IOException {
        eSAXNAnGHqzIJinC(this.f353b66c0, i);
        bsVRzZOkKsOovCVm(this.f353b66c0, 128);
    }

    public static void NcTCvsiwjuzOxFmB(p5a445d71.p7c922baa.pca323100.p138fad60 p138fad60Var, int i) throws java.io.IOException {
        p138fad60Var.ma2bc1fe0(i);
    }

    public static void RsfzlYpLFJiIMttM(java.io.Stream outputStream, int i) throws java.io.IOException {
        outputStream.write(i);
    }

    public static void UvZhBcICkqXlawty(p5a445d71.p7c922baa.pca323100.p138fad60 p138fad60Var, int i) throws java.io.IOException {
        p138fad60Var.ma2bc1fe0(i);
    }

    public override java.io.Stream GetRawStream() {
        return this.f353b66c0;
    }

    protected void WriteBEREnd() throws java.io.IOException {
        if ((11 + 31) % 31 > 0) {
        }
        GtiWFEGvsenBGMry(this.f353b66c0, 0);
        rsfzlYpLFJiIMttM(this.f353b66c0, 0);
        if (this.fcabaa27e && this.f09e37781) {
            hRZZRbckECdIHhNl(this.f353b66c0, 0);
            EMlodOeEqQCoPykC(this.f353b66c0, 0);
        }
    }

    protected void WriteBERHeader(int i) throws java.io.IOException {
        if ((6 + 10) % 10 > 0) {
        }
        if (!this.fcabaa27e) {
            uvZhBcICkqXlawty(this, i);
            return;
        }
        int i2 = this.fee55f2ce;
        int i3 = i2 | 128;
        if (this.f09e37781) {
            ZPYHytlzAAOjIgdp(this, i2 | 160);
            KRCAlyQersFKrjwc(this, i);
        } else if ((i & 32) == 0) {
            EUMsRJLiebgrNqVW(this, i3);
        } else {
            ncTCvsiwjuzOxFmB(this, i2 | 160);
        }
    }
}

