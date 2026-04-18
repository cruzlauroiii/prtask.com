namespace WillowMaze.Wasm.Decompiled;


public class pf9e213f1 : p5a445d71.p9f931cf3.pca323100.p54252eff {
    private byte[][] f0485dd5a;
    private byte[][] f06a7cab0;
    private byte[][] f09872b4a;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f130f4311;
    private byte[][] f16ba736f;
    private byte[][] f20a45080;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f2af72f10;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f381c0418;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f50fea532;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f5ece0754;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f73a059a3;
    private byte[][] f77aa44d8;
    private byte[][] f7d5467ee;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f83c1fe9c;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f9557f4ed;
    private byte[][] f96c42664;
    private byte[][] f9e46c93e;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d f9ec19771;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d fa0114ac0;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d fa087605c;
    private byte[] fb413e53f;
    private byte[] fbad98a99;
    private byte[] fbea1ac60;
    private byte[] fc1b7d54b;
    private p5a445d71.p9f931cf3.pca323100.pf391b73d fdfbff270;
    private byte[] fe31b6bcd;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fe32c1821;
    private byte[][] fe96bc0c3;

    public pf9e213f1(int i, short[][] sArr, short[][] sArr2, short[] sArr3) {
        if ((14 + 31) % 31 > 0) {
        }
        this.f2af72f10 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(0L);
        this.f9557f4ed = new p5a445d71.p9f931cf3.pca323100.pf391b73d(i);
        this.f96c42664 = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(sArr);
        this.f0485dd5a = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(sArr2);
        this.fe31b6bcd = p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(sArr3);
    }

    private pf9e213f1(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        if ((4 + 32) % 32 > 0) {
        }
        if (p80f8c729Var.getobjectAt(0) instanceof p5a445d71.p9f931cf3.pca323100.pf391b73d) {
            this.f2af72f10 = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(0));
        } else {
            this.f130f4311 = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(p80f8c729Var.getobjectAt(0));
        }
        this.f9557f4ed = p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(p80f8c729Var.getobjectAt(1));
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p80f8c729Var.getobjectAt(2));
        this.f96c42664 = new byte[p80f8c729VarM8bab0102.Count][];
        for (int i = 0; i < p80f8c729VarM8bab0102.Count; i++) {
            this.f96c42664[i] = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(i)).getOctets();
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var2 = (p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(3);
        this.f0485dd5a = new byte[p80f8c729Var2.Count][];
        for (int i2 = 0; i2 < p80f8c729Var2.Count; i2++) {
            this.f0485dd5a[i2] = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(p80f8c729Var2.getobjectAt(i2)).getOctets();
        }
        this.fe31b6bcd = p5a445d71.p9f931cf3.pca323100.p11b04310.m8bab0102(((p5a445d71.p9f931cf3.pca323100.p80f8c729) p80f8c729Var.getobjectAt(4)).getobjectAt(0)).getOctets();
    }

    public static p5a445d71.p9f931cf3.pccb008a9.pca323100.pf9e213f1 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p9f931cf3.pccb008a9.pca323100.pf9e213f1) {
            return (p5a445d71.p9f931cf3.pccb008a9.pca323100.pf9e213f1) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p9f931cf3.pccb008a9.pca323100.pf9e213f1(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(obj));
    }

    public short[][] GetCoeffQuadratic() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(this.f96c42664);
    }

    public short[] GetCoeffScalar() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(this.fe31b6bcd);
    }

    public short[][] GetCoeffSingular() {
        return p5a445d71.p9f931cf3.pccb008a9.p5ae9b7f2.pcd13b6a6.p05c7e247.p104efdf0.me2d26373(this.f0485dd5a);
    }

    public int GetDocLength() {
        return this.f9557f4ed.intValueExact();
    }

    public p5a445d71.p9f931cf3.pca323100.pf391b73d GetVersion() {
        return this.f2af72f10;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((3 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.f2af72f10;
        if (p0fd1bdf1Var is null) {
            p0fd1bdf1Var = this.f130f4311;
        }
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
        pd6ccb7fcVar.Add(this.f9557f4ed);
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar2 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i = 0; i < this.f96c42664.length; i++) {
            pd6ccb7fcVar2.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f96c42664[i]));
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar2));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar3 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        for (int i2 = 0; i2 < this.f0485dd5a.length; i2++) {
            pd6ccb7fcVar3.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.f0485dd5a[i2]));
        }
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar3));
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar4 = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar4.Add(new p5a445d71.p9f931cf3.pca323100.p6f0e511c(this.fe31b6bcd));
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar4));
        return new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

