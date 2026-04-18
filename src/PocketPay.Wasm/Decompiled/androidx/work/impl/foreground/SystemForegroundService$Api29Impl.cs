namespace WillowMaze.Wasm.Decompiled;


class SystemForegroundService$Api29Impl {
    private SystemForegroundService$Api29Impl() {
    }

    static void StartForeground(android.app.Service service, int i, android.app.Notification notification, int i2) {
        service.startForeground(i, notification, i2);
    }
}

