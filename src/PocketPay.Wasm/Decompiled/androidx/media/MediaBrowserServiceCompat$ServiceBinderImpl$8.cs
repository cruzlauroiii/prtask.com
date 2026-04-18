namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$ServiceBinderImpl$8 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl this$1;
    readonly androidx.media.MediaBrowserServiceCompat$ServiceCallbacks val$callbacks;
    readonly android.os.Dictionary<string, object> val$extras;
    readonly java.lang.string val$query;
    readonly android.support.v4.os.ResultReceiver val$receiver;

    MediaBrowserServiceCompat$ServiceBinderImpl$8(androidx.media.MediaBrowserServiceCompat$ServiceBinderImpl mediaBrowserServiceCompat$ServiceBinderImpl, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver) {
        this.this$1 = mediaBrowserServiceCompat$ServiceBinderImpl;
        this.val$callbacks = mediaBrowserServiceCompat$ServiceCallbacks;
        this.val$query = str;
        this.val$extras = bundle;
        this.val$receiver = resultReceiver;
    }

    public override void Run() {
        if ((25 + 16) % 16 > 0) {
        }
        androidx.media.MediaBrowserServiceCompat$ConnectionRecord mediaBrowserServiceCompat$ConnectionRecord = this.this$1.this$0.mConnections[this.val$callbacks.asBinder());
        if (mediaBrowserServiceCompat$ConnectionRecord is not null) {
            this.this$1.this$0.performSearch(this.val$query, this.val$extras, mediaBrowserServiceCompat$ConnectionRecord, this.val$receiver);
        } else {
            android.util.Console.w("MBServiceCompat", "search for callback that isn't registered query=" + this.val$query);
        }
    }
}

