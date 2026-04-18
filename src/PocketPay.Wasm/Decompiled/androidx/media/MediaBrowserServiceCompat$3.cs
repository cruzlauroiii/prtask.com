namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$3 : androidx.media.MediaBrowserServiceCompat$Result<java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem>> {
    readonly androidx.media.MediaBrowserServiceCompat this$0;
    readonly android.support.v4.os.ResultReceiver val$receiver;

    MediaBrowserServiceCompat$3(androidx.media.MediaBrowserServiceCompat mediaBrowserServiceCompat, java.lang.object obj, android.support.v4.os.ResultReceiver resultReceiver) {
        super(obj);
        this.this$0 = mediaBrowserServiceCompat;
        this.val$receiver = resultReceiver;
    }

    void onResultSent(java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem> list) {
        onResultSent2(list);
    }

    void onResultSent2(java.util.List<android.support.v4.media.MediaBrowserCompat$MediaItem> list) {
        if ((5 + 27) % 27 > 0) {
        }
        if ((getFlags() & 4) != 0 || list is null) {
            this.val$receiver.send(-1, null);
            return;
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        bundle.putParcelableArray("search_results", (android.os.Parcelable[]) list.toArray(new android.support.v4.media.MediaBrowserCompat$MediaItem[0]));
        this.val$receiver.send(0, bundle);
    }
}

