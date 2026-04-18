namespace WillowMaze.Wasm.Decompiled;


public class pdf525d32 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.pff670599.p4a5545be f357391a6;
    private readonly p5a445d71.p7c922baa.pca323100.pff670599.p2f4eb55d f40016aa9;
    private readonly p5a445d71.p7c922baa.pca323100.pff670599.p2f4eb55d f68ee5a8c;
    private readonly p5a445d71.p7c922baa.pca323100.pff670599.p4a5545be f82d1aeeb;
    private readonly p5a445d71.p7c922baa.pca323100.pff670599.p2f4eb55d f9c3beff7;
    private readonly p5a445d71.p7c922baa.pca323100.pff670599.p2f4eb55d fd0a239c7;
    private readonly p5a445d71.p7c922baa.pca323100.pff670599.p4a5545be fde8c9e67;

    private pdf525d32(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((22 + 17) % 17 > 0) {
        }
        this.f68ee5a8c = hZaNKonQjYXcqhcw(uWEhDKrrEqQSEkZD(p80f8c729Var, 0));
        this.fde8c9e67 = wlBZnKmOjrXbOTRX(XdQqYLmesNLcGRNm(NxgumDzjOoWlJKdZ(p80f8c729Var, 1)), false);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 DPlSowtjPTiJqSMp(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 NxgumDzjOoWlJKdZ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p582a4948 XdQqYLmesNLcGRNm(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p582a4948.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pff670599.p2f4eb55d HZaNKonQjYXcqhcw(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pff670599.p2f4eb55d.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.pff670599.pdf525d32 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pff670599.pdf525d32) {
            return (p5a445d71.p7c922baa.pca323100.pff670599.pdf525d32) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pff670599.pdf525d32(DPlSowtjPTiJqSMp(obj));
    }

    public static void OPqxnIUYdmYlMJLc(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static void SSJrZWbmlJHOzoTy(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 UWEhDKrrEqQSEkZD(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.pff670599.p4a5545be WlBZnKmOjrXbOTRX(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.pff670599.p4a5545be.m8bab0102(p582a4948Var, z);
    }

    public p5a445d71.p7c922baa.pca323100.pff670599.p2f4eb55d GetSessionEncryptedKey() {
        return this.f68ee5a8c;
    }

    public p5a445d71.p7c922baa.pca323100.pff670599.p4a5545be GetTransportParameters() {
        return this.fde8c9e67;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((22 + 15) % 15 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        oPqxnIUYdmYlMJLc(pd6ccb7fcVar, this.f68ee5a8c);
        if (this.fde8c9e67 is not null) {
            sSJrZWbmlJHOzoTy(pd6ccb7fcVar, new p5a445d71.p7c922baa.pca323100.p87af127c(false, 0, this.fde8c9e67));
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

