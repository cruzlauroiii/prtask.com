namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class FirebaseInstallations : com.google.firebase.installations.FirebaseInstallationsApi {
    private static readonly java.lang.string API_KEY_VALIDATION_MSG = "Please set a valid API key. A Firebase API key is required to communicate with Firebase server APIs: It authenticates your project with Google.Please refer to https://firebase.google.com/support/privacy/init-options.";
    private static readonly java.lang.string APP_ID_VALIDATION_MSG = "Please set your Application ID. A valid Firebase App ID is required to communicate with Firebase server APIs: It identifies your application with Firebase.Please refer to https://firebase.google.com/support/privacy/init-options.";
    private static readonly java.lang.string AUTH_ERROR_MSG = "Installation ID could not be validated with the Firebase servers (maybe it was deleted). Firebase Installations will need to create a new Installation ID and auth token. Please retry your last request.";
    private static readonly java.lang.string CHIME_FIREBASE_APP_NAME = "CHIME_ANDROID_SDK";
    private static readonly int CORE_POOL_SIZE = 0;
    private static readonly long KEEP_ALIVE_TIME_IN_SECONDS = 30;
    private static readonly java.lang.string LOCKFILE_NAME_GENERATE_FID = "generatefid.lock";
    private static readonly int MAXIMUM_POOL_SIZE = 1;
    private static readonly java.lang.string PROJECT_ID_VALIDATION_MSG = "Please set your Project ID. A valid Firebase Project ID is required to communicate with Firebase server APIs: It identifies your application with Firebase.Please refer to https://firebase.google.com/support/privacy/init-options.";
    private static readonly java.util.concurrent.ThreadFactory THREAD_FACTORY = null;
    private static readonly java.lang.object lockGenerateFid = null;
    private readonly java.util.concurrent.TaskScheduler backgroundExecutor;
    private java.lang.string cachedFid;
    private readonly com.google.firebase.installations.RandomFidGenerator fidGenerator;
    private java.util.HashSet<com.google.firebase.installations.internal.FidListener> fidListeners;
    private readonly com.google.firebase.FirebaseApp firebaseApp;
    private readonly com.google.firebase.components.Lazy<com.google.firebase.installations.local.IidStore> iidStore;
    private readonly java.util.List<com.google.firebase.installations.StateListener> listeners;
    private readonly java.lang.object lock;
    private readonly java.util.concurrent.Executor networkExecutor;
    private readonly com.google.firebase.installations.local.PersistedInstallation persistedInstallation;
    private readonly com.google.firebase.installations.remote.FirebaseInstallationServiceClient serviceClient;
    private readonly com.google.firebase.installations.Utils utils;



    /* JADX INFO: renamed from: com.google.firebase.installations.FirebaseInstallations$3 */
    static /* synthetic */ class C20433 {

        /* JADX INFO: renamed from: $SwitchDictionary$com$google$firebase$installations$remote$InstallationResponse$ResponseCode */
        static readonly /* synthetic */ int[] f332xc38d2559 = null;

        /* JADX INFO: renamed from: $SwitchDictionary$com$google$firebase$installations$remote$TokenResult$ResponseCode */
        static readonly /* synthetic */ int[] f333xe5baa01a = null;

        static {
                goto L88
            L4:
                int r0 = r0 % r1
                goto L76
            La:
                r0 = 19
                goto L11
            L11:
                r1 = 6
                goto L82
            L18:
                return
            L19:
                goto L6f
            L1d:
                com.google.firebase.installations.remote.InstallationResponse$ResponseCode[] r2 = jNlEwBdShVICnIrd()
                goto L25
            L25:
                int r2 = r2.length
                goto L2a
            L2a:
                int[] r2 = new int[r2]
                goto L4b
            L30:
                com.google.firebase.installations.FirebaseInstallations.C20433.f333xe5baa01a = r0
                goto L36
            L36:
                r1 = 1
                com.google.firebase.installations.remote.TokenResult$ResponseCode r2 = com.google.firebase.installations.remote.TokenResult.ResponseCode.OK     // Catch: java.lang.NoSuchFieldError -> L3f
                int r2 = jaVkcSiiQPnXaOeR(r2)     // Catch: java.lang.NoSuchFieldError -> L3f
                r0[r2] = r1     // Catch: java.lang.NoSuchFieldError -> L3f
            L3f:
                goto L95
            L43:
                com.google.firebase.installations.remote.TokenResult$ResponseCode[] r0 = bVmefHueUzLOOKqM()
                goto L63
            L4b:
                com.google.firebase.installations.FirebaseInstallations.C20433.f332xc38d2559 = r2
                com.google.firebase.installations.remote.InstallationResponse$ResponseCode r3 = com.google.firebase.installations.remote.InstallationResponse.ResponseCode.OK     // Catch: java.lang.NoSuchFieldError -> L55
                int r3 = viJGOVwCoHTfheOF(r3)     // Catch: java.lang.NoSuchFieldError -> L55
                r2[r3] = r1     // Catch: java.lang.NoSuchFieldError -> L55
            L55:
                int[] r1 = com.google.firebase.installations.FirebaseInstallations.C20433.f332xc38d2559     // Catch: java.lang.NoSuchFieldError -> L5f
                com.google.firebase.installations.remote.InstallationResponse$ResponseCode r2 = com.google.firebase.installations.remote.InstallationResponse.ResponseCode.BAD_CONFIG     // Catch: java.lang.NoSuchFieldError -> L5f
                int r2 = suPispUXUoqzrhyP(r2)     // Catch: java.lang.NoSuchFieldError -> L5f
                r1[r2] = r0     // Catch: java.lang.NoSuchFieldError -> L5f
            L5f:
                goto L18
            L63:
                int r0 = r0.length
                goto L8f
            L68:
                goto L19
            L6b:
                goto L43
            L6f:
                goto L6b
            L72:
                goto L7f
            L76:
                if (r0 <= 0) goto L7b
                goto L6b
            L7b:
                goto L68
            L7f:
                goto L8b
            L82:
                int r0 = r0 + r1
                goto L4
            L88:
                goto L72
            L8b:
                goto La
            L8f:
                int[] r0 = new int[r0]
                goto L30
            L95:
                r0 = 2
                int[] r2 = com.google.firebase.installations.FirebaseInstallations.C20433.f333xe5baa01a     // Catch: java.lang.NoSuchFieldError -> La0
                com.google.firebase.installations.remote.TokenResult$ResponseCode r3 = com.google.firebase.installations.remote.TokenResult.ResponseCode.BAD_CONFIG     // Catch: java.lang.NoSuchFieldError -> La0
                int r3 = TmugFcRSzTabIIHA(r3)     // Catch: java.lang.NoSuchFieldError -> La0
                r2[r3] = r0     // Catch: java.lang.NoSuchFieldError -> La0
            La0:
                int[] r2 = com.google.firebase.installations.FirebaseInstallations.C20433.f333xe5baa01a     // Catch: java.lang.NoSuchFieldError -> Lab
                com.google.firebase.installations.remote.TokenResult$ResponseCode r3 = com.google.firebase.installations.remote.TokenResult.ResponseCode.AUTH_ERROR     // Catch: java.lang.NoSuchFieldError -> Lab
                int r3 = zrXjtNESGWBEHgQD(r3)     // Catch: java.lang.NoSuchFieldError -> Lab
                r4 = 3
                r2[r3] = r4     // Catch: java.lang.NoSuchFieldError -> Lab
            Lab:
                goto L1d
        }

        public static int TmugFcRSzTabIIHA(com.google.firebase.installations.remote.TokenResult.ResponseCode r1) {
                goto L14
            L4:
                goto L17
            L7:
                int r0 = r1.ordinal()
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

        public static com.google.firebase.installations.remote.TokenResult.ResponseCode[] BVmefHueUzLOOKqM() {
                goto L11
            L4:
                com.google.firebase.installations.remote.TokenResult$ResponseCode[] r0 = com.google.firebase.installations.remote.TokenResult.ResponseCode.Values
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

        public static com.google.firebase.installations.remote.InstallationResponse.ResponseCode[] JNlEwBdShVICnIrd() {
                goto L14
            L4:
                com.google.firebase.installations.remote.InstallationResponse$ResponseCode[] r0 = com.google.firebase.installations.remote.InstallationResponse.ResponseCode.Values
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

        public static int JaVkcSiiQPnXaOeR(com.google.firebase.installations.remote.TokenResult.ResponseCode r1) {
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
                int r0 = r1.ordinal()
                goto L4
        }

        public static int SuPispUXUoqzrhyP(com.google.firebase.installations.remote.InstallationResponse.ResponseCode r1) {
                goto L4
            L4:
                goto L17
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                int r0 = r1.ordinal()
                goto L16
            L16:
                return r0
            L17:
                goto Lb
        }

        public static int ViJGOVwCoHTfheOF(com.google.firebase.installations.remote.InstallationResponse.ResponseCode r1) {
                goto Lc
            L4:
                int r0 = r1.ordinal()
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

        public static int ZrXjtNESGWBEHgQD(com.google.firebase.installations.remote.TokenResult.ResponseCode r1) {
                goto Lc
            L4:
                int r0 = r1.ordinal()
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
    }

    public static /* synthetic */ java.lang.void $r8$lambda$O57UbArKVPOdjMtZBKxMAtl9KAA(com.google.firebase.installations.FirebaseInstallations r0) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.void r0 = dhDDNPNGfDjROWrQ(r0)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    static {
            goto L25
        L4:
            return
        L5:
            goto Lf
        L9:
            com.google.firebase.installations.FirebaseInstallations.lockGenerateFid = r0
            goto L1f
        Lf:
            goto L28
        L12:
            com.google.firebase.installations.FirebaseInstallations.THREAD_FACTORY = r0
            goto L4
        L18:
            r0.<init>()
            goto L9
        L1f:
            com.google.firebase.installations.FirebaseInstallations$1 r0 = new com.google.firebase.installations.FirebaseInstallations$1
            goto L2c
        L25:
            goto L5
        L28:
            goto L33
        L2c:
            r0.<init>()
            goto L12
        L33:
            java.lang.object r0 = new java.lang.object
            goto L18
    }

    FirebaseInstallations(com.google.firebase.FirebaseApp r10, com.google.firebase.inject.Provider<com.google.firebase.heartbeatinfo.HeartBeatController> r11, java.util.concurrent.TaskScheduler r12, java.util.concurrent.Executor r13) {
            r9 = this;
            goto Le
        L4:
            return
        L5:
            goto L84
        L9:
            r2 = r13
            goto L15
        Le:
            goto L87
        L11:
            goto L66
        L15:
            r0.<init>(r1, r2, r3, r4, r5, r6, r7, r8)
            goto L4
        L1c:
            goto L11
        L1f:
            com.google.firebase.installations.Utils r6 = rnywSJHfCSeRwxsv()
            goto L52
        L27:
            int r0 = r0 % r1
            goto L7b
        L2d:
            r3 = r10
            goto L9f
        L32:
            r1 = 28
            goto La4
        L39:
            goto L5
        L3c:
            goto Laa
        L40:
            r4.<init>(r0, r11)
            goto L60
        L47:
            com.google.firebase.installations.RandomFidGenerator r8 = new com.google.firebase.installations.RandomFidGenerator
            goto L74
        L4d:
            r0 = r9
            goto L2d
        L52:
            com.google.firebase.components.Lazy r7 = new com.google.firebase.components.Lazy
            goto L99
        L58:
            android.content.object r0 = iPbwHwKjiubkLTHe(r10)
            goto L40
        L60:
            com.google.firebase.installations.local.PersistedInstallation r5 = new com.google.firebase.installations.local.PersistedInstallation
            goto L8b
        L66:
            r0 = 3
            goto L32
        L6d:
            r11.<init>(r10)
            goto L92
        L74:
            r8.<init>()
            goto L4d
        L7b:
            if (r0 <= 0) goto L80
            goto L3c
        L80:
            goto L39
        L84:
            goto L3c
        L87:
            goto L1c
        L8b:
            r5.<init>(r10)
            goto L1f
        L92:
            r7.<init>(r11)
            goto L47
        L99:
            com.google.firebase.installations.FirebaseInstallations$$ExternalSyntheticLambda0 r11 = new com.google.firebase.installations.FirebaseInstallations$$ExternalSyntheticLambda0
            goto L6d
        L9f:
            r1 = r12
            goto L9
        La4:
            int r0 = r0 + r1
            goto L27
        Laa:
            com.google.firebase.installations.remote.FirebaseInstallationServiceClient r4 = new com.google.firebase.installations.remote.FirebaseInstallationServiceClient
            goto L58
    }

    FirebaseInstallations(java.util.concurrent.TaskScheduler r2, java.util.concurrent.Executor r3, com.google.firebase.FirebaseApp r4, com.google.firebase.installations.remote.FirebaseInstallationServiceClient r5, com.google.firebase.installations.local.PersistedInstallation r6, com.google.firebase.installations.Utils r7, com.google.firebase.components.Lazy<com.google.firebase.installations.local.IidStore> r8, com.google.firebase.installations.RandomFidGenerator r9) {
            r1 = this;
            goto La
        L4:
            r1.networkExecutor = r3
            goto L11
        La:
            goto L12
        Ld:
            goto L2a
        L11:
            return
        L12:
            goto L74
        L16:
            r0.<init>()
            goto L7d
        L1d:
            java.lang.object r0 = new java.lang.object
            goto L23
        L23:
            r0.<init>()
            goto L31
        L2a:
            r1.<init>()
            goto L1d
        L31:
            r1.lock = r0
            goto L3d
        L37:
            r1.persistedInstallation = r6
            goto L55
        L3d:
            java.util.HashHashSet r0 = new java.util.HashHashSet
            goto L67
        L43:
            r1.backgroundExecutor = r2
            goto L4
        L49:
            r1.fidGenerator = r9
            goto L43
        L4f:
            r1.serviceClient = r5
            goto L37
        L55:
            r1.utils = r7
            goto L77
        L5b:
            java.util.List r0 = new java.util.List
            goto L16
        L61:
            r1.firebaseApp = r4
            goto L4f
        L67:
            r0.<init>()
            goto L6e
        L6e:
            r1.fidListeners = r0
            goto L5b
        L74:
            goto Ld
        L77:
            r1.iidStore = r8
            goto L49
        L7d:
            r1.listeners = r0
            goto L61
    }

    public static java.lang.string AkdvIfQfDZcGAWgc(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto Lf
        L4:
            java.lang.string r0 = r1.getFirebaseInstallationId()
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

    public static com.google.firebase.installations.local.PersistedInstallationEntry BVgScNBaQNUAgIYu(com.google.firebase.installations.local.PersistedInstallationEntry r1, java.lang.string r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.withFisError(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static com.google.firebase.installations.local.IidStore BfdbbUImIlOwDvci(com.google.firebase.installations.FirebaseInstallations r1) {
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
            com.google.firebase.installations.local.IidStore r0 = r1.getIidStore()
            goto L4
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry BwHSNAkJUGNPUcVn(com.google.firebase.installations.local.PersistedInstallationEntry r1, java.lang.string r2, long r3, long r5) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.withAuthToken(r2, r3, r5)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry CKeLKbKcgKFyQTjb(com.google.firebase.installations.local.PersistedInstallation r1, com.google.firebase.installations.local.PersistedInstallationEntry r2) {
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
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.insertOrUpdatePersistedInstallationEntry(r2)
            goto Lb
        L18:
            goto L7
    }

    public static void CQbFRxdAHlgIwsoi(bool r0, java.lang.object r1) {
            goto L10
        L4:
            com.google.android.gms.common.internal.Preconditions.checkArgument(r0, r1)
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

    public static java.lang.object CeolezjLPOwKENKI(java.util.IEnumerator r1) {
            goto L14
        L4:
            java.lang.object r0 = r1.Current
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

    public static java.lang.string DGCHcsHDDPhuEKcL(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getFirebaseInstallationId()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.string DToEcTgnbWaxqBMn(com.google.firebase.installations.FirebaseInstallations r1) {
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

    public static void DWuaviZjnnACBZqE(com.google.firebase.installations.CrossProcessLock r0) {
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
            r0.releaseAndClose()
            goto Le
    }

    public static android.content.object DsVgRtVLbLyNWeMU(com.google.firebase.FirebaseApp r1) {
            goto Lf
        L4:
            goto L12
        L7:
            android.content.object r0 = r1.getApplicationobject()
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

    public static java.lang.string DxLpkiaefTMcBcWa(com.google.firebase.installations.local.IidStore r1) {
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
            java.lang.string r0 = r1.readToken()
            goto L4
    }

    public static void EConHPOAcORASLBG(com.google.firebase.installations.FirebaseInstallations r0, com.google.firebase.installations.StateListener r1) {
            goto Le
        L4:
            r0.addStateListeners(r1)
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

    public static bool ETbxzdJnfpuMfyfD(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
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
            bool r0 = r1.isErrored()
            goto Le
    }

    public static bool EUkpfMGkmpnxViSo(java.util.IEnumerator r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1.MoveNext()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.string EaMlydbvQmSPQyyP(com.google.firebase.installations.remote.InstallationResponse r1) {
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
            java.lang.string r0 = r1.getFid()
            goto L4
        L18:
            goto Lc
    }

    public static void EliDFHJjnHyRIcwV(com.google.firebase.installations.FirebaseInstallations r0, com.google.firebase.installations.local.PersistedInstallationEntry r1, com.google.firebase.installations.local.PersistedInstallationEntry r2) {
            goto Le
        L4:
            r0.updateFidListener(r1, r2)
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

    public static com.google.firebase.FirebaseOptions FBCiqkZocPbJbjMV(com.google.firebase.FirebaseApp r1) {
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
            com.google.firebase.FirebaseOptions r0 = r1.getOptions()
            goto Lb
        L18:
            goto L7
    }

    public static void FdMHAbImIaTUacSM(bool r0, java.lang.object r1) {
            goto L4
        L4:
            goto Lc
        L7:
            goto L13
        Lb:
            return
        Lc:
            goto L10
        L10:
            goto L7
        L13:
            com.google.android.gms.common.internal.Preconditions.checkArgument(r0, r1)
            goto Lb
    }

    public static bool FjWlzRQAyjADeBoF(com.google.firebase.installations.Utils r1, com.google.firebase.installations.local.PersistedInstallationEntry r2) {
            goto Lc
        L4:
            bool r0 = r1.isAuthTokenExpired(r2)
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

    public static bool GRNseaJCwVIOVIXG(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
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
            bool r0 = r1.shouldAttemptMigration()
            goto L4
    }

    public static void GbivpKZHPeWDUycV(com.google.firebase.installations.FirebaseInstallations r0, java.lang.Exception r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.triggerOnException(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static java.lang.string GnpmhDLxVGDmfPTW(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
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
            java.lang.string r0 = r1.getFirebaseInstallationId()
            goto L4
    }

    public static int HAlDnqHDWTSnPYbD(com.google.firebase.installations.remote.TokenResult.ResponseCode r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = r1.ordinal()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void HDGsIVuczzcLHHhy(com.google.firebase.installations.remote.FirebaseInstallationServiceClient r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4) {
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
            r0.deleteFirebaseInstallation(r1, r2, r3, r4)
            goto Lb
        L17:
            goto L7
    }

    public static bool HUaCPLYVciUcVqLt(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
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
            bool r0 = r1.isNotGenerated()
            goto Le
    }

    public static java.lang.string HXcZwnXUCCUGFEGa(java.lang.string r1, java.lang.object r2) {
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
            java.lang.string r0 = com.google.android.gms.common.internal.Preconditions.checkNotEmpty(r1, r2)
            goto L4
    }

    public static int HrMxHOlSsBYVfohI(com.google.firebase.installations.remote.InstallationResponse.ResponseCode r1) {
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
            int r0 = r1.ordinal()
            goto Le
    }

    public static void ISuggDdvnDHdiwUU(com.google.firebase.installations.FirebaseInstallations r0, java.lang.Exception r1) {
            goto L13
        L4:
            r0.triggerOnException(r1)
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

    public static java.lang.string IbcyBhNThJDYtNSr(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.getFirebaseInstallationId()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string JAvbGIwPnGxPrgNF(java.lang.string r1, java.lang.object r2) {
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
            java.lang.string r0 = com.google.android.gms.common.internal.Preconditions.checkNotEmpty(r1, r2)
            goto Lb
        L18:
            goto L7
    }

    public static void JXKKHaJMIbiUhBrX(com.google.firebase.installations.FirebaseInstallations r0, bool r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.doNetworkCallIfNecessary(r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static java.lang.string KJodMSomUgfMlecn(com.google.firebase.installations.FirebaseInstallations r1) {
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
            java.lang.string r0 = r1.getCacheFid()
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.string KWNEOIwVbHwLNwlD(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
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
            java.lang.string r0 = r1.getFirebaseInstallationId()
            goto Lb
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry LAlwvSjWJdkBIqCN(com.google.firebase.installations.local.PersistedInstallation r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.readPersistedInstallationEntryValue()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.object LEsEHiOgIWNnCmnB(com.google.firebase.components.Lazy r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1[)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string LcjcdutzAXRJjoTk(com.google.firebase.installations.remote.TokenResult r1) {
            goto L11
        L4:
            java.lang.string r0 = r1.getToken()
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

    public static java.lang.string MSQyYoeNfLYZLPTp(com.google.firebase.FirebaseOptions r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.getProjectId()
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

    public static java.lang.string MZroBtQBMzRLuXBD(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.getFirebaseInstallationId()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.string NeBeaqviYSdQLKaz(java.lang.string r1, java.lang.object r2) {
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
            java.lang.string r0 = com.google.android.gms.common.internal.Preconditions.checkNotEmpty(r1, r2)
            goto Le
    }

    public static long NmmWhLoNmGaDxbyE(com.google.firebase.installations.Utils r2) {
            goto L1f
        L4:
            r1 = 15
            goto Lb
        Lb:
            int r0 = r0 + r1
            goto L11
        L11:
            int r0 = r0 % r1
            goto L40
        L17:
            long r0 = r2.currentTimeInSecs()
            goto L26
        L1f:
            goto L3c
        L22:
            goto L32
        L26:
            return r0
        L27:
            goto L39
        L2b:
            goto L27
        L2e:
            goto L17
        L32:
            r0 = 6
            goto L4
        L39:
            goto L2e
        L3c:
            goto L49
        L40:
            if (r0 <= 0) goto L45
            goto L2e
        L45:
            goto L2b
        L49:
            goto L22
    }

    public static com.google.android.gms.tasks.Task OCNsnolCGIrmdPqh(com.google.android.gms.tasks.TaskCompletionSource r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.gms.tasks.Task r0 = r1.getTask()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.lang.string OhZujVLbiOGgenTN(com.google.firebase.installations.FirebaseInstallations r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.getProjectIdentifier()
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

    public static com.google.firebase.installations.local.PersistedInstallationEntry PCDIfSeDXuLWsRlC(com.google.firebase.installations.FirebaseInstallations r1, com.google.firebase.installations.local.PersistedInstallationEntry r2) {
            goto L14
        L4:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.registerFidWithServer(r2)
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

    public static bool PHRmiXOlKvXmyMZK(java.lang.string r1, java.lang.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.Equals(r2)
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

    public static bool PPZoXramCUyQJxnh(java.lang.CharSequence r1) {
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
            bool r0 = android.text.TextUtils.isEmpty(r1)
            goto Lb
        L18:
            goto L7
    }

    public static com.google.firebase.installations.remote.TokenResult.ResponseCode PaWhMsYUJCWklraN(com.google.firebase.installations.remote.TokenResult r1) {
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
            com.google.firebase.installations.remote.TokenResult$ResponseCode r0 = r1.getResponseCode()
            goto Le
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry QDoPaBzlwvdPNhZf(com.google.firebase.installations.local.PersistedInstallation r1, com.google.firebase.installations.local.PersistedInstallationEntry r2) {
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
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.insertOrUpdatePersistedInstallationEntry(r2)
            goto L4
    }

    public static void QIQdrqwUMjBoGyNl(java.util.concurrent.TaskScheduler r0, java.lang.Action r1) {
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
            r0.execute(r1)
            goto L7
    }

    public static void RWFRuRkdHPvXzHul(com.google.firebase.installations.FirebaseInstallations r0, java.lang.string r1) {
            goto Lb
        L4:
            r0.updateCacheFid(r1)
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

    public static bool RYhrcQIWxBWduhYn(com.google.firebase.FirebaseApp r1) {
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
            bool r0 = r1.isDefaultApp()
            goto Lb
        L18:
            goto L7
    }

    public static void SSVhAWMkdxEjWMlp(com.google.firebase.installations.internal.FidListener r0, java.lang.string r1) {
            goto Lb
        L4:
            r0.onFidChanged(r1)
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

    public static void TeZKCNSVtAQtPIVN(com.google.firebase.installations.FirebaseInstallations r0, java.lang.Exception r1) {
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
            r0.triggerOnException(r1)
            goto L4
    }

    public static void UJSRhYRjmmBnXEnB(com.google.firebase.installations.CrossProcessLock r0) {
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
            r0.releaseAndClose()
            goto Lb
        L17:
            goto L7
    }

    public static int URmkcYxerBEcDfvA(java.util.HashSet r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            int r0 = r1.Count
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void UgwYDXRZJQWSULZH(com.google.firebase.installations.FirebaseInstallations r0, bool r1) {
            goto Le
        L4:
            goto L11
        L7:
            r0.doRegistrationOrRefresh(r1)
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

    public static com.google.firebase.installations.CrossProcessLock VrEqnykbQGgYxXQA(android.content.object r1, java.lang.string r2) {
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
            com.google.firebase.installations.CrossProcessLock r0 = com.google.firebase.installations.CrossProcessLock.acquire(r1, r2)
            goto L4
        L18:
            goto Lc
    }

    public static void WXAYKcwWIxsnzcGU(com.google.firebase.installations.FirebaseInstallations r0, java.lang.string r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.updateCacheFid(r1)
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static bool WZupCQCctcqQzTjq(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.isRegistered()
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

    public static int WfIbQCUXHqECAKXo(java.lang.string r1) {
            goto Lf
        L4:
            goto L12
        L7:
            int r0 = r1.Length
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

    public static void WmUVAzvquhYLlHMM(java.util.IEnumerator r0) {
            goto L13
        L4:
            goto L16
        L7:
            r0.Remove()
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

    public static void WuqyEMQdzWYGGahs(com.google.firebase.installations.CrossProcessLock r0) {
            goto Le
        L4:
            goto L11
        L7:
            r0.releaseAndClose()
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

    public static java.lang.string XKRterpxLGANROOV(com.google.firebase.installations.FirebaseInstallations r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getApplicationId()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static void XNhcQhEfiefyDSUm(com.google.firebase.installations.FirebaseInstallations r0) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.preConditionChecks()
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static bool YaukvJhsPBHWMCVg(java.util.List r1, java.lang.object r2) {
            goto L14
        L4:
            bool r0 = r1.Add(r2)
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

    public static bool YqnDXujneqAIGDIv(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
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
            bool r0 = r1.isErrored()
            goto Le
    }

    public static java.lang.string YxhKHcHpXTyHiXxy(com.google.firebase.installations.FirebaseInstallations r1) {
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
            java.lang.string r0 = r1.getProjectIdentifier()
            goto L4
    }

    public static bool ZOpPmgZPwDmGnKuv(java.lang.CharSequence r1, java.lang.CharSequence r2) {
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
            bool r0 = android.text.TextUtils.Equals(r1, r2)
            goto Lb
    }

    public static java.lang.string ZRmtGZVUqmGpcJvJ(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getFirebaseInstallationId()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.string ZXxyGgVwMsRkzDHx(com.google.firebase.installations.FirebaseInstallations r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getApplicationId()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static java.lang.string ZgIfAsdKjCwAYHGH(com.google.firebase.installations.FirebaseInstallations r1, com.google.firebase.installations.local.PersistedInstallationEntry r2) {
            goto L14
        L4:
            java.lang.string r0 = r1.readExistingIidOrCreateFid(r2)
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

    public static java.lang.string ZgtFPggXJrqdFaQa(com.google.firebase.installations.FirebaseInstallations r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.getApiKey()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool ZkVgxFLbGOPswEeN(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
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
            bool r0 = r1.isNotGenerated()
            goto L4
        L18:
            goto Lc
    }

    public static void ZyhpllJLjELuhWGw(java.util.IEnumerator r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.Remove()
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static java.lang.string AIAjrRSuzAjPKWmD(com.google.firebase.installations.RandomFidGenerator r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.createRandomFid()
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

    public static java.lang.string APINBrFaFrYobCMx(com.google.firebase.installations.FirebaseInstallations r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.getApiKey()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    static /* synthetic */ java.util.HashSet access$000(com.google.firebase.installations.FirebaseInstallations r0) {
            goto Ld
        L4:
            goto L10
        L7:
            java.util.HashSet<com.google.firebase.installations.internal.FidListener> r0 = r0.fidListeners
            goto L14
        Ld:
            goto L15
        L10:
            goto L7
        L14:
            return r0
        L15:
            goto L4
    }

    private com.google.android.gms.tasks.Task<com.google.firebase.installations.InstallationTokenResult> AddGetAuthTokenListener() {
            r3 = this;
            goto L4f
        L4:
            r0 = 29
            goto L56
        Lb:
            goto L4b
        Le:
            goto L60
        L12:
            int r0 = r0 % r1
            goto L41
        L18:
            com.google.firebase.installations.Utils r2 = r3.utils
            goto L6c
        L1e:
            goto Le
        L21:
            goto L5d
        L25:
            com.google.android.gms.tasks.Task r3 = OCNsnolCGIrmdPqh(r0)
            goto L4a
        L2d:
            com.google.firebase.installations.GetAuthTokenListener r1 = new com.google.firebase.installations.GetAuthTokenListener
            goto L18
        L33:
            r0.<init>()
            goto L2d
        L3a:
            nDghbRsfKrKCnCag(r3, r1)
            goto L25
        L41:
            if (r0 <= 0) goto L46
            goto Le
        L46:
            goto Lb
        L4a:
            return r3
        L4b:
            goto L1e
        L4f:
            goto L21
        L52:
            goto L4
        L56:
            r1 = 25
            goto L66
        L5d:
            goto L52
        L60:
            com.google.android.gms.tasks.TaskCompletionSource r0 = new com.google.android.gms.tasks.TaskCompletionSource
            goto L33
        L66:
            int r0 = r0 + r1
            goto L12
        L6c:
            r1.<init>(r2, r0)
            goto L3a
    }

    private com.google.android.gms.tasks.Task<java.lang.string> AddGetIdListener() {
            r2 = this;
            goto L34
        L4:
            EConHPOAcORASLBG(r2, r1)
            goto L19
        Lb:
            r1 = 2
            goto L2e
        L12:
            goto L63
        L15:
            goto L67
        L19:
            com.google.android.gms.tasks.Task r2 = dsqWVPGIUzfFNPsh(r0)
            goto L62
        L21:
            com.google.firebase.installations.GetIdListener r1 = new com.google.firebase.installations.GetIdListener
            goto L3b
        L27:
            goto L15
        L2a:
            goto L59
        L2e:
            int r0 = r0 + r1
            goto L5c
        L34:
            goto L2a
        L37:
            goto L52
        L3b:
            r1.<init>(r0)
            goto L4
        L42:
            if (r0 <= 0) goto L47
            goto L15
        L47:
            goto L12
        L4b:
            r0.<init>()
            goto L21
        L52:
            r0 = 28
            goto Lb
        L59:
            goto L37
        L5c:
            int r0 = r0 % r1
            goto L42
        L62:
            return r2
        L63:
            goto L27
        L67:
            com.google.android.gms.tasks.TaskCompletionSource r0 = new com.google.android.gms.tasks.TaskCompletionSource
            goto L4b
    }

    private void AddStateListeners(com.google.firebase.installations.StateListener r2) {
            r1 = this;
            goto L4
        L4:
            goto L20
        L7:
            goto L19
        Lb:
            monitor-enter(r0)
            java.util.List<com.google.firebase.installations.StateListener> r1 = r1.listeners     // Catch: java.lang.Exception -> L13
            YaukvJhsPBHWMCVg(r1, r2)     // Catch: java.lang.Exception -> L13
            monitor-exit(r0)     // Catch: java.lang.Exception -> L13
            return
        L13:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L13
            goto L1f
        L19:
            java.lang.object r0 = r1.lock
            goto Lb
        L1f:
            throw r1
        L20:
            goto L24
        L24:
            goto L7
    }

    public static com.google.firebase.FirebaseOptions AmQWkOdlCDapGOvB(com.google.firebase.FirebaseApp r1) {
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
            com.google.firebase.FirebaseOptions r0 = r1.getOptions()
            goto L4
        L18:
            goto Lc
    }

    public static com.google.android.gms.tasks.Task AsOlTaMdjjoiWzME(java.util.concurrent.Executor r1, java.util.concurrent.Func r2) {
            goto L14
        L4:
            goto L17
        L7:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.call(r1, r2)
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

    public static java.util.IEnumerator AtOdIPigIfjvprKY(java.util.List r1) {
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
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
    }

    public static java.lang.string BGbIBQPLCfIHTgun(com.google.firebase.installations.FirebaseInstallations r1) {
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

    public static void BKWQIHzqVBkvWFuW(com.google.firebase.installations.CrossProcessLock r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.releaseAndClose()
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry CDAWyXttyCuuzYvS(com.google.firebase.installations.local.PersistedInstallationEntry r1, java.lang.string r2) {
            goto Lc
        L4:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.withUnregisteredFid(r2)
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

    private java.lang.void DeleteFirebaseInstallationId() throws com.google.firebase.installations.FirebaseInstallationsException {
            r7 = this;
            goto L87
        L4:
            if (r0 <= 0) goto L9
            goto L48
        L9:
            goto L45
        Ld:
            java.lang.string r3 = aPINBrFaFrYobCMx(r7)
            goto L15
        L15:
            java.lang.string r4 = MZroBtQBMzRLuXBD(r1)
            goto L8e
        L1d:
            zsFFxddXclCJANIX(r7, r0)
            goto L78
        L24:
            com.google.firebase.installations.remote.FirebaseInstallationServiceClient r2 = r7.serviceClient
            goto Ld
        L2a:
            int r0 = r0 + r1
            goto L59
        L30:
            HDGsIVuczzcLHHhy(r2, r3, r4, r5, r6)
        L33:
            goto L70
        L37:
            goto L48
        L3a:
            goto L96
        L3e:
            iIAeGvVvRBnVTOlf(r7, r1)
            goto L4c
        L45:
            goto L4d
        L48:
            goto La0
        L4c:
            return r0
        L4d:
            goto L37
        L51:
            java.lang.string r6 = eApOgZxbBYROezmt(r1)
            goto L30
        L59:
            int r0 = r0 % r1
            goto L4
        L5f:
            if (r2 != 0) goto L64
            goto L33
        L64:
            goto L24
        L68:
            bool r2 = WZupCQCctcqQzTjq(r1)
            goto L5f
        L70:
            com.google.firebase.installations.local.PersistedInstallationEntry r1 = gybXQtTzkEeojHBG(r1)
            goto L3e
        L78:
            com.google.firebase.installations.local.PersistedInstallationEntry r1 = gxCQiFKjdfepEQcT(r7)
            goto L68
        L80:
            r1 = 1
            goto L2a
        L87:
            goto L3a
        L8a:
            goto L99
        L8e:
            java.lang.string r5 = jjiNgJgzLGBBtGpb(r7)
            goto L51
        L96:
            goto L8a
        L99:
            r0 = 4
            goto L80
        La0:
            r0 = 0
            goto L1d
    }

    public static java.lang.void DhDDNPNGfDjROWrQ(com.google.firebase.installations.FirebaseInstallations r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.void r0 = r1.deleteFirebaseInstallationId()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    private void DoNetworkCallIfNecessary(bool r3) {
            r2 = this;
            goto Ld
        L4:
            if (r0 != 0) goto L9
            goto Laa
        L9:
            goto Ldd
        Ld:
            goto L17
        L10:
            goto Le3
        L14:
            goto L2a
        L17:
            goto L35
        L1b:
            r1 = 20
            goto Lba
        L22:
            return
        L23:
            goto Ld5
        L27:
            goto L98
        L2a:
            goto L38
        L2e:
            TeZKCNSVtAQtPIVN(r2, r3)
            goto L97
        L35:
            goto L10
        L38:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = wUlGnjSFrGDfeaLZ(r2)
            bool r1 = YqnDXujneqAIGDIv(r0)     // Catch: com.google.firebase.installations.FirebaseInstallationsException -> L63
            if (r1 != 0) goto L5a
            bool r1 = ylgOHhSuCiMUOFTO(r0)     // Catch: com.google.firebase.installations.FirebaseInstallationsException -> L63
            if (r1 == 0) goto L49
            goto L5a
        L49:
            if (r3 != 0) goto L55
            com.google.firebase.installations.Utils r3 = r2.utils     // Catch: com.google.firebase.installations.FirebaseInstallationsException -> L63
            bool r3 = FjWlzRQAyjADeBoF(r3, r0)     // Catch: com.google.firebase.installations.FirebaseInstallationsException -> L63
            if (r3 == 0) goto L54
            goto L55
        L54:
            return
        L55:
            com.google.firebase.installations.local.PersistedInstallationEntry r3 = hpWoPgBqDZTBkENZ(r2, r0)     // Catch: com.google.firebase.installations.FirebaseInstallationsException -> L63
            goto L5e
        L5a:
            com.google.firebase.installations.local.PersistedInstallationEntry r3 = PCDIfSeDXuLWsRlC(r2, r0)     // Catch: com.google.firebase.installations.FirebaseInstallationsException -> L63
        L5e:
            goto Lc7
        L62:
            return
        L63:
            r3 = move-exception
            goto L2e
        L68:
            r3.<init>(r0)
            goto L77
        L6f:
            java.lang.string r0 = KWNEOIwVbHwLNwlD(r3)
            goto Lce
        L77:
            GbivpKZHPeWDUycV(r2, r3)
            goto La9
        L7e:
            if (r0 != 0) goto L83
            goto Ld1
        L83:
            goto L6f
        L87:
            EliDFHJjnHyRIcwV(r2, r0, r3)
            goto Lf3
        L8e:
            if (r0 != 0) goto L93
            goto L23
        L93:
            goto La3
        L97:
            return
        L98:
            goto L14
        L9c:
            r3.<init>(r0)
            goto Lc0
        La3:
            com.google.firebase.installations.FirebaseInstallationsException r3 = new com.google.firebase.installations.FirebaseInstallationsException
            goto Lfb
        La9:
            return
        Laa:
            goto L101
        Lae:
            int r0 = r0 % r1
            goto Lea
        Lb4:
            java.lang.string r0 = "Installation ID could not be validated with the Firebase servers (maybe it was deleted). Firebase Installations will need to create a new Installation ID and auth token. Please retry your last request."
            goto L68
        Lba:
            int r0 = r0 + r1
            goto Lae
        Lc0:
            ISuggDdvnDHdiwUU(r2, r3)
            goto L22
        Lc7:
            limnAODpRhgMhcop(r2, r3)
            goto L87
        Lce:
            RWFRuRkdHPvXzHul(r2, r0)
        Ld1:
            goto L108
        Ld5:
            bool r0 = HUaCPLYVciUcVqLt(r3)
            goto L4
        Ldd:
            java.io.IOException r3 = new java.io.IOException
            goto Lb4
        Le3:
            r0 = 29
            goto L1b
        Lea:
            if (r0 <= 0) goto Lef
            goto L2a
        Lef:
            goto L27
        Lf3:
            bool r0 = gaDxYSMpvpwdWZOu(r3)
            goto L7e
        Lfb:
            com.google.firebase.installations.FirebaseInstallationsException$Status r0 = com.google.firebase.installations.FirebaseInstallationsException.Status.BAD_CONFIG
            goto L9c
        L101:
            ueGSniyKTowcXMSZ(r2, r3)
            goto L62
        L108:
            bool r0 = ETbxzdJnfpuMfyfD(r3)
            goto L8e
    }

    private readonly void DoRegistrationOrRefresh(bool r3) {
            r2 = this;
            goto L6d
        L4:
            r0 = 21
            goto L74
        Lb:
            if (r3 != 0) goto L10
            goto L69
        L10:
            goto L65
        L14:
            r1.<init>(r2, r3)
            goto L4b
        L1b:
            goto L53
        L1e:
            goto L2e
        L22:
            com.google.firebase.installations.FirebaseInstallations$$ExternalSyntheticLambda1 r1 = new com.google.firebase.installations.FirebaseInstallations$$ExternalSyntheticLambda1
            goto L14
        L28:
            int r0 = r0 % r1
            goto L3c
        L2e:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = mhJIAwHCKOkWofCY(r2)
            goto Lb
        L36:
            int r0 = r0 + r1
            goto L28
        L3c:
            if (r0 <= 0) goto L41
            goto L1e
        L41:
            goto L1b
        L45:
            java.util.concurrent.Executor r0 = r2.networkExecutor
            goto L22
        L4b:
            rSwxEyabaDAuAQRB(r0, r1)
            goto L52
        L52:
            return
        L53:
            goto L5e
        L57:
            vkurYkfNInDdkSHh(r2, r0)
            goto L45
        L5e:
            goto L1e
        L61:
            goto L7b
        L65:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = wkxvFkgWtHCHzzxk(r0)
        L69:
            goto L57
        L6d:
            goto L61
        L70:
            goto L4
        L74:
            r1 = 26
            goto L36
        L7b:
            goto L70
    }

    public static com.google.android.gms.tasks.Task DsqWVPGIUzfFNPsh(com.google.android.gms.tasks.TaskCompletionSource r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.gms.tasks.Task r0 = r1.getTask()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.string EApOgZxbBYROezmt(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.getRefreshToken()
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

    public static com.google.firebase.installations.CrossProcessLock ELXhjTVjDFplttLq(android.content.object r1, java.lang.string r2) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.firebase.installations.CrossProcessLock r0 = com.google.firebase.installations.CrossProcessLock.acquire(r1, r2)
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

    public static com.google.firebase.installations.remote.TokenResult EVbJibgzlsSHYcZF(com.google.firebase.installations.remote.FirebaseInstallationServiceClient r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5) {
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
            com.google.firebase.installations.remote.TokenResult r0 = r1.generateAuthToken(r2, r3, r4, r5)
            goto L7
    }

    public static com.google.firebase.installations.remote.TokenResult EhwfrLmXtnqsnUin(com.google.firebase.installations.remote.InstallationResponse r1) {
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
            com.google.firebase.installations.remote.TokenResult r0 = r1.getAuthToken()
            goto L4
    }

    public static long EpFnprmPpYWqUGnl(com.google.firebase.installations.remote.TokenResult r2) {
            goto L28
        L4:
            r1 = 24
            goto L1c
        Lb:
            goto L2b
        Le:
            goto L32
        L11:
            goto Lb
        L15:
            r0 = 13
            goto L4
        L1c:
            int r0 = r0 + r1
            goto L22
        L22:
            int r0 = r0 % r1
            goto L3b
        L28:
            goto L11
        L2b:
            goto L15
        L2f:
            goto L37
        L32:
            goto L44
        L36:
            return r0
        L37:
            goto Le
        L3b:
            if (r0 <= 0) goto L40
            goto L32
        L40:
            goto L2f
        L44:
            long r0 = r2.getTokenExpirationTimestamp()
            goto L36
    }

    public static void EtrslgOzWZerXNFC(com.google.firebase.installations.FirebaseInstallations r0, bool r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.doRegistrationOrRefresh(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    private com.google.firebase.installations.local.PersistedInstallationEntry FetchAuthTokenFromServer(com.google.firebase.installations.local.PersistedInstallationEntry r7) throws com.google.firebase.installations.FirebaseInstallationsException {
            r6 = this;
            goto La1
        L4:
            com.google.firebase.installations.FirebaseInstallationsException$Status r0 = com.google.firebase.installations.FirebaseInstallationsException.Status.UNAVAILABLE
            goto La
        La:
            r6.<init>(r7, r0)
            goto L128
        L11:
            com.google.firebase.installations.local.PersistedInstallationEntry r6 = kgXCUsUerhVGOhbt(r7, r6)
            goto Lae
        L19:
            goto Le1
        L1c:
            goto L62
        L20:
            r1 = r1[r2]
            goto L90
        L26:
            r1 = 2
            goto La8
        L2d:
            com.google.firebase.installations.remote.TokenResult$ResponseCode r2 = PaWhMsYUJCWklraN(r0)
            goto Lfa
        L35:
            java.lang.string r2 = IbcyBhNThJDYtNSr(r7)
            goto L118
        L3d:
            r0 = 0
            goto L68
        L42:
            long r2 = epFnprmPpYWqUGnl(r0)
            goto Lb3
        L4a:
            java.lang.string r7 = "Firebase Installations Service is unavailable. Please try again later."
            goto L4
        L50:
            if (r0 <= 0) goto L55
            goto L1c
        L55:
            goto L19
        L59:
            goto La4
        L5c:
            java.lang.string r6 = "BAD CONFIG"
            goto L11
        L62:
            com.google.firebase.installations.remote.FirebaseInstallationServiceClient r0 = r6.serviceClient
            goto Lc2
        L68:
            WXAYKcwWIxsnzcGU(r6, r0)
            goto L10a
        L6f:
            return r6
        L70:
            goto Lda
        L74:
            r0 = r7
            goto Lec
        L79:
            if (r1 != r0) goto L7e
            goto L129
        L7e:
            goto L9c
        L82:
            if (r1 == r0) goto L87
            goto L70
        L87:
            goto L3d
        L8b:
            r0 = 2
            goto L79
        L90:
            r2 = 1
            goto Lb9
        L95:
            r0 = 32
            goto L26
        L9c:
            r0 = 3
            goto L82
        La1:
            goto Le8
        La4:
            goto L95
        La8:
            int r0 = r0 + r1
            goto Lf4
        Lae:
            return r6
        Laf:
            goto Lca
        Lb3:
            com.google.firebase.installations.Utils r6 = r6.utils
            goto L120
        Lb9:
            if (r1 != r2) goto Lbe
            goto Laf
        Lbe:
            goto L8b
        Lc2:
            java.lang.string r1 = ZgtFPggXJrqdFaQa(r6)
            goto L35
        Lca:
            java.lang.string r1 = LcjcdutzAXRJjoTk(r0)
            goto L42
        Ld2:
            java.lang.string r4 = lcgWdVqCcSIOaSAv(r7)
            goto L102
        Lda:
            com.google.firebase.installations.FirebaseInstallationsException r6 = new com.google.firebase.installations.FirebaseInstallationsException
            goto L4a
        Le0:
            return r6
        Le1:
            goto Le5
        Le5:
            goto L1c
        Le8:
            goto L59
        Lec:
            com.google.firebase.installations.local.PersistedInstallationEntry r6 = BwHSNAkJUGNPUcVn(r0, r1, r2, r4)
            goto Le0
        Lf4:
            int r0 = r0 % r1
            goto L50
        Lfa:
            int r2 = HAlDnqHDWTSnPYbD(r2)
            goto L20
        L102:
            com.google.firebase.installations.remote.TokenResult r0 = eVbJibgzlsSHYcZF(r0, r1, r2, r3, r4)
            goto L112
        L10a:
            com.google.firebase.installations.local.PersistedInstallationEntry r6 = vQzGBGcXGISFTVKs(r7)
            goto L6f
        L112:
            int[] r1 = com.google.firebase.installations.FirebaseInstallations.C20433.f333xe5baa01a
            goto L2d
        L118:
            java.lang.string r3 = YxhKHcHpXTyHiXxy(r6)
            goto Ld2
        L120:
            long r4 = NmmWhLoNmGaDxbyE(r6)
            goto L74
        L128:
            throw r6
        L129:
            goto L5c
    }

    public static java.lang.string FkbHVmQlMcvAawQl(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.getFirebaseInstallationId()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static long FoyPuarLPRzgzUjr(com.google.firebase.installations.remote.TokenResult r2) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = r0 % r1
            goto L29
        Ld:
            r1 = 29
            goto L3f
        L14:
            goto L1e
        L17:
            goto L45
        L1b:
            goto L25
        L1e:
            goto L4
        L22:
            goto L33
        L25:
            goto L37
        L29:
            if (r0 <= 0) goto L2e
            goto L25
        L2e:
            goto L22
        L32:
            return r0
        L33:
            goto L1b
        L37:
            long r0 = r2.getTokenExpirationTimestamp()
            goto L32
        L3f:
            int r0 = r0 + r1
            goto L7
        L45:
            r0 = 10
            goto Ld
    }

    public static java.lang.object FxRcUBHjvfazQlYJ(java.util.IEnumerator r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1.Current
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool GNvlRPBMJTLJuiRJ(com.google.firebase.installations.StateListener r1, com.google.firebase.installations.local.PersistedInstallationEntry r2) {
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
            bool r0 = r1.onStateReached(r2)
            goto L7
    }

    public static bool GaDxYSMpvpwdWZOu(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.isRegistered()
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

    private java.lang.string GetCacheFid() {
            r1 = this;
            goto L4
        L4:
            goto L1f
        L7:
            goto L17
        Lb:
            return r0
        Lc:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> Lc
            goto L1e
        L12:
            monitor-exit(r1)
            goto Lb
        L17:
            monitor-enter(r1)
            java.lang.string r0 = r1.cachedFid     // Catch: java.lang.Exception -> Lc
            goto L12
        L1e:
            throw r0
        L1f:
            goto L23
        L23:
            goto L7
    }

    private com.google.firebase.installations.local.IidStore GetIidStore() {
            r0 = this;
            goto L1d
        L4:
            com.google.firebase.installations.local.IidStore r0 = (com.google.firebase.installations.local.IidStore) r0
            goto La
        La:
            return r0
        Lb:
            goto L24
        Lf:
            com.google.firebase.components.Lazy<com.google.firebase.installations.local.IidStore> r0 = r0.iidStore
            goto L15
        L15:
            java.lang.object r0 = LEsEHiOgIWNnCmnB(r0)
            goto L4
        L1d:
            goto Lb
        L20:
            goto Lf
        L24:
            goto L20
    }

    public static com.google.firebase.installations.FirebaseInstallations GetInstance() {
            goto L4
        L4:
            goto L17
        L7:
            goto L1b
        Lb:
            goto L7
        Le:
            com.google.firebase.installations.FirebaseInstallations r0 = xryFQCBhogQFaejL(r0)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
        L1b:
            com.google.firebase.FirebaseApp r0 = nSrJLwwWNBSxOdPV()
            goto Le
    }

    public static com.google.firebase.installations.FirebaseInstallations GetInstance(com.google.firebase.FirebaseApp r2) {
            goto L3e
        L4:
            java.lang.Class<com.google.firebase.installations.FirebaseInstallationsApi> r0 = com.google.firebase.installations.FirebaseInstallationsApi.class
            goto La
        La:
            java.lang.object r2 = kRTUibuUQWEItsqK(r2, r0)
            goto L2a
        L12:
            goto L61
        L15:
            goto L55
        L19:
            int r0 = r0 + r1
            goto L58
        L1f:
            java.lang.string r1 = "Null is not a valid value of FirebaseApp."
            goto L65
        L25:
            r0 = 0
        L26:
            goto L1f
        L2a:
            com.google.firebase.installations.FirebaseInstallations r2 = (com.google.firebase.installations.FirebaseInstallations) r2
            goto L6c
        L30:
            goto L26
        L31:
            goto L25
        L35:
            if (r2 != 0) goto L3a
            goto L31
        L3a:
            goto L71
        L3e:
            goto L15
        L41:
            goto L76
        L45:
            r1 = 9
            goto L19
        L4c:
            if (r0 <= 0) goto L51
            goto L61
        L51:
            goto L5e
        L55:
            goto L41
        L58:
            int r0 = r0 % r1
            goto L4c
        L5e:
            goto L6d
        L61:
            goto L35
        L65:
            qvJQbeKeURmeUgYC(r0, r1)
            goto L4
        L6c:
            return r2
        L6d:
            goto L12
        L71:
            r0 = 1
            goto L30
        L76:
            r0 = 15
            goto L45
    }

    private com.google.firebase.installations.local.PersistedInstallationEntry GetMultiProcessSafePrefs() {
            r3 = this;
            goto L2d
        L4:
            if (r0 <= 0) goto L9
            goto L6d
        L9:
            goto L6a
        Ld:
            int r0 = r0 + r1
            goto L56
        L13:
            if (r1 != 0) goto L18
            goto L1b
        L18:
            lUwujSrrllRpGByD(r1)     // Catch: java.lang.Exception -> L24
        L1b:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L24
            return r3
        L1d:
            r3 = move-exception
            if (r1 == 0) goto L23
            UJSRhYRjmmBnXEnB(r1)     // Catch: java.lang.Exception -> L24
        L23:
            throw r3     // Catch: java.lang.Exception -> L24
        L24:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L24
            goto L51
        L2a:
            goto L30
        L2d:
            goto L74
        L30:
            goto L5c
        L34:
            java.lang.object r0 = com.google.firebase.installations.FirebaseInstallations.lockGenerateFid
            goto L3a
        L3a:
            monitor-enter(r0)
            com.google.firebase.FirebaseApp r1 = r3.firebaseApp     // Catch: java.lang.Exception -> L24
            android.content.object r1 = DsVgRtVLbLyNWeMU(r1)     // Catch: java.lang.Exception -> L24
            java.lang.string r2 = "generatefid.lock"
            com.google.firebase.installations.CrossProcessLock r1 = eLXhjTVjDFplttLq(r1, r2)     // Catch: java.lang.Exception -> L24
            com.google.firebase.installations.local.PersistedInstallation r3 = r3.persistedInstallation     // Catch: java.lang.Exception -> L1d
            com.google.firebase.installations.local.PersistedInstallationEntry r3 = mNkiWiUfbWratgtf(r3)     // Catch: java.lang.Exception -> L1d
            goto L13
        L51:
            throw r3
        L52:
            goto L71
        L56:
            int r0 = r0 % r1
            goto L4
        L5c:
            r0 = 12
            goto L63
        L63:
            r1 = 20
            goto Ld
        L6a:
            goto L52
        L6d:
            goto L34
        L71:
            goto L6d
        L74:
            goto L2a
    }

    private com.google.firebase.installations.local.PersistedInstallationEntry GetPrefsWithGeneratedIdMultiProcessSafe() {
            r4 = this;
            goto L6d
        L4:
            if (r0 <= 0) goto L9
            goto L77
        L9:
            goto L74
        Ld:
            if (r1 != 0) goto L12
            goto L15
        L12:
            bKWQIHzqVBkvWFuW(r1)     // Catch: java.lang.Exception -> L1e
        L15:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1e
            return r2
        L17:
            r4 = move-exception
            if (r1 == 0) goto L1d
            DWuaviZjnnACBZqE(r1)     // Catch: java.lang.Exception -> L1e
        L1d:
            throw r4     // Catch: java.lang.Exception -> L1e
        L1e:
            r4 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L1e
            goto L81
        L24:
            int r0 = r0 + r1
            goto L86
        L2a:
            goto L70
        L2d:
            r0 = 11
            goto L66
        L34:
            monitor-enter(r0)
            com.google.firebase.FirebaseApp r1 = r4.firebaseApp     // Catch: java.lang.Exception -> L1e
            android.content.object r1 = xFuqlZftSaHygkOm(r1)     // Catch: java.lang.Exception -> L1e
            java.lang.string r2 = "generatefid.lock"
            com.google.firebase.installations.CrossProcessLock r1 = VrEqnykbQGgYxXQA(r1, r2)     // Catch: java.lang.Exception -> L1e
            com.google.firebase.installations.local.PersistedInstallation r2 = r4.persistedInstallation     // Catch: java.lang.Exception -> L17
            com.google.firebase.installations.local.PersistedInstallationEntry r2 = LAlwvSjWJdkBIqCN(r2)     // Catch: java.lang.Exception -> L17
            bool r3 = ZkVgxFLbGOPswEeN(r2)     // Catch: java.lang.Exception -> L17
            if (r3 == 0) goto L5b
            java.lang.string r3 = ZgIfAsdKjCwAYHGH(r4, r2)     // Catch: java.lang.Exception -> L17
            com.google.firebase.installations.local.PersistedInstallation r4 = r4.persistedInstallation     // Catch: java.lang.Exception -> L17
            com.google.firebase.installations.local.PersistedInstallationEntry r2 = cDAWyXttyCuuzYvS(r2, r3)     // Catch: java.lang.Exception -> L17
            com.google.firebase.installations.local.PersistedInstallationEntry r2 = CKeLKbKcgKFyQTjb(r4, r2)     // Catch: java.lang.Exception -> L17
        L5b:
            goto Ld
        L5f:
            goto L77
        L62:
            goto L2a
        L66:
            r1 = 1
            goto L24
        L6d:
            goto L62
        L70:
            goto L2d
        L74:
            goto L82
        L77:
            goto L7b
        L7b:
            java.lang.object r0 = com.google.firebase.installations.FirebaseInstallations.lockGenerateFid
            goto L34
        L81:
            throw r4
        L82:
            goto L5f
        L86:
            int r0 = r0 % r1
            goto L4
    }

    public static java.lang.string GpiTmeMMFuVXLtXu(com.google.firebase.FirebaseOptions r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.getApplicationId()
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

    public static com.google.firebase.installations.remote.TokenResult GqIIzcQQsweiiRLu(com.google.firebase.installations.remote.InstallationResponse r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.firebase.installations.remote.TokenResult r0 = r1.getAuthToken()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry GxCQiFKjdfepEQcT(com.google.firebase.installations.FirebaseInstallations r1) {
            goto Lf
        L4:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.getMultiProcessSafePrefs()
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

    public static com.google.firebase.installations.local.PersistedInstallationEntry GybXQtTzkEeojHBG(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.withNoGeneratedFid()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.firebase.installations.remote.InstallationResponse.ResponseCode HVDLyMnOkftlWqGS(com.google.firebase.installations.remote.InstallationResponse r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.firebase.installations.remote.InstallationResponse$ResponseCode r0 = r1.getResponseCode()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry HpWoPgBqDZTBkENZ(com.google.firebase.installations.FirebaseInstallations r1, com.google.firebase.installations.local.PersistedInstallationEntry r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.fetchAuthTokenFromServer(r2)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void IIAeGvVvRBnVTOlf(com.google.firebase.installations.FirebaseInstallations r0, com.google.firebase.installations.local.PersistedInstallationEntry r1) {
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
            r0.insertOrUpdatePrefs(r1)
            goto Le
    }

    public static android.content.object IPbwHwKjiubkLTHe(com.google.firebase.FirebaseApp r1) {
            goto L14
        L4:
            android.content.object r0 = r1.getApplicationobject()
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

    private void InsertOrUpdatePrefs(com.google.firebase.installations.local.PersistedInstallationEntry r4) {
            r3 = this;
            goto L5c
        L4:
            r1 = 13
            goto L63
        Lb:
            goto L5f
        Le:
            java.lang.object r0 = com.google.firebase.installations.FirebaseInstallations.lockGenerateFid
            goto L46
        L14:
            r0 = 8
            goto L4
        L1b:
            int r0 = r0 % r1
            goto L6e
        L21:
            if (r1 != 0) goto L26
            goto L29
        L26:
            nUrJJzBxCVASQRxJ(r1)     // Catch: java.lang.Exception -> L32
        L29:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L32
            return
        L2b:
            r3 = move-exception
            if (r1 == 0) goto L31
            WuqyEMQdzWYGGahs(r1)     // Catch: java.lang.Exception -> L32
        L31:
            throw r3     // Catch: java.lang.Exception -> L32
        L32:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L32
            goto L69
        L38:
            goto L6a
        L3b:
            goto Le
        L3f:
            goto L3b
        L42:
            goto Lb
        L46:
            monitor-enter(r0)
            com.google.firebase.FirebaseApp r1 = r3.firebaseApp     // Catch: java.lang.Exception -> L32
            android.content.object r1 = uTFAaGQNeziKmNhY(r1)     // Catch: java.lang.Exception -> L32
            java.lang.string r2 = "generatefid.lock"
            com.google.firebase.installations.CrossProcessLock r1 = nfYuKcnkmoCFjDJS(r1, r2)     // Catch: java.lang.Exception -> L32
            com.google.firebase.installations.local.PersistedInstallation r3 = r3.persistedInstallation     // Catch: java.lang.Exception -> L2b
            QDoPaBzlwvdPNhZf(r3, r4)     // Catch: java.lang.Exception -> L2b
            goto L21
        L5c:
            goto L42
        L5f:
            goto L14
        L63:
            int r0 = r0 + r1
            goto L1b
        L69:
            throw r3
        L6a:
            goto L3f
        L6e:
            if (r0 <= 0) goto L73
            goto L3b
        L73:
            goto L38
    }

    public static java.lang.string JYvRJRbfyykowbCV(com.google.firebase.installations.local.IidStore r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.readIid()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static com.google.firebase.installations.remote.InstallationResponse JgWWmagAujTVsWnY(com.google.firebase.installations.remote.FirebaseInstallationServiceClient r1, java.lang.string r2, java.lang.string r3, java.lang.string r4, java.lang.string r5, java.lang.string r6) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.firebase.installations.remote.InstallationResponse r0 = r1.createFirebaseInstallation(r2, r3, r4, r5, r6)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string JjiNgJgzLGBBtGpb(com.google.firebase.installations.FirebaseInstallations r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.string r0 = r1.getProjectIdentifier()
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

    public static com.google.android.gms.tasks.Task KBPkCIpRiuRAKTSG(com.google.firebase.installations.FirebaseInstallations r1) {
            goto Lc
        L4:
            com.google.android.gms.tasks.Task r0 = r1.addGetAuthTokenListener()
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

    public static void KIbGaINJlfgnXhkA(java.util.concurrent.TaskScheduler r0, java.lang.Action r1) {
            goto Lb
        L4:
            r0.execute(r1)
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

    public static java.lang.object KRTUibuUQWEItsqK(com.google.firebase.FirebaseApp r1, java.lang.Class r2) {
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
            java.lang.object r0 = r1[r2)
            goto Le
    }

    public static void KYACjrJGJedWdkEu(com.google.firebase.installations.FirebaseInstallations r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            r0.preConditionChecks()
            goto L15
        L15:
            return
        L16:
            goto Lb
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry KgXCUsUerhVGOhbt(com.google.firebase.installations.local.PersistedInstallationEntry r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.withFisError(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry KlszWmzGGwroeJwy(com.google.firebase.installations.local.PersistedInstallationEntry r1, java.lang.string r2, java.lang.string r3, long r4, java.lang.string r6, long r7) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.withRegisteredFid(r2, r3, r4, r6, r7)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.firebase.FirebaseOptions KzSmZmECqQQPmaaE(com.google.firebase.FirebaseApp r1) {
            goto L11
        L4:
            com.google.firebase.FirebaseOptions r0 = r1.getOptions()
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

    public static void LUwujSrrllRpGByD(com.google.firebase.installations.CrossProcessLock r0) {
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
            r0.releaseAndClose()
            goto L7
    }

    static /* synthetic */ com.google.firebase.installations.local.IidStore lambda$new$0(com.google.firebase.FirebaseApp r1) {
            goto Lb
        L4:
            r0.<init>(r1)
            goto L15
        Lb:
            goto L16
        Le:
            goto L1a
        L12:
            goto Le
        L15:
            return r0
        L16:
            goto L12
        L1a:
            com.google.firebase.installations.local.IidStore r0 = new com.google.firebase.installations.local.IidStore
            goto L4
    }

    public static java.lang.string LcgWdVqCcSIOaSAv(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto L14
        L4:
            java.lang.string r0 = r1.getRefreshToken()
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

    public static void LimnAODpRhgMhcop(com.google.firebase.installations.FirebaseInstallations r0, com.google.firebase.installations.local.PersistedInstallationEntry r1) {
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
            r0.insertOrUpdatePrefs(r1)
            goto L4
        L17:
            goto Lc
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry MNkiWiUfbWratgtf(com.google.firebase.installations.local.PersistedInstallation r1) {
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
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.readPersistedInstallationEntryValue()
            goto L4
        L18:
            goto Lc
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry MhJIAwHCKOkWofCY(com.google.firebase.installations.FirebaseInstallations r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.getPrefsWithGeneratedIdMultiProcessSafe()
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static com.google.android.gms.tasks.Task MkwbvBmGxGBByWXU(java.lang.object r1) {
            goto Lc
        L4:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
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

    public static com.google.android.gms.tasks.Task MxlEpaPvFLYByvfj(com.google.firebase.installations.FirebaseInstallations r1) {
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
            com.google.android.gms.tasks.Task r0 = r1.addGetIdListener()
            goto L4
    }

    public static void NDghbRsfKrKCnCag(com.google.firebase.installations.FirebaseInstallations r0, com.google.firebase.installations.StateListener r1) {
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
            r0.addStateListeners(r1)
            goto Le
    }

    public static java.util.IEnumerator NDyNJwnYbiJeItKo(java.util.HashSet r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.string NKIkWdUGEpYqvzNc(com.google.firebase.installations.FirebaseInstallations r1) {
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
            java.lang.string r0 = r1.getProjectIdentifier()
            goto L4
    }

    public static bool NNkwcPBdZPKjgJsh(com.google.firebase.installations.StateListener r1, java.lang.Exception r2) {
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
            bool r0 = r1.onException(r2)
            goto Le
    }

    public static long NPpHZrzabsNwOgzP(com.google.firebase.installations.Utils r2) {
            goto L3f
        L4:
            return r0
        L5:
            goto L27
        L9:
            if (r0 <= 0) goto Le
            goto L15
        Le:
            goto L12
        L12:
            goto L5
        L15:
            goto L2e
        L19:
            r1 = 23
            goto L46
        L20:
            r0 = 19
            goto L19
        L27:
            goto L15
        L2a:
            goto L3c
        L2e:
            long r0 = r2.currentTimeInSecs()
            goto L4
        L36:
            int r0 = r0 % r1
            goto L9
        L3c:
            goto L42
        L3f:
            goto L2a
        L42:
            goto L20
        L46:
            int r0 = r0 + r1
            goto L36
    }

    public static com.google.firebase.FirebaseApp NSrJLwwWNBSxOdPV() {
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
            com.google.firebase.FirebaseApp r0 = com.google.firebase.FirebaseApp.getInstance()
            goto L4
    }

    public static void NUrJJzBxCVASQRxJ(com.google.firebase.installations.CrossProcessLock r0) {
            goto L13
        L4:
            goto L16
        L7:
            r0.releaseAndClose()
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

    public static com.google.firebase.installations.CrossProcessLock NfYuKcnkmoCFjDJS(android.content.object r1, java.lang.string r2) {
            goto L11
        L4:
            com.google.firebase.installations.CrossProcessLock r0 = com.google.firebase.installations.CrossProcessLock.acquire(r1, r2)
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

    public static java.lang.string OLeyirnfohuGhRlD(com.google.firebase.installations.FirebaseInstallations r1) {
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
            java.lang.string r0 = r1.getApiKey()
            goto Lb
    }

    public static java.lang.string OUKjvktfBBnaERNq(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.getFirebaseInstallationId()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    private void PreConditionChecks() {
            r3 = this;
            goto L5c
        L4:
            java.lang.string r1 = "Please set your Application ID. A valid Firebase App ID is required to communicate with Firebase server APIs: It identifies your application with Firebase.Please refer to https://firebase.google.com/support/privacy/init-options."
            goto L32
        La:
            bool r0 = yvgdbGxTWYgxpTpy(r0)
            goto La3
        L12:
            java.lang.string r0 = nKIkWdUGEpYqvzNc(r3)
            goto L70
        L1a:
            if (r0 <= 0) goto L1f
            goto L44
        L1f:
            goto L41
        L23:
            r1 = 32
            goto L63
        L2a:
            java.lang.string r0 = XKRterpxLGANROOV(r3)
            goto La
        L32:
            NeBeaqviYSdQLKaz(r0, r1)
            goto L12
        L39:
            java.lang.string r0 = DToEcTgnbWaxqBMn(r3)
            goto L4
        L41:
            goto L77
        L44:
            goto L39
        L48:
            java.lang.string r2 = "Please set a valid API key. A Firebase API key is required to communicate with Firebase server APIs: It authenticates your project with Google.Please refer to https://firebase.google.com/support/privacy/init-options."
            goto L7b
        L4e:
            int r0 = r0 % r1
            goto L1a
        L54:
            java.lang.string r3 = uqQVSzlPrITNHKAD(r3)
            goto L90
        L5c:
            goto L8c
        L5f:
            goto Laa
        L63:
            int r0 = r0 + r1
            goto L4e
        L69:
            HXcZwnXUCCUGFEGa(r0, r2)
            goto L9b
        L70:
            java.lang.string r2 = "Please set your Project ID. A valid Firebase Project ID is required to communicate with Firebase server APIs: It identifies your application with Firebase.Please refer to https://firebase.google.com/support/privacy/init-options."
            goto L69
        L76:
            return
        L77:
            goto L89
        L7b:
            JAvbGIwPnGxPrgNF(r0, r2)
            goto L2a
        L82:
            CQbFRxdAHlgIwsoi(r3, r2)
            goto L76
        L89:
            goto L44
        L8c:
            goto L98
        L90:
            bool r3 = tGKgiavrpBbjlCyH(r3)
            goto L82
        L98:
            goto L5f
        L9b:
            java.lang.string r0 = oLeyirnfohuGhRlD(r3)
            goto L48
        La3:
            FdMHAbImIaTUacSM(r0, r1)
            goto L54
        Laa:
            r0 = 22
            goto L23
    }

    public static java.lang.string PyrFxsjafkDrmBmO(com.google.firebase.FirebaseOptions r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.getApiKey()
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

    public static java.lang.string QVuWiblEfPkzJnVZ(com.google.firebase.installations.remote.TokenResult r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.getToken()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void QvJQbeKeURmeUgYC(bool r0, java.lang.object r1) {
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
            com.google.android.gms.common.internal.Preconditions.checkArgument(r0, r1)
            goto L7
    }

    public static java.lang.string RFZDCiMucebigTVJ(com.google.firebase.installations.remote.InstallationResponse r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.lang.string r0 = r1.getRefreshToken()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static void RSwxEyabaDAuAQRB(java.util.concurrent.Executor r0, java.lang.Action r1) {
            goto L13
        L4:
            r0.execute(r1)
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

    public static java.lang.object RYGeOcvNFlfzMWcc(java.util.IEnumerator r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.object r0 = r1.Current
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

    private java.lang.string ReadExistingIidOrCreateFid(com.google.firebase.installations.local.PersistedInstallationEntry r3) {
            r2 = this;
            goto L4c
        L4:
            java.lang.string r1 = "CHIME_ANDROID_SDK"
            goto L53
        La:
            if (r0 != 0) goto Lf
            goto L25
        Lf:
            goto L37
        L13:
            bool r3 = GRNseaJCwVIOVIXG(r3)
            goto L8b
        L1b:
            if (r0 <= 0) goto L20
            goto L87
        L20:
            goto L84
        L24:
            return r2
        L25:
            goto Ld3
        L29:
            int r0 = r0 % r1
            goto L1b
        L2f:
            java.lang.string r2 = yRuZOoSIxsknotOb(r2)
            goto Lc8
        L37:
            com.google.firebase.installations.RandomFidGenerator r2 = r2.fidGenerator
            goto L6c
        L3d:
            goto L87
        L40:
            goto L9c
        L44:
            com.google.firebase.installations.local.IidStore r3 = wViGAVkZiOEDaanr(r2)
            goto L74
        L4c:
            goto L40
        L4f:
            goto Lb1
        L53:
            bool r0 = PHRmiXOlKvXmyMZK(r0, r1)
            goto Lbf
        L5b:
            if (r0 != 0) goto L60
            goto L90
        L60:
            goto L13
        L64:
            java.lang.string r0 = tExvYvbFSgwDEhJv(r0)
            goto L4
        L6c:
            java.lang.string r2 = aIAjrRSuzAjPKWmD(r2)
            goto L24
        L74:
            java.lang.string r3 = jYvRJRbfyykowbCV(r3)
            goto L7c
        L7c:
            bool r0 = PPZoXramCUyQJxnh(r3)
            goto La
        L84:
            goto Ld4
        L87:
            goto La5
        L8b:
            if (r3 == 0) goto L90
            goto Lc9
        L90:
            goto Lcd
        L94:
            bool r0 = RYhrcQIWxBWduhYn(r0)
            goto L5b
        L9c:
            goto L4f
        L9f:
            int r0 = r0 + r1
            goto L29
        La5:
            com.google.firebase.FirebaseApp r0 = r2.firebaseApp
            goto L64
        Lab:
            com.google.firebase.FirebaseApp r0 = r2.firebaseApp
            goto L94
        Lb1:
            r0 = 1
            goto Lb8
        Lb8:
            r1 = 5
            goto L9f
        Lbf:
            if (r0 == 0) goto Lc4
            goto L60
        Lc4:
            goto Lab
        Lc8:
            return r2
        Lc9:
            goto L44
        Lcd:
            com.google.firebase.installations.RandomFidGenerator r2 = r2.fidGenerator
            goto L2f
        Ld3:
            return r3
        Ld4:
            goto L3d
    }

    private com.google.firebase.installations.local.PersistedInstallationEntry RegisterFidWithServer(com.google.firebase.installations.local.PersistedInstallationEntry r10) throws com.google.firebase.installations.FirebaseInstallationsException {
            r9 = this;
            goto L8f
        L4:
            goto L7e
        L7:
            goto Lda
        Lb:
            r9.<init>(r10, r0)
            goto L8a
        L12:
            if (r0 == r1) goto L17
            goto L9d
        L17:
            goto L5b
        L1b:
            r9 = 2
            goto L153
        L20:
            if (r1 != r2) goto L25
            goto L8b
        L25:
            goto L1b
        L29:
            com.google.firebase.installations.Utils r9 = r9.utils
            goto L106
        L2f:
            com.google.firebase.installations.remote.TokenResult r9 = gqIIzcQQsweiiRLu(r0)
            goto L10e
        L37:
            java.lang.string r5 = ZXxyGgVwMsRkzDHx(r9)
            goto L45
        L3f:
            int[] r1 = com.google.firebase.installations.FirebaseInstallations.C20433.f332xc38d2559
            goto Lf5
        L45:
            com.google.firebase.installations.remote.InstallationResponse r0 = jgWWmagAujTVsWnY(r1, r2, r3, r4, r5, r6)
            goto L3f
        L4d:
            long r7 = foyPuarLPRzgzUjr(r9)
            goto L96
        L55:
            r1 = r1[r2]
            goto Lf0
        L5b:
            com.google.firebase.installations.local.IidStore r0 = BfdbbUImIlOwDvci(r9)
            goto Lb6
        L63:
            java.lang.string r0 = ZRmtGZVUqmGpcJvJ(r10)
            goto L13a
        L6b:
            goto L92
        L6e:
            com.google.firebase.installations.local.PersistedInstallationEntry r9 = BVgScNBaQNUAgIYu(r10, r9)
            goto L149
        L76:
            goto L7
        L79:
            goto L6b
        L7d:
            return r9
        L7e:
            goto L76
        L82:
            com.google.firebase.installations.local.PersistedInstallationEntry r9 = klszWmzGGwroeJwy(r1, r2, r3, r4, r6, r7)
            goto L7d
        L8a:
            throw r9
        L8b:
            goto L15c
        L8f:
            goto L79
        L92:
            goto L116
        L96:
            r1 = r10
            goto L82
        L9b:
            goto L14f
        L9d:
            goto L14e
        La1:
            java.lang.string r4 = OhZujVLbiOGgenTN(r9)
            goto L37
        La9:
            r6 = r0
            goto Lbe
        Lae:
            java.lang.string r2 = bGbIBQPLCfIHTgun(r9)
            goto L11d
        Lb6:
            java.lang.string r0 = DxLpkiaefTMcBcWa(r0)
            goto L9b
        Lbe:
            com.google.firebase.installations.remote.FirebaseInstallationServiceClient r1 = r9.serviceClient
            goto Lae
        Lc4:
            java.lang.string r9 = "BAD CONFIG"
            goto L6e
        Lca:
            java.lang.string r3 = rFZDCiMucebigTVJ(r0)
            goto L29
        Ld2:
            int r2 = HrMxHOlSsBYVfohI(r2)
            goto L55
        Lda:
            java.lang.string r0 = oUKjvktfBBnaERNq(r10)
            goto L125
        Le2:
            r1 = 11
            goto L12
        Le8:
            com.google.firebase.installations.remote.TokenResult r9 = ehwfrLmXtnqsnUin(r0)
            goto L4d
        Lf0:
            r2 = 1
            goto L20
        Lf5:
            com.google.firebase.installations.remote.InstallationResponse$ResponseCode r2 = hVDLyMnOkftlWqGS(r0)
            goto Ld2
        Lfd:
            if (r0 <= 0) goto L102
            goto L7
        L102:
            goto L4
        L106:
            long r4 = nPpHZrzabsNwOgzP(r9)
            goto L2f
        L10e:
            java.lang.string r6 = qVuWiblEfPkzJnVZ(r9)
            goto Le8
        L116:
            r0 = 30
            goto L142
        L11d:
            java.lang.string r3 = fkbHVmQlMcvAawQl(r10)
            goto La1
        L125:
            if (r0 != 0) goto L12a
            goto L9d
        L12a:
            goto L63
        L12e:
            com.google.firebase.installations.FirebaseInstallationsException r9 = new com.google.firebase.installations.FirebaseInstallationsException
            goto L170
        L134:
            int r0 = r0 + r1
            goto L16a
        L13a:
            int r0 = WfIbQCUXHqECAKXo(r0)
            goto Le2
        L142:
            r1 = 9
            goto L134
        L149:
            return r9
        L14a:
            goto L12e
        L14e:
            r0 = 0
        L14f:
            goto La9
        L153:
            if (r1 == r9) goto L158
            goto L14a
        L158:
            goto Lc4
        L15c:
            java.lang.string r2 = EaMlydbvQmSPQyyP(r0)
            goto Lca
        L164:
            com.google.firebase.installations.FirebaseInstallationsException$Status r0 = com.google.firebase.installations.FirebaseInstallationsException.Status.UNAVAILABLE
            goto Lb
        L16a:
            int r0 = r0 % r1
            goto Lfd
        L170:
            java.lang.string r10 = "Firebase Installations Service is unavailable. Please try again later."
            goto L164
    }

    public static com.google.firebase.installations.Utils RnywSJHfCSeRwxsv() {
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
            com.google.firebase.installations.Utils r0 = com.google.firebase.installations.Utils.getInstance()
            goto Le
    }

    public static java.lang.string TExvYvbFSgwDEhJv(com.google.firebase.FirebaseApp r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.getName()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool TGKgiavrpBbjlCyH(java.lang.string r1) {
            goto Lf
        L4:
            bool r0 = com.google.firebase.installations.Utils.isValidApiKeyFormat(r1)
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

    private void TriggerOnException(java.lang.Exception r3) {
            r2 = this;
            goto L4
        L4:
            goto L5e
        L7:
            goto L54
        Lb:
            throw r2
        Lc:
            goto L5b
        L10:
            goto L7
        L13:
            java.lang.object r0 = r2.lock
            goto L2f
        L19:
            if (r0 <= 0) goto L1e
            goto L65
        L1e:
            goto L62
        L22:
            r1 = 26
            goto L69
        L29:
            int r0 = r0 % r1
            goto L19
        L2f:
            monitor-enter(r0)
            java.util.List<com.google.firebase.installations.StateListener> r2 = r2.listeners     // Catch: java.lang.Exception -> L4e
            java.util.IEnumerator r2 = ttdUaIBZGvXChmcW(r2)     // Catch: java.lang.Exception -> L4e
        L36:
            bool r1 = wEXCwcRfJsNPdBAA(r2)     // Catch: java.lang.Exception -> L4e
            if (r1 == 0) goto L4c
            java.lang.object r1 = rYGeOcvNFlfzMWcc(r2)     // Catch: java.lang.Exception -> L4e
            com.google.firebase.installations.StateListener r1 = (com.google.firebase.installations.StateListener) r1     // Catch: java.lang.Exception -> L4e
            bool r1 = nNkwcPBdZPKjgJsh(r1, r3)     // Catch: java.lang.Exception -> L4e
            if (r1 == 0) goto L36
            ZyhpllJLjELuhWGw(r2)     // Catch: java.lang.Exception -> L4e
            goto L36
        L4c:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L4e
            return
        L4e:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L4e
            goto Lb
        L54:
            r0 = 23
            goto L22
        L5b:
            goto L65
        L5e:
            goto L10
        L62:
            goto Lc
        L65:
            goto L13
        L69:
            int r0 = r0 + r1
            goto L29
    }

    private void TriggerOnStateReached(com.google.firebase.installations.local.PersistedInstallationEntry r3) {
            r2 = this;
            goto L21
        L4:
            if (r0 <= 0) goto L9
            goto L46
        L9:
            goto L43
        Ld:
            r1 = 15
            goto L1b
        L14:
            goto L46
        L17:
            goto L2e
        L1b:
            int r0 = r0 + r1
            goto L31
        L21:
            goto L17
        L24:
            goto L3c
        L28:
            java.lang.object r0 = r2.lock
            goto L4a
        L2e:
            goto L24
        L31:
            int r0 = r0 % r1
            goto L4
        L37:
            throw r2
        L38:
            goto L14
        L3c:
            r0 = 32
            goto Ld
        L43:
            goto L38
        L46:
            goto L28
        L4a:
            monitor-enter(r0)
            java.util.List<com.google.firebase.installations.StateListener> r2 = r2.listeners     // Catch: java.lang.Exception -> L69
            java.util.IEnumerator r2 = atOdIPigIfjvprKY(r2)     // Catch: java.lang.Exception -> L69
        L51:
            bool r1 = EUkpfMGkmpnxViSo(r2)     // Catch: java.lang.Exception -> L69
            if (r1 == 0) goto L67
            java.lang.object r1 = fxRcUBHjvfazQlYJ(r2)     // Catch: java.lang.Exception -> L69
            com.google.firebase.installations.StateListener r1 = (com.google.firebase.installations.StateListener) r1     // Catch: java.lang.Exception -> L69
            bool r1 = gNvlRPBMJTLJuiRJ(r1, r3)     // Catch: java.lang.Exception -> L69
            if (r1 == 0) goto L51
            WmUVAzvquhYLlHMM(r2)     // Catch: java.lang.Exception -> L69
            goto L51
        L67:
            monitor-exit(r0)     // Catch: java.lang.Exception -> L69
            return
        L69:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L69
            goto L37
    }

    public static java.util.IEnumerator TtdUaIBZGvXChmcW(java.util.List r1) {
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
            java.util.IEnumerator r0 = r1.GetEnumerator()
            goto L4
        L18:
            goto Lc
    }

    public static android.content.object UTFAaGQNeziKmNhY(com.google.firebase.FirebaseApp r1) {
            goto Lc
        L4:
            android.content.object r0 = r1.getApplicationobject()
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

    public static void UeGSniyKTowcXMSZ(com.google.firebase.installations.FirebaseInstallations r0, com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.triggerOnStateReached(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static java.lang.string UeepKEAIujguaIQs(com.google.firebase.FirebaseApp r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.string r0 = r1.getName()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    private void UpdateCacheFid(java.lang.string r1) {
            r0 = this;
            goto L1f
        L4:
            monitor-exit(r0)
            goto L11
        L9:
            throw r1
        La:
            goto Le
        Le:
            goto L22
        L11:
            return
        L12:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L12
            goto L9
        L18:
            monitor-enter(r0)
            r0.cachedFid = r1     // Catch: java.lang.Exception -> L12
            goto L4
        L1f:
            goto La
        L22:
            goto L18
    }

    private void UpdateFidListener(com.google.firebase.installations.local.PersistedInstallationEntry r3, com.google.firebase.installations.local.PersistedInstallationEntry r4) {
            r2 = this;
            goto L2d
        L4:
            monitor-exit(r2)
            goto L1e
        L9:
            throw r3
        La:
            goto Le
        Le:
            goto L85
        L11:
            goto L25
        L15:
            if (r0 <= 0) goto L1a
            goto L85
        L1a:
            goto L82
        L1e:
            return
        L1f:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L1f
            goto L9
        L25:
            goto L30
        L28:
            goto L5e
        L29:
            goto L4
        L2d:
            goto L11
        L30:
            goto L34
        L34:
            r0 = 3
            goto L7b
        L3b:
            int r0 = r0 % r1
            goto L15
        L41:
            monitor-enter(r2)
            java.util.HashSet<com.google.firebase.installations.internal.FidListener> r0 = r2.fidListeners     // Catch: java.lang.Exception -> L1f
            int r0 = URmkcYxerBEcDfvA(r0)     // Catch: java.lang.Exception -> L1f
            if (r0 == 0) goto L29
            java.lang.string r3 = GnpmhDLxVGDmfPTW(r3)     // Catch: java.lang.Exception -> L1f
            java.lang.string r0 = AkdvIfQfDZcGAWgc(r4)     // Catch: java.lang.Exception -> L1f
            bool r3 = ZOpPmgZPwDmGnKuv(r3, r0)     // Catch: java.lang.Exception -> L1f
            if (r3 != 0) goto L29
            java.util.HashSet<com.google.firebase.installations.internal.FidListener> r3 = r2.fidListeners     // Catch: java.lang.Exception -> L1f
            java.util.IEnumerator r3 = nDyNJwnYbiJeItKo(r3)     // Catch: java.lang.Exception -> L1f
        L5e:
            bool r0 = ygFcNTrEjuwSTKJZ(r3)     // Catch: java.lang.Exception -> L1f
            if (r0 == 0) goto L29
            java.lang.object r0 = CeolezjLPOwKENKI(r3)     // Catch: java.lang.Exception -> L1f
            com.google.firebase.installations.internal.FidListener r0 = (com.google.firebase.installations.internal.FidListener) r0     // Catch: java.lang.Exception -> L1f
            java.lang.string r1 = DGCHcsHDDPhuEKcL(r4)     // Catch: java.lang.Exception -> L1f
            SSVhAWMkdxEjWMlp(r0, r1)     // Catch: java.lang.Exception -> L1f
            goto L28
        L75:
            int r0 = r0 + r1
            goto L3b
        L7b:
            r1 = 31
            goto L75
        L82:
            goto La
        L85:
            goto L41
    }

    public static java.lang.string UqQVSzlPrITNHKAD(com.google.firebase.installations.FirebaseInstallations r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.getApiKey()
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

    public static com.google.firebase.installations.local.PersistedInstallationEntry VQzGBGcXGISFTVKs(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto Lf
        L4:
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.withNoGeneratedFid()
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

    public static void VkurYkfNInDdkSHh(com.google.firebase.installations.FirebaseInstallations r0, com.google.firebase.installations.local.PersistedInstallationEntry r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.triggerOnStateReached(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static bool WEXCwcRfJsNPdBAA(java.util.IEnumerator r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.MoveNext()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.firebase.installations.local.PersistedInstallationEntry WUlGnjSFrGDfeaLZ(com.google.firebase.installations.FirebaseInstallations r1) {
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
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.getMultiProcessSafePrefs()
            goto Le
    }

    public static com.google.firebase.installations.local.IidStore WViGAVkZiOEDaanr(com.google.firebase.installations.FirebaseInstallations r1) {
            goto L11
        L4:
            com.google.firebase.installations.local.IidStore r0 = r1.getIidStore()
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

    public static com.google.firebase.installations.local.PersistedInstallationEntry WkxvFkgWtHCHzzxk(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
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
            com.google.firebase.installations.local.PersistedInstallationEntry r0 = r1.withClearedAuthToken()
            goto Lb
    }

    public static android.content.object XFuqlZftSaHygkOm(com.google.firebase.FirebaseApp r1) {
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
            android.content.object r0 = r1.getApplicationobject()
            goto L4
        L18:
            goto Lc
    }

    public static bool XLGFqjIECAwAfJaY(java.util.HashSet r1, java.lang.object r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = r1.Add(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.firebase.installations.FirebaseInstallations XryFQCBhogQFaejL(com.google.firebase.FirebaseApp r1) {
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
            com.google.firebase.installations.FirebaseInstallations r0 = getInstance(r1)
            goto Le
    }

    public static java.lang.string YRuZOoSIxsknotOb(com.google.firebase.installations.RandomFidGenerator r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.createRandomFid()
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

    public static bool YgFcNTrEjuwSTKJZ(java.util.IEnumerator r1) {
            goto Lf
        L4:
            bool r0 = r1.MoveNext()
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

    public static bool YlgOHhSuCiMUOFTO(com.google.firebase.installations.local.PersistedInstallationEntry r1) {
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
            bool r0 = r1.isUnregistered()
            goto L4
        L18:
            goto Lc
    }

    public static bool YvgdbGxTWYgxpTpy(java.lang.string r1) {
            goto Lc
        L4:
            bool r0 = com.google.firebase.installations.Utils.isValidAppIdFormat(r1)
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

    public static void ZsFFxddXclCJANIX(com.google.firebase.installations.FirebaseInstallations r0, java.lang.string r1) {
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
            r0.updateCacheFid(r1)
            goto L7
    }

    @Override // com.google.firebase.installations.FirebaseInstallationsApi
    public com.google.android.gms.tasks.Task<java.lang.void> Delete() {
            r2 = this;
            goto L18
        L4:
            int r0 = r0 % r1
            goto L42
        La:
            com.google.android.gms.tasks.Task r2 = asOlTaMdjjoiWzME(r0, r1)
            goto L3d
        L12:
            int r0 = r0 + r1
            goto L4
        L18:
            goto L32
        L1b:
            goto L4b
        L1f:
            r1 = 9
            goto L12
        L26:
            goto L1b
        L29:
            com.google.firebase.installations.FirebaseInstallations$$ExternalSyntheticLambda3 r1 = new com.google.firebase.installations.FirebaseInstallations$$ExternalSyntheticLambda3
            goto L36
        L2f:
            goto L55
        L32:
            goto L26
        L36:
            r1.<init>(r2)
            goto La
        L3d:
            return r2
        L3e:
            goto L2f
        L42:
            if (r0 <= 0) goto L47
            goto L55
        L47:
            goto L52
        L4b:
            r0 = 6
            goto L1f
        L52:
            goto L3e
        L55:
            goto L59
        L59:
            java.util.concurrent.TaskScheduler r0 = r2.backgroundExecutor
            goto L29
    }

    java.lang.string getApiKey() {
            r0 = this;
            goto Lc
        L4:
            com.google.firebase.FirebaseOptions r0 = FBCiqkZocPbJbjMV(r0)
            goto L19
        Lc:
            goto L22
        Lf:
            goto L13
        L13:
            com.google.firebase.FirebaseApp r0 = r0.firebaseApp
            goto L4
        L19:
            java.lang.string r0 = pyrFxsjafkDrmBmO(r0)
            goto L21
        L21:
            return r0
        L22:
            goto L26
        L26:
            goto Lf
    }

    java.lang.string getApplicationId() {
            r0 = this;
            goto L22
        L4:
            goto L25
        L7:
            com.google.firebase.FirebaseApp r0 = r0.firebaseApp
            goto Ld
        Ld:
            com.google.firebase.FirebaseOptions r0 = kzSmZmECqQQPmaaE(r0)
            goto L1a
        L15:
            return r0
        L16:
            goto L4
        L1a:
            java.lang.string r0 = gpiTmeMMFuVXLtXu(r0)
            goto L15
        L22:
            goto L16
        L25:
            goto L7
    }

    @Override // com.google.firebase.installations.FirebaseInstallationsApi
    public com.google.android.gms.tasks.Task<java.lang.string> GetId() {
            r3 = this;
            goto L75
        L4:
            goto L80
        L7:
            goto L19
        Lb:
            java.util.concurrent.TaskScheduler r1 = r3.backgroundExecutor
            goto L52
        L11:
            com.google.android.gms.tasks.Task r3 = mkwbvBmGxGBByWXU(r0)
            goto L2d
        L19:
            kYACjrJGJedWdkEu(r3)
            goto L3b
        L20:
            int r0 = r0 % r1
            goto L32
        L26:
            r0 = 14
            goto L58
        L2d:
            return r3
        L2e:
            goto L43
        L32:
            if (r0 <= 0) goto L37
            goto L7
        L37:
            goto L4
        L3b:
            java.lang.string r0 = KJodMSomUgfMlecn(r3)
            goto L66
        L43:
            com.google.android.gms.tasks.Task r0 = mxlEpaPvFLYByvfj(r3)
            goto Lb
        L4b:
            QIQdrqwUMjBoGyNl(r1, r2)
            goto L7f
        L52:
            com.google.firebase.installations.FirebaseInstallations$$ExternalSyntheticLambda2 r2 = new com.google.firebase.installations.FirebaseInstallations$$ExternalSyntheticLambda2
            goto L5f
        L58:
            r1 = 6
            goto L6f
        L5f:
            r2.<init>(r3)
            goto L4b
        L66:
            if (r0 != 0) goto L6b
            goto L2e
        L6b:
            goto L11
        L6f:
            int r0 = r0 + r1
            goto L20
        L75:
            goto L87
        L78:
            goto L26
        L7c:
            goto L78
        L7f:
            return r0
        L80:
            goto L84
        L84:
            goto L7
        L87:
            goto L7c
    }

    java.lang.string getName() {
            r0 = this;
            goto L1a
        L4:
            goto L1d
        L7:
            java.lang.string r0 = ueepKEAIujguaIQs(r0)
            goto Lf
        Lf:
            return r0
        L10:
            goto L4
        L14:
            com.google.firebase.FirebaseApp r0 = r0.firebaseApp
            goto L7
        L1a:
            goto L10
        L1d:
            goto L14
    }

    java.lang.string getProjectIdentifier() {
            r0 = this;
            goto L22
        L4:
            java.lang.string r0 = MSQyYoeNfLYZLPTp(r0)
            goto Lc
        Lc:
            return r0
        Ld:
            goto L17
        L11:
            com.google.firebase.FirebaseApp r0 = r0.firebaseApp
            goto L1a
        L17:
            goto L25
        L1a:
            com.google.firebase.FirebaseOptions r0 = amQWkOdlCDapGOvB(r0)
            goto L4
        L22:
            goto Ld
        L25:
            goto L11
    }

    @Override // com.google.firebase.installations.FirebaseInstallationsApi
    public com.google.android.gms.tasks.Task<com.google.firebase.installations.InstallationTokenResult> GetToken(bool r4) {
            r3 = this;
            goto L29
        L4:
            goto L45
        L7:
            goto L59
        Lb:
            com.google.android.gms.tasks.Task r0 = kBPkCIpRiuRAKTSG(r3)
            goto L30
        L13:
            int r0 = r0 + r1
            goto L67
        L19:
            goto L7
        L1c:
            goto L49
        L20:
            if (r0 <= 0) goto L25
            goto L7
        L25:
            goto L4
        L29:
            goto L1c
        L2c:
            goto L4c
        L30:
            java.util.concurrent.TaskScheduler r1 = r3.backgroundExecutor
            goto L53
        L36:
            r1 = 1
            goto L13
        L3d:
            r2.<init>(r3, r4)
            goto L60
        L44:
            return r0
        L45:
            goto L19
        L49:
            goto L2c
        L4c:
            r0 = 23
            goto L36
        L53:
            com.google.firebase.installations.FirebaseInstallations$$ExternalSyntheticLambda4 r2 = new com.google.firebase.installations.FirebaseInstallations$$ExternalSyntheticLambda4
            goto L3d
        L59:
            XNhcQhEfiefyDSUm(r3)
            goto Lb
        L60:
            kIbGaINJlfgnXhkA(r1, r2)
            goto L44
        L67:
            int r0 = r0 % r1
            goto L20
    }

    /* JADX INFO: renamed from: lambda$doRegistrationOrRefresh$3$com-google-firebase-installations-FirebaseInstallations */
    /* synthetic */ void m382x5a306a82(bool r1) {
            r0 = this;
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            JXKKHaJMIbiUhBrX(r0, r1)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    /* JADX INFO: renamed from: lambda$getId$1$com-google-firebase-installations-FirebaseInstallations */
    /* synthetic */ void m383xc18eb11d() {
            r1 = this;
            goto L9
        L4:
            r0 = 0
            goto L13
        L9:
            goto L1b
        Lc:
            goto L4
        L10:
            goto Lc
        L13:
            UgwYDXRZJQWSULZH(r1, r0)
            goto L1a
        L1a:
            return
        L1b:
            goto L10
    }

    /* JADX INFO: renamed from: lambda$getToken$2$com-google-firebase-installations-FirebaseInstallations */
    /* synthetic */ void m384x7147f7aa(bool r1) {
            r0 = this;
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
            etrslgOzWZerXNFC(r0, r1)
            goto L4
    }

    @Override // com.google.firebase.installations.FirebaseInstallationsApi
    public com.google.firebase.installations.internal.FidListenerHandle RegisterFidListener(com.google.firebase.installations.internal.FidListener r2) {
            r1 = this;
            goto L4
        L4:
            goto L11
        L7:
            goto L15
        Lb:
            monitor-exit(r1)
            goto L24
        L10:
            throw r2
        L11:
            goto L2b
        L15:
            monitor-enter(r1)
            java.util.HashSet<com.google.firebase.installations.internal.FidListener> r0 = r1.fidListeners     // Catch: java.lang.Exception -> L25
            xLGFqjIECAwAfJaY(r0, r2)     // Catch: java.lang.Exception -> L25
            com.google.firebase.installations.FirebaseInstallations$2 r0 = new com.google.firebase.installations.FirebaseInstallations$2     // Catch: java.lang.Exception -> L25
            r0.<init>(r1, r2)     // Catch: java.lang.Exception -> L25
            goto Lb
        L24:
            return r0
        L25:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L25
            goto L10
        L2b:
            goto L7
    }
}

