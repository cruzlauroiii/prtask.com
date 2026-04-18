namespace WillowMaze.Wasm.Decompiled;


class pe93197c1$p57640572 : java.security.KeyStoreException {
    private readonly java.lang.Exception f5220f233;
    private readonly java.lang.Exception f560220fc;
    private readonly java.lang.Exception f7e364d61;

    public pe93197c1$p57640572(java.lang.string str, java.lang.Exception exc) {
        super(str);
        this.f560220fc = exc;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

