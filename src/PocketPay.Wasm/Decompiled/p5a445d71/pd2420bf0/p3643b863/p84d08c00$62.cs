namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$62 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$62(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void MjODkGdZTPDiSIuu(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static char RrjyEAuJOiqKlxPN(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void DNAXzCPEZygYJVFE(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void DNjRtUFkgLrnkXUb(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void EUPZtygYMnRTnpJR(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void FRXwWwZfJppXNsYv(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void JRXmCCuyTbRiEhdn(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void PoJSbyMRuTJfcJDT(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void QCejUcBGCfuXTMsA(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void SoKapNfILALimZhD(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void TZRjjcqOstAsRTxi(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((13 + 7) % 7 > 0) {
        }
        char cRrjyEAuJOiqKlxPN = RrjyEAuJOiqKlxPN(pd4bc0fd0Var);
        if (cRrjyEAuJOiqKlxPN == '\t' || cRrjyEAuJOiqKlxPN == '\n' || cRrjyEAuJOiqKlxPN == '\f' || cRrjyEAuJOiqKlxPN == '\r' || cRrjyEAuJOiqKlxPN == ' ') {
            return;
        }
        if (cRrjyEAuJOiqKlxPN == '\"') {
            MjODkGdZTPDiSIuu(p9abb1f36Var, f32ddd298);
            return;
        }
        if (cRrjyEAuJOiqKlxPN == '\'') {
            fRXwWwZfJppXNsYv(p9abb1f36Var, f521d5b7b);
            return;
        }
        if (cRrjyEAuJOiqKlxPN == '>') {
            tZRjjcqOstAsRTxi(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            dNAXzCPEZygYJVFE(p9abb1f36Var);
            dNjRtUFkgLrnkXUb(p9abb1f36Var, ff6068daa);
            return;
        }
        if (cRrjyEAuJOiqKlxPN != 65535) {
            poJSbyMRuTJfcJDT(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            qCejUcBGCfuXTMsA(p9abb1f36Var, f102e6000);
        } else {
            soKapNfILALimZhD(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            eUPZtygYMnRTnpJR(p9abb1f36Var);
            jRXmCCuyTbRiEhdn(p9abb1f36Var, ff6068daa);
        }
    }
}

