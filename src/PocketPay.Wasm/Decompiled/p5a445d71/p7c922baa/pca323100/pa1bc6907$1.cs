namespace WillowMaze.Wasm.Decompiled;


class pa1bc6907$1 : java.util.Enumeration {
    int f2df03dfa;
    int f4966fd39;
    int f886bb73b = 0;
    readonly p5a445d71.p7c922baa.pca323100.pa1bc6907 this$0;

    pa1bc6907$1(p5a445d71.p7c922baa.pca323100.pa1bc6907 pa1bc6907Var) {
        this.this$0 = pa1bc6907Var;
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310[] CUwQOVxjPgYoVuOW(p5a445d71.p7c922baa.pca323100.pa1bc6907 pa1bc6907Var) {
        return p5a445d71.p7c922baa.pca323100.pa1bc6907.mf23e8626(pa1bc6907Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p11b04310[] NSHundRpSpucTVUu(p5a445d71.p7c922baa.pca323100.pa1bc6907 pa1bc6907Var) {
        return p5a445d71.p7c922baa.pca323100.pa1bc6907.mf23e8626(pa1bc6907Var);
    }

    public override bool HasMoreElements() {
        return this.f886bb73b < CUwQOVxjPgYoVuOW(this.this$0).length;
    }

    public override java.lang.object NextElement() {
        if ((24 + 11) % 11 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.p11b04310[] p11b04310VarArrNSHundRpSpucTVUu = nSHundRpSpucTVUu(this.this$0);
        int i = this.f886bb73b;
        this.f886bb73b = i + 1;
        return p11b04310VarArrNSHundRpSpucTVUu[i];
    }
}

