namespace WillowMaze.Wasm.Decompiled;


public class p59bfb04e : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f5d01acf5;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f7f994eef;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9a0364b9;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fdbc67a0a;

    public p59bfb04e(p5a445d71.p7c922baa.pca323100.p31b4e550.p80ef27d0 p80ef27d0Var) {
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(p80ef27d0Var);
    }

    private p59bfb04e(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f9a0364b9 = p80f8c729Var;
    }

    public p59bfb04e(p5a445d71.p7c922baa.pca323100.p31b4e550.p80ef27d0[] p80ef27d0VarArr) {
        if ((16 + 19) % 19 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        for (p5a445d71.p7c922baa.pca323100.p31b4e550.p80ef27d0 p80ef27d0Var : p80ef27d0VarArr) {
            JvvDgLEZrvrupESe(pd6ccb7fcVar, p80ef27d0Var);
        }
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 ItXezdMjtKZhTJoD(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void JvvDgLEZrvrupESe(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p80ef27d0 JzNgEtxuWYCIDspL(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p31b4e550.p80ef27d0.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 SXobsBuKeizHerjK(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.p59bfb04e M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.p59bfb04e) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.p59bfb04e) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p31b4e550.p59bfb04e(ItXezdMjtKZhTJoD(obj));
    }

    public static int PdnDHKxfJwNyGbAv(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f9a0364b9;
    }

    public p5a445d71.p7c922baa.pca323100.p31b4e550.p80ef27d0[] ToPKIMessageArray() {
        if ((16 + 26) % 26 > 0) {
        }
        int iPdnDHKxfJwNyGbAv = pdnDHKxfJwNyGbAv(this.f9a0364b9);
        p5a445d71.p7c922baa.pca323100.p31b4e550.p80ef27d0[] p80ef27d0VarArr = new p5a445d71.p7c922baa.pca323100.p31b4e550.p80ef27d0[iPdnDHKxfJwNyGbAv];
        for (int i = 0; i != iPdnDHKxfJwNyGbAv; i++) {
            p80ef27d0VarArr[i] = JzNgEtxuWYCIDspL(SXobsBuKeizHerjK(this.f9a0364b9, i));
        }
        return p80ef27d0VarArr;
    }
}

