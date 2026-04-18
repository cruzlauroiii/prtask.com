namespace WillowMaze.Wasm.Decompiled;

public class Pab0cf104_p910eef8c
{
    private HashSet<object> M5f258a5b(p883d7615 P0)
    {
        // str: "Vary"
        // call: StringsKt.split$default
        // call: SetsKt.emptySet
        // call: List<object>.iterator
        // call: p883d7615.name
        // call: StringsKt.getCASE_INSENSITIVE_ORDER
        // call: p883d7615.size
        // call: StringsKt.equals
        // call: object.toString
        // call: HashSet<object>.<init>
        // call: HashSet<object>.add
        // call: StringsKt.trim
        // call: p883d7615.value
        // call: IEnumerator<object>.next
        // call: IEnumerator<object>.hasNext
        // field: kotlin.jvm.internal.StringCompanionObject.INSTANCE
        // type: HashSet<object>
        return default!;
    }

    private p883d7615 M67be67ce(p883d7615 P0, p883d7615 P1)
    {
        // call: p883d7615.value
        // call: HashSet<object>.contains
        // call: pab0cf104$p910eef8c.m5f258a5b
        // call: p883d7615$p2bd4a59b.add
        // call: p883d7615.name
        // call: p883d7615$p2bd4a59b.<init>
        // call: HashSet<object>.isEmpty
        // call: p883d7615.size
        // call: p883d7615$p2bd4a59b.build
        // field: p7ddcfee1.pd1efad72.p23e8a4b4.f12ea5829
        // type: p883d7615$p2bd4a59b
        return default!;
    }

    public bool HasVaryAll(pd64ed3e9 P0)
    {
        // str: "*"
        // str: "<this>"
        // call: HashSet<object>.contains
        // call: pd64ed3e9.headers
        // call: pab0cf104$p910eef8c.m5f258a5b
        // call: Intrinsics.checkNotNullParameter
        return false;
    }

    public string Key(pdfadebdd P0)
    {
        // str: "url"
        // call: pdfadebdd.toString
        // call: Intrinsics.checkNotNullParameter
        // call: p58efa9e8$p910eef8c.encodeUtf8
        // call: p58efa9e8.hex
        // call: p58efa9e8.md5
        // field: p38cb8f46.p58efa9e8.f910eef8c
        return string.Empty;
    }

    public int ReadInt$okhttp(pcc81e3f6 P0)
    {
        // str: "source"
        // str: "expected an int but was \""
        // call: IOException.<init>
        // call: NumberFormatException.getMessage
        // call: Intrinsics.checkNotNullParameter
        // call: pcc81e3f6.readDecimalLong
        // call: pcc81e3f6.readUtf8LineStrict
        // call: CharSequence.length
        // call: StringBuilder.<init>
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // type: IOException
        // type: StringBuilder
        return 0;
    }

    public p883d7615 VaryHeaders(pd64ed3e9 P0)
    {
        // str: "<this>"
        // call: pd64ed3e9.request
        // call: pd64ed3e9.networkResponse
        // call: Intrinsics.checkNotNullParameter
        // call: p15c2d85f.headers
        // call: pd64ed3e9.headers
        // call: pab0cf104$p910eef8c.m67be67ce
        // call: Intrinsics.checkNotNull
        return default!;
    }

    public bool VaryMatches(pd64ed3e9 P0, p883d7615 P1, p15c2d85f P2)
    {
        // str: "cachedResponse"
        // str: "cachedRequest"
        // str: "newRequest"
        // call: IEnumerable<object>.iterator
        // call: IEnumerator<object>.hasNext
        // call: pab0cf104$p910eef8c.m5f258a5b
        // call: ICollection<object>.isEmpty
        // call: p15c2d85f.headers
        // call: Intrinsics.checkNotNullParameter
        // call: pd64ed3e9.headers
        // call: p883d7615.values
        // call: IEnumerator<object>.next
        // call: Intrinsics.areEqual
        return false;
    }

}
