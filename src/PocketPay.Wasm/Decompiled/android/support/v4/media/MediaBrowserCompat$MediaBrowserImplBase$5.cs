namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplBase$5 : java.lang.Action {
    readonly android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase this$0;
    readonly android.support.v4.media.MediaBrowserCompat$SearchCallback val$callback;
    readonly android.os.Dictionary<string, object> val$extras;
    readonly java.lang.string val$query;

    MediaBrowserCompat$MediaBrowserImplBase$5(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.this$0 = mediaBrowserCompat$MediaBrowserImplBase;
        this.val$callback = mediaBrowserCompat$SearchCallback;
        this.val$query = str;
        this.val$extras = bundle;
    }

    public static void GExajotsvAqLbgoo(android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaBrowserCompat$SearchCallback.onError(str, bundle);
    }

    public static void GExajotsvAqLbgoo(android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GExajotsvAqLbgoo(android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GExajotsvAqLbgoo(android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        if ((20 + 32) % 32 > 0) {
        }
        gExajotsvAqLbgoo(this.val$callback, this.val$query, this.val$extras);
    }
}

