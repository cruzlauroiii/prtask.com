namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$54 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$54(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void AwaQJbUuJJxXfoxo(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void DrHjyaVPDhOwjPSA(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void MPMGnUAEaTpfVcXx(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        pd4bc0fd0Var.advance();
    }

    public static void OoRUfFzBeEgBDZnN(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void ROLgTLWiUHJDttWE(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static bool BYLGKThOiItOEezZ(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, java.lang.string str) {
        return pd4bc0fd0Var.matchConsumeIgnoreCase(str);
    }

    public static void HAIDcXcRGmOUmjfw(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void HTdHaaYAmPZtfAVl(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static bool JNhPaJbOLRODcjUF(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.Count == 0;
    }

    public static void JcNfrdIkexiRZJsY(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static bool MWIazZKyTVgJvxrN(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, java.lang.string str) {
        return pd4bc0fd0Var.matchConsumeIgnoreCase(str);
    }

    public static void OlXtrqCZbgDZbjWv(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static bool QeBpsraxkkqppdFj(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char c) {
        return pd4bc0fd0Var.matches(c);
    }

    public static java.lang.string SeGwSJqOMjlOrQLo(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static void TEeDhKrNtpUQOArv(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static java.lang.string UPWxcyFHpTnrWNpZ(java.lang.string str) {
        return com.decryptstringmanager.Decryptstring.decryptstring(str);
    }

    public static bool UoosgkPPrhqlhyAc(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char[] cArr) {
        return pd4bc0fd0Var.matchesAny(cArr);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((1 + 15) % 15 > 0) {
        }
        if (jNhPaJbOLRODcjUF(pd4bc0fd0Var)) {
            hAIDcXcRGmOUmjfw(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            DrHjyaVPDhOwjPSA(p9abb1f36Var);
            AwaQJbUuJJxXfoxo(p9abb1f36Var, ff6068daa);
            return;
        }
        if (uoosgkPPrhqlhyAc(pd4bc0fd0Var, new char[]{'\t', '\n', '\r', '\f', ' '})) {
            MPMGnUAEaTpfVcXx(pd4bc0fd0Var);
            return;
        }
        if (qeBpsraxkkqppdFj(pd4bc0fd0Var, '>')) {
            olXtrqCZbgDZbjWv(p9abb1f36Var);
            OoRUfFzBeEgBDZnN(p9abb1f36Var, ff6068daa);
            return;
        }
        java.lang.string strUPWxcyFHpTnrWNpZ = uPWxcyFHpTnrWNpZ("832222d9d692cd7f4b94b4589d800ae98abcb05b45ebfd16d562000a175b0728c4c4");
        if (bYLGKThOiItOEezZ(pd4bc0fd0Var, strUPWxcyFHpTnrWNpZ)) {
            p9abb1f36Var.f147a911a.fed49193a = strUPWxcyFHpTnrWNpZ;
            tEeDhKrNtpUQOArv(p9abb1f36Var, f06325115);
            return;
        }
        java.lang.string strSeGwSJqOMjlOrQLo = seGwSJqOMjlOrQLo("4495c235e2f42eeacd436910a359db77b6520c0c912340ee1e8bd69d88b6a48c378a");
        if (mWIazZKyTVgJvxrN(pd4bc0fd0Var, strSeGwSJqOMjlOrQLo)) {
            p9abb1f36Var.f147a911a.fed49193a = strSeGwSJqOMjlOrQLo;
            jcNfrdIkexiRZJsY(p9abb1f36Var, f54f5e5d3);
        } else {
            hTdHaaYAmPZtfAVl(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            ROLgTLWiUHJDttWE(p9abb1f36Var, f102e6000);
        }
    }
}

