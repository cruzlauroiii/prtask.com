namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$65 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$65(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static char FSWnLgVNrHWNBNxG(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void UFnGiByKDOpkjhCp(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void ZtBZuBmMqHTYMXqf(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.eofError(p84d08c00Var);
    }

    public static void GlxEPacfXsMKCRNn(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void HvWegfamjUOasNPd(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.emitDoctypePending();
    }

    public static void TLvXpMwHYzZGAngQ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void TOAaXiYADKbXgBui(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.error(p84d08c00Var);
    }

    public static void ZDnWPSIZGPYfEakb(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        char cFSWnLgVNrHWNBNxG = FSWnLgVNrHWNBNxG(pd4bc0fd0Var);
        if (cFSWnLgVNrHWNBNxG == '\t' || cFSWnLgVNrHWNBNxG == '\n' || cFSWnLgVNrHWNBNxG == '\f' || cFSWnLgVNrHWNBNxG == '\r' || cFSWnLgVNrHWNBNxG == ' ') {
            return;
        }
        if (cFSWnLgVNrHWNBNxG == '>') {
            glxEPacfXsMKCRNn(p9abb1f36Var);
            tLvXpMwHYzZGAngQ(p9abb1f36Var, ff6068daa);
        } else if (cFSWnLgVNrHWNBNxG != 65535) {
            tOAaXiYADKbXgBui(p9abb1f36Var, this);
            UFnGiByKDOpkjhCp(p9abb1f36Var, f102e6000);
        } else {
            ZtBZuBmMqHTYMXqf(p9abb1f36Var, this);
            p9abb1f36Var.f147a911a.fc352559f = true;
            hvWegfamjUOasNPd(p9abb1f36Var);
            zDnWPSIZGPYfEakb(p9abb1f36Var, ff6068daa);
        }
    }
}

