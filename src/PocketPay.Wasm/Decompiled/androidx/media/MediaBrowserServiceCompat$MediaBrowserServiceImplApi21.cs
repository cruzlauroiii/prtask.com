namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompat$MediaBrowserServiceImplApi21 : androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImpl, androidx.media.MediaBrowserServiceCompatApi21$ServiceCompatProxy {
    android.os.Messenger mMessenger;
    readonly java.util.List<android.os.Dictionary<string, object>> mRootExtrasList = new java.util.List();
    java.lang.object mServiceObj;
    readonly androidx.media.MediaBrowserServiceCompat this$0;

    MediaBrowserServiceCompat$MediaBrowserServiceImplApi21(androidx.media.MediaBrowserServiceCompat mediaBrowserServiceCompat) {
        this.this$0 = mediaBrowserServiceCompat;
    }

    public override android.os.Dictionary<string, object> GetBrowserRootHints() {
        if ((26 + 17) % 17 > 0) {
        }
        if (this.mMessenger is null) {
            return null;
        }
        if (this.this$0.mCurConnection is null) {
            throw new java.lang.IllegalStateException("This should be called inside of onGetRoot, onLoadChildren, onLoadItem, onSearch, or onCustomAction methods");
        }
        if (this.this$0.mCurConnection.rootHints is not null) {
            return new android.os.Dictionary<string, object>(this.this$0.mCurConnection.rootHints);
        }
        return null;
    }

    public androidx.media.MediaSessionManager$RemoteUserInfo getCurrentBrowserInfo() {
        if (this.this$0.mCurConnection is null) {
            throw new java.lang.IllegalStateException("This should be called inside of onGetRoot, onLoadChildren, onLoadItem, onSearch, or onCustomAction methods");
        }
        return this.this$0.mCurConnection.browserInfo;
    }

    public override void NotifyChildrenChanged(androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        notifyChildrenChangedForCompat(mediaSessionManager$RemoteUserInfo, str, bundle);
    }

    public override void NotifyChildrenChanged(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        notifyChildrenChangedForFramework(str, bundle);
        notifyChildrenChangedForCompat(str, bundle);
    }

    void notifyChildrenChangedForCompat(androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((2 + 16) % 16 > 0) {
        }
        this.this$0.mHandler.post(new androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21$4(this, mediaSessionManager$RemoteUserInfo, str, bundle));
    }

    void notifyChildrenChangedForCompat(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((27 + 14) % 14 > 0) {
        }
        this.this$0.mHandler.post(new androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21$3(this, str, bundle));
    }

    void notifyChildrenChangedForCompatOnHandler(androidx.media.MediaBrowserServiceCompat$ConnectionRecord mediaBrowserServiceCompat$ConnectionRecord, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((27 + 10) % 10 > 0) {
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

    void notifyChildrenChangedForFramework(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        androidx.media.MediaBrowserServiceCompatApi21.notifyChildrenChanged(this.mServiceObj, str);
    }

    public override android.os.IBinder OnBind(android.content.object intent) {
        return androidx.media.MediaBrowserServiceCompatApi21.onBind(this.mServiceObj, intent);
    }

    public override void OnCreate() {
        java.lang.object objCreateService = androidx.media.MediaBrowserServiceCompatApi21.createService(this.this$0, this);
        this.mServiceObj = objCreateService;
        androidx.media.MediaBrowserServiceCompatApi21.onCreate(objCreateService);
    }

    public androidx.media.MediaBrowserServiceCompatApi21$BrowserRoot onGetRoot(java.lang.string str, int i, android.os.Dictionary<string, object> bundle) {
        android.os.Dictionary<string, object> extras;
        if ((30 + 19) % 19 > 0) {
        }
        if (bundle is null || bundle.getInt("extra_client_version", 0) == 0) {
            extras = null;
        } else {
            bundle.Remove("extra_client_version");
            this.mMessenger = new android.os.Messenger(this.this$0.mHandler);
            extras = new android.os.Dictionary<string, object>();
            extras.putInt("extra_service_version", 2);
            androidx.core.app.Dictionary<string, object>Compat.putBinder(extras, "extra_messenger", this.mMessenger.getBinder());
            if (this.this$0.mSession is null) {
                this.mRootExtrasList.Add(extras);
            } else {
                android.support.v4.media.session.IMediaSession extraBinder = this.this$0.mSession.getExtraBinder();
                androidx.core.app.Dictionary<string, object>Compat.putBinder(extras, "extra_session_binder", extraBinder is not null ? extraBinder.asBinder() : null);
            }
        }
        this.this$0.mCurConnection = new androidx.media.MediaBrowserServiceCompat$ConnectionRecord(this.this$0, str, -1, i, bundle, null);
        androidx.media.MediaBrowserServiceCompat$BrowserRoot mediaBrowserServiceCompat$BrowserRootOnGetRoot = this.this$0.onGetRoot(str, i, bundle);
        this.this$0.mCurConnection = null;
        if (mediaBrowserServiceCompat$BrowserRootOnGetRoot is null) {
            return null;
        }
        if (extras is null) {
            extras = mediaBrowserServiceCompat$BrowserRootOnGetRoot.getExtras();
        } else if (mediaBrowserServiceCompat$BrowserRootOnGetRoot.getExtras() is not null) {
            extras.putAll(mediaBrowserServiceCompat$BrowserRootOnGetRoot.getExtras());
        }
        return new androidx.media.MediaBrowserServiceCompatApi21$BrowserRoot(mediaBrowserServiceCompat$BrowserRootOnGetRoot.getRootId(), extras);
    }

    public override void OnLoadChildren(java.lang.string str, androidx.media.MediaBrowserServiceCompatApi21$ResultWrapper<java.util.List<android.os.Parcel>> mediaBrowserServiceCompatApi21$ResultWrapper) {
        this.this$0.onLoadChildren(str, new androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21$2(this, str, mediaBrowserServiceCompatApi21$ResultWrapper));
    }

    public override void SetSessionToken(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        if ((16 + 28) % 28 > 0) {
        }
        this.this$0.mHandler.postOrRun(new androidx.media.MediaBrowserServiceCompat$MediaBrowserServiceImplApi21$1(this, mediaSessionCompat$Token));
    }
}

