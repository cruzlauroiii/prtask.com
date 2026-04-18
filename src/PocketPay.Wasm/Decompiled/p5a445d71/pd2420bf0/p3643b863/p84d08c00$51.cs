namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$51 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$51(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void LCYUJUhohqYTJjYJ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void PUeBpwyUqDtwEaLY(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static char TbSwqTlOlQwTjgxM(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void XWKtXXOodVpKyfAa(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void DakHvCyiUTxTggVk(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void IOYBhMkodRMaIGVW(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void LhyyOnYPZDJCZlzo(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.createDoctypePending();
    }

    public static void UjfjVQLfSgXbIUHP(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void WJpamlmouMPJtNxQ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        char cTbSwqTlOlQwTjgxM = TbSwqTlOlQwTjgxM(pd4bc0fd0Var);
        if (cTbSwqTlOlQwTjgxM == '\t' || cTbSwqTlOlQwTjgxM == '\n' || cTbSwqTlOlQwTjgxM == '\f' || cTbSwqTlOlQwTjgxM == '\r' || cTbSwqTlOlQwTjgxM == ' ') {
            PUeBpwyUqDtwEaLY(p9abb1f36Var, f4824ae77);
            return;
        }
        if (cTbSwqTlOlQwTjgxM != '>') {
            if (cTbSwqTlOlQwTjgxM != 65535) {
                XWKtXXOodVpKyfAa(p9abb1f36Var, this);
                iOYBhMkodRMaIGVW(p9abb1f36Var, f4824ae77);
                return;
            }
            LCYUJUhohqYTJjYJ(p9abb1f36Var, this);
        }
        dakHvCyiUTxTggVk(p9abb1f36Var, this);
        lhyyOnYPZDJCZlzo(p9abb1f36Var);
        p9abb1f36Var.f147a911a.fc352559f = true;
        ujfjVQLfSgXbIUHP(p9abb1f36Var);
        wJpamlmouMPJtNxQ(p9abb1f36Var, ff6068daa);
    }
}

