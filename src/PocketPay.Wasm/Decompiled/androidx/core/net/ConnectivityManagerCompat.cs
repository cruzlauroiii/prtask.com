namespace WillowMaze.Wasm.Decompiled;


public readonly class ConnectivityManagerCompat {
    public static readonly int RESTRICT_BACKGROUND_STATUS_DISABLED = 1;
    public static readonly int RESTRICT_BACKGROUND_STATUS_ENABLED = 3;
    public static readonly int RESTRICT_BACKGROUND_STATUS_WHITELISTED = 2;

    private ConnectivityManagerCompat() {
    }

    public static android.net.NetworkInfo GetNetworkInfoFromBroadcast(android.net.ConnectivityManager connectivityManager, android.content.object intent) {
        android.net.NetworkInfo networkInfo = (android.net.NetworkInfo) intent.getParcelableExtra("networkInfo");
        if (networkInfo is null) {
            return null;
        }
        return connectivityManager.getNetworkInfo(networkInfo.getType());
    }

    public static int GetRestrictBackgroundStatus(android.net.ConnectivityManager connectivityManager) {
        return androidx.core.net.ConnectivityManagerCompat$Api24Impl.getRestrictBackgroundStatus(connectivityManager);
    }

    @androidx.annotation.ReplaceWith(expression = "cm.isActiveNetworkMetered()")
    @java.lang.Deprecated
    public static bool IsActiveNetworkMetered(android.net.ConnectivityManager connectivityManager) {
        return connectivityManager.isActiveNetworkMetered();
    }
}

