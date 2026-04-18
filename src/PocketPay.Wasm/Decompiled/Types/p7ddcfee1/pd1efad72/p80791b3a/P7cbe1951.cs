namespace WillowMaze.Wasm.Decompiled;

public class P7cbe1951 : P06050a91
{
    private readonly p50e34df9 F36278a16;
    private readonly p50e34df9 F3952212f;
    private readonly p50e34df9 F5869df16;

    private string CookieHeader(List<object> P0)
    {
        // str: "; "
        // str: "StringBuilder().apply(builderAction).toString()"
        // call: IEnumerable<object>.iterator
        // call: StringBuilder.append
        // call: p706f1088.name
        // call: StringBuilder.toString
        // call: StringBuilder.<init>
        // call: CollectionsKt.throwIndexOverflow
        // call: p706f1088.value
        // call: IEnumerator<object>.hasNext
        // call: IEnumerator<object>.next
        // call: Intrinsics.checkNotNullExpressionValue
        // type: StringBuilder
        return string.Empty;
    }

    public pd64ed3e9 Intercept(p06050a91$p53205501 P0)
    {
        // str: "chain"
        // str: "gzip"
        // str: "Connection"
        // str: "4ed5105a3eb9dd545d0cb0428a114747281c29aee20e448840adb9ef743f8715ba8606ce6b7fa5d0"
        // str: "Host"
        // str: "Keep-Alive"
        // str: "Accept-Encoding"
        // str: "fecb00f3245f0bbb859dd299f0cc814db9eee913395ca2dd0bb9f2c67fa89db318c5d07119ff89c60d"
        // str: "Cookie"
        // str: "Transfer-Encoding"
        // str: "Content-Length"
        // str: "68a8d3350b168a6f2dffbe7266b4680c962c65cf1174f3e9299ec91ae7eb60471327420b14f002195f8cc597"
        // str: "chunked"
        // str: "Range"
        // str: "993b62855f6d89aa12850f7aacec670cb7d69a68ee40246f98b89935f8b057d5a19f6a0fd5b8"
        // call: ICollection<object>.isEmpty
        // call: p15c2d85f$p2bd4a59b.header
        // call: pd64ed3e9.m28ab1449
        // call: p15c2d85f.header
        // call: p15c2d85f.newBuilder
        // call: p883d7615$p2bd4a59b.removeAll
        // call: pd64ed3e9.headers
        // call: p15c2d85f.body
        // call: pd64ed3e9$p2bd4a59b.body
        // call: DecryptString.decryptString
        // call: p23e8a4b4.toHostHeader$default
        // call: p06050a91$p53205501.request
        // call: p883d7615$p2bd4a59b.build
        // call: p15c2d85f.url
        // call: pd896b5e6.receiveHeaders
        // call: p15c2d85f$p2bd4a59b.removeHeader
        // call: p0d3cf03b.contentType
        // call: pd64ed3e9.newBuilder
        // call: p883d7615.newBuilder
        // call: pb5d3c5d3.<init>
        // field: p7ddcfee1.pd1efad72.p80791b3a.p7cbe1951.f3952212f
        // type: pb5d3c5d3
        // type: p00313170
        return default!;
    }

}
