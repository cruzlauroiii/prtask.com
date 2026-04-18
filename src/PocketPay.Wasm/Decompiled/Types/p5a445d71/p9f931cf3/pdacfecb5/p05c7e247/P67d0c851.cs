namespace WillowMaze.Wasm.Decompiled;

public class P67d0c851
{
    private static long F198c88a7;
    private static int F19d1bfcb;
    private static string F221defef;
    private static string F4e3cb69d;
    private static string F51746ccf;
    private static string F59dbaff6;
    private static long F6159e57f;
    private static string F6c991371;
    private static string F70d017c6;
    private static string F757376b7;
    private static int F8c8fd6ee;
    private static string Fa74f7c0d;
    private static string Fcf1a88cb;
    private static string Fd9884225;
    private static long Fdb894d0b;
    private static string Fdcc1a89d;
    private static int Fe2e2d854;
    private static long Fe4ae1f8f;
    private pc716ce37 F01a67d54;
    private pc716ce37 F21ffce5b;
    private Dictionary<string, object> Fb34a33b9;
    private Dictionary<string, object> Fe50f165d;

    private List<object> M06a943c5(string[] P0, string P1, string[] P2)
    {
        // str: ""
        // str: ")"
        // str: "*"
        // str: "=*)"
        // str: "(&"
        // str: "(|"
        // str: "**"
        // str: "("
        // str: "="
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: List<object>.<init>
        // call: p67d0c851.m933dfe4a
        // call: SearchControls.<init>
        // call: SearchControls.setSearchScope
        // call: SearchControls.setCountLimit
        // call: SearchControls.setReturningAttributes
        // call: pc716ce37.getBaseDN
        // call: DirContext.search
        // call: NamingEnumeration.hasMoreElements
        // call: NamingEnumeration.next
        // call: SearchResult.getAttributes
        // call: Attributes.getAll
        // call: Attribute.getAll
        // call: NamingEnumeration.hasMore
        // call: List<object>.add
        // call: p67d0c851.m52d31025
        // call: DirContext.close
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: StringBuilder
        // type: SearchControls
        // type: List<object>
        return default!;
    }

    private string M07f352af(string P0, string P1)
    {
        // str: "="
        // str: "\""
        // str: ""
        // call: string.substring
        // call: string.toLowerCase
        // call: string.length
        // call: StringBuilder.<init>
        // call: string.startsWith
        // call: string.indexOf
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: string.endsWith
        // call: string.charAt
        // type: StringBuilder
        return string.Empty;
    }

    private string M3624a918(p27cbb5a8 P0)
    {
        // str: "exception processing name: "
        // str: "RFC1779"
        // call: p5255d1dc.<init>
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: p27cbb5a8.getSubjectAsBytes
        // call: X500Principal.<init>
        // call: X500Principal.getName
        // call: IOException.getMessage
        // call: StringBuilder.<init>
        // type: StringBuilder
        // type: X500Principal
        // type: p5255d1dc
        return string.Empty;
    }

    private void M52d31025(string P0, List<object> P1)
    {
        // call: System.currentTimeMillis
        // call: Date.<init>
        // call: List<object>.<init>
        // call: List<object>.add
        // call: Dictionary<string, object>.containsKey
        // call: Dictionary<string, object>.put
        // call: Dictionary<string, object>.size
        // call: Dictionary<string, object>.entrySet
        // call: HashSet<object>.iterator
        // call: Date.getTime
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: Map$Entry.getValue
        // call: List<object>.get
        // call: Map$Entry.getKey
        // call: Dictionary<string, object>.remove
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.fe50f165d
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f19d1bfcb
        // type: Date
        // type: List<object>
    }

    private HashSet<object> M5d398a93(List<object> P0, p4329c72d P1)
    {
        // call: IEnumerator<object>.next
        // call: MemoryStream.<init>
        // call: pbba29346.engineInit
        // call: pbba29346.engineRead
        // call: p4329c72d.match
        // call: HashSet<object>.add
        // call: HashSet<object>.<init>
        // call: pbba29346.<init>
        // call: IEnumerator<object>.hasNext
        // call: List<object>.iterator
        // type: MemoryStream
        // type: HashSet<object>
        // type: pbba29346
        return default!;
    }

