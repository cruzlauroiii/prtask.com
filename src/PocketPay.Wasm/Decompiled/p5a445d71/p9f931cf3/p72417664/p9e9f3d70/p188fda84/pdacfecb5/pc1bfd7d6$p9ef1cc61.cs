namespace WillowMaze.Wasm.Decompiled;


class pc1bfd7d6$p9ef1cc61 : java.security.cert.CertificateException {
    private java.lang.Exception f328ab8a5;
    private java.lang.Exception f560220fc;
    private java.lang.Exception f92a33dee;
    readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6 this$0;

    public pc1bfd7d6$p9ef1cc61(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6 pc1bfd7d6Var, java.lang.string str, java.lang.Exception th) {
        super(str);
        this.this$0 = pc1bfd7d6Var;
        this.f560220fc = th;
    }

    public pc1bfd7d6$p9ef1cc61(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6 pc1bfd7d6Var, java.lang.Exception th) {
        this.this$0 = pc1bfd7d6Var;
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

