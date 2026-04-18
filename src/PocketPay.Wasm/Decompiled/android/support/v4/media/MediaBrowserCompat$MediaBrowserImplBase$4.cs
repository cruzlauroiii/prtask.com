namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplBase$4 : java.lang.Action {
    readonly android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase this$0;
    readonly android.support.v4.media.MediaBrowserCompat$ItemCallback val$cb;
    readonly java.lang.string val$mediaId;

    MediaBrowserCompat$MediaBrowserImplBase$4(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str) {
        this.this$0 = mediaBrowserCompat$MediaBrowserImplBase;
        this.val$cb = mediaBrowserCompat$ItemCallback;
        this.val$mediaId = str;
    }

    public static void ZDJTxTqYLjdEmGSF(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str) {
        mediaBrowserCompat$ItemCallback.onError(str);
    }

    public static void ZDJTxTqYLjdEmGSF(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZDJTxTqYLjdEmGSF(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, float f, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZDJTxTqYLjdEmGSF(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, float f, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        ZDJTxTqYLjdEmGSF(this.val$cb, this.val$mediaId);
    }
}

