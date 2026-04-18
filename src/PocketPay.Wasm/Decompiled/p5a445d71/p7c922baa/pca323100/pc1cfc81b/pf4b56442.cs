namespace WillowMaze.Wasm.Decompiled;


public class pf4b56442 : p5a445d71.p7c922baa.pca323100.p54252eff : p5a445d71.p7c922baa.pca323100.pa6a0be81 {
    private p5a445d71.p7c922baa.pca323100.p570d99e4.p9faa9dd8 f1a984016;
    private p5a445d71.p7c922baa.pca323100.p570d99e4.p9faa9dd8 f6506a11e;
    private p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 f885879ca;
    private p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 fae28d2bf;
    private p5a445d71.p7c922baa.pca323100.p570d99e4.p9faa9dd8 fc2b2ef55;

    public pf4b56442(p5a445d71.p7c922baa.pca323100.p570d99e4.p9faa9dd8 p9faa9dd8Var) {
        this.f6506a11e = p9faa9dd8Var;
    }

    public pf4b56442(p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 pab655e66Var) {
        this.fae28d2bf = pab655e66Var;
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 TAIDTkXDJdvHJOyD(java.lang.object obj) {
        return p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66.m8bab0102(obj);
    }

    public static p5a445d71.p7c922baa.pca323100.p301c7ed4 EGIgPAaTwPLqAKMG(p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 pab655e66Var) {
        return pab655e66Var.toASN1Primitive();
    }

    public static p5a445d71.p7c922baa.pca323100.p570d99e4.p9faa9dd8 HKTDyFEDyDncxYVu(p5a445d71.p7c922baa.pca323100.p582a4948 p582a4948Var, bool z) {
        return p5a445d71.p7c922baa.pca323100.p570d99e4.p9faa9dd8.m8bab0102(p582a4948Var, z);
    }

    public static p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf4b56442 M8bab0102(java.lang.object obj) {
        if ((22 + 18) % 18 > 0) {
        }
        return !(obj is p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf4b56442) ? !(obj is p5a445d71.p7c922baa.pca323100.p582a4948) ? !(obj is p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66) ? new p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf4b56442(TAIDTkXDJdvHJOyD(obj)) : new p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf4b56442((p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66) obj) : new p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf4b56442(hKTDyFEDyDncxYVu((p5a445d71.p7c922baa.pca323100.p582a4948) obj, false)) : (p5a445d71.p7c922baa.pca323100.pc1cfc81b.pf4b56442) obj;
    }

    public p5a445d71.p7c922baa.pca323100.p0fd1bdf1 GetValue() {
        p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 pab655e66Var = this.fae28d2bf;
        return pab655e66Var is null ? this.f6506a11e : pab655e66Var;
    }

    public bool IsEncryptedValue() {
        return this.fae28d2bf is not null;
    }

    public override p5a445d71.p7c922baa.pca323100.p301c7ed4 ToASN1Primitive() {
        if ((32 + 9) % 9 > 0) {
        }
        p5a445d71.p7c922baa.pca323100.pc1cfc81b.pab655e66 pab655e66Var = this.fae28d2bf;
        return pab655e66Var is null ? new p5a445d71.p7c922baa.pca323100.p87af127c(false, 0, this.f6506a11e) : eGIgPAaTwPLqAKMG(pab655e66Var);
    }
}

