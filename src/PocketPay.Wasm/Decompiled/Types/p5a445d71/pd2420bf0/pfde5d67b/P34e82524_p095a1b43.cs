namespace WillowMaze.Wasm.Decompiled;

public abstract class P34e82524_p095a1b43 : Pc2cc7082$p095a1b43
{
    private pc2cc7082$p4c3880bb F21fba57f;
    private pc2cc7082$p4c3880bb F32346884;
    private pc2cc7082$p4c3880bb F357ee36d;
    private Dictionary<string, object> F4340fd73;
    private Dictionary<string, object> F4571a4a0;
    private Dictionary<string, object> F55e7dd30;
    private Uri F572d4e42;
    private Uri F5a74f83e;
    private Uri F81b9fdf4;
    private Dictionary<string, object> F8955c267;
    private Uri F8e70ccfe;
    private Dictionary<string, object> F96b6315e;
    private pc2cc7082$p4c3880bb Fea9f6aca;

    private Map$Entry M1f809e1c(string P0)
    {
        // call: Map$Entry.getKey
        // call: string.equals
        // call: p1060d512.mef6cf578
        // call: Dictionary<string, object>.entrySet
        // call: IEnumerator<object>.next
        // call: HashSet<object>.iterator
        // call: IEnumerator<object>.hasNext
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f4340fd73
        return default!;
    }

    private static string M6d861da2(string P0)
    {
        // str: "1eae0134df6e43b0016fef97e09f00f06efb0673d53e1361a8a7b4538b1cdba5ff606b000ab9"
        // str: "2becdf7b0d8c1d3db958d0335d913af2a61327d756f7bf232683ff64278bc64d24"
        // call: DecryptString.decryptString
        // call: string.getBytes
        // call: p34e82524$p095a1b43.m9b0084a2
        // call: string.<init>
        // type: string
        return string.Empty;
    }

    private static bool M9b0084a2(byte[] P0)
    {
        return false;
    }

    private List<object> Ma287dc0b(string P0)
    {
        // call: HashSet<object>.iterator
        // call: pad3d06d0.m78a62b57
        // call: IEnumerator<object>.next
        // call: string.equalsIgnoreCase
        // call: Dictionary<string, object>.entrySet
        // call: Map$Entry.getValue
        // call: Map$Entry.getKey
        // call: IEnumerator<object>.hasNext
        // call: Collections.emptyList
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f4340fd73
        return default!;
    }

    public pc2cc7082$p095a1b43 AddHeader(string P0, string P1)
    {
        // str: ""
        // call: p34e82524$p095a1b43.headers
        // call: p34e82524$p095a1b43.m6d861da2
        // call: pad3d06d0.m4d495f50
        // call: List<object>.isEmpty
        // call: List<object>.add
        // call: Dictionary<string, object>.put
        // call: List<object>.<init>
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f4340fd73
        // type: List<object>
        return default!;
    }

    public string Cookie(string P0)
    {
        // str: "Cookie name must not be empty"
        // call: Dictionary<string, object>.get
        // call: pad3d06d0.m4d495f50
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f55e7dd30
        return string.Empty;
    }

    public pc2cc7082$p095a1b43 Cookie(string P0, string P1)
    {
        // str: "Cookie value must not be null"
        // str: "Cookie name must not be empty"
        // call: pad3d06d0.m78a62b57
        // call: pad3d06d0.m4d495f50
        // call: Dictionary<string, object>.put
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f55e7dd30
        return default!;
    }

    public Dictionary<string, object> Cookies()
    {
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f55e7dd30
        return default!;
    }

    public bool HasCookie(string P0)
    {
        // str: "Cookie name must not be empty"
        // call: Dictionary<string, object>.containsKey
        // call: pad3d06d0.m4d495f50
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f55e7dd30
        return false;
    }

    public bool HasHeader(string P0)
    {
        // str: "Header name must not be empty"
        // call: pad3d06d0.m4d495f50
        // call: p34e82524$p095a1b43.ma287dc0b
        // call: List<object>.size
        return false;
    }

    public bool HasHeaderWithValue(string P0, string P1)
    {
        // call: p34e82524$p095a1b43.headers
        // call: pad3d06d0.m4d495f50
        // call: IEnumerator<object>.next
        // call: List<object>.iterator
        // call: string.equalsIgnoreCase
        // call: IEnumerator<object>.hasNext
        return false;
    }

    public string Header(string P0)
    {
        // str: "Header name must not be null"
        // str: ", "
        // call: p34e82524$p095a1b43.ma287dc0b
        // call: pad3d06d0.m78a62b57
        // call: List<object>.size
        // call: p101ebc0f.m731b886d
        return string.Empty;
    }

    public pc2cc7082$p095a1b43 Header(string P0, string P1)
    {
        // str: "Header name must not be empty"
        // call: pad3d06d0.m4d495f50
        // call: p34e82524$p095a1b43.addHeader
        // call: p34e82524$p095a1b43.removeHeader
        return default!;
    }

    public List<object> Headers(string P0)
    {
        // call: pad3d06d0.m4d495f50
        // call: p34e82524$p095a1b43.ma287dc0b
        return default!;
    }

    public Dictionary<string, object> Headers()
    {
        // call: Dictionary<string, object>.<init>
        // call: HashSet<object>.iterator
        // call: Dictionary<string, object>.size
        // call: List<object>.get
        // call: Dictionary<string, object>.entrySet
        // call: Dictionary<string, object>.put
        // call: IEnumerator<object>.next
        // call: List<object>.size
        // call: Map$Entry.getKey
        // call: Map$Entry.getValue
        // call: IEnumerator<object>.hasNext
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f4340fd73
        // type: Dictionary<string, object>
        return default!;
    }

    public pc2cc7082$p095a1b43 Method(pc2cc7082$p4c3880bb P0)
    {
        // str: "Method must not be null"
        // call: pad3d06d0.m78a62b57
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.fea9f6aca
        return default!;
    }

    public pc2cc7082$p4c3880bb Method()
    {
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.fea9f6aca
        return default!;
    }

    public Dictionary<string, object> MultiHeaders()
    {
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f4340fd73
        return default!;
    }

    public pc2cc7082$p095a1b43 RemoveCookie(string P0)
    {
        // str: "Cookie name must not be empty"
        // call: Dictionary<string, object>.remove
        // call: pad3d06d0.m4d495f50
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f55e7dd30
        return default!;
    }

    public pc2cc7082$p095a1b43 RemoveHeader(string P0)
    {
        // str: "Header name must not be empty"
        // call: p34e82524$p095a1b43.m1f809e1c
        // call: Dictionary<string, object>.remove
        // call: pad3d06d0.m4d495f50
        // call: Map$Entry.getKey
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f4340fd73
        return default!;
    }

    public Uri Url()
    {
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f572d4e42
        return default!;
    }

    public pc2cc7082$p095a1b43 Url(Uri P0)
    {
        // str: "URL must not be null"
        // call: pad3d06d0.m78a62b57
        // field: p5a445d71.pd2420bf0.pfde5d67b.p34e82524$p095a1b43.f572d4e42
        return default!;
    }

}
