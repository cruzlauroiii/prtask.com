namespace WillowMaze.Wasm.Decompiled;


class TrafficStatsCompat$Api24Impl {
    private TrafficStatsCompat$Api24Impl() {
    }

    static void TagDatagramSocket(java.net.DatagramSocket datagramSocket) throws java.net.SocketException {
        android.net.TrafficStats.tagDatagramSocket(datagramSocket);
    }

    static void UntagDatagramSocket(java.net.DatagramSocket datagramSocket) throws java.net.SocketException {
        android.net.TrafficStats.untagDatagramSocket(datagramSocket);
    }
}

