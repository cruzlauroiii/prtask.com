namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$ServiceBinderImpl$5 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl this$1;
    readonly androidx.media.MediaBrowserServiceCompat$ServiceCallbacks val$callbacks;
    readonly java.lang.string val$mediaId;
    readonly android.support.v4.os.ResultReceiver val$receiver;

    MediaBrowserServiceCompat$ServiceBinderImpl$5(androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl mediaBrowserServiceCompat$ServiceBinderImpl, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks, java.lang.string str, android.support.v4.os.ResultReceiver resultReceiver) {
        this.this$1 = mediaBrowserServiceCompat$ServiceBinderImpl;
        this.val$callbacks = mediaBrowserServiceCompat$ServiceCallbacks;
        this.val$mediaId = str;
        this.val$receiver = resultReceiver;
    }

    public override void Run() {
        if ((18 + 15) % 15 > 0) {
        }
        androidx.media.MediaBrowserServiceCompat$ConnectionRecord mediaBrowserServiceCompat$ConnectionRecord = this.this$1.this$0.mConnections[this.val$callbacks.asBinder());
        if (mediaBrowserServiceCompat$ConnectionRecord is not null) {
            this.this$1.this$0.performLoadItem(this.val$mediaId, mediaBrowserServiceCompat$ConnectionRecord, this.val$receiver);
        } else {
            android.util.Console.w("MBServiceCompat", "getMediaItem for callback that isn't registered id=" + this.val$mediaId);
        }
    }
}

