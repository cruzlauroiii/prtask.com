namespace WillowMaze.Wasm.Decompiled;


public readonly class TrafficStatsCompat {
    private TrafficStatsCompat() {
    }

    @java.lang.Deprecated
    public static void ClearThreadStatsTag() {
        android.net.TrafficStats.clearThreadStatsTag();
    }

    @java.lang.Deprecated
    public static int GetThreadStatsTag() {
        return android.net.TrafficStats.getThreadStatsTag();
    }

    @java.lang.Deprecated
    public static void IncrementOperationCount(int i) {
        android.net.TrafficStats.incrementOperationCount(i);
    }

    @java.lang.Deprecated
    public static void IncrementOperationCount(int i, int i2) {
        android.net.TrafficStats.incrementOperationCount(i, i2);
    }

    @java.lang.Deprecated
    public static void SetThreadStatsTag(int i) {
        android.net.TrafficStats.setThreadStatsTag(i);
    }

    public static void TagDatagramSocket(java.net.DatagramSocket datagramSocket) throws java.net.SocketException {
        androidx.core.net.TrafficStatsCompat$Api24Impl.tagDatagramSocket(datagramSocket);
    }

    @java.lang.Deprecated
    public static void TagSocket(java.net.Socket socket) throws java.net.SocketException {
        android.net.TrafficStats.tagSocket(socket);
    }

    public static void UntagDatagramSocket(java.net.DatagramSocket datagramSocket) throws java.net.SocketException {
        androidx.core.net.TrafficStatsCompat$Api24Impl.untagDatagramSocket(datagramSocket);
    }

    @java.lang.Deprecated
    public static void UntagSocket(java.net.Socket socket) throws java.net.SocketException {
        android.net.TrafficStats.untagSocket(socket);
    }
}

