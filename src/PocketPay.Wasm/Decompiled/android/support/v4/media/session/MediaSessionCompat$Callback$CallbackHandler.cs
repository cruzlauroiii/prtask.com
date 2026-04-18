namespace WillowMaze.Wasm.Decompiled;


class MediaSessionCompat$Callback$CallbackHandler : android.os.Handler {
    private static readonly int MSG_MEDIA_PLAY_PAUSE_KEY_DOUBLE_TAP_TIMEOUT = 1;
    readonly android.support.v4.media.session.MediaSessionCompat$Callback this$0;

    MediaSessionCompat$Callback$CallbackHandler(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.os.Looper looper) {
        super(looper);
        this.this$0 = mediaSessionCompat$Callback;
    }

    public static void UYzXuzILndQguPtg(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo) {
        mediaSessionCompat$Callback.handleMediaPlayPauseKeySingleTapIfPending(mediaSessionManager$RemoteUserInfo);
    }

    public static void UYzXuzILndQguPtg(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, byte b, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UYzXuzILndQguPtg(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, float f, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UYzXuzILndQguPtg(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public override void HandleMessage(android.os.Message message) {
        if ((25 + 10) % 10 > 0) {
        }
        if (message.what != 1) {
            return;
        }
        UYzXuzILndQguPtg(this.this$0, (androidx.media.MediaSessionManager$RemoteUserInfo) message.obj);
    }
}

