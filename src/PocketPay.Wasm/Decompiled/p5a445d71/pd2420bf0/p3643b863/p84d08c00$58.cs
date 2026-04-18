namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$58 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$58(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void BUmRWEbryIuvjnfi(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void DNsriXwSLTbUaSCf(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void HTjKTRGztbEnBRsZ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void JKuqwQxhNyjFDtlB(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void JMwPBNaQBgkilXjV(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static java.lang.stringBuilder PxAnTPkOUsCXvXLD(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void XArKrAuSiDdADWIC(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static char XOMKDYkMaJklEuGu(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void EkImWVObrfDaNXNO(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void KgnqequKgkzUgMev(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static java.lang.stringBuilder ZEfksCkgTtDGKQTQ(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((14 + 20) % 20 > 0) {
        }
        char cXOMKDYkMaJklEuGu = XOMKDYkMaJklEuGu(pd4bc0fd0Var);
        if (cXOMKDYkMaJklEuGu == 0) {
            XArKrAuSiDdADWIC(p9abb1f36Var, this);
            PxAnTPkOUsCXvXLD(p9abb1f36Var.f147a911a.f88084d9a, (char) 65533);
            return;
        }
        if (cXOMKDYkMaJklEuGu == '\'') {
            kgnqequKgkzUgMev(p9abb1f36Var, f909bbffd);
            return;
        }
        if (cXOMKDYkMaJklEuGu == '>') {
            DNsriXwSLTbUaSCf(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            BUmRWEbryIuvjnfi(p9abb1f36Var);
            JKuqwQxhNyjFDtlB(p9abb1f36Var, ff6068daa);
            return;
        }
        if (cXOMKDYkMaJklEuGu != 65535) {
            zEfksCkgTtDGKQTQ(p9abb1f36Var.f147a911a.f88084d9a, cXOMKDYkMaJklEuGu);
            return;
        }
        JMwPBNaQBgkilXjV(p9abb1f36Var, this);
        p9abb1f36Var.f147a911a.fc352559f = true;
        ekImWVObrfDaNXNO(p9abb1f36Var);
        HTjKTRGztbEnBRsZ(p9abb1f36Var, ff6068daa);
    }
}

