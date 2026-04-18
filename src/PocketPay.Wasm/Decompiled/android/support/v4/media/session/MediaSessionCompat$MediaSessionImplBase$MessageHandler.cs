namespace WillowMaze.Wasm.Decompiled;


class MediaSessionCompat$MediaSessionImplBase$MessageHandler : android.os.Handler {
    private static readonly int KEYCODE_MEDIA_PAUSE = 127;
    private static readonly int KEYCODE_MEDIA_PLAY = 126;
    private static readonly int MSG_ADD_QUEUE_ITEM = 25;
    private static readonly int MSG_ADD_QUEUE_ITEM_AT = 26;
    private static readonly int MSG_ADJUST_VOLUME = 2;
    private static readonly int MSG_COMMAND = 1;
    private static readonly int MSG_CUSTOM_ACTION = 20;
    private static readonly int MSG_FAST_FORWARD = 16;
    private static readonly int MSG_MEDIA_BUTTON = 21;
    private static readonly int MSG_NEXT = 14;
    private static readonly int MSG_PAUSE = 12;
    private static readonly int MSG_PLAY = 7;
    private static readonly int MSG_PLAY_MEDIA_ID = 8;
    private static readonly int MSG_PLAY_SEARCH = 9;
    private static readonly int MSG_PLAY_Uri = 10;
    private static readonly int MSG_PREPARE = 3;
    private static readonly int MSG_PREPARE_MEDIA_ID = 4;
    private static readonly int MSG_PREPARE_SEARCH = 5;
    private static readonly int MSG_PREPARE_Uri = 6;
    private static readonly int MSG_PREVIOUS = 15;
    private static readonly int MSG_RATE = 19;
    private static readonly int MSG_RATE_EXTRA = 31;
    private static readonly int MSG_REMOVE_QUEUE_ITEM = 27;
    private static readonly int MSG_REMOVE_QUEUE_ITEM_AT = 28;
    private static readonly int MSG_REWIND = 17;
    private static readonly int MSG_SEEK_TO = 18;
    private static readonly int MSG_SET_CAPTIONING_ENABLED = 29;
    private static readonly int MSG_SET_REPEAT_MODE = 23;
    private static readonly int MSG_SET_SHUFFLE_MODE = 30;
    private static readonly int MSG_SET_VOLUME = 22;
    private static readonly int MSG_SKIP_TO_ITEM = 11;
    private static readonly int MSG_STOP = 13;
    readonly android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase this$0;

    public MediaSessionCompat$MediaSessionImplBase$MessageHandler(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, android.os.Looper looper) {
        super(looper);
        this.this$0 = mediaSessionCompat$MediaSessionImplBase;
    }

    public static android.os.Dictionary<string, object> AamKVctNnlbBJjir(android.os.Message message) {
        return message.getData();
    }

