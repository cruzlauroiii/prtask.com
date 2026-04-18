namespace WillowMaze.Wasm.Decompiled;


public class pf82b098c : java.security.cert.CertPathValidatorException : p5a445d71.p9f931cf3.p3d5d08c7.p42552b1f.p292fa332 {
    private java.lang.Exception f42f4d21c;
    private java.lang.Exception f53dc075c;
    private java.lang.Exception f53f07664;
    private java.lang.Exception f560220fc;
    private java.lang.Exception fb5813978;

    public pf82b098c(java.lang.string str) {
        super(str);
    }

    public pf82b098c(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    public pf82b098c(java.lang.string str, java.lang.Exception th, java.security.cert.CertPath certPath, int i) {
        super(str, th, certPath, i);
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

