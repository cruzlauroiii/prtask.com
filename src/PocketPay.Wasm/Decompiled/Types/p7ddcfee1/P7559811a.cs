namespace WillowMaze.Wasm.Decompiled;

public class P7559811a
{
    public static p7559811a$p910eef8c F05b8b57f;
    public static p7559811a$p910eef8c F2f867da6;
    public static p7559811a$p910eef8c F910eef8c;
    private readonly List<object> F09f4c753;
    private readonly List<object> F0db7fb8a;
    private readonly p4e56d02a F3cb6c58e;
    private readonly p20455456 F460fd9fd;
    private readonly p4e56d02a F6900c76a;
    private readonly List<object> F6f142d6c;
    private readonly p20455456 F7fbef881;
    private readonly List<object> F90097617;
    private readonly p4e56d02a Fbae232ea;
    private readonly p4e56d02a Fbf4d4b6c;
    private readonly p20455456 Fc438bf28;
    private readonly p4e56d02a Fe6f44969;
    private readonly p20455456 Ff93b031c;
    private readonly Lazy<object> PeerCertificates$delegate;

    private string M32132c89(Certificate P0)
    {
        // str: "6cc325fb031ebc27f021248edd0346884a2714c532332aed1f340ddbf148b347"
        // call: object.toString
        // call: DecryptString.decryptString
        // call: Intrinsics.checkNotNullExpressionValue
        // call: X509Certificate.getSubjectDN
        // call: Certificate.getType
        return string.Empty;
    }

    public static p7559811a Mb5eda0a7(SSLSession P0)
    {
        // call: p7559811a$p910eef8c.get
        // field: p7ddcfee1.p7559811a.f910eef8c
        return default!;
    }

    public static p7559811a Mb5eda0a7(p20455456 P0, p4e56d02a P1, List<object> P2, List<object> P3)
    {
        // call: p7559811a$p910eef8c.get
        // field: p7ddcfee1.p7559811a.f910eef8c
        return default!;
    }

    public p4e56d02a -deprecated_cipherSuite()
    {
        // field: p7ddcfee1.p7559811a.f3cb6c58e
        return default!;
    }

    public List<object> -deprecated_localCertificates()
    {
        // field: p7ddcfee1.p7559811a.f6f142d6c
        return default!;
    }

    public Principal -deprecated_localPrincipal()
    {
        // call: p7559811a.localPrincipal
        return default!;
    }

    public List<object> -deprecated_peerCertificates()
    {
        // call: p7559811a.peerCertificates
        return default!;
    }

    public Principal -deprecated_peerPrincipal()
    {
        // call: p7559811a.peerPrincipal
        return default!;
    }

    public p20455456 -deprecated_tlsVersion()
    {
        // field: p7ddcfee1.p7559811a.ff93b031c
        return default!;
    }

    public p4e56d02a CipherSuite()
    {
        // field: p7ddcfee1.p7559811a.f3cb6c58e
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: p7559811a.peerCertificates
        // call: Intrinsics.areEqual
        // field: p7ddcfee1.p7559811a.f3cb6c58e
        // field: p7ddcfee1.p7559811a.f6f142d6c
        // field: p7ddcfee1.p7559811a.ff93b031c
        return false;
    }

    public int HashCode()
    {
        // call: p20455456.hashCode
        // call: p7559811a.peerCertificates
        // call: object.hashCode
        // call: p4e56d02a.hashCode
        // field: p7ddcfee1.p7559811a.f3cb6c58e
        // field: p7ddcfee1.p7559811a.f6f142d6c
        // field: p7ddcfee1.p7559811a.ff93b031c
        return 0;
    }

    public List<object> LocalCertificates()
    {
        // field: p7ddcfee1.p7559811a.f6f142d6c
        return default!;
    }

    public Principal LocalPrincipal()
    {
        // call: CollectionsKt.firstOrNull
        // call: X509Certificate.getSubjectX500Principal
        // field: p7ddcfee1.p7559811a.f6f142d6c
        return default!;
    }

    public List<object> PeerCertificates()
    {
        // call: Lazy<object>.getValue
        // field: p7ddcfee1.p7559811a.peerCertificates$delegate
        return default!;
    }

    public Principal PeerPrincipal()
    {
        // call: X509Certificate.getSubjectX500Principal
        // call: p7559811a.peerCertificates
        // call: CollectionsKt.firstOrNull
        return default!;
    }

    public p20455456 TlsVersion()
    {
        // field: p7ddcfee1.p7559811a.ff93b031c
        return default!;
    }

    public string ToString()
    {
        // str: " peerCertificates="
        // str: "Handshake{tlsVersion="
        // str: " cipherSuite="
        // str: " localCertificates="
        // call: StringBuilder.append
        // call: IEnumerable<object>.iterator
        // call: p7559811a.peerCertificates
        // call: StringBuilder.toString
        // call: CollectionsKt.collectionSizeOrDefault
        // call: IEnumerator<object>.hasNext
        // call: ICollection<object>.add
        // call: p7559811a.m32132c89
        // call: IEnumerator<object>.next
        // call: object.toString
        // call: List<object>.<init>
        // call: StringBuilder.<init>
        // field: p7ddcfee1.p7559811a.ff93b031c
        // field: p7ddcfee1.p7559811a.f3cb6c58e
        // field: p7ddcfee1.p7559811a.f6f142d6c
        // type: List<object>
        // type: StringBuilder
        return string.Empty;
    }

}
