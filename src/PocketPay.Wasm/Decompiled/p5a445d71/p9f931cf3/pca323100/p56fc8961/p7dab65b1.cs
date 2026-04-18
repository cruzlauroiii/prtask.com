namespace WillowMaze.Wasm.Decompiled;


public class p7dab65b1 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f1634d4a7;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f40d8e39d;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f5bc79f52;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f5e68b266;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f820c4979;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ff98bf1ba;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a ffc9d59bc;

    public p7dab65b1(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f5bc79f52 = p364bf33aVar;
        this.f5e68b266 = p0fd1bdf1Var;
    }

    private p7dab65b1(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.f5bc79f52 = UXWzZKGfKhFBXfLe(xIaARXIHAGuHuqHZ(p80f8c729Var, 0));
        this.f5e68b266 = ekWnGTynxOXOmSLB(zGCQZsfpPUeecPul(tFKezUQMDCPphAAo(p80f8c729Var, 1)));
    }

    public static void HleyIXQXYkuTjpBD(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p364bf33a UXWzZKGfKhFBXfLe(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static void XJFkuCnSgxEPrhFR(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 EkWnGTynxOXOmSLB(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p7dab65b1 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p56fc8961.p7dab65b1) {
            return (p5a445d71.p9f931cf3.pca323100.p56fc8961.p7dab65b1) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p7dab65b1(zTaqNkPgITQDidkv(obj));
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 TFKezUQMDCPphAAo(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 XIaARXIHAGuHuqHZ(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p582a4948 ZGCQZsfpPUeecPul(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p582a4948.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 ZTaqNkPgITQDidkv(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetCertId() {
        return this.f5bc79f52;
    }

    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetCertValue() {
        return this.f5e68b266;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((8 + 21) % 21 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        XJFkuCnSgxEPrhFR(pd6ccb7fcVar, this.f5bc79f52);
        HleyIXQXYkuTjpBD(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.p87af127c(0, this.f5e68b266));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

