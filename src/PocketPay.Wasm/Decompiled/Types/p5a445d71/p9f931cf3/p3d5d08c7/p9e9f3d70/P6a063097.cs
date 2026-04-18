namespace WillowMaze.Wasm.Decompiled;

public class P6a063097 : X509Certificate, Pc7effecb
{
    private p44f86c11 F0a324c93;
    private pc7effecb F201da641;
    private pc7effecb F21f3482b;
    private pc7effecb F25b97e1e;
    private peb0f48a1 F4326b9d9;
    private int F491de0d7;
    private peb0f48a1 F4a8a08f0;
    private bool F6483e95f;
    private p44f86c11 F71f13188;
    private p44f86c11 F8966d166;
    private int F8fb7b28a;
    private bool[] F9fbf864f;
    private int Fa9e2f859;
    private peb0f48a1 Fb2ee7a12;
    private bool[] Fd5edbddb;
    private pc7effecb Fde5e7e5f;
    private bool Fe2011431;
    private peb0f48a1 Fefdc6b24;
    private pc7effecb Ffa1a2953;

    private void M0776a920(PublicKey P0, Signature P1)
    {
        // str: "certificate does not verify with supplied key"
        // str: "signature algorithm in TBS cert not same as outer cert"
        // call: Signature.verify
        // call: Signature.update
        // call: p8420911c.getSignature
        // call: p234a7530.getParameters
        // call: CertificateException.<init>
        // call: p6a063097.m62e2b9fd
        // call: peb0f48a1.getSignatureAlgorithm
        // call: peb0f48a1.getTBSCertificate
        // call: p63daa24a.m666068eb
        // call: p6a063097.getTBSCertificate
        // call: p6a063097.getSignature
        // call: SignatureException.<init>
        // call: Signature.initVerify
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: CertificateException
        // type: SignatureException
    }

    private bool M62e2b9fd(p234a7530 P0, p234a7530 P1)
    {
        // call: object.equals
        // call: p234a7530.getParameters
        // call: p364bf33a.equals
        // call: p234a7530.getAlgorithm
        // field: p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17
        return false;
    }

    private int M742652bf()
    {
        // call: p6a063097.getEncoded
        return 0;
    }

    private static ICollection<object> Md0623d60(byte[] P0)
    {
        // str: "Bad tag number: "
        // call: pf17d2ecd.getName
        // call: p694426e7.m8bab0102
        // call: p694426e7.toString
        // call: p2d24d5da.getString
        // call: pf17d2ecd.getEncoded
        // call: List<object>.add
        // call: Collections.unmodifiableList
        // call: ICollection<object>.add
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: pf17d2ecd.getTagNo
        // call: StringBuilder.toString
        // call: IOException.<init>
        // call: ICollection<object>.size
        // call: Collections.unmodifiableCollection
        // call: List<object>.<init>
        // call: p80f8c729.m8bab0102
        // call: p80f8c729.getObjects
        // call: Enumeration.hasMoreElements
        // call: Enumeration.nextElement
        // field: p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa1b01e73.p3647bc84.f76425f17
        // type: StringBuilder
        // type: List<object>
        // type: IOException
        // type: CertificateParsingException
        return default!;
    }

    private byte[] Mff8a35d6(string P0)
    {
        // call: p5e2f5f3c.getExtension
        // call: p11b04310.getOctets
        // call: p364bf33a.<init>
        // call: peb0f48a1.getTBSCertificate
        // call: p8420911c.getExtensions
        // call: p63e4e92b.getExtnValue
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: p364bf33a
        return default!;
    }

    public void CheckValidity()
    {
        // call: p6a063097.checkValidity
        // call: DateTime.<init>
        // type: DateTime
    }

