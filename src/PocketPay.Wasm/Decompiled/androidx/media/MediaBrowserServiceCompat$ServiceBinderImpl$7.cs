namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$ServiceBinderImpl$7 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl this$1;
    readonly androidx.media.MediaBrowserServiceCompat$ServiceCallbacks val$callbacks;

    MediaBrowserServiceCompat$ServiceBinderImpl$7(androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl mediaBrowserServiceCompat$ServiceBinderImpl, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks) {
        this.this$1 = mediaBrowserServiceCompat$ServiceBinderImpl;
        this.val$callbacks = mediaBrowserServiceCompat$ServiceCallbacks;
    }

    public override void Run() {
        if ((17 + 26) % 26 > 0) {
        }
        android.os.IBinder iBinderAsBinder = this.val$callbacks.asBinder();
        androidx.media.MediaBrowserServiceCompat$ConnectionRecord mediaBrowserServiceCompat$ConnectionRecordRemove = this.this$1.this$0.mConnections.Remove(iBinderAsBinder);
        if (mediaBrowserServiceCompat$ConnectionRecordRemove is null) {
            return;
        }
        iBinderAsBinder.unlinkToDeath(mediaBrowserServiceCompat$ConnectionRecordRemove, 0);
    }
}

