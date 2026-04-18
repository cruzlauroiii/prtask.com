namespace WillowMaze.Wasm.Decompiled;


public class p524c9481 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f05093e53;
    private readonly p5a445d71.p7c922baa.pca323100.p11b04310 f19607a5c;
    private readonly p5a445d71.p7c922baa.pca323100.p11b04310 f6053b724;
    private readonly p5a445d71.p7c922baa.pca323100.p11b04310 f6a9350ff;
    private readonly p5a445d71.p7c922baa.pca323100.p11b04310 fb59fe78e;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fe1896788;
    private readonly p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 fe6243f10;

    private p524c9481(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.fe1896788 = XHLzhScHzVslMnlv(OJfUEUqtDEIHvcwo(p80f8c729Var, 0));
        this.fb59fe78e = hzDgaDwpWDKbNHWD(yeCopyOoLGEQgvqA(p80f8c729Var, 1));
    }

    public p524c9481(p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 p234a7530Var, byte[] bArr) {
        this.fe1896788 = p234a7530Var;
        this.fb59fe78e = new p5a445d71.p7c922baa.pca323100.p6f0e511c(bArr);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 OJfUEUqtDEIHvcwo(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 XHLzhScHzVslMnlv(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static void ZEqJgHiIzHlcvNWv(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310 HzDgaDwpWDKbNHWD(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p11b04310.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p5360af35.p524c9481 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p5360af35.p524c9481) {
            return (p5a445d71.p7c922baa.pca323100.p5360af35.p524c9481) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p5360af35.p524c9481(vgNsevIvrJHoShSu(obj));
    }

    public static void SlybHlTnNhgEuejd(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 VgNsevIvrJHoShSu(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 YeCopyOoLGEQgvqA(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p7c922baa.pca323100.p11b04310 GetEncryptedContent() {
        return this.fb59fe78e;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetEncryptionAlgorithm() {
        return this.fe1896788;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((25 + 13) % 13 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        ZEqJgHiIzHlcvNWv(pd6ccb7fcVar, this.fe1896788);
        slybHlTnNhgEuejd(pd6ccb7fcVar, this.fb59fe78e);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

