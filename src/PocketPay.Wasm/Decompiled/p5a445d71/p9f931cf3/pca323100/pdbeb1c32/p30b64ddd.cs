namespace WillowMaze.Wasm.Decompiled;


public class p30b64ddd : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private readonly p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p29974401 f236a9c63;
    private readonly p5a445d71.p9f931cf3.pca323100.p80f8c729 f3aac19e0;
    private readonly p5a445d71.p9f931cf3.pca323100.p80f8c729 f6fb19b03;
    private readonly p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p29974401 fbafb6e07;
    private readonly p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p29974401 fd7c819c7;

    private p30b64ddd(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.f6fb19b03 = p80f8c729Var;
        this.fd7c819c7 = znGXkzhEQGGTxDJB(mJevSEbmvigleIDH(p80f8c729Var, 0));
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 KaKWjhGtCZTVdQFd(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p29d19857 UzonumeGWvGGxzup(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p29d19857.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 AZrVBaUfmnwUHHwI(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 CFyBoDUdUfhcvtIJ(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p30b64ddd M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p30b64ddd) {
            return (p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p30b64ddd) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p30b64ddd(KaKWjhGtCZTVdQFd(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 MJevSEbmvigleIDH(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 NGRCjaXdAElDsDPI(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p29974401 ZnGXkzhEQGGTxDJB(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p29974401.m8bab0102(obj);
    }

    public p5a445d71.p9f931cf3.pca323100.pdbeb1c32.p29974401 GetPublicKeyAndChallenge() {
        return this.fd7c819c7;
    }

    public p5a445d71.p9f931cf3.pca323100.p29d19857 GetSignature() {
        return UzonumeGWvGGxzup(nGRCjaXdAElDsDPI(this.f6fb19b03, 2));
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetSignatureAlgorithm() {
        return cFyBoDUdUfhcvtIJ(aZrVBaUfmnwUHHwI(this.f6fb19b03, 1));
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f6fb19b03;
    }
}

