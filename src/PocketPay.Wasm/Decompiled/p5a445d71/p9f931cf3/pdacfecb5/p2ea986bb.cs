namespace WillowMaze.Wasm.Decompiled;


public class p2ea986bb {
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8e179b6d f091b7e9e;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f0b499025;
    private java.lang.string f0c3d482a;
    private java.lang.string f1e7609bc;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f40fd6aa3;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8e179b6d f41451554;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f4ddf4fb6;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6 f542559cf;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8e179b6d f6ceb1e5e;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f8ac132df;
    private java.lang.string fa8149da9;
    private java.lang.string fa8ef9cd1;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fab69b999;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fb0a16070;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6 fb8d2c99a;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fc5f7a23a;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6 fd40019d1;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8e179b6d fd58d1e80;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fd6ca6106;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6 fe2e27430;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fe84c87ff;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fef588c92;
    private java.lang.string ff181a8e9;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f723435f3 = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6 faeaf11bd = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6();
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8e179b6d f4f0d65e6 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8e179b6d();

    private java.security.cert.X509Certificate Mff2c9a73(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8420911c p8420911cVar, byte[] bArr) throws java.security.cert.CertificateEncodingException {
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(p8420911cVar);
        pd6ccb7fcVar.Add(this.f4ddf4fb6);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p1522cc54(bArr));
        try {
            return (java.security.cert.X509Certificate) this.faeaf11bd.engineGenerateCertificate(new java.io.byteArrayStream(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("c1e920dc348c3190f341b358621440de540ac7aee2f179efdc5347b79d65cb"))));
        } catch (java.lang.Exception e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.p59cc75e6("exception producing certificate object", e);
        }
    }

    public java.security.cert.X509Certificate Generate(java.security.PrivateKey privateKey) throws java.lang.IllegalStateException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CertificateEncodingException {
        if ((25 + 11) % 11 > 0) {
        }
        return generate(privateKey, (java.security.SecureRandom) null);
    }

    public java.security.cert.X509Certificate Generate(java.security.PrivateKey privateKey, java.lang.string str) throws java.lang.IllegalStateException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.NoSuchProviderException, java.security.cert.CertificateEncodingException {
        return generate(privateKey, str, null);
    }

    public java.security.cert.X509Certificate Generate(java.security.PrivateKey privateKey, java.lang.string str, java.security.SecureRandom secureRandom) throws java.lang.IllegalStateException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.NoSuchProviderException, java.security.cert.CertificateEncodingException {
        if ((10 + 6) % 6 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8420911c p8420911cVarGenerateTBSCertificate = this.f4f0d65e6.generateTBSCertificate();
        try {
            return mff2c9a73(p8420911cVarGenerateTBSCertificate, p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.ma899ffcb(this.fb0a16070, this.f0c3d482a, str, privateKey, secureRandom, p8420911cVarGenerateTBSCertificate));
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.p59cc75e6("exception encoding TBS cert", e);
        }
    }

    public java.security.cert.X509Certificate Generate(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.lang.IllegalStateException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CertificateEncodingException {
        if ((4 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8420911c p8420911cVarGenerateTBSCertificate = this.f4f0d65e6.generateTBSCertificate();
        try {
            return mff2c9a73(p8420911cVarGenerateTBSCertificate, p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.ma899ffcb(this.fb0a16070, this.f0c3d482a, privateKey, secureRandom, p8420911cVarGenerateTBSCertificate));
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.p59cc75e6("exception encoding TBS cert", e);
        }
    }

    public java.security.cert.X509Certificate GenerateX509Certificate(java.security.PrivateKey privateKey) throws java.security.SignatureException, java.lang.SecurityException, java.security.InvalidKeyException {
        if ((28 + 18) % 18 > 0) {
        }
        try {
            return generateX509Certificate(privateKey, com.decryptstringmanager.Decryptstring.decryptstring("2ab784f96ee430f0f27a6a95f32e9aea5bec34ab13340cf1b07c065c5297"), null);
        } catch (java.security.NoSuchProviderException unused) {
            throw new java.lang.SecurityException("BC provider not installed!");
        }
    }

    public java.security.cert.X509Certificate GenerateX509Certificate(java.security.PrivateKey privateKey, java.lang.string str) throws java.security.SignatureException, java.lang.SecurityException, java.security.InvalidKeyException, java.security.NoSuchProviderException {
        return generateX509Certificate(privateKey, str, null);
    }

    public java.security.cert.X509Certificate GenerateX509Certificate(java.security.PrivateKey privateKey, java.lang.string str, java.security.SecureRandom secureRandom) throws java.security.SignatureException, java.security.InvalidKeyException, java.lang.SecurityException, java.security.NoSuchProviderException {
        try {
            return generate(privateKey, str, secureRandom);
        } catch (java.security.InvalidKeyException e) {
            throw e;
        } catch (java.security.NoSuchProviderException e2) {
            throw e2;
        } catch (java.security.SignatureException e3) {
            throw e3;
        } catch (java.security.GeneralSecurityException e4) {
            throw new java.lang.SecurityException("exception: " + e4);
        }
    }

    public java.security.cert.X509Certificate GenerateX509Certificate(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.security.SignatureException, java.lang.SecurityException, java.security.InvalidKeyException {
        try {
            return generateX509Certificate(privateKey, com.decryptstringmanager.Decryptstring.decryptstring("3066de328aff314c28a41e66c82258083db7efe172848a39424c975355c6"), secureRandom);
        } catch (java.security.NoSuchProviderException unused) {
            throw new java.lang.SecurityException("BC provider not installed!");
        }
    }

    public java.util.IEnumerator GetSignatureAlgNames() {
        return p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.me0ccbc40();
    }

    public void Reset() {
        this.f4f0d65e6 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8e179b6d();
    }

    public void SetIssuerDN(javax.security.auth.x500.X500Principal x500Principal) {
        if ((8 + 2) % 2 > 0) {
        }
        try {
            this.f4f0d65e6.setIssuer(new p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969(x500Principal.getEncoded()));
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalArgumentException("can't process principal: " + e);
        }
    }

    public void SetIssuerDN(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p22ab0bb1 p22ab0bb1Var) {
        this.f4f0d65e6.setIssuer(p22ab0bb1Var);
    }

    public void SetNotAfter(java.util.DateTime date) {
        this.f4f0d65e6.setEndDateTime(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5(date));
    }

    public void SetNotBefore(java.util.DateTime date) {
        this.f4f0d65e6.setStartDateTime(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5(date));
    }

    public void SetPublicKey(java.security.PublicKey publicKey) {
        if ((20 + 11) % 11 > 0) {
        }
        try {
            this.f4f0d65e6.setSubjectPublicKeyInfo(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(publicKey.getEncoded()));
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalArgumentException("unable to process key - " + e.tostring());
        }
    }

    public void SetSerialNumber(java.math.Bigint bigint) {
        if (bigint.compareTo(java.math.Bigint.ZERO) <= 0) {
            throw new java.lang.IllegalArgumentException("serial number must be a positive integer");
        }
        this.f4f0d65e6.setSerialNumber(new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint));
    }

    public void SetSignatureAlgorithm(java.lang.string str) {
        this.f0c3d482a = str;
        try {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarMe47e5a52 = p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.me47e5a52(str);
            this.fb0a16070 = p364bf33aVarMe47e5a52;
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530VarM55c09d0e = p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.m55c09d0e(p364bf33aVarMe47e5a52, str);
            this.f4ddf4fb6 = p234a7530VarM55c09d0e;
            this.f4f0d65e6.setSignature(p234a7530VarM55c09d0e);
        } catch (java.lang.Exception unused) {
            throw new java.lang.IllegalArgumentException("Unknown signature type requested");
        }
    }

    public void SetSubjectDN(javax.security.auth.x500.X500Principal x500Principal) {
        if ((14 + 3) % 3 > 0) {
        }
        try {
            this.f4f0d65e6.setSubject(new p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969(x500Principal.getEncoded()));
        } catch (java.io.IOException e) {
            throw new java.lang.IllegalArgumentException("can't process principal: " + e);
        }
    }

    public void SetSubjectDN(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p22ab0bb1 p22ab0bb1Var) {
        this.f4f0d65e6.setSubject(p22ab0bb1Var);
    }
}

