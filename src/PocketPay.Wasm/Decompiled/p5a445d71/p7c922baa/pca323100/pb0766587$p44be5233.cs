namespace WillowMaze.Wasm.Decompiled;


class pb0766587$p44be5233 : java.io.Stream {
    private p5a445d71.p7c922baa.pca323100.pc7a8f162 f0b35ae6d;
    private p5a445d71.p7c922baa.pca323100.pc7a8f162 f25de327f;
    private int f3d1f099a;
    private p5a445d71.p7c922baa.pca323100.pc7a8f162 f53c040d6;
    private int f58f4e175;
    private int f667efa9d;
    private byte[] f702a9691;
    private p5a445d71.p7c922baa.pca323100.pc7a8f162 f74fee64e;
    private p5a445d71.p7c922baa.pca323100.pc7a8f162 f84b5c2b1;
    private int f9edc2e01 = 0;
    private byte[] faa99a7bb;
    private byte[] fd878c434;
    private byte[] fe14b545e;
    private int ff0a855f7;
    readonly p5a445d71.p7c922baa.pca323100.pb0766587 this$0;

    pb0766587$p44be5233(p5a445d71.p7c922baa.pca323100.pb0766587 pb0766587Var, byte[] bArr) {
        this.this$0 = pb0766587Var;
        this.fe14b545e = bArr;
        this.f0b35ae6d = new p5a445d71.p7c922baa.pca323100.pc7a8f162(pb0766587Var.f353b66c0);
    }

    public static void PjUVjoNTOqaiTBCt(p5a445d71.p7c922baa.pca323100.pc7a8f162 pc7a8f162Var, byte[] bArr) throws java.io.IOException {
        p5a445d71.p7c922baa.pca323100.p6f0e511c.m97a57645(pc7a8f162Var, bArr);
    }

    public static void RxPGVRCrmDRtcEaw(p5a445d71.p7c922baa.pca323100.pb0766587 pb0766587Var) {
        pb0766587Var.writeBEREnd();
    }

    public static void UMAmVkIOdqYJOXkM(p5a445d71.p7c922baa.pca323100.pc7a8f162 pc7a8f162Var, byte[] bArr) throws java.io.IOException {
        p5a445d71.p7c922baa.pca323100.p6f0e511c.m97a57645(pc7a8f162Var, bArr);
    }

    public static void VIKpEpyCNkNroZmT(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void VOXWxtTzREYvNBAN(p5a445d71.p7c922baa.pca323100.pc7a8f162 pc7a8f162Var, byte[] bArr) throws java.io.IOException {
        p5a445d71.p7c922baa.pca323100.p6f0e511c.m97a57645(pc7a8f162Var, bArr);
    }

    public static void LAWFQJaRRfAdLQQk(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static int OEgiRrPtyDNyXolU(int i, int i2) {
        return java.lang.Math.min(i, i2);
    }

    public override void Close() throws java.io.IOException {
        if ((17 + 29) % 29 > 0) {
        }
        int i = this.f9edc2e01;
        if (i != 0) {
            byte[] bArr = new byte[i];
            VIKpEpyCNkNroZmT(this.fe14b545e, 0, bArr, 0, i);
            VOXWxtTzREYvNBAN(this.f0b35ae6d, bArr);
        }
        RxPGVRCrmDRtcEaw(this.this$0);
    }

    public override void Write(int i) throws java.io.IOException {
        if ((19 + 8) % 8 > 0) {
        }
        byte[] bArr = this.fe14b545e;
        int i2 = this.f9edc2e01;
        int i3 = i2 + 1;
        this.f9edc2e01 = i3;
        bArr[i2] = (byte) i;
        if (i3 != bArr.length) {
            return;
        }
        UMAmVkIOdqYJOXkM(this.f0b35ae6d, bArr);
        this.f9edc2e01 = 0;
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((18 + 32) % 32 > 0) {
        }
        while (i2 > 0) {
            int iOEgiRrPtyDNyXolU = oEgiRrPtyDNyXolU(i2, this.fe14b545e.length - this.f9edc2e01);
            lAWFQJaRRfAdLQQk(bArr, i, this.fe14b545e, this.f9edc2e01, iOEgiRrPtyDNyXolU);
            int i3 = this.f9edc2e01 + iOEgiRrPtyDNyXolU;
            this.f9edc2e01 = i3;
            byte[] bArr2 = this.fe14b545e;
            if (i3 < bArr2.length) {
                return;
            }
            PjUVjoNTOqaiTBCt(this.f0b35ae6d, bArr2);
            this.f9edc2e01 = 0;
            i += iOEgiRrPtyDNyXolU;
            i2 -= iOEgiRrPtyDNyXolU;
        }
    }
}

