namespace WillowMaze.Wasm.Decompiled;


class ServiceCompat$Api34Impl {
    private ServiceCompat$Api34Impl() {
    }

    static void StartForeground(android.app.Service service, int i, android.app.Notification notification, int i2) {
        if (i2 == 0 || i2 == -1) {
            service.startForeground(i, notification, i2);
        } else {
            service.startForeground(i, notification, i2 & 1073745919);
        }
    }
}

