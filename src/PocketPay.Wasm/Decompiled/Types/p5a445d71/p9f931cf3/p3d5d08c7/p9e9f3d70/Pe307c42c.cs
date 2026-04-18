namespace WillowMaze.Wasm.Decompiled;

public class Pe307c42c : X509CRL
{
    private bool F06d51118;
    private bool F13c7984f;
    private int F19242387;
    private string F2505866c;
    private byte[] F3d0e1ae7;
    private bool F3e1a0964;
    private bool F47956a4e;
    private pe7f120ea F4a8a08f0;
    private int F4d002d69;
    private string F52f8e6ae;
    private bool F78466e26;
    private int F8af738c1;
    private bool F8c1686a1;
    private pe7f120ea Fa802f58d;
    private pe7f120ea Fa8f9738c;
    private byte[] Fb863be6d;
    private int Fdcc2aab6;
    private byte[] Fdfef16e0;
    private byte[] Ff29d3c1a;

    private void M4161443f(PublicKey P0, Signature P1)
    {
        // str: "Signature algorithm on CertificateList does not match TBSCertList."
        // str: "CRL does not verify with supplied public key."
        // call: pe307c42c.getTBSCertList
        // call: SignatureException.<init>
        // call: Signature.verify
        // call: Signature.update
        // call: p234a7530.equals
        // call: pe7f120ea.getSignatureAlgorithm
        // call: pe7f120ea.getTBSCertList
        // call: pe307c42c.getSignature
        // call: CRLException.<init>
        // call: p5944520d.getSignature
        // call: Signature.initVerify
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        // type: SignatureException
        // type: CRLException
    }

    private HashSet<object> M78f71595()
    {
        // call: Enumeration.nextElement
        // call: p5743860f.<init>
        // call: pe7f120ea.getRevokedCertificateEnumeration
        // call: p63e4e92b.getParsedValue
        // call: p5944520d$p82f1dd3e.getExtensions
        // call: HashSet<object>.add
        // call: pfb202cf8.getNames
        // call: Enumeration.hasMoreElements
        // call: p694426e7.m8bab0102
        // call: HashSet<object>.<init>
        // call: pf17d2ecd.getName
        // call: p5944520d$p82f1dd3e.hasExtensions
        // call: p5e2f5f3c.getExtension
        // call: pfb202cf8.m8bab0102
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f06d51118
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac
        // type: HashSet<object>
        // type: p5743860f
        return default!;
    }

    public static bool Ma1dcd3d9(X509CRL P0)
    {
        // str: "Exception reading IssuingDistributionPoint"
        // call: pc05b9619.<init>
        // call: p364bf33a.getId
        // call: X509CRL.getExtensionValue
        // call: p11b04310.m8bab0102
        // call: p11b04310.getOctets
        // call: p781d85ab.m8bab0102
        // call: p781d85ab.isIndirectCRL
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1
        // type: pc05b9619
        return false;
    }

    private HashSet<object> Mf684fa0b(bool P0)
    {
        // call: HashSet<object>.add
        // call: p5e2f5f3c.getExtension
        // call: p5944520d.getExtensions
        // call: pe7f120ea.getTBSCertList
        // call: p63e4e92b.isCritical
        // call: HashSet<object>.<init>
        // call: Enumeration.hasMoreElements
        // call: p364bf33a.getId
        // call: pe307c42c.getVersion
        // call: p5e2f5f3c.oids
        // call: Enumeration.nextElement
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        // type: HashSet<object>
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: X509CRL.equals
        // call: pe7f120ea.equals
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f8c1686a1
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4d002d69
        return false;
    }

    public HashSet<object> GetCriticalExtensionOIDs()
    {
        // call: pe307c42c.mf684fa0b
        return default!;
    }

    public byte[] GetEncoded()
    {
        // str: "41a70d0861cdb691f0de66bfc8e3f3b8a7d83f10e77901ef96f3e336e5b323"
        // call: DecryptString.decryptString
        // call: pe7f120ea.getEncoded
        // call: CRLException.<init>
        // call: IOException.toString
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        // type: CRLException
        return default!;
    }

