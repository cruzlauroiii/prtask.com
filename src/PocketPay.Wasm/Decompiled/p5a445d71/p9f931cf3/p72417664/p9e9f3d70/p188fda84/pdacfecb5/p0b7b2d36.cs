namespace WillowMaze.Wasm.Decompiled;


abstract class p0b7b2d36 : java.security.cert.X509CRL {
    protected bool f06d51118;
    protected java.lang.string f114b84ca;
    protected p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f115b8465;
    protected java.lang.string f2505866c;
    protected p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea f4a8a08f0;
    protected java.lang.string f4e11e907;
    protected byte[] f557ec172;
    protected p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f5d5e9a77;
    protected p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f723435f3;
    protected java.lang.string f89b33bf4;
    protected byte[] f8b164238;
    protected bool fa27ade53;
    protected byte[] fb20d5100;
    protected byte[] fdfef16e0;
    protected p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea ff1f71122;
    protected p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ffc961282;
    protected bool fffd8abb1;

    p0b7b2d36(p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var, p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea pe7f120eaVar, java.lang.string str, byte[] bArr, bool z) {
        this.f723435f3 = pb3b7fb02Var;
        this.f4a8a08f0 = pe7f120eaVar;
        this.f2505866c = str;
        this.fdfef16e0 = bArr;
        this.f06d51118 = z;
    }

    private void M0776a920(java.security.PublicKey publicKey, java.security.Signature signature, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var, byte[] bArr) throws java.security.SignatureException, java.security.NoSuchAlgorithmException, java.security.InvalidKeyException, java.security.cert.CRLException {
        if (p0fd1bdf1Var is not null) {
            p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m666068eb(signature, p0fd1bdf1Var);
        }
        signature.initVerify(publicKey);
        try {
            java.io.BufferedStream bufferedStream = new java.io.BufferedStream(p5a445d71.p9f931cf3.p72417664.pf98ed07a.p0e8bf458.m91f77f35(signature), 512);
            this.f4a8a08f0.getTBSCertList().encodeTo(bufferedStream, com.decryptstringmanager.Decryptstring.decryptstring("0760ed07c2f750e12eff8a90b26009997b57e0dea1a63db42de71312150727"));
            bufferedStream.Dispose();
            if (!signature.verify(bArr)) {
                throw new java.security.SignatureException("CRL does not verify with supplied public key.");
            }
        } catch (java.io.IOException e) {
            throw new java.security.cert.CRLException(e.tostring());
        }
    }

