namespace WillowMaze.Wasm.Decompiled;


class p80f8c729$1 : p5a445d71.p7c922baa.pca323100.p94dfe8e0 {
    private readonly int f2ffe4e77;
    private int f6a992d55;
    private readonly int f81e0f696;
    private int f8791ca60;
    private readonly int f9386e50c;
    private int fc66f1364;
    private int fddb9965d;
    readonly p5a445d71.p7c922baa.pca323100.p80f8c729 this$0;
    readonly p5a445d71.p7c922baa.pca323100.p80f8c729 val$outer;

    p80f8c729$1(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var2) {
        this.this$0 = p80f8c729Var;
        this.val$outer = p80f8c729Var2;
        this.f2ffe4e77 = ZvbKxzpRuSOOwtNR(p80f8c729Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 HkPDwfqLLRbgQNes(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var, int i) {
        return p80f8c729Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p94dfe8e0 MXPTGBrdCFtpECLU(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.parser();
    }

    public static int ZvbKxzpRuSOOwtNR(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p4183ae36 JUNGXCaXNUMQHhYG(p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var) {
        return ped34daf1Var.parser();
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 GetLoadedobject() {
        return this.val$outer;
    }

    public override p5a445d71.p7c922baa.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        if ((22 + 9) % 9 > 0) {
        }
        int i = this.f6a992d55;
        if (i == this.f2ffe4e77) {
            return null;
        }
        p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var = this.this$0;
        this.f6a992d55 = i + 1;
        p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1VarHkPDwfqLLRbgQNes = HkPDwfqLLRbgQNes(p80f8c729Var, i);
        return !(p0fd1bdf1VarHkPDwfqLLRbgQNes is p5a445d71.p7c922baa.pca323100.p80f8c729) ? !(p0fd1bdf1VarHkPDwfqLLRbgQNes is p5a445d71.p7c922baa.pca323100.ped34daf1) ? p0fd1bdf1VarHkPDwfqLLRbgQNes : jUNGXCaXNUMQHhYG((p5a445d71.p7c922baa.pca323100.ped34daf1) p0fd1bdf1VarHkPDwfqLLRbgQNes) : MXPTGBrdCFtpECLU((p5a445d71.p7c922baa.pca323100.p80f8c729) p0fd1bdf1VarHkPDwfqLLRbgQNes);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.val$outer;
    }
}

