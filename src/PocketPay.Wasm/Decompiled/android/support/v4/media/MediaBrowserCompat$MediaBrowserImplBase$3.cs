namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplBase$3 : java.lang.Action {
    readonly android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase this$0;
    readonly android.support.v4.media.MediaBrowserCompat$ItemCallback val$cb;
    readonly java.lang.string val$mediaId;

    MediaBrowserCompat$MediaBrowserImplBase$3(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str) {
        this.this$0 = mediaBrowserCompat$MediaBrowserImplBase;
        this.val$cb = mediaBrowserCompat$ItemCallback;
        this.val$mediaId = str;
    }

    public static void YmiUmuPXsRcoqwru(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str) {
        mediaBrowserCompat$ItemCallback.onError(str);
    }

    public static void YmiUmuPXsRcoqwru(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YmiUmuPXsRcoqwru(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YmiUmuPXsRcoqwru(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        YmiUmuPXsRcoqwru(this.val$cb, this.val$mediaId);
    }
}

