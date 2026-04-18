namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class ConfigRealtimeHttpClient {
    private static readonly java.lang.string API_KEY_HEADER = "X-Goog-Api-Key";
    static readonly int[] BACKOFF_TIME_DURATIONS_IN_MINUTES = null;
    private static readonly java.util.regex.Regex GMP_APP_ID_PATTERN = null;
    private static readonly java.lang.string INSTALLATIONS_AUTH_TOKEN_HEADER = "X-Goog-Firebase-Installations-Auth";
    private static readonly java.lang.string X_ACCEPT_RESPONSE_STREAMING = "X-Accept-Response-Streaming";
    private static readonly java.lang.string X_ANDROID_CERT_HEADER = "X-Android-Cert";
    private static readonly java.lang.string X_ANDROID_PACKAGE_HEADER = "X-Android-Package";
    private static readonly java.lang.string X_GOOGLE_GFE_CAN_RETRY = "X-Google-GFE-Can-Retry";
    private readonly int ORIGINAL_RETRIES;
    com.google.firebase.remoteconfig.internal.ConfigCacheClient activatedCache;
    private readonly com.google.android.gms.common.util.Clock clock;
    private readonly com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler;
    private readonly android.content.object context;
    private readonly com.google.firebase.FirebaseApp firebaseApp;
    private readonly com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallations;
    private int httpRetriesRemaining;
    private bool isHttpConnectionRunning;
    private bool isInBackground;
    private bool isRealtimeDisabled;
    private readonly java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> listeners;
    private readonly java.lang.string namespace;
    private readonly java.util.Random random;
    private readonly java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler;
    private readonly com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient sharedPrefsClient;



    static {
            goto La
        L4:
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient.GMP_APP_ID_PATTERN = r0
            goto L31
        La:
            goto L46
        Ld:
            goto L4a
        L11:
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient.BACKOFF_TIME_DURATIONS_IN_MINUTES = r0
            goto L17
        L17:
            java.lang.string r0 = "^[^:]+:([0-9]+):(android|ios|web):([0-9a-f]+)"
            goto L1d
        L1d:
            java.util.regex.Regex r0 = UfPMfGIFHAWAAtAW(r0)
            goto L4
        L25:
            goto Ld
        L28:
            int[] r0 = new int[r0]
            r0 = {x0032: FILL_ARRAY_DATA , data: [2, 4, 8, 16, 32, 64, 128, 256} // fill-array
            goto L11
        L31:
            return
        L46:
            goto L25
        L4a:
            r0 = 8
            goto L28
    }

    public ConfigRealtimeHttpClient(com.google.firebase.FirebaseApp r2, com.google.firebase.installations.FirebaseInstallationsApi r3, com.google.firebase.remoteconfig.internal.ConfigFetchHandler r4, com.google.firebase.remoteconfig.internal.ConfigCacheClient r5, android.content.object r6, java.lang.string r7, java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> r8, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r9, java.util.concurrent.ScheduledTaskScheduler r10) {
            r1 = this;
            goto Laf
        L4:
            r1.isHttpConnectionRunning = r8
            goto L82
        La:
            r8 = 0
            goto L4
        Lf:
            r1.clock = r10
            goto Lb6
        L15:
            r1.ORIGINAL_RETRIES = r0
            goto L29
        L1b:
            int r10 = fpvLsQuDggEdhcpC(r0, r10)
            goto L2f
        L23:
            r1.firebaseInstallations = r3
            goto La4
        L29:
            r1.listeners = r8
            goto La
        L2f:
            r1.httpRetriesRemaining = r10
            goto L59
        L35:
            r1.context = r6
            goto L4d
        L3b:
            r1.sharedPrefsClient = r9
            goto L66
        L41:
            r1.random = r10
            goto L9c
        L47:
            r1.configFetchHandler = r4
            goto L23
        L4d:
            r1.namespace = r7
            goto L3b
        L53:
            r1.isInBackground = r8
            goto L61
        L59:
            com.google.android.gms.common.util.Clock r10 = vMUsBwlaGXYIRlmq()
            goto Lf
        L61:
            return
        L62:
            goto L78
        L66:
            r1.isRealtimeDisabled = r8
            goto L53
        L6c:
            r0 = 8
            goto L15
        L72:
            java.util.Random r10 = new java.util.Random
            goto L7b
        L78:
            goto Lb2
        L7b:
            r10.<init>()
            goto L41
        L82:
            r1.scheduledTaskScheduler = r10
            goto L72
        L88:
            int r0 = r0 - r10
            goto Laa
        L8d:
            r1.<init>()
            goto L6c
        L94:
            int r10 = lpyPfMdwaowDvMBO(r10)
            goto L88
        L9c:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata r10 = kmHuVUGMYtSnKwJV(r9)
            goto L94
        La4:
            r1.activatedCache = r5
            goto L35
        Laa:
            r10 = 1
            goto L1b
        Laf:
            goto L62
        Lb2:
            goto L8d
        Lb6:
            r1.firebaseApp = r2
            goto L47
    }

    public static bool AJQgCywEjLeqUVnq(com.google.android.gms.tasks.Task r1) {
            goto Lc
        L4:
            bool r0 = r1.isSuccessful()
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

    public static java.lang.object ATLqhycwyxCRWZTB(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static com.google.android.gms.tasks.Task BBcAtgEVqvVwSCpu(java.lang.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static long BFmjVxMTxidNfRvu(com.google.android.gms.common.util.Clock r2) {
            goto L24
        L4:
            r1 = 22
            goto L17
        Lb:
            return r0
        Lc:
            goto L10
        L10:
            goto L31
        L13:
            goto L2b
        L17:
            int r0 = r0 + r1
            goto L35
        L1d:
            r0 = 26
            goto L4
        L24:
            goto L13
        L27:
            goto L1d
        L2b:
            goto L27
        L2e:
            goto Lc
        L31:
            goto L44
        L35:
            int r0 = r0 % r1
            goto L3b
        L3b:
            if (r0 <= 0) goto L40
            goto L31
        L40:
            goto L2e
        L44:
            long r0 = r2.currentTimeMillis()
            goto Lb
    }

    public static com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.RealtimeBackoffMetadata BeqsftxzEQubefTQ(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata r0 = r1.getRealtimeBackoffMetadata()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string BgZsmNkQVaKUCuhv(com.google.firebase.FirebaseOptions r1) {
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
            java.lang.string r0 = r1.getApplicationId()
            goto Le
    }

    public static int BuueyznUQdgHGePR(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.RealtimeBackoffMetadata r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = r1.getNumFailedStreams()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void ByUOUcuzWxzEirvc(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, bool r1) {
            goto L13
        L4:
            r0.setIsHttpConnectionRunning(r1)
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

    public static long CCbTnPgUcvAXqhrg(long r2, long r4) {
            goto L27
        L4:
            r0 = 14
            goto L2e
        Lb:
            int r0 = r0 % r1
            goto L3a
        L11:
            long r0 = java.lang.Math.max(r2, r4)
            goto L35
        L19:
            goto L23
        L1c:
            goto L49
        L20:
            goto L36
        L23:
            goto L11
        L27:
            goto L1c
        L2a:
            goto L4
        L2e:
            r1 = 13
            goto L43
        L35:
            return r0
        L36:
            goto L19
        L3a:
            if (r0 <= 0) goto L3f
            goto L23
        L3f:
            goto L20
        L43:
            int r0 = r0 + r1
            goto Lb
        L49:
            goto L2a
    }

    public static bool DBnQDEIAWmTkyCBi(java.util.IEnumerator r1) {
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
            bool r0 = r1.MoveNext()
            goto Le
    }

    public static com.google.android.gms.tasks.Task DxFyQutonXjcBUvJ(com.google.firebase.installations.FirebaseInstallationsApi r1) {
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
            com.google.android.gms.tasks.Task r0 = r1.getId()
            goto L4
    }

    public static void EHDlMmpUlJChXXOE(java.io.Stream r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.Dispose()
            goto Lb
        L17:
            goto L7
    }

    public static java.lang.string ELFbGyafvqVKYcVD(java.lang.string r1, java.lang.object[] r2) {
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
            java.lang.string r0 = java.lang.string.format(r1, r2)
            goto L4
    }

    public static int EOuGLXWNhkSBwdle(java.lang.int r1) {
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
            int r0 = r1.intValue()
            goto Le
    }

    public static java.lang.string EPnJEFGvSZOiLrJB(java.lang.string r1, java.lang.object[] r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = java.lang.string.format(r1, r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void EWFXltPSHsRKcdHR(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, com.google.firebase.remoteconfig.FirebaseRemoteConfigException r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.propagateErrors(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void FDTcTqBBkUYCImSP(java.io.Stream r0) {
            goto Le
        L4:
            r0.Dispose()
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static void FFJlxFsbrHXQeFwj(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, com.google.firebase.remoteconfig.FirebaseRemoteConfigException r1) {
            goto Le
        L4:
            r0.propagateErrors(r1)
            goto L15
        Lb:
            goto L11
        Le:
            goto L16
        L11:
            goto L4
        L15:
            return
        L16:
            goto Lb
    }

    public static bool FJHPeqchnTSLhqFK(com.google.android.gms.tasks.Task r1) {
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
            bool r0 = r1.isSuccessful()
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.Exception FQRIPsGpUghTGRaU(com.google.android.gms.tasks.Task r1) {
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

    public static java.lang.object FZmtEkGJSblYkmiY(java.util.IEnumerator r1) {
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
            java.lang.object r0 = r1.Current
            goto Lb
        L18:
            goto L7
    }

    public static void GGKGkdgHelpVrQYM(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r0, int r1, java.util.DateTime r2) {
            goto L13
        L4:
            r0.setRealtimeBackoffMetadata(r1, r2)
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

    public static long GlvASIPRqMdTezZY(java.util.DateTime r2) {
            goto L3f
        L4:
            return r0
        L5:
            goto L19
        L9:
            if (r0 <= 0) goto Le
            goto L2d
        Le:
            goto L2a
        L12:
            r1 = 4
            goto L46
        L19:
            goto L2d
        L1c:
            goto L27
        L20:
            r0 = 31
            goto L12
        L27:
            goto L42
        L2a:
            goto L5
        L2d:
            goto L37
        L31:
            int r0 = r0 % r1
            goto L9
        L37:
            long r0 = r2.getTime()
            goto L4
        L3f:
            goto L1c
        L42:
            goto L20
        L46:
            int r0 = r0 + r1
            goto L31
    }

    public static bool GmeGcBEBjVvOMcje(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1) {
            goto L14
        L4:
            bool r0 = r1.canMakeHttpStreamConnection()
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

    public static java.lang.object HMNKxqIobictVJch(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.object r0 = r1.Add(r2, r3)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static int HzeIfsVsqVEzhbyF(java.lang.int r1) {
            goto Lc
        L4:
            int r0 = r1.intValue()
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

    public static int INJpxCrikFwzMZSu(java.lang.int r1) {
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
            int r0 = r1.intValue()
            goto Le
    }

    public static void IceObjBLtvSbiyzZ(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0) {
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
            r0.retryHttpConnectionWhenBackoffEnds()
            goto Le
    }

    public static void IsdoiXnBIHDyGmBP(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, java.net.HttpUriConnection r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.closeRealtimeHttpStream(r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static com.google.android.gms.tasks.Task JIRFWovtKDBTXXaV(java.lang.Exception r1) {
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

    public static com.google.firebase.remoteconfig.internal.ConfigAutoFetch JfHmkjsKmMbvlOQy(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1, java.net.HttpUriConnection r2) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.firebase.remoteconfig.internal.ConfigAutoFetch r0 = r1.startAutoFetch(r2)
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

    public static java.io.Stream KEPZNbsgEIYXkiZh(java.net.HttpUriConnection r1) {
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
            java.io.Stream r0 = r1.getErrorStream()
            goto Lb
        L18:
            goto L7
    }

    public static void KWmexSwyFiEkkCNq(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, java.net.HttpUriConnection r1) {
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
            r0.closeRealtimeHttpStream(r1)
            goto Le
    }

    public static long LGMdSpdcblhQPRip(com.google.android.gms.common.util.Clock r2) {
            goto L2b
        L4:
            goto L27
        L7:
            goto L3b
        Lb:
            int r0 = r0 + r1
            goto L43
        L11:
            r1 = 22
            goto Lb
        L18:
            r0 = 12
            goto L11
        L1f:
            goto L7
        L22:
            goto L49
        L26:
            return r0
        L27:
            goto L1f
        L2b:
            goto L22
        L2e:
            goto L18
        L32:
            if (r0 <= 0) goto L37
            goto L7
        L37:
            goto L4
        L3b:
            long r0 = r2.currentTimeMillis()
            goto L26
        L43:
            int r0 = r0 % r1
            goto L32
        L49:
            goto L2e
    }

    public static java.io.Stream LKnoTRdTpAMntUvZ(java.net.HttpUriConnection r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.io.Stream r0 = r1.getStream()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void LNAOJKAIpQpSmUXn(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, com.google.firebase.remoteconfig.FirebaseRemoteConfigException r1) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.propagateErrors(r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static void LTNPOwlyAQzWyFCI(java.net.HttpUriConnection r0, java.lang.string r1, java.lang.string r2) {
            goto Le
        L4:
            goto L11
        L7:
            r0.setRequestProperty(r1, r2)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void LeFaBJjmlmQfqVqg(java.io.Stream r0, byte[] r1) {
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
            r0.write(r1)
            goto Le
    }

    public static void LtBSeVAeFBfuhiOd(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, java.util.DateTime r1) {
            goto Lb
        L4:
            r0.updateBackoffMetadataWithLastFailedStreamConnectionTime(r1)
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

    public static com.google.android.gms.tasks.Task LyYHKjNMghfIlKCM(com.google.firebase.installations.FirebaseInstallationsApi r1, bool r2) {
            goto L14
        L4:
            com.google.android.gms.tasks.Task r0 = r1.getToken(r2)
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

    public static int MAKiJUmwPrdmiMdv(java.lang.int r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.intValue()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.RealtimeBackoffMetadata MmQqqtnfiiBthKKr(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata r0 = r1.getRealtimeBackoffMetadata()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int MpCRCcCPZNJpfCWr(java.util.Random r1, int r2) {
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
            int r0 = r1.nextInt(r2)
            goto L7
    }

    public static void MuyyTzXRICqiPXfd(com.google.firebase.remoteconfig.ConfigUpdateListener r0, com.google.firebase.remoteconfig.FirebaseRemoteConfigException r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.onError(r1)
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

    public static java.lang.string NGuJrfgLAnSauWPR(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1, java.io.Stream r2) {
            goto L11
        L4:
            java.lang.string r0 = r1.parseForbiddenErrorResponseMessage(r2)
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

    public static int NWKzevDYvuXxOTPH(java.lang.int r1) {
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
            int r0 = r1.intValue()
            goto L7
    }

    public static java.lang.stringBuilder NlUqJQxhQktuXBsp(java.lang.stringBuilder r1, java.lang.string r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Le
    }

    public static java.lang.stringBuilder NqjzRmRxklcjYRfY(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string NtFaUPREJbXngnBC(java.lang.stringBuilder r1) {
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
            java.lang.string r0 = r1.tostring()
            goto L4
        L18:
            goto Lc
    }

    public static bool NtoJbiiViMMGpomY(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1, int r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            bool r0 = r1.isStatusCodeRetryable(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.android.gms.tasks.Task NuVxwpeFZocbnoei(com.google.android.gms.tasks.Task[] r1) {
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
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.whenAllComplete(r1)
            goto Lb
    }

    public static long ODGsrSRhejcyScrt(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r2, int r3) {
            goto L33
        L4:
            goto L1a
        L7:
            goto L14
        Lb:
            if (r0 <= 0) goto L10
            goto L1a
        L10:
            goto L17
        L14:
            goto L36
        L17:
            goto L42
        L1a:
            goto L2b
        L1e:
            int r0 = r0 % r1
            goto Lb
        L24:
            r1 = 15
            goto L46
        L2b:
            long r0 = r2.getRandomizedBackoffDurationInMillis(r3)
            goto L41
        L33:
            goto L7
        L36:
            goto L3a
        L3a:
            r0 = 12
            goto L24
        L41:
            return r0
        L42:
            goto L4
        L46:
            int r0 = r0 + r1
            goto L1e
    }

    public static java.lang.string ObXUIuFYRLOmheKv(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.tostring()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.io.Stream OgoAldMdZrYvYVju(java.net.HttpUriConnection r1) {
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
            java.io.Stream r0 = r1.getErrorStream()
            goto Lb
    }

    public static void OvYpYcjXFiQTEyBr(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, bool r1) {
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.setIsHttpConnectionRunning(r1)
            goto Le
    }

    public static java.lang.object PbligHzbItsrSLiS(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto L4
    }

    public static int PsYOBSNSzwsiPcZB(java.lang.int r1) {
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
            int r0 = r1.intValue()
            goto L7
    }

    public static java.lang.object QDeMjarWXpiIvjaj(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto L14
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static long QJcfgWaCFMafAqZs(com.google.android.gms.common.util.Clock r2) {
            goto L26
        L4:
            int r0 = r0 % r1
            goto L2d
        La:
            goto L48
        Ld:
            goto L1e
        L11:
            int r0 = r0 + r1
            goto L4
        L17:
            r0 = 8
            goto L36
        L1e:
            long r0 = r2.currentTimeMillis()
            goto L47
        L26:
            goto L40
        L29:
            goto L17
        L2d:
            if (r0 <= 0) goto L32
            goto Ld
        L32:
            goto La
        L36:
            r1 = 9
            goto L11
        L3d:
            goto Ld
        L40:
            goto L44
        L44:
            goto L29
        L47:
            return r0
        L48:
            goto L3d
    }

    public static void QspqzklnvSWTsdhB(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, java.util.DateTime r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.updateBackoffMetadataWithLastFailedStreamConnectionTime(r1)
            goto Lb
        L17:
            goto L7
    }

    public static int RGVJaIwxWaroLBIJ(java.lang.int r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            int r0 = r1.intValue()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static long RWdiTaEEwWMnxlXR(java.util.DateTime r2) {
            goto L24
        L4:
            long r0 = r2.getTime()
            goto L12
        Lc:
            int r0 = r0 % r1
            goto L43
        L12:
            return r0
        L13:
            goto L2b
        L17:
            int r0 = r0 + r1
            goto Lc
        L1d:
            goto L13
        L20:
            goto L4
        L24:
            goto L2e
        L27:
            goto L35
        L2b:
            goto L20
        L2e:
            goto L32
        L32:
            goto L27
        L35:
            r0 = 6
            goto L3c
        L3c:
            r1 = 15
            goto L17
        L43:
            if (r0 <= 0) goto L48
            goto L20
        L48:
            goto L1d
    }

    public static java.lang.string RZAZOyLUCMVZZAiU(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.string r0 = r1.getRealtimeUri(r2)
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

    public static java.lang.string SVBIrMNHsbptcaRS(android.content.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.getPackageName()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.object UNezvgbUFDsFfTYD(com.google.android.gms.tasks.Task r1) {
            goto Lc
        L4:
            java.lang.object r0 = r1.getResult()
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

    public static int UXyXOfloxsDcmqQo(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.e(r1, r2)
            goto L4
        L18:
            goto Lc
    }

    public static java.util.regex.Regex UfPMfGIFHAWAAtAW(java.lang.string r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.util.regex.Regex r0 = java.util.regex.Regex.compile(r1)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.util.DateTime UiavwYlNdpYfivkB(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.RealtimeBackoffMetadata r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.util.DateTime r0 = r1.getBackoffEndTime()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void VDLPtIsgNOIJmzXn(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, java.net.HttpUriConnection r1, java.lang.string r2, java.lang.string r3) {
            goto Le
        L4:
            goto L11
        L7:
            r0.setRequestParams(r1, r2, r3)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.RealtimeBackoffMetadata VcHZypDDlfKODBnL(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r1) {
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
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata r0 = r1.getRealtimeBackoffMetadata()
            goto L7
    }

    public static long VckTiwngCQhikgim(java.util.DateTime r2) {
            goto L4
        L4:
            goto L3b
        L7:
            goto L1e
        Lb:
            return r0
        Lc:
            goto L38
        L10:
            int r0 = r0 % r1
            goto L28
        L16:
            long r0 = r2.getTime()
            goto Lb
        L1e:
            r0 = 14
            goto L3f
        L25:
            goto L7
        L28:
            if (r0 <= 0) goto L2d
            goto L34
        L2d:
            goto L31
        L31:
            goto Lc
        L34:
            goto L16
        L38:
            goto L34
        L3b:
            goto L25
        L3f:
            r1 = 9
            goto L46
        L46:
            int r0 = r0 + r1
            goto L10
    }

    public static void VjTdHbewvkTzrbgH(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, com.google.firebase.remoteconfig.FirebaseRemoteConfigException r1) {
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
            r0.propagateErrors(r1)
            goto Le
    }

    public static java.util.regex.Match WIHsaUZltTfVfSjR(java.util.regex.Regex r1, java.lang.CharSequence r2) {
            goto L11
        L4:
            java.util.regex.Match r0 = r1.matcher(r2)
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

    public static void WJagkLDjYgITMRyy(java.net.HttpUriConnection r0, java.lang.string r1, java.lang.string r2) {
            goto Lb
        L4:
            r0.setRequestProperty(r1, r2)
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

    public static void WbUFvLexghlAXMlZ(java.io.Stream r0) {
            goto Lb
        L4:
            r0.flush()
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

    public static java.lang.object WdEobxVRvxJDvdID(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
            goto Lf
        L4:
            java.lang.object r0 = r1.Add(r2, r3)
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

    public static java.util.concurrent.ScheduledTask XCVpBHLeFctYwXHj(java.util.concurrent.ScheduledTaskScheduler r1, java.lang.Action r2, long r3, java.util.concurrent.TimeUnit r5) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.util.concurrent.ScheduledTask r0 = r1.schedule(r2, r3, r5)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void XIGgSGdOdZmATeUU(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, long r1) {
            goto Le
        L4:
            goto L11
        L7:
            r0.makeRealtimeHttpConnection(r1)
            goto L15
        Le:
            goto L16
        L11:
            goto L7
        L15:
            return
        L16:
            goto L4
    }

    public static void XZRWGVbDUwFjHyph(java.net.HttpUriConnection r0) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L10
        Lb:
            return
        Lc:
            goto L17
        L10:
            r0.disconnect()
            goto Lb
        L17:
            goto L7
    }

    public static void XxSCufAzllmGkuPa(java.net.HttpUriConnection r0, java.lang.string r1, java.lang.string r2) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.setRequestProperty(r1, r2)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static com.google.android.gms.tasks.Task YBirCsGCZattfLGh(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.Continuation r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.gms.tasks.Task r0 = r1.continueWithTask(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.firebase.FirebaseOptions YMMHyMpdjUmUvQLn(com.google.firebase.FirebaseApp r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.firebase.FirebaseOptions r0 = r1.getOptions()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool YsDCyEhCjeVoGSaJ(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1, int r2) {
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
            bool r0 = r1.isStatusCodeRetryable(r2)
            goto L4
        L18:
            goto Lc
    }

    public static int ZIOTQWvUsLYpqWhW(java.lang.int r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = r1.intValue()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.string ZOeVQAqnNxgtNKue(java.lang.string r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = extractProjectNumberFromAppId(r1)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static int ZuOChnngKZOeThvA(java.net.HttpUriConnection r1) {
            goto L14
        L4:
            int r0 = r1.getResponseCode()
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

    public static void AALfepQVvRTsTXaz(com.google.firebase.remoteconfig.internal.ConfigAutoFetch r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.listenForNotifications()
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static java.lang.string AFplXXOpKokGwEEL(java.lang.string r1, java.lang.object[] r2) {
            goto L11
        L4:
            java.lang.string r0 = java.lang.string.format(r1, r2)
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

    public static void AKDtiLpjNCnphUqt(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, java.util.DateTime r1) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.updateBackoffMetadataWithLastFailedStreamConnectionTime(r1)
            goto L7
    }

    public static java.io.Stream AaMfsbgExMCEDLFF(java.net.HttpUriConnection r1) {
            goto L14
        L4:
            java.io.Stream r0 = r1.getErrorStream()
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

    static /* synthetic */ void access$000(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            wxPQVRAFiCPCdGoe(r0)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    static /* synthetic */ void access$100(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, com.google.firebase.remoteconfig.FirebaseRemoteConfigException r1) {
            goto L9
        L4:
            return
        L5:
            goto L10
        L9:
            goto L5
        Lc:
            goto L13
        L10:
            goto Lc
        L13:
            VjTdHbewvkTzrbgH(r0, r1)
            goto L4
    }

    public static com.google.android.gms.tasks.Task AhDwLADLHrwPLMYG(java.lang.object r1) {
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
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto L7
    }

    public static long AkEgPSzMTaeXjdWM(com.google.android.gms.common.util.Clock r2) {
            goto L38
        L4:
            r1 = 9
            goto L25
        Lb:
            goto L3b
        Le:
            if (r0 <= 0) goto L13
            goto L21
        L13:
            goto L1e
        L17:
            r0 = 31
            goto L4
        L1e:
            goto L40
        L21:
            goto L44
        L25:
            int r0 = r0 + r1
            goto L2b
        L2b:
            int r0 = r0 % r1
            goto Le
        L31:
            goto L21
        L34:
            goto Lb
        L38:
            goto L34
        L3b:
            goto L17
        L3f:
            return r0
        L40:
            goto L31
        L44:
            long r0 = r2.currentTimeMillis()
            goto L3f
    }

    public static java.lang.object AuSkscuIBRghEvhH(com.google.android.gms.tasks.Task r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1.getResult()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static int AwLFmdjRovRnOFYk(java.lang.int r1) {
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
            int r0 = r1.intValue()
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.object AxDKgyDnEtpbFWRt(com.google.android.gms.tasks.Task r1) {
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
            java.lang.object r0 = r1.getResult()
            goto L7
    }

    public static java.lang.string BEweKdIolALRQzNt(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1, java.io.Stream r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.parseForbiddenErrorResponseMessage(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.string BfDQdJiAcLxnjeqE(java.lang.string r1) {
            goto Lc
        L4:
            java.lang.string r0 = extractProjectNumberFromAppId(r1)
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

    public static long BhmhkJWfePjNXrkp(java.util.concurrent.TimeUnit r2, long r3) {
            goto L23
        L4:
            int r0 = r0 + r1
            goto L18
        La:
            goto L30
        Ld:
            goto L2a
        L11:
            r0 = 5
            goto L34
        L18:
            int r0 = r0 % r1
            goto L3b
        L1e:
            return r0
        L1f:
            goto La
        L23:
            goto Ld
        L26:
            goto L11
        L2a:
            goto L26
        L2d:
            goto L1f
        L30:
            goto L44
        L34:
            r1 = 24
            goto L4
        L3b:
            if (r0 <= 0) goto L40
            goto L30
        L40:
            goto L2d
        L44:
            long r0 = r2.toMillis(r3)
            goto L1e
    }

    public static java.net.UriConnection CQVodDOTOTLJNUIH(java.net.Uri r1) {
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
            java.net.UriConnection r0 = r1.openConnection()
            goto Le
    }

    private bool CanMakeHttpStreamConnection() {
            r1 = this;
            goto L32
        L4:
            throw r0
        L5:
            goto L13
        L9:
            monitor-exit(r1)
            goto L39
        Le:
            r0 = 1
            goto L2d
        L13:
            goto L35
        L16:
            monitor-enter(r1)
            java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> r0 = r1.listeners     // Catch: java.lang.Exception -> L3a
            bool r0 = qwUjslIUIlTNRUZf(r0)     // Catch: java.lang.Exception -> L3a
            if (r0 != 0) goto L2e
            bool r0 = r1.isHttpConnectionRunning     // Catch: java.lang.Exception -> L3a
            if (r0 != 0) goto L2e
            bool r0 = r1.isRealtimeDisabled     // Catch: java.lang.Exception -> L3a
            if (r0 != 0) goto L2e
            bool r0 = r1.isInBackground     // Catch: java.lang.Exception -> L3a
            goto L40
        L2d:
            goto L4a
        L2e:
            goto L49
        L32:
            goto L5
        L35:
            goto L16
        L39:
            return r0
        L3a:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L3a
            goto L4
        L40:
            if (r0 == 0) goto L45
            goto L2e
        L45:
            goto Le
        L49:
            r0 = 0
        L4a:
            goto L9
    }

    public static void CkHgtYAmjZXZgQhZ(java.net.HttpUriConnection r0, java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.setRequestProperty(r1, r2)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    private org.json.JSONobject CreateRequestBody(java.lang.string r4) {
            r3 = this;
            goto L19
        L4:
            org.json.JSONobject r3 = new org.json.JSONobject
            goto Lb4
        La:
            java.lang.string r1 = gnKLAvBmanuVUIeV(r1)
            goto L55
        L12:
            WdEobxVRvxJDvdID(r0, r2, r1)
            goto L3c
        L19:
            goto L51
        L1c:
            goto L78
        L20:
            ATLqhycwyxCRWZTB(r0, r1, r3)
            goto L8c
        L27:
            if (r0 <= 0) goto L2c
            goto L95
        L2c:
            goto L92
        L30:
            int r0 = r0 + r1
            goto L36
        L36:
            int r0 = r0 % r1
            goto L27
        L3c:
            java.lang.string r1 = "namespace"
            goto Lf5
        L42:
            java.lang.string r3 = "appInstanceId"
            goto Lde
        L48:
            com.google.firebase.FirebaseApp r3 = r3.firebaseApp
            goto La7
        L4e:
            goto L95
        L51:
            goto Lbb
        L55:
            java.lang.string r2 = "lastKnownVersionNumber"
            goto Lc4
        L5b:
            com.google.firebase.remoteconfig.internal.ConfigFetchHandler r1 = r3.configFetchHandler
            goto L61
        L61:
            long r1 = rBjfyMHWcrcUlJxo(r1)
            goto La
        L69:
            com.google.firebase.FirebaseOptions r1 = oEqmqncFgprlCVPq(r1)
            goto Led
        L71:
            QDeMjarWXpiIvjaj(r0, r1, r2)
            goto L5b
        L78:
            r0 = 13
            goto L85
        L7f:
            com.google.firebase.FirebaseApp r1 = r3.firebaseApp
            goto L69
        L85:
            r1 = 20
            goto L30
        L8c:
            java.lang.string r3 = "sdkVersion"
            goto L99
        L92:
            goto Lb0
        L95:
            goto Ld2
        L99:
            java.lang.string r1 = "22.1.0"
            goto Lfb
        L9f:
            java.lang.string r1 = bfDQdJiAcLxnjeqE(r1)
            goto Ld8
        La7:
            com.google.firebase.FirebaseOptions r3 = heCfuKNNUmIFXmWJ(r3)
            goto Le5
        Laf:
            return r3
        Lb0:
            goto L4e
        Lb4:
            r3.<init>(r0)
            goto Laf
        Lbb:
            goto L1c
        Lbe:
            java.lang.string r1 = "appId"
            goto L20
        Lc4:
            HMNKxqIobictVJch(r0, r2, r1)
            goto L48
        Lcb:
            r0.<init>()
            goto L7f
        Ld2:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto Lcb
        Ld8:
            java.lang.string r2 = "project"
            goto L12
        Lde:
            PbligHzbItsrSLiS(r0, r3, r4)
            goto L4
        Le5:
            java.lang.string r3 = xjGtoNuipDrMdlpo(r3)
            goto Lbe
        Led:
            java.lang.string r1 = BgZsmNkQVaKUCuhv(r1)
            goto L9f
        Lf5:
            java.lang.string r2 = r3.namespace
            goto L71
        Lfb:
            zoqubckNztcHNCYh(r0, r3, r1)
            goto L42
    }

    public static java.io.Stream CuDzPmkxPktHmpda(java.net.HttpUriConnection r1) {
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
            java.io.Stream r0 = r1.getErrorStream()
            goto Le
    }

    public static byte[] CuWOhDSBIbhQlWBB(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            byte[] r0 = r1.getbytes(r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static int DNejJVPOxjphsTCn(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.RealtimeBackoffMetadata r1) {
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
            int r0 = r1.getNumFailedStreams()
            goto L7
    }

    public static int ELjczldzCXGGNcGO(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = r1.Length
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool EXyWatOrYjyQTIUF(java.util.DateTime r1, java.util.DateTime r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.before(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    private void EnableBackoff() {
            r1 = this;
            goto Le
        L4:
            monitor-exit(r1)
            goto L1d
        L9:
            throw r0
        La:
            goto L1a
        Le:
            goto La
        L11:
            goto L15
        L15:
            monitor-enter(r1)
            goto L24
        L1a:
            goto L11
        L1d:
            return
        L1e:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L1e
            goto L9
        L24:
            r0 = 1
            r1.isRealtimeDisabled = r0     // Catch: java.lang.Exception -> L1e
            goto L4
    }

    public static void EuwUallvLXQyWpaX(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, java.net.HttpUriConnection r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.closeRealtimeHttpStream(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    private static java.lang.string ExtractProjectNumberFromAppId(java.lang.string r1) {
            goto L3f
        L4:
            return r1
        L5:
            goto L46
        L9:
            if (r0 != 0) goto Le
            goto L13
        Le:
            goto L1f
        L12:
            return r1
        L13:
            goto L32
        L17:
            java.lang.string r1 = jDpNzkHpjgNHUkzz(r1, r0)
            goto L12
        L1f:
            r0 = 1
            goto L17
        L24:
            java.util.regex.Regex r0 = com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient.GMP_APP_ID_PATTERN
            goto L37
        L2a:
            bool r0 = mEHTcQwZeAQwhwqj(r1)
            goto L9
        L32:
            r1 = 0
            goto L4
        L37:
            java.util.regex.Match r1 = WIHsaUZltTfVfSjR(r0, r1)
            goto L2a
        L3f:
            goto L5
        L42:
            goto L24
        L46:
            goto L42
    }

    public static java.lang.Exception EyTkoJbyiXIJLZlT(com.google.android.gms.tasks.Task r1) {
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

    public static java.lang.string FBXiAxsIUVHOYRjz(com.google.firebase.FirebaseOptions r1) {
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
            java.lang.string r0 = r1.getApiKey()
            goto L4
    }

    public static bool FLSBMvyHNOUjQFIf(com.google.android.gms.tasks.Task r1) {
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

    public static com.google.android.gms.tasks.Task FalXEvcSSbxdGujH(java.lang.Exception r1) {
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
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forException(r1)
            goto L4
    }

    public static int FpvLsQuDggEdhcpC(int r1, int r2) {
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
            int r0 = java.lang.Math.max(r1, r2)
            goto Le
    }

    public static java.util.DateTime FzwImBnZejeRqYcP(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.RealtimeBackoffMetadata r1) {
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
            java.util.DateTime r0 = r1.getBackoffEndTime()
            goto Lb
    }

    public static java.lang.stringBuilder GLgmhZCoUUfZYgkt(java.lang.stringBuilder r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    private java.lang.string GetFingerprintHashForPackage() {
            r5 = this;
            goto L91
        L4:
            java.lang.string r1 = "Could not get fingerprint hash for package: "
            goto L49
        La:
            if (r0 <= 0) goto Lf
            goto La3
        Lf:
            goto La0
        L13:
            r1 = 21
            goto L7c
        L1a:
            return r2
        L1b:
            goto Lac
        L1f:
            goto L94
        L22:
            java.lang.stringBuilder r1 = new java.lang.stringBuilder
            goto L43
        L28:
            java.lang.string r0 = "FirebaseRemoteConfig"
            goto L4
        L2e:
            r0 = 23
            goto L13
        L35:
            java.lang.string r5 = ObXUIuFYRLOmheKv(r5)
            goto L8a
        L3d:
            android.content.object r5 = r5.context
            goto L82
        L43:
            java.lang.string r3 = "No such package: "
            goto Lb3
        L49:
            r2 = 0
            android.content.object r3 = r5.context     // Catch: android.content.pm.PackageManager.NameNotFoundException -> La8
            java.lang.string r4 = qfREnbgOXpikWZUK(r3)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> La8
            byte[] r3 = kTPJUMtfyHBPlFdT(r3, r4)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> La8
            if (r3 != 0) goto L6d
            java.lang.stringBuilder r3 = new java.lang.stringBuilder     // Catch: android.content.pm.PackageManager.NameNotFoundException -> La8
            r3.<init>(r1)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> La8
            android.content.object r1 = r5.context     // Catch: android.content.pm.PackageManager.NameNotFoundException -> La8
            java.lang.string r1 = ujDHHiKqzyciOYYf(r1)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> La8
            java.lang.stringBuilder r1 = NlUqJQxhQktuXBsp(r3, r1)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> La8
            java.lang.string r1 = ndTAioWDcYLBJhhd(r1)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> La8
            UXyXOfloxsDcmqQo(r0, r1)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> La8
            return r2
        L6d:
            r1 = 0
            java.lang.string r5 = jgXcfFLNzoFNgHDD(r3, r1)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> La8
            goto La7
        L76:
            int r0 = r0 % r1
            goto La
        L7c:
            int r0 = r0 + r1
            goto L76
        L82:
            java.lang.string r5 = SVBIrMNHsbptcaRS(r5)
            goto L98
        L8a:
            ooomVmOWLFGWHFSn(r0, r5)
            goto L1a
        L91:
            goto Laf
        L94:
            goto L2e
        L98:
            java.lang.stringBuilder r5 = gLgmhZCoUUfZYgkt(r1, r5)
            goto L35
        La0:
            goto L1b
        La3:
            goto L28
        La7:
            return r5
        La8:
            goto L22
        Lac:
            goto La3
        Laf:
            goto L1f
        Lb3:
            r1.<init>(r3)
            goto L3d
    }

    private long GetRandomizedBackoffDurationInMillis(int r5) {
            r4 = this;
            goto L44
        L4:
            long r2 = (long) r5
            goto L6f
        L9:
            if (r0 <= 0) goto Le
            goto L35
        Le:
            goto L32
        L12:
            return r2
        L13:
            goto L98
        L17:
            int[] r0 = com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient.BACKOFF_TIME_DURATIONS_IN_MINUTES
            goto L5f
        L1d:
            r0 = 4
            goto L83
        L24:
            int r0 = r0 % r1
            goto L9
        L2a:
            goto L47
        L2d:
            int r5 = (int) r0
            goto L8a
        L32:
            goto L13
        L35:
            goto L17
        L39:
            long r2 = r2 + r4
            goto L12
        L3e:
            long r2 = r0 / r2
            goto L64
        L44:
            goto L9b
        L47:
            goto L1d
        L4b:
            r5 = r1
        L4c:
            goto L92
        L50:
            if (r5 < r1) goto L55
            goto La6
        L55:
            goto La5
        L59:
            int r5 = r5 + (-1)
            goto L7d
        L5f:
            int r1 = r0.length
            goto L50
        L64:
            java.util.Random r4 = r4.random
            goto L2d
        L6a:
            long r4 = (long) r4
            goto L39
        L6f:
            long r0 = bhmhkJWfePjNXrkp(r1, r2)
            goto L9f
        L77:
            int r0 = r0 + r1
            goto L24
        L7d:
            r5 = r0[r5]
            goto L4
        L83:
            r1 = 28
            goto L77
        L8a:
            int r4 = MpCRCcCPZNJpfCWr(r4, r5)
            goto L6a
        L92:
            java.util.concurrent.TimeUnit r1 = java.util.concurrent.TimeUnit.MINUTES
            goto L59
        L98:
            goto L35
        L9b:
            goto L2a
        L9f:
            r2 = 2
            goto L3e
        La5:
            goto L4c
        La6:
            goto L4b
    }

    private java.lang.string GetRealtimeUri(java.lang.string r1) {
            r0 = this;
            goto L2f
        L4:
            com.google.firebase.FirebaseOptions r0 = YMMHyMpdjUmUvQLn(r0)
            goto Lc
        Lc:
            java.lang.string r0 = ljnTJSecKTDfQdbo(r0)
            goto L3c
        L14:
            return r0
        L15:
            goto L44
        L19:
            java.lang.string r0 = ELFbGyafvqVKYcVD(r1, r0)
            goto L14
        L21:
            java.lang.object[] r0 = new java.lang.object[]{r0, r1}
            goto L36
        L29:
            com.google.firebase.FirebaseApp r0 = r0.firebaseApp
            goto L4
        L2f:
            goto L15
        L32:
            goto L29
        L36:
            java.lang.string r1 = "https://firebaseremoteconfigrealtime.googleapis.com/v1/projects/%s/namespaces/%s:streamFetchInvalidations"
            goto L19
        L3c:
            java.lang.string r0 = ZOeVQAqnNxgtNKue(r0)
            goto L21
        L44:
            goto L32
    }

    private java.net.Uri GetUrl() {
            r2 = this;
            goto L4d
        L4:
            r1 = 20
            goto L2e
        Lb:
            if (r0 <= 0) goto L10
            goto L57
        L10:
            goto L54
        L14:
            goto L50
        L17:
            return r2
        L18:
            goto L46
        L1c:
            return r0
        L1d:
            goto L40
        L21:
            hTwmWGGbNgCAaUcp(r2, r0)
            goto L34
        L28:
            java.lang.string r0 = "Uri is malformed"
            goto L21
        L2e:
            int r0 = r0 + r1
            goto L66
        L34:
            r2 = 0
            goto L17
        L39:
            r0 = 32
            goto L4
        L40:
            java.lang.string r2 = "FirebaseRemoteConfig"
            goto L28
        L46:
            goto L57
        L49:
            goto L14
        L4d:
            goto L49
        L50:
            goto L39
        L54:
            goto L18
        L57:
            java.net.Uri r0 = new java.net.Uri     // Catch: java.net.MalformedUriException -> L1d
            java.lang.string r1 = r2.namespace     // Catch: java.net.MalformedUriException -> L1d
            java.lang.string r2 = RZAZOyLUCMVZZAiU(r2, r1)     // Catch: java.net.MalformedUriException -> L1d
            r0.<init>(r2)     // Catch: java.net.MalformedUriException -> L1d
            goto L1c
        L66:
            int r0 = r0 % r1
            goto Lb
    }

    public static java.lang.string GnKLAvBmanuVUIeV(long r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = java.lang.long.tostring(r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void GrzqrfvznDUYLbbu(java.net.HttpUriConnection r0, java.lang.string r1, java.lang.string r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.setRequestProperty(r1, r2)
            goto L7
    }

    public static com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.RealtimeBackoffMetadata GxpioNJlSZFDTJgz(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r1) {
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
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata r0 = r1.getRealtimeBackoffMetadata()
            goto Le
    }

    public static java.util.DateTime HNfxwwVbXPhZnFpm(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.RealtimeBackoffMetadata r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.util.DateTime r0 = r1.getBackoffEndTime()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static int HTwmWGGbNgCAaUcp(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = android.util.Console.e(r1, r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.firebase.FirebaseOptions HeCfuKNNUmIFXmWJ(com.google.firebase.FirebaseApp r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.firebase.FirebaseOptions r0 = r1.getOptions()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.android.gms.tasks.Task ITgsXyhezFJsrycI(com.google.android.gms.tasks.Task[] r1) {
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
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.whenAllComplete(r1)
            goto Le
    }

    private bool IsStatusCodeRetryable(int r1) {
            r0 = this;
            goto L1c
        L4:
            r0 = 504(0x1f8, float:7.06E-43)
            goto L45
        La:
            if (r1 != r0) goto Lf
            goto L54
        Lf:
            goto L6c
        L13:
            if (r1 != r0) goto L18
            goto L54
        L18:
            goto L4
        L1c:
            goto L4f
        L1f:
            goto L36
        L23:
            goto L54
        L24:
            goto L58
        L28:
            r0 = 1
            goto L4e
        L2d:
            goto L1f
        L30:
            r0 = 503(0x1f7, float:7.05E-43)
            goto L13
        L36:
            r0 = 408(0x198, float:5.72E-43)
            goto L5d
        L3c:
            if (r1 != r0) goto L41
            goto L54
        L41:
            goto L30
        L45:
            if (r1 == r0) goto L4a
            goto L24
        L4a:
            goto L23
        L4e:
            return r0
        L4f:
            goto L2d
        L53:
            return r0
        L54:
            goto L28
        L58:
            r0 = 0
            goto L53
        L5d:
            if (r1 != r0) goto L62
            goto L54
        L62:
            goto L66
        L66:
            r0 = 429(0x1ad, float:6.01E-43)
            goto La
        L6c:
            r0 = 502(0x1f6, float:7.03E-43)
            goto L3c
    }

    public static java.lang.string JDpNzkHpjgNHUkzz(java.util.regex.Match r1, int r2) {
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
            java.lang.string r0 = r1.group(r2)
            goto Lb
    }

    public static java.lang.string JgXcfFLNzoFNgHDD(byte[] r1, bool r2) {
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
            java.lang.string r0 = com.google.android.gms.common.util.Hex.bytesTostringUppercase(r1, r2)
            goto Lb
        L18:
            goto L7
    }

    public static void KGhYwPqcGpuUHBDv(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.resetRetryCount()
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static byte[] KTPJUMtfyHBPlFdT(android.content.object r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            byte[] r0 = com.google.android.gms.common.util.AndroidUtilsLight.getPackageCertificateHashbytes(r1, r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.RealtimeBackoffMetadata KmHuVUGMYtSnKwJV(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r1) {
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
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata r0 = r1.getRealtimeBackoffMetadata()
            goto Lb
        L18:
            goto L7
    }

    public static java.io.Stream LUVeRNgmZRGABRHF(java.net.HttpUriConnection r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.io.Stream r0 = r1.getErrorStream()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string LjnTJSecKTDfQdbo(com.google.firebase.FirebaseOptions r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.getApplicationId()
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

    public static int LpyPfMdwaowDvMBO(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.RealtimeBackoffMetadata r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = r1.getNumFailedStreams()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool MEHTcQwZeAQwhwqj(java.util.regex.Match r1) {
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
            bool r0 = r1.matches()
            goto L4
        L18:
            goto Lc
    }

    public static bool MTXVDYhPLNoajQgf(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1, int r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = r1.isStatusCodeRetryable(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    private void MakeRealtimeHttpConnection(long r4) {
            r3 = this;
            goto L29
        L4:
            if (r0 <= 0) goto L9
            goto L1e
        L9:
            goto L1b
        Ld:
            throw r4
        Le:
            goto L39
        L12:
            if (r0 == 0) goto L17
            goto L4e
        L17:
            goto L77
        L1b:
            goto Le
        L1e:
            goto L30
        L22:
            r1 = 32
            goto L83
        L29:
            goto L3c
        L2c:
            goto L46
        L30:
            monitor-enter(r3)
            bool r0 = pfYFKaJrxNMtwCou(r3)     // Catch: java.lang.Exception -> L7d
            goto L12
        L39:
            goto L1e
        L3c:
            goto L89
        L40:
            int r0 = r0 % r1
            goto L4
        L46:
            r0 = 26
            goto L22
        L4d:
            return
        L4e:
            int r0 = r3.httpRetriesRemaining     // Catch: java.lang.Exception -> L7d
            if (r0 <= 0) goto L63
            int r0 = r0 + (-1)
            r3.httpRetriesRemaining = r0     // Catch: java.lang.Exception -> L7d
            java.util.concurrent.ScheduledTaskScheduler r0 = r3.scheduledTaskScheduler     // Catch: java.lang.Exception -> L7d
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient$1 r1 = new com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient$1     // Catch: java.lang.Exception -> L7d
            r1.<init>(r3)     // Catch: java.lang.Exception -> L7d
            java.util.concurrent.TimeUnit r2 = java.util.concurrent.TimeUnit.MILLISECONDS     // Catch: java.lang.Exception -> L7d
            XCVpBHLeFctYwXHj(r0, r1, r4, r2)     // Catch: java.lang.Exception -> L7d
            goto L73
        L63:
            bool r4 = r3.isInBackground     // Catch: java.lang.Exception -> L7d
            if (r4 != 0) goto L73
            com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException r4 = new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException     // Catch: java.lang.Exception -> L7d
            java.lang.string r5 = "Unable to connect to the server. Check your connection and try again."
            com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code r0 = com.google.firebase.remoteconfig.FirebaseRemoteConfigException.Code.CONFIG_UPDATE_STREAM_ERROR     // Catch: java.lang.Exception -> L7d
            r4.<init>(r5, r0)     // Catch: java.lang.Exception -> L7d
            LNAOJKAIpQpSmUXn(r3, r4)     // Catch: java.lang.Exception -> L7d
        L73:
            goto L8c
        L77:
            monitor-exit(r3)
            goto L4d
        L7c:
            return
        L7d:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L7d
            goto Ld
        L83:
            int r0 = r0 + r1
            goto L40
        L89:
            goto L2c
        L8c:
            monitor-exit(r3)
            goto L7c
    }

    public static void NaVVpHnfBkPjXPlp(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0) {
            goto Lb
        L4:
            r0.retryHttpConnectionWhenBackoffEnds()
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

    public static java.lang.string NdTAioWDcYLBJhhd(java.lang.stringBuilder r1) {
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
            java.lang.string r0 = r1.tostring()
            goto L4
        L18:
            goto Lc
    }

    public static org.json.JSONobject NpCJLuVpYJJOwowz(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1, java.lang.string r2) {
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
            org.json.JSONobject r0 = r1.createRequestBody(r2)
            goto Le
    }

    public static com.google.firebase.FirebaseOptions OEqmqncFgprlCVPq(com.google.firebase.FirebaseApp r1) {
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
            com.google.firebase.FirebaseOptions r0 = r1.getOptions()
            goto Lb
    }

    public static int OKgTGzIgEDgUjptQ(java.lang.int r1) {
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
            int r0 = r1.intValue()
            goto Lb
        L18:
            goto L7
    }

    public static int OoomVmOWLFGWHFSn(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            int r0 = android.util.Console.i(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static long PXqZIrGjOyKrIZro(com.google.android.gms.common.util.Clock r2) {
            goto L1b
        L4:
            long r0 = r2.currentTimeMillis()
            goto Lc
        Lc:
            return r0
        Ld:
            goto L36
        L11:
            r0 = 11
            goto L22
        L18:
            goto L1e
        L1b:
            goto L39
        L1e:
            goto L11
        L22:
            r1 = 14
            goto L3d
        L29:
            goto Ld
        L2c:
            goto L4
        L30:
            int r0 = r0 % r1
            goto L43
        L36:
            goto L2c
        L39:
            goto L18
        L3d:
            int r0 = r0 + r1
            goto L30
        L43:
            if (r0 <= 0) goto L48
            goto L2c
        L48:
            goto L29
    }

    private java.lang.string ParseForbiddenErrorResponseMessage(java.io.Stream r3) {
            r2 = this;
            goto L5a
        L4:
            java.lang.stringBuilder r2 = new java.lang.stringBuilder
            goto L66
        La:
            if (r3 == 0) goto Lf
            goto L62
        Lf:
            goto L4a
        L13:
            r0 = 20
            goto L86
        L1a:
            java.lang.string r2 = NtFaUPREJbXngnBC(r2)
            goto L27
        L22:
            goto L73
        L23:
            goto L2c
        L27:
            return r2
        L28:
            goto L34
        L2c:
            int r3 = eLjczldzCXGGNcGO(r2)
            goto La
        L34:
            goto L56
        L37:
            goto L50
        L3b:
            if (r0 <= 0) goto L40
            goto L56
        L40:
            goto L53
        L44:
            int r0 = r0 + r1
            goto L80
        L4a:
            java.lang.string r2 = "Unable to connect to the server, access is forbidden. HTTP status code: 403"
            goto L61
        L50:
            goto L5d
        L53:
            goto L28
        L56:
            goto L4
        L5a:
            goto L37
        L5d:
            goto L13
        L61:
            return r2
        L62:
            goto L1a
        L66:
            r2.<init>()
            java.io.StreamReader r0 = new java.io.StreamReader     // Catch: java.io.IOException -> L23
            java.io.StreamReader r1 = new java.io.StreamReader     // Catch: java.io.IOException -> L23
            r1.<init>(r3)     // Catch: java.io.IOException -> L23
            r0.<init>(r1)     // Catch: java.io.IOException -> L23
        L73:
            java.lang.string r3 = sBDAhQIAhUgzIKqQ(r0)     // Catch: java.io.IOException -> L23
            if (r3 == 0) goto L62
            NqjzRmRxklcjYRfY(r2, r3)     // Catch: java.io.IOException -> L23
            goto L22
        L80:
            int r0 = r0 % r1
            goto L3b
        L86:
            r1 = 4
            goto L44
    }

    public static bool PfYFKaJrxNMtwCou(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1.canMakeHttpStreamConnection()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.io.Stream PlEcxfULWHdaMvBu(java.net.HttpUriConnection r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.io.Stream r0 = r1.getStream()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    private void PropagateErrors(com.google.firebase.remoteconfig.FirebaseRemoteConfigException r3) {
            r2 = this;
            goto L2f
        L4:
            goto L32
        L7:
            goto L42
        L8:
            goto L63
        Lc:
            int r0 = r0 % r1
            goto L18
        L12:
            int r0 = r0 + r1
            goto Lc
        L18:
            if (r0 <= 0) goto L1d
            goto L24
        L1d:
            goto L21
        L21:
            goto L37
        L24:
            goto L3b
        L28:
            goto L24
        L2b:
            goto L4
        L2f:
            goto L2b
        L32:
            goto L68
        L36:
            throw r3
        L37:
            goto L28
        L3b:
            monitor-enter(r2)
            java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> r0 = r2.listeners     // Catch: java.lang.Exception -> L56
            java.util.IEnumerator r0 = tyGDqlRdZDmZkFOZ(r0)     // Catch: java.lang.Exception -> L56
        L42:
            bool r1 = DBnQDEIAWmTkyCBi(r0)     // Catch: java.lang.Exception -> L56
            if (r1 == 0) goto L8
            java.lang.object r1 = FZmtEkGJSblYkmiY(r0)     // Catch: java.lang.Exception -> L56
            com.google.firebase.remoteconfig.ConfigUpdateListener r1 = (com.google.firebase.remoteconfig.ConfigUpdateListener) r1     // Catch: java.lang.Exception -> L56
            MuyyTzXRICqiPXfd(r1, r3)     // Catch: java.lang.Exception -> L56
            goto L7
        L55:
            return
        L56:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L56
            goto L36
        L5c:
            r1 = 5
            goto L12
        L63:
            monitor-exit(r2)
            goto L55
        L68:
            r0 = 8
            goto L5c
    }

    public static com.google.android.gms.tasks.Task PvnBsVRqtxxoVODE(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.gms.tasks.Task r0 = r1.createRealtimeConnection()
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

    public static java.lang.string PzcaWqQffunkgLyy(org.json.JSONobject r1) {
            goto L14
        L4:
            java.lang.string r0 = r1.tostring()
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

    public static com.google.android.gms.tasks.Task QIhzlGZzQhvahBhH(java.lang.Exception r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forException(r1)
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

    public static void QYKpRUyyeRARSehI(java.net.HttpUriConnection r0, java.lang.string r1, java.lang.string r2) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.setRequestProperty(r1, r2)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static java.lang.string QfREnbgOXpikWZUK(android.content.object r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getPackageName()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void QgYrDginHPXwqGro(java.io.Stream r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.Dispose()
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static java.lang.string QuhRxlwlgiDHomne(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1) {
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
            java.lang.string r0 = r1.getFingerprintHashForPackage()
            goto Lb
    }

    public static void QvjOLXeDOXqnmsuj(java.net.HttpUriConnection r0, java.lang.string r1, java.lang.string r2) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.setRequestProperty(r1, r2)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static bool QwUjslIUIlTNRUZf(java.util.HashSet r1) {
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
            bool r0 = r1.Count == 0
            goto Le
    }

    public static int QzpeFUjYXSmFbiPp(java.lang.int r1) {
            goto Lf
        L4:
            int r0 = r1.intValue()
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

    public static void RBGoCjRAurcgEPHY(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, java.net.HttpUriConnection r1, java.lang.string r2) {
            goto Lc
        L4:
            goto Lf
        L7:
            return
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L13
        L13:
            r0.setCommonRequestHeaders(r1, r2)
            goto L7
    }

    public static long RBjfyMHWcrcUlJxo(com.google.firebase.remoteconfig.internal.ConfigFetchHandler r2) {
            goto L20
        L4:
            goto L2f
        L7:
            goto L11
        Lb:
            int r0 = r0 + r1
            goto L36
        L11:
            long r0 = r2.getTemplateVersionNumber()
            goto L2e
        L19:
            r1 = 23
            goto Lb
        L20:
            goto L2a
        L23:
            goto L45
        L27:
            goto L7
        L2a:
            goto L33
        L2e:
            return r0
        L2f:
            goto L27
        L33:
            goto L23
        L36:
            int r0 = r0 % r1
            goto L3c
        L3c:
            if (r0 <= 0) goto L41
            goto L7
        L41:
            goto L4
        L45:
            r0 = 1
            goto L19
    }

    public static java.lang.Exception ReOuLfzKAKRhELfx(com.google.android.gms.tasks.Task r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.Exception r0 = r1.getException()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    private void ResetRetryCount() {
            r1 = this;
            goto L18
        L4:
            return
        L5:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto L1f
        Lb:
            monitor-enter(r1)
            goto L10
        L10:
            r0 = 8
            r1.httpRetriesRemaining = r0     // Catch: java.lang.Exception -> L5
            goto L27
        L18:
            goto L20
        L1b:
            goto Lb
        L1f:
            throw r0
        L20:
            goto L24
        L24:
            goto L1b
        L27:
            monitor-exit(r1)
            goto L4
    }

    public static java.lang.string RiddOWVeXWLxIklx(java.lang.string r1, java.lang.object[] r2) {
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
            java.lang.string r0 = java.lang.string.format(r1, r2)
            goto Le
    }

    public static com.google.android.gms.tasks.Task RpoOxohgsGOwjUbh(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.Continuation r3) {
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
            com.google.android.gms.tasks.Task r0 = r1.continueWith(r2, r3)
            goto Lb
    }

    public static java.lang.string SBDAhQIAhUgzIKqQ(java.io.StreamReader r1) {
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
            java.lang.string r0 = r1.readLine()
            goto Le
    }

    public static int SQfUhkQOVwCfyrfL(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = android.util.Console.d(r1, r2, r3)
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

    private void SetCommonRequestHeaders(java.net.HttpUriConnection r2, java.lang.string r3) {
            r1 = this;
            goto L40
        L4:
            com.google.firebase.FirebaseApp r3 = r1.firebaseApp
            goto L18
        La:
            java.lang.string r1 = "Content-Type"
            goto L4a
        L10:
            java.lang.string r1 = quhRxlwlgiDHomne(r1)
            goto L71
        L18:
            com.google.firebase.FirebaseOptions r3 = sgRBGOJNTqyCdsrE(r3)
            goto L8b
        L20:
            java.lang.string r0 = "X-Goog-Api-Key"
            goto L5d
        L26:
            grzqrfvznDUYLbbu(r2, r0, r3)
            goto L64
        L2d:
            java.lang.string r1 = "Accept"
            goto L6a
        L33:
            XxSCufAzllmGkuPa(r2, r1, r3)
            goto La
        L3a:
            java.lang.string r1 = "X-Accept-Response-Streaming"
            goto Lb3
        L40:
            goto L94
        L43:
            goto L78
        L47:
            goto L43
        L4a:
            java.lang.string r3 = "application/json"
            goto Lac
        L50:
            java.lang.string r3 = "yes"
            goto L56
        L56:
            ckHgtYAmjZXZgQhZ(r2, r1, r3)
            goto L3a
        L5d:
            qYKpRUyyeRARSehI(r2, r0, r3)
            goto L85
        L64:
            java.lang.string r3 = "X-Android-Cert"
            goto L10
        L6a:
            qvjOLXeDOXqnmsuj(r2, r1, r3)
            goto L93
        L71:
            WJagkLDjYgITMRyy(r2, r3, r1)
            goto La0
        L78:
            java.lang.string r0 = "X-Goog-Firebase-Installations-Auth"
            goto L7e
        L7e:
            tobudrHnthirMKYp(r2, r0, r3)
            goto L4
        L85:
            android.content.object r3 = r1.context
            goto L98
        L8b:
            java.lang.string r3 = fBXiAxsIUVHOYRjz(r3)
            goto L20
        L93:
            return
        L94:
            goto L47
        L98:
            java.lang.string r3 = uGBpTIrSDQtziDaU(r3)
            goto La6
        La0:
            java.lang.string r1 = "X-Google-GFE-Can-Retry"
            goto L50
        La6:
            java.lang.string r0 = "X-Android-Package"
            goto L26
        Lac:
            LTNPOwlyAQzWyFCI(r2, r1, r3)
            goto L2d
        Lb3:
            java.lang.string r3 = "true"
            goto L33
    }

    private void SetIsHttpConnectionRunning(bool r1) {
            r0 = this;
            goto L15
        L4:
            throw r1
        L5:
            goto L23
        L9:
            monitor-exit(r0)
            goto Le
        Le:
            return
        Lf:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> Lf
            goto L4
        L15:
            goto L5
        L18:
            goto L1c
        L1c:
            monitor-enter(r0)
            r0.isHttpConnectionRunning = r1     // Catch: java.lang.Exception -> Lf
            goto L9
        L23:
            goto L18
    }

    public static com.google.firebase.FirebaseOptions SgRBGOJNTqyCdsrE(com.google.firebase.FirebaseApp r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.firebase.FirebaseOptions r0 = r1.getOptions()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void TYvpQmseetyoVrUi(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, long r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.makeRealtimeHttpConnection(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static java.lang.string TcahndajoizRIKPF(com.google.firebase.installations.InstallationTokenResult r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.getToken()
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

    public static void TfdZrmRmoULvbhzl(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.resetRealtimeBackoff()
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void TobudrHnthirMKYp(java.net.HttpUriConnection r0, java.lang.string r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.setRequestProperty(r1, r2)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient.RealtimeBackoffMetadata TqyUMROllberlLCT(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r1) {
            goto L14
        L4:
            goto L17
        L7:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata r0 = r1.getRealtimeBackoffMetadata()
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

    public static java.util.IEnumerator TyGDqlRdZDmZkFOZ(java.util.HashSet r1) {
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
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.string UGBpTIrSDQtziDaU(android.content.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.getPackageName()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static int UbXdbGZpaMtQEshA(java.lang.int r1) {
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
            int r0 = r1.intValue()
            goto Lb
    }

    public static java.lang.string UjDHHiKqzyciOYYf(android.content.object r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.string r0 = r1.getPackageName()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    private void UpdateBackoffMetadataWithLastFailedStreamConnectionTime(java.util.DateTime r7) {
            r6 = this;
            goto L4
        L4:
            goto L66
        L7:
            goto L54
        Lb:
            r3.<init>(r4)
            goto L78
        L12:
            GGKGkdgHelpVrQYM(r6, r0, r3)
            goto L2d
        L19:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r0 = r6.sharedPrefsClient
            goto L46
        L1f:
            goto L2e
        L22:
            goto L19
        L26:
            r1 = 6
            goto L4e
        L2d:
            return
        L2e:
            goto L63
        L32:
            long r4 = r4 + r1
            goto Lb
        L37:
            goto L7
        L3a:
            int r0 = r0 + 1
            goto L87
        L40:
            java.util.DateTime r3 = new java.util.DateTime
            goto L70
        L46:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata r0 = BeqsftxzEQubefTQ(r0)
            goto L5b
        L4e:
            int r0 = r0 + r1
            goto L6a
        L54:
            r0 = 23
            goto L26
        L5b:
            int r0 = BuueyznUQdgHGePR(r0)
            goto L3a
        L63:
            goto L22
        L66:
            goto L37
        L6a:
            int r0 = r0 % r1
            goto L7e
        L70:
            long r4 = RWdiTaEEwWMnxlXR(r7)
            goto L32
        L78:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r6 = r6.sharedPrefsClient
            goto L12
        L7e:
            if (r0 <= 0) goto L83
            goto L22
        L83:
            goto L1f
        L87:
            long r1 = ODGsrSRhejcyScrt(r6, r0)
            goto L40
    }

    public static com.google.android.gms.common.util.Clock VMUsBwlaGXYIRlmq() {
            goto Lc
        L4:
            com.google.android.gms.common.util.Clock r0 = com.google.android.gms.common.util.DefaultClock.getInstance()
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

    public static java.net.Uri VtVgVloLxAdSTOYr(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1) {
            goto L11
        L4:
            java.net.Uri r0 = r1.getUrl()
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

    public static java.lang.int WWOmfwARPjzIqZaN(int r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.int r0 = java.lang.int.valueOf(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void WhzQGrvlkPURtqgx(java.net.HttpUriConnection r0, java.lang.string r1) {
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
            r0.setRequestMethod(r1)
            goto L4
        L17:
            goto Lc
    }

    public static java.lang.string WsSipkPyELuxdzqw(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r1, java.io.Stream r2) {
            goto L11
        L4:
            java.lang.string r0 = r1.parseForbiddenErrorResponseMessage(r2)
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

    public static void WxPQVRAFiCPCdGoe(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.enableBackoff()
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static void XUSRgppQIVpsEfMt(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0) {
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
            r0.retryHttpConnectionWhenBackoffEnds()
            goto Le
    }

    public static java.lang.string XjGtoNuipDrMdlpo(com.google.firebase.FirebaseOptions r1) {
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
            java.lang.string r0 = r1.getApplicationId()
            goto Le
    }

    public static void XpzdojMSXdMJxsgS(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, bool r1) {
            goto L10
        L4:
            r0.setIsHttpConnectionRunning(r1)
            goto Lb
        Lb:
            return
        Lc:
            goto L17
        L10:
            goto Lc
        L13:
            goto L4
        L17:
            goto L13
    }

    public static void YrTSCFjqgbfYGhlY(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, bool r1) {
            goto L13
        L4:
            r0.setIsHttpConnectionRunning(r1)
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

    public static int ZofhKfPdCqcRKgvJ(java.lang.int r1) {
            goto Lc
        L4:
            int r0 = r1.intValue()
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

    public static java.lang.object ZoqubckNztcHNCYh(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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
            java.lang.object r0 = r1.Add(r2, r3)
            goto Le
    }

    public void BeginRealtimeHttpStream() {
            r4 = this;
            goto L84
        L4:
            r0 = 29
            goto L96
        Lb:
            com.google.android.gms.tasks.Task[] r1 = new com.google.android.gms.tasks.Task[r1]
            goto Lbc
        L11:
            com.google.android.gms.tasks.Task r1 = iTgsXyhezFJsrycI(r1)
            goto L71
        L19:
            rpoOxohgsGOwjUbh(r1, r2, r3)
            goto L20
        L20:
            return
        L21:
            goto L25
        L25:
            goto Le4
        L28:
            goto L5d
        L2c:
            java.util.DateTime r0 = fzwImBnZejeRqYcP(r0)
            goto L60
        L34:
            com.google.android.gms.tasks.Task r0 = pvnBsVRqtxxoVODE(r4)
            goto L58
        L3c:
            r1.<init>(r2)
            goto L2c
        L43:
            IceObjBLtvSbiyzZ(r4)
            goto L91
        L4a:
            bool r0 = GmeGcBEBjVvOMcje(r4)
            goto L68
        L52:
            r1[r2] = r0
            goto L11
        L58:
            r1 = 1
            goto Lb
        L5d:
            goto L87
        L60:
            bool r0 = eXyWatOrYjyQTIUF(r1, r0)
            goto L9d
        L68:
            if (r0 == 0) goto L6d
            goto Ld7
        L6d:
            goto Ld6
        L71:
            java.util.concurrent.ScheduledTaskScheduler r2 = r4.scheduledTaskScheduler
            goto L8b
        L77:
            r3.<init>(r4, r0)
            goto L19
        L7e:
            int r0 = r0 % r1
            goto Lc1
        L84:
            goto L28
        L87:
            goto L4
        L8b:
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient$$ExternalSyntheticLambda1 r3 = new com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient$$ExternalSyntheticLambda1
            goto L77
        L91:
            return
        L92:
            goto L34
        L96:
            r1 = 8
            goto Lca
        L9d:
            if (r0 != 0) goto La2
            goto L92
        La2:
            goto L43
        La6:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata r0 = VcHZypDDlfKODBnL(r0)
            goto Ldb
        Lae:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r0 = r4.sharedPrefsClient
            goto La6
        Lb4:
            long r2 = pXqZIrGjOyKrIZro(r2)
            goto L3c
        Lbc:
            r2 = 0
            goto L52
        Lc1:
            if (r0 <= 0) goto Lc6
            goto Le4
        Lc6:
            goto Le1
        Lca:
            int r0 = r0 + r1
            goto L7e
        Ld0:
            com.google.android.gms.common.util.Clock r2 = r4.clock
            goto Lb4
        Ld6:
            return
        Ld7:
            goto Lae
        Ldb:
            java.util.DateTime r1 = new java.util.DateTime
            goto Ld0
        Le1:
            goto L21
        Le4:
            goto L4a
    }

    public void CloseRealtimeHttpStream(java.net.HttpUriConnection r1) {
            r0 = this;
            goto L30
        L4:
            XZRWGVbDUwFjHyph(r1)
            java.io.Stream r0 = LKnoTRdTpAMntUvZ(r1)     // Catch: java.io.IOException -> L1b
            FDTcTqBBkUYCImSP(r0)     // Catch: java.io.IOException -> L1b
            java.io.Stream r0 = lUVeRNgmZRGABRHF(r1)     // Catch: java.io.IOException -> L1b
            if (r0 == 0) goto L1b
            java.io.Stream r0 = cuDzPmkxPktHmpda(r1)     // Catch: java.io.IOException -> L1b
            qgYrDginHPXwqGro(r0)     // Catch: java.io.IOException -> L1b
        L1b:
            goto L28
        L1f:
            if (r1 != 0) goto L24
            goto L1b
        L24:
            goto L4
        L28:
            return
        L29:
            goto L2d
        L2d:
            goto L33
        L30:
            goto L29
        L33:
            goto L1f
    }

    public com.google.android.gms.tasks.Task<java.net.HttpUriConnection> CreateRealtimeConnection() {
            r5 = this;
            goto L41
        L4:
            return r5
        L5:
            goto L65
        L9:
            com.google.android.gms.tasks.Task r0 = LyYHKjNMghfIlKCM(r0, r1)
            goto L91
        L11:
            if (r0 <= 0) goto L16
            goto L82
        L16:
            goto L7f
        L1a:
            r4.<init>(r5, r0, r2)
            goto L74
        L21:
            com.google.android.gms.tasks.Task r1 = NuVxwpeFZocbnoei(r3)
            goto L3b
        L29:
            r3 = 2
            goto L9e
        L2e:
            com.google.firebase.installations.FirebaseInstallationsApi r0 = r5.firebaseInstallations
            goto L8c
        L34:
            r0 = 17
            goto L97
        L3b:
            java.util.concurrent.ScheduledTaskScheduler r3 = r5.scheduledTaskScheduler
            goto L48
        L41:
            goto L68
        L44:
            goto L34
        L48:
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient$$ExternalSyntheticLambda0 r4 = new com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient$$ExternalSyntheticLambda0
            goto L1a
        L4e:
            r3[r1] = r2
            goto L21
        L54:
            int r0 = r0 % r1
            goto L11
        L5a:
            r1 = 1
            goto L4e
        L5f:
            r3[r1] = r0
            goto L5a
        L65:
            goto L82
        L68:
            goto L7c
        L6c:
            com.google.android.gms.tasks.Task r2 = DxFyQutonXjcBUvJ(r2)
            goto L29
        L74:
            com.google.android.gms.tasks.Task r5 = YBirCsGCZattfLGh(r1, r3, r4)
            goto L4
        L7c:
            goto L44
        L7f:
            goto L5
        L82:
            goto L2e
        L86:
            int r0 = r0 + r1
            goto L54
        L8c:
            r1 = 0
            goto L9
        L91:
            com.google.firebase.installations.FirebaseInstallationsApi r2 = r5.firebaseInstallations
            goto L6c
        L97:
            r1 = 5
            goto L86
        L9e:
            com.google.android.gms.tasks.Task[] r3 = new com.google.android.gms.tasks.Task[r3]
            goto L5f
    }

    public java.util.DateTime GetBackoffEndTime() {
            r0 = this;
            goto L22
        L4:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r0 = r0.sharedPrefsClient
            goto L12
        La:
            return r0
        Lb:
            goto Lf
        Lf:
            goto L25
        L12:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata r0 = gxpioNJlSZFDTJgz(r0)
            goto L1a
        L1a:
            java.util.DateTime r0 = hNfxwwVbXPhZnFpm(r0)
            goto La
        L22:
            goto Lb
        L25:
            goto L4
    }

    public int GetNumberOfFailedStreams() {
            r0 = this;
            goto Lc
        L4:
            int r0 = dNejJVPOxjphsTCn(r0)
            goto L13
        Lc:
            goto L14
        Lf:
            goto L1b
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto Lf
        L1b:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r0 = r0.sharedPrefsClient
            goto L21
        L21:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata r0 = tqyUMROllberlLCT(r0)
            goto L4
    }

    /* JADX INFO: renamed from: lambda$beginRealtimeHttpStream$1$com-google-firebase-remoteconfig-internal-ConfigRealtimeHttpClient */
    /* synthetic */ com.google.android.gms.tasks.Task m411x5fb1dc1(com.google.android.gms.tasks.Task r11, com.google.android.gms.tasks.Task r12) throws java.lang.Exception {
            r10 = this;
            goto L2f6
        L4:
            com.google.android.gms.common.util.Clock r6 = r10.clock
            goto L1ba
        La:
            r5 = r4
            goto L2ce
        Lf:
            if (r6 != 0) goto L14
            goto Ldb
        L14:
            goto Ld9
        L18:
            r5 = r4
            goto L2e5
        L1d:
            r3.<init>(r6)
            goto La2
        L24:
            goto L189
        L26:
            goto L37d
        L2a:
            r0 = 403(0x193, float:5.65E-43)
            goto L38a
        L30:
            euwUallvLXQyWpaX(r10, r11)
            goto L18d
        L37:
            bool r6 = NtoJbiiViMMGpomY(r10, r6)
            goto L30c
        L3f:
            r11.<init>(r0, r12, r1)
            goto L24
        L46:
            r3 = 0
            goto L1f5
        L4b:
            int r6 = HzeIfsVsqVEzhbyF(r5)
            goto Lf4
        L53:
            KWmexSwyFiEkkCNq(r10, r11)
            goto L2ea
        L5a:
            int r0 = r0 % r1
            goto L24d
        L60:
            goto L153
        L62:
            goto L152
        L66:
            java.io.Stream r11 = KEPZNbsgEIYXkiZh(r11)
            goto L256
        L6e:
            java.lang.string r12 = "Unable to connect to the server. Try again in a few minutes. HTTP status code: %d"
            goto L2a
        L74:
            int r2 = qzpeFUjYXSmFbiPp(r5)
            goto Lb0
        L7c:
            EWFXltPSHsRKcdHR(r10, r11)
            goto L32a
        L83:
            r3.<init>(r6)
            goto L336
        L8a:
            int r1 = PsYOBSNSzwsiPcZB(r5)
            goto L34f
        L92:
            int r1 = awLFmdjRovRnOFYk(r5)
            goto L11e
        L9a:
            bool r6 = YsDCyEhCjeVoGSaJ(r10, r6)
            goto L115
        La2:
            QspqzklnvSWTsdhB(r10, r3)
        La5:
            goto L194
        La9:
            goto L326
        Lac:
            goto L112
        Lb0:
            if (r2 == r1) goto Lb5
            goto L14e
        Lb5:
            goto L14c
        Lb9:
            if (r1 == r0) goto Lbe
            goto L25a
        Lbe:
            goto L66
        Lc2:
            goto L173
        Lc4:
            r6 = move-exception
            goto La
        Lc9:
            throw r4
        Lca:
            goto La9
        Lce:
            r9 = r5
            goto L2f1
        Ld3:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException r11 = new com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException
            goto L375
        Ld9:
            goto L344
        Ldb:
            goto L343
        Ldf:
            r0 = 4
            goto L1ca
        Le6:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code r1 = com.google.firebase.remoteconfig.FirebaseRemoteConfigException.Code.CONFIG_UPDATE_STREAM_ERROR
            goto L186
        Lec:
            int r6 = INJpxCrikFwzMZSu(r5)
            goto L37
        Lf4:
            bool r6 = mTXVDYhPLNoajQgf(r10, r6)
            goto Lf
        Lfc:
            java.lang.string r12 = riddOWVeXWLxIklx(r12, r1)
            goto L12f
        L104:
            java.lang.string r12 = EPnJEFGvSZOiLrJB(r12, r1)
            goto L8a
        L10c:
            int r0 = r0 + r1
            goto L5a
        L112:
            goto L2f9
        L115:
            if (r6 != 0) goto L11a
            goto L62
        L11a:
            goto L60
        L11e:
            if (r1 == r0) goto L123
            goto L1b6
        L123:
            goto L127
        L127:
            java.io.Stream r11 = OgoAldMdZrYvYVju(r11)
            goto L1b2
        L12f:
            int r1 = oKgTGzIgEDgUjptQ(r5)
            goto Lb9
        L137:
            java.util.DateTime r3 = new java.util.DateTime
            goto L2df
        L13d:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException r11 = new com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException
            goto L25e
        L143:
            if (r2 != r1) goto L148
            goto L32b
        L148:
            goto L15d
        L14c:
            goto L268
        L14e:
            goto L315
        L152:
            r2 = r3
        L153:
            goto L177
        L157:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException r11 = new com.google.firebase.remoteconfig.FirebaseRemoteConfigServerException
            goto L1c2
        L15d:
            java.lang.object[] r1 = new java.lang.object[]{r5}
            goto L104
        L165:
            r5 = r11
        L166:
            java.lang.string r7 = "FirebaseRemoteConfig"
            java.lang.string r8 = "Exception connecting to real-time RC backend. Retrying the connection..."
            sQfUhkQOVwCfyrfL(r7, r8, r6)     // Catch: java.lang.Exception -> L172
            goto L53
        L171:
            return r10
        L172:
            r4 = move-exception
        L173:
            goto L30
        L177:
            if (r2 != 0) goto L17c
            goto L2c2
        L17c:
            goto L137
        L180:
            goto L28d
        L182:
            goto L28c
        L186:
            r11.<init>(r0, r12, r1)
        L189:
            goto L1ee
        L18d:
            xpzdojMSXdMJxsgS(r10, r3)
            goto L2b6
        L194:
            if (r2 == 0) goto L199
            goto L268
        L199:
            goto L27d
        L19d:
            java.lang.string r12 = aFplXXOpKokGwEEL(r12, r1)
            goto L92
        L1a5:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code r1 = com.google.firebase.remoteconfig.FirebaseRemoteConfigException.Code.CONFIG_UPDATE_STREAM_ERROR
            goto L32f
        L1ab:
            yrTSCFjqgbfYGhlY(r10, r3)
            goto L358
        L1b2:
            java.lang.string r12 = NGuJrfgLAnSauWPR(r10, r11)
        L1b6:
            goto L157
        L1ba:
            long r6 = BFmjVxMTxidNfRvu(r6)
            goto L1d
        L1c2:
            int r0 = RGVJaIwxWaroLBIJ(r5)
            goto L390
        L1ca:
            r1 = 15
            goto L10c
        L1d1:
            if (r2 == 0) goto L1d6
            goto L268
        L1d6:
            goto L74
        L1da:
            java.util.DateTime r3 = new java.util.DateTime
            goto L4
        L1e0:
            r4 = r9
            goto Lc2
        L1e5:
            if (r2 == r1) goto L1ea
            goto L31f
        L1ea:
            goto L31d
        L1ee:
            FFJlxFsbrHXQeFwj(r10, r11)
            goto L266
        L1f5:
            r4 = 0
            bool r5 = AJQgCywEjLeqUVnq(r11)     // Catch: java.io.IOException -> L2a0 java.lang.Exception -> L2da
            if (r5 == 0) goto L2d0
            OvYpYcjXFiQTEyBr(r10, r2)     // Catch: java.io.IOException -> L2a0 java.lang.Exception -> L2da
            java.lang.object r11 = UNezvgbUFDsFfTYD(r11)     // Catch: java.io.IOException -> L2a0 java.lang.Exception -> L2da
            java.net.HttpUriConnection r11 = (java.net.HttpUriConnection) r11     // Catch: java.io.IOException -> L2a0 java.lang.Exception -> L2da
            int r5 = ZuOChnngKZOeThvA(r11)     // Catch: java.io.IOException -> Lc4 java.lang.Exception -> L307
            java.lang.int r5 = wWOmfwARPjzIqZaN(r5)     // Catch: java.io.IOException -> Lc4 java.lang.Exception -> L307
            int r6 = ubXdbGZpaMtQEshA(r5)     // Catch: java.lang.Exception -> L172 java.io.IOException -> L287
            if (r6 != r1) goto L222
            kGhYwPqcGpuUHBDv(r10)     // Catch: java.lang.Exception -> L172 java.io.IOException -> L287
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r6 = r10.sharedPrefsClient     // Catch: java.lang.Exception -> L172 java.io.IOException -> L287
            tfdZrmRmoULvbhzl(r6)     // Catch: java.lang.Exception -> L172 java.io.IOException -> L287
            com.google.firebase.remoteconfig.internal.ConfigAutoFetch r6 = JfHmkjsKmMbvlOQy(r10, r11)     // Catch: java.lang.Exception -> L172 java.io.IOException -> L287
            aALfepQVvRTsTXaz(r6)     // Catch: java.lang.Exception -> L172 java.io.IOException -> L287
        L222:
            goto L361
        L226:
            r3.<init>(r6)
            goto L2bf
        L22d:
            if (r2 != 0) goto L232
            goto L339
        L232:
            goto L33d
        L236:
            if (r2 != 0) goto L23b
            goto La5
        L23b:
            goto L1da
        L23f:
            com.google.android.gms.common.util.Clock r6 = r10.clock
            goto L291
        L245:
            int r6 = zofhKfPdCqcRKgvJ(r5)
            goto L9a
        L24d:
            if (r0 <= 0) goto L252
            goto L326
        L252:
            goto L323
        L256:
            java.lang.string r12 = bEweKdIolALRQzNt(r10, r11)
        L25a:
            goto L13d
        L25e:
            int r0 = NWKzevDYvuXxOTPH(r5)
            goto Le6
        L266:
            goto L26
        L268:
            goto L396
        L26c:
            if (r2 == 0) goto L271
            goto L32b
        L271:
            goto L2a5
        L275:
            java.io.Stream r11 = aaMfsbgExMCEDLFF(r11)
            goto L2c6
        L27d:
            int r2 = ZIOTQWvUsLYpqWhW(r5)
            goto L1e5
        L285:
            goto L26
        L287:
            r6 = move-exception
            goto L305
        L28c:
            r2 = r3
        L28d:
            goto L22d
        L291:
            long r6 = QJcfgWaCFMafAqZs(r6)
            goto L83
        L299:
            r11 = r4
            goto L165
        L29e:
            goto L173
        L2a0:
            r6 = move-exception
            goto L299
        L2a5:
            int r2 = MAKiJUmwPrdmiMdv(r5)
            goto L143
        L2ad:
            if (r5 != 0) goto L2b2
            goto L344
        L2b2:
            goto L4b
        L2b6:
            if (r5 != 0) goto L2bb
            goto L153
        L2bb:
            goto L245
        L2bf:
            aKDtiLpjNCnphUqt(r10, r3)
        L2c2:
            goto L26c
        L2c6:
            java.lang.string r12 = wsSipkPyELuxdzqw(r10, r11)
        L2ca:
            goto Ld3
        L2ce:
            goto L166
        L2d0:
            java.io.IOException r5 = new java.io.IOException     // Catch: java.io.IOException -> L2a0 java.lang.Exception -> L2da
            java.lang.Exception r11 = FQRIPsGpUghTGRaU(r11)     // Catch: java.io.IOException -> L2a0 java.lang.Exception -> L2da
            r5.<init>(r11)     // Catch: java.io.IOException -> L2a0 java.lang.Exception -> L2da
            throw r5     // Catch: java.io.IOException -> L2a0 java.lang.Exception -> L2da
        L2da:
            r11 = move-exception
            goto L18
        L2df:
            com.google.android.gms.common.util.Clock r6 = r10.clock
            goto L2fd
        L2e5:
            r4 = r11
            goto L385
        L2ea:
            ByUOUcuzWxzEirvc(r10, r3)
            goto L2ad
        L2f1:
            r5 = r4
            goto L1e0
        L2f6:
            goto Lac
        L2f9:
            goto Ldf
        L2fd:
            long r6 = akEgPSzMTaeXjdWM(r6)
            goto L226
        L305:
            goto L166
        L307:
            r5 = move-exception
            goto Lce
        L30c:
            if (r6 != 0) goto L311
            goto L182
        L311:
            goto L180
        L315:
            java.lang.object[] r1 = new java.lang.object[]{r5}
            goto Lfc
        L31d:
            goto L268
        L31f:
            goto L36d
        L323:
            goto Lca
        L326:
            goto L6e
        L32a:
            goto L34b
        L32b:
            goto L348
        L32f:
            r11.<init>(r0, r12, r1)
            goto L7c
        L336:
            LtBSeVAeFBfuhiOd(r10, r3)
        L339:
            goto L1d1
        L33d:
            java.util.DateTime r3 = new java.util.DateTime
            goto L23f
        L343:
            r2 = r3
        L344:
            goto L236
        L348:
            naVVpHnfBkPjXPlp(r10)
        L34b:
            goto Lc9
        L34f:
            if (r1 == r0) goto L354
            goto L2ca
        L354:
            goto L275
        L358:
            if (r5 != 0) goto L35d
            goto L28d
        L35d:
            goto Lec
        L361:
            IsdoiXnBIHDyGmBP(r10, r11)
            goto L1ab
        L368:
            r2 = 1
            goto L46
        L36d:
            java.lang.object[] r1 = new java.lang.object[]{r5}
            goto L19d
        L375:
            int r0 = EOuGLXWNhkSBwdle(r5)
            goto L1a5
        L37d:
            com.google.android.gms.tasks.Task r10 = BBcAtgEVqvVwSCpu(r4)
            goto L171
        L385:
            r11 = r5
            goto L29e
        L38a:
            r1 = 200(0xc8, float:2.8E-43)
            goto L368
        L390:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigException$Code r1 = com.google.firebase.remoteconfig.FirebaseRemoteConfigException.Code.CONFIG_UPDATE_STREAM_ERROR
            goto L3f
        L396:
            xUSRgppQIVpsEfMt(r10)
            goto L285
    }

    /* JADX INFO: renamed from: lambda$createRealtimeConnection$0$com-google-firebase-remoteconfig-internal-ConfigRealtimeHttpClient */
    /* synthetic */ com.google.android.gms.tasks.Task m412xad28ecdf(com.google.android.gms.tasks.Task r1, com.google.android.gms.tasks.Task r2, com.google.android.gms.tasks.Task r3) throws java.lang.Exception {
            r0 = this;
            goto L8e
        L4:
            bool r3 = fLSBMvyHNOUjQFIf(r1)
            goto Lad
        Lc:
            goto L91
        Lf:
            com.google.android.gms.tasks.Task r0 = falXEvcSSbxdGujH(r0)
            goto L17
        L17:
            return r0
        L18:
            java.net.Uri r3 = vtVgVloLxAdSTOYr(r0)     // Catch: java.io.IOException -> L55
            java.net.UriConnection r3 = cQVodDOTOTLJNUIH(r3)     // Catch: java.io.IOException -> L55
            java.net.HttpUriConnection r3 = (java.net.HttpUriConnection) r3     // Catch: java.io.IOException -> L55
            java.lang.object r1 = auSkscuIBRghEvhH(r1)     // Catch: java.io.IOException -> L55
            com.google.firebase.installations.InstallationTokenResult r1 = (com.google.firebase.installations.InstallationTokenResult) r1     // Catch: java.io.IOException -> L55
            java.lang.string r1 = tcahndajoizRIKPF(r1)     // Catch: java.io.IOException -> L55
            java.lang.object r2 = axDKgyDnEtpbFWRt(r2)     // Catch: java.io.IOException -> L55
            java.lang.string r2 = (java.lang.string) r2     // Catch: java.io.IOException -> L55
            VDLPtIsgNOIJmzXn(r0, r3, r2, r1)     // Catch: java.io.IOException -> L55
            goto L66
        L39:
            com.google.android.gms.tasks.Task r0 = JIRFWovtKDBTXXaV(r0)
            goto L7b
        L41:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException r1 = new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException
            goto L5a
        L47:
            return r0
        L48:
            goto Lc
        L4c:
            com.google.android.gms.tasks.Task r0 = qIhzlGZzQhvahBhH(r1)
            goto L47
        L54:
            return r0
        L55:
            r0 = move-exception
            goto L41
        L5a:
            java.lang.string r2 = "Failed to open HTTP stream connection"
            goto Lc4
        L60:
            java.lang.string r2 = "Firebase Installations failed to get installation auth token for config update listener connection."
            goto La5
        L66:
            com.google.android.gms.tasks.Task r0 = ahDwLADLHrwPLMYG(r3)
            goto L54
        L6e:
            java.lang.string r1 = "Firebase Installations failed to get installation ID for config update listener connection."
            goto Lb6
        L74:
            r0.<init>(r2, r1)
            goto L39
        L7b:
            return r0
        L7c:
            goto L86
        L80:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException r0 = new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException
            goto L60
        L86:
            bool r3 = FJHPeqchnTSLhqFK(r2)
            goto L9c
        L8e:
            goto L48
        L91:
            goto L4
        L95:
            r0.<init>(r1, r2)
            goto Lf
        L9c:
            if (r3 == 0) goto La1
            goto L18
        La1:
            goto Lbe
        La5:
            java.lang.Exception r1 = eyTkoJbyiXIJLZlT(r1)
            goto L74
        Lad:
            if (r3 == 0) goto Lb2
            goto L7c
        Lb2:
            goto L80
        Lb6:
            java.lang.Exception r2 = reOuLfzKAKRhELfx(r2)
            goto L95
        Lbe:
            com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException r0 = new com.google.firebase.remoteconfig.FirebaseRemoteConfigClientException
            goto L6e
        Lc4:
            r1.<init>(r2, r0)
            goto L4c
    }

    public void RetryHttpConnectionWhenBackoffEnds() {
            r5 = this;
            goto L26
        L4:
            goto L78
        L7:
            goto L4b
        Lb:
            return
        Lc:
            r0 = move-exception
            monitor-exit(r5)     // Catch: java.lang.Exception -> Lc
            goto L77
        L12:
            int r0 = r0 % r1
            goto L32
        L18:
            r1 = 17
            goto L3b
        L1f:
            goto L7
        L22:
            goto L48
        L26:
            goto L22
        L29:
            goto L41
        L2d:
            monitor-exit(r5)
            goto Lb
        L32:
            if (r0 <= 0) goto L37
            goto L7
        L37:
            goto L4
        L3b:
            int r0 = r0 + r1
            goto L12
        L41:
            r0 = 30
            goto L18
        L48:
            goto L29
        L4b:
            monitor-enter(r5)
            java.util.DateTime r0 = new java.util.DateTime     // Catch: java.lang.Exception -> Lc
            com.google.android.gms.common.util.Clock r1 = r5.clock     // Catch: java.lang.Exception -> Lc
            long r1 = LGMdSpdcblhQPRip(r1)     // Catch: java.lang.Exception -> Lc
            r0.<init>(r1)     // Catch: java.lang.Exception -> Lc
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r1 = r5.sharedPrefsClient     // Catch: java.lang.Exception -> Lc
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient$RealtimeBackoffMetadata r1 = MmQqqtnfiiBthKKr(r1)     // Catch: java.lang.Exception -> Lc
            java.util.DateTime r1 = UiavwYlNdpYfivkB(r1)     // Catch: java.lang.Exception -> Lc
            long r1 = VckTiwngCQhikgim(r1)     // Catch: java.lang.Exception -> Lc
            long r3 = GlvASIPRqMdTezZY(r0)     // Catch: java.lang.Exception -> Lc
            long r1 = r1 - r3
            r3 = 0
            long r0 = CCbTnPgUcvAXqhrg(r3, r1)     // Catch: java.lang.Exception -> Lc
            tYvpQmseetyoVrUi(r5, r0)     // Catch: java.lang.Exception -> Lc
            goto L2d
        L77:
            throw r0
        L78:
            goto L1f
    }

    void setRealtimeBackgroundState(bool r1) {
            r0 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L13
        Lb:
            goto L7
        Le:
            return
        Lf:
            goto Lb
        L13:
            r0.isInBackground = r1
            goto Le
    }

    public void SetRequestParams(java.net.HttpUriConnection r2, java.lang.string r3, java.lang.string r4) throws java.io.IOException {
            r1 = this;
            goto L62
        L4:
            java.lang.string r0 = "POST"
            goto L44
        La:
            org.json.JSONobject r1 = npCJLuVpYJJOwowz(r1, r3)
            goto L53
        L12:
            java.io.BufferedStream r3 = new java.io.BufferedStream
            goto L39
        L18:
            r3.<init>(r2)
            goto L5b
        L1f:
            return
        L20:
            goto L41
        L24:
            EHDlMmpUlJChXXOE(r3)
            goto L1f
        L2b:
            rBGoCjRAurcgEPHY(r1, r2, r4)
            goto La
        L32:
            WbUFvLexghlAXMlZ(r3)
            goto L24
        L39:
            java.io.Stream r2 = plEcxfULWHdaMvBu(r2)
            goto L18
        L41:
            goto L65
        L44:
            whzQGrvlkPURtqgx(r2, r0)
            goto L2b
        L4b:
            byte[] r1 = cuWOhDSBIbhQlWBB(r1, r3)
            goto L12
        L53:
            java.lang.string r1 = pzcaWqQffunkgLyy(r1)
            goto L69
        L5b:
            LeFaBJjmlmQfqVqg(r3, r1)
            goto L32
        L62:
            goto L20
        L65:
            goto L4
        L69:
            java.lang.string r3 = "utf-8"
            goto L4b
    }

    public com.google.firebase.remoteconfig.internal.ConfigAutoFetch StartAutoFetch(java.net.HttpUriConnection r8) {
            r7 = this;
            goto L42
        L4:
            monitor-exit(r7)
            goto L1f
        L9:
            int r0 = r0 % r1
            goto Lf
        Lf:
            if (r0 <= 0) goto L14
            goto L28
        L14:
            goto L25
        L18:
            r0 = 8
            goto L34
        L1f:
            return r0
        L20:
            r0 = move-exception
            goto L61
        L25:
            goto L30
        L28:
            goto L49
        L2c:
            goto L45
        L2f:
            throw r8
        L30:
            goto L3b
        L34:
            r1 = 2
            goto L67
        L3b:
            goto L28
        L3e:
            goto L2c
        L42:
            goto L3e
        L45:
            goto L18
        L49:
            monitor-enter(r7)
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient$2 r5 = new com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient$2     // Catch: java.lang.Exception -> L20
            r5.<init>(r7)     // Catch: java.lang.Exception -> L20
            com.google.firebase.remoteconfig.internal.ConfigAutoFetch r0 = new com.google.firebase.remoteconfig.internal.ConfigAutoFetch     // Catch: java.lang.Exception -> L20
            com.google.firebase.remoteconfig.internal.ConfigFetchHandler r2 = r7.configFetchHandler     // Catch: java.lang.Exception -> L20
            com.google.firebase.remoteconfig.internal.ConfigCacheClient r3 = r7.activatedCache     // Catch: java.lang.Exception -> L20
            java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> r4 = r7.listeners     // Catch: java.lang.Exception -> L20
            java.util.concurrent.ScheduledTaskScheduler r6 = r7.scheduledTaskScheduler     // Catch: java.lang.Exception -> L20
            r1 = r8
            r0.<init>(r1, r2, r3, r4, r5, r6)     // Catch: java.lang.Exception -> L20
            goto L4
        L61:
            r8 = r0
            monitor-exit(r7)     // Catch: java.lang.Exception -> L20
            goto L2f
        L67:
            int r0 = r0 + r1
            goto L9
    }

    public void StartHttpConnection() {
            r2 = this;
            goto L4
        L4:
            goto L15
        L7:
            goto L4a
        Lb:
            goto L23
        Le:
            goto L27
        L12:
            goto Le
        L15:
            goto L2d
        L19:
            if (r0 <= 0) goto L1e
            goto Le
        L1e:
            goto Lb
        L22:
            return
        L23:
            goto L12
        L27:
            r0 = 0
            goto L43
        L2d:
            goto L7
        L30:
            int r0 = r0 + r1
            goto L3d
        L36:
            r1 = 27
            goto L30
        L3d:
            int r0 = r0 % r1
            goto L19
        L43:
            XIGgSGdOdZmATeUU(r2, r0)
            goto L22
        L4a:
            r0 = 29
            goto L36
    }
}