    public void CheckValidity(DateTime P0)
    {
        // str: "certificate expired on "
        // str: "certificate not valid till "
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: pa76d4ef5.getTime
        // call: p6a063097.getNotAfter
        // call: peb0f48a1.getEndDate
        // call: CertificateNotYetValidException.<init>
        // call: DateTime.getTime
        // call: StringBuilder.append
        // call: p6a063097.getNotBefore
        // call: peb0f48a1.getStartDate
        // call: CertificateExpiredException.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: CertificateExpiredException
        // type: StringBuilder
        // type: CertificateNotYetValidException
    }

    public bool Equals(object P0)
    {
        // call: p6a063097.getEncoded
        // call: Certificate.getEncoded
        // call: pff43b8de.m2a3f81d2
        return false;
    }

    public p0fd1bdf1 GetBagAttribute(p364bf33a P0)
    {
        // call: pc7effecb.getBagAttribute
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f201da641
        return default!;
    }

    public Enumeration GetBagAttributeKeys()
    {
        // call: pc7effecb.getBagAttributeKeys
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f201da641
        return default!;
    }

    public int GetBasicConstraints()
    {
        // call: System.Numerics.BigInteger.intValue
        // call: p44f86c11.getPathLenConstraint
        // call: p44f86c11.isCA
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f8966d166
        return 0;
    }

    public HashSet<object> GetCriticalExtensionOIDs()
    {
        // call: p8420911c.getExtensions
        // call: Enumeration.hasMoreElements
        // call: p6a063097.getVersion
        // call: Enumeration.nextElement
        // call: p364bf33a.getId
        // call: p5e2f5f3c.oids
        // call: peb0f48a1.getTBSCertificate
        // call: p63e4e92b.isCritical
        // call: HashSet<object>.<init>
        // call: p5e2f5f3c.getExtension
        // call: HashSet<object>.add
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: HashSet<object>
        return default!;
    }

    public byte[] GetEncoded()
    {
        // str: "a5d35d448171d25dd131973e6119f22600d69261a7e0c22f7281c38c57aff7"
        // call: IOException.toString
        // call: DecryptString.decryptString
        // call: peb0f48a1.getEncoded
        // call: CertificateEncodingException.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: CertificateEncodingException
        return default!;
    }

    public List<object> GetExtendedKeyUsage()
    {
        // str: "error processing extended key usage extension"
        // str: "2.5.29.37"
        // call: pd1c2953c.<init>
        // call: pd1c2953c.readObject
        // call: List<object>.<init>
        // call: p80f8c729.size
        // call: p80f8c729.getObjectAt
        // call: p364bf33a.getId
        // call: List<object>.add
        // call: Collections.unmodifiableList
        // call: CertificateParsingException.<init>
        // call: p6a063097.mff8a35d6
        // type: CertificateParsingException
        // type: pd1c2953c
        // type: List<object>
        return default!;
    }

    public byte[] GetExtensionValue(string P0)
    {
        // str: "error parsing "
        // call: peb0f48a1.getTBSCertificate
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: Exception.toString
        // call: StringBuilder.append
        // call: p364bf33a.<init>
        // call: p63e4e92b.getExtnValue
        // call: p11b04310.getEncoded
        // call: p5e2f5f3c.getExtension
        // call: IllegalStateException.<init>
        // call: p8420911c.getExtensions
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: StringBuilder
        // type: IllegalStateException
        // type: p364bf33a
        return default!;
    }

    public ICollection<object> GetIssuerAlternativeNames()
    {
        // call: p364bf33a.getId
        // call: p6a063097.md0623d60
        // call: p6a063097.mff8a35d6
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fff334857
        return default!;
    }

    public Principal GetIssuerDN()
    {
        // call: pe2c8c969.<init>
        // call: peb0f48a1.getIssuer
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: pe2c8c969
        return default!;
    }

    public bool[] GetIssuerUniqueID()
    {
        // call: peb0f48a1.getTBSCertificate
        // call: p29d19857.getBytes
        // call: p29d19857.getPadBits
        // call: p8420911c.getIssuerUniqueId
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        return default!;
    }

