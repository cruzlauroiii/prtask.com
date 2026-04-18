namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$41 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$41(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void IdmBlOablLqsMqAj(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void IfLUpJuDgwJAzIOa(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void WlRmBQLEqLNRBfNz(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void BDNvIuuruIzgTocV(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void ClXoeAieFwmOAvqM(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        pd4bc0fd0Var.unconsume();
    }

    public static char GaPorICwoGfXVayw(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void KPRmfxmBnTpwOtuv(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitTagPending();
    }

    public static void PdSDUYiIYjhtCuSj(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void SJdCqsVrzEkepNLu(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void VrPoAnShBdeqQAUl(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((6 + 7) % 7 > 0) {
        }
        char cGaPorICwoGfXVayw = gaPorICwoGfXVayw(pd4bc0fd0Var);
        if (cGaPorICwoGfXVayw == '\t' || cGaPorICwoGfXVayw == '\n' || cGaPorICwoGfXVayw == '\f' || cGaPorICwoGfXVayw == '\r' || cGaPorICwoGfXVayw == ' ') {
            sJdCqsVrzEkepNLu(p9abb1f36Var, f9c983841);
            return;
        }
        if (cGaPorICwoGfXVayw == '/') {
            WlRmBQLEqLNRBfNz(p9abb1f36Var, f4ece3c81);
            return;
        }
        if (cGaPorICwoGfXVayw == '>') {
            kPRmfxmBnTpwOtuv(p9abb1f36Var);
            bDNvIuuruIzgTocV(p9abb1f36Var, ff6068daa);
        } else if (cGaPorICwoGfXVayw == 65535) {
            pdSDUYiIYjhtCuSj(p9abb1f36Var, this);
            vrPoAnShBdeqQAUl(p9abb1f36Var, ff6068daa);
        } else {
            IfLUpJuDgwJAzIOa(p9abb1f36Var, this);
            clXoeAieFwmOAvqM(pd4bc0fd0Var);
            IdmBlOablLqsMqAj(p9abb1f36Var, f9c983841);
        }
    }
}

