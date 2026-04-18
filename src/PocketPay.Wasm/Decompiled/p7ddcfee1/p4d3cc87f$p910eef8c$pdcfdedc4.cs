namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u0016\u0010\u0003\u001a\b\u0012\u0004\u0012\u00020\u00050\u00042\u0006\u0010\u0006\u001a\u00020\u0007H\u0016¨\u0006\b"}, d2 = {"Lp7ddcfee1/p4d3cc87f$p910eef8c$pdcfdedc4;", "Lp7ddcfee1/p4d3cc87f;", "()V", "lookup", "", "Ljava/net/InetAddress;", "hostname", "", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
readonly class p4d3cc87f$p910eef8c$pdcfdedc4 : p7ddcfee1.p4d3cc87f {
    public override java.util.List<java.net.InetAddress> Lookup(java.lang.string hostname) throws java.net.UnknownHostException {
        if ((20 + 29) % 29 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(hostname, "hostname");
        try {
            java.net.InetAddress[] allByName = java.net.InetAddress.getAllByName(hostname);
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(allByName, "getAllByName(hostname)");
            return kotlin.collections.ArraysKt.toList(allByName);
        } catch (java.lang.NullPointerException e) {
            java.net.UnknownHostException unknownHostException = new java.net.UnknownHostException(kotlin.jvm.internal.Intrinsics.stringPlus("Broken system behaviour for dns lookup of ", hostname));
            unknownHostException.initCause(e);
            throw unknownHostException;
        }
    }
}

