namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$53 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$53(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.stringBuilder AzOqVSwelJYkZBvG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static java.lang.string BiKOUDUUPPAqWlch(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consumeLetterSequence();
    }

    public static bool MMeNcFEQqRcJsKZG(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.matchesLetter();
    }

    public static char PKIANEPwxujHlUFp(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void SPQYibnqQcRcEjaq(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void BkFUXBSzGWGmEVdE(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void FNxQEuKtTQEigWdG(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void GwcsqnYiBcZWBrlN(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static java.lang.stringBuilder IfHhnScQpgFMNxwe(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static java.lang.stringBuilder LDYIrYepXyEfkuyy(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void LkssbEfqnFeQRbZd(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void QAYCIdzhrPmMeLJF(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void RNYHuVajQHIBeUnB(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (MMeNcFEQqRcJsKZG(pd4bc0fd0Var)) {
            AzOqVSwelJYkZBvG(p9abb1f36Var.f147a911a.fb068931c, BiKOUDUUPPAqWlch(pd4bc0fd0Var));
            return;
        }
        char cPKIANEPwxujHlUFp = PKIANEPwxujHlUFp(pd4bc0fd0Var);
        if (cPKIANEPwxujHlUFp == 0) {
            SPQYibnqQcRcEjaq(p9abb1f36Var, this);
            lDYIrYepXyEfkuyy(p9abb1f36Var.f147a911a.fb068931c, (char) 65533);
            return;
        }
        if (cPKIANEPwxujHlUFp != ' ') {
            if (cPKIANEPwxujHlUFp == '>') {
                lkssbEfqnFeQRbZd(p9abb1f36Var);
                bkFUXBSzGWGmEVdE(p9abb1f36Var, ff6068daa);
                return;
            }
            if (cPKIANEPwxujHlUFp == 65535) {
                qAYCIdzhrPmMeLJF(p9abb1f36Var, this);
                p9abb1f36Var.f147a911a.fc352559f = true;
                gwcsqnYiBcZWBrlN(p9abb1f36Var);
                rNYHuVajQHIBeUnB(p9abb1f36Var, ff6068daa);
                return;
            }
            if (cPKIANEPwxujHlUFp != '\t' && cPKIANEPwxujHlUFp != '\n' && cPKIANEPwxujHlUFp != '\f' && cPKIANEPwxujHlUFp != '\r') {
                ifHhnScQpgFMNxwe(p9abb1f36Var.f147a911a.fb068931c, cPKIANEPwxujHlUFp);
                return;
            }
        }
        fNxQEuKtTQEigWdG(p9abb1f36Var, f01f177f4);
    }
}

