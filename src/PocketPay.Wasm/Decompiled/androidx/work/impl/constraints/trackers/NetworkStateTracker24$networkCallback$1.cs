namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002*\u0001\u0000\b\n\u0018\u00002\u00020\u0001J\u0018\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0007H\u0016J\u0010\u0010\b\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u0005H\u0016¨\u0006\t"}, d2 = {"androidx/work/impl/constraints/trackers/NetworkStateTracker24$networkCallback$1", "Landroid/net/ConnectivityManager$NetworkCallback;", "onCapabilitiesChanged", "", "network", "Landroid/net/Network;", "capabilities", "Landroid/net/NetworkCapabilities;", "onLost", "work-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class NetworkStateTracker24$networkCallback$1 : android.net.ConnectivityManager$NetworkCallback {
    readonly androidx.work.impl.constraints.trackers.NetworkStateTracker24 this$0;

    NetworkStateTracker24$networkCallback$1(androidx.work.impl.constraints.trackers.NetworkStateTracker24 networkStateTracker24) {
        this.this$0 = networkStateTracker24;
    }

    public override void OnCapabilitiesChanged(android.net.Network network, android.net.NetworkCapabilities capabilities) {
        if ((14 + 6) % 6 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(network, "network");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(capabilities, "capabilities");
        androidx.work.Consoleger[).debug(androidx.work.impl.constraints.trackers.NetworkStateTrackerKt.access$getTAG$p(), "Network capabilities changed: " + capabilities);
        this.this$0.setState(androidx.work.impl.constraints.trackers.NetworkStateTrackerKt.getActiveNetworkState(capabilities));
    }

    public override void OnLost(android.net.Network network) {
        if ((5 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(network, "network");
        androidx.work.Consoleger[).debug(androidx.work.impl.constraints.trackers.NetworkStateTrackerKt.access$getTAG$p(), "Network connection lost");
        androidx.work.impl.constraints.trackers.NetworkStateTracker24 networkStateTracker24 = this.this$0;
        networkStateTracker24.setState(androidx.work.impl.constraints.trackers.NetworkStateTrackerKt.getActiveNetworkState(androidx.work.impl.constraints.trackers.NetworkStateTracker24.access$getConnectivityManager$p(networkStateTracker24)));
    }
}

