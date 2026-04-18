namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$47 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$47(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.stringBuilder CwbzJeOcJltTwsYJ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void DQREApVUvUrNaTJK(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static java.lang.string NYkrXFmcTHRxDgWE(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char[] cArr) {
        return pd4bc0fd0Var.consumeToAny(cArr);
    }

    public static java.lang.stringBuilder NvQTUpKRAvWsBrQI(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static char WrUNaPqVGMGYvAAs(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    public static void CvPvOsXVxmmhifIR(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void JUiRFwVdClLTWQrH(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void NtQCIiBgOMvlNQBy(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        pd4bc0fd0Var.advance();
    }

    public static void SkvfIakuXtWtAJEG(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitCommentPending();
    }

    public static void XcZygzZLCaoZsoPW(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((10 + 10) % 10 > 0) {
        }
        char cWrUNaPqVGMGYvAAs = WrUNaPqVGMGYvAAs(pd4bc0fd0Var);
        if (cWrUNaPqVGMGYvAAs == 0) {
            jUiRFwVdClLTWQrH(p9abb1f36Var, this);
            ntQCIiBgOMvlNQBy(pd4bc0fd0Var);
            CwbzJeOcJltTwsYJ(p9abb1f36Var.f8695e16d.f8d777f38, (char) 65533);
        } else if (cWrUNaPqVGMGYvAAs == '-') {
            xcZygzZLCaoZsoPW(p9abb1f36Var, f10c201ca);
        } else {
            if (cWrUNaPqVGMGYvAAs != 65535) {
                NvQTUpKRAvWsBrQI(p9abb1f36Var.f8695e16d.f8d777f38, NYkrXFmcTHRxDgWE(pd4bc0fd0Var, new char[]{'-', 0}));
                return;
            }
            DQREApVUvUrNaTJK(p9abb1f36Var, this);
            skvfIakuXtWtAJEG(p9abb1f36Var);
            cvPvOsXVxmmhifIR(p9abb1f36Var, ff6068daa);
        }
    }
}

