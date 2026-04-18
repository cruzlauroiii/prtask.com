namespace WillowMaze.Wasm.Decompiled;


class p35fd653a : p5a445d71.p9f931cf3.p72417664.pd53d0176 {
    private readonly java.security.cert.PKIXCertPathChecker f0cdeec99;
    private readonly java.security.cert.PKIXCertPathChecker f5065246f;
    private readonly java.security.cert.PKIXCertPathChecker f8eac8e27;
    private readonly java.security.cert.PKIXCertPathChecker f9bcf0edc;

    public p35fd653a(java.security.cert.PKIXCertPathChecker pKIXCertPathChecker) {
        this.f9bcf0edc = pKIXCertPathChecker;
    }

    public override void Check(java.security.cert.Certificate certificate) throws java.security.cert.CertPathValidatorException {
        this.f9bcf0edc.check(certificate);
    }

    public override void Initialize(p5a445d71.p9f931cf3.p72417664.pcb5fa6f0 pcb5fa6f0Var) throws java.security.cert.CertPathValidatorException {
        this.f9bcf0edc.init(false);
    }

    public override void SetParameter(java.lang.string str, java.lang.object obj) {
    }
}

