namespace WillowMaze.Wasm.Decompiled;


public class p3100400d : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private byte[] f1287a38a;
    private byte[] f1860998a;
    private byte[] f1b38daae;
    private byte[] f27db7458;
    private byte[] f34772f98;
    private int f349ba165;
    private byte[] f382fd102;
    private byte[] f39523a20;
    private byte[] f3af3d59a;
    private int f5377df7e;
    private byte[] f63ce8e1d;
    private byte[] f69c16123;
    private int f7b8b965a;
    private byte[] f7e117ecd;
    private int f8ce4b16b;
    private byte[] f9e521745;
    private int fa2035bc4;
    private byte[] fa57e941f;
    private byte[] fa5a9eac4;
    private int fa76ad14e;
    private byte[] faa6dde50;
    private int fabc0db9b;
    private byte[] facacee91;
    private byte[] fafc214c7;
    private byte[] fc5a1bcef;
    private int fc848102e;
    private byte[] fc962b02d;
    private byte[] fdddf1f00;
    private int fe5dd933c;
    private byte[] fecd3c6eb;
    private byte[] ff4008ee7;

    public p3100400d(int i, int i2, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar2, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 p6c210a37Var) {
        this.f7b8b965a = i;
        this.f8ce4b16b = i2;
        this.fa5a9eac4 = p021739e3Var.getEncoded();
        this.faa6dde50 = p89f5ebf1Var.getEncoded();
        this.ff4008ee7 = p6c210a37Var.getEncoded();
        this.f7e117ecd = pfc77ea6cVar.getEncoded();
        this.f382fd102 = pfc77ea6cVar2.getEncoded();
    }

    private p3100400d(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.f7b8b965a = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729Var.getobjectAt(0)).intValueExact();
        this.f8ce4b16b = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729Var.getobjectAt(1)).intValueExact();
        this.fa5a9eac4 = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var.getobjectAt(2)).getOctets();
        this.faa6dde50 = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var.getobjectAt(3)).getOctets();
        this.f7e117ecd = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var.getobjectAt(4)).getOctets();
        this.f382fd102 = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var.getobjectAt(5)).getOctets();
        this.ff4008ee7 = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var.getobjectAt(6)).getOctets();
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.p3100400d M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.p3100400d) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.p3100400d) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.p3100400d(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 GetField() {
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3(this.fa5a9eac4);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 GetGoppaPoly() {
        if ((29 + 19) % 19 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(getField(), this.faa6dde50);
    }

    public int GetK() {
        return this.f8ce4b16b;
    }

    public int GetN() {
        return this.f7b8b965a;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c GetP1() {
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c(this.f7e117ecd);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c GetP2() {
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c(this.f382fd102);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37 GetSInv() {
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p6c210a37(this.ff4008ee7);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((19 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f7b8b965a));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f8ce4b16b));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.fa5a9eac4));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.faa6dde50));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f7e117ecd));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f382fd102));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.ff4008ee7));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

