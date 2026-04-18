namespace WillowMaze.Wasm.Decompiled;


public class pe004ba1d : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.p364bf33a f12d45344;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f584ab081;
    private readonly p5a445d71.p7c922baa.pca323100.p364bf33a f5987e74a;
    private readonly p5a445d71.p7c922baa.pca323100.p364bf33a f63bb4187;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f75edc41a;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f8a019b31;
    private readonly p5a445d71.p7c922baa.pca323100.p364bf33a fd5dd19c9;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1 ff1649b80;
    private readonly p5a445d71.p7c922baa.pca323100.p0fd1bdf1 ff5e65075;

    public pe004ba1d(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f63bb4187 = p364bf33aVar;
        this.ff5e65075 = p0fd1bdf1Var;
    }

    private pe004ba1d(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((6 + 30) % 30 > 0) {
        }
        if (BVwxSCXiNzQIluLF(p80f8c729Var) != 2) {
            throw new java.lang.IllegalArgumentException("Sequence must be 2 elements.");
        }
        this.f63bb4187 = jNcdscsrjlrEkhan(LBCujPzSjYdhEtXI(p80f8c729Var, 0));
        this.ff5e65075 = WhEtLuELmKKhJjbC(p80f8c729Var, 1);
    }

    public static int BVwxSCXiNzQIluLF(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 DvFsICFMQVRPQEyb(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 LBCujPzSjYdhEtXI(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 WhEtLuELmKKhJjbC(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p364bf33a JNcdscsrjlrEkhan(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 LzYjUiSKrFMrYFuH(p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        return p0fd1bdf1Var.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.pe004ba1d M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p8010fd0f.pe004ba1d) {
            return (p5a445d71.p7c922baa.pca323100.p8010fd0f.pe004ba1d) obj;
        }
        if (!(obj is p5a445d71.p7c922baa.pca323100.p0fd1bdf1)) {
            if (obj is byte[]) {
                return xnKJqKFCmuEIdmid(DvFsICFMQVRPQEyb(obj));
            }
            return null;
        }
        p5a445d71.p7c922baa.pca323100.p301c7ed4 p301c7ed4VarLzYjUiSKrFMrYFuH = lzYjUiSKrFMrYFuH((p5a445d71.p7c922baa.pca323100.p0fd1bdf1) obj);
        if (p301c7ed4VarLzYjUiSKrFMrYFuH is p5a445d71.p7c922baa.pca323100.p80f8c729) {
            return new p5a445d71.p7c922baa.pca323100.p8010fd0f.pe004ba1d((p5a445d71.p7c922baa.pca323100.p80f8c729) p301c7ed4VarLzYjUiSKrFMrYFuH);
        }
        return null;
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.pe004ba1d XnKJqKFCmuEIdmid(java.lang.object obj) {
        return m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetFailInfoOID() {
        return this.f63bb4187;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetFailInfoValue() {
        return this.ff5e65075;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((31 + 16) % 16 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr = new p5a445d71.p7c922baa.pca323100.p0fd1bdf1[2];
        p0fd1bdf1VarArr[0] = this.f63bb4187;
        p0fd1bdf1VarArr[1] = this.ff5e65075;
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(p0fd1bdf1VarArr);
    }
}

