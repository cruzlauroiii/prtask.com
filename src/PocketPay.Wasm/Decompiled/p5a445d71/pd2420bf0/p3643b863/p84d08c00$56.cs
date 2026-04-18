namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$56 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$56(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void GZdFYdnyQBjfAjpX(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void KndiSkkRMIyDHIdM(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void LXwnmNiSYhqFSrKG(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void RwfPFufVyJiqYLfb(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void XrTGSPqoTfhjKmVJ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void XyAlOoUcSzwVRvep(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static char YcVceThJhbQFcXkA(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void ZvcomzDscnUWErWY(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void ILcCxFFJWsPmCSDO(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void KkWDABCNajnKIMks(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void SgXHFtkRGoFKQjrd(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((28 + 19) % 19 > 0) {
        }
        char cYcVceThJhbQFcXkA = YcVceThJhbQFcXkA(pd4bc0fd0Var);
        if (cYcVceThJhbQFcXkA == '\t' || cYcVceThJhbQFcXkA == '\n' || cYcVceThJhbQFcXkA == '\f' || cYcVceThJhbQFcXkA == '\r' || cYcVceThJhbQFcXkA == ' ') {
            return;
        }
        if (cYcVceThJhbQFcXkA == '\"') {
            LXwnmNiSYhqFSrKG(p9abb1f36Var, f989190f8);
            return;
        }
        if (cYcVceThJhbQFcXkA == '\'') {
            sgXHFtkRGoFKQjrd(p9abb1f36Var, fff58e899);
            return;
        }
        if (cYcVceThJhbQFcXkA == '>') {
            RwfPFufVyJiqYLfb(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            ZvcomzDscnUWErWY(p9abb1f36Var);
            XyAlOoUcSzwVRvep(p9abb1f36Var, ff6068daa);
            return;
        }
        if (cYcVceThJhbQFcXkA != 65535) {
            GZdFYdnyQBjfAjpX(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            kkWDABCNajnKIMks(p9abb1f36Var, f102e6000);
        } else {
            iLcCxFFJWsPmCSDO(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            XrTGSPqoTfhjKmVJ(p9abb1f36Var);
            KndiSkkRMIyDHIdM(p9abb1f36Var, ff6068daa);
        }
    }
}

