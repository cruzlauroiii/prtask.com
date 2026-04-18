namespace WillowMaze.Wasm.Decompiled;


class pc05b9619 : java.security.cert.CRLException {
    java.lang.Exception f19dbb72e;
    java.lang.Exception f381985e1;
    java.lang.Exception f560220fc;

    pc05b9619(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

