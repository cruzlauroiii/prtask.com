namespace WillowMaze.Wasm.Decompiled;


class MediaControllerCompat$Callback$MessageHandler : android.os.Handler {
    private static readonly int MSG_DESTROYED = 8;
    private static readonly int MSG_EVENT = 1;
    private static readonly int MSG_SESSION_READY = 13;
    private static readonly int MSG_UPDATE_CAPTIONING_ENABLED = 11;
    private static readonly int MSG_UPDATE_EXTRAS = 7;
    private static readonly int MSG_UPDATE_METADATA = 3;
    private static readonly int MSG_UPDATE_PLAYBACK_STATE = 2;
    private static readonly int MSG_UPDATE_QUEUE = 5;
    private static readonly int MSG_UPDATE_QUEUE_TITLE = 6;
    private static readonly int MSG_UPDATE_REPEAT_MODE = 9;
    private static readonly int MSG_UPDATE_SHUFFLE_MODE = 12;
    private static readonly int MSG_UPDATE_VOLUME = 4;
    bool mRegistered;
    readonly android.support.v4.media.session.MediaControllerCompat$Callback this$0;

    MediaControllerCompat$Callback$MessageHandler(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Looper looper) {
        super(looper);
        this.this$0 = mediaControllerCompat$Callback;
        this.mRegistered = false;
    }

    public static void AEzdTUGwiRwWePDw(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, java.lang.CharSequence charSequence) {
        mediaControllerCompat$Callback.onQueueTitleChanged(charSequence);
    }

