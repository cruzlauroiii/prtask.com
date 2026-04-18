namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$7 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$7(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void CMXkbsCNLDdIoFAn(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void EjpOYoVFzwTyyamc(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static java.lang.string HwFAQKwkMNTCBmeU(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char c) {
        return pd4bc0fd0Var.consumeTo(c);
    }

    public static char QAjxDtmtTSJeAOlN(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    public static void EUkOjDgbxjBlJtuJ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        p9abb1f36Var.emit(p459a6f79Var);
    }

    public static void PuKanQiKotSbSMES(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.string str) {
        p9abb1f36Var.emit(str);
    }

    public static void YrtenzluWHKOfvFJ(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        pd4bc0fd0Var.advance();
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        char cQAjxDtmtTSJeAOlN = QAjxDtmtTSJeAOlN(pd4bc0fd0Var);
        if (cQAjxDtmtTSJeAOlN == 0) {
            EjpOYoVFzwTyyamc(p9abb1f36Var, this);
            yrtenzluWHKOfvFJ(pd4bc0fd0Var);
            CMXkbsCNLDdIoFAn(p9abb1f36Var, (char) 65533);
        } else if (cQAjxDtmtTSJeAOlN == 65535) {
            eUkOjDgbxjBlJtuJ(p9abb1f36Var, new p5a445d71.pd2420bf0.p3643b863.p459a6f79$p4423718c());
        } else {
            puKanQiKotSbSMES(p9abb1f36Var, HwFAQKwkMNTCBmeU(pd4bc0fd0Var, (char) 0));
        }
    }
}

