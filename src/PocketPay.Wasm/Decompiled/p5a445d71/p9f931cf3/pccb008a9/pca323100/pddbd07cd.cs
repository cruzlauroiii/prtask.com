namespace WillowMaze.Wasm.Decompiled;


public class pddbd07cd : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private byte[] f118e4829;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f1867f91f;
    private byte[] f247ce246;
    private int f337a7b0c;
    private byte[] f424ab140;
    private byte[] f4c8859b1;
    private int f6e93db67;
    private int f7b8b965a;
    private int f8ce4b16b;
    private int f9be6c70d;
    private byte[] fa5a9eac4;
    private byte[] faa6dde50;
    private byte[] fc0cd8b30;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fc10f7796;
    private byte[] fc1535720;
    private int fc3c3f3a1;
    private byte[] fc616e9bb;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fd685b09c;
    private byte[] fe8396959;
    private int fe99f9ebd;
    private byte[] fef6275db;
    private int ffd742d1f;

    public pddbd07cd(int i, int i2, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 p021739e3Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 p89f5ebf1Var, p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c pfc77ea6cVar, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var) {
        this.f7b8b965a = i;
        this.f8ce4b16b = i2;
        this.fa5a9eac4 = p021739e3Var.getEncoded();
        this.faa6dde50 = p89f5ebf1Var.getEncoded();
        this.fc616e9bb = pfc77ea6cVar.getEncoded();
        this.fc10f7796 = p234a7530Var;
    }

    private pddbd07cd(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.f7b8b965a = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729Var.getobjectAt(0)).intValueExact();
        this.f8ce4b16b = ((p5a445d71.p9f931cf3.pca323100.pf391b73d) p80f8c729Var.getobjectAt(1)).intValueExact();
        this.fa5a9eac4 = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var.getobjectAt(2)).getOctets();
        this.faa6dde50 = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var.getobjectAt(3)).getOctets();
        this.fc616e9bb = ((p5a445d71.p9f931cf3.pca323100.p11b04310) p80f8c729Var.getobjectAt(4)).getOctets();
        this.fc10f7796 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(p80f8c729Var.getobjectAt(5));
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.pddbd07cd M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.pddbd07cd) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.pddbd07cd) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.pddbd07cd(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 GetDigest() {
        return this.fc10f7796;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3 GetField() {
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p021739e3(this.fa5a9eac4);
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1 GetGoppaPoly() {
        if ((28 + 18) % 18 > 0) {
        }
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.p89f5ebf1(getField(), this.faa6dde50);
    }

    public int GetK() {
        return this.f8ce4b16b;
    }

    public int GetN() {
        return this.f7b8b965a;
    }

    public p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c GetP() {
        return new p5a445d71.p9f931cf3.pccb008a9.p7e676e9e.p1bbf1d9f.pfc77ea6c(this.fc616e9bb);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((32 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f7b8b965a));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pf391b73d(this.f8ce4b16b));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.fa5a9eac4));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.faa6dde50));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.fc616e9bb));
        pd6ccb7fcVar.Add(this.fc10f7796);
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