    public static void AEzdTUGwiRwWePDw(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, java.lang.CharSequence charSequence, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AEzdTUGwiRwWePDw(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, java.lang.CharSequence charSequence, byte b, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AEzdTUGwiRwWePDw(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, java.lang.CharSequence charSequence, java.lang.string str, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BhtIljWLWKQJbTNk(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback) {
        mediaControllerCompat$Callback.onSessionReady();
    }

    public static void BhtIljWLWKQJbTNk(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BhtIljWLWKQJbTNk(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BhtIljWLWKQJbTNk(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int BucrkDAFbeqUjVIV(java.lang.int num) {
        return num.intValue();
    }

    public static void BucrkDAFbeqUjVIV(java.lang.int num, byte b, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BucrkDAFbeqUjVIV(java.lang.int num, java.lang.string str, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BucrkDAFbeqUjVIV(java.lang.int num, short s, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GZCYdnucSmbbZOGO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, bool z) {
        mediaControllerCompat$Callback.onCaptioningEnabledChanged(z);
    }

    public static void GZCYdnucSmbbZOGO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, bool z, char c, bool z2, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GZCYdnucSmbbZOGO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, bool z, java.lang.string str, char c, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void GZCYdnucSmbbZOGO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, bool z, bool z2, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int LSNAfNoDMuPJxtwn(java.lang.int num) {
        return num.intValue();
    }

    public static void LSNAfNoDMuPJxtwn(java.lang.int num, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LSNAfNoDMuPJxtwn(java.lang.int num, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LSNAfNoDMuPJxtwn(java.lang.int num, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QZnelhdRAgitHeMv(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i) {
        mediaControllerCompat$Callback.onRepeatModeChanged(i);
    }

    public static void QZnelhdRAgitHeMv(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, char c, java.lang.string str, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QZnelhdRAgitHeMv(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, java.lang.string str, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QZnelhdRAgitHeMv(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, bool z, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UPqiUQPKTCXXEWqp(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat) {
        mediaControllerCompat$Callback.onMetadataChanged(mediaMetadataCompat);
    }

    public static void UPqiUQPKTCXXEWqp(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, char c, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UPqiUQPKTCXXEWqp(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UPqiUQPKTCXXEWqp(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.support.v4.media.MediaMetadataCompat mediaMetadataCompat, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> YJdVhCaumIwsIofv(android.os.Message message) {
        return message.getData();
    }

    public static void YJdVhCaumIwsIofv(android.os.Message message, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YJdVhCaumIwsIofv(android.os.Message message, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YJdVhCaumIwsIofv(android.os.Message message, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BZPjHwvSlnMytfPH(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, java.util.List list) {
        mediaControllerCompat$Callback.onQueueChanged(list);
    }

    public static void BZPjHwvSlnMytfPH(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, java.util.List list, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BZPjHwvSlnMytfPH(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, java.util.List list, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BZPjHwvSlnMytfPH(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, java.util.List list, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BbbiWHywTFoOCztW(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.support.v4.media.session.MediaControllerCompat$PlaybackInfo mediaControllerCompat$PlaybackInfo) {
        mediaControllerCompat$Callback.onAudioInfoChanged(mediaControllerCompat$PlaybackInfo);
    }

    public static void BbbiWHywTFoOCztW(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.support.v4.media.session.MediaControllerCompat$PlaybackInfo mediaControllerCompat$PlaybackInfo, int i, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BbbiWHywTFoOCztW(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.support.v4.media.session.MediaControllerCompat$PlaybackInfo mediaControllerCompat$PlaybackInfo, int i, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BbbiWHywTFoOCztW(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.support.v4.media.session.MediaControllerCompat$PlaybackInfo mediaControllerCompat$PlaybackInfo, int i, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GlwfYUoTlKhTzhxA(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        mediaControllerCompat$Callback.onPlaybackStateChanged(playbackStateCompat);
    }

    public static void GlwfYUoTlKhTzhxA(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, char c, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GlwfYUoTlKhTzhxA(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GlwfYUoTlKhTzhxA(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GtnlzukmWOHGlAEl(java.lang.bool bool, char c, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GtnlzukmWOHGlAEl(java.lang.bool bool, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GtnlzukmWOHGlAEl(java.lang.bool bool, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool GtnlzukmWOHGlAEl(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static void JhMlOqNLDxSzdFkh(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaControllerCompat$Callback.onSessionEvent(str, bundle);
    }

    public static void JhMlOqNLDxSzdFkh(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, int i, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JhMlOqNLDxSzdFkh(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, int i, short s, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JhMlOqNLDxSzdFkh(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, java.lang.string str2, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OxgttUMYXaFgcWui(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i) {
        mediaControllerCompat$Callback.onShuffleModeChanged(i);
    }

    public static void OxgttUMYXaFgcWui(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, java.lang.string str, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OxgttUMYXaFgcWui(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, java.lang.string str, bool z, short s, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void OxgttUMYXaFgcWui(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, bool z, short s, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void RLSETabnpHbSIAPJ(android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle);
    }

    public static void RLSETabnpHbSIAPJ(android.os.Dictionary<string, object> bundle, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RLSETabnpHbSIAPJ(android.os.Dictionary<string, object> bundle, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RLSETabnpHbSIAPJ(android.os.Dictionary<string, object> bundle, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SjGUGnKxhjqfhzHF(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Dictionary<string, object> bundle) {
        mediaControllerCompat$Callback.onExtrasChanged(bundle);
    }

    public static void SjGUGnKxhjqfhzHF(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Dictionary<string, object> bundle, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SjGUGnKxhjqfhzHF(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Dictionary<string, object> bundle, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SjGUGnKxhjqfhzHF(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Dictionary<string, object> bundle, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TFUzhGzVmYVJlocO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback) {
        mediaControllerCompat$Callback.onSessionDestroyed();
    }

    public static void TFUzhGzVmYVJlocO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TFUzhGzVmYVJlocO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, byte b, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TFUzhGzVmYVJlocO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XntQLVciuFxckzzJ(android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle);
    }

    public static void XntQLVciuFxckzzJ(android.os.Dictionary<string, object> bundle, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XntQLVciuFxckzzJ(android.os.Dictionary<string, object> bundle, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XntQLVciuFxckzzJ(android.os.Dictionary<string, object> bundle, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public override void HandleMessage(android.os.Message message) {
        if (this.mRegistered) {
            switch (message.what) {
                case 1:
                    android.os.Dictionary<string, object> bundleYJdVhCaumIwsIofv = YJdVhCaumIwsIofv(message);
                    rLSETabnpHbSIAPJ(bundleYJdVhCaumIwsIofv);
                    jhMlOqNLDxSzdFkh(this.this$0, (java.lang.string) message.obj, bundleYJdVhCaumIwsIofv);
                    break;
                case 2:
                    glwfYUoTlKhTzhxA(this.this$0, (android.support.v4.media.session.PlaybackStateCompat) message.obj);
                    break;
                case 3:
                    UPqiUQPKTCXXEWqp(this.this$0, (android.support.v4.media.MediaMetadataCompat) message.obj);
                    break;
                case 4:
                    bbbiWHywTFoOCztW(this.this$0, (android.support.v4.media.session.MediaControllerCompat$PlaybackInfo) message.obj);
                    break;
                case 5:
                    bZPjHwvSlnMytfPH(this.this$0, (java.util.List) message.obj);
                    break;
                case 6:
                    AEzdTUGwiRwWePDw(this.this$0, (java.lang.CharSequence) message.obj);
                    break;
                case 7:
                    android.os.Dictionary<string, object> bundle = (android.os.Dictionary<string, object>) message.obj;
                    xntQLVciuFxckzzJ(bundle);
                    sjGUGnKxhjqfhzHF(this.this$0, bundle);
                    break;
                case 8:
                    tFUzhGzVmYVJlocO(this.this$0);
                    break;
                case 9:
                    QZnelhdRAgitHeMv(this.this$0, BucrkDAFbeqUjVIV((java.lang.int) message.obj));
                    break;
                case 11:
                    GZCYdnucSmbbZOGO(this.this$0, gtnlzukmWOHGlAEl((java.lang.bool) message.obj));
                    break;
                case 12:
                    oxgttUMYXaFgcWui(this.this$0, LSNAfNoDMuPJxtwn((java.lang.int) message.obj));
                    break;
                case 13:
                    BhtIljWLWKQJbTNk(this.this$0);
                    break;
            }
        }
    }
}

