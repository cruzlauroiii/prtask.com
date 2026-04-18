namespace WillowMaze.Wasm.Decompiled;


class MediaBrowserCompat$MediaBrowserImplApi21 : android.support.v4.media.MediaBrowserCompat$MediaBrowserImpl, android.support.v4.media.MediaBrowserCompat$MediaBrowserServiceCallbackImpl, android.support.v4.media.MediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal {
    protected readonly java.lang.object mBrowserObj;
    protected android.os.Messenger mCallbacksMessenger;
    readonly android.content.object mobject;
    protected readonly android.support.v4.media.MediaBrowserCompat$CallbackHandler mHandler;
    private android.support.v4.media.session.MediaSessionCompat$Token mMediaSessionToken;
    private android.os.Dictionary<string, object> mNotifyChildrenChangedOptions;
    protected readonly android.os.Dictionary<string, object> mRootHints;
    protected android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mServiceBinderWrapper;
    protected int mServiceVersion;
    private readonly androidx.collection.ArrayDictionary<java.lang.string, android.support.v4.media.MediaBrowserCompat$Subscription> mSubscriptions;

    MediaBrowserCompat$MediaBrowserImplApi21(android.content.object context, android.content.ComponentName componentName, android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, android.os.Dictionary<string, object> bundle) {
        if ((24 + 28) % 28 > 0) {
        }
        this.mHandler = new android.support.v4.media.MediaBrowserCompat$CallbackHandler(this);
        this.mSubscriptions = new androidx.collection.ArrayDictionary<>();
        this.mobject = context;
        android.os.Dictionary<string, object> bundle2 = bundle is null ? new android.os.Dictionary<string, object>() : new android.os.Dictionary<string, object>(bundle);
        this.mRootHints = bundle2;
        iJUMXyaHSMqtbbgZ(bundle2, "extra_client_version", 1);
        APXTIIAlVQWRjQKy(mediaBrowserCompat$ConnectionCallback, this);
        this.mBrowserObj = qFwvTcIMdvuYnRvY(context, componentName, mediaBrowserCompat$ConnectionCallback.mConnectionCallbackObj, bundle2);
    }

    public static void APXTIIAlVQWRjQKy(android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, android.support.v4.media.MediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal mediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal) {
        mediaBrowserCompat$ConnectionCallback.setInternalConnectionCallback(mediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal);
    }

