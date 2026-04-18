namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$32 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$32(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void BPEKBkdWyPPaeGQZ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void LEaaoihHJizkQbag(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.createTempBuffer();
    }

    public static void QMCPSIwWqpORDCSp(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void TEmiJJRYXhaicxkI(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static bool YaqiwbIdLajmcrqT(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char c) {
        return pd4bc0fd0Var.matches(c);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (!yaqiwbIdLajmcrqT(pd4bc0fd0Var, '/')) {
            tEmiJJRYXhaicxkI(p9abb1f36Var, ff645d19f);
            return;
        }
        qMCPSIwWqpORDCSp(p9abb1f36Var, '/');
        lEaaoihHJizkQbag(p9abb1f36Var);
        BPEKBkdWyPPaeGQZ(p9abb1f36Var, fbeb77cad);
    }
}

