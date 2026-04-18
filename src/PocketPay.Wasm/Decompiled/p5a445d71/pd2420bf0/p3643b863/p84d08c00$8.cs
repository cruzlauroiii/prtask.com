namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$8 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$8(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void LZIPUiZmCIGafyqd(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e RVAPodTZgTrEIlGX(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, bool z) {
        return p9abb1f36Var.createTagPending(z);
    }

    public static char WuiEbpwDAfAKhHrZ(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    public static void DRTxTUdFZOwqdNDg(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void EvmWAuyUuBKTOXZk(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void HcArnoEKUumTXkwr(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static bool HyAeenoPPqJwwIQl(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.matchesLetter();
    }

    public static void IfdzYfrbmQBdeHDQ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void OAZgzqNWRISFfSce(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void SloSlRYPuqgBwwtR(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((11 + 19) % 19 > 0) {
        }
        char cWuiEbpwDAfAKhHrZ = WuiEbpwDAfAKhHrZ(pd4bc0fd0Var);
        if (cWuiEbpwDAfAKhHrZ == '!') {
            LZIPUiZmCIGafyqd(p9abb1f36Var, f7b1ceb59);
            return;
        }
        if (cWuiEbpwDAfAKhHrZ == '/') {
            ifdzYfrbmQBdeHDQ(p9abb1f36Var, ff1253c42);
            return;
        }
        if (cWuiEbpwDAfAKhHrZ == '?') {
            oAZgzqNWRISFfSce(p9abb1f36Var, f6c633ddc);
            return;
        }
        if (hyAeenoPPqJwwIQl(pd4bc0fd0Var)) {
            RVAPodTZgTrEIlGX(p9abb1f36Var, true);
            dRTxTUdFZOwqdNDg(p9abb1f36Var, ffe99bb7e);
        } else {
            sloSlRYPuqgBwwtR(p9abb1f36Var, this);
            evmWAuyUuBKTOXZk(p9abb1f36Var, '<');
            hcArnoEKUumTXkwr(p9abb1f36Var, ff6068daa);
        }
    }
}

