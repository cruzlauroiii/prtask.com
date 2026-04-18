namespace WillowMaze.Wasm.Decompiled;


public class p8e3f2ae5 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 f53ed7f2e;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f f7cd87af9;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f f907b09e4;
    private readonly p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 fa3e2fe12;
    private readonly p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 fe77de465;
    private readonly p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 feae3dc6d;

    public p8e3f2ae5(p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f p8670b90fVar, p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 p32555e78Var) {
        this.f7cd87af9 = p8670b90fVar;
        this.fa3e2fe12 = p32555e78Var;
    }

    private p8e3f2ae5(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((9 + 10) % 10 > 0) {
        }
        if (wpIjEBbazSAZTnXQ(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException("incorrect sequence size");
        }
        this.f7cd87af9 = jTXiSSDbIIQICJNK(bzATzBaeaeobngnQ(p80f8c729Var, 0));
        this.fa3e2fe12 = UOPXCHJpSZTBfqBD(SVrqZVddhHqeXOPg(p80f8c729Var, 1));
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 FIZCyyJOJTMIscrV(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8e3f2ae5 IpcBunuYaBShAfNI(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 NJEgMNJoCNDNTBnm(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static void NfoAcwHFSWVDVAkG(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 SVrqZVddhHqeXOPg(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 UOPXCHJpSZTBfqBD(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78.m8bab0102(obj);
    }

    public static void XZLCobMOzhkxxXcL(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 BzATzBaeaeobngnQ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f JTXiSSDbIIQICJNK(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8e3f2ae5 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p8010fd0f.p8e3f2ae5) {
            return (p5a445d71.p7c922baa.pca323100.p8010fd0f.p8e3f2ae5) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p8010fd0f.p8e3f2ae5(NJEgMNJoCNDNTBnm(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8e3f2ae5 M8bab0102(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return IpcBunuYaBShAfNI(FIZCyyJOJTMIscrV(p582a4948Var, z));
    }

    public static int WpIjEBbazSAZTnXQ(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f GetBodyPartID() {
        return this.f7cd87af9;
    }

    public p5a445d71.p7c922baa.pca323100.p570d99e4.p32555e78 GetContentInfo() {
        return this.fa3e2fe12;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((5 + 5) % 5 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        XZLCobMOzhkxxXcL(pd6ccb7fcVar, this.f7cd87af9);
        NfoAcwHFSWVDVAkG(pd6ccb7fcVar, this.fa3e2fe12);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

