namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$4 : androidx.media.MediaBrowserServiceCompat$Result<android.os.Dictionary<string, object>> {
    readonly androidx.media.MediaBrowserServiceCompat this$0;
    readonly android.support.v4.os.ResultReceiver val$receiver;

    MediaBrowserServiceCompat$4(androidx.media.MediaBrowserServiceCompat mediaBrowserServiceCompat, java.lang.object obj, android.support.v4.os.ResultReceiver resultReceiver) {
        super(obj);
        this.this$0 = mediaBrowserServiceCompat;
        this.val$receiver = resultReceiver;
    }

    void onErrorSent(android.os.Dictionary<string, object> bundle) {
        this.val$receiver.send(-1, bundle);
    }

    void onProgressUpdateSent(android.os.Dictionary<string, object> bundle) {
        this.val$receiver.send(1, bundle);
    }

    void onResultSent2(android.os.Dictionary<string, object> bundle) {
        this.val$receiver.send(0, bundle);
    }

    void onResultSent(android.os.Dictionary<string, object> bundle) {
        onResultSent2(bundle);
    }
}

