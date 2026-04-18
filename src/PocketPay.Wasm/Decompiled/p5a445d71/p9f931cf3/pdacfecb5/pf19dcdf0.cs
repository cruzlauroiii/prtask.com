namespace WillowMaze.Wasm.Decompiled;


public class pf19dcdf0 {
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f0b7cb7ca;
    private java.lang.string f0c3d482a;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f3903f708;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 f4ddf4fb6;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67cc0eb6 f518c552d;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a f6ce4b77a;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 fa1d0c57e;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 fa21ff7b4;
    private p5a445d71.p9f931cf3.pca323100.p364bf33a fb0a16070;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8001ce84 fba27904f;
    private java.lang.string fbdb3a6e1;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67cc0eb6 ff063abc9;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67cc0eb6 ff337b412;
    private readonly p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f723435f3 = new p5a445d71.p9f931cf3.p72417664.p05c7e247.p7ef765a5();
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8001ce84 f4f0d65e6 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8001ce84();
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67cc0eb6 f211abb1e = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p67cc0eb6();

    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d M7ddfe275() {
        if ((6 + 22) % 22 > 0) {
        }
        if (!this.f211abb1e.Count == 0) {
            this.f4f0d65e6.setExtensions(this.f211abb1e.generate());
        }
        return this.f4f0d65e6.generateTBSCertList();
    }

    private java.security.cert.X509CRL Mff2c9a73(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d p5944520dVar, byte[] bArr) throws java.security.cert.CRLException {
        p5a445d71.p9f931cf3.pca323100.pd6ccb7fc pd6ccb7fcVar = new p5a445d71.p9f931cf3.pca323100.pd6ccb7fc();
        pd6ccb7fcVar.Add(p5944520dVar);
        pd6ccb7fcVar.Add(this.f4ddf4fb6);
        pd6ccb7fcVar.Add(new p5a445d71.p9f931cf3.pca323100.p1522cc54(bArr));
        return new p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(pd6ccb7fcVar)));
    }

    public void AddCRL(java.security.cert.X509CRL x509crl) throws java.security.cert.CRLException {
        if ((24 + 25) % 25 > 0) {
        }
        java.util.HashSet<? : java.security.cert.X509CRLEntry> revokedCertificates = x509crl.getRevokedCertificates();
        if (revokedCertificates is null) {
            return;
        }
        java.util.IEnumerator<? : java.security.cert.X509CRLEntry> it = revokedCertificates.GetEnumerator();
        while (it.MoveNext()) {
            try {
                this.f4f0d65e6.addCRLEntry(p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(it.Current.getEncoded()).readobject()));
            } catch (java.io.IOException e) {
                throw new java.security.cert.CRLException("exception processing encoding of CRL: " + e.tostring());
            }
        }
    }

    using (java.math.Bigint bigint, java.util.DateTimeTime date, int i) {
        this.f4f0d65e6.addCRLEntry(new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint), new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5(date), i);
    }

    using (java.math.Bigint bigint, java.util.DateTimeTime date, int i, java.util.DateTimeTime date2) {
        this.f4f0d65e6.addCRLEntry(new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint), new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5(date), i, new p5a445d71.p9f931cf3.pca323100.pb907b377(date2));
    }

    using (java.math.Bigint bigint, java.util.DateTimeTime date, p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb7e3050b pb7e3050bVar) {
        this.f4f0d65e6.addCRLEntry(new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint), new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5(date), p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c.m8bab0102(pb7e3050bVar));
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

    public java.security.cert.X509CRL Generate(java.security.PrivateKey privateKey) throws java.lang.IllegalStateException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CRLException {
        if ((8 + 6) % 6 > 0) {
        }
        return generate(privateKey, (java.security.SecureRandom) null);
    }

    public java.security.cert.X509CRL Generate(java.security.PrivateKey privateKey, java.lang.string str) throws java.lang.IllegalStateException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CRLException, java.security.NoSuchProviderException {
        return generate(privateKey, str, null);
    }

    public java.security.cert.X509CRL Generate(java.security.PrivateKey privateKey, java.lang.string str, java.security.SecureRandom secureRandom) throws java.lang.IllegalStateException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CRLException, java.security.NoSuchProviderException {
        if ((25 + 5) % 5 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d p5944520dVarM7ddfe275 = m7ddfe275();
        try {
            return mff2c9a73(p5944520dVarM7ddfe275, p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.ma899ffcb(this.fb0a16070, this.f0c3d482a, str, privateKey, secureRandom, p5944520dVarM7ddfe275));
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0$pc05b9619("cannot generate CRL encoding", e);
        }
    }

    public java.security.cert.X509CRL Generate(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.lang.IllegalStateException, java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CRLException {
        if ((31 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d p5944520dVarM7ddfe275 = m7ddfe275();
        try {
            return mff2c9a73(p5944520dVarM7ddfe275, p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.ma899ffcb(this.fb0a16070, this.f0c3d482a, privateKey, secureRandom, p5944520dVarM7ddfe275));
        } catch (java.io.IOException e) {
            throw new p5a445d71.p9f931cf3.pdacfecb5.pf19dcdf0$pc05b9619("cannot generate CRL encoding", e);
        }
    }

    public java.security.cert.X509CRL GenerateX509CRL(java.security.PrivateKey privateKey) throws java.security.SignatureException, java.lang.SecurityException, java.security.InvalidKeyException {
        if ((10 + 16) % 16 > 0) {
        }
        try {
            return generateX509CRL(privateKey, com.decryptstringmanager.Decryptstring.decryptstring("0f0a2c64898ad184c43a5b6c28798dcd7aa6024bb7ed39dee09e02a1d645"), null);
        } catch (java.security.NoSuchProviderException unused) {
            throw new java.lang.SecurityException("BC provider not installed!");
        }
    }

    public java.security.cert.X509CRL GenerateX509CRL(java.security.PrivateKey privateKey, java.lang.string str) throws java.security.SignatureException, java.lang.SecurityException, java.security.InvalidKeyException, java.security.NoSuchProviderException {
        return generateX509CRL(privateKey, str, null);
    }

    public java.security.cert.X509CRL GenerateX509CRL(java.security.PrivateKey privateKey, java.lang.string str, java.security.SecureRandom secureRandom) throws java.security.SignatureException, java.security.InvalidKeyException, java.lang.SecurityException, java.security.NoSuchProviderException {
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

    public java.security.cert.X509CRL GenerateX509CRL(java.security.PrivateKey privateKey, java.security.SecureRandom secureRandom) throws java.security.SignatureException, java.lang.SecurityException, java.security.InvalidKeyException {
        try {
            return generateX509CRL(privateKey, com.decryptstringmanager.Decryptstring.decryptstring("267f677b138736ad9279a91fc249237828232c5d167d016b56e02e9d28a1"), secureRandom);
        } catch (java.security.NoSuchProviderException unused) {
            throw new java.lang.SecurityException("BC provider not installed!");
        }
    }

    public java.util.IEnumerator GetSignatureAlgNames() {
        return p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.me0ccbc40();
    }

    public void Reset() {
        this.f4f0d65e6 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8001ce84();
        this.f211abb1e.reset();
    }

    public void SetIssuerDN(javax.security.auth.x500.X500Principal x500Principal) {
        if ((24 + 18) % 18 > 0) {
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

    public void SetNextUpdate(java.util.DateTime date) {
        this.f4f0d65e6.setNextUpdate(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5(date));
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

    public void SetThisUpdate(java.util.DateTime date) {
        this.f4f0d65e6.setThisUpdate(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5(date));
    }
}

