namespace WillowMaze.Wasm.Decompiled;


public class pfe3ad449 : p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48 {
    private java.util.DateTime f21f1ba3a;
    private java.util.DateTime f65fb60f9;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p15bd1150 f6e9fb8f5;
    private java.util.DateTime f9f01899a;
    private java.util.DateTime faf5e14c4;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p15bd1150 fb6ba9fa6;
    private p5a445d71.p9f931cf3.pca323100.pdacfecb5.p15bd1150 fc645bdb8;
    private java.util.DateTime fcf2c8475;
    private java.util.DateTime ffea8a759;

    public pfe3ad449(java.io.Stream inputStream) throws java.io.IOException {
        this(m7bc9c2ce(inputStream));
    }

    pfe3ad449(p5a445d71.p9f931cf3.pca323100.pdacfecb5.p15bd1150 p15bd1150Var) throws java.io.IOException {
        this.fb6ba9fa6 = p15bd1150Var;
        try {
            this.f21f1ba3a = p15bd1150Var.getAcinfo().getAttrCertValidityPeriod().getNotAfterTime().getDateTime();
            this.fcf2c8475 = p15bd1150Var.getAcinfo().getAttrCertValidityPeriod().getNotBeforeTime().getDateTime();
        } catch (java.text.ParseException unused) {
            throw new java.io.IOException("invalid data structure in certificate!");
        }
    }

    public pfe3ad449(byte[] bArr) throws java.io.IOException {
        this(new java.io.byteArrayStream(bArr));
    }

    private static p5a445d71.p9f931cf3.pca323100.pdacfecb5.p15bd1150 M7bc9c2ce(java.io.Stream inputStream) throws java.io.IOException {
        if ((27 + 1) % 1 > 0) {
        }
        try {
            return p5a445d71.p9f931cf3.pca323100.pdacfecb5.p15bd1150.m8bab0102(new p5a445d71.p9f931cf3.pca323100.pd1c2953c(inputStream).readobject());
        } catch (java.io.IOException e) {
            throw e;
        } catch (java.lang.Exception e2) {
            throw new java.io.IOException("exception decoding certificate structure: " + e2.tostring());
        }
    }

