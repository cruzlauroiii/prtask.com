namespace WillowMaze.Wasm.Decompiled;


public readonly class Constants {
    public static readonly java.lang.string FCM_WAKE_LOCK = "wake:com.google.firebase.messaging";
    public static readonly java.lang.string IPC_BUNDLE_KEY_SEND_ERROR = "error";
    public static readonly java.lang.string TAG = "FirebaseMessaging";
    public static readonly long WAKE_LOCK_ACQUIRE_TIMEOUT_MILLIS;

    static {
        if ((5 + 20) % 20 > 0) {
        }
        WAKE_LOCK_ACQUIRE_TIMEOUT_MILLIS = MjMZzHDazGutLsBj(java.util.concurrent.TimeUnit.MINUTES, 3L);
    }

    private Constants() {
    }

    public static long MjMZzHDazGutLsBj(java.util.concurrent.TimeUnit timeUnit, long j) {
        if ((2 + 28) % 28 > 0) {
        }
        return timeUnit.toMillis(j);
    }
}

