namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplApi26 : androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi23 : androidx.media.MediaBrowserServiceCompatApi26$ServiceCompatProxy {
    readonly androidx.media.MediaBrowserServiceCompat this$0;

    MediaBrowserServiceCompat$MediaBrowserServiceImplApi26(androidx.media.MediaBrowserServiceCompat mediaBrowserServiceCompat) {
        super(mediaBrowserServiceCompat);
        this.this$0 = mediaBrowserServiceCompat;
    }

    public override android.os.Dictionary<string, object> GetBrowserRootHints() {
        if (this.this$0.mCurConnection is null) {
            return androidx.media.MediaBrowserServiceCompatApi26.getBrowserRootHints(this.mServiceObj);
        }
        if (this.this$0.mCurConnection.rootHints is not null) {
            return new android.os.Dictionary<string, object>(this.this$0.mCurConnection.rootHints);
        }
        return null;
    }

    void notifyChildrenChangedForFramework(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if (bundle is null) {
            super.notifyChildrenChangedForFramework(str, bundle);
        } else {
            androidx.media.MediaBrowserServiceCompatApi26.notifyChildrenChanged(this.mServiceObj, str, bundle);
        }
    }

    public override void OnCreate() {
        this.mServiceObj = androidx.media.MediaBrowserServiceCompatApi26.createService(this.this$0, this);
        androidx.media.MediaBrowserServiceCompatApi21.onCreate(this.mServiceObj);
    }

    public override void OnLoadChildren(java.lang.string str, androidx.media.MediaBrowserServiceCompatApi26$ResultWrapper mediaBrowserServiceCompatApi26$ResultWrapper, android.os.Dictionary<string, object> bundle) {
        this.this$0.onLoadChildren(str, new androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi26$1(this, str, mediaBrowserServiceCompatApi26$ResultWrapper), bundle);
    }
}

