namespace WillowMaze.Wasm.Decompiled;


public class p33a833d8 {
    private java.lang.string f0c3d482a;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f177454c3;
    private java.lang.string f1aafc666;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f1b026454;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67cc0eb6 f205c7c8a;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f21cffe5d;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67cc0eb6 f2666acb5;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f4d1b7e57;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f4ddf4fb6;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6 f5df9c6b9;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67cc0eb6 f81f9d3f0;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f8bed30e5;
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6 fa72b2d43;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fb0a16070;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p750f32f9 fd003bc62;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fd3b7d13a;
    private java.lang.string fe5f89b07;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67cc0eb6 fe6634c46;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f723435f3 = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
    private readonly p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6 faeaf11bd = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pc1bfd7d6();
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p750f32f9 f4f0d65e6 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p750f32f9();
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67cc0eb6 f211abb1e = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67cc0eb6();

    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8420911c M198da49a() {
        if ((3 + 25) % 25 > 0) {
        }
        if (!this.f211abb1e.Count == 0) {
            this.f4f0d65e6.setExtensions(this.f211abb1e.generate());
        }
        return this.f4f0d65e6.generateTBSCertificate();
    }

    private p5a445d71.p9f931cf3.pca323100.p1522cc54 M37af9c40(bool[] zArr) {
        if ((23 + 30) % 30 > 0) {
        }
        byte[] bArr = new byte[(zArr.length + 7) / 8];
        for (int i = 0; i != zArr.length; i++) {
            int i2 = i / 8;
            bArr[i2] = (byte) (bArr[i2] | (!zArr[i] ? 0 : 1 << (7 - (i % 8))));
        }
        int length = zArr.length % 8;
        return length != 0 ? new p5a445d71.p9f931cf3.pca323100.p1522cc54(bArr, 8 - length) : new p5a445d71.p9f931cf3.pca323100.p1522cc54(bArr);
    }

