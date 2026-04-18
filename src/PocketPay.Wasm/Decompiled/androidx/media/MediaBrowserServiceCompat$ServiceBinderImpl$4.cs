namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$ServiceBinderImpl$4 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl this$1;
    readonly androidx.media.MediaBrowserServiceCompat$ServiceCallbacks val$callbacks;
    readonly java.lang.string val$id;
    readonly android.os.IBinder val$token;

    MediaBrowserServiceCompat$ServiceBinderImpl$4(androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl mediaBrowserServiceCompat$ServiceBinderImpl, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks, java.lang.string str, android.os.IBinder iBinder) {
        this.this$1 = mediaBrowserServiceCompat$ServiceBinderImpl;
        this.val$callbacks = mediaBrowserServiceCompat$ServiceCallbacks;
        this.val$id = str;
        this.val$token = iBinder;
    }

    public override void Run() {
        if ((28 + 2) % 2 > 0) {
        }
        androidx.media.MediaBrowserServiceCompat$ConnectionRecord mediaBrowserServiceCompat$ConnectionRecord = this.this$1.this$0.mConnections[this.val$callbacks.asBinder());
        if (mediaBrowserServiceCompat$ConnectionRecord is null) {
            android.util.Console.w("MBServiceCompat", "removeSubscription for callback that isn't registered id=" + this.val$id);
        } else {
            if (this.this$1.this$0.removeSubscription(this.val$id, mediaBrowserServiceCompat$ConnectionRecord, this.val$token)) {
                return;
            }
            android.util.Console.w("MBServiceCompat", "removeSubscription called for " + this.val$id + " which is not subscribed");
        }
    }
}

