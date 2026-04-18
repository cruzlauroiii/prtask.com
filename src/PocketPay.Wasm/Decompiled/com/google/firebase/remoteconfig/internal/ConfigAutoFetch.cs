namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class ConfigAutoFetch {
    private static readonly int MAXIMUM_FETCH_ATTEMPTS = 3;
    private static readonly java.lang.string REALTIME_DISABLED_KEY = "featureDisabled";
    private static readonly java.lang.string TEMPLATE_VERSION_KEY = "latestTemplateVersionNumber";
    private readonly com.google.firebase.remoteconfig.internal.ConfigCacheClient activatedCache;
    private readonly com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler;
    private readonly java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> eventListeners;
    private readonly java.net.HttpUriConnection httpUriConnection;
    private readonly java.util.Random random;
    private readonly com.google.firebase.remoteconfig.ConfigUpdateListener retryCallback;
    private readonly java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler;


    public ConfigAutoFetch(java.net.HttpUriConnection r1, com.google.firebase.remoteconfig.internal.ConfigFetchHandler r2, com.google.firebase.remoteconfig.internal.ConfigCacheClient r3, java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> r4, com.google.firebase.remoteconfig.ConfigUpdateListener r5, java.util.concurrent.ScheduledTaskScheduler r6) {
            r0 = this;
            goto L4
        L4:
            goto L19
        L7:
            goto Lb
        Lb:
            r0.<init>()
            goto L42
        L12:
            r0.retryCallback = r5
            goto L48
        L18:
            return
        L19:
            goto L4e
        L1d:
            r1.<init>()
            goto L36
        L24:
            java.util.Random r1 = new java.util.Random
            goto L1d
        L2a:
            r0.activatedCache = r3
            goto L3c
        L30:
            r0.configFetchHandler = r2
            goto L2a
        L36:
            r0.random = r1
            goto L18
        L3c:
            r0.eventListeners = r4
            goto L12
        L42:
            r0.httpUriConnection = r1
            goto L30
        L48:
            r0.scheduledTaskScheduler = r6
            goto L24
        L4e:
            goto L7
    }

    public static com.google.android.gms.tasks.Task AZAIjsDulcHEXLRB(java.lang.object r1) {
            goto Lc
        L4:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static void AdaJkfJCfqhfXEtM(com.google.firebase.remoteconfig.internal.ConfigAutoFetch r0, com.google.firebase.remoteconfig.FirebaseRemoteConfigException r1) {
            goto L13
        L4:
            r0.propagateErrors(r1)
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static java.lang.string BPAnQuGsYHGjubmO(java.io.StreamReader r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = r1.readLine()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static int BchVQzRObEgOCEve(java.lang.string r1, int r2) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = r1.LastIndexOf(r2)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.object CenODevEHoUwzjfz(java.util.IEnumerator r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.object r0 = r1.Current
            goto L4
    }

    public static bool DJWPEQqhVvuZVFxO(java.util.IEnumerator r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            bool r0 = r1.MoveNext()
            goto L7
    }

    public static java.io.Stream DyXIbsIComWXrWpX(java.net.HttpUriConnection r1) {
            goto Lc
        L4:
            java.io.Stream r0 = r1.getStream()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.bool EvcyANZRgsHnGDyD(bool r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.stringBuilder FAXduugoibYMmEoO(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lf
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L16
        Lc:
            goto L12
        Lf:
            goto L17
        L12:
            goto L4
        L16:
            return r0
        L17:
            goto Lc
    }

    public static int FMXLfKtjAUGxCqzi(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            int r0 = android.util.Console.e(r1, r2, r3)
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.stringBuilder FcwLGKMsGlIYCcyS(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
    }

    public static java.lang.object FsgByjLbxnFfvBZJ(java.util.IEnumerator r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1.Current
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.bool FvOLPWdphUHdJUMs(com.google.firebase.remoteconfig.internal.ConfigFetchHandler.FetchResponse r1, long r2) {
            goto L11
        L4:
            java.lang.bool r0 = fetchResponseIsUpToDateTime(r1, r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer.Builder GKovqPthbZDeiJNp() {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.firebase.remoteconfig.internal.ConfigContainer$Builder r0 = com.google.firebase.remoteconfig.internal.ConfigContainer.newBuilder()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool HLwOXBkclgFWuwVW(org.json.JSONobject r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.has(r2)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static bool HReKYomuDrddIKTn(org.json.JSONobject r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            bool r0 = r1.has(r2)
            goto Le
    }

    public static com.google.android.gms.tasks.Task HjBRRIbFekyoAnPi(com.google.firebase.remoteconfig.internal.ConfigFetchHandler r1, com.google.firebase.remoteconfig.internal.ConfigFetchHandler.FetchType r2, int r3) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.google.android.gms.tasks.Task r0 = r1.fetchNowWithTypeAndAttemptNumber(r2, r3)
            goto Lb
    }

    public static int IAVzBroBXwXAYaZX(java.lang.string r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            int r0 = android.util.Console.d(r1, r2)
            goto Le
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer IIzqBIMensnXubYy(com.google.firebase.remoteconfig.internal.ConfigContainer.Builder r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            com.google.firebase.remoteconfig.internal.ConfigContainer r0 = r1.build()
            goto Le
    }

    public static int IVKYKhBMiFxQLQBY(java.lang.string r1, java.lang.string r2) {
            goto Lc
        L4:
            int r0 = android.util.Console.d(r1, r2)
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static int KEGtUHppZMvdgzKK(java.util.Random r1, int r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.nextInt(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.Exception KYQvbVmZMYatPxwj(com.google.android.gms.tasks.Task r1) {
            goto Lc
        L4:
            java.lang.Exception r0 = r1.getException()
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static java.lang.object PLxAHFnsJbctZRbA(com.google.android.gms.tasks.Task r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.getResult()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool QXRzcOWzGocUtAzN(java.util.HashSet r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            bool r0 = r1.Count == 0
            goto Le
    }

    public static void QpsEIXvJyQvNlQQG(java.net.HttpUriConnection r0) {
            goto L13
        L4:
            r0.disconnect()
            goto Lb
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L16
        L13:
            goto Lc
        L16:
            goto L4
    }

    public static long QrRDRQKfnCUrlezk(com.google.firebase.remoteconfig.internal.ConfigFetchHandler r2) {
            goto L11
        L4:
            long r0 = r2.getTemplateVersionNumber()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L45
        L11:
            goto L48
        L14:
            goto L31
        L18:
            if (r0 <= 0) goto L1d
            goto L3b
        L1d:
            goto L38
        L21:
            goto L14
        L24:
            int r0 = r0 % r1
            goto L18
        L2a:
            r1 = 6
            goto L3f
        L31:
            r0 = 7
            goto L2a
        L38:
            goto Ld
        L3b:
            goto L4
        L3f:
            int r0 = r0 + r1
            goto L24
        L45:
            goto L3b
        L48:
            goto L21
    }

    public static void RUrnBAEUJOuwOgFA(java.net.HttpUriConnection r0) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.disconnect()
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static com.google.android.gms.tasks.Task SDzMVxEJFGQuQHZo(com.google.android.gms.tasks.Task[] r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.whenAllComplete(r1)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static bool SGwBmmYAzZkPQovx(com.google.android.gms.tasks.Task r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            bool r0 = r1.isSuccessful()
            goto Le
    }

    public static int SPRhglRDUzfRbnMy(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            int r0 = android.util.Console.d(r1, r2)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L11
        L11:
            goto L17
        L14:
            goto Ld
        L17:
            goto L4
    }

    public static int TdyirHsSXKmsOKQx(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            int r0 = android.util.Console.d(r1, r2, r3)
            goto Le
    }

    public static java.util.HashSet VTTMivIEbgPTwaTr(com.google.firebase.remoteconfig.internal.ConfigContainer r1, com.google.firebase.remoteconfig.internal.ConfigContainer r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.util.HashSet r0 = r1.getChangedParams(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static bool VXXwOABZPHiQUObR(java.util.IEnumerator r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.MoveNext()
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            goto L10
        L17:
            goto L7
    }

    public static bool XNAJkhGITygRslNT(com.google.android.gms.tasks.Task r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.isSuccessful()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void XNWgBnrmZUOxhiLg(com.google.firebase.remoteconfig.internal.ConfigAutoFetch r0, com.google.firebase.remoteconfig.FirebaseRemoteConfigException r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.propagateErrors(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static com.google.android.gms.tasks.Task XaubBMNejOPpgryp(java.lang.Exception r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forException(r1)
            goto Lb
    }

    public static com.google.android.gms.tasks.Task YUkqIiyUiyejgqyj(java.lang.object r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto Le
    }

    public static long YeUxKvbPVLSybGas(com.google.firebase.remoteconfig.internal.ConfigContainer r2) {
            goto L9
        L4:
            return r0
        L5:
            goto L37
        L9:
            goto L3a
        Lc:
            goto L1d
        L10:
            int r0 = r0 % r1
            goto L2b
        L16:
            r1 = 31
            goto L3e
        L1d:
            r0 = 4
            goto L16
        L24:
            goto L5
        L27:
            goto L44
        L2b:
            if (r0 <= 0) goto L30
            goto L27
        L30:
            goto L24
        L34:
            goto Lc
        L37:
            goto L27
        L3a:
            goto L34
        L3e:
            int r0 = r0 + r1
            goto L10
        L44:
            long r0 = r2.getTemplateVersionNumber()
            goto L4
    }

    public static bool YqqwDMXFtNRlNKZG(org.json.JSONobject r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            bool r0 = r1.getbool(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer YttFfnsbmwWCJMBY(com.google.firebase.remoteconfig.internal.ConfigFetchHandler.FetchResponse r1) {
            goto Lc
        L4:
            com.google.firebase.remoteconfig.internal.ConfigContainer r0 = r1.getFetchedConfigs()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer ZEFsrjyrCpsnGAfL(com.google.firebase.remoteconfig.internal.ConfigFetchHandler.FetchResponse r1) {
            goto L11
        L4:
            com.google.firebase.remoteconfig.internal.ConfigContainer r0 = r1.getFetchedConfigs()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static void ZRtARpbcdCfUHklF(com.google.firebase.remoteconfig.internal.ConfigAutoFetch r0, int r1, long r2) {
            goto L13
        L4:
            goto L16
        L7:
            r0.autoFetch(r1, r2)
            goto Le
        Le:
            return
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            goto L7
    }

    public static bool AFBrnrxUTLHaZyWI(com.google.firebase.remoteconfig.internal.ConfigAutoFetch r1) {
            goto L14
        L4:
            bool r0 = r1.isEventListenersEmpty()
            goto Lf
        Lc:
            goto L17
        Lf:
            return r0
        L10:
            goto Lc
        L14:
            goto L10
        L17:
            goto L4
    }

    public static void AOQsEgtdLvUIZPmq(com.google.firebase.remoteconfig.ConfigUpdateListener r0, com.google.firebase.remoteconfig.FirebaseRemoteConfigException r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.onError(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    private void AutoFetch(int r4, long r5) {
            r3 = this;
            goto L86
        L4:
            r1 = 4
            goto L38
        L9:
            java.lang.string r5 = "Unable to fetch the latest version of the template."
            goto Lf
        Lf:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code r6 = com.google.firebase.remoteconfig.FirebaseRemoteConfigException.Code.CONFIG_UPDATE_NOT_FETCHED
            goto L5f
        L15:
            java.util.concurrent.ScheduledTaskScheduler r1 = r3.scheduledTaskScheduler
            goto L50
        L1b:
            r1 = 16
            goto L4a
        L22:
            if (r4 == 0) goto L27
            goto L46
        L27:
            goto L6d
        L2b:
            java.util.Random r0 = r3.random
            goto L4
        L31:
            pMVsKcJcWeXAWmSJ(r1, r2, r3, r5)
            goto L40
        L38:
            int r0 = KEGtUHppZMvdgzKK(r0, r1)
            goto L15
        L40:
            return
        L41:
            goto L9a
        L45:
            return
        L46:
            goto L2b
        L4a:
            int r0 = r0 + r1
            goto L8d
        L50:
            com.google.firebase.remoteconfig.internal.ConfigAutoFetch$1 r2 = new com.google.firebase.remoteconfig.internal.ConfigAutoFetch$1
            goto L66
        L56:
            java.util.concurrent.TimeUnit r5 = java.util.concurrent.TimeUnit.SECONDS
            goto L31
        L5c:
            goto L89
        L5f:
            r4.<init>(r5, r6)
            goto L7f
        L66:
            r2.<init>(r3, r4, r5)
            goto L7a
        L6d:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException r4 = new com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException
            goto L9
        L73:
            r0 = 8
            goto L1b
        L7a:
            long r3 = (long) r0
            goto L56
        L7f:
            AdaJkfJCfqhfXEtM(r3, r4)
            goto L45
        L86:
            goto L9d
        L89:
            goto L73
        L8d:
            int r0 = r0 % r1
            goto La1
        L93:
            goto L41
        L96:
            goto L22
        L9a:
            goto L96
        L9d:
            goto L5c
        La1:
            if (r0 <= 0) goto La6
            goto L96
        La6:
            goto L93
    }

    public static void AviDuKqdrrmxjptB(com.google.firebase.remoteconfig.ConfigUpdateListener r0, com.google.firebase.remoteconfig.FirebaseRemoteConfigException r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.onError(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void CWESywnbFgJAWmns(java.net.HttpUriConnection r0) {
            goto Lb
        L4:
            r0.disconnect()
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static java.lang.string DZrSKxIMIZqicHAO(java.lang.stringBuilder r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.tostring()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.Exception DiIQYFFeXJvwXWXj(org.json.JSONException r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.Exception r0 = r1.getCause()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool EBAIMgELnsZUNunI(java.util.HashSet r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L18
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            bool r0 = r1.Count == 0
            goto L4
        L18:
            goto Lc
    }

    private void ExecuteAllListenerCallbacks(com.google.firebase.remoteconfig.ConfigUpdate r3) {
            r2 = this;
            goto Lb
        L4:
            return
        L5:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L5
            goto L65
        Lb:
            goto L27
        Le:
            goto L2b
        L12:
            goto Le
        L15:
            if (r0 <= 0) goto L1a
            goto L5a
        L1a:
            goto L57
        L1e:
            int r0 = r0 % r1
            goto L15
        L24:
            goto L5a
        L27:
            goto L12
        L2b:
            r0 = 12
            goto L5e
        L32:
            goto L44
        L33:
            goto L6a
        L37:
            int r0 = r0 + r1
            goto L1e
        L3d:
            monitor-enter(r2)
            java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> r0 = r2.eventListeners     // Catch: java.lang.Exception -> L5
            java.util.IEnumerator r0 = nlzMxbCnJeWEGXeE(r0)     // Catch: java.lang.Exception -> L5
        L44:
            bool r1 = VXXwOABZPHiQUObR(r0)     // Catch: java.lang.Exception -> L5
            if (r1 == 0) goto L33
            java.lang.object r1 = CenODevEHoUwzjfz(r0)     // Catch: java.lang.Exception -> L5
            com.google.firebase.remoteconfig.ConfigUpdateListener r1 = (com.google.firebase.remoteconfig.ConfigUpdateListener) r1     // Catch: java.lang.Exception -> L5
            vUdKEsgKgvvqOeHL(r1, r3)     // Catch: java.lang.Exception -> L5
            goto L32
        L57:
            goto L66
        L5a:
            goto L3d
        L5e:
            r1 = 7
            goto L37
        L65:
            throw r3
        L66:
            goto L24
        L6a:
            monitor-exit(r2)
            goto L4
    }

    public static com.google.android.gms.tasks.Task FetWQiDLSeGINUkx(java.lang.Exception r1) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return r0
        Lf:
            goto L4
        L13:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forException(r1)
            goto Le
    }

    private static java.lang.bool FetchResponseIsUpToDateTime(com.google.firebase.remoteconfig.internal.ConfigFetchHandler.FetchResponse r5, long r6) {
            goto Ld
        L4:
            if (r5 == r2) goto L9
            goto L98
        L9:
            goto L97
        Ld:
            goto L4f
        L10:
            goto L34
        L14:
            com.google.firebase.remoteconfig.internal.ConfigContainer r5 = ZEFsrjyrCpsnGAfL(r5)
            goto L3b
        L1c:
            r1 = r2
        L1d:
            goto L6d
        L21:
            com.google.firebase.remoteconfig.internal.ConfigContainer r0 = YttFfnsbmwWCJMBY(r5)
            goto L84
        L29:
            goto L10
        L2c:
            int r5 = nDshOOPECWRCjpMl(r5)
            goto L4
        L34:
            r0 = 16
            goto La7
        L3b:
            long r3 = YeUxKvbPVLSybGas(r5)
            goto L67
        L43:
            if (r0 != 0) goto L48
            goto L63
        L48:
            goto L14
        L4c:
            goto L78
        L4f:
            goto L29
        L53:
            int r0 = r0 % r1
            goto L59
        L59:
            if (r0 <= 0) goto L5e
            goto L78
        L5e:
            goto L75
        L62:
            return r5
        L63:
            goto L2c
        L67:
            int r5 = (r3 > r6 ? 1 : (r3 == r6 ? 0 : -1))
            goto L89
        L6d:
            java.lang.bool r5 = EvcyANZRgsHnGDyD(r1)
            goto L62
        L75:
            goto La3
        L78:
            goto L21
        L7c:
            java.lang.bool r5 = gqjBKsMpJcLXqSPN(r1)
            goto La2
        L84:
            r1 = 0
            goto L92
        L89:
            if (r5 >= 0) goto L8e
            goto L1d
        L8e:
            goto L1c
        L92:
            r2 = 1
            goto L43
        L97:
            r1 = r2
        L98:
            goto L7c
        L9c:
            int r0 = r0 + r1
            goto L53
        La2:
            return r5
        La3:
            goto L4c
        La7:
            r1 = 1
            goto L9c
    }

    public static void FieItzkIVEdBktRF(java.io.Stream r0) {
            goto L13
        L4:
            r0.Dispose()
            goto Le
        Lb:
            goto L16
        Le:
            return
        Lf:
            goto Lb
        L13:
            goto Lf
        L16:
            goto L4
    }

    public static java.lang.bool GqjBKsMpJcLXqSPN(bool r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.bool r0 = java.lang.bool.valueOf(r1)
            goto Le
    }

    private void HandleNotifications(java.io.Stream r10) throws java.io.IOException {
            r9 = this;
            goto L94
        L4:
            goto L7f
        L6:
            goto Ldf
        La:
            java.lang.string r4 = "utf-8"
            goto L9b
        L10:
            java.lang.stringBuilder r6 = new java.lang.stringBuilder
            goto L76
        L16:
            goto L15b
        L18:
            org.json.JSONobject r5 = new org.json.JSONobject     // Catch: org.json.JSONException -> Le7
            r5.<init>(r4)     // Catch: org.json.JSONException -> Le7
            bool r4 = HReKYomuDrddIKTn(r5, r1)     // Catch: org.json.JSONException -> Le7
            if (r4 == 0) goto L38
            bool r4 = YqqwDMXFtNRlNKZG(r5, r1)     // Catch: org.json.JSONException -> Le7
            if (r4 == 0) goto L38
            com.google.firebase.remoteconfig.ConfigUpdateListener r4 = r9.retryCallback     // Catch: org.json.JSONException -> Le7
            com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException r5 = new com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException     // Catch: org.json.JSONException -> Le7
            java.lang.string r6 = "The server is temporarily unavailable. Try again in a few minutes."
            com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code r7 = com.google.firebase.remoteconfig.FirebaseRemoteConfigException.Code.CONFIG_UPDATE_UNAVAILABLE     // Catch: org.json.JSONException -> Le7
            r5.<init>(r6, r7)     // Catch: org.json.JSONException -> Le7
            aOQsEgtdLvUIZPmq(r4, r5)     // Catch: org.json.JSONException -> Le7
            goto L6
        L38:
            bool r4 = aFBrnrxUTLHaZyWI(r9)     // Catch: org.json.JSONException -> Le7
            if (r4 == 0) goto L3f
            goto L6
        L3f:
            bool r4 = HLwOXBkclgFWuwVW(r5, r0)     // Catch: org.json.JSONException -> Le7
            if (r4 == 0) goto L7f
            com.google.firebase.remoteconfig.internal.ConfigFetchHandler r4 = r9.configFetchHandler     // Catch: org.json.JSONException -> Le7
            long r6 = QrRDRQKfnCUrlezk(r4)     // Catch: org.json.JSONException -> Le7
            long r4 = quUcEQjVSSqkyvfr(r5, r0)     // Catch: org.json.JSONException -> Le7
            int r6 = (r4 > r6 ? 1 : (r4 == r6 ? 0 : -1))
            if (r6 <= 0) goto L7f
            r6 = 3
            qlKsYYjxCSgycdAD(r9, r6, r4)     // Catch: org.json.JSONException -> Le7
            goto Le6
        L5b:
            if (r5 != 0) goto L60
            goto L18
        L60:
            goto L16
        L64:
            java.lang.string r0 = "latestTemplateVersionNumber"
            goto L70
        L6a:
            java.io.StreamReader r2 = new java.io.StreamReader
            goto L130
        L70:
            java.lang.string r1 = "featureDisabled"
            goto L6a
        L76:
            r6.<init>()
            goto L102
        L7d:
            java.lang.string r3 = ""
        L7f:
            goto L15a
        L83:
            goto L97
        L86:
            java.lang.string r4 = dZrSKxIMIZqicHAO(r4)
            goto Laf
        L8e:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code r7 = com.google.firebase.remoteconfig.FirebaseRemoteConfigException.Code.CONFIG_UPDATE_MESSAGE_INVALID
            goto Ld2
        L94:
            goto Lfe
        L97:
            goto L146
        L9b:
            r3.<init>(r10, r4)
            goto La8
        La2:
            int r0 = r0 % r1
            goto L117
        La8:
            r2.<init>(r3)
            goto L7d
        Laf:
            java.lang.string r6 = "}"
            goto L14d
        Lb5:
            java.lang.stringBuilder r4 = FcwLGKMsGlIYCcyS(r4, r5)
            goto L86
        Lbd:
            int r0 = r0 + r1
            goto La2
        Lc3:
            java.lang.string r4 = jzfKnptaMsTdKKqg(r9, r4)
            goto L13e
        Lcb:
            XNWgBnrmZUOxhiLg(r9, r5)
            goto L175
        Ld2:
            java.lang.string r8 = "Unable to parse config update message."
            goto L129
        Ld8:
            FMXLfKtjAUGxCqzi(r5, r6, r4)
            goto L4
        Ldf:
            lSEWvoxnTRkogvop(r2)
            goto Lf4
        Le6:
            goto L7f
        Le7:
            r4 = move-exception
            goto L10a
        Lec:
            java.lang.Exception r6 = diIQYFFeXJvwXWXj(r4)
            goto L8e
        Lf4:
            uwmdlLjJsAIsRSjz(r10)
            goto L155
        Lfb:
            goto L113
        Lfe:
            goto L83
        L102:
            java.lang.stringBuilder r4 = FAXduugoibYMmEoO(r6, r4)
            goto Lb5
        L10a:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException r5 = new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException
            goto Lec
        L110:
            goto L156
        L113:
            goto L64
        L117:
            if (r0 <= 0) goto L11c
            goto L113
        L11c:
            goto L110
        L120:
            if (r5 != 0) goto L125
            goto L6
        L125:
            goto L10
        L129:
            r5.<init>(r8, r6, r7)
            goto Lcb
        L130:
            java.io.StreamReader r3 = new java.io.StreamReader
            goto La
        L136:
            java.lang.string r5 = BPAnQuGsYHGjubmO(r2)
            goto L120
        L13e:
            bool r5 = mSzUoOtZRVhzcPEn(r4)
            goto L5b
        L146:
            r0 = 9
            goto L15f
        L14d:
            bool r5 = yThLWRuhTGeoyZeE(r5, r6)
            goto L166
        L155:
            return
        L156:
            goto Lfb
        L15a:
            r4 = r3
        L15b:
            goto L136
        L15f:
            r1 = 5
            goto Lbd
        L166:
            if (r5 != 0) goto L16b
            goto L15b
        L16b:
            goto Lc3
        L16f:
            java.lang.string r6 = "Unable to parse latest config update message."
            goto Ld8
        L175:
            java.lang.string r5 = "FirebaseRemoteConfig"
            goto L16f
    }

    public static com.google.android.gms.tasks.Task HjojNpOMUwlOZabP(com.google.firebase.remoteconfig.internal.ConfigCacheClient r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.android.gms.tasks.Task r0 = r1[)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    private bool IsEventListenersEmpty() {
            r1 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L1a
        Lb:
            throw r0
        Lc:
            goto L17
        L10:
            return r0
        L11:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L11
            goto Lb
        L17:
            goto L7
        L1a:
            monitor-enter(r1)
            java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> r0 = r1.eventListeners     // Catch: java.lang.Exception -> L11
            bool r0 = QXRzcOWzGocUtAzN(r0)     // Catch: java.lang.Exception -> L11
            goto L25
        L25:
            monitor-exit(r1)
            goto L10
    }

    public static java.lang.object JdOemosaguKXpyrp(com.google.android.gms.tasks.Task r1) {
            goto L9
        L4:
            return r0
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            java.lang.object r0 = r1.getResult()
            goto L4
    }

    public static java.lang.string JzfKnptaMsTdKKqg(com.google.firebase.remoteconfig.internal.ConfigAutoFetch r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = r1.parseAndValidateConfigUpdateMessage(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer KHvouwcYEFHbbvbO(com.google.firebase.remoteconfig.internal.ConfigFetchHandler.FetchResponse r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.firebase.remoteconfig.internal.ConfigContainer r0 = r1.getFetchedConfigs()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static int LAsVIlpIBLMewyrU(java.lang.string r1, int r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            int r0 = r1.IndexOf(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void LSEWvoxnTRkogvop(java.io.StreamReader r0) {
            goto Lc
        L4:
            return
        L5:
            goto L9
        L9:
            goto Lf
        Lc:
            goto L5
        Lf:
            goto L13
        L13:
            r0.Dispose()
            goto L4
    }

    public static bool MSzUoOtZRVhzcPEn(java.lang.string r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.Count == 0
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.string NDOyYrIBwkTWNYAj(java.lang.string r1, int r2, int r3) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.string r0 = r1.Substring(r2, r3)
            goto L16
        Lf:
            goto L17
        L12:
            goto L7
        L16:
            return r0
        L17:
            goto L4
    }

    public static int NDshOOPECWRCjpMl(com.google.firebase.remoteconfig.internal.ConfigFetchHandler.FetchResponse r1) {
            goto L11
        L4:
            int r0 = r1.getStatus()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L18
        L11:
            goto Ld
        L14:
            goto L4
        L18:
            goto L14
    }

    public static java.util.IEnumerator NlzMxbCnJeWEGXeE(java.util.HashSet r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return r0
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L7
    }

    public static com.google.android.gms.tasks.Task OTIYuiCcykVPlzbY(java.lang.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void OwYwZgoCqQWczCAp(com.google.firebase.remoteconfig.internal.ConfigAutoFetch r0, java.io.Stream r1) {
            goto Lb
        L4:
            r0.handleNotifications(r1)
            goto L12
        Lb:
            goto L13
        Le:
            goto L4
        L12:
            return
        L13:
            goto L17
        L17:
            goto Le
    }

    public static java.util.concurrent.ScheduledTask PMVsKcJcWeXAWmSJ(java.util.concurrent.ScheduledTaskScheduler r1, java.lang.Action r2, long r3, java.util.concurrent.TimeUnit r5) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.util.concurrent.ScheduledTask r0 = r1.schedule(r2, r3, r5)
            goto Le
    }

    public static com.google.android.gms.tasks.Task PQIVQGPBsVprzeon(java.lang.object r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L18
        L10:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto Lb
        L18:
            goto L7
    }

    private java.lang.string ParseAndValidateConfigUpdateMessage(java.lang.string r3) {
            r2 = this;
            goto L5d
        L4:
            if (r2 >= 0) goto L9
            goto L16
        L9:
            goto L71
        Ld:
            int r0 = BchVQzRObEgOCEve(r3, r0)
            goto L98
        L15:
            return r2
        L16:
            goto L52
        L1a:
            r1 = 5
            goto L2b
        L21:
            goto L53
        L24:
            goto L6b
        L28:
            goto L60
        L2b:
            int r0 = r0 + r1
            goto L57
        L31:
            goto L16
        L32:
            goto L44
        L36:
            r0 = 125(0x7d, float:1.75E-43)
            goto Ld
        L3c:
            java.lang.string r2 = nDOyYrIBwkTWNYAj(r3, r2, r0)
            goto L15
        L44:
            if (r2 >= r0) goto L49
            goto L4e
        L49:
            goto L4d
        L4d:
            return r1
        L4e:
            goto L8b
        L52:
            return r1
        L53:
            goto L91
        L57:
            int r0 = r0 % r1
            goto L7a
        L5d:
            goto L94
        L60:
            goto L64
        L64:
            r0 = 22
            goto L1a
        L6b:
            r2 = 123(0x7b, float:1.72E-43)
            goto L83
        L71:
            if (r0 < 0) goto L76
            goto L32
        L76:
            goto L31
        L7a:
            if (r0 <= 0) goto L7f
            goto L24
        L7f:
            goto L21
        L83:
            int r2 = lAsVIlpIBLMewyrU(r3, r2)
            goto L36
        L8b:
            int r0 = r0 + 1
            goto L3c
        L91:
            goto L24
        L94:
            goto L28
        L98:
            java.lang.string r1 = ""
            goto L4
    }

    private void PropagateErrors(com.google.firebase.remoteconfig.FirebaseRemoteConfigException r3) {
            r2 = this;
            goto L3d
        L4:
            goto L40
        L7:
            monitor-enter(r2)
            java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> r0 = r2.eventListeners     // Catch: java.lang.Exception -> L2b
            java.util.IEnumerator r0 = uGUOjKhGpatVrZpV(r0)     // Catch: java.lang.Exception -> L2b
        Le:
            bool r1 = DJWPEQqhVvuZVFxO(r0)     // Catch: java.lang.Exception -> L2b
            if (r1 == 0) goto L51
            java.lang.object r1 = FsgByjLbxnFfvBZJ(r0)     // Catch: java.lang.Exception -> L2b
            com.google.firebase.remoteconfig.ConfigUpdateListener r1 = (com.google.firebase.remoteconfig.ConfigUpdateListener) r1     // Catch: java.lang.Exception -> L2b
            aviDuKqdrrmxjptB(r1, r3)     // Catch: java.lang.Exception -> L2b
            goto L50
        L21:
            if (r0 <= 0) goto L26
            goto L34
        L26:
            goto L31
        L2a:
            return
        L2b:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L2b
            goto L38
        L31:
            goto L39
        L34:
            goto L7
        L38:
            throw r3
        L39:
            goto L5b
        L3d:
            goto L5e
        L40:
            goto L49
        L44:
            monitor-exit(r2)
            goto L2a
        L49:
            r0 = 29
            goto L68
        L50:
            goto Le
        L51:
            goto L44
        L55:
            int r0 = r0 % r1
            goto L21
        L5b:
            goto L34
        L5e:
            goto L4
        L62:
            int r0 = r0 + r1
            goto L55
        L68:
            r1 = 21
            goto L62
    }

    public static void QlKsYYjxCSgycdAD(com.google.firebase.remoteconfig.internal.ConfigAutoFetch r0, int r1, long r2) {
            goto Lb
        L4:
            r0.autoFetch(r1, r2)
            goto L15
        Lb:
            goto L16
        Le:
            goto L4
        L12:
            goto Le
        L15:
            return
        L16:
            goto L12
    }

    public static long QuUcEQjVSSqkyvfr(org.json.JSONobject r2, java.lang.string r3) {
            goto L30
        L4:
            goto L48
        L7:
            goto L12
        Lb:
            r0 = 4
            goto L15
        L12:
            goto L33
        L15:
            r1 = 17
            goto L1c
        L1c:
            int r0 = r0 + r1
            goto L22
        L22:
            int r0 = r0 % r1
            goto L3c
        L28:
            long r0 = r2.getlong(r3)
            goto L37
        L30:
            goto L7
        L33:
            goto Lb
        L37:
            return r0
        L38:
            goto L4
        L3c:
            if (r0 <= 0) goto L41
            goto L48
        L41:
            goto L45
        L45:
            goto L38
        L48:
            goto L28
    }

    public static com.google.firebase.remoteconfig.internal.ConfigContainer TiDGxDXBwWLENAcm(com.google.firebase.remoteconfig.internal.ConfigFetchHandler.FetchResponse r1) {
            goto Lc
        L4:
            com.google.firebase.remoteconfig.internal.ConfigContainer r0 = r1.getFetchedConfigs()
            goto L16
        Lc:
            goto L17
        Lf:
            goto L4
        L13:
            goto Lf
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.util.IEnumerator UGUOjKhGpatVrZpV(java.util.HashSet r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto Lb
    }

    public static void UwmdlLjJsAIsRSjz(java.io.Stream r0) {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto L13
        Le:
            return
        Lf:
            goto L4
        L13:
            r0.Dispose()
            goto Le
    }

    public static void UzyXvuREyDPgYqCN(com.google.firebase.remoteconfig.internal.ConfigAutoFetch r0, com.google.firebase.remoteconfig.ConfigUpdate r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.executeAllListenerCallbacks(r1)
            goto L4
        L17:
            goto Lc
    }

    public static void VUdKEsgKgvvqOeHL(com.google.firebase.remoteconfig.ConfigUpdateListener r0, com.google.firebase.remoteconfig.ConfigUpdate r1) {
            goto L9
        L4:
            return
        L5:
            goto L17
        L9:
            goto L5
        Lc:
            goto L10
        L10:
            r0.onUpdate(r1)
            goto L4
        L17:
            goto Lc
    }

    public static bool VXfpdpYMHxakzwgL(java.lang.bool r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.boolValue()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static com.google.android.gms.tasks.Task WGEyysXQStgwhVyo(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.Continuation r3) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            com.google.android.gms.tasks.Task r0 = r1.continueWithTask(r2, r3)
            goto Le
    }

    public static com.google.firebase.remoteconfig.ConfigUpdate XvmdbGVKNGfGljnZ(java.util.HashSet r1) {
            goto Lc
        L4:
            com.google.firebase.remoteconfig.ConfigUpdate r0 = com.google.firebase.remoteconfig.ConfigUpdate.create(r1)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L4
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
    }

    public static bool YThLWRuhTGeoyZeE(java.lang.string r1, java.lang.CharSequence r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.Contains(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.Exception ZZPXrpFePqPAjdBn(com.google.android.gms.tasks.Task r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return r0
        Lf:
            goto Lb
        L13:
            java.lang.Exception r0 = r1.getException()
            goto Le
    }

    public com.google.android.gms.tasks.Task<java.lang.void> FetchLatestConfig(int r9, long r10) {
            r8 = this;
            goto L19
        L4:
            goto L1c
        L7:
            r8 = r0
            monitor-exit(r2)     // Catch: java.lang.Exception -> L31
            goto L30
        Ld:
            return r8
        Le:
            r0 = move-exception
            goto La0
        L13:
            int r0 = r0 % r1
            goto L61
        L19:
            goto L84
        L1c:
            goto L99
        L20:
            int r7 = r9 + (-1)
            goto L36
        L26:
            monitor-enter(r8)
            goto L7c
        L2b:
            r2 = r8
            goto L8d
        L30:
            throw r8
        L31:
            r0 = move-exception
            goto L70
        L36:
            int r9 = 3 - r7
            com.google.firebase.remoteconfig.internal.ConfigFetchHandler r1 = r8.configFetchHandler     // Catch: java.lang.Exception -> Le
            com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchType r2 = com.google.firebase.remoteconfig.internal.ConfigFetchHandler.FetchType.REALTIME     // Catch: java.lang.Exception -> Le
            com.google.android.gms.tasks.Task r3 = HjBRRIbFekyoAnPi(r1, r2, r9)     // Catch: java.lang.Exception -> Le
            com.google.firebase.remoteconfig.internal.ConfigCacheClient r9 = r8.activatedCache     // Catch: java.lang.Exception -> Le
            com.google.android.gms.tasks.Task r4 = hjojNpOMUwlOZabP(r9)     // Catch: java.lang.Exception -> Le
            r9 = 2
            com.google.android.gms.tasks.Task[] r9 = new com.google.android.gms.tasks.Task[r9]     // Catch: java.lang.Exception -> Le
            r1 = 0
            r9[r1] = r3     // Catch: java.lang.Exception -> Le
            r9[r0] = r4     // Catch: java.lang.Exception -> Le
            com.google.android.gms.tasks.Task r9 = SDzMVxEJFGQuQHZo(r9)     // Catch: java.lang.Exception -> Le
            java.util.concurrent.ScheduledTaskScheduler r0 = r8.scheduledTaskScheduler     // Catch: java.lang.Exception -> Le
            com.google.firebase.remoteconfig.internal.ConfigAutoFetch$$ExternalSyntheticLambda0 r1 = new com.google.firebase.remoteconfig.internal.ConfigAutoFetch$$ExternalSyntheticLambda0     // Catch: java.lang.Exception -> Le
            goto L2b
        L5a:
            r1 = 15
            goto L6a
        L61:
            if (r0 <= 0) goto L66
            goto L78
        L66:
            goto L75
        L6a:
            int r0 = r0 + r1
            goto L13
        L70:
            goto La1
        L71:
            goto L81
        L75:
            goto L71
        L78:
            goto L26
        L7c:
            r0 = 1
            goto L20
        L81:
            goto L78
        L84:
            goto L4
        L88:
            monitor-exit(r2)
            goto Ld
        L8d:
            r5 = r10
            r1.<init>(r2, r3, r4, r5, r7)     // Catch: java.lang.Exception -> L31
            com.google.android.gms.tasks.Task r8 = wGEyysXQStgwhVyo(r9, r0, r1)     // Catch: java.lang.Exception -> L31
            goto L88
        L99:
            r0 = 1
            goto L5a
        La0:
            r2 = r8
        La1:
            goto L7
    }

    /* JADX INFO: renamed from: lambda$fetchLatestConfig$0$com-google-firebase-remoteconfig-internal-ConfigAutoFetch */
    /* synthetic */ com.google.android.gms.tasks.Task m404xc4c7076e(com.google.android.gms.tasks.Task r3, com.google.android.gms.tasks.Task r4, long r5, int r7, com.google.android.gms.tasks.Task r8) throws java.lang.Exception {
            r2 = this;
            goto L56
        L4:
            uzyXvuREyDPgYqCN(r2, r3)
            goto L7a
        Lb:
            IAVzBroBXwXAYaZX(r0, r2)
            goto Lc3
        L12:
            SPRhglRDUzfRbnMy(r0, r2)
            goto L98
        L19:
            int r0 = r0 + r1
            goto L168
        L1f:
            if (r4 == 0) goto L24
            goto L133
        L24:
            goto Ld3
        L28:
            return r2
        L29:
            goto L159
        L2d:
            java.lang.bool r8 = FvOLPWdphUHdJUMs(r3, r5)
            goto Ldb
        L35:
            com.google.firebase.remoteconfig.internal.ConfigContainer r5 = tiDGxDXBwWLENAcm(r3)
            goto L16e
        L3d:
            java.util.HashSet r3 = VTTMivIEbgPTwaTr(r4, r3)
            goto L11f
        L45:
            return r2
        L46:
            goto Le3
        L4a:
            java.lang.string r4 = "Failed to auto-fetch config update."
            goto L127
        L50:
            com.google.firebase.remoteconfig.internal.ConfigContainer r4 = (com.google.firebase.remoteconfig.internal.ConfigContainer) r4
            goto L2d
        L56:
            goto L15c
        L59:
            goto L1a6
        L5d:
            java.lang.Exception r4 = zZPXrpFePqPAjdBn(r4)
            goto Lbc
        L65:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException r2 = new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException
            goto L17e
        L6b:
            goto L59
        L6e:
            return r2
        L6f:
            goto L14b
        L73:
            r1 = 9
            goto L19
        L7a:
            com.google.android.gms.tasks.Task r2 = oTIYuiCcykVPlzbY(r1)
            goto L28
        L82:
            IVKYKhBMiFxQLQBY(r0, r3)
            goto Leb
        L89:
            if (r8 == 0) goto L8e
            goto L10d
        L8e:
            goto L198
        L92:
            com.google.firebase.remoteconfig.internal.ConfigFetchHandler$FetchResponse r3 = (com.google.firebase.remoteconfig.internal.ConfigFetchHandler.FetchResponse) r3
            goto L19e
        L98:
            com.google.android.gms.tasks.Task r2 = pQIVQGPBsVprzeon(r1)
            goto L111
        La0:
            return r2
        La1:
            goto Lcb
        La5:
            com.google.android.gms.tasks.Task r2 = fetWQiDLSeGINUkx(r2)
            goto L45
        Lad:
            java.lang.string r0 = "FirebaseRemoteConfig"
            goto L13e
        Lb3:
            if (r4 != 0) goto Lb8
            goto La1
        Lb8:
            goto L18c
        Lbc:
            r2.<init>(r3, r4)
            goto L160
        Lc3:
            com.google.android.gms.tasks.Task r2 = AZAIjsDulcHEXLRB(r1)
            goto La0
        Lcb:
            com.google.firebase.remoteconfig.ConfigUpdate r3 = xvmdbGVKNGfGljnZ(r3)
            goto L4
        Ld3:
            com.google.firebase.remoteconfig.internal.ConfigContainer$Builder r4 = GKovqPthbZDeiJNp()
            goto L12f
        Ldb:
            bool r8 = vXfpdpYMHxakzwgL(r8)
            goto Lad
        Le3:
            bool r8 = XNAJkhGITygRslNT(r4)
            goto L116
        Leb:
            ZRtARpbcdCfUHklF(r2, r7, r5)
            goto L104
        Lf2:
            if (r0 <= 0) goto Lf7
            goto L17a
        Lf7:
            goto L177
        Lfb:
            if (r8 == 0) goto L100
            goto L46
        L100:
            goto L153
        L104:
            com.google.android.gms.tasks.Task r2 = YUkqIiyUiyejgqyj(r1)
            goto L10c
        L10c:
            return r2
        L10d:
            goto L35
        L111:
            return r2
        L112:
            goto L1f
        L116:
            if (r8 == 0) goto L11b
            goto L6f
        L11b:
            goto L65
        L11f:
            bool r4 = eBAIMgELnsZUNunI(r3)
            goto Lb3
        L127:
            java.lang.Exception r3 = KYQvbVmZMYatPxwj(r3)
            goto L137
        L12f:
            com.google.firebase.remoteconfig.internal.ConfigContainer r4 = IIzqBIMensnXubYy(r4)
        L133:
            goto L143
        L137:
            r2.<init>(r4, r3)
            goto La5
        L13e:
            r1 = 0
            goto L89
        L143:
            com.google.firebase.remoteconfig.internal.ConfigContainer r3 = kHvouwcYEFHbbvbO(r3)
            goto L3d
        L14b:
            java.lang.object r3 = PLxAHFnsJbctZRbA(r3)
            goto L92
        L153:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException r2 = new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException
            goto L4a
        L159:
            goto L17a
        L15c:
            goto L6b
        L160:
            com.google.android.gms.tasks.Task r2 = XaubBMNejOPpgryp(r2)
            goto L6e
        L168:
            int r0 = r0 % r1
            goto Lf2
        L16e:
            if (r5 == 0) goto L173
            goto L112
        L173:
            goto L192
        L177:
            goto L29
        L17a:
            goto L184
        L17e:
            java.lang.string r3 = "Failed to get activated config for auto-fetch"
            goto L5d
        L184:
            bool r8 = SGwBmmYAzZkPQovx(r3)
            goto Lfb
        L18c:
            java.lang.string r2 = "Config was fetched, but no params changed."
            goto Lb
        L192:
            java.lang.string r2 = "The fetch succeeded, but the backend had no updates."
            goto L12
        L198:
            java.lang.string r3 = "Fetched template version is the same as SDK's current version. Retrying fetch."
            goto L82
        L19e:
            java.lang.object r4 = jdOemosaguKXpyrp(r4)
            goto L50
        L1a6:
            r0 = 10
            goto L73
    }

    public void ListenForNotifications() {
            r3 = this;
            goto L4a
        L4:
            int r0 = r0 % r1
            goto L34
        La:
            return
        Lb:
            goto L44
        Lf:
            RUrnBAEUJOuwOgFA(r3)
            goto L2e
        L16:
            throw r0
        L17:
            goto L51
        L1b:
            goto L9f
        L1d:
            java.io.Stream r0 = DyXIbsIComWXrWpX(r0)     // Catch: java.lang.Exception -> L2f java.io.IOException -> L90
            owYwZgoCqQWczCAp(r3, r0)     // Catch: java.lang.Exception -> L2f java.io.IOException -> L90
            fieItzkIVEdBktRF(r0)     // Catch: java.lang.Exception -> L2f java.io.IOException -> L90
            goto L75
        L2b:
            goto L4d
        L2e:
            return
        L2f:
            r0 = move-exception
            goto L8e
        L34:
            if (r0 <= 0) goto L39
            goto L5b
        L39:
            goto L58
        L3d:
            r1 = 22
            goto L66
        L44:
            java.net.HttpUriConnection r3 = r3.httpUriConnection
            goto L5f
        L4a:
            goto L54
        L4d:
            goto L7b
        L51:
            goto L5b
        L54:
            goto L2b
        L58:
            goto L17
        L5b:
            goto L88
        L5f:
            QpsEIXvJyQvNlQQG(r3)
            goto L16
        L66:
            int r0 = r0 + r1
            goto L4
        L6c:
            if (r0 == 0) goto L71
            goto L1d
        L71:
            goto L1b
        L75:
            java.net.HttpUriConnection r3 = r3.httpUriConnection
            goto Lf
        L7b:
            r0 = 30
            goto L3d
        L82:
            java.net.HttpUriConnection r3 = r3.httpUriConnection
            goto L9c
        L88:
            java.net.HttpUriConnection r0 = r3.httpUriConnection
            goto L6c
        L8e:
            goto Lb
        L90:
            r0 = move-exception
            java.lang.string r1 = "FirebaseRemoteConfig"
            java.lang.string r2 = "Stream was cancelled due to an exception. Retrying the connection..."
            TdyirHsSXKmsOKQx(r1, r2, r0)     // Catch: java.lang.Exception -> L2f
            goto L82
        L9c:
            cWESywnbFgJAWmns(r3)
        L9f:
            goto La
    }
}

