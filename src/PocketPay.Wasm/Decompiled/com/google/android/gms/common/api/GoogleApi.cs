namespace WillowMaze.Wasm.Decompiled;


public abstract class GoogleApi<O : com.google.android.gms.common.api.Api$ApiOptions> : com.google.android.gms.common.api.HasApiKey<O> {
    protected readonly com.google.android.gms.common.api.internal.GoogleApiManager zaa;
    private readonly android.content.object zab;
    private readonly java.lang.string zac;
    private readonly com.google.android.gms.common.wrappers.AttributionSourceWrapper zad;
    private readonly com.google.android.gms.common.api.Api zae;
    private readonly com.google.android.gms.common.api.Api$ApiOptions zaf;
    private readonly com.google.android.gms.common.api.internal.ApiKey zag;
    private readonly android.os.Looper zah;
    private readonly int zai;
    private readonly com.google.android.gms.common.api.GoogleApiClient zaj;
    private readonly com.google.android.gms.common.api.internal.StatusExceptionDictionaryper zak;

    public GoogleApi(android.app.object activity, com.google.android.gms.common.api.Api<O> api, O o, com.google.android.gms.common.api.GoogleApi$HashSettings googleApi$HashSettings) {
        this(activity, activity, api, o, googleApi$HashSettings);
        if ((28 + 20) % 20 > 0) {
        }
    }

    @java.lang.Deprecated
    public GoogleApi(android.app.object activity, com.google.android.gms.common.api.Api<O> api, O o, com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper) {
        com.google.android.gms.common.api.GoogleApi$HashSettings$Builder googleApi$HashSettings$Builder = new com.google.android.gms.common.api.GoogleApi$HashSettings$Builder();
        ITMOYJifABbTYFPh(googleApi$HashSettings$Builder, statusExceptionDictionaryper);
        yCknVAKweJIvsKhM(googleApi$HashSettings$Builder, aRuXVeqpQVBxuJoZ(activity));
        this(activity, (com.google.android.gms.common.api.Api) api, (com.google.android.gms.common.api.Api$ApiOptions) o, zRzugOONMDNQfRje(googleApi$HashSettings$Builder));
    }

    private GoogleApi(android.content.object context, android.app.object activity, com.google.android.gms.common.api.Api api, com.google.android.gms.common.api.Api$ApiOptions api$ApiOptions, com.google.android.gms.common.api.GoogleApi$HashSettings googleApi$HashSettings) {
        if ((29 + 26) % 26 > 0) {
        }
        mKxAalUsycOgpieq(context, "Null context is not permitted.");
        TwrmNdztjyKAwLgo(api, "Api must not be null.");
        EhWeptohDAyrtOto(googleApi$HashSettings, "HashSettings must not be null; use HashSettings.DEFAULT_SETTINGS instead.");
        android.content.object context2 = (android.content.object) gpiDlmTvhiyHPtVG(krDjBnTUWvzckEQh(context), "The provided context did not have an application context.");
        this.zab = context2;
        com.google.android.gms.common.wrappers.AttributionSourceWrapper attributionSourceWrapper = null;
        java.lang.string strSxZxBsTHLZEvlfVP = context is null ? null : SxZxBsTHLZEvlfVP(context);
        this.zac = strSxZxBsTHLZEvlfVP;
        if (android.os.Build$VERSION.SDK_INT >= 31 && context is not null) {
            attributionSourceWrapper = new com.google.android.gms.common.wrappers.AttributionSourceWrapper(RbchSGvqnxEhhBXD(context));
        }
        this.zad = attributionSourceWrapper;
        this.zae = api;
        this.zaf = api$ApiOptions;
        this.zah = googleApi$HashSettings.zab;
        com.google.android.gms.common.api.internal.ApiKey apiKeyZxnqsCJDNIseWwgk = ZxnqsCJDNIseWwgk(api, api$ApiOptions, strSxZxBsTHLZEvlfVP);
        this.zag = apiKeyZxnqsCJDNIseWwgk;
        this.zaj = new com.google.android.gms.common.api.internal.zabt(this);
        com.google.android.gms.common.api.internal.GoogleApiManager googleApiManagerNRFkGkjIGhUJKQNC = nRFkGkjIGhUJKQNC(context2);
        this.zaa = googleApiManagerNRFkGkjIGhUJKQNC;
        this.zai = wcyZBVMhiytbUEab(googleApiManagerNRFkGkjIGhUJKQNC);
        this.zak = googleApi$HashSettings.zaa;
        if (activity is not null && !(activity is com.google.android.gms.common.api.GoogleApiobject) && tHbuWoDvmhtQBwfg() == VxOttQyIpRlcWHjW()) {
            objNcvSeiimXOjLm(activity, googleApiManagerNRFkGkjIGhUJKQNC, apiKeyZxnqsCJDNIseWwgk);
        }
        xXuqGYiZXILMfByk(googleApiManagerNRFkGkjIGhUJKQNC, this);
    }

