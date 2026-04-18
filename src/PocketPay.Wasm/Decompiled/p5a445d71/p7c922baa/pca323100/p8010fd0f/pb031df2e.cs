namespace WillowMaze.Wasm.Decompiled;


public class pb031df2e : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 f159be057;
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 f2cafb55a;
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 f3dc9626f;
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 f8af1d0ee;
    private readonly p5a445d71.p7c922baa.pca323100.p80f8c729 fd3bf977d;

    public pb031df2e(p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43 p14febf43Var) {
        this.fd3bf977d = new p5a445d71.p7c922baa.pca323100.pb840b7ef(p14febf43Var);
    }

    private pb031df2e(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((2 + 3) % 3 > 0) {
        }
        if (IWHMGJGadhZQVIri(p80f8c729Var) != 1) {
            throw new java.lang.IllegalArgumentException("incorrect sequence size");
        }
        this.fd3bf977d = NCdlFKKYtBmOJHZP(hczgWaSZGIMegyzu(p80f8c729Var, 0));
    }

    public pb031df2e(p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43[] p14febf43VarArr) {
        this.fd3bf977d = new p5a445d71.p7c922baa.pca323100.pb840b7ef(p14febf43VarArr);
    }

    public static int DQVGfMcRTzrEfaKI(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static int IWHMGJGadhZQVIri(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 MtqaPdbgOUuUyUEV(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 NCdlFKKYtBmOJHZP(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 CaLMtiOjpDldZUlX(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43 DQlJPKOmhoVTUclj(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 HczgWaSZGIMegyzu(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.pb031df2e M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p8010fd0f.pb031df2e) {
            return (p5a445d71.p7c922baa.pca323100.p8010fd0f.pb031df2e) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p8010fd0f.pb031df2e(caLMtiOjpDldZUlX(obj));
    }

    public static int YYILYbEimzXcKFvf(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43[] GetBodyList() {
        if ((17 + 12) % 12 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43[] p14febf43VarArr = new p5a445d71.p7c922baa.pca323100.p8010fd0f.p14febf43[DQVGfMcRTzrEfaKI(this.fd3bf977d)];
        for (int i = 0; i != yYILYbEimzXcKFvf(this.fd3bf977d); i++) {
            p14febf43VarArr[i] = dQlJPKOmhoVTUclj(MtqaPdbgOUuUyUEV(this.fd3bf977d, i));
        }
        return p14febf43VarArr;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(this.fd3bf977d);
    }
}

