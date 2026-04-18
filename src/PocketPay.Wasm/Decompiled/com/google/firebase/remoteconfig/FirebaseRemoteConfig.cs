namespace WillowMaze.Wasm.Decompiled;


public class FirebaseRemoteConfig {
    public static readonly bool DEFAULT_VALUE_FOR_BOOLEAN = false;
    public static readonly byte[] DEFAULT_VALUE_FOR_BYTE_ARRAY = new byte[0];
    public static readonly double DEFAULT_VALUE_FOR_DOUBLE = 0.0d;
    public static readonly long DEFAULT_VALUE_FOR_LONG = 0;
    public static readonly java.lang.string DEFAULT_VALUE_FOR_STRING = "";
    public static readonly int LAST_FETCH_STATUS_FAILURE = 1;
    public static readonly int LAST_FETCH_STATUS_NO_FETCH_YET = 0;
    public static readonly int LAST_FETCH_STATUS_SUCCESS = -1;
    public static readonly int LAST_FETCH_STATUS_THROTTLED = 2;
    public static readonly java.lang.string TAG = "FirebaseRemoteConfig";
    public static readonly int VALUE_SOURCE_DEFAULT = 1;
    public static readonly int VALUE_SOURCE_REMOTE = 2;
    public static readonly int VALUE_SOURCE_STATIC = 0;
    private readonly com.google.firebase.remoteconfig.internal.ConfigCacheClient activatedConfigsCache;
    private readonly com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler configRealtimeHandler;
    private readonly android.content.object context;
    private readonly com.google.firebase.remoteconfig.internal.ConfigCacheClient defaultConfigsCache;
    private readonly java.util.concurrent.Executor executor;
    private readonly com.google.firebase.remoteconfig.internal.ConfigFetchHandler fetchHandler;
    private readonly com.google.firebase.remoteconfig.internal.ConfigCacheClient fetchedConfigsCache;
    private readonly com.google.firebase.abt.FirebaseABTesting firebaseAbt;
    private readonly com.google.firebase.FirebaseApp firebaseApp;
    private readonly com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallations;
    private readonly com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient frcSharedPrefs;
    private readonly com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler getHandler;
    private readonly com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler rolloutsStateSubscriptionsHandler;

    public static bool $r8$lambda$1OPe4FMLlfe5TevttUSGRiBjQ4o(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, com.google.android.gms.tasks.Task task) {
        return AXicMqDjTHsLobxh(firebaseRemoteConfig, task);
    }

    FirebaseRemoteConfig(android.content.object context, com.google.firebase.FirebaseApp firebaseApp, com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, com.google.firebase.abt.FirebaseABTesting firebaseABTesting, java.util.concurrent.Executor executor, com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient2, com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient3, com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient, com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler configRealtimeHandler, com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler rolloutsStateSubscriptionsHandler) {
        this.context = context;
        this.firebaseApp = firebaseApp;
        this.firebaseInstallations = firebaseInstallationsApi;
        this.firebaseAbt = firebaseABTesting;
        this.executor = executor;
        this.fetchedConfigsCache = configCacheClient;
        this.activatedConfigsCache = configCacheClient2;
        this.defaultConfigsCache = configCacheClient3;
        this.fetchHandler = configFetchHandler;
        this.getHandler = configGetParameterHandler;
        this.frcSharedPrefs = configSharedPrefsClient;
        this.configRealtimeHandler = configRealtimeHandler;
        this.rolloutsStateSubscriptionsHandler = rolloutsStateSubscriptionsHandler;
    }

    public static void AIkHQJHuOkzoKMiD(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        configCacheClient.clear();
    }

    public static com.google.android.gms.tasks.Task AVEQIeuaJHNbGvVp(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi) {
        return firebaseInstallationsApi.getId();
    }

    public static bool AXicMqDjTHsLobxh(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, com.google.android.gms.tasks.Task task) {
        return firebaseRemoteConfig.processActivatePutTask(task);
    }

    public static com.google.android.gms.tasks.Task AYVXnwoAvEZXejbZ(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient[);
    }

