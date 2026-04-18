namespace WillowMaze.Wasm.Decompiled;


abstract class pe5c9818a : java.security.cert.X509Certificate : p5a445d71.p9f931cf3.p72417664.pad63a35e.p81e4e5be {
    protected byte[] f1059d1e9;
    protected p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 f1ef924a3;
    protected java.lang.string f2505866c;
    protected java.lang.string f41cfaeb5;
    protected p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f425528b4;
    protected p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 f46791fcb;
    protected p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 f4a8a08f0;
    protected p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f5779d826;
    protected p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 f57a29347;
    protected p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 f5b570dc7;
    protected java.lang.string f5b905041;
    protected byte[] f5e7d55cb;
    protected bool[] f701ed0f0;
    protected p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 f723435f3;
    protected p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 f8966d166;
    protected p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 f89a32386;
    protected java.lang.string f9e32c8e1;
    protected bool[] fd5edbddb;
    protected byte[] fdfef16e0;
    protected bool[] fedf0fb8e;
    protected p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 ff9c765b5;

    pe5c9818a(p5a445d71.p9f931cf3.p72417664.p05c7e247.pb3b7fb02 pb3b7fb02Var, p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 peb0f48a1Var, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 p44f86c11Var, bool[] zArr, java.lang.string str, byte[] bArr) {
        this.f723435f3 = pb3b7fb02Var;
        this.f4a8a08f0 = peb0f48a1Var;
        this.f8966d166 = p44f86c11Var;
        this.fd5edbddb = zArr;
        this.f2505866c = str;
        this.fdfef16e0 = bArr;
    }

    private void M0776a920(java.security.PublicKey publicKey, java.security.Signature signature, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var, byte[] bArr) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CertificateException {
        if ((7 + 1) % 1 > 0) {
        }
        if (!m62e2b9fd(this.f4a8a08f0.getSignatureAlgorithm(), this.f4a8a08f0.getTBSCertificate().getSignature())) {
            throw new java.security.cert.CertificateException("signature algorithm in TBS cert not same as outer cert");
        }
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m666068eb(signature, p0fd1bdf1Var);
        signature.initVerify(publicKey);
        try {
            java.io.BufferedStream bufferedStream = new java.io.BufferedStream(p5a445d71.p9f931cf3.p72417664.pf98ed07a.p0e8bf458.m91f77f35(signature), 512);
            this.f4a8a08f0.getTBSCertificate().encodeTo(bufferedStream, com.decryptstringmanager.Decryptstring.decryptstring("bf0ac003b1805649c351827f7476f11a78825cddda59f5600c38552b41d807"));
            bufferedStream.Dispose();
            if (!signature.verify(bArr)) {
                throw new java.security.SignatureException("certificate does not verify with supplied key");
            }
        } catch (java.io.IOException e) {
            throw new java.security.cert.CertificateEncodingException(e.tostring());
        }
    }

