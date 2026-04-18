namespace WillowMaze.Wasm.Decompiled;


public class p46a7aa58 : p5a445d71.p7c922baa.pca323100.p54252eff {
    p5a445d71.p7c922baa.pca323100.p11b04310 f12bfeff3;
    p5a445d71.p7c922baa.pca323100.pf391b73d f471dacea;
    p5a445d71.p7c922baa.pca323100.pf391b73d f78f88b98;
    p5a445d71.p7c922baa.pca323100.p11b04310 fa45175f4;
    p5a445d71.p7c922baa.pca323100.pf391b73d fae35f64a;
    p5a445d71.p7c922baa.pca323100.p11b04310 fc60f78fb;
    p5a445d71.p7c922baa.pca323100.p11b04310 ff0b53b2d;

    private p46a7aa58(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        this.ff0b53b2d = (p5a445d71.p7c922baa.pca323100.p11b04310) gMeDDaqezDzYJPnf(p80f8c729Var, 0);
        this.f471dacea = XpjoENHLxflwyEyW(IkOKCFzFTbhyAjIL(p80f8c729Var, 1));
    }

    public p46a7aa58(byte[] bArr, int i) {
        if ((11 + 25) % 25 > 0) {
        }
        this.ff0b53b2d = new p5a445d71.p7c922baa.pca323100.p6f0e511c(bArr);
        this.f471dacea = new p5a445d71.p7c922baa.pca323100.pf391b73d(i);
    }

    public static void FqjCqWwLEDMjrugw(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 IkOKCFzFTbhyAjIL(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static void MUlEoLxIpPLMfhEF(p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar, p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        pd6ccb7fcVar.Add(p0fd1bdf1Var);
    }

    public static byte[] WOUGvBwNfuqBLqmT(p5a445d71.p7c922baa.pca323100.p11b04310 p11b04310Var) {
        return p11b04310Var.getOctets();
    }

    public static p5a445d71.p7c922baa.pca323100.pf391b73d XpjoENHLxflwyEyW(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pf391b73d.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GMeDDaqezDzYJPnf(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p80f8c729 GgypAgoLqOeXYoIx(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.p80f8c729.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p56fc8961.p46a7aa58 M8bab0102(java.lang.object obj) {
        if (obj is p5a445d71.p7c922baa.pca323100.p56fc8961.p46a7aa58) {
            return (p5a445d71.p7c922baa.pca323100.p56fc8961.p46a7aa58) obj;
        }
        if (obj is null) {
            return null;
        }
        return new p5a445d71.p7c922baa.pca323100.p56fc8961.p46a7aa58(ggypAgoLqOeXYoIx(obj));
    }

    public static java.math.Bigint MjWhnlexouJWnLUo(p5a445d71.p7c922baa.pca323100.pf391b73d pf391b73dVar) {
        return pf391b73dVar.getValue();
    }

    public byte[] GetIV() {
        return WOUGvBwNfuqBLqmT(this.ff0b53b2d);
    }

    public java.math.Bigint GetIterations() {
        return mjWhnlexouJWnLUo(this.f471dacea);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((6 + 25) % 25 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p7c922baa.pca323100.pd6ccb7fc();
        MUlEoLxIpPLMfhEF(pd6ccb7fcVar, this.ff0b53b2d);
        FqjCqWwLEDMjrugw(pd6ccb7fcVar, this.f471dacea);
        return new p5a445d71.p7c922baa.pca323100.pb840b7ef(pd6ccb7fcVar);
    }
}

