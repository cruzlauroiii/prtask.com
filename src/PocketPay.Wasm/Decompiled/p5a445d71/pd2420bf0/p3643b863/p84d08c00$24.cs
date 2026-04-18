namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$24 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$24(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void DXOyfVUvQJcIMKRH(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void FjXEdbELoOEHcZrZ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void MWyvrQBkCQdlPoaL(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void NcvQeSjbYlUxQjmM(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static void RPSEtVESgvLPTAoz(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void RkmgzMnXsiRHkhGj(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void RrNOlUsqhNfMmAua(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static bool VMtTMnUlNyOipjZV(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.Count == 0;
    }

    public static void WpGavRLJJOoFkXjG(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void ELjZIadNfTxptSof(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static char LfLgfHhjKYUuFLQC(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void PdyjvcCdRfPIheQD(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void YFnnxDMcgOFqsxWW(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (VMtTMnUlNyOipjZV(pd4bc0fd0Var)) {
            pdyjvcCdRfPIheQD(p9abb1f36Var, this);
            WpGavRLJJOoFkXjG(p9abb1f36Var, ff6068daa);
            return;
        }
        char cLfLgfHhjKYUuFLQC = lfLgfHhjKYUuFLQC(pd4bc0fd0Var);
        if (cLfLgfHhjKYUuFLQC == 0) {
            RPSEtVESgvLPTAoz(p9abb1f36Var, this);
            MWyvrQBkCQdlPoaL(p9abb1f36Var, (char) 65533);
            RkmgzMnXsiRHkhGj(p9abb1f36Var, f4abfd16e);
        } else {
            if (cLfLgfHhjKYUuFLQC == '-') {
                NcvQeSjbYlUxQjmM(p9abb1f36Var, cLfLgfHhjKYUuFLQC);
                return;
            }
            if (cLfLgfHhjKYUuFLQC == '<') {
                yFnnxDMcgOFqsxWW(p9abb1f36Var, fb76a2a32);
            } else if (cLfLgfHhjKYUuFLQC == '>') {
                eLjZIadNfTxptSof(p9abb1f36Var, cLfLgfHhjKYUuFLQC);
                RrNOlUsqhNfMmAua(p9abb1f36Var, f6d75cd7a);
            } else {
                FjXEdbELoOEHcZrZ(p9abb1f36Var, cLfLgfHhjKYUuFLQC);
                DXOyfVUvQJcIMKRH(p9abb1f36Var, f4abfd16e);
            }
        }
    }
}