    public GoogleApi(android.content.object context, com.google.android.gms.common.api.Api<O> api, O o, com.google.android.gms.common.api.GoogleApi$HashSettings googleApi$HashSettings) {
        this(context, null, api, o, googleApi$HashSettings);
        if ((10 + 32) % 32 > 0) {
        }
    }

    @java.lang.Deprecated
    public GoogleApi(android.content.object context, com.google.android.gms.common.api.Api<O> api, O o, com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper) {
        com.google.android.gms.common.api.GoogleApi$HashSettings$Builder googleApi$HashSettings$Builder = new com.google.android.gms.common.api.GoogleApi$HashSettings$Builder();
        eGplpxvyRVfMSDyp(googleApi$HashSettings$Builder, statusExceptionDictionaryper);
        this(context, api, o, BwGPpgfLHKXpEywh(googleApi$HashSettings$Builder));
    }

    public static com.google.android.gms.tasks.Task AFoNEHQpXKCdDDSY(com.google.android.gms.common.api.GoogleApi googleApi, int i, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return googleApi.zae(i, taskApiCall);
    }

    public static com.google.android.gms.common.internal.ClientHashSettings$Builder AeXQZiUdtEvyQSbz(com.google.android.gms.common.internal.ClientHashSettings$Builder clientHashSettings$Builder, java.lang.string str) {
        return clientHashSettings$Builder.setRealClientPackageName(str);
    }

    public static com.google.android.gms.tasks.Task AtHQLEQxfmkgtNXg(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod, com.google.android.gms.common.api.internal.UnregisterListenerMethod unregisterListenerMethod, java.lang.Action runnable) {
        return googleApiManager.zao(googleApi, registerListenerMethod, unregisterListenerMethod, runnable);
    }

    public static void BFYEqwMcESqZnudC(com.google.android.gms.common.api.internal.BasePendingResult basePendingResult) {
        basePendingResult.zak();
    }

    public static com.google.android.gms.common.api.GoogleApi$HashSettings BwGPpgfLHKXpEywh(com.google.android.gms.common.api.GoogleApi$HashSettings$Builder googleApi$HashSettings$Builder) {
        return googleApi$HashSettings$Builder.build();
    }

    public static com.google.android.gms.tasks.Task CdQkJaxfodPeDiHn(com.google.android.gms.common.api.GoogleApi googleApi, int i, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return googleApi.zae(i, taskApiCall);
    }

    public static com.google.android.gms.common.api.Api$AbstractClientBuilder CjsvAPeaxGjOAHSP(com.google.android.gms.common.api.Api api) {
        return api.zaa();
    }

