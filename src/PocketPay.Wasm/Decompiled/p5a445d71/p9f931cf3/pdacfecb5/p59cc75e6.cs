namespace WillowMaze.Wasm.Decompiled;


class p59cc75e6 : java.security.cert.CertificateEncodingException {
    java.lang.Exception f2040a3c6;
    java.lang.Exception f560220fc;
    java.lang.Exception f7d52b194;
    java.lang.Exception fb0ef3ee3;
    java.lang.Exception fee03b26f;

    p59cc75e6(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

