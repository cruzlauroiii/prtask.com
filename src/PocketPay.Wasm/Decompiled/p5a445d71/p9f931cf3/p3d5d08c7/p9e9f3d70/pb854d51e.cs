namespace WillowMaze.Wasm.Decompiled;


class pb854d51e {
    pb854d51e() {
    }

    private static byte[] M1c04e86a(javax.security.auth.x500.X500Principal x500Principal) {
        return m78a62b57(m78a62b57(x500Principal).getEncoded());
    }

    static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 M7538fd40(java.security.cert.X509Certificate x509Certificate) {
        return !(x509Certificate is p5a445d71.p9f931cf3.p72417664.pad63a35e.p81e4e5be) ? mc1e8b1fb(m78a62b57(x509Certificate).getSubjectX500Principal()) : m78a62b57(((p5a445d71.p9f931cf3.p72417664.pad63a35e.p81e4e5be) x509Certificate).getSubjectX500Name());
    }

    static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 M7691cf52(java.security.cert.TrustAnchor trustAnchor) {
        return mc1e8b1fb(m78a62b57(trustAnchor).getCA());
    }

    private static java.security.cert.TrustAnchor M78a62b57(java.security.cert.TrustAnchor trustAnchor) {
        if (trustAnchor is null) {
            throw new java.lang.IllegalStateException();
        }
        return trustAnchor;
    }

    private static java.security.cert.X509CRL M78a62b57(java.security.cert.X509CRL x509crl) {
        if (x509crl is null) {
            throw new java.lang.IllegalStateException();
        }
        return x509crl;
    }

    private static java.security.cert.X509Certificate M78a62b57(java.security.cert.X509Certificate x509Certificate) {
        if (x509Certificate is null) {
            throw new java.lang.IllegalStateException();
        }
        return x509Certificate;
    }

    private static javax.security.auth.x500.X500Principal M78a62b57(javax.security.auth.x500.X500Principal x500Principal) {
        if (x500Principal is null) {
            throw new java.lang.IllegalStateException();
        }
        return x500Principal;
    }

    private static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 M78a62b57(p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7Var) {
        if (p694426e7Var is null) {
            throw new java.lang.IllegalStateException();
        }
        return p694426e7Var;
    }

    private static byte[] M78a62b57(byte[] bArr) {
        if (bArr is null) {
            throw new java.lang.IllegalStateException();
        }
        return bArr;
    }

    static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 M8b725164(java.security.cert.X509CRL x509crl) {
        return mc1e8b1fb(m78a62b57(x509crl).getIssuerX500Principal());
    }

    static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 M8b725164(java.security.cert.X509Certificate x509Certificate) {
        return !(x509Certificate is p5a445d71.p9f931cf3.p72417664.pad63a35e.p81e4e5be) ? mc1e8b1fb(m78a62b57(x509Certificate).getIssuerX500Principal()) : m78a62b57(((p5a445d71.p9f931cf3.p72417664.pad63a35e.p81e4e5be) x509Certificate).getIssuerX500Name());
    }

    static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 Mc1e8b1fb(javax.security.auth.x500.X500Principal x500Principal) {
        return m78a62b57(p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(m1c04e86a(x500Principal)));
    }

    static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 Mc1e8b1fb(p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa4116702 pa4116702Var, javax.security.auth.x500.X500Principal x500Principal) {
        return m78a62b57(p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(pa4116702Var, m1c04e86a(x500Principal)));
    }

    static p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 Me037eb7c(java.lang.object obj) {
        return !(obj is java.security.cert.X509Certificate) ? mc1e8b1fb((javax.security.auth.x500.X500Principal) ((p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48) obj).getIssuer().getPrincipals()[0]) : m8b725164((java.security.cert.X509Certificate) obj);
    }
}

