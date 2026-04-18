namespace WillowMaze.Wasm.Decompiled;


public class p32555e78 : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.p56fc8961.p03c3d84c {
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f2c439527;
    private bool f2ed3e9a9;
    private bool f415c5d36;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f5db075bb;
    private bool f80925ac2;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f99ef537e;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f9a0364b9;
    private bool fae5be8e2;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fb41d3ae9;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fdf5feafa;
    private p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fe4c62159;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a ffb34b8db;

    public p32555e78(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f80925ac2 = true;
        this.fdf5feafa = p364bf33aVar;
        this.f9a0364b9 = p0fd1bdf1Var;
    }

    private p32555e78(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((30 + 3) % 3 > 0) {
        }
        this.f80925ac2 = true;
        java.util.Enumeration enumerationNWJOUukKPcpdQOuz = nWJOUukKPcpdQOuz(p80f8c729Var);
        this.fdf5feafa = (p5a445d71.p9f931cf3.pca323100.p364bf33a) jhVVhRJkARQfJXQC(enumerationNWJOUukKPcpdQOuz);
        if (qBjffTybwPoOADoP(enumerationNWJOUukKPcpdQOuz)) {
            this.f9a0364b9 = yEzvDOipHCuwkZSL((p5a445d71.p9f931cf3.pca323100.p582a4948) hzOCAmNtNeZGzdAc(enumerationNWJOUukKPcpdQOuz));
        }
        this.f80925ac2 = p80f8c729Var is p5a445d71.p9f931cf3.pca323100.p6a819fa7;
    }

    public static p5a445d71.p9f931cf3.pca323100.p80f8c729 GwChtAUuHgPodddW(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.lang.object HzOCAmNtNeZGzdAc(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static java.lang.object JhVVhRJkARQfJXQC(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78) {
            return (p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pca323100.p56fc8961.p32555e78(GwChtAUuHgPodddW(obj));
    }

    public static void NJkHHcknvUnZCHch(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.util.Enumeration NWJOUukKPcpdQOuz(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static bool QBjffTybwPoOADoP(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static void SLATJBdjHOQNcNAl(p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 YEzvDOipHCuwkZSL(p5a445d71.p9f931cf3.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetContent() {
        return this.f9a0364b9;
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetContentType() {
        return this.fdf5feafa;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((21 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc(2);
        nJkHHcknvUnZCHch(pd6ccb7fcVar, this.fdf5feafa);
        if (this.f9a0364b9 is not null) {
            sLATJBdjHOQNcNAl(pd6ccb7fcVar, new p5a445d71.p9f931cf3.pca323100.pd0fc91bc(true, 0, this.f9a0364b9));
        }
        return !this.f80925ac2 ? new p5a445d71.p9f931cf3.pca323100.p85c20c01(pd6ccb7fcVar) : new p5a445d71.p9f931cf3.pca323100.p6a819fa7(pd6ccb7fcVar);
    }
}

