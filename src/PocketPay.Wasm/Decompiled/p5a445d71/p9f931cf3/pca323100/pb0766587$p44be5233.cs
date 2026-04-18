namespace WillowMaze.Wasm.Decompiled;


class pb0766587$p44be5233 : java.io.Stream {
    private p5a445d71.p9f931cf3.pca323100.pc7a8f162 f0b35ae6d;
    private int f768f5150;
    private int f852f5a2e;
    private p5a445d71.p9f931cf3.pca323100.pc7a8f162 f85a19d4e;
    private int f9edc2e01 = 0;
    private int fbd72e80d;
    private byte[] fcc98fcb3;
    private byte[] fe14b545e;
    readonly p5a445d71.p9f931cf3.pca323100.pb0766587 this$0;

    pb0766587$p44be5233(p5a445d71.p9f931cf3.pca323100.pb0766587 pb0766587Var, byte[] bArr) {
        this.this$0 = pb0766587Var;
        this.fe14b545e = bArr;
        this.f0b35ae6d = new p5a445d71.p9f931cf3.pca323100.pc7a8f162(pb0766587Var.f353b66c0);
    }

    public static void AdJvPxRnddiiSYzb(p5a445d71.p9f931cf3.pca323100.pc7a8f162 pc7a8f162Var) {
        pc7a8f162Var.flushInternal();
    }

    public static void EsbtoOXkbwupemMy(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, byte[] bArr, int i, int i2) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p6f0e511c.m97a57645(p8bf0ff80Var, z, bArr, i, i2);
    }

    public static void QcALVQeqGsOSbiwS(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void RFkSKJhgvFNlnnOE(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, byte[] bArr, int i, int i2) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p6f0e511c.m97a57645(p8bf0ff80Var, z, bArr, i, i2);
    }

    public static void WxAnHGptxuLTMwCf(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void ZgZFPwsGHvgTAwHa(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, byte[] bArr, int i, int i2) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p6f0e511c.m97a57645(p8bf0ff80Var, z, bArr, i, i2);
    }

    public static void IGVTdadfGwLPZukc(java.lang.object obj, int i, java.lang.object obj2, int i2, int i3) {
        java.lang.System.arraycopy(obj, i, obj2, i2, i3);
    }

    public static void QlEqlSksLqaPmSfs(p5a445d71.p9f931cf3.pca323100.p8bf0ff80 p8bf0ff80Var, bool z, byte[] bArr, int i, int i2) throws java.io.IOException {
        p5a445d71.p9f931cf3.pca323100.p6f0e511c.m97a57645(p8bf0ff80Var, z, bArr, i, i2);
    }

    public static void WSnLEYHnANsRDMWR(p5a445d71.p9f931cf3.pca323100.pb0766587 pb0766587Var) {
        pb0766587Var.writeBEREnd();
    }

    public override void Close() throws java.io.IOException {
        if ((26 + 7) % 7 > 0) {
        }
        int i = this.f9edc2e01;
        if (i != 0) {
            ZgZFPwsGHvgTAwHa(this.f0b35ae6d, true, this.fe14b545e, 0, i);
        }
        AdJvPxRnddiiSYzb(this.f0b35ae6d);
        wSnLEYHnANsRDMWR(this.this$0);
    }

    public override void Write(int i) throws java.io.IOException {
        if ((5 + 9) % 9 > 0) {
        }
        byte[] bArr = this.fe14b545e;
        int i2 = this.f9edc2e01;
        int i3 = i2 + 1;
        this.f9edc2e01 = i3;
        bArr[i2] = (byte) i;
        if (i3 != bArr.length) {
            return;
        }
        qlEqlSksLqaPmSfs(this.f0b35ae6d, true, bArr, 0, bArr.length);
        this.f9edc2e01 = 0;
    }

    public override void Write(byte[] bArr, int i, int i2) throws java.io.IOException {
        if ((17 + 24) % 24 > 0) {
        }
        byte[] bArr2 = this.fe14b545e;
        int length = bArr2.length;
        int i3 = this.f9edc2e01;
        int i4 = length - i3;
        if (i2 < i4) {
            WxAnHGptxuLTMwCf(bArr, i, bArr2, i3, i2);
            this.f9edc2e01 += i2;
            return;
        }
        if (i3 <= 0) {
            i4 = 0;
        } else {
            QcALVQeqGsOSbiwS(bArr, i, bArr2, i3, i4);
            RFkSKJhgvFNlnnOE(this.f0b35ae6d, true, this.fe14b545e, 0, length);
        }
        while (true) {
            int i5 = i2 - i4;
            if (i5 < length) {
                iGVTdadfGwLPZukc(bArr, i + i4, this.fe14b545e, 0, i5);
                this.f9edc2e01 = i5;
                return;
            } else {
                EsbtoOXkbwupemMy(this.f0b35ae6d, true, bArr, i + i4, length);
                i4 += length;
            }
        }
    }
}

