namespace WillowMaze.Wasm.Decompiled;

public abstract class Pe5c9818a : X509Certificate, P81e4e5be
{
    private byte[] F1059d1e9;
    private p44f86c11 F1ef924a3;
    private string F2505866c;
    private string F41cfaeb5;
    private pb3b7fb02 F425528b4;
    private peb0f48a1 F46791fcb;
    private peb0f48a1 F4a8a08f0;
    private pb3b7fb02 F5779d826;
    private p44f86c11 F57a29347;
    private peb0f48a1 F5b570dc7;
    private string F5b905041;
    private byte[] F5e7d55cb;
    private bool[] F701ed0f0;
    private pb3b7fb02 F723435f3;
    private p44f86c11 F8966d166;
    private p44f86c11 F89a32386;
    private string F9e32c8e1;
    private bool[] Fd5edbddb;
    private byte[] Fdfef16e0;
    private bool[] Fedf0fb8e;
    private pb3b7fb02 Ff9c765b5;

    private void M0776a920(PublicKey P0, Signature P1, p0fd1bdf1 P2, byte[] P3)
    {
        // str: "certificate does not verify with supplied key"
        // str: "signature algorithm in TBS cert not same as outer cert"
        // str: "bf0ac003b1805649c351827f7476f11a78825cddda59f5600c38552b41d807"
        // call: p8420911c.getSignature
        // call: peb0f48a1.getTBSCertificate
        // call: pe5c9818a.m62e2b9fd
        // call: IOException.toString
        // call: CertificateEncodingException.<init>
        // call: Signature.verify
        // call: peb0f48a1.getSignatureAlgorithm
        // call: p63daa24a.m666068eb
        // call: SignatureException.<init>
        // call: CertificateException.<init>
        // call: Signature.initVerify
        // call: p0e8bf458.m91f77f35
        // call: BufferedOutputStream.<init>
        // call: DecryptString.decryptString
        // call: p8420911c.encodeTo
        // call: Stream.close
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: SignatureException
        // type: CertificateException
        // type: CertificateEncodingException
        // type: BufferedOutputStream
    }

    private void M4161443f(PublicKey P0, p01088c78 P1)
    {
        // str: "no matching key found"
        // str: "no matching signature found"
        // call: List<object>.size
        // call: peb0f48a1.getSignatureAlgorithm
        // call: p80f8c729.m8bab0102
        // call: p80f8c729.size
        // call: p234a7530.getParameters
        // call: InvalidKeyException.<init>
        // call: p234a7530.m8bab0102
        // call: p63daa24a.m98b32efc
        // call: List<object>.get
        // call: pe5c9818a.getSignature
        // call: pe5c9818a.m0776a920
        // call: p63daa24a.m6d7cc104
        // call: p80f8c729.getObjectAt
        // call: p01088c78.createSignature
        // call: p1522cc54.m8bab0102
        // call: p1522cc54.getBytes
        // call: peb0f48a1.getSignature
        // call: p90693d0d.getPublicKeys
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: InvalidKeyException
    }

    private bool M62e2b9fd(p234a7530 P0, p234a7530 P1)
    {
        // str: "org.bouncycastle.x509.allow_absent_equiv_NULL"
        // call: p234a7530.getParameters
        // call: p364bf33a.equals
        // call: object.equals
        // call: p9fc2d28c.mf2b2f421
        // call: p234a7530.getAlgorithm
        // field: p5a445d71.p9f931cf3.pca323100.p4631e342.f76425f17
        return false;
    }

    private static p11b04310 Mb74a4d22(peb0f48a1 P0, string P1)
    {
        // call: peb0f48a1.getTBSCertificate
        // call: p63e4e92b.getExtnValue
        // call: p364bf33a.<init>
        // call: p8420911c.getExtensions
        // call: p5e2f5f3c.getExtension
        // type: p364bf33a
        return default!;
    }

