namespace WillowMaze.Wasm.Decompiled;


public class p895b0c87 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private readonly p5a445d71.p7c922baa.pca323100.ped34daf1 f15544082;
    private readonly p5a445d71.p7c922baa.pca323100.p364bf33a f1ef64c01;
    private readonly p5a445d71.p7c922baa.pca323100.p364bf33a f46298fd2;
    private readonly p5a445d71.p7c922baa.pca323100.p364bf33a f6f3db962;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f f7cd87af9;
    private readonly p5a445d71.p7c922baa.pca323100.p364bf33a f97bb96bd;
    private readonly p5a445d71.p7c922baa.pca323100.p364bf33a fd0ffd7bd;
    private readonly p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f fe99e2eec;
    private readonly p5a445d71.p7c922baa.pca323100.ped34daf1 fefd717fe;

    public p895b0c87(p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f p8670b90fVar, p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var) {
        this.f7cd87af9 = p8670b90fVar;
        this.f1ef64c01 = p364bf33aVar;
        this.fefd717fe = ped34daf1Var;
    }

    private p895b0c87(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((9 + 18) % 18 > 0) {
        }
        if (QaXlqfPFOYVEiGmv(p80f8c729Var) != 3) {
            throw new java.lang.IllegalArgumentException("incorrect sequence size");
        }
        this.f7cd87af9 = sSyujTfGPVRGpBnF(jcbfAlHnIdNecVWd(p80f8c729Var, 0));
        this.f1ef64c01 = SFoNGofVQqdHhTYK(JuvfFQjnJjwVzITU(p80f8c729Var, 1));
        this.fefd717fe = QHrIUqipbdskfFfm(gfJxOwbPQrXBIAFo(p80f8c729Var, 2));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 JuvfFQjnJjwVzITU(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.ped34daf1 QHrIUqipbdskfFfm(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.ped34daf1.m8bab0102(obj);
    }

    public static int QaXlqfPFOYVEiGmv(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p364bf33a SFoNGofVQqdHhTYK(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p364bf33a.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 AVwfVpEGjrEwZSRa(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GfJxOwbPQrXBIAFo(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 JcbfAlHnIdNecVWd(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p895b0c87 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p8010fd0f.p895b0c87) {
            return (p5a445d71.p7c922baa.pca323100.p8010fd0f.p895b0c87) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p8010fd0f.p895b0c87(aVwfVpEGjrEwZSRa(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f SSyujTfGPVRGpBnF(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetAttrType() {
        return this.f1ef64c01;
    }

    public p5a445d71.p7c922baa.pca323100.ped34daf1 GetAttrValues() {
        return this.fefd717fe;
    }

    public p5a445d71.p7c922baa.pca323100.p8010fd0f.p8670b90f GetBodyPartID() {
        return this.f7cd87af9;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((7 + 12) % 12 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr = new p5a445d71.p7c922baa.pca323100.p0fd1bdf1[3];
        p0fd1bdf1VarArr[0] = this.f7cd87af9;
        p0fd1bdf1VarArr[1] = this.f1ef64c01;
        p0fd1bdf1VarArr[2] = this.fefd717fe;
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(p0fd1bdf1VarArr);
    }
}