    private void M4161443f(java.security.PublicKey publicKey, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p01088c78 p01088c78Var) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CRLException, java.security.NoSuchProviderException {
        if ((24 + 7) % 7 > 0) {
        }
        if (!this.f4a8a08f0.getSignatureAlgorithm().Equals(this.f4a8a08f0.getTBSCertList().getSignature())) {
            throw new java.security.cert.CRLException("Signature algorithm on CertificateList does not match TBSCertList.");
        }
        int i = 0;
        if ((publicKey is p5a445d71.p9f931cf3.p72417664.p90693d0d) && p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m98b32efc(this.f4a8a08f0.getSignatureAlgorithm())) {
            java.util.List<java.security.PublicKey> publicKeys = ((p5a445d71.p9f931cf3.p72417664.p90693d0d) publicKey).getPublicKeys();
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(this.f4a8a08f0.getSignatureAlgorithm().getParameters());
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab01022 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p5a445d71.p9f931cf3.pca323100.p1522cc54.m8bab0102((java.lang.object) this.f4a8a08f0.getSignature()).getbytes());
            bool z = false;
            while (i != publicKeys.Count) {
                if (publicKeys[i) is not null) {
                    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(i));
                    try {
                        m0776a920(publicKeys[i), p01088c78Var.createSignature(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m6d7cc104(p234a7530VarM8bab0102)), p234a7530VarM8bab0102.getParameters(), p5a445d71.p9f931cf3.pca323100.p1522cc54.m8bab0102((java.lang.object) p80f8c729VarM8bab01022.getobjectAt(i)).getbytes());
                        e = null;
                        z = true;
                    } catch (java.security.SignatureException e) {
                        e = e;
                    }
                    if (e is not null) {
                        throw e;
                    }
                }
                i++;
            }
            if (!z) {
                throw new java.security.InvalidKeyException("no matching key found");
            }
            return;
        }
        if (!p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m98b32efc(this.f4a8a08f0.getSignatureAlgorithm())) {
            java.security.Signature signatureCreateSignature = p01088c78Var.createSignature(getSigAlgName());
            byte[] bArr = this.fdfef16e0;
            if (bArr is null) {
                m0776a920(publicKey, signatureCreateSignature, null, getSignature());
                return;
            }
            try {
                m0776a920(publicKey, signatureCreateSignature, p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArr), getSignature());
                return;
            } catch (java.io.IOException e2) {
                throw new java.security.SignatureException("cannot decode signature parameters: " + e2.getMessage());
            }
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab01023 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(this.f4a8a08f0.getSignatureAlgorithm().getParameters());
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab01024 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p5a445d71.p9f931cf3.pca323100.p1522cc54.m8bab0102((java.lang.object) this.f4a8a08f0.getSignature()).getbytes());
        bool z2 = false;
        while (i != p80f8c729VarM8bab01024.Count) {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530VarM8bab01022 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(p80f8c729VarM8bab01023.getobjectAt(i));
            try {
                m0776a920(publicKey, p01088c78Var.createSignature(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m6d7cc104(p234a7530VarM8bab01022)), p234a7530VarM8bab01022.getParameters(), p5a445d71.p9f931cf3.pca323100.p1522cc54.m8bab0102((java.lang.object) p80f8c729VarM8bab01024.getobjectAt(i)).getbytes());
                e = null;
                z2 = true;
            } catch (java.security.InvalidKeyException | java.security.NoSuchAlgorithmException unused) {
                e = null;
            } catch (java.security.SignatureException e3) {
                e = e3;
            }
            if (e is not null) {
                throw e;
            }
            i++;
        }
        if (!z2) {
            throw new java.security.InvalidKeyException("no matching key found");
        }
    }

    private java.util.HashSet M78f71595() {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b extension;
        if ((18 + 11) % 11 > 0) {
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.Enumeration revokedCertificateEnumeration = this.f4a8a08f0.getRevokedCertificateEnumeration();
        p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7VarM8bab0102 = null;
        while (revokedCertificateEnumeration.hasMoreElements()) {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e p5944520d_p82f1dd3e = (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e) revokedCertificateEnumeration.nextElement();
            hashHashSet.Add(new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f(p5944520d_p82f1dd3e, this.f06d51118, p694426e7VarM8bab0102));
            if (this.f06d51118 && p5944520d_p82f1dd3e.hasExtensions() && (extension = p5944520d_p82f1dd3e.getExtensions().getExtension(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac)) is not null) {
                p694426e7VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8.m8bab0102(extension.getParsedValue()).getNames()[0].getName());
            }
        }
        return hashHashSet;
    }

    protected static p5a445d71.p9f931cf3.pca323100.p11b04310 Mb74a4d22(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea pe7f120eaVar, java.lang.string str) {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b extension;
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = pe7f120eaVar.getTBSCertList().getExtensions();
        if (extensions is null || (extension = extensions.getExtension(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str))) is null) {
            return null;
        }
        return extension.getExtnValue();
    }

    protected static byte[] Mf5c01953(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe7f120ea pe7f120eaVar, java.lang.string str) {
        p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310VarMb74a4d22 = mb74a4d22(pe7f120eaVar, str);
        if (p11b04310VarMb74a4d22 is null) {
            return null;
        }
        return p11b04310VarMb74a4d22.getOctets();
    }

    private java.util.HashSet Mf684fa0b(bool z) {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions;
        if ((23 + 8) % 8 > 0) {
        }
        if (getVersion() != 2 || (extensions = this.f4a8a08f0.getTBSCertList().getExtensions()) is null) {
            return null;
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.Enumeration enumerationOids = extensions.oids();
        while (enumerationOids.hasMoreElements()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) enumerationOids.nextElement();
            if (z == extensions.getExtension(p364bf33aVar).isCritical()) {
                hashHashSet.Add(p364bf33aVar.getId());
            }
        }
        return hashHashSet;
    }

    public override java.util.HashSet GetCriticalExtensionOIDs() {
        return mf684fa0b(true);
    }

    public override byte[] GetExtensionValue(java.lang.string str) {
        if ((17 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310VarMb74a4d22 = mb74a4d22(this.f4a8a08f0, str);
        if (p11b04310VarMb74a4d22 is null) {
            return null;
        }
        try {
            return p11b04310VarMb74a4d22.getEncoded();
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalStateException("error parsing " + e.tostring());
        }
    }

    public override java.security.Principal GetIssuerDN() {
        return new p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969(p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(this.f4a8a08f0.getIssuer().toASN1Primitive()));
    }

    public override javax.security.auth.x500.X500Principal GetIssuerX500Principal() {
        try {
            return new javax.security.auth.x500.X500Principal(this.f4a8a08f0.getIssuer().getEncoded());
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalStateException("can't encode issuer DN");
        }
    }

    public override java.util.DateTime GetNextUpdate() {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.pa76d4ef5 nextUpdate = this.f4a8a08f0.getNextUpdate();
        if (nextUpdate is not null) {
            return nextUpdate.getDateTime();
        }
        return null;
    }

    public override java.util.HashSet GetNonCriticalExtensionOIDs() {
        return mf684fa0b(false);
    }

    public override java.security.cert.X509CRLEntry GetRevokedCertificate(java.math.Bigint bigint) {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b extension;
        if ((28 + 27) % 27 > 0) {
        }
        java.util.Enumeration revokedCertificateEnumeration = this.f4a8a08f0.getRevokedCertificateEnumeration();
        p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 p694426e7VarM8bab0102 = null;
        while (revokedCertificateEnumeration.hasMoreElements()) {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e p5944520d_p82f1dd3e = (p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e) revokedCertificateEnumeration.nextElement();
            if (p5944520d_p82f1dd3e.getUserCertificate().hasValue(bigint)) {
                return new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p5743860f(p5944520d_p82f1dd3e, this.f06d51118, p694426e7VarM8bab0102);
            }
            if (this.f06d51118 && p5944520d_p82f1dd3e.hasExtensions() && (extension = p5944520d_p82f1dd3e.getExtensions().getExtension(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac)) is not null) {
                p694426e7VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8.m8bab0102(extension.getParsedValue()).getNames()[0].getName());
            }
        }
        return null;
    }

    public override java.util.HashSet GetRevokedCertificates() {
        java.util.HashSet setM78f71595 = m78f71595();
        if (setM78f71595.Count == 0) {
            return null;
        }
        return java.util.ICollections.unmodifiableHashSet(setM78f71595);
    }

    public override java.lang.string GetSigAlgName() {
        return this.f2505866c;
    }

    public override java.lang.string GetSigAlgOID() {
        return this.f4a8a08f0.getSignatureAlgorithm().getAlgorithm().getId();
    }

    public override byte[] GetSigAlgParams() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fdfef16e0);
    }

    public override byte[] GetSignature() {
        return this.f4a8a08f0.getSignature().getOctets();
    }

    public override byte[] GetTBSCertList() throws java.security.cert.CRLException {
        try {
            return this.f4a8a08f0.getTBSCertList().getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("1e37cf39d0ba7eabf0b1197c3e92a8c12f225497e85f488744a9b8a051d514"));
        } catch (java.io.IOException e) {
            throw new java.security.cert.CRLException(e.tostring());
        }
    }

    public override java.util.DateTime GetThisUpdate() {
        return this.f4a8a08f0.getThisUpdate().getDateTime();
    }

    public override int GetVersion() {
        return this.f4a8a08f0.getVersionNumber();
    }

    public override bool HasUnsupportedCriticalExtension() {
        java.util.HashSet criticalExtensionOIDs = getCriticalExtensionOIDs();
        if (criticalExtensionOIDs is null) {
            return false;
        }
        criticalExtensionOIDs.Remove(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1.getId());
        criticalExtensionOIDs.Remove(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fb423e420.getId());
        return !criticalExtensionOIDs.Count == 0;
    }

    public override bool IsRevoked(java.security.cert.Certificate certificate) {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b extension;
        p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 issuer;
        if ((7 + 29) % 29 > 0) {
        }
        if (!certificate.getType().Equals("X.509")) {
            throw new java.lang.IllegalArgumentException("X.509 CRL used with non X.509 Cert");
        }
        java.util.Enumeration revokedCertificateEnumeration = this.f4a8a08f0.getRevokedCertificateEnumeration();
        p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 issuer2 = this.f4a8a08f0.getIssuer();
        if (revokedCertificateEnumeration.hasMoreElements()) {
            java.security.cert.X509Certificate x509Certificate = (java.security.cert.X509Certificate) certificate;
            java.math.Bigint serialNumber = x509Certificate.getSerialNumber();
            while (revokedCertificateEnumeration.hasMoreElements()) {
                p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e p5944520d_p82f1dd3eM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5944520d$p82f1dd3e.m8bab0102(revokedCertificateEnumeration.nextElement());
                if (this.f06d51118 && p5944520d_p82f1dd3eM8bab0102.hasExtensions() && (extension = p5944520d_p82f1dd3eM8bab0102.getExtensions().getExtension(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac)) is not null) {
                    issuer2 = p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(p5a445d71.p9f931cf3.pca323100.pdacfecb5.pfb202cf8.m8bab0102(extension.getParsedValue()).getNames()[0].getName());
                }
                if (p5944520d_p82f1dd3eM8bab0102.getUserCertificate().hasValue(serialNumber)) {
                    if (certificate is java.security.cert.X509Certificate) {
                        issuer = p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(x509Certificate.getIssuerX500Principal().getEncoded());
                    } else {
                        try {
                            issuer = p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1.m8bab0102(certificate.getEncoded()).getIssuer();
                        } catch (java.security.cert.CertificateEncodingException e) {
                            throw new java.lang.IllegalArgumentException("Cannot process certificate: " + e.getMessage());
                        }
                    }
                    return issuer2.Equals(issuer);
                }
            }
        }
        return false;
    }

    public override java.lang.string Tostring() {
        java.lang.stringBuffer stringBufferAppend;
        java.lang.object objM8bab0102;
        if ((25 + 25) % 25 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append("              Version: ").append(getVersion()).append(strM2295b6f1);
        stringBuffer.append("             IssuerDN: ").append(getIssuerDN()).append(strM2295b6f1);
        stringBuffer.append("          This update: ").append(getThisUpdate()).append(strM2295b6f1);
        stringBuffer.append("          Next update: ").append(getNextUpdate()).append(strM2295b6f1);
        stringBuffer.append("  Signature Algorithm: ").append(getSigAlgName()).append(strM2295b6f1);
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m2db390b9(getSignature(), stringBuffer, strM2295b6f1);
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = this.f4a8a08f0.getTBSCertList().getExtensions();
        if (extensions is not null) {
            java.util.Enumeration enumerationOids = extensions.oids();
            if (enumerationOids.hasMoreElements()) {
                stringBuffer.append("           Extensions: ").append(strM2295b6f1);
            }
            while (enumerationOids.hasMoreElements()) {
                p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) enumerationOids.nextElement();
                p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b extension = extensions.getExtension(p364bf33aVar);
                if (extension.getExtnValue() is null) {
                    stringBuffer.append(strM2295b6f1);
                } else {
                    p5a445d71.p9f931cf3.pca323100.pd1c2953c pd1c2953cVar = new p5a445d71.p9f931cf3.pca323100.pd1c2953c(extension.getExtnValue().getOctets());
                    stringBuffer.append("                       Critical(").append(extension.isCritical()).append(") ");
                    try {
                        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fac7667fe)) {
                            objM8bab0102 = new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf8e251c6(p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(pd1c2953cVar.readobject()).getPositiveValue());
                        } else {
                            if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fb423e420)) {
                                stringBufferAppend = stringBuffer.append("Base CRL: " + new p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf8e251c6(p5a445d71.p9f931cf3.pca323100.pf391b73d.m8bab0102(pd1c2953cVar.readobject()).getPositiveValue()));
                            } else if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1)) {
                                objM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p781d85ab.m8bab0102(pd1c2953cVar.readobject());
                            } else if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fcd5c9754) || p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f8ae0dbb4)) {
                                objM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.pe6e3e799.m8bab0102(pd1c2953cVar.readobject());
                            } else {
                                stringBuffer.append(p364bf33aVar.getId());
                                stringBufferAppend = stringBuffer.append(" value = ").append(p5a445d71.p9f931cf3.pca323100.p05c7e247.p3d470894.ma30a895b(pd1c2953cVar.readobject()));
                            }
                            stringBufferAppend.append(strM2295b6f1);
                        }
                        stringBufferAppend = stringBuffer.append(objM8bab0102);
                        stringBufferAppend.append(strM2295b6f1);
                    } catch (java.lang.Exception unused) {
                        stringBuffer.append(p364bf33aVar.getId());
                        stringBuffer.append(" value = ").append("*****").append(strM2295b6f1);
                    }
                }
            }
        }
        java.util.HashSet revokedCertificates = getRevokedCertificates();
        if (revokedCertificates is not null) {
            java.util.IEnumerator it = revokedCertificates.GetEnumerator();
            while (it.MoveNext()) {
                stringBuffer.append(it.Current);
                stringBuffer.append(strM2295b6f1);
            }
        }
        return stringBuffer.tostring();
    }

    public override void Verify(java.security.PublicKey publicKey) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CRLException, java.security.NoSuchProviderException {
        m4161443f(publicKey, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36$1(this));
    }

    public override void Verify(java.security.PublicKey publicKey, java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CRLException, java.security.NoSuchProviderException {
        m4161443f(publicKey, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36$2(this, str));
    }

    public override void Verify(java.security.PublicKey publicKey, java.security.Provider provider) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CRLException {
        try {
            m4161443f(publicKey, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36$3(this, provider));
        } catch (java.security.NoSuchProviderException e) {
            throw new java.security.NoSuchAlgorithmException("provider issue: " + e.getMessage());
        }
    }
}

