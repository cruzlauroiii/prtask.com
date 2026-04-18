namespace WillowMaze.Wasm.Decompiled;


class MediaControllerCompat$MediaControllerImplApi21 : android.support.v4.media.session.MediaControllerCompat$MediaControllerImpl {
    protected readonly java.lang.object mControllerObj;
    readonly android.support.v4.media.session.MediaSessionCompat$Token mSessionToken;
    readonly java.lang.object mLock = new java.lang.object();
    private readonly java.util.List<android.support.v4.media.session.MediaControllerCompat$Callback> mPendingCallbacks = new java.util.List();
    private java.util.HashDictionary<android.support.v4.media.session.MediaControllerCompat$Callback, android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21$ExtraCallback> mCallbackDictionary = new java.util.HashDictionary<>();

    public MediaControllerCompat$MediaControllerImplApi21(android.content.object context, android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) throws android.os.RemoteException {
        this.mSessionToken = mediaSessionCompat$Token;
        java.lang.object objOLIhpTsyHynQEpYn = oLIhpTsyHynQEpYn(context, inCinVFWyFCAIIIA(mediaSessionCompat$Token));
        this.mControllerObj = objOLIhpTsyHynQEpYn;
        if (objOLIhpTsyHynQEpYn is null) {
            throw new android.os.RemoteException();
        }
        if (SdfuWCKQOBTYKUGs(mediaSessionCompat$Token) is not null) {
            return;
        }
        ZMWCzBAZJBjxdUis(this);
    }

