namespace WillowMaze.Wasm.Decompiled;


public class pad1b94ef : p5a445d71.p9f931cf3.pca323100.p54252eff {
    p5a445d71.p9f931cf3.pca323100.p11b04310 f0079932e;
    p5a445d71.p9f931cf3.pca323100.p364bf33a f19593ed9;
    p5a445d71.p9f931cf3.pca323100.p364bf33a f518a5f1e;
    p5a445d71.p9f931cf3.pca323100.p11b04310 f6d7193ad;
    p5a445d71.p9f931cf3.pca323100.p364bf33a f748192ec;
    p5a445d71.p9f931cf3.pca323100.p11b04310 f82f8bfcd;
    p5a445d71.p9f931cf3.pca323100.p11b04310 f881e048d;
    p5a445d71.p9f931cf3.pca323100.p11b04310 fd1fc8eaf;

    public pad1b94ef(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310Var) {
        this.f19593ed9 = p364bf33aVar;
        this.fd1fc8eaf = p11b04310Var;
    }

    private pad1b94ef(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.f19593ed9 = (p5a445d71.p9f931cf3.pca323100.p364bf33a) qelwTClwyixPZtoC(p80f8c729Var, 0);
        this.fd1fc8eaf = (p5a445d71.p9f931cf3.pca323100.p11b04310) YveKGRhZCulGmgfY(p80f8c729Var, 1);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 PBGvlkRxdvmchZYf(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 YveKGRhZCulGmgfY(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p785c9c91.pad1b94ef M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p785c9c91.pad1b94ef) {
            return (p5a445d71.p9f931cf3.pca323100.p785c9c91.pad1b94ef) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p785c9c91.pad1b94ef(PBGvlkRxdvmchZYf(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p785c9c91.pad1b94ef M8bab0102(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return ySEbPfFZcFqYqfRw(pnrYFXUQVzNBMDAC(p582a4948Var, z));
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 PnrYFXUQVzNBMDAC(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 QelwTClwyixPZtoC(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void TYgRshBGACmJuzsg(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void ToTdBRqKvNVkNymG(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p785c9c91.pad1b94ef YSEbPfFZcFqYqfRw(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public p5a445d71.p9f931cf3.pca323100.p11b04310 GetResponse() {
        return this.fd1fc8eaf;
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetResponseType() {
        return this.f19593ed9;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((2 + 20) % 20 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        tYgRshBGACmJuzsg(pd6ccb7fcVar, this.f19593ed9);
        toTdBRqKvNVkNymG(pd6ccb7fcVar, this.fd1fc8eaf);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

