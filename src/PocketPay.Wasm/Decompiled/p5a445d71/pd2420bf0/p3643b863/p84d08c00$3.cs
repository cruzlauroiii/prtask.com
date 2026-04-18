namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$3 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$3(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static char GQpxMkDTleLAlWvr(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    public static java.lang.string HAzWsoaXOaBMlgyK(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char[] cArr) {
        return pd4bc0fd0Var.consumeToAny(cArr);
    }

    public static void IajJDPBrfempSYiW(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void JZOvkmkQucqjTBug(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        p9abb1f36Var.emit(p459a6f79Var);
    }

    public static void PiqfFvjnBecgGTzd(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void QOkwWrZtFGQoYjZO(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void AFeMioqWXpXAbRoR(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void INqCsGUlZoTRoVkj(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        pd4bc0fd0Var.advance();
    }

    public static void JFoLDlydgPYgKBll(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.string str) {
        p9abb1f36Var.emit(str);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        char cGQpxMkDTleLAlWvr = GQpxMkDTleLAlWvr(pd4bc0fd0Var);
        if (cGQpxMkDTleLAlWvr == 0) {
            PiqfFvjnBecgGTzd(p9abb1f36Var, this);
            iNqCsGUlZoTRoVkj(pd4bc0fd0Var);
            QOkwWrZtFGQoYjZO(p9abb1f36Var, (char) 65533);
        } else {
            if (cGQpxMkDTleLAlWvr == '&') {
                aFeMioqWXpXAbRoR(p9abb1f36Var, fe091e93e);
                return;
            }
            if (cGQpxMkDTleLAlWvr == '<') {
                IajJDPBrfempSYiW(p9abb1f36Var, f8126add5);
            } else if (cGQpxMkDTleLAlWvr == 65535) {
                JZOvkmkQucqjTBug(p9abb1f36Var, new p5a445d71.pd2420bf0.p3643b863.p459a6f79$p4423718c());
            } else {
                jFoLDlydgPYgKBll(p9abb1f36Var, HAzWsoaXOaBMlgyK(pd4bc0fd0Var, new char[]{'&', '<', 0}));
            }
        }
    }
}

