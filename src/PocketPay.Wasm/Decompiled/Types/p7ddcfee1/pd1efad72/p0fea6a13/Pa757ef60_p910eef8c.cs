namespace WillowMaze.Wasm.Decompiled;

public class Pa757ef60_p910eef8c
{
    public static p883d7615 Access$combine(pa757ef60$p910eef8c P0, p883d7615 P1, p883d7615 P2)
    {
        // call: pa757ef60$p910eef8c.combine
        return default!;
    }

    public static pd64ed3e9 Access$stripBody(pa757ef60$p910eef8c P0, pd64ed3e9 P1)
    {
        // call: pa757ef60$p910eef8c.stripBody
        return default!;
    }

    private p883d7615 Combine(p883d7615 P0, p883d7615 P1)
    {
        // str: "3f84023d2687e931ba26ad44d981d633305c3634c83dd94ba583999599"
        // str: "Warning"
        // call: p883d7615.value
        // call: StringsKt.equals
        // call: p883d7615$p2bd4a59b.build
        // call: p883d7615.size
        // call: StringsKt.startsWith$default
        // call: pa757ef60$p910eef8c.isContentSpecificHeader
        // call: p883d7615.get
        // call: DecryptString.decryptString
        // call: p883d7615$p2bd4a59b.addLenient$okhttp
        // call: p883d7615$p2bd4a59b.<init>
        // call: pa757ef60$p910eef8c.isEndToEnd
        // call: p883d7615.name
        // type: p883d7615$p2bd4a59b
        return default!;
    }

    private bool IsContentSpecificHeader(string P0)
    {
        // str: "Content-Length"
        // str: "7fa4b2fcddb42ad37806032827c1980ba9720ea5599db022ddb76d14c3c61a03c41e6a31e4fa99f7"
        // str: "e615215f994b97b2a602dc77df37356a8196089d0bac4ca57fb979fbfec565668cee07d9fc8c6329ad773af7"
        // call: StringsKt.equals
        // call: DecryptString.decryptString
        return false;
    }

    private bool IsEndToEnd(string P0)
    {
        // str: "TE"
        // str: "Connection"
        // str: "Transfer-Encoding"
        // str: "Proxy-Authorization"
        // str: "Keep-Alive"
        // str: "Proxy-Authenticate"
        // str: "Upgrade"
        // str: "Trailers"
        // call: StringsKt.equals
        return false;
    }

    private pd64ed3e9 StripBody(pd64ed3e9 P0)
    {
        // call: pd64ed3e9$p2bd4a59b.build
        // call: pd64ed3e9.newBuilder
        // call: pd64ed3e9$p2bd4a59b.body
        // call: pd64ed3e9.body
        return default!;
    }

}
