namespace WillowMaze.Wasm.Decompiled;


protected class pa80e639a$p1a6189ca : java.security.InvalidKeyException {
    private readonly java.lang.Exception f560220fc;
    private readonly java.lang.Exception ffdee6cd3;

    pa80e639a$p1a6189ca(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

