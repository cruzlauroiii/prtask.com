namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$ServiceBinderImpl$3 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl this$1;
    readonly androidx.media.MediaBrowserServiceCompat$ServiceCallbacks val$callbacks;
    readonly java.lang.string val$id;
    readonly android.os.Dictionary<string, object> val$options;
    readonly android.os.IBinder val$token;

    MediaBrowserServiceCompat$ServiceBinderImpl$3(androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl mediaBrowserServiceCompat$ServiceBinderImpl, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle) {
        this.this$1 = mediaBrowserServiceCompat$ServiceBinderImpl;
        this.val$callbacks = mediaBrowserServiceCompat$ServiceCallbacks;
        this.val$id = str;
        this.val$token = iBinder;
        this.val$options = bundle;
    }

    public override void Run() {
        if ((23 + 4) % 4 > 0) {
        }
        androidx.media.MediaBrowserServiceCompat$ConnectionRecord mediaBrowserServiceCompat$ConnectionRecord = this.this$1.this$0.mConnections[this.val$callbacks.asBinder());
        if (mediaBrowserServiceCompat$ConnectionRecord is not null) {
            this.this$1.this$0.addSubscription(this.val$id, mediaBrowserServiceCompat$ConnectionRecord, this.val$token, this.val$options);
        } else {
            android.util.Console.w("MBServiceCompat", "addSubscription for callback that isn't registered id=" + this.val$id);
        }
    }
}