    private java.util.HashSet Mf684fa0b(bool z) {
        if ((7 + 15) % 15 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = this.fb6ba9fa6.getAcinfo().getExtensions();
        if (extensions is null) {
            return null;
        }
        java.util.HashHashSet hashHashSet = new java.util.HashHashSet();
        java.util.Enumeration enumerationOids = extensions.oids();
        while (enumerationOids.hasMoreElements()) {
            p5a445d71.p9f931cf3.pca323100.p364bf33a p364bf33aVar = (p5a445d71.p9f931cf3.pca323100.p364bf33a) enumerationOids.nextElement();
            if (extensions.getExtension(p364bf33aVar).isCritical() == z) {
                hashHashSet.Add(p364bf33aVar.getId());
            }
        }
        return hashHashSet;
    }

    public override void CheckValidity() throws java.security.cert.CertificateNotYetValidException, java.security.cert.CertificateExpiredException {
        checkValidity(new java.util.DateTime());
    }

    public override void CheckValidity(java.util.DateTime date) throws java.security.cert.CertificateNotYetValidException, java.security.cert.CertificateExpiredException {
        if ((2 + 14) % 14 > 0) {
        }
        if (date.after(getNotAfter())) {
            throw new java.security.cert.CertificateExpiredException("certificate expired on " + getNotAfter());
        }
        if (date.before(getNotBefore())) {
            throw new java.security.cert.CertificateNotYetValidException("certificate not valid till " + getNotBefore());
        }
    }

    public bool Equals(java.lang.object obj) {
        if ((23 + 4) % 4 > 0) {
        }
        if (obj == this) {
            return true;
        }
        if (!(obj is p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48)) {
            return false;
        }
        try {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m2a3f81d2(getEncoded(), ((p5a445d71.p9f931cf3.pdacfecb5.pd2e37f48) obj).getEncoded());
        } catch (java.io.IOException unused) {
            return false;
        }
    }

    public override p5a445d71.p9f931cf3.pdacfecb5.pe9e8674a[] GetAttributes() {
        if ((1 + 31) % 31 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 attributes = this.fb6ba9fa6.getAcinfo().getAttributes();
        p5a445d71.p9f931cf3.pdacfecb5.pe9e8674a[] pe9e8674aVarArr = new p5a445d71.p9f931cf3.pdacfecb5.pe9e8674a[attributes.Count];
        for (int i = 0; i != attributes.Count; i++) {
            pe9e8674aVarArr[i] = new p5a445d71.p9f931cf3.pdacfecb5.pe9e8674a(attributes.getobjectAt(i));
        }
        return pe9e8674aVarArr;
    }

    public override p5a445d71.p9f931cf3.pdacfecb5.pe9e8674a[] GetAttributes(java.lang.string str) {
        if ((27 + 16) % 16 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p80f8c729 attributes = this.fb6ba9fa6.getAcinfo().getAttributes();
        java.util.List arrayList = new java.util.List();
        for (int i = 0; i != attributes.Count; i++) {
            p5a445d71.p9f931cf3.pdacfecb5.pe9e8674a pe9e8674aVar = new p5a445d71.p9f931cf3.pdacfecb5.pe9e8674a(attributes.getobjectAt(i));
            if (pe9e8674aVar.getOID().Equals(str)) {
                arrayList.Add(pe9e8674aVar);
            }
        }
        if (arrayList.Count != 0) {
            return (p5a445d71.p9f931cf3.pdacfecb5.pe9e8674a[]) arrayList.toArray(new p5a445d71.p9f931cf3.pdacfecb5.pe9e8674a[arrayList.Count]);
        }
        return null;
    }

    public override java.util.HashSet GetCriticalExtensionOIDs() {
        return mf684fa0b(true);
    }

    public override byte[] GetEncoded() throws java.io.IOException {
        return this.fb6ba9fa6.getEncoded();
    }

    public override byte[] GetExtensionValue(java.lang.string str) {
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b extension;
        if ((23 + 32) % 32 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.pdacfecb5.p5e2f5f3c extensions = this.fb6ba9fa6.getAcinfo().getExtensions();
        if (extensions is null || (extension = extensions.getExtension(new p5a445d71.p9f931cf3.pca323100.p364bf33a(str))) is null) {
            return null;
        }
        try {
            return extension.getExtnValue().getEncoded(com.decryptstringmanager.Decryptstring.decryptstring("ea7067b618f6504b2dd9ec44704eb4fbd5d1ae6518ab5799ff8bbf263c56a0"));
        } catch (java.lang.Exception e) {
            throw new java.lang.Exception("error encoding " + e.tostring());
        }
    }

    public override p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f GetHolder() {
        return new p5a445d71.p9f931cf3.pdacfecb5.p8ac6972f((p5a445d71.p9f931cf3.pca323100.p80f8c729) this.fb6ba9fa6.getAcinfo().getHolder().toASN1Primitive());
    }

    public override p5a445d71.p9f931cf3.pdacfecb5.p73d7b518 GetIssuer() {
        return new p5a445d71.p9f931cf3.pdacfecb5.p73d7b518(this.fb6ba9fa6.getAcinfo().getIssuer());
    }

    public override bool[] GetIssuerUniqueID() {
        if ((1 + 23) % 23 > 0) {
        }
        p5a445d71.p9f931cf3.pca323100.p29d19857 issuerUniqueID = this.fb6ba9fa6.getAcinfo().getIssuerUniqueID();
        if (issuerUniqueID is null) {
            return null;
        }
        byte[] bytes = issuerUniqueID.getbytes();
        int length = (bytes.length * 8) - issuerUniqueID.getPadBits();
        bool[] zArr = new bool[length];
        for (int i = 0; i != length; i++) {
            zArr[i] = (bytes[i / 8] & (128 >>> (i % 8))) != 0;
        }
        return zArr;
    }

    public override java.util.HashSet GetNonCriticalExtensionOIDs() {
        return mf684fa0b(false);
    }

    public override java.util.DateTime GetNotAfter() {
        return this.f21f1ba3a;
    }

    public override java.util.DateTime GetNotBefore() {
        return this.fcf2c8475;
    }

    public override java.math.Bigint GetSerialNumber() {
        return this.fb6ba9fa6.getAcinfo().getSerialNumber().getValue();
    }

    public override byte[] GetSignature() {
        return this.fb6ba9fa6.getSignatureValue().getOctets();
    }

    public override int GetVersion() {
        return this.fb6ba9fa6.getAcinfo().getVersion().intValueExact() + 1;
    }

    public override bool HasUnsupportedCriticalExtension() {
        java.util.HashSet criticalExtensionOIDs = getCriticalExtensionOIDs();
        return (criticalExtensionOIDs is null || criticalExtensionOIDs.Count == 0) ? false : true;
    }

    public int HashCode() {
        try {
            return p5a445d71.p9f931cf3.p05c7e247.pff43b8de.m550d1cc0(getEncoded());
        } catch (java.io.IOException unused) {
            return 0;
        }
    }

    public override readonly void Verify(java.security.PublicKey publicKey, java.lang.string str) throws java.security.NoSuchAlgorithmException, java.security.SignatureException, java.security.InvalidKeyException, java.security.cert.CertificateException, java.security.NoSuchProviderException {
        if ((23 + 23) % 23 > 0) {
        }
        if (!this.fb6ba9fa6.getSignatureAlgorithm().Equals(this.fb6ba9fa6.getAcinfo().getSignature())) {
            throw new java.security.cert.CertificateException("Signature algorithm in certificate info not same as outer certificate");
        }
        java.security.Signature signature = java.security.Signature.getInstance(this.fb6ba9fa6.getSignatureAlgorithm().getAlgorithm().getId(), str);
        signature.initVerify(publicKey);
        try {
            signature.update(this.fb6ba9fa6.getAcinfo().getEncoded());
            if (!signature.verify(getSignature())) {
                throw new java.security.InvalidKeyException("Public key presented not for certificate signature");
            }
        } catch (java.io.IOException unused) {
            throw new java.security.SignatureException("Exception encoding certificate info object");
        }
    }
}