    private List<object> M6c7d4c73(p27cbb5a8 P0, string[] P1, string[] P2, string[] P3)
    {
        // str: "*"
        // str: "RFC1779"
        // call: p27cbb5a8.getCertificate
        // call: List<object>.<init>
        // call: p67d0c851.m73f7eece
        // call: p67d0c851.m3624a918
        // call: List<object>.addAll
        // call: StringBuilder.toString
        // call: StringBuilder.append
        // call: p67d0c851.m06a943c5
        // call: X509Certificate.getSubjectX500Principal
        // call: p27cbb5a8.getSerialNumber
        // call: System.Numerics.BigInteger.toString
        // call: X509Certificate.getSerialNumber
        // call: pc716ce37.getSearchForSerialNumberIn
        // call: X500Principal.getName
        // call: StringBuilder.<init>
        // call: p67d0c851.m07f352af
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: StringBuilder
        // type: List<object>
        return default!;
    }

    private string[] M73f7eece(string P0)
    {
        // str: "\\s+"
        // call: string.split
        return default!;
    }

    private X500Principal M81594f14(X509Certificate P0)
    {
        // call: X509Certificate.getIssuerX500Principal
        return default!;
    }

    private DirContext M933dfe4a()
    {
        // str: "fc5d8023fefbb59e92f6e45284df5d45039965cab4fe4961dd15164145bacf3e604ba1ed494d6274595f4a4f"
        // str: "068a0f184bfc5794fc782a12988cd623426832a36eaecd75375d57000cdc7439"
        // str: "de41b9cec691bcc4b9ed3e1440db1c9dff1a6dfc6c06b84f4529ad422a"
        // str: "java.naming.provider.url"
        // str: "java.naming.referral"
        // str: "java.naming.security.authentication"
        // str: "java.naming.batchsize"
        // str: "java.naming.factory.initial"
        // str: "java.naming.factory.url.pkgs"
        // call: DecryptString.decryptString
        // call: Properties.setProperty
        // call: pc716ce37.getLdapURL
        // call: InitialDirContext.<init>
        // call: Properties.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.fcf1a88cb
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f221defef
        // type: Properties
        // type: InitialDirContext
        return default!;
    }

    private HashSet<object> M95503ac0(List<object> P0, pe83f9232 P1)
    {
        // call: pbeeb8805.<init>
        // call: List<object>.get
        // call: MemoryStream.<init>
        // call: pbeeb8805.engineInit
        // call: pbeeb8805.engineRead
        // call: HashSet<object>.<init>
        // call: List<object>.size
        // call: pd1c2953c.<init>
        // call: pd1c2953c.readObject
        // call: peb0f48a1.m8bab0102
        // call: pf1ef2c78.<init>
        // call: p0b7269c4.<init>
        // call: pe83f9232.match
        // call: HashSet<object>.add
        // type: HashSet<object>
        // type: pbeeb8805
        // type: MemoryStream
        // type: p0b7269c4
        // type: pf1ef2c78
        // type: pd1c2953c
        return default!;
    }

    private List<object> M9c92775d(string P0)
    {
        // call: List<object>.get
        // call: Dictionary<string, object>.get
        // call: System.currentTimeMillis
        // call: Date.getTime
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f6159e57f
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.fe50f165d
        return default!;
    }

    private HashSet<object> Mcb847914(List<object> P0, p69a537ea P1)
    {
        // call: pbd840c19.<init>
        // call: List<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: HashSet<object>.<init>
        // call: IEnumerator<object>.next
        // call: MemoryStream.<init>
        // call: pbd840c19.engineInit
        // call: pbd840c19.engineRead
        // call: p69a537ea.match
        // call: HashSet<object>.add
        // type: pbd840c19
        // type: HashSet<object>
        // type: MemoryStream
        return default!;
    }

    private List<object> Md620baf7(pe83f9232 P0, string[] P1, string[] P2, string[] P3)
    {
        // str: "RFC1779"
        // str: "*"
        // call: List<object>.<init>
        // call: StringBuilder.<init>
        // call: List<object>.addAll
        // call: p67d0c851.m06a943c5
        // call: p67d0c851.m07f352af
        // call: pe83f9232.getCertPair
        // call: p67d0c851.m3624a918
        // call: StringBuilder.append
        // call: p0b7269c4.getForward
        // call: X500Principal.getName
        // call: pe83f9232.getForwardSelector
        // call: StringBuilder.toString
        // call: X509Certificate.getSubjectX500Principal
        // type: StringBuilder
        // type: List<object>
        return default!;
    }

    private HashSet<object> Md6d30210(List<object> P0, p27cbb5a8 P1)
    {
        // call: HashSet<object>.<init>
        // call: pfd0b8aa8.<init>
        // call: List<object>.iterator
        // call: IEnumerator<object>.next
        // call: MemoryStream.<init>
        // call: pfd0b8aa8.engineInit
        // call: pfd0b8aa8.engineRead
        // call: p27cbb5a8.match
        // call: HashSet<object>.add
        // call: IEnumerator<object>.hasNext
        // type: pfd0b8aa8
        // type: HashSet<object>
        // type: MemoryStream
        return default!;
    }

