namespace WillowMaze.Wasm.Decompiled;


public class p29974401 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p3cdccfc9 f17ff6589;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f187262da;
    private p5a445d71.p7c922baa.pca323100.pff11dfb3 f21154393;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f2188587e;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p3cdccfc9 f5e7e2554;
    private p5a445d71.p7c922baa.pca323100.pff11dfb3 f684598c8;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f6fb19b03;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f76acfaa3;
    private p5a445d71.p7c922baa.pca323100.pff11dfb3 fb04ec0ad;
    private p5a445d71.p7c922baa.pca323100.pff11dfb3 fd477c3de;
    private p5a445d71.p7c922baa.pca323100.pff11dfb3 fd905e047;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fee7f3c53;
    private p5a445d71.p7c922baa.pca323100.pdacfecb5.p3cdccfc9 ff6e72887;

    private p29974401(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f6fb19b03 = p80f8c729Var;
        this.f5e7e2554 = XrHbQNQOiwOqXGLg(qseTbmxSkoCmwxfL(p80f8c729Var, 0));
        this.fb04ec0ad = SYEejxdZszaNkELI(oOshJTbULZuwHxoY(p80f8c729Var, 1));
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 EgCvOijRIdpDTqqv(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pff11dfb3 SYEejxdZszaNkELI(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pff11dfb3.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pdacfecb5.p3cdccfc9 XrHbQNQOiwOqXGLg(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pdbeb1c32.p29974401 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pdbeb1c32.p29974401) {
            return (p5a445d71.p7c922baa.pca323100.pdbeb1c32.p29974401) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pdbeb1c32.p29974401(EgCvOijRIdpDTqqv(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 OOshJTbULZuwHxoY(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 QseTbmxSkoCmwxfL(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p7c922baa.pca323100.pff11dfb3 GetChallenge() {
        return this.fb04ec0ad;
    }

    public p5a445d71.p7c922baa.pca323100.pdacfecb5.p3cdccfc9 GetSubjectPublicKeyInfo() {
        return this.f5e7e2554;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f6fb19b03;
    }
}