    public byte[] GetExtensionValue(string P0)
    {
        // str: "error parsing "
        // call: p5944520d.getExtensions
        // call: StringBuilder.append
        // call: IllegalStateException.<init>
        // call: pe7f120ea.getTBSCertList
        // call: StringBuilder.toString
        // call: p364bf33a.<init>
        // call: p63e4e92b.getExtnValue
        // call: p11b04310.getEncoded
        // call: StringBuilder.<init>
        // call: Exception.toString
        // call: p5e2f5f3c.getExtension
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        // type: p364bf33a
        // type: StringBuilder
        // type: IllegalStateException
        return default!;
    }

    public Principal GetIssuerDN()
    {
        // call: pe2c8c969.<init>
        // call: pe7f120ea.getIssuer
        // call: p694426e7.m8bab0102
        // call: p694426e7.toASN1Primitive
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        // type: pe2c8c969
        return default!;
    }

    public X500Principal GetIssuerX500Principal()
    {
        // str: "can't encode issuer DN"
        // call: pe7f120ea.getIssuer
        // call: p694426e7.getEncoded
        // call: X500Principal.<init>
        // call: IllegalStateException.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        // type: IllegalStateException
        // type: X500Principal
        return default!;
    }

    public DateTime GetNextUpdate()
    {
        // call: pe7f120ea.getNextUpdate
        // call: pa76d4ef5.getDate
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        return default!;
    }

    public HashSet<object> GetNonCriticalExtensionOIDs()
    {
        // call: pe307c42c.mf684fa0b
        return default!;
    }

    public X509CRLEntry GetRevokedCertificate(System.Numerics.BigInteger P0)
    {
        // call: p63e4e92b.getParsedValue
        // call: p694426e7.m8bab0102
        // call: p5944520d$p82f1dd3e.getUserCertificate
        // call: Enumeration.nextElement
        // call: pf391b73d.hasValue
        // call: pf17d2ecd.getName
        // call: p5944520d$p82f1dd3e.getExtensions
        // call: pfb202cf8.getNames
        // call: pe7f120ea.getRevokedCertificateEnumeration
        // call: p5743860f.<init>
        // call: pfb202cf8.m8bab0102
        // call: Enumeration.hasMoreElements
        // call: p5e2f5f3c.getExtension
        // call: p5944520d$p82f1dd3e.hasExtensions
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f06d51118
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac
        // type: p5743860f
        return default!;
    }

    public HashSet<object> GetRevokedCertificates()
    {
        // call: Collections.unmodifiableSet
        // call: HashSet<object>.isEmpty
        // call: pe307c42c.m78f71595
        return default!;
    }

    public string GetSigAlgName()
    {
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f2505866c
        return string.Empty;
    }

    public string GetSigAlgOID()
    {
        // call: p234a7530.getAlgorithm
        // call: pe7f120ea.getSignatureAlgorithm
        // call: p364bf33a.getId
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        return string.Empty;
    }

    public byte[] GetSigAlgParams()
    {
        // call: System.arraycopy
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.fdfef16e0
        return default!;
    }

    public byte[] GetSignature()
    {
        // call: pe7f120ea.getSignature
        // call: p29d19857.getOctets
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        return default!;
    }

    public byte[] GetTBSCertList()
    {
        // str: "01e297f7d0c047d847dc50a5fa39b362d4655eb449b799e0a3408b04f4d434"
        // call: IOException.toString
        // call: pe7f120ea.getTBSCertList
        // call: DecryptString.decryptString
        // call: p5944520d.getEncoded
        // call: CRLException.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        // type: CRLException
        return default!;
    }

    public DateTime GetThisUpdate()
    {
        // call: pa76d4ef5.getDate
        // call: pe7f120ea.getThisUpdate
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        return default!;
    }

