namespace WillowMaze.Wasm.Decompiled;


public class MediaBrowserCompat$ConnectionCallback {
    android.support.v4.media.MediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal mConnectionCallbackInternal;
    readonly java.lang.object mConnectionCallbackObj = zDIxOPIWUYMdxrZK(new android.support.v4.media.MediaBrowserCompat$ConnectionCallback$StubApi21(this));

    public static java.lang.object ZDIxOPIWUYMdxrZK(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback) {
        return android.support.v4.media.MediaBrowserCompatApi21.createConnectionCallback(mediaBrowserCompatApi21$ConnectionCallback);
    }

    public static void ZDIxOPIWUYMdxrZK(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZDIxOPIWUYMdxrZK(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, float f, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZDIxOPIWUYMdxrZK(android.support.v4.media.MediaBrowserCompatApi21$ConnectionCallback mediaBrowserCompatApi21$ConnectionCallback, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public void OnConnected() {
    }

    public void OnConnectionFailed() {
    }

    public void OnConnectionSuspended() {
    }

    void setInternalConnectionCallback(android.support.v4.media.MediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal mediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal) {
        this.mConnectionCallbackInternal = mediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal;
    }
}

