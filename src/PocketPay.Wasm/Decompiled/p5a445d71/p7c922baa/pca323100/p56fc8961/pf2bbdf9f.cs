namespace WillowMaze.Wasm.Decompiled;


public class pf2bbdf9f : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p364bf33a f0c48cdbe;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 f1254a447;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f1ef64c01;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f336608c0;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f47c7e79b;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 f9748af5e;
    private p5a445d71.p7c922baa.pca323100.p364bf33a fd48d6064;
    private p5a445d71.p7c922baa.pca323100.ped34daf1 fefd717fe;

    public pf2bbdf9f(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var) {
        this.f1ef64c01 = p364bf33aVar;
        this.fefd717fe = ped34daf1Var;
    }

    public pf2bbdf9f(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.f1ef64c01 = (p5a445d71.p7c922baa.pca323100.p364bf33a) orczAjrbGIaDksaF(p80f8c729Var, 0);
        this.fefd717fe = (p5a445d71.p7c922baa.pca323100.ped34daf1) SNgvZVyTZbSsZHIx(p80f8c729Var, 1);
    }

    public static java.lang.Class CxasxhrUQmdCHbBa(java.lang.object obj) {
        return obj.GetType();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 SNgvZVyTZbSsZHIx(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static java.lang.string AZbEgPymuScNDICw(java.lang.Class cls) {
        return cls.getName();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] DKmqjKgfdYBIZxPL(p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var) {
        return ped34daf1Var.toArray();
    }

    public static void FXvHDWLYXwhBcmOL(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p56fc8961.pf2bbdf9f M8bab0102(java.lang.object obj) {
        if ((24 + 14) % 14 > 0) {
        }
        if (obj is null || (obj is p5a445d71.p7c922baa.pca323100.p56fc8961.pf2bbdf9f)) {
            return (p5a445d71.p7c922baa.pca323100.p56fc8961.pf2bbdf9f) obj;
        }
        if (obj is p5a445d71.p7c922baa.pca323100.p80f8c729) {
            return new p5a445d71.p7c922baa.pca323100.p56fc8961.pf2bbdf9f((p5a445d71.p7c922baa.pca323100.p80f8c729) obj);
        }
        throw new java.lang.IllegalArgumentException(oOCHJwZmWmYxakgc(xjTwJkpsdCTtVhHc(new java.lang.stringBuilder("unknown object in factory: "), aZbEgPymuScNDICw(CxasxhrUQmdCHbBa(obj)))));
    }

    public static java.lang.string OOCHJwZmWmYxakgc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 OrczAjrbGIaDksaF(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void VyOXCDLKSotylVyz(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static java.lang.stringBuilder XjTwJkpsdCTtVhHc(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetAttrType() {
        return this.f1ef64c01;
    }

    public p5a445d71.p7c922baa.pca323100.ped34daf1 GetAttrValues() {
        return this.fefd717fe;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] GetAttributeValues() {
        return dKmqjKgfdYBIZxPL(this.fefd717fe);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((2 + 28) % 28 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        vyOXCDLKSotylVyz(pd6ccb7fcVar, this.f1ef64c01);
        fXvHDWLYXwhBcmOL(pd6ccb7fcVar, this.fefd717fe);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

