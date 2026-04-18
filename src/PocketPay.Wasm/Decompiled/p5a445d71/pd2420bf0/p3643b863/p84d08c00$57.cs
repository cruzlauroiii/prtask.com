namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$57 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$57(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.stringBuilder CGWwRYLbiCdRGJHW(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void ISYyiSEbLIDKqliM(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void MlWMGtjEMTCfcwrm(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static char RqqjhPZxOCtXUFGL(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void UnjmfAAPraOdawXb(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void XszxcoTjQwZYqVul(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void FgQSpjjeUxnjkKLB(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void MybQuiACSTdgNUId(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void NJlCtirmGCfckyCV(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static java.lang.stringBuilder WMOdGuGWYEbPBDpT(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void YAhvgQNYpmafjMtC(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((32 + 3) % 3 > 0) {
        }
        char cRqqjhPZxOCtXUFGL = RqqjhPZxOCtXUFGL(pd4bc0fd0Var);
        if (cRqqjhPZxOCtXUFGL == 0) {
            yAhvgQNYpmafjMtC(p9abb1f36Var, this);
            wMOdGuGWYEbPBDpT(p9abb1f36Var.f147a911a.f88084d9a, (char) 65533);
            return;
        }
        if (cRqqjhPZxOCtXUFGL == '\"') {
            UnjmfAAPraOdawXb(p9abb1f36Var, f909bbffd);
            return;
        }
        if (cRqqjhPZxOCtXUFGL == '>') {
            mybQuiACSTdgNUId(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            nJlCtirmGCfckyCV(p9abb1f36Var);
            fgQSpjjeUxnjkKLB(p9abb1f36Var, ff6068daa);
            return;
        }
        if (cRqqjhPZxOCtXUFGL != 65535) {
            CGWwRYLbiCdRGJHW(p9abb1f36Var.f147a911a.f88084d9a, cRqqjhPZxOCtXUFGL);
            return;
        }
        MlWMGtjEMTCfcwrm(p9abb1f36Var, this);
        p9abb1f36Var.f147a911a.fc352559f = true;
        ISYyiSEbLIDKqliM(p9abb1f36Var);
        XszxcoTjQwZYqVul(p9abb1f36Var, ff6068daa);
    }
}

