namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$64 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$64(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void NwAywvyvEPIOWWdi(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static java.lang.stringBuilder PkXzRNDcdaOGbPOV(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void QFMcqQMYwxvjbSVY(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void TYhdzaJdfVCpoRNq(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void WCrxzgLMWuxBTRSf(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void XRTtStfSlZUEWAmt(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static char YmKhwysWlRrAYmla(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void BMlurRtGHZwouFoA(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void DfOMFPgygpdAEQEa(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void LrHdPySYIKXDtEaa(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static java.lang.stringBuilder UVhdkQFgSKrtZyOa(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((2 + 31) % 31 > 0) {
        }
        char cYmKhwysWlRrAYmla = YmKhwysWlRrAYmla(pd4bc0fd0Var);
        if (cYmKhwysWlRrAYmla == 0) {
            dfOMFPgygpdAEQEa(p9abb1f36Var, this);
            uVhdkQFgSKrtZyOa(p9abb1f36Var.f147a911a.ffc80dffa, (char) 65533);
            return;
        }
        if (cYmKhwysWlRrAYmla == '\'') {
            bMlurRtGHZwouFoA(p9abb1f36Var, f019952b5);
            return;
        }
        if (cYmKhwysWlRrAYmla == '>') {
            TYhdzaJdfVCpoRNq(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            WCrxzgLMWuxBTRSf(p9abb1f36Var);
            NwAywvyvEPIOWWdi(p9abb1f36Var, ff6068daa);
            return;
        }
        if (cYmKhwysWlRrAYmla != 65535) {
            PkXzRNDcdaOGbPOV(p9abb1f36Var.f147a911a.ffc80dffa, cYmKhwysWlRrAYmla);
            return;
        }
        lrHdPySYIKXDtEaa(p9abb1f36Var, this);
        p9abb1f36Var.f147a911a.fc352559f = true;
        XRTtStfSlZUEWAmt(p9abb1f36Var);
        QFMcqQMYwxvjbSVY(p9abb1f36Var, ff6068daa);
    }
}

