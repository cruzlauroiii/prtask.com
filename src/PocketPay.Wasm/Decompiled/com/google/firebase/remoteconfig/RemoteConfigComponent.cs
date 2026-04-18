namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class RemoteConfigComponent : com.google.firebase.remoteconfig.interop.FirebaseRemoteConfigInterop {
    public static readonly java.lang.string ACTIVATE_FILE_NAME = "activate";
    public static readonly long CONNECTION_TIMEOUT_IN_SECONDS = 60;
    public static readonly java.lang.string DEFAULTS_FILE_NAME = "defaults";
    private static readonly com.google.android.gms.common.util.Clock DEFAULT_CLOCK = null;
    public static readonly java.lang.string DEFAULT_NAMESPACE = "firebase";
    private static readonly java.util.Random DEFAULT_RANDOM = null;
    public static readonly java.lang.string FETCH_FILE_NAME = "fetch";
    private static readonly java.lang.string FIREBASE_REMOTE_CONFIG_FILE_NAME_PREFIX = "frc";
    private static readonly java.lang.string PREFERENCES_FILE_NAME = "settings";
    private static readonly java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.FirebaseRemoteConfig> frcNamespaceInstancesStatic = null;
    private readonly com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> analyticsConnector;
    private readonly java.lang.string appId;
    private readonly android.content.object context;
    private java.util.Dictionary<java.lang.string, java.lang.string> customHeaders;
    private readonly java.util.concurrent.ScheduledTaskScheduler executor;
    private readonly com.google.firebase.abt.FirebaseABTesting firebaseAbt;
    private readonly com.google.firebase.FirebaseApp firebaseApp;
    private readonly com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallations;
    private readonly java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.FirebaseRemoteConfig> frcNamespaceInstances;

    private static class GlobalBackgroundListener : com.google.android.gms.common.api.internal.BackgroundDetector.BackgroundStateChangeListener {
        private static readonly java.util.concurrent.atomic.object<com.google.firebase.remoteconfig.RemoteConfigComponent.GlobalBackgroundListener> INSTANCE = null;

        static {
                goto L10
            L4:
                return
            L5:
                goto L23
            L9:
                r0.<init>()
                goto L1d
            L10:
                goto L5
            L13:
                goto L17
            L17:
                java.util.concurrent.atomic.object r0 = new java.util.concurrent.atomic.object
                goto L9
            L1d:
                com.google.firebase.remoteconfig.RemoteConfigComponent.GlobalBackgroundListener.INSTANCE = r0
                goto L4
            L23:
                goto L13
        }

        private GlobalBackgroundListener() {
                r0 = this;
                goto L13
            L4:
                r0.<init>()
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

        public static void DRTpvfJsXHtxbPSq(android.app.Application r0) {
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
                com.google.android.gms.common.api.internal.BackgroundDetector.initialize(r0)
                goto Lb
        }

        public static bool IogPZWQnzFpeeQIW(java.util.concurrent.atomic.object r1, java.lang.object r2, java.lang.object r3) {
                goto Lf
            L4:
                goto L12
            L7:
                bool r0 = androidx.lifecycle.object$$ExternalSyntheticBackportWithForwarding0.m35m(r1, r2, r3)
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

        static /* synthetic */ void access$000(android.content.object r0) {
                goto L13
            L4:
                goto L16
            L7:
                return
            L8:
                goto L4
            Lc:
                rVlpDTzkpFmFrYKV(r0)
                goto L7
            L13:
                goto L8
            L16:
                goto Lc
        }

        public static com.google.android.gms.common.api.internal.BackgroundDetector DyzCsTJiaemhBchv() {
                goto Lc
            L4:
                com.google.android.gms.common.api.internal.BackgroundDetector r0 = com.google.android.gms.common.api.internal.BackgroundDetector.getInstance()
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

        private static void EnsureBackgroundListenerIsRegistered(android.content.object r3) {
                goto L1a
            L4:
                goto L42
            L7:
                goto Lb
            Lb:
                android.content.object r3 = ysPpXqOYdyyvndHb(r3)
                goto L32
            L13:
                DRTpvfJsXHtxbPSq(r3)
                goto L87
            L1a:
                goto L72
            L1d:
                goto L94
            L21:
                java.lang.object r1 = wZZKlTQtRAoyNwfX(r0)
                goto L29
            L29:
                if (r1 == 0) goto L2e
                goto L65
            L2e:
                goto L5c
            L32:
                android.app.Application r3 = (android.app.Application) r3
                goto L69
            L38:
                if (r0 != 0) goto L3d
                goto L65
            L3d:
                goto L13
            L41:
                return
            L42:
                goto L6f
            L46:
                if (r0 <= 0) goto L4b
                goto L7
            L4b:
                goto L4
            L4f:
                int r0 = r0 + r1
                goto L76
            L55:
                r1.<init>()
                goto L8f
            L5c:
                com.google.firebase.remoteconfig.RemoteConfigComponent$GlobalBackgroundListener r1 = new com.google.firebase.remoteconfig.RemoteConfigComponent$GlobalBackgroundListener
                goto L55
            L62:
                imQlNecyNvqahiRL(r3, r1)
            L65:
                goto L41
            L69:
                java.util.concurrent.atomic.object<com.google.firebase.remoteconfig.RemoteConfigComponent$GlobalBackgroundListener> r0 = com.google.firebase.remoteconfig.RemoteConfigComponent.GlobalBackgroundListener.INSTANCE
                goto L21
            L6f:
                goto L7
            L72:
                goto L84
            L76:
                int r0 = r0 % r1
                goto L46
            L7c:
                bool r0 = IogPZWQnzFpeeQIW(r0, r2, r1)
                goto L38
            L84:
                goto L1d
            L87:
                com.google.android.gms.common.api.internal.BackgroundDetector r3 = dyzCsTJiaemhBchv()
                goto L62
            L8f:
                r2 = 0
                goto L7c
            L94:
                r0 = 21
                goto L9b
            L9b:
                r1 = 26
                goto L4f
        }

        public static void ImQlNecyNvqahiRL(com.google.android.gms.common.api.internal.BackgroundDetector r0, com.google.android.gms.common.api.internal.BackgroundDetector.BackgroundStateChangeListener r1) {
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
                r0.addListener(r1)
                goto L4
        }

        public static void LmhGWkGmPHItxrvp(bool r0) {
                goto L13
            L4:
                com.google.firebase.remoteconfig.RemoteConfigComponent.access$100(r0)
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

        public static void RVlpDTzkpFmFrYKV(android.content.object r0) {
                goto Le
            L4:
                ensureBackgroundListenerIsRegistered(r0)
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

        public static java.lang.object WZZKlTQtRAoyNwfX(java.util.concurrent.atomic.object r1) {
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
                java.lang.object r0 = r1[)
                goto L7
        }

        public static android.content.object YsPpXqOYdyyvndHb(android.content.object r1) {
                goto L14
            L4:
                return r0
            L5:
                goto L9
            L9:
                goto L17
            Lc:
                android.content.object r0 = r1.getApplicationobject()
                goto L4
            L14:
                goto L5
            L17:
                goto Lc
        }

        @Override // com.google.android.gms.common.api.internal.BackgroundDetector.BackgroundStateChangeListener
        public void OnBackgroundStateChanged(bool r1) {
                r0 = this;
                goto L10
            L4:
                lmhGWkGmPHItxrvp(r1)
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
    }

    static {
            goto L16
        L4:
            com.google.firebase.remoteconfig.RemoteConfigComponent.DEFAULT_RANDOM = r0
            goto La
        La:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L26
        L10:
            com.google.firebase.remoteconfig.RemoteConfigComponent.DEFAULT_CLOCK = r0
            goto L39
        L16:
            goto L35
        L19:
            goto L3f
        L1d:
            com.google.firebase.remoteconfig.RemoteConfigComponent.frcNamespaceInstancesStatic = r0
            goto L34
        L23:
            goto L19
        L26:
            r0.<init>()
            goto L1d
        L2d:
            r0.<init>()
            goto L4
        L34:
            return
        L35:
            goto L23
        L39:
            java.util.Random r0 = new java.util.Random
            goto L2d
        L3f:
            com.google.android.gms.common.util.Clock r0 = DunZCpvOeeREVGUK()
            goto L10
    }

    RemoteConfigComponent(android.content.object r9, java.util.concurrent.ScheduledTaskScheduler r10, com.google.firebase.FirebaseApp r11, com.google.firebase.installations.FirebaseInstallationsApi r12, com.google.firebase.abt.FirebaseABTesting r13, com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> r14) {
            r8 = this;
            goto L19
        L4:
            r5 = r13
            goto L51
        L9:
            r0 = r8
            goto L30
        Le:
            r2 = r10
            goto L45
        L13:
            int r0 = r0 + r1
            goto L2a
        L19:
            goto L41
        L1c:
            goto L5e
        L20:
            r4 = r12
            goto L4
        L25:
            r7 = 1
            goto L9
        L2a:
            int r0 = r0 % r1
            goto L35
        L30:
            r1 = r9
            goto Le
        L35:
            if (r0 <= 0) goto L3a
            goto L6f
        L3a:
            goto L6c
        L3e:
            goto L6f
        L41:
            goto L56
        L45:
            r3 = r11
            goto L20
        L4a:
            r1 = 5
            goto L13
        L51:
            r6 = r14
            goto L65
        L56:
            goto L1c
        L59:
            return
        L5a:
            goto L3e
        L5e:
            r0 = 21
            goto L4a
        L65:
            r0.<init>(r1, r2, r3, r4, r5, r6, r7)
            goto L59
        L6c:
            goto L5a
        L6f:
            goto L25
    }

    protected RemoteConfigComponent(android.content.object r2, java.util.concurrent.ScheduledTaskScheduler r3, com.google.firebase.FirebaseApp r4, com.google.firebase.installations.FirebaseInstallationsApi r5, com.google.firebase.abt.FirebaseABTesting r6, com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> r7, bool r8) {
            r1 = this;
            goto L83
        L4:
            java.lang.string r4 = eYFcSRINjXiqrduZ(r4)
            goto L27
        Lc:
            r1.customHeaders = r0
            goto L2d
        L12:
            goto L86
        L15:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L91
        L1b:
            java.util.HashDictionary r0 = new java.util.HashDictionary
            goto L8a
        L21:
            r1.executor = r3
            goto L76
        L27:
            r1.appId = r4
            goto L43
        L2d:
            r1.context = r2
            goto L21
        L33:
            r2.<init>(r1)
            goto L6f
        L3a:
            if (r8 != 0) goto L3f
            goto L72
        L3f:
            goto L69
        L43:
            yfFpWoDTBkagyUHh(r2)
            goto L3a
        L4a:
            r1.firebaseAbt = r6
            goto L55
        L50:
            return
        L51:
            goto L12
        L55:
            r1.analyticsConnector = r7
            goto L61
        L5b:
            r1.firebaseInstallations = r5
            goto L4a
        L61:
            com.google.firebase.FirebaseOptions r4 = GCTvUOgUgGfSRVmF(r4)
            goto L4
        L69:
            com.google.firebase.remoteconfig.RemoteConfigComponent$$ExternalSyntheticLambda1 r2 = new com.google.firebase.remoteconfig.RemoteConfigComponent$$ExternalSyntheticLambda1
            goto L33
        L6f:
            dGGzoNDoKtBCZXub(r3, r2)
        L72:
            goto L50
        L76:
            r1.firebaseApp = r4
            goto L5b
        L7c:
            r1.<init>()
            goto L15
        L83:
            goto L51
        L86:
            goto L7c
        L8a:
            r0.<init>()
            goto Lc
        L91:
            r0.<init>()
            goto L98
        L98:
            r1.frcNamespaceInstances = r0
            goto L1b
    }

    public static com.google.firebase.remoteconfig.internal.ConfigCacheClient AwdRkHjdbiJWXjCK(com.google.firebase.remoteconfig.RemoteConfigComponent r1, java.lang.string r2, java.lang.string r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.firebase.remoteconfig.internal.ConfigCacheClient r0 = r1.getCacheClient(r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static void CTKuNNXDjPPqcdiI(com.google.firebase.remoteconfig.FirebaseRemoteConfig r0, bool r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.setConfigUpdateBackgroundState(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static long CTqEeskDwJHMABXK(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r2) {
            goto Lb
        L4:
            goto L38
        L7:
            goto L12
        Lb:
            goto L7
        Le:
            goto L3c
        L12:
            goto Le
        L15:
            int r0 = r0 % r1
            goto L43
        L1b:
            int r0 = r0 + r1
            goto L15
        L21:
            return r0
        L22:
            goto L4
        L26:
            long r0 = r2.getFetchTimeoutInSeconds()
            goto L21
        L2e:
            r1 = 13
            goto L1b
        L35:
            goto L22
        L38:
            goto L26
        L3c:
            r0 = 15
            goto L2e
        L43:
            if (r0 <= 0) goto L48
            goto L38
        L48:
            goto L35
    }

    public static com.google.android.gms.common.util.Clock DunZCpvOeeREVGUK() {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.gms.common.util.Clock r0 = com.google.android.gms.common.util.DefaultClock.getInstance()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static com.google.firebase.remoteconfig.internal.ConfigCacheClient FggjwagUFLOFyehI(com.google.firebase.remoteconfig.RemoteConfigComponent r1, java.lang.string r2, java.lang.string r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.firebase.remoteconfig.internal.ConfigCacheClient r0 = r1.getCacheClient(r2, r3)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler FvpnCuGhCdSqZYXd(com.google.firebase.remoteconfig.RemoteConfigComponent r1, com.google.firebase.remoteconfig.internal.ConfigCacheClient r2, com.google.firebase.remoteconfig.internal.ConfigCacheClient r3) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler r0 = r1.getRolloutsStateSubscriptionsHandler(r2, r3)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static com.google.firebase.FirebaseOptions GCTvUOgUgGfSRVmF(com.google.firebase.FirebaseApp r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.firebase.FirebaseOptions r0 = r1.getOptions()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static android.content.Dictionary<string, object> HNEwcGChDeFTBKqa(android.content.object r1, java.lang.string r2, int r3) {
            goto Lc
        L4:
            android.content.Dictionary<string, object> r0 = r1.getDictionary<string, object>(r2, r3)
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

    public static com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler HoVoYelfalmTKtdb(com.google.firebase.remoteconfig.FirebaseRemoteConfig r1) {
            goto Lf
        L4:
            com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler r0 = r1.getRolloutsStateSubscriptionsHandler()
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

    public static bool HoiLMqtulrLDQpio(java.util.IEnumerator r1) {
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
            bool r0 = r1.MoveNext()
            goto Le
    }

    public static java.lang.object HsRVSndzmeIscfvn(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.object IbZJOOVdiugdIfel(java.lang.object r1) {
            goto Lc
        L4:
            java.lang.object r0 = java.util.objects.requireNonNull(r1)
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

    public static void JSTSKKknZlETNHrv(bool r0) {
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
            notifyRCInstances(r0)
            goto Le
    }

    public static com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateFactory KkVEyCYDvUFNWJEI(com.google.firebase.remoteconfig.internal.ConfigCacheClient r1, com.google.firebase.remoteconfig.internal.ConfigCacheClient r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateFactory r0 = com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateFactory.create(r1, r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool NgrvnDmoCaUvJiix(com.google.firebase.FirebaseApp r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = isPrimaryApp(r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object ONsRpbsDmmhVZQsd(java.util.Dictionary r1, java.lang.object r2, java.lang.object r3) {
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

    public static java.lang.string QEiVzjARJlZWsRcV(java.lang.string r1, java.lang.object[] r2) {
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
            java.lang.string r0 = java.lang.string.format(r1, r2)
            goto L4
        L18:
            goto Lc
    }

    public static com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler RSMNViQshSgmaaia(com.google.firebase.remoteconfig.RemoteConfigComponent r1, com.google.firebase.remoteconfig.internal.ConfigCacheClient r2, com.google.firebase.remoteconfig.internal.ConfigCacheClient r3) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler r0 = r1.getGetHandler(r2, r3)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static bool RUAjiPrVlZHOItUP(com.google.firebase.FirebaseApp r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = isPrimaryApp(r1)
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

    public static void VYUrfydOwVAEJhmv(com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler r0, com.google.android.gms.common.util.BiConsumer r1) {
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
            r0.addListener(r1)
            goto L4
    }

    public static java.lang.string WayqvlGtRzcnsQGJ(com.google.firebase.FirebaseApp r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.string r0 = r1.getName()
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

    public static com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient XCvzSTXkWKsOtRYs(android.content.object r1, java.lang.string r2, java.lang.string r3) {
            goto Lc
        L4:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r0 = getSharedPrefsClient(r1, r2, r3)
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

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHandler XReAsVdqjcBXHtAt(com.google.firebase.remoteconfig.RemoteConfigComponent r1, java.lang.string r2, com.google.firebase.remoteconfig.internal.ConfigCacheClient r3, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r4) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.firebase.remoteconfig.internal.ConfigFetchHandler r0 = r1.getFetchHandler(r2, r3, r4)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void XTdZAYkcrCOeQaTA(com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler r0, com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber r1) {
            goto Lb
        L4:
            r0.registerRolloutsStateSubscriber(r1)
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

    public static java.lang.object XdaaZuzZuZcSDqYB(java.util.IEnumerator r1) {
            goto L11
        L4:
            java.lang.object r0 = r1.Current
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

    public static bool YGPuJJBSQpWvXShO(java.lang.string r1, java.lang.object r2) {
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

    public static java.lang.object YMBkCBCDmfSMzPgJ(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.object r0 = r1[r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static long ZlKhpYfwPGnxPMfz(com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r2) {
            goto L33
        L4:
            r1 = 26
            goto L12
        Lb:
            goto L23
        Le:
            goto L30
        L12:
            int r0 = r0 + r1
            goto L46
        L18:
            long r0 = r2.getFetchTimeoutInSeconds()
            goto L41
        L20:
            goto L42
        L23:
            goto L18
        L27:
            if (r0 <= 0) goto L2c
            goto L23
        L2c:
            goto L20
        L30:
            goto L36
        L33:
            goto Le
        L36:
            goto L3a
        L3a:
            r0 = 2
            goto L4
        L41:
            return r0
        L42:
            goto Lb
        L46:
            int r0 = r0 % r1
            goto L27
    }

    static /* synthetic */ void access$100(bool r0) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            JSTSKKknZlETNHrv(r0)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static java.lang.string AxhoAaVBwmsgGviz(com.google.firebase.FirebaseOptions r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.getApplicationId()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool BtlWVYyAcEknOUyD(java.util.Dictionary r1, java.lang.object r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = r1.ContainsKey(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static com.google.android.gms.tasks.Task DGGzoNDoKtBCZXub(java.util.concurrent.Executor r1, java.util.concurrent.Func r2) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.call(r1, r2)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string EYFcSRINjXiqrduZ(com.google.firebase.FirebaseOptions r1) {
            goto L14
        L4:
            java.lang.string r0 = r1.getApplicationId()
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

    private com.google.firebase.remoteconfig.internal.ConfigCacheClient GetCacheClient(java.lang.string r3, java.lang.string r4) {
            r2 = this;
            goto L5b
        L4:
            goto L65
        L7:
            goto L52
        Lb:
            com.google.firebase.remoteconfig.internal.ConfigCacheClient r2 = inihJbULQfXYhbuo(r4, r2)
            goto L69
        L13:
            r1 = 4
            goto L22
        L1a:
            com.google.firebase.remoteconfig.internal.ConfigStorageClient r2 = uLZfBvNAekWRpfmx(r2, r3)
            goto Lb
        L22:
            int r0 = r0 + r1
            goto L28
        L28:
            int r0 = r0 % r1
            goto L2e
        L2e:
            if (r0 <= 0) goto L33
            goto L65
        L33:
            goto L62
        L37:
            java.lang.string r0 = "frc"
            goto L55
        L3d:
            android.content.object r2 = r2.context
            goto L1a
        L43:
            r0 = 21
            goto L13
        L4a:
            java.lang.object[] r3 = new java.lang.object[]{r0, r1, r3, r4}
            goto L6e
        L52:
            goto L5e
        L55:
            java.lang.string r1 = r2.appId
            goto L4a
        L5b:
            goto L7
        L5e:
            goto L43
        L62:
            goto L6a
        L65:
            goto L37
        L69:
            return r2
        L6a:
            goto L4
        L6e:
            java.lang.string r4 = "%s_%s_%s_%s.json"
            goto L74
        L74:
            java.lang.string r3 = QEiVzjARJlZWsRcV(r4, r3)
            goto L7c
        L7c:
            java.util.concurrent.ScheduledTaskScheduler r4 = r2.executor
            goto L3d
    }

    private com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler GetGetHandler(com.google.firebase.remoteconfig.internal.ConfigCacheClient r2, com.google.firebase.remoteconfig.internal.ConfigCacheClient r3) {
            r1 = this;
            goto L10
        L4:
            com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler r0 = new com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler
            goto La
        La:
            java.util.concurrent.ScheduledTaskScheduler r1 = r1.executor
            goto L1a
        L10:
            goto L22
        L13:
            goto L4
        L17:
            goto L13
        L1a:
            r0.<init>(r1, r2, r3)
            goto L21
        L21:
            return r0
        L22:
            goto L17
    }

    private static com.google.firebase.remoteconfig.internal.Personalization GetPersonalization(com.google.firebase.FirebaseApp r0, java.lang.string r1, com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> r2) {
            goto L34
        L4:
            java.lang.string r0 = "firebase"
            goto L2c
        La:
            if (r0 != 0) goto Lf
            goto L1b
        Lf:
            goto L4
        L13:
            r0.<init>(r2)
            goto L1a
        L1a:
            return r0
        L1b:
            goto L1f
        L1f:
            r0 = 0
            goto L27
        L24:
            goto L37
        L27:
            return r0
        L28:
            goto L24
        L2c:
            bool r0 = ixkKpQPVzUPTXSTo(r1, r0)
            goto L49
        L34:
            goto L28
        L37:
            goto L41
        L3b:
            com.google.firebase.remoteconfig.internal.Personalization r0 = new com.google.firebase.remoteconfig.internal.Personalization
            goto L13
        L41:
            bool r0 = NgrvnDmoCaUvJiix(r0)
            goto La
        L49:
            if (r0 != 0) goto L4e
            goto L1b
        L4e:
            goto L3b
    }

    private com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler GetRolloutsStateSubscriptionsHandler(com.google.firebase.remoteconfig.internal.ConfigCacheClient r2, com.google.firebase.remoteconfig.internal.ConfigCacheClient r3) {
            r1 = this;
            goto L27
        L4:
            goto L2a
        L7:
            java.util.concurrent.ScheduledTaskScheduler r1 = r1.executor
            goto Ld
        Ld:
            r0.<init>(r2, r3, r1)
            goto L22
        L14:
            com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateFactory r3 = KkVEyCYDvUFNWJEI(r2, r3)
            goto L1c
        L1c:
            com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler r0 = new com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler
            goto L7
        L22:
            return r0
        L23:
            goto L4
        L27:
            goto L23
        L2a:
            goto L14
    }

    static com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient GetSharedPrefsClient(android.content.object r2, java.lang.string r3, java.lang.string r4) {
            goto L23
        L4:
            java.lang.object[] r3 = new java.lang.object[]{r0, r3, r4, r1}
            goto L2a
        Lc:
            goto L26
        Lf:
            if (r0 <= 0) goto L14
            goto L7c
        L14:
            goto L79
        L18:
            int r0 = r0 % r1
            goto Lf
        L1e:
            r4 = 0
            goto L71
        L23:
            goto L66
        L26:
            goto L3b
        L2a:
            java.lang.string r4 = "%s_%s_%s_%s"
            goto L54
        L30:
            int r0 = r0 + r1
            goto L18
        L36:
            return r3
        L37:
            goto L63
        L3b:
            r0 = 4
            goto L5c
        L42:
            java.lang.string r1 = "settings"
            goto L4
        L48:
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r3 = new com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient
            goto L6a
        L4e:
            java.lang.string r0 = "frc"
            goto L42
        L54:
            java.lang.string r3 = tkdvxmKIYLIbzloN(r4, r3)
            goto L1e
        L5c:
            r1 = 30
            goto L30
        L63:
            goto L7c
        L66:
            goto Lc
        L6a:
            r3.<init>(r2)
            goto L36
        L71:
            android.content.Dictionary<string, object> r2 = HNEwcGChDeFTBKqa(r2, r3, r4)
            goto L48
        L79:
            goto L37
        L7c:
            goto L4e
    }

    public static com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler HWrZXYQWWFYcZiTA(com.google.firebase.remoteconfig.RemoteConfigComponent r1, com.google.firebase.FirebaseApp r2, com.google.firebase.installations.FirebaseInstallationsApi r3, com.google.firebase.remoteconfig.internal.ConfigFetchHandler r4, com.google.firebase.remoteconfig.internal.ConfigCacheClient r5, android.content.object r6, java.lang.string r7, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r8) {
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
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler r0 = r1.getRealtime(r2, r3, r4, r5, r6, r7, r8)
            goto Le
    }

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig IJdeuKchnukmmKRO(com.google.firebase.remoteconfig.RemoteConfigComponent r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.firebase.remoteconfig.FirebaseRemoteConfig r0 = r1[r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.firebase.FirebaseOptions IQXgAVFrpwFyxOBQ(com.google.firebase.FirebaseApp r1) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.firebase.FirebaseOptions r0 = r1.getOptions()
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

    public static com.google.firebase.remoteconfig.internal.ConfigCacheClient InihJbULQfXYhbuo(java.util.concurrent.Executor r1, com.google.firebase.remoteconfig.internal.ConfigStorageClient r2) {
            goto Lf
        L4:
            com.google.firebase.remoteconfig.internal.ConfigCacheClient r0 = com.google.firebase.remoteconfig.internal.ConfigCacheClient.getInstance(r1, r2)
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

    private static bool IsAbtSupported(com.google.firebase.FirebaseApp r1, java.lang.string r2) {
            goto L43
        L4:
            if (r2 != 0) goto L9
            goto L28
        L9:
            goto L1a
        Ld:
            r1 = 1
            goto L27
        L12:
            bool r2 = uOfLMXKAWDHdRuWS(r2, r0)
            goto L4
        L1a:
            bool r1 = oQjmINwsaxtgMtjA(r1)
            goto L32
        L22:
            return r1
        L23:
            goto L3b
        L27:
            return r1
        L28:
            goto L3e
        L2c:
            java.lang.string r0 = "firebase"
            goto L12
        L32:
            if (r1 != 0) goto L37
            goto L28
        L37:
            goto Ld
        L3b:
            goto L46
        L3e:
            r1 = 0
            goto L22
        L43:
            goto L23
        L46:
            goto L2c
    }

    private static bool IsPrimaryApp(com.google.firebase.FirebaseApp r1) {
            goto L22
        L4:
            java.lang.string r1 = WayqvlGtRzcnsQGJ(r1)
            goto L1c
        Lc:
            return r1
        Ld:
            goto L19
        L11:
            bool r1 = YGPuJJBSQpWvXShO(r1, r0)
            goto Lc
        L19:
            goto L25
        L1c:
            java.lang.string r0 = "[DEFAULT]"
            goto L11
        L22:
            goto Ld
        L25:
            goto L4
    }

    public static bool IxkKpQPVzUPTXSTo(java.lang.string r1, java.lang.object r2) {
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
            bool r0 = r1.Equals(r2)
            goto L4
    }

    static /* synthetic */ com.google.firebase.analytics.connector.AnalyticsConnector lambda$getFetchHandler$0() {
            goto L7
        L4:
            goto La
        L7:
            goto L14
        La:
            goto Le
        Le:
            r0 = 0
            goto L13
        L13:
            return r0
        L14:
            goto L4
    }

    private static void NotifyRCInstances(bool r3) {
            goto L1d
        L4:
            java.lang.Class<com.google.firebase.remoteconfig.RemoteConfigComponent> r0 = com.google.firebase.remoteconfig.RemoteConfigComponent.class
            goto L5b
        La:
            goto L3e
        Ld:
            goto L4
        L11:
            return
        L12:
            r3 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L12
            goto L3d
        L18:
            goto L66
        L19:
            goto L56
        L1d:
            goto L30
        L20:
            goto L42
        L24:
            int r0 = r0 % r1
            goto L34
        L2a:
            goto L20
        L2d:
            goto Ld
        L30:
            goto L2a
        L34:
            if (r0 <= 0) goto L39
            goto Ld
        L39:
            goto La
        L3d:
            throw r3
        L3e:
            goto L2d
        L42:
            r0 = 10
            goto L4f
        L49:
            int r0 = r0 + r1
            goto L24
        L4f:
            r1 = 5
            goto L49
        L56:
            monitor-exit(r0)
            goto L11
        L5b:
            monitor-enter(r0)
            java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.FirebaseRemoteConfig> r1 = com.google.firebase.remoteconfig.RemoteConfigComponent.frcNamespaceInstancesStatic     // Catch: java.lang.Exception -> L12
            java.util.ICollection r1 = rQnQlkTowYSUnSIS(r1)     // Catch: java.lang.Exception -> L12
            java.util.IEnumerator r1 = ortAnpFSEJgCOqYc(r1)     // Catch: java.lang.Exception -> L12
        L66:
            bool r2 = HoiLMqtulrLDQpio(r1)     // Catch: java.lang.Exception -> L12
            if (r2 == 0) goto L19
            java.lang.object r2 = XdaaZuzZuZcSDqYB(r1)     // Catch: java.lang.Exception -> L12
            com.google.firebase.remoteconfig.FirebaseRemoteConfig r2 = (com.google.firebase.remoteconfig.FirebaseRemoteConfig) r2     // Catch: java.lang.Exception -> L12
            CTKuNNXDjPPqcdiI(r2, r3)     // Catch: java.lang.Exception -> L12
            goto L18
    }

    public static bool OQjmINwsaxtgMtjA(com.google.firebase.FirebaseApp r1) {
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
            bool r0 = isPrimaryApp(r1)
            goto Lb
    }

    public static java.util.IEnumerator OrtAnpFSEJgCOqYc(java.util.ICollection r1) {
            goto Lf
        L4:
            goto L12
        L7:
            java.util.IEnumerator r0 = r1.GetEnumerator()
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

    public static com.google.firebase.remoteconfig.internal.Personalization QXmHCoglsPquZSyg(com.google.firebase.FirebaseApp r1, java.lang.string r2, com.google.firebase.inject.Provider r3) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.firebase.remoteconfig.internal.Personalization r0 = getPersonalization(r1, r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.util.ICollection RQnQlkTowYSUnSIS(java.util.Dictionary r1) {
            goto L14
        L4:
            java.util.ICollection r0 = r1.Values
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

    public static com.google.firebase.remoteconfig.internal.ConfigCacheClient SrPYbwdoCafRGmuP(com.google.firebase.remoteconfig.RemoteConfigComponent r1, java.lang.string r2, java.lang.string r3) {
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
            com.google.firebase.remoteconfig.internal.ConfigCacheClient r0 = r1.getCacheClient(r2, r3)
            goto L7
    }

    public static java.lang.string TkdvxmKIYLIbzloN(java.lang.string r1, java.lang.object[] r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.string r0 = java.lang.string.format(r1, r2)
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

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig UEgChskLTXZLLwLd(com.google.firebase.remoteconfig.RemoteConfigComponent r1, com.google.firebase.FirebaseApp r2, java.lang.string r3, com.google.firebase.installations.FirebaseInstallationsApi r4, com.google.firebase.abt.FirebaseABTesting r5, java.util.concurrent.Executor r6, com.google.firebase.remoteconfig.internal.ConfigCacheClient r7, com.google.firebase.remoteconfig.internal.ConfigCacheClient r8, com.google.firebase.remoteconfig.internal.ConfigCacheClient r9, com.google.firebase.remoteconfig.internal.ConfigFetchHandler r10, com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler r11, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r12, com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler r13) {
            goto L14
        L4:
            com.google.firebase.remoteconfig.FirebaseRemoteConfig r0 = r1[r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13)
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

    public static com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient UHbPwruwkiSHNgTB(com.google.firebase.remoteconfig.RemoteConfigComponent r1, java.lang.string r2, java.lang.string r3, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r4) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient r0 = r1.getFrcBackendApiClient(r2, r3, r4)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.firebase.remoteconfig.internal.ConfigStorageClient ULZfBvNAekWRpfmx(android.content.object r1, java.lang.string r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.firebase.remoteconfig.internal.ConfigStorageClient r0 = com.google.firebase.remoteconfig.internal.ConfigStorageClient.getInstance(r1, r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static bool UOfLMXKAWDHdRuWS(java.lang.string r1, java.lang.object r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            bool r0 = r1.Equals(r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.string USRjHiwtZEfWMDHv(com.google.firebase.FirebaseOptions r1) {
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

    public static com.google.firebase.remoteconfig.FirebaseRemoteConfig UvAISEbsgWGMouDd(com.google.firebase.remoteconfig.RemoteConfigComponent r1, java.lang.string r2) {
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
            com.google.firebase.remoteconfig.FirebaseRemoteConfig r0 = r1[r2)
            goto Le
    }

    public static com.google.firebase.FirebaseOptions VSOSBWRztlPjfrlN(com.google.firebase.FirebaseApp r1) {
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

    public static void YfFpWoDTBkagyUHh(android.content.object r0) {
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
            com.google.firebase.remoteconfig.RemoteConfigComponent.GlobalBackgroundListener.access$000(r0)
            goto L4
    }

    public static bool YjlVHVOmoUKvamkn(com.google.firebase.FirebaseApp r1, java.lang.string r2) {
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
            bool r0 = isAbtSupported(r1, r2)
            goto Lb
    }

    public static void ZaiueTcHylfJnegc(com.google.firebase.remoteconfig.FirebaseRemoteConfig r0) {
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
            r0.startLoadingConfigsFromDisk()
            goto L4
    }

    synchronized com.google.firebase.remoteconfig.FirebaseRemoteConfig Get(com.google.firebase.FirebaseApp r17, java.lang.string r18, com.google.firebase.installations.FirebaseInstallationsApi r19, com.google.firebase.abt.FirebaseABTesting r20, java.util.concurrent.Executor r21, com.google.firebase.remoteconfig.internal.ConfigCacheClient r22, com.google.firebase.remoteconfig.internal.ConfigCacheClient r23, com.google.firebase.remoteconfig.internal.ConfigCacheClient r24, com.google.firebase.remoteconfig.internal.ConfigFetchHandler r25, com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler r26, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r27, com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler r28) {
            r16 = this;
            goto Lec
        L4:
            r2 = r9
            goto L3e
        L9:
            r4 = r19
            goto L88
        Lf:
            if (r0 <= 0) goto L14
            goto Ld6
        L14:
            goto Ld3
        L18:
            r15 = r1
            goto L38
        L1d:
            r7 = r18
            goto L95
        L23:
            r8 = r23
            goto L4f
        L29:
            r12 = r27
            goto L49
        L2f:
            goto Lef
        L32:
            throw r0
        L33:
            r0 = move-exception
            goto L7c
        L38:
            r3 = r17
            goto L9
        L3e:
            r5 = r10
            goto Lfe
        L43:
            int r0 = r0 % r1
            goto Lf
        L49:
            r14 = r28
            goto Lf9
        L4f:
            r11 = r26
            goto L29
        L55:
            r10 = r25
            r1.<init>(r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13, r14)     // Catch: java.lang.Exception -> L33
            zaiueTcHylfJnegc(r1)     // Catch: java.lang.Exception -> L33
            java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.FirebaseRemoteConfig> r2 = r15.frcNamespaceInstances     // Catch: java.lang.Exception -> L33
            ONsRpbsDmmhVZQsd(r2, r0, r1)     // Catch: java.lang.Exception -> L33
            java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.FirebaseRemoteConfig> r2 = com.google.firebase.remoteconfig.RemoteConfigComponent.frcNamespaceInstancesStatic     // Catch: java.lang.Exception -> L33
            HsRVSndzmeIscfvn(r2, r0, r1)     // Catch: java.lang.Exception -> L33
            goto L6a
        L68:
            r15 = r1
            r0 = r7
        L6a:
            java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.FirebaseRemoteConfig> r1 = r15.frcNamespaceInstances     // Catch: java.lang.Exception -> L33
            java.lang.object r0 = YMBkCBCDmfSMzPgJ(r1, r0)     // Catch: java.lang.Exception -> L33
            com.google.firebase.remoteconfig.FirebaseRemoteConfig r0 = (com.google.firebase.remoteconfig.FirebaseRemoteConfig) r0     // Catch: java.lang.Exception -> L33
            goto Lc1
        L76:
            r7 = r22
            goto L23
        L7c:
            goto Ldb
        L7d:
            goto L8e
        L81:
            r1 = 29
            goto Le6
        L88:
            r6 = r21
            goto L76
        L8e:
            goto Ld6
        L91:
            goto L2f
        L95:
            monitor-enter(r16)
            java.util.Dictionary<java.lang.string, com.google.firebase.remoteconfig.FirebaseRemoteConfig> r0 = r1.frcNamespaceInstances     // Catch: java.lang.Exception -> Lc7
            bool r0 = btlWVYyAcEknOUyD(r0, r7)     // Catch: java.lang.Exception -> Lc7
            if (r0 != 0) goto L68
            com.google.firebase.remoteconfig.FirebaseRemoteConfig r0 = new com.google.firebase.remoteconfig.FirebaseRemoteConfig     // Catch: java.lang.Exception -> Lc7
            android.content.object r9 = r1.context     // Catch: java.lang.Exception -> Lc7
            bool r2 = yjlVHVOmoUKvamkn(r17, r18)     // Catch: java.lang.Exception -> Lc7
            if (r2 == 0) goto Lab
            r10 = r20
            goto Lad
        Lab:
            r2 = 0
            r10 = r2
        Lad:
            android.content.object r6 = r1.context     // Catch: java.lang.Exception -> Lc7
            r2 = r17
            r3 = r19
            r5 = r23
            r4 = r25
            r8 = r27
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler r13 = hWrZXYQWWFYcZiTA(r1, r2, r3, r4, r5, r6, r7, r8)     // Catch: java.lang.Exception -> Lc7
            goto L18
        Lc1:
            monitor-exit(r16)
            goto Lc6
        Lc6:
            return r0
        Lc7:
            r0 = move-exception
            goto Lda
        Lcc:
            r0 = 32
            goto L81
        Ld3:
            goto L7d
        Ld6:
            goto Le0
        Lda:
            r15 = r1
        Ldb:
            monitor-exit(r16)     // Catch: java.lang.Exception -> L33
            goto L32
        Le0:
            r1 = r16
            goto L1d
        Le6:
            int r0 = r0 + r1
            goto L43
        Lec:
            goto L91
        Lef:
            goto Lcc
        Lf3:
            r9 = r24
            goto L55
        Lf9:
            r1 = r0
            goto L4
        Lfe:
            r0 = r18
            goto Lf3
    }

    public com.google.firebase.remoteconfig.FirebaseRemoteConfig Get(java.lang.string r15) {
            r14 = this;
            goto L77
        L4:
            r0 = 18
            goto Lcb
        Lb:
            r1 = r14
            goto L58
        L10:
            goto L62
        L13:
            goto L87
        L17:
            if (r0 != 0) goto L1c
            goto L37
        L1c:
            IbZJOOVdiugdIfel(r0)     // Catch: java.lang.Exception -> Lb3
            com.google.firebase.remoteconfig.RemoteConfigComponent$$ExternalSyntheticLambda0 r1 = new com.google.firebase.remoteconfig.RemoteConfigComponent$$ExternalSyntheticLambda0     // Catch: java.lang.Exception -> Lb3
            r1.<init>(r0)     // Catch: java.lang.Exception -> Lb3
            VYUrfydOwVAEJhmv(r11, r1)     // Catch: java.lang.Exception -> Lb3
            goto Lb2
        L2b:
            r1 = r14
        L2c:
            goto L30
        L30:
            r15 = r0
        L31:
            monitor-exit(r1)     // Catch: java.lang.Exception -> L6c
            goto L6b
        L36:
            goto L31
        L37:
            com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler r13 = FvpnCuGhCdSqZYXd(r14, r8, r9)     // Catch: java.lang.Exception -> L53
            com.google.firebase.FirebaseApp r2 = r14.firebaseApp     // Catch: java.lang.Exception -> L53
            com.google.firebase.installations.FirebaseInstallationsApi r4 = r14.firebaseInstallations     // Catch: java.lang.Exception -> L53
            com.google.firebase.abt.FirebaseABTesting r5 = r14.firebaseAbt     // Catch: java.lang.Exception -> L53
            java.util.concurrent.ScheduledTaskScheduler r6 = r14.executor     // Catch: java.lang.Exception -> L53
            com.google.firebase.remoteconfig.internal.ConfigFetchHandler r10 = XReAsVdqjcBXHtAt(r14, r15, r7, r12)     // Catch: java.lang.Exception -> L53
            goto Lb
        L4b:
            goto L13
        L4e:
            goto Lbd
        L52:
            return r14
        L53:
            r0 = move-exception
            goto L2b
        L58:
            r3 = r15
            com.google.firebase.remoteconfig.FirebaseRemoteConfig r14 = uEgChskLTXZLLwLd(r1, r2, r3, r4, r5, r6, r7, r8, r9, r10, r11, r12, r13)     // Catch: java.lang.Exception -> L6c
            goto L66
        L61:
            goto L2c
        L62:
            goto L4b
        L66:
            monitor-exit(r1)
            goto L52
        L6b:
            throw r15
        L6c:
            r0 = move-exception
            goto L61
        L71:
            int r0 = r0 % r1
            goto L7e
        L77:
            goto L4e
        L7a:
            goto L4
        L7e:
            if (r0 <= 0) goto L83
            goto L13
        L83:
            goto L10
        L87:
            monitor-enter(r14)
            java.lang.string r0 = "fetch"
            com.google.firebase.remoteconfig.internal.ConfigCacheClient r7 = FggjwagUFLOFyehI(r14, r15, r0)     // Catch: java.lang.Exception -> L53
            java.lang.string r0 = "activate"
            com.google.firebase.remoteconfig.internal.ConfigCacheClient r8 = srPYbwdoCafRGmuP(r14, r15, r0)     // Catch: java.lang.Exception -> L53
            java.lang.string r0 = "defaults"
            com.google.firebase.remoteconfig.internal.ConfigCacheClient r9 = AwdRkHjdbiJWXjCK(r14, r15, r0)     // Catch: java.lang.Exception -> L53
            android.content.object r0 = r14.context     // Catch: java.lang.Exception -> L53
            java.lang.string r1 = r14.appId     // Catch: java.lang.Exception -> L53
            com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r12 = XCvzSTXkWKsOtRYs(r0, r1, r15)     // Catch: java.lang.Exception -> L53
            com.google.firebase.remoteconfig.internal.ConfigGetParameterHandler r11 = RSMNViQshSgmaaia(r14, r8, r9)     // Catch: java.lang.Exception -> L53
            com.google.firebase.FirebaseApp r0 = r14.firebaseApp     // Catch: java.lang.Exception -> L53
            com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> r1 = r14.analyticsConnector     // Catch: java.lang.Exception -> L53
            com.google.firebase.remoteconfig.internal.Personalization r0 = qXmHCoglsPquZSyg(r0, r15, r1)     // Catch: java.lang.Exception -> L53
            goto L17
        Lb2:
            goto L37
        Lb3:
            r0 = move-exception
            goto Lb8
        Lb8:
            r15 = r0
            goto Lc6
        Lbd:
            goto L7a
        Lc0:
            int r0 = r0 + r1
            goto L71
        Lc6:
            r1 = r14
            goto L36
        Lcb:
            r1 = 31
            goto Lc0
    }

    com.google.firebase.remoteconfig.FirebaseRemoteConfig getDefault() {
            r1 = this;
            goto L14
        L4:
            return r1
        L5:
            goto L11
        L9:
            com.google.firebase.remoteconfig.FirebaseRemoteConfig r1 = uvAISEbsgWGMouDd(r1, r0)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L1b
        L1b:
            java.lang.string r0 = "firebase"
            goto L9
    }

    synchronized com.google.firebase.remoteconfig.internal.ConfigFetchHandler GetFetchHandler(java.lang.string r11, com.google.firebase.remoteconfig.internal.ConfigCacheClient r12, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r13) {
            r10 = this;
            goto L7
        L4:
            goto La
        L7:
            goto L20
        La:
            goto L24
        Le:
            if (r0 <= 0) goto L13
            goto L2e
        L13:
            goto L2b
        L17:
            return r0
        L18:
            r0 = move-exception
            goto L77
        L1d:
            goto L2e
        L20:
            goto L4
        L24:
            r0 = 19
            goto L7d
        L2b:
            goto L73
        L2e:
            goto L32
        L32:
            monitor-enter(r10)
            com.google.firebase.remoteconfig.internal.ConfigFetchHandler r0 = new com.google.firebase.remoteconfig.internal.ConfigFetchHandler     // Catch: java.lang.Exception -> L18
            com.google.firebase.installations.FirebaseInstallationsApi r1 = r10.firebaseInstallations     // Catch: java.lang.Exception -> L18
            com.google.firebase.FirebaseApp r2 = r10.firebaseApp     // Catch: java.lang.Exception -> L18
            bool r2 = RUAjiPrVlZHOItUP(r2)     // Catch: java.lang.Exception -> L18
            if (r2 == 0) goto L42
            com.google.firebase.inject.Provider<com.google.firebase.analytics.connector.AnalyticsConnector> r2 = r10.analyticsConnector     // Catch: java.lang.Exception -> L18
            goto L47
        L42:
            com.google.firebase.remoteconfig.RemoteConfigComponent$$ExternalSyntheticLambda2 r2 = new com.google.firebase.remoteconfig.RemoteConfigComponent$$ExternalSyntheticLambda2     // Catch: java.lang.Exception -> L18
            r2.<init>()     // Catch: java.lang.Exception -> L18
        L47:
            java.util.concurrent.ScheduledTaskScheduler r3 = r10.executor     // Catch: java.lang.Exception -> L18
            com.google.android.gms.common.util.Clock r4 = com.google.firebase.remoteconfig.RemoteConfigComponent.DEFAULT_CLOCK     // Catch: java.lang.Exception -> L18
            java.util.Random r5 = com.google.firebase.remoteconfig.RemoteConfigComponent.DEFAULT_RANDOM     // Catch: java.lang.Exception -> L18
            com.google.firebase.FirebaseApp r6 = r10.firebaseApp     // Catch: java.lang.Exception -> L18
            com.google.firebase.FirebaseOptions r6 = iQXgAVFrpwFyxOBQ(r6)     // Catch: java.lang.Exception -> L18
            java.lang.string r6 = uSRjHiwtZEfWMDHv(r6)     // Catch: java.lang.Exception -> L18
            com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient r7 = uHbPwruwkiSHNgTB(r10, r6, r11, r13)     // Catch: java.lang.Exception -> L18
            java.util.Dictionary<java.lang.string, java.lang.string> r9 = r10.customHeaders     // Catch: java.lang.Exception -> L18
            r6 = r12
            r8 = r13
            r0.<init>(r1, r2, r3, r4, r5, r6, r7, r8, r9)     // Catch: java.lang.Exception -> L18
            goto L84
        L66:
            int r0 = r0 + r1
            goto L6c
        L6c:
            int r0 = r0 % r1
            goto Le
        L72:
            throw r11
        L73:
            goto L1d
        L77:
            r11 = r0
            monitor-exit(r10)     // Catch: java.lang.Exception -> L18
            goto L72
        L7d:
            r1 = 25
            goto L66
        L84:
            monitor-exit(r10)
            goto L17
    }

    com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient getFrcBackendApiClient(java.lang.string r11, java.lang.string r12, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r13) {
            r10 = this;
            goto Lf
        L4:
            r4 = r11
            goto L67
        L9:
            com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient r1 = new com.google.firebase.remoteconfig.internal.ConfigFetchHttpClient
            goto L6c
        Lf:
            goto L83
        L12:
            goto L1e
        L16:
            com.google.firebase.FirebaseOptions r0 = vSOSBWRztlPjfrlN(r0)
            goto L2e
        L1e:
            r0 = 30
            goto L72
        L25:
            if (r0 <= 0) goto L2a
            goto L5a
        L2a:
            goto L57
        L2e:
            java.lang.string r3 = axhoAaVBwmsgGviz(r0)
            goto L9
        L36:
            return r1
        L37:
            goto L80
        L3b:
            long r8 = ZlKhpYfwPGnxPMfz(r13)
            goto L4
        L43:
            int r0 = r0 % r1
            goto L25
        L49:
            long r6 = CTqEeskDwJHMABXK(r13)
            goto L3b
        L51:
            com.google.firebase.FirebaseApp r0 = r10.firebaseApp
            goto L16
        L57:
            goto L37
        L5a:
            goto L51
        L5e:
            goto L12
        L61:
            int r0 = r0 + r1
            goto L43
        L67:
            r5 = r12
            goto L79
        L6c:
            android.content.object r2 = r10.context
            goto L49
        L72:
            r1 = 7
            goto L61
        L79:
            r1.<init>(r2, r3, r4, r5, r6, r8)
            goto L36
        L80:
            goto L5a
        L83:
            goto L5e
    }

    synchronized com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler GetRealtime(com.google.firebase.FirebaseApp r10, com.google.firebase.installations.FirebaseInstallationsApi r11, com.google.firebase.remoteconfig.internal.ConfigFetchHandler r12, com.google.firebase.remoteconfig.internal.ConfigCacheClient r13, android.content.object r14, java.lang.string r15, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r16) {
            r9 = this;
            goto Lb
        L4:
            r1 = 17
            goto L36
        Lb:
            goto L15
        Le:
            goto L4e
        L12:
            goto L32
        L15:
            goto L45
        L19:
            r10 = r0
            monitor-exit(r9)     // Catch: java.lang.Exception -> L2a
            goto L1f
        L1f:
            throw r10
        L20:
            goto L12
        L24:
            monitor-exit(r9)
            goto L29
        L29:
            return r0
        L2a:
            r0 = move-exception
            goto L19
        L2f:
            goto L20
        L32:
            goto L55
        L36:
            int r0 = r0 + r1
            goto L48
        L3c:
            if (r0 <= 0) goto L41
            goto L32
        L41:
            goto L2f
        L45:
            goto Le
        L48:
            int r0 = r0 % r1
            goto L3c
        L4e:
            r0 = 22
            goto L4
        L55:
            monitor-enter(r9)
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler r0 = new com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler     // Catch: java.lang.Exception -> L2a
            java.util.concurrent.ScheduledTaskScheduler r8 = r9.executor     // Catch: java.lang.Exception -> L2a
            r1 = r10
            r2 = r11
            r3 = r12
            r4 = r13
            r5 = r14
            r6 = r15
            r7 = r16
            r0.<init>(r1, r2, r3, r4, r5, r6, r7, r8)     // Catch: java.lang.Exception -> L2a
            goto L24
    }

    @Override // com.google.firebase.remoteconfig.interop.FirebaseRemoteConfigInterop
    public void RegisterRolloutsStateSubscriber(java.lang.string r1, com.google.firebase.remoteconfig.interop.rollouts.RolloutsStateSubscriber r2) {
            r0 = this;
            goto Lc
        L4:
            com.google.firebase.remoteconfig.FirebaseRemoteConfig r0 = iJdeuKchnukmmKRO(r0, r1)
            goto L13
        Lc:
            goto L1c
        Lf:
            goto L4
        L13:
            com.google.firebase.remoteconfig.internal.rollouts.RolloutsStateSubscriptionsHandler r0 = HoVoYelfalmTKtdb(r0)
            goto L20
        L1b:
            return
        L1c:
            goto L27
        L20:
            XTdZAYkcrCOeQaTA(r0, r2)
            goto L1b
        L27:
            goto Lf
    }

    public void SetCustomHeaders(java.util.Dictionary<java.lang.string, java.lang.string> r1) {
            r0 = this;
            goto Le
        L4:
            monitor-exit(r0)
            goto L15
        L9:
            throw r1
        La:
            goto L23
        Le:
            goto La
        L11:
            goto L1c
        L15:
            return
        L16:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L16
            goto L9
        L1c:
            monitor-enter(r0)
            r0.customHeaders = r1     // Catch: java.lang.Exception -> L16
            goto L4
        L23:
            goto L11
    }
}

