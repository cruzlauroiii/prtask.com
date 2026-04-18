namespace WillowMaze.Wasm.Decompiled;


public class p3cfda039 : p5a445d71.p7c922baa.pca323100.p54252eff {
    private p5a445d71.p7c922baa.pca323100.p364bf33a f05143d5c;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 f32845009;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f5c550f06;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f619c9851;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f6ecddd4d;
    private p5a445d71.p7c922baa.pca323100.p364bf33a f70bb1a45;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fc5e33391;
    private p5a445d71.p7c922baa.pca323100.p0fd1bdf1 fc690e184;

    public p3cfda039(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar) {
        this(p364bf33aVar, null);
    }

    public p3cfda039(p5a445d71.p7c922baa.pca323100.p364bf33a p364bf33aVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f5c550f06 = p364bf33aVar;
        this.fc5e33391 = p0fd1bdf1Var;
    }

    private p3cfda039(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        if ((21 + 29) % 29 > 0) {
        }
        this.f5c550f06 = (p5a445d71.p7c922baa.pca323100.p364bf33a) aZRajgWTbHrnvLjl(p80f8c729Var, 0);
        if (ktHadiGVoLdjnohg(p80f8c729Var) <= 1) {
            return;
        }
        this.fc5e33391 = mpxfUjOQOEwTetcS(p80f8c729Var, 1);
    }

    public static void WQwcAlpsqWEzUNmP(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 AZRajgWTbHrnvLjl(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static int KtHadiGVoLdjnohg(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.pfa17f333.p3cfda039 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.pfa17f333.p3cfda039) {
            return (p5a445d71.p7c922baa.pca323100.pfa17f333.p3cfda039) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.pfa17f333.p3cfda039(wMNAoIeLguqWoqsR(obj));
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 MpxfUjOQOEwTetcS(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void VrMflYzFFRELpLVE(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 WMNAoIeLguqWoqsR(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public p5a445d71.p7c922baa.pca323100.p364bf33a GetCommitmentTypeIdentifier() {
        return this.f5c550f06;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetQualifier() {
        return this.fc5e33391;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((32 + 24) % 24 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        WQwcAlpsqWEzUNmP(pd6ccb7fcVar, this.f5c550f06);
        p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var = this.fc5e33391;
        if (p0fd1bdf1Var is not null) {
            vrMflYzFFRELpLVE(pd6ccb7fcVar, p0fd1bdf1Var);
        }
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

