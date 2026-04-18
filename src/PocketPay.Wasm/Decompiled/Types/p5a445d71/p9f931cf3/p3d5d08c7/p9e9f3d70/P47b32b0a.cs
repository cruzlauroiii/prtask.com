namespace WillowMaze.Wasm.Decompiled;

public class P47b32b0a : CertStoreSpi
{
    private static string F05a021eb;
    private static string F1fe3f8e9;
    private static string F221defef;
    private static string F40400841;
    private static string F5083a776;
    private static string F5250a6b8;
    private static string F636333d4;
    private static string F6c991371;
    private static string F70d017c6;
    private static string F9ae8f034;
    private static string Fa9fa886b;
    private static string Fbb1eb989;
    private static string Fcf1a88cb;
    private static string Fd39174ab;
    private static string Fe97934a1;
    private static string Fed2a102a;
    private static string Ff28da333;
    private static string Ff536c9e6;
    private pc716ce37 F1eef2de9;
    private pc716ce37 F21ffce5b;

    private HashSet<object> M06a943c5(string P0, string P1, string[] P2)
    {
        // str: "(&("
        // str: ")("
        // str: "=*))"
        // str: "("
        // str: "=*)"
        // str: "Error getting results from LDAP directory "
        // str: "="
        // call: HashSet<object>.<init>
        // call: p47b32b0a.m933dfe4a
        // call: SearchControls.<init>
        // call: SearchControls.setSearchScope
        // call: SearchControls.setCountLimit
        // call: SearchControls.setReturningAttributes
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: pc716ce37.getBaseDN
        // call: DirContext.search
        // call: NamingEnumeration.hasMoreElements
        // call: NamingEnumeration.next
        // call: SearchResult.getAttributes
        // call: Attributes.getAll
        // call: Attribute.getAll
        // call: NamingEnumeration.hasMore
        // call: HashSet<object>.add
        // call: DirContext.close
        // call: CertStoreException.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p47b32b0a.f21ffce5b
        // type: SearchControls
        // type: StringBuilder
        // type: HashSet<object>
        // type: CertStoreException
        return default!;
    }

    private string M07f352af(string P0, string P1)
    {
        // str: "\""
        // call: string.indexOf
        // call: string.substring
        // call: string.charAt
        // call: string.length
        // call: string.toLowerCase
        // call: string.endsWith
        // call: string.startsWith
        return string.Empty;
    }

    private HashSet<object> M49af30d4(X509CertSelector P0)
    {
        // str: "*"
        // call: pc716ce37.getCACertificateAttribute
        // call: pc716ce37.getCACertificateSubjectAttributeName
        // call: pc716ce37.getLdapCACertificateAttributeName
        // call: p47b32b0a.m6c7d4c73
        // call: p47b32b0a.m06a943c5
        // call: HashSet<object>.isEmpty
        // call: HashSet<object>.addAll
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p47b32b0a.f21ffce5b
        return default!;
    }

    private HashSet<object> M6c7d4c73(X509CertSelector P0, string[] P1, string P2, string P3)
    {
        // str: "RFC1779"
        // str: "exception processing selector: "
        // str: "*"
        // call: HashSet<object>.<init>
        // call: X509CertSelector.getSubjectAsBytes
        // call: X509CertSelector.getSubjectAsString
        // call: X509CertSelector.getCertificate
        // call: p47b32b0a.m06a943c5
        // call: X509Certificate.getSubjectX500Principal
        // call: X500Principal.getName
        // call: X509Certificate.getSerialNumber
        // call: System.Numerics.BigInteger.toString
        // call: X500Principal.<init>
        // call: p47b32b0a.m07f352af
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: HashSet<object>.addAll
        // call: pc716ce37.getSearchForSerialNumberIn
        // call: CertStoreException.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p47b32b0a.f21ffce5b
        // type: X500Principal
        // type: StringBuilder
        // type: CertStoreException
        // type: HashSet<object>
        return default!;
    }

