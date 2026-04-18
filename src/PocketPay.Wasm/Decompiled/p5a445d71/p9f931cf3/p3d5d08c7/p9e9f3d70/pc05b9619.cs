namespace WillowMaze.Wasm.Decompiled;


class pc05b9619 : java.security.cert.CRLException {
    java.lang.Exception f25836836;
    java.lang.Exception f44460de3;
    java.lang.Exception f560220fc;
    java.lang.Exception f8cf3cd2f;

    pc05b9619(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

