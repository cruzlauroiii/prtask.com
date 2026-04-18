namespace WillowMaze.Wasm.Decompiled;


public class pfeaff37e : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f2063c160;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f3b10ae68;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f49b46b53;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f599dcce2;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f9eb487f2;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fe531afeb;

    public pfeaff37e(java.lang.string str, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this(new p5a445d71.p7c922baa.pca323100.p364bf33a(str), p0fd1bdf1Var);
    }

    public pfeaff37e(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f599dcce2 = p364bf33aVar;
        this.f2063c160 = p0fd1bdf1Var;
    }

    private pfeaff37e(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f599dcce2 = (p5a445d71.p7c922baa.pca323100.p364bf33a) yWbOQvsVPPyfieto(p80f8c729Var, 0);
        this.f2063c160 = iXBODBBKXZCiazhL(p80f8c729Var, 1);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 BMQYaUMylkYGTjla(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 IXBODBBKXZCiazhL(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfeaff37e M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfeaff37e) {
            return (p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfeaff37e) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pc1cfc81b.pfeaff37e(bMQYaUMylkYGTjla(obj));
    }

    public static void SlwONIFaWeXRrrfb(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void SvvYQbwHsSYTaory(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 YWbOQvsVPPyfieto(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetType() {
        return this.f599dcce2;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetValue() {
        return this.f2063c160;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((15 + 28) % 28 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        svvYQbwHsSYTaory(pd6ccb7fcVar, this.f599dcce2);
        slwONIFaWeXRrrfb(pd6ccb7fcVar, this.f2063c160);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

