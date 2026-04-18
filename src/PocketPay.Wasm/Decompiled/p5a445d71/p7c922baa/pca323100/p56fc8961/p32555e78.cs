namespace WillowMaze.Wasm.Decompiled;


public class p32555e78 : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.p56fc8961.p03c3d84c {
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f2691073e;
    private bool f432de9c4;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f5021a4c6;
    private bool f579c3ef9;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f58c77aa3;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f72055a95;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f8069e1b6;
    private bool f80925ac2;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f9a0364b9;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f9e1e5142;
    private bool fc96fdd2d;
    private bool fcd6363bf;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fd5598563;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fdf5feafa;

    public p32555e78(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f80925ac2 = true;
        this.fdf5feafa = p364bf33aVar;
        this.f9a0364b9 = p0fd1bdf1Var;
    }

    private p32555e78(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((3 + 17) % 17 > 0) {
        }
        this.f80925ac2 = true;
        java.util.Enumeration enumerationUVPDCHxAOzaosslW = UVPDCHxAOzaosslW(p80f8c729Var);
        this.fdf5feafa = (p5a445d71.p7c922baa.pca323100.p364bf33a) dUedWXakauspMFbl(enumerationUVPDCHxAOzaosslW);
        if (zAMWeYEZVPsciyla(enumerationUVPDCHxAOzaosslW)) {
            this.f9a0364b9 = zPTInZrsWPFZmlQa((p5a445d71.p7c922baa.pca323100.p582a4948) xmmnpjlwTJSeWRek(enumerationUVPDCHxAOzaosslW));
        }
        this.f80925ac2 = p80f8c729Var is p5a445d71.p7c922baa.pca323100.p6a819fa7;
    }

    public static void PuxVXsqIeevnHXgF(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.util.Enumeration UVPDCHxAOzaosslW(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.getobjects();
    }

    public static void VslZKIOWiLTxoLwI(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.object DUedWXakauspMFbl(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78) {
            return (p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p56fc8961.p32555e78(mlsQVDIgwxsLSbBE(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 MlsQVDIgwxsLSbBE(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static java.lang.object XmmnpjlwTJSeWRek(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static bool ZAMWeYEZVPsciyla(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 ZPTInZrsWPFZmlQa(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var) {
        return p582a4948Var.getobject();
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetContent() {
        return this.f9a0364b9;
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetContentType() {
        return this.fdf5feafa;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((21 + 16) % 16 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        PuxVXsqIeevnHXgF(pd6ccb7fcVar, this.fdf5feafa);
        if (this.f9a0364b9 is not null) {
            VslZKIOWiLTxoLwI(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.pd0fc91bc(true, 0, this.f9a0364b9));
        }
        return !this.f80925ac2 ? new p5a445d71.p7c922baa.pca323100.p85c20c01(pd6ccb7fcVar) : new p5a445d71.p7c922baa.pca323100.p6a819fa7(pd6ccb7fcVar);
    }
}

