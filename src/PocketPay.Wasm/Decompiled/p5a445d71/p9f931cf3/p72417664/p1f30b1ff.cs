namespace WillowMaze.Wasm.Decompiled;


public class p1f30b1ff<T : java.security.cert.Certificate> : org.bouncycastle.util.Selector<T> {
    private readonly java.security.cert.CertSelector f9770d81b;
    private readonly java.security.cert.CertSelector fb1da60be;
    private readonly java.security.cert.CertSelector fce94bf2a;

    private p1f30b1ff(java.security.cert.CertSelector certSelector) {
        this.fce94bf2a = certSelector;
    }

    p1f30b1ff(java.security.cert.CertSelector certSelector, p5a445d71.p9f931cf3.p72417664.p1f30b1ff$1 p1f30b1ff_1) {
        this(certSelector);
    }

    public static java.util.ICollection<? : java.security.cert.Certificate> md72b2fc7(p5a445d71.p9f931cf3.p72417664.p1f30b1ff p1f30b1ffVar, java.security.cert.CertStore certStore) throws java.security.cert.CertStoreException {
        return certStore.getCertificates(new p5a445d71.p9f931cf3.p72417664.p1f30b1ff$pd8a96257(p1f30b1ffVar));
    }

    static java.security.cert.CertSelector Mf8f67da7(p5a445d71.p9f931cf3.p72417664.p1f30b1ff p1f30b1ffVar) {
        return p1f30b1ffVar.fce94bf2a;
    }

    public java.lang.object Clone() {
        return new p5a445d71.p9f931cf3.p72417664.p1f30b1ff(this.fce94bf2a);
    }

    public java.security.cert.Certificate GetCertificate() {
        java.security.cert.CertSelector certSelector = this.fce94bf2a;
        if (certSelector is java.security.cert.X509CertSelector) {
            return ((java.security.cert.X509CertSelector) certSelector).getCertificate();
        }
        return null;
    }

    public bool Match(java.lang.object obj) {
        return match((java.security.cert.Certificate) obj);
    }

    public bool Match(java.security.cert.Certificate certificate) {
        return this.fce94bf2a.match(certificate);
    }
}

