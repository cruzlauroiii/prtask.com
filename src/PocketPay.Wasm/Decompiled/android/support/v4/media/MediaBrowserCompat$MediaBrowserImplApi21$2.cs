namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplApi21$2 : java.lang.Action {
    readonly android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 this$0;
    readonly android.support.v4.media.MediaBrowserCompat$ItemCallback val$cb;
    readonly java.lang.string val$mediaId;

    MediaBrowserCompat$MediaBrowserImplApi21$2(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str) {
        this.this$0 = mediaBrowserCompat$MediaBrowserImplApi21;
        this.val$cb = mediaBrowserCompat$ItemCallback;
        this.val$mediaId = str;
    }

    public static void GBJCmorhlpiVvffl(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str) {
        mediaBrowserCompat$ItemCallback.onError(str);
    }

    public static void GBJCmorhlpiVvffl(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, byte b, char c, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GBJCmorhlpiVvffl(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, byte b, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GBJCmorhlpiVvffl(android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback, java.lang.string str, java.lang.string str2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override void Run() {
        GBJCmorhlpiVvffl(this.val$cb, this.val$mediaId);
    }
}

