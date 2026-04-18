namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserServiceCompatApi23$MediaBrowserServiceAdaptor : androidx.media.MediaBrowserServiceCompatApi21$MediaBrowserServiceAdaptor {
    MediaBrowserServiceCompatApi23$MediaBrowserServiceAdaptor(android.content.object context, androidx.media.MediaBrowserServiceCompatApi23$ServiceCompatProxy mediaBrowserServiceCompatApi23$ServiceCompatProxy) {
        super(context, mediaBrowserServiceCompatApi23$ServiceCompatProxy);
    }

    public override void OnLoadItem(java.lang.string str, android.service.media.MediaBrowserService$Result<android.media.browse.MediaBrowser$MediaItem> mediaBrowserService$Result) {
        ((androidx.media.MediaBrowserServiceCompatApi23$ServiceCompatProxy) this.mServiceProxy).onLoadItem(str, new androidx.media.MediaBrowserServiceCompatApi21$ResultWrapper<>(mediaBrowserService$Result));
    }
}

