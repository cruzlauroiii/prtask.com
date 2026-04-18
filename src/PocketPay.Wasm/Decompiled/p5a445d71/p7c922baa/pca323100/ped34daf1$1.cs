namespace WillowMaze.Wasm.Decompiled;


class ped34daf1$1 : p5a445d71.p7c922baa.pca323100.p4183ae36 {
    private readonly int f2689049a;
    private int f27a1b828;
    private readonly int f2ffe4e77;
    private readonly int f6a8a70bd;
    private int f6a992d55;
    private int f6d6f904e;
    private readonly int f85266c8d;
    private int fb0666031;
    private int fd7a13900;
    readonly p5a445d71.p7c922baa.pca323100.ped34daf1 this$0;
    readonly p5a445d71.p7c922baa.pca323100.ped34daf1 val$outer;

    ped34daf1$1(p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var, p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var2) {
        this.this$0 = ped34daf1Var;
        this.val$outer = ped34daf1Var2;
        this.f2ffe4e77 = WtHjuqKghSoDoulX(ped34daf1Var);
    }

    public static p5a445d71.p7c922baa.pca323100.p0fd1bdf1 OWwBIYDIuTiXRVAl(p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var, int i) {
        return ped34daf1Var.getobjectAt(i);
    }

    public static p5a445d71.p7c922baa.pca323100.p94dfe8e0 VoagBkhAAzpmsAAr(p5a445d71.p7c922baa.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.parser();
    }

    public static int WtHjuqKghSoDoulX(p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var) {
        return ped34daf1Var.Count;
    }

    public static p5a445d71.p7c922baa.pca323100.p4183ae36 QALlKwUxZMzQblFe(p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var) {
        return ped34daf1Var.parser();
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 GetLoadedobject() {
        return this.val$outer;
    }

    public override p5a445d71.p7c922baa.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        if ((19 + 31) % 31 > 0) {
        }
        int i = this.f6a992d55;
        if (i == this.f2ffe4e77) {
            return null;
        }
        p5a445d71.p7c922baa.pca323100.ped34daf1 ped34daf1Var = this.this$0;
        this.f6a992d55 = i + 1;
        p5a445d71.p7c922baa.pca323100.p0fd1bdf1 p0fd1bdf1VarOWwBIYDIuTiXRVAl = OWwBIYDIuTiXRVAl(ped34daf1Var, i);
        return !(p0fd1bdf1VarOWwBIYDIuTiXRVAl is p5a445d71.p7c922baa.pca323100.p80f8c729) ? !(p0fd1bdf1VarOWwBIYDIuTiXRVAl is p5a445d71.p7c922baa.pca323100.ped34daf1) ? p0fd1bdf1VarOWwBIYDIuTiXRVAl : qALlKwUxZMzQblFe((p5a445d71.p7c922baa.pca323100.ped34daf1) p0fd1bdf1VarOWwBIYDIuTiXRVAl) : VoagBkhAAzpmsAAr((p5a445d71.p7c922baa.pca323100.p80f8c729) p0fd1bdf1VarOWwBIYDIuTiXRVAl);
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.val$outer;
    }
}