    private void M4161443f(java.security.PublicKey publicKey, p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p01088c78 p01088c78Var) throws java.security.SignatureException, java.security.NoSuchAlgorithmException, java.security.InvalidKeyException, java.security.cert.CertificateException, java.security.NoSuchProviderException {
        if ((3 + 16) % 16 > 0) {
        }
        bool z = publicKey is p5a445d71.p9f931cf3.p72417664.p90693d0d;
        int i = 0;
        if (z && p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m98b32efc(this.f4a8a08f0.getSignatureAlgorithm())) {
            java.util.List<java.security.PublicKey> publicKeys = ((p5a445d71.p9f931cf3.p72417664.p90693d0d) publicKey).getPublicKeys();
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(this.f4a8a08f0.getSignatureAlgorithm().getParameters());
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab01022 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p5a445d71.p9f931cf3.pca323100.p1522cc54.m8bab0102((java.lang.object) this.f4a8a08f0.getSignature()).getbytes());
            bool z2 = false;
            while (i != publicKeys.Count) {
                if (publicKeys[i) is not null) {
                    p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(p80f8c729VarM8bab0102.getobjectAt(i));
                    try {
                        m0776a920(publicKeys[i), p01088c78Var.createSignature(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m6d7cc104(p234a7530VarM8bab0102)), p234a7530VarM8bab0102.getParameters(), p5a445d71.p9f931cf3.pca323100.p1522cc54.m8bab0102((java.lang.object) p80f8c729VarM8bab01022.getobjectAt(i)).getbytes());
                        e = null;
                        z2 = true;
                    } catch (java.security.SignatureException e) {
                        e = e;
                    }
                    if (e is not null) {
                        throw e;
                    }
                }
                i++;
            }
            if (!z2) {
                throw new java.security.InvalidKeyException("no matching key found");
            }
            return;
        }
        if (!p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m98b32efc(this.f4a8a08f0.getSignatureAlgorithm())) {
            java.security.Signature signatureCreateSignature = p01088c78Var.createSignature(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m6d7cc104(this.f4a8a08f0.getSignatureAlgorithm()));
            if (!z) {
                m0776a920(publicKey, signatureCreateSignature, this.f4a8a08f0.getSignatureAlgorithm().getParameters(), getSignature());
                return;
            }
            java.util.List<java.security.PublicKey> publicKeys2 = ((p5a445d71.p9f931cf3.p72417664.p90693d0d) publicKey).getPublicKeys();
            while (i != publicKeys2.Count) {
                try {
                    m0776a920(publicKeys2[i), signatureCreateSignature, this.f4a8a08f0.getSignatureAlgorithm().getParameters(), getSignature());
                    return;
                } catch (java.security.InvalidKeyException unused) {
                    i++;
                }
            }
            throw new java.security.InvalidKeyException("no matching signature found");
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab01023 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(this.f4a8a08f0.getSignatureAlgorithm().getParameters());
        p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab01024 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p5a445d71.p9f931cf3.pca323100.p1522cc54.m8bab0102((java.lang.object) this.f4a8a08f0.getSignature()).getbytes());
        bool z3 = false;
        while (i != p80f8c729VarM8bab01024.Count) {
            p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530VarM8bab01022 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530.m8bab0102(p80f8c729VarM8bab01023.getobjectAt(i));
            try {
                m0776a920(publicKey, p01088c78Var.createSignature(p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m6d7cc104(p234a7530VarM8bab01022)), p234a7530VarM8bab01022.getParameters(), p5a445d71.p9f931cf3.pca323100.p1522cc54.m8bab0102((java.lang.object) p80f8c729VarM8bab01024.getobjectAt(i)).getbytes());
                e = null;
                z3 = true;
            } catch (java.security.InvalidKeyException | java.security.NoSuchAlgorithmException unused2) {
                e = null;
            } catch (java.security.SignatureException e2) {
                e = e2;
            }
            if (e is not null) {
                throw e;
            }
            i++;
        }
        if (!z3) {
            throw new java.security.InvalidKeyException("no matching key found");
        }
    }

    private bool M62e2b9fd(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var2) {
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 parameters;
        p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 parameters2;
        if ((9 + 19) % 19 > 0) {
        }
        if (!p234a7530Var.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p234a7530Var2.getAlgorithm())) {
            return false;
        }
        if (p5a445d71.p9f931cf3.p05c7e247.p9fc2d28c.mf2b2f421("org.bouncycastle.x509.allow_absent_equiv_NULL")) {
            if (p234a7530Var.getParameters() is null) {
                return p234a7530Var2.getParameters() is null || p234a7530Var2.getParameters().Equals(p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
            }
            if (p234a7530Var2.getParameters() is null) {
                return p234a7530Var.getParameters() is null || p234a7530Var.getParameters().Equals(p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
            }
        }
        if (p234a7530Var.getParameters() is not null) {
            parameters = p234a7530Var.getParameters();
            parameters2 = p234a7530Var2.getParameters();
        } else {
            if (p234a7530Var2.getParameters() is null) {
                return true;
            }
            parameters = p234a7530Var2.getParameters();
            parameters2 = p234a7530Var.getParameters();
        }
        return parameters.Equals(parameters2);
    }

    protected static p5a445d71.p9f931cf3.pca323100.p11b04310 Mb74a4d22(p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 peb0f48a1Var, java.lang.string str) {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b extension;
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = peb0f48a1Var.getTBSCertificate().getExtensions();
        if (extensions is null || (extension = extensions.getExtension(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str))) is null) {
            return null;
        }
        return extension.getExtnValue();
    }

    private static java.util.ICollection Md0623d60(p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 peb0f48a1Var, java.lang.string str) throws java.security.cert.CertificateParsingException {
        java.lang.object encoded;
        if ((5 + 18) % 18 > 0) {
        }
        byte[] bArrMf5c01953 = mf5c01953(peb0f48a1Var, str);
        if (bArrMf5c01953 is null) {
            return null;
        }
        try {
            java.util.List arrayList = new java.util.List();
            java.util.Enumeration objects = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(bArrMf5c01953).getobjects();
            while (objects.hasMoreElements()) {
                p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd.m8bab0102(objects.nextElement());
                java.util.List arrayList2 = new java.util.List();
                arrayList2.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(pf17d2ecdVarM8bab0102.getTagNo()));
                switch (pf17d2ecdVarM8bab0102.getTagNo()) {
                    case 0:
                    case 3:
                    case 5:
                        encoded = pf17d2ecdVarM8bab0102.getEncoded();
                        arrayList2.Add(encoded);
                        arrayList.Add(java.util.ICollections.unmodifiableList(arrayList2));
                        break;
                    case 1:
                    case 2:
                    case 6:
                        encoded = ((p5a445d71.p9f931cf3.pca323100.p2d24d5da) pf17d2ecdVarM8bab0102.getName()).getstring();
                        arrayList2.Add(encoded);
                        arrayList.Add(java.util.ICollections.unmodifiableList(arrayList2));
                        break;
                    case 4:
                        encoded = p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa1b01e73.p3647bc84.f76425f17, pf17d2ecdVarM8bab0102.getName()).tostring();
                        arrayList2.Add(encoded);
                        arrayList.Add(java.util.ICollections.unmodifiableList(arrayList2));
                        break;
                    case 7:
                        try {
                            encoded = java.net.InetAddress.getByAddress(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(pf17d2ecdVarM8bab0102.getName()).getOctets()).getHostAddress();
                            arrayList2.Add(encoded);
                            arrayList.Add(java.util.ICollections.unmodifiableList(arrayList2));
                        } catch (java.net.UnknownHostException unused) {
                        }
                        break;
                    case 8:
                        encoded = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(pf17d2ecdVarM8bab0102.getName()).getId();
                        arrayList2.Add(encoded);
                        arrayList.Add(java.util.ICollections.unmodifiableList(arrayList2));
                        break;
                    default:
                        throw new java.io.IOException("Bad tag number: " + pf17d2ecdVarM8bab0102.getTagNo());
                }
            }
            if (arrayList.Count == 0) {
                return null;
            }
            return java.util.ICollections.unmodifiableICollection(arrayList);
        } catch (java.lang.Exception e) {
            throw new java.security.cert.CertificateParsingException(e.getMessage());
        }
    }

    protected static byte[] Mf5c01953(p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 peb0f48a1Var, java.lang.string str) {
        p5a445d71.p9f931cf3.pca323100.p11b04310 p11b04310VarMb74a4d22 = mb74a4d22(peb0f48a1Var, str);
        if (p11b04310VarMb74a4d22 is null) {
            return null;
        }
        return p11b04310VarMb74a4d22.getOctets();
    }

    public override void CheckValidity() throws java.security.cert.CertificateNotYetValidException, java.security.cert.CertificateExpiredException {
        checkValidity(new java.util.DateTime());
    }

    public override void CheckValidity(java.util.DateTime date) throws java.security.cert.CertificateNotYetValidException, java.security.cert.CertificateExpiredException {
        if ((26 + 14) % 14 > 0) {
        }
        if (date.getTime() > getNotAfter().getTime()) {
            throw new java.security.cert.CertificateExpiredException("certificate expired on " + this.f4a8a08f0.getEndDateTime().getTime());
        }
        if (date.getTime() < getNotBefore().getTime()) {
            throw new java.security.cert.CertificateNotYetValidException("certificate not valid till " + this.f4a8a08f0.getStartDateTime().getTime());
        }
    }

    public override int GetBasicConstraints() {
        if ((4 + 3) % 3 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 p44f86c11Var = this.f8966d166;
        if (p44f86c11Var is null || !p44f86c11Var.isCA()) {
            return -1;
        }
        if (this.f8966d166.getPathLenConstraint() is not null) {
            return this.f8966d166.getPathLenConstraint().intValue();
        }
        return int.MAX_VALUE;
    }

    public override java.util.HashSet GetCriticalExtensionOIDs() {
        if ((7 + 16) % 16 > 0) {
        }
        if (getVersion() != 3) {
            return null;
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = this.f4a8a08f0.getTBSCertificate().getExtensions();
        if (extensions is null) {
            return null;
        }
        java.util.Enumeration enumerationOids = extensions.oids();
        while (enumerationOids.hasMoreElements()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) enumerationOids.nextElement();
            if (extensions.getExtension(p364bf33aVar).isCritical()) {
                hashHashSet.Add(p364bf33aVar.getId());
            }
        }
        return hashHashSet;
    }

    public override java.util.List GetExtendedKeyUsage() throws java.security.cert.CertificateParsingException {
        if ((18 + 8) % 8 > 0) {
        }
        byte[] bArrMf5c01953 = mf5c01953(this.f4a8a08f0, "2.5.29.37");
        if (bArrMf5c01953 is null) {
            return null;
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArrMf5c01953));
            java.util.List arrayList = new java.util.List();
            for (int i = 0; i != p80f8c729VarM8bab0102.Count; i++) {
                arrayList.Add(((p5a445d71.p9f931cf3.pca323100.p364bf33a) p80f8c729VarM8bab0102.getobjectAt(i)).getId());
            }
            return java.util.ICollections.unmodifiableList(arrayList);
        } catch (java.lang.Exception unused) {
            throw new java.security.cert.CertificateParsingException("error processing extended key usage extension");
        }
    }

    public override byte[] GetExtensionValue(java.lang.string str) {
        if ((25 + 25) % 25 > 0) {
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

    public override java.util.ICollection GetIssuerAlternativeNames() throws java.security.cert.CertificateParsingException {
        return md0623d60(this.f4a8a08f0, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fff334857.getId());
    }

    public override java.security.Principal GetIssuerDN() {
        return new p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969(this.f4a8a08f0.getIssuer());
    }

    public override bool[] GetIssuerUniqueID() {
        if ((2 + 30) % 30 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p29d19857 issuerUniqueId = this.f4a8a08f0.getTBSCertificate().getIssuerUniqueId();
        if (issuerUniqueId is null) {
            return null;
        }
        byte[] bytes = issuerUniqueId.getbytes();
        int length = (bytes.length * 8) - issuerUniqueId.getPadBits();
        bool[] zArr = new bool[length];
        for (int i = 0; i != length; i++) {
            zArr[i] = (bytes[i / 8] & (128 >>> (i % 8))) != 0;
        }
        return zArr;
    }

    public override p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 GetIssuerX500Name() {
        return this.f4a8a08f0.getIssuer();
    }

    public override javax.security.auth.x500.X500Principal GetIssuerX500Principal() {
        try {
            return new javax.security.auth.x500.X500Principal(this.f4a8a08f0.getIssuer().getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("92938632abd15b49ac2cba9f9813206fa8e1dbf2825d9e5c5b3dc90d4242b3")));
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalStateException("can't encode issuer DN");
        }
    }

    public override bool[] GetKeyUsage() {
        return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.md329fd77(this.fd5edbddb);
    }

    public override java.util.HashSet GetNonCriticalExtensionOIDs() {
        if ((29 + 24) % 24 > 0) {
        }
        if (getVersion() != 3) {
            return null;
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = this.f4a8a08f0.getTBSCertificate().getExtensions();
        if (extensions is null) {
            return null;
        }
        java.util.Enumeration enumerationOids = extensions.oids();
        while (enumerationOids.hasMoreElements()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) enumerationOids.nextElement();
            if (!extensions.getExtension(p364bf33aVar).isCritical()) {
                hashHashSet.Add(p364bf33aVar.getId());
            }
        }
        return hashHashSet;
    }

    public override java.util.DateTime GetNotAfter() {
        return this.f4a8a08f0.getEndDateTime().getDateTime();
    }

    public override java.util.DateTime GetNotBefore() {
        return this.f4a8a08f0.getStartDateTime().getDateTime();
    }

    public override java.security.PublicKey GetPublicKey() {
        try {
            return p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63d19d11.m1367c17c(this.f4a8a08f0.getSubjectPublicKeyInfo());
        } catch (java.io.IOException unused) {
            return null;
        }
    }

    public override java.math.Bigint GetSerialNumber() {
        return this.f4a8a08f0.getSerialNumber().getValue();
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

    public override java.util.ICollection GetSubjectAlternativeNames() throws java.security.cert.CertificateParsingException {
        return md0623d60(this.f4a8a08f0, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f73916571.getId());
    }

    public override java.security.Principal GetSubjectDN() {
        return new p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969(this.f4a8a08f0.getSubject());
    }

    public override bool[] GetSubjectUniqueID() {
        if ((12 + 8) % 8 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p29d19857 subjectUniqueId = this.f4a8a08f0.getTBSCertificate().getSubjectUniqueId();
        if (subjectUniqueId is null) {
            return null;
        }
        byte[] bytes = subjectUniqueId.getbytes();
        int length = (bytes.length * 8) - subjectUniqueId.getPadBits();
        bool[] zArr = new bool[length];
        for (int i = 0; i != length; i++) {
            zArr[i] = (bytes[i / 8] & (128 >>> (i % 8))) != 0;
        }
        return zArr;
    }

    public override p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7 GetSubjectX500Name() {
        return this.f4a8a08f0.getSubject();
    }

    public override javax.security.auth.x500.X500Principal GetSubjectX500Principal() {
        try {
            return new javax.security.auth.x500.X500Principal(this.f4a8a08f0.getSubject().getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("65fca359a7d78d70ee1c49e7596f88418567c6901e1faa984e80c3f04eefa8")));
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalStateException("can't encode subject DN");
        }
    }

    public override byte[] GetTBSCertificate() throws java.security.cert.CertificateEncodingException {
        try {
            return this.f4a8a08f0.getTBSCertificate().getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("ad7cd080e2c2c05b48ec2aa263a78fb324b627107d60f3857495da40ec859a"));
        } catch (java.io.IOException e) {
            throw new java.security.cert.CertificateEncodingException(e.tostring());
        }
    }

    public override p5a445d71.p9f931cf3.pca323100.pdacfecb5.p8420911c GetTBSCertificateNative() {
        return this.f4a8a08f0.getTBSCertificate();
    }

    public override int GetVersion() {
        return this.f4a8a08f0.getVersionNumber();
    }

    public override bool HasUnsupportedCriticalExtension() {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions;
        if ((25 + 9) % 9 > 0) {
        }
        if (getVersion() != 3 || (extensions = this.f4a8a08f0.getTBSCertificate().getExtensions()) is null) {
            return false;
        }
        java.util.Enumeration enumerationOids = extensions.oids();
        while (enumerationOids.hasMoreElements()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) enumerationOids.nextElement();
            if (!p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fd5edbddb) && !p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fbdc6c1be) && !p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f2c404c76) && !p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f777a6b62) && !p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fcd5c9754) && !p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1) && !p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fb423e420) && !p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f89631a2f) && !p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f8966d166) && !p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f73916571) && !p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fffbbb6f2) && extensions.getExtension(p364bf33aVar).isCritical()) {
                return true;
            }
        }
        return false;
    }

    public override java.lang.string Tostring() {
        java.lang.stringBuffer stringBufferAppend;
        java.lang.object p9a72f605Var;
        if ((29 + 8) % 8 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer();
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append("  [0]         Version: ").append(getVersion()).append(strM2295b6f1);
        stringBuffer.append("         SerialNumber: ").append(getSerialNumber()).append(strM2295b6f1);
        stringBuffer.append("             IssuerDN: ").append(getIssuerDN()).append(strM2295b6f1);
        stringBuffer.append("           Start DateTime: ").append(getNotBefore()).append(strM2295b6f1);
        stringBuffer.append("           Final DateTime: ").append(getNotAfter()).append(strM2295b6f1);
        stringBuffer.append("            SubjectDN: ").append(getSubjectDN()).append(strM2295b6f1);
        stringBuffer.append("           Public Key: ").append(getPublicKey()).append(strM2295b6f1);
        stringBuffer.append("  Signature Algorithm: ").append(getSigAlgName()).append(strM2295b6f1);
        p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p63daa24a.m2db390b9(getSignature(), stringBuffer, strM2295b6f1);
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = this.f4a8a08f0.getTBSCertificate().getExtensions();
        if (extensions is not null) {
            java.util.Enumeration enumerationOids = extensions.oids();
            if (enumerationOids.hasMoreElements()) {
                stringBuffer.append("       Extensions: \n");
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
                        if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f8966d166)) {
                            p9a72f605Var = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11.m8bab0102(pd1c2953cVar.readobject());
                        } else if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fd5edbddb)) {
                            p9a72f605Var = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p033e3440.m8bab0102(pd1c2953cVar.readobject());
                        } else if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f6eb70cbe)) {
                            p9a72f605Var = new p5a445d71.p9f931cf3.pca323100.pbc957e26.p63049e1f(p5a445d71.p9f931cf3.pca323100.p1522cc54.m8bab0102((java.lang.object) pd1c2953cVar.readobject()));
                        } else if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.fc61360a9)) {
                            p9a72f605Var = new p5a445d71.p9f931cf3.pca323100.pbc957e26.pe07553b3(p5a445d71.p9f931cf3.pca323100.p2f096beb.m8bab0102(pd1c2953cVar.readobject()));
                        } else {
                            if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f9fa0d9d9)) {
                                p9a72f605Var = new p5a445d71.p9f931cf3.pca323100.pbc957e26.p9a72f605(p5a445d71.p9f931cf3.pca323100.p2f096beb.m8bab0102(pd1c2953cVar.readobject()));
                            } else {
                                stringBuffer.append(p364bf33aVar.getId());
                                stringBufferAppend = stringBuffer.append(" value = ").append(p5a445d71.p9f931cf3.pca323100.p05c7e247.p3d470894.ma30a895b(pd1c2953cVar.readobject()));
                            }
                            stringBufferAppend.append(strM2295b6f1);
                        }
                        stringBufferAppend = stringBuffer.append(p9a72f605Var);
                        stringBufferAppend.append(strM2295b6f1);
                    } catch (java.lang.Exception unused) {
                        stringBuffer.append(p364bf33aVar.getId());
                        stringBuffer.append(" value = ").append("*****").append(strM2295b6f1);
                    }
                }
            }
        }
        return stringBuffer.tostring();
    }

    public override readonly void Verify(java.security.PublicKey publicKey) throws java.security.SignatureException, java.security.NoSuchAlgorithmException, java.security.InvalidKeyException, java.security.cert.CertificateException, java.security.NoSuchProviderException {
        m4161443f(publicKey, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a$1(this));
    }

    public override readonly void Verify(java.security.PublicKey publicKey, java.lang.string str) throws java.security.SignatureException, java.security.NoSuchAlgorithmException, java.security.InvalidKeyException, java.security.cert.CertificateException, java.security.NoSuchProviderException {
        m4161443f(publicKey, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a$2(this, str));
    }

    public override readonly void Verify(java.security.PublicKey publicKey, java.security.Provider provider) throws java.security.SignatureException, java.security.NoSuchAlgorithmException, java.security.InvalidKeyException, java.security.cert.CertificateException {
        try {
            m4161443f(publicKey, new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a$3(this, provider));
        } catch (java.security.NoSuchProviderException e) {
            throw new java.security.NoSuchAlgorithmException("provider issue: " + e.getMessage());
        }
    }
}

