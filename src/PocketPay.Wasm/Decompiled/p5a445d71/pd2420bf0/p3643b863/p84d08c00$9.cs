namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$9 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$9(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static bool DTLARuQgarVJjPTc(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.matchesLetter();
    }

    public static p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e FDDonTTRYYFczOOE(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, bool z) {
        return p9abb1f36Var.createTagPending(z);
    }

    public static bool UatktDQhUgiCZtOV(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.Count == 0;
    }

    public static bool AwXmRbfPHEeEbWbn(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char c) {
        return pd4bc0fd0Var.matches(c);
    }

    public static void CTKhrQlxWQuIuKXV(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void IaSTZAquMdzdrFBk(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void KmzYUUFomJGeCQak(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void SHWdjGvKJAojgHxg(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void UsLegYihQpcGAtyd(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    public static void VXQzsPfkkKNoItpG(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void WTHwwJszoBpmqDTX(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.string str) {
        p9abb1f36Var.emit(str);
    }

    public static void YAFPhQHmWAORxFOU(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (UatktDQhUgiCZtOV(pd4bc0fd0Var)) {
            iaSTZAquMdzdrFBk(p9abb1f36Var, this);
            wTHwwJszoBpmqDTX(p9abb1f36Var, "</");
            vXQzsPfkkKNoItpG(p9abb1f36Var, ff6068daa);
        } else if (DTLARuQgarVJjPTc(pd4bc0fd0Var)) {
            FDDonTTRYYFczOOE(p9abb1f36Var, false);
            yAFPhQHmWAORxFOU(p9abb1f36Var, ffe99bb7e);
        } else if (awXmRbfPHEeEbWbn(pd4bc0fd0Var, '>')) {
            cTKhrQlxWQuIuKXV(p9abb1f36Var, this);
            kmzYUUFomJGeCQak(p9abb1f36Var, ff6068daa);
        } else {
            sHWdjGvKJAojgHxg(p9abb1f36Var, this);
            usLegYihQpcGAtyd(p9abb1f36Var, f6c633ddc);
        }
    }
}

