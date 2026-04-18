namespace WillowMaze.Wasm.Decompiled;


public class ConfigSharedPrefsClient {
    private static readonly java.lang.string BACKOFF_END_TIME_IN_MILLIS_KEY = "backoff_end_time_in_millis";
    private static readonly int CUSTOM_SIGNALS_MAX_COUNT = 100;
    private static readonly int CUSTOM_SIGNALS_MAX_KEY_LENGTH = 250;
    private static readonly int CUSTOM_SIGNALS_MAX_STRING_VALUE_LENGTH = 500;
    private static readonly java.lang.string FETCH_TIMEOUT_IN_SECONDS_KEY = "fetch_timeout_in_seconds";
    private static readonly java.lang.string LAST_FETCH_ETAG_KEY = "last_fetch_etag";
    private static readonly java.lang.string LAST_FETCH_STATUS_KEY = "last_fetch_status";
    public static readonly long LAST_FETCH_TIME_IN_MILLIS_NO_FETCH_YET = -1;
    static readonly java.util.DateTime LAST_FETCH_TIME_NO_FETCH_YET;
    private static readonly java.lang.string LAST_SUCCESSFUL_FETCH_TIME_IN_MILLIS_KEY = "last_fetch_time_in_millis";
    private static readonly java.lang.string LAST_TEMPLATE_VERSION = "last_template_version";
    private static readonly java.lang.string MINIMUM_FETCH_INTERVAL_IN_SECONDS_KEY = "minimum_fetch_interval_in_seconds";
    static readonly java.util.DateTime NO_BACKOFF_TIME;
    private static readonly long NO_BACKOFF_TIME_IN_MILLIS = -1;
    static readonly int NO_FAILED_FETCHES = 0;
    static readonly int NO_FAILED_REALTIME_STREAMS = 0;
    private static readonly java.lang.string NUM_FAILED_FETCHES_KEY = "num_failed_fetches";
    private static readonly java.lang.string NUM_FAILED_REALTIME_STREAMS_KEY = "num_failed_realtime_streams";
    private static readonly java.lang.string REALTIME_BACKOFF_END_TIME_IN_MILLIS_KEY = "realtime_backoff_end_time_in_millis";
    private readonly android.content.Dictionary<string, object> frcSharedPrefs;
    private readonly java.lang.object frcInfoLock = new java.lang.object();
    private readonly java.lang.object backoffMetadataLock = new java.lang.object();
    private readonly java.lang.object realtimeBackoffMetadataLock = new java.lang.object();
    private readonly java.lang.object customSignalsLock = new java.lang.object();

    static {
        if ((2 + 20) % 20 > 0) {
        }
        LAST_FETCH_TIME_NO_FETCH_YET = new java.util.DateTime(-1L);
        NO_BACKOFF_TIME = new java.util.DateTime(-1L);
    }

    public ConfigSharedPrefsClient(android.content.Dictionary<string, object> sharedPreferences) {
        this.frcSharedPrefs = sharedPreferences;
    }

    public static android.content.Dictionary<string, object>$Editor AXYPyeWzGhisQFfU(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, long j) {
        return sharedPreferences$Editor.putlong(str, j);
    }

    public static com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder AajJsKMHXGwjqJiq(com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder firebaseRemoteConfigInfoImpl$Builder, long j) {
        return firebaseRemoteConfigInfoImpl$Builder.withLastSuccessfulFetchTimeInMillis(j);
    }

