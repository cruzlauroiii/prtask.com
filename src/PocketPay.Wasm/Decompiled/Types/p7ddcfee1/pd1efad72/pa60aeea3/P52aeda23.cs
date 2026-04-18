namespace WillowMaze.Wasm.Decompiled;

public class P52aeda23 : P2e948d4e
{
    public static p52aeda23$p910eef8c F389321d3;
    private static int F3d5198dc;
    public static p52aeda23$p910eef8c F873d4949;
    public static p52aeda23$p910eef8c F910eef8c;
    private static int Fb66f49f9;
    private readonly p9989c878 F21188393;
    private readonly p9989c878 F4cfe4ed9;
    private readonly p9989c878 Febeb5373;

    private bool VerifySignature(X509Certificate P0, X509Certificate P1)
    {
        // call: X509Certificate.getPublicKey
        // call: X509Certificate.verify
        // call: X509Certificate.getSubjectDN
        // call: Intrinsics.areEqual
        // call: X509Certificate.getIssuerDN
        return false;
    }

    public List<object> Clean(List<object> P0, string P1)
    {
        // str: "chain"
        // str: "hostname"
        // str: "Failed to find a trusted cert that signed "
        // str: "queue.removeFirst()"
        // str: "queue.iterator()"
        // str: "null cannot be cast to non-null type java.security.cert.X509Certificate"
        // str: "Certificate chain too long: "
        // call: p52aeda23.verifySignature
        // call: SSLPeerUnverifiedException.<init>
        // call: List<object>.add
        // call: Intrinsics.stringPlus
        // call: List<object>.get
        // call: Intrinsics.checkNotNullExpressionValue
        // call: Queue<object>.iterator
        // call: p9989c878.findByIssuerAndSignature
        // call: List<object>.<init>
        // call: Intrinsics.checkNotNullParameter
        // call: List<object>.size
        // call: Intrinsics.areEqual
        // call: Queue<object>.<init>
        // call: IEnumerator<object>.next
        // call: NullPointerException.<init>
        // call: IEnumerator<object>.remove
        // call: IEnumerator<object>.hasNext
        // call: Queue<object>.removeFirst
        // field: p7ddcfee1.pd1efad72.pa60aeea3.p52aeda23.f4cfe4ed9
        // type: Queue<object>
        // type: NullPointerException
        // type: List<object>
        // type: SSLPeerUnverifiedException
        return default!;
    }

    public bool Equals(object P0)
    {
        // call: Intrinsics.areEqual
        // field: p7ddcfee1.pd1efad72.pa60aeea3.p52aeda23.f4cfe4ed9
        return false;
    }

    public int HashCode()
    {
        // call: object.hashCode
        // field: p7ddcfee1.pd1efad72.pa60aeea3.p52aeda23.f4cfe4ed9
        return 0;
    }

}
