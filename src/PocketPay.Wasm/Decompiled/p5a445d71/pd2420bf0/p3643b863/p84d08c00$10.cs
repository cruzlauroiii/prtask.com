namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$10 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$10(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void GNsuUKezTFcHOlHc(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, java.lang.string str) {
        p459a6f79_pc101058e.appendTagName(str);
    }

    public static void IhPnFKhqklxMaqyD(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static char MzfGVSwRcXLAQwkQ(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static java.lang.string NiOkTCVpXlAAJBzF() {
        return p5a445d71.pd2420bf0.p3643b863.p84d08c00.access$300();
    }

    public static void PNRngkMUxnwdqHVS(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void UPkNpQuZCtinMRQo(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void UfxUdjYmDZjXXnlJ(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, java.lang.string str) {
        p459a6f79_pc101058e.appendTagName(str);
    }

    public static void VChKtdBHsJtFjAfy(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, char c) {
        p459a6f79_pc101058e.appendTagName(c);
    }

    public static void YFNgdFDVHGeQGDot(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitTagPending();
    }

    public static java.lang.string YFyzFXmYOdcSjTJI(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consumeTagName();
    }

    public static void AZVTnHwJAbJwOrXe(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void MwxuJWgwoRAwZWGV(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((2 + 5) % 5 > 0) {
        }
        UfxUdjYmDZjXXnlJ(p9abb1f36Var.fe69d4caa, YFyzFXmYOdcSjTJI(pd4bc0fd0Var));
        char cMzfGVSwRcXLAQwkQ = MzfGVSwRcXLAQwkQ(pd4bc0fd0Var);
        if (cMzfGVSwRcXLAQwkQ == 0) {
            GNsuUKezTFcHOlHc(p9abb1f36Var.fe69d4caa, NiOkTCVpXlAAJBzF());
            return;
        }
        if (cMzfGVSwRcXLAQwkQ != ' ') {
            if (cMzfGVSwRcXLAQwkQ == '/') {
                IhPnFKhqklxMaqyD(p9abb1f36Var, f4ece3c81);
                return;
            }
            if (cMzfGVSwRcXLAQwkQ == '>') {
                YFNgdFDVHGeQGDot(p9abb1f36Var);
                PNRngkMUxnwdqHVS(p9abb1f36Var, ff6068daa);
                return;
            } else if (cMzfGVSwRcXLAQwkQ == 65535) {
                mwxuJWgwoRAwZWGV(p9abb1f36Var, this);
                aZVTnHwJAbJwOrXe(p9abb1f36Var, ff6068daa);
                return;
            } else if (cMzfGVSwRcXLAQwkQ != '\t' && cMzfGVSwRcXLAQwkQ != '\n' && cMzfGVSwRcXLAQwkQ != '\f' && cMzfGVSwRcXLAQwkQ != '\r') {
                VChKtdBHsJtFjAfy(p9abb1f36Var.fe69d4caa, cMzfGVSwRcXLAQwkQ);
                return;
            }
        }
        UPkNpQuZCtinMRQo(p9abb1f36Var, f9c983841);
    }
}

