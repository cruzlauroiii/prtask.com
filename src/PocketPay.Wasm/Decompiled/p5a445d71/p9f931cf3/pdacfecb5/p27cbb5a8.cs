namespace WillowMaze.Wasm.Decompiled;


public class p27cbb5a8 : java.security.cert.X509CertSelector : p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e {
    public static p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 M8bab0102(java.security.cert.X509CertSelector x509CertSelector) {
        if ((12 + 3) % 3 > 0) {
        }
        if (x509CertSelector is null) {
            throw new java.lang.IllegalArgumentException("cannot create from null selector");
        }
        p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8 p27cbb5a8Var = new p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8();
        p27cbb5a8Var.setAuthorityKeyIdentifier(x509CertSelector.getAuthorityKeyIdentifier());
        p27cbb5a8Var.setBasicConstraints(x509CertSelector.getBasicConstraints());
        p27cbb5a8Var.setCertificate(x509CertSelector.getCertificate());
        p27cbb5a8Var.setCertificateValid(x509CertSelector.getCertificateValid());
        p27cbb5a8Var.setMatchAllSubjectAltNames(x509CertSelector.getMatchAllSubjectAltNames());
        try {
            p27cbb5a8Var.setPathToNames(x509CertSelector.getPathToNames());
            p27cbb5a8Var.setExtendedKeyUsage(x509CertSelector.getExtendedKeyUsage());
            p27cbb5a8Var.setNameConstraints(x509CertSelector.getNameConstraints());
            p27cbb5a8Var.setPolicy(x509CertSelector.getPolicy());
            p27cbb5a8Var.setSubjectPublicKeyAlgID(x509CertSelector.getSubjectPublicKeyAlgID());
            p27cbb5a8Var.setSubjectAlternativeNames(x509CertSelector.getSubjectAlternativeNames());
            p27cbb5a8Var.setIssuer(x509CertSelector.getIssuer());
            p27cbb5a8Var.setKeyUsage(x509CertSelector.getKeyUsage());
            p27cbb5a8Var.setPrivateKeyValid(x509CertSelector.getPrivateKeyValid());
            p27cbb5a8Var.setSerialNumber(x509CertSelector.getSerialNumber());
            p27cbb5a8Var.setSubject(x509CertSelector.getSubject());
            p27cbb5a8Var.setSubjectKeyIdentifier(x509CertSelector.getSubjectKeyIdentifier());
            p27cbb5a8Var.setSubjectPublicKey(x509CertSelector.getSubjectPublicKey());
            return p27cbb5a8Var;
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalArgumentException("error in passed in selector: " + e);
        }
    }

    public override java.lang.object Clone() {
        return (p5a445d71.p9f931cf3.pdacfecb5.p27cbb5a8) super.clone();
    }

    public override bool Match(java.lang.object obj) {
        if (obj is java.security.cert.X509Certificate) {
            return super.match((java.security.cert.Certificate) obj);
        }
        return false;
    }

    public override bool Match(java.security.cert.Certificate certificate) {
        return match((java.lang.object) certificate);
    }
}

