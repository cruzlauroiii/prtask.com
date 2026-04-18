namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$30 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$30(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void DldYCAljIEpqTvZo(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void FsVDoenUlBLQeXFh(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void HLRTonoSDztHcaXH(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static char MATZFRhUQaZNySRg(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void QXjmNVrnGLvwelnM(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void ZsotGrJhgoruuYaB(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void JhZquSqDZENkVINM(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void KlzRulBKRmAJsKNd(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void NxKQSXmceciSKkvI(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void PTmgHaCqiReULHRr(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void VOTMnITZVpFPRRiv(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void WwFVZxWNKJtLLwLx(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        char cMATZFRhUQaZNySRg = MATZFRhUQaZNySRg(pd4bc0fd0Var);
        if (cMATZFRhUQaZNySRg == 0) {
            FsVDoenUlBLQeXFh(p9abb1f36Var, this);
            ZsotGrJhgoruuYaB(p9abb1f36Var, (char) 65533);
            nxKQSXmceciSKkvI(p9abb1f36Var, ff645d19f);
        } else if (cMATZFRhUQaZNySRg == '-') {
            klzRulBKRmAJsKNd(p9abb1f36Var, cMATZFRhUQaZNySRg);
            QXjmNVrnGLvwelnM(p9abb1f36Var, ff54f502f);
        } else if (cMATZFRhUQaZNySRg == '<') {
            HLRTonoSDztHcaXH(p9abb1f36Var, cMATZFRhUQaZNySRg);
            vOTMnITZVpFPRRiv(p9abb1f36Var, f99402e9c);
        } else if (cMATZFRhUQaZNySRg == 65535) {
            DldYCAljIEpqTvZo(p9abb1f36Var, this);
            jhZquSqDZENkVINM(p9abb1f36Var, ff6068daa);
        } else {
            pTmgHaCqiReULHRr(p9abb1f36Var, cMATZFRhUQaZNySRg);
            wwFVZxWNKJtLLwLx(p9abb1f36Var, ff645d19f);
        }
    }
}

