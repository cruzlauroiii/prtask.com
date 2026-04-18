namespace WillowMaze.Wasm.Decompiled;

public abstract class P0b7b2d36 : X509CRL
{
    private bool F06d51118;
    private string F114b84ca;
    private pb3b7fb02 F115b8465;
    private string F2505866c;
    private pe7f120ea F4a8a08f0;
    private string F4e11e907;
    private byte[] F557ec172;
    private pb3b7fb02 F5d5e9a77;
    private pb3b7fb02 F723435f3;
    private string F89b33bf4;
    private byte[] F8b164238;
    private bool Fa27ade53;
    private byte[] Fb20d5100;
    private byte[] Fdfef16e0;
    private pe7f120ea Ff1f71122;
    private pb3b7fb02 Ffc961282;
    private bool Fffd8abb1;

    private void M0776a920(PublicKey P0, Signature P1, p0fd1bdf1 P2, byte[] P3)
    {
        // str: "CRL does not verify with supplied public key."
        // str: "0760ed07c2f750e12eff8a90b26009997b57e0dea1a63db42de71312150727"
        // call: Signature.verify
        // call: p63daa24a.m666068eb
        // call: Signature.initVerify
        // call: p0e8bf458.m91f77f35
        // call: BufferedOutputStream.<init>
        // call: pe7f120ea.getTBSCertList
        // call: DecryptString.decryptString
        // call: p5944520d.encodeTo
        // call: Stream.close
        // call: SignatureException.<init>
        // call: IOException.toString
        // call: CRLException.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        // type: BufferedOutputStream
        // type: CRLException
        // type: SignatureException
    }

    private void M4161443f(PublicKey P0, p01088c78 P1)
    {
        // str: "no matching key found"
        // str: "cannot decode signature parameters: "
        // str: "Signature algorithm on CertificateList does not match TBSCertList."
        // call: p1522cc54.getBytes
        // call: StringBuilder.append
        // call: p0b7b2d36.m0776a920
        // call: List<object>.size
        // call: p234a7530.equals
        // call: p80f8c729.m8bab0102
        // call: StringBuilder.<init>
        // call: p5944520d.getSignature
        // call: pe7f120ea.getTBSCertList
        // call: p80f8c729.getObjectAt
        // call: IOException.getMessage
        // call: p63daa24a.m6d7cc104
        // call: p01088c78.createSignature
        // call: p234a7530.getParameters
        // call: p1522cc54.m8bab0102
        // call: InvalidKeyException.<init>
        // call: List<object>.get
        // call: p80f8c729.size
        // call: p0b7b2d36.getSigAlgName
        // call: pe7f120ea.getSignatureAlgorithm
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.fdfef16e0
        // type: CRLException
        // type: StringBuilder
        // type: InvalidKeyException
        // type: SignatureException
    }

    private HashSet<object> M78f71595()
    {
        // call: p5743860f.<init>
        // call: pe7f120ea.getRevokedCertificateEnumeration
        // call: Enumeration.hasMoreElements
        // call: p5944520d$p82f1dd3e.getExtensions
        // call: p694426e7.m8bab0102
        // call: pf17d2ecd.getName
        // call: p63e4e92b.getParsedValue
        // call: p5944520d$p82f1dd3e.hasExtensions
        // call: HashSet<object>.add
        // call: pfb202cf8.m8bab0102
        // call: pfb202cf8.getNames
        // call: Enumeration.nextElement
        // call: HashSet<object>.<init>
        // call: p5e2f5f3c.getExtension
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f06d51118
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        // type: HashSet<object>
        // type: p5743860f
        return default!;
    }

    private static p11b04310 Mb74a4d22(pe7f120ea P0, string P1)
    {
        // call: p5e2f5f3c.getExtension
        // call: p5944520d.getExtensions
        // call: p364bf33a.<init>
        // call: pe7f120ea.getTBSCertList
        // call: p63e4e92b.getExtnValue
        // type: p364bf33a
        return default!;
    }

    private static byte[] Mf5c01953(pe7f120ea P0, string P1)
    {
        // call: p11b04310.getOctets
        // call: p0b7b2d36.mb74a4d22
        return default!;
    }

