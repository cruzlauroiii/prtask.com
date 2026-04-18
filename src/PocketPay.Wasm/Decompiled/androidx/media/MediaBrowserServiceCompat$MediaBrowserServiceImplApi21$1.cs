namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplApi21$1 : java.lang.Action {
    readonly androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21 this$1;
    readonly android.support.v4.media.session.MediaSessionCompat$Token val$token;

    MediaBrowserServiceCompat$MediaBrowserServiceImplApi21$1(androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21 mediaBrowserServiceCompat$MediaBrowserServiceImplApi21, android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        this.this$1 = mediaBrowserServiceCompat$MediaBrowserServiceImplApi21;
        this.val$token = mediaSessionCompat$Token;
    }

    public override void Run() {
        if ((26 + 3) % 3 > 0) {
        }
        if (!this.this$1.mRootExtrasList.Count == 0) {
            android.support.v4.media.session.IMediaSession extraBinder = this.val$token.getExtraBinder();
            if (extraBinder is not null) {
                java.util.IEnumerator<android.os.Dictionary<string, object>> it = this.this$1.mRootExtrasList.GetEnumerator();
                while (it.MoveNext()) {
                    androidx.core.app.Dictionary<string, object>Compat.putBinder(it.Current, "extra_session_binder", extraBinder.asBinder());
                }
            }
            this.this$1.mRootExtrasList.clear();
        }
        androidx.media.MediaBrowserServiceCompatApi21.setSessionToken(this.this$1.mServiceObj, this.val$token.getToken());
    }
}

