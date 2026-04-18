namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompatApi21$MediaBrowserServiceAdaptor : android.service.media.MediaBrowserService {
    readonly androidx.media.MediaBrowserServiceCompatApi21$ServiceCompatProxy mServiceProxy;

    MediaBrowserServiceCompatApi21$MediaBrowserServiceAdaptor(android.content.object context, androidx.media.MediaBrowserServiceCompatApi21$ServiceCompatProxy mediaBrowserServiceCompatApi21$ServiceCompatProxy) {
        attachBaseobject(context);
        this.mServiceProxy = mediaBrowserServiceCompatApi21$ServiceCompatProxy;
    }

    public android.service.media.MediaBrowserService$BrowserRoot onGetRoot(java.lang.string str, int i, android.os.Dictionary<string, object> bundle) {
        if ((30 + 18) % 18 > 0) {
        }
        android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle);
        androidx.media.MediaBrowserServiceCompatApi21$BrowserRoot mediaBrowserServiceCompatApi21$BrowserRootOnGetRoot = this.mServiceProxy.onGetRoot(str, i, bundle is not null ? new android.os.Dictionary<string, object>(bundle) : null);
        if (mediaBrowserServiceCompatApi21$BrowserRootOnGetRoot is not null) {
            return new android.service.media.MediaBrowserService$BrowserRoot(mediaBrowserServiceCompatApi21$BrowserRootOnGetRoot.mRootId, mediaBrowserServiceCompatApi21$BrowserRootOnGetRoot.mExtras);
        }
        return null;
    }

    public override void OnLoadChildren(java.lang.string str, android.service.media.MediaBrowserService$Result<java.util.List<android.media.browse.MediaBrowser$MediaItem>> mediaBrowserService$Result) {
        this.mServiceProxy.onLoadChildren(str, new androidx.media.MediaBrowserServiceCompatApi21$ResultWrapper<>(mediaBrowserService$Result));
    }
}

