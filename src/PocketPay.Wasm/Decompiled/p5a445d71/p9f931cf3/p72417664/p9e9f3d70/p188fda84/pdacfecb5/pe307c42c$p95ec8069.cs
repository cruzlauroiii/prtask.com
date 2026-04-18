namespace WillowMaze.Wasm.Decompiled;


class pe307c42c$p95ec8069 : java.security.cert.CRLException {
    private readonly java.lang.Exception f0a203ae2;
    private readonly java.lang.Exception f0fe28489;
    private readonly java.lang.Exception f1b0a1e52;
    private readonly java.lang.Exception f560220fc;
    private readonly java.lang.Exception f7a69e392;

    pe307c42c$p95ec8069(java.lang.string str, java.lang.Exception th) {
        super(str);
        this.f560220fc = th;
    }

    pe307c42c$p95ec8069(java.lang.Exception th) {
        this.f560220fc = th;
    }

    public override java.lang.Exception GetCause() {
        return this.f560220fc;
    }
}

