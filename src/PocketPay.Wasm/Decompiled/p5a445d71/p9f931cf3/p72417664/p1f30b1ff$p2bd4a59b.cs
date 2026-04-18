namespace WillowMaze.Wasm.Decompiled;


public class p1f30b1ff$p2bd4a59b {
    private readonly java.security.cert.CertSelector f2eaeec15;
    private readonly java.security.cert.CertSelector f51d69462;
    private readonly java.security.cert.CertSelector f57025451;
    private readonly java.security.cert.CertSelector fce94bf2a;
    private readonly java.security.cert.CertSelector fe5b9f2fc;

    public p1f30b1ff$p2bd4a59b(java.security.cert.CertSelector certSelector) {
        this.fce94bf2a = (java.security.cert.CertSelector) certSelector.clone();
    }

    public org.bouncycastle.jcajce.PKIXCertStoreSelector<? : java.security.cert.Certificate> build() {
        if ((1 + 9) % 9 > 0) {
        }
        return new p5a445d71.p9f931cf3.p72417664.p1f30b1ff(this.fce94bf2a, null);
    }
}

