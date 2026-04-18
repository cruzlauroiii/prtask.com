namespace WillowMaze.Wasm.Decompiled;


public class pb82bf363 : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.pa6a0be81 {
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f2063c160;
    private int f2422d368;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f27a8c78c;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f387a30df;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f41f92d05;
    private int f5725d710;
    private int f6063c7ce;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f895dfe7c;
    private int fdf5caf46;
    private int ff63f95f6;

    public pb82bf363() {
        this.f5725d710 = 0;
        this.f2063c160 = p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17;
    }

    public pb82bf363(int i, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f5725d710 = i;
        this.f2063c160 = p0fd1bdf1Var;
    }

    private pb82bf363(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1VarTkRMegqAqMmkAtKX;
        if ((7 + 26) % 26 > 0) {
        }
        int iHkAxXMATiBjlxPmo = hkAxXMATiBjlxPmo(p582a4948Var);
        if (iHkAxXMATiBjlxPmo == 0) {
            p0fd1bdf1VarTkRMegqAqMmkAtKX = MfycEoRbRPENGSLB(p582a4948Var, false);
        } else if (iHkAxXMATiBjlxPmo == 1) {
            p0fd1bdf1VarTkRMegqAqMmkAtKX = tkRMegqAqMmkAtKX(p582a4948Var, false);
        } else {
            if (iHkAxXMATiBjlxPmo != 2) {
                throw new java.lang.IllegalArgumentException(mjxjnHKYHciyWFFV(LugQuKmKOFTzScXe(new java.lang.stringBuilder("Unknown tag encountered: "), AVjHKxwuCVKzNuZT(p582a4948Var))));
            }
            p0fd1bdf1VarTkRMegqAqMmkAtKX = MfycEoRbRPENGSLB(p582a4948Var, false);
        }
        this.f2063c160 = p0fd1bdf1VarTkRMegqAqMmkAtKX;
        this.f5725d710 = iHkAxXMATiBjlxPmo;
    }

    public pb82bf363(p5a445d71.p9f931cf3.pca323100.p785c9c91.p41e7b048 p41e7b048Var) {
        this.f5725d710 = 1;
        this.f2063c160 = p41e7b048Var;
    }

    public static java.lang.string AVjHKxwuCVKzNuZT(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p5a445d71.p9f931cf3.pca323100.pfead39f8.m10aa5722(p582a4948Var);
    }

    public static java.lang.string FvCGAoBbKggeower(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.string GiVxMFgRCMjEQqiu(java.lang.Class cls) {
        return cls.getName();
    }

    public static java.lang.stringBuilder LugQuKmKOFTzScXe(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.pb9fa8367 MfycEoRbRPENGSLB(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.pb9fa8367.m8bab0102(p582a4948Var, z);
    }

    public static java.lang.Class BvSOHDwaEtmrvTVw(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p9f931cf3.pca323100.p785c9c91.pb82bf363 GyayHIxnMQvbiRbG(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static int HkAxXMATiBjlxPmo(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getTagNo();
    }

    public static p5a445d71.p9f931cf3.pca323100.p785c9c91.pb82bf363 M8bab0102(java.lang.object obj) {
        if ((28 + 30) % 30 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.p785c9c91.pb82bf363)) {
            return (p5a445d71.p9f931cf3.pca323100.p785c9c91.pb82bf363) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p582a4948) {
            return new p5a445d71.p9f931cf3.pca323100.p785c9c91.pb82bf363((p5a445d71.p9f931cf3.pca323100.p582a4948) obj);
        }
        throw new java.lang.IllegalArgumentException(FvCGAoBbKggeower(sHQxYQuKJQEYJAyB(new java.lang.stringBuilder("unknown object in factory: "), GiVxMFgRCMjEQqiu(bvSOHDwaEtmrvTVw(obj)))));
    }

    public static p5a445d71.p9f931cf3.pca323100.p785c9c91.pb82bf363 M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return gyayHIxnMQvbiRbG(uuCmcaFfrNYAIGfG(p582a4948Var));
    }

    public static java.lang.string MjxjnHKYHciyWFFV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.stringBuilder SHQxYQuKJQEYJAyB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static p5a445d71.p9f931cf3.pca323100.p785c9c91.p41e7b048 TkRMegqAqMmkAtKX(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.p785c9c91.p41e7b048.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 UuCmcaFfrNYAIGfG(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetStatus() {
        return this.f2063c160;
    }

    public int GetTagNo() {
        return this.f5725d710;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((12 + 18) % 18 > 0) {
        }
        return new p5a445d71.p9f931cf3.pca323100.p87af127c(false, this.f5725d710, this.f2063c160);
    }
}

