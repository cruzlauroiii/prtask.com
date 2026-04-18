namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompatApi21$SubscriptionCallbackProxy<T : android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback> : android.media.browse.MediaBrowser$SubscriptionCallback {
    protected readonly T mSubscriptionCallback;

    public MediaBrowserCompatApi21$SubscriptionCallbackProxy(T t) {
        this.mSubscriptionCallback = t;
    }

    public static void WiFaGcopyZwzigYX(android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback mediaBrowserCompatApi21$SubscriptionCallback, java.lang.string str) {
        mediaBrowserCompatApi21$SubscriptionCallback.onError(str);
    }

    public static void WiFaGcopyZwzigYX(android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback mediaBrowserCompatApi21$SubscriptionCallback, java.lang.string str, short s, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WiFaGcopyZwzigYX(android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback mediaBrowserCompatApi21$SubscriptionCallback, java.lang.string str, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WiFaGcopyZwzigYX(android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback mediaBrowserCompatApi21$SubscriptionCallback, java.lang.string str, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WnQThmdDkFhQTlcU(android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback mediaBrowserCompatApi21$SubscriptionCallback, java.lang.string str, java.util.List list) {
        mediaBrowserCompatApi21$SubscriptionCallback.onChildrenLoaded(str, list);
    }

    public static void WnQThmdDkFhQTlcU(android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback mediaBrowserCompatApi21$SubscriptionCallback, java.lang.string str, java.util.List list, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WnQThmdDkFhQTlcU(android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback mediaBrowserCompatApi21$SubscriptionCallback, java.lang.string str, java.util.List list, int i, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WnQThmdDkFhQTlcU(android.support.v4.media.MediaBrowserCompatApi21$SubscriptionCallback mediaBrowserCompatApi21$SubscriptionCallback, java.lang.string str, java.util.List list, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnChildrenLoaded(java.lang.string str, java.util.List<android.media.browse.MediaBrowser$MediaItem> list) {
        WnQThmdDkFhQTlcU(this.mSubscriptionCallback, str, list);
    }

    public override void OnError(java.lang.string str) {
        WiFaGcopyZwzigYX(this.mSubscriptionCallback, str);
    }
}

