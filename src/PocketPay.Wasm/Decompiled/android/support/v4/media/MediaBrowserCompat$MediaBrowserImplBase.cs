namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplBase : android.support.v4.media.MediaBrowserCompat$MediaBrowserImpl, android.support.v4.media.MediaBrowserCompat$MediaBrowserServiceCallbackImpl {
    static readonly int CONNECT_STATE_CONNECTED = 3;
    static readonly int CONNECT_STATE_CONNECTING = 2;
    static readonly int CONNECT_STATE_DISCONNECTED = 1;
    static readonly int CONNECT_STATE_DISCONNECTING = 0;
    static readonly int CONNECT_STATE_SUSPENDED = 4;
    readonly android.support.v4.media.MediaBrowserCompat$ConnectionCallback mCallback;
    android.os.Messenger mCallbacksMessenger;
    readonly android.content.object mobject;
    private android.os.Dictionary<string, object> mExtras;
    private android.support.v4.media.session.MediaSessionCompat$Token mMediaSessionToken;
    private android.os.Dictionary<string, object> mNotifyChildrenChangedOptions;
    readonly android.os.Dictionary<string, object> mRootHints;
    private java.lang.string mRootId;
    android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mServiceBinderWrapper;
    readonly android.content.ComponentName mServiceComponent;
    android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase$MediaServiceConnection mServiceConnection;
    readonly android.support.v4.media.MediaBrowserCompat$CallbackHandler mHandler = new android.support.v4.media.MediaBrowserCompat$CallbackHandler(this);
    private readonly androidx.collection.ArrayDictionary<java.lang.string, android.support.v4.media.MediaBrowserCompat$Subscription> mSubscriptions = new androidx.collection.ArrayDictionary<>();
    int mState = 1;

    public MediaBrowserCompat$MediaBrowserImplBase(android.content.object context, android.content.ComponentName componentName, android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, android.os.Dictionary<string, object> bundle) {
        if (context is null) {
            throw new java.lang.IllegalArgumentException("context must not be null");
        }
        if (componentName is null) {
            throw new java.lang.IllegalArgumentException("service component must not be null");
        }
        if (mediaBrowserCompat$ConnectionCallback is null) {
            throw new java.lang.IllegalArgumentException("connection callback must not be null");
        }
        this.mobject = context;
        this.mServiceComponent = componentName;
        this.mCallback = mediaBrowserCompat$ConnectionCallback;
        this.mRootHints = bundle is not null ? new android.os.Dictionary<string, object>(bundle) : null;
    }

    public static java.util.List APIIBoADTIEuqmEu(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription) {
        return mediaBrowserCompat$Subscription.getCallbacks();
    }

    public static void APIIBoADTIEuqmEu(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, int i, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void APIIBoADTIEuqmEu(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void APIIBoADTIEuqmEu(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, java.lang.string str, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AraiXwWrQmEdNAqx(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.search(str, bundle, resultReceiver, messenger);
    }

    public static void AraiXwWrQmEdNAqx(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, int i, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AraiXwWrQmEdNAqx(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, short s, int i, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AraiXwWrQmEdNAqx(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, short s, bool z, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void BVDnApHXvviBWvam(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, byte b, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BVDnApHXvviBWvam(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BVDnApHXvviBWvam(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, bool z, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool BVDnApHXvviBWvam(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase) {
        return mediaBrowserCompat$MediaBrowserImplBase.isConnected();
    }

    public static java.lang.stringBuilder CgDRdOnhsFYQAfYe(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void CgDRdOnhsFYQAfYe(java.lang.stringBuilder sb, java.lang.object obj, char c, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CgDRdOnhsFYQAfYe(java.lang.stringBuilder sb, java.lang.object obj, char c, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CgDRdOnhsFYQAfYe(java.lang.stringBuilder sb, java.lang.object obj, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string CrJhihyCpTHpoPCK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void CrJhihyCpTHpoPCK(java.lang.stringBuilder sb, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void CrJhihyCpTHpoPCK(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CrJhihyCpTHpoPCK(java.lang.stringBuilder sb, bool z, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DGNHaRmwGcnjYehO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DGNHaRmwGcnjYehO(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DGNHaRmwGcnjYehO(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DGNHaRmwGcnjYehO(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static int DQAUMfxWQkqOCsyB(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.i(str, str2, th);
    }

    public static void DQAUMfxWQkqOCsyB(java.lang.string str, java.lang.string str2, java.lang.Exception th, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DQAUMfxWQkqOCsyB(java.lang.string str, java.lang.string str2, java.lang.Exception th, float f, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DQAUMfxWQkqOCsyB(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DYDXIkpztzQfeBIl(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.sendCustomAction(str, bundle, resultReceiver, messenger);
    }

    public static void DYDXIkpztzQfeBIl(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, float f, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DYDXIkpztzQfeBIl(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, float f, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DYDXIkpztzQfeBIl(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, java.lang.string str2, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List DeAXCoRhNhibfVoX(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription) {
        return mediaBrowserCompat$Subscription.getCallbacks();
    }

    public static void DeAXCoRhNhibfVoX(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DeAXCoRhNhibfVoX(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DeAXCoRhNhibfVoX(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, short s, byte b, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object EgBDAUrxWXZbKHSy(java.util.List list, int i) {
        return list[i);
    }

    public static void EgBDAUrxWXZbKHSy(java.util.List list, int i, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EgBDAUrxWXZbKHSy(java.util.List list, int i, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EgBDAUrxWXZbKHSy(java.util.List list, int i, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EjxjeTMOCOWZqCNt(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void EjxjeTMOCOWZqCNt(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EjxjeTMOCOWZqCNt(java.lang.stringBuilder sb, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EjxjeTMOCOWZqCNt(java.lang.stringBuilder sb, short s, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EkWYhQDHSoPvauYm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EkWYhQDHSoPvauYm(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EkWYhQDHSoPvauYm(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EkWYhQDHSoPvauYm(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EpBVGfoPwCJuoEAO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EpBVGfoPwCJuoEAO(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EpBVGfoPwCJuoEAO(java.lang.stringBuilder sb, java.lang.string str, float f, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EpBVGfoPwCJuoEAO(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator FDzeGoIvizGSslZq(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void FDzeGoIvizGSslZq(java.util.HashSet set, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void FDzeGoIvizGSslZq(java.util.HashSet set, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FDzeGoIvizGSslZq(java.util.HashSet set, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int FWEdWhKsALedYIQX(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void FWEdWhKsALedYIQX(java.lang.string str, java.lang.string str2, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FWEdWhKsALedYIQX(java.lang.string str, java.lang.string str2, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FWEdWhKsALedYIQX(java.lang.string str, java.lang.string str2, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int FoPLfzAocelJEqdz(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void FoPLfzAocelJEqdz(java.lang.string str, java.lang.string str2, byte b, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FoPLfzAocelJEqdz(java.lang.string str, java.lang.string str2, int i, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FoPLfzAocelJEqdz(java.lang.string str, java.lang.string str2, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GFXzFQzMSegdiFuS(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase) {
        mediaBrowserCompat$MediaBrowserImplBase.forceCloseConnection();
    }

    public static void GFXzFQzMSegdiFuS(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GFXzFQzMSegdiFuS(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GFXzFQzMSegdiFuS(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, short s, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HcSFbChbJMLbredi(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HcSFbChbJMLbredi(java.lang.stringBuilder sb, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HcSFbChbJMLbredi(java.lang.stringBuilder sb, int i, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HcSFbChbJMLbredi(java.lang.stringBuilder sb, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HrYcuwBNRWleWfwH(int i) {
        return getStateLabel(i);
    }

    public static void HrYcuwBNRWleWfwH(int i, byte b, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void HrYcuwBNRWleWfwH(int i, char c, int i2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HrYcuwBNRWleWfwH(int i, int i2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int IBDWKGnmDqlEEcJp(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void IBDWKGnmDqlEEcJp(java.lang.string str, java.lang.string str2, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IBDWKGnmDqlEEcJp(java.lang.string str, java.lang.string str2, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IBDWKGnmDqlEEcJp(java.lang.string str, java.lang.string str2, bool z, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object IBRgBvfltcZMvIov(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void IBRgBvfltcZMvIov(java.util.IEnumerator it, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IBRgBvfltcZMvIov(java.util.IEnumerator it, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IBRgBvfltcZMvIov(java.util.IEnumerator it, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string IQmGXxgRaNvZbRXO(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void IQmGXxgRaNvZbRXO(java.lang.stringBuilder sb, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IQmGXxgRaNvZbRXO(java.lang.stringBuilder sb, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IQmGXxgRaNvZbRXO(java.lang.stringBuilder sb, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IjmwUNJXoqFJXfeO(android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback) {
        mediaBrowserCompat$ConnectionCallback.onConnected();
    }

    public static void IjmwUNJXoqFJXfeO(android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, char c, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IjmwUNJXoqFJXfeO(android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IjmwUNJXoqFJXfeO(android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static int JHtaShGRXRZHPGOo(java.util.List list) {
        return list.Count;
    }

    public static void JHtaShGRXRZHPGOo(java.util.List list, float f, java.lang.string str, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JHtaShGRXRZHPGOo(java.util.List list, int i, java.lang.string str, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JHtaShGRXRZHPGOo(java.util.List list, bool z, float f, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JWgQyEBDYPoduuhy(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, byte b, bool z, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JWgQyEBDYPoduuhy(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, float f, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void JWgQyEBDYPoduuhy(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool JWgQyEBDYPoduuhy(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static java.lang.string JaqFTPjgEUgHtInB(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void JaqFTPjgEUgHtInB(java.lang.stringBuilder sb, char c, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JaqFTPjgEUgHtInB(java.lang.stringBuilder sb, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JaqFTPjgEUgHtInB(java.lang.stringBuilder sb, bool z, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int JjfKXsVboxvwZmVw(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void JjfKXsVboxvwZmVw(java.lang.string str, java.lang.string str2, byte b, int i, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void JjfKXsVboxvwZmVw(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JjfKXsVboxvwZmVw(java.lang.string str, java.lang.string str2, java.lang.string str3, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KOzZKVFfRuhoQUqH(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KOzZKVFfRuhoQUqH(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KOzZKVFfRuhoQUqH(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KOzZKVFfRuhoQUqH(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KUyMBegGAtAmNDHm(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KUyMBegGAtAmNDHm(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KUyMBegGAtAmNDHm(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KUyMBegGAtAmNDHm(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LMflOkMzcbFWPvZV(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void LMflOkMzcbFWPvZV(java.util.Dictionary$Entry map$Entry, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LMflOkMzcbFWPvZV(java.util.Dictionary$Entry map$Entry, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LMflOkMzcbFWPvZV(java.util.Dictionary$Entry map$Entry, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LUtZNVfxCoVtJtEN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LUtZNVfxCoVtJtEN(java.lang.stringBuilder sb, java.lang.string str, float f, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void LUtZNVfxCoVtJtEN(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LUtZNVfxCoVtJtEN(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LahmKRexHobDRRBw(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LahmKRexHobDRRBw(java.lang.stringBuilder sb, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LahmKRexHobDRRBw(java.lang.stringBuilder sb, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LahmKRexHobDRRBw(java.lang.stringBuilder sb, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LzZzDgHdBoDVcwce(android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback) {
        mediaBrowserCompat$ConnectionCallback.onConnectionFailed();
    }

    public static void LzZzDgHdBoDVcwce(android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LzZzDgHdBoDVcwce(android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LzZzDgHdBoDVcwce(android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MqNLSfzvUpIQMYNQ(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, byte b, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MqNLSfzvUpIQMYNQ(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MqNLSfzvUpIQMYNQ(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool MqNLSfzvUpIQMYNQ(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static int MscZEMwCwFHIdQtn(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void MscZEMwCwFHIdQtn(java.lang.string str, java.lang.string str2, byte b, short s, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void MscZEMwCwFHIdQtn(java.lang.string str, java.lang.string str2, java.lang.string str3, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void MscZEMwCwFHIdQtn(java.lang.string str, java.lang.string str2, short s, java.lang.string str3, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static int OSlCTXvXppRLKAml(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void OSlCTXvXppRLKAml(java.lang.string str, java.lang.string str2, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OSlCTXvXppRLKAml(java.lang.string str, java.lang.string str2, int i, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OSlCTXvXppRLKAml(java.lang.string str, java.lang.string str2, short s, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OayLKjcmcnDKylUN(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OayLKjcmcnDKylUN(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OayLKjcmcnDKylUN(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OayLKjcmcnDKylUN(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OsFYUXjUCIAGWtYn(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase) {
        mediaBrowserCompat$MediaBrowserImplBase.dump();
    }

    public static void OsFYUXjUCIAGWtYn(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, char c, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OsFYUXjUCIAGWtYn(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, int i, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OsFYUXjUCIAGWtYn(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, short s, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OtZFxVSYlaimmNhk(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaBrowserCompat$SubscriptionCallback.onError(str, bundle);
    }

    public static void OtZFxVSYlaimmNhk(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, byte b, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OtZFxVSYlaimmNhk(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, char c, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OtZFxVSYlaimmNhk(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, bool z, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PEmiaAlFQfrIYhHf(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary.Remove(obj);
    }

    public static void PEmiaAlFQfrIYhHf(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, int i, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PEmiaAlFQfrIYhHf(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.string str, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PEmiaAlFQfrIYhHf(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.string str, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PKdzPvpqAKEFXdJS(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PKdzPvpqAKEFXdJS(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PKdzPvpqAKEFXdJS(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PKdzPvpqAKEFXdJS(java.lang.stringBuilder sb, java.lang.string str, float f, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PWJynFGBtWdsydGk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PWJynFGBtWdsydGk(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PWJynFGBtWdsydGk(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PWJynFGBtWdsydGk(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PiOvtVICunyAYyGk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void PiOvtVICunyAYyGk(java.lang.stringBuilder sb, byte b, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PiOvtVICunyAYyGk(java.lang.stringBuilder sb, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PiOvtVICunyAYyGk(java.lang.stringBuilder sb, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PqRNmGzogUBKbcmT(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary[obj);
    }

    public static void PqRNmGzogUBKbcmT(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, float f, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PqRNmGzogUBKbcmT(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PqRNmGzogUBKbcmT(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PuRRirJNCaiOhUsp(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void PuRRirJNCaiOhUsp(java.lang.stringBuilder sb, char c, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PuRRirJNCaiOhUsp(java.lang.stringBuilder sb, short s, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PuRRirJNCaiOhUsp(java.lang.stringBuilder sb, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PycUMbNkXhKWogBl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary[obj);
    }

    public static void PycUMbNkXhKWogBl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, int i, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PycUMbNkXhKWogBl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.string str, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PycUMbNkXhKWogBl(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, bool z, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List QJiqFjvrtDPMMXTg(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription) {
        return mediaBrowserCompat$Subscription.getOptionsList();
    }

    public static void QJiqFjvrtDPMMXTg(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QJiqFjvrtDPMMXTg(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, short s, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QJiqFjvrtDPMMXTg(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, short s, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QOSXLkVvkeXQmhFj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void QOSXLkVvkeXQmhFj(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, bool z, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QOSXLkVvkeXQmhFj(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QOSXLkVvkeXQmhFj(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void QRNBNuVmIEiUJWvL(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, java.lang.string str, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QRNBNuVmIEiUJWvL(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, short s, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QRNBNuVmIEiUJWvL(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, short s, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool QRNBNuVmIEiUJWvL(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase) {
        return mediaBrowserCompat$MediaBrowserImplBase.isConnected();
    }

    public static void QXxfhywOErOwAgXM(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.getMediaItem(str, resultReceiver, messenger);
    }

    public static void QXxfhywOErOwAgXM(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, char c, byte b, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QXxfhywOErOwAgXM(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, java.lang.string str2, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QXxfhywOErOwAgXM(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, java.lang.string str2, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QaqEbVZwWMCCnLAj(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void QaqEbVZwWMCCnLAj(java.lang.stringBuilder sb, java.lang.object obj, char c, int i, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QaqEbVZwWMCCnLAj(java.lang.stringBuilder sb, java.lang.object obj, int i, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QaqEbVZwWMCCnLAj(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QmsTZQNAedpNeZYn(android.content.object context, android.content.ServiceConnection serviceConnection) {
        context.unbindService(serviceConnection);
    }

    public static void QmsTZQNAedpNeZYn(android.content.object context, android.content.ServiceConnection serviceConnection, float f, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void QmsTZQNAedpNeZYn(android.content.object context, android.content.ServiceConnection serviceConnection, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void QmsTZQNAedpNeZYn(android.content.object context, android.content.ServiceConnection serviceConnection, int i, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int RHIWEkoJtKIvwCam(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void RHIWEkoJtKIvwCam(java.lang.string str, java.lang.string str2, short s, bool z, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RHIWEkoJtKIvwCam(java.lang.string str, java.lang.string str2, bool z, int i, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void RHIWEkoJtKIvwCam(java.lang.string str, java.lang.string str2, bool z, java.lang.string str3, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RKSOhIeYhDyVTjlc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RKSOhIeYhDyVTjlc(java.lang.stringBuilder sb, float f, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RKSOhIeYhDyVTjlc(java.lang.stringBuilder sb, float f, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RKSOhIeYhDyVTjlc(java.lang.stringBuilder sb, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RLEaflnCxYnqBOoA(int i) {
        return getStateLabel(i);
    }

    public static void RLEaflnCxYnqBOoA(int i, char c, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RLEaflnCxYnqBOoA(int i, char c, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RLEaflnCxYnqBOoA(int i, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string RXfgMwTIOWqpoWWW(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RXfgMwTIOWqpoWWW(java.lang.stringBuilder sb, int i, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RXfgMwTIOWqpoWWW(java.lang.stringBuilder sb, short s, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RXfgMwTIOWqpoWWW(java.lang.stringBuilder sb, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder SobBoRgscTMwWoUp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void SobBoRgscTMwWoUp(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SobBoRgscTMwWoUp(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SobBoRgscTMwWoUp(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TFFWjkgVSXMOlRMX(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TFFWjkgVSXMOlRMX(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TFFWjkgVSXMOlRMX(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TFFWjkgVSXMOlRMX(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TbDxJRbqeYMQEOEE(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.removeSubscription(str, iBinder, messenger);
    }

    public static void TbDxJRbqeYMQEOEE(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger, short s, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TbDxJRbqeYMQEOEE(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TbDxJRbqeYMQEOEE(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UqeAxeARUTGvCMmZ(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, char c, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UqeAxeARUTGvCMmZ(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UqeAxeARUTGvCMmZ(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool UqeAxeARUTGvCMmZ(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription) {
        return mediaBrowserCompat$Subscription.Count == 0;
    }

    public static java.lang.object UrDLuvuEqdOLFPhC(java.util.List list, int i) {
        return list[i);
    }

    public static void UrDLuvuEqdOLFPhC(java.util.List list, int i, float f, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void UrDLuvuEqdOLFPhC(java.util.List list, int i, float f, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UrDLuvuEqdOLFPhC(java.util.List list, int i, float f, java.lang.string str, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VTcUntVdBgJVytlS(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.addSubscription(str, iBinder, bundle, messenger);
    }

    public static void VTcUntVdBgJVytlS(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, android.os.Messenger messenger, byte b, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VTcUntVdBgJVytlS(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, android.os.Messenger messenger, float f, java.lang.string str2, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VTcUntVdBgJVytlS(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, android.os.Messenger messenger, short s, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VjdIMBIqSxOpADXH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void VjdIMBIqSxOpADXH(java.lang.stringBuilder sb, java.lang.object obj, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void VjdIMBIqSxOpADXH(java.lang.stringBuilder sb, java.lang.object obj, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VjdIMBIqSxOpADXH(java.lang.stringBuilder sb, java.lang.object obj, float f, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WhkGLWxIUkDeUnZu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void WhkGLWxIUkDeUnZu(java.lang.stringBuilder sb, java.lang.string str, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WhkGLWxIUkDeUnZu(java.lang.stringBuilder sb, java.lang.string str, short s, bool z, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WhkGLWxIUkDeUnZu(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WhkQSHhAHEBvyfsk(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void WhkQSHhAHEBvyfsk(java.lang.stringBuilder sb, java.lang.object obj, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WhkQSHhAHEBvyfsk(java.lang.stringBuilder sb, java.lang.object obj, int i, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WhkQSHhAHEBvyfsk(java.lang.stringBuilder sb, java.lang.object obj, short s, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int WliGONRxKJrpqpQt(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void WliGONRxKJrpqpQt(java.lang.string str, java.lang.string str2, float f, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WliGONRxKJrpqpQt(java.lang.string str, java.lang.string str2, int i, bool z, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WliGONRxKJrpqpQt(java.lang.string str, java.lang.string str2, short s, bool z, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static int WpguPmhJntaokAUt(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void WpguPmhJntaokAUt(java.lang.string str, java.lang.string str2, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WpguPmhJntaokAUt(java.lang.string str, java.lang.string str2, short s, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WpguPmhJntaokAUt(java.lang.string str, java.lang.string str2, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string WyfLwZBIidLtUbWm(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void WyfLwZBIidLtUbWm(java.lang.stringBuilder sb, float f, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WyfLwZBIidLtUbWm(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WyfLwZBIidLtUbWm(java.lang.stringBuilder sb, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int XQULazWFWxMfCpPl(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void XQULazWFWxMfCpPl(java.lang.string str, java.lang.string str2, java.lang.string str3, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XQULazWFWxMfCpPl(java.lang.string str, java.lang.string str2, bool z, byte b, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void XQULazWFWxMfCpPl(java.lang.string str, java.lang.string str2, bool z, byte b, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void XfaUWcHydjlYzplw(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, byte b, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XfaUWcHydjlYzplw(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, char c, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XfaUWcHydjlYzplw(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool XfaUWcHydjlYzplw(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static android.support.v4.media.MediaBrowserCompat$SubscriptionCallback XxxSqDvXubYHhAmR(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle) {
        return mediaBrowserCompat$Subscription.getCallback(bundle);
    }

    public static void XxxSqDvXubYHhAmR(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XxxSqDvXubYHhAmR(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void XxxSqDvXubYHhAmR(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZDbdqVhrcCWuQDQh(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ZDbdqVhrcCWuQDQh(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZDbdqVhrcCWuQDQh(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, short s, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZDbdqVhrcCWuQDQh(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase) {
        return mediaBrowserCompat$MediaBrowserImplBase.isConnected();
    }

    public static java.lang.string ZNSBgPLmAiVpTpSS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ZNSBgPLmAiVpTpSS(java.lang.stringBuilder sb, byte b, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZNSBgPLmAiVpTpSS(java.lang.stringBuilder sb, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZNSBgPLmAiVpTpSS(java.lang.stringBuilder sb, bool z, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZclFdjJtDUmICCFi(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback) {
        mediaBrowserCompat$Subscription.putCallback(bundle, mediaBrowserCompat$SubscriptionCallback);
    }

    public static void ZclFdjJtDUmICCFi(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZclFdjJtDUmICCFi(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZclFdjJtDUmICCFi(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AAbIyrZYBlNMOjvj(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, float f, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AAbIyrZYBlNMOjvj(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, float f, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AAbIyrZYBlNMOjvj(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool AAbIyrZYBlNMOjvj(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase) {
        return mediaBrowserCompat$MediaBrowserImplBase.isConnected();
    }

    public static int AUrDvFHGNyKETpTj(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void AUrDvFHGNyKETpTj(java.lang.string str, java.lang.string str2, short s, java.lang.string str3, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AUrDvFHGNyKETpTj(java.lang.string str, java.lang.string str2, bool z, char c, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void AUrDvFHGNyKETpTj(java.lang.string str, java.lang.string str2, bool z, short s, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder BDIOPoiVRWTeJrng(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void BDIOPoiVRWTeJrng(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BDIOPoiVRWTeJrng(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BDIOPoiVRWTeJrng(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int BIGpuluSPRBYmZjN(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void BIGpuluSPRBYmZjN(java.lang.string str, java.lang.string str2, float f, short s, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BIGpuluSPRBYmZjN(java.lang.string str, java.lang.string str2, short s, java.lang.string str3, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BIGpuluSPRBYmZjN(java.lang.string str, java.lang.string str2, short s, bool z, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object BKUlmbfohVQVAMui(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void BKUlmbfohVQVAMui(java.util.Dictionary$Entry map$Entry, int i, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BKUlmbfohVQVAMui(java.util.Dictionary$Entry map$Entry, java.lang.string str, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BKUlmbfohVQVAMui(java.util.Dictionary$Entry map$Entry, bool z, char c, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void BLkcOBqIXbriGAPc(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.addSubscription(str, iBinder, bundle, messenger);
    }

    public static void BLkcOBqIXbriGAPc(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, android.os.Messenger messenger, int i, short s, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BLkcOBqIXbriGAPc(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, android.os.Messenger messenger, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BLkcOBqIXbriGAPc(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, android.os.Messenger messenger, bool z, short s, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CFVzlbWOdqTJdGdn(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, float f, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CFVzlbWOdqTJdGdn(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CFVzlbWOdqTJdGdn(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CFVzlbWOdqTJdGdn(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static void CNifCNRuNHxahmAt(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle) {
        mediaBrowserCompat$SubscriptionCallback.onChildrenLoaded(str, list, bundle);
    }

    public static void CNifCNRuNHxahmAt(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle, byte b, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CNifCNRuNHxahmAt(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle, float f, java.lang.string str2, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CNifCNRuNHxahmAt(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle, bool z, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CvyAuNpwRWETWdTV(java.util.IEnumerator it, byte b, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void CvyAuNpwRWETWdTV(java.util.IEnumerator it, java.lang.string str, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void CvyAuNpwRWETWdTV(java.util.IEnumerator it, java.lang.string str, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool CvyAuNpwRWETWdTV(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void CxYpuLcrAxcCqbtu(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.os.Messenger messenger, java.lang.string str, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CxYpuLcrAxcCqbtu(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.os.Messenger messenger, java.lang.string str, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CxYpuLcrAxcCqbtu(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.os.Messenger messenger, java.lang.string str, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool CxYpuLcrAxcCqbtu(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.os.Messenger messenger, java.lang.string str) {
        return mediaBrowserCompat$MediaBrowserImplBase.isCurrent(messenger, str);
    }

    public static java.lang.string DIEWjVbGmlHMuouZ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void DIEWjVbGmlHMuouZ(java.lang.stringBuilder sb, char c, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DIEWjVbGmlHMuouZ(java.lang.stringBuilder sb, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DIEWjVbGmlHMuouZ(java.lang.stringBuilder sb, int i, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int DpQysdkdqQNGIIoa(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.i(str, str2, th);
    }

    public static void DpQysdkdqQNGIIoa(java.lang.string str, java.lang.string str2, java.lang.Exception th, float f, char c, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void DpQysdkdqQNGIIoa(java.lang.string str, java.lang.string str2, java.lang.Exception th, float f, java.lang.string str3, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DpQysdkdqQNGIIoa(java.lang.string str, java.lang.string str2, java.lang.Exception th, java.lang.string str3, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EBgjfgChgraWkyzG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EBgjfgChgraWkyzG(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EBgjfgChgraWkyzG(java.lang.stringBuilder sb, java.lang.string str, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EBgjfgChgraWkyzG(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string EJdaBIIeAObtVvCn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void EJdaBIIeAObtVvCn(java.lang.stringBuilder sb, byte b, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EJdaBIIeAObtVvCn(java.lang.stringBuilder sb, char c, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EJdaBIIeAObtVvCn(java.lang.stringBuilder sb, int i, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EMTIrNsClPeOMDcN(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EMTIrNsClPeOMDcN(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EMTIrNsClPeOMDcN(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool EMTIrNsClPeOMDcN(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase) {
        return mediaBrowserCompat$MediaBrowserImplBase.isConnected();
    }

    public static java.lang.stringBuilder EuXVsSLDoEuiAdsl(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EuXVsSLDoEuiAdsl(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EuXVsSLDoEuiAdsl(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EuXVsSLDoEuiAdsl(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FPmEXshXhRYQCvsX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FPmEXshXhRYQCvsX(java.lang.stringBuilder sb, int i, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FPmEXshXhRYQCvsX(java.lang.stringBuilder sb, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FPmEXshXhRYQCvsX(java.lang.stringBuilder sb, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string GCwGBFbcupKISPUP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void GCwGBFbcupKISPUP(java.lang.stringBuilder sb, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GCwGBFbcupKISPUP(java.lang.stringBuilder sb, char c, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GCwGBFbcupKISPUP(java.lang.stringBuilder sb, short s, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GJSbIVgSjtocrwYj(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void GJSbIVgSjtocrwYj(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GJSbIVgSjtocrwYj(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GJSbIVgSjtocrwYj(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GSxKjoPwmFRGrSTI(java.lang.CharSequence charSequence, byte b, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GSxKjoPwmFRGrSTI(java.lang.CharSequence charSequence, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GSxKjoPwmFRGrSTI(java.lang.CharSequence charSequence, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool GSxKjoPwmFRGrSTI(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static java.lang.stringBuilder GTXcPLwbvMumwDtM(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void GTXcPLwbvMumwDtM(java.lang.stringBuilder sb, int i, float f, char c, int i2, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GTXcPLwbvMumwDtM(java.lang.stringBuilder sb, int i, float f, int i2, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GTXcPLwbvMumwDtM(java.lang.stringBuilder sb, int i, java.lang.string str, float f, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GeLsCTQqjQrbmuAK(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void GeLsCTQqjQrbmuAK(java.lang.stringBuilder sb, int i, int i2, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GeLsCTQqjQrbmuAK(java.lang.stringBuilder sb, int i, short s, int i2, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GeLsCTQqjQrbmuAK(java.lang.stringBuilder sb, int i, bool z, int i2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    private static java.lang.string GetStateLabel(int i) {
        if ((4 + 9) % 9 > 0) {
        }
        return i == 0 ? "CONNECT_STATE_DISCONNECTING" : i == 1 ? "CONNECT_STATE_DISCONNECTED" : i == 2 ? "CONNECT_STATE_CONNECTING" : i == 3 ? "CONNECT_STATE_CONNECTED" : i == 4 ? "CONNECT_STATE_SUSPENDED" : PuRRirJNCaiOhUsp(gTXcPLwbvMumwDtM(new java.lang.stringBuilder("UNKNOWN/"), i));
    }

    private static void GetStateLabel(int i, float f, int i2, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetStateLabel(int i, float f, short s, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    private static void GetStateLabel(int i, short s, bool z, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static int GjallzzjJgEfLujL(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void GjallzzjJgEfLujL(java.lang.string str, java.lang.string str2, short s, byte b, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void GjallzzjJgEfLujL(java.lang.string str, java.lang.string str2, short s, byte b, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void GjallzzjJgEfLujL(java.lang.string str, java.lang.string str2, short s, java.lang.string str3, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.util.HashSet GqLjQvbNRvSmESij(androidx.collection.ArrayDictionary arrayDictionary) {
        return arrayDictionary.entryHashSet();
    }

    public static void GqLjQvbNRvSmESij(androidx.collection.ArrayDictionary arrayDictionary, float f, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GqLjQvbNRvSmESij(androidx.collection.ArrayDictionary arrayDictionary, int i, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GqLjQvbNRvSmESij(androidx.collection.ArrayDictionary arrayDictionary, short s, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HRMqjMFGFjnWQkxs(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list) {
        mediaBrowserCompat$SubscriptionCallback.onChildrenLoaded(str, list);
    }

    public static void HRMqjMFGFjnWQkxs(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, char c, java.lang.string str2, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HRMqjMFGFjnWQkxs(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, float f, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void HRMqjMFGFjnWQkxs(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, java.lang.string str2, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HazxBWyQTRjFgYNK(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HazxBWyQTRjFgYNK(java.lang.stringBuilder sb, char c, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HazxBWyQTRjFgYNK(java.lang.stringBuilder sb, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HazxBWyQTRjFgYNK(java.lang.stringBuilder sb, float f, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HmXJcmLOVQDInytG(int i) {
        return getStateLabel(i);
    }

    public static void HmXJcmLOVQDInytG(int i, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HmXJcmLOVQDInytG(int i, float f, java.lang.string str, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HmXJcmLOVQDInytG(int i, short s, java.lang.string str, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int HovzAzhOpydAJZnM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void HovzAzhOpydAJZnM(java.lang.string str, java.lang.string str2, char c, int i, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HovzAzhOpydAJZnM(java.lang.string str, java.lang.string str2, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HovzAzhOpydAJZnM(java.lang.string str, java.lang.string str2, int i, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ILKqvTWNYNXrkKSf(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, java.lang.string str, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ILKqvTWNYNXrkKSf(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, short s, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ILKqvTWNYNXrkKSf(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, short s, java.lang.string str, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool ILKqvTWNYNXrkKSf(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase) {
        return mediaBrowserCompat$MediaBrowserImplBase.isConnected();
    }

    public static int IMjsAOfbklAqRFzy(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void IMjsAOfbklAqRFzy(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IMjsAOfbklAqRFzy(java.lang.string str, java.lang.string str2, short s, byte b, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void IMjsAOfbklAqRFzy(java.lang.string str, java.lang.string str2, short s, int i, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    private void IsCurrent(android.os.Messenger messenger, java.lang.string str, float f, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private void IsCurrent(android.os.Messenger messenger, java.lang.string str, java.lang.string str2, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    private void IsCurrent(android.os.Messenger messenger, java.lang.string str, short s, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    private bool IsCurrent(android.os.Messenger messenger, java.lang.string str) {
        int i;
        if ((18 + 22) % 22 > 0) {
        }
        if (this.mCallbacksMessenger == messenger && (i = this.mState) != 0 && i != 1) {
            return true;
        }
        int i2 = this.mState;
        if (i2 == 0 || i2 == 1) {
            return false;
        }
        pumeTkSKzYAqMIrU("MediaBrowserCompat", zDhndKGaHZxwQdsV(urBYrhVOOLgMrzQy(LUtZNVfxCoVtJtEN(mXsDvAHfRKPUBmIL(jHZOKqhbnaUEoxfB(kAizyKCNkkhGpnui(vPapDJGwaoZQjhJn(WhkGLWxIUkDeUnZu(new java.lang.stringBuilder(), str), " for "), this.mServiceComponent), " with mCallbacksMessenger="), this.mCallbacksMessenger), " this="), this)));
        return false;
    }

    public static java.lang.object JAwBhiqdpHRTqeZI(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void JAwBhiqdpHRTqeZI(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JAwBhiqdpHRTqeZI(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JAwBhiqdpHRTqeZI(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, bool z, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder JHZOKqhbnaUEoxfB(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void JHZOKqhbnaUEoxfB(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void JHZOKqhbnaUEoxfB(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void JHZOKqhbnaUEoxfB(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List JJDDEjdvXDUUdhGe(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription) {
        return mediaBrowserCompat$Subscription.getOptionsList();
    }

    public static void JJDDEjdvXDUUdhGe(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void JJDDEjdvXDUUdhGe(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, float f, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JJDDEjdvXDUUdhGe(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, int i, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void JQwbmXcMjvHQZutE(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JQwbmXcMjvHQZutE(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void JQwbmXcMjvHQZutE(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, short s, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool JQwbmXcMjvHQZutE(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase) {
        return mediaBrowserCompat$MediaBrowserImplBase.isConnected();
    }

    public static java.lang.stringBuilder KAizyKCNkkhGpnui(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void KAizyKCNkkhGpnui(java.lang.stringBuilder sb, java.lang.object obj, float f, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KAizyKCNkkhGpnui(java.lang.stringBuilder sb, java.lang.object obj, bool z, char c, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KAizyKCNkkhGpnui(java.lang.stringBuilder sb, java.lang.object obj, bool z, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KCnCYvXOVAldGHfi(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.os.Messenger messenger, java.lang.string str, java.lang.string str2, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KCnCYvXOVAldGHfi(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.os.Messenger messenger, java.lang.string str, java.lang.string str2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KCnCYvXOVAldGHfi(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.os.Messenger messenger, java.lang.string str, short s, java.lang.string str2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool KCnCYvXOVAldGHfi(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.os.Messenger messenger, java.lang.string str) {
        return mediaBrowserCompat$MediaBrowserImplBase.isCurrent(messenger, str);
    }

    public static java.lang.string KMPBYXTzCuzMDATH(int i) {
        return getStateLabel(i);
    }

    public static void KMPBYXTzCuzMDATH(int i, char c, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KMPBYXTzCuzMDATH(int i, float f, bool z, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KMPBYXTzCuzMDATH(int i, int i2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KdJIwtctumWgVWun(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KdJIwtctumWgVWun(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KdJIwtctumWgVWun(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KdJIwtctumWgVWun(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void KefxTLCRWzFEQBKZ(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str) {
        mediaBrowserCompat$SubscriptionCallback.onError(str);
    }

    public static void KefxTLCRWzFEQBKZ(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, byte b, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void KefxTLCRWzFEQBKZ(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, char c, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KefxTLCRWzFEQBKZ(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.lang.string str2, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder KkOWMDPZzjADfWfg(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void KkOWMDPZzjADfWfg(java.lang.stringBuilder sb, java.lang.string str, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KkOWMDPZzjADfWfg(java.lang.stringBuilder sb, java.lang.string str, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KkOWMDPZzjADfWfg(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KnVGdMQQVxnnDgkB(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, byte b, char c, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KnVGdMQQVxnnDgkB(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, char c, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KnVGdMQQVxnnDgkB(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool KnVGdMQQVxnnDgkB(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase) {
        return mediaBrowserCompat$MediaBrowserImplBase.isConnected();
    }

    public static int KtdQWUekHFILHkZS(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void KtdQWUekHFILHkZS(java.lang.string str, java.lang.string str2, char c, java.lang.string str3, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KtdQWUekHFILHkZS(java.lang.string str, java.lang.string str2, float f, short s, char c, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void KtdQWUekHFILHkZS(java.lang.string str, java.lang.string str2, short s, float f, java.lang.string str3, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder LSDBGlrDhGGFHytP(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void LSDBGlrDhGGFHytP(java.lang.stringBuilder sb, java.lang.string str, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LSDBGlrDhGGFHytP(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LSDBGlrDhGGFHytP(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string LUoumsJLqjaOOgbD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void LUoumsJLqjaOOgbD(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void LUoumsJLqjaOOgbD(java.lang.stringBuilder sb, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LUoumsJLqjaOOgbD(java.lang.stringBuilder sb, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object LXLYxlnjZXYnUhGo(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary[obj);
    }

    public static void LXLYxlnjZXYnUhGo(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, float f, char c, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXLYxlnjZXYnUhGo(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, bool z, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LXLYxlnjZXYnUhGo(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, bool z, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static int LkkJMzkLofWBosEu(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void LkkJMzkLofWBosEu(java.lang.string str, java.lang.string str2, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LkkJMzkLofWBosEu(java.lang.string str, java.lang.string str2, short s, int i, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void LkkJMzkLofWBosEu(java.lang.string str, java.lang.string str2, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static int LyHjpKjHDNuJaKNg(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void LyHjpKjHDNuJaKNg(java.lang.string str, java.lang.string str2, byte b, bool z, char c, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void LyHjpKjHDNuJaKNg(java.lang.string str, java.lang.string str2, char c, byte b, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void LyHjpKjHDNuJaKNg(java.lang.string str, java.lang.string str2, java.lang.string str3, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string MKMNxBEycVCJJFkM(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void MKMNxBEycVCJJFkM(java.lang.stringBuilder sb, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MKMNxBEycVCJJFkM(java.lang.stringBuilder sb, float f, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MKMNxBEycVCJJFkM(java.lang.stringBuilder sb, int i, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void MRcraDtEFzXddIPP(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, float f, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MRcraDtEFzXddIPP(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, java.lang.string str, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MRcraDtEFzXddIPP(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, java.lang.string str, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool MRcraDtEFzXddIPP(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase) {
        return mediaBrowserCompat$MediaBrowserImplBase.isConnected();
    }

    public static java.lang.stringBuilder MXsDvAHfRKPUBmIL(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void MXsDvAHfRKPUBmIL(java.lang.stringBuilder sb, java.lang.object obj, float f, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MXsDvAHfRKPUBmIL(java.lang.stringBuilder sb, java.lang.object obj, short s, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MXsDvAHfRKPUBmIL(java.lang.stringBuilder sb, java.lang.object obj, bool z, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void MfjorXTfgqunPudz(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, byte b, char c, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MfjorXTfgqunPudz(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, byte b, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MfjorXTfgqunPudz(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool MfjorXTfgqunPudz(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static int NJEhSOAvIYweGsQV(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static void NJEhSOAvIYweGsQV(java.lang.string str, java.lang.string str2, float f, java.lang.string str3, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NJEhSOAvIYweGsQV(java.lang.string str, java.lang.string str2, int i, byte b, java.lang.string str3, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NJEhSOAvIYweGsQV(java.lang.string str, java.lang.string str2, java.lang.string str3, float f, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string NbNycOtxsDwOITYS(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void NbNycOtxsDwOITYS(java.lang.stringBuilder sb, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void NbNycOtxsDwOITYS(java.lang.stringBuilder sb, char c, byte b, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void NbNycOtxsDwOITYS(java.lang.stringBuilder sb, char c, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NjOkbFJYQsDbJnQX(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NjOkbFJYQsDbJnQX(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void NjOkbFJYQsDbJnQX(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, java.lang.string str, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool NjOkbFJYQsDbJnQX(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase) {
        return mediaBrowserCompat$MediaBrowserImplBase.isConnected();
    }

    public static java.lang.stringBuilder OGsEVxuRPaBKqrHo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void OGsEVxuRPaBKqrHo(java.lang.stringBuilder sb, java.lang.string str, float f, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OGsEVxuRPaBKqrHo(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OGsEVxuRPaBKqrHo(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OOfIsZjfYnCKMUMq(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void OOfIsZjfYnCKMUMq(java.lang.stringBuilder sb, java.lang.object obj, byte b, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OOfIsZjfYnCKMUMq(java.lang.stringBuilder sb, java.lang.object obj, float f, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OOfIsZjfYnCKMUMq(java.lang.stringBuilder sb, java.lang.object obj, int i, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OREZvIzvcRHdToUC(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void OREZvIzvcRHdToUC(java.lang.stringBuilder sb, byte b, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OREZvIzvcRHdToUC(java.lang.stringBuilder sb, char c, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OREZvIzvcRHdToUC(java.lang.stringBuilder sb, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder OaqabLVhrSmstYaK(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void OaqabLVhrSmstYaK(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, float f, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void OaqabLVhrSmstYaK(java.lang.stringBuilder sb, java.lang.object obj, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OaqabLVhrSmstYaK(java.lang.stringBuilder sb, java.lang.object obj, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static int OdFrrPGRCjSgLXaE(java.util.List list) {
        return list.Count;
    }

    public static void OdFrrPGRCjSgLXaE(java.util.List list, java.lang.string str, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OdFrrPGRCjSgLXaE(java.util.List list, java.lang.string str, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void OdFrrPGRCjSgLXaE(java.util.List list, short s, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string OhRLdClAKaPYZPSs(int i) {
        return getStateLabel(i);
    }

    public static void OhRLdClAKaPYZPSs(int i, int i2, float f, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void OhRLdClAKaPYZPSs(int i, int i2, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void OhRLdClAKaPYZPSs(int i, java.lang.string str, short s, float f, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PUJovRzFwWbRpBle(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PUJovRzFwWbRpBle(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PUJovRzFwWbRpBle(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PUJovRzFwWbRpBle(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PVFxTXbtSkOTHZRE(int i) {
        return getStateLabel(i);
    }

    public static void PVFxTXbtSkOTHZRE(int i, int i2, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PVFxTXbtSkOTHZRE(int i, short s, int i2, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PVFxTXbtSkOTHZRE(int i, short s, int i2, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void PbdutUmjahLUTepf(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.removeSubscription(str, iBinder, messenger);
    }

    public static void PbdutUmjahLUTepf(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger, char c, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PbdutUmjahLUTepf(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger, char c, short s, java.lang.string str2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PbdutUmjahLUTepf(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger, short s, java.lang.string str2, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string PcCFUwOeTTNsGzsD(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void PcCFUwOeTTNsGzsD(java.lang.stringBuilder sb, char c, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PcCFUwOeTTNsGzsD(java.lang.stringBuilder sb, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PcCFUwOeTTNsGzsD(java.lang.stringBuilder sb, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PebYIcBilKdoKJaM(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PebYIcBilKdoKJaM(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void PebYIcBilKdoKJaM(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PebYIcBilKdoKJaM(java.lang.stringBuilder sb, java.lang.string str, short s, java.lang.string str2, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int PumeTkSKzYAqMIrU(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void PumeTkSKzYAqMIrU(java.lang.string str, java.lang.string str2, float f, byte b, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void PumeTkSKzYAqMIrU(java.lang.string str, java.lang.string str2, java.lang.string str3, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PumeTkSKzYAqMIrU(java.lang.string str, java.lang.string str2, java.lang.string str3, short s, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QheVTatVqbxueuNm(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void QheVTatVqbxueuNm(java.lang.stringBuilder sb, java.lang.object obj, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QheVTatVqbxueuNm(java.lang.stringBuilder sb, java.lang.object obj, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QheVTatVqbxueuNm(java.lang.stringBuilder sb, java.lang.object obj, short s, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder QzZkWqRhxAJgryMA(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void QzZkWqRhxAJgryMA(java.lang.stringBuilder sb, java.lang.object obj, byte b, short s, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QzZkWqRhxAJgryMA(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void QzZkWqRhxAJgryMA(java.lang.stringBuilder sb, java.lang.object obj, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RLlWncnarNUHZILG(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RLlWncnarNUHZILG(java.lang.stringBuilder sb, java.lang.string str, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RLlWncnarNUHZILG(java.lang.stringBuilder sb, java.lang.string str, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RLlWncnarNUHZILG(java.lang.stringBuilder sb, java.lang.string str, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RPfcvqBXPxAOQShn(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, int i, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void RPfcvqBXPxAOQShn(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, int i, short s, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RPfcvqBXPxAOQShn(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, java.lang.string str, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool RPfcvqBXPxAOQShn(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static java.lang.string RVqSuUYfXdLBFefr(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void RVqSuUYfXdLBFefr(java.lang.stringBuilder sb, byte b, int i, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RVqSuUYfXdLBFefr(java.lang.stringBuilder sb, byte b, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RVqSuUYfXdLBFefr(java.lang.stringBuilder sb, short s, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder RsJAnFEgOyZguUBn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void RsJAnFEgOyZguUBn(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RsJAnFEgOyZguUBn(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RsJAnFEgOyZguUBn(java.lang.stringBuilder sb, java.lang.string str, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RycByNRQYPvIeeYf(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.os.Messenger messenger, java.lang.string str, byte b, int i, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RycByNRQYPvIeeYf(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.os.Messenger messenger, java.lang.string str, char c, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RycByNRQYPvIeeYf(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.os.Messenger messenger, java.lang.string str, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool RycByNRQYPvIeeYf(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase mediaBrowserCompat$MediaBrowserImplBase, android.os.Messenger messenger, java.lang.string str) {
        return mediaBrowserCompat$MediaBrowserImplBase.isCurrent(messenger, str);
    }

    public static java.lang.stringBuilder SCjIYWpOYIUrVjmb(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void SCjIYWpOYIUrVjmb(java.lang.stringBuilder sb, java.lang.object obj, char c, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SCjIYWpOYIUrVjmb(java.lang.stringBuilder sb, java.lang.object obj, char c, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SCjIYWpOYIUrVjmb(java.lang.stringBuilder sb, java.lang.object obj, float f, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SQanFlZTSDFnYcNo(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void SQanFlZTSDFnYcNo(java.lang.stringBuilder sb, byte b, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void SQanFlZTSDFnYcNo(java.lang.stringBuilder sb, float f, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SQanFlZTSDFnYcNo(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder SWAeiiOnHlUjbVNH(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void SWAeiiOnHlUjbVNH(java.lang.stringBuilder sb, java.lang.object obj, byte b, float f, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SWAeiiOnHlUjbVNH(java.lang.stringBuilder sb, java.lang.object obj, byte b, float f, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void SWAeiiOnHlUjbVNH(java.lang.stringBuilder sb, java.lang.object obj, byte b, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object SoEYqSaOVDyRnIva(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static void SoEYqSaOVDyRnIva(java.util.List list, int i, char c, int i2, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SoEYqSaOVDyRnIva(java.util.List list, int i, int i2, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SoEYqSaOVDyRnIva(java.util.List list, int i, java.lang.string str, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TJyLsiSPLAjYoOXz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TJyLsiSPLAjYoOXz(java.lang.stringBuilder sb, java.lang.string str, byte b, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TJyLsiSPLAjYoOXz(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void TJyLsiSPLAjYoOXz(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TdIVlPahiYxmXHOF(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TdIVlPahiYxmXHOF(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TdIVlPahiYxmXHOF(java.lang.stringBuilder sb, java.lang.string str, int i, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TdIVlPahiYxmXHOF(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder TfnUmkcKCmApVcAi(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void TfnUmkcKCmApVcAi(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TfnUmkcKCmApVcAi(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TfnUmkcKCmApVcAi(java.lang.stringBuilder sb, java.lang.string str, short s, int i, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string TqxYgPWauxVMXcQd(int i) {
        return getStateLabel(i);
    }

    public static void TqxYgPWauxVMXcQd(int i, byte b, char c, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TqxYgPWauxVMXcQd(int i, char c, byte b, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TqxYgPWauxVMXcQd(int i, java.lang.string str, byte b, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TxrDXbtEZxKkHDDy(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static void TxrDXbtEZxKkHDDy(java.util.List list, int i, byte b, float f, java.lang.string str, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TxrDXbtEZxKkHDDy(java.util.List list, int i, int i2, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void TxrDXbtEZxKkHDDy(java.util.List list, int i, java.lang.string str, float f, byte b, int i2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UWjIUyeffvSPHhEq(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void UWjIUyeffvSPHhEq(java.lang.stringBuilder sb, java.lang.object obj, char c, short s, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UWjIUyeffvSPHhEq(java.lang.stringBuilder sb, java.lang.object obj, bool z, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UWjIUyeffvSPHhEq(java.lang.stringBuilder sb, java.lang.object obj, bool z, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UahXHQrPcLKECzxs(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void UahXHQrPcLKECzxs(java.lang.stringBuilder sb, byte b, char c, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UahXHQrPcLKECzxs(java.lang.stringBuilder sb, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UahXHQrPcLKECzxs(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string UrAvuBvyGSWuuIzk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void UrAvuBvyGSWuuIzk(java.lang.stringBuilder sb, int i, float f, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UrAvuBvyGSWuuIzk(java.lang.stringBuilder sb, int i, short s, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UrAvuBvyGSWuuIzk(java.lang.stringBuilder sb, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder UrBYrhVOOLgMrzQy(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void UrBYrhVOOLgMrzQy(java.lang.stringBuilder sb, java.lang.object obj, char c, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UrBYrhVOOLgMrzQy(java.lang.stringBuilder sb, java.lang.object obj, float f, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void UrBYrhVOOLgMrzQy(java.lang.stringBuilder sb, java.lang.object obj, short s, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VPapDJGwaoZQjhJn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VPapDJGwaoZQjhJn(java.lang.stringBuilder sb, java.lang.string str, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VPapDJGwaoZQjhJn(java.lang.stringBuilder sb, java.lang.string str, int i, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void VPapDJGwaoZQjhJn(java.lang.stringBuilder sb, java.lang.string str, short s, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static int VuWLlMxEOwOPqKuw(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void VuWLlMxEOwOPqKuw(java.lang.string str, java.lang.string str2, char c, java.lang.string str3, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void VuWLlMxEOwOPqKuw(java.lang.string str, java.lang.string str2, float f, java.lang.string str3, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VuWLlMxEOwOPqKuw(java.lang.string str, java.lang.string str2, short s, char c, float f, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder WDcMVuKNixAGCPSG(java.lang.stringBuilder sb, int i) {
        return sb.append(i);
    }

    public static void WDcMVuKNixAGCPSG(java.lang.stringBuilder sb, int i, byte b, java.lang.string str, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WDcMVuKNixAGCPSG(java.lang.stringBuilder sb, int i, int i2, float f, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WDcMVuKNixAGCPSG(java.lang.stringBuilder sb, int i, java.lang.string str, float f, int i2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int WDgRMhJzWiirzemJ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void WDgRMhJzWiirzemJ(java.lang.string str, java.lang.string str2, float f, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WDgRMhJzWiirzemJ(java.lang.string str, java.lang.string str2, int i, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void WDgRMhJzWiirzemJ(java.lang.string str, java.lang.string str2, bool z, float f, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WXiNekUoJJqVinLG(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, android.os.Messenger messenger) {
        mediaBrowserCompat$CallbackHandler.setCallbacksMessenger(messenger);
    }

    public static void WXiNekUoJJqVinLG(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, android.os.Messenger messenger, byte b, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void WXiNekUoJJqVinLG(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, android.os.Messenger messenger, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WXiNekUoJJqVinLG(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, android.os.Messenger messenger, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string XHkBcrPSVuOHzFzP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void XHkBcrPSVuOHzFzP(java.lang.stringBuilder sb, java.lang.string str, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XHkBcrPSVuOHzFzP(java.lang.stringBuilder sb, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void XHkBcrPSVuOHzFzP(java.lang.stringBuilder sb, bool z, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XPRgrnhXzikyRHZo(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XPRgrnhXzikyRHZo(java.lang.stringBuilder sb, java.lang.string str, char c, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XPRgrnhXzikyRHZo(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XPRgrnhXzikyRHZo(java.lang.stringBuilder sb, java.lang.string str, short s, char c, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder YCwybLDeeVoYCIcJ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void YCwybLDeeVoYCIcJ(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YCwybLDeeVoYCIcJ(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void YCwybLDeeVoYCIcJ(java.lang.stringBuilder sb, java.lang.string str, short s, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object YLnsHgbIdSEbZLrT(java.util.List list, int i) {
        return list[i);
    }

    public static void YLnsHgbIdSEbZLrT(java.util.List list, int i, byte b, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void YLnsHgbIdSEbZLrT(java.util.List list, int i, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void YLnsHgbIdSEbZLrT(java.util.List list, int i, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ZDhndKGaHZxwQdsV(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void ZDhndKGaHZxwQdsV(java.lang.stringBuilder sb, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZDhndKGaHZxwQdsV(java.lang.stringBuilder sb, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZDhndKGaHZxwQdsV(java.lang.stringBuilder sb, bool z, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public override void Connect() {
        if ((28 + 32) % 32 > 0) {
        }
        int i = this.mState;
        if (i != 0 && i != 1) {
            throw new java.lang.IllegalStateException(EjxjeTMOCOWZqCNt(tfnUmkcKCmApVcAi(oGsEVxuRPaBKqrHo(new java.lang.stringBuilder("connect() called while neigther disconnecting nor disconnected (state="), hmXJcmLOVQDInytG(this.mState)), ")")));
        }
        this.mState = 2;
        XfaUWcHydjlYzplw(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase$1(this));
    }

    public override void Disconnect() {
        if ((13 + 2) % 2 > 0) {
        }
        this.mState = 0;
        MqNLSfzvUpIQMYNQ(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase$2(this));
    }

    void dump() {
        if ((20 + 6) % 6 > 0) {
        }
        IBDWKGnmDqlEEcJp("MediaBrowserCompat", "MediaBrowserCompat...");
        wDgRMhJzWiirzemJ("MediaBrowserCompat", xHkBcrPSVuOHzFzP(qzZkWqRhxAJgryMA(new java.lang.stringBuilder("  mServiceComponent="), this.mServiceComponent)));
        gjallzzjJgEfLujL("MediaBrowserCompat", rVqSuUYfXdLBFefr(qheVTatVqbxueuNm(new java.lang.stringBuilder("  mCallback="), this.mCallback)));
        FWEdWhKsALedYIQX("MediaBrowserCompat", hazxBWyQTRjFgYNK(uWjIUyeffvSPHhEq(new java.lang.stringBuilder("  mRootHints="), this.mRootHints)));
        WpguPmhJntaokAUt("MediaBrowserCompat", CrJhihyCpTHpoPCK(TFFWjkgVSXMOlRMX(new java.lang.stringBuilder("  mState="), ohRLdClAKaPYZPSs(this.mState))));
        WliGONRxKJrpqpQt("MediaBrowserCompat", RXfgMwTIOWqpoWWW(oOfIsZjfYnCKMUMq(new java.lang.stringBuilder("  mServiceConnection="), this.mServiceConnection)));
        JjfKXsVboxvwZmVw("MediaBrowserCompat", IQmGXxgRaNvZbRXO(QaqEbVZwWMCCnLAj(new java.lang.stringBuilder("  mServiceBinderWrapper="), this.mServiceBinderWrapper)));
        bIGpuluSPRBYmZjN("MediaBrowserCompat", WyfLwZBIidLtUbWm(oaqabLVhrSmstYaK(new java.lang.stringBuilder("  mCallbacksMessenger="), this.mCallbacksMessenger)));
        ktdQWUekHFILHkZS("MediaBrowserCompat", sQanFlZTSDFnYcNo(kkOWMDPZzjADfWfg(new java.lang.stringBuilder("  mRootId="), this.mRootId)));
        vuWLlMxEOwOPqKuw("MediaBrowserCompat", RKSOhIeYhDyVTjlc(sWAeiiOnHlUjbVNH(new java.lang.stringBuilder("  mMediaSessionToken="), this.mMediaSessionToken)));
    }

    void forceCloseConnection() {
        if ((32 + 22) % 22 > 0) {
        }
        android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase$MediaServiceConnection mediaBrowserCompat$MediaBrowserImplBase$MediaServiceConnection = this.mServiceConnection;
        if (mediaBrowserCompat$MediaBrowserImplBase$MediaServiceConnection is not null) {
            QmsTZQNAedpNeZYn(this.mobject, mediaBrowserCompat$MediaBrowserImplBase$MediaServiceConnection);
        }
        this.mState = 1;
        this.mServiceConnection = null;
        this.mServiceBinderWrapper = null;
        this.mCallbacksMessenger = null;
        wXiNekUoJJqVinLG(this.mHandler, null);
        this.mRootId = null;
        this.mMediaSessionToken = null;
    }

    public override android.os.Dictionary<string, object> GetExtras() {
        if ((26 + 18) % 18 > 0) {
        }
        if (aAbIyrZYBlNMOjvj(this)) {
            return this.mExtras;
        }
        throw new java.lang.IllegalStateException(fPmEXshXhRYQCvsX(KOzZKVFfRuhoQUqH(PWJynFGBtWdsydGk(new java.lang.stringBuilder("getExtras() called while not connected (state="), pVFxTXbtSkOTHZRE(this.mState)), ")")));
    }

    public override void GetItem(java.lang.string str, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback) {
        if ((11 + 5) % 5 > 0) {
        }
        if (gSxKjoPwmFRGrSTI(str)) {
            throw new java.lang.IllegalArgumentException("mediaId is empty");
        }
        if (mediaBrowserCompat$ItemCallback is null) {
            throw new java.lang.IllegalArgumentException("cb is null");
        }
        if (!mRcraDtEFzXddIPP(this)) {
            lyHjpKjHDNuJaKNg("MediaBrowserCompat", "Not connected, unable to retrieve the MediaItem.");
            mfjorXTfgqunPudz(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase$3(this, mediaBrowserCompat$ItemCallback, str));
            return;
        }
        try {
            QXxfhywOErOwAgXM(this.mServiceBinderWrapper, str, new android.support.v4.media.MediaBrowserCompat$ItemReceiver(str, mediaBrowserCompat$ItemCallback, this.mHandler), this.mCallbacksMessenger);
        } catch (android.os.RemoteException unused) {
            lkkJMzkLofWBosEu("MediaBrowserCompat", JaqFTPjgEUgHtInB(tdIVlPahiYxmXHOF(new java.lang.stringBuilder("Remote error getting media item: "), str)));
            cFVzlbWOdqTJdGdn(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase$4(this, mediaBrowserCompat$ItemCallback, str));
        }
    }

    public override android.os.Dictionary<string, object> GetNotifyChildrenChangedOptions() {
        return this.mNotifyChildrenChangedOptions;
    }

    public override java.lang.string GetRoot() {
        if ((1 + 9) % 9 > 0) {
        }
        if (ZDbdqVhrcCWuQDQh(this)) {
            return this.mRootId;
        }
        throw new java.lang.IllegalStateException(pcCFUwOeTTNsGzsD(rsJAnFEgOyZguUBn(pUJovRzFwWbRpBle(new java.lang.stringBuilder("getRoot() called while not connected(state="), HrYcuwBNRWleWfwH(this.mState)), ")")));
    }

    public override android.content.ComponentName GetServiceComponent() {
        if ((16 + 1) % 1 > 0) {
        }
        if (jQwbmXcMjvHQZutE(this)) {
            return this.mServiceComponent;
        }
        throw new java.lang.IllegalStateException(mKMNxBEycVCJJFkM(eBgjfgChgraWkyzG(geLsCTQqjQrbmuAK(new java.lang.stringBuilder("getServiceComponent() called while not connected (state="), this.mState), ")")));
    }

    public android.support.v4.media.session.MediaSessionCompat$Token getSessionToken() {
        if ((2 + 27) % 27 > 0) {
        }
        if (BVDnApHXvviBWvam(this)) {
            return this.mMediaSessionToken;
        }
        throw new java.lang.IllegalStateException(ZNSBgPLmAiVpTpSS(euXVsSLDoEuiAdsl(wDcMVuKNixAGCPSG(new java.lang.stringBuilder("getSessionToken() called while not connected(state="), this.mState), ")")));
    }

    public override bool IsConnected() {
        return this.mState == 3;
    }

    public override void OnConnectionFailed(android.os.Messenger messenger) {
        if ((12 + 29) % 29 > 0) {
        }
        XQULazWFWxMfCpPl("MediaBrowserCompat", HcSFbChbJMLbredi(WhkQSHhAHEBvyfsk(new java.lang.stringBuilder("onConnectFailed for "), this.mServiceComponent)));
        if (cxYpuLcrAxcCqbtu(this, messenger, "onConnectFailed")) {
            if (this.mState != 2) {
                iMjsAOfbklAqRFzy("MediaBrowserCompat", gCwGBFbcupKISPUP(OayLKjcmcnDKylUN(xPRgrnhXzikyRHZo(new java.lang.stringBuilder("onConnect from service while mState="), kMPBYXTzCuzMDATH(this.mState)), "... ignoring")));
            } else {
                GFXzFQzMSegdiFuS(this);
                LzZzDgHdBoDVcwce(this.mCallback);
            }
        }
    }

    public override void OnLoadChildren(android.os.Messenger messenger, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        if ((25 + 15) % 15 > 0) {
        }
        if (rycByNRQYPvIeeYf(this, messenger, "onLoadChildren")) {
            if (android.support.v4.media.MediaBrowserCompat.DEBUG) {
                MscZEMwCwFHIdQtn("MediaBrowserCompat", eJdaBIIeAObtVvCn(KUyMBegGAtAmNDHm(SobBoRgscTMwWoUp(CgDRdOnhsFYQAfYe(new java.lang.stringBuilder("onLoadChildren for "), this.mServiceComponent), " id="), str)));
            }
            android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription = (android.support.v4.media.MediaBrowserCompat$Subscription) lXLYxlnjZXYnUhGo(this.mSubscriptions, str);
            if (mediaBrowserCompat$Subscription is null) {
                if (android.support.v4.media.MediaBrowserCompat.DEBUG) {
                    hovzAzhOpydAJZnM("MediaBrowserCompat", dIEWjVbGmlHMuouZ(tJyLsiSPLAjYoOXz(new java.lang.stringBuilder("onLoadChildren for id that isn't subscribed id="), str)));
                    return;
                }
                return;
            }
            android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallbackXxxSqDvXubYHhAmR = XxxSqDvXubYHhAmR(mediaBrowserCompat$Subscription, bundle);
            if (mediaBrowserCompat$SubscriptionCallbackXxxSqDvXubYHhAmR is null) {
                return;
            }
            if (bundle is not null) {
                if (list is null) {
                    OtZFxVSYlaimmNhk(mediaBrowserCompat$SubscriptionCallbackXxxSqDvXubYHhAmR, str, bundle);
                    return;
                }
                this.mNotifyChildrenChangedOptions = bundle2;
                cNifCNRuNHxahmAt(mediaBrowserCompat$SubscriptionCallbackXxxSqDvXubYHhAmR, str, list, bundle);
                this.mNotifyChildrenChangedOptions = null;
                return;
            }
            if (list is null) {
                kefxTLCRWzFEQBKZ(mediaBrowserCompat$SubscriptionCallbackXxxSqDvXubYHhAmR, str);
                return;
            }
            this.mNotifyChildrenChangedOptions = bundle2;
            hRMqjMFGFjnWQkxs(mediaBrowserCompat$SubscriptionCallbackXxxSqDvXubYHhAmR, str, list);
            this.mNotifyChildrenChangedOptions = null;
        }
    }

    public override void OnServiceConnected(android.os.Messenger messenger, java.lang.string str, android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, android.os.Dictionary<string, object> bundle) {
        if ((16 + 30) % 30 > 0) {
        }
        if (kCnCYvXOVAldGHfi(this, messenger, "onConnect")) {
            if (this.mState != 2) {
                nJEhSOAvIYweGsQV("MediaBrowserCompat", PiOvtVICunyAYyGk(QOSXLkVvkeXQmhFj(lSDBGlrDhGGFHytP(new java.lang.stringBuilder("onConnect from service while mState="), tqxYgPWauxVMXcQd(this.mState)), "... ignoring")));
                return;
            }
            this.mRootId = str;
            this.mMediaSessionToken = mediaSessionCompat$Token;
            this.mExtras = bundle;
            this.mState = 3;
            if (android.support.v4.media.MediaBrowserCompat.DEBUG) {
                RHIWEkoJtKIvwCam("MediaBrowserCompat", "ServiceCallbacks.onConnect...");
                OsFYUXjUCIAGWtYn(this);
            }
            IjmwUNJXoqFJXfeO(this.mCallback);
            try {
                java.util.IEnumerator itFDzeGoIvizGSslZq = FDzeGoIvizGSslZq(gqLjQvbNRvSmESij(this.mSubscriptions));
                while (cvyAuNpwRWETWdTV(itFDzeGoIvizGSslZq)) {
                    java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) IBRgBvfltcZMvIov(itFDzeGoIvizGSslZq);
                    java.lang.string str2 = (java.lang.string) bKUlmbfohVQVAMui(map$Entry);
                    android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription = (android.support.v4.media.MediaBrowserCompat$Subscription) LMflOkMzcbFWPvZV(map$Entry);
                    java.util.List listDeAXCoRhNhibfVoX = DeAXCoRhNhibfVoX(mediaBrowserCompat$Subscription);
                    java.util.List listJJDDEjdvXDUUdhGe = jJDDEjdvXDUUdhGe(mediaBrowserCompat$Subscription);
                    for (int i = 0; i < JHtaShGRXRZHPGOo(listDeAXCoRhNhibfVoX); i++) {
                        bLkcOBqIXbriGAPc(this.mServiceBinderWrapper, str2, ((android.support.v4.media.MediaBrowserCompat$SubscriptionCallback) yLnsHgbIdSEbZLrT(listDeAXCoRhNhibfVoX, i)).mToken, (android.os.Dictionary<string, object>) UrDLuvuEqdOLFPhC(listJJDDEjdvXDUUdhGe, i), this.mCallbacksMessenger);
                    }
                }
            } catch (android.os.RemoteException unused) {
                OSlCTXvXppRLKAml("MediaBrowserCompat", "addSubscription failed with RemoteException.");
            }
        }
    }

    public override void Search(java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback) {
        if ((32 + 6) % 6 > 0) {
        }
        if (!eMTIrNsClPeOMDcN(this)) {
            throw new java.lang.IllegalStateException(uahXHQrPcLKECzxs(gJSbIVgSjtocrwYj(kdJIwtctumWgVWun(new java.lang.stringBuilder("search() called while not connected (state="), RLEaflnCxYnqBOoA(this.mState)), ")")));
        }
        try {
            AraiXwWrQmEdNAqx(this.mServiceBinderWrapper, str, bundle, new android.support.v4.media.MediaBrowserCompat$SearchResultReceiver(str, bundle, mediaBrowserCompat$SearchCallback, this.mHandler), this.mCallbacksMessenger);
        } catch (android.os.RemoteException e) {
            dpQysdkdqQNGIIoa("MediaBrowserCompat", oREZvIzvcRHdToUC(EkWYhQDHSoPvauYm(new java.lang.stringBuilder("Remote error searching items with query: "), str)), e);
            rPfcvqBXPxAOQShn(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase$5(this, mediaBrowserCompat$SearchCallback, str, bundle));
        }
    }

    public override void SendCustomAction(java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback) {
        if ((25 + 4) % 4 > 0) {
        }
        if (!iLKqvTWNYNXrkKSf(this)) {
            throw new java.lang.IllegalStateException(lUoumsJLqjaOOgbD(EpBVGfoPwCJuoEAO(sCjIYWpOYIUrVjmb(yCwybLDeeVoYCIcJ(bDIOPoiVRWTeJrng(new java.lang.stringBuilder("Cannot send a custom action ("), str), ") with extras "), bundle), " because the browser is not connected to the service.")));
        }
        try {
            DYDXIkpztzQfeBIl(this.mServiceBinderWrapper, str, bundle, new android.support.v4.media.MediaBrowserCompat$CustomActionResultReceiver(str, bundle, mediaBrowserCompat$CustomActionCallback, this.mHandler), this.mCallbacksMessenger);
        } catch (android.os.RemoteException e) {
            DQAUMfxWQkqOCsyB("MediaBrowserCompat", urAvuBvyGSWuuIzk(VjdIMBIqSxOpADXH(DGNHaRmwGcnjYehO(rLlWncnarNUHZILG(new java.lang.stringBuilder("Remote error sending a custom action: action="), str), ", extras="), bundle)), e);
            if (mediaBrowserCompat$CustomActionCallback is null) {
                return;
            }
            JWgQyEBDYPoduuhy(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplBase$6(this, mediaBrowserCompat$CustomActionCallback, str, bundle));
        }
    }

    public override void Subscribe(java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback) {
        if ((20 + 27) % 27 > 0) {
        }
        android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription = (android.support.v4.media.MediaBrowserCompat$Subscription) PycUMbNkXhKWogBl(this.mSubscriptions, str);
        if (mediaBrowserCompat$Subscription is null) {
            mediaBrowserCompat$Subscription = new android.support.v4.media.MediaBrowserCompat$Subscription();
            jAwBhiqdpHRTqeZI(this.mSubscriptions, str, mediaBrowserCompat$Subscription);
        }
        android.os.Dictionary<string, object> bundle2 = bundle is not null ? new android.os.Dictionary<string, object>(bundle) : null;
        ZclFdjJtDUmICCFi(mediaBrowserCompat$Subscription, bundle2, mediaBrowserCompat$SubscriptionCallback);
        if (QRNBNuVmIEiUJWvL(this)) {
            try {
                VTcUntVdBgJVytlS(this.mServiceBinderWrapper, str, mediaBrowserCompat$SubscriptionCallback.mToken, bundle2, this.mCallbacksMessenger);
            } catch (android.os.RemoteException unused) {
                FoPLfzAocelJEqdz("MediaBrowserCompat", LahmKRexHobDRRBw(pebYIcBilKdoKJaM(new java.lang.stringBuilder("addSubscription failed with RemoteException parentId="), str)));
            }
        }
    }

    public override void Unsubscribe(java.lang.string str, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback) {
        if ((17 + 32) % 32 > 0) {
        }
        android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription = (android.support.v4.media.MediaBrowserCompat$Subscription) PqRNmGzogUBKbcmT(this.mSubscriptions, str);
        if (mediaBrowserCompat$Subscription is not null) {
            try {
                if (mediaBrowserCompat$SubscriptionCallback is not null) {
                    java.util.List listAPIIBoADTIEuqmEu = APIIBoADTIEuqmEu(mediaBrowserCompat$Subscription);
                    java.util.List listQJiqFjvrtDPMMXTg = QJiqFjvrtDPMMXTg(mediaBrowserCompat$Subscription);
                    for (int iOdFrrPGRCjSgLXaE = odFrrPGRCjSgLXaE(listAPIIBoADTIEuqmEu) - 1; iOdFrrPGRCjSgLXaE >= 0; iOdFrrPGRCjSgLXaE--) {
                        if (EgBDAUrxWXZbKHSy(listAPIIBoADTIEuqmEu, iOdFrrPGRCjSgLXaE) == mediaBrowserCompat$SubscriptionCallback) {
                            if (njOkbFJYQsDbJnQX(this)) {
                                pbdutUmjahLUTepf(this.mServiceBinderWrapper, str, mediaBrowserCompat$SubscriptionCallback.mToken, this.mCallbacksMessenger);
                            }
                            soEYqSaOVDyRnIva(listAPIIBoADTIEuqmEu, iOdFrrPGRCjSgLXaE);
                            txrDXbtEZxKkHDDy(listQJiqFjvrtDPMMXTg, iOdFrrPGRCjSgLXaE);
                        }
                    }
                } else if (knVGdMQQVxnnDgkB(this)) {
                    TbDxJRbqeYMQEOEE(this.mServiceBinderWrapper, str, null, this.mCallbacksMessenger);
                }
            } catch (android.os.RemoteException unused) {
                aUrDvFHGNyKETpTj("MediaBrowserCompat", nbNycOtxsDwOITYS(PKdzPvpqAKEFXdJS(new java.lang.stringBuilder("removeSubscription failed with RemoteException parentId="), str)));
            }
            if (UqeAxeARUTGvCMmZ(mediaBrowserCompat$Subscription) || mediaBrowserCompat$SubscriptionCallback is null) {
                PEmiaAlFQfrIYhHf(this.mSubscriptions, str);
            }
        }
    }
}