    private static ICollection<object> Md0623d60(peb0f48a1 P0, string P1)
    {
        // str: "Bad tag number: "
        // call: pe5c9818a.mf5c01953
        // call: CertificateParsingException.<init>
        // call: List<object>.<init>
        // call: p80f8c729.m8bab0102
        // call: p80f8c729.getObjects
        // call: Enumeration.hasMoreElements
        // call: Enumeration.nextElement
        // call: pf17d2ecd.m8bab0102
        // call: pf17d2ecd.getTagNo
        // call: pf74464bf.m1adac6f4
        // call: List<object>.add
        // call: pf17d2ecd.getName
        // call: p364bf33a.m8bab0102
        // call: p364bf33a.getId
        // call: p6f0e511c.getInstance
        // call: p11b04310.getOctets
        // call: InetAddress.getByAddress
        // call: InetAddress.getHostAddress
        // call: Exception.getMessage
        // call: p694426e7.m8bab0102
        // field: p5a445d71.p9f931cf3.pca323100.p32c90ea1.pa1b01e73.p3647bc84.f76425f17
        // field: android.content.pm.ActivityInfo.applicationInfo
        // type: List<object>
        // type: IOException
        // type: CertificateParsingException
        // type: StringBuilder
        return default!;
    }

    private static byte[] Mf5c01953(peb0f48a1 P0, string P1)
    {
        // call: p11b04310.getOctets
        // call: pe5c9818a.mb74a4d22
        return default!;
    }

    public void CheckValidity()
    {
        // call: pe5c9818a.checkValidity
        // call: DateTime.<init>
        // type: DateTime
    }

    public void CheckValidity(DateTime P0)
    {
        // str: "certificate expired on "
        // str: "certificate not valid till "
        // call: peb0f48a1.getStartDate
        // call: StringBuilder.append
        // call: DateTime.getTime
        // call: CertificateExpiredException.<init>
        // call: StringBuilder.toString
        // call: pe5c9818a.getNotBefore
        // call: CertificateNotYetValidException.<init>
        // call: pa76d4ef5.getTime
        // call: peb0f48a1.getEndDate
        // call: pe5c9818a.getNotAfter
        // call: StringBuilder.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: CertificateExpiredException
        // type: StringBuilder
        // type: CertificateNotYetValidException
    }

    public int GetBasicConstraints()
    {
        // call: p44f86c11.getPathLenConstraint
        // call: System.Numerics.BigInteger.intValue
        // call: p44f86c11.isCA
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f8966d166
        return 0;
    }

    public HashSet<object> GetCriticalExtensionOIDs()
    {
        // call: Enumeration.hasMoreElements
        // call: p364bf33a.getId
        // call: HashSet<object>.<init>
        // call: p63e4e92b.isCritical
        // call: HashSet<object>.add
        // call: p5e2f5f3c.oids
        // call: Enumeration.nextElement
        // call: p8420911c.getExtensions
        // call: peb0f48a1.getTBSCertificate
        // call: pe5c9818a.getVersion
        // call: p5e2f5f3c.getExtension
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: HashSet<object>
        return default!;
    }

    public List<object> GetExtendedKeyUsage()
    {
        // str: "error processing extended key usage extension"
        // str: "2.5.29.37"
        // call: pe5c9818a.mf5c01953
        // call: CertificateParsingException.<init>
        // call: p301c7ed4.m89e75c46
        // call: p80f8c729.m8bab0102
        // call: List<object>.<init>
        // call: p80f8c729.size
        // call: p80f8c729.getObjectAt
        // call: p364bf33a.getId
        // call: List<object>.add
        // call: Collections.unmodifiableList
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: CertificateParsingException
        // type: List<object>
        return default!;
    }

    public byte[] GetExtensionValue(string P0)
    {
        // str: "error parsing "
        // call: Exception.toString
        // call: pe5c9818a.mb74a4d22
        // call: p11b04310.getEncoded
        // call: StringBuilder.append
        // call: IllegalStateException.<init>
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: StringBuilder
        // type: IllegalStateException
        return default!;
    }

    public ICollection<object> GetIssuerAlternativeNames()
    {
        // call: p364bf33a.getId
        // call: pe5c9818a.md0623d60
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fff334857
        return default!;
    }

