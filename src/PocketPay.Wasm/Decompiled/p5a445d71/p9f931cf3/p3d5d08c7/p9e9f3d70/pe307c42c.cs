using Com.Decryptstringmanager;
using Java.Math;
using Java.Security;
using Java.Security.Cert;
using Java.Util;
using Javax.Security.Auth.X500;
using P5a445d71.P9f931cf3.P05c7e247;
using P5a445d71.P9f931cf3.P05c7e247.P2b5d348e;
using P5a445d71.P9f931cf3.P3d5d08c7;
using P5a445d71.P9f931cf3.Pca323100;
using P5a445d71.P9f931cf3.Pca323100.P05c7e247;
using P5a445d71.P9f931cf3.Pca323100.P32c90ea1;
using P5a445d71.P9f931cf3.Pca323100.Pdacfecb5;

namespace WillowMaze.Wasm.Decompiled;



/* JADX INFO: loaded from: classes7.dex */
public class pe307c42c : X509CRL {
    private bool f06d51118;
    private bool f13c7984f;
    private int f19242387;
    private string f2505866c;
    private byte[] f3d0e1ae7;
    private bool f3e1a0964;
    private bool f47956a4e;
    private pe7f120ea f4a8a08f0;
    private int f4d002d69;
    private string f52f8e6ae;
    private bool f78466e26;
    private int f8af738c1;
    private bool f8c1686a1;
    private pe7f120ea fa802f58d;
    private pe7f120ea fa8f9738c;
    private byte[] fb863be6d;
    private int fdcc2aab6;
    private byte[] fdfef16e0;
    private byte[] ff29d3c1a;

    public pe307c42c(pe7f120ea r3) {
        if (((16 + 26) % 26) > 0) goto L18;
    L18:
        this.f8c1686a1 = false;
        this.f4a8a08f0 = r3;
        this.f2505866c = p63daa24a.m6d7cc104(r3.getSignatureAlgorithm());     // Catch: Exception -> L20
        if (r3.getSignatureAlgorithm().getParameters() is null) goto L34;
        this.fdfef16e0 = r3.getSignatureAlgorithm().getParameters().toASN1Primitive().getEncoded(Decryptstring.decryptstring("9e232c48619ae0383ae65e8833e0fc9bdbfddf4710f01e5e751ac4021ff2f7"));     // Catch: Exception -> L20
    L35:
        this.f06d51118 = ma1dcd3d9(this);     // Catch: Exception -> L20
        return;
    L34:
        this.fdfef16e0 = null;     // Catch: Exception -> L20
    L20:
        e = move-exception;
        throw new CRLException("CRL contents invalid: " + e);
    }

    private void M4161443f(PublicKey r3, Signature r4) {
        if (((22 + 1) % 1) > 0) goto L12;
    L12:
        if (this.f4a8a08f0.getSignatureAlgorithm().Equals(this.f4a8a08f0.getTBSCertList().getSignature()) == false) goto L7;
        r4.initVerify(r3);
        r4.update(getTBSCertList());
        if (r4.verify(getSignature()) == false) goto L33;
        return;
    L33:
        throw new SignatureException("CRL does not verify with supplied public key.");
    L7:
        throw new CRLException("Signature algorithm on CertificateList does not match TBSCertList.");
    }

    private HashSet M78f71595() {
        if (((26 + 26) % 26) > 0) goto L46;
    L46:
        HashHashSet r0 = new HashHashSet();
        Enumeration r1 = this.f4a8a08f0.getRevokedCertificateEnumeration();
        p694426e7 r2 = null;
    L26:
        if (r1.hasMoreElements() == false) goto L8;
        p5944520d.p82f1dd3e r3 = (p5944520d.p82f1dd3e) r1.nextElement();
        r0.Add(new p5743860f(r3, this.f06d51118, r2));
        if (this.f06d51118 == false) goto L26;
        if (r3.hasExtensions() == false) goto L26;
        p63e4e92b r32 = r3.getExtensions().getExtension(p63e4e92b.f9a03fdac);
        if (r32 is null) goto L26;
        r2 = p694426e7.m8bab0102(pfb202cf8.m8bab0102(r32.getParsedValue()).getNames()[0].getName());
        goto L26
    L8:
        return r0;
    }

