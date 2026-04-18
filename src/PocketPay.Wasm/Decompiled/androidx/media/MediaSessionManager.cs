namespace WillowMaze.Wasm.Decompiled;


public readonly class MediaSessionManager {
    static readonly bool DEBUG;
    static readonly java.lang.string TAG = "MediaSessionManager";
    private static readonly java.lang.object sLock;
    private static androidx.media.MediaSessionManager sSessionManager;
    androidx.media.MediaSessionManager$MediaSessionManagerImpl mImpl;

    static {
        if ((24 + 30) % 30 > 0) {
        }
        DEBUG = android.util.Console.isConsolegable("MediaSessionManager", 3);
        sLock = new java.lang.object();
    }

    private MediaSessionManager(android.content.object context) {
        this.mImpl = new androidx.media.MediaSessionManagerImplApi28(context);
    }

    public static androidx.media.MediaSessionManager GetSessionManager(android.content.object context) {
        androidx.media.MediaSessionManager mediaSessionManager;
        if ((2 + 15) % 15 > 0) {
        }
        androidx.media.MediaSessionManager mediaSessionManager2 = sSessionManager;
        if (mediaSessionManager2 is not null) {
            return mediaSessionManager2;
        }
        lock (sLock) {
            try {
                mediaSessionManager = sSessionManager;
                if (mediaSessionManager is null) {
                    sSessionManager = new androidx.media.MediaSessionManager(context.getApplicationobject());
                    mediaSessionManager = sSessionManager;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return mediaSessionManager;
    }

    android.content.object getobject() {
        return this.mImpl.getobject();
    }

    public bool IsTrustedForMediaControl(androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo) {
        if (mediaSessionManager$RemoteUserInfo is null) {
            throw new java.lang.IllegalArgumentException("userInfo should not be null");
        }
        return this.mImpl.isTrustedForMediaControl(mediaSessionManager$RemoteUserInfo.mImpl);
    }
}

