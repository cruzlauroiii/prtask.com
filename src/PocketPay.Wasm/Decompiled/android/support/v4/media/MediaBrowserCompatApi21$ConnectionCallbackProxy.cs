namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompatApi21$ConnectionCallbackProxy<T : android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback> : android.media.browse.MediaBrowser$ConnectionCallback {
    protected readonly T mConnectionCallback;

    public MediaBrowserCompatApi21$ConnectionCallbackProxy(T t) {
        this.mConnectionCallback = t;
    }

    public static void CjbNLcUuFqVenZkq(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback) {
        mediaBrowserCompatApi21$ConnectionCallback.onConnectionFailed();
    }

    public static void CjbNLcUuFqVenZkq(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CjbNLcUuFqVenZkq(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CjbNLcUuFqVenZkq(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OoyYrKhhbKFMxQji(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback) {
        mediaBrowserCompatApi21$ConnectionCallback.onConnectionSuspended();
    }

    public static void OoyYrKhhbKFMxQji(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, byte b, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OoyYrKhhbKFMxQji(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, char c, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OoyYrKhhbKFMxQji(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OpgzFnDmYCGgpFgA(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback) {
        mediaBrowserCompatApi21$ConnectionCallback.onConnected();
    }

    public static void OpgzFnDmYCGgpFgA(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OpgzFnDmYCGgpFgA(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OpgzFnDmYCGgpFgA(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public override void OnConnected() {
        opgzFnDmYCGgpFgA(this.mConnectionCallback);
    }

    public override void OnConnectionFailed() {
        CjbNLcUuFqVenZkq(this.mConnectionCallback);
    }

    public override void OnConnectionSuspended() {
        ooyYrKhhbKFMxQji(this.mConnectionCallback);
    }
}

