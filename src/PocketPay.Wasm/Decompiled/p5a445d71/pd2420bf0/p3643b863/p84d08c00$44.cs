namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$44 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$44(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void AyYIQlhKqnTywaLi(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static bool KobZsuZorDNhynjE(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, java.lang.string str) {
        return pd4bc0fd0Var.matchConsume(str);
    }

    public static void KtCVBhHAmbBHukab(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.createCommentPending();
    }

    public static void WrmYsGiFYQCWMBRK(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static bool QBUxxksqFFiErSME(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, java.lang.string str) {
        return pd4bc0fd0Var.matchConsumeIgnoreCase(str);
    }

    public static void VJWtkSQPoKmFKUZs(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static bool VTeYKvbAEzHphlHL(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, java.lang.string str) {
        return pd4bc0fd0Var.matchConsume(str);
    }

    public static void ViydrKkeLtBYxJez(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.createTempBuffer();
    }

    public static void YFbtBunSFNUwfteO(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void ZwofywlyRcOgbBoE(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (KobZsuZorDNhynjE(pd4bc0fd0Var, "--")) {
            KtCVBhHAmbBHukab(p9abb1f36Var);
            WrmYsGiFYQCWMBRK(p9abb1f36Var, fd7686627);
        } else if (qBUxxksqFFiErSME(pd4bc0fd0Var, "DOCTYPE")) {
            yFbtBunSFNUwfteO(p9abb1f36Var, f5b4d577e);
        } else if (vTeYKvbAEzHphlHL(pd4bc0fd0Var, "[CDATA[")) {
            viydrKkeLtBYxJez(p9abb1f36Var);
            AyYIQlhKqnTywaLi(p9abb1f36Var, f57008f9f);
        } else {
            vJWtkSQPoKmFKUZs(p9abb1f36Var, this);
            zwofywlyRcOgbBoE(p9abb1f36Var, f6c633ddc);
        }
    }
}

