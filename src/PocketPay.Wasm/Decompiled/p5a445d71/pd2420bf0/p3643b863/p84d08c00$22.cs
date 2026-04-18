namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$22 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$22(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void CHezflJDXIOKYBio(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        pd4bc0fd0Var.advance();
    }

    public static void FlEQhbfjdStVHwFN(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void GfUetSSPukzxjTdb(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.string str) {
        p9abb1f36Var.emit(str);
    }

    public static void OYFwvNxJxIMAhaQv(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static char PPSxLMJpxEBvInlV(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    public static void RoWzonPAoGGCExAm(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void ToANSOTxyoyAMXOR(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void GVYnshoovdddXfat(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static bool HRJHwyRsobxlNEiM(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.Count == 0;
    }

    public static java.lang.string KTisbAivlvkwyORo(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char[] cArr) {
        return pd4bc0fd0Var.consumeToAny(cArr);
    }

    public static void LZPnfJaErPUQDOnF(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void TAEwHcEtlclVVmLQ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (hRJHwyRsobxlNEiM(pd4bc0fd0Var)) {
            lZPnfJaErPUQDOnF(p9abb1f36Var, this);
            FlEQhbfjdStVHwFN(p9abb1f36Var, ff6068daa);
            return;
        }
        char cPPSxLMJpxEBvInlV = PPSxLMJpxEBvInlV(pd4bc0fd0Var);
        if (cPPSxLMJpxEBvInlV == 0) {
            OYFwvNxJxIMAhaQv(p9abb1f36Var, this);
            CHezflJDXIOKYBio(pd4bc0fd0Var);
            gVYnshoovdddXfat(p9abb1f36Var, (char) 65533);
        } else if (cPPSxLMJpxEBvInlV == '-') {
            ToANSOTxyoyAMXOR(p9abb1f36Var, '-');
            RoWzonPAoGGCExAm(p9abb1f36Var, fc6448d40);
        } else if (cPPSxLMJpxEBvInlV == '<') {
            tAEwHcEtlclVVmLQ(p9abb1f36Var, fb76a2a32);
        } else {
            GfUetSSPukzxjTdb(p9abb1f36Var, kTisbAivlvkwyORo(pd4bc0fd0Var, new char[]{'-', '<', 0}));
        }
    }
}