    public X500Principal GetIssuerX500Principal()
    {
        // str: "can't encode issuer DN"
        // call: IllegalStateException.<init>
        // call: peb0f48a1.getIssuer
        // call: p694426e7.getEncoded
        // call: X500Principal.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: X500Principal
        // type: IllegalStateException
        return default!;
    }

    public bool[] GetKeyUsage()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.fd5edbddb
        return default!;
    }

    public HashSet<object> GetNonCriticalExtensionOIDs()
    {
        // call: p6a063097.getVersion
        // call: HashSet<object>.<init>
        // call: Enumeration.nextElement
        // call: Enumeration.hasMoreElements
        // call: HashSet<object>.add
        // call: p5e2f5f3c.oids
        // call: p8420911c.getExtensions
        // call: p364bf33a.getId
        // call: p63e4e92b.isCritical
        // call: p5e2f5f3c.getExtension
        // call: peb0f48a1.getTBSCertificate
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: HashSet<object>
        return default!;
    }

    public DateTime GetNotAfter()
    {
        // call: pa76d4ef5.getDate
        // call: peb0f48a1.getEndDate
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        return default!;
    }

    public DateTime GetNotBefore()
    {
        // call: pa76d4ef5.getDate
        // call: peb0f48a1.getStartDate
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        return default!;
    }

    public PublicKey GetPublicKey()
    {
        // call: peb0f48a1.getSubjectPublicKeyInfo
        // call: p63d19d11.m1367c17c
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        return default!;
    }

    public System.Numerics.BigInteger GetSerialNumber()
    {
        // call: pf391b73d.getValue
        // call: peb0f48a1.getSerialNumber
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        return default!;
    }

    public string GetSigAlgName()
    {
        // str: "Alg.Alias.Signature."
        // str: "2fd3ff13db41fceac8a4cbf3857d79d024776f96f1c7b5d77b2f987a8102"
        // call: p6a063097.getSigAlgOID
        // call: StringBuilder.<init>
        // call: Security.getProvider
        // call: Provider.getProperty
        // call: Security.getProviders
        // call: StringBuilder.toString
        // call: DecryptString.decryptString
        // call: StringBuilder.append
        // type: StringBuilder
        return string.Empty;
    }

    public string GetSigAlgOID()
    {
        // call: peb0f48a1.getSignatureAlgorithm
        // call: p234a7530.getAlgorithm
        // call: p364bf33a.getId
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        return string.Empty;
    }

    public byte[] GetSigAlgParams()
    {
        // str: "ba4d353d8ac54c208fd5463ee2cd1c85f96a4d80395689b01a0acadf5e297e"
        // call: p234a7530.getParameters
        // call: peb0f48a1.getSignatureAlgorithm
        // call: p0fd1bdf1.toASN1Primitive
        // call: DecryptString.decryptString
        // call: p301c7ed4.getEncoded
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        return default!;
    }

    public byte[] GetSignature()
    {
        // call: peb0f48a1.getSignature
        // call: p29d19857.getOctets
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        return default!;
    }

    public ICollection<object> GetSubjectAlternativeNames()
    {
        // call: p6a063097.md0623d60
        // call: p6a063097.mff8a35d6
        // call: p364bf33a.getId
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f73916571
        return default!;
    }

    public Principal GetSubjectDN()
    {
        // call: peb0f48a1.getSubject
        // call: pe2c8c969.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: pe2c8c969
        return default!;
    }

    public bool[] GetSubjectUniqueID()
    {
        // call: p29d19857.getPadBits
        // call: p29d19857.getBytes
        // call: p8420911c.getSubjectUniqueId
        // call: peb0f48a1.getTBSCertificate
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        return default!;
    }

    public X500Principal GetSubjectX500Principal()
    {
        // str: "can't encode issuer DN"
        // call: peb0f48a1.getSubject
        // call: p694426e7.getEncoded
        // call: X500Principal.<init>
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: X500Principal
        // type: IllegalStateException
        return default!;
    }

    public byte[] GetTBSCertificate()
    {
        // str: "538c85479634c6a8af3f9751b7f744ae52ed02cd68efcf55ef0dd1dbe9f900"
        // call: CertificateEncodingException.<init>
        // call: IOException.toString
        // call: peb0f48a1.getTBSCertificate
        // call: DecryptString.decryptString
        // call: p8420911c.getEncoded
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: CertificateEncodingException
        return default!;
    }

    public int GetVersion()
    {
        // call: peb0f48a1.getVersionNumber
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        return 0;
    }

    public bool HasUnsupportedCriticalExtension()
    {
        // call: string.equals
        // call: p8420911c.getExtensions
        // call: peb0f48a1.getTBSCertificate
        // call: Enumeration.nextElement
        // call: p5e2f5f3c.oids
        // call: p6a063097.getVersion
        // call: p5e2f5f3c.getExtension
        // call: p364bf33a.getId
        // call: p63e4e92b.isCritical
        // call: Enumeration.hasMoreElements
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f63571c7a
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.ff5878814
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f4435a5c2
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0c79369d
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f20458968
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fe0982184
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5596ff53
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fb8ec8409
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5b9e3e48
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.fdbd11eec
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f0b308c8b
        return false;
    }

    public int HashCode()
    {
        // call: p6a063097.m742652bf
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.fe2011431
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f491de0d7
        return 0;
    }

    public void SetBagAttribute(p364bf33a P0, p0fd1bdf1 P1)
    {
        // call: pc7effecb.setBagAttribute
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f201da641
    }

    public string ToString()
    {
        // str: "           Start Date: "
        // str: "           Final Date: "
        // str: "            Signature: "
        // str: "         SerialNumber: "
        // str: "            SubjectDN: "
        // str: " value = "
        // str: "             IssuerDN: "
        // str: "           Public Key: "
        // str: "  Signature Algorithm: "
        // str: "                       "
        // str: ") "
        // str: " value = *****"
        // str: "       Extensions: \n"
        // str: "                       critical("
        // str: "  [0]         Version: "
        // call: StringBuilder.append
        // call: p89be9433.m2295b6f1
        // call: p92640bd7.m97a57645
        // call: pd1c2953c.<init>
        // call: p6a063097.getVersion
        // call: p6a063097.getPublicKey
        // call: p63e4e92b.getExtnValue
        // call: p6a063097.getSubjectDN
        // call: p364bf33a.getId
        // call: p6a063097.getIssuerDN
        // call: string.<init>
        // call: Enumeration.hasMoreElements
        // call: p6a063097.getSignature
        // call: p364bf33a.equals
        // call: pd1c2953c.readObject
        // call: p44f86c11.m8bab0102
        // call: p033e3440.m8bab0102
        // call: p63049e1f.<init>
        // call: pe07553b3.<init>
        // call: p9a72f605.<init>
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f8966d166
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fd5edbddb
        // field: p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f6eb70cbe
        // field: p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.fc61360a9
        // field: p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f9fa0d9d9
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
        // type: StringBuilder
        // type: string
        // type: p63049e1f
        // type: pe07553b3
        // type: p9a72f605
        // type: pd1c2953c
        return string.Empty;
    }

    public void Verify(PublicKey P0)
    {
        // str: "fd434305a70785bd54e4faccc11c510cd2f27424b25dbe4ad98a7bee0047"
        // call: p63daa24a.m6d7cc104
        // call: DecryptString.decryptString
        // call: Signature.getInstance
        // call: peb0f48a1.getSignatureAlgorithm
        // call: p6a063097.m0776a920
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
    }

    public void Verify(PublicKey P0, string P1)
    {
        // call: p63daa24a.m6d7cc104
        // call: p6a063097.m0776a920
        // call: Signature.getInstance
        // call: peb0f48a1.getSignatureAlgorithm
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
    }

    public void Verify(PublicKey P0, Provider P1)
    {
        // call: peb0f48a1.getSignatureAlgorithm
        // call: Signature.getInstance
        // call: p63daa24a.m6d7cc104
        // call: p6a063097.m0776a920
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p6a063097.f4a8a08f0
    }

}