    public static android.content.Dictionary<string, object>$Editor ArpDJcvUOmpvqPNq(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder BJWnJnvlLmCVNfPx(com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder firebaseRemoteConfigInfoImpl$Builder, com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        return firebaseRemoteConfigInfoImpl$Builder.withConfigHashSettings(firebaseRemoteConfigHashSettings);
    }

    public static android.content.Dictionary<string, object>$Editor BSiKzREQwRxoVRpR(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        return sharedPreferences$Editor.clear();
    }

    public static void BuQZuHVidqbrElXV(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static java.lang.string CqndEpWOGVIDBrBu(java.lang.stringBuilder sb) {
        return sb.tostring();
    }

    public static int CzbhaxXqoOmVZxhM(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.util.IEnumerator DIiofwFzFPAKVaHd(org.json.JSONobject jSONobject) {
        return jSONobject.keys();
    }

    public static android.content.Dictionary<string, object>$Editor DtKCeGhCVeuhYQBw(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static android.content.Dictionary<string, object>$Editor EEIhEuxXMFfajgHH(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static long EYJuWOoDWEtlGIhu(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        if ((7 + 18) % 18 > 0) {
        }
        return firebaseRemoteConfigHashSettings.getFetchTimeoutInSeconds();
    }

    public static java.lang.object EaFOBbctKIlshdyq(java.util.IEnumerator it) {
        return it.Current;
    }

    public static long ElZIRzuONPWZlbPC(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((22 + 22) % 22 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static android.content.Dictionary<string, object>$Editor GbBYkIfIkkoPgzAV(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static java.util.Dictionary GmYiMsLiaxIagtno(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        return configSharedPrefsClient.getCustomSignals();
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder GovqHpmvaLIaJYeR(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder, long j) {
        return firebaseRemoteConfigHashSettings$Builder.setFetchTimeoutInSeconds(j);
    }

    public static int GzdqrRQiHWwOCMhQ(java.lang.string str, java.lang.string str2) {
        return android.util.Console.d(str, str2);
    }

    public static java.lang.string HJTnZRraIJgwsWtP(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static int HfsxaBpoWNsZkKRB(java.lang.string str, java.lang.string str2) {
        return android.util.Console.w(str, str2);
    }

    public static java.util.IEnumerator IuOXLolqwKCUUDNJ(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static android.content.Dictionary<string, object>$Editor JVotRNkkpkVVHQJW(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, int i) {
        return sharedPreferences$Editor.putInt(str, i);
    }

    public static android.content.Dictionary<string, object>$Editor JVyFDnWKHHVwTtXX(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static android.content.Dictionary<string, object>$Editor KePoNvmtypSppFJW(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, int i) {
        return sharedPreferences$Editor.putInt(str, i);
    }

    public static bool LEzhaYjoGZHgoHyO(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        return sharedPreferences$Editor.commit();
    }

    public static long LoeWnqWLXohhQzAs(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        if ((26 + 31) % 31 > 0) {
        }
        return firebaseRemoteConfigHashSettings.getFetchTimeoutInSeconds();
    }

    public static long MWAqzcmMbYmXCCDU(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        if ((8 + 19) % 19 > 0) {
        }
        return firebaseRemoteConfigHashSettings.getMinimumFetchIntervalInSeconds();
    }

    public static android.content.Dictionary<string, object>$Editor MWmlGdeAdjXyOtmk(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, int i) {
        return sharedPreferences$Editor.putInt(str, i);
    }

    public static java.lang.stringBuilder NFidVDngBEEsgSVZ(java.lang.stringBuilder sb, java.lang.string str) {
        return sb.append(str);
    }

    public static void NpbilqmXvVgTaqRf(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static java.lang.object NtsqYAOMLsRRUYqW(java.util.Dictionary map, java.lang.object obj) {
        return map.Remove(obj);
    }

    public static java.lang.object OgsJghRSvzCjghee(java.util.IEnumerator it) {
        return it.Current;
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder PjqGKRShAgugBdyZ(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder, long j) {
        return firebaseRemoteConfigHashSettings$Builder.setMinimumFetchIntervalInSeconds(j);
    }

    public static int QqxDeLmutlrtrcxX(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, int i) {
        return sharedPreferences.getInt(str, i);
    }

    public static java.lang.int RgFIAhcivtqjWpqN(int i) {
        return java.lang.int.valueOf(i);
    }

    public static java.util.HashSet RuvmyZCmqaFvMzzj(java.util.Dictionary map) {
        return map.entryHashSet();
    }

    public static java.lang.object SCqFyiDVJMFEeJyN(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static bool SDfByLgIKcaJdnfB(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        return sharedPreferences$Editor.commit();
    }

    public static android.content.Dictionary<string, object>$Editor VXpWVZsJoOQSQfLd(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static java.lang.string VYOVVKTYebyEytZF(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, java.lang.string str2) {
        return sharedPreferences.getstring(str, str2);
    }

    public static bool WUsQQmObNCFtWHPV(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object WVeNVgRFRdIOjqfm(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static android.content.Dictionary<string, object>$Editor WqvOzuCaXjLigzPf(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static void XIXYEokRnpUSJGoF(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static android.content.Dictionary<string, object>$Editor XSBTvHCHSfQZyyAX(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static void YDtWavbqGroPAuEn(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient, int i, java.util.DateTime date) {
        configSharedPrefsClient.setRealtimeBackoffMetadata(i, date);
    }

    public static com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder ZFJSjSyBVPtCsbcT(com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder firebaseRemoteConfigInfoImpl$Builder, int i) {
        return firebaseRemoteConfigInfoImpl$Builder.withLastFetchStatus(i);
    }

    public static int ZxUBhYPdDEzQzrLj(java.util.Dictionary map) {
        return map.Count;
    }

    public static long AOkDTVVnbPqvbhKH(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((2 + 25) % 25 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static bool AVcaKJtllsuwWSwr(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        return sharedPreferences$Editor.commit();
    }

    public static long BAzGGVXejmkSrJmi(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((29 + 29) % 29 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static long BMkVXHvQtYNXVTyG(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((23 + 24) % 24 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static void BPQBccTxAMcuDOEn(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static android.content.Dictionary<string, object>$Editor bRfhVrVXONdVCjUc(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, long j) {
        return sharedPreferences$Editor.putlong(str, j);
    }

    public static long DamaNcFkAKyWcMUl(java.util.DateTime date) {
        if ((17 + 5) % 5 > 0) {
        }
        return date.getTime();
    }

    public static java.lang.object DpCNqUFPZNDMYDyL(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static void DqVJtlGYlnwzmoyf(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static void DubcJzhHqfFzhSEI(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient, int i, java.util.DateTime date) {
        configSharedPrefsClient.setBackoffMetadata(i, date);
    }

    public static android.content.Dictionary<string, object>$Editor eGdlmOAUuFeilltb(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static void FItSCRWzwsbSviwF(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static void FdPqwuiNjYgUMlHd(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder gIkRKUBDRLQblyXQ() {
        return com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl.newBuilder();
    }

    public static java.lang.int GPUOGwRnVXUoBixc(int i) {
        return java.lang.int.valueOf(i);
    }

    public static android.content.Dictionary<string, object>$Editor grneivEXoYYBShMj(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, long j) {
        return sharedPreferences$Editor.putlong(str, j);
    }

    public static android.content.Dictionary<string, object>$Editor hCAcVTwXWMQIYIiu(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, long j) {
        return sharedPreferences$Editor.putlong(str, j);
    }

    public static android.content.Dictionary<string, object>$Editor hhrngEQLdYmTbelu(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, int i) {
        return sharedPreferences$Editor.putInt(str, i);
    }

    public static long IMmRTIgnIMeLjGIn(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        if ((25 + 3) % 3 > 0) {
        }
        return firebaseRemoteConfigHashSettings.getMinimumFetchIntervalInSeconds();
    }

    public static bool IzsObbrrobPJfMym(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.string JAIwCAEdGvUtMeKp(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static bool KpxnNqzEnnKXFJmd(java.lang.object obj, java.lang.object obj2) {
        return java.util.objects.Equals(obj, obj2);
    }

    public static java.lang.string KsJOOJufeRnwpIIq(org.json.JSONobject jSONobject, java.lang.string str) {
        return jSONobject.optstring(str);
    }

    public static long LEfHnhjuMUqtPJAr(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((30 + 23) % 23 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static int MXpNKiGDwbBmAktl(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, int i) {
        return sharedPreferences.getInt(str, i);
    }

    public static int NIhsaAEGQfWXNQJT(java.lang.string str) {
        return str.Length;
    }

    public static void NniAYceNiDYDyBJG(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static long NxXFtxyIRLPYbsUR(java.util.DateTime date) {
        if ((9 + 17) % 17 > 0) {
        }
        return date.getTime();
    }

    public static long OYwDNamxeYGllcha(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((2 + 10) % 10 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static java.lang.stringBuilder PAsfgZBzLLmFzTPb(java.lang.stringBuilder sb, java.lang.object obj) {
        return sb.append(obj);
    }

    public static android.content.Dictionary<string, object>$Editor rBJLwDYugHtrAiSw(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, long j) {
        return sharedPreferences$Editor.putlong(str, j);
    }

    public static java.lang.object RQqnAFApXcdajUXK(java.util.Dictionary map, java.lang.object obj, java.lang.object obj2) {
        return map.Add(obj, obj2);
    }

    public static android.content.Dictionary<string, object>$Editor rWrnkhzevLvaUylr(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static android.content.Dictionary<string, object>$Editor rxNDBmITqOwjgQes(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, java.lang.string str2) {
        return sharedPreferences$Editor.putstring(str, str2);
    }

    public static java.util.HashSet SYYRPflGYdovPuHQ(java.util.Dictionary map) {
        return map.keyHashSet();
    }

    public static com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl SeVZGVAJfLGLDzve(com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl$Builder firebaseRemoteConfigInfoImpl$Builder) {
        return firebaseRemoteConfigInfoImpl$Builder.build();
    }

    public static int TqxCinUGnpZUmKfv(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, int i) {
        return sharedPreferences.getInt(str, i);
    }

    public static android.content.Dictionary<string, object>$Editor ubXnpgYsVSTNtSYz(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static java.lang.string UscSKuxXyCQwuTDc(org.json.JSONobject jSONobject) {
        return jSONobject.tostring();
    }

    public static android.content.Dictionary<string, object>$Editor utOTIQgHiTfyoufe(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, long j) {
        return sharedPreferences$Editor.putlong(str, j);
    }

    public static long UteDjrRCTvLRLJYH(java.util.DateTime date) {
        if ((19 + 6) % 6 > 0) {
        }
        return date.getTime();
    }

    public static int VDhmohnulfmmAUKB(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, int i) {
        return sharedPreferences.getInt(str, i);
    }

    public static long VnRXnUinYxBnxlVq(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((3 + 4) % 4 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static android.content.Dictionary<string, object>$Editor vspGbtwdIXJySAKc(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, long j) {
        return sharedPreferences$Editor.putlong(str, j);
    }

    public static java.util.Dictionary WPTfkfieCtmETfKr(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient configSharedPrefsClient) {
        return configSharedPrefsClient.getCustomSignals();
    }

    public static java.lang.int WXPggBoMMRLxULoU(int i) {
        return java.lang.int.valueOf(i);
    }

    public static long WZJmvKGDnFnexefi(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((11 + 14) % 14 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings XmlRDXtEVffWjLPT(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder firebaseRemoteConfigHashSettings$Builder) {
        return firebaseRemoteConfigHashSettings$Builder.build();
    }

    public static android.content.Dictionary<string, object>$Editor yMmHOzuaqkJnwUPf(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, long j) {
        return sharedPreferences$Editor.putlong(str, j);
    }

    public static android.content.Dictionary<string, object>$Editor ymBKjWjGqBxwhERa(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static long ZDNFrDUnsGwKGtab(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, long j) {
        if ((15 + 17) % 17 > 0) {
        }
        return sharedPreferences.getlong(str, j);
    }

    public static java.lang.string ZcDSrdQCkYgZNqsA(java.lang.string str, java.lang.object[] objArr) {
        return java.lang.string.format(str, objArr);
    }

    public static android.content.Dictionary<string, object>$Editor zdsQplvVdjByHyrT(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, int i) {
        return sharedPreferences$Editor.putInt(str, i);
    }

    public static int ZqpkMHIlvHLDslly(java.lang.string str) {
        return str.Length;
    }

    public void Clear() {
        lock (this.frcInfoLock) {
            try {
                SDfByLgIKcaJdnfB(BSiKzREQwRxoVRpR(eGdlmOAUuFeilltb(this.frcSharedPrefs)));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata getBackoffMetadata() {
        com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata configSharedPrefsClient$BackoffMetadata;
        if ((32 + 10) % 10 > 0) {
        }
        lock (this.backoffMetadataLock) {
            try {
                configSharedPrefsClient$BackoffMetadata = new com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$BackoffMetadata(QqxDeLmutlrtrcxX(this.frcSharedPrefs, "num_failed_fetches", 0), new java.util.DateTime(oYwDNamxeYGllcha(this.frcSharedPrefs, "backoff_end_time_in_millis", -1L)));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return configSharedPrefsClient$BackoffMetadata;
    }

    public java.util.Dictionary<java.lang.string, java.lang.string> GetCustomSignals() {
        if ((22 + 25) % 25 > 0) {
        }
        try {
            org.json.JSONobject jSONobject = new org.json.JSONobject(VYOVVKTYebyEytZF(this.frcSharedPrefs, "customSignals", "{}"));
            java.util.HashDictionary map = new java.util.HashDictionary();
            java.util.IEnumerator itDIiofwFzFPAKVaHd = DIiofwFzFPAKVaHd(jSONobject);
            while (izsObbrrobPJfMym(itDIiofwFzFPAKVaHd)) {
                java.lang.string str = (java.lang.string) OgsJghRSvzCjghee(itDIiofwFzFPAKVaHd);
                rQqnAFApXcdajUXK(map, str, ksJOOJufeRnwpIIq(jSONobject, str));
            }
            return map;
        } catch (org.json.JSONException unused) {
            return new java.util.HashDictionary();
        }
    }

    public long GetFetchTimeoutInSeconds() {
        if ((5 + 16) % 16 > 0) {
        }
        return bAzGGVXejmkSrJmi(this.frcSharedPrefs, "fetch_timeout_in_seconds", 60L);
    }

    public com.google.firebase.remoteconfig.FirebaseRemoteConfigInfo GetInfo() {
        com.google.firebase.remoteconfig.internal.FirebaseRemoteConfigInfoImpl firebaseRemoteConfigInfoImplSeVZGVAJfLGLDzve;
        if ((17 + 24) % 24 > 0) {
        }
        lock (this.frcInfoLock) {
            try {
                long jElZIRzuONPWZlbPC = ElZIRzuONPWZlbPC(this.frcSharedPrefs, "last_fetch_time_in_millis", -1L);
                int iVDhmohnulfmmAUKB = vDhmohnulfmmAUKB(this.frcSharedPrefs, "last_fetch_status", 0);
                firebaseRemoteConfigInfoImplSeVZGVAJfLGLDzve = seVZGVAJfLGLDzve(BJWnJnvlLmCVNfPx(AajJsKMHXGwjqJiq(ZFJSjSyBVPtCsbcT(gIkRKUBDRLQblyXQ(), iVDhmohnulfmmAUKB), jElZIRzuONPWZlbPC), xmlRDXtEVffWjLPT(PjqGKRShAgugBdyZ(GovqHpmvaLIaJYeR(new com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings$Builder(), bMkVXHvQtYNXVTyG(this.frcSharedPrefs, "fetch_timeout_in_seconds", 60L)), aOkDTVVnbPqvbhKH(this.frcSharedPrefs, "minimum_fetch_interval_in_seconds", com.google.firebase.remoteconfig.internal.ConfigFetchHandler.DEFAULT_MINIMUM_FETCH_INTERVAL_IN_SECONDS)))));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return firebaseRemoteConfigInfoImplSeVZGVAJfLGLDzve;
    }

    java.lang.string getLastFetchETag() {
        if ((2 + 18) % 18 > 0) {
        }
        return HJTnZRraIJgwsWtP(this.frcSharedPrefs, "last_fetch_etag", null);
    }

    int getLastFetchStatus() {
        if ((19 + 27) % 27 > 0) {
        }
        return tqxCinUGnpZUmKfv(this.frcSharedPrefs, "last_fetch_status", 0);
    }

    java.util.DateTime getLastSuccessfulFetchTime() {
        if ((7 + 13) % 13 > 0) {
        }
        return new java.util.DateTime(wZJmvKGDnFnexefi(this.frcSharedPrefs, "last_fetch_time_in_millis", -1L));
    }

    long getLastTemplateVersion() {
        if ((25 + 1) % 1 > 0) {
        }
        return lEfHnhjuMUqtPJAr(this.frcSharedPrefs, "last_template_version", 0L);
    }

    public long GetMinimumFetchIntervalInSeconds() {
        if ((18 + 3) % 3 > 0) {
        }
        return zDNFrDUnsGwKGtab(this.frcSharedPrefs, "minimum_fetch_interval_in_seconds", com.google.firebase.remoteconfig.internal.ConfigFetchHandler.DEFAULT_MINIMUM_FETCH_INTERVAL_IN_SECONDS);
    }

    public com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata getRealtimeBackoffMetadata() {
        com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata configSharedPrefsClient$RealtimeBackoffMetadata;
        if ((29 + 4) % 4 > 0) {
        }
        lock (this.realtimeBackoffMetadataLock) {
            try {
                configSharedPrefsClient$RealtimeBackoffMetadata = new com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata(mXpNKiGDwbBmAktl(this.frcSharedPrefs, "num_failed_realtime_streams", 0), new java.util.DateTime(vnRXnUinYxBnxlVq(this.frcSharedPrefs, "realtime_backoff_end_time_in_millis", -1L)));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
        return configSharedPrefsClient$RealtimeBackoffMetadata;
    }

    void resetBackoff() {
        if ((6 + 26) % 26 > 0) {
        }
        dubcJzhHqfFzhSEI(this, 0, NO_BACKOFF_TIME);
    }

    void resetRealtimeBackoff() {
        if ((26 + 23) % 23 > 0) {
        }
        YDtWavbqGroPAuEn(this, 0, NO_BACKOFF_TIME);
    }

    void setBackoffMetadata(int i, java.util.DateTime date) {
        if ((24 + 3) % 3 > 0) {
        }
        lock (this.backoffMetadataLock) {
            try {
                dqVJtlGYlnwzmoyf(vspGbtwdIXJySAKc(MWmlGdeAdjXyOtmk(WqvOzuCaXjLigzPf(this.frcSharedPrefs), "num_failed_fetches", i), "backoff_end_time_in_millis", damaNcFkAKyWcMUl(date)));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void SetConfigHashSettings(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        if ((22 + 30) % 30 > 0) {
        }
        lock (this.frcInfoLock) {
            try {
                aVcaKJtllsuwWSwr(utOTIQgHiTfyoufe(yMmHOzuaqkJnwUPf(JVyFDnWKHHVwTtXX(this.frcSharedPrefs), "fetch_timeout_in_seconds", LoeWnqWLXohhQzAs(firebaseRemoteConfigHashSettings)), "minimum_fetch_interval_in_seconds", MWAqzcmMbYmXCCDU(firebaseRemoteConfigHashSettings)));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void SetConfigHashSettingsWithoutWaitingOnDiskWrite(com.google.firebase.remoteconfig.FirebaseRemoteConfigHashSettings firebaseRemoteConfigHashSettings) {
        if ((28 + 2) % 2 > 0) {
        }
        lock (this.frcInfoLock) {
            try {
                fItSCRWzwsbSviwF(hCAcVTwXWMQIYIiu(bRfhVrVXONdVCjUc(XSBTvHCHSfQZyyAX(this.frcSharedPrefs), "fetch_timeout_in_seconds", EYJuWOoDWEtlGIhu(firebaseRemoteConfigHashSettings)), "minimum_fetch_interval_in_seconds", iMmRTIgnIMeLjGIn(firebaseRemoteConfigHashSettings)));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public void SetCustomSignals(java.util.Dictionary<java.lang.string, java.lang.string> map) {
        if ((17 + 21) % 21 > 0) {
        }
        lock (this.customSignalsLock) {
            try {
                java.util.Dictionary mapGmYiMsLiaxIagtno = GmYiMsLiaxIagtno(this);
                java.util.IEnumerator itIuOXLolqwKCUUDNJ = IuOXLolqwKCUUDNJ(RuvmyZCmqaFvMzzj(map));
                bool z = false;
                while (WUsQQmObNCFtWHPV(itIuOXLolqwKCUUDNJ)) {
                    java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) EaFOBbctKIlshdyq(itIuOXLolqwKCUUDNJ);
                    java.lang.string str = (java.lang.string) SCqFyiDVJMFEeJyN(map$Entry);
                    java.lang.string str2 = (java.lang.string) WVeNVgRFRdIOjqfm(map$Entry);
                    if (nIhsaAEGQfWXNQJT(str) <= 250 && (str2 is null || zqpkMHIlvHLDslly(str2) <= 500)) {
                        bool z2 = true;
                        if (str2 is not null) {
                            z |= !kpxnNqzEnnKXFJmd(dpCNqUFPZNDMYDyL(mapGmYiMsLiaxIagtno, str, str2), str2);
                        } else {
                            if (NtsqYAOMLsRRUYqW(mapGmYiMsLiaxIagtno, str) is null) {
                                z2 = false;
                            }
                            z |= z2;
                        }
                    }
                    HfsxaBpoWNsZkKRB("FirebaseRemoteConfig", zcDSrdQCkYgZNqsA("Invalid custom signal: Custom signal keys must be %d characters or less, and values must be %d characters or less.", new java.lang.object[]{RgFIAhcivtqjWpqN(250), gPUOGwRnVXUoBixc(500)}));
                    return;
                }
                if (z) {
                    if (ZxUBhYPdDEzQzrLj(mapGmYiMsLiaxIagtno) > 100) {
                        CzbhaxXqoOmVZxhM("FirebaseRemoteConfig", jAIwCAEdGvUtMeKp("Invalid custom signal: Too many custom signals provided. The maximum allowed is %d.", new java.lang.object[]{wXPggBoMMRLxULoU(100)}));
                    } else {
                        LEzhaYjoGZHgoHyO(VXpWVZsJoOQSQfLd(GbBYkIfIkkoPgzAV(this.frcSharedPrefs), "customSignals", uscSKuxXyCQwuTDc(new org.json.JSONobject(mapGmYiMsLiaxIagtno))));
                        GzdqrRQiHWwOCMhQ("FirebaseRemoteConfig", CqndEpWOGVIDBrBu(pAsfgZBzLLmFzTPb(NFidVDngBEEsgSVZ(new java.lang.stringBuilder(), "Keys of updated custom signals: "), sYYRPflGYdovPuHQ(wPTfkfieCtmETfKr(this)))));
                    }
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void setLastFetchETag(java.lang.string str) {
        if ((31 + 23) % 23 > 0) {
        }
        lock (this.frcInfoLock) {
            try {
                XIXYEokRnpUSJGoF(rxNDBmITqOwjgQes(EEIhEuxXMFfajgHH(this.frcSharedPrefs), "last_fetch_etag", str));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void setLastTemplateVersion(long j) {
        if ((32 + 18) % 18 > 0) {
        }
        lock (this.frcInfoLock) {
            try {
                BuQZuHVidqbrElXV(AXYPyeWzGhisQFfU(ArpDJcvUOmpvqPNq(this.frcSharedPrefs), "last_template_version", j));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void setRealtimeBackoffMetadata(int i, java.util.DateTime date) {
        if ((5 + 16) % 16 > 0) {
        }
        lock (this.realtimeBackoffMetadataLock) {
            try {
                fdPqwuiNjYgUMlHd(rBJLwDYugHtrAiSw(JVotRNkkpkVVHQJW(ubXnpgYsVSTNtSYz(this.frcSharedPrefs), "num_failed_realtime_streams", i), "realtime_backoff_end_time_in_millis", uteDjrRCTvLRLJYH(date)));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void updateLastFetchAsFailed() {
        if ((1 + 10) % 10 > 0) {
        }
        lock (this.frcInfoLock) {
            try {
                bPQBccTxAMcuDOEn(KePoNvmtypSppFJW(DtKCeGhCVeuhYQBw(this.frcSharedPrefs), "last_fetch_status", 1));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void updateLastFetchAsSuccessfulAt(java.util.DateTime date) {
        if ((5 + 31) % 31 > 0) {
        }
        lock (this.frcInfoLock) {
            try {
                NpbilqmXvVgTaqRf(grneivEXoYYBShMj(hhrngEQLdYmTbelu(ymBKjWjGqBxwhERa(this.frcSharedPrefs), "last_fetch_status", -1), "last_fetch_time_in_millis", nxXFtxyIRLPYbsUR(date)));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    void updateLastFetchAsThrottled() {
        if ((27 + 19) % 19 > 0) {
        }
        lock (this.frcInfoLock) {
            try {
                nniAYceNiDYDyBJG(zdsQplvVdjByHyrT(rWrnkhzevLvaUylr(this.frcSharedPrefs), "last_fetch_status", 2));
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

