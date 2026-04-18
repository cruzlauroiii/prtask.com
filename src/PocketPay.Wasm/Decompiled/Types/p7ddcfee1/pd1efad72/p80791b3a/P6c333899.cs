namespace WillowMaze.Wasm.Decompiled;

public class P6c333899
{
    public static p6c333899 F76425f17;
    public static p6c333899 Fa0a8ceab;

    private bool IncludeAuthorityInRequestLine(p15c2d85f P0, Proxy$Type P1)
    {
        // call: p15c2d85f.isHttps
        // field: java.net.Proxy$Type.HTTP
        return false;
    }

    public string Get(p15c2d85f P0, Proxy$Type P1)
    {
        // str: "request"
        // str: "proxyType"
        // str: " HTTP/1.1"
        // str: "StringBuilder().apply(builderAction).toString()"
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.append
        // call: p15c2d85f.method
        // call: p6c333899.requestPath
        // call: StringBuilder.<init>
        // call: p15c2d85f.url
        // call: p6c333899.includeAuthorityInRequestLine
        // call: StringBuilder.toString
        // call: Intrinsics.checkNotNullExpressionValue
        // field: p7ddcfee1.pd1efad72.p80791b3a.p6c333899.f76425f17
        // type: StringBuilder
        return string.Empty;
    }

    public string RequestPath(pdfadebdd P0)
    {
        // str: "url"
        // call: pdfadebdd.encodedPath
        // call: Intrinsics.checkNotNullParameter
        // call: StringBuilder.append
        // call: StringBuilder.toString
        // call: pdfadebdd.encodedQuery
        // call: StringBuilder.<init>
        // type: StringBuilder
        return string.Empty;
    }

}