    public Principal GetIssuerDN()
    {
        // call: pe2c8c969.<init>
        // call: peb0f48a1.getIssuer
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: pe2c8c969
        return default!;
    }

    public bool[] GetIssuerUniqueID()
    {
        // call: p8420911c.getIssuerUniqueId
        // call: p29d19857.getPadBits
        // call: peb0f48a1.getTBSCertificate
        // call: p29d19857.getBytes
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        return default!;
    }

    public p694426e7 GetIssuerX500Name()
    {
        // call: peb0f48a1.getIssuer
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        return default!;
    }

    public X500Principal GetIssuerX500Principal()
    {
        // str: "92938632abd15b49ac2cba9f9813206fa8e1dbf2825d9e5c5b3dc90d4242b3"
        // str: "can't encode issuer DN"
        // call: peb0f48a1.getIssuer
        // call: DecryptString.decryptString
        // call: p694426e7.getEncoded
        // call: X500Principal.<init>
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: X500Principal
        // type: IllegalStateException
        return default!;
    }

    public bool[] GetKeyUsage()
    {
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.fd5edbddb
        return default!;
    }

    public HashSet<object> GetNonCriticalExtensionOIDs()
    {
        // call: Enumeration.nextElement
        // call: p5e2f5f3c.getExtension
        // call: p364bf33a.getId
        // call: HashSet<object>.<init>
        // call: p8420911c.getExtensions
        // call: Enumeration.hasMoreElements
        // call: HashSet<object>.add
        // call: p63e4e92b.isCritical
        // call: pe5c9818a.getVersion
        // call: peb0f48a1.getTBSCertificate
        // call: p5e2f5f3c.oids
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: HashSet<object>
        return default!;
    }

    public DateTime GetNotAfter()
    {
        // call: pa76d4ef5.getDate
        // call: peb0f48a1.getEndDate
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        return default!;
    }

    public DateTime GetNotBefore()
    {
        // call: pa76d4ef5.getDate
        // call: peb0f48a1.getStartDate
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        return default!;
    }

    public PublicKey GetPublicKey()
    {
        // call: peb0f48a1.getSubjectPublicKeyInfo
        // call: p63d19d11.m1367c17c
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        return default!;
    }

    public System.Numerics.BigInteger GetSerialNumber()
    {
        // call: pf391b73d.getValue
        // call: peb0f48a1.getSerialNumber
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        return default!;
    }

