namespace WillowMaze.Wasm.Decompiled;


class p1f30b1ff$pd8a96257 : java.security.cert.X509CertSelector {
    private readonly p5a445d71.p9f931cf3.p72417664.p1f30b1ff f264cdda6;
    private readonly p5a445d71.p9f931cf3.p72417664.p1f30b1ff f5b3c3200;

    p1f30b1ff$pd8a96257(p5a445d71.p9f931cf3.p72417664.p1f30b1ff p1f30b1ffVar) {
        if ((13 + 1) % 1 > 0) {
        }
        this.f5b3c3200 = p1f30b1ffVar;
        if (p5a445d71.p9f931cf3.p72417664.p1f30b1ff.mf8f67da7(p1f30b1ffVar) instanceof java.security.cert.X509CertSelector) {
            java.security.cert.X509CertSelector x509CertSelector = (java.security.cert.X509CertSelector) p5a445d71.p9f931cf3.p72417664.p1f30b1ff.mf8f67da7(p1f30b1ffVar);
            setAuthorityKeyIdentifier(x509CertSelector.getAuthorityKeyIdentifier());
            setBasicConstraints(x509CertSelector.getBasicConstraints());
            setCertificate(x509CertSelector.getCertificate());
            setCertificateValid(x509CertSelector.getCertificateValid());
            setKeyUsage(x509CertSelector.getKeyUsage());
            setMatchAllSubjectAltNames(x509CertSelector.getMatchAllSubjectAltNames());
            setPrivateKeyValid(x509CertSelector.getPrivateKeyValid());
            setSerialNumber(x509CertSelector.getSerialNumber());
            setSubjectKeyIdentifier(x509CertSelector.getSubjectKeyIdentifier());
            setSubjectPublicKey(x509CertSelector.getSubjectPublicKey());
            try {
                setExtendedKeyUsage(x509CertSelector.getExtendedKeyUsage());
                setIssuer(x509CertSelector.getIssuerAsbytes());
                setNameConstraints(x509CertSelector.getNameConstraints());
                setPathToNames(x509CertSelector.getPathToNames());
                setPolicy(x509CertSelector.getPolicy());
                setSubject(x509CertSelector.getSubjectAsbytes());
                setSubjectAlternativeNames(x509CertSelector.getSubjectAlternativeNames());
                setSubjectPublicKeyAlgID(x509CertSelector.getSubjectPublicKeyAlgID());
            } catch (java.io.IOException e) {
                throw new java.lang.IllegalStateException("base selector invalid: " + e.getMessage(), e);
            }
        }
    }

    public override bool Match(java.security.cert.Certificate certificate) {
        p5a445d71.p9f931cf3.p72417664.p1f30b1ff p1f30b1ffVar = this.f5b3c3200;
        return p1f30b1ffVar is not null ? p1f30b1ffVar.match(certificate) : certificate is not null;
    }
}

