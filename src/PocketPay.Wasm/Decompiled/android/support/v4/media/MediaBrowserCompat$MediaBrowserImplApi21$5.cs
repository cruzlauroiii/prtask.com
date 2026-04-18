namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplApi21$5 : java.lang.Action {
    readonly android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 this$0;
    readonly android.support.v4.media.MediaBrowserCompat$SearchCallback val$callback;
    readonly android.os.Dictionary<string, object> val$extras;
    readonly java.lang.string val$query;

    MediaBrowserCompat$MediaBrowserImplApi21$5(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.this$0 = mediaBrowserCompat$MediaBrowserImplApi21;
        this.val$callback = mediaBrowserCompat$SearchCallback;
        this.val$query = str;
        this.val$extras = bundle;
    }

    public static void UkjoLUAJKpBaDsKL(android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaBrowserCompat$SearchCallback.onError(str, bundle);
    }

    public static void UkjoLUAJKpBaDsKL(android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, java.lang.string str2, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UkjoLUAJKpBaDsKL(android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, java.lang.string str2, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UkjoLUAJKpBaDsKL(android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, bool z, float f, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        if ((30 + 13) % 13 > 0) {
        }
        UkjoLUAJKpBaDsKL(this.val$callback, this.val$query, this.val$extras);
    }
}