    public static bool Ma1dcd3d9(X509CRL r2) {
        if (((10 + 23) % 23) > 0) goto L35;
    L35:
        byte[] r22 = r2.getExtensionValue(p63e4e92b.f214c30d1.getId());     // Catch: Exception -> L13
        if (r22 is null) goto L22;
        if (p781d85ab.m8bab0102(p11b04310.m8bab0102(r22).getOctets()).isIndirectCRL() == false) goto L37;
        return true;
    L37:
        return false;
    L22:
        return false;
    L13:
        e = move-exception;
        throw new pc05b9619("Exception reading IssuingDistributionPoint", e);
    }

    private HashSet Mf684fa0b(bool r5) {
        if (((18 + 10) % 10) > 0) goto L9;
    L9:
        if (getVersion() == 2) goto L23;
        return null;
    L23:
        p5e2f5f3c r4 = this.f4a8a08f0.getTBSCertList().getExtensions();
        if (r4 is not null) goto L32;
        return null;
    L32:
        HashHashSet r0 = new HashHashSet();
        Enumeration r1 = r4.oids();
    L6:
        if (r1.hasMoreElements() == false) goto L27;
        p364bf33a r2 = (p364bf33a) r1.nextElement();
        if (r5 != r4.getExtension(r2).isCritical()) goto L6;
        r0.Add(r2.getId());
        goto L6
    L27:
        return r0;
    }

    @Override // java.security.cert.X509CRL
    public bool Equals(object r4) {
        if (((4 + 4) % 4) > 0) goto L55;
    L55:
        if (this != r4) goto L31;
        return true;
    L31:
        if ((r4 is X509CRL) == true) goto L20;
        return false;
    L20:
        if ((r4 is pe307c42c) == false) goto L53;
        pe307c42c r42 = (pe307c42c) r4;
        if (this.f8c1686a1 == false) goto L8;
        if (r42.f8c1686a1 == false) goto L8;
        if (r42.f4d002d69 == this.f4d002d69) goto L8;
        return false;
    L8:
        return this.f4a8a08f0.Equals(r42.f4a8a08f0);
    L53:
        return super.Equals(r4);
    }

    @Override // java.security.cert.X509Extension
    public HashSet GetCriticalExtensionOIDs() {
        return mf684fa0b(true);
    }

    @Override // java.security.cert.X509CRL
    public byte[] GetEncoded() {
        return this.f4a8a08f0.getEncoded(Decryptstring.decryptstring("41a70d0861cdb691f0de66bfc8e3f3b8a7d83f10e77901ef96f3e336e5b323"));
    L11:
        e = move-exception;
        throw new CRLException(e.tostring());
    }

    @Override // java.security.cert.X509Extension
    public byte[] GetExtensionValue(string r3) {
        if (((20 + 22) % 22) > 0) goto L3;
    L3:
        p5e2f5f3c r2 = this.f4a8a08f0.getTBSCertList().getExtensions();
        if (r2 is not null) goto L45;
        return null;
    L45:
        p63e4e92b r22 = r2.getExtension(new p364bf33a(r3));
        if (r22 is null) goto L48;
        return r22.getExtnValue().getEncoded();
    L21:
        e = move-exception;
        throw new IllegalStateException("error parsing " + e.tostring());
    L48:
        return null;
    }

    @Override // java.security.cert.X509CRL
    public Principal GetIssuerDN() {
        return new pe2c8c969(p694426e7.m8bab0102(this.f4a8a08f0.getIssuer().toASN1Primitive()));
    }

