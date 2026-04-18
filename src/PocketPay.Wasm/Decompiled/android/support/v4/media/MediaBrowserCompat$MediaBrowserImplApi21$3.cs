namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplApi21$3 : java.lang.Action {
    readonly android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 this$0;
    readonly android.support.v4.media.MediaBrowserCompat$ItemCallback val$cb;
    readonly java.lang.string val$mediaId;

    MediaBrowserCompat$MediaBrowserImplApi21$3(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str) {
        this.this$0 = mediaBrowserCompat$MediaBrowserImplApi21;
        this.val$cb = mediaBrowserCompat$ItemCallback;
        this.val$mediaId = str;
    }

    public static void CWQxHiQqIsePvwwo(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str) {
        mediaBrowserCompat$ItemCallback.onError(str);
    }

    public static void CWQxHiQqIsePvwwo(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, java.lang.string str2, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CWQxHiQqIsePvwwo(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, short s, java.lang.string str2, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CWQxHiQqIsePvwwo(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, short s, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        cWQxHiQqIsePvwwo(this.val$cb, this.val$mediaId);
    }
}

