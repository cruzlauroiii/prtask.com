namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$1 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$1(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void DVjRZeCVBSPOfvpn(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static char EJbaBjJGCFwOljcj(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void HKEnHpCxfjAisyeI(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void QMkulhVDStkrlDUh(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static java.lang.string SWaAEPjhmktJoFZy(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consumeData();
    }

    public static void CvDxGgbuWVRXkYxb(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p459a6f79 p459a6f79Var) {
        p9abb1f36Var.emit(p459a6f79Var);
    }

    public static void HmahkKykEmomupWA(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.string str) {
        p9abb1f36Var.emit(str);
    }

    public static void UhZYQRaEPmRuEpMS(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static char VPMgBKrkMuJmsjrC(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        char cVPMgBKrkMuJmsjrC = vPMgBKrkMuJmsjrC(pd4bc0fd0Var);
        if (cVPMgBKrkMuJmsjrC == 0) {
            uhZYQRaEPmRuEpMS(p9abb1f36Var, this);
            HKEnHpCxfjAisyeI(p9abb1f36Var, EJbaBjJGCFwOljcj(pd4bc0fd0Var));
        } else {
            if (cVPMgBKrkMuJmsjrC == '&') {
                QMkulhVDStkrlDUh(p9abb1f36Var, f71bfb8e6);
                return;
            }
            if (cVPMgBKrkMuJmsjrC == '<') {
                DVjRZeCVBSPOfvpn(p9abb1f36Var, f0eb3adf9);
            } else if (cVPMgBKrkMuJmsjrC == 65535) {
                cvDxGgbuWVRXkYxb(p9abb1f36Var, new p5a445d71.pd2420bf0.p3643b863.p459a6f79$p4423718c());
            } else {
                hmahkKykEmomupWA(p9abb1f36Var, SWaAEPjhmktJoFZy(pd4bc0fd0Var));
            }
        }
    }
}