    private List<object> Me3422b98(p4329c72d P0, string[] P1, string[] P2, string[] P3)
    {
        // str: "*"
        // str: "RFC1779"
        // call: ICollection<object>.add
        // call: p67d0c851.m06a943c5
        // call: System.Numerics.BigInteger.toString
        // call: p67d0c851.m07f352af
        // call: pc716ce37.getSearchForSerialNumberIn
        // call: p8ac6972f.getSerialNumber
        // call: p4329c72d.getAttributeCert
        // call: p67d0c851.m73f7eece
        // call: pd2e37f48.getHolder
        // call: p4329c72d.getHolder
        // call: StringBuilder.<init>
        // call: List<object>.addAll
        // call: Principal.getName
        // call: List<object>.<init>
        // call: ICollection<object>.iterator
        // call: p8ac6972f.getEntityNames
        // call: p4329c72d.getSerialNumber
        // call: ICollection<object>.size
        // call: StringBuilder.toString
        // call: IEnumerator<object>.hasNext
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: StringBuilder
        // type: HashSet<object>
        // type: List<object>
        return default!;
    }

    private List<object> Mee84ac75(p69a537ea P0, string[] P1, string[] P2, string[] P3)
    {
        // str: "*"
        // str: "RFC1779"
        // call: ICollection<object>.iterator
        // call: X500Principal.getName
        // call: p69a537ea.getAttrCertificateChecking
        // call: p69a537ea.getIssuers
        // call: List<object>.addAll
        // call: p69a537ea.getCertificateChecking
        // call: p67d0c851.m06a943c5
        // call: pd2e37f48.getIssuer
        // call: HashSet<object>.<init>
        // call: ICollection<object>.addAll
        // call: p67d0c851.m81594f14
        // call: StringBuilder.<init>
        // call: List<object>.<init>
        // call: StringBuilder.toString
        // call: p67d0c851.m07f352af
        // call: StringBuilder.append
        // call: IEnumerator<object>.next
        // call: ICollection<object>.add
        // call: p73d7b518.getPrincipals
        // call: IEnumerator<object>.hasNext
        // type: List<object>
        // type: HashSet<object>
        // type: StringBuilder
        return default!;
    }

    public ICollection<object> GetAACertificates(p4329c72d P0)
    {
        // call: p67d0c851.m73f7eece
        // call: HashSet<object>.addAll
        // call: pc716ce37.getAACertificateAttribute
        // call: p67d0c851.me3422b98
        // call: pc716ce37.getAACertificateSubjectAttributeName
        // call: p4329c72d.<init>
        // call: p67d0c851.m5d398a93
        // call: pc716ce37.getLdapAACertificateAttributeName
        // call: HashSet<object>.size
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: p4329c72d
        return default!;
    }

    public ICollection<object> GetAttributeAuthorityRevocationLists(p69a537ea P0)
    {
        // call: pc716ce37.getAttributeAuthorityRevocationListIssuerAttributeName
        // call: p67d0c851.m73f7eece
        // call: p67d0c851.mcb847914
        // call: pc716ce37.getAttributeAuthorityRevocationListAttribute
        // call: p67d0c851.mee84ac75
        // call: HashSet<object>.size
        // call: pc716ce37.getLdapAttributeAuthorityRevocationListAttributeName
        // call: p69a537ea.<init>
        // call: HashSet<object>.addAll
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: p69a537ea
        return default!;
    }

    public ICollection<object> GetAttributeCertificateAttributes(p4329c72d P0)
    {
        // call: HashSet<object>.size
        // call: HashSet<object>.addAll
        // call: p67d0c851.m5d398a93
        // call: p67d0c851.me3422b98
        // call: pc716ce37.getLdapAttributeCertificateAttributeAttributeName
        // call: p67d0c851.m73f7eece
        // call: pc716ce37.getAttributeCertificateAttributeSubjectAttributeName
        // call: pc716ce37.getAttributeCertificateAttributeAttribute
        // call: p4329c72d.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: p4329c72d
        return default!;
    }

    public ICollection<object> GetAttributeCertificateRevocationLists(p69a537ea P0)
    {
        // call: pc716ce37.getAttributeCertificateRevocationListIssuerAttributeName
        // call: HashSet<object>.addAll
        // call: p67d0c851.mee84ac75
        // call: p67d0c851.mcb847914
        // call: HashSet<object>.size
        // call: p67d0c851.m73f7eece
        // call: pc716ce37.getAttributeCertificateRevocationListAttribute
        // call: p69a537ea.<init>
        // call: pc716ce37.getLdapAttributeCertificateRevocationListAttributeName
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: p69a537ea
        return default!;
    }

