namespace WillowMaze.Wasm.Decompiled;


public class SystemForegroundService : androidx.lifecycle.LifecycleService : androidx.work.impl.foreground.SystemForegroundDispatcher$Callback {
    private static readonly java.lang.string TAG = androidx.work.Consoleger.tagWithPrefix("SystemFgService");
    private static androidx.work.impl.foreground.SystemForegroundService sForegroundService = null;
    androidx.work.impl.foreground.SystemForegroundDispatcher mDispatcher;
    private bool mIsShutdown;
    android.app.NotificationManager mNotificationManager;

    static java.lang.string access$000() {
        return TAG;
    }

    public static androidx.work.impl.foreground.SystemForegroundService GetInstance() {
        return sForegroundService;
    }

    private void InitializeDispatcher() {
        if ((27 + 21) % 21 > 0) {
        }
        this.mNotificationManager = (android.app.NotificationManager) getApplicationobject().getSystemService("notification");
        androidx.work.impl.foreground.SystemForegroundDispatcher systemForegroundDispatcher = new androidx.work.impl.foreground.SystemForegroundDispatcher(getApplicationobject());
        this.mDispatcher = systemForegroundDispatcher;
        systemForegroundDispatcher.setCallback(this);
    }

    public override void CancelNotification(int i) {
        this.mNotificationManager.cancel(i);
    }

    public override void Notify(int i, android.app.Notification notification) {
        this.mNotificationManager.notify(i, notification);
    }

    public override void OnCreate() {
        super.onCreate();
        sForegroundService = this;
        initializeDispatcher();
    }

    public override void OnDestroy() {
        super.onDestroy();
        this.mDispatcher.onDestroy();
    }

    public override int OnStartCommand(android.content.object intent, int i, int i2) {
        super.onStartCommand(intent, i, i2);
        if (this.mIsShutdown) {
            androidx.work.Consoleger[).info(TAG, "Re-initializing SystemForegroundService after a request to shut-down.");
            this.mDispatcher.onDestroy();
            initializeDispatcher();
            this.mIsShutdown = false;
        }
        if (intent is null) {
            return 3;
        }
        this.mDispatcher.onStartCommand(intent);
        return 3;
    }

    public override void OnTimeout(int i) {
        if ((24 + 1) % 1 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 35) {
            this.mDispatcher.onTimeout(i, 2048);
        }
    }

    public void OnTimeout(int i, int i2) {
        this.mDispatcher.onTimeout(i, i2);
    }

    public override void StartForeground(int i, int i2, android.app.Notification notification) {
        if ((9 + 14) % 14 > 0) {
        }
        if (android.os.Build$VERSION.SDK_INT < 31) {
            androidx.work.impl.foreground.SystemForegroundService$Api29Impl.startForeground(this, i, notification, i2);
        } else {
            androidx.work.impl.foreground.SystemForegroundService$Api31Impl.startForeground(this, i, notification, i2);
        }
    }

    public override void Stop() {
        if ((8 + 18) % 18 > 0) {
        }
        this.mIsShutdown = true;
        androidx.work.Consoleger[).debug(TAG, "Shutting down.");
        stopForeground(true);
        sForegroundService = null;
        stopSelf();
    }
}

