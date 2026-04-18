namespace WillowMaze.Wasm.Decompiled;


public class p30b64ddd : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 f3487effd;
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 f5e5f797c;
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 f6fb19b03;
    private readonly p5a445d71.p7c922baa.pca323100.pdbeb1c32.p29974401 fad24be5c;
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 fb5f26c5d;
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 fce4c8233;
    private readonly p5a445d71.p7c922baa.pca323100.pdbeb1c32.p29974401 fd7c819c7;

    private p30b64ddd(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f6fb19b03 = p80f8c729Var;
        this.fd7c819c7 = YpKFADwkSFfRgUfh(UTuLTAKTxZTJWhZh(p80f8c729Var, 0));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 SrBLZwOZRsIxiiIk(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 UTuLTAKTxZTJWhZh(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 WXOhqOhzHqWJJHaB(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pdbeb1c32.p29974401 YpKFADwkSFfRgUfh(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdbeb1c32.p29974401.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 BxnRzBPIYbJYJyqN(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 JmUAmMyccGSuePoJ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p1522cc54 KYCduXymWxKQYFYw(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p1522cc54.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pdbeb1c32.p30b64ddd M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pdbeb1c32.p30b64ddd) {
            return (p5a445d71.p7c922baa.pca323100.pdbeb1c32.p30b64ddd) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pdbeb1c32.p30b64ddd(bxnRzBPIYbJYJyqN(obj));
    }

    public p5a445d71.p7c922baa.pca323100.pdbeb1c32.p29974401 GetPublicKeyAndChallenge() {
        return this.fd7c819c7;
    }

    public p5a445d71.p7c922baa.pca323100.p1522cc54 GetSignature() {
        return kYCduXymWxKQYFYw(jmUAmMyccGSuePoJ(this.f6fb19b03, 2));
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetSignatureAlgorithm() {
        return WXOhqOhzHqWJJHaB(SrBLZwOZRsIxiiIk(this.f6fb19b03, 1));
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f6fb19b03;
    }
}