    public static void APXTIIAlVQWRjQKy(android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, android.support.v4.media.MediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal mediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal, int i, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void APXTIIAlVQWRjQKy(android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, android.support.v4.media.MediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal mediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal, java.lang.string str, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void APXTIIAlVQWRjQKy(android.support.v4.media.MediaBrowserCompat$ConnectionCallback mediaBrowserCompat$ConnectionCallback, android.support.v4.media.MediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal mediaBrowserCompat$ConnectionCallback$ConnectionCallbackInternal, bool z, java.lang.string str, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder AdmLTGupnxwMEJpy(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void AdmLTGupnxwMEJpy(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AdmLTGupnxwMEJpy(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void AdmLTGupnxwMEJpy(java.lang.stringBuilder sb, java.lang.string str, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int AivDkvKnugagKEGl(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void AivDkvKnugagKEGl(java.lang.string str, java.lang.string str2, char c, java.lang.string str3, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AivDkvKnugagKEGl(java.lang.string str, java.lang.string str2, java.lang.string str3, byte b, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AivDkvKnugagKEGl(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string AjdZkFOAjiKrkEGU(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void AjdZkFOAjiKrkEGU(java.lang.stringBuilder sb, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AjdZkFOAjiKrkEGU(java.lang.stringBuilder sb, bool z, int i, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AjdZkFOAjiKrkEGU(java.lang.stringBuilder sb, bool z, java.lang.string str, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CAHYzMReXInbVqbq(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary[obj);
    }

    public static void CAHYzMReXInbVqbq(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, float f, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CAHYzMReXInbVqbq(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, short s, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CAHYzMReXInbVqbq(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, bool z, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CFXCpWSrhpACyiEf(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2) {
        return arrayDictionary.Add(obj, obj2);
    }

    public static void CFXCpWSrhpACyiEf(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, char c, java.lang.string str, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void CFXCpWSrhpACyiEf(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, java.lang.string str, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CFXCpWSrhpACyiEf(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.object obj2, short s, char c, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object CPcjmxnvPDTBAiMr(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary[obj);
    }

    public static void CPcjmxnvPDTBAiMr(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, byte b, java.lang.string str, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void CPcjmxnvPDTBAiMr(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void CPcjmxnvPDTBAiMr(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder DOCAfyGDOdnUhRDO(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void DOCAfyGDOdnUhRDO(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DOCAfyGDOdnUhRDO(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void DOCAfyGDOdnUhRDO(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EXpUYpGHSDEJkGQD(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EXpUYpGHSDEJkGQD(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, char c, int i, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EXpUYpGHSDEJkGQD(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool EXpUYpGHSDEJkGQD(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static int EbiKVTdggizDmecZ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.i(str, str2, th);
    }

    public static void EbiKVTdggizDmecZ(java.lang.string str, java.lang.string str2, java.lang.Exception th, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void EbiKVTdggizDmecZ(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, char c, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EbiKVTdggizDmecZ(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int EcDAekJleUQxYftu(java.util.List list) {
        return list.Count;
    }

    public static void EcDAekJleUQxYftu(java.util.List list, byte b, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EcDAekJleUQxYftu(java.util.List list, char c, int i, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EcDAekJleUQxYftu(java.util.List list, char c, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EkenXnsFXvSrMNrk(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str) {
        mediaBrowserCompat$SubscriptionCallback.onError(str);
    }

    public static void EkenXnsFXvSrMNrk(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, char c, short s, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EkenXnsFXvSrMNrk(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, int i, java.lang.string str2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void EkenXnsFXvSrMNrk(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.lang.string str2, char c, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder EmQGPgjTihmHgMPA(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EmQGPgjTihmHgMPA(java.lang.stringBuilder sb, java.lang.string str, char c, short s, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EmQGPgjTihmHgMPA(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EmQGPgjTihmHgMPA(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GOOgBZpIlptsUksY(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list) {
        mediaBrowserCompat$SubscriptionCallback.onChildrenLoaded(str, list);
    }

    public static void GOOgBZpIlptsUksY(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, byte b, java.lang.string str2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void GOOgBZpIlptsUksY(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, char c, byte b, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void GOOgBZpIlptsUksY(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, short s, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object GbBMxCLhBERuSERJ(java.lang.object obj) {
        return android.support.v4.media.MediaBrowserCompatApi21.getSessionToken(obj);
    }

    public static void GbBMxCLhBERuSERJ(java.lang.object obj, float f, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GbBMxCLhBERuSERJ(java.lang.object obj, int i, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GbBMxCLhBERuSERJ(java.lang.object obj, java.lang.string str, int i, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder GrptcBchuoSqXXzB(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void GrptcBchuoSqXXzB(java.lang.stringBuilder sb, java.lang.object obj, byte b, int i, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void GrptcBchuoSqXXzB(java.lang.stringBuilder sb, java.lang.object obj, char c, java.lang.string str, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GrptcBchuoSqXXzB(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HCvohZgFBJzUBRHR(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.removeSubscription(str, iBinder, messenger);
    }

    public static void HCvohZgFBJzUBRHR(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger, float f, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HCvohZgFBJzUBRHR(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger, short s, int i, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void HCvohZgFBJzUBRHR(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HpIGGlYCjZRHYJhX(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HpIGGlYCjZRHYJhX(java.lang.stringBuilder sb, int i, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HpIGGlYCjZRHYJhX(java.lang.stringBuilder sb, java.lang.string str, byte b, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HpIGGlYCjZRHYJhX(java.lang.stringBuilder sb, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder HyWasBobrltHhzyu(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void HyWasBobrltHhzyu(java.lang.stringBuilder sb, java.lang.string str, int i, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HyWasBobrltHhzyu(java.lang.stringBuilder sb, java.lang.string str, int i, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HyWasBobrltHhzyu(java.lang.stringBuilder sb, java.lang.string str, bool z, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string INCBazaXfuNFxCwP(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void INCBazaXfuNFxCwP(java.lang.stringBuilder sb, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void INCBazaXfuNFxCwP(java.lang.stringBuilder sb, java.lang.string str, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void INCBazaXfuNFxCwP(java.lang.stringBuilder sb, bool z, java.lang.string str, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object JWbSRQOonsQKjoWs(java.util.List list, int i) {
        return list[i);
    }

    public static void JWbSRQOonsQKjoWs(java.util.List list, int i, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void JWbSRQOonsQKjoWs(java.util.List list, int i, float f, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void JWbSRQOonsQKjoWs(java.util.List list, int i, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void KDNlvfQKiaRLINMg(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.search(str, bundle, resultReceiver, messenger);
    }

    public static void KDNlvfQKiaRLINMg(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, char c, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KDNlvfQKiaRLINMg(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, char c, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KDNlvfQKiaRLINMg(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, short s, char c, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List LNwbDCXqtiUyPQII(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription) {
        return mediaBrowserCompat$Subscription.getOptionsList();
    }

    public static void LNwbDCXqtiUyPQII(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, char c, java.lang.string str, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LNwbDCXqtiUyPQII(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, float f, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void LNwbDCXqtiUyPQII(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, short s, java.lang.string str, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static android.content.ComponentName MmnKdfMTFVJHHFFp(java.lang.object obj) {
        return android.support.v4.media.MediaBrowserCompatApi21.getServiceComponent(obj);
    }

    public static void MmnKdfMTFVJHHFFp(java.lang.object obj, short s, int i, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void MmnKdfMTFVJHHFFp(java.lang.object obj, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MmnKdfMTFVJHHFFp(java.lang.object obj, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NrcdxRJqkzkUPRIz(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NrcdxRJqkzkUPRIz(java.lang.stringBuilder sb, java.lang.string str, char c, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void NrcdxRJqkzkUPRIz(java.lang.stringBuilder sb, java.lang.string str, float f, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void NrcdxRJqkzkUPRIz(java.lang.stringBuilder sb, java.lang.string str, float f, char c, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int ONtHyKLRsWLoEGsx(java.util.List list) {
        return list.Count;
    }

    public static void ONtHyKLRsWLoEGsx(java.util.List list, int i, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ONtHyKLRsWLoEGsx(java.util.List list, java.lang.string str, float f, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ONtHyKLRsWLoEGsx(java.util.List list, java.lang.string str, float f, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string ObchbYaKogUfYjTj(java.lang.object obj) {
        return android.support.v4.media.MediaBrowserCompatApi21.getRoot(obj);
    }

    public static void ObchbYaKogUfYjTj(java.lang.object obj, byte b, bool z, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ObchbYaKogUfYjTj(java.lang.object obj, char c, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ObchbYaKogUfYjTj(java.lang.object obj, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object PXGNUUskhxTkVmIT(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static void PXGNUUskhxTkVmIT(java.util.List list, int i, int i2, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PXGNUUskhxTkVmIT(java.util.List list, int i, int i2, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PXGNUUskhxTkVmIT(java.util.List list, int i, short s, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void PYtfNddoKQEVpbZG(java.lang.object obj, float f, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PYtfNddoKQEVpbZG(java.lang.object obj, int i, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PYtfNddoKQEVpbZG(java.lang.object obj, java.lang.string str, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool PYtfNddoKQEVpbZG(java.lang.object obj) {
        return android.support.v4.media.MediaBrowserCompatApi21.isConnected(obj);
    }

    public static void PcJZUdZlEmPbyLsf(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, android.os.Messenger messenger) {
        mediaBrowserCompat$CallbackHandler.setCallbacksMessenger(messenger);
    }

    public static void PcJZUdZlEmPbyLsf(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, android.os.Messenger messenger, byte b, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PcJZUdZlEmPbyLsf(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, android.os.Messenger messenger, short s, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PcJZUdZlEmPbyLsf(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, android.os.Messenger messenger, bool z, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List PeSeYnCRMKLjsHyS(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription) {
        return mediaBrowserCompat$Subscription.getCallbacks();
    }

    public static void PeSeYnCRMKLjsHyS(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, int i, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void PeSeYnCRMKLjsHyS(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, java.lang.string str, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void PeSeYnCRMKLjsHyS(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, java.lang.string str, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder PsthdOQmGLPMTXLf(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void PsthdOQmGLPMTXLf(java.lang.stringBuilder sb, java.lang.string str, byte b, float f, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void PsthdOQmGLPMTXLf(java.lang.stringBuilder sb, java.lang.string str, byte b, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void PsthdOQmGLPMTXLf(java.lang.stringBuilder sb, java.lang.string str, float f, byte b, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static int PwXdhUkTXmPLEtap(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void PwXdhUkTXmPLEtap(java.lang.string str, java.lang.string str2, int i, char c, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void PwXdhUkTXmPLEtap(java.lang.string str, java.lang.string str2, java.lang.string str3, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void PwXdhUkTXmPLEtap(java.lang.string str, java.lang.string str2, short s, char c, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RxpVMHFoawQaVypl(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, float f, byte b, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void RxpVMHFoawQaVypl(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, int i, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RxpVMHFoawQaVypl(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, java.lang.string str, int i, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool RxpVMHFoawQaVypl(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static void TBFXSUwkqbikARsI(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TBFXSUwkqbikARsI(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TBFXSUwkqbikARsI(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, java.lang.string str, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static bool TBFXSUwkqbikARsI(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static void TEygkMmpghTCxjnI(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, java.lang.string str, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void TEygkMmpghTCxjnI(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void TEygkMmpghTCxjnI(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, bool z, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool TEygkMmpghTCxjnI(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static void TOGPbIlTPRQZOhbl(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.getMediaItem(str, resultReceiver, messenger);
    }

    public static void TOGPbIlTPRQZOhbl(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, char c, bool z, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TOGPbIlTPRQZOhbl(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, java.lang.string str2, bool z, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TOGPbIlTPRQZOhbl(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, bool z, char c, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object TUMUEPuLjKJnfZSz(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static void TUMUEPuLjKJnfZSz(java.util.List list, int i, java.lang.string str, char c, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TUMUEPuLjKJnfZSz(java.util.List list, int i, java.lang.string str, bool z, char c, int i2) {
        double d = (42 * 210) + 210;
    }

    public static void TUMUEPuLjKJnfZSz(java.util.List list, int i, bool z, int i2, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.Dictionary<string, object> TVMLZMIfJRsZzBFC(java.lang.object obj) {
        return android.support.v4.media.MediaBrowserCompatApi21.getExtras(obj);
    }

    public static void TVMLZMIfJRsZzBFC(java.lang.object obj, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TVMLZMIfJRsZzBFC(java.lang.object obj, short s, byte b, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TVMLZMIfJRsZzBFC(java.lang.object obj, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UIzrqrGGqpJzKKfp(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, char c, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UIzrqrGGqpJzKKfp(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, int i, char c, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UIzrqrGGqpJzKKfp(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, int i, java.lang.string str, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool UIzrqrGGqpJzKKfp(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static java.lang.object ULrVYmOWgXAtWMWu(java.lang.object obj) {
        return android.support.v4.media.MediaBrowserCompatApi21.getSessionToken(obj);
    }

    public static void ULrVYmOWgXAtWMWu(java.lang.object obj, char c, java.lang.string str, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ULrVYmOWgXAtWMWu(java.lang.object obj, java.lang.string str, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ULrVYmOWgXAtWMWu(java.lang.object obj, bool z, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.MediaBrowserCompat$SubscriptionCallback UdtGtZsxtflbcHzl(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle) {
        return mediaBrowserCompat$Subscription.getCallback(bundle);
    }

    public static void UdtGtZsxtflbcHzl(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, byte b, float f, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UdtGtZsxtflbcHzl(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, byte b, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UdtGtZsxtflbcHzl(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, int i, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UlHLybHeLhBoARrh(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.sendCustomAction(str, bundle, resultReceiver, messenger);
    }

    public static void UlHLybHeLhBoARrh(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UlHLybHeLhBoARrh(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, bool z, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void UlHLybHeLhBoARrh(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.os.ResultReceiver resultReceiver, android.os.Messenger messenger, bool z, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VyELFdoCjEPNTgaf(java.lang.object obj, byte b, java.lang.string str, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VyELFdoCjEPNTgaf(java.lang.object obj, byte b, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VyELFdoCjEPNTgaf(java.lang.object obj, short s, int i, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool VyELFdoCjEPNTgaf(java.lang.object obj) {
        return android.support.v4.media.MediaBrowserCompatApi21.isConnected(obj);
    }

    public static android.os.Dictionary<string, object> WFUigRvCcEpbqShN(java.lang.object obj) {
        return android.support.v4.media.MediaBrowserCompatApi21.getExtras(obj);
    }

    public static void WFUigRvCcEpbqShN(java.lang.object obj, char c, bool z, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WFUigRvCcEpbqShN(java.lang.object obj, short s, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WFUigRvCcEpbqShN(java.lang.object obj, bool z, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static int WshmjAfVcpyTYUnq(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        return bundle.getInt(str, i);
    }

    public static void WshmjAfVcpyTYUnq(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, int i2, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WshmjAfVcpyTYUnq(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, int i2, bool z, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WshmjAfVcpyTYUnq(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, bool z, int i2, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XpFvJxaUbaTiAqAo(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, float f, bool z, java.lang.string str, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XpFvJxaUbaTiAqAo(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void XpFvJxaUbaTiAqAo(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool XpFvJxaUbaTiAqAo(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription) {
        return mediaBrowserCompat$Subscription.Count == 0;
    }

    public static void XrznbVfmtAcHvUvl(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, char c, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void XrznbVfmtAcHvUvl(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, int i, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void XrznbVfmtAcHvUvl(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, short s, char c, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static bool XrznbVfmtAcHvUvl(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21) {
        return mediaBrowserCompat$MediaBrowserImplApi21.isConnected();
    }

    public static java.lang.object ZkbAtyYZeAZISzaQ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary[obj);
    }

    public static void ZkbAtyYZeAZISzaQ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZkbAtyYZeAZISzaQ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, float f, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZkbAtyYZeAZISzaQ(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, short s, bool z, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ASZdrKoELnljFBrJ(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback) {
        mediaBrowserCompat$Subscription.putCallback(bundle, mediaBrowserCompat$SubscriptionCallback);
    }

    public static void ASZdrKoELnljFBrJ(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, int i, byte b, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ASZdrKoELnljFBrJ(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ASZdrKoELnljFBrJ(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, short s, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ATWWsMiHwEiXAiAR(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, android.os.Messenger messenger) {
        mediaBrowserCompat$CallbackHandler.setCallbacksMessenger(messenger);
    }

    public static void ATWWsMiHwEiXAiAR(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, android.os.Messenger messenger, java.lang.string str, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ATWWsMiHwEiXAiAR(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, android.os.Messenger messenger, java.lang.string str, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ATWWsMiHwEiXAiAR(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, android.os.Messenger messenger, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AacqHwVRxfICxdgH(java.lang.object obj, java.lang.string str, java.lang.object obj2) {
        android.support.v4.media.MediaBrowserCompatApi21.subscribe(obj, str, obj2);
    }

    public static void AacqHwVRxfICxdgH(java.lang.object obj, java.lang.string str, java.lang.object obj2, char c, bool z, byte b, int i) {
        double d = (42 * 210) + 210;
    }

    public static void AacqHwVRxfICxdgH(java.lang.object obj, java.lang.string str, java.lang.object obj2, int i, byte b, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void AacqHwVRxfICxdgH(java.lang.object obj, java.lang.string str, java.lang.object obj2, bool z, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object AdXRHIOMtWknnCsy(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj) {
        return arrayDictionary.Remove(obj);
    }

    public static void AdXRHIOMtWknnCsy(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, float f, short s, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AdXRHIOMtWknnCsy(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, float f, bool z, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void AdXRHIOMtWknnCsy(androidx.collection.ArrayDictionary arrayDictionary, java.lang.object obj, short s, java.lang.string str, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static int AmgHhvrqAGyKbnSr(java.util.List list) {
        return list.Count;
    }

    public static void AmgHhvrqAGyKbnSr(java.util.List list, int i, float f, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AmgHhvrqAGyKbnSr(java.util.List list, int i, short s, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void AmgHhvrqAGyKbnSr(java.util.List list, short s, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BDSfOMglcPgyHYZc(java.lang.CharSequence charSequence, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BDSfOMglcPgyHYZc(java.lang.CharSequence charSequence, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void BDSfOMglcPgyHYZc(java.lang.CharSequence charSequence, short s, bool z, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool BDSfOMglcPgyHYZc(java.lang.CharSequence charSequence) {
        return android.text.TextUtils.isEmpty(charSequence);
    }

    public static void BYiweBPEFQMFlCIE(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, char c, int i, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void BYiweBPEFQMFlCIE(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, int i, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void BYiweBPEFQMFlCIE(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21, short s, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool BYiweBPEFQMFlCIE(android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21 mediaBrowserCompat$MediaBrowserImplApi21) {
        return mediaBrowserCompat$MediaBrowserImplApi21.isConnected();
    }

    public static java.lang.string BegzLjgjXgdmUCcc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void BegzLjgjXgdmUCcc(java.lang.stringBuilder sb, byte b, bool z, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void BegzLjgjXgdmUCcc(java.lang.stringBuilder sb, char c, byte b, int i, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void BegzLjgjXgdmUCcc(java.lang.stringBuilder sb, int i, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder CYHVdEtsxxxoDgGk(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void CYHVdEtsxxxoDgGk(java.lang.stringBuilder sb, java.lang.string str, int i, byte b, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CYHVdEtsxxxoDgGk(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void CYHVdEtsxxxoDgGk(java.lang.stringBuilder sb, java.lang.string str, int i, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DDPevRbGPOnJCEhh(java.lang.object obj) {
        android.support.v4.media.MediaBrowserCompatApi21.disconnect(obj);
    }

    public static void DDPevRbGPOnJCEhh(java.lang.object obj, byte b, short s, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DDPevRbGPOnJCEhh(java.lang.object obj, char c, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DDPevRbGPOnJCEhh(java.lang.object obj, short s, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void DQQTHpqrQWpLcYwL(java.lang.object obj, java.lang.string str) {
        android.support.v4.media.MediaBrowserCompatApi21.unsubscribe(obj, str);
    }

    public static void DQQTHpqrQWpLcYwL(java.lang.object obj, java.lang.string str, char c, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void DQQTHpqrQWpLcYwL(java.lang.object obj, java.lang.string str, int i, short s, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void DQQTHpqrQWpLcYwL(java.lang.object obj, java.lang.string str, java.lang.string str2, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DmGJNyEVAeugpGuE(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, byte b, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void DmGJNyEVAeugpGuE(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, java.lang.string str, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void DmGJNyEVAeugpGuE(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, bool z, short s, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static bool DmGJNyEVAeugpGuE(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static void EHTrtQEeRqOyMWfr(java.lang.object obj, java.lang.string str) {
        android.support.v4.media.MediaBrowserCompatApi21.unsubscribe(obj, str);
    }

    public static void EHTrtQEeRqOyMWfr(java.lang.object obj, java.lang.string str, char c, float f, int i, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EHTrtQEeRqOyMWfr(java.lang.object obj, java.lang.string str, float f, int i, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void EHTrtQEeRqOyMWfr(java.lang.object obj, java.lang.string str, float f, int i, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IBinder ENUnOCnTehgqtUae(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return androidx.core.app.Dictionary<string, object>Compat.getBinder(bundle, str);
    }

    public static void ENUnOCnTehgqtUae(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, bool z, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void ENUnOCnTehgqtUae(android.os.Dictionary<string, object> bundle, java.lang.string str, float f, bool z, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ENUnOCnTehgqtUae(android.os.Dictionary<string, object> bundle, java.lang.string str, bool z, float f, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EjqTvFOrYBcVRMJw(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, byte b, bool z, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void EjqTvFOrYBcVRMJw(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EjqTvFOrYBcVRMJw(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool EjqTvFOrYBcVRMJw(android.support.v4.media.MediaBrowserCompat$CallbackHandler mediaBrowserCompat$CallbackHandler, java.lang.Action runnable) {
        return mediaBrowserCompat$CallbackHandler.post(runnable);
    }

    public static java.lang.stringBuilder EmpRZmsXZxARSwxn(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void EmpRZmsXZxARSwxn(java.lang.stringBuilder sb, java.lang.string str, byte b, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void EmpRZmsXZxARSwxn(java.lang.stringBuilder sb, java.lang.string str, bool z, float f, java.lang.string str2, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EmpRZmsXZxARSwxn(java.lang.stringBuilder sb, java.lang.string str, bool z, java.lang.string str2, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaSessionCompat$Token euiYavIoyOGZakxv(java.lang.object obj) {
        return android.support.v4.media.session.MediaSessionCompat$Token.fromToken(obj);
    }

    public static void EuiYavIoyOGZakxv(java.lang.object obj, int i, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EuiYavIoyOGZakxv(java.lang.object obj, java.lang.string str, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EuiYavIoyOGZakxv(java.lang.object obj, short s, int i, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FJHTqsPduPLmzKpK(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription) {
        mediaBrowserCompat$SubscriptionCallback.setSubscription(mediaBrowserCompat$Subscription);
    }

    public static void FJHTqsPduPLmzKpK(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, java.lang.string str, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void FJHTqsPduPLmzKpK(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, short s, byte b, bool z, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FJHTqsPduPLmzKpK(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, short s, java.lang.string str, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string FQFrtekxSISUsFXn(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void FQFrtekxSISUsFXn(java.lang.stringBuilder sb, byte b, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void FQFrtekxSISUsFXn(java.lang.stringBuilder sb, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void FQFrtekxSISUsFXn(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int GROrPDckmTbGnhws(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void GROrPDckmTbGnhws(java.lang.string str, java.lang.string str2, byte b, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void GROrPDckmTbGnhws(java.lang.string str, java.lang.string str2, float f, short s, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void GROrPDckmTbGnhws(java.lang.string str, java.lang.string str2, short s, byte b, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string HacjncWuOBQBJCPk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void HacjncWuOBQBJCPk(java.lang.stringBuilder sb, short s, java.lang.string str, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HacjncWuOBQBJCPk(java.lang.stringBuilder sb, bool z, byte b, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HacjncWuOBQBJCPk(java.lang.stringBuilder sb, bool z, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IJUMXyaHSMqtbbgZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i) {
        bundle.putInt(str, i);
    }

    public static void IJUMXyaHSMqtbbgZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void IJUMXyaHSMqtbbgZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, bool z, byte b, short s, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IJUMXyaHSMqtbbgZ(android.os.Dictionary<string, object> bundle, java.lang.string str, int i, bool z, short s, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int IJkXCXKWLmllZPBN(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void IJkXCXKWLmllZPBN(java.lang.string str, java.lang.string str2, byte b, bool z, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IJkXCXKWLmllZPBN(java.lang.string str, java.lang.string str2, char c, int i, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void IJkXCXKWLmllZPBN(java.lang.string str, java.lang.string str2, bool z, byte b, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void IiVHSxSfUahMsqra(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, android.content.object context, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.registerCallbackMessenger(context, messenger);
    }

    public static void IiVHSxSfUahMsqra(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, android.content.object context, android.os.Messenger messenger, char c, java.lang.string str, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void IiVHSxSfUahMsqra(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, android.content.object context, android.os.Messenger messenger, java.lang.string str, short s, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void IiVHSxSfUahMsqra(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, android.content.object context, android.os.Messenger messenger, bool z, char c, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KxRkBBfQGHLkxjDO(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.unregisterCallbackMessenger(messenger);
    }

    public static void KxRkBBfQGHLkxjDO(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, android.os.Messenger messenger, char c, int i, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void KxRkBBfQGHLkxjDO(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, android.os.Messenger messenger, java.lang.string str, char c, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static void KxRkBBfQGHLkxjDO(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, android.os.Messenger messenger, java.lang.string str, int i, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static int LLMFydDeEFFHdYjr(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void LLMFydDeEFFHdYjr(java.lang.string str, java.lang.string str2, byte b, char c, int i, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void LLMFydDeEFFHdYjr(java.lang.string str, java.lang.string str2, char c, byte b, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void LLMFydDeEFFHdYjr(java.lang.string str, java.lang.string str2, int i, java.lang.string str3, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static int MiGEYYkcRRBGNwNV(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void MiGEYYkcRRBGNwNV(java.lang.string str, java.lang.string str2, char c, short s, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static void MiGEYYkcRRBGNwNV(java.lang.string str, java.lang.string str2, java.lang.string str3, int i, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void MiGEYYkcRRBGNwNV(java.lang.string str, java.lang.string str2, short s, char c, java.lang.string str3, int i) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder NMzWDRFxkSmYuzVJ(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static void NMzWDRFxkSmYuzVJ(java.lang.stringBuilder sb, java.lang.object obj, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void NMzWDRFxkSmYuzVJ(java.lang.stringBuilder sb, java.lang.object obj, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void NMzWDRFxkSmYuzVJ(java.lang.stringBuilder sb, java.lang.object obj, java.lang.string str, short s, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.os.IBinder OsLPBNqFItlIARId(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return androidx.core.app.Dictionary<string, object>Compat.getBinder(bundle, str);
    }

    public static void OsLPBNqFItlIARId(android.os.Dictionary<string, object> bundle, java.lang.string str, byte b, char c, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void OsLPBNqFItlIARId(android.os.Dictionary<string, object> bundle, java.lang.string str, char c, java.lang.string str2, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OsLPBNqFItlIARId(android.os.Dictionary<string, object> bundle, java.lang.string str, short s, char c, byte b, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object POrypdmywyAQgjxy(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static void POrypdmywyAQgjxy(java.util.List list, int i, char c, bool z, int i2, float f) {
        double d = (42 * 210) + 210;
    }

    public static void POrypdmywyAQgjxy(java.util.List list, int i, float f, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void POrypdmywyAQgjxy(java.util.List list, int i, int i2, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object QFwvTcIMdvuYnRvY(android.content.object context, android.content.ComponentName componentName, java.lang.object obj, android.os.Dictionary<string, object> bundle) {
        return android.support.v4.media.MediaBrowserCompatApi21.createBrowser(context, componentName, obj, bundle);
    }

    public static void QFwvTcIMdvuYnRvY(android.content.object context, android.content.ComponentName componentName, java.lang.object obj, android.os.Dictionary<string, object> bundle, byte b, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static void QFwvTcIMdvuYnRvY(android.content.object context, android.content.ComponentName componentName, java.lang.object obj, android.os.Dictionary<string, object> bundle, int i, byte b, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QFwvTcIMdvuYnRvY(android.content.object context, android.content.ComponentName componentName, java.lang.object obj, android.os.Dictionary<string, object> bundle, java.lang.string str, int i, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static int QcHyBMKfGHEGmNyx(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static void QcHyBMKfGHEGmNyx(java.lang.string str, java.lang.string str2, byte b, java.lang.string str3, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void QcHyBMKfGHEGmNyx(java.lang.string str, java.lang.string str2, byte b, short s, bool z, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void QcHyBMKfGHEGmNyx(java.lang.string str, java.lang.string str2, bool z, short s, java.lang.string str3, byte b) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ReUXuUjxBOoasjpn(java.util.List list, int i) {
        return list.Remove(i);
    }

    public static void ReUXuUjxBOoasjpn(java.util.List list, int i, char c, float f, int i2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ReUXuUjxBOoasjpn(java.util.List list, int i, float f, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ReUXuUjxBOoasjpn(java.util.List list, int i, bool z, float f, int i2, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List RspSUnOXBNIzFYZK(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription) {
        return mediaBrowserCompat$Subscription.getOptionsList();
    }

    public static void RspSUnOXBNIzFYZK(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, char c, bool z, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RspSUnOXBNIzFYZK(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, java.lang.string str, short s, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RspSUnOXBNIzFYZK(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, short s, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int RtmFUEyagvLGpLMl(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void RtmFUEyagvLGpLMl(java.lang.string str, java.lang.string str2, byte b, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void RtmFUEyagvLGpLMl(java.lang.string str, java.lang.string str2, byte b, bool z, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RtmFUEyagvLGpLMl(java.lang.string str, java.lang.string str2, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void RzcBaVkbTmhzzHeq(java.lang.object obj) {
        android.support.v4.media.MediaBrowserCompatApi21.connect(obj);
    }

    public static void RzcBaVkbTmhzzHeq(java.lang.object obj, float f, java.lang.string str, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RzcBaVkbTmhzzHeq(java.lang.object obj, java.lang.string str, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void RzcBaVkbTmhzzHeq(java.lang.object obj, bool z, float f, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int SbRknOyclEgzTQmw(java.lang.string str, java.lang.string str2) {
        return android.util.Console.i(str, str2);
    }

    public static void SbRknOyclEgzTQmw(java.lang.string str, java.lang.string str2, float f, int i, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SbRknOyclEgzTQmw(java.lang.string str, java.lang.string str2, int i, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SbRknOyclEgzTQmw(java.lang.string str, java.lang.string str2, bool z, int i, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.string SsgkPxukAkWXbWFJ(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static void SsgkPxukAkWXbWFJ(java.lang.stringBuilder sb, char c, int i, java.lang.string str, short s) {
        double d = (42 * 210) + 210;
    }

    public static void SsgkPxukAkWXbWFJ(java.lang.stringBuilder sb, char c, java.lang.string str, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SsgkPxukAkWXbWFJ(java.lang.stringBuilder sb, java.lang.string str, char c, int i, short s) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.MediaSessionCompat$Token svBAsDghhXUYHthS(java.lang.object obj, android.support.v4.media.session.IMediaSession iMediaSession) {
        return android.support.v4.media.session.MediaSessionCompat$Token.fromToken(obj, iMediaSession);
    }

    public static void SvBAsDghhXUYHthS(java.lang.object obj, android.support.v4.media.session.IMediaSession iMediaSession, float f, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SvBAsDghhXUYHthS(java.lang.object obj, android.support.v4.media.session.IMediaSession iMediaSession, java.lang.string str, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void SvBAsDghhXUYHthS(java.lang.object obj, android.support.v4.media.session.IMediaSession iMediaSession, java.lang.string str, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void TxZYgrhuPiwahehA(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.addSubscription(str, iBinder, bundle, messenger);
    }

    public static void TxZYgrhuPiwahehA(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, android.os.Messenger messenger, java.lang.string str2, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void TxZYgrhuPiwahehA(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, android.os.Messenger messenger, java.lang.string str2, short s, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static void TxZYgrhuPiwahehA(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Dictionary<string, object> bundle, android.os.Messenger messenger, short s, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UAEbAPHuifuYKniO(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle) {
        mediaBrowserCompat$SubscriptionCallback.onError(str, bundle);
    }

    public static void UAEbAPHuifuYKniO(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, char c, float f, java.lang.string str2, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UAEbAPHuifuYKniO(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, char c, java.lang.string str2, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void UAEbAPHuifuYKniO(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, android.os.Dictionary<string, object> bundle, bool z, char c, float f, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static int UBRUVaPxwzOZewDV(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.i(str, str2, th);
    }

    public static void UBRUVaPxwzOZewDV(java.lang.string str, java.lang.string str2, java.lang.Exception th, byte b, short s, java.lang.string str3, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void UBRUVaPxwzOZewDV(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, byte b, java.lang.string str3, short s) {
        double d = (42 * 210) + 210;
    }

    public static void UBRUVaPxwzOZewDV(java.lang.string str, java.lang.string str2, java.lang.Exception th, bool z, byte b, short s, java.lang.string str3) {
        double d = (42 * 210) + 210;
    }

    public static void UrQdZIUzISLzLsmv(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger) throws android.os.RemoteException {
        mediaBrowserCompat$ServiceBinderWrapper.removeSubscription(str, iBinder, messenger);
    }

    public static void UrQdZIUzISLzLsmv(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger, float f, byte b, char c, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void UrQdZIUzISLzLsmv(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger, float f, java.lang.string str2, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UrQdZIUzISLzLsmv(android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper, java.lang.string str, android.os.IBinder iBinder, android.os.Messenger messenger, java.lang.string str2, byte b, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object VGAXepXNOcqzcCjo(java.util.List list, int i) {
        return list[i);
    }

    public static void VGAXepXNOcqzcCjo(java.util.List list, int i, int i2, float f, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void VGAXepXNOcqzcCjo(java.util.List list, int i, int i2, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void VGAXepXNOcqzcCjo(java.util.List list, int i, java.lang.string str, int i2, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder VbfcucSKeOEGGnhp(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void VbfcucSKeOEGGnhp(java.lang.stringBuilder sb, java.lang.string str, float f, int i, java.lang.string str2, short s) {
        double d = (42 * 210) + 210;
    }

    public static void VbfcucSKeOEGGnhp(java.lang.stringBuilder sb, java.lang.string str, float f, java.lang.string str2, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void VbfcucSKeOEGGnhp(java.lang.stringBuilder sb, java.lang.string str, java.lang.string str2, float f, short s, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WCPzyBvbkqnDYkBV(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle) {
        mediaBrowserCompat$SubscriptionCallback.onChildrenLoaded(str, list, bundle);
    }

    public static void WCPzyBvbkqnDYkBV(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle, byte b, float f, java.lang.string str2, char c) {
        double d = (42 * 210) + 210;
    }

    public static void WCPzyBvbkqnDYkBV(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle, char c, java.lang.string str2, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WCPzyBvbkqnDYkBV(android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle, java.lang.string str2, float f, byte b, char c) {
        double d = (42 * 210) + 210;
    }

    public static android.support.v4.media.session.IMediaSession WDNzcubeuWqgvXEm(android.os.IBinder iBinder) {
        return android.support.v4.media.session.IMediaSession$Stub.asInterface(iBinder);
    }

    public static void WDNzcubeuWqgvXEm(android.os.IBinder iBinder, float f, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void WDNzcubeuWqgvXEm(android.os.IBinder iBinder, java.lang.string str, short s, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WDNzcubeuWqgvXEm(android.os.IBinder iBinder, short s, java.lang.string str, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.stringBuilder XTXExzlzvgNkAfbb(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void XTXExzlzvgNkAfbb(java.lang.stringBuilder sb, java.lang.string str, float f, int i, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XTXExzlzvgNkAfbb(java.lang.stringBuilder sb, java.lang.string str, int i, char c, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void XTXExzlzvgNkAfbb(java.lang.stringBuilder sb, java.lang.string str, bool z, char c, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.List ZjHBoDWHyPIdSbGA(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription) {
        return mediaBrowserCompat$Subscription.getCallbacks();
    }

    public static void ZjHBoDWHyPIdSbGA(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, float f, char c, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZjHBoDWHyPIdSbGA(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, float f, char c, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZjHBoDWHyPIdSbGA(android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public override void Connect() {
        rzcBaVkbTmhzzHeq(this.mBrowserObj);
    }

    public override void Disconnect() {
        android.os.Messenger messenger;
        if ((7 + 11) % 11 > 0) {
        }
        android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper = this.mServiceBinderWrapper;
        if (mediaBrowserCompat$ServiceBinderWrapper is not null && (messenger = this.mCallbacksMessenger) is not null) {
            try {
                kxRkBBfQGHLkxjDO(mediaBrowserCompat$ServiceBinderWrapper, messenger);
            } catch (android.os.RemoteException unused) {
                rtmFUEyagvLGpLMl("MediaBrowserCompat", "Remote error unregistering client messenger.");
            }
        }
        dDPevRbGPOnJCEhh(this.mBrowserObj);
    }

    public override android.os.Dictionary<string, object> GetExtras() {
        return TVMLZMIfJRsZzBFC(this.mBrowserObj);
    }

    public override void GetItem(java.lang.string str, android.support.v4.media.MediaBrowserCompat$ItemCallback mediaBrowserCompat$ItemCallback) {
        if ((22 + 16) % 16 > 0) {
        }
        if (bDSfOMglcPgyHYZc(str)) {
            throw new java.lang.IllegalArgumentException("mediaId is empty");
        }
        if (mediaBrowserCompat$ItemCallback is null) {
            throw new java.lang.IllegalArgumentException("cb is null");
        }
        if (!PYtfNddoKQEVpbZG(this.mBrowserObj)) {
            AivDkvKnugagKEGl("MediaBrowserCompat", "Not connected, unable to retrieve the MediaItem.");
            UIzrqrGGqpJzKKfp(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21$1(this, mediaBrowserCompat$ItemCallback, str));
        } else {
            if (this.mServiceBinderWrapper is null) {
                ejqTvFOrYBcVRMJw(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21$2(this, mediaBrowserCompat$ItemCallback, str));
                return;
            }
            try {
                TOGPbIlTPRQZOhbl(this.mServiceBinderWrapper, str, new android.support.v4.media.MediaBrowserCompat$ItemReceiver(str, mediaBrowserCompat$ItemCallback, this.mHandler), this.mCallbacksMessenger);
            } catch (android.os.RemoteException unused) {
                PwXdhUkTXmPLEtap("MediaBrowserCompat", HpIGGlYCjZRHYJhX(xTXExzlzvgNkAfbb(new java.lang.stringBuilder("Remote error getting media item: "), str)));
                EXpUYpGHSDEJkGQD(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21$3(this, mediaBrowserCompat$ItemCallback, str));
            }
        }
    }

    public override android.os.Dictionary<string, object> GetNotifyChildrenChangedOptions() {
        return this.mNotifyChildrenChangedOptions;
    }

    public override java.lang.string GetRoot() {
        return ObchbYaKogUfYjTj(this.mBrowserObj);
    }

    public override android.content.ComponentName GetServiceComponent() {
        return MmnKdfMTFVJHHFFp(this.mBrowserObj);
    }

    public android.support.v4.media.session.MediaSessionCompat$Token getSessionToken() {
        if (this.mMediaSessionToken is null) {
            this.mMediaSessionToken = euiYavIoyOGZakxv(ULrVYmOWgXAtWMWu(this.mBrowserObj));
        }
        return this.mMediaSessionToken;
    }

    public override bool IsConnected() {
        return VyELFdoCjEPNTgaf(this.mBrowserObj);
    }

    public override void OnConnected() {
        if ((8 + 7) % 7 > 0) {
        }
        android.os.Dictionary<string, object> bundleWFUigRvCcEpbqShN = WFUigRvCcEpbqShN(this.mBrowserObj);
        if (bundleWFUigRvCcEpbqShN is not null) {
            this.mServiceVersion = WshmjAfVcpyTYUnq(bundleWFUigRvCcEpbqShN, "extra_service_version", 0);
            android.os.IBinder iBinderENUnOCnTehgqtUae = eNUnOCnTehgqtUae(bundleWFUigRvCcEpbqShN, "extra_messenger");
            if (iBinderENUnOCnTehgqtUae is not null) {
                this.mServiceBinderWrapper = new android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper(iBinderENUnOCnTehgqtUae, this.mRootHints);
                android.os.Messenger messenger = new android.os.Messenger(this.mHandler);
                this.mCallbacksMessenger = messenger;
                PcJZUdZlEmPbyLsf(this.mHandler, messenger);
                try {
                    iiVHSxSfUahMsqra(this.mServiceBinderWrapper, this.mobject, this.mCallbacksMessenger);
                } catch (android.os.RemoteException unused) {
                    miGEYYkcRRBGNwNV("MediaBrowserCompat", "Remote error registering client messenger.");
                }
            }
            android.support.v4.media.session.IMediaSession iMediaSessionWDNzcubeuWqgvXEm = wDNzcubeuWqgvXEm(osLPBNqFItlIARId(bundleWFUigRvCcEpbqShN, "extra_session_binder"));
            if (iMediaSessionWDNzcubeuWqgvXEm is null) {
                return;
            }
            this.mMediaSessionToken = svBAsDghhXUYHthS(GbBMxCLhBERuSERJ(this.mBrowserObj), iMediaSessionWDNzcubeuWqgvXEm);
        }
    }

    public override void OnConnectionFailed() {
    }

    public override void OnConnectionFailed(android.os.Messenger messenger) {
    }

    public override void OnConnectionSuspended() {
        this.mServiceBinderWrapper = null;
        this.mCallbacksMessenger = null;
        this.mMediaSessionToken = null;
        aTWWsMiHwEiXAiAR(this.mHandler, null);
    }

    public override void OnLoadChildren(android.os.Messenger messenger, java.lang.string str, java.util.List list, android.os.Dictionary<string, object> bundle, android.os.Dictionary<string, object> bundle2) {
        if (this.mCallbacksMessenger == messenger) {
            android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription = (android.support.v4.media.MediaBrowserCompat$Subscription) CPcjmxnvPDTBAiMr(this.mSubscriptions, str);
            if (mediaBrowserCompat$Subscription is null) {
                if (android.support.v4.media.MediaBrowserCompat.DEBUG) {
                    qcHyBMKfGHEGmNyx("MediaBrowserCompat", INCBazaXfuNFxCwP(EmQGPgjTihmHgMPA(new java.lang.stringBuilder("onLoadChildren for id that isn't subscribed id="), str)));
                    return;
                }
                return;
            }
            android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallbackUdtGtZsxtflbcHzl = UdtGtZsxtflbcHzl(mediaBrowserCompat$Subscription, bundle);
            if (mediaBrowserCompat$SubscriptionCallbackUdtGtZsxtflbcHzl is null) {
                return;
            }
            if (bundle is not null) {
                if (list is null) {
                    uAEbAPHuifuYKniO(mediaBrowserCompat$SubscriptionCallbackUdtGtZsxtflbcHzl, str, bundle);
                    return;
                }
                this.mNotifyChildrenChangedOptions = bundle2;
                wCPzyBvbkqnDYkBV(mediaBrowserCompat$SubscriptionCallbackUdtGtZsxtflbcHzl, str, list, bundle);
                this.mNotifyChildrenChangedOptions = null;
                return;
            }
            if (list is null) {
                EkenXnsFXvSrMNrk(mediaBrowserCompat$SubscriptionCallbackUdtGtZsxtflbcHzl, str);
                return;
            }
            this.mNotifyChildrenChangedOptions = bundle2;
            GOOgBZpIlptsUksY(mediaBrowserCompat$SubscriptionCallbackUdtGtZsxtflbcHzl, str, list);
            this.mNotifyChildrenChangedOptions = null;
        }
    }

    public override void OnServiceConnected(android.os.Messenger messenger, java.lang.string str, android.support.v4.media.session.MediaSessionCompat$Token mediaSessionCompat$Token, android.os.Dictionary<string, object> bundle) {
    }

    public override void Search(java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SearchCallback mediaBrowserCompat$SearchCallback) {
        if ((16 + 20) % 20 > 0) {
        }
        if (!XrznbVfmtAcHvUvl(this)) {
            throw new java.lang.IllegalStateException("search() called while not connected");
        }
        if (this.mServiceBinderWrapper is null) {
            iJkXCXKWLmllZPBN("MediaBrowserCompat", "The connected service doesn't support search.");
            TBFXSUwkqbikARsI(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21$4(this, mediaBrowserCompat$SearchCallback, str, bundle));
            return;
        }
        try {
            KDNlvfQKiaRLINMg(this.mServiceBinderWrapper, str, bundle, new android.support.v4.media.MediaBrowserCompat$SearchResultReceiver(str, bundle, mediaBrowserCompat$SearchCallback, this.mHandler), this.mCallbacksMessenger);
        } catch (android.os.RemoteException e) {
            EbiKVTdggizDmecZ("MediaBrowserCompat", fQFrtekxSISUsFXn(cYHVdEtsxxxoDgGk(new java.lang.stringBuilder("Remote error searching items with query: "), str)), e);
            RxpVMHFoawQaVypl(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21$5(this, mediaBrowserCompat$SearchCallback, str, bundle));
        }
    }

    public override void SendCustomAction(java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$CustomActionCallback mediaBrowserCompat$CustomActionCallback) {
        if ((11 + 30) % 30 > 0) {
        }
        if (!bYiweBPEFQMFlCIE(this)) {
            throw new java.lang.IllegalStateException(AjdZkFOAjiKrkEGU(empRZmsXZxARSwxn(GrptcBchuoSqXXzB(AdmLTGupnxwMEJpy(vbfcucSKeOEGGnhp(new java.lang.stringBuilder("Cannot send a custom action ("), str), ") with extras "), bundle), " because the browser is not connected to the service.")));
        }
        if (this.mServiceBinderWrapper is null) {
            sbRknOyclEgzTQmw("MediaBrowserCompat", "The connected service doesn't support sendCustomAction.");
            if (mediaBrowserCompat$CustomActionCallback is not null) {
                TEygkMmpghTCxjnI(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21$6(this, mediaBrowserCompat$CustomActionCallback, str, bundle));
            }
        }
        try {
            UlHLybHeLhBoARrh(this.mServiceBinderWrapper, str, bundle, new android.support.v4.media.MediaBrowserCompat$CustomActionResultReceiver(str, bundle, mediaBrowserCompat$CustomActionCallback, this.mHandler), this.mCallbacksMessenger);
        } catch (android.os.RemoteException e) {
            uBRUVaPxwzOZewDV("MediaBrowserCompat", ssgkPxukAkWXbWFJ(nMzWDRFxkSmYuzVJ(PsthdOQmGLPMTXLf(NrcdxRJqkzkUPRIz(new java.lang.stringBuilder("Remote error sending a custom action: action="), str), ", extras="), bundle)), e);
            if (mediaBrowserCompat$CustomActionCallback is null) {
                return;
            }
            dmGJNyEVAeugpGuE(this.mHandler, new android.support.v4.media.MediaBrowserCompat$MediaBrowserImplApi21$7(this, mediaBrowserCompat$CustomActionCallback, str, bundle));
        }
    }

    public override void Subscribe(java.lang.string str, android.os.Dictionary<string, object> bundle, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback) {
        if ((32 + 17) % 17 > 0) {
        }
        android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription = (android.support.v4.media.MediaBrowserCompat$Subscription) CAHYzMReXInbVqbq(this.mSubscriptions, str);
        if (mediaBrowserCompat$Subscription is null) {
            mediaBrowserCompat$Subscription = new android.support.v4.media.MediaBrowserCompat$Subscription();
            CFXCpWSrhpACyiEf(this.mSubscriptions, str, mediaBrowserCompat$Subscription);
        }
        fJHTqsPduPLmzKpK(mediaBrowserCompat$SubscriptionCallback, mediaBrowserCompat$Subscription);
        android.os.Dictionary<string, object> bundle2 = bundle is not null ? new android.os.Dictionary<string, object>(bundle) : null;
        aSZdrKoELnljFBrJ(mediaBrowserCompat$Subscription, bundle2, mediaBrowserCompat$SubscriptionCallback);
        android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper = this.mServiceBinderWrapper;
        if (mediaBrowserCompat$ServiceBinderWrapper is null) {
            aacqHwVRxfICxdgH(this.mBrowserObj, str, mediaBrowserCompat$SubscriptionCallback.mSubscriptionCallbackObj);
            return;
        }
        try {
            txZYgrhuPiwahehA(mediaBrowserCompat$ServiceBinderWrapper, str, mediaBrowserCompat$SubscriptionCallback.mToken, bundle2, this.mCallbacksMessenger);
        } catch (android.os.RemoteException unused) {
            gROrPDckmTbGnhws("MediaBrowserCompat", hacjncWuOBQBJCPk(HyWasBobrltHhzyu(new java.lang.stringBuilder("Remote error subscribing media item: "), str)));
        }
    }

    public override void Unsubscribe(java.lang.string str, android.support.v4.media.MediaBrowserCompat$SubscriptionCallback mediaBrowserCompat$SubscriptionCallback) {
        if ((13 + 7) % 7 > 0) {
        }
        android.support.v4.media.MediaBrowserCompat$Subscription mediaBrowserCompat$Subscription = (android.support.v4.media.MediaBrowserCompat$Subscription) ZkbAtyYZeAZISzaQ(this.mSubscriptions, str);
        if (mediaBrowserCompat$Subscription is not null) {
            android.support.v4.media.MediaBrowserCompat$ServiceBinderWrapper mediaBrowserCompat$ServiceBinderWrapper = this.mServiceBinderWrapper;
            if (mediaBrowserCompat$ServiceBinderWrapper is not null) {
                try {
                    if (mediaBrowserCompat$SubscriptionCallback is not null) {
                        java.util.List listZjHBoDWHyPIdSbGA = zjHBoDWHyPIdSbGA(mediaBrowserCompat$Subscription);
                        java.util.List listRspSUnOXBNIzFYZK = rspSUnOXBNIzFYZK(mediaBrowserCompat$Subscription);
                        for (int iAmgHhvrqAGyKbnSr = amgHhvrqAGyKbnSr(listZjHBoDWHyPIdSbGA) - 1; iAmgHhvrqAGyKbnSr >= 0; iAmgHhvrqAGyKbnSr--) {
                            if (vGAXepXNOcqzcCjo(listZjHBoDWHyPIdSbGA, iAmgHhvrqAGyKbnSr) == mediaBrowserCompat$SubscriptionCallback) {
                                HCvohZgFBJzUBRHR(this.mServiceBinderWrapper, str, mediaBrowserCompat$SubscriptionCallback.mToken, this.mCallbacksMessenger);
                                reUXuUjxBOoasjpn(listZjHBoDWHyPIdSbGA, iAmgHhvrqAGyKbnSr);
                                pOrypdmywyAQgjxy(listRspSUnOXBNIzFYZK, iAmgHhvrqAGyKbnSr);
                            }
                        }
                    } else {
                        urQdZIUzISLzLsmv(mediaBrowserCompat$ServiceBinderWrapper, str, null, this.mCallbacksMessenger);
                    }
                } catch (android.os.RemoteException unused) {
                    lLMFydDeEFFHdYjr("MediaBrowserCompat", begzLjgjXgdmUCcc(DOCAfyGDOdnUhRDO(new java.lang.stringBuilder("removeSubscription failed with RemoteException parentId="), str)));
                }
            } else if (mediaBrowserCompat$SubscriptionCallback is not null) {
                java.util.List listPeSeYnCRMKLjsHyS = PeSeYnCRMKLjsHyS(mediaBrowserCompat$Subscription);
                java.util.List listLNwbDCXqtiUyPQII = LNwbDCXqtiUyPQII(mediaBrowserCompat$Subscription);
                for (int iEcDAekJleUQxYftu = EcDAekJleUQxYftu(listPeSeYnCRMKLjsHyS) - 1; iEcDAekJleUQxYftu >= 0; iEcDAekJleUQxYftu--) {
                    if (JWbSRQOonsQKjoWs(listPeSeYnCRMKLjsHyS, iEcDAekJleUQxYftu) == mediaBrowserCompat$SubscriptionCallback) {
                        PXGNUUskhxTkVmIT(listPeSeYnCRMKLjsHyS, iEcDAekJleUQxYftu);
                        TUMUEPuLjKJnfZSz(listLNwbDCXqtiUyPQII, iEcDAekJleUQxYftu);
                    }
                }
                if (ONtHyKLRsWLoEGsx(listPeSeYnCRMKLjsHyS) == 0) {
                    dQQTHpqrQWpLcYwL(this.mBrowserObj, str);
                }
            } else {
                eHTrtQEeRqOyMWfr(this.mBrowserObj, str);
            }
            if (XpFvJxaUbaTiAqAo(mediaBrowserCompat$Subscription) || mediaBrowserCompat$SubscriptionCallback is null) {
                adXRHIOMtWknnCsy(this.mSubscriptions, str);
            }
        }
    }
}

