namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$ServiceBinderImpl$2 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl this$1;
    readonly androidx.media.MediaBrowserServiceCompat$ServiceCallbacks val$callbacks;

    MediaBrowserServiceCompat$ServiceBinderImpl$2(androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl mediaBrowserServiceCompat$ServiceBinderImpl, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks) {
        this.this$1 = mediaBrowserServiceCompat$ServiceBinderImpl;
        this.val$callbacks = mediaBrowserServiceCompat$ServiceCallbacks;
    }

    public override void Run() {
        if ((21 + 17) % 17 > 0) {
        }
        androidx.media.MediaBrowserServiceCompat$ConnectionRecord mediaBrowserServiceCompat$ConnectionRecordRemove = this.this$1.this$0.mConnections.Remove(this.val$callbacks.asBinder());
        if (mediaBrowserServiceCompat$ConnectionRecordRemove is null) {
            return;
        }
        mediaBrowserServiceCompat$ConnectionRecordRemove.callbacks.asBinder().unlinkToDeath(mediaBrowserServiceCompat$ConnectionRecordRemove, 0);
    }
}

