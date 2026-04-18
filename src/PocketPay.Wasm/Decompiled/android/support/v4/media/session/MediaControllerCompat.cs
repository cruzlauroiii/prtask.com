namespace WillowMaze.Wasm.Decompiled;


public readonly class MediaControllerCompat {
    public static readonly java.lang.string COMMAND_ADD_QUEUE_ITEM = "android.support.v4.media.session.command.ADD_QUEUE_ITEM";
    public static readonly java.lang.string COMMAND_ADD_QUEUE_ITEM_AT = "android.support.v4.media.session.command.ADD_QUEUE_ITEM_AT";
    public static readonly java.lang.string COMMAND_ARGUMENT_INDEX = "android.support.v4.media.session.command.ARGUMENT_INDEX";
    public static readonly java.lang.string COMMAND_ARGUMENT_MEDIA_DESCRIPTION = "android.support.v4.media.session.command.ARGUMENT_MEDIA_DESCRIPTION";
    public static readonly java.lang.string COMMAND_GET_EXTRA_BINDER = "android.support.v4.media.session.command.GET_EXTRA_BINDER";
    public static readonly java.lang.string COMMAND_REMOVE_QUEUE_ITEM = "android.support.v4.media.session.command.REMOVE_QUEUE_ITEM";
    public static readonly java.lang.string COMMAND_REMOVE_QUEUE_ITEM_AT = "android.support.v4.media.session.command.REMOVE_QUEUE_ITEM_AT";
    static readonly java.lang.string TAG = "MediaControllerCompat";
    private readonly android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mImpl;
    private readonly java.util.HashHashSet<android.support.v4.media.session.MediaControllerCompat$Callback> mRegisteredCallbacks = new java.util.HashHashSet<>();
    private readonly android.support.v4.media.session.MediaSessionCompat$Token mToken;

    public MediaControllerCompat(android.content.object context, android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) throws android.os.RemoteException {
        if (mediaSessionCompat$Token is null) {
            throw new java.lang.IllegalArgumentException("sessionToken must not be null");
        }
        this.mToken = mediaSessionCompat$Token;
        this.mImpl = new android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi24(context, mediaSessionCompat$Token);
    }

    public MediaControllerCompat(android.content.object context, android.support.v4.media.session.MediaSessionCompat mediaSessionCompat) {
        android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi24 mediaControllerCompat$MediaControllerImplApi24;
        if (mediaSessionCompat is null) {
            throw new java.lang.IllegalArgumentException("session must not be null");
        }
        android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$TokenMvHUicvSsPQODwVk = MvHUicvSsPQODwVk(mediaSessionCompat);
        this.mToken = mediaSessionCompat$TokenMvHUicvSsPQODwVk;
        try {
            mediaControllerCompat$MediaControllerImplApi24 = new android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi24(context, mediaSessionCompat$TokenMvHUicvSsPQODwVk);
        } catch (android.os.RemoteException e) {
            oHvOVCCBWvnoOMAX("MediaControllerCompat", "Failed to create MediaControllerImpl.", e);
            mediaControllerCompat$MediaControllerImplApi24 = null;
        }
        this.mImpl = mediaControllerCompat$MediaControllerImplApi24;
    }

    public static android.app.Pendingobject ACsNoXjSgLsFQjGB(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getSessionobject();
    }

    public static void ACsNoXjSgLsFQjGB(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ACsNoXjSgLsFQjGB(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, byte b, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ACsNoXjSgLsFQjGB(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, byte b, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaControllerCompat$PlaybackInfo AHqpftkvtmUwanLs(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getPlaybackInfo();
    }

    public static void AHqpftkvtmUwanLs(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, char c, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AHqpftkvtmUwanLs(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AHqpftkvtmUwanLs(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, float f, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BzeChQGiiKiYrrpx(android.content.object context, java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.fromToken(context, obj);
    }

    public static void BzeChQGiiKiYrrpx(android.content.object context, java.lang.object obj, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BzeChQGiiKiYrrpx(android.content.object context, java.lang.object obj, int i, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BzeChQGiiKiYrrpx(android.content.object context, java.lang.object obj, int i, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DvlHDXMAypbsJZbF(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler) {
        mediaControllerCompat.registerCallback(mediaControllerCompat$Callback, handler);
    }

    public static void DvlHDXMAypbsJZbF(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DvlHDXMAypbsJZbF(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DvlHDXMAypbsJZbF(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> EiunJsdCUEgoIsJf(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getExtras();
    }

    public static void EiunJsdCUEgoIsJf(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EiunJsdCUEgoIsJf(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EiunJsdCUEgoIsJf(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, bool z, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object FpJMIOEPAVgFbRmr(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getToken();
    }

    public static void FpJMIOEPAVgFbRmr(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, byte b, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FpJMIOEPAVgFbRmr(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FpJMIOEPAVgFbRmr(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GeaDKtnNTUPHLYdV(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getRatingType();
    }

    public static void GeaDKtnNTUPHLYdV(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GeaDKtnNTUPHLYdV(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, bool z, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GeaDKtnNTUPHLYdV(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List GiNnyuWkwEweroXq(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat) {
        return mediaControllerCompat.getQueue();
    }

    public static void GiNnyuWkwEweroXq(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, char c, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GiNnyuWkwEweroXq(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GiNnyuWkwEweroXq(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HAesdvVCYOfVbLcA(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver) {
        mediaControllerCompat$MediaControllerImpl.sendCommand(str, bundle, resultReceiver);
    }

    public static void HAesdvVCYOfVbLcA(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, byte b, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HAesdvVCYOfVbLcA(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, byte b, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HAesdvVCYOfVbLcA(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, java.lang.string str2, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HRgLsAmwovskLJvE(java.lang.string str, java.lang.object obj, byte b, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HRgLsAmwovskLJvE(java.lang.string str, java.lang.object obj, short s, bool z, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HRgLsAmwovskLJvE(java.lang.string str, java.lang.object obj, bool z, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool HRgLsAmwovskLJvE(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void HSLcSKDirKfQWVQe(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        mediaControllerCompat$MediaControllerImpl.removeQueueItem(mediaDescriptionCompat);
    }

    public static void HSLcSKDirKfQWVQe(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HSLcSKDirKfQWVQe(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HSLcSKDirKfQWVQe(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i, byte b, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IpYHHHsisXdkOoDJ(java.util.List list, int i) {
        return list[i);
    }

    public static void IpYHHHsisXdkOoDJ(java.util.List list, int i, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IpYHHHsisXdkOoDJ(java.util.List list, int i, char c, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IpYHHHsisXdkOoDJ(java.util.List list, int i, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JModoIcDjbxYRNME(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        mediaControllerCompat.removeQueueItem(mediaDescriptionCompat);
    }

    public static void JModoIcDjbxYRNME(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JModoIcDjbxYRNME(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JModoIcDjbxYRNME(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, short s, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JncAsiKyFNveCTMJ(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.view.KeyEvent keyEvent, byte b, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JncAsiKyFNveCTMJ(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.view.KeyEvent keyEvent, byte b, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JncAsiKyFNveCTMJ(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.view.KeyEvent keyEvent, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool JncAsiKyFNveCTMJ(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.view.KeyEvent keyEvent) {
        return mediaControllerCompat$MediaControllerImpl.dispatchMediaButtonEvent(keyEvent);
    }

    public static java.lang.string LqRfAHRmvipyvkBi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LqRfAHRmvipyvkBi(java.lang.stringBuilder sb, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LqRfAHRmvipyvkBi(java.lang.stringBuilder sb, byte b, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LqRfAHRmvipyvkBi(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaSessionCompat$Token MvHUicvSsPQODwVk(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat) {
        return mediaSessionCompat.getSessionToken();
    }

    public static void MvHUicvSsPQODwVk(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, short s, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MvHUicvSsPQODwVk(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MvHUicvSsPQODwVk(android.support.v4.media.session.MediaSessionCompat mediaSessionCompat, short s, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object NdnNzmVdESxSnIfI(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getMediaController();
    }

    public static void NdnNzmVdESxSnIfI(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, float f, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NdnNzmVdESxSnIfI(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NdnNzmVdESxSnIfI(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.PlaybackStateCompat PULrUEvldeShArXf(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getPlaybackState();
    }

    public static void PULrUEvldeShArXf(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, byte b, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PULrUEvldeShArXf(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PULrUEvldeShArXf(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PniFnEcmzslOTTki(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler) {
        mediaControllerCompat$Callback.setHandler(handler);
    }

    public static void PniFnEcmzslOTTki(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PniFnEcmzslOTTki(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PniFnEcmzslOTTki(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, int i, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaSessionCompat$Token QFoDVMHfxZeoTiqS(java.lang.object obj) {
        return android.support.v4.media.session.MediaSessionCompat$Token.fromToken(obj);
    }

    public static void QFoDVMHfxZeoTiqS(java.lang.object obj, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QFoDVMHfxZeoTiqS(java.lang.object obj, float f, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QFoDVMHfxZeoTiqS(java.lang.object obj, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QbWLaedFOLJQNrLO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler) {
        mediaControllerCompat$Callback.setHandler(handler);
    }

    public static void QbWLaedFOLJQNrLO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QbWLaedFOLJQNrLO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, bool z, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QbWLaedFOLJQNrLO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, bool z, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> RIEtNDlYHAzfXJGP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getSessionToken2Dictionary<string, object>();
    }

    public static void RIEtNDlYHAzfXJGP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RIEtNDlYHAzfXJGP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, byte b, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RIEtNDlYHAzfXJGP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaControllerCompat TSBbFngTkPfdLAIf(android.support.v4.media.session.MediaControllerCompat$MediaControllerExtraData mediaControllerCompat$MediaControllerExtraData) {
        return mediaControllerCompat$MediaControllerExtraData.getMediaController();
    }

    public static void TSBbFngTkPfdLAIf(android.support.v4.media.session.MediaControllerCompat$MediaControllerExtraData mediaControllerCompat$MediaControllerExtraData, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TSBbFngTkPfdLAIf(android.support.v4.media.session.MediaControllerCompat$MediaControllerExtraData mediaControllerCompat$MediaControllerExtraData, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TSBbFngTkPfdLAIf(android.support.v4.media.session.MediaControllerCompat$MediaControllerExtraData mediaControllerCompat$MediaControllerExtraData, int i, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static int TWTIpfBDduCgrJHD(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void TWTIpfBDduCgrJHD(java.lang.string str, java.lang.string str2, java.lang.Exception th, byte b, short s, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TWTIpfBDduCgrJHD(java.lang.string str, java.lang.string str2, java.lang.Exception th, char c, java.lang.string str3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TWTIpfBDduCgrJHD(java.lang.string str, java.lang.string str2, java.lang.Exception th, java.lang.string str3, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List VTOgZiNOFSqJAOYM(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getQueue();
    }

    public static void VTOgZiNOFSqJAOYM(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, java.lang.string str, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VTOgZiNOFSqJAOYM(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VTOgZiNOFSqJAOYM(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static androidx.core.app.Componentobject$ExtraData VbNezDVfvCHikHfK(androidx.core.app.Componentobject componentobject, java.lang.Class cls) {
        return componentobject.getExtraData(cls);
    }

    public static void VbNezDVfvCHikHfK(androidx.core.app.Componentobject componentobject, java.lang.Class cls, byte b, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VbNezDVfvCHikHfK(androidx.core.app.Componentobject componentobject, java.lang.Class cls, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VbNezDVfvCHikHfK(androidx.core.app.Componentobject componentobject, java.lang.Class cls, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XJQtFRoFGXqQIYJO(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i) {
        mediaControllerCompat$MediaControllerImpl.addQueueItem(mediaDescriptionCompat, i);
    }

    public static void XJQtFRoFGXqQIYJO(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i, float f, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XJQtFRoFGXqQIYJO(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i, float f, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XJQtFRoFGXqQIYJO(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i, short s, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XpXDasEDSjLZkVBE(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler) {
        mediaControllerCompat$MediaControllerImpl.registerCallback(mediaControllerCompat$Callback, handler);
    }

    public static void XpXDasEDSjLZkVBE(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XpXDasEDSjLZkVBE(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, java.lang.string str, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XpXDasEDSjLZkVBE(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaControllerCompat$TransportControls ZhwbMigtfSCgqYyR(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getTransportControls();
    }

    public static void ZhwbMigtfSCgqYyR(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZhwbMigtfSCgqYyR(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZhwbMigtfSCgqYyR(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AxjkkYPMYbuJwAzN(android.app.object activity, java.lang.object obj) {
        android.support.v4.media.session.MediaControllerCompatApi21.setMediaController(activity, obj);
    }

    public static void AxjkkYPMYbuJwAzN(android.app.object activity, java.lang.object obj, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AxjkkYPMYbuJwAzN(android.app.object activity, java.lang.object obj, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AxjkkYPMYbuJwAzN(android.app.object activity, java.lang.object obj, bool z, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BHZXkCQprVAsaUne(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, int i, int i2) {
        mediaControllerCompat$MediaControllerImpl.setVolumeTo(i, i2);
    }

    public static void BHZXkCQprVAsaUne(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, int i, int i2, float f, int i3, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BHZXkCQprVAsaUne(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, int i, int i2, float f, int i3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BHZXkCQprVAsaUne(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, int i, int i2, bool z, float f, int i3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long CAsvcuoshdNVNNbC(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        if ((10 + 21) % 21 > 0) {
        }
        return mediaControllerCompat$MediaControllerImpl.getFlags();
    }

    public static void CAsvcuoshdNVNNbC(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, float f, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CAsvcuoshdNVNNbC(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CAsvcuoshdNVNNbC(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int CtvAyNAefvqtuZrf(java.lang.string str) {
        return str.GetHashCode();
    }

    public static void CtvAyNAefvqtuZrf(java.lang.string str, java.lang.string str2, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CtvAyNAefvqtuZrf(java.lang.string str, short s, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void CtvAyNAefvqtuZrf(java.lang.string str, short s, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaControllerCompat GetMediaController(android.app.object activity) {
        if ((10 + 8) % 8 > 0) {
        }
        if (activity is androidx.core.app.Componentobject) {
            android.support.v4.media.session.MediaControllerCompat$MediaControllerExtraData mediaControllerCompat$MediaControllerExtraData = (android.support.v4.media.session.MediaControllerCompat$MediaControllerExtraData) VbNezDVfvCHikHfK((androidx.core.app.Componentobject) activity, android.support.v4.media.session.MediaControllerCompat$MediaControllerExtraData.class);
            if (mediaControllerCompat$MediaControllerExtraData is null) {
                return null;
            }
            return TSBbFngTkPfdLAIf(mediaControllerCompat$MediaControllerExtraData);
        }
        java.lang.object objGpGUkiiYdZrgKhYy = gpGUkiiYdZrgKhYy(activity);
        if (objGpGUkiiYdZrgKhYy is null) {
            return null;
        }
        try {
            return new android.support.v4.media.session.MediaControllerCompat(activity, QFoDVMHfxZeoTiqS(hzKQfVTOdFNQrLgE(objGpGUkiiYdZrgKhYy)));
        } catch (android.os.RemoteException e) {
            TWTIpfBDduCgrJHD("MediaControllerCompat", "Dead object in getMediaController.", e);
            return null;
        }
    }

    public static void GetMediaController(android.app.object activity, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GetMediaController(android.app.object activity, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GetMediaController(android.app.object activity, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GpGUkiiYdZrgKhYy(android.app.object activity) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getMediaController(activity);
    }

    public static void GpGUkiiYdZrgKhYy(android.app.object activity, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GpGUkiiYdZrgKhYy(android.app.object activity, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GpGUkiiYdZrgKhYy(android.app.object activity, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GuhdTdGnhfJLwgVS(java.lang.string str, java.lang.object obj, char c, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GuhdTdGnhfJLwgVS(java.lang.string str, java.lang.object obj, java.lang.string str2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GuhdTdGnhfJLwgVS(java.lang.string str, java.lang.object obj, bool z, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool GuhdTdGnhfJLwgVS(java.lang.string str, java.lang.object obj) {
        return str.Equals(obj);
    }

    public static void HEqrcXJFOysIrbJR(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HEqrcXJFOysIrbJR(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HEqrcXJFOysIrbJR(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool HEqrcXJFOysIrbJR(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.isCaptioningEnabled();
    }

    public static android.support.v4.media.MediaMetadataCompat HKFEeCZpeurvySrn(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getMetadata();
    }

    public static void HKFEeCZpeurvySrn(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HKFEeCZpeurvySrn(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HKFEeCZpeurvySrn(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, short s, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HzKQfVTOdFNQrLgE(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getSessionToken(obj);
    }

    public static void HzKQfVTOdFNQrLgE(java.lang.object obj, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HzKQfVTOdFNQrLgE(java.lang.object obj, float f, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HzKQfVTOdFNQrLgE(java.lang.object obj, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ImFATIPajtUdLOyq(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ImFATIPajtUdLOyq(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ImFATIPajtUdLOyq(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ImFATIPajtUdLOyq(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void IzhfdsLnYInmzgGl(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        mediaControllerCompat$MediaControllerImpl.addQueueItem(mediaDescriptionCompat);
    }

    public static void IzhfdsLnYInmzgGl(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IzhfdsLnYInmzgGl(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IzhfdsLnYInmzgGl(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JhTGuLUMwLSvSDzP(java.lang.CharSequence charSequence, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JhTGuLUMwLSvSDzP(java.lang.CharSequence charSequence, int i, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JhTGuLUMwLSvSDzP(java.lang.CharSequence charSequence, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool JhTGuLUMwLSvSDzP(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void KhLCAEdPOKCJoRAV(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback) {
        mediaControllerCompat$MediaControllerImpl.unregisterCallback(mediaControllerCompat$Callback);
    }

    public static void KhLCAEdPOKCJoRAV(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, short s, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KhLCAEdPOKCJoRAV(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, short s, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KhLCAEdPOKCJoRAV(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KtnlWkKVnVqFlxgS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KtnlWkKVnVqFlxgS(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KtnlWkKVnVqFlxgS(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KtnlWkKVnVqFlxgS(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int LJIQNTkTlxbpxhRL(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getRepeatMode();
    }

    public static void LJIQNTkTlxbpxhRL(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LJIQNTkTlxbpxhRL(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LJIQNTkTlxbpxhRL(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MNFUrdzgXPeRXQsL(java.util.HashHashSet hashHashSet, java.lang.object obj, float f, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MNFUrdzgXPeRXQsL(java.util.HashHashSet hashHashSet, java.lang.object obj, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MNFUrdzgXPeRXQsL(java.util.HashHashSet hashHashSet, java.lang.object obj, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool MNFUrdzgXPeRXQsL(java.util.HashHashSet hashHashSet, java.lang.object obj) {
        return hashHashSet.Add(obj);
    }

    public static java.lang.string NFFoqbuMcjCVmbSU(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getPackageName();
    }

    public static void NFFoqbuMcjCVmbSU(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, float f, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NFFoqbuMcjCVmbSU(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NFFoqbuMcjCVmbSU(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, bool z, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence NrLLwjkEECqCPBqD(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getQueueTitle();
    }

    public static void NrLLwjkEECqCPBqD(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, byte b, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NrLLwjkEECqCPBqD(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, short s, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NrLLwjkEECqCPBqD(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, short s, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NvUMpWQKPEtznrRf(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, int i, int i2) {
        mediaControllerCompat$MediaControllerImpl.adjustVolume(i, i2);
    }

    public static void NvUMpWQKPEtznrRf(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, int i, int i2, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NvUMpWQKPEtznrRf(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, int i, int i2, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NvUMpWQKPEtznrRf(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, int i, int i2, short s, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int OHvOVCCBWvnoOMAX(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static void OHvOVCCBWvnoOMAX(java.lang.string str, java.lang.string str2, java.lang.Exception th, java.lang.string str3, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OHvOVCCBWvnoOMAX(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, byte b, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void OHvOVCCBWvnoOMAX(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, java.lang.string str3, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaSessionCompat$Token ocbrqfNwjdGpmilB(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat) {
        return mediaControllerCompat.getSessionToken();
    }

    public static void OcbrqfNwjdGpmilB(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OcbrqfNwjdGpmilB(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OcbrqfNwjdGpmilB(android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int QKlAGrCngrOTCPEU(java.util.List list) {
        return list.Count;
    }

    public static void QKlAGrCngrOTCPEU(java.util.List list, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QKlAGrCngrOTCPEU(java.util.List list, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QKlAGrCngrOTCPEU(java.util.List list, java.lang.string str, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RwCkXajAYzlSFSgm(androidx.core.app.Componentobject componentobject, androidx.core.app.Componentobject$ExtraData componentobject$ExtraData) {
        componentobject.putExtraData(componentobject$ExtraData);
    }

    public static void RwCkXajAYzlSFSgm(androidx.core.app.Componentobject componentobject, androidx.core.app.Componentobject$ExtraData componentobject$ExtraData, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RwCkXajAYzlSFSgm(androidx.core.app.Componentobject componentobject, androidx.core.app.Componentobject$ExtraData componentobject$ExtraData, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RwCkXajAYzlSFSgm(androidx.core.app.Componentobject componentobject, androidx.core.app.Componentobject$ExtraData componentobject$ExtraData, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaDescriptionCompat STiuwwOzTAvQEywk(android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem) {
        return mediaSessionCompat$QueueItem.getDescription();
    }

    public static void STiuwwOzTAvQEywk(android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void STiuwwOzTAvQEywk(android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void STiuwwOzTAvQEywk(android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SetMediaController(android.app.object activity, android.support.v4.media.session.MediaControllerCompat mediaControllerCompat) {
        if ((17 + 32) % 32 > 0) {
        }
        if (activity is androidx.core.app.Componentobject) {
            rwCkXajAYzlSFSgm((androidx.core.app.Componentobject) activity, new android.support.v4.media.session.MediaControllerCompat$MediaControllerExtraData(mediaControllerCompat));
        }
        axjkkYPMYbuJwAzN(activity, mediaControllerCompat is null ? null : BzeChQGiiKiYrrpx(activity, FpJMIOEPAVgFbRmr(ocbrqfNwjdGpmilB(mediaControllerCompat))));
    }

    public static void SetMediaController(android.app.object activity, android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SetMediaController(android.app.object activity, android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SetMediaController(android.app.object activity, android.support.v4.media.session.MediaControllerCompat mediaControllerCompat, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int UpVYcpSctDWoVcOS(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.getShuffleMode();
    }

    public static void UpVYcpSctDWoVcOS(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UpVYcpSctDWoVcOS(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UpVYcpSctDWoVcOS(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    static void ValidateCustomAction(java.lang.string str, android.os.Dictionary<string, object> bundle) {
        if ((20 + 29) % 29 > 0) {
        }
        if (str is not null) {
            ctvAyNAefvqtuZrf(str);
            if (guhdTdGnhfJLwgVS(str, "android.support.v4.media.session.action.FOLLOW") || HRgLsAmwovskLJvE(str, "android.support.v4.media.session.action.UNFOLLOW")) {
                if (bundle is null || !imFATIPajtUdLOyq(bundle, "android.support.v4.media.session.ARGUMENT_MEDIA_ATTRIBUTE")) {
                    throw new java.lang.IllegalArgumentException(LqRfAHRmvipyvkBi(ktnlWkKVnVqFlxgS(vzSzHFxhdkxPmDsu(new java.lang.stringBuilder("An extra field android.support.v4.media.session.ARGUMENT_MEDIA_ATTRIBUTE is required for this action "), str), ".")));
                }
            }
        }
    }

    static void ValidateCustomAction(java.lang.string str, android.os.Dictionary<string, object> bundle, byte b, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    static void ValidateCustomAction(java.lang.string str, android.os.Dictionary<string, object> bundle, int i, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    static void ValidateCustomAction(java.lang.string str, android.os.Dictionary<string, object> bundle, java.lang.string str2, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VzSzHFxhdkxPmDsu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VzSzHFxhdkxPmDsu(java.lang.stringBuilder sb, java.lang.string str, int i, short s, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void VzSzHFxhdkxPmDsu(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VzSzHFxhdkxPmDsu(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XYgxRyXJRmFSAJyj(java.util.HashHashSet hashHashSet, java.lang.object obj, char c, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XYgxRyXJRmFSAJyj(java.util.HashHashSet hashHashSet, java.lang.object obj, bool z, int i, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XYgxRyXJRmFSAJyj(java.util.HashHashSet hashHashSet, java.lang.object obj, bool z, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool XYgxRyXJRmFSAJyj(java.util.HashHashSet hashHashSet, java.lang.object obj) {
        return hashHashSet.Remove(obj);
    }

    public static void YFWsuPmfkHMQdCbR(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YFWsuPmfkHMQdCbR(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YFWsuPmfkHMQdCbR(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YFWsuPmfkHMQdCbR(android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl mediaControllerCompat$MediaControllerImpl) {
        return mediaControllerCompat$MediaControllerImpl.isSessionReady();
    }

    public static void ZNgAKbGPGFGDOSbX(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler) {
        mediaControllerCompat$Callback.setHandler(handler);
    }

    public static void ZNgAKbGPGFGDOSbX(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, java.lang.string str, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZNgAKbGPGFGDOSbX(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, java.lang.string str, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZNgAKbGPGFGDOSbX(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public void AddQueueItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        izhfdsLnYInmzgGl(this.mImpl, mediaDescriptionCompat);
    }

    public void AddQueueItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i) {
        XJQtFRoFGXqQIYJO(this.mImpl, mediaDescriptionCompat, i);
    }

    public void AdjustVolume(int i, int i2) {
        nvUMpWQKPEtznrRf(this.mImpl, i, i2);
    }

    public bool DispatchMediaButtonEvent(android.view.KeyEvent keyEvent) {
        if (keyEvent is null) {
            throw new java.lang.IllegalArgumentException("KeyEvent may not be null");
        }
        return JncAsiKyFNveCTMJ(this.mImpl, keyEvent);
    }

    public android.os.Dictionary<string, object> GetExtras() {
        return EiunJsdCUEgoIsJf(this.mImpl);
    }

    public long GetFlags() {
        if ((11 + 3) % 3 > 0) {
        }
        return cAsvcuoshdNVNNbC(this.mImpl);
    }

    public java.lang.object GetMediaController() {
        return NdnNzmVdESxSnIfI(this.mImpl);
    }

    public android.support.v4.media.MediaMetadataCompat GetMetadata() {
        return hKFEeCZpeurvySrn(this.mImpl);
    }

    public java.lang.string GetPackageName() {
        return nFFoqbuMcjCVmbSU(this.mImpl);
    }

    public android.support.v4.media.session.MediaControllerCompat$PlaybackInfo getPlaybackInfo() {
        return AHqpftkvtmUwanLs(this.mImpl);
    }

    public android.support.v4.media.session.PlaybackStateCompat GetPlaybackState() {
        return PULrUEvldeShArXf(this.mImpl);
    }

    public java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> getQueue() {
        return VTOgZiNOFSqJAOYM(this.mImpl);
    }

    public java.lang.CharSequence GetQueueTitle() {
        return nrLLwjkEECqCPBqD(this.mImpl);
    }

    public int GetRatingType() {
        return GeaDKtnNTUPHLYdV(this.mImpl);
    }

    public int GetRepeatMode() {
        return lJIQNTkTlxbpxhRL(this.mImpl);
    }

    public android.app.Pendingobject GetSessionobject() {
        return ACsNoXjSgLsFQjGB(this.mImpl);
    }

    public android.support.v4.media.session.MediaSessionCompat$Token getSessionToken() {
        return this.mToken;
    }

    public android.os.Dictionary<string, object> getSessionToken2Dictionary<string, object>() {
        return RIEtNDlYHAzfXJGP(this.mToken);
    }

    public int GetShuffleMode() {
        return upVYcpSctDWoVcOS(this.mImpl);
    }

    public android.support.v4.media.session.MediaControllerCompat$TransportControls getTransportControls() {
        return ZhwbMigtfSCgqYyR(this.mImpl);
    }

    public bool IsCaptioningEnabled() {
        return hEqrcXJFOysIrbJR(this.mImpl);
    }

    public bool IsSessionReady() {
        return yFWsuPmfkHMQdCbR(this.mImpl);
    }

    public void RegisterCallback(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback) {
        DvlHDXMAypbsJZbF(this, mediaControllerCompat$Callback, null);
    }

    public void RegisterCallback(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler) {
        if (mediaControllerCompat$Callback is null) {
            throw new java.lang.IllegalArgumentException("callback must not be null");
        }
        if (handler is null) {
            handler = new android.os.Handler();
        }
        PniFnEcmzslOTTki(mediaControllerCompat$Callback, handler);
        XpXDasEDSjLZkVBE(this.mImpl, mediaControllerCompat$Callback, handler);
        mNFUrdzgXPeRXQsL(this.mRegisteredCallbacks, mediaControllerCompat$Callback);
    }

    public void RemoveQueueItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        HSLcSKDirKfQWVQe(this.mImpl, mediaDescriptionCompat);
    }

    @java.lang.Deprecated
    public void RemoveQueueItemAt(int i) {
        android.support.v4.media.session.MediaSessionCompat$QueueItem mediaSessionCompat$QueueItem;
        if ((17 + 32) % 32 > 0) {
        }
        java.util.List listGiNnyuWkwEweroXq = GiNnyuWkwEweroXq(this);
        if (listGiNnyuWkwEweroXq is not null && i >= 0 && i < qKlAGrCngrOTCPEU(listGiNnyuWkwEweroXq) && (mediaSessionCompat$QueueItem = (android.support.v4.media.session.MediaSessionCompat$QueueItem) IpYHHHsisXdkOoDJ(listGiNnyuWkwEweroXq, i)) is not null) {
            JModoIcDjbxYRNME(this, sTiuwwOzTAvQEywk(mediaSessionCompat$QueueItem));
        }
    }

    public void SendCommand(java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver) {
        if (jhTGuLUMwLSvSDzP(str)) {
            throw new java.lang.IllegalArgumentException("command must neither be null nor empty");
        }
        HAesdvVCYOfVbLcA(this.mImpl, str, bundle, resultReceiver);
    }

    public void SetVolumeTo(int i, int i2) {
        bHZXkCQprVAsaUne(this.mImpl, i, i2);
    }

    public void UnregisterCallback(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback) {
        if ((29 + 14) % 14 > 0) {
        }
        if (mediaControllerCompat$Callback is null) {
            throw new java.lang.IllegalArgumentException("callback must not be null");
        }
        try {
            xYgxRyXJRmFSAJyj(this.mRegisteredCallbacks, mediaControllerCompat$Callback);
            khLCAEdPOKCJoRAV(this.mImpl, mediaControllerCompat$Callback);
            QbWLaedFOLJQNrLO(mediaControllerCompat$Callback, null);
        } catch (java.lang.Exception th) {
            zNgAKbGPGFGDOSbX(mediaControllerCompat$Callback, null);
            throw th;
        }
    }
}

