namespace WillowMaze.Wasm.Decompiled;


class MediaSessionCompat$MediaSessionImplApi28 : android.support.v4.media.session.MediaSessionCompat$MediaSessionImplApi21 {
    MediaSessionCompat$MediaSessionImplApi28(android.content.object context, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        super(context, str, bundle);
    }

    MediaSessionCompat$MediaSessionImplApi28(java.lang.object obj) {
        super(obj);
    }

    public static android.media.session.MediaSessionManager$RemoteUserInfo ARggdvNkqmKVbRPG(android.media.session.MediaSession mediaSession) {
        return mediaSession.getCurrentControllerInfo();
    }

    public static void ARggdvNkqmKVbRPG(android.media.session.MediaSession mediaSession, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ARggdvNkqmKVbRPG(android.media.session.MediaSession mediaSession, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ARggdvNkqmKVbRPG(android.media.session.MediaSession mediaSession, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public readonly androidx.media.MediaSessionManager$RemoteUserInfo getCurrentControllerInfo() {
        return new androidx.media.MediaSessionManager$RemoteUserInfo(ARggdvNkqmKVbRPG((android.media.session.MediaSession) this.mSessionObj));
    }

    public override void SetCurrentControllerInfo(androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo) {
    }
}

