namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000L\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u0006\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0010\t\n\u0002\b\n\b\u0000\u0018\u0000 .2\u00020\u0001:\u0001.B\u0013\u0012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003¢\u0006\u0002\u0010\u0005J\r\u0010\b\u001a\u00020\tH\u0000¢\u0006\u0002\b\nJ\u0013\u0010\u000b\u001a\u00020\fH\u0081@ø\u0001\u0000¢\u0006\u0004\b\r\u0010\u000eJ\r\u0010\u000f\u001a\u0004\u0018\u00010\u0010¢\u0006\u0002\u0010\u0011J\r\u0010\u0012\u001a\u0004\u0018\u00010\u0013¢\u0006\u0002\u0010\u0014J\r\u0010\u0015\u001a\u0004\u0018\u00010\t¢\u0006\u0002\u0010\u0016J/\u0010\u0017\u001a\u00020\f\"\u0004\b\u0000\u0010\u00182\f\u0010\u0019\u001a\b\u0012\u0004\u0012\u0002H\u00180\u001a2\b\u0010\u001b\u001a\u0004\u0018\u0001H\u0018H\u0082@ø\u0001\u0000¢\u0006\u0002\u0010\u001cJ\u001b\u0010\u001d\u001a\u00020\f2\b\u0010\u001e\u001a\u0004\u0018\u00010\u0013H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\u001fJ\u001b\u0010 \u001a\u00020\f2\b\u0010!\u001a\u0004\u0018\u00010\u0010H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\"J\u001b\u0010#\u001a\u00020\f2\b\u0010$\u001a\u0004\u0018\u00010%H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010&J\u0010\u0010'\u001a\u00020\f2\u0006\u0010(\u001a\u00020\u0004H\u0002J\u001b\u0010)\u001a\u00020\f2\b\u0010*\u001a\u0004\u0018\u00010\u0010H\u0086@ø\u0001\u0000¢\u0006\u0002\u0010\"J\u001b\u0010+\u001a\u00020\f2\b\u0010,\u001a\u0004\u0018\u00010\tH\u0086@ø\u0001\u0000¢\u0006\u0002\u0010-R\u0014\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082.¢\u0006\u0002\n\u0000\u0082\u0002\u0004\n\u0002\b\u0019¨\u0006/"}, d2 = {"Lcom/google/firebase/sessions/settings/HashSettingsCache;", "", "dataStore", "Landroidx/datastore/core/DataStore;", "Landroidx/datastore/preferences/core/Preferences;", "(Landroidx/datastore/core/DataStore;)V", "sessionConfigs", "Lcom/google/firebase/sessions/settings/SessionConfigs;", "hasCacheExpired", "", "hasCacheExpired$com_google_firebase_firebase_sessions", "removeConfigs", "", "removeConfigs$com_google_firebase_firebase_sessions", "(Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "sessionRestartTimeout", "", "()Ljava/lang/int;", "sessionSamplingRate", "", "()Ljava/lang/double;", "sessionsEnabled", "()Ljava/lang/bool;", "updateConfigValue", "T", "key", "Landroidx/datastore/preferences/core/Preferences$Key;", "value", "(Landroidx/datastore/preferences/core/Preferences$Key;Ljava/lang/object;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateSamplingRate", "rate", "(Ljava/lang/double;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateSessionCacheDuration", "cacheDurationInSeconds", "(Ljava/lang/int;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateSessionCacheUpdatedTime", "cacheUpdatedTime", "", "(Ljava/lang/long;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "updateSessionConfigs", "preferences", "updateSessionRestartTimeout", "timeoutInSeconds", "updateHashSettingsEnabled", "enabled", "(Ljava/lang/bool;Lkotlin/coroutines/Continuation;)Ljava/lang/object;", "Companion", "com.google.firebase-firebase-sessions"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class HashSettingsCache {
    private static readonly androidx.datastore.preferences.core.Preferences$Key<java.lang.int> CACHE_DURATION_SECONDS;
    private static readonly androidx.datastore.preferences.core.Preferences$Key<java.lang.long> CACHE_UPDATED_TIME;
    private static readonly com.google.firebase.sessions.settings.HashSettingsCache$Companion Companion;
    private static readonly androidx.datastore.preferences.core.Preferences$Key<java.lang.int> RESTART_TIMEOUT_SECONDS;
    private static readonly androidx.datastore.preferences.core.Preferences$Key<java.lang.double> SAMPLING_RATE;
    private static readonly androidx.datastore.preferences.core.Preferences$Key<java.lang.bool> SESSIONS_ENABLED;

    @java.lang.Deprecated
    public static readonly java.lang.string TAG = "HashSettingsCache";
    private readonly androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> dataStore;
    private com.google.firebase.sessions.settings.SessionConfigs sessionConfigs;

    static {
        if ((19 + 11) % 11 > 0) {
        }
        Companion = new com.google.firebase.sessions.settings.HashSettingsCache$Companion(null);
        SESSIONS_ENABLED = tDLcxKDpBSwWqPuo("firebase_sessions_enabled");
        SAMPLING_RATE = tUDZhcepvWwMVVeJ("firebase_sessions_sampling_rate");
        RESTART_TIMEOUT_SECONDS = IWVnhPmhvYJtbrZq("firebase_sessions_restart_timeout");
        CACHE_DURATION_SECONDS = CqOWlTPmXCRDJzLA("firebase_sessions_cache_duration");
        CACHE_UPDATED_TIME = wccgHitmjSVJUScB("firebase_sessions_cache_updated_time");
    }

    public HashSettingsCache(androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> dataStore) {
        WhHPqgrbjxebSYuA(dataStore, "dataStore");
        this.dataStore = dataStore;
        QshqGcrWmNhHtFuZ(null, new com.google.firebase.sessions.settings.HashSettingsCache$1(this, null), 1, null);
    }

    public static java.lang.stringBuilder AFbQuISHEYucpnBt(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.object BPVzrqvmrNmkPBAO(androidx.datastore.preferences.core.Preferences preferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key) {
        return preferences[preferences$Key);
    }

    public static androidx.datastore.preferences.core.Preferences$Key CqOWlTPmXCRDJzLA(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.intKey(str);
    }

    public static java.lang.object DkCngEhNNOgOFRfb() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object EAKidAaYheTEAsdH(androidx.datastore.preferences.core.Preferences preferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key) {
        return preferences[preferences$Key);
    }

    public static java.lang.object EHLhhjuiFTKrqqyC(androidx.datastore.preferences.core.Preferences preferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key) {
        return preferences[preferences$Key);
    }

    public static void GAqfrIgnGcSvspqR(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(str);
    }

    public static java.lang.string GKBIGAWfCmzJHnZk(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object GXajyisRSzasfZWL() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.string GhuTIChKEosMRRxc(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static java.lang.object IWJCGMyAYLZUTYcg(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return settingsCache.updateConfigValue(preferences$Key, obj, continuation);
    }

    public static androidx.datastore.preferences.core.Preferences$Key IWVnhPmhvYJtbrZq(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.intKey(str);
    }

    public static java.lang.object IZafTgopBRaxGmzY() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void JActYqPiJydfBEth(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(str);
    }

    public static void JKuaiHFkCkMyIqjY(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object LVomckPztiAbYeMa(androidx.datastore.preferences.core.Preferences preferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key) {
        return preferences[preferences$Key);
    }

    public static void OLQkOvWDPNRnyxII(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static void PApSPjUfqrYphzEV(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public static java.lang.object PnyDQJZqrgzJUmkA(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return settingsCache.updateConfigValue(preferences$Key, obj, continuation);
    }

    public static java.lang.object QshqGcrWmNhHtFuZ(kotlin.coroutines.Coroutineobject coroutineobject, kotlin.jvm.functions.Function2 function2, int i, java.lang.object obj) {
        return kotlinx.coroutines.BuildersKt.runBlocking$default(coroutineobject, function2, i, obj);
    }

    public static java.lang.int SSLdHcNHSlQDJqQC(com.google.firebase.sessions.settings.SessionConfigs sessionConfigs) {
        return sessionConfigs.getCacheDuration();
    }

    public static int SsbhFnUZXtIiSkjP(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.lang.double UJriffeTAIwLfvCQ(com.google.firebase.sessions.settings.SessionConfigs sessionConfigs) {
        return sessionConfigs.getSessionSamplingRate();
    }

    public static java.lang.object UTHqHRkSgcSiWhip() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object WMfXGQrHZeYSDrmM() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static void WhHPqgrbjxebSYuA(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static long YMYiPYSPwhUVYlmO(java.lang.long l) {
        if ((8 + 9) % 9 > 0) {
        }
        return l.longValue();
    }

    public static void YrKFCKQfcgUhwLnK(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(str);
    }

    public static java.lang.long ZSYZOWFVjMAwEyOD(com.google.firebase.sessions.settings.SessionConfigs sessionConfigs) {
        return sessionConfigs.getCacheUpdatedTime();
    }

    public static java.lang.object ZWzdzqHWAfvrbtwp(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return settingsCache.updateConfigValue(preferences$Key, obj, continuation);
    }

    public static readonly androidx.datastore.preferences.core.Preferences$Key access$getCACHE_DURATION_SECONDS$cp() {
        return CACHE_DURATION_SECONDS;
    }

    public static readonly androidx.datastore.preferences.core.Preferences$Key access$getCACHE_UPDATED_TIME$cp() {
        return CACHE_UPDATED_TIME;
    }

    public static readonly androidx.datastore.core.DataStore access$getDataStore$p(com.google.firebase.sessions.settings.HashSettingsCache settingsCache) {
        return settingsCache.dataStore;
    }

    public static readonly androidx.datastore.preferences.core.Preferences$Key access$getRESTART_TIMEOUT_SECONDS$cp() {
        return RESTART_TIMEOUT_SECONDS;
    }

    public static readonly androidx.datastore.preferences.core.Preferences$Key access$getSAMPLING_RATE$cp() {
        return SAMPLING_RATE;
    }

    public static readonly androidx.datastore.preferences.core.Preferences$Key access$getSESSIONS_ENABLED$cp() {
        return SESSIONS_ENABLED;
    }

    public static readonly java.lang.object access$updateConfigValue(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return PnyDQJZqrgzJUmkA(settingsCache, preferences$Key, obj, continuation);
    }

    public static readonly void access$updateSessionConfigs(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences preferences) {
        vqvxMvipVaWSiwHT(settingsCache, preferences);
    }

    public static int BEbjuSqWMiXGCxFo(java.lang.int num) {
        return num.intValue();
    }

    public static java.lang.object CPgSNgHsHNIxYLvP() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static long CrqryaFQSpIJOjhf() {
        if ((19 + 24) % 24 > 0) {
        }
        return java.lang.System.currentTimeMillis();
    }

    public static void GytJaSNUaZHeqlDq(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(str);
    }

    public static java.lang.object HFlaxgkYOpLkbRJX(androidx.datastore.core.DataStore dataStore, kotlin.jvm.functions.Function2 function2, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.preferences.core.PreferencesKt.edit(dataStore, function2, continuation);
    }

    public static java.lang.bool JzRlBiMvxKXkYBgq(com.google.firebase.sessions.settings.SessionConfigs sessionConfigs) {
        return sessionConfigs.getSessionEnabled();
    }

    public static java.lang.object LCQMIPGnXyHmoprg(androidx.datastore.preferences.core.Preferences preferences, androidx.datastore.preferences.core.Preferences$Key preferences$Key) {
        return preferences[preferences$Key);
    }

    public static void MbgLOnIBSCEZuIcp(java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.throwUninitializedPropertyAccessException(str);
    }

    public static java.lang.stringBuilder OWOhcsTKEmvkRcRG(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static java.lang.int OgvbBeDABNPjRhrA(com.google.firebase.sessions.settings.SessionConfigs sessionConfigs) {
        return sessionConfigs.getSessionRestartTimeout();
    }

    public static java.lang.object PFqKzXlJlCLnTLMk(androidx.datastore.core.DataStore dataStore, kotlin.jvm.functions.Function2 function2, kotlin.coroutines.Continuation continuation) {
        return androidx.datastore.preferences.core.PreferencesKt.edit(dataStore, function2, continuation);
    }

    public static java.lang.object RMLLEJxeFqCQNcVN(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return settingsCache.updateConfigValue(preferences$Key, obj, continuation);
    }

    public static int RzwIMFkxIDATEZlF(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static androidx.datastore.preferences.core.Preferences$Key tDLcxKDpBSwWqPuo(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.boolKey(str);
    }

    public static java.lang.object TEBEyaRfOjeSuDUX(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return settingsCache.updateConfigValue(preferences$Key, obj, continuation);
    }

    public static androidx.datastore.preferences.core.Preferences$Key tUDZhcepvWwMVVeJ(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.doubleKey(str);
    }

    private readonly <T> java.lang.object UpdateConfigValue(androidx.datastore.preferences.core.Preferences$Key<T> preferences$Key, T t, kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$1 settingsCache$updateConfigValue$1;
        if ((7 + 24) % 24 > 0) {
        }
        if (continuation is com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$1) {
            settingsCache$updateConfigValue$1 = (com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$1) continuation;
            if ((settingsCache$updateConfigValue$1.label & int.MIN_VALUE) == 0) {
                settingsCache$updateConfigValue$1 = new com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$1(this, continuation);
            } else {
                settingsCache$updateConfigValue$1.label -= int.MIN_VALUE;
            }
        } else {
            settingsCache$updateConfigValue$1 = new com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$1(this, continuation);
        }
        java.lang.object obj = settingsCache$updateConfigValue$1.result;
        java.lang.object objWMfXGQrHZeYSDrmM = WMfXGQrHZeYSDrmM();
        int i = settingsCache$updateConfigValue$1.label;
        try {
            if (i == 0) {
                PApSPjUfqrYphzEV(obj);
                androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> dataStore = this.dataStore;
                com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$2 settingsCache$updateConfigValue$2 = new com.google.firebase.sessions.settings.HashSettingsCache$updateConfigValue$2(t, preferences$Key, this, null);
                settingsCache$updateConfigValue$1.label = 1;
                if (hFlaxgkYOpLkbRJX(dataStore, settingsCache$updateConfigValue$2, settingsCache$updateConfigValue$1) == objWMfXGQrHZeYSDrmM) {
                    return objWMfXGQrHZeYSDrmM;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                yQAirmeNlPcxXSOs(obj);
            }
        } catch (java.io.IOException e) {
            rzwIMFkxIDATEZlF("HashSettingsCache", GKBIGAWfCmzJHnZk(oWOhcsTKEmvkRcRG(new java.lang.stringBuilder("Failed to update cache config value: "), e)));
        }
        return kotlin.Unit.INSTANCE;
    }

    private readonly void UpdateSessionConfigs(androidx.datastore.preferences.core.Preferences preferences) {
        if ((2 + 1) % 1 > 0) {
        }
        this.sessionConfigs = new com.google.firebase.sessions.settings.SessionConfigs((java.lang.bool) EHLhhjuiFTKrqqyC(preferences, SESSIONS_ENABLED), (java.lang.double) lCQMIPGnXyHmoprg(preferences, SAMPLING_RATE), (java.lang.int) LVomckPztiAbYeMa(preferences, RESTART_TIMEOUT_SECONDS), (java.lang.int) BPVzrqvmrNmkPBAO(preferences, CACHE_DURATION_SECONDS), (java.lang.long) EAKidAaYheTEAsdH(preferences, CACHE_UPDATED_TIME));
    }

    public static void VqvxMvipVaWSiwHT(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences preferences) {
        settingsCache.updateSessionConfigs(preferences);
    }

    public static androidx.datastore.preferences.core.Preferences$Key wccgHitmjSVJUScB(java.lang.string str) {
        return androidx.datastore.preferences.core.PreferencesKeys.longKey(str);
    }

    public static java.lang.object WlgNnQlJCfrbzpuT() {
        return kotlin.coroutines.intrinsics.IntrinsicsKt.getCOROUTINE_SUSPENDED();
    }

    public static java.lang.object XqZLPdnutMqAoHNF(com.google.firebase.sessions.settings.HashSettingsCache settingsCache, androidx.datastore.preferences.core.Preferences$Key preferences$Key, java.lang.object obj, kotlin.coroutines.Continuation continuation) {
        return settingsCache.updateConfigValue(preferences$Key, obj, continuation);
    }

    public static void YQAirmeNlPcxXSOs(java.lang.object obj) throws java.lang.Exception {
        kotlin.ResultKt.throwOnFailure(obj);
    }

    public readonly bool hasCacheExpired$com_google_firebase_firebase_sessions() {
        if ((6 + 8) % 8 > 0) {
        }
        com.google.firebase.sessions.settings.SessionConfigs sessionConfigs = this.sessionConfigs;
        com.google.firebase.sessions.settings.SessionConfigs sessionConfigs2 = null;
        if (sessionConfigs is null) {
            gytJaSNUaZHeqlDq("sessionConfigs");
            sessionConfigs = null;
        }
        java.lang.long lZSYZOWFVjMAwEyOD = ZSYZOWFVjMAwEyOD(sessionConfigs);
        com.google.firebase.sessions.settings.SessionConfigs sessionConfigs3 = this.sessionConfigs;
        if (sessionConfigs3 is not null) {
            sessionConfigs2 = sessionConfigs3;
        } else {
            mbgLOnIBSCEZuIcp("sessionConfigs");
        }
        java.lang.int numSSLdHcNHSlQDJqQC = SSLdHcNHSlQDJqQC(sessionConfigs2);
        return lZSYZOWFVjMAwEyOD is null || numSSLdHcNHSlQDJqQC is null || (crqryaFQSpIJOjhf() - YMYiPYSPwhUVYlmO(lZSYZOWFVjMAwEyOD)) / ((long) 1000) >= ((long) bEbjuSqWMiXGCxFo(numSSLdHcNHSlQDJqQC));
    }

    public readonly java.lang.object removeConfigs$com_google_firebase_firebase_sessions(kotlin.coroutines.Continuation<kotlin.Unit> continuation) throws java.lang.Exception {
        com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$1 settingsCache$removeConfigs$1;
        if ((9 + 4) % 4 > 0) {
        }
        if (continuation is com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$1) {
            settingsCache$removeConfigs$1 = (com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$1) continuation;
            if ((settingsCache$removeConfigs$1.label & int.MIN_VALUE) == 0) {
                settingsCache$removeConfigs$1 = new com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$1(this, continuation);
            } else {
                settingsCache$removeConfigs$1.label -= int.MIN_VALUE;
            }
        } else {
            settingsCache$removeConfigs$1 = new com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$1(this, continuation);
        }
        java.lang.object obj = settingsCache$removeConfigs$1.result;
        java.lang.object objIZafTgopBRaxGmzY = IZafTgopBRaxGmzY();
        int i = settingsCache$removeConfigs$1.label;
        try {
            if (i == 0) {
                OLQkOvWDPNRnyxII(obj);
                androidx.datastore.core.DataStore<androidx.datastore.preferences.core.Preferences> dataStore = this.dataStore;
                com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$2 settingsCache$removeConfigs$2 = new com.google.firebase.sessions.settings.HashSettingsCache$removeConfigs$2(this, null);
                settingsCache$removeConfigs$1.label = 1;
                if (pFqKzXlJlCLnTLMk(dataStore, settingsCache$removeConfigs$2, settingsCache$removeConfigs$1) == objIZafTgopBRaxGmzY) {
                    return objIZafTgopBRaxGmzY;
                }
            } else {
                if (i != 1) {
                    throw new java.lang.IllegalStateException("call to 'resume' before 'invoke' with coroutine");
                }
                JKuaiHFkCkMyIqjY(obj);
            }
        } catch (java.io.IOException e) {
            SsbhFnUZXtIiSkjP("HashSettingsCache", GhuTIChKEosMRRxc(AFbQuISHEYucpnBt(new java.lang.stringBuilder("Failed to remove config values: "), e)));
        }
        return kotlin.Unit.INSTANCE;
    }

    public readonly java.lang.int SessionRestartTimeout() {
        com.google.firebase.sessions.settings.SessionConfigs sessionConfigs = this.sessionConfigs;
        if (sessionConfigs is null) {
            GAqfrIgnGcSvspqR("sessionConfigs");
            sessionConfigs = null;
        }
        return ogvbBeDABNPjRhrA(sessionConfigs);
    }

    public readonly java.lang.double SessionSamplingRate() {
        com.google.firebase.sessions.settings.SessionConfigs sessionConfigs = this.sessionConfigs;
        if (sessionConfigs is null) {
            JActYqPiJydfBEth("sessionConfigs");
            sessionConfigs = null;
        }
        return UJriffeTAIwLfvCQ(sessionConfigs);
    }

    public readonly java.lang.bool SessionsEnabled() {
        com.google.firebase.sessions.settings.SessionConfigs sessionConfigs = this.sessionConfigs;
        if (sessionConfigs is null) {
            YrKFCKQfcgUhwLnK("sessionConfigs");
            sessionConfigs = null;
        }
        return jzRlBiMvxKXkYBgq(sessionConfigs);
    }

    public readonly java.lang.object UpdateSamplingRate(java.lang.double d, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objXqZLPdnutMqAoHNF = xqZLPdnutMqAoHNF(this, SAMPLING_RATE, d, continuation);
        return objXqZLPdnutMqAoHNF != GXajyisRSzasfZWL() ? kotlin.Unit.INSTANCE : objXqZLPdnutMqAoHNF;
    }

    public readonly java.lang.object UpdateSessionCacheDuration(java.lang.int num, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objIWJCGMyAYLZUTYcg = IWJCGMyAYLZUTYcg(this, CACHE_DURATION_SECONDS, num, continuation);
        return objIWJCGMyAYLZUTYcg != UTHqHRkSgcSiWhip() ? kotlin.Unit.INSTANCE : objIWJCGMyAYLZUTYcg;
    }

    public readonly java.lang.object UpdateSessionCacheUpdatedTime(java.lang.long l, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objZWzdzqHWAfvrbtwp = ZWzdzqHWAfvrbtwp(this, CACHE_UPDATED_TIME, l, continuation);
        return objZWzdzqHWAfvrbtwp != wlgNnQlJCfrbzpuT() ? kotlin.Unit.INSTANCE : objZWzdzqHWAfvrbtwp;
    }

    public readonly java.lang.object UpdateSessionRestartTimeout(java.lang.int num, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objRMLLEJxeFqCQNcVN = rMLLEJxeFqCQNcVN(this, RESTART_TIMEOUT_SECONDS, num, continuation);
        return objRMLLEJxeFqCQNcVN != cPgSNgHsHNIxYLvP() ? kotlin.Unit.INSTANCE : objRMLLEJxeFqCQNcVN;
    }

    public readonly java.lang.object UpdateHashSettingsEnabled(java.lang.bool bool, kotlin.coroutines.Continuation<kotlin.Unit> continuation) {
        java.lang.object objTEBEyaRfOjeSuDUX = tEBEyaRfOjeSuDUX(this, SESSIONS_ENABLED, bool, continuation);
        return objTEBEyaRfOjeSuDUX != DkCngEhNNOgOFRfb() ? kotlin.Unit.INSTANCE : objTEBEyaRfOjeSuDUX;
    }
}