    private DirContext M933dfe4a()
    {
        // str: "72d3ea1cbaf10b758339c3e52b9711b0848c080d417b29f774584ed2b975552abb25661635605a91c0f491ee"
        // str: "a09e737da0852f1b70dc8c9e9bee7fc707079edf89e2ec2cda448784365d33bd"
        // str: "java.naming.batchsize"
        // str: "java.naming.factory.initial"
        // str: "java.naming.referral"
        // str: "042ea5531968db65e9f7c2f38cc5400872af575ff27debf58553e63e5e"
        // str: "java.naming.provider.url"
        // str: "java.naming.factory.url.pkgs"
        // str: "java.naming.security.authentication"
        // call: DecryptString.decryptString
        // call: Properties.setProperty
        // call: InitialDirContext.<init>
        // call: pc716ce37.getLdapURL
        // call: Properties.<init>
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p47b32b0a.f221defef
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p47b32b0a.fcf1a88cb
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p47b32b0a.f21ffce5b
        // type: InitialDirContext
        // type: Properties
        return default!;
    }

    private HashSet<object> M99318ca1(X509CertSelector P0)
    {
        // str: "*"
        // call: p47b32b0a.m6c7d4c73
        // call: p47b32b0a.m06a943c5
        // call: pc716ce37.getLdapCrossCertificateAttributeName
        // call: HashSet<object>.addAll
        // call: pc716ce37.getCrossCertificateAttribute
        // call: pc716ce37.getCrossCertificateSubjectAttributeName
        // call: HashSet<object>.isEmpty
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p47b32b0a.f21ffce5b
        return default!;
    }

    private HashSet<object> Med43b357(X509CertSelector P0)
    {
        // call: pc716ce37.getLdapUserCertificateAttributeName
        // call: pc716ce37.getUserCertificateSubjectAttributeName
        // call: pc716ce37.getUserCertificateAttribute
        // call: p47b32b0a.m6c7d4c73
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p47b32b0a.f21ffce5b
        return default!;
    }

    public ICollection<object> EngineGetCRLs(CRLSelector P0)
    {
        // str: "selector is not a X509CRLSelector"
        // str: "RFC1779"
        // str: "*"
        // str: "X.509"
        // str: "e522517e082777b2eb351f52b85439d3b47283686ee92973702dbdf91b27"
        // str: "CRL cannot be constructed from LDAP result "
        // call: pc716ce37.getCertificateRevocationListIssuerAttributeName
        // call: StringBuilder.<init>
        // call: X509CRLSelector.getIssuerNames
        // call: X500Principal.<init>
        // call: CertStoreException.<init>
        // call: HashSet<object>.addAll
        // call: HashSet<object>.<init>
        // call: StringBuilder.append
        // call: p47b32b0a.m06a943c5
        // call: p47b32b0a.m07f352af
        // call: HashSet<object>.iterator
        // call: DecryptString.decryptString
        // call: CertificateFactory.getInstance
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: MemoryStream.<init>
        // call: CertificateFactory.generateCRL
        // call: X509CRLSelector.match
        // call: HashSet<object>.add
        // call: X500Principal.getName
        // field: p5a445d71.p9f931cf3.p3d5d08c7.p9e9f3d70.p47b32b0a.f21ffce5b
        // type: StringBuilder
        // type: HashSet<object>
        // type: X500Principal
        // type: MemoryStream
        // type: CertStoreException
        return default!;
    }

    public ICollection<object> EngineGetCertificates(CertSelector P0)
    {
        // str: "selector is not a X509CertSelector"
        // str: "X.509"
        // str: "e6bcb6401f39f1d2804f84fd3d3518c840b1816f7eff015e6b1caad54a38"
        // str: "certificate cannot be constructed from LDAP result: "
        // call: CertStoreException.<init>
        // call: HashSet<object>.addAll
        // call: StringBuilder.append
        // call: p47b32b0a.med43b357
        // call: p47b32b0a.m99318ca1
        // call: StringBuilder.<init>
        // call: p47b32b0a.m49af30d4
        // call: HashSet<object>.<init>
        // call: StringBuilder.toString
        // call: HashSet<object>.iterator
        // call: DecryptString.decryptString
        // call: CertificateFactory.getInstance
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: List<object>.<init>
        // call: List<object>.add
        // call: pd1c2953c.<init>
        // call: pd1c2953c.readObject
        // call: pf1ef2c78.m8bab0102
        // call: List<object>.clear
        // type: CertStoreException
        // type: StringBuilder
        // type: HashSet<object>
        // type: List<object>
        // type: pd1c2953c
        // type: MemoryStream
        return default!;
    }

}
