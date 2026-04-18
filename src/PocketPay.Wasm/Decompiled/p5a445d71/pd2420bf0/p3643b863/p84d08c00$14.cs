namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$14 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$14(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void EfUJNFEvHjzhKTay(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void GnIKPQUVeGquVoev(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void AfOmjogeArDnXGQv(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static bool CrQuGnCfbuwLOVOc(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char c) {
        return pd4bc0fd0Var.matches(c);
    }

    public static void QScwEFJhQbXmeWGl(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.createTempBuffer();
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (crQuGnCfbuwLOVOc(pd4bc0fd0Var, '/')) {
            qScwEFJhQbXmeWGl(p9abb1f36Var);
            GnIKPQUVeGquVoev(p9abb1f36Var, fcb6e5623);
        } else {
            EfUJNFEvHjzhKTay(p9abb1f36Var, '<');
            afOmjogeArDnXGQv(p9abb1f36Var, fa48e7494);
        }
    }
}

