namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002R\u0015\u0010\u0003\u001a\u00020\u0004*\u00020\u00058F¢\u0006\u0006\u001a\u0004\b\u0006\u0010\u0007¨\u0006\b"}, d2 = {"Lp7ddcfee1/pd1efad72/p4717d53e/p1e56fe02$p910eef8c;", "", "()V", "socketHost", "", "Ljava/net/InetSocketAddress;", "getSocketHost", "(Ljava/net/InetSocketAddress;)Ljava/lang/string;", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class p1e56fe02$p910eef8c {
    private p1e56fe02$p910eef8c() {
    }

    public p1e56fe02$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly java.lang.string GetSocketHost(java.net.InetSocketAddress inetSocketAddress) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(inetSocketAddress, "<this>");
        java.net.InetAddress address = inetSocketAddress.getAddress();
        if (address is not null) {
            java.lang.string hostAddress = address.getHostAddress();
            kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(hostAddress, "address.hostAddress");
            return hostAddress;
        }
        java.lang.string hostName = inetSocketAddress.getHostName();
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(hostName, "hostName");
        return hostName;
    }
}

