namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\bÆ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bJ\u0018\u0010\t\u001a\u00020\n2\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\bH\u0002J\u000e\u0010\u000b\u001a\u00020\u00042\u0006\u0010\f\u001a\u00020\r¨\u0006\u000e"}, d2 = {"Lp7ddcfee1/pd1efad72/p80791b3a/p6c333899;", "", "()V", "get", "", "request", "Lp7ddcfee1/p15c2d85f;", "proxyType", "Ljava/net/Proxy$Type;", "includeAuthorityInRequestLine", "", "requestPath", "url", "Lp7ddcfee1/pdfadebdd;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p6c333899 {
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p6c333899 f76425f17 = new p7ddcfee1.pd1efad72.p80791b3a.p6c333899();
    public static readonly p7ddcfee1.pd1efad72.p80791b3a.p6c333899 fa0a8ceab = null;

    private p6c333899() {
    }

    private readonly bool IncludeAuthorityInRequestLine(p7ddcfee1.p15c2d85f request, java.net.Proxy$Type proxyType) {
        return !request.isHttps() && proxyType == java.net.Proxy$Type.HTTP;
    }

    public readonly java.lang.string Get(p7ddcfee1.p15c2d85f request, java.net.Proxy$Type proxyType) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(request, "request");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(proxyType, "proxyType");
        java.lang.stringBuilder sb = new java.lang.stringBuilder();
        sb.append(request.method());
        sb.append(' ');
        p7ddcfee1.pd1efad72.p80791b3a.p6c333899 p6c333899Var = f76425f17;
        if (p6c333899Var.includeAuthorityInRequestLine(request, proxyType)) {
            sb.append(request.url());
        } else {
            sb.append(p6c333899Var.requestPath(request.url()));
        }
        sb.append(" HTTP/1.1");
        java.lang.string string = sb.tostring();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(string, "stringBuilder().apply(builderAction).tostring()");
        return string;
    }

    public readonly java.lang.string RequestPath(p7ddcfee1.pdfadebdd url) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(url, "url");
        java.lang.string strEncodedPath = url.encodedPath();
        java.lang.string strEncodedQuery = url.encodedQuery();
        return strEncodedQuery is null ? strEncodedPath : strEncodedPath + '?' + ((java.lang.object) strEncodedQuery);
    }
}

