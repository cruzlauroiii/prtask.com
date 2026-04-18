namespace WillowMaze.Wasm.Decompiled;


class pf19dcdf0$pc05b9619 : java.security.cert.CRLException {
    java.lang.Exception f3306418f;
    java.lang.Exception f560220fc;
    java.lang.Exception fc13df08b;

    pf19dcdf0$pc05b9619(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

