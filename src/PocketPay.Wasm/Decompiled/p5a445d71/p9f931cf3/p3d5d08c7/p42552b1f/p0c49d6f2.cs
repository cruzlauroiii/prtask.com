namespace WillowMaze.Wasm.Decompiled;


public class p0c49d6f2 : java.security.cert.CertPathBuilderException : p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.p292fa332 {
    private java.lang.Exception f560220fc;
    private java.lang.Exception f9df28e7b;
    private java.lang.Exception fbd925bbf;

    public p0c49d6f2(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public p0c49d6f2(java.lang.string str, java.lang.Exception th, java.security.cert.CertPath certPath, int i) {
        super(str, th);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

