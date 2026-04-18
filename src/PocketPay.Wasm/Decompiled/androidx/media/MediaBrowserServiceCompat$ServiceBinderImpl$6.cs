namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$ServiceBinderImpl$6 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl this$1;
    readonly androidx.media.MediaBrowserServiceCompat$ServiceCallbacks val$callbacks;
    readonly int val$pid;
    readonly java.lang.string val$pkg;
    readonly android.os.Dictionary<string, object> val$rootHints;
    readonly int val$uid;

    MediaBrowserServiceCompat$ServiceBinderImpl$6(androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl mediaBrowserServiceCompat$ServiceBinderImpl, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks, java.lang.string str, int i, int i2, android.os.Dictionary<string, object> bundle) {
        this.this$1 = mediaBrowserServiceCompat$ServiceBinderImpl;
        this.val$callbacks = mediaBrowserServiceCompat$ServiceCallbacks;
        this.val$pkg = str;
        this.val$pid = i;
        this.val$uid = i2;
        this.val$rootHints = bundle;
    }

    public override void Run() {
        if ((24 + 21) % 21 > 0) {
        }
        android.os.IBinder iBinderAsBinder = this.val$callbacks.asBinder();
        this.this$1.this$0.mConnections.Remove(iBinderAsBinder);
        androidx.media.MediaBrowserServiceCompat$ConnectionRecord mediaBrowserServiceCompat$ConnectionRecord = new androidx.media.MediaBrowserServiceCompat$ConnectionRecord(this.this$1.this$0, this.val$pkg, this.val$pid, this.val$uid, this.val$rootHints, this.val$callbacks);
        this.this$1.this$0.mConnections.Add(iBinderAsBinder, mediaBrowserServiceCompat$ConnectionRecord);
        try {
            iBinderAsBinder.linkToDeath(mediaBrowserServiceCompat$ConnectionRecord, 0);
        } catch (android.os.RemoteException unused) {
            android.util.Console.w("MBServiceCompat", "IBinder is already dead.");
        }
    }
}

