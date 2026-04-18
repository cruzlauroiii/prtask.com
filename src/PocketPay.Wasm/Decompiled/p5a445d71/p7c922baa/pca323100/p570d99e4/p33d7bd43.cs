namespace WillowMaze.Wasm.Decompiled;


public class p33d7bd43 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f230874b9;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f3b923db9;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f66a4eb62;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f6710a63e;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f82a40064;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fce0d4ec2;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fedf66bf7;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fff0a3c61;

    public p33d7bd43(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.fff0a3c61 = p364bf33aVar;
        this.f82a40064 = p0fd1bdf1Var;
    }

    private p33d7bd43(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.fff0a3c61 = ARrTBOeLuqQFehAT(PfqsPRmpUsideqwC(p80f8c729Var, 0));
        this.f82a40064 = EOshPycOXjJNtRDG(p80f8c729Var, 1);
    }

    public static p5a445d71.p7c922baa.pca323100.p364bf33a ARrTBOeLuqQFehAT(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 EOshPycOXjJNtRDG(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 PfqsPRmpUsideqwC(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void JQmUsBRTDCTKTTOA(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void JSkucqArPYLfEGqZ(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 KJpJFdsJOHirMQoF(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p33d7bd43 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p570d99e4.p33d7bd43) {
            return (p5a445d71.p7c922baa.pca323100.p570d99e4.p33d7bd43) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p570d99e4.p33d7bd43(kJpJFdsJOHirMQoF(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p33d7bd43 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return wDnHOQVbahDIVDXf(vEItyWZiDfFUQbkv(p582a4948Var, z));
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 VEItyWZiDfFUQbkv(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p33d7bd43 WDnHOQVbahDIVDXf(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetInfo() {
        return this.f82a40064;
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetInfoFormat() {
        return this.fff0a3c61;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((19 + 11) % 11 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        jSkucqArPYLfEGqZ(pd6ccb7fcVar, this.fff0a3c61);
        jQmUsBRTDCTKTTOA(pd6ccb7fcVar, this.f82a40064);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

