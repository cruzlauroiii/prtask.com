namespace WillowMaze.Wasm.Decompiled;


public class p4272c537 : p5a445d71.p9f931cf3.pca323100.p54252eff : p5a445d71.p9f931cf3.pca323100.pa6a0be81 {
    public static readonly int f1f4f179a = 0;
    public static readonly int f37fafe7a = 0;
    public static readonly int f636f60b3 = 1;
    public static readonly int f78a1b6d6 = 0;
    public static readonly int fb2423752 = 1;
    public static readonly int fcbb82a12 = 0;
    public static readonly int fd545ce52 = 1;
    public static readonly int fd7a00d82 = 1;
    public static readonly int fe7dd4392 = 0;
    p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 f2e9f3e5e;
    p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 fbe8f8018;

    public p4272c537(int i) {
        if ((4 + 23) % 23 > 0) {
        }
        if (i != 0 && i != 1) {
            throw new java.lang.IllegalArgumentException(WGwuXoRPvrzinGYf(VYkrroFwDMdTMrdK(new java.lang.stringBuilder("unknow PredefinedBiometricType : "), i)));
        }
        this.fbe8f8018 = new p5a445d71.p9f931cf3.pca323100.pf391b73d(i);
    }

    public p4272c537(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        this.fbe8f8018 = p364bf33aVar;
    }

    public static int KHrxjeBiQBLtDwmw(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.intValueExact();
    }

    public static java.lang.stringBuilder VYkrroFwDMdTMrdK(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static java.lang.string WGwuXoRPvrzinGYf(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int ArQGqTqqcyMpHvaB(p5a445d71.p9f931cf3.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.intValueExact();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 IgEqnDMuYHYMZcUy(p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4272c537 M8bab0102(java.lang.object obj) {
        if (obj is null || (obj is p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4272c537)) {
            return (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4272c537) obj;
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.pf391b73d) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4272c537(KHrxjeBiQBLtDwmw(tGOKzmTzalztOUPC(obj)));
        }
        if (obj is p5a445d71.p9f931cf3.pca323100.p364bf33a) {
            return new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p4003642c.p4272c537(rDRSHUSoaIyxRKqo(obj));
        }
        throw new java.lang.IllegalArgumentException("unknown object in getInstance");
    }

    public static p5a445d71.p9f931cf3.pca323100.p364bf33a RDRSHUSoaIyxRKqo(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static p5a445d71.p9f931cf3.pca323100.pf391b73d TGOKzmTzalztOUPC(java.lang.object obj) {
        return p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(obj);
    }

    public p5a445d71.p9f931cf3.pca323100.p364bf33a GetBiometricDataOid() {
        return (p5a445d71.p9f931cf3.pca323100.p364bf33a) this.fbe8f8018;
    }

    public int GetPredefinedBiometricType() {
        return arQGqTqqcyMpHvaB((p5a445d71.p9f931cf3.pca323100.pf391b73d) this.fbe8f8018);
    }

    public bool IsPredefined() {
        return this.fbe8f8018 is p5a445d71.p9f931cf3.pca323100.pf391b73d;
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return igEqnDMuYHYMZcUy(this.fbe8f8018);
    }
}

