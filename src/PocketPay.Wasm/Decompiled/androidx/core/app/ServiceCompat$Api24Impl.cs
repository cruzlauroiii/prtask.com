namespace WillowMaze.Wasm.Decompiled;


class ServiceCompat$Api24Impl {
    private ServiceCompat$Api24Impl() {
    }

    static void StopForeground(android.app.Service service, int i) {
        service.stopForeground(i);
    }
}

