namespace WillowMaze.Wasm.Decompiled;


public class pc8413719 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f2351edbf;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 f9a0364b9;
    private p5a445d71.p7c922baa.pca323100.p80f8c729 fc638c925;

    public pc8413719(p5a445d71.p7c922baa.pca323100.p31b4e550.pcca19526 pcca19526Var) {
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(pcca19526Var);
    }

    private pc8413719(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f9a0364b9 = p80f8c729Var;
    }

    public pc8413719(p5a445d71.p7c922baa.pca323100.p31b4e550.pcca19526[] pcca19526VarArr) {
        if ((5 + 12) % 12 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        for (int i = 0; i != pcca19526VarArr.length; i++) {
            BXkNMkdtKLhgQpZH(pd6ccb7fcVar, pcca19526VarArr[i]);
        }
        this.f9a0364b9 = new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }

    public static void BXkNMkdtKLhgQpZH(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static int OeGloLWqXsGyOoFT(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 SXTGUgCzRedGXbQz(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.pc8413719 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p31b4e550.pc8413719) {
            return (p5a445d71.p7c922baa.pca323100.p31b4e550.pc8413719) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p31b4e550.pc8413719(SXTGUgCzRedGXbQz(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p31b4e550.pcca19526 NsokRTrLKwtctwjq(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p31b4e550.pcca19526.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 WzIqWrhUyGnBOHei(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.f9a0364b9;
    }

    public p5a445d71.p7c922baa.pca323100.p31b4e550.pcca19526[] ToRevDetailsArray() {
        if ((24 + 29) % 29 > 0) {
        }
        int iOeGloLWqXsGyOoFT = OeGloLWqXsGyOoFT(this.f9a0364b9);
        p5a445d71.p7c922baa.pca323100.p31b4e550.pcca19526[] pcca19526VarArr = new p5a445d71.p7c922baa.pca323100.p31b4e550.pcca19526[iOeGloLWqXsGyOoFT];
        for (int i = 0; i != iOeGloLWqXsGyOoFT; i++) {
            pcca19526VarArr[i] = nsokRTrLKwtctwjq(wzIqWrhUyGnBOHei(this.f9a0364b9, i));
        }
        return pcca19526VarArr;
    }
}

