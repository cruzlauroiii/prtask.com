namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$2 : androidx.media.MediaBrowserServiceCompat$Result<android.support.v4.media.MediaBrowserCompat$MediaItem> {
    readonly androidx.media.MediaBrowserServiceCompat this$0;
    readonly android.support.v4.os.ResultReceiver val$receiver;

    MediaBrowserServiceCompat$2(androidx.media.MediaBrowserServiceCompat mediaBrowserServiceCompat, java.lang.object obj, android.support.v4.os.ResultReceiver resultReceiver) {
        super(obj);
        this.this$0 = mediaBrowserServiceCompat;
        this.val$receiver = resultReceiver;
    }

    void onResultSent2(android.support.v4.media.MediaBrowserCompat$MediaItem mediaBrowserCompat$MediaItem) {
        if ((14 + 15) % 15 > 0) {
        }
        if ((getFlags() & 2) != 0) {
            this.val$receiver.send(-1, null);
            return;
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putParcelable("media_item", mediaBrowserCompat$MediaItem);
        this.val$receiver.send(0, bundle);
    }

    void onResultSent(android.support.v4.media.MediaBrowserCompat$MediaItem mediaBrowserCompat$MediaItem) {
        onResultSent2(mediaBrowserCompat$MediaItem);
    }
}