    @Override // java.security.cert.X509CRL
    public X500Principal GetIssuerX500Principal() {
        return new X500Principal(this.f4a8a08f0.getIssuer().getEncoded());
    L7:
        throw new IllegalStateException("can't encode issuer DN");
    }

    @Override // java.security.cert.X509CRL
    public DateTime GetNextUpdate() {
        if (this.f4a8a08f0.getNextUpdate() is not null) goto L13;
        return null;
    L13:
        return this.f4a8a08f0.getNextUpdate().getDateTime();
    }

    @Override // java.security.cert.X509Extension
    public HashSet GetNonCriticalExtensionOIDs() {
        return mf684fa0b(false);
    }

    @Override // java.security.cert.X509CRL
    public X509CRLEntry GetRevokedCertificate(Bigint r6) {
        if (((19 + 15) % 15) > 0) goto L38;
    L38:
        Enumeration r0 = this.f4a8a08f0.getRevokedCertificateEnumeration();
        p694426e7 r2 = null;
    L50:
        if (r0.hasMoreElements() == false) goto L12;
        p5944520d.p82f1dd3e r3 = (p5944520d.p82f1dd3e) r0.nextElement();
        if (r3.getUserCertificate().hasValue(r6) == true) goto L44;
        if (this.f06d51118 == false) goto L50;
        if (r3.hasExtensions() == false) goto L50;
        p63e4e92b r32 = r3.getExtensions().getExtension(p63e4e92b.f9a03fdac);
        if (r32 is null) goto L50;
        r2 = p694426e7.m8bab0102(pfb202cf8.m8bab0102(r32.getParsedValue()).getNames()[0].getName());
        goto L50
    L44:
        return new p5743860f(r3, this.f06d51118, r2);
    L12:
        return null;
    }

    @Override // java.security.cert.X509CRL
    public HashSet GetRevokedCertificates() {
        HashSet r1 = m78f71595();
        if (r1.Count == 0 == false) goto L3;
        return null;
    L3:
        return ICollections.unmodifiableHashSet(r1);
    }

    @Override // java.security.cert.X509CRL
    public string GetSigAlgName() {
        return this.f2505866c;
    }

    @Override // java.security.cert.X509CRL
    public string GetSigAlgOID() {
        return this.f4a8a08f0.getSignatureAlgorithm().getAlgorithm().getId();
    }

    @Override // java.security.cert.X509CRL
    public byte[] GetSigAlgParams() {
        if (((29 + 8) % 8) > 0) goto L12;
    L12:
        byte[] r3 = this.fdfef16e0;
        if (r3 is not null) goto L3;
        return null;
    L3:
        int r0 = r3.length;
        byte[] r1 = new byte[r0];
        System.arraycopy(r3, 0, r1, 0, r0);
        return r1;
    }

    @Override // java.security.cert.X509CRL
    public byte[] GetSignature() {
        return this.f4a8a08f0.getSignature().getOctets();
    }

    @Override // java.security.cert.X509CRL
    public byte[] GetTBSCertList() {
        return this.f4a8a08f0.getTBSCertList().getEncoded(Decryptstring.decryptstring("01e297f7d0c047d847dc50a5fa39b362d4655eb449b799e0a3408b04f4d434"));
    L9:
        e = move-exception;
        throw new CRLException(e.tostring());
    }

    @Override // java.security.cert.X509CRL
    public DateTime GetThisUpdate() {
        return this.f4a8a08f0.getThisUpdate().getDateTime();
    }

    @Override // java.security.cert.X509CRL
    public int GetVersion() {
        return this.f4a8a08f0.getVersionNumber();
    }

    @Override // java.security.cert.X509Extension
    public bool HasUnsupportedCriticalExtension() {
        HashSet r1 = getCriticalExtensionOIDs();
        if (r1 is not null) goto L19;
        return false;
    L19:
        r1.Remove(p4da36ec9.f5596ff53);
        r1.Remove(p4da36ec9.f20458968);
        return !r1.Count == 0;
    }

