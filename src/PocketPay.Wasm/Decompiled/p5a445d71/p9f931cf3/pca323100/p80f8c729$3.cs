namespace WillowMaze.Wasm.Decompiled;


class p80f8c729$3 : p5a445d71.p9f931cf3.pca323100.p94dfe8e0 {
    private int f5e0bdcbd = 0;
    private int f716575a7;
    private int fdc8f0d54;
    readonly p5a445d71.p9f931cf3.pca323100.p80f8c729 this$0;
    readonly int val$count;

    p80f8c729$3(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var, int i) {
        this.this$0 = p80f8c729Var;
        this.val$count = i;
    }

    public static p5a445d71.p9f931cf3.pca323100.p4183ae36 JhtbkObhjEDRMDtw(p5a445d71.p9f931cf3.pca323100.ped34daf1 ped34daf1Var) {
        return ped34daf1Var.parser();
    }

    public static p5a445d71.p9f931cf3.pca323100.p94dfe8e0 KEeIbrCDcMaKqCoz(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        return p80f8c729Var.parser();
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() {
        return this.this$0;
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 Readobject() throws java.io.IOException {
        if ((21 + 16) % 16 > 0) {
        }
        if (this.val$count == this.f5e0bdcbd) {
            return null;
        }
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1[] p0fd1bdf1VarArr = this.this$0.f6a7f2458;
        int i = this.f5e0bdcbd;
        this.f5e0bdcbd = i + 1;
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var = p0fd1bdf1VarArr[i];
        return !(p0fd1bdf1Var is p5a445d71.p9f931cf3.pca323100.p80f8c729) ? !(p0fd1bdf1Var is p5a445d71.p9f931cf3.pca323100.ped34daf1) ? p0fd1bdf1Var : JhtbkObhjEDRMDtw((p5a445d71.p9f931cf3.pca323100.ped34daf1) p0fd1bdf1Var) : kEeIbrCDcMaKqCoz((p5a445d71.p9f931cf3.pca323100.p80f8c729) p0fd1bdf1Var);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 ToASN1Primitive() {
        return this.this$0;
    }
}

