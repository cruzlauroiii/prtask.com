namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$26 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$26(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static bool GdvkVNFAqjPAJxPP(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.matchesLetter();
    }

    public static void QwDNQUrCmZxqMKOe(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void JGiIzLxtwBCzJXCZ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static char KcIFYMuHQArQTceK(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    public static char KqclPLregKTpXGPr(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    public static p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e mBZsoHAhuzNsmESA(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, bool z) {
        return p9abb1f36Var.createTagPending(z);
    }

    public static void QkLbKbAVgolRVKhM(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, char c) {
        p459a6f79_pc101058e.appendTagName(c);
    }

    public static java.lang.stringBuilder SAJZEpgtusdQnGZN(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void TXXskbhgjKaiCNAg(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.string str) {
        p9abb1f36Var.emit(str);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (!GdvkVNFAqjPAJxPP(pd4bc0fd0Var)) {
            tXXskbhgjKaiCNAg(p9abb1f36Var, "</");
            jGiIzLxtwBCzJXCZ(p9abb1f36Var, f4abfd16e);
        } else {
            mBZsoHAhuzNsmESA(p9abb1f36Var, false);
            qkLbKbAVgolRVKhM(p9abb1f36Var.fe69d4caa, kqclPLregKTpXGPr(pd4bc0fd0Var));
            sAJZEpgtusdQnGZN(p9abb1f36Var.f2aea0929, kcIFYMuHQArQTceK(pd4bc0fd0Var));
            QwDNQUrCmZxqMKOe(p9abb1f36Var, f40c43328);
        }
    }
}

