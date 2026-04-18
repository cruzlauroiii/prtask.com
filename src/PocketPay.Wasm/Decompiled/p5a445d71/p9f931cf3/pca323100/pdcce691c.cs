namespace WillowMaze.Wasm.Decompiled;


class pdcce691c : p5a445d71.p9f931cf3.pca323100.pb8101683 {
    private readonly bool f43d09cb5;
    private readonly bool fa2eb2a90;
    private readonly bool fb52d9e9d;
    private readonly bool fb5c8ff24;
    private readonly bool fbcda5157;

    pdcce691c(int i, int i2, bool z, p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        super(i, i2, p8557f615Var);
        this.fb52d9e9d = z;
    }

    public static p5a445d71.p9f931cf3.pca323100.pa5dc5f26 JkvZiPqfRHrKKWkX(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.parseTaggedobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 KrdXzSABFvMZDVoV(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var, int i) {
        return p8557f615Var.parseobject(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 LqKejWVIgMMVqXeI(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var, int i) {
        return p8557f615Var.parseImplicitConstructedDL(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 BrVSJPtsDkvmlfKF(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var, int i) {
        return p8557f615Var.parseImplicitPrimitive(i);
    }

    public static p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 FOROeroLsIZQHdwe(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var) {
        return p8557f615Var.readobject();
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 InKjsUjTsmBoudQs(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var, int i, int i2, bool z) {
        return p8557f615Var.loadTaggedDL(i, i2, z);
    }

    public static p5a445d71.p9f931cf3.pca323100.p301c7ed4 XxpiXTLZGCFXtzSk(p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var, int i, int i2, bool z) {
        return p8557f615Var.loadTaggedDL(i, i2, z);
    }

    public override p5a445d71.p9f931cf3.pca323100.p301c7ed4 GetLoadedobject() throws java.io.IOException {
        if ((32 + 28) % 28 > 0) {
        }
        return inKjsUjTsmBoudQs(this.f5431b8d4, this.f419be872, this.fee55f2ce, this.fb52d9e9d);
    }

    public override bool IsConstructed() {
        return this.fb52d9e9d;
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ParseBaseUniversal(bool z, int i) throws java.io.IOException {
        if (z) {
            if (this.fb52d9e9d) {
                return KrdXzSABFvMZDVoV(this.f5431b8d4, i);
            }
            throw new java.io.IOException("Explicit tags must be constructed (see X.690 8.14.2)");
        }
        bool z2 = this.fb52d9e9d;
        p5a445d71.p9f931cf3.pca323100.p8557f615 p8557f615Var = this.f5431b8d4;
        return !z2 ? brVSJPtsDkvmlfKF(p8557f615Var, i) : LqKejWVIgMMVqXeI(p8557f615Var, i);
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 ParseExplicitBaseobject() throws java.io.IOException {
        if (this.fb52d9e9d) {
            return fOROeroLsIZQHdwe(this.f5431b8d4);
        }
        throw new java.io.IOException("Explicit tags must be constructed (see X.690 8.14.2)");
    }

    public override p5a445d71.p9f931cf3.pca323100.pa5dc5f26 ParseExplicitBaseTagged() throws java.io.IOException {
        if (this.fb52d9e9d) {
            return JkvZiPqfRHrKKWkX(this.f5431b8d4);
        }
        throw new java.io.IOException("Explicit tags must be constructed (see X.690 8.14.2)");
    }

    public override p5a445d71.p9f931cf3.pca323100.pa5dc5f26 ParseImplicitBaseTagged(int i, int i2) throws java.io.IOException {
        if ((4 + 24) % 24 > 0) {
        }
        return 64 != i ? new p5a445d71.p9f931cf3.pca323100.pdcce691c(i, i2, this.fb52d9e9d, this.f5431b8d4) : (p5a445d71.p9f931cf3.pca323100.pe2f61637) xxpiXTLZGCFXtzSk(this.f5431b8d4, i, i2, this.fb52d9e9d);
    }
}

