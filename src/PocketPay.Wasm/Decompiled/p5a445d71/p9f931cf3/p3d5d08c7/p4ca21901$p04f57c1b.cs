namespace WillowMaze.Wasm.Decompiled;


class p4ca21901$p04f57c1b : java.lang.Exception {
    private java.lang.Exception f4346b178;
    private java.lang.Exception f560220fc;
    private java.lang.Exception f5f82c078;
    private java.lang.Exception fccd98c6f;

    p4ca21901$p04f57c1b(java.lang.Exception th) {
        super(th.tostring());
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

