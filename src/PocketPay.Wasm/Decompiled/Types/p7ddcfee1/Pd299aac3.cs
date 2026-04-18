namespace WillowMaze.Wasm.Decompiled;

public class Pd299aac3
{
    public static pd299aac3$p910eef8c F3873d5de;
    public static pd299aac3 F5b39c8b5;
    public static pd299aac3$p910eef8c F910eef8c;
    public static pd299aac3 Fb7e90b32;
    public static pd299aac3$p910eef8c Fceb4c93b;
    private readonly HashSet<object> F28195ebf;
    private readonly p2e948d4e F7d7ee747;
    private readonly p2e948d4e Fb641057a;
    private readonly HashSet<object> Fd3226782;
    private readonly p2e948d4e Fdbe9a409;
    private readonly HashSet<object> Fe6da843d;

    public static string M8a6f5038(Certificate P0)
    {
        // call: pd299aac3$p910eef8c.pin
        // field: p7ddcfee1.pd299aac3.f910eef8c
        return string.Empty;
    }

    public static p58efa9e8 Ma4b1f447(X509Certificate P0)
    {
        // call: pd299aac3$p910eef8c.sha1Hash
        // field: p7ddcfee1.pd299aac3.f910eef8c
        return default!;
    }

    public static p58efa9e8 Mfaa80f21(X509Certificate P0)
    {
        // call: pd299aac3$p910eef8c.sha256Hash
        // field: p7ddcfee1.pd299aac3.f910eef8c
        return default!;
    }

    public void Check(string P0, List<object> P1)
    {
        // str: "hostname"
        // str: "peerCertificates"
        // call: pd299aac3$p0ba4439e$1.<init>
        // call: pd299aac3.check$okhttp
        // call: Intrinsics.checkNotNullParameter
        // type: pd299aac3$p0ba4439e$1
    }

    public void Check(string P0, Certificate[] P1)
    {
        // str: "peerCertificates"
        // str: "hostname"
        // call: Intrinsics.checkNotNullParameter
        // call: ArraysKt.toList
        // call: pd299aac3.check
    }

    public void Check$okhttp(string P0, Func<object> P1)
    {
        // str: ": "
        // str: "sha256"
        // str: "\n    "
        // str: "Certificate pinning failure!\n  Peer certificate chain:"
        // str: "cleanedPeerCertificatesFn"
        // str: "hostname"
        // str: "sha1"
        // str: "\n  Pinned certificates for "
        // str: "StringBuilder().apply(builderAction).toString()"
        // str: "unsupported hashAlgorithm: "
        // str: ":"
        // call: pd299aac3$pe78e14c5.getHash
        // call: X509Certificate.getSubjectDN
        // call: StringBuilder.<init>
        // call: Principal.getName
        // call: pd299aac3$pe78e14c5.getHashAlgorithm
        // call: Intrinsics.areEqual
        // call: pd299aac3.findMatchingPins
        // call: pd299aac3$p910eef8c.pin
        // call: List<object>.iterator
        // call: Func<object>.invoke
        // call: Intrinsics.stringPlus
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.hasNext
        // call: Intrinsics.checkNotNullParameter
        // call: pd299aac3$p910eef8c.sha256Hash
        // call: List<object>.isEmpty
        // call: pd299aac3$p910eef8c.sha1Hash
        // call: SSLPeerUnverifiedException.<init>
        // field: p7ddcfee1.pd299aac3.f910eef8c
        // type: AssertionError
        // type: StringBuilder
        // type: SSLPeerUnverifiedException
    }

    public bool Equals(object P0)
    {
        // call: Intrinsics.areEqual
        // field: p7ddcfee1.pd299aac3.fb641057a
        // field: p7ddcfee1.pd299aac3.fd3226782
        return false;
    }

    public List<object> FindMatchingPins(string P0)
    {
        // str: "hostname"
        // call: Intrinsics.checkNotNullParameter
        // call: List<object>.add
        // call: List<object>.isEmpty
        // call: IEnumerator<object>.next
        // call: List<object>.<init>
        // call: IEnumerator<object>.hasNext
        // call: CollectionsKt.emptyList
        // call: pd299aac3$pe78e14c5.matchesHostname
        // call: IEnumerable<object>.iterator
        // call: TypeIntrinsics.asMutableList
        // field: p7ddcfee1.pd299aac3.fd3226782
        // type: List<object>
        return default!;
    }

    public p2e948d4e GetCertificateChainCleaner$okhttp()
    {
        // field: p7ddcfee1.pd299aac3.fb641057a
        return default!;
    }

    public HashSet<object> GetPins()
    {
        // field: p7ddcfee1.pd299aac3.fd3226782
        return default!;
    }

    public int HashCode()
    {
        // call: object.hashCode
        // field: p7ddcfee1.pd299aac3.fb641057a
        // field: p7ddcfee1.pd299aac3.fd3226782
        return 0;
    }

    public pd299aac3 WithCertificateChainCleaner$okhttp(p2e948d4e P0)
    {
        // str: "certificateChainCleaner"
        // call: Intrinsics.areEqual
        // call: Intrinsics.checkNotNullParameter
        // call: pd299aac3.<init>
        // field: p7ddcfee1.pd299aac3.fb641057a
        // field: p7ddcfee1.pd299aac3.fd3226782
        // type: pd299aac3
        return default!;
    }

}
