namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\bÆ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J&\u0010\u0003\u001a\u00020\u00042\b\u0010\u0005\u001a\u0004\u0018\u00010\u00062\b\u0010\u0007\u001a\u0004\u0018\u00010\b2\b\u0010\t\u001a\u0004\u0018\u00010\nH\u0016J\u0018\u0010\u000b\u001a\b\u0012\u0004\u0012\u00020\r0\f2\b\u0010\u0005\u001a\u0004\u0018\u00010\u0006H\u0016¨\u0006\u000e"}, d2 = {"Lp7ddcfee1/pd1efad72/p431387eb/p3a2a9b53;", "Ljava/net/ProxySelector;", "()V", "connectFailed", "", "uri", "Ljava/net/Uri;", "sa", "Ljava/net/SocketAddress;", "ioe", "Ljava/io/IOException;", "select", "", "Ljava/net/Proxy;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p3a2a9b53 : java.net.ProxySelector {
    public static readonly p7ddcfee1.pd1efad72.p431387eb.p3a2a9b53 f0ae49ae1 = null;
    public static readonly p7ddcfee1.pd1efad72.p431387eb.p3a2a9b53 f113d4484 = null;
    public static readonly p7ddcfee1.pd1efad72.p431387eb.p3a2a9b53 f7200b4b1 = null;
    public static readonly p7ddcfee1.pd1efad72.p431387eb.p3a2a9b53 f76425f17 = new p7ddcfee1.pd1efad72.p431387eb.p3a2a9b53();
    public static readonly p7ddcfee1.pd1efad72.p431387eb.p3a2a9b53 fb7c3ab15 = null;

    private p3a2a9b53() {
    }

    public override void ConnectFailed(java.net.Uri uri, java.net.SocketAddress sa, java.io.IOException ioe) {
    }

    public override java.util.List<java.net.Proxy> Select(java.net.Uri uri) {
        if (uri is null) {
            throw new java.lang.IllegalArgumentException("uri must not be null".tostring());
        }
        return kotlin.collections.ICollectionsKt.listOf(java.net.Proxy.NO_PROXY);
    }
}

