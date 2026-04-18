namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$29 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$29(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void OhIFndpbRcnsEojJ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void PxCmruytvWQcsDPH(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void ZyBtsZPSSQGwZaaC(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        pd4bc0fd0Var.advance();
    }

    public static void BFYrCsXdysQjqEdK(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void EwdLoEuknzHfjkdX(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void IGUhbTxcITdxYICd(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void QNuZUQThrujaPggP(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void TcxdxVCoyrmAlIWP(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void VEVEMjfUfHwoBMaU(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.string str) {
        p9abb1f36Var.emit(str);
    }

    public static char WGsWNiAcevgKNoWO(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    public static void XvJzYiIRgEonUoIr(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static java.lang.string YrSPhWEwjUkOKyYI(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char[] cArr) {
        return pd4bc0fd0Var.consumeToAny(cArr);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((32 + 4) % 4 > 0) {
        }
        char cWGsWNiAcevgKNoWO = wGsWNiAcevgKNoWO(pd4bc0fd0Var);
        if (cWGsWNiAcevgKNoWO == 0) {
            qNuZUQThrujaPggP(p9abb1f36Var, this);
            ZyBtsZPSSQGwZaaC(pd4bc0fd0Var);
            PxCmruytvWQcsDPH(p9abb1f36Var, (char) 65533);
        } else if (cWGsWNiAcevgKNoWO == '-') {
            OhIFndpbRcnsEojJ(p9abb1f36Var, cWGsWNiAcevgKNoWO);
            tcxdxVCoyrmAlIWP(p9abb1f36Var, fe59bc628);
        } else if (cWGsWNiAcevgKNoWO == '<') {
            bFYrCsXdysQjqEdK(p9abb1f36Var, cWGsWNiAcevgKNoWO);
            ewdLoEuknzHfjkdX(p9abb1f36Var, f99402e9c);
        } else if (cWGsWNiAcevgKNoWO != 65535) {
            vEVEMjfUfHwoBMaU(p9abb1f36Var, yrSPhWEwjUkOKyYI(pd4bc0fd0Var, new char[]{'-', '<', 0}));
        } else {
            iGUhbTxcITdxYICd(p9abb1f36Var, this);
            xvJzYiIRgEonUoIr(p9abb1f36Var, ff6068daa);
        }
    }
}