    public int GetVersion()
    {
        // call: pe7f120ea.getVersionNumber
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        return 0;
    }

    public bool HasUnsupportedCriticalExtension()
    {
        // call: HashSet<object>.remove
        // call: pe307c42c.getCriticalExtensionOIDs
        // call: HashSet<object>.isEmpty
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f20458968
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p4da36ec9.f5596ff53
        return false;
    }

    public int HashCode()
    {
        // call: X509CRL.hashCode
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4d002d69
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f8c1686a1
        return 0;
    }

    public bool IsRevoked(Certificate P0)
    {
        // str: "X.509 CRL used with non X.509 Cert"
        // str: "X.509"
        // str: "Cannot process certificate"
        // call: string.equals
        // call: p5944520d$p82f1dd3e.getUserCertificate
        // call: X509Certificate.getSerialNumber
        // call: pfb202cf8.getNames
        // call: pe7f120ea.getRevokedCertificateEnumeration
        // call: X500Principal.getEncoded
        // call: Enumeration.nextElement
        // call: p694426e7.m8bab0102
        // call: pf17d2ecd.getName
        // call: X509Certificate.getIssuerX500Principal
        // call: Exception.<init>
        // call: pfb202cf8.m8bab0102
        // call: p694426e7.equals
        // call: p5944520d$p82f1dd3e.m8bab0102
        // call: p5944520d$p82f1dd3e.hasExtensions
        // call: Certificate.getType
        // call: p63e4e92b.getParsedValue
        // call: Certificate.getEncoded
        // call: peb0f48a1.m8bab0102
        // call: peb0f48a1.getIssuer
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f06d51118
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac
        // type: Exception
        return false;
    }

    public string ToString()
    {
        // str: "                       critical("
        // str: "              Version: "
        // str: "            Signature: "
        // str: "             IssuerDN: "
        // str: ") "
        // str: "Base CRL: "
        // str: " value = "
        // str: " value = *****"
        // str: "                       "
        // str: "          This update: "
        // str: "  Signature Algorithm: "
        // str: "           Extensions: "
        // str: "          Next update: "
        // call: StringBuilder.append
        // call: p11b04310.getOctets
        // call: Enumeration.nextElement
        // call: string.<init>
        // call: p364bf33a.getId
        // call: IEnumerator<object>.next
        // call: p92640bd7.m97a57645
        // call: pe307c42c.getRevokedCertificates
        // call: HashSet<object>.iterator
        // call: Enumeration.hasMoreElements
        // call: p63e4e92b.getExtnValue
        // call: pe7f120ea.getTBSCertList
        // call: pe307c42c.getSignature
        // call: p5944520d.getExtensions
        // call: IEnumerator<object>.hasNext
        // call: pe307c42c.getVersion
        // call: p89be9433.m2295b6f1
        // call: p364bf33a.equals
        // call: pd1c2953c.readObject
        // call: pf391b73d.m8bab0102
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.pe307c42c.f4a8a08f0
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fac7667fe
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fb423e420
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fcd5c9754
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f8ae0dbb4
        // type: string
        // type: pd1c2953c
        // type: pf8e251c6
        // type: StringBuilder
        // type: StringBuilder
        return string.Empty;
    }

    public void Verify(PublicKey P0)
    {
        // str: "c069c2de2513454db38a3b9b9423a704b121451d43f725b6224b54118d7c"
        // call: pe307c42c.getSigAlgName
        // call: Signature.getInstance
        // call: pe307c42c.m4161443f
        // call: DecryptString.decryptString
    }

    public void Verify(PublicKey P0, string P1)
    {
        // call: Signature.getInstance
        // call: pe307c42c.getSigAlgName
        // call: pe307c42c.m4161443f
    }

    public void Verify(PublicKey P0, Provider P1)
    {
        // call: Signature.getInstance
        // call: pe307c42c.getSigAlgName
        // call: pe307c42c.m4161443f
    }

}
