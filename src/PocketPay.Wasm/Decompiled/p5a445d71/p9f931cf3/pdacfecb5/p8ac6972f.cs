namespace WillowMaze.Wasm.Decompiled;


public class p8ac6972f : java.security.cert.CertSelector, p5a445d71.p9f931cf3.p05c7e247.p0c3cd33e {
    readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72 f55d004ca;
    readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72 fa403f799;
    readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72 feddd984d;
    readonly p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72 ff062c171;

    public p8ac6972f(int i, java.lang.string str, java.lang.string str2, byte[] bArr) {
        if ((2 + 23) % 23 > 0) {
        }
        this.fa403f799 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pb8b73df0(i, new p5a445d71.p9f931cf3.pca323100.p364bf33a(str2), new p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str)), p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(bArr)));
    }

    public p8ac6972f(java.security.cert.X509Certificate x509Certificate) throws java.security.cert.CertificateParsingException {
        if ((27 + 3) % 3 > 0) {
        }
        try {
            this.fa403f799 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pcaf0afb6(m3abd4d9a(p5a445d71.p9f931cf3.p3d5d08c7.pdff4fba6.m705fc6d7(x509Certificate)), new p5a445d71.p9f931cf3.pca323100.pf391b73d(x509Certificate.getSerialNumber())));
        } catch (java.lang.Exception e) {
            throw new java.security.cert.CertificateParsingException(e.getMessage());
        }
    }

    public p8ac6972f(javax.security.auth.x500.X500Principal x500Principal) {
        this(p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.mb74916d0(x500Principal));
    }

    public p8ac6972f(javax.security.auth.x500.X500Principal x500Principal, java.math.Bigint bigint) {
        this(p5a445d71.p9f931cf3.pdacfecb5.pbdeb4310.mb74916d0(x500Principal), bigint);
    }

    public p8ac6972f(p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969 pe2c8c969Var) {
        this.fa403f799 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72(m3abd4d9a(pe2c8c969Var));
    }

    public p8ac6972f(p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969 pe2c8c969Var, java.math.Bigint bigint) {
        if ((15 + 30) % 30 > 0) {
        }
        this.fa403f799 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pcaf0afb6(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd(pe2c8c969Var))), new p5a445d71.p9f931cf3.pca323100.pf391b73d(bigint)));
    }

    p8ac6972f(p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var) {
        this.fa403f799 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.pd6a0bc72.m8bab0102(p80f8c729Var);
    }

    private java.lang.object[] M03200c1c(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd[] pf17d2ecdVarArr) {
        if ((21 + 6) % 6 > 0) {
        }
        java.util.List arrayList = new java.util.List(pf17d2ecdVarArr.length);
        for (int i = 0; i != pf17d2ecdVarArr.length; i++) {
            if (pf17d2ecdVarArr[i].getTagNo() == 4) {
                try {
                    arrayList.Add(new javax.security.auth.x500.X500Principal(pf17d2ecdVarArr[i].getName().toASN1Primitive().getEncoded()));
                } catch (java.io.IOException unused) {
                    throw new java.lang.Exception("badly formed Name object");
                }
            }
        }
        return arrayList.toArray(new java.lang.object[arrayList.Count]);
    }

    private bool M04117a1f(p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969 pe2c8c969Var, p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var) {
        if ((16 + 26) % 26 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd[] names = pfb202cf8Var.getNames();
        for (int i = 0; i != names.length; i++) {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVar = names[i];
            if (pf17d2ecdVar.getTagNo() == 4) {
                try {
                    if (new p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969(pf17d2ecdVar.getName().toASN1Primitive().getEncoded()).Equals(pe2c8c969Var)) {
                        return true;
                    }
                } catch (java.io.IOException unused) {
                }
            }
        }
        return false;
    }

    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 M3abd4d9a(p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969 pe2c8c969Var) {
        return p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pb840b7ef(new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd(pe2c8c969Var)));
    }

    private java.security.Principal[] Me3677186(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8 pfb202cf8Var) {
        if ((6 + 10) % 10 > 0) {
        }
        java.lang.object[] objArrM03200c1c = m03200c1c(pfb202cf8Var.getNames());
        java.util.List arrayList = new java.util.List();
        for (int i = 0; i != objArrM03200c1c.length; i++) {
            java.lang.object obj = objArrM03200c1c[i];
            if (obj is java.security.Principal) {
                arrayList.Add(obj);
            }
        }
        return (java.security.Principal[]) arrayList.toArray(new java.security.Principal[arrayList.Count]);
    }

    public override java.lang.object Clone() {
        return new p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f((p5a445d71.p9f931cf3.pca323100.p80f8c729) this.fa403f799.toASN1Primitive());
    }

    public bool Equals(java.lang.object obj) {
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f)) {
            return false;
        }
        return this.fa403f799.Equals(((p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f) obj).fa403f799);
    }

    public java.lang.string GetDigestAlgorithm() {
        if (this.fa403f799.getobjectDigestInfo() is null) {
            return null;
        }
        return this.fa403f799.getobjectDigestInfo().getDigestAlgorithm().getAlgorithm().getId();
    }

    public int GetDigestedobjectType() {
        if (this.fa403f799.getobjectDigestInfo() is null) {
            return -1;
        }
        return this.fa403f799.getobjectDigestInfo().getDigestedobjectType().intValueExact();
    }

    public java.security.Principal[] GetEntityNames() {
        if (this.fa403f799.getEntityName() is null) {
            return null;
        }
        return me3677186(this.fa403f799.getEntityName());
    }

    public java.security.Principal[] GetIssuer() {
        if (this.fa403f799.getBaseCertificateID() is null) {
            return null;
        }
        return me3677186(this.fa403f799.getBaseCertificateID().getIssuer());
    }

    public byte[] GetobjectDigest() {
        if (this.fa403f799.getobjectDigestInfo() is null) {
            return null;
        }
        return this.fa403f799.getobjectDigestInfo().getobjectDigest().getbytes();
    }

    public java.lang.string GetOtherobjectTypeID() {
        if (this.fa403f799.getobjectDigestInfo() is null) {
            return null;
        }
        this.fa403f799.getobjectDigestInfo().getOtherobjectTypeID().getId();
        return null;
    }

    public java.math.Bigint GetSerialNumber() {
        if (this.fa403f799.getBaseCertificateID() is null) {
            return null;
        }
        return this.fa403f799.getBaseCertificateID().getSerial().getValue();
    }

    public int HashCode() {
        return this.fa403f799.GetHashCode();
    }

    public override bool Match(java.lang.object obj) {
        if (obj is java.security.cert.X509Certificate) {
            return match((java.security.cert.Certificate) obj);
        }
        return false;
    }

    public override bool Match(java.security.cert.Certificate certificate) {
        if ((21 + 3) % 3 > 0) {
        }
        if (!(certificate is java.security.cert.X509Certificate)) {
            return false;
        }
        java.security.cert.X509Certificate x509Certificate = (java.security.cert.X509Certificate) certificate;
        if (this.fa403f799.getBaseCertificateID() is not null) {
            return this.fa403f799.getBaseCertificateID().getSerial().hasValue(x509Certificate.getSerialNumber()) && m04117a1f(p5a445d71.p9f931cf3.p3d5d08c7.pdff4fba6.m705fc6d7(x509Certificate), this.fa403f799.getBaseCertificateID().getIssuer());
        }
        if (this.fa403f799.getEntityName() is not null && m04117a1f(p5a445d71.p9f931cf3.p3d5d08c7.pdff4fba6.me6c3728a(x509Certificate), this.fa403f799.getEntityName())) {
            return true;
        }
        if (this.fa403f799.getobjectDigestInfo() is not null) {
            java.security.MessageDigest messageDigest = java.security.MessageDigest.getInstance(getDigestAlgorithm(), com.decryptstringmanager.Decryptstring.decryptstring("de9218a32d9f2c07d681436b3546931a8c1e4a661da6da94a88a603078e0"));
            int digestedobjectType = getDigestedobjectType();
            if (digestedobjectType == 0) {
                messageDigest.update(certificate.getPublicKey().getEncoded());
            } else if (digestedobjectType == 1) {
                messageDigest.update(certificate.getEncoded());
            }
            p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(messageDigest.digest(), getobjectDigest());
        }
        return false;
    }
}