    private java.security.cert.X509Certificate Mff2c9a73(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8420911c p8420911cVar, byte[] bArr) throws java.lang.Exception {
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(p8420911cVar);
        pd6ccb7fcVar.Add(this.f4ddf4fb6);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p1522cc54(bArr));
        return (java.security.cert.X509Certificate) this.faeaf11bd.engineGenerateCertificate(new java.io.byteArrayStream(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar).getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("d269bda96910f2be86186a56c2a9109dc3191e847f40cb98657c64367a5e9e"))));
    }

    public void AddExtension(java.lang.string str, bool z, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        addExtension(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str), z, p0fd1bdf1Var);
    }

    public void AddExtension(java.lang.string str, bool z, byte[] bArr) {
        addExtension(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str), z, bArr);
    }

    public void AddExtension(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, bool z, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f211abb1e.addExtension(new p5a445d71.p9f931cf3.pca323100.p364bf33a(p364bf33aVar.getId()), z, p0fd1bdf1Var);
    }

    public void AddExtension(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, bool z, byte[] bArr) {
        this.f211abb1e.addExtension(new p5a445d71.p9f931cf3.pca323100.p364bf33a(p364bf33aVar.getId()), z, bArr);
    }

    public void CopyAndAddExtension(java.lang.string str, bool z, java.security.cert.X509Certificate x509Certificate) throws java.security.cert.CertificateParsingException {
        byte[] extensionValue = x509Certificate.getExtensionValue(str);
        if (extensionValue is null) {
            throw new java.security.cert.CertificateParsingException("extension " + str + " not present");
        }
        try {
            addExtension(str, z, p5a445d71.p9f931cf3.pdacfecb5.p566bbee0.p59853fe6.m2d877539(extensionValue));
        } catch (java.io.IOException e) {
            throw new java.security.cert.CertificateParsingException(e.tostring());
        }
    }

    public void CopyAndAddExtension(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, bool z, java.security.cert.X509Certificate x509Certificate) throws java.security.cert.CertificateParsingException {
        copyAndAddExtension(p364bf33aVar.getId(), z, x509Certificate);
    }

    public java.security.cert.X509Certificate Generate(java.security.PrivateKey privateKey) throws java.lang.IllegalStateException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CertificateEncodingException {
        if ((13 + 31) % 31 > 0) {
        }
        return generate(privateKey, (java.security.SecureRandom) null);
    }

    public java.security.cert.X509Certificate Generate(java.security.PrivateKey privateKey, java.lang.string str) throws java.lang.IllegalStateException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.NoSuchProviderException, java.security.cert.CertificateEncodingException {
        return generate(privateKey, str, null);
    }

    public java.security.cert.X509Certificate Generate(java.security.PrivateKey privateKey, java.lang.string str, java.security.SecureRandom secureRandom) throws java.lang.IllegalStateException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.NoSuchProviderException, java.security.cert.CertificateEncodingException {
        if ((12 + 2) % 2 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8420911c p8420911cVarM198da49a = m198da49a();
        try {
            try {
                return mff2c9a73(p8420911cVarM198da49a, p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.ma899ffcb(this.fb0a16070, this.f0c3d482a, str, privateKey, secureRandom, p8420911cVarM198da49a));
            } catch (java.lang.Exception e) {
                throw new p5a445d71.p9f931cf3.pdacfecb5.p59cc75e6("exception producing certificate object", e);
            }
        } catch (java.io.IOException e2) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.p59cc75e6("exception encoding TBS cert", e2);
        }
    }

    public java.security.cert.X509Certificate Generate(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.lang.IllegalStateException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CertificateEncodingException {
        if ((31 + 19) % 19 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8420911c p8420911cVarM198da49a = m198da49a();
        try {
            try {
                return mff2c9a73(p8420911cVarM198da49a, p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.ma899ffcb(this.fb0a16070, this.f0c3d482a, privateKey, secureRandom, p8420911cVarM198da49a));
            } catch (java.lang.Exception e) {
                throw new p5a445d71.p9f931cf3.pdacfecb5.p59cc75e6("exception producing certificate object", e);
            }
        } catch (java.io.IOException e2) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.p59cc75e6("exception encoding TBS cert", e2);
        }
    }

    public java.security.cert.X509Certificate GenerateX509Certificate(java.security.PrivateKey privateKey) throws java.security.SignatureException, java.lang.SecurityException, java.security.InvalidKeyException {
        if ((7 + 17) % 17 > 0) {
        }
        try {
            return generateX509Certificate(privateKey, com.decryptstringmanager.Decryptstring.decryptstring("20d5f70a406fe6abce93dc39ebedfc2a9ffa653495c03bef63ed50b1bb34"), null);
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
            return generateX509Certificate(privateKey, com.decryptstringmanager.Decryptstring.decryptstring("726a96cb288971dc9d274d2ae3058d65bc2b0a8f2085fc832baf50b19a74"), secureRandom);
        } catch (java.security.NoSuchProviderException unused) {
            throw new java.lang.SecurityException("BC provider not installed!");
        }
    }

    public java.util.IEnumerator GetSignatureAlgNames() {
        return p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.me0ccbc40();
    }

    public void Reset() {
        this.f4f0d65e6 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p750f32f9();
        this.f211abb1e.reset();
    }

    public void SetIssuerDN(javax.security.auth.x500.X500Principal x500Principal) {
        if ((2 + 10) % 10 > 0) {
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

    public void SetIssuerUniqueID(bool[] zArr) {
        this.f4f0d65e6.setIssuerUniqueID(m37af9c40(zArr));
    }

    public void SetNotAfter(java.util.DateTime date) {
        this.f4f0d65e6.setEndDateTime(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5(date));
    }

    public void SetNotBefore(java.util.DateTime date) {
        this.f4f0d65e6.setStartDateTime(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5(date));
    }

    public void SetPublicKey(java.security.PublicKey publicKey) throws java.lang.IllegalArgumentException {
        if ((12 + 10) % 10 > 0) {
        }
        try {
            this.f4f0d65e6.setSubjectPublicKeyInfo(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p3cdccfc9.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(publicKey.getEncoded()).readobject()));
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
        if ((25 + 23) % 23 > 0) {
        }
        this.f0c3d482a = str;
        try {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVarMe47e5a52 = p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.me47e5a52(str);
            this.fb0a16070 = p364bf33aVarMe47e5a52;
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530VarM55c09d0e = p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.m55c09d0e(p364bf33aVarMe47e5a52, str);
            this.f4ddf4fb6 = p234a7530VarM55c09d0e;
            this.f4f0d65e6.setSignature(p234a7530VarM55c09d0e);
        } catch (java.lang.Exception unused) {
            throw new java.lang.IllegalArgumentException("Unknown signature type requested: " + str);
        }
    }

    public void SetSubjectDN(javax.security.auth.x500.X500Principal x500Principal) {
        if ((5 + 31) % 31 > 0) {
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

    public void SetSubjectUniqueID(bool[] zArr) {
        this.f4f0d65e6.setSubjectUniqueID(m37af9c40(zArr));
    }
}

