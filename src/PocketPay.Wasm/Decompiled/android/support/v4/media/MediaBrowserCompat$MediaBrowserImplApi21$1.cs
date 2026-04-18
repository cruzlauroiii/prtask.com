namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplApi21$1 : java.lang.Action {
    readonly android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 this$0;
    readonly android.support.v4.media.MediaBrowserCompat$ItemCallback val$cb;
    readonly java.lang.string val$mediaId;

    MediaBrowserCompat$MediaBrowserImplApi21$1(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str) {
        this.this$0 = mediaBrowserCompat$MediaBrowserImplApi21;
        this.val$cb = mediaBrowserCompat$ItemCallback;
        this.val$mediaId = str;
    }

    public static void QEyBIbTueDKTKUbL(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str) {
        mediaBrowserCompat$ItemCallback.onError(str);
    }

    public static void QEyBIbTueDKTKUbL(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QEyBIbTueDKTKUbL(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QEyBIbTueDKTKUbL(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        QEyBIbTueDKTKUbL(this.val$cb, this.val$mediaId);
    }
}

