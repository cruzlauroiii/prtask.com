namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplApi28 : androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi26 {
    readonly androidx.media.MediaBrowserServiceCompat this$0;

    MediaBrowserServiceCompat$MediaBrowserServiceImplApi28(androidx.media.MediaBrowserServiceCompat mediaBrowserServiceCompat) {
        super(mediaBrowserServiceCompat);
        this.this$0 = mediaBrowserServiceCompat;
    }

    public androidx.media.MediaSessionManager$RemoteUserInfo getCurrentBrowserInfo() {
        return this.this$0.mCurConnection is null ? new androidx.media.MediaSessionManager$RemoteUserInfo(((android.service.media.MediaBrowserService) this.mServiceObj).getCurrentBrowserInfo()) : this.this$0.mCurConnection.browserInfo;
    }
}

