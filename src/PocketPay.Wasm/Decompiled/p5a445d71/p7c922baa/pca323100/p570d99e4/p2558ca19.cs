namespace WillowMaze.Wasm.Decompiled;


public class p2558ca19 {
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f03153b66;
    private p5a445d71.p7c922baa.pca323100.pa5dc5f26 f3045ec52;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f3ea7b009;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f4a9cb9e0;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f5ca70fc6;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 f69c864bf;
    private p5a445d71.p7c922baa.pca323100.pa5dc5f26 f828615db;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f8d2230de;

    public p2558ca19(p5a445d71.p7c922baa.pca323100.p94dfe8e0 p94dfe8e0Var) throws java.io.IOException {
        this.f3ea7b009 = (p5a445d71.p7c922baa.pca323100.p364bf33a) CqRyPgZMKSupLnRr(p94dfe8e0Var);
        this.f03153b66 = YbtziKQZFgWxTnEY(YjttQLMOcIGlEtxP(XPTePNRTFiKqxcoD(p94dfe8e0Var)));
        this.f828615db = (p5a445d71.p7c922baa.pca323100.pa5dc5f26) pwlBhyZvbzAGFUCe(p94dfe8e0Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 ChYMztxGsejxjbaw(p5a445d71.p7c922baa.pca323100.pa5dc5f26 pa5dc5f26Var, int i, bool z) {
        return pa5dc5f26Var.getobjectParser(i, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 CqRyPgZMKSupLnRr(p5a445d71.p7c922baa.pca323100.p94dfe8e0 p94dfe8e0Var) {
        return p94dfe8e0Var.readobject();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 XPTePNRTFiKqxcoD(p5a445d71.p7c922baa.pca323100.p94dfe8e0 p94dfe8e0Var) {
        return p94dfe8e0Var.readobject();
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 YbtziKQZFgWxTnEY(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 YjttQLMOcIGlEtxP(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 PwlBhyZvbzAGFUCe(p5a445d71.p7c922baa.pca323100.p94dfe8e0 p94dfe8e0Var) {
        return p94dfe8e0Var.readobject();
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p234a7530 GetContentEncryptionAlgorithm() {
        return this.f03153b66;
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetContentType() {
        return this.f3ea7b009;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetEncryptedContent(int i) throws java.io.IOException {
        return ChYMztxGsejxjbaw(this.f828615db, i, false);
    }
}

