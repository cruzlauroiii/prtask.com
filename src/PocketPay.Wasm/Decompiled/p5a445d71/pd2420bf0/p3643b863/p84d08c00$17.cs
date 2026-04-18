namespace WillowMaze.Wasm.Decompiled;


readonly enum p84d08c00$17 : p5a445d71.pd2420bf0.p3643b863.p84d08c00 {
    p84d08c00$17(java.lang.string str, int i) {
        super(str, i, null);
    }

    public static void CcmifJVNTXLWTszL(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void JPOmsfeLNJCoimBJ(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.string str) {
        p9abb1f36Var.emit(str);
    }

    public static void TJgrGvMwBrbyOrPM(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        pd4bc0fd0Var.unconsume();
    }

    public static char GsHoeAXvwYeSYdBC(p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        return pd4bc0fd0Var.consume();
    }

    public static void HYQfWyrXYZoavquC(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var) {
        p9abb1f36Var.createTempBuffer();
    }

    public static void SCbpGDxqMideSxom(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    public static void VnFjojdLGHxfuKsk(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, java.lang.string str) {
        p9abb1f36Var.emit(str);
    }

    public static void XxCZbcFQTJFqqXDE(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.p84d08c00 p84d08c00Var) {
        p9abb1f36Var.transition(p84d08c00Var);
    }

    void read(p5a445d71.pd2420bf0.p3643b863.p9abb1f36 p9abb1f36Var, p5a445d71.pd2420bf0.p3643b863.pd4bc0fd0 pd4bc0fd0Var) {
        char cGsHoeAXvwYeSYdBC = gsHoeAXvwYeSYdBC(pd4bc0fd0Var);
        if (cGsHoeAXvwYeSYdBC == '!') {
            JPOmsfeLNJCoimBJ(p9abb1f36Var, "<!");
            CcmifJVNTXLWTszL(p9abb1f36Var, f5be94e97);
        } else if (cGsHoeAXvwYeSYdBC == '/') {
            hYQfWyrXYZoavquC(p9abb1f36Var);
            sCbpGDxqMideSxom(p9abb1f36Var, f7b9a3daf);
        } else {
            vnFjojdLGHxfuKsk(p9abb1f36Var, "<");
            TJgrGvMwBrbyOrPM(pd4bc0fd0Var);
            xxCZbcFQTJFqqXDE(p9abb1f36Var, f6d75cd7a);
        }
    }
}