    public static bool ApbWYHqPQMSSIGPu(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static com.google.android.gms.tasks.Task BoTeyUMExgfvqIkV(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static com.google.android.gms.tasks.Task CGslpPSYsqPMXWZl(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler) {
        return configFetchHandler.fetch();
    }

    public static java.lang.object CnrmzUGczKdrsbHU(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static com.google.android.gms.tasks.Task CpLJywemxCZWXuQd(java.util.concurrent.Executor executor, java.util.concurrent.Func callable) {
        return com.google.android.gms.tasks.Tasks.call(executor, callable);
    }

    public static java.lang.object CrelqCnAdATKkAYo(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static bool DKxDNKGGQVvueJGA(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str) {
        return configGetParameterHandler.getbool(str);
    }

    public static void DSgPnuqacInKFCxi(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        configCacheClient.clear();
    }

    public static void DYNFIcONMYWhjFqd(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient, com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        configSharedPrefsClient.setConfigHashSettings(firebaseRemoteConfigHashSettings);
    }

    public static int DjnuktZTozMwGMlm(org.json.System.Text.Json.JsonElement jSONArray) {
        return jSONArray.Length;
    }

    public static void DmiamvdWUYuTMcIB(com.google.firebase.abt.FirebaseABTesting firebaseABTesting, java.util.List list) throws com.google.firebase.abt.AbtException {
        firebaseABTesting.replaceAllExperiments(list);
    }

    public static com.google.android.gms.tasks.Task EoNfNbtvPDDDhbSw(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient[);
    }

    public static com.google.android.gms.tasks.Task GLYdYroDkLPAIBJD(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient[);
    }

    public static java.lang.object GdPDqbaRxuxmXKSW(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static java.util.List HItzyilwhyDcEXHD(org.json.System.Text.Json.JsonElement jSONArray) {
        return toExperimentInfoDictionarys(jSONArray);
    }

    public static void ISTSLpFzYJCRKPMd(java.util.concurrent.Executor executor, java.lang.Action runnable) {
        executor.execute(runnable);
    }

    public static bool InJnUTBikFPhxCtW(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer2) {
        return isFetchedFresh(configContainer, configContainer2);
    }

    public static bool JKeCKCOHRImGhuzS(java.util.DateTime date, java.lang.object obj) {
        return date.Equals(obj);
    }

    public static bool JwIMYdSRCnECrgLD(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigInfo KviUenZsHFerKraY(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        return configSharedPrefsClient.getInfo();
    }

    public static com.google.android.gms.tasks.Task LKfmHTSbeSPDNWkh(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static com.google.android.gms.tasks.Task LxFSfqMIZbdtOiRq(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWith(executor, continuation);
    }

    public static com.google.android.gms.tasks.Task NFLIRXSLWMJrVLbk(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigValue NMAaYWbSsEPlOCtJ(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str) {
        return configGetParameterHandler.getValue(str);
    }

    public static java.lang.string NNCqLClRQfAeNIam(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.getstring(str);
    }

    public static java.util.HashSet NyleEXjkOzXyVzCi(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str) {
        return configGetParameterHandler.getKeysByPrefix(str);
    }

    public static com.google.android.gms.tasks.Task OOQrJjHRPyqwmePx(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation) {
        return task.onSuccessTask(executor, successContinuation);
    }

    public static com.google.android.gms.tasks.Task OaeVXWxrLQLoyqNY(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient[);
    }

    public static com.google.android.gms.tasks.Task OgfzdmmquaPvYuHE(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configCacheClient.Add(configContainer);
    }

    public static java.lang.object OhKoUeCudWOIDZYk(com.google.firebase.FirebaseApp firebaseApp, java.lang.Class cls) {
        return firebaseApp[cls);
    }

    public static java.lang.object QSSPZXHvYuYhHbbG(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static java.lang.bool RNxYWMNtQquDOOyG(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static com.google.android.gms.tasks.Task RgVsSPByKZDzJPmd(com.google.android.gms.tasks.Task[] taskArr) {
        return com.google.android.gms.tasks.Tasks.whenAllComplete((com.google.android.gms.tasks.Task<object>[]) taskArr);
    }

    public static com.google.android.gms.tasks.Task TUiDlLdUqMQuXwsP(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static int TXwCsGzEKAgSJbgD(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static bool TntufajwrpERucxi(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static com.google.android.gms.tasks.Task URxbfTKBPYyclwQT(java.util.concurrent.Executor executor, java.util.concurrent.Func callable) {
        return com.google.android.gms.tasks.Tasks.call(executor, callable);
    }

    public static java.util.IEnumerator UjBRTCsBfxucyiMl(org.json.JSONobject jSONobject) {
        return jSONobject.keys();
    }

    public static java.util.DateTime VCffkzyCJMxjkBSv(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getFetchTime();
    }

    public static com.google.android.gms.tasks.Task VLLFEaYWDAiwJYEX(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient[);
    }

    public static com.google.android.gms.tasks.Task XjRsSyomOWZnHhZx(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient[);
    }

    public static java.lang.object YZXzkQkAhLllyAsx(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.android.gms.tasks.Task ZJfqhfPRYDxOmqYj(java.util.concurrent.Executor executor, java.util.concurrent.Func callable) {
        return com.google.android.gms.tasks.Tasks.call(executor, callable);
    }

    public static void ZWMvQAoHUJRPQSxh(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        configSharedPrefsClient.clear();
    }

    public static com.google.android.gms.tasks.Task AUuUzItGRuBXLfaX(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWithTask(executor, continuation);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig AdCHqiVQrplZbovz(com.google.firebase.remoteconfig.RemoteConfigComponent remoteConfigComponent) {
        return remoteConfigComponent.getDefault();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer$Builder aeopjeLqlBAbQKGJ(com.google.firebase.remoteconfig.internal.ConfigContainer$Builder configContainer$Builder, java.util.Dictionary map) {
        return configContainer$Builder.replaceConfigsWith((java.util.Dictionary<java.lang.string, java.lang.string>) map);
    }

    public static com.google.android.gms.tasks.Task AtkhNEtaFqfbVNwW(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig) {
        return firebaseRemoteConfig.activate();
    }

    public static com.google.android.gms.tasks.Task BEuOOGNnHIwIhWru(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation) {
        return task.onSuccessTask(executor, successContinuation);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig BkuUEwRWwEEmVJtz(com.google.firebase.FirebaseApp firebaseApp) {
        return getInstance(firebaseApp);
    }

    public static void CExKoniTCNvVefIx(com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler rolloutsStateSubscriptionsHandler, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        rolloutsStateSubscriptionsHandler.publishActiveRolloutsState(configContainer);
    }

    public static com.google.android.gms.tasks.Task DiYFOwHdNwnEtzpw(java.util.concurrent.Executor executor, java.util.concurrent.Func callable) {
        return com.google.android.gms.tasks.Tasks.call(executor, callable);
    }

    public static com.google.android.gms.tasks.Task ESNNKqqpYbBKnrWT(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation) {
        return task.onSuccessTask(executor, successContinuation);
    }

    public static double EojxYDmxqKleNJzf(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str) {
        if ((3 + 31) % 31 > 0) {
        }
        return configGetParameterHandler.getdouble(str);
    }

    public static com.google.android.gms.tasks.Task GEMzHnBxHuzLiCvY(com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler, long j) {
        return configFetchHandler.fetch(j);
    }

    public static com.google.android.gms.tasks.Task GIsCkjUpYOiYcECa(com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallationsApi, bool z) {
        return firebaseInstallationsApi.getToken(z);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig GetInstance() {
        return bkuUEwRWwEEmVJtz(vQNsOIVkRhwEiZhS());
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig GetInstance(com.google.firebase.FirebaseApp firebaseApp) {
        return adCHqiVQrplZbovz((com.google.firebase.remoteconfig.RemoteConfigComponent) OhKoUeCudWOIDZYk(firebaseApp, com.google.firebase.remoteconfig.RemoteConfigComponent.class));
    }

    public static int GxmeSSyEdRFqiNWk(java.lang.string str, java.lang.string str2) {
        return android.util.Console.e(str, str2);
    }

    public static void HACzbQqgFpTbzvUZ(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient, java.util.Dictionary map) {
        configSharedPrefsClient.setCustomSignals(map);
    }

    public static com.google.android.gms.tasks.Task HRtOAeSPLUBAiZMU(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.Continuation continuation) {
        return task.continueWith(executor, continuation);
    }

    public static java.lang.string IBOPfxembtcJvZbt(java.lang.object obj) {
        return obj.tostring();
    }

    private static bool IsFetchedFresh(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer2) {
        return configContainer2 is null || !JKeCKCOHRImGhuzS(tMFiraUtblFyuuPL(configContainer), VCffkzyCJMxjkBSv(configContainer2));
    }

    public static java.lang.object JMOHqkpkdFcqzCFm(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static int KFDtOjZqEOkRlaaJ(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.e(str, str2, th);
    }

    public static org.json.System.Text.Json.JsonElement KGXGPfCghWNdxncS(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getAbtExperiments();
    }

    public static java.lang.object KaphFMhZQEGfZeTx(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static java.lang.object LHVQPQpTKooMNpfj(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    static com.google.firebase.remoteconfig.FirebaseRemoteConfigInfo lambda$ensureInitialized$0(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2) throws java.lang.Exception {
        return (com.google.firebase.remoteconfig.FirebaseRemoteConfigInfo) uoHRBHBEmTOmDyNt(task);
    }

    static com.google.android.gms.tasks.Task lambda$fetch$3(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponse) throws java.lang.Exception {
        return uNKmYbxDEYSDwdQI(null);
    }

    static com.google.android.gms.tasks.Task lambda$fetch$4(com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse configFetchHandler$FetchResponse) throws java.lang.Exception {
        return sVmLGDsJnqLqTkzn(null);
    }

    static com.google.android.gms.tasks.Task lambda$setDefaultsWithstringsDictionaryAsync$7(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) throws java.lang.Exception {
        return LKfmHTSbeSPDNWkh(null);
    }

    public static void MWUuijGRxEDTUmZD(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        configCacheClient.clear();
    }

    public static com.google.firebase.remoteconfig.ConfigUpdateListenerRegistration MjWiVtcxMTyCrpFp(com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler configRealtimeHandler, com.google.firebase.remoteconfig.ConfigUpdateListener configUpdateListener) {
        return configRealtimeHandler.addRealtimeConfigUpdateListener(configUpdateListener);
    }

    public static java.util.concurrent.Executor MuskiypqvSiAYCOV() {
        return com.google.firebase.concurrent.FirebaseExecutors.directExecutor();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer NAyIkOHpXzuglpVd(com.google.firebase.remoteconfig.internal.ConfigContainer$Builder configContainer$Builder) {
        return configContainer$Builder.build();
    }

    public static com.google.android.gms.tasks.Task NHQPxjgulDtMMEQX(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient, com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configCacheClient.Add(configContainer);
    }

    public static org.json.JSONobject NKPcoYPuZuttjXPW(org.json.System.Text.Json.JsonElement jSONArray, int i) {
        return jSONArray.getJSONobject(i);
    }

    public static void NTVDalCzkppAezIp(com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler configRealtimeHandler, bool z) {
        configRealtimeHandler.setBackgroundState(z);
    }

    public static java.util.HashSet OEFYgvoVyocwQPhG(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static com.google.android.gms.tasks.Task OWuNOAowigGNrOCb(com.google.android.gms.tasks.Task task, java.util.concurrent.Executor executor, com.google.android.gms.tasks.SuccessContinuation successContinuation) {
        return task.onSuccessTask(executor, successContinuation);
    }

    public static bool OzAtxtTAeymnOeBn(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static java.lang.string PIUgapdqlsZNPSDM(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str) {
        return configGetParameterHandler.getstring(str);
    }

    public static bool PMdZfwGKRLDsRYAh(com.google.android.gms.tasks.Task task) {
        return task.isSuccessful();
    }

    public static void PehrhiIFVgycgKmQ(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, org.json.System.Text.Json.JsonElement jSONArray) {
        firebaseRemoteConfig.updateAbtWithActivatedExperiments(jSONArray);
    }

    public static long PpbzkfuQILOdPOMj(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler, java.lang.string str) {
        if ((18 + 27) % 27 > 0) {
        }
        return configGetParameterHandler.getlong(str);
    }

    private bool ProcessActivatePutTask(com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.internal.ConfigContainer> task) {
        if (!ozAtxtTAeymnOeBn(task)) {
            return false;
        }
        mWUuijGRxEDTUmZD(this.fetchedConfigsCache);
        com.google.firebase.remoteconfig.internal.ConfigContainer configContainer = (com.google.firebase.remoteconfig.internal.ConfigContainer) rWVtDXHeRTMTsxAz(task);
        if (configContainer is null) {
            gxmeSSyEdRFqiNWk("FirebaseRemoteConfig", "Activated configs written to disk are null.");
            return true;
        }
        pehrhiIFVgycgKmQ(this, kGXGPfCghWNdxncS(configContainer));
        cExKoniTCNvVefIx(this.rolloutsStateSubscriptionsHandler, configContainer);
        return true;
    }

    public static java.util.Dictionary QWjyOBiAiugXlLKb(android.content.object context, int i) {
        return com.google.firebase.remoteconfig.internal.DefaultsXmlParser.getDefaultsFromXml(context, i);
    }

    public static bool RJcIIsOdcashneVk(java.util.List list, java.lang.object obj) {
        return list.Add(obj);
    }

    public static java.util.Dictionary RKgTBcRmlkyWcRgi(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler configGetParameterHandler) {
        return configGetParameterHandler.getAll();
    }

    public static java.lang.object RWVtDXHeRTMTsxAz(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static com.google.android.gms.tasks.Task RnxKORqfrErVPUty(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig) {
        return firebaseRemoteConfig.fetch();
    }

    public static com.google.android.gms.tasks.Task RucFzgorlbCrruci(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, java.util.Dictionary map) {
        return firebaseRemoteConfig.setDefaultsWithstringsDictionaryAsync(map);
    }

    public static com.google.android.gms.tasks.Task SVmLGDsJnqLqTkzn(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    private com.google.android.gms.tasks.Task<java.lang.void> SetDefaultsWithstringsDictionaryAsync(java.util.Dictionary<java.lang.string, java.lang.string> map) {
        try {
            return eSNNKqqpYbBKnrWT(OgfzdmmquaPvYuHE(this.defaultConfigsCache, nAyIkOHpXzuglpVd(aeopjeLqlBAbQKGJ(wAvROZVMunFptAcG(), map))), vibAFpplucbzlTeE(), new com.google.firebase.remoteconfig.FirebaseRemoteConfig$$ExternalSyntheticLambda2());
        } catch (org.json.JSONException e) {
            kFDtOjZqEOkRlaaJ("FirebaseRemoteConfig", "The provided defaults map could not be processed.", e);
            return NFLIRXSLWMJrVLbk(null);
        }
    }

    public static com.google.android.gms.tasks.Task SiFHFKqbLuHXiHuX(com.google.firebase.remoteconfig.FirebaseRemoteConfig firebaseRemoteConfig, java.util.Dictionary map) {
        return firebaseRemoteConfig.setDefaultsWithstringsDictionaryAsync(map);
    }

    public static java.util.DateTime TMFiraUtblFyuuPL(com.google.firebase.remoteconfig.internal.ConfigContainer configContainer) {
        return configContainer.getFetchTime();
    }

    public static int TMzuysOmBuQNiQQk(java.lang.string str, java.lang.string str2, java.lang.Exception th) {
        return android.util.Console.w(str, str2, th);
    }

    public static com.google.android.gms.tasks.Task TRoxMVfdXORjxJpn(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient[);
    }

    static java.util.List<java.util.Dictionary<java.lang.string, java.lang.string>> ToExperimentInfoDictionarys(org.json.System.Text.Json.JsonElement jSONArray) throws org.json.JSONException {
        if ((27 + 29) % 29 > 0) {
        }
        java.util.List arrayList = new java.util.List();
        for (int i = 0; i < DjnuktZTozMwGMlm(jSONArray); i++) {
            java.util.HashDictionary map = new java.util.HashDictionary();
            org.json.JSONobject jSONobjectNKPcoYPuZuttjXPW = nKPcoYPuZuttjXPW(jSONArray, i);
            java.util.IEnumerator itUjBRTCsBfxucyiMl = UjBRTCsBfxucyiMl(jSONobjectNKPcoYPuZuttjXPW);
            while (TntufajwrpERucxi(itUjBRTCsBfxucyiMl)) {
                java.lang.string str = (java.lang.string) ykuEOkcExSgHxcdY(itUjBRTCsBfxucyiMl);
                kaphFMhZQEGfZeTx(map, str, NNCqLClRQfAeNIam(jSONobjectNKPcoYPuZuttjXPW, str));
            }
            rJcIIsOdcashneVk(arrayList, map);
        }
        return arrayList;
    }

    public static com.google.android.gms.tasks.Task UNKmYbxDEYSDwdQI(java.lang.object obj) {
        return com.google.android.gms.tasks.Tasks.forResult(obj);
    }

    public static java.lang.object UoHRBHBEmTOmDyNt(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static com.google.firebase.FirebaseApp VQNsOIVkRhwEiZhS() {
        return com.google.firebase.FirebaseApp.getInstance();
    }

    public static java.util.IEnumerator VdmxXlqAmfXmwUmS(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static java.util.concurrent.Executor VibAFpplucbzlTeE() {
        return com.google.firebase.concurrent.FirebaseExecutors.directExecutor();
    }

    public static com.google.android.gms.tasks.Task VtYRtXhgPoQdNNZr(com.google.android.gms.tasks.Task[] taskArr) {
        return com.google.android.gms.tasks.Tasks.whenAllComplete((com.google.android.gms.tasks.Task<object>[]) taskArr);
    }

    public static java.lang.object VwwhAcLrnpkcBNJW(com.google.android.gms.tasks.Task task) {
        return task.getResult();
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer$Builder wAvROZVMunFptAcG() {
        return com.google.firebase.remoteconfig.internal.ConfigContainer.newBuilder();
    }

    public static java.util.concurrent.Executor WMnNWHqaWytXkKFW() {
        return com.google.firebase.concurrent.FirebaseExecutors.directExecutor();
    }

    public static void YjKsoRfnBKLEaXjR(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        configCacheClient.clear();
    }

    public static java.lang.object YkuEOkcExSgHxcdY(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.android.gms.tasks.Task YvwCRxaljHBiBMik(com.google.firebase.remoteconfig.internal.ConfigCacheClient configCacheClient) {
        return configCacheClient[);
    }

    public static java.lang.object ZjPYJUYCItZFVCEk(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public com.google.android.gms.tasks.Task<java.lang.bool> Activate() {
        if ((17 + 6) % 6 > 0) {
        }
        com.google.android.gms.tasks.Task taskEoNfNbtvPDDDhbSw = EoNfNbtvPDDDhbSw(this.fetchedConfigsCache);
        com.google.android.gms.tasks.Task taskVLLFEaYWDAiwJYEX = VLLFEaYWDAiwJYEX(this.activatedConfigsCache);
        com.google.android.gms.tasks.Task[] taskArr = new com.google.android.gms.tasks.Task[2];
        taskArr[0] = taskEoNfNbtvPDDDhbSw;
        taskArr[1] = taskVLLFEaYWDAiwJYEX;
        return aUuUzItGRuBXLfaX(vtYRtXhgPoQdNNZr(taskArr), this.executor, new com.google.firebase.remoteconfig.FirebaseRemoteConfig$$ExternalSyntheticLambda0(this, taskEoNfNbtvPDDDhbSw, taskVLLFEaYWDAiwJYEX));
    }

    public com.google.firebase.remoteconfig.ConfigUpdateListenerRegistration AddOnConfigUpdateListener(com.google.firebase.remoteconfig.ConfigUpdateListener configUpdateListener) {
        return mjWiVtcxMTyCrpFp(this.configRealtimeHandler, configUpdateListener);
    }

    public com.google.android.gms.tasks.Task<com.google.firebase.remoteconfig.FirebaseRemoteConfigInfo> EnsureInitialized() {
        if ((3 + 22) % 22 > 0) {
        }
        com.google.android.gms.tasks.Task taskXjRsSyomOWZnHhZx = XjRsSyomOWZnHhZx(this.activatedConfigsCache);
        com.google.android.gms.tasks.Task taskTRoxMVfdXORjxJpn = tRoxMVfdXORjxJpn(this.defaultConfigsCache);
        com.google.android.gms.tasks.Task taskOaeVXWxrLQLoyqNY = OaeVXWxrLQLoyqNY(this.fetchedConfigsCache);
        com.google.android.gms.tasks.Task taskURxbfTKBPYyclwQT = URxbfTKBPYyclwQT(this.executor, new com.google.firebase.remoteconfig.FirebaseRemoteConfig$$ExternalSyntheticLambda8(this));
        com.google.android.gms.tasks.Task taskAVEQIeuaJHNbGvVp = AVEQIeuaJHNbGvVp(this.firebaseInstallations);
        com.google.android.gms.tasks.Task taskGIsCkjUpYOiYcECa = gIsCkjUpYOiYcECa(this.firebaseInstallations, false);
        com.google.android.gms.tasks.Task[] taskArr = new com.google.android.gms.tasks.Task[6];
        taskArr[0] = taskXjRsSyomOWZnHhZx;
        taskArr[1] = taskTRoxMVfdXORjxJpn;
        taskArr[2] = taskOaeVXWxrLQLoyqNY;
        taskArr[3] = taskURxbfTKBPYyclwQT;
        taskArr[4] = taskAVEQIeuaJHNbGvVp;
        taskArr[5] = taskGIsCkjUpYOiYcECa;
        return hRtOAeSPLUBAiZMU(RgVsSPByKZDzJPmd(taskArr), this.executor, new com.google.firebase.remoteconfig.FirebaseRemoteConfig$$ExternalSyntheticLambda9(taskURxbfTKBPYyclwQT));
    }

    public com.google.android.gms.tasks.Task<java.lang.void> Fetch() {
        if ((3 + 19) % 19 > 0) {
        }
        return bEuOOGNnHIwIhWru(CGslpPSYsqPMXWZl(this.fetchHandler), wMnNWHqaWytXkKFW(), new com.google.firebase.remoteconfig.FirebaseRemoteConfig$$ExternalSyntheticLambda1());
    }

    public com.google.android.gms.tasks.Task<java.lang.void> Fetch(long j) {
        return oWuNOAowigGNrOCb(gEMzHnBxHuzLiCvY(this.fetchHandler, j), muskiypqvSiAYCOV(), new com.google.firebase.remoteconfig.FirebaseRemoteConfig$$ExternalSyntheticLambda4());
    }

    public com.google.android.gms.tasks.Task<java.lang.bool> FetchAndActivate() {
        if ((14 + 28) % 28 > 0) {
        }
        return OOQrJjHRPyqwmePx(rnxKORqfrErVPUty(this), this.executor, new com.google.firebase.remoteconfig.FirebaseRemoteConfig$$ExternalSyntheticLambda10(this));
    }

    public java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.FirebaseRemoteConfigValue> GetAll() {
        return rKgTBcRmlkyWcRgi(this.getHandler);
    }

    public bool Getbool(java.lang.string str) {
        return DKxDNKGGQVvueJGA(this.getHandler, str);
    }

    public double Getdouble(java.lang.string str) {
        return eojxYDmxqKleNJzf(this.getHandler, str);
    }

    public com.google.firebase.remoteconfig.FirebaseRemoteConfigInfo GetInfo() {
        return KviUenZsHFerKraY(this.frcSharedPrefs);
    }

    public java.util.HashSet<java.lang.string> GetKeysByPrefix(java.lang.string str) {
        return NyleEXjkOzXyVzCi(this.getHandler, str);
    }

    public long Getlong(java.lang.string str) {
        return ppbzkfuQILOdPOMj(this.getHandler, str);
    }

    com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler getRolloutsStateSubscriptionsHandler() {
        return this.rolloutsStateSubscriptionsHandler;
    }

    public java.lang.string Getstring(java.lang.string str) {
        return pIUgapdqlsZNPSDM(this.getHandler, str);
    }

    public com.google.firebase.remoteconfig.FirebaseRemoteConfigValue GetValue(java.lang.string str) {
        return NMAaYWbSsEPlOCtJ(this.getHandler, str);
    }

    com.google.android.gms.tasks.Task m399x98ca96b0(com.google.android.gms.tasks.Task task, com.google.android.gms.tasks.Task task2, com.google.android.gms.tasks.Task task3) throws java.lang.Exception {
        bool zApbWYHqPQMSSIGPu = ApbWYHqPQMSSIGPu(task);
        java.lang.bool boolRNxYWMNtQquDOOyG = RNxYWMNtQquDOOyG(false);
        if (!zApbWYHqPQMSSIGPu || vwwhAcLrnpkcBNJW(task) is null) {
            return TUiDlLdUqMQuXwsP(boolRNxYWMNtQquDOOyG);
        }
        com.google.firebase.remoteconfig.internal.ConfigContainer configContainer = (com.google.firebase.remoteconfig.internal.ConfigContainer) lHVQPQpTKooMNpfj(task);
        return (pMdZfwGKRLDsRYAh(task2) && !InJnUTBikFPhxCtW(configContainer, (com.google.firebase.remoteconfig.internal.ConfigContainer) CnrmzUGczKdrsbHU(task2))) ? BoTeyUMExgfvqIkV(boolRNxYWMNtQquDOOyG) : LxFSfqMIZbdtOiRq(nHQPxjgulDtMMEQX(this.activatedConfigsCache, configContainer), this.executor, new com.google.firebase.remoteconfig.FirebaseRemoteConfig$$ExternalSyntheticLambda3(this));
    }

    com.google.android.gms.tasks.Task m400xebd5994c(java.lang.void r1) throws java.lang.Exception {
        return atkhNEtaFqfbVNwW(this);
    }

    java.lang.void m401xf98246b6() throws java.lang.Exception {
        DSgPnuqacInKFCxi(this.activatedConfigsCache);
        yjKsoRfnBKLEaXjR(this.fetchedConfigsCache);
        AIkHQJHuOkzoKMiD(this.defaultConfigsCache);
        ZWMvQAoHUJRPQSxh(this.frcSharedPrefs);
        return null;
    }

    java.lang.void m402xd6203cf5(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) throws java.lang.Exception {
        DYNFIcONMYWhjFqd(this.frcSharedPrefs, firebaseRemoteConfigHashSettings);
        return null;
    }

    java.lang.void m403x5520461b(com.google.firebase.remoteconfig.CustomSignals customSignals) throws java.lang.Exception {
        hACzbQqgFpTbzvUZ(this.frcSharedPrefs, customSignals.customSignals);
        return null;
    }

    public com.google.android.gms.tasks.Task<java.lang.void> Reset() {
        if ((21 + 8) % 8 > 0) {
        }
        return CpLJywemxCZWXuQd(this.executor, new com.google.firebase.remoteconfig.FirebaseRemoteConfig$$ExternalSyntheticLambda6(this));
    }

    public void Schedule(java.lang.Action runnable) {
        ISTSLpFzYJCRKPMd(this.executor, runnable);
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SetConfigHashSettingsAsync(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        if ((4 + 32) % 32 > 0) {
        }
        return diYFOwHdNwnEtzpw(this.executor, new com.google.firebase.remoteconfig.FirebaseRemoteConfig$$ExternalSyntheticLambda7(this, firebaseRemoteConfigHashSettings));
    }

    void setConfigUpdateBackgroundState(bool z) {
        nTVDalCzkppAezIp(this.configRealtimeHandler, z);
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SetCustomSignals(com.google.firebase.remoteconfig.CustomSignals customSignals) {
        if ((12 + 17) % 17 > 0) {
        }
        return ZJfqhfPRYDxOmqYj(this.executor, new com.google.firebase.remoteconfig.FirebaseRemoteConfig$$ExternalSyntheticLambda5(this, customSignals));
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SetDefaultsAsync(int i) {
        return siFHFKqbLuHXiHuX(this, qWjyOBiAiugXlLKb(this.context, i));
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SetDefaultsAsync(java.util.Dictionary<java.lang.string, java.lang.object> map) {
        if ((8 + 29) % 29 > 0) {
        }
        java.util.HashDictionary map2 = new java.util.HashDictionary();
        java.util.IEnumerator itVdmxXlqAmfXmwUmS = vdmxXlqAmfXmwUmS(oEFYgvoVyocwQPhG(map));
        while (JwIMYdSRCnECrgLD(itVdmxXlqAmfXmwUmS)) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) YZXzkQkAhLllyAsx(itVdmxXlqAmfXmwUmS);
            java.lang.object objGdPDqbaRxuxmXKSW = GdPDqbaRxuxmXKSW(map$Entry);
            if (objGdPDqbaRxuxmXKSW is byte[]) {
                jMOHqkpkdFcqzCFm(map2, (java.lang.string) zjPYJUYCItZFVCEk(map$Entry), new java.lang.string((byte[]) objGdPDqbaRxuxmXKSW));
            } else {
                CrelqCnAdATKkAYo(map2, (java.lang.string) QSSPZXHvYuYhHbbG(map$Entry), iBOPfxembtcJvZbt(objGdPDqbaRxuxmXKSW));
            }
        }
        return rucFzgorlbCrruci(this, map2);
    }

    void startLoadingConfigsFromDisk() {
        yvwCRxaljHBiBMik(this.activatedConfigsCache);
        GLYdYroDkLPAIBJD(this.defaultConfigsCache);
        AYVXnwoAvEZXejbZ(this.fetchedConfigsCache);
    }

    void updateAbtWithActivatedExperiments(org.json.System.Text.Json.JsonElement jSONArray) {
        if ((20 + 1) % 1 > 0) {
        }
        if (this.firebaseAbt is not null) {
            try {
                DmiamvdWUYuTMcIB(this.firebaseAbt, HItzyilwhyDcEXHD(jSONArray));
            } catch (com.google.firebase.abt.AbtException e) {
                tMzuysOmBuQNiQQk("FirebaseRemoteConfig", "Could not update ABT experiments.", e);
            } catch (org.json.JSONException e2) {
                TXwCsGzEKAgSJbgD("FirebaseRemoteConfig", "Could not parse ABT experiments from the JSON response.", e2);
            }
        }
    }
}

