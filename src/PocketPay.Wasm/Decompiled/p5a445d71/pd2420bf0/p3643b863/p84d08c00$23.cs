namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$23 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$23(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void AsfRdsXGarVIgMhs(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void ESQmDhhPAedTwMcu(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void KqDZRYSjWIUydoLl(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void NcmwPXwvUZEzmiUJ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void PuEXVzPcioikSwSr(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void HpuCeMiNedeYqBBq(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static char IXpAxQShkViWTFof(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void MhNltvQkdjuumPRw(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void OGGxtaLRtymLMZzo(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static bool VXDwstVISjLbqFDv(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.Count == 0;
    }

    public static void WNAfQiapwPWbChZL(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void WinwbWteqkuPtUAE(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (vXDwstVISjLbqFDv(pd4bc0fd0Var)) {
            KqDZRYSjWIUydoLl(p9abb1f36Var, this);
            oGGxtaLRtymLMZzo(p9abb1f36Var, ff6068daa);
            return;
        }
        char cIXpAxQShkViWTFof = iXpAxQShkViWTFof(pd4bc0fd0Var);
        if (cIXpAxQShkViWTFof == 0) {
            NcmwPXwvUZEzmiUJ(p9abb1f36Var, this);
            winwbWteqkuPtUAE(p9abb1f36Var, (char) 65533);
            mhNltvQkdjuumPRw(p9abb1f36Var, f4abfd16e);
        } else if (cIXpAxQShkViWTFof == '-') {
            ESQmDhhPAedTwMcu(p9abb1f36Var, cIXpAxQShkViWTFof);
            wNAfQiapwPWbChZL(p9abb1f36Var, f3fafc927);
        } else if (cIXpAxQShkViWTFof == '<') {
            PuEXVzPcioikSwSr(p9abb1f36Var, fb76a2a32);
        } else {
            hpuCeMiNedeYqBBq(p9abb1f36Var, cIXpAxQShkViWTFof);
            AsfRdsXGarVIgMhs(p9abb1f36Var, f4abfd16e);
        }
    }
}

