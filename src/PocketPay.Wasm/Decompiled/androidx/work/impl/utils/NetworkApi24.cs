namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u0012\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0003\u001a\u00020\u0004¨\u0006\u0005"}, d2 = {"registerDefaultNetworkCallbackCompat", "", "Landroid/net/ConnectivityManager;", "networkCallback", "Landroid/net/ConnectivityManager$NetworkCallback;", "work-runtime_release"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class NetworkApi24 {
    public static readonly void RegisterDefaultNetworkCallbackCompat(android.net.ConnectivityManager connectivityManager, android.net.ConnectivityManager$NetworkCallback networkCallback) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(connectivityManager, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(networkCallback, "networkCallback");
        connectivityManager.registerDefaultNetworkCallback(networkCallback);
    }
}

