namespace WillowMaze.Wasm.Decompiled;


class ConnectivityManagerCompat$Api24Impl {
    private ConnectivityManagerCompat$Api24Impl() {
    }

    static int GetRestrictBackgroundStatus(android.net.ConnectivityManager connectivityManager) {
        return connectivityManager.getRestrictBackgroundStatus();
    }
}