    private HashSet<object> Mf684fa0b(bool P0)
    {
        // call: HashSet<object>.add
        // call: p5e2f5f3c.getExtension
        // call: HashSet<object>.<init>
        // call: p0b7b2d36.getVersion
        // call: pe7f120ea.getTBSCertList
        // call: p5944520d.getExtensions
        // call: p364bf33a.getId
        // call: Enumeration.nextElement
        // call: p63e4e92b.isCritical
        // call: Enumeration.hasMoreElements
        // call: p5e2f5f3c.oids
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        // type: HashSet<object>
        return default!;
    }

    public HashSet<object> GetCriticalExtensionOIDs()
    {
        // call: p0b7b2d36.mf684fa0b
        return default!;
    }

    public byte[] GetExtensionValue(string P0)
    {
        // str: "error parsing "
        // call: p0b7b2d36.mb74a4d22
        // call: IllegalStateException.<init>
        // call: StringBuilder.append
        // call: Exception.toString
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: p11b04310.getEncoded
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        // type: StringBuilder
        // type: IllegalStateException
        return default!;
    }

    public Principal GetIssuerDN()
    {
        // call: pe2c8c969.<init>
        // call: p694426e7.m8bab0102
        // call: pe7f120ea.getIssuer
        // call: p694426e7.toASN1Primitive
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        // type: pe2c8c969
        return default!;
    }

    public X500Principal GetIssuerX500Principal()
    {
        // str: "can't encode issuer DN"
        // call: IllegalStateException.<init>
        // call: pe7f120ea.getIssuer
        // call: p694426e7.getEncoded
        // call: X500Principal.<init>
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        // type: IllegalStateException
        // type: X500Principal
        return default!;
    }

    public DateTime GetNextUpdate()
    {
        // call: pe7f120ea.getNextUpdate
        // call: pa76d4ef5.getDate
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        return default!;
    }

    public HashSet<object> GetNonCriticalExtensionOIDs()
    {
        // call: p0b7b2d36.mf684fa0b
        return default!;
    }

    public X509CRLEntry GetRevokedCertificate(System.Numerics.BigInteger P0)
    {
        // call: pfb202cf8.m8bab0102
        // call: p5944520d$p82f1dd3e.getUserCertificate
        // call: p5743860f.<init>
        // call: p63e4e92b.getParsedValue
        // call: Enumeration.hasMoreElements
        // call: p5944520d$p82f1dd3e.getExtensions
        // call: pe7f120ea.getRevokedCertificateEnumeration
        // call: p694426e7.m8bab0102
        // call: p5e2f5f3c.getExtension
        // call: p5944520d$p82f1dd3e.hasExtensions
        // call: pf17d2ecd.getName
        // call: pf391b73d.hasValue
        // call: pfb202cf8.getNames
        // call: Enumeration.nextElement
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f06d51118
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac
        // type: p5743860f
        return default!;
    }

    public HashSet<object> GetRevokedCertificates()
    {
        // call: HashSet<object>.isEmpty
        // call: p0b7b2d36.m78f71595
        // call: Collections.unmodifiableSet
        return default!;
    }

    public string GetSigAlgName()
    {
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f2505866c
        return string.Empty;
    }

    public string GetSigAlgOID()
    {
        // call: pe7f120ea.getSignatureAlgorithm
        // call: p364bf33a.getId
        // call: p234a7530.getAlgorithm
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        return string.Empty;
    }

    public byte[] GetSigAlgParams()
    {
        // call: pff43b8de.md329fd77
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.fdfef16e0
        return default!;
    }

    public byte[] GetSignature()
    {
        // call: pe7f120ea.getSignature
        // call: p29d19857.getOctets
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        return default!;
    }

    public byte[] GetTBSCertList()
    {
        // str: "1e37cf39d0ba7eabf0b1197c3e92a8c12f225497e85f488744a9b8a051d514"
        // call: CRLException.<init>
        // call: pe7f120ea.getTBSCertList
        // call: DecryptString.decryptString
        // call: p5944520d.getEncoded
        // call: IOException.toString
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        // type: CRLException
        return default!;
    }

