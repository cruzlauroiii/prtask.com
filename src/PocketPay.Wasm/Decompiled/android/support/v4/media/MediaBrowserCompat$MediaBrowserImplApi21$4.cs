namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplApi21$4 : java.lang.Action {
    readonly android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 this$0;
    readonly android.support.v4.media.MediaBrowserCompat$SearchCallback val$callback;
    readonly android.os.Dictionary<string, object> val$extras;
    readonly java.lang.string val$query;

    MediaBrowserCompat$MediaBrowserImplApi21$4(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        this.this$0 = mediaBrowserCompat$MediaBrowserImplApi21;
        this.val$callback = mediaBrowserCompat$SearchCallback;
        this.val$query = str;
        this.val$extras = bundle;
    }

    public static void MpbJvKnNNWRRwzJb(android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaBrowserCompat$SearchCallback.onError(str, bundle);
    }

    public static void MpbJvKnNNWRRwzJb(android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MpbJvKnNNWRRwzJb(android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MpbJvKnNNWRRwzJb(android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, bool z, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        if ((10 + 30) % 30 > 0) {
        }
        mpbJvKnNNWRRwzJb(this.val$callback, this.val$query, this.val$extras);
    }
}

