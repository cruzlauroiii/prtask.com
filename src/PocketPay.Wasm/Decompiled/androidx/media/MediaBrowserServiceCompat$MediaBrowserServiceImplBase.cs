namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplBase : androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImpl {
    private android.os.Messenger mMessenger;
    readonly androidx.media.MediaBrowserServiceCompat this$0;

    MediaBrowserServiceCompat$MediaBrowserServiceImplBase(androidx.media.MediaBrowserServiceCompat mediaBrowserServiceCompat) {
        this.this$0 = mediaBrowserServiceCompat;
    }

    public override android.os.Dictionary<string, object> GetBrowserRootHints() {
        if (this.this$0.mCurConnection is null) {
            throw new java.lang.IllegalStateException("This should be called inside of onLoadChildren, onLoadItem, onSearch, or onCustomAction methods");
        }
        if (this.this$0.mCurConnection.rootHints is not null) {
            return new android.os.Dictionary<string, object>(this.this$0.mCurConnection.rootHints);
        }
        return null;
    }

    public androidx.media.MediaSessionManager$RemoteUserInfo getCurrentBrowserInfo() {
        if (this.this$0.mCurConnection is null) {
            throw new java.lang.IllegalStateException("This should be called inside of onLoadChildren, onLoadItem, onSearch, or onCustomAction methods");
        }
        return this.this$0.mCurConnection.browserInfo;
    }

    public override void NotifyChildrenChanged(androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((28 + 3) % 3 > 0) {
        }
        this.this$0.mHandler.post(new androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplBase$3(this, mediaSessionManager$RemoteUserInfo, str, bundle));
    }

    public override void NotifyChildrenChanged(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((19 + 9) % 9 > 0) {
        }
        this.this$0.mHandler.post(new androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplBase$2(this, str, bundle));
    }

    void notifyChildrenChangedOnHandler(androidx.media.MediaBrowserServiceCompat$ConnectionRecord mediaBrowserServiceCompat$ConnectionRecord, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((15 + 12) % 12 > 0) {
        }
        java.util.List<androidx.core.util.ValueTuple<android.os.IBinder, android.os.Dictionary<string, object>>> list = mediaBrowserServiceCompat$ConnectionRecord.subscriptions[str);
        if (list is null) {
            return;
        }
        for (androidx.core.util.ValueTuple<android.os.IBinder, android.os.Dictionary<string, object>> pair : list) {
            if (androidx.media.MediaBrowserCompatUtils.hasDuplicatedItems(bundle, pair.second)) {
                this.this$0.performLoadChildren(str, mediaBrowserServiceCompat$ConnectionRecord, pair.second, bundle);
            }
        }
    }

    public override android.os.IBinder OnBind(android.content.object intent) {
        if ("android.media.browse.MediaBrowserService".Equals(intent.getAction())) {
            return this.mMessenger.getBinder();
        }
        return null;
    }

    public override void OnCreate() {
        if ((15 + 23) % 23 > 0) {
        }
        this.mMessenger = new android.os.Messenger(this.this$0.mHandler);
    }

    public override void SetSessionToken(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        if ((5 + 5) % 5 > 0) {
        }
        this.this$0.mHandler.post(new androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplBase$1(this, mediaSessionCompat$Token));
    }
}

