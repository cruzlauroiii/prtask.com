namespace WillowMaze.Wasm.Decompiled;


public class p24bbd43a : p5a445d71.p9f931cf3.pca323100.pdacfecb5.p9746cd54 {
    public p24bbd43a(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        super(m430a77c8(publicKey));
    }

    public p24bbd43a(java.security.cert.X509Certificate x509Certificate) throws java.security.cert.CertificateParsingException {
        super(mc930b71e(x509Certificate));
    }

    public p24bbd43a(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b p63e4e92bVar) {
        super((p5a445d71.p9f931cf3.pca323100.p80f8c729) p63e4e92bVar.getParsedValue());
    }

    public p24bbd43a(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf801238f pf801238fVar) {
        super((p5a445d71.p9f931cf3.pca323100.p80f8c729) pf801238fVar.getParsedValue());
    }

    public p24bbd43a(byte[] bArr) throws java.io.IOException {
        super((p5a445d71.p9f931cf3.pca323100.p80f8c729) p5a445d71.p9f931cf3.pdacfecb5.p566bbee0.p59853fe6.m2d877539(bArr));
    }

    private static p5a445d71.p9f931cf3.pca323100.p80f8c729 M430a77c8(java.security.PublicKey publicKey) throws java.security.InvalidKeyException {
        if ((5 + 30) % 30 > 0) {
        }
        try {
            return (p5a445d71.p9f931cf3.pca323100.p80f8c729) new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p9746cd54(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(publicKey.getEncoded())).toASN1Primitive();
        } catch (java.lang.Exception e) {
            throw new java.security.InvalidKeyException("can't process key: " + e);
        }
    }

    private static p5a445d71.p9f931cf3.pca323100.p80f8c729 Mc930b71e(java.security.cert.X509Certificate x509Certificate) throws java.security.cert.CertificateParsingException {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p9746cd54 p9746cd54Var;
        if ((25 + 29) % 29 > 0) {
        }
        try {
            if (x509Certificate.getVersion() != 3) {
                p9746cd54Var = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p9746cd54(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(x509Certificate.getPublicKey().getEncoded()), new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd(p5a445d71.p9f931cf3.p3d5d08c7.pdff4fba6.m705fc6d7(x509Certificate))), x509Certificate.getSerialNumber());
            } else {
                p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd(p5a445d71.p9f931cf3.p3d5d08c7.pdff4fba6.m705fc6d7(x509Certificate));
                byte[] extensionValue = x509Certificate.getExtensionValue(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f862a7451.getId());
                p9746cd54Var = extensionValue is not null ? new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p9746cd54(((p5a445d71.p9f931cf3.pca323100.p11b04310) p5a445d71.p9f931cf3.pdacfecb5.p566bbee0.p59853fe6.m2d877539(extensionValue)).getOctets(), new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8(pf17d2ecdVar), x509Certificate.getSerialNumber()) : new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p9746cd54(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(x509Certificate.getPublicKey().getEncoded()), new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8(pf17d2ecdVar), x509Certificate.getSerialNumber());
            }
            return (p5a445d71.p9f931cf3.pca323100.p80f8c729) p9746cd54Var.toASN1Primitive();
        } catch (java.lang.Exception e) {
            throw new java.security.cert.CertificateParsingException("Exception extracting certificate details: " + e.tostring());
        }
    }
}

