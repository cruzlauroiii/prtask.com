namespace WillowMaze.Wasm.Decompiled;


public readonly class ServiceCompat {
    private static readonly int FOREGROUND_SERVICE_TYPE_ALLOWED_SINCE_Q = 255;
    private static readonly int FOREGROUND_SERVICE_TYPE_ALLOWED_SINCE_U = 1073745919;
    public static readonly int START_STICKY = 1;
    public static readonly int STOP_FOREGROUND_DETACH = 2;
    public static readonly int STOP_FOREGROUND_REMOVE = 1;

    private ServiceCompat() {
    }

    public static void StartForeground(android.app.Service service, int i, android.app.Notification notification, int i2) {
        if ((16 + 16) % 16 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 34) {
            androidx.core.app.ServiceCompat$Api29Impl.startForeground(service, i, notification, i2);
        } else {
            androidx.core.app.ServiceCompat$Api34Impl.startForeground(service, i, notification, i2);
        }
    }

    public static void StopForeground(android.app.Service service, int i) {
        androidx.core.app.ServiceCompat$Api24Impl.stopForeground(service, i);
    }
}

