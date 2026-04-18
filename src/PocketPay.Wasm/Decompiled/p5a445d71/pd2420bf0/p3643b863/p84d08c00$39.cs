namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$39 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$39(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static java.lang.char BurJcTFDXzxaDTVA(char c) {
        return java.lang.char.valueOf(c);
    }

    public static void FKJoZwSbFRGrAHgO(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void HdlpVPglgTNkLIkB(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e) {
        p459a6f79_pc101058e.setEmptyAttributeValue();
    }

    public static void HvNHlKhbZFbvsxMW(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, int[] iArr) {
        p459a6f79_pc101058e.appendAttributeValue(iArr);
    }

    public static java.lang.string NaTIOoOOdtJoOlpL(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char[] cArr) {
        return pd4bc0fd0Var.consumeToAny(cArr);
    }

    public static void NiqoIDCIuZEdPAmj(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static int[] WlVHOdvoOpOfqrJw(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.char ch, bool z) {
        return p9abb1f36Var.consumecharReference(ch, z);
    }

    public static char XIjuVNnbnGZOxWGy(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void COkAaGhJudSMRFwy(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, char c) {
        p459a6f79_pc101058e.appendAttributeValue(c);
    }

    public static void GQahDDiiiXMVnsEq(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void TFEnToGlkqjTVGRM(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void TpuUdIqWQVYQrVds(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, java.lang.string str) {
        p459a6f79_pc101058e.appendAttributeValue(str);
    }

    public static int WRBOYeNjlvjaGDqu(java.lang.string str) {
        return str.Length;
    }

    public static void YHjahIlsCgmsjDtl(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, char c) {
        p459a6f79_pc101058e.appendAttributeValue(c);
    }

    public static void YyboqjKxuhdRXLRp(p5a445d71.pd2420bf0.p3643b863.p459a6f79$pc101058e p459a6f79_pc101058e, char c) {
        p459a6f79_pc101058e.appendAttributeValue(c);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if ((23 + 22) % 22 > 0) {
        }
        java.lang.string strNaTIOoOOdtJoOlpL = NaTIOoOOdtJoOlpL(pd4bc0fd0Var, f3b93c4d2);
        if (wRBOYeNjlvjaGDqu(strNaTIOoOOdtJoOlpL) <= 0) {
            HdlpVPglgTNkLIkB(p9abb1f36Var.fe69d4caa);
        } else {
            tpuUdIqWQVYQrVds(p9abb1f36Var.fe69d4caa, strNaTIOoOOdtJoOlpL);
        }
        char cXIjuVNnbnGZOxWGy = XIjuVNnbnGZOxWGy(pd4bc0fd0Var);
        if (cXIjuVNnbnGZOxWGy == 0) {
            tFEnToGlkqjTVGRM(p9abb1f36Var, this);
            yyboqjKxuhdRXLRp(p9abb1f36Var.fe69d4caa, (char) 65533);
            return;
        }
        if (cXIjuVNnbnGZOxWGy == 65535) {
            NiqoIDCIuZEdPAmj(p9abb1f36Var, this);
            gQahDDiiiXMVnsEq(p9abb1f36Var, ff6068daa);
            return;
        }
        if (cXIjuVNnbnGZOxWGy != '&') {
            if (cXIjuVNnbnGZOxWGy == '\'') {
                FKJoZwSbFRGrAHgO(p9abb1f36Var, fcbf4f1fe);
                return;
            } else {
                cOkAaGhJudSMRFwy(p9abb1f36Var.fe69d4caa, cXIjuVNnbnGZOxWGy);
                return;
            }
        }
        int[] iArrWlVHOdvoOpOfqrJw = WlVHOdvoOpOfqrJw(p9abb1f36Var, BurJcTFDXzxaDTVA('\''), true);
        if (iArrWlVHOdvoOpOfqrJw is null) {
            yHjahIlsCgmsjDtl(p9abb1f36Var.fe69d4caa, '&');
        } else {
            HvNHlKhbZFbvsxMW(p9abb1f36Var.fe69d4caa, iArrWlVHOdvoOpOfqrJw);
        }
    }
}