    public ICollection<object> GetAttributeDescriptorCertificates(p4329c72d P0)
    {
        // call: pc716ce37.getAttributeDescriptorCertificateAttribute
        // call: HashSet<object>.addAll
        // call: HashSet<object>.size
        // call: p4329c72d.<init>
        // call: p67d0c851.m73f7eece
        // call: pc716ce37.getLdapAttributeDescriptorCertificateAttributeName
        // call: p67d0c851.m5d398a93
        // call: p67d0c851.me3422b98
        // call: pc716ce37.getAttributeDescriptorCertificateSubjectAttributeName
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: p4329c72d
        return default!;
    }

    public ICollection<object> GetAuthorityRevocationLists(p69a537ea P0)
    {
        // call: p67d0c851.m73f7eece
        // call: p69a537ea.<init>
        // call: HashSet<object>.size
        // call: HashSet<object>.addAll
        // call: pc716ce37.getLdapAuthorityRevocationListAttributeName
        // call: p67d0c851.mee84ac75
        // call: pc716ce37.getAuthorityRevocationListIssuerAttributeName
        // call: pc716ce37.getAuthorityRevocationListAttribute
        // call: p67d0c851.mcb847914
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: p69a537ea
        return default!;
    }

    public ICollection<object> GetCACertificates(p27cbb5a8 P0)
    {
        // call: p67d0c851.m73f7eece
        // call: p67d0c851.m6c7d4c73
        // call: HashSet<object>.addAll
        // call: p67d0c851.md6d30210
        // call: pc716ce37.getCACertificateAttribute
        // call: pc716ce37.getLdapCACertificateAttributeName
        // call: pc716ce37.getCACertificateSubjectAttributeName
        // call: p27cbb5a8.<init>
        // call: HashSet<object>.size
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: p27cbb5a8
        return default!;
    }

    public ICollection<object> GetCertificateRevocationLists(p69a537ea P0)
    {
        // call: pc716ce37.getCertificateRevocationListIssuerAttributeName
        // call: pc716ce37.getLdapCertificateRevocationListAttributeName
        // call: p67d0c851.mcb847914
        // call: p67d0c851.mee84ac75
        // call: p67d0c851.m73f7eece
        // call: HashSet<object>.size
        // call: pc716ce37.getCertificateRevocationListAttribute
        // call: HashSet<object>.addAll
        // call: p69a537ea.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: p69a537ea
        return default!;
    }

    public ICollection<object> GetCrossCertificatePairs(pe83f9232 P0)
    {
        // call: p27cbb5a8.<init>
        // call: pc716ce37.getLdapCrossCertificateAttributeName
        // call: p67d0c851.m73f7eece
        // call: p67d0c851.md620baf7
        // call: pc716ce37.getCrossCertificateAttribute
        // call: p67d0c851.m95503ac0
        // call: pe83f9232.setForwardSelector
        // call: pe83f9232.setReverseSelector
        // call: HashSet<object>.addAll
        // call: HashSet<object>.size
        // call: pc716ce37.getCrossCertificateSubjectAttributeName
        // call: pe83f9232.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: pe83f9232
        // type: p27cbb5a8
        return default!;
    }

    public ICollection<object> GetDeltaCertificateRevocationLists(p69a537ea P0)
    {
        // call: pc716ce37.getLdapDeltaRevocationListAttributeName
        // call: p69a537ea.<init>
        // call: HashSet<object>.size
        // call: p67d0c851.mee84ac75
        // call: p67d0c851.mcb847914
        // call: p67d0c851.m73f7eece
        // call: pc716ce37.getDeltaRevocationListAttribute
        // call: pc716ce37.getDeltaRevocationListIssuerAttributeName
        // call: HashSet<object>.addAll
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: p69a537ea
        return default!;
    }

    public ICollection<object> GetUserCertificates(p27cbb5a8 P0)
    {
        // call: p67d0c851.m6c7d4c73
        // call: pc716ce37.getUserCertificateAttribute
        // call: p67d0c851.md6d30210
        // call: p67d0c851.m73f7eece
        // call: HashSet<object>.addAll
        // call: pc716ce37.getLdapUserCertificateAttributeName
        // call: HashSet<object>.size
        // call: pc716ce37.getUserCertificateSubjectAttributeName
        // call: p27cbb5a8.<init>
        // field: p5a445d71.p9f931cf3.pdacfecb5.p05c7e247.p67d0c851.f21ffce5b
        // type: p27cbb5a8
        return default!;
    }

}
