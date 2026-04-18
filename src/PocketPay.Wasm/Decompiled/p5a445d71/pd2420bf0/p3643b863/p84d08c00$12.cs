namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$12 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$12(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static bool AjWEINUIPzvLjRLy(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.matchesLetter();
    }

    public static void HVVGWkSFDDlFQBMf(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.string str) {
        p9abb1f36Var.emit(str);
    }

    public static char JkMXddnvfgqCVMqs(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    public static char WazDFnegqrQmovJl(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.current();
    }

    public static void DQQhImrOpikEFNIX(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, char c) {
        p459a6f79_pc101058e.appendTagName(c);
    }

    public static void GsoEOAqYCeMgXGCu(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static java.lang.stringBuilder TvSyYzYmYjDMObou(java.lang.stringBuilder sb, char c) {
        return sb.append(c);
    }

    public static void VfghqsLEZHUaJBYF(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e zPjPPzslgtzuxisc(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, bool z) {
        return p9abb1f36Var.createTagPending(z);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (!AjWEINUIPzvLjRLy(pd4bc0fd0Var)) {
            HVVGWkSFDDlFQBMf(p9abb1f36Var, "</");
            gsoEOAqYCeMgXGCu(p9abb1f36Var, fdf4c5269);
        } else {
            zPjPPzslgtzuxisc(p9abb1f36Var, false);
            dQQhImrOpikEFNIX(p9abb1f36Var.fe69d4caa, JkMXddnvfgqCVMqs(pd4bc0fd0Var));
            tvSyYzYmYjDMObou(p9abb1f36Var.f2aea0929, WazDFnegqrQmovJl(pd4bc0fd0Var));
            vfghqsLEZHUaJBYF(p9abb1f36Var, ffe899d6f);
        }
    }
}