    public string GetSigAlgName()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f2505866c
        return string.Empty;
    }

    public string GetSigAlgOID()
    {
        // call: p234a7530.getAlgorithm
        // call: peb0f48a1.getSignatureAlgorithm
        // call: p364bf33a.getId
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        return string.Empty;
    }

    public byte[] GetSigAlgParams()
    {
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.fdfef16e0
        return default!;
    }

    public byte[] GetSignature()
    {
        // call: p29d19857.getOctets
        // call: peb0f48a1.getSignature
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        return default!;
    }

    public ICollection<object> GetSubjectAlternativeNames()
    {
        // call: pe5c9818a.md0623d60
        // call: p364bf33a.getId
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f73916571
        return default!;
    }

    public Principal GetSubjectDN()
    {
        // call: pe2c8c969.<init>
        // call: peb0f48a1.getSubject
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: pe2c8c969
        return default!;
    }

    public bool[] GetSubjectUniqueID()
    {
        // call: peb0f48a1.getTBSCertificate
        // call: p29d19857.getPadBits
        // call: p8420911c.getSubjectUniqueId
        // call: p29d19857.getBytes
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        return default!;
    }

    public p694426e7 GetSubjectX500Name()
    {
        // call: peb0f48a1.getSubject
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        return default!;
    }

    public X500Principal GetSubjectX500Principal()
    {
        // str: "65fca359a7d78d70ee1c49e7596f88418567c6901e1faa984e80c3f04eefa8"
        // str: "can't encode subject DN"
        // call: IllegalStateException.<init>
        // call: peb0f48a1.getSubject
        // call: DecryptString.decryptString
        // call: p694426e7.getEncoded
        // call: X500Principal.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: X500Principal
        // type: IllegalStateException
        return default!;
    }

    public byte[] GetTBSCertificate()
    {
        // str: "ad7cd080e2c2c05b48ec2aa263a78fb324b627107d60f3857495da40ec859a"
        // call: CertificateEncodingException.<init>
        // call: IOException.toString
        // call: peb0f48a1.getTBSCertificate
        // call: DecryptString.decryptString
        // call: p8420911c.getEncoded
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: CertificateEncodingException
        return default!;
    }

    public p8420911c GetTBSCertificateNative()
    {
        // call: peb0f48a1.getTBSCertificate
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        return default!;
    }

    public int GetVersion()
    {
        // call: peb0f48a1.getVersionNumber
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        return 0;
    }

    public bool HasUnsupportedCriticalExtension()
    {
        // call: p364bf33a.equals
        // call: p5e2f5f3c.oids
        // call: p5e2f5f3c.getExtension
        // call: Enumeration.hasMoreElements
        // call: p8420911c.getExtensions
        // call: Enumeration.nextElement
        // call: p63e4e92b.isCritical
        // call: pe5c9818a.getVersion
        // call: peb0f48a1.getTBSCertificate
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f2c404c76
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fd5edbddb
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fffbbb6f2
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fbdc6c1be
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f777a6b62
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fcd5c9754
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fb423e420
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f8966d166
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f73916571
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f89631a2f
        return false;
    }

    public string ToString()
    {
        // str: " value = "
        // str: "                       critical("
        // str: "       Extensions: \n"
        // str: "           Final Date: "
        // str: "            SubjectDN: "
        // str: "  [0]         Version: "
        // str: "           Start Date: "
        // str: "             IssuerDN: "
        // str: "*****"
        // str: "         SerialNumber: "
        // str: "  Signature Algorithm: "
        // str: ") "
        // str: "           Public Key: "
        // call: pe5c9818a.getSubjectDN
        // call: StringBuilder.append
        // call: p89be9433.m2295b6f1
        // call: pe5c9818a.getVersion
        // call: pd1c2953c.<init>
        // call: pe5c9818a.getNotAfter
        // call: pe5c9818a.getSerialNumber
        // call: p8420911c.getExtensions
        // call: StringBuilder.<init>
        // call: Enumeration.nextElement
        // call: pe5c9818a.getIssuerDN
        // call: p364bf33a.equals
        // call: pd1c2953c.readObject
        // call: p44f86c11.m8bab0102
        // call: p033e3440.m8bab0102
        // call: p1522cc54.m8bab0102
        // call: p63049e1f.<init>
        // call: p2f096beb.m8bab0102
        // call: pe07553b3.<init>
        // call: p9a72f605.<init>
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f8966d166
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fd5edbddb
        // field: p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f6eb70cbe
        // field: p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.fc61360a9
        // field: p5a445d71.p9f931cf3.pca323100.pbc957e26.pce2825c4.f9fa0d9d9
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.pe5c9818a.f4a8a08f0
        // type: StringBuilder
        // type: p63049e1f
        // type: pe07553b3
        // type: p9a72f605
        // type: pd1c2953c
        return string.Empty;
    }

    public void Verify(PublicKey P0)
    {
        // call: pe5c9818a.m4161443f
        // call: pe5c9818a$1.<init>
        // type: pe5c9818a$1
    }

    public void Verify(PublicKey P0, string P1)
    {
        // call: pe5c9818a$2.<init>
        // call: pe5c9818a.m4161443f
        // type: pe5c9818a$2
    }

    public void Verify(PublicKey P0, Provider P1)
    {
        // str: "provider issue: "
        // call: StringBuilder.append
        // call: NoSuchProviderException.getMessage
        // call: NoSuchAlgorithmException.<init>
        // call: StringBuilder.toString
        // call: pe5c9818a$3.<init>
        // call: pe5c9818a.m4161443f
        // call: StringBuilder.<init>
        // type: StringBuilder
        // type: pe5c9818a$3
        // type: NoSuchAlgorithmException
    }

}