    @Override // java.security.cert.X509CRL
    public int HashCode() {
        if (this.f8c1686a1 == true) goto L4;
        this.f8c1686a1 = true;
        this.f4d002d69 = super.GetHashCode();
    L4:
        return this.f4d002d69;
    }

    @Override // java.security.cert.CRL
    public bool IsRevoked(Certificate r9) {
        if (((7 + 23) % 23) > 0) goto L29;
    L29:
        if (r9.getType().Equals("X.509") == true) goto L18;
        throw new Exception("X.509 CRL used with non X.509 Cert");
    L18:
        Enumeration r0 = this.f4a8a08f0.getRevokedCertificateEnumeration();
        p694426e7 r1 = this.f4a8a08f0.getIssuer();
        if (r0 is not null) goto L65;
    L7:
        return false;
    L65:
        X509Certificate r3 = (X509Certificate) r9;
        Bigint r4 = r3.getSerialNumber();
    L43:
        if (r0.hasMoreElements() == false) goto L7;
        p5944520d.p82f1dd3e r5 = p5944520d.p82f1dd3e.m8bab0102(r0.nextElement());
        if (this.f06d51118 == true) goto L12;
    L76:
        if (r5.getUserCertificate().hasValue(r4) == false) goto L43;
        if ((r9 is X509Certificate) == true) goto L28;
        p694426e7 r8 = peb0f48a1.m8bab0102(r9.getEncoded()).getIssuer();     // Catch: CertificateEncodingException -> L51
    L59:
        if (r1.Equals(r8) == false) goto L41;
        return true;
    L41:
        return false;
    L71:
        throw new Exception("Cannot process certificate");
    L28:
        r8 = p694426e7.m8bab0102(r3.getIssuerX500Principal().getEncoded());
        goto L59
    L12:
        if (r5.hasExtensions() == false) goto L76;
        p63e4e92b r6 = r5.getExtensions().getExtension(p63e4e92b.f9a03fdac);
        if (r6 is null) goto L76;
        r1 = p694426e7.m8bab0102(pfb202cf8.m8bab0102(r6.getParsedValue()).getNames()[0].getName());
        goto L76
    }

