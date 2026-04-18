namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$42 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$42(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void RzlCABOWfBBTeGku(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void TnmYJVHHiSbwXVmq(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitTagPending();
    }

    public static void VuJyTLTUKEjXrARB(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void WXJarmGzWRYsKnJl(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        pd4bc0fd0Var.unconsume();
    }

    public static void YTymuzTDOJYoHqjb(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void EsxquFNXNsRtoWFF(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void OMVjWffssDfILExj(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static char WlVbPlyaIIyDXTXe(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((11 + 11) % 11 > 0) {
        }
        char cWlVbPlyaIIyDXTXe = wlVbPlyaIIyDXTXe(pd4bc0fd0Var);
        if (cWlVbPlyaIIyDXTXe == '>') {
            p9abb1f36Var.fe69d4caa.f5ff907dd = true;
            TnmYJVHHiSbwXVmq(p9abb1f36Var);
            YTymuzTDOJYoHqjb(p9abb1f36Var, ff6068daa);
        } else if (cWlVbPlyaIIyDXTXe == 65535) {
            RzlCABOWfBBTeGku(p9abb1f36Var, this);
            VuJyTLTUKEjXrARB(p9abb1f36Var, ff6068daa);
        } else {
            oMVjWffssDfILExj(p9abb1f36Var, this);
            WXJarmGzWRYsKnJl(pd4bc0fd0Var);
            esxquFNXNsRtoWFF(p9abb1f36Var, f9c983841);
        }
    }
}

