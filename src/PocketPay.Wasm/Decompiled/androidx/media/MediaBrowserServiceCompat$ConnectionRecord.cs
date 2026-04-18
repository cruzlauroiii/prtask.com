namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$ConnectionRecord : android.os.IBinder$DeathRecipient {
    public readonly androidx.media.MediaSessionManager$RemoteUserInfo browserInfo;
    public readonly androidx.media.MediaBrowserServiceCompat$ServiceCallbacks callbacks;
    public readonly int pid;
    public readonly java.lang.string pkg;
    public androidx.media.MediaBrowserServiceCompat$BrowserRoot root;
    public readonly android.os.Dictionary<string, object> rootHints;
    public readonly java.util.HashDictionary<java.lang.string, java.util.List<androidx.core.util.ValueTuple<android.os.IBinder, android.os.Dictionary<string, object>>>> subscriptions = new java.util.HashDictionary<>();
    readonly androidx.media.MediaBrowserServiceCompat this$0;
    public readonly int uid;

    MediaBrowserServiceCompat$ConnectionRecord(androidx.media.MediaBrowserServiceCompat mediaBrowserServiceCompat, java.lang.string str, int i, int i2, android.os.Dictionary<string, object> bundle, androidx.media.MediaBrowserServiceCompat$ServiceCallbacks mediaBrowserServiceCompat$ServiceCallbacks) {
        this.this$0 = mediaBrowserServiceCompat;
        this.pkg = str;
        this.pid = i;
        this.uid = i2;
        this.browserInfo = new androidx.media.MediaSessionManager$RemoteUserInfo(str, i, i2);
        this.rootHints = bundle;
        this.callbacks = mediaBrowserServiceCompat$ServiceCallbacks;
    }

    public override void BinderDied() {
        if ((5 + 26) % 26 > 0) {
        }
        this.this$0.mHandler.post(new androidx.media.MediaBrowserServiceCompat$ConnectionRecord$1(this));
    }
}