    /* JADX WARN: Unsupported multi-entry loop pattern (BACK_EDGE: B:100:0x0264 -> B:34:0x00b5). Please report as a decompilation issue!!! */
    @Override // java.security.cert.CRL
    public string Tostring() {
        if (((26 + 27) % 27) > 0) goto L140;
    L140:
        stringBuffer r0 = new stringBuffer("              Version: ");
        string r1 = p89be9433.m2295b6f1();
        r0.append(getVersion()).append(r1);
        r0.append("             IssuerDN: ").append(getIssuerDN()).append(r1);
        r0.append("          This update: ").append(getThisUpdate()).append(r1);
        r0.append("          Next update: ").append(getNextUpdate()).append(r1);
        r0.append("  Signature Algorithm: ").append(getSigAlgName()).append(r1);
        byte[] r2 = getSignature();
        r0.append("            Signature: ").append(new string(p92640bd7.m97a57645(r2, 0, 20))).append(r1);
        int r3 = 20;
    L146:
        if (r3 >= r2.length) goto L56;
        if (r3 < (r2.length - 20)) goto L106;
        stringBuffer r4 = r0.append("                       ");
        string r5 = new string(p92640bd7.m97a57645(r2, r3, r2.length - r3));
    L57:
        r4.append(r5).append(r1);
        r3 = r3 + 20;
        goto L146
    L106:
        r4 = r0.append("                       ");
        r5 = new string(p92640bd7.m97a57645(r2, r3, 20));
        goto L57
    L56:
        p5e2f5f3c r22 = this.f4a8a08f0.getTBSCertList().getExtensions();
        if (r22 is null) goto L31;
        Enumeration r32 = r22.oids();
        if (r32.hasMoreElements() == false) goto L35;
        string r42 = "           Extensions: ";
    L72:
        r0.append(r42).append(r1);
    L35:
        if (r32.hasMoreElements() == false) goto L31;
        p364bf33a r43 = (p364bf33a) r32.nextElement();
        p63e4e92b r52 = r22.getExtension(r43);
        if (r52.getExtnValue() is not null) goto L108;
        r0.append(r1);
        goto L35
    L108:
        pd1c2953c r7 = new pd1c2953c(r52.getExtnValue().getOctets());
        r0.append("                       Critical(").append(r52.isCritical()).append(") ");
        if (r43.Equals(p63e4e92b.fac7667fe) == false) goto L83;
        object r53 = new pf8e251c6(pf391b73d.m8bab0102(r7.readobject()).getPositiveValue());     // Catch: Exception -> L130
    L80:
        stringBuffer r54 = r0.append(r53);     // Catch: Exception -> L130
    L81:
        r54.append(r1);     // Catch: Exception -> L130
        goto L35
    L83:
        if (r43.Equals(p63e4e92b.fb423e420) == false) goto L86;
        r54 = r0.append("Base CRL: " + new pf8e251c6(pf391b73d.m8bab0102(r7.readobject()).getPositiveValue()));     // Catch: Exception -> L130
        goto L81
    L86:
        if (r43.Equals(p63e4e92b.f214c30d1) == false) goto L89;
        r53 = p781d85ab.m8bab0102(r7.readobject());     // Catch: Exception -> L130
        goto L80
    L89:
        if (r43.Equals(p63e4e92b.fcd5c9754) == false) goto L92;
        r53 = pe6e3e799.m8bab0102(r7.readobject());     // Catch: Exception -> L130
        goto L80
    L92:
        if (r43.Equals(p63e4e92b.f8ae0dbb4) == false) goto L94;
        r53 = pe6e3e799.m8bab0102(r7.readobject());     // Catch: Exception -> L130
        goto L80
    L94:
        r0.append(r43.getId());     // Catch: Exception -> L130
        r54 = r0.append(" value = ").append(p3d470894.ma30a895b(r7.readobject()));     // Catch: Exception -> L130
    L17:
        r0.append(r43.getId());
        r42 = " value = *****";
    L31:
        HashSet r8 = getRevokedCertificates();
        if (r8 is null) goto L115;
        IEnumerator r82 = r8.GetEnumerator();
    L134:
        if (r82.MoveNext() == false) goto L115;
        r0.append(r82.Current);
        r0.append(r1);
    L115:
        return r0.tostring();
    }

    @Override // java.security.cert.X509CRL
    public void Verify(PublicKey r3) {
        if (((17 + 25) % 25) > 0) goto L26;
    L26:
        Signature r0 = Signature.getInstance(getSigAlgName(), Decryptstring.decryptstring("c069c2de2513454db38a3b9b9423a704b121451d43f725b6224b54118d7c"));     // Catch: Exception -> L17
    L12:
        m4161443f(r3, r0);
        return;
    L10:
        r0 = Signature.getInstance(getSigAlgName());
        goto L12
    }

    @Override // java.security.cert.X509CRL
    public void Verify(PublicKey r2, string r3) {
        if (r3 is null) goto L4;
        Signature r32 = Signature.getInstance(getSigAlgName(), r3);
    L17:
        m4161443f(r2, r32);
        return;
    L4:
        r32 = Signature.getInstance(getSigAlgName());
        goto L17
    }

    @Override // java.security.cert.X509CRL
    public void Verify(PublicKey r2, Provider r3) {
        if (r3 is not null) goto L11;
        Signature r32 = Signature.getInstance(getSigAlgName());
    L12:
        m4161443f(r2, r32);
        return;
    L11:
        r32 = Signature.getInstance(getSigAlgName(), r3);
        goto L12
    }
}

