namespace WillowMaze.Wasm.Decompiled;


class p51002034$p99d8045f : java.security.KeyStoreException {
    private readonly java.lang.Exception f1f6f28f9;
    private readonly java.lang.Exception f560220fc;
    private readonly java.lang.Exception f65c476b8;
    private readonly java.lang.Exception f93a2aaae;

    p51002034$p99d8045f(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

