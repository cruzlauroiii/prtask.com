namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$38 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$38(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void BNRDXwWYvYnXyBXK(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, char c) {
        p459a6f79_pc101058e.appendAttributeValue(c);
    }

    public static void DqdbFzoSLPbClboH(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static int EAMyrsaKWTDsBvVJ(java.lang.string str) {
        return str.Length;
    }

    public static void GQjCVYsNZzfqxvJe(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e) {
        p459a6f79_pc101058e.setEmptyAttributeValue();
    }

    public static void HRMhlEMuPTFeFWPK(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, char c) {
        p459a6f79_pc101058e.appendAttributeValue(c);
    }

    public static java.lang.string JRJAAwuznLHcgNOl(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char[] cArr) {
        return pd4bc0fd0Var.consumeToAny(cArr);
    }

    public static char KHtvVbjcFamnBXjo(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void QXecSqKNcJwprsjw(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void YmTaWKSmlFoNuOii(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, char c) {
        p459a6f79_pc101058e.appendAttributeValue(c);
    }

    public static void ZbyUzfeMIsJAXtBa(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, int[] iArr) {
        p459a6f79_pc101058e.appendAttributeValue(iArr);
    }

    public static void AouQjBKNhZMdrRxw(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, java.lang.string str) {
        p459a6f79_pc101058e.appendAttributeValue(str);
    }

    public static java.lang.char CFIhXNqtzDpzDoER(char c) {
        return java.lang.char.valueOf(c);
    }

    public static int[] DPGzlRXAfCRnfVfT(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.char ch, bool z) {
        return p9abb1f36Var.consumecharReference(ch, z);
    }

    public static void PbRGeEIsoJyxhuWP(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void UVpSmxhXWoLYplps(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((5 + 2) % 2 > 0) {
        }
        java.lang.string strJRJAAwuznLHcgNOl = JRJAAwuznLHcgNOl(pd4bc0fd0Var, f647ce0f5);
        if (EAMyrsaKWTDsBvVJ(strJRJAAwuznLHcgNOl) <= 0) {
            GQjCVYsNZzfqxvJe(p9abb1f36Var.fe69d4caa);
        } else {
            aouQjBKNhZMdrRxw(p9abb1f36Var.fe69d4caa, strJRJAAwuznLHcgNOl);
        }
        char cKHtvVbjcFamnBXjo = KHtvVbjcFamnBXjo(pd4bc0fd0Var);
        if (cKHtvVbjcFamnBXjo == 0) {
            QXecSqKNcJwprsjw(p9abb1f36Var, this);
            YmTaWKSmlFoNuOii(p9abb1f36Var.fe69d4caa, (char) 65533);
            return;
        }
        if (cKHtvVbjcFamnBXjo == '\"') {
            pbRGeEIsoJyxhuWP(p9abb1f36Var, fcbf4f1fe);
            return;
        }
        if (cKHtvVbjcFamnBXjo == '&') {
            int[] iArrDPGzlRXAfCRnfVfT = dPGzlRXAfCRnfVfT(p9abb1f36Var, cFIhXNqtzDpzDoER('\"'), true);
            if (iArrDPGzlRXAfCRnfVfT is null) {
                BNRDXwWYvYnXyBXK(p9abb1f36Var.fe69d4caa, '&');
                return;
            } else {
                ZbyUzfeMIsJAXtBa(p9abb1f36Var.fe69d4caa, iArrDPGzlRXAfCRnfVfT);
                return;
            }
        }
        if (cKHtvVbjcFamnBXjo != 65535) {
            HRMhlEMuPTFeFWPK(p9abb1f36Var.fe69d4caa, cKHtvVbjcFamnBXjo);
        } else {
            DqdbFzoSLPbClboH(p9abb1f36Var, this);
            uVpSmxhXWoLYplps(p9abb1f36Var, ff6068daa);
        }
    }
}

