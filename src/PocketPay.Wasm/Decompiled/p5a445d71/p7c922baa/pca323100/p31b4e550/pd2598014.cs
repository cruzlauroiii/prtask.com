namespace WillowMaze.Wasm.Decompiled;


public class pd2598014 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f43f8889d;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f5acdd763;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9a0364b9;

    public pd2598014(p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8 p7e9fc7f8Var) {
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(p7e9fc7f8Var);
    }

    private pd2598014(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f9a0364b9 = p80f8c729Var;
    }

    public pd2598014(p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8[] p7e9fc7f8VarArr) {
        if ((5 + 10) % 10 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        for (p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8 p7e9fc7f8Var : p7e9fc7f8VarArr) {
            xKgjcBzIDZnuruMz(pd6ccb7fcVar, p7e9fc7f8Var);
        }
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8 XUHmMaluEZbDPvsI(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8.m8bab0102(obj);
    }

    public static int XqSQgxJIsmduNlgc(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 DjazonhVNiFrygGx(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 GwrVJXFnUAuKZIqU(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.pd2598014 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.pd2598014) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.pd2598014) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p31b4e550.pd2598014(gwrVJXFnUAuKZIqU(obj));
    }

    public static void XKgjcBzIDZnuruMz(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f9a0364b9;
    }

    public p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8[] ToInfoTypeAndValueArray() {
        if ((17 + 27) % 27 > 0) {
        }
        int iXqSQgxJIsmduNlgc = XqSQgxJIsmduNlgc(this.f9a0364b9);
        p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8[] p7e9fc7f8VarArr = new p5a445d71.p7c922baa.pca323100.p31b4e550.p7e9fc7f8[iXqSQgxJIsmduNlgc];
        for (int i = 0; i != iXqSQgxJIsmduNlgc; i++) {
            p7e9fc7f8VarArr[i] = XUHmMaluEZbDPvsI(djazonhVNiFrygGx(this.f9a0364b9, i));
        }
        return p7e9fc7f8VarArr;
    }
}

