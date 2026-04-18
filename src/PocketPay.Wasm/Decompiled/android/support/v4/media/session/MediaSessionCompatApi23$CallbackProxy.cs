namespace WillowMaze.Wasm.Decompiled;


class MediaSessionCompatApi23$CallbackProxy<T : android.support.v4.media.session.MediaSessionCompatApi23$Callback> : android.support.v4.media.session.MediaSessionCompatApi21$CallbackProxy<T> {
    public MediaSessionCompatApi23$CallbackProxy(T t) {
        super(t);
    }

    public static void PKmCoZzNyYnrlPbN(android.support.v4.media.session.MediaSessionCompatApi23$Callback mediaSessionCompatApi23$Callback, android.net.Uri uri, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompatApi23$Callback.onPlayFromUri(uri, bundle);
    }

    public static void PKmCoZzNyYnrlPbN(android.support.v4.media.session.MediaSessionCompatApi23$Callback mediaSessionCompatApi23$Callback, android.net.Uri uri, android.os.Dictionary<string, object> bundle, byte b, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PKmCoZzNyYnrlPbN(android.support.v4.media.session.MediaSessionCompatApi23$Callback mediaSessionCompatApi23$Callback, android.net.Uri uri, android.os.Dictionary<string, object> bundle, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PKmCoZzNyYnrlPbN(android.support.v4.media.session.MediaSessionCompatApi23$Callback mediaSessionCompatApi23$Callback, android.net.Uri uri, android.os.Dictionary<string, object> bundle, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DdRQJPMeATvOOztc(android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle);
    }

    public static void DdRQJPMeATvOOztc(android.os.Dictionary<string, object> bundle, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DdRQJPMeATvOOztc(android.os.Dictionary<string, object> bundle, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DdRQJPMeATvOOztc(android.os.Dictionary<string, object> bundle, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public override void OnPlayFromUri(android.net.Uri uri, android.os.Dictionary<string, object> bundle) {
        ddRQJPMeATvOOztc(bundle);
        PKmCoZzNyYnrlPbN((android.support.v4.media.session.MediaSessionCompatApi23$Callback) this.mCallback, uri, bundle);
    }
}

