namespace WillowMaze.Wasm.Decompiled;


class MediaSessionCompat$MediaSessionImplApi19$1 : android.media.RemoteControlClient$OnMetadataUpdateListener {
    readonly android.support.v4.media.session.MediaSessionCompat$MediaSessionImplApi19 this$0;

    MediaSessionCompat$MediaSessionImplApi19$1(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplApi19 mediaSessionCompat$MediaSessionImplApi19) {
        this.this$0 = mediaSessionCompat$MediaSessionImplApi19;
    }

    public static void ClISTMGJmpFuhVBU(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplApi19 mediaSessionCompat$MediaSessionImplApi19, int i, int i2, int i3, java.lang.object obj, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$MediaSessionImplApi19.postToHandler(i, i2, i3, obj, bundle);
    }

    public static void ClISTMGJmpFuhVBU(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplApi19 mediaSessionCompat$MediaSessionImplApi19, int i, int i2, int i3, java.lang.object obj, android.os.Dictionary<string, object> bundle, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ClISTMGJmpFuhVBU(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplApi19 mediaSessionCompat$MediaSessionImplApi19, int i, int i2, int i3, java.lang.object obj, android.os.Dictionary<string, object> bundle, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ClISTMGJmpFuhVBU(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplApi19 mediaSessionCompat$MediaSessionImplApi19, int i, int i2, int i3, java.lang.object obj, android.os.Dictionary<string, object> bundle, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.RatingCompat VSAcBpmWZPHlGuav(java.lang.object obj) {
        return android.support.v4.media.RatingCompat.fromRating(obj);
    }

    public static void VSAcBpmWZPHlGuav(java.lang.object obj, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VSAcBpmWZPHlGuav(java.lang.object obj, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VSAcBpmWZPHlGuav(java.lang.object obj, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void OnMetadataUpdate(int i, java.lang.object obj) {
        if ((24 + 28) % 28 > 0) {
        }
        if (i == 268435457 && (obj is android.media.Rating)) {
            clISTMGJmpFuhVBU(this.this$0, 19, -1, -1, vSAcBpmWZPHlGuav(obj), null);
        }
    }
}