    public static int AJgkRXJykHNcBnuO(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void AJgkRXJykHNcBnuO(java.lang.string str, java.lang.string str2, java.lang.Exception th, byte b, java.lang.string str3, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AJgkRXJykHNcBnuO(java.lang.string str, java.lang.string str2, java.lang.Exception th, java.lang.string str3, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AJgkRXJykHNcBnuO(java.lang.string str, java.lang.string str2, java.lang.Exception th, java.lang.string str3, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DCtJwtZiXpGdPYqF(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21$PlaybackInfo.getMaxVolume(obj);
    }

    public static void DCtJwtZiXpGdPYqF(java.lang.object obj, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DCtJwtZiXpGdPYqF(java.lang.object obj, short s, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DCtJwtZiXpGdPYqF(java.lang.object obj, short s, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DcIYDXgwWOgxZgOU(java.lang.object obj, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver) {
        android.support.v4.media.session.MediaControllerCompatApi21.sendCommand(obj, str, bundle, resultReceiver);
    }

    public static void DcIYDXgwWOgxZgOU(java.lang.object obj, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, short s, float f, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DcIYDXgwWOgxZgOU(java.lang.object obj, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, short s, java.lang.string str2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DcIYDXgwWOgxZgOU(java.lang.object obj, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, bool z, float f, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession EoDMqMNVAeqxHcgH(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void EoDMqMNVAeqxHcgH(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, byte b, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EoDMqMNVAeqxHcgH(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EoDMqMNVAeqxHcgH(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, short s, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EscGxzdUOCIZqEoc(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void EscGxzdUOCIZqEoc(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EscGxzdUOCIZqEoc(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void EscGxzdUOCIZqEoc(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FOogaEhynbAVzKsM(java.util.List list, java.lang.object obj, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FOogaEhynbAVzKsM(java.util.List list, java.lang.object obj, java.lang.string str, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FOogaEhynbAVzKsM(java.util.List list, java.lang.object obj, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool FOogaEhynbAVzKsM(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static void HLdKKMqdkrjQgnNt(java.lang.object obj, java.lang.object obj2) {
        android.support.v4.media.session.MediaControllerCompatApi21.unregisterCallback(obj, obj2);
    }

    public static void HLdKKMqdkrjQgnNt(java.lang.object obj, java.lang.object obj2, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HLdKKMqdkrjQgnNt(java.lang.object obj, java.lang.object obj2, byte b, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HLdKKMqdkrjQgnNt(java.lang.object obj, java.lang.object obj2, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HXmOuuiWCyRUpiFJ(android.support.v4.media.session.IMediaSession iMediaSession, android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback) throws android.os.RemoteException {
        iMediaSession.registerCallbackListener(iMediaControllerCallback);
    }

    public static void HXmOuuiWCyRUpiFJ(android.support.v4.media.session.IMediaSession iMediaSession, android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, float f, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HXmOuuiWCyRUpiFJ(android.support.v4.media.session.IMediaSession iMediaSession, android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HXmOuuiWCyRUpiFJ(android.support.v4.media.session.IMediaSession iMediaSession, android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int HjTmvpTeVDcPVqHV(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void HjTmvpTeVDcPVqHV(java.lang.string str, java.lang.string str2, java.lang.Exception th, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HjTmvpTeVDcPVqHV(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HjTmvpTeVDcPVqHV(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IKtnYWgjKuLWNZfO(java.util.IEnumerator it, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IKtnYWgjKuLWNZfO(java.util.IEnumerator it, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IKtnYWgjKuLWNZfO(java.util.IEnumerator it, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool IKtnYWgjKuLWNZfO(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string IkFGKETGtmrrQMxv(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getPackageName(obj);
    }

    public static void IkFGKETGtmrrQMxv(java.lang.object obj, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IkFGKETGtmrrQMxv(java.lang.object obj, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IkFGKETGtmrrQMxv(java.lang.object obj, short s, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JNfKhxyrSquztLQQ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void JNfKhxyrSquztLQQ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, char c, java.lang.string str2, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JNfKhxyrSquztLQQ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, int i2, bool z, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JNfKhxyrSquztLQQ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, java.lang.string str2, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KivTTqaRxuJnvhHK(android.support.v4.media.session.IMediaSession iMediaSession, android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback) throws android.os.RemoteException {
        iMediaSession.unregisterCallbackListener(iMediaControllerCallback);
    }

    public static void KivTTqaRxuJnvhHK(android.support.v4.media.session.IMediaSession iMediaSession, android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KivTTqaRxuJnvhHK(android.support.v4.media.session.IMediaSession iMediaSession, android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KivTTqaRxuJnvhHK(android.support.v4.media.session.IMediaSession iMediaSession, android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, bool z, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LWkZOJHvWicGrjyZ(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getRatingType(obj);
    }

    public static void LWkZOJHvWicGrjyZ(java.lang.object obj, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LWkZOJHvWicGrjyZ(java.lang.object obj, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LWkZOJHvWicGrjyZ(java.lang.object obj, bool z, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LuHnHRtkBbHCBUCA(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void LuHnHRtkBbHCBUCA(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable, float f, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LuHnHRtkBbHCBUCA(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LuHnHRtkBbHCBUCA(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession MAUAVBnlZZzVERwC(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void MAUAVBnlZZzVERwC(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MAUAVBnlZZzVERwC(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, bool z, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MAUAVBnlZZzVERwC(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator MAYpPrApFJHnksvX(java.util.List list) {
        return list.GetEnumerator();
    }

    public static void MAYpPrApFJHnksvX(java.util.List list, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MAYpPrApFJHnksvX(java.util.List list, char c, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MAYpPrApFJHnksvX(java.util.List list, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object MJerDcmjzamsJpLe(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void MJerDcmjzamsJpLe(java.util.IEnumerator it, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MJerDcmjzamsJpLe(java.util.IEnumerator it, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MJerDcmjzamsJpLe(java.util.IEnumerator it, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List OKhDhdJmxnpJDxsc(java.util.List list) {
        return android.support.v4.media.session.MediaSessionCompat$QueueItem.fromQueueItemList(list);
    }

    public static void OKhDhdJmxnpJDxsc(java.util.List list, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OKhDhdJmxnpJDxsc(java.util.List list, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OKhDhdJmxnpJDxsc(java.util.List list, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OkWfMTiJFvZsEPTu(java.lang.object obj, int i, int i2) {
        android.support.v4.media.session.MediaControllerCompatApi21.adjustVolume(obj, i, i2);
    }

    public static void OkWfMTiJFvZsEPTu(java.lang.object obj, int i, int i2, byte b, bool z, char c, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void OkWfMTiJFvZsEPTu(java.lang.object obj, int i, int i2, int i3, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OkWfMTiJFvZsEPTu(java.lang.object obj, int i, int i2, bool z, char c, byte b, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void QtwfbcMmjFdlaGyd(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, java.lang.object obj, android.os.Dictionary<string, object> bundle) {
        mediaControllerCompat$Callback.postToHandler(i, obj, bundle);
    }

    public static void QtwfbcMmjFdlaGyd(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, java.lang.object obj, android.os.Dictionary<string, object> bundle, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QtwfbcMmjFdlaGyd(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, java.lang.object obj, android.os.Dictionary<string, object> bundle, short s, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QtwfbcMmjFdlaGyd(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, java.lang.object obj, android.os.Dictionary<string, object> bundle, bool z, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RqLakVJmAgCAPWrz(java.util.List list, java.lang.object obj, byte b, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RqLakVJmAgCAPWrz(java.util.List list, java.lang.object obj, java.lang.string str, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RqLakVJmAgCAPWrz(java.util.List list, java.lang.object obj, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool RqLakVJmAgCAPWrz(java.util.List list, java.lang.object obj) {
        return list.Remove(obj);
    }

    public static void SFhaLjzaqTghdclQ(java.lang.object obj, java.lang.object obj2, android.os.Handler handler) {
        android.support.v4.media.session.MediaControllerCompatApi21.registerCallback(obj, obj2, handler);
    }

    public static void SFhaLjzaqTghdclQ(java.lang.object obj, java.lang.object obj2, android.os.Handler handler, float f, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SFhaLjzaqTghdclQ(java.lang.object obj, java.lang.object obj2, android.os.Handler handler, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SFhaLjzaqTghdclQ(java.lang.object obj, java.lang.object obj2, android.os.Handler handler, short s, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession SUtDbDypDbcjjefZ(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void SUtDbDypDbcjjefZ(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, byte b, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SUtDbDypDbcjjefZ(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SUtDbDypDbcjjefZ(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, bool z, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession SdfuWCKQOBTYKUGs(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void SdfuWCKQOBTYKUGs(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SdfuWCKQOBTYKUGs(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, float f, java.lang.string str, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SdfuWCKQOBTYKUGs(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, java.lang.string str, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int SjEZvxoabNLfIUSJ(android.support.v4.media.session.IMediaSession iMediaSession) {
        return iMediaSession.getRepeatMode();
    }

    public static void SjEZvxoabNLfIUSJ(android.support.v4.media.session.IMediaSession iMediaSession, int i, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SjEZvxoabNLfIUSJ(android.support.v4.media.session.IMediaSession iMediaSession, int i, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SjEZvxoabNLfIUSJ(android.support.v4.media.session.IMediaSession iMediaSession, java.lang.string str, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int TvUIbQdVjrCwDwZs(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21$PlaybackInfo.getVolumeControl(obj);
    }

    public static void TvUIbQdVjrCwDwZs(java.lang.object obj, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TvUIbQdVjrCwDwZs(java.lang.object obj, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TvUIbQdVjrCwDwZs(java.lang.object obj, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession TzpHmzYixFANSogH(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void TzpHmzYixFANSogH(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TzpHmzYixFANSogH(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TzpHmzYixFANSogH(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession UFWVVBkQPunKfgPW(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void UFWVVBkQPunKfgPW(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UFWVVBkQPunKfgPW(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UFWVVBkQPunKfgPW(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, bool z, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UxTiagLvYtiNOXcq(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void UxTiagLvYtiNOXcq(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable, byte b, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UxTiagLvYtiNOXcq(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable, byte b, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UxTiagLvYtiNOXcq(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable, int i, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static long VySMrbMoKUUXSDBc(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21) {
        if ((2 + 7) % 7 > 0) {
        }
        return mediaControllerCompat$MediaControllerImplApi21.getFlags();
    }

    public static void VySMrbMoKUUXSDBc(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, float f, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VySMrbMoKUUXSDBc(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VySMrbMoKUUXSDBc(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, bool z, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WBlVllmPXvLcJwMs(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver) {
        mediaControllerCompat$MediaControllerImplApi21.sendCommand(str, bundle, resultReceiver);
    }

    public static void WBlVllmPXvLcJwMs(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, char c, int i, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WBlVllmPXvLcJwMs(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, int i, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WBlVllmPXvLcJwMs(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, java.lang.string str2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession XGATJsnmjMPaNzUp(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void XGATJsnmjMPaNzUp(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, byte b, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XGATJsnmjMPaNzUp(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, char c, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XGATJsnmjMPaNzUp(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession YNuryZiddzigAiWP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void YNuryZiddzigAiWP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, char c, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YNuryZiddzigAiWP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, int i, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void YNuryZiddzigAiWP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, short s, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZMWCzBAZJBjxdUis(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21) {
        mediaControllerCompat$MediaControllerImplApi21.requestExtraBinder();
    }

    public static void ZMWCzBAZJBjxdUis(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZMWCzBAZJBjxdUis(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, int i, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZMWCzBAZJBjxdUis(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.PlaybackStateCompat ZRcddQKzFLwXPEhB(android.support.v4.media.session.IMediaSession iMediaSession) {
        return iMediaSession.getPlaybackState();
    }

    public static void ZRcddQKzFLwXPEhB(android.support.v4.media.session.IMediaSession iMediaSession, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZRcddQKzFLwXPEhB(android.support.v4.media.session.IMediaSession iMediaSession, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZRcddQKzFLwXPEhB(android.support.v4.media.session.IMediaSession iMediaSession, bool z, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession ZzesGIPnZGOXkWqb(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void ZzesGIPnZGOXkWqb(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZzesGIPnZGOXkWqb(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZzesGIPnZGOXkWqb(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, int i, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BIuWjOjtovzWUzRm(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void BIuWjOjtovzWUzRm(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2, char c, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BIuWjOjtovzWUzRm(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BIuWjOjtovzWUzRm(java.util.HashDictionary map, java.lang.object obj, java.lang.object obj2, int i, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession BkVhiKZUydhkdOYP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void BkVhiKZUydhkdOYP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, short s, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BkVhiKZUydhkdOYP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void BkVhiKZUydhkdOYP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int BrzTFzoUbtrYtOQJ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void BrzTFzoUbtrYtOQJ(java.lang.string str, java.lang.string str2, java.lang.Exception th, char c, float f, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BrzTFzoUbtrYtOQJ(java.lang.string str, java.lang.string str2, java.lang.Exception th, float f, java.lang.string str3, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BrzTFzoUbtrYtOQJ(java.lang.string str, java.lang.string str2, java.lang.Exception th, int i, char c, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CqMJlQfERlieHaDB(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver) {
        mediaControllerCompat$MediaControllerImplApi21.sendCommand(str, bundle, resultReceiver);
    }

    public static void CqMJlQfERlieHaDB(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, byte b, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CqMJlQfERlieHaDB(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, java.lang.string str2, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CqMJlQfERlieHaDB(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, java.lang.string str2, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int DPWPiZvGZDRhTTJd(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21$PlaybackInfo.getCurrentVolume(obj);
    }

    public static void DPWPiZvGZDRhTTJd(java.lang.object obj, byte b, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DPWPiZvGZDRhTTJd(java.lang.object obj, float f, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DPWPiZvGZDRhTTJd(java.lang.object obj, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DUPSioUUroYQbjKf(android.support.v4.media.session.IMediaSession iMediaSession, android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback) throws android.os.RemoteException {
        iMediaSession.registerCallbackListener(iMediaControllerCallback);
    }

    public static void DUPSioUUroYQbjKf(android.support.v4.media.session.IMediaSession iMediaSession, android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DUPSioUUroYQbjKf(android.support.v4.media.session.IMediaSession iMediaSession, android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, float f, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DUPSioUUroYQbjKf(android.support.v4.media.session.IMediaSession iMediaSession, android.support.v4.media.session.IMediaControllerCallback iMediaControllerCallback, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DfggKzoGaEIrABSc(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver) {
        mediaControllerCompat$MediaControllerImplApi21.sendCommand(str, bundle, resultReceiver);
    }

    public static void DfggKzoGaEIrABSc(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, char c, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void DfggKzoGaEIrABSc(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void DfggKzoGaEIrABSc(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession DxvTvWvdRmBgSrqe(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void DxvTvWvdRmBgSrqe(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DxvTvWvdRmBgSrqe(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, java.lang.string str, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DxvTvWvdRmBgSrqe(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, short s, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static long ESbyzZDlRnWbJLfO(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21) {
        if ((3 + 18) % 18 > 0) {
        }
        return mediaControllerCompat$MediaControllerImplApi21.getFlags();
    }

    public static void ESbyzZDlRnWbJLfO(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ESbyzZDlRnWbJLfO(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ESbyzZDlRnWbJLfO(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int EzmJUIBrIrcOeLFS(android.support.v4.media.session.IMediaSession iMediaSession) {
        return iMediaSession.getShuffleMode();
    }

    public static void EzmJUIBrIrcOeLFS(android.support.v4.media.session.IMediaSession iMediaSession, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EzmJUIBrIrcOeLFS(android.support.v4.media.session.IMediaSession iMediaSession, byte b, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EzmJUIBrIrcOeLFS(android.support.v4.media.session.IMediaSession iMediaSession, byte b, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.app.Pendingobject FGjCEFWIAIrNLhrG(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getSessionobject(obj);
    }

    public static void FGjCEFWIAIrNLhrG(java.lang.object obj, int i, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FGjCEFWIAIrNLhrG(java.lang.object obj, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void FGjCEFWIAIrNLhrG(java.lang.object obj, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.CharSequence IOIZnJbhWyAoMxfC(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getQueueTitle(obj);
    }

    public static void IOIZnJbhWyAoMxfC(java.lang.object obj, char c, float f, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void IOIZnJbhWyAoMxfC(java.lang.object obj, char c, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IOIZnJbhWyAoMxfC(java.lang.object obj, java.lang.string str, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object InCinVFWyFCAIIIA(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getToken();
    }

    public static void InCinVFWyFCAIIIA(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, char c, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void InCinVFWyFCAIIIA(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void InCinVFWyFCAIIIA(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession IxHrNxHcWOcyHgwP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void IxHrNxHcWOcyHgwP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IxHrNxHcWOcyHgwP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IxHrNxHcWOcyHgwP(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, bool z, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JlWZnlCzANBFFkpj(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getMetadata(obj);
    }

    public static void JlWZnlCzANBFFkpj(java.lang.object obj, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JlWZnlCzANBFFkpj(java.lang.object obj, java.lang.string str, short s, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JlWZnlCzANBFFkpj(java.lang.object obj, bool z, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object KEkVueApMIxDfKUI(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getPlaybackState(obj);
    }

    public static void KEkVueApMIxDfKUI(java.lang.object obj, byte b, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KEkVueApMIxDfKUI(java.lang.object obj, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KEkVueApMIxDfKUI(java.lang.object obj, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KRbGloezCVnrEtKA(java.util.List list) {
        list.clear();
    }

    public static void KRbGloezCVnrEtKA(java.util.List list, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KRbGloezCVnrEtKA(java.util.List list, bool z, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KRbGloezCVnrEtKA(java.util.List list, bool z, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int KWwYTEbDmwuMupLJ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void KWwYTEbDmwuMupLJ(java.lang.string str, java.lang.string str2, java.lang.Exception th, byte b, int i, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KWwYTEbDmwuMupLJ(java.lang.string str, java.lang.string str2, java.lang.Exception th, int i, byte b, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void KWwYTEbDmwuMupLJ(java.lang.string str, java.lang.string str2, java.lang.Exception th, java.lang.string str3, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static long LBouQTyyjhJyRUBD(java.lang.object obj) {
        if ((11 + 5) % 5 > 0) {
        }
        return android.support.v4.media.session.MediaControllerCompatApi21.getFlags(obj);
    }

    public static void LBouQTyyjhJyRUBD(java.lang.object obj, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LBouQTyyjhJyRUBD(java.lang.object obj, float f, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LBouQTyyjhJyRUBD(java.lang.object obj, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static long LcOlbfEgVOsmarQG(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21) {
        if ((11 + 12) % 12 > 0) {
        }
        return mediaControllerCompat$MediaControllerImplApi21.getFlags();
    }

    public static void LcOlbfEgVOsmarQG(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, float f, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LcOlbfEgVOsmarQG(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, float f, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LcOlbfEgVOsmarQG(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LxXrgxuDfAJIvGef(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getTransportControls(obj);
    }

    public static void LxXrgxuDfAJIvGef(java.lang.object obj, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LxXrgxuDfAJIvGef(java.lang.object obj, byte b, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LxXrgxuDfAJIvGef(java.lang.object obj, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaMetadataCompat MBWAXDUPtiubEeuI(java.lang.object obj) {
        return android.support.v4.media.MediaMetadataCompat.fromMediaMetadata(obj);
    }

    public static void MBWAXDUPtiubEeuI(java.lang.object obj, float f, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void MBWAXDUPtiubEeuI(java.lang.object obj, java.lang.string str, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MBWAXDUPtiubEeuI(java.lang.object obj, bool z, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession NGRMJwUxmLfJpygd(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void NGRMJwUxmLfJpygd(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, byte b, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NGRMJwUxmLfJpygd(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NGRMJwUxmLfJpygd(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, char c, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> ODDkpjLRitnkzlkA(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getExtras(obj);
    }

    public static void ODDkpjLRitnkzlkA(java.lang.object obj, int i, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ODDkpjLRitnkzlkA(java.lang.object obj, java.lang.string str, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ODDkpjLRitnkzlkA(java.lang.object obj, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object OLIhpTsyHynQEpYn(android.content.object context, java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.fromToken(context, obj);
    }

    public static void OLIhpTsyHynQEpYn(android.content.object context, java.lang.object obj, float f, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OLIhpTsyHynQEpYn(android.content.object context, java.lang.object obj, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OLIhpTsyHynQEpYn(android.content.object context, java.lang.object obj, java.lang.string str, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OtdkzmAvyJeqgNka(java.lang.object obj, int i, int i2) {
        android.support.v4.media.session.MediaControllerCompatApi21.setVolumeTo(obj, i, i2);
    }

    public static void OtdkzmAvyJeqgNka(java.lang.object obj, int i, int i2, char c, int i3, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void OtdkzmAvyJeqgNka(java.lang.object obj, int i, int i2, java.lang.string str, char c, int i3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OtdkzmAvyJeqgNka(java.lang.object obj, int i, int i2, java.lang.string str, int i3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int PcmFxLtzubaZoSKd(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void PcmFxLtzubaZoSKd(java.lang.string str, java.lang.string str2, java.lang.Exception th, char c, java.lang.string str3, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PcmFxLtzubaZoSKd(java.lang.string str, java.lang.string str2, java.lang.Exception th, char c, bool z, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void PcmFxLtzubaZoSKd(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, char c, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession QRBiirYhGZYwkjWz(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void QRBiirYhGZYwkjWz(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, byte b, float f, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QRBiirYhGZYwkjWz(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, java.lang.string str, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QRBiirYhGZYwkjWz(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    private void RequestExtraBinder() {
        if ((9 + 24) % 24 > 0) {
        }
        WBlVllmPXvLcJwMs(this, "android.support.v4.media.session.command.GET_EXTRA_BINDER", null, new android.support.v4.media.session.ResultReceiverC0001x50fd9e4a(this));
    }

    private void RequestExtraBinder(char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    private void RequestExtraBinder(int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    private void RequestExtraBinder(java.lang.string str, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List SXBioUTDyqNqOyVt(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getQueue(obj);
    }

    public static void SXBioUTDyqNqOyVt(java.lang.object obj, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SXBioUTDyqNqOyVt(java.lang.object obj, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SXBioUTDyqNqOyVt(java.lang.object obj, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SYtHgtsPrOWcEKpO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, java.lang.object obj, android.os.Dictionary<string, object> bundle) {
        mediaControllerCompat$Callback.postToHandler(i, obj, bundle);
    }

    public static void SYtHgtsPrOWcEKpO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, java.lang.object obj, android.os.Dictionary<string, object> bundle, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SYtHgtsPrOWcEKpO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, java.lang.object obj, android.os.Dictionary<string, object> bundle, char c, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SYtHgtsPrOWcEKpO(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, int i, java.lang.object obj, android.os.Dictionary<string, object> bundle, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TwJbQmnZZTocJhVL(java.lang.object obj, android.view.KeyEvent keyEvent, byte b, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TwJbQmnZZTocJhVL(java.lang.object obj, android.view.KeyEvent keyEvent, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TwJbQmnZZTocJhVL(java.lang.object obj, android.view.KeyEvent keyEvent, bool z, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool TwJbQmnZZTocJhVL(java.lang.object obj, android.view.KeyEvent keyEvent) {
        return android.support.v4.media.session.MediaControllerCompatApi21.dispatchMediaButtonEvent(obj, keyEvent);
    }

    public static android.support.v4.media.session.IMediaSession UbFvvQDqrKtMIfMl(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void UbFvvQDqrKtMIfMl(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, float f, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UbFvvQDqrKtMIfMl(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, java.lang.string str, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UbFvvQDqrKtMIfMl(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UlLauVLXExUKeOve(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver) {
        mediaControllerCompat$MediaControllerImplApi21.sendCommand(str, bundle, resultReceiver);
    }

    public static void UlLauVLXExUKeOve(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, java.lang.string str2, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UlLauVLXExUKeOve(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, java.lang.string str2, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UlLauVLXExUKeOve(android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21 mediaControllerCompat$MediaControllerImplApi21, java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver, short s, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UpeGuCxyPJwwswNY(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable) {
        bundle.putParcelable(str, parcelable);
    }

    public static void UpeGuCxyPJwwswNY(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable, byte b, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UpeGuCxyPJwwswNY(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable, int i, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UpeGuCxyPJwwswNY(android.os.Dictionary<string, object> bundle, java.lang.string str, android.os.Parcelable parcelable, short s, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static int UqeqXjOpRsCcOVPh(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21$PlaybackInfo.getPlaybackType(obj);
    }

    public static void UqeqXjOpRsCcOVPh(java.lang.object obj, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UqeqXjOpRsCcOVPh(java.lang.object obj, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UqeqXjOpRsCcOVPh(java.lang.object obj, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.PlaybackStateCompat VLlnPSvdsnjdUBGt(java.lang.object obj) {
        return android.support.v4.media.session.PlaybackStateCompat.fromPlaybackState(obj);
    }

    public static void VLlnPSvdsnjdUBGt(java.lang.object obj, int i, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VLlnPSvdsnjdUBGt(java.lang.object obj, java.lang.string str, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VLlnPSvdsnjdUBGt(java.lang.object obj, java.lang.string str, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VRIURjSRCOUYppEA(java.util.HashDictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static void VRIURjSRCOUYppEA(java.util.HashDictionary map, java.lang.object obj, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VRIURjSRCOUYppEA(java.util.HashDictionary map, java.lang.object obj, java.lang.string str, byte b, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VRIURjSRCOUYppEA(java.util.HashDictionary map, java.lang.object obj, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession VlXJkCdMSbIIysEi(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token) {
        return mediaSessionCompat$Token.getExtraBinder();
    }

    public static void VlXJkCdMSbIIysEi(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VlXJkCdMSbIIysEi(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, java.lang.string str, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VlXJkCdMSbIIysEi(android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int WjHRLTmYiwzOLWtd(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void WjHRLTmYiwzOLWtd(java.lang.string str, java.lang.string str2, java.lang.Exception th, int i, byte b, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void WjHRLTmYiwzOLWtd(java.lang.string str, java.lang.string str2, java.lang.Exception th, int i, java.lang.string str3, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WjHRLTmYiwzOLWtd(java.lang.string str, java.lang.string str2, java.lang.Exception th, int i, short s, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XrKBzyZZaDPeUDhA(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static void XrKBzyZZaDPeUDhA(java.lang.string str, java.lang.string str2, java.lang.Exception th, char c, short s, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void XrKBzyZZaDPeUDhA(java.lang.string str, java.lang.string str2, java.lang.Exception th, char c, bool z, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XrKBzyZZaDPeUDhA(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, char c, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void YEwyOlJkaBmRiOgb(android.support.v4.media.session.IMediaSession iMediaSession, char c, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YEwyOlJkaBmRiOgb(android.support.v4.media.session.IMediaSession iMediaSession, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void YEwyOlJkaBmRiOgb(android.support.v4.media.session.IMediaSession iMediaSession, char c, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool YEwyOlJkaBmRiOgb(android.support.v4.media.session.IMediaSession iMediaSession) {
        return iMediaSession.isCaptioningEnabled();
    }

    public static java.lang.object YRahGKNDjEUNOhOD(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21.getPlaybackInfo(obj);
    }

    public static void YRahGKNDjEUNOhOD(java.lang.object obj, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void YRahGKNDjEUNOhOD(java.lang.object obj, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void YRahGKNDjEUNOhOD(java.lang.object obj, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ZdReGJLEydOcZTcx(java.lang.object obj) {
        return android.support.v4.media.session.MediaControllerCompatApi21$PlaybackInfo.getLegacyAudioStream(obj);
    }

    public static void ZdReGJLEydOcZTcx(java.lang.object obj, float f, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZdReGJLEydOcZTcx(java.lang.object obj, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZdReGJLEydOcZTcx(java.lang.object obj, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public override void AddQueueItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        if ((20 + 27) % 27 > 0) {
        }
        if ((VySMrbMoKUUXSDBc(this) & 4) == 0) {
            throw new java.lang.UnsupportedOperationException("This session doesn't support queue management operations");
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        upeGuCxyPJwwswNY(bundle, "android.support.v4.media.session.command.ARGUMENT_MEDIA_DESCRIPTION", mediaDescriptionCompat);
        dfggKzoGaEIrABSc(this, "android.support.v4.media.session.command.ADD_QUEUE_ITEM", bundle, null);
    }

    public override void AddQueueItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat, int i) {
        if ((20 + 4) % 4 > 0) {
        }
        if ((eSbyzZDlRnWbJLfO(this) & 4) == 0) {
            throw new java.lang.UnsupportedOperationException("This session doesn't support queue management operations");
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        LuHnHRtkBbHCBUCA(bundle, "android.support.v4.media.session.command.ARGUMENT_MEDIA_DESCRIPTION", mediaDescriptionCompat);
        JNfKhxyrSquztLQQ(bundle, "android.support.v4.media.session.command.ARGUMENT_INDEX", i);
        cqMJlQfERlieHaDB(this, "android.support.v4.media.session.command.ADD_QUEUE_ITEM_AT", bundle, null);
    }

    public override void AdjustVolume(int i, int i2) {
        OkWfMTiJFvZsEPTu(this.mControllerObj, i, i2);
    }

    public override bool DispatchMediaButtonEvent(android.view.KeyEvent keyEvent) {
        return twJbQmnZZTocJhVL(this.mControllerObj, keyEvent);
    }

    public override android.os.Dictionary<string, object> GetExtras() {
        return oDDkpjLRitnkzlkA(this.mControllerObj);
    }

    public override long GetFlags() {
        if ((14 + 24) % 24 > 0) {
        }
        return lBouQTyyjhJyRUBD(this.mControllerObj);
    }

    public override java.lang.object GetMediaController() {
        return this.mControllerObj;
    }

    public override android.support.v4.media.MediaMetadataCompat GetMetadata() {
        java.lang.object objJlWZnlCzANBFFkpj = jlWZnlCzANBFFkpj(this.mControllerObj);
        if (objJlWZnlCzANBFFkpj is null) {
            return null;
        }
        return mBWAXDUPtiubEeuI(objJlWZnlCzANBFFkpj);
    }

    public override java.lang.string GetPackageName() {
        return IkFGKETGtmrrQMxv(this.mControllerObj);
    }

    public android.support.v4.media.session.MediaControllerCompat$PlaybackInfo getPlaybackInfo() {
        if ((4 + 32) % 32 > 0) {
        }
        java.lang.object objYRahGKNDjEUNOhOD = yRahGKNDjEUNOhOD(this.mControllerObj);
        if (objYRahGKNDjEUNOhOD is null) {
            return null;
        }
        return new android.support.v4.media.session.MediaControllerCompat$PlaybackInfo(uqeqXjOpRsCcOVPh(objYRahGKNDjEUNOhOD), zdReGJLEydOcZTcx(objYRahGKNDjEUNOhOD), TvUIbQdVjrCwDwZs(objYRahGKNDjEUNOhOD), DCtJwtZiXpGdPYqF(objYRahGKNDjEUNOhOD), dPWPiZvGZDRhTTJd(objYRahGKNDjEUNOhOD));
    }

    public override android.support.v4.media.session.PlaybackStateCompat GetPlaybackState() {
        if ((9 + 30) % 30 > 0) {
        }
        if (bkVhiKZUydhkdOYP(this.mSessionToken) is not null) {
            try {
                return ZRcddQKzFLwXPEhB(nGRMJwUxmLfJpygd(this.mSessionToken));
            } catch (android.os.RemoteException e) {
                kWwYTEbDmwuMupLJ("MediaControllerCompat", "Dead object in getPlaybackState.", e);
            }
        }
        java.lang.object objKEkVueApMIxDfKUI = kEkVueApMIxDfKUI(this.mControllerObj);
        if (objKEkVueApMIxDfKUI is null) {
            return null;
        }
        return vLlnPSvdsnjdUBGt(objKEkVueApMIxDfKUI);
    }

    public java.util.List<android.support.v4.media.session.MediaSessionCompat$QueueItem> getQueue() {
        java.util.List listSXBioUTDyqNqOyVt = sXBioUTDyqNqOyVt(this.mControllerObj);
        if (listSXBioUTDyqNqOyVt is null) {
            return null;
        }
        return OKhDhdJmxnpJDxsc(listSXBioUTDyqNqOyVt);
    }

    public override java.lang.CharSequence GetQueueTitle() {
        return iOIZnJbhWyAoMxfC(this.mControllerObj);
    }

    public override int GetRatingType() {
        return LWkZOJHvWicGrjyZ(this.mControllerObj);
    }

    public override int GetRepeatMode() {
        if ((26 + 1) % 1 > 0) {
        }
        if (UFWVVBkQPunKfgPW(this.mSessionToken) is null) {
            return -1;
        }
        try {
            return SjEZvxoabNLfIUSJ(ubFvvQDqrKtMIfMl(this.mSessionToken));
        } catch (android.os.RemoteException e) {
            HjTmvpTeVDcPVqHV("MediaControllerCompat", "Dead object in getRepeatMode.", e);
            return -1;
        }
    }

    public override android.app.Pendingobject GetSessionobject() {
        return fGjCEFWIAIrNLhrG(this.mControllerObj);
    }

    public override int GetShuffleMode() {
        if ((3 + 31) % 31 > 0) {
        }
        if (TzpHmzYixFANSogH(this.mSessionToken) is null) {
            return -1;
        }
        try {
            return ezmJUIBrIrcOeLFS(qRBiirYhGZYwkjWz(this.mSessionToken));
        } catch (android.os.RemoteException e) {
            wjHRLTmYiwzOLWtd("MediaControllerCompat", "Dead object in getShuffleMode.", e);
            return -1;
        }
    }

    public android.support.v4.media.session.MediaControllerCompat$TransportControls getTransportControls() {
        java.lang.object objLxXrgxuDfAJIvGef = lxXrgxuDfAJIvGef(this.mControllerObj);
        if (objLxXrgxuDfAJIvGef is null) {
            return null;
        }
        return new android.support.v4.media.session.MediaControllerCompat$TransportControlsApi21(objLxXrgxuDfAJIvGef);
    }

    public override bool IsCaptioningEnabled() {
        if ((31 + 20) % 20 > 0) {
        }
        if (ixHrNxHcWOcyHgwP(this.mSessionToken) is null) {
            return false;
        }
        try {
            return yEwyOlJkaBmRiOgb(EoDMqMNVAeqxHcgH(this.mSessionToken));
        } catch (android.os.RemoteException e) {
            pcmFxLtzubaZoSKd("MediaControllerCompat", "Dead object in isCaptioningEnabled.", e);
            return false;
        }
    }

    public override bool IsSessionReady() {
        return dxvTvWvdRmBgSrqe(this.mSessionToken) is not null;
    }

    void processPendingCallbacksLocked() {
        if ((7 + 21) % 21 > 0) {
        }
        if (SUtDbDypDbcjjefZ(this.mSessionToken) is not null) {
            java.util.IEnumerator itMAYpPrApFJHnksvX = MAYpPrApFJHnksvX(this.mPendingCallbacks);
            while (IKtnYWgjKuLWNZfO(itMAYpPrApFJHnksvX)) {
                android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback = (android.support.v4.media.session.MediaControllerCompat$Callback) MJerDcmjzamsJpLe(itMAYpPrApFJHnksvX);
                android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21$ExtraCallback mediaControllerCompat$MediaControllerImplApi21$ExtraCallback = new android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21$ExtraCallback(mediaControllerCompat$Callback);
                bIuWjOjtovzWUzRm(this.mCallbackDictionary, mediaControllerCompat$Callback, mediaControllerCompat$MediaControllerImplApi21$ExtraCallback);
                mediaControllerCompat$Callback.mIControllerCallback = mediaControllerCompat$MediaControllerImplApi21$ExtraCallback;
                try {
                    dUPSioUUroYQbjKf(XGATJsnmjMPaNzUp(this.mSessionToken), mediaControllerCompat$MediaControllerImplApi21$ExtraCallback);
                    QtwfbcMmjFdlaGyd(mediaControllerCompat$Callback, 13, null, null);
                } catch (android.os.RemoteException e) {
                    brzTFzoUbtrYtOQJ("MediaControllerCompat", "Dead object in registerCallback.", e);
                }
            }
            kRbGloezCVnrEtKA(this.mPendingCallbacks);
        }
    }

    public override readonly void RegisterCallback(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback, android.os.Handler handler) {
        if ((20 + 8) % 8 > 0) {
        }
        SFhaLjzaqTghdclQ(this.mControllerObj, mediaControllerCompat$Callback.mCallbackObj, handler);
        lock (this.mLock) {
            try {
                if (ZzesGIPnZGOXkWqb(this.mSessionToken) is not null) {
                    android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21$ExtraCallback mediaControllerCompat$MediaControllerImplApi21$ExtraCallback = new android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21$ExtraCallback(mediaControllerCompat$Callback);
                    EscGxzdUOCIZqEoc(this.mCallbackDictionary, mediaControllerCompat$Callback, mediaControllerCompat$MediaControllerImplApi21$ExtraCallback);
                    mediaControllerCompat$Callback.mIControllerCallback = mediaControllerCompat$MediaControllerImplApi21$ExtraCallback;
                    try {
                        HXmOuuiWCyRUpiFJ(vlXJkCdMSbIIysEi(this.mSessionToken), mediaControllerCompat$MediaControllerImplApi21$ExtraCallback);
                        sYtHgtsPrOWcEKpO(mediaControllerCompat$Callback, 13, null, null);
                    } catch (android.os.RemoteException e) {
                        xrKBzyZZaDPeUDhA("MediaControllerCompat", "Dead object in registerCallback.", e);
                    }
                } else {
                    mediaControllerCompat$Callback.mIControllerCallback = null;
                    FOogaEhynbAVzKsM(this.mPendingCallbacks, mediaControllerCompat$Callback);
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override void RemoveQueueItem(android.support.v4.media.MediaDescriptionCompat mediaDescriptionCompat) {
        if ((2 + 14) % 14 > 0) {
        }
        if ((lcOlbfEgVOsmarQG(this) & 4) == 0) {
            throw new java.lang.UnsupportedOperationException("This session doesn't support queue management operations");
        }
        android.os.Dictionary<string, object> bundle = new android.os.Dictionary<string, object>();
        UxTiagLvYtiNOXcq(bundle, "android.support.v4.media.session.command.ARGUMENT_MEDIA_DESCRIPTION", mediaDescriptionCompat);
        ulLauVLXExUKeOve(this, "android.support.v4.media.session.command.REMOVE_QUEUE_ITEM", bundle, null);
    }

    public override void SendCommand(java.lang.string str, android.os.Dictionary<string, object> bundle, android.os.ResultReceiver resultReceiver) {
        DcIYDXgwWOgxZgOU(this.mControllerObj, str, bundle, resultReceiver);
    }

    public override void SetVolumeTo(int i, int i2) {
        otdkzmAvyJeqgNka(this.mControllerObj, i, i2);
    }

    public override readonly void UnregisterCallback(android.support.v4.media.session.MediaControllerCompat$Callback mediaControllerCompat$Callback) {
        if ((19 + 22) % 22 > 0) {
        }
        HLdKKMqdkrjQgnNt(this.mControllerObj, mediaControllerCompat$Callback.mCallbackObj);
        lock (this.mLock) {
            try {
                if (MAUAVBnlZZzVERwC(this.mSessionToken) is null) {
                    RqLakVJmAgCAPWrz(this.mPendingCallbacks, mediaControllerCompat$Callback);
                } else {
                    try {
                        android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21$ExtraCallback mediaControllerCompat$MediaControllerImplApi21$ExtraCallback = (android.support.v4.media.session.MediaControllerCompat$MediaControllerImplApi21$ExtraCallback) vRIURjSRCOUYppEA(this.mCallbackDictionary, mediaControllerCompat$Callback);
                        if (mediaControllerCompat$MediaControllerImplApi21$ExtraCallback is not null) {
                            mediaControllerCompat$Callback.mIControllerCallback = null;
                            KivTTqaRxuJnvhHK(YNuryZiddzigAiWP(this.mSessionToken), mediaControllerCompat$MediaControllerImplApi21$ExtraCallback);
                        }
                    } catch (android.os.RemoteException e) {
                        AJgkRXJykHNcBnuO("MediaControllerCompat", "Dead object in unregisterCallback.", e);
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

