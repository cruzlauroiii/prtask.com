namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$63 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$63(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static char ILldRPtTYfGDwggH(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void JjDFGETlDhjKJwZE(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void MsEwjioqnYiWhEmp(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void RNJkipLbggfguHtd(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void JrDezuJkFjtTPydY(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void MLyIZAdEktEeDRDK(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void MWCDwcAbFUQcNkIx(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void OpXKQmOrMfZkqIoD(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static java.lang.stringBuilder QbQwbDKsBfThDtFW(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder RhFZjMSggSAiwKTw(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void XGzhMoLcaFklXqCF(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((25 + 7) % 7 > 0) {
        }
        char cILldRPtTYfGDwggH = ILldRPtTYfGDwggH(pd4bc0fd0Var);
        if (cILldRPtTYfGDwggH == 0) {
            mLyIZAdEktEeDRDK(p9abb1f36Var, this);
            rhFZjMSggSAiwKTw(p9abb1f36Var.f147a911a.ffc80dffa, (char) 65533);
            return;
        }
        if (cILldRPtTYfGDwggH == '\"') {
            mWCDwcAbFUQcNkIx(p9abb1f36Var, f019952b5);
            return;
        }
        if (cILldRPtTYfGDwggH == '>') {
            MsEwjioqnYiWhEmp(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            xGzhMoLcaFklXqCF(p9abb1f36Var);
            JjDFGETlDhjKJwZE(p9abb1f36Var, ff6068daa);
            return;
        }
        if (cILldRPtTYfGDwggH != 65535) {
            qbQwbDKsBfThDtFW(p9abb1f36Var.f147a911a.ffc80dffa, cILldRPtTYfGDwggH);
            return;
        }
        opXKQmOrMfZkqIoD(p9abb1f36Var, this);
        p9abb1f36Var.f147a911a.fc352559f = true;
        jrDezuJkFjtTPydY(p9abb1f36Var);
        RNJkipLbggfguHtd(p9abb1f36Var, ff6068daa);
    }
}

