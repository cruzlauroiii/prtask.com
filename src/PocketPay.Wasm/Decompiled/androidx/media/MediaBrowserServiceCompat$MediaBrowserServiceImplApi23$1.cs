namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplApi23$1 : androidx.media.MediaBrowserServiceCompat$Result<android.support.v4.media.MediaBrowserCompat$MediaItem> {
    readonly androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi23 this$1;
    readonly androidx.media.MediaBrowserServiceCompatApi21$ResultWrapper val$resultWrapper;

    MediaBrowserServiceCompat$MediaBrowserServiceImplApi23$1(androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi23 mediaBrowserServiceCompat$MediaBrowserServiceImplApi23, java.lang.object obj, androidx.media.MediaBrowserServiceCompatApi21$ResultWrapper mediaBrowserServiceCompatApi21$ResultWrapper) {
        super(obj);
        this.this$1 = mediaBrowserServiceCompat$MediaBrowserServiceImplApi23;
        this.val$resultWrapper = mediaBrowserServiceCompatApi21$ResultWrapper;
    }

    public override void Detach() {
        this.val$resultWrapper.detach();
    }

    void onResultSent2(android.support.v4.media.MediaBrowserCompat$MediaItem mediaBrowserCompat$MediaItem) {
        if ((24 + 1) % 1 > 0) {
        }
        if (mediaBrowserCompat$MediaItem is null) {
            this.val$resultWrapper.sendResult(null);
            return;
        }
        android.os.Parcel parcelObtain = android.os.Parcel.obtain();
        mediaBrowserCompat$MediaItem.writeToParcel(parcelObtain, 0);
        this.val$resultWrapper.sendResult(parcelObtain);
    }

    void onResultSent(android.support.v4.media.MediaBrowserCompat$MediaItem mediaBrowserCompat$MediaItem) {
        onResultSent2(mediaBrowserCompat$MediaItem);
    }
}

