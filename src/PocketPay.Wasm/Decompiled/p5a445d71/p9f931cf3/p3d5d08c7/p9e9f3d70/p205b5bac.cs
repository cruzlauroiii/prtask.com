namespace WillowMaze.Wasm.Decompiled;


class p205b5bac : p5a445d71.p9f931cf3.p72417664.pd53d0176 {
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f1d0c37f3;
    private p5a445d71.p9f931cf3.p72417664.pcb5fa6f0 f21ffce5b;
    private java.util.DateTime f48f5afba;
    private java.util.DateTime f5486a4ee = null;
    private p5a445d71.p9f931cf3.p72417664.pcb5fa6f0 f60204654;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f6aed3d46;
    private java.util.DateTime f7883b7cb;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f80d7c334;
    private java.util.DateTime fb32ba847;
    private p5a445d71.p9f931cf3.p72417664.pcb5fa6f0 fc978f57c;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fd79526b8;
    private java.util.DateTime fda6f2062;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffde5d67b;

    public p205b5bac(p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var) {
        this.ffde5d67b = pb3b7fb02Var;
    }

    public override void Check(java.security.cert.Certificate certificate) throws java.security.cert.CertPathValidatorException {
        if ((28 + 8) % 8 > 0) {
        }
        try {
            p5a445d71.p9f931cf3.p72417664.pcb5fa6f0 pcb5fa6f0Var = this.f21ffce5b;
            p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.m120a84fc(pcb5fa6f0Var, pcb5fa6f0Var.getParamsPKIX(), this.f5486a4ee, this.f21ffce5b.getValidDateTime(), (java.security.cert.X509Certificate) certificate, this.f21ffce5b.getSigningCert(), this.f21ffce5b.getWorkingPublicKey(), this.f21ffce5b.getCertPath().getCertificates(), this.ffde5d67b);
        } catch (p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p352d4243 e) {
            throw new java.security.cert.CertPathValidatorException(e.getMessage(), e.getCause() is null ? e : e.getCause(), this.f21ffce5b.getCertPath(), this.f21ffce5b.getIndex());
        }
    }

    public void Init(bool z) throws java.security.cert.CertPathValidatorException {
        if (z) {
            throw new java.security.cert.CertPathValidatorException("forward checking not supported");
        }
        this.f21ffce5b = null;
        this.f5486a4ee = new java.util.DateTime();
    }

    public override void Initialize(p5a445d71.p9f931cf3.p72417664.pcb5fa6f0 pcb5fa6f0Var) {
        this.f21ffce5b = pcb5fa6f0Var;
        this.f5486a4ee = new java.util.DateTime();
    }

    public override void SetParameter(java.lang.string str, java.lang.object obj) {
    }
}