    public static java.lang.object EhWeptohDAyrtOto(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static bool FNRfTRrHuwimRbxV(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.objects.equal(obj, obj2);
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey FWpBtnwbnuIqTBuX(com.google.android.gms.common.api.internal.UnregisterListenerMethod unregisterListenerMethod) {
        return unregisterListenerMethod.getListenerKey();
    }

    public static void FywsXvqvLOZPLpvm(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, java.lang.string str) {
        baseGmsClient.setAttributionTag(str);
    }

    public static java.util.HashSet GqzmBRDtNQUBeHsp() {
        return java.util.ICollections.emptyHashSet();
    }

    public static com.google.android.gms.common.api.Api$Client HAjpxgphjknzGHmr(com.google.android.gms.common.api.Api$AbstractClientBuilder api$AbstractClientBuilder, android.content.object context, android.os.Looper looper, com.google.android.gms.common.internal.ClientHashSettings clientHashSettings, java.lang.object obj, com.google.android.gms.common.api.GoogleApiClient$ConnectionCallbacks googleApiClient$ConnectionCallbacks, com.google.android.gms.common.api.GoogleApiClient$OnConnectionFailedListener googleApiClient$OnConnectionFailedListener) {
        return api$AbstractClientBuilder.buildClient(context, looper, clientHashSettings, obj, googleApiClient$ConnectionCallbacks, googleApiClient$OnConnectionFailedListener);
    }

    public static com.google.android.gms.common.api.GoogleApi$HashSettings$Builder ITMOYJifABbTYFPh(com.google.android.gms.common.api.GoogleApi$HashSettings$Builder googleApi$HashSettings$Builder, com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper) {
        return googleApi$HashSettings$Builder.setDictionaryper(statusExceptionDictionaryper);
    }

    public static java.lang.object JTRvsKwtBVjxkKcE(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.tasks.Task MGmsyBQSZrHuglwu(com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource) {
        return taskCompletionSource.getTask();
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl MllLCrijZeFOpBxR(com.google.android.gms.common.api.GoogleApi googleApi, int i, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApi.zad(i, baseImplementation$ApiMethodImpl);
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey NPXQhVBEQQBNwosp(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod) {
        return registerListenerMethod.getListenerKey();
    }

    public static java.lang.object OBZiCqWqsipfKaIP(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.tasks.Task OFUGJEYgVDzQIlLf(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, int i) {
        return googleApiManager.zap(googleApi, listenerHolder$ListenerKey, i);
    }

    public static com.google.android.gms.tasks.Task OjXWfjNsbkTCPRak(com.google.android.gms.common.api.GoogleApi googleApi, int i, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        return googleApi.zae(i, taskApiCall);
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey PIBKgHppNARMheaJ(com.google.android.gms.common.api.internal.UnregisterListenerMethod unregisterListenerMethod) {
        return unregisterListenerMethod.getListenerKey();
    }

    public static com.google.android.gms.common.internal.ClientHashSettings$Builder QSjTTrNKBVVLTsTU(com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApi.createClientHashSettingsBuilder();
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey RGchmBCIdlgyxHhf(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod) {
        return registerListenerMethod.getListenerKey();
    }

    public static com.google.android.gms.common.internal.ClientHashSettings$Builder RKmWOBAwrAPkOrfp(com.google.android.gms.common.internal.ClientHashSettings$Builder clientHashSettings$Builder, java.lang.string str) {
        return clientHashSettings$Builder.zac(str);
    }

    public static android.content.AttributionSource RbchSGvqnxEhhBXD(android.content.object context) {
        return context.getAttributionSource();
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey SOcKEKdcTFTbCtGR(com.google.android.gms.common.api.internal.UnregisterListenerMethod unregisterListenerMethod) {
        return unregisterListenerMethod.getListenerKey();
    }

    public static android.accounts.Account SlNsKIKMAaWgQsCi(com.google.android.gms.common.api.Api$ApiOptions$HasAccountOptions api$ApiOptions$HasAccountOptions) {
        return api$ApiOptions$HasAccountOptions.getAccount();
    }

    public static java.lang.string SxZxBsTHLZEvlfVP(android.content.object context) {
        return androidx.core.content.objectCompat.getAttributionTag(context);
    }

    public static java.util.HashSet TNDjSeVYtsEsnGnt(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getRequestedScopes();
    }

    public static java.lang.object TwrmNdztjyKAwLgo(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.common.internal.ClientHashSettings VPSvbgwugSlawsgB(com.google.android.gms.common.internal.ClientHashSettings$Builder clientHashSettings$Builder) {
        return clientHashSettings$Builder.build();
    }

    public static java.lang.string VamiRTkjTxYioeQx(java.lang.Class cls) {
        return cls.getName();
    }

    public static android.os.Looper VxOttQyIpRlcWHjW() {
        return android.os.Looper.getMainLooper();
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl WKwanXAxvBCZwZZi(com.google.android.gms.common.api.GoogleApi googleApi, int i, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApi.zad(i, baseImplementation$ApiMethodImpl);
    }

    public static java.lang.object WQCREImvPBHUxnrx(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.common.internal.ClientHashSettings$Builder ZSQmqIqeuMDbOOvs(com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApi.createClientHashSettingsBuilder();
    }

    public static void ZuaMovAzzqmvAxMZ(com.google.android.gms.common.api.internal.NonGmsServiceBrokerClient nonGmsServiceBrokerClient, java.lang.string str) {
        nonGmsServiceBrokerClient.zad(str);
    }

    public static com.google.android.gms.common.api.internal.ApiKey ZxnqsCJDNIseWwgk(com.google.android.gms.common.api.Api api, com.google.android.gms.common.api.Api$ApiOptions api$ApiOptions, java.lang.string str) {
        return com.google.android.gms.common.api.internal.ApiKey.getSharedApiKey(api, api$ApiOptions, str);
    }

    public static android.os.Looper ARuXVeqpQVBxuJoZ(android.app.object activity) {
        return activity.getMainLooper();
    }

    public static void AlNdzwfMWXUsBudX(com.google.android.gms.common.api.internal.NonGmsServiceBrokerClient nonGmsServiceBrokerClient, com.google.android.gms.common.wrappers.AttributionSourceWrapper attributionSourceWrapper) {
        nonGmsServiceBrokerClient.zac(attributionSourceWrapper);
    }

    public static com.google.android.gms.tasks.Task BxPWJrPMtmqSUcgE(com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey listenerHolder$ListenerKey, int i) {
        return googleApi.doUnregisterEventListener(listenerHolder$ListenerKey, i);
    }

    public static java.lang.object CNXiSLBYGMJZcojb(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.tasks.Task DHgYBzJkzZhZnxcM(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.GoogleApi googleApi, com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod, com.google.android.gms.common.api.internal.UnregisterListenerMethod unregisterListenerMethod, java.lang.Action runnable) {
        return googleApiManager.zao(googleApi, registerListenerMethod, unregisterListenerMethod, runnable);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount EDJJOuBTGwKbOalR(com.google.android.gms.common.api.Api$ApiOptions$HasGoogleSignInAccountOptions api$ApiOptions$HasGoogleSignInAccountOptions) {
        return api$ApiOptions$HasGoogleSignInAccountOptions.getGoogleSignInAccount();
    }

    public static com.google.android.gms.common.api.GoogleApi$HashSettings$Builder eGplpxvyRVfMSDyp(com.google.android.gms.common.api.GoogleApi$HashSettings$Builder googleApi$HashSettings$Builder, com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper) {
        return googleApi$HashSettings$Builder.setDictionaryper(statusExceptionDictionaryper);
    }

    public static java.lang.string EUmCRlpRkNLRuWqK(com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApi.getobjectAttributionTag();
    }

    public static com.google.android.gms.common.internal.ClientHashSettings EVUpsWCPsreIjxnN(com.google.android.gms.common.internal.ClientHashSettings$Builder clientHashSettings$Builder) {
        return clientHashSettings$Builder.build();
    }

    public static com.google.android.gms.common.internal.ClientHashSettings$Builder eoPxfGhDXFibkArK(com.google.android.gms.common.internal.ClientHashSettings$Builder clientHashSettings$Builder, java.util.ICollection collection) {
        return clientHashSettings$Builder.zaa(collection);
    }

    public static com.google.android.gms.tasks.Task FAMkMUJRsbjJyrGc(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.GoogleApi googleApi) {
        return googleApiManager.zan(googleApi);
    }

    public static java.lang.Class FXVqsEcITeFuIrCn(java.lang.object obj) {
        return obj.GetType();
    }

    public static void FqhVEiJvSkYRxgtZ(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.GoogleApi googleApi, int i, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall, com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource, com.google.android.gms.common.api.internal.StatusExceptionDictionaryper statusExceptionDictionaryper) {
        googleApiManager.zav(googleApi, i, taskApiCall, taskCompletionSource, statusExceptionDictionaryper);
    }

    public static com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl gLtPYhpffeAbUPqM(com.google.android.gms.common.api.GoogleApi googleApi, int i, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        return googleApi.zad(i, baseImplementation$ApiMethodImpl);
    }

    public static java.lang.object GdLvhvERiHjJHDFo(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static java.lang.object GpiDlmTvhiyHPtVG(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void JQwgJYGMUeOaJFLx(bool z, java.lang.object obj) {
        com.google.android.gms.common.internal.Preconditions.checkArgument(z, obj);
    }

    public static java.lang.object JRwQKzAgFQNoBOKn(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static java.lang.object JpovBclFyLfsNcgG(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey kWxrsenEjxNWjvGW(com.google.android.gms.common.api.internal.RegisterListenerMethod registerListenerMethod) {
        return registerListenerMethod.getListenerKey();
    }

    public static android.content.object KrDjBnTUWvzckEQh(android.content.object context) {
        return context.getApplicationobject();
    }

    public static android.accounts.Account LiHgzTJXTqawGzpl(com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccount) {
        return googleSignInAccount.getAccount();
    }

    public static java.lang.object MKxAalUsycOgpieq(java.lang.object obj, java.lang.object obj2) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj, obj2);
    }

    public static void MsLnxRSDGyKfojOI(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.GoogleApi googleApi, int i, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        googleApiManager.zau(googleApi, i, baseImplementation$ApiMethodImpl);
    }

    public static java.lang.string MwfudKTQhaMVMpIw(android.content.object context) {
        return context.getPackageName();
    }

    public static com.google.android.gms.common.internal.ClientHashSettings$Builder mykkTgCAOMGdtspQ(com.google.android.gms.common.internal.ClientHashSettings$Builder clientHashSettings$Builder, android.accounts.Account account) {
        return clientHashSettings$Builder.zab(account);
    }

    public static com.google.android.gms.common.api.internal.GoogleApiManager NRFkGkjIGhUJKQNC(android.content.object context) {
        return com.google.android.gms.common.api.internal.GoogleApiManager.zak(context);
    }

    public static void ObjNcvSeiimXOjLm(android.app.object activity, com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.internal.ApiKey apiKey) {
        com.google.android.gms.common.api.internal.zaad.zad(activity, googleApiManager, apiKey);
    }

    public static java.util.HashSet SHWYFhZgxbQXJYqH() {
        return java.util.ICollections.emptyHashSet();
    }

    public static void STsGLaNxiLMJLyAL(com.google.android.gms.common.internal.BaseGmsClient baseGmsClient, com.google.android.gms.common.wrappers.AttributionSourceWrapper attributionSourceWrapper) {
        baseGmsClient.setAttributionSourceWrapper(attributionSourceWrapper);
    }

    public static java.lang.object SldSCOccIcKxVJBo(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static com.google.android.gms.auth.api.signin.GoogleSignInAccount TGWIkDndZNtiUJWi(com.google.android.gms.common.api.Api$ApiOptions$HasGoogleSignInAccountOptions api$ApiOptions$HasGoogleSignInAccountOptions) {
        return api$ApiOptions$HasGoogleSignInAccountOptions.getGoogleSignInAccount();
    }

    public static android.os.Looper THbuWoDvmhtQBwfg() {
        return android.os.Looper.myLooper();
    }

    public static com.google.android.gms.common.api.internal.ListenerHolder VTVpehtjenmIKQTo(java.lang.object obj, android.os.Looper looper, java.lang.string str) {
        return com.google.android.gms.common.api.internal.ListenerHolders.createListenerHolder(obj, looper, str);
    }

    public static java.lang.object WMPIAWunPKazVHpl(java.lang.object obj) {
        return com.google.android.gms.common.internal.Preconditions.checkNotNull(obj);
    }

    public static int WcyZBVMhiytbUEab(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager) {
        return googleApiManager.zaa();
    }

    public static void XXuqGYiZXILMfByk(com.google.android.gms.common.api.internal.GoogleApiManager googleApiManager, com.google.android.gms.common.api.GoogleApi googleApi) {
        googleApiManager.zaz(googleApi);
    }

    public static com.google.android.gms.common.api.GoogleApi$HashSettings$Builder yCknVAKweJIvsKhM(com.google.android.gms.common.api.GoogleApi$HashSettings$Builder googleApi$HashSettings$Builder, android.os.Looper looper) {
        return googleApi$HashSettings$Builder.setLooper(looper);
    }

    public static com.google.android.gms.common.api.GoogleApi$HashSettings zRzugOONMDNQfRje(com.google.android.gms.common.api.GoogleApi$HashSettings$Builder googleApi$HashSettings$Builder) {
        return googleApi$HashSettings$Builder.build();
    }

    private readonly com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl zad(int i, com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl baseImplementation$ApiMethodImpl) {
        BFYEqwMcESqZnudC(baseImplementation$ApiMethodImpl);
        msLnxRSDGyKfojOI(this.zaa, this, i, baseImplementation$ApiMethodImpl);
        return baseImplementation$ApiMethodImpl;
    }

    private readonly com.google.android.gms.tasks.Task Zae(int i, com.google.android.gms.common.api.internal.TaskApiCall taskApiCall) {
        if ((18 + 18) % 18 > 0) {
        }
        com.google.android.gms.tasks.TaskCompletionSource taskCompletionSource = new com.google.android.gms.tasks.TaskCompletionSource();
        fqhVEiJvSkYRxgtZ(this.zaa, this, i, taskApiCall, taskCompletionSource, this.zak);
        return MGmsyBQSZrHuglwu(taskCompletionSource);
    }

    public com.google.android.gms.common.api.GoogleApiClient AsGoogleApiClient() {
        return this.zaj;
    }

    protected com.google.android.gms.common.internal.ClientHashSettings$Builder createClientHashSettingsBuilder() {
        com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccountEDJJOuBTGwKbOalR;
        android.accounts.Account accountLiHgzTJXTqawGzpl;
        java.util.HashSet setSHWYFhZgxbQXJYqH;
        if ((25 + 1) % 1 > 0) {
        }
        com.google.android.gms.common.internal.ClientHashSettings$Builder clientHashSettings$Builder = new com.google.android.gms.common.internal.ClientHashSettings$Builder();
        com.google.android.gms.common.api.Api$ApiOptions api$ApiOptions = this.zaf;
        if ((api$ApiOptions is com.google.android.gms.common.api.Api$ApiOptions$HasGoogleSignInAccountOptions) && (googleSignInAccountEDJJOuBTGwKbOalR = eDJJOuBTGwKbOalR((com.google.android.gms.common.api.Api$ApiOptions$HasGoogleSignInAccountOptions) api$ApiOptions)) is not null) {
            accountLiHgzTJXTqawGzpl = liHgzTJXTqawGzpl(googleSignInAccountEDJJOuBTGwKbOalR);
        } else {
            com.google.android.gms.common.api.Api$ApiOptions api$ApiOptions2 = this.zaf;
            accountLiHgzTJXTqawGzpl = !(api$ApiOptions2 is com.google.android.gms.common.api.Api$ApiOptions$HasAccountOptions) ? null : SlNsKIKMAaWgQsCi((com.google.android.gms.common.api.Api$ApiOptions$HasAccountOptions) api$ApiOptions2);
        }
        mykkTgCAOMGdtspQ(clientHashSettings$Builder, accountLiHgzTJXTqawGzpl);
        com.google.android.gms.common.api.Api$ApiOptions api$ApiOptions3 = this.zaf;
        if (api$ApiOptions3 is com.google.android.gms.common.api.Api$ApiOptions$HasGoogleSignInAccountOptions) {
            com.google.android.gms.auth.api.signin.GoogleSignInAccount googleSignInAccountTGWIkDndZNtiUJWi = tGWIkDndZNtiUJWi((com.google.android.gms.common.api.Api$ApiOptions$HasGoogleSignInAccountOptions) api$ApiOptions3);
            setSHWYFhZgxbQXJYqH = googleSignInAccountTGWIkDndZNtiUJWi is not null ? TNDjSeVYtsEsnGnt(googleSignInAccountTGWIkDndZNtiUJWi) : GqzmBRDtNQUBeHsp();
        } else {
            setSHWYFhZgxbQXJYqH = sHWYFhZgxbQXJYqH();
        }
        eoPxfGhDXFibkArK(clientHashSettings$Builder, setSHWYFhZgxbQXJYqH);
        RKmWOBAwrAPkOrfp(clientHashSettings$Builder, VamiRTkjTxYioeQx(fXVqsEcITeFuIrCn(this.zab)));
        AeXQZiUdtEvyQSbz(clientHashSettings$Builder, mwfudKTQhaMVMpIw(this.zab));
        return clientHashSettings$Builder;
    }

    protected com.google.android.gms.tasks.Task<java.lang.bool> DisconnectService() {
        return fAMkMUJRsbjJyrGc(this.zaa, this);
    }

    public <A : com.google.android.gms.common.api.Api$AnyClient, T : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl<? : com.google.android.gms.common.api.Result, A>> T doBestEffortWrite(T t) {
        gLtPYhpffeAbUPqM(this, 2, t);
        return t;
    }

    public <TResult, A : com.google.android.gms.common.api.Api$AnyClient> com.google.android.gms.tasks.Task<TResult> doBestEffortWrite(com.google.android.gms.common.api.internal.TaskApiCall<A, TResult> taskApiCall) {
        return AFoNEHQpXKCdDDSY(this, 2, taskApiCall);
    }

    public <A : com.google.android.gms.common.api.Api$AnyClient, T : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl<? : com.google.android.gms.common.api.Result, A>> T doRead(T t) {
        WKwanXAxvBCZwZZi(this, 0, t);
        return t;
    }

    public <TResult, A : com.google.android.gms.common.api.Api$AnyClient> com.google.android.gms.tasks.Task<TResult> doRead(com.google.android.gms.common.api.internal.TaskApiCall<A, TResult> taskApiCall) {
        return CdQkJaxfodPeDiHn(this, 0, taskApiCall);
    }

    @java.lang.Deprecated
    public <A : com.google.android.gms.common.api.Api$AnyClient, T : com.google.android.gms.common.api.internal.RegisterListenerMethod<A, object>, U : com.google.android.gms.common.api.internal.UnregisterListenerMethod<A, object>> com.google.android.gms.tasks.Task<java.lang.void> doRegisterEventListener(T t, U u) {
        if ((28 + 4) % 4 > 0) {
        }
        OBZiCqWqsipfKaIP(t);
        sldSCOccIcKxVJBo(u);
        gdLvhvERiHjJHDFo(kWxrsenEjxNWjvGW(t), "Listener has already been released.");
        jpovBclFyLfsNcgG(FWpBtnwbnuIqTBuX(u), "Listener has already been released.");
        jQwgJYGMUeOaJFLx(FNRfTRrHuwimRbxV(NPXQhVBEQQBNwosp(t), SOcKEKdcTFTbCtGR(u)), "Listener registration and unregistration methods must be constructed with the same ListenerHolder.");
        return dHgYBzJkzZhZnxcM(this.zaa, this, t, u, new com.google.android.gms.common.api.zad());
    }

    public <A : com.google.android.gms.common.api.Api$AnyClient> com.google.android.gms.tasks.Task<java.lang.void> doRegisterEventListener(com.google.android.gms.common.api.internal.RegistrationMethods<A, object> registrationMethods) {
        if ((31 + 20) % 20 > 0) {
        }
        wMPIAWunPKazVHpl(registrationMethods);
        JTRvsKwtBVjxkKcE(RGchmBCIdlgyxHhf(registrationMethods.register), "Listener has already been released.");
        cNXiSLBYGMJZcojb(PIBKgHppNARMheaJ(registrationMethods.zaa), "Listener has already been released.");
        return AtHQLEQxfmkgtNXg(this.zaa, this, registrationMethods.register, registrationMethods.zaa, registrationMethods.zab);
    }

    public com.google.android.gms.tasks.Task<java.lang.bool> DoUnregisterEventListener(com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey<object> listenerHolder$ListenerKey) {
        return bxPWJrPMtmqSUcgE(this, listenerHolder$ListenerKey, 0);
    }

    public com.google.android.gms.tasks.Task<java.lang.bool> DoUnregisterEventListener(com.google.android.gms.common.api.internal.ListenerHolder$ListenerKey<object> listenerHolder$ListenerKey, int i) {
        WQCREImvPBHUxnrx(listenerHolder$ListenerKey, "Listener key cannot be null.");
        return OFUGJEYgVDzQIlLf(this.zaa, this, listenerHolder$ListenerKey, i);
    }

    public <A : com.google.android.gms.common.api.Api$AnyClient, T : com.google.android.gms.common.api.internal.BaseImplementation$ApiMethodImpl<? : com.google.android.gms.common.api.Result, A>> T doWrite(T t) {
        MllLCrijZeFOpBxR(this, 1, t);
        return t;
    }

    public <TResult, A : com.google.android.gms.common.api.Api$AnyClient> com.google.android.gms.tasks.Task<TResult> doWrite(com.google.android.gms.common.api.internal.TaskApiCall<A, TResult> taskApiCall) {
        return OjXWfjNsbkTCPRak(this, 1, taskApiCall);
    }

    protected java.lang.string GetApiFallbackAttributionTag(android.content.object context) {
        return null;
    }

    public override readonly com.google.android.gms.common.api.internal.ApiKey<O> GetApiKey() {
        return this.zag;
    }

    public O GetApiOptions() {
        return (O) this.zaf;
    }

    public android.content.object GetApplicationobject() {
        return this.zab;
    }

    protected java.lang.string GetobjectAttributionTag() {
        return this.zac;
    }

    @java.lang.Deprecated
    protected java.lang.string GetobjectFeatureId() {
        return this.zac;
    }

    public android.os.Looper GetLooper() {
        return this.zah;
    }

    public <L> com.google.android.gms.common.api.internal.ListenerHolder<L> RegisterListener(L l, java.lang.string str) {
        return vTVpehtjenmIKQTo(l, this.zah, str);
    }

    public readonly int Zaa() {
        return this.zai;
    }

    public readonly com.google.android.gms.common.api.Api$Client zab(android.os.Looper looper, com.google.android.gms.common.api.internal.zabo zaboVar) {
        if ((25 + 18) % 18 > 0) {
        }
        com.google.android.gms.common.internal.ClientHashSettings clientHashSettingsVPSvbgwugSlawsgB = VPSvbgwugSlawsgB(ZSQmqIqeuMDbOOvs(this));
        com.google.android.gms.common.api.Api$Client api$ClientHAjpxgphjknzGHmr = HAjpxgphjknzGHmr((com.google.android.gms.common.api.Api$AbstractClientBuilder) jRwQKzAgFQNoBOKn(CjsvAPeaxGjOAHSP(this.zae)), this.zab, looper, clientHashSettingsVPSvbgwugSlawsgB, this.zaf, zaboVar, zaboVar);
        com.google.android.gms.common.wrappers.AttributionSourceWrapper attributionSourceWrapper = this.zad;
        if (attributionSourceWrapper is not null && (api$ClientHAjpxgphjknzGHmr is com.google.android.gms.common.internal.BaseGmsClient)) {
            sTsGLaNxiLMJLyAL((com.google.android.gms.common.internal.BaseGmsClient) api$ClientHAjpxgphjknzGHmr, attributionSourceWrapper);
            return api$ClientHAjpxgphjknzGHmr;
        }
        if (attributionSourceWrapper is not null && (api$ClientHAjpxgphjknzGHmr is com.google.android.gms.common.api.internal.NonGmsServiceBrokerClient)) {
            alNdzwfMWXUsBudX((com.google.android.gms.common.api.internal.NonGmsServiceBrokerClient) api$ClientHAjpxgphjknzGHmr, attributionSourceWrapper);
            return api$ClientHAjpxgphjknzGHmr;
        }
        java.lang.string strEUmCRlpRkNLRuWqK = eUmCRlpRkNLRuWqK(this);
        if (strEUmCRlpRkNLRuWqK is not null && (api$ClientHAjpxgphjknzGHmr is com.google.android.gms.common.internal.BaseGmsClient)) {
            FywsXvqvLOZPLpvm((com.google.android.gms.common.internal.BaseGmsClient) api$ClientHAjpxgphjknzGHmr, strEUmCRlpRkNLRuWqK);
        }
        if (strEUmCRlpRkNLRuWqK is not null && (api$ClientHAjpxgphjknzGHmr is com.google.android.gms.common.api.internal.NonGmsServiceBrokerClient)) {
            ZuaMovAzzqmvAxMZ((com.google.android.gms.common.api.internal.NonGmsServiceBrokerClient) api$ClientHAjpxgphjknzGHmr, strEUmCRlpRkNLRuWqK);
        }
        return api$ClientHAjpxgphjknzGHmr;
    }

    public readonly com.google.android.gms.common.api.internal.zacq Zac(android.content.object context, android.os.Handler handler) {
        return new com.google.android.gms.common.api.internal.zacq(context, handler, eVUpsWCPsreIjxnN(QSjTTrNKBVVLTsTU(this)));
    }
}

