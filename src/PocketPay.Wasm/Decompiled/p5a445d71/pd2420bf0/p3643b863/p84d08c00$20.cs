namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$20 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$20(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static bool OgJVOPCEhVRQTWvw(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char c) {
        return pd4bc0fd0Var.matches(c);
    }

    public static void WqDZpuCUaRGptKtw(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void CgoIflGBxpJmiQOA(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void ETzgQUmOmhfDBvFT(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (!OgJVOPCEhVRQTWvw(pd4bc0fd0Var, '-')) {
            cgoIflGBxpJmiQOA(p9abb1f36Var, f6d75cd7a);
        } else {
            eTzgQUmOmhfDBvFT(p9abb1f36Var, '-');
            WqDZpuCUaRGptKtw(p9abb1f36Var, f379df6fa);
        }
    }
}

