namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$21 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$21(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void XwHYAYbMeiVRRWnB(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, char c) {
        p9abb1f36Var.emit(c);
    }

    public static bool BkhBkZDqbngUgpCY(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var, char c) {
        return pd4bc0fd0Var.matches(c);
    }

    public static void MLyYOEJnrQUZvRJa(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void QPtLgXJPvIexLcyn(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.advanceTransition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        if (!bkhBkZDqbngUgpCY(pd4bc0fd0Var, '-')) {
            mLyYOEJnrQUZvRJa(p9abb1f36Var, f6d75cd7a);
        } else {
            XwHYAYbMeiVRRWnB(p9abb1f36Var, '-');
            qPtLgXJPvIexLcyn(p9abb1f36Var, f3fafc927);
        }
    }
}

