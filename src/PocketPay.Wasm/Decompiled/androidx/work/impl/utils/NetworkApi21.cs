namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u0018\u0010\u0000\u001a\u0004\u0018\u00010\u0001*\u00020\u00022\b\u0010\u0003\u001a\u0004\u0018\u00010\u0004H\u0000\u001a\u0014\u0010\u0005\u001a\u00020\u0006*\u00020\u00012\u0006\u0010\u0007\u001a\u00020\bH\u0000\u001a\u0014\u0010\t\u001a\u00020\n*\u00020\u00022\u0006\u0010\u000b\u001a\u00020\fH\u0000¨\u0006\r"}, d2 = {"getNetworkCapabilitiesCompat", "Landroid/net/NetworkCapabilities;", "Landroid/net/ConnectivityManager;", "network", "Landroid/net/Network;", "hasCapabilityCompat", "", "capability", "", "unregisterNetworkCallbackCompat", "", "networkCallback", "Landroid/net/ConnectivityManager$NetworkCallback;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class NetworkApi21 {
    public static readonly android.net.NetworkCapabilities GetNetworkCapabilitiesCompat(android.net.ConnectivityManager connectivityManager, android.net.Network network) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(connectivityManager, "<this>");
        return connectivityManager.getNetworkCapabilities(network);
    }

    public static readonly bool HasCapabilityCompat(android.net.NetworkCapabilities networkCapabilities, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(networkCapabilities, "<this>");
        return networkCapabilities.hasCapability(i);
    }

    public static readonly void UnregisterNetworkCallbackCompat(android.net.ConnectivityManager connectivityManager, android.net.ConnectivityManager$NetworkCallback networkCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(connectivityManager, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(networkCallback, "networkCallback");
        connectivityManager.unregisterNetworkCallback(networkCallback);
    }
}