    public static void AamKVctNnlbBJjir(android.os.Message message, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AamKVctNnlbBJjir(android.os.Message message, short s, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AamKVctNnlbBJjir(android.os.Message message, short s, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AhXIGVpZcBRaKnbV(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onStop();
    }

    public static void AhXIGVpZcBRaKnbV(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AhXIGVpZcBRaKnbV(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AhXIGVpZcBRaKnbV(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AzocarehbMGkRTCd(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onPause();
    }

    public static void AzocarehbMGkRTCd(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, float f, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AzocarehbMGkRTCd(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AzocarehbMGkRTCd(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BYCcQkiWNMWaFlsb(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, int i2) {
        mediaSessionCompat$MediaSessionImplBase.setVolumeTo(i, i2);
    }

    public static void BYCcQkiWNMWaFlsb(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, int i2, char c, byte b, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void BYCcQkiWNMWaFlsb(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, int i2, int i3, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BYCcQkiWNMWaFlsb(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, int i2, int i3, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BsDMHUyGmSGjlQZr(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.RatingCompat ratingCompat, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$Callback.onHashSetRating(ratingCompat, bundle);
    }

    public static void BsDMHUyGmSGjlQZr(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.RatingCompat ratingCompat, android.os.Dictionary<string, object> bundle, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BsDMHUyGmSGjlQZr(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.RatingCompat ratingCompat, android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BsDMHUyGmSGjlQZr(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.RatingCompat ratingCompat, android.os.Dictionary<string, object> bundle, bool z, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CLyyFZsqQMucjgCr(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo) {
        mediaSessionCompat$MediaSessionImplBase.setCurrentControllerInfo(mediaSessionManager$RemoteUserInfo);
    }

    public static void CLyyFZsqQMucjgCr(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CLyyFZsqQMucjgCr(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CLyyFZsqQMucjgCr(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, java.lang.string str, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DOIeONerRNjHWmkn(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.net.Uri uri, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$Callback.onPrepareFromUri(uri, bundle);
    }

    public static void DOIeONerRNjHWmkn(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.net.Uri uri, android.os.Dictionary<string, object> bundle, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DOIeONerRNjHWmkn(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.net.Uri uri, android.os.Dictionary<string, object> bundle, float f, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DOIeONerRNjHWmkn(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.net.Uri uri, android.os.Dictionary<string, object> bundle, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DxkYQrbZOfXfrIOP(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onSkipToPrevious();
    }

    public static void DxkYQrbZOfXfrIOP(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DxkYQrbZOfXfrIOP(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DxkYQrbZOfXfrIOP(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FACKbpwIcxVxnPBv(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onFastForward();
    }

    public static void FACKbpwIcxVxnPBv(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, java.lang.string str, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FACKbpwIcxVxnPBv(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FACKbpwIcxVxnPBv(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FkzyAWGRQaYIryGK(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onPrepare();
    }

    public static void FkzyAWGRQaYIryGK(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FkzyAWGRQaYIryGK(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FkzyAWGRQaYIryGK(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int GrrTEqrEvihvRsDD(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void GrrTEqrEvihvRsDD(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, byte b, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GrrTEqrEvihvRsDD(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GrrTEqrEvihvRsDD(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HDxJHOhhxUdbddbN(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$Callback.onPlayFromSearch(str, bundle);
    }

    public static void HDxJHOhhxUdbddbN(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HDxJHOhhxUdbddbN(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, bool z, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HDxJHOhhxUdbddbN(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HVYAJgEocJqBGQEy(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.content.object intent, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HVYAJgEocJqBGQEy(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.content.object intent, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HVYAJgEocJqBGQEy(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.content.object intent, bool z, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool HVYAJgEocJqBGQEy(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.content.object intent) {
        return mediaSessionCompat$Callback.onMediaButtonEvent(intent);
    }

    public static void HcjOQMZDBsSaAkql(java.lang.bool bool, int i, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HcjOQMZDBsSaAkql(java.lang.bool bool, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HcjOQMZDBsSaAkql(java.lang.bool bool, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool HcjOQMZDBsSaAkql(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static long IurOKeDfqHJeZomE(java.lang.long l) {
        if ((20 + 8) % 8 > 0) {
        }
        return l.longValue();
    }

    public static void IurOKeDfqHJeZomE(java.lang.long l, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IurOKeDfqHJeZomE(java.lang.long l, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IurOKeDfqHJeZomE(java.lang.long l, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LBSbaTwOcvzPtRCK(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, bool z) {
        mediaSessionCompat$Callback.onHashSetCaptioningEnabled(z);
    }

    public static void LBSbaTwOcvzPtRCK(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, bool z, float f, int i, short s, bool z2) {
        double d = (42 * 210) + 210;
    }

    public static void LBSbaTwOcvzPtRCK(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, bool z, float f, bool z2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LBSbaTwOcvzPtRCK(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, bool z, int i, bool z2, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LljsaknEexmUKzLW(android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle);
    }

    public static void LljsaknEexmUKzLW(android.os.Dictionary<string, object> bundle, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LljsaknEexmUKzLW(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LljsaknEexmUKzLW(android.os.Dictionary<string, object> bundle, bool z, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LuINIPmjTbJUxkHr(android.os.Dictionary<string, object> bundle) {
        android.support.v4.media.session.MediaSessionCompat.ensureClassLoader(bundle);
    }

    public static void LuINIPmjTbJUxkHr(android.os.Dictionary<string, object> bundle, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LuINIPmjTbJUxkHr(android.os.Dictionary<string, object> bundle, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LuINIPmjTbJUxkHr(android.os.Dictionary<string, object> bundle, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int NNtxlWwZnIBOsZAs(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void NNtxlWwZnIBOsZAs(java.lang.string str, java.lang.string str2, bool z, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NNtxlWwZnIBOsZAs(java.lang.string str, java.lang.string str2, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void NNtxlWwZnIBOsZAs(java.lang.string str, java.lang.string str2, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int NSnbIFxDivdRBhUV(java.util.List list) {
        return list.Count;
    }

    public static void NSnbIFxDivdRBhUV(java.util.List list, int i, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NSnbIFxDivdRBhUV(java.util.List list, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NSnbIFxDivdRBhUV(java.util.List list, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OFUEqdbYwcLAEVJf(java.util.List list, int i) {
        return list[i);
    }

    public static void OFUEqdbYwcLAEVJf(java.util.List list, int i, byte b, float f, int i2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OFUEqdbYwcLAEVJf(java.util.List list, int i, float f, int i2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OFUEqdbYwcLAEVJf(java.util.List list, int i, int i2, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PuazIPzDRismwhda(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$Callback.onPrepareFromSearch(str, bundle);
    }

    public static void PuazIPzDRismwhda(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, byte b, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PuazIPzDRismwhda(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, float f, java.lang.string str2, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PuazIPzDRismwhda(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, int i, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RetfDSDituWWCJtr(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        mediaSessionCompat$Callback.onRemoveQueueItem(mediaDescriptionCompat);
    }

    public static void RetfDSDituWWCJtr(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RetfDSDituWWCJtr(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RetfDSDituWWCJtr(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SLArqIFMwNVQZFgk(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onPause();
    }

    public static void SLArqIFMwNVQZFgk(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SLArqIFMwNVQZFgk(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SLArqIFMwNVQZFgk(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SdGEpFCJRRaBrhBZ(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onSkipToNext();
    }

    public static void SdGEpFCJRRaBrhBZ(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SdGEpFCJRRaBrhBZ(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SdGEpFCJRRaBrhBZ(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, bool z, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SeUgRfstKqptkixa(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$Callback.onPlayFromMediaId(str, bundle);
    }

    public static void SeUgRfstKqptkixa(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SeUgRfstKqptkixa(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SeUgRfstKqptkixa(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, bool z, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat TYVwAAKYkDMhlKzJ(android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem) {
        return mediaSessionCompat$QueueItem.getDescription();
    }

    public static void TYVwAAKYkDMhlKzJ(android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TYVwAAKYkDMhlKzJ(android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TYVwAAKYkDMhlKzJ(android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ULIiANPVPXNoWIEI(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onFastForward();
    }

    public static void ULIiANPVPXNoWIEI(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ULIiANPVPXNoWIEI(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ULIiANPVPXNoWIEI(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VCGKeEdfAXXRrdsg(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i) {
        mediaSessionCompat$Callback.onHashSetShuffleMode(i);
    }

    public static void VCGKeEdfAXXRrdsg(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, char c, short s, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void VCGKeEdfAXXRrdsg(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, int i2, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VCGKeEdfAXXRrdsg(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, int i2, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XfhatSfoRsSitqRW(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i) {
        mediaSessionCompat$Callback.onHashSetRepeatMode(i);
    }

    public static void XfhatSfoRsSitqRW(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XfhatSfoRsSitqRW(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, char c, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XfhatSfoRsSitqRW(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, java.lang.string str, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static long XuNBavSPiouPgsof(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat) {
        if ((27 + 15) % 15 > 0) {
        }
        return playbackStateCompat.getActions();
    }

    public static void XuNBavSPiouPgsof(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XuNBavSPiouPgsof(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XuNBavSPiouPgsof(android.support.v4.media.session.PlaybackStateCompat playbackStateCompat, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XwgdjzIxdPhbJotj(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo) {
        mediaSessionCompat$MediaSessionImplBase.setCurrentControllerInfo(mediaSessionManager$RemoteUserInfo);
    }

    public static void XwgdjzIxdPhbJotj(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XwgdjzIxdPhbJotj(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XwgdjzIxdPhbJotj(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int AaejWlwwlBvNbnLv(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getInt(str);
    }

    public static void AaejWlwwlBvNbnLv(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void AaejWlwwlBvNbnLv(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AaejWlwwlBvNbnLv(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BHIRToLPpQQLBpWu(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.RatingCompat ratingCompat) {
        mediaSessionCompat$Callback.onHashSetRating(ratingCompat);
    }

    public static void BHIRToLPpQQLBpWu(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.RatingCompat ratingCompat, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BHIRToLPpQQLBpWu(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.RatingCompat ratingCompat, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BHIRToLPpQQLBpWu(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.RatingCompat ratingCompat, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BeCqaAWSIXknzTPl(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo) {
        mediaSessionCompat$MediaSessionImplBase.setCurrentControllerInfo(mediaSessionManager$RemoteUserInfo);
    }

    public static void BeCqaAWSIXknzTPl(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BeCqaAWSIXknzTPl(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BeCqaAWSIXknzTPl(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, androidx.media.MediaSessionManager$RemoteUserInfo mediaSessionManager$RemoteUserInfo, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string BoCMlNrnadBVZkkU(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getstring(str);
    }

    public static void BoCMlNrnadBVZkkU(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BoCMlNrnadBVZkkU(android.os.Dictionary<string, object> bundle, java.lang.string str, java.lang.string str2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BoCMlNrnadBVZkkU(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CGvoBWGgOyuNWLBM(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onRewind();
    }

    public static void CGvoBWGgOyuNWLBM(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CGvoBWGgOyuNWLBM(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CGvoBWGgOyuNWLBM(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static long CwvcMaWzUWJgCNCV(java.lang.long l) {
        if ((1 + 4) % 4 > 0) {
        }
        return l.longValue();
    }

    public static void CwvcMaWzUWJgCNCV(java.lang.long l, int i, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CwvcMaWzUWJgCNCV(java.lang.long l, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CwvcMaWzUWJgCNCV(java.lang.long l, bool z, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DFSFfqdPnTLUDByJ(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        mediaSessionCompat$Callback.onAddQueueItem(mediaDescriptionCompat);
    }

    public static void DFSFfqdPnTLUDByJ(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, java.lang.string str, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DFSFfqdPnTLUDByJ(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DFSFfqdPnTLUDByJ(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DyYlifVmsVQFkLUJ(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, long j) {
        mediaSessionCompat$Callback.onSkipToQueueItem(j);
    }

    public static void DyYlifVmsVQFkLUJ(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, long j, byte b, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DyYlifVmsVQFkLUJ(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, long j, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DyYlifVmsVQFkLUJ(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, long j, java.lang.string str, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EaeAKcyLwUxtIEJH(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i) {
        mediaSessionCompat$Callback.onAddQueueItem(mediaDescriptionCompat, i);
    }

    public static void EaeAKcyLwUxtIEJH(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EaeAKcyLwUxtIEJH(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EaeAKcyLwUxtIEJH(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i, bool z, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GiRQGLZRFtZPaAnv(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        mediaSessionCompat$Callback.onRemoveQueueItem(mediaDescriptionCompat);
    }

    public static void GiRQGLZRFtZPaAnv(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GiRQGLZRFtZPaAnv(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GiRQGLZRFtZPaAnv(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, bool z, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GpJeehfomwMIeuQA(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onRewind();
    }

    public static void GpJeehfomwMIeuQA(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GpJeehfomwMIeuQA(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GpJeehfomwMIeuQA(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.content.object HXkHQaHYhJYSvRyq(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable) {
        return intent.putExtra(str, parcelable);
    }

    public static void HXkHQaHYhJYSvRyq(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable, float f, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HXkHQaHYhJYSvRyq(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable, float f, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HXkHQaHYhJYSvRyq(android.content.object intent, java.lang.string str, android.os.Parcelable parcelable, java.lang.string str2, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HrghzCkhWeNOZXAM(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$Callback.onCustomAction(str, bundle);
    }

    public static void HrghzCkhWeNOZXAM(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, char c, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HrghzCkhWeNOZXAM(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, int i, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HrghzCkhWeNOZXAM(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, int i, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void IOPvhBOxeIuSdVrS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, int i2) {
        mediaSessionCompat$MediaSessionImplBase.adjustVolume(i, i2);
    }

    public static void IOPvhBOxeIuSdVrS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, int i2, byte b, char c, float f, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void IOPvhBOxeIuSdVrS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, int i2, byte b, char c, int i3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IOPvhBOxeIuSdVrS(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase mediaSessionCompat$MediaSessionImplBase, int i, int i2, float f, byte b, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void JgdCHkEwPLBYSEXc(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, long j) {
        mediaSessionCompat$Callback.onSeekTo(j);
    }

    public static void JgdCHkEwPLBYSEXc(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, long j, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JgdCHkEwPLBYSEXc(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, long j, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JgdCHkEwPLBYSEXc(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, long j, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    private void OnMediaButtonEvent(android.view.KeyEvent keyEvent, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        if ((2 + 24) % 24 > 0) {
        }
        if (keyEvent is not null && qIARSknZMuhyIKte(keyEvent) == 0) {
            long jXuNBavSPiouPgsof = this.this$0.mState is not null ? XuNBavSPiouPgsof(this.this$0.mState) : 0L;
            int iTaBbbxoWPcZyNOLC = taBbbxoWPcZyNOLC(keyEvent);
            if (iTaBbbxoWPcZyNOLC != 79) {
                if (iTaBbbxoWPcZyNOLC == 126) {
                    if ((4 & jXuNBavSPiouPgsof) == 0) {
                        return;
                    }
                    tQXzrWToHZNdazFx(mediaSessionCompat$Callback);
                    return;
                }
                if (iTaBbbxoWPcZyNOLC == 127) {
                    if ((2 & jXuNBavSPiouPgsof) == 0) {
                        return;
                    }
                    SLArqIFMwNVQZFgk(mediaSessionCompat$Callback);
                    return;
                }
                switch (iTaBbbxoWPcZyNOLC) {
                    case 86:
                        if ((1 & jXuNBavSPiouPgsof) != 0) {
                            rHETUiluWvpHtAQn(mediaSessionCompat$Callback);
                            break;
                        }
                        break;
                    case 87:
                        if ((32 & jXuNBavSPiouPgsof) != 0) {
                            tQEJNFgoAMGMlnES(mediaSessionCompat$Callback);
                            break;
                        }
                        break;
                    case 88:
                        if ((16 & jXuNBavSPiouPgsof) != 0) {
                            rbgBUVLZIJevSCks(mediaSessionCompat$Callback);
                            break;
                        }
                        break;
                    case 89:
                        if ((8 & jXuNBavSPiouPgsof) != 0) {
                            gpJeehfomwMIeuQA(mediaSessionCompat$Callback);
                            break;
                        }
                        break;
                    case 90:
                        if ((64 & jXuNBavSPiouPgsof) != 0) {
                            FACKbpwIcxVxnPBv(mediaSessionCompat$Callback);
                            break;
                        }
                        break;
                }
                return;
            }
            NNtxlWwZnIBOsZAs("MediaSessionCompat", "KEYCODE_MEDIA_PLAY_PAUSE and KEYCODE_HEADSETHOOK are handled already");
        }
    }

    private void OnMediaButtonEvent(android.view.KeyEvent keyEvent, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    private void OnMediaButtonEvent(android.view.KeyEvent keyEvent, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void OnMediaButtonEvent(android.view.KeyEvent keyEvent, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PQPpSNwOpZVtRXTn(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onPlay();
    }

    public static void PQPpSNwOpZVtRXTn(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PQPpSNwOpZVtRXTn(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PQPpSNwOpZVtRXTn(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int QIARSknZMuhyIKte(android.view.KeyEvent keyEvent) {
        return keyEvent.getAction();
    }

    public static void QIARSknZMuhyIKte(android.view.KeyEvent keyEvent, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QIARSknZMuhyIKte(android.view.KeyEvent keyEvent, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QIARSknZMuhyIKte(android.view.KeyEvent keyEvent, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RHETUiluWvpHtAQn(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onStop();
    }

    public static void RHETUiluWvpHtAQn(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RHETUiluWvpHtAQn(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RHETUiluWvpHtAQn(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, float f, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> ROlbUZKzFxbHALSR(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getDictionary<string, object>(str);
    }

    public static void ROlbUZKzFxbHALSR(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ROlbUZKzFxbHALSR(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ROlbUZKzFxbHALSR(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RbgBUVLZIJevSCks(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onSkipToPrevious();
    }

    public static void RbgBUVLZIJevSCks(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RbgBUVLZIJevSCks(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, short s, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RbgBUVLZIJevSCks(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SfwTervDvzWJpgJF(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$Callback.onPrepareFromMediaId(str, bundle);
    }

    public static void SfwTervDvzWJpgJF(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, char c, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SfwTervDvzWJpgJF(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, java.lang.string str2, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SfwTervDvzWJpgJF(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, short s, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TQEJNFgoAMGMlnES(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onSkipToNext();
    }

    public static void TQEJNFgoAMGMlnES(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TQEJNFgoAMGMlnES(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TQEJNFgoAMGMlnES(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, short s, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TQXzrWToHZNdazFx(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$Callback.onPlay();
    }

    public static void TQXzrWToHZNdazFx(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TQXzrWToHZNdazFx(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, int i, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TQXzrWToHZNdazFx(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int TaBbbxoWPcZyNOLC(android.view.KeyEvent keyEvent) {
        return keyEvent.getKeyCode();
    }

    public static void TaBbbxoWPcZyNOLC(android.view.KeyEvent keyEvent, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TaBbbxoWPcZyNOLC(android.view.KeyEvent keyEvent, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TaBbbxoWPcZyNOLC(android.view.KeyEvent keyEvent, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VnPWQAMSAyCgeuqY(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler, android.view.KeyEvent keyEvent, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback) {
        mediaSessionCompat$MediaSessionImplBase$MessageHandler.onMediaButtonEvent(keyEvent, mediaSessionCompat$Callback);
    }

    public static void VnPWQAMSAyCgeuqY(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler, android.view.KeyEvent keyEvent, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VnPWQAMSAyCgeuqY(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler, android.view.KeyEvent keyEvent, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VnPWQAMSAyCgeuqY(android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$MessageHandler mediaSessionCompat$MediaSessionImplBase$MessageHandler, android.view.KeyEvent keyEvent, android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, bool z, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VrntDIkbiEWMVUdz(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.net.Uri uri, android.os.Dictionary<string, object> bundle) {
        mediaSessionCompat$Callback.onPlayFromUri(uri, bundle);
    }

    public static void VrntDIkbiEWMVUdz(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.net.Uri uri, android.os.Dictionary<string, object> bundle, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VrntDIkbiEWMVUdz(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.net.Uri uri, android.os.Dictionary<string, object> bundle, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VrntDIkbiEWMVUdz(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, android.net.Uri uri, android.os.Dictionary<string, object> bundle, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZJbQplTczroBPBou(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver) {
        mediaSessionCompat$Callback.onCommand(str, bundle, resultReceiver);
    }

    public static void ZJbQplTczroBPBou(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZJbQplTczroBPBou(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, char c, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZJbQplTczroBPBou(android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public override void HandleMessage(android.os.Message message) {
        if ((13 + 26) % 26 > 0) {
        }
        android.support.v4.media.session.MediaSessionCompat$Callback mediaSessionCompat$Callback = this.this$0.mCallback;
        if (mediaSessionCompat$Callback is not null) {
            android.os.Dictionary<string, object> bundleAamKVctNnlbBJjir = AamKVctNnlbBJjir(message);
            LuINIPmjTbJUxkHr(bundleAamKVctNnlbBJjir);
            CLyyFZsqQMucjgCr(this.this$0, new androidx.media.MediaSessionManager$RemoteUserInfo(boCMlNrnadBVZkkU(bundleAamKVctNnlbBJjir, "data_calling_pkg"), aaejWlwwlBvNbnLv(bundleAamKVctNnlbBJjir, "data_calling_pid"), GrrTEqrEvihvRsDD(bundleAamKVctNnlbBJjir, "data_calling_uid")));
            android.os.Dictionary<string, object> bundleROlbUZKzFxbHALSR = rOlbUZKzFxbHALSR(bundleAamKVctNnlbBJjir, "data_extras");
            LljsaknEexmUKzLW(bundleROlbUZKzFxbHALSR);
            try {
                switch (message.what) {
                    case 1:
                        android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$Command mediaSessionCompat$MediaSessionImplBase$Command = (android.support.v4.media.session.MediaSessionCompat$MediaSessionImplBase$Command) message.obj;
                        zJbQplTczroBPBou(mediaSessionCompat$Callback, mediaSessionCompat$MediaSessionImplBase$Command.command, mediaSessionCompat$MediaSessionImplBase$Command.extras, mediaSessionCompat$MediaSessionImplBase$Command.stub);
                        break;
                    case 2:
                        iOPvhBOxeIuSdVrS(this.this$0, message.arg1, 0);
                        break;
                    case 3:
                        FkzyAWGRQaYIryGK(mediaSessionCompat$Callback);
                        break;
                    case 4:
                        sfwTervDvzWJpgJF(mediaSessionCompat$Callback, (java.lang.string) message.obj, bundleROlbUZKzFxbHALSR);
                        break;
                    case 5:
                        PuazIPzDRismwhda(mediaSessionCompat$Callback, (java.lang.string) message.obj, bundleROlbUZKzFxbHALSR);
                        break;
                    case 6:
                        DOIeONerRNjHWmkn(mediaSessionCompat$Callback, (android.net.Uri) message.obj, bundleROlbUZKzFxbHALSR);
                        break;
                    case 7:
                        pQPpSNwOpZVtRXTn(mediaSessionCompat$Callback);
                        break;
                    case 8:
                        SeUgRfstKqptkixa(mediaSessionCompat$Callback, (java.lang.string) message.obj, bundleROlbUZKzFxbHALSR);
                        break;
                    case 9:
                        HDxJHOhhxUdbddbN(mediaSessionCompat$Callback, (java.lang.string) message.obj, bundleROlbUZKzFxbHALSR);
                        break;
                    case 10:
                        vrntDIkbiEWMVUdz(mediaSessionCompat$Callback, (android.net.Uri) message.obj, bundleROlbUZKzFxbHALSR);
                        break;
                    case 11:
                        dyYlifVmsVQFkLUJ(mediaSessionCompat$Callback, cwvcMaWzUWJgCNCV((java.lang.long) message.obj));
                        break;
                    case 12:
                        AzocarehbMGkRTCd(mediaSessionCompat$Callback);
                        break;
                    case 13:
                        AhXIGVpZcBRaKnbV(mediaSessionCompat$Callback);
                        break;
                    case 14:
                        SdGEpFCJRRaBrhBZ(mediaSessionCompat$Callback);
                        break;
                    case 15:
                        DxkYQrbZOfXfrIOP(mediaSessionCompat$Callback);
                        break;
                    case 16:
                        ULIiANPVPXNoWIEI(mediaSessionCompat$Callback);
                        break;
                    case 17:
                        cGvoBWGgOyuNWLBM(mediaSessionCompat$Callback);
                        break;
                    case 18:
                        jgdCHkEwPLBYSEXc(mediaSessionCompat$Callback, IurOKeDfqHJeZomE((java.lang.long) message.obj));
                        break;
                    case 19:
                        bHIRToLPpQQLBpWu(mediaSessionCompat$Callback, (android.support.v4.media.RatingCompat) message.obj);
                        break;
                    case 20:
                        hrghzCkhWeNOZXAM(mediaSessionCompat$Callback, (java.lang.string) message.obj, bundleROlbUZKzFxbHALSR);
                        break;
                    case 21:
                        android.view.KeyEvent keyEvent = (android.view.KeyEvent) message.obj;
                        android.content.object intent = new android.content.object("android.intent.action.MEDIA_BUTTON");
                        hXkHQaHYhJYSvRyq(intent, "android.intent.extra.KEY_EVENT", keyEvent);
                        if (!HVYAJgEocJqBGQEy(mediaSessionCompat$Callback, intent)) {
                            vnPWQAMSAyCgeuqY(this, keyEvent, mediaSessionCompat$Callback);
                        }
                        break;
                    case 22:
                        BYCcQkiWNMWaFlsb(this.this$0, message.arg1, 0);
                        break;
                    case 23:
                        XfhatSfoRsSitqRW(mediaSessionCompat$Callback, message.arg1);
                        break;
                    case 25:
                        dFSFfqdPnTLUDByJ(mediaSessionCompat$Callback, (android.support.v4.media.MediaDescriptionCompat) message.obj);
                        break;
                    case 26:
                        eaeAKcyLwUxtIEJH(mediaSessionCompat$Callback, (android.support.v4.media.MediaDescriptionCompat) message.obj, message.arg1);
                        break;
                    case 27:
                        RetfDSDituWWCJtr(mediaSessionCompat$Callback, (android.support.v4.media.MediaDescriptionCompat) message.obj);
                        break;
                    case 28:
                        if (this.this$0.mQueue is not null) {
                            android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem = (message.arg1 < 0 || message.arg1 >= NSnbIFxDivdRBhUV(this.this$0.mQueue)) ? null : (android.support.v4.media.session.MediaSessionCompat$QueueItem) OFUEqdbYwcLAEVJf(this.this$0.mQueue, message.arg1);
                            if (mediaSessionCompat$QueueItem is not null) {
                                giRQGLZRFtZPaAnv(mediaSessionCompat$Callback, TYVwAAKYkDMhlKzJ(mediaSessionCompat$QueueItem));
                            }
                        }
                        break;
                    case 29:
                        LBSbaTwOcvzPtRCK(mediaSessionCompat$Callback, HcjOQMZDBsSaAkql((java.lang.bool) message.obj));
                        break;
                    case 30:
                        VCGKeEdfAXXRrdsg(mediaSessionCompat$Callback, message.arg1);
                        break;
                    case 31:
                        BsDMHUyGmSGjlQZr(mediaSessionCompat$Callback, (android.support.v4.media.RatingCompat) message.obj, bundleROlbUZKzFxbHALSR);
                        break;
                }
                XwgdjzIxdPhbJotj(this.this$0, null);
            } catch (java.lang.Exception th) {
                beCqaAWSIXknzTPl(this.this$0, null);
                throw th;
            }
        }
    }
}

