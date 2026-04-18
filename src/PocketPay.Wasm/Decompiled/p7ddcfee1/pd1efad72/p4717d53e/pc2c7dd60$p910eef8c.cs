namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00008\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\b\u0086\u0003\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J&\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\f2\u0006\u0010\r\u001a\u00020\u000e2\u0006\u0010\u000f\u001a\u00020\u00102\u0006\u0010\u0011\u001a\u00020\u0004R\u000e\u0010\u0003\u001a\u00020\u0004X\u0080T¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082T¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Lp7ddcfee1/pd1efad72/p4717d53e/pc2c7dd60$p910eef8c;", "", "()V", "IDLE_CONNECTION_HEALTHY_NS", "", "MAX_TUNNEL_ATTEMPTS", "", "NPE_THROW_WITH_NULL", "", "newTestConnection", "Lp7ddcfee1/pd1efad72/p4717d53e/pc2c7dd60;", "connectionPool", "Lp7ddcfee1/pd1efad72/p4717d53e/pe5e1ca24;", "route", "Lp7ddcfee1/p9405c3af;", "socket", "Ljava/net/Socket;", "idleAtNs", "okhttp"}, m527k = 1, mv = {1, 6, 0}, xi = 48)
public readonly class pc2c7dd60$p910eef8c {
    private pc2c7dd60$p910eef8c() {
    }

    public pc2c7dd60$p910eef8c(kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this();
    }

    public readonly p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60 NewTestConnection(p7ddcfee1.pd1efad72.p4717d53e.pe5e1ca24 connectionPool, p7ddcfee1.p9405c3af route, java.net.Socket socket, long idleAtNs) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(connectionPool, "connectionPool");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(route, "route");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(socket, "socket");
        p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60 pc2c7dd60Var = new p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60(connectionPool, route);
        p7ddcfee1.pd1efad72.p4717d53e.pc2c7dd60.access$setSocket$p(pc2c7dd60Var, socket);
        pc2c7dd60Var.setIdleAtNs$okhttp(idleAtNs);
        return pc2c7dd60Var;
    }
}

