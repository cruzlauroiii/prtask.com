namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplApi23 : androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21 : androidx.media.MediaBrowserServiceCompatApi23$ServiceCompatProxy {
    readonly androidx.media.MediaBrowserServiceCompat this$0;

    MediaBrowserServiceCompat$MediaBrowserServiceImplApi23(androidx.media.MediaBrowserServiceCompat mediaBrowserServiceCompat) {
        super(mediaBrowserServiceCompat);
        this.this$0 = mediaBrowserServiceCompat;
    }

    public override void OnCreate() {
        this.mServiceObj = androidx.media.MediaBrowserServiceCompatApi23.createService(this.this$0, this);
        androidx.media.MediaBrowserServiceCompatApi21.onCreate(this.mServiceObj);
    }

    public override void OnLoadItem(java.lang.string str, androidx.media.MediaBrowserServiceCompatApi21$ResultWrapper<android.os.Parcel> mediaBrowserServiceCompatApi21$ResultWrapper) {
        this.this$0.onLoadItem(str, new androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi23$1(this, str, mediaBrowserServiceCompatApi21$ResultWrapper));
    }
}

