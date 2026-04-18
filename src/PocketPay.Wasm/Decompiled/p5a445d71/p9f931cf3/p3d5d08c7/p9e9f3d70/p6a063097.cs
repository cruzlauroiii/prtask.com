namespace WillowMaze.Wasm.Decompiled;


public class p6a063097 : java.security.cert.X509Certificate : p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb {
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 f0a324c93;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb f201da641;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb f21f3482b;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb f25b97e1e;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 f4326b9d9;
    private int f491de0d7;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 f4a8a08f0;
    private bool f6483e95f;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 f71f13188;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11 f8966d166;
    private int f8fb7b28a;
    private bool[] f9fbf864f;
    private int fa9e2f859;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 fb2ee7a12;
    private bool[] fd5edbddb;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb fde5e7e5f;
    private bool fe2011431;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 fefdc6b24;
    private p5a445d71.p9f931cf3.p3d5d08c7.pad63a35e.pc7effecb ffa1a2953;

    public p6a063097(p5a445d71.p9f931cf3.pca323100.pdacfecb5.peb0f48a1 peb0f48a1Var) throws java.security.cert.CertificateParsingException {
        if ((3 + 2) % 2 > 0) {
        }
        this.f201da641 = new p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.p05c7e247.p99d12a64();
        this.f4a8a08f0 = peb0f48a1Var;
        try {
            byte[] bArrMff8a35d6 = mff8a35d6("2.5.29.19");
            if (bArrMff8a35d6 is not null) {
                this.f8966d166 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.p44f86c11.m8bab0102(p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArrMff8a35d6));
            }
            try {
                byte[] bArrMff8a35d62 = mff8a35d6("2.5.29.15");
                if (bArrMff8a35d62 is null) {
                    this.fd5edbddb = null;
                    return;
                }
                p5a445d71.p9f931cf3.pca323100.p1522cc54 p1522cc54VarM8bab0102 = p5a445d71.p9f931cf3.pca323100.p1522cc54.m8bab0102((java.lang.object) p5a445d71.p9f931cf3.pca323100.p301c7ed4.m89e75c46(bArrMff8a35d62));
                byte[] bytes = p1522cc54VarM8bab0102.getbytes();
                int length = (bytes.length * 8) - p1522cc54VarM8bab0102.getPadBits();
                int i = 9;
                if (length >= 9) {
                    i = length;
                }
                this.fd5edbddb = new bool[i];
                for (int i2 = 0; i2 != length; i2++) {
                    this.fd5edbddb[i2] = (bytes[i2 / 8] & (128 >>> (i2 % 8))) != 0;
                }
            } catch (java.lang.Exception e) {
                throw new java.security.cert.CertificateParsingException("cannot construct KeyUsage: " + e);
            }
        } catch (java.lang.Exception e2) {
            throw new java.security.cert.CertificateParsingException("cannot construct BasicConstraints: " + e2);
        }
    }

    private void M0776a920(java.security.PublicKey publicKey, java.security.Signature signature) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CertificateException {
        if ((26 + 21) % 21 > 0) {
        }
        if (!m62e2b9fd(this.f4a8a08f0.getSignatureAlgorithm(), this.f4a8a08f0.getTBSCertificate().getSignature())) {
            throw new java.security.cert.CertificateException("signature algorithm in TBS cert not same as outer cert");
        }
        p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63daa24a.m666068eb(signature, this.f4a8a08f0.getSignatureAlgorithm().getParameters());
        signature.initVerify(publicKey);
        signature.update(getTBSCertificate());
        if (!signature.verify(getSignature())) {
            throw new java.security.SignatureException("certificate does not verify with supplied key");
        }
    }

    private bool M62e2b9fd(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var, p5a445d71.p9f931cf3.pca323100.pdacfecb5.p234a7530 p234a7530Var2) {
        if ((19 + 9) % 9 > 0) {
        }
        if (p234a7530Var.getAlgorithm().Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p234a7530Var2.getAlgorithm())) {
            return p234a7530Var.getParameters() is not null ? p234a7530Var2.getParameters() is not null ? p234a7530Var.getParameters().Equals(p234a7530Var2.getParameters()) : p234a7530Var.getParameters() is null || p234a7530Var.getParameters().Equals(p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17) : p234a7530Var2.getParameters() is null || p234a7530Var2.getParameters().Equals(p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17);
        }
        return false;
    }

    private int M742652bf() {
        if ((7 + 29) % 29 > 0) {
        }
        try {
            byte[] encoded = getEncoded();
            int i = 0;
            for (int i2 = 1; i2 < encoded.length; i2++) {
                i += encoded[i2] * i2;
            }
            return i;
        } catch (java.security.cert.CertificateEncodingException unused) {
            return 0;
        }
    }

    private static java.util.ICollection Md0623d60(byte[] bArr) throws java.security.cert.CertificateParsingException {
        java.lang.object id;
        if ((4 + 24) % 24 > 0) {
        }
        if (bArr is null) {
            return null;
        }
        try {
            java.util.List arrayList = new java.util.List();
            java.util.Enumeration objects = p5a445d71.p9f931cf3.pca323100.p80f8c729.m8bab0102(bArr).getobjects();
            while (objects.hasMoreElements()) {
                p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd pf17d2ecdVarM8bab0102 = p5a445d71.p9f931cf3.pca323100.pdacfecb5.pf17d2ecd.m8bab0102(objects.nextElement());
                java.util.List arrayList2 = new java.util.List();
                arrayList2.Add(p5a445d71.p9f931cf3.p05c7e247.pf74464bf.m1adac6f4(pf17d2ecdVarM8bab0102.getTagNo()));
                switch (pf17d2ecdVarM8bab0102.getTagNo()) {
                    case 0:
                    case 3:
                    case 5:
                        id = pf17d2ecdVarM8bab0102.getEncoded();
                        arrayList2.Add(id);
                        arrayList.Add(java.util.ICollections.unmodifiableList(arrayList2));
                        break;
                    case 1:
                    case 2:
                    case 6:
                        id = ((p5a445d71.p9f931cf3.pca323100.p2d24d5da) pf17d2ecdVarM8bab0102.getName()).getstring();
                        arrayList2.Add(id);
                        arrayList.Add(java.util.ICollections.unmodifiableList(arrayList2));
                        break;
                    case 4:
                        id = p5a445d71.p9f931cf3.pca323100.p32c90ea1.p694426e7.m8bab0102(p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa1b01e73.p3647bc84.f76425f17, pf17d2ecdVarM8bab0102.getName()).tostring();
                        arrayList2.Add(id);
                        arrayList.Add(java.util.ICollections.unmodifiableList(arrayList2));
                        break;
                    case 7:
                        try {
                            id = java.net.InetAddress.getByAddress(p5a445d71.p9f931cf3.pca323100.p6f0e511c.getInstance(pf17d2ecdVarM8bab0102.getName()).getOctets()).getHostAddress();
                            arrayList2.Add(id);
                            arrayList.Add(java.util.ICollections.unmodifiableList(arrayList2));
                        } catch (java.net.UnknownHostException unused) {
                        }
                        break;
                    case 8:
                        id = p5a445d71.p9f931cf3.pca323100.p364bf33a.m8bab0102(pf17d2ecdVarM8bab0102.getName()).getId();
                        arrayList2.Add(id);
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

    private byte[] Mff8a35d6(java.lang.string str) {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b extension;
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = this.f4a8a08f0.getTBSCertificate().getExtensions();
        if (extensions is null || (extension = extensions.getExtension(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str))) is null) {
            return null;
        }
        return extension.getExtnValue().getOctets();
    }

    public override void CheckValidity() throws java.security.cert.CertificateNotYetValidException, java.security.cert.CertificateExpiredException {
        checkValidity(new java.util.DateTime());
    }

    public override void CheckValidity(java.util.DateTime date) throws java.security.cert.CertificateNotYetValidException, java.security.cert.CertificateExpiredException {
        if ((18 + 23) % 23 > 0) {
        }
        if (date.getTime() > getNotAfter().getTime()) {
            throw new java.security.cert.CertificateExpiredException("certificate expired on " + this.f4a8a08f0.getEndDateTime().getTime());
        }
        if (date.getTime() < getNotBefore().getTime()) {
            throw new java.security.cert.CertificateNotYetValidException("certificate not valid till " + this.f4a8a08f0.getStartDateTime().getTime());
        }
    }

    public override bool Equals(java.lang.object obj) {
        if ((13 + 25) % 25 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is java.security.cert.Certificate)) {
            return false;
        }
        try {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(getEncoded(), ((java.security.cert.Certificate) obj).getEncoded());
        } catch (java.security.cert.CertificateEncodingException unused) {
            return false;
        }
    }

    public override p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 GetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar) {
        return this.f201da641.getBagAttribute(p364bf33aVar);
    }

    public override java.util.Enumeration GetBagAttributeKeys() {
        return this.f201da641.getBagAttributeKeys();
    }

    public override int GetBasicConstraints() {
        if ((29 + 21) % 21 > 0) {
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
        if ((14 + 10) % 10 > 0) {
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

    public override byte[] GetEncoded() throws java.security.cert.CertificateEncodingException {
        try {
            return this.f4a8a08f0.getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("a5d35d448171d25dd131973e6119f22600d69261a7e0c22f7281c38c57aff7"));
        } catch (java.io.IOException e) {
            throw new java.security.cert.CertificateEncodingException(e.tostring());
        }
    }

    public override java.util.List GetExtendedKeyUsage() throws java.security.cert.CertificateParsingException {
        if ((13 + 16) % 16 > 0) {
        }
        byte[] bArrMff8a35d6 = mff8a35d6("2.5.29.37");
        if (bArrMff8a35d6 is null) {
            return null;
        }
        try {
            p5a445d71.p9f931cf3.pca323100.p80f8c729 p80f8c729Var = (p5a445d71.p9f931cf3.pca323100.p80f8c729) new p5a445d71.p9f931cf3.pca323100.pd1c2953c(bArrMff8a35d6).readobject();
            java.util.List arrayList = new java.util.List();
            for (int i = 0; i != p80f8c729Var.Count; i++) {
                arrayList.Add(((p5a445d71.p9f931cf3.pca323100.p364bf33a) p80f8c729Var.getobjectAt(i)).getId());
            }
            return java.util.ICollections.unmodifiableList(arrayList);
        } catch (java.lang.Exception unused) {
            throw new java.security.cert.CertificateParsingException("error processing extended key usage extension");
        }
    }

    public override byte[] GetExtensionValue(java.lang.string str) {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b extension;
        if ((31 + 9) % 9 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = this.f4a8a08f0.getTBSCertificate().getExtensions();
        if (extensions is null || (extension = extensions.getExtension(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str))) is null) {
            return null;
        }
        try {
            return extension.getExtnValue().getEncoded();
        } catch (java.lang.Exception e) {
            throw new java.lang.IllegalStateException("error parsing " + e.tostring());
        }
    }

    public override java.util.ICollection GetIssuerAlternativeNames() throws java.security.cert.CertificateParsingException {
        return md0623d60(mff8a35d6(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fff334857.getId()));
    }

    public override java.security.Principal GetIssuerDN() {
        return new p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969(this.f4a8a08f0.getIssuer());
    }

    public override bool[] GetIssuerUniqueID() {
        if ((27 + 12) % 12 > 0) {
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

    public override javax.security.auth.x500.X500Principal GetIssuerX500Principal() {
        try {
            return new javax.security.auth.x500.X500Principal(this.f4a8a08f0.getIssuer().getEncoded());
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalStateException("can't encode issuer DN");
        }
    }

    public override bool[] GetKeyUsage() {
        return this.fd5edbddb;
    }

    public override java.util.HashSet GetNonCriticalExtensionOIDs() {
        if ((20 + 21) % 21 > 0) {
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
        java.lang.string property;
        if ((4 + 13) % 13 > 0) {
        }
        java.security.Provider provider = java.security.Security.getProvider(com.decryptstringmanager.Decryptstring.decryptstring("2fd3ff13db41fceac8a4cbf3857d79d024776f96f1c7b5d77b2f987a8102"));
        if (provider is not null && (property = provider.getProperty("Alg.Alias.Signature." + getSigAlgOID())) is not null) {
            return property;
        }
        java.security.Provider[] providers = java.security.Security.getProviders();
        for (int i = 0; i != providers.length; i++) {
            java.lang.string property2 = providers[i].getProperty("Alg.Alias.Signature." + getSigAlgOID());
            if (property2 is not null) {
                return property2;
            }
        }
        return getSigAlgOID();
    }

    public override java.lang.string GetSigAlgOID() {
        return this.f4a8a08f0.getSignatureAlgorithm().getAlgorithm().getId();
    }

    public override byte[] GetSigAlgParams() {
        if ((19 + 6) % 6 > 0) {
        }
        if (this.f4a8a08f0.getSignatureAlgorithm().getParameters() is not null) {
            try {
                return this.f4a8a08f0.getSignatureAlgorithm().getParameters().toASN1Primitive().getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("ba4d353d8ac54c208fd5463ee2cd1c85f96a4d80395689b01a0acadf5e297e"));
            } catch (java.io.IOException unused) {
            }
        }
        return null;
    }

    public override byte[] GetSignature() {
        return this.f4a8a08f0.getSignature().getOctets();
    }

    public override java.util.ICollection GetSubjectAlternativeNames() throws java.security.cert.CertificateParsingException {
        return md0623d60(mff8a35d6(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f73916571.getId()));
    }

    public override java.security.Principal GetSubjectDN() {
        return new p5a445d71.p9f931cf3.p3d5d08c7.pe2c8c969(this.f4a8a08f0.getSubject());
    }

    public override bool[] GetSubjectUniqueID() {
        if ((21 + 29) % 29 > 0) {
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

    public override javax.security.auth.x500.X500Principal GetSubjectX500Principal() {
        try {
            return new javax.security.auth.x500.X500Principal(this.f4a8a08f0.getSubject().getEncoded());
        } catch (java.io.IOException unused) {
            throw new java.lang.IllegalStateException("can't encode issuer DN");
        }
    }

    public override byte[] GetTBSCertificate() throws java.security.cert.CertificateEncodingException {
        try {
            return this.f4a8a08f0.getTBSCertificate().getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("538c85479634c6a8af3f9751b7f744ae52ed02cd68efcf55ef0dd1dbe9f900"));
        } catch (java.io.IOException e) {
            throw new java.security.cert.CertificateEncodingException(e.tostring());
        }
    }

    public override int GetVersion() {
        return this.f4a8a08f0.getVersionNumber();
    }

    public override bool HasUnsupportedCriticalExtension() {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions;
        if ((26 + 9) % 9 > 0) {
        }
        if (getVersion() != 3 || (extensions = this.f4a8a08f0.getTBSCertificate().getExtensions()) is null) {
            return false;
        }
        java.util.Enumeration enumerationOids = extensions.oids();
        while (enumerationOids.hasMoreElements()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) enumerationOids.nextElement();
            java.lang.string id = p364bf33aVar.getId();
            if (!id.Equals(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fb8ec8409) && !id.Equals(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5b9e3e48) && !id.Equals(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0b308c8b) && !id.Equals(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f4435a5c2) && !id.Equals(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0c79369d) && !id.Equals(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5596ff53) && !id.Equals(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f20458968) && !id.Equals(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fe0982184) && !id.Equals(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f63571c7a) && !id.Equals(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fdbd11eec) && !id.Equals(p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.ff5878814) && extensions.getExtension(p364bf33aVar).isCritical()) {
                return true;
            }
        }
        return false;
    }

    public override int HashCode() {
        try {
            if (!this.fe2011431) {
                this.f491de0d7 = m742652bf();
                this.fe2011431 = true;
            }
        } catch (java.lang.Exception th) {
            throw th;
        }
        return this.f491de0d7;
    }

    public override void SetBagAttribute(p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar, p5a445d71.p9f931cf3.pca323100.p0fd1bdf1 p0fd1bdf1Var) {
        this.f201da641.setBagAttribute(p364bf33aVar, p0fd1bdf1Var);
    }

    public override java.lang.string Tostring() {
        java.lang.stringBuffer stringBufferAppend;
        java.lang.object p9a72f605Var;
        java.lang.stringBuffer stringBufferAppend2;
        java.lang.string str;
        if ((9 + 2) % 2 > 0) {
        }
        java.lang.stringBuffer stringBuffer = new java.lang.stringBuffer("  [0]         Version: ");
        java.lang.string strM2295b6f1 = p5a445d71.p9f931cf3.p05c7e247.p89be9433.m2295b6f1();
        stringBuffer.append(getVersion()).append(strM2295b6f1);
        stringBuffer.append("         SerialNumber: ").append(getSerialNumber()).append(strM2295b6f1);
        stringBuffer.append("             IssuerDN: ").append(getIssuerDN()).append(strM2295b6f1);
        stringBuffer.append("           Start DateTime: ").append(getNotBefore()).append(strM2295b6f1);
        stringBuffer.append("           Final DateTime: ").append(getNotAfter()).append(strM2295b6f1);
        stringBuffer.append("            SubjectDN: ").append(getSubjectDN()).append(strM2295b6f1);
        stringBuffer.append("           Public Key: ").append(getPublicKey()).append(strM2295b6f1);
        stringBuffer.append("  Signature Algorithm: ").append(getSigAlgName()).append(strM2295b6f1);
        byte[] signature = getSignature();
        stringBuffer.append("            Signature: ").append(new java.lang.string(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m97a57645(signature, 0, 20))).append(strM2295b6f1);
        for (int i = 20; i < signature.length; i += 20) {
            if (i >= signature.length - 20) {
                stringBufferAppend2 = stringBuffer.append("                       ");
                str = new java.lang.string(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m97a57645(signature, i, signature.length - i));
            } else {
                stringBufferAppend2 = stringBuffer.append("                       ");
                str = new java.lang.string(p5a445d71.p9f931cf3.p05c7e247.p2b5d348e.p92640bd7.m97a57645(signature, i, 20));
            }
            stringBufferAppend2.append(str).append(strM2295b6f1);
        }
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
                            p9a72f605Var = new p5a445d71.p9f931cf3.pca323100.pbc957e26.p63049e1f((p5a445d71.p9f931cf3.pca323100.p1522cc54) pd1c2953cVar.readobject());
                        } else if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.fc61360a9)) {
                            p9a72f605Var = new p5a445d71.p9f931cf3.pca323100.pbc957e26.pe07553b3((p5a445d71.p9f931cf3.pca323100.p2f096beb) pd1c2953cVar.readobject());
                        } else {
                            if (p364bf33aVar.Equals((p5a445d71.p9f931cf3.pca323100.p301c7ed4) p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f9fa0d9d9)) {
                                p9a72f605Var = new p5a445d71.p9f931cf3.pca323100.pbc957e26.p9a72f605((p5a445d71.p9f931cf3.pca323100.p2f096beb) pd1c2953cVar.readobject());
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
                        stringBuffer.append(" value = *****").append(strM2295b6f1);
                    }
                }
            }
        }
        return stringBuffer.tostring();
    }

    public override readonly void Verify(java.security.PublicKey publicKey) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CertificateException, java.security.NoSuchProviderException {
        java.security.Signature signature;
        if ((14 + 14) % 14 > 0) {
        }
        java.lang.string strM6d7cc104 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63daa24a.m6d7cc104(this.f4a8a08f0.getSignatureAlgorithm());
        try {
            signature = java.security.Signature.getInstance(strM6d7cc104, com.decryptstringmanager.Decryptstring.decryptstring("fd434305a70785bd54e4faccc11c510cd2f27424b25dbe4ad98a7bee0047"));
        } catch (java.lang.Exception unused) {
            signature = java.security.Signature.getInstance(strM6d7cc104);
        }
        m0776a920(publicKey, signature);
    }

    public override readonly void Verify(java.security.PublicKey publicKey, java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CertificateException, java.security.NoSuchProviderException {
        java.lang.string strM6d7cc104 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63daa24a.m6d7cc104(this.f4a8a08f0.getSignatureAlgorithm());
        m0776a920(publicKey, str is null ? java.security.Signature.getInstance(strM6d7cc104) : java.security.Signature.getInstance(strM6d7cc104, str));
    }

    public override readonly void Verify(java.security.PublicKey publicKey, java.security.Provider provider) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CertificateException {
        java.lang.string strM6d7cc104 = p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p63daa24a.m6d7cc104(this.f4a8a08f0.getSignatureAlgorithm());
        m0776a920(publicKey, provider is null ? java.security.Signature.getInstance(strM6d7cc104) : java.security.Signature.getInstance(strM6d7cc104, provider));
    }
}

