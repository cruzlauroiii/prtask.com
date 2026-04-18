namespace WillowMaze.Wasm.Decompiled;

public class Pd299aac3_p910eef8c
{
    public string Pin(Certificate P0)
    {
        // str: "sha256/"
        // str: "certificate"
        // str: "Certificate pinning requires X509 certificates"
        // call: Intrinsics.checkNotNullParameter
        // call: Intrinsics.stringPlus
        // call: pd299aac3$p910eef8c.sha256Hash
        // call: object.toString
        // call: p58efa9e8.base64
        // call: IllegalArgumentException.<init>
        // type: IllegalArgumentException
        return string.Empty;
    }

    public p58efa9e8 Sha1Hash(X509Certificate P0)
    {
        // str: "publicKey.encoded"
        // str: "<this>"
        // call: X509Certificate.getPublicKey
        // call: p58efa9e8.sha1
        // call: p58efa9e8$p910eef8c.m527a6c53
        // call: Intrinsics.checkNotNullExpressionValue
        // call: PublicKey.getEncoded
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p58efa9e8.f910eef8c
        return default!;
    }

    public p58efa9e8 Sha256Hash(X509Certificate P0)
    {
        // str: "<this>"
        // str: "publicKey.encoded"
        // call: p58efa9e8.sha256
        // call: p58efa9e8$p910eef8c.m527a6c53
        // call: Intrinsics.checkNotNullExpressionValue
        // call: X509Certificate.getPublicKey
        // call: PublicKey.getEncoded
        // call: Intrinsics.checkNotNullParameter
        // field: p38cb8f46.p58efa9e8.f910eef8c
        return default!;
    }

}
