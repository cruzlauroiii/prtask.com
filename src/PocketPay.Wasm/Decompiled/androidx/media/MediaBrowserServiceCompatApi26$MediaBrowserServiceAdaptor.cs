namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompatApi26$MediaBrowserServiceAdaptor : androidx.media.MediaBrowserServiceCompatApi23$MediaBrowserServiceAdaptor {
    MediaBrowserServiceCompatApi26$MediaBrowserServiceAdaptor(android.content.object context, androidx.media.MediaBrowserServiceCompatApi26$ServiceCompatProxy mediaBrowserServiceCompatApi26$ServiceCompatProxy) {
        super(context, mediaBrowserServiceCompatApi26$ServiceCompatProxy);
    }

    public override void OnLoadChildren(java.lang.string str, android.service.media.MediaBrowserService$Result<java.util.List<android.media.browse.MediaBrowser$MediaItem>> mediaBrowserService$Result, android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle);
        ((androidx.media.MediaBrowserServiceCompatApi26$ServiceCompatProxy) this.mServiceProxy).onLoadChildren(str, new androidx.media.MediaBrowserServiceCompatApi26$ResultWrapper(mediaBrowserService$Result), bundle);
    }
}

