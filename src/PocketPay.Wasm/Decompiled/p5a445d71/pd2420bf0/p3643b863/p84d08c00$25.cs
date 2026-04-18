namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$25 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$25(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void DTjOJTzZkTLUPYRX(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.createTempBuffer();
    }

    public static java.lang.string GxWSUDMWAwOGlfqL(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JXAWwtrYaWJKGNSe(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void KtNNLJuZACkyfdzv(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static char RrvyECoCgdZXmifu(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    public static void UucbNJOLLGNjBOgV(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.string str) {
        p9abb1f36Var.emit(str);
    }

    public static char VhjDKXCSKuinLLhU(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    public static void XqDqHRHnZBMvIWfE(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static bool EkYvspFizangpuEU(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char c) {
        return pd4bc0fd0Var.matches(c);
    }

    public static bool NTLovjMjsBLDJogI(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.matchesLetter();
    }

    public static void PkzcnviyjIjONYsm(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void SHtATTzCFFndhDLt(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.createTempBuffer();
    }

    public static java.lang.stringBuilder TkYwNxbtkshxhJtO(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder UuSSqMFscXDpRVnf(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (nTLovjMjsBLDJogI(pd4bc0fd0Var)) {
            DTjOJTzZkTLUPYRX(p9abb1f36Var);
            tkYwNxbtkshxhJtO(p9abb1f36Var.f2aea0929, VhjDKXCSKuinLLhU(pd4bc0fd0Var));
            UucbNJOLLGNjBOgV(p9abb1f36Var, GxWSUDMWAwOGlfqL(uuSSqMFscXDpRVnf(new java.lang.stringBuilder("<"), RrvyECoCgdZXmifu(pd4bc0fd0Var))));
            KtNNLJuZACkyfdzv(p9abb1f36Var, fd0764151);
            return;
        }
        if (ekYvspFizangpuEU(pd4bc0fd0Var, '/')) {
            sHtATTzCFFndhDLt(p9abb1f36Var);
            XqDqHRHnZBMvIWfE(p9abb1f36Var, f13765c42);
        } else {
            pkzcnviyjIjONYsm(p9abb1f36Var, '<');
            JXAWwtrYaWJKGNSe(p9abb1f36Var, f4abfd16e);
        }
    }
}

