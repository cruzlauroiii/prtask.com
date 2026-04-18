namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0010\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\u0010\u0010\u0006\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016J\b\u0010\u0007\u001a\u00020\u0003H\u0016¨\u0006\b"}, d2 = {"app/service/NetworkRetriever$networkCallback$1", "Landroid/net/ConnectivityManager$NetworkCallback;", "onAvailable", "", "network", "Landroid/net/Network;", "onLost", "onUnavailable", "feature-app-impl_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p8b07625b$p80e50760$1 : android.net.ConnectivityManager$NetworkCallback {
    readonly pd2a57dc1.paaabf0d3.p8b07625b this$0;

    p8b07625b$p80e50760$1(pd2a57dc1.paaabf0d3.p8b07625b p8b07625bVar) {
        this.this$0 = p8b07625bVar;
    }

    public override void OnAvailable(android.net.Network network) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(network, "network");
        super.onAvailable(network);
        pd2a57dc1.paaabf0d3.p8b07625b.mc415ec7b(this.this$0);
    }

    public override void OnLost(android.net.Network network) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(network, "network");
        super.onLost(network);
        pd2a57dc1.paaabf0d3.p8b07625b.me9ddd80e(this.this$0);
        pd2a57dc1.paaabf0d3.p8b07625b.mb6238d9f(this.this$0, false);
    }

    public override void OnUnavailable() {
        super.onUnavailable();
        pd2a57dc1.paaabf0d3.p8b07625b.me9ddd80e(this.this$0);
        pd2a57dc1.paaabf0d3.p8b07625b.mb6238d9f(this.this$0, false);
    }
}

