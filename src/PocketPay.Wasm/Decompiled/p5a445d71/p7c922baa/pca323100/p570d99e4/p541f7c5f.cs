namespace WillowMaze.Wasm.Decompiled;


public class p541f7c5f : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p11b04310 f62db5569;
    private p5a445d71.p7c922baa.pca323100.p11b04310 f79add8dc;
    private p5a445d71.p7c922baa.pca323100.p570d99e4.pdc07e7dd f9dbb2948;
    private p5a445d71.p7c922baa.pca323100.p11b04310 fd13ade2b;
    private p5a445d71.p7c922baa.pca323100.p11b04310 fef3e7fc8;
    private p5a445d71.p7c922baa.pca323100.p570d99e4.pdc07e7dd ff393f3f5;

    public p541f7c5f(p5a445d71.p7c922baa.pca323100.p570d99e4.pdc07e7dd pdc07e7ddVar, p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        this.ff393f3f5 = pdc07e7ddVar;
        this.f79add8dc = p11b04310Var;
    }

    private p541f7c5f(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.ff393f3f5 = EGIVLuHOxCyJbate(bBfvIpPoPAxeWTZS(p80f8c729Var, 0));
        this.f79add8dc = (p5a445d71.p7c922baa.pca323100.p11b04310) xXEjTxDZDdsBfEEW(p80f8c729Var, 1);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 AxWYEfNugYWipMlX(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.pdc07e7dd EGIVLuHOxCyJbate(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p570d99e4.pdc07e7dd.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 HAcShgKarUdlqwso(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 BBfvIpPoPAxeWTZS(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p541f7c5f M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.p541f7c5f) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.p541f7c5f) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.p541f7c5f(HAcShgKarUdlqwso(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p541f7c5f M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return srtErYTRUcbvlDeH(AxWYEfNugYWipMlX(p582a4948Var, z));
    }

    public static void NeVEODshCQCfnqpG(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void STKrwDzmnAznlIub(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p541f7c5f SrtErYTRUcbvlDeH(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 XXEjTxDZDdsBfEEW(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p7c922baa.pca323100.p11b04310 GetEncryptedKey() {
        return this.f79add8dc;
    }

    public p5a445d71.p7c922baa.pca323100.p570d99e4.pdc07e7dd GetIdentifier() {
        return this.ff393f3f5;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((5 + 22) % 22 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        neVEODshCQCfnqpG(pd6ccb7fcVar, this.ff393f3f5);
        sTKrwDzmnAznlIub(pd6ccb7fcVar, this.f79add8dc);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