    public DateTime GetThisUpdate()
    {
        // call: pe7f120ea.getThisUpdate
        // call: pa76d4ef5.getDate
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        return default!;
    }

    public int GetVersion()
    {
        // call: pe7f120ea.getVersionNumber
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        return 0;
    }

    public bool HasUnsupportedCriticalExtension()
    {
        // call: p0b7b2d36.getCriticalExtensionOIDs
        // call: p364bf33a.getId
        // call: HashSet<object>.remove
        // call: HashSet<object>.isEmpty
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fb423e420
        return false;
    }

    public bool IsRevoked(Certificate P0)
    {
        // str: "X.509"
        // str: "Cannot process certificate: "
        // str: "X.509 CRL used with non X.509 Cert"
        // call: pf391b73d.hasValue
        // call: p694426e7.m8bab0102
        // call: Enumeration.hasMoreElements
        // call: p5944520d$p82f1dd3e.getUserCertificate
        // call: p5944520d$p82f1dd3e.hasExtensions
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: X500Principal.getEncoded
        // call: X509Certificate.getSerialNumber
        // call: pe7f120ea.getIssuer
        // call: pfb202cf8.m8bab0102
        // call: CertificateEncodingException.getMessage
        // call: pfb202cf8.getNames
        // call: p63e4e92b.getParsedValue
        // call: IllegalArgumentException.<init>
        // call: StringBuilder.append
        // call: Certificate.getType
        // call: Enumeration.nextElement
        // call: Certificate.getEncoded
        // call: peb0f48a1.m8bab0102
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f9a03fdac
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f06d51118
        // type: StringBuilder
        // type: IllegalArgumentException
        return false;
    }

    public string ToString()
    {
        // str: "          This update: "
        // str: "          Next update: "
        // str: "  Signature Algorithm: "
        // str: "              Version: "
        // str: ") "
        // str: "*****"
        // str: " value = "
        // str: "Base CRL: "
        // str: "                       critical("
        // str: "             IssuerDN: "
        // str: "           Extensions: "
        // call: p0b7b2d36.getNextUpdate
        // call: IEnumerator<object>.hasNext
        // call: p63e4e92b.getExtnValue
        // call: StringBuilder.append
        // call: Enumeration.nextElement
        // call: p0b7b2d36.getSignature
        // call: p364bf33a.getId
        // call: p0b7b2d36.getRevokedCertificates
        // call: p11b04310.getOctets
        // call: IEnumerator<object>.next
        // call: Enumeration.hasMoreElements
        // call: StringBuilder.toString
        // call: p63daa24a.m2db390b9
        // call: HashSet<object>.iterator
        // call: pd1c2953c.<init>
        // call: p5e2f5f3c.oids
        // call: p89be9433.m2295b6f1
        // call: p0b7b2d36.getSigAlgName
        // call: StringBuilder.<init>
        // call: p364bf33a.equals
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fac7667fe
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fb423e420
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f214c30d1
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.fcd5c9754
        // field: p5a445d71.p9f931cf3.pca323100.pdacfecb5.p63e4e92b.f8ae0dbb4
        // field: p5a445d71.p9f931cf3.p72417664.p9e9f3d70.p188fda84.pdacfecb5.p0b7b2d36.f4a8a08f0
        // type: StringBuilder
        // type: pf8e251c6
        // type: StringBuilder
        // type: pd1c2953c
        return string.Empty;
    }

    public void Verify(PublicKey P0)
    {
        // call: p0b7b2d36.m4161443f
        // call: p0b7b2d36$1.<init>
        // type: p0b7b2d36$1
    }

    public void Verify(PublicKey P0, string P1)
    {
        // call: p0b7b2d36.m4161443f
        // call: p0b7b2d36$2.<init>
        // type: p0b7b2d36$2
    }

    public void Verify(PublicKey P0, Provider P1)
    {
        // str: "provider issue: "
        // call: StringBuilder.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: NoSuchProviderException.getMessage
        // call: NoSuchAlgorithmException.<init>
        // call: p0b7b2d36$3.<init>
        // call: p0b7b2d36.m4161443f
        // type: StringBuilder
        // type: NoSuchAlgorithmException
        // type: p0b7b2d36$3
    }

}
