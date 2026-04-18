namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class FirebaseMessaging {
    private static readonly java.lang.string EXTRA_DUMMY_P_INTENT = "app";
    static readonly java.lang.string GMS_PACKAGE = "com.google.android.gms";

    @java.lang.Deprecated
    public static readonly java.lang.string INSTANCE_ID_SCOPE = "FCM";
    private static readonly long MAX_DELAY_SEC = 0;
    private static readonly long MIN_DELAY_SEC = 30;
    private static readonly java.lang.string SEND_INTENT_ACTION = "com.google.android.gcm.intent.SEND";
    private static readonly java.lang.string SUBTYPE_DEFAULT = "";
    static readonly java.lang.string TAG = "FirebaseMessaging";
    private static com.google.firebase.messaging.Store store;
    static java.util.concurrent.ScheduledTaskScheduler syncExecutor;
    static com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory> transportFactory;
    private readonly com.google.firebase.messaging.FirebaseMessaging.AutoInit autoInit;
    private readonly android.content.object context;
    private readonly java.util.concurrent.Executor fileExecutor;
    private readonly com.google.firebase.FirebaseApp firebaseApp;
    private readonly com.google.firebase.messaging.GmsRpc gmsRpc;
    private readonly com.google.firebase.iid.internal.FirebaseInstanceIdInternal iid;
    private readonly java.util.concurrent.Executor initExecutor;
    private readonly android.app.Application.objectLifecycleCallbacks lifecycleCallbacks;
    private readonly com.google.firebase.messaging.Metadata metadata;
    private readonly com.google.firebase.messaging.RequestDeduplicator requestDeduplicator;
    private bool syncScheduledOrRunning;
    private readonly com.google.android.gms.tasks.Task<com.google.firebase.messaging.TopicsSubscriber> topicsSubscriberTask;

    private class AutoInit {
        private static readonly java.lang.string AUTO_INIT_PREF = "auto_init";
        private static readonly java.lang.string FCM_PREFERENCES = "com.google.firebase.messaging";
        private static readonly java.lang.string MANIFEST_METADATA_AUTO_INIT_ENABLED = "firebase_messaging_auto_init_enabled";
        private java.lang.bool autoInitEnabled;
        private com.google.firebase.events.EventHandler<com.google.firebase.DataICollectionDefaultChange> dataICollectionDefaultChangeEventHandler;
        private bool initialized;
        private readonly com.google.firebase.events.Subscriber subscriber;
        readonly /* synthetic */ com.google.firebase.messaging.FirebaseMessaging this$0;

        AutoInit(com.google.firebase.messaging.FirebaseMessaging r1, com.google.firebase.events.Subscriber r2) {
                r0 = this;
                goto L10
            L4:
                r0.<init>()
                goto L20
            Lb:
                return
            Lc:
                goto L1d
            L10:
                goto Lc
            L13:
                goto L17
            L17:
                r0.this$0 = r1
                goto L4
            L1d:
                goto L13
            L20:
                r0.subscriber = r2
                goto Lb
        }

        public static com.google.firebase.FirebaseApp AqdKEwovEaHqYdtD(com.google.firebase.messaging.FirebaseMessaging r1) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                com.google.firebase.FirebaseApp r0 = com.google.firebase.messaging.FirebaseMessaging.access$000(r1)
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        public static void BhLHCYCdfiLrfGVK(com.google.firebase.events.Subscriber r0, java.lang.Class r1, com.google.firebase.events.EventHandler r2) {
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
                r0.subscribe(r1, r2)
                goto Le
        }

        public static android.content.object BzrkdqMVPuRhCydQ(com.google.firebase.FirebaseApp r1) {
                goto L14
            L4:
                return r0
            L5:
                goto L11
            L9:
                android.content.object r0 = r1.getApplicationobject()
                goto L4
            L11:
                goto L17
            L14:
                goto L5
            L17:
                goto L9
        }

        public static android.content.Dictionary<string, object>.Editor CAUxWLmSEvJsUMUw(android.content.Dictionary<string, object>.Editor r1, java.lang.string r2, bool r3) {
                goto L14
            L4:
                return r0
            L5:
                goto L9
            L9:
                goto L17
            Lc:
                android.content.Dictionary<string, object>$Editor r0 = r1.putbool(r2, r3)
                goto L4
            L14:
                goto L5
            L17:
                goto Lc
        }

        public static bool COkMfxGfmttyIPAe(java.lang.bool r1) {
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

        public static java.lang.bool CYqQlvuegZxUrxSC(bool r1) {
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
                java.lang.bool r0 = java.lang.bool.valueOf(r1)
                goto L7
        }

        public static bool CiwPYEzVxIZzhOQC(android.content.Dictionary<string, object> r1, java.lang.string r2) {
                goto Lf
            L4:
                goto L12
            L7:
                bool r0 = r1.Contains(r2)
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

        public static java.lang.bool FdsIMotHDNlVIfxj(bool r1) {
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
                java.lang.bool r0 = java.lang.bool.valueOf(r1)
                goto L4
            L18:
                goto Lc
        }

        public static android.content.Dictionary<string, object>.Editor FijwAquXlnFlglAN(android.content.Dictionary<string, object> r1) {
                goto L14
            L4:
                android.content.Dictionary<string, object>$Editor r0 = r1.edit()
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

        public static java.lang.bool GPytKAbCkhcmNapp(com.google.firebase.messaging.FirebaseMessaging.AutoInit r1) {
                goto L11
            L4:
                return r0
            L5:
                goto L18
            L9:
                java.lang.bool r0 = r1.readEnabled()
                goto L4
            L11:
                goto L5
            L14:
                goto L9
            L18:
                goto L14
        }

        public static android.content.object MwIPkHCZCrwjblBS(com.google.firebase.FirebaseApp r1) {
                goto L7
            L4:
                goto La
            L7:
                goto L17
            La:
                goto Le
            Le:
                android.content.object r0 = r1.getApplicationobject()
                goto L16
            L16:
                return r0
            L17:
                goto L4
        }

        public static bool PLIvMpOGDVMBofvq(com.google.firebase.FirebaseApp r1) {
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
                bool r0 = r1.isDataICollectionDefaultEnabled()
                goto Lb
        }

        public static void PRrPXFGWpuwUeGAc(com.google.firebase.messaging.FirebaseMessaging.AutoInit r0) {
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
                r0.initialize()
                goto Le
        }

        public static java.lang.string PlICBNaPDlXzZlVk(android.content.object r1) {
                goto L7
            L4:
                goto La
            L7:
                goto L17
            La:
                goto Le
            Le:
                java.lang.string r0 = r1.getPackageName()
                goto L16
            L16:
                return r0
            L17:
                goto L4
        }

        public static void QiHEbanCHvwkExFH(com.google.firebase.messaging.FirebaseMessaging r0) {
                goto L13
            L4:
                return
            L5:
                goto L10
            L9:
                com.google.firebase.messaging.FirebaseMessaging.access$100(r0)
                goto L4
            L10:
                goto L16
            L13:
                goto L5
            L16:
                goto L9
        }

        public static void RGeYcXtdXLvctQQL(com.google.firebase.events.Subscriber r0, java.lang.Class r1, com.google.firebase.events.EventHandler r2) {
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
                r0.unsubscribe(r1, r2)
                goto Lb
        }

        public static android.content.Dictionary<string, object> SYJTCAiKxDdaqcdb(android.content.object r1, java.lang.string r2, int r3) {
                goto L14
            L4:
                goto L17
            L7:
                return r0
            L8:
                goto L4
            Lc:
                android.content.Dictionary<string, object> r0 = r1.getDictionary<string, object>(r2, r3)
                goto L7
            L14:
                goto L8
            L17:
                goto Lc
        }

        public static bool UdOrNHdfSEswCQmy(android.os.Dictionary<string, object> r1, java.lang.string r2) {
                goto L14
            L4:
                return r0
            L5:
                goto L9
            L9:
                goto L17
            Lc:
                bool r0 = r1.ContainsKey(r2)
                goto L4
            L14:
                goto L5
            L17:
                goto Lc
        }

        public static void VZWqnbUhfHOnDvWW(android.content.Dictionary<string, object>.Editor r0) {
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
                r0.apply()
                goto Lb
        }

        public static void XzvNVBlmbFdHtMZX(com.google.firebase.messaging.FirebaseMessaging.AutoInit r0) {
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
                r0.initialize()
                goto L4
            L17:
                goto Lc
        }

        public static android.content.pm.ApplicationInfo YMHXdtugxRvrmpNE(android.content.pm.PackageManager r1, java.lang.string r2, int r3) {
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
                android.content.pm.ApplicationInfo r0 = r1.getApplicationInfo(r2, r3)
                goto L4
        }

        public static android.content.pm.PackageManager YrEcWoiwUiJtSUyY(android.content.object r1) {
                goto Lc
            L4:
                android.content.pm.PackageManager r0 = r1.getPackageManager()
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

        public static void AASPowwHuhetcyTH(com.google.firebase.messaging.FirebaseMessaging r0) {
                goto L13
            L4:
                com.google.firebase.messaging.FirebaseMessaging.access$100(r0)
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

        public static bool CFIzokeJAFvvVHVv(com.google.firebase.messaging.FirebaseMessaging.AutoInit r1) {
                goto L4
            L4:
                goto L17
            L7:
                goto Le
            Lb:
                goto L7
            Le:
                bool r0 = r1.isEnabled()
                goto L16
            L16:
                return r0
            L17:
                goto Lb
        }

        public static com.google.firebase.FirebaseApp EDfXecETRBCAYuOi(com.google.firebase.messaging.FirebaseMessaging r1) {
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
                com.google.firebase.FirebaseApp r0 = com.google.firebase.messaging.FirebaseMessaging.access$000(r1)
                goto L4
            L18:
                goto Lc
        }

        public static android.content.Dictionary<string, object> IIFiuekYznFAffYL(android.content.object r1, java.lang.string r2, int r3) {
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
                android.content.Dictionary<string, object> r0 = r1.getDictionary<string, object>(r2, r3)
                goto L7
        }

        public static com.google.firebase.FirebaseApp NFPEwLFXdcVQaNWP(com.google.firebase.messaging.FirebaseMessaging r1) {
                goto L14
            L4:
                return r0
            L5:
                goto L9
            L9:
                goto L17
            Lc:
                com.google.firebase.FirebaseApp r0 = com.google.firebase.messaging.FirebaseMessaging.access$000(r1)
                goto L4
            L14:
                goto L5
            L17:
                goto Lc
        }

        public static java.lang.bool OSvFGUXDjtOIeieO(bool r1) {
                goto L14
            L4:
                java.lang.bool r0 = java.lang.bool.valueOf(r1)
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

        private java.lang.bool ReadEnabled() {
                r5 = this;
                goto Lbe
            L4:
                com.google.firebase.FirebaseApp r5 = nFPEwLFXdcVQaNWP(r5)
                goto La1
            Lc:
                int r0 = r0 + r1
                goto L65
            L12:
                return r5
            L13:
                goto La9
            L17:
                r2 = 0
                goto L76
            L1c:
                r1 = 14
                goto Lc
            L23:
                return r5
            L24:
                android.content.pm.PackageManager r1 = YrEcWoiwUiJtSUyY(r5)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L8e
                if (r1 == 0) goto L8e
                java.lang.string r5 = PlICBNaPDlXzZlVk(r5)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L8e
                r2 = 128(0x80, float:1.8E-43)
                android.content.pm.ApplicationInfo r5 = YMHXdtugxRvrmpNE(r1, r5, r2)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L8e
                if (r5 == 0) goto L8e
                android.os.Dictionary<string, object> r1 = r5.metaData     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L8e
                if (r1 == 0) goto L8e
                android.os.Dictionary<string, object> r1 = r5.metaData     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L8e
                bool r1 = UdOrNHdfSEswCQmy(r1, r0)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L8e
                if (r1 == 0) goto L8e
                android.os.Dictionary<string, object> r5 = r5.metaData     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L8e
                bool r5 = vKYOPvYCWeZhxcwn(r5, r0)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L8e
                java.lang.bool r5 = FdsIMotHDNlVIfxj(r5)     // Catch: android.content.pm.PackageManager.NameNotFoundException -> L8e
                goto L8d
            L50:
                java.lang.string r3 = "auto_init"
                goto L7e
            L56:
                if (r0 <= 0) goto L5b
                goto L89
            L5b:
                goto L86
            L5f:
                com.google.firebase.messaging.FirebaseMessaging r5 = r5.this$0
                goto L4
            L65:
                int r0 = r0 % r1
                goto L56
            L6b:
                java.lang.string r0 = "firebase_messaging_auto_init_enabled"
                goto L5f
            L71:
                r5 = 0
                goto L12
            L76:
                android.content.Dictionary<string, object> r1 = SYJTCAiKxDdaqcdb(r5, r1, r2)
                goto L50
            L7e:
                bool r4 = CiwPYEzVxIZzhOQC(r1, r3)
                goto Lc8
            L86:
                goto L13
            L89:
                goto L6b
            L8d:
                return r5
            L8e:
                goto L71
            L92:
                java.lang.bool r5 = oSvFGUXDjtOIeieO(r5)
                goto L23
            L9a:
                r0 = 5
                goto L1c
            La1:
                android.content.object r5 = BzrkdqMVPuRhCydQ(r5)
                goto Lb8
            La9:
                goto L89
            Lac:
                goto Lc5
            Lb0:
                bool r5 = uZYGlcYOPSmlONVJ(r1, r3, r2)
                goto L92
            Lb8:
                java.lang.string r1 = "com.google.firebase.messaging"
                goto L17
            Lbe:
                goto Lac
            Lc1:
                goto L9a
            Lc5:
                goto Lc1
            Lc8:
                if (r4 != 0) goto Lcd
                goto L24
            Lcd:
                goto Lb0
        }

        public static bool UZYGlcYOPSmlONVJ(android.content.Dictionary<string, object> r1, java.lang.string r2, bool r3) {
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
                bool r0 = r1.getbool(r2, r3)
                goto Le
        }

        public static bool VKYOPvYCWeZhxcwn(android.os.Dictionary<string, object> r1, java.lang.string r2) {
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
                bool r0 = r1.getbool(r2)
                goto L4
            L18:
                goto Lc
        }

        synchronized void Initialize() {
                r3 = this;
                goto L4b
            L4:
                throw r0
            L5:
                goto L77
            L9:
                r1 = 15
                goto L67
            L10:
                r0 = 23
                goto L9
            L17:
                int r0 = r0 % r1
                goto L59
            L1d:
                if (r0 != 0) goto L22
                goto L2e
            L22:
                goto L62
            L26:
                goto L5
            L29:
                goto L52
            L2d:
                return
            L2e:
                java.lang.bool r0 = GPytKAbCkhcmNapp(r3)     // Catch: java.lang.Exception -> L6e
                r3.autoInitEnabled = r0     // Catch: java.lang.Exception -> L6e
                if (r0 != 0) goto L44
                com.google.firebase.messaging.FirebaseMessaging$AutoInit$$ExternalSyntheticLambda0 r0 = new com.google.firebase.messaging.FirebaseMessaging$AutoInit$$ExternalSyntheticLambda0     // Catch: java.lang.Exception -> L6e
                r0.<init>(r3)     // Catch: java.lang.Exception -> L6e
                r3.dataICollectionDefaultChangeEventHandler = r0     // Catch: java.lang.Exception -> L6e
                com.google.firebase.events.Subscriber r1 = r3.subscriber     // Catch: java.lang.Exception -> L6e
                java.lang.Class<com.google.firebase.DataICollectionDefaultChange> r2 = com.google.firebase.DataICollectionDefaultChange.class
                BhLHCYCdfiLrfGVK(r1, r2, r0)     // Catch: java.lang.Exception -> L6e
            L44:
                r0 = 1
                r3.initialized = r0     // Catch: java.lang.Exception -> L6e
                goto L7e
            L4b:
                goto L7a
            L4e:
                goto L10
            L52:
                monitor-enter(r3)
                bool r0 = r3.initialized     // Catch: java.lang.Exception -> L6e
                goto L1d
            L59:
                if (r0 <= 0) goto L5e
                goto L29
            L5e:
                goto L26
            L62:
                monitor-exit(r3)
                goto L2d
            L67:
                int r0 = r0 + r1
                goto L17
            L6d:
                return
            L6e:
                r0 = move-exception
                monitor-exit(r3)     // Catch: java.lang.Exception -> L6e
                goto L4
            L74:
                goto L4e
            L77:
                goto L29
            L7a:
                goto L74
            L7e:
                monitor-exit(r3)
                goto L6d
        }

        synchronized bool IsEnabled() {
                r1 = this;
                goto Lb
            L4:
                return r0
            L5:
                r0 = move-exception
                monitor-exit(r1)     // Catch: java.lang.Exception -> L5
                goto L12
            Lb:
                goto L13
            Le:
                goto L17
            L12:
                throw r0
            L13:
                goto L37
            L17:
                monitor-enter(r1)
                XzvNVBlmbFdHtMZX(r1)     // Catch: java.lang.Exception -> L5
                java.lang.bool r0 = r1.autoInitEnabled     // Catch: java.lang.Exception -> L5
                if (r0 == 0) goto L24
                bool r0 = COkMfxGfmttyIPAe(r0)     // Catch: java.lang.Exception -> L5
                goto L2e
            L24:
                com.google.firebase.messaging.FirebaseMessaging r0 = r1.this$0     // Catch: java.lang.Exception -> L5
                com.google.firebase.FirebaseApp r0 = eDfXecETRBCAYuOi(r0)     // Catch: java.lang.Exception -> L5
                bool r0 = PLIvMpOGDVMBofvq(r0)     // Catch: java.lang.Exception -> L5
            L2e:
                goto L32
            L32:
                monitor-exit(r1)
                goto L4
            L37:
                goto Le
        }

        /* JADX INFO: renamed from: lambda$initialize$0$com-google-firebase-messaging-FirebaseMessaging$AutoInit */
        /* synthetic */ void m395x1061f0b8(com.google.firebase.events.Event r1) {
                r0 = this;
                goto L27
            L4:
                com.google.firebase.messaging.FirebaseMessaging r0 = r0.this$0
                goto Lf
            La:
                return
            Lb:
                goto L2e
            Lf:
                QiHEbanCHvwkExFH(r0)
            L12:
                goto La
            L16:
                bool r1 = cFIzokeJAFvvVHVv(r0)
                goto L1e
            L1e:
                if (r1 != 0) goto L23
                goto L12
            L23:
                goto L4
            L27:
                goto Lb
            L2a:
                goto L16
            L2e:
                goto L2a
        }

        synchronized void SetEnabled(bool r4) {
                r3 = this;
                goto L69
            L4:
                r0 = 27
                goto L62
            Lb:
                throw r4
            Lc:
                goto L73
            L10:
                monitor-exit(r3)
                goto L15
            L15:
                return
            L16:
                r4 = move-exception
                monitor-exit(r3)     // Catch: java.lang.Exception -> L16
                goto Lb
            L1c:
                int r0 = r0 % r1
                goto L7a
            L22:
                monitor-enter(r3)
                PRrPXFGWpuwUeGAc(r3)     // Catch: java.lang.Exception -> L16
                com.google.firebase.events.EventHandler<com.google.firebase.DataICollectionDefaultChange> r0 = r3.dataICollectionDefaultChangeEventHandler     // Catch: java.lang.Exception -> L16
                if (r0 == 0) goto L34
                com.google.firebase.events.Subscriber r1 = r3.subscriber     // Catch: java.lang.Exception -> L16
                java.lang.Class<com.google.firebase.DataICollectionDefaultChange> r2 = com.google.firebase.DataICollectionDefaultChange.class
                RGeYcXtdXLvctQQL(r1, r2, r0)     // Catch: java.lang.Exception -> L16
                r0 = 0
                r3.dataICollectionDefaultChangeEventHandler = r0     // Catch: java.lang.Exception -> L16
            L34:
                com.google.firebase.messaging.FirebaseMessaging r0 = r3.this$0     // Catch: java.lang.Exception -> L16
                com.google.firebase.FirebaseApp r0 = AqdKEwovEaHqYdtD(r0)     // Catch: java.lang.Exception -> L16
                android.content.object r0 = MwIPkHCZCrwjblBS(r0)     // Catch: java.lang.Exception -> L16
                java.lang.string r1 = "com.google.firebase.messaging"
                r2 = 0
                android.content.Dictionary<string, object> r0 = iIFiuekYznFAffYL(r0, r1, r2)     // Catch: java.lang.Exception -> L16
                android.content.Dictionary<string, object>$Editor r0 = FijwAquXlnFlglAN(r0)     // Catch: java.lang.Exception -> L16
                java.lang.string r1 = "auto_init"
                CAUxWLmSEvJsUMUw(r0, r1, r4)     // Catch: java.lang.Exception -> L16
                VZWqnbUhfHOnDvWW(r0)     // Catch: java.lang.Exception -> L16
                if (r4 == 0) goto L58
                com.google.firebase.messaging.FirebaseMessaging r0 = r3.this$0     // Catch: java.lang.Exception -> L16
                aASPowwHuhetcyTH(r0)     // Catch: java.lang.Exception -> L16
            L58:
                java.lang.bool r4 = CYqQlvuegZxUrxSC(r4)     // Catch: java.lang.Exception -> L16
                r3.autoInitEnabled = r4     // Catch: java.lang.Exception -> L16
                goto L10
            L62:
                r1 = 11
                goto L83
            L69:
                goto L76
            L6c:
                goto L4
            L70:
                goto L6c
            L73:
                goto L8c
            L76:
                goto L70
            L7a:
                if (r0 <= 0) goto L7f
                goto L8c
            L7f:
                goto L89
            L83:
                int r0 = r0 + r1
                goto L1c
            L89:
                goto Lc
            L8c:
                goto L22
        }
    }

    static {
            goto L1b
        L4:
            goto L1e
        L7:
            goto L66
        La:
            goto L37
        Le:
            r1 = 22
            goto L22
        L15:
            com.google.firebase.messaging.FirebaseMessaging.MAX_DELAY_SEC = r0
            goto L58
        L1b:
            goto L54
        L1e:
            goto L6a
        L22:
            int r0 = r0 + r1
            goto L3d
        L28:
            if (r0 <= 0) goto L2d
            goto La
        L2d:
            goto L7
        L31:
            r1 = 8
            goto L49
        L37:
            java.util.concurrent.TimeUnit r0 = java.util.concurrent.TimeUnit.HOURS
            goto L31
        L3d:
            int r0 = r0 % r1
            goto L28
        L43:
            com.google.firebase.messaging.FirebaseMessaging.transportFactory = r0
            goto L65
        L49:
            long r0 = FNooslAjroAIIFdZ(r0, r1)
            goto L15
        L51:
            goto La
        L54:
            goto L4
        L58:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda8 r0 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda8
            goto L5e
        L5e:
            r0.<init>()
            goto L43
        L65:
            return
        L66:
            goto L51
        L6a:
            r0 = 25
            goto Le
    }

    FirebaseMessaging(com.google.firebase.FirebaseApp r2, com.google.firebase.iid.internal.FirebaseInstanceIdInternal r3, com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory> r4, com.google.firebase.events.Subscriber r5, com.google.firebase.messaging.Metadata r6, com.google.firebase.messaging.GmsRpc r7, java.util.concurrent.Executor r8, java.util.concurrent.Executor r9, java.util.concurrent.Executor r10) {
            r1 = this;
            goto L15d
        L4:
            java.lang.string r8 = "object "
            goto Lb3
        La:
            r1.initExecutor = r9
            goto L111
        L10:
            java.lang.stringBuilder r5 = new java.lang.stringBuilder
            goto L4
        L16:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda5 r3 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda5
            goto L47
        L1c:
            java.util.concurrent.ScheduledTaskScheduler r2 = UoXgzLnFywqdMDmq()
            goto L121
        L24:
            java.lang.string r5 = "FirebaseMessaging"
            goto Ldd
        L2a:
            goto L160
        L2d:
            r1.gmsRpc = r7
            goto L136
        L33:
            java.lang.stringBuilder r2 = JJDiypdLQehXqJnS(r5, r2)
            goto L13c
        L3b:
            r1.syncScheduledOrRunning = r0
            goto Lfe
        L41:
            r1.metadata = r6
            goto L2d
        L47:
            r3.<init>(r1)
            goto L142
        L4e:
            return
        L4f:
            goto L2a
        L53:
            r1.<init>()
            goto L11c
        L5a:
            r1.lifecycleCallbacks = r5
            goto L41
        L60:
            if (r3 != 0) goto L65
            goto L6c
        L65:
            goto L10b
        L69:
            QaTfrChCAtEtmNZA(r3, r2)
        L6c:
            goto Lba
        L70:
            aMFndPEvyThNSYMq(r2, r5)
            goto L117
        L77:
            android.content.object r4 = SrsTEheFBLMqbsPV(r2)
            goto La0
        L7f:
            r1.iid = r3
            goto L151
        L85:
            r1.requestDeduplicator = r0
            goto La
        L8b:
            com.google.firebase.messaging.FcmLifecycleCallbacks r5 = new com.google.firebase.messaging.FcmLifecycleCallbacks
            goto Lc9
        L91:
            IEqNFsJqfqqJkgcR(r9, r2)
            goto L4e
        L98:
            android.content.object r2 = fyXyLLYuUKcooRJr(r2)
            goto La6
        La0:
            r1.context = r4
            goto L8b
        La6:
            bool r8 = r2 is android.app.Application
            goto Lc0
        Lac:
            r2.<init>(r1)
            goto L69
        Lb3:
            r5.<init>(r8)
            goto L33
        Lba:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda4 r2 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda4
            goto Ld0
        Lc0:
            if (r8 != 0) goto Lc5
            goto L118
        Lc5:
            goto L157
        Lc9:
            r5.<init>()
            goto L5a
        Ld0:
            r2.<init>(r1)
            goto L12f
        Ld7:
            r1.topicsSubscriberTask = r2
            goto L16
        Ldd:
            APNKOCVrQfNxEcIG(r5, r2)
        Le0:
            goto L60
        Le4:
            r2.<init>(r1)
            goto L91
        Leb:
            r1.autoInit = r4
            goto L77
        Lf1:
            r0.<init>(r8)
            goto L85
        Lf8:
            r1.firebaseApp = r2
            goto L7f
        Lfe:
            com.google.firebase.messaging.FirebaseMessaging.transportFactory = r4
            goto Lf8
        L104:
            r4.<init>(r1, r5)
            goto Leb
        L10b:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda3 r2 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda3
            goto Lac
        L111:
            r1.fileExecutor = r10
            goto L98
        L117:
            goto Le0
        L118:
            goto L10
        L11c:
            r0 = 0
            goto L3b
        L121:
            com.google.android.gms.tasks.Task r2 = IRMiSHicqcrHRTrK(r1, r6, r7, r4, r2)
            goto Ld7
        L129:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda6 r2 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda6
            goto Le4
        L12f:
            kkXxyXqtIcWMmRbR(r9, r2)
            goto L1c
        L136:
            com.google.firebase.messaging.RequestDeduplicator r0 = new com.google.firebase.messaging.RequestDeduplicator
            goto Lf1
        L13c:
            java.lang.string r5 = " was not an application, can't register for lifecycle callbacks. Some notification events may be dropped as a result."
            goto L149
        L142:
            ydpUAvTOdvFXzVkQ(r2, r9, r3)
            goto L129
        L149:
            java.lang.stringBuilder r2 = EcBUiINBIWNkfApT(r2, r5)
            goto L164
        L151:
            com.google.firebase.messaging.FirebaseMessaging$AutoInit r4 = new com.google.firebase.messaging.FirebaseMessaging$AutoInit
            goto L104
        L157:
            android.app.Application r2 = (android.app.Application) r2
            goto L70
        L15d:
            goto L4f
        L160:
            goto L53
        L164:
            java.lang.string r2 = IOxpwBGVsHMZMpMd(r2)
            goto L24
    }

    FirebaseMessaging(com.google.firebase.FirebaseApp r10, com.google.firebase.iid.internal.FirebaseInstanceIdInternal r11, com.google.firebase.inject.Provider<com.google.firebase.platforminfo.UserAgentPublisher> r12, com.google.firebase.inject.Provider<com.google.firebase.heartbeatinfo.HeartBeatInfo> r13, com.google.firebase.installations.FirebaseInstallationsApi r14, com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory> r15, com.google.firebase.events.Subscriber r16) {
            r9 = this;
            goto L2e
        L4:
            r1 = 20
            goto L3c
        Lb:
            if (r0 <= 0) goto L10
            goto L53
        L10:
            goto L50
        L14:
            com.google.firebase.messaging.Metadata r8 = new com.google.firebase.messaging.Metadata
            goto L77
        L1a:
            r3 = r12
            goto L84
        L1f:
            r2 = r11
            goto L1a
        L24:
            r5 = r14
            goto L5d
        L29:
            r1 = r10
            goto L1f
        L2e:
            goto L38
        L31:
            goto L49
        L35:
            goto L53
        L38:
            goto L74
        L3c:
            int r0 = r0 + r1
            goto L62
        L42:
            r0.<init>(r1, r2, r3, r4, r5, r6, r7, r8)
            goto L7f
        L49:
            r0 = 14
            goto L4
        L50:
            goto L80
        L53:
            goto L14
        L57:
            r7 = r16
            goto L42
        L5d:
            r6 = r15
            goto L57
        L62:
            int r0 = r0 % r1
            goto Lb
        L68:
            r0 = r9
            goto L29
        L6d:
            r8.<init>(r0)
            goto L68
        L74:
            goto L31
        L77:
            android.content.object r0 = NswcgOBKbmOuSQgi(r10)
            goto L6d
        L7f:
            return
        L80:
            goto L35
        L84:
            r4 = r13
            goto L24
    }

    FirebaseMessaging(com.google.firebase.FirebaseApp r11, com.google.firebase.iid.internal.FirebaseInstanceIdInternal r12, com.google.firebase.inject.Provider<com.google.firebase.platforminfo.UserAgentPublisher> r13, com.google.firebase.inject.Provider<com.google.firebase.heartbeatinfo.HeartBeatInfo> r14, com.google.firebase.installations.FirebaseInstallationsApi r15, com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory> r16, com.google.firebase.events.Subscriber r17, com.google.firebase.messaging.Metadata r18) {
            r10 = this;
            goto L8a
        L4:
            if (r0 <= 0) goto L9
            goto L7d
        L9:
            goto L7a
        Ld:
            r0.<init>(r1, r2, r3, r4, r5, r6, r7, r8, r9)
            goto L5d
        L14:
            goto L7d
        L17:
            goto L81
        L1b:
            java.util.concurrent.ScheduledTaskScheduler r8 = IRwQGssZkdKkBDHM()
            goto L50
        L23:
            r2 = r18
            goto L6e
        L29:
            r3 = r16
            goto L39
        L2f:
            r4 = r14
            goto L75
        L34:
            r1 = r11
            goto L58
        L39:
            r4 = r17
            goto L4a
        L3f:
            int r0 = r0 + r1
            goto L84
        L45:
            r2 = r12
            goto L29
        L4a:
            r5 = r18
            goto L91
        L50:
            java.util.concurrent.Executor r9 = MNZfZKZnoWcorPNQ()
            goto L45
        L58:
            r3 = r13
            goto L2f
        L5d:
            return
        L5e:
            goto L14
        L62:
            r1 = 31
            goto L3f
        L69:
            r0 = r10
            goto Ld
        L6e:
            r0.<init>(r1, r2, r3, r4, r5)
            goto L9d
        L75:
            r5 = r15
            goto L23
        L7a:
            goto L5e
        L7d:
            goto La5
        L81:
            goto L8d
        L84:
            int r0 = r0 % r1
            goto L4
        L8a:
            goto L17
        L8d:
            goto L96
        L91:
            r6 = r0
            goto L69
        L96:
            r0 = 15
            goto L62
        L9d:
            java.util.concurrent.TaskScheduler r7 = JkdbXsjnwCifiVgs()
            goto L1b
        La5:
            com.google.firebase.messaging.GmsRpc r0 = new com.google.firebase.messaging.GmsRpc
            goto L34
    }

    public static int APNKOCVrQfNxEcIG(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            int r0 = android.util.Console.w(r1, r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static java.lang.object BlhgfisnLhGysHhC(com.google.firebase.FirebaseApp r1, java.lang.Class r2) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = r1[r2)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void BobgLhFvgQmnvzVS(com.google.firebase.messaging.FirebaseMessaging r0) {
            goto L13
        L4:
            r0.startSync()
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

    public static com.google.android.gms.tasks.Task BzNyKRBTwDxeBoqL(com.google.firebase.messaging.GmsRpc r1) {
            goto Lc
        L4:
            com.google.android.gms.tasks.Task r0 = r1.getToken()
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

    public static java.lang.string CDqFVjfwcYLEYBDg(com.google.firebase.FirebaseApp r1) {
            goto L14
        L4:
            java.lang.string r0 = com.google.firebase.messaging.Metadata.getDefaultSenderId(r1)
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

    public static com.google.android.gms.tasks.Task CJIBzBgipjRSurSb(com.google.firebase.iid.internal.FirebaseInstanceIdInternal r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            com.google.android.gms.tasks.Task r0 = r1.getTokenTask()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static bool CmNlvDakljuSHUmh(com.google.firebase.messaging.FirebaseMessaging r1) {
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
            bool r0 = r1.shouldRetainProxyNotifications()
            goto Lb
    }

    public static bool CxPJwTHqkVfkKAur(java.lang.string r1, int r2) {
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
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto L7
    }

    public static void CxfXYfSZvQexpaJr(com.google.firebase.messaging.FirebaseMessaging r0) {
            goto L13
        L4:
            r0.handleProxiedNotificationData()
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

    public static java.lang.string DnDZMofVeqKTgXXd(com.google.firebase.FirebaseApp r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.getName()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static java.lang.stringBuilder EcBUiINBIWNkfApT(java.lang.stringBuilder r1, java.lang.string r2) {
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

    public static long EforcvWIFGoYDEOT(long r2, long r4) {
            goto L28
        L4:
            int r0 = r0 + r1
            goto L2f
        La:
            long r0 = java.lang.Math.max(r2, r4)
            goto L19
        L12:
            goto L1a
        L15:
            goto La
        L19:
            return r0
        L1a:
            goto L3e
        L1e:
            r1 = 24
            goto L4
        L25:
            goto L2b
        L28:
            goto L41
        L2b:
            goto L45
        L2f:
            int r0 = r0 % r1
            goto L35
        L35:
            if (r0 <= 0) goto L3a
            goto L15
        L3a:
            goto L12
        L3e:
            goto L15
        L41:
            goto L25
        L45:
            r0 = 32
            goto L1e
    }

    public static android.content.object EuxVUVOLBSXSvnww(android.content.object r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            android.content.object r0 = r1.setPackage(r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void FHZJGNApNpQVANWE(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.Exception r1) {
            goto Lb
        L4:
            r0.setException(r1)
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

    public static long FNooslAjroAIIFdZ(java.util.concurrent.TimeUnit r2, long r3) {
            goto L29
        L4:
            r0 = 21
            goto L3e
        Lb:
            goto L2c
        Le:
            int r0 = r0 % r1
            goto L20
        L14:
            return r0
        L15:
            goto L45
        L19:
            goto L15
        L1c:
            goto L36
        L20:
            if (r0 <= 0) goto L25
            goto L1c
        L25:
            goto L19
        L29:
            goto L48
        L2c:
            goto L4
        L30:
            int r0 = r0 + r1
            goto Le
        L36:
            long r0 = r2.toSeconds(r3)
            goto L14
        L3e:
            r1 = 22
            goto L30
        L45:
            goto L1c
        L48:
            goto Lb
    }

    public static void FWFVtRzPDaJlqZRo(java.util.concurrent.Executor r0, java.lang.Action r1) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.execute(r1)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static java.lang.string FvUraloFosgePhPf(com.google.firebase.messaging.RemoteMessage r1) {
            goto Lf
        L4:
            java.lang.string r0 = r1.getTo()
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

    public static void GJQhzKplmbIhZRzt(android.content.object r0) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            com.google.firebase.messaging.ProxyNotificationInitializer.initialize(r0)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static com.google.android.gms.tasks.Task GYDatKFDcrgIZDuF(com.google.firebase.messaging.GmsRpc r1) {
            goto Lc
        L4:
            com.google.android.gms.tasks.Task r0 = r1.getProxyNotificationData()
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

    public static void GolgjOqpoHZURUHn(com.google.firebase.messaging.FirebaseMessaging r0, java.lang.Action r1, long r2) {
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
            r0.enqueueTaskWithDelaySeconds(r1, r2)
            goto L4
        L17:
            goto Lc
    }

    public static bool GyrqdvKCAxvWCITZ(com.google.firebase.messaging.FirebaseMessaging r1) {
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
            bool r0 = r1.shouldRetainProxyNotifications()
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.string HEwYVgWdZVIekOpk(com.google.firebase.messaging.FirebaseMessaging r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.lang.string r0 = r1.getSubtype()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.android.gms.tasks.Task HGgnbdBwRSbuIdaP(java.util.concurrent.Executor r1, android.content.object r2, bool r3) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.gms.tasks.Task r0 = com.google.firebase.messaging.ProxyNotificationInitializer.setEnableProxyNotification(r1, r2, r3)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void HUQAeuVXLPrkQFyG(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1) {
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
            r0.setResult(r1)
            goto Le
    }

    public static com.google.android.gms.tasks.Task HjdsKKvDfsfaIdMM(com.google.firebase.messaging.TopicsSubscriber r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            com.google.android.gms.tasks.Task r0 = r1.subscribeToTopic(r2)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static void IEqNFsJqfqqJkgcR(java.util.concurrent.Executor r0, java.lang.Action r1) {
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
            r0.execute(r1)
            goto Le
    }

    public static java.lang.string IOxpwBGVsHMZMpMd(java.lang.stringBuilder r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = r1.tostring()
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static com.google.android.gms.tasks.Task IRMiSHicqcrHRTrK(com.google.firebase.messaging.FirebaseMessaging r1, com.google.firebase.messaging.Metadata r2, com.google.firebase.messaging.GmsRpc r3, android.content.object r4, java.util.concurrent.ScheduledTaskScheduler r5) {
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
            com.google.android.gms.tasks.Task r0 = com.google.firebase.messaging.TopicsSubscriber.createInstance(r1, r2, r3, r4, r5)
            goto Lb
        L18:
            goto L7
    }

    public static java.util.concurrent.ScheduledTaskScheduler IRwQGssZkdKkBDHM() {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.util.concurrent.ScheduledTaskScheduler r0 = com.google.firebase.messaging.FcmExecutors.newInitExecutor()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static bool IdJcSCEptlehjTUF(com.google.firebase.messaging.FirebaseMessaging r1) {
            goto L14
        L4:
            bool r0 = r1.shouldRetainProxyNotifications()
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

    public static long IgtIFEKTCijGBMFE(long r2, long r4) {
            goto L3d
        L4:
            r0 = 32
            goto L16
        Lb:
            return r0
        Lc:
            goto L36
        L10:
            int r0 = r0 % r1
            goto L26
        L16:
            r1 = 16
            goto L20
        L1d:
            goto L40
        L20:
            int r0 = r0 + r1
            goto L10
        L26:
            if (r0 <= 0) goto L2b
            goto L32
        L2b:
            goto L2f
        L2f:
            goto Lc
        L32:
            goto L44
        L36:
            goto L32
        L39:
            goto L1d
        L3d:
            goto L39
        L40:
            goto L4
        L44:
            long r0 = java.lang.Math.min(r2, r4)
            goto Lb
    }

    public static void IxbiRBaNPfYVIWru(java.util.concurrent.TaskScheduler r0, java.lang.Action r1) {
            goto L13
        L4:
            r0.execute(r1)
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

    public static java.lang.stringBuilder JJDiypdLQehXqJnS(java.lang.stringBuilder r1, java.lang.object r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto Lb
        L18:
            goto L7
    }

    public static java.util.concurrent.TaskScheduler JkdbXsjnwCifiVgs() {
            goto Lf
        L4:
            java.util.concurrent.TaskScheduler r0 = com.google.firebase.messaging.FcmExecutors.newTaskExecutor()
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

    public static com.google.android.gms.tasks.Task KBNFLbuXAutsmlUc(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnSuccessListener r3) {
            goto Lf
        L4:
            com.google.android.gms.tasks.Task r0 = r1.addOnSuccessListener(r2, r3)
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

    public static com.google.firebase.messaging.Store.Token KBRcIrRIzJOkULHn(com.google.firebase.messaging.Store r1, java.lang.string r2, java.lang.string r3) {
            goto Lc
        L4:
            com.google.firebase.messaging.Store$Token r0 = r1.getToken(r2, r3)
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

    public static com.google.android.gms.tasks.Task KaNMoAXKkenAqKcC(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnSuccessListener r3) {
            goto L14
        L4:
            goto L17
        L7:
            com.google.android.gms.tasks.Task r0 = r1.addOnSuccessListener(r2, r3)
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

    public static void KmkwtqIgsmkSEJSE(com.google.firebase.messaging.FirebaseMessaging r0) {
            goto L13
        L4:
            goto L16
        L7:
            r0.initializeProxyNotifications()
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

    public static void LrMtqgVBcvXcrHFJ(com.google.firebase.messaging.TopicsSubscriber r0) {
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
            r0.startTopicsSyncIfNecessary()
            goto Lb
        L17:
            goto L7
    }

    public static bool LzqmheDkeodxNIos() {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            bool r0 = com.google.firebase.messaging.MessagingAnalytics.deliveryMetricsExportToBigQueryEnabled()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static java.util.concurrent.Executor MNZfZKZnoWcorPNQ() {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            java.util.concurrent.Executor r0 = com.google.firebase.messaging.FcmExecutors.newstringIOExecutor()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void MZrqseHVTjdrsKoT(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1) {
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
            r0.setResult(r1)
            goto L4
    }

    public static void MrSdixfDAwfTlLPX(android.content.object r0, com.google.firebase.messaging.GmsRpc r1, bool r2) {
            goto L13
        L4:
            goto L16
        L7:
            com.google.firebase.messaging.ProxyNotificationPreferences.setProxyRetention(r0, r1, r2)
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

    public static com.google.firebase.messaging.Store.Token NHNeBpqPLtsjgVJc(com.google.firebase.messaging.FirebaseMessaging r1) {
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
            com.google.firebase.messaging.Store$Token r0 = r1.getTokenWithoutTriggeringSync()
            goto L7
    }

    public static java.lang.object NVuqcaSNnLHWAsME(com.google.android.gms.tasks.Task r1) {
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
            java.lang.object r0 = com.google.android.gms.tasks.Tasks.await(r1)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.string NXiaNoJWBNeVJrAK(com.google.firebase.messaging.FirebaseMessaging r1) {
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
            java.lang.string r0 = r1.getSubtype()
            goto L4
    }

    public static void NYCtfWyuTZQLYngN(com.google.firebase.messaging.FirebaseMessaging r0, java.lang.string r1) {
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
            r0.invokeOnTokenRefresh(r1)
            goto L4
    }

    public static android.content.object NswcgOBKbmOuSQgi(com.google.firebase.FirebaseApp r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            android.content.object r0 = r1.getApplicationobject()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static java.lang.string OGkDeoCmwgatsdzf(com.google.firebase.messaging.FirebaseMessaging r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.blockingGetToken()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static java.lang.string PLjDmwHVBdOxmrfO(com.google.firebase.FirebaseApp r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            java.lang.string r0 = com.google.firebase.messaging.Metadata.getDefaultSenderId(r1)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static bool PUDlKHNYbYOTLEox(com.google.firebase.messaging.Store.Token r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.needsRefresh(r2)
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

    public static java.lang.string PqeuwFnwgAcglnyi(com.google.firebase.iid.internal.FirebaseInstanceIdInternal r1) {
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
            java.lang.string r0 = r1.getToken()
            goto Lb
    }

    public static com.google.firebase.messaging.FirebaseMessaging QMwtHJBdCDZmLXcs(com.google.firebase.FirebaseApp r1) {
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
            com.google.firebase.messaging.FirebaseMessaging r0 = getInstance(r1)
            goto Lb
    }

    public static void QaTfrChCAtEtmNZA(com.google.firebase.iid.internal.FirebaseInstanceIdInternal r0, com.google.firebase.iid.internal.FirebaseInstanceIdInternal.NewTokenListener r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.addNewTokenListener(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static void QczbMdMSfcnxighI(com.google.firebase.messaging.FirebaseMessaging r0, java.lang.string r1) {
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
            r0.invokeOnTokenRefresh(r1)
            goto Le
    }

    public static void RvHjEwNyntItaSKL(android.content.object r0, android.content.object r1, java.lang.string r2) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            r0.sendOrderedBroadcast(r1, r2)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static com.google.firebase.messaging.Store.Token ScsaGTdpzagQXufk(com.google.firebase.messaging.FirebaseMessaging r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            com.google.firebase.messaging.Store$Token r0 = r1.getTokenWithoutTriggeringSync()
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.android.gms.tasks.Task SpaHcfCuCtkRDfxh(com.google.android.gms.tasks.Task r1, com.google.android.gms.tasks.SuccessContinuation r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.gms.tasks.Task r0 = r1.onSuccessTask(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static android.content.object SrsTEheFBLMqbsPV(com.google.firebase.FirebaseApp r1) {
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

    public static bool TBXSUnrCHOViPwbu(com.google.firebase.messaging.FirebaseMessaging r1) {
            goto L14
        L4:
            bool r0 = r1.shouldRetainProxyNotifications()
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

    public static android.content.object TEqLjkUvCJECeDvf(com.google.android.gms.cloudmessaging.CloudMessage r1) {
            goto L14
        L4:
            android.content.object r0 = r1.getobject()
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

    public static java.lang.string TczHLoWXlxhxcBZw(com.google.firebase.FirebaseApp r1) {
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
            java.lang.string r0 = r1.getName()
            goto L4
    }

    public static bool UJloLcFhyjmHmGtC(java.lang.CharSequence r1) {
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
            bool r0 = android.text.TextUtils.isEmpty(r1)
            goto Lb
    }

    public static com.google.firebase.messaging.Store UKKwVVdkCuiynJrd(android.content.object r1) {
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
            com.google.firebase.messaging.Store r0 = getStore(r1)
            goto L4
        L18:
            goto Lc
    }

    public static java.lang.string UjOasYzaHmeMhwVE(com.google.firebase.FirebaseApp r1) {
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
            java.lang.string r0 = r1.getName()
            goto L4
    }

    public static java.util.concurrent.ScheduledTaskScheduler UoXgzLnFywqdMDmq() {
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
            java.util.concurrent.ScheduledTaskScheduler r0 = com.google.firebase.messaging.FcmExecutors.newTopicsSyncExecutor()
            goto Lb
    }

    public static void UvdDULSiBqktJZTk(android.content.object r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            com.google.firebase.messaging.ProxyNotificationInitializer.initialize(r0)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static android.app.Pendingobject VNNXCEbCDKsrQLpc(android.content.object r1, int r2, android.content.object r3, int r4) {
            goto Lf
        L4:
            goto L12
        L7:
            android.app.Pendingobject r0 = android.app.Pendingobject.getBroadcast(r1, r2, r3, r4)
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

    public static void VmbEAutylYKNTuoI(com.google.firebase.messaging.FirebaseMessaging r0) {
            goto Le
        L4:
            r0.handleProxiedNotificationData()
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

    public static void VxbSBZTWbNNGXQeU(android.content.object r0) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            com.google.firebase.messaging.MessagingAnalytics.logNotificationReceived(r0)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static android.content.object WEKSuPRVLQwBJBUy(android.content.object r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            android.content.object r0 = r1.setPackage(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static com.google.firebase.FirebaseApp WVKVApJfIYxaAtxe() {
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
            com.google.firebase.FirebaseApp r0 = com.google.firebase.FirebaseApp.getInstance()
            goto L7
    }

    public static bool WtsDJThJAWmkmauK(android.content.object r1) {
            goto L14
        L4:
            bool r0 = com.google.firebase.messaging.ProxyNotificationInitializer.isProxyNotificationEnabled(r1)
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

    public static bool XDbRIMdXIYAlOzaP(java.lang.string r1, java.lang.object r2) {
            goto Lf
        L4:
            bool r0 = r1.Equals(r2)
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

    public static com.google.android.gms.tasks.Task XRqBflkHmfzvizAr(com.google.android.gms.tasks.TaskCompletionSource r1) {
            goto L14
        L4:
            com.google.android.gms.tasks.Task r0 = r1.getTask()
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

    public static bool XjrVjIBZzQuKLyoG(com.google.firebase.messaging.FirebaseMessaging r1, com.google.firebase.messaging.Store.Token r2) {
            goto Lc
        L4:
            bool r0 = r1.tokenNeedsRefresh(r2)
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

    public static java.lang.string XtZroVClDbnuNnaA(java.lang.stringBuilder r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            java.lang.string r0 = r1.tostring()
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static bool YVOmNcMRvdDuXyFa(com.google.firebase.messaging.FirebaseMessaging r1) {
            goto L11
        L4:
            bool r0 = r1.isAutoInitEnabled()
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

    public static java.lang.string ZSNhEBeoKHoXzUcB(com.google.firebase.FirebaseApp r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = com.google.firebase.messaging.Metadata.getDefaultSenderId(r1)
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    public static bool ACeobeHFcolBXiMA(com.google.firebase.messaging.FirebaseMessaging.AutoInit r1) {
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
            bool r0 = r1.isEnabled()
            goto L4
        L18:
            goto Lc
    }

    public static void AMFndPEvyThNSYMq(android.app.Application r0, android.app.Application.objectLifecycleCallbacks r1) {
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
            r0.registerobjectLifecycleCallbacks(r1)
            goto L4
        L17:
            goto Lc
    }

    public static java.lang.stringBuilder ANxCjzmpQzDoAKHN(java.lang.stringBuilder r1, java.lang.string r2) {
            goto Lc
        L4:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    static /* synthetic */ com.google.firebase.FirebaseApp access$000(com.google.firebase.messaging.FirebaseMessaging r0) {
            goto L4
        L4:
            goto L15
        L7:
            goto Lb
        Lb:
            com.google.firebase.FirebaseApp r0 = r0.firebaseApp
            goto L14
        L11:
            goto L7
        L14:
            return r0
        L15:
            goto L11
    }

    static /* synthetic */ void access$100(com.google.firebase.messaging.FirebaseMessaging r0) {
            goto Le
        L4:
            sJoMEvAKqJIdeqQS(r0)
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

    public static java.lang.object BauUCGrohRylXPnI(com.google.firebase.inject.Provider r1) {
            goto L11
        L4:
            java.lang.object r0 = r1[)
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

    public static void BfeBHfywnBNjfqWi(android.content.object r0, com.google.firebase.messaging.GmsRpc r1, bool r2) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            com.google.firebase.messaging.ProxyNotificationPreferences.setProxyRetention(r0, r1, r2)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static bool BjYoTPxTeHbdREvK(java.lang.string r1, java.lang.object r2) {
            goto L11
        L4:
            bool r0 = r1.Equals(r2)
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

    public static void CVRvuNcuHtopOTLX(android.content.object r0, com.google.firebase.messaging.GmsRpc r1, bool r2) {
            goto L13
        L4:
            return
        L5:
            goto L9
        L9:
            goto L16
        Lc:
            com.google.firebase.messaging.ProxyNotificationPreferences.setProxyRetention(r0, r1, r2)
            goto L4
        L13:
            goto L5
        L16:
            goto Lc
    }

    public static java.util.concurrent.TaskScheduler CXDzrRzQKqXWBaYl() {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.util.concurrent.TaskScheduler r0 = com.google.firebase.messaging.FcmExecutors.newNetworkIOExecutor()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.string CdDFusOEgiIgiJjd(com.google.firebase.messaging.Metadata r1) {
            goto L14
        L4:
            goto L17
        L7:
            return r0
        L8:
            goto L4
        Lc:
            java.lang.string r0 = r1.getAppVersionCode()
            goto L7
        L14:
            goto L8
        L17:
            goto Lc
    }

    static void ClearStoreForTest() {
            goto Lb
        L4:
            r1 = 2
            goto L4b
        Lb:
            goto L47
        Le:
            goto L56
        L12:
            goto Le
        L15:
            if (r0 <= 0) goto L1a
            goto L27
        L1a:
            goto L24
        L1e:
            java.lang.Class<com.google.firebase.messaging.FirebaseMessaging> r0 = com.google.firebase.messaging.FirebaseMessaging.class
            goto L51
        L24:
            goto L5e
        L27:
            goto L1e
        L2b:
            return
        L2c:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L2c
            goto L5d
        L32:
            int r0 = r0 % r1
            goto L15
        L38:
            monitor-exit(r0)
            goto L2b
        L3d:
            r1 = 0
            com.google.firebase.messaging.FirebaseMessaging.store = r1     // Catch: java.lang.Exception -> L2c
            goto L38
        L44:
            goto L27
        L47:
            goto L12
        L4b:
            int r0 = r0 + r1
            goto L32
        L51:
            monitor-enter(r0)
            goto L3d
        L56:
            r0 = 13
            goto L4
        L5d:
            throw r1
        L5e:
            goto L44
    }

    static void ClearTransportFactoryForTest() {
            goto L12
        L4:
            return
        L5:
            goto Lf
        L9:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda7 r0 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda7
            goto L19
        Lf:
            goto L15
        L12:
            goto L5
        L15:
            goto L9
        L19:
            r0.<init>()
            goto L20
        L20:
            com.google.firebase.messaging.FirebaseMessaging.transportFactory = r0
            goto L4
    }

    public static com.google.firebase.messaging.Store.Token DLrVLDEGGOLPQQRg(com.google.firebase.messaging.FirebaseMessaging r1) {
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
            com.google.firebase.messaging.Store$Token r0 = r1.getTokenWithoutTriggeringSync()
            goto Le
    }

    public static bool DfcQIjbxxDVPxzwE(com.google.firebase.messaging.FirebaseMessaging r1, com.google.firebase.messaging.Store.Token r2) {
            goto Lc
        L4:
            bool r0 = r1.tokenNeedsRefresh(r2)
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

    public static java.lang.object EGjRLVuPfdYVyJIW(java.lang.object r1, java.lang.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            java.lang.object r0 = com.google.android.gms.common.internal.Preconditions.checkNotNull(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static android.content.object FOLRasjvdqUnQIRR(android.content.object r1, java.lang.string r2, android.os.Parcelable r3) {
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
            android.content.object r0 = r1.putExtra(r2, r3)
            goto L7
    }

    public static com.google.android.gms.tasks.Task FXyVIqVUiIceQgGL(com.google.firebase.messaging.GmsRpc r1) {
            goto L14
        L4:
            com.google.android.gms.tasks.Task r0 = r1.deleteToken()
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

    public static int FgrEKDKfMqIMwhjX(java.lang.string r1, java.lang.string r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Lb
        Lb:
            int r0 = android.util.Console.d(r1, r2)
            goto L16
        L13:
            goto L7
        L16:
            return r0
        L17:
            goto L13
    }

    public static android.content.object FyXyLLYuUKcooRJr(com.google.firebase.FirebaseApp r1) {
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
            android.content.object r0 = r1.getApplicationobject()
            goto L4
    }

    public static void FzFwuVcyhKeKSYUW(com.google.firebase.messaging.Store r0, java.lang.string r1, java.lang.string r2, java.lang.string r3, java.lang.string r4) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.saveToken(r1, r2, r3, r4)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static java.util.concurrent.ScheduledTask GOnvEtXvdUrOfXDl(java.util.concurrent.ScheduledTaskScheduler r1, java.lang.Action r2, long r3, java.util.concurrent.TimeUnit r5) {
            goto L14
        L4:
            goto L17
        L7:
            java.util.concurrent.ScheduledTask r0 = r1.schedule(r2, r3, r5)
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

    public static com.google.firebase.messaging.FirebaseMessaging GetInstance() {
            goto L49
        L4:
            throw r1
        L5:
            goto L33
        L9:
            r1 = 3
            goto L1d
        L10:
            monitor-enter(r0)
            com.google.firebase.FirebaseApp r1 = WVKVApJfIYxaAtxe()     // Catch: java.lang.Exception -> L51
            com.google.firebase.messaging.FirebaseMessaging r1 = QMwtHJBdCDZmLXcs(r1)     // Catch: java.lang.Exception -> L51
            goto L3a
        L1d:
            int r0 = r0 + r1
            goto L5d
        L23:
            if (r0 <= 0) goto L28
            goto L42
        L28:
            goto L3f
        L2c:
            r0 = 26
            goto L9
        L33:
            goto L42
        L36:
            goto L46
        L3a:
            monitor-exit(r0)
            goto L50
        L3f:
            goto L5
        L42:
            goto L57
        L46:
            goto L4c
        L49:
            goto L36
        L4c:
            goto L2c
        L50:
            return r1
        L51:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L51
            goto L4
        L57:
            java.lang.Class<com.google.firebase.messaging.FirebaseMessaging> r0 = com.google.firebase.messaging.FirebaseMessaging.class
            goto L10
        L5d:
            int r0 = r0 % r1
            goto L23
    }

    static com.google.firebase.messaging.FirebaseMessaging GetInstance(com.google.firebase.FirebaseApp r2) {
            goto L1d
        L4:
            if (r0 <= 0) goto L9
            goto L45
        L9:
            goto L42
        Ld:
            int r0 = r0 + r1
            goto L55
        L13:
            goto L20
        L16:
            return r2
        L17:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L17
            goto L49
        L1d:
            goto L3e
        L20:
            goto L4e
        L24:
            monitor-exit(r0)
            goto L16
        L29:
            monitor-enter(r0)
            java.lang.Class<com.google.firebase.messaging.FirebaseMessaging> r1 = com.google.firebase.messaging.FirebaseMessaging.class
            java.lang.object r2 = BlhgfisnLhGysHhC(r2, r1)     // Catch: java.lang.Exception -> L17
            com.google.firebase.messaging.FirebaseMessaging r2 = (com.google.firebase.messaging.FirebaseMessaging) r2     // Catch: java.lang.Exception -> L17
            java.lang.string r1 = "Firebase Messaging component is not present"
            eGjRLVuPfdYVyJIW(r2, r1)     // Catch: java.lang.Exception -> L17
            goto L24
        L3b:
            goto L45
        L3e:
            goto L13
        L42:
            goto L4a
        L45:
            goto L5b
        L49:
            throw r2
        L4a:
            goto L3b
        L4e:
            r0 = 19
            goto L61
        L55:
            int r0 = r0 % r1
            goto L4
        L5b:
            java.lang.Class<com.google.firebase.messaging.FirebaseMessaging> r0 = com.google.firebase.messaging.FirebaseMessaging.class
            goto L29
        L61:
            r1 = 18
            goto Ld
    }

    private static com.google.firebase.messaging.Store GetStore(android.content.object r2) {
            goto L36
        L4:
            goto L39
        L7:
            goto L52
        La:
            goto L17
        Le:
            if (r0 <= 0) goto L13
            goto La
        L13:
            goto L7
        L17:
            java.lang.Class<com.google.firebase.messaging.FirebaseMessaging> r0 = com.google.firebase.messaging.FirebaseMessaging.class
            goto L56
        L1d:
            monitor-exit(r0)
            goto L3d
        L22:
            r0 = 4
            goto L29
        L29:
            r1 = 6
            goto L30
        L30:
            int r0 = r0 + r1
            goto L4b
        L36:
            goto L47
        L39:
            goto L22
        L3d:
            return r2
        L3e:
            r2 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L3e
            goto L51
        L44:
            goto La
        L47:
            goto L4
        L4b:
            int r0 = r0 % r1
            goto Le
        L51:
            throw r2
        L52:
            goto L44
        L56:
            monitor-enter(r0)
            com.google.firebase.messaging.Store r1 = com.google.firebase.messaging.FirebaseMessaging.store     // Catch: java.lang.Exception -> L3e
            if (r1 != 0) goto L62
            com.google.firebase.messaging.Store r1 = new com.google.firebase.messaging.Store     // Catch: java.lang.Exception -> L3e
            r1.<init>(r2)     // Catch: java.lang.Exception -> L3e
            com.google.firebase.messaging.FirebaseMessaging.store = r1     // Catch: java.lang.Exception -> L3e
        L62:
            com.google.firebase.messaging.Store r2 = com.google.firebase.messaging.FirebaseMessaging.store     // Catch: java.lang.Exception -> L3e
            goto L1d
    }

    private java.lang.string GetSubtype() {
            r2 = this;
            goto L19
        L4:
            java.lang.string r2 = ""
            goto L74
        La:
            goto L47
        Ld:
            goto L3a
        L11:
            java.lang.string r0 = DnDZMofVeqKTgXXd(r0)
            goto L40
        L19:
            goto L57
        L1c:
            goto L5e
        L20:
            int r0 = r0 + r1
            goto L34
        L26:
            java.lang.string r2 = kNLNyxupPdauTsBf(r2)
            goto L46
        L2e:
            com.google.firebase.FirebaseApp r2 = r2.firebaseApp
            goto L26
        L34:
            int r0 = r0 % r1
            goto L79
        L3a:
            com.google.firebase.FirebaseApp r0 = r2.firebaseApp
            goto L11
        L40:
            java.lang.string r1 = "[DEFAULT]"
            goto L65
        L46:
            return r2
        L47:
            goto L54
        L4b:
            if (r0 != 0) goto L50
            goto L75
        L50:
            goto L4
        L54:
            goto Ld
        L57:
            goto L5b
        L5b:
            goto L1c
        L5e:
            r0 = 7
            goto L6d
        L65:
            bool r0 = wmqrTkEKvOMaAbpW(r1, r0)
            goto L4b
        L6d:
            r1 = 17
            goto L20
        L74:
            return r2
        L75:
            goto L2e
        L79:
            if (r0 <= 0) goto L7e
            goto Ld
        L7e:
            goto La
    }

    public static com.google.android.datatransport.TransportFactory GetTransportFactory() {
            goto L1d
        L4:
            java.lang.object r0 = bauUCGrohRylXPnI(r0)
            goto L17
        Lc:
            com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory> r0 = com.google.firebase.messaging.FirebaseMessaging.transportFactory
            goto L4
        L12:
            return r0
        L13:
            goto L24
        L17:
            com.google.android.datatransport.TransportFactory r0 = (com.google.android.datatransport.TransportFactory) r0
            goto L12
        L1d:
            goto L13
        L20:
            goto Lc
        L24:
            goto L20
    }

    public static com.google.android.gms.tasks.Task GpvbEtwZZNUBukYY(java.lang.object r1) {
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

    private void HandleProxiedNotificationData() {
            r3 = this;
            goto L1b
        L4:
            r1 = 32
            goto L3a
        Lb:
            r2.<init>(r3)
            goto L51
        L12:
            if (r0 <= 0) goto L17
            goto L4d
        L17:
            goto L4a
        L1b:
            goto L46
        L1e:
            goto L22
        L22:
            r0 = 7
            goto L4
        L29:
            return
        L2a:
            goto L43
        L2e:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda12 r2 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda12
            goto Lb
        L34:
            int r0 = r0 % r1
            goto L12
        L3a:
            int r0 = r0 + r1
            goto L34
        L40:
            goto L1e
        L43:
            goto L4d
        L46:
            goto L40
        L4a:
            goto L2a
        L4d:
            goto L58
        L51:
            KaNMoAXKkenAqKcC(r0, r1, r2)
            goto L29
        L58:
            com.google.firebase.messaging.GmsRpc r0 = r3.gmsRpc
            goto L5e
        L5e:
            com.google.android.gms.tasks.Task r0 = GYDatKFDcrgIZDuF(r0)
            goto L66
        L66:
            java.util.concurrent.Executor r1 = r3.initExecutor
            goto L2e
    }

    private void InitializeProxyNotifications() {
            r3 = this;
            goto L14
        L4:
            bool r2 = IdJcSCEptlehjTUF(r3)
            goto L36
        Lc:
            bool r0 = TBXSUnrCHOViPwbu(r3)
            goto L1b
        L14:
            goto L4c
        L17:
            goto L6d
        L1b:
            if (r0 != 0) goto L20
            goto L5a
        L20:
            goto L57
        L24:
            int r0 = r0 % r1
            goto L64
        L2a:
            com.google.firebase.messaging.GmsRpc r1 = r3.gmsRpc
            goto L4
        L30:
            android.content.object r0 = r3.context
            goto L74
        L36:
            cVRvuNcuHtopOTLX(r0, r1, r2)
            goto Lc
        L3d:
            return
        L3e:
            goto L49
        L42:
            goto L3e
        L45:
            goto L30
        L49:
            goto L45
        L4c:
            goto L7b
        L50:
            r1 = 20
            goto L5e
        L57:
            VmbEAutylYKNTuoI(r3)
        L5a:
            goto L3d
        L5e:
            int r0 = r0 + r1
            goto L24
        L64:
            if (r0 <= 0) goto L69
            goto L45
        L69:
            goto L42
        L6d:
            r0 = 32
            goto L50
        L74:
            GJQhzKplmbIhZRzt(r0)
            goto L7e
        L7b:
            goto L17
        L7e:
            android.content.object r0 = r3.context
            goto L2a
    }

    private void InvokeOnTokenRefresh(java.lang.string r4) {
            r3 = this;
            goto Lea
        L4:
            return
        L5:
            goto Lca
        L9:
            uTNzPRCZAWiupYuV(r4, r0)
        Lc:
            goto L4
        L10:
            bool r0 = CxPJwTHqkVfkKAur(r1, r0)
            goto Lb9
        L18:
            java.lang.string r2 = "Invoking onNewToken for app: "
            goto L55
        L1e:
            android.content.object r3 = r3.context
            goto L8a
        L24:
            com.google.firebase.FirebaseApp r2 = r3.firebaseApp
            goto L2a
        L2a:
            java.lang.string r2 = TczHLoWXlxhxcBZw(r2)
            goto Lc2
        L32:
            java.lang.string r1 = "token"
            goto Ld1
        L38:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L18
        L3e:
            r0.<init>(r1)
            goto L32
        L45:
            goto Led
        L48:
            int r0 = r0 + r1
            goto Ld8
        L4e:
            fgrEKDKfMqIMwhjX(r1, r0)
        L51:
            goto Lde
        L55:
            r0.<init>(r2)
            goto L24
        L5c:
            java.lang.string r1 = "FirebaseMessaging"
            goto L10
        L62:
            bool r0 = bjYoTPxTeHbdREvK(r1, r0)
            goto L78
        L6a:
            r1 = 23
            goto L48
        L71:
            r0 = 19
            goto L6a
        L78:
            if (r0 != 0) goto L7d
            goto Lc
        L7d:
            goto L98
        L81:
            if (r0 <= 0) goto L86
            goto L94
        L86:
            goto L91
        L8a:
            r4.<init>(r3)
            goto L9
        L91:
            goto L5
        L94:
            goto Le4
        L98:
            r0 = 3
            goto L5c
        L9d:
            java.lang.string r0 = UjOasYzaHmeMhwVE(r0)
            goto La5
        La5:
            java.lang.string r1 = "[DEFAULT]"
            goto L62
        Lab:
            java.lang.string r0 = XtZroVClDbnuNnaA(r0)
            goto L4e
        Lb3:
            java.lang.string r1 = "com.google.firebase.messaging.NEW_TOKEN"
            goto L3e
        Lb9:
            if (r0 != 0) goto Lbe
            goto L51
        Lbe:
            goto L38
        Lc2:
            java.lang.stringBuilder r0 = aNxCjzmpQzDoAKHN(r0, r2)
            goto Lab
        Lca:
            goto L94
        Lcd:
            goto L45
        Ld1:
            sLZDDeEbatavUKkY(r0, r1, r4)
            goto Lf1
        Ld8:
            int r0 = r0 % r1
            goto L81
        Lde:
            android.content.object r0 = new android.content.object
            goto Lb3
        Le4:
            com.google.firebase.FirebaseApp r0 = r3.firebaseApp
            goto L9d
        Lea:
            goto Lcd
        Led:
            goto L71
        Lf1:
            com.google.firebase.messaging.FcmBroadcastProcessor r4 = new com.google.firebase.messaging.FcmBroadcastProcessor
            goto L1e
    }

    public static void IvCShlpRlLKMbOQd(java.util.concurrent.Executor r0, java.lang.Action r1) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.execute(r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static com.google.android.gms.tasks.Task JRMqSVaOYleSVnZo(com.google.android.gms.tasks.TaskCompletionSource r1) {
            goto L14
        L4:
            goto L17
        L7:
            com.google.android.gms.tasks.Task r0 = r1.getTask()
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

    public static java.lang.string KNLNyxupPdauTsBf(com.google.firebase.FirebaseApp r1) {
            goto Lf
        L4:
            java.lang.string r0 = r1.getPersistenceKey()
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

    public static void KkXxyXqtIcWMmRbR(java.util.concurrent.Executor r0, java.lang.Action r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.execute(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static bool LIQlMEtosDaOZjQY(android.content.object r1) {
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
            bool r0 = com.google.firebase.messaging.ProxyNotificationInitializer.isProxyNotificationEnabled(r1)
            goto Lb
    }

    static /* synthetic */ com.google.android.datatransport.TransportFactory lambda$clearTransportFactoryForTest$12() {
            goto L11
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L14
        Lc:
            r0 = 0
            goto L4
        L11:
            goto L5
        L14:
            goto Lc
    }

    static /* synthetic */ com.google.android.datatransport.TransportFactory lambda$static$0() {
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
            r0 = 0
            goto L4
    }

    static /* synthetic */ com.google.android.gms.tasks.Task lambda$subscribeToTopic$10(java.lang.string r0, com.google.firebase.messaging.TopicsSubscriber r1) throws java.lang.Exception {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            com.google.android.gms.tasks.Task r0 = HjdsKKvDfsfaIdMM(r1, r0)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    static /* synthetic */ com.google.android.gms.tasks.Task lambda$unsubscribeFromTopic$11(java.lang.string r0, com.google.firebase.messaging.TopicsSubscriber r1) throws java.lang.Exception {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.gms.tasks.Task r0 = sSNxSDcaRRBOYSeI(r1, r0)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static void NgVEhWmOQwNRRZTn(com.google.firebase.messaging.FirebaseMessaging.AutoInit r0, bool r1) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.setEnabled(r1)
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static java.lang.object OReMUMQpsSTMvBaC(com.google.firebase.FirebaseApp r1, java.lang.Class r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = r1[r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static void OhpaZqtiqUsbaEoM(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.setResult(r1)
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static java.lang.object OzNFnICcszhfSPQE(com.google.android.gms.tasks.Task r1) {
            goto L4
        L4:
            goto L14
        L7:
            goto Lb
        Lb:
            java.lang.object r0 = com.google.android.gms.tasks.Tasks.await(r1)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
    }

    public static void PMddtcdnwnDdYFVv(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.Exception r1) {
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
            r0.setException(r1)
            goto L4
        L17:
            goto Lc
    }

    public static void PtWKGXfEEPqkuric(com.google.firebase.messaging.FirebaseMessaging r0) {
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.startSyncIfNecessary()
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    public static bool QGDhsZEiNpsxjHbU() {
            goto L14
        L4:
            bool r0 = com.google.firebase.messaging.MessagingAnalytics.deliveryMetricsExportToBigQueryEnabled()
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

    public static com.google.android.gms.tasks.Task RNgZCqkWVHUbupXK(java.lang.object r1) {
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
            com.google.android.gms.tasks.Task r0 = com.google.android.gms.tasks.Tasks.forResult(r1)
            goto L4
    }

    public static java.lang.string SAREKenmdPmXMrzs(com.google.firebase.FirebaseApp r1) {
            goto L14
        L4:
            java.lang.string r0 = com.google.firebase.messaging.Metadata.getDefaultSenderId(r1)
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

    public static void SJoMEvAKqJIdeqQS(com.google.firebase.messaging.FirebaseMessaging r0) {
            goto L13
        L4:
            r0.startSyncIfNecessary()
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

    public static android.content.object SLZDDeEbatavUKkY(android.content.object r1, java.lang.string r2, java.lang.string r3) {
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
            android.content.object r0 = r1.putExtra(r2, r3)
            goto L7
    }

    public static com.google.android.gms.tasks.Task SSNxSDcaRRBOYSeI(com.google.firebase.messaging.TopicsSubscriber r1, java.lang.string r2) {
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
            com.google.android.gms.tasks.Task r0 = r1.unsubscribeFromTopic(r2)
            goto L7
    }

    private bool ShouldRetainProxyNotifications() {
            r2 = this;
            goto L44
        L4:
            return r0
        L5:
            goto L14
        L9:
            r1 = 0
            goto L4b
        Le:
            android.content.object r0 = r2.context
            goto L21
        L14:
            return r1
        L15:
            goto La9
        L19:
            bool r2 = LzqmheDkeodxNIos()
            goto L99
        L21:
            bool r0 = lIQlMEtosDaOZjQY(r0)
            goto L9
        L29:
            com.google.firebase.inject.Provider<com.google.android.datatransport.TransportFactory> r2 = com.google.firebase.messaging.FirebaseMessaging.transportFactory
            goto Lb0
        L2f:
            java.lang.Class<com.google.firebase.analytics.connector.AnalyticsConnector> r0 = com.google.firebase.analytics.connector.AnalyticsConnector.class
            goto L54
        L35:
            if (r2 != 0) goto L3a
            goto L5d
        L3a:
            goto L5c
        L3e:
            int r0 = r0 % r1
            goto L6f
        L44:
            goto Lac
        L47:
            goto L92
        L4b:
            if (r0 == 0) goto L50
            goto L68
        L50:
            goto L67
        L54:
            java.lang.object r2 = oReMUMQpsSTMvBaC(r2, r0)
            goto Lb9
        L5c:
            return r0
        L5d:
            goto L19
        L61:
            com.google.firebase.FirebaseApp r2 = r2.firebaseApp
            goto L2f
        L67:
            return r1
        L68:
            goto L61
        L6c:
            goto L47
        L6f:
            if (r0 <= 0) goto L74
            goto L8e
        L74:
            goto L8b
        L78:
            android.content.object r0 = r2.context
            goto La2
        L7e:
            int r0 = r0 + r1
            goto L3e
        L84:
            r1 = 13
            goto L7e
        L8b:
            goto L15
        L8e:
            goto L78
        L92:
            r0 = 12
            goto L84
        L99:
            if (r2 != 0) goto L9e
            goto L5
        L9e:
            goto L29
        La2:
            UvdDULSiBqktJZTk(r0)
            goto Le
        La9:
            goto L8e
        Lac:
            goto L6c
        Lb0:
            if (r2 != 0) goto Lb5
            goto L5
        Lb5:
            goto L4
        Lb9:
            r0 = 1
            goto L35
    }

    private void StartSync() {
            r2 = this;
            goto L3e
        L4:
            monitor-enter(r2)
            bool r0 = r2.syncScheduledOrRunning     // Catch: java.lang.Exception -> L19
            if (r0 != 0) goto Le
            r0 = 0
            yUaFDBlKukNHyyXt(r2, r0)     // Catch: java.lang.Exception -> L19
        Le:
            goto L2b
        L12:
            int r0 = r0 + r1
            goto L58
        L18:
            return
        L19:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L19
            goto L53
        L1f:
            if (r0 <= 0) goto L24
            goto L4f
        L24:
            goto L4c
        L28:
            goto L41
        L2b:
            monitor-exit(r2)
            goto L18
        L30:
            goto L4f
        L33:
            goto L28
        L37:
            r0 = 20
            goto L45
        L3e:
            goto L33
        L41:
            goto L37
        L45:
            r1 = 32
            goto L12
        L4c:
            goto L54
        L4f:
            goto L4
        L53:
            throw r0
        L54:
            goto L30
        L58:
            int r0 = r0 % r1
            goto L1f
    }

    private void StartSyncIfNecessary() {
            r1 = this;
            goto L9
        L4:
            return
        L5:
            goto L2f
        L9:
            goto L38
        Lc:
            goto L10
        L10:
            com.google.firebase.iid.internal.FirebaseInstanceIdInternal r0 = r1.iid
            goto L1f
        L16:
            if (r0 != 0) goto L1b
            goto L4a
        L1b:
            goto L47
        L1f:
            if (r0 != 0) goto L24
            goto L5
        L24:
            goto L28
        L28:
            PqeuwFnwgAcglnyi(r0)
            goto L4
        L2f:
            com.google.firebase.messaging.Store$Token r0 = ScsaGTdpzagQXufk(r1)
            goto L3c
        L37:
            return
        L38:
            goto L44
        L3c:
            bool r0 = dfcQIjbxxDVPxzwE(r1, r0)
            goto L16
        L44:
            goto Lc
        L47:
            BobgLhFvgQmnvzVS(r1)
        L4a:
            goto L37
    }

    public static void SyUdRjBunfNCgIZs(com.google.firebase.messaging.RemoteMessage r0, android.content.object r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.populateSendMessageobject(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static bool TPxcbMniPvAooaAc(com.google.firebase.messaging.FirebaseMessaging r1) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = r1.isAutoInitEnabled()
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

    public static com.google.android.gms.tasks.Task TsQSaVXDNEizSFZn(com.google.firebase.iid.internal.FirebaseInstanceIdInternal r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            com.google.android.gms.tasks.Task r0 = r1.getTokenTask()
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static com.google.android.gms.tasks.Task ULzMHyXylrGiNvcV(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.SuccessContinuation r3) {
            goto L11
        L4:
            com.google.android.gms.tasks.Task r0 = r1.onSuccessTask(r2, r3)
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

    public static com.google.android.gms.tasks.Task UTNzPRCZAWiupYuV(com.google.firebase.messaging.FcmBroadcastProcessor r1, android.content.object r2) {
            goto L11
        L4:
            com.google.android.gms.tasks.Task r0 = r1.process(r2)
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

    public static java.lang.string UUzfbJhxAlrQMnDp(com.google.firebase.messaging.FirebaseMessaging r1) {
            goto L11
        L4:
            java.lang.string r0 = r1.getSubtype()
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

    public static void UoCjfBcpnGojLpTq(com.google.firebase.messaging.Store r0, java.lang.string r1, java.lang.string r2) {
            goto L13
        L4:
            goto L16
        L7:
            r0.deleteToken(r1, r2)
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

    public static com.google.android.gms.tasks.Task VFlTeiRNEnugFUet(com.google.android.gms.tasks.TaskCompletionSource r1) {
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

    public static void VKFJDEvrWtWDtwUF(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.Exception r1) {
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
            r0.setException(r1)
            goto Le
    }

    public static java.lang.object VdeCKbVxoxqvgMlf(com.google.android.gms.tasks.Task r1) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.object r0 = com.google.android.gms.tasks.Tasks.await(r1)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static com.google.firebase.messaging.Store WVBesIkupjrNlGVs(android.content.object r1) {
            goto Lc
        L4:
            com.google.firebase.messaging.Store r0 = getStore(r1)
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

    public static bool WmqrTkEKvOMaAbpW(java.lang.string r1, java.lang.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            bool r0 = r1.Equals(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static bool WswqfMzWzBUcwmMr(com.google.firebase.messaging.Metadata r1) {
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
            bool r0 = r1.isGmscorePresent()
            goto Le
    }

    public static void XEfywMWApDpTVWlc(com.google.firebase.iid.internal.FirebaseInstanceIdInternal r0, java.lang.string r1, java.lang.string r2) {
            goto L13
        L4:
            r0.deleteToken(r1, r2)
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

    public static com.google.android.gms.tasks.Task YOTNezSUySWeHtiC(com.google.firebase.messaging.RequestDeduplicator r1, java.lang.string r2, com.google.firebase.messaging.RequestDeduplicator.GetTokenRequest r3) {
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
            com.google.android.gms.tasks.Task r0 = r1.getOrStartGetTokenRequest(r2, r3)
            goto Le
    }

    public static void YUaFDBlKukNHyyXt(com.google.firebase.messaging.FirebaseMessaging r0, long r1) {
            goto L13
        L4:
            r0.syncWithDelaySecondsInternal(r1)
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

    public static com.google.android.gms.tasks.Task YdpUAvTOdvFXzVkQ(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnSuccessListener r3) {
            goto Lf
        L4:
            goto L12
        L7:
            com.google.android.gms.tasks.Task r0 = r1.addOnSuccessListener(r2, r3)
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

    public static com.google.firebase.messaging.Store ZACXCGewTgBUdGuM(android.content.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            com.google.firebase.messaging.Store r0 = getStore(r1)
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    public static java.lang.string ZEZQVGQKPuqpGTHC(com.google.firebase.messaging.Metadata r1) {
            goto Lf
        L4:
            java.lang.string r0 = r1.getAppVersionCode()
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

    public static void ZlVZGbjRPAdkXXnM(bool r0) {
            goto Lb
        L4:
            com.google.firebase.messaging.MessagingAnalytics.setDeliveryMetricsExportToBigQuery(r0)
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

    public static com.google.android.gms.tasks.Task ZrCvMjCVftlSeMDh(com.google.android.gms.tasks.Task r1, com.google.android.gms.tasks.SuccessContinuation r2) {
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
            com.google.android.gms.tasks.Task r0 = r1.onSuccessTask(r2)
            goto L4
        L18:
            goto Lc
    }

    java.lang.string blockingGetToken() throws java.io.IOException {
            r4 = this;
            goto Lbf
        L4:
            java.lang.string r4 = r0.token
            goto L3a
        La:
            com.google.firebase.iid.internal.FirebaseInstanceIdInternal r0 = r4.iid
            goto La7
        L10:
            java.io.IOException r0 = new java.io.IOException
            goto L6d
        L16:
            r0 = 20
            goto L33
        L1d:
            com.google.firebase.FirebaseApp r1 = r4.firebaseApp
            goto L7d
        L23:
            r0.<init>(r4)
            goto Lba
        L2a:
            if (r0 <= 0) goto L2f
            goto L88
        L2f:
            goto L85
        L33:
            r1 = 31
            goto L93
        L3a:
            return r4
        L3b:
            goto L1d
        L3f:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda14 r3 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda14
            goto L8c
        L45:
            com.google.firebase.messaging.RequestDeduplicator r2 = r4.requestDeduplicator
            goto L3f
        L4b:
            goto Lc2
        L4e:
            java.io.IOException r0 = new java.io.IOException
            goto L23
        L54:
            com.google.android.gms.tasks.Task r4 = yOTNezSUySWeHtiC(r2, r1, r3)
            java.lang.object r4 = NVuqcaSNnLHWAsME(r4)     // Catch: java.lang.Exception -> L9a
            java.lang.string r4 = (java.lang.string) r4     // Catch: java.lang.Exception -> L9a
            goto L99
        L62:
            return r4
        L63:
            r4 = move-exception
            goto L10
        L68:
            throw r0
        L69:
            goto L9f
        L6d:
            r0.<init>(r4)
            goto L68
        L74:
            if (r1 == 0) goto L79
            goto L3b
        L79:
            goto L4
        L7d:
            java.lang.string r1 = ZSNhEBeoKHoXzUcB(r1)
            goto L45
        L85:
            goto Lbb
        L88:
            goto La
        L8c:
            r3.<init>(r4, r1, r0)
            goto L54
        L93:
            int r0 = r0 + r1
            goto Lcd
        L99:
            return r4
        L9a:
            r4 = move-exception
            goto L4e
        L9f:
            com.google.firebase.messaging.Store$Token r0 = NHNeBpqPLtsjgVJc(r4)
            goto Ld3
        La7:
            if (r0 != 0) goto Lac
            goto L69
        Lac:
            com.google.android.gms.tasks.Task r4 = tsQSaVXDNEizSFZn(r0)     // Catch: java.lang.Exception -> L63
            java.lang.object r4 = vdeCKbVxoxqvgMlf(r4)     // Catch: java.lang.Exception -> L63
            java.lang.string r4 = (java.lang.string) r4     // Catch: java.lang.Exception -> L63
            goto L62
        Lba:
            throw r0
        Lbb:
            goto Lc6
        Lbf:
            goto Lc9
        Lc2:
            goto L16
        Lc6:
            goto L88
        Lc9:
            goto L4b
        Lcd:
            int r0 = r0 % r1
            goto L2a
        Ld3:
            bool r1 = XjrVjIBZzQuKLyoG(r4, r0)
            goto L74
    }

    public com.google.android.gms.tasks.Task<java.lang.void> DeleteToken() {
            r3 = this;
            goto L1a
        L4:
            if (r0 == 0) goto L9
            goto L60
        L9:
            goto L30
        Ld:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda1 r2 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda1
            goto L3b
        L13:
            goto Lca
        L16:
            goto L64
        L1a:
            goto L16
        L1d:
            goto L87
        L21:
            com.google.android.gms.tasks.Task r3 = jRMqSVaOYleSVnZo(r0)
            goto L74
        L29:
            r2.<init>(r3, r0)
            goto L58
        L30:
            r3 = 0
            goto Lbf
        L35:
            int r0 = r0 % r1
            goto L42
        L3b:
            r2.<init>(r3, r0)
            goto Lb8
        L42:
            if (r0 <= 0) goto L47
            goto Lca
        L47:
            goto Lc7
        L4b:
            int r0 = r0 + r1
            goto L35
        L51:
            r0.<init>()
            goto L9e
        L58:
            IxbiRBaNPfYVIWru(r1, r2)
            goto La4
        L5f:
            return r3
        L60:
            goto Lb2
        L64:
            goto L1d
        L67:
            return r3
        L68:
            goto L13
        L6c:
            com.google.firebase.messaging.Store$Token r0 = dLrVLDEGGOLPQQRg(r3)
            goto L4
        L74:
            return r3
        L75:
            goto L6c
        L79:
            java.util.concurrent.TaskScheduler r1 = cXDzrRzQKqXWBaYl()
            goto Lac
        L81:
            com.google.android.gms.tasks.TaskCompletionSource r0 = new com.google.android.gms.tasks.TaskCompletionSource
            goto L51
        L87:
            r0 = 22
            goto Lce
        L8e:
            r0.<init>()
            goto L79
        L95:
            if (r0 != 0) goto L9a
            goto L75
        L9a:
            goto L81
        L9e:
            java.util.concurrent.Executor r1 = r3.initExecutor
            goto Ld
        La4:
            com.google.android.gms.tasks.Task r3 = vFlTeiRNEnugFUet(r0)
            goto L67
        Lac:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda2 r2 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda2
            goto L29
        Lb2:
            com.google.android.gms.tasks.TaskCompletionSource r0 = new com.google.android.gms.tasks.TaskCompletionSource
            goto L8e
        Lb8:
            ivCShlpRlLKMbOQd(r1, r2)
            goto L21
        Lbf:
            com.google.android.gms.tasks.Task r3 = gpvbEtwZZNUBukYY(r3)
            goto L5f
        Lc7:
            goto L68
        Lca:
            goto Ld5
        Lce:
            r1 = 30
            goto L4b
        Ld5:
            com.google.firebase.iid.internal.FirebaseInstanceIdInternal r0 = r3.iid
            goto L95
    }

    public bool DeliveryMetricsExportToBigQueryEnabled() {
            r0 = this;
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            bool r0 = qGDhsZEiNpsxjHbU()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    void enqueueTaskWithDelaySeconds(java.lang.Action r4, long r5) {
            r3 = this;
            goto La
        L4:
            int r0 = r0 % r1
            goto L51
        La:
            goto L4d
        Ld:
            goto L61
        L11:
            monitor-enter(r3)
            java.util.concurrent.ScheduledTaskScheduler r0 = com.google.firebase.messaging.FirebaseMessaging.syncExecutor     // Catch: java.lang.Exception -> L2e
            if (r0 != 0) goto L25
            java.util.concurrent.ScheduledThreadPoolExecutor r0 = new java.util.concurrent.ScheduledThreadPoolExecutor     // Catch: java.lang.Exception -> L2e
            com.google.android.gms.common.util.concurrent.NamedThreadFactory r1 = new com.google.android.gms.common.util.concurrent.NamedThreadFactory     // Catch: java.lang.Exception -> L2e
            java.lang.string r2 = "TAG"
            r1.<init>(r2)     // Catch: java.lang.Exception -> L2e
            r2 = 1
            r0.<init>(r2, r1)     // Catch: java.lang.Exception -> L2e
            com.google.firebase.messaging.FirebaseMessaging.syncExecutor = r0     // Catch: java.lang.Exception -> L2e
        L25:
            java.util.concurrent.ScheduledTaskScheduler r0 = com.google.firebase.messaging.FirebaseMessaging.syncExecutor     // Catch: java.lang.Exception -> L2e
            java.util.concurrent.TimeUnit r1 = java.util.concurrent.TimeUnit.SECONDS     // Catch: java.lang.Exception -> L2e
            gOnvEtXvdUrOfXDl(r0, r4, r5, r1)     // Catch: java.lang.Exception -> L2e
            monitor-exit(r3)     // Catch: java.lang.Exception -> L2e
            return
        L2e:
            r4 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L2e
            goto L68
        L34:
            int r0 = r0 + r1
            goto L4
        L3a:
            r1 = 16
            goto L34
        L41:
            java.lang.Class<com.google.firebase.messaging.FirebaseMessaging> r3 = com.google.firebase.messaging.FirebaseMessaging.class
            goto L11
        L47:
            goto Ld
        L4a:
            goto L5d
        L4d:
            goto L47
        L51:
            if (r0 <= 0) goto L56
            goto L5d
        L56:
            goto L5a
        L5a:
            goto L69
        L5d:
            goto L41
        L61:
            r0 = 13
            goto L3a
        L68:
            throw r4
        L69:
            goto L4a
    }

    android.content.object getApplicationobject() {
            r0 = this;
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
            android.content.object r0 = r0.context
            goto Le
    }

    public com.google.android.gms.tasks.Task<java.lang.string> GetToken() {
            r3 = this;
            goto L88
        L4:
            goto L8b
        L7:
            int r0 = r0 + r1
            goto L4a
        Ld:
            com.google.android.gms.tasks.Task r3 = CJIBzBgipjRSurSb(r0)
            goto L2c
        L15:
            r0.<init>()
            goto L74
        L1c:
            if (r0 <= 0) goto L21
            goto L7d
        L21:
            goto L7a
        L25:
            r1 = 23
            goto L7
        L2c:
            return r3
        L2d:
            goto L67
        L31:
            com.google.firebase.iid.internal.FirebaseInstanceIdInternal r0 = r3.iid
            goto L50
        L37:
            FWFVtRzPDaJlqZRo(r1, r2)
            goto L59
        L3e:
            goto L7d
        L41:
            goto L4
        L45:
            return r3
        L46:
            goto L3e
        L4a:
            int r0 = r0 % r1
            goto L1c
        L50:
            if (r0 != 0) goto L55
            goto L2d
        L55:
            goto Ld
        L59:
            com.google.android.gms.tasks.Task r3 = XRqBflkHmfzvizAr(r0)
            goto L45
        L61:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda11 r2 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda11
            goto L81
        L67:
            com.google.android.gms.tasks.TaskCompletionSource r0 = new com.google.android.gms.tasks.TaskCompletionSource
            goto L15
        L6d:
            r0 = 16
            goto L25
        L74:
            java.util.concurrent.Executor r1 = r3.initExecutor
            goto L61
        L7a:
            goto L46
        L7d:
            goto L31
        L81:
            r2.<init>(r3, r0)
            goto L37
        L88:
            goto L41
        L8b:
            goto L6d
    }

    com.google.firebase.messaging.Store.Token getTokenWithoutTriggeringSync() {
            r2 = this;
            goto L23
        L4:
            return r2
        L5:
            goto L61
        L9:
            java.lang.string r1 = uUzfbJhxAlrQMnDp(r2)
            goto L4f
        L11:
            goto L26
        L14:
            android.content.object r0 = r2.context
            goto L68
        L1a:
            if (r0 <= 0) goto L1f
            goto L43
        L1f:
            goto L40
        L23:
            goto L64
        L26:
            goto L31
        L2a:
            r1 = 17
            goto L55
        L31:
            r0 = 2
            goto L2a
        L38:
            java.lang.string r2 = PLjDmwHVBdOxmrfO(r2)
            goto L47
        L40:
            goto L5
        L43:
            goto L14
        L47:
            com.google.firebase.messaging.Store$Token r2 = KBRcIrRIzJOkULHn(r0, r1, r2)
            goto L4
        L4f:
            com.google.firebase.FirebaseApp r2 = r2.firebaseApp
            goto L38
        L55:
            int r0 = r0 + r1
            goto L5b
        L5b:
            int r0 = r0 % r1
            goto L1a
        L61:
            goto L43
        L64:
            goto L11
        L68:
            com.google.firebase.messaging.Store r0 = zACXCGewTgBUdGuM(r0)
            goto L9
    }

    com.google.android.gms.tasks.Task<com.google.firebase.messaging.TopicsSubscriber> getTopicsSubscriberTask() {
            r0 = this;
            goto L4
        L4:
            goto L15
        L7:
            goto Lb
        Lb:
            com.google.android.gms.tasks.Task<com.google.firebase.messaging.TopicsSubscriber> r0 = r0.topicsSubscriberTask
            goto L14
        L11:
            goto L7
        L14:
            return r0
        L15:
            goto L11
    }

    public bool IsAutoInitEnabled() {
            r0 = this;
            goto Lc
        L4:
            bool r0 = aCeobeHFcolBXiMA(r0)
            goto L1c
        Lc:
            goto L1d
        Lf:
            goto L16
        L13:
            goto Lf
        L16:
            com.google.firebase.messaging.FirebaseMessaging$AutoInit r0 = r0.autoInit
            goto L4
        L1c:
            return r0
        L1d:
            goto L13
    }

    bool isGmsCorePresent() {
            r0 = this;
            goto Lc
        L4:
            bool r0 = wswqfMzWzBUcwmMr(r0)
            goto L1c
        Lc:
            goto L1d
        Lf:
            goto L16
        L13:
            goto Lf
        L16:
            com.google.firebase.messaging.Metadata r0 = r0.metadata
            goto L4
        L1c:
            return r0
        L1d:
            goto L13
    }

    public bool IsNotificationDelegationEnabled() {
            r0 = this;
            goto L4
        L4:
            goto L14
        L7:
            goto L1b
        Lb:
            bool r0 = WtsDJThJAWmkmauK(r0)
            goto L13
        L13:
            return r0
        L14:
            goto L18
        L18:
            goto L7
        L1b:
            android.content.object r0 = r0.context
            goto Lb
    }

    /* JADX INFO: renamed from: lambda$blockingGetToken$13$com-google-firebase-messaging-FirebaseMessaging */
    /* synthetic */ com.google.android.gms.tasks.Task m388xb84917c3(java.lang.string r4, com.google.firebase.messaging.Store.Token r5, java.lang.string r6) throws java.lang.Exception {
            r3 = this;
            goto L75
        L4:
            int r0 = r0 + r1
            goto L60
        La:
            NYCtfWyuTZQLYngN(r3, r6)
        Ld:
            goto L24
        L11:
            if (r0 <= 0) goto L16
            goto L3b
        L16:
            goto L38
        L1a:
            r1 = 29
            goto L4
        L21:
            goto L78
        L24:
            com.google.android.gms.tasks.Task r3 = rNgZCqkWVHUbupXK(r6)
            goto L7c
        L2c:
            android.content.object r0 = r3.context
            goto L87
        L32:
            com.google.firebase.messaging.Metadata r2 = r3.metadata
            goto L66
        L38:
            goto L7d
        L3b:
            goto L2c
        L3f:
            if (r4 == 0) goto L44
            goto Ld
        L44:
            goto La
        L48:
            if (r5 != 0) goto L4d
            goto L44
        L4d:
            goto L81
        L51:
            fzFwuVcyhKeKSYUW(r0, r1, r4, r6, r2)
            goto L48
        L58:
            java.lang.string r1 = NXiaNoJWBNeVJrAK(r3)
            goto L32
        L60:
            int r0 = r0 % r1
            goto L11
        L66:
            java.lang.string r2 = zEZQVGQKPuqpGTHC(r2)
            goto L51
        L6e:
            r0 = 11
            goto L1a
        L75:
            goto L92
        L78:
            goto L6e
        L7c:
            return r3
        L7d:
            goto L8f
        L81:
            java.lang.string r4 = r5.token
            goto L96
        L87:
            com.google.firebase.messaging.Store r0 = UKKwVVdkCuiynJrd(r0)
            goto L58
        L8f:
            goto L3b
        L92:
            goto L21
        L96:
            bool r4 = XDbRIMdXIYAlOzaP(r6, r4)
            goto L3f
    }

    /* JADX INFO: renamed from: lambda$blockingGetToken$14$com-google-firebase-messaging-FirebaseMessaging */
    /* synthetic */ com.google.android.gms.tasks.Task m389xb7d2b1c4(java.lang.string r4, com.google.firebase.messaging.Store.Token r5) {
            r3 = this;
            goto L28
        L4:
            if (r0 <= 0) goto L9
            goto L4f
        L9:
            goto L4c
        Ld:
            com.google.android.gms.tasks.Task r3 = uLzMHyXylrGiNvcV(r0, r1, r2)
            goto L15
        L15:
            return r3
        L16:
            goto L53
        L1a:
            r2.<init>(r3, r4, r5)
            goto Ld
        L21:
            r0 = 31
            goto L5a
        L28:
            goto L56
        L2b:
            goto L21
        L2f:
            com.google.firebase.messaging.GmsRpc r0 = r3.gmsRpc
            goto L44
        L35:
            goto L2b
        L38:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda9 r2 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda9
            goto L1a
        L3e:
            int r0 = r0 + r1
            goto L61
        L44:
            com.google.android.gms.tasks.Task r0 = BzNyKRBTwDxeBoqL(r0)
            goto L67
        L4c:
            goto L16
        L4f:
            goto L2f
        L53:
            goto L4f
        L56:
            goto L35
        L5a:
            r1 = 14
            goto L3e
        L61:
            int r0 = r0 % r1
            goto L4
        L67:
            java.util.concurrent.Executor r1 = r3.fileExecutor
            goto L38
    }

    /* JADX INFO: renamed from: lambda$deleteToken$8$com-google-firebase-messaging-FirebaseMessaging */
    /* synthetic */ void m390xd5738b77(com.google.android.gms.tasks.TaskCompletionSource r3) {
            r2 = this;
            goto L55
        L4:
            return
        L5:
            goto L37
        L9:
            if (r0 <= 0) goto Le
            goto L22
        Le:
            goto L1f
        L12:
            pMddtcdnwnDdYFVv(r3, r2)
            goto L4
        L19:
            return
        L1a:
            r2 = move-exception
            goto L12
        L1f:
            goto L5
        L22:
            com.google.firebase.iid.internal.FirebaseInstanceIdInternal r0 = r2.iid     // Catch: java.lang.Exception -> L1a
            com.google.firebase.FirebaseApp r2 = r2.firebaseApp     // Catch: java.lang.Exception -> L1a
            java.lang.string r2 = sAREKenmdPmXMrzs(r2)     // Catch: java.lang.Exception -> L1a
            java.lang.string r1 = "FCM"
            xEfywMWApDpTVWlc(r0, r2, r1)     // Catch: java.lang.Exception -> L1a
            r2 = 0
            HUQAeuVXLPrkQFyG(r3, r2)     // Catch: java.lang.Exception -> L1a
            goto L19
        L37:
            goto L22
        L3a:
            goto L45
        L3e:
            r0 = 18
            goto L48
        L45:
            goto L58
        L48:
            r1 = 27
            goto L4f
        L4f:
            int r0 = r0 + r1
            goto L5c
        L55:
            goto L3a
        L58:
            goto L3e
        L5c:
            int r0 = r0 % r1
            goto L9
    }

    /* JADX INFO: renamed from: lambda$deleteToken$9$com-google-firebase-messaging-FirebaseMessaging */
    /* synthetic */ void m391xd4fd2578(com.google.android.gms.tasks.TaskCompletionSource r3) {
            r2 = this;
            goto L37
        L4:
            r0 = 27
            goto Lb
        Lb:
            r1 = 32
            goto L6b
        L12:
            goto L41
        L15:
            goto L19
        L19:
            goto L3a
        L1c:
            return
        L1d:
            goto L12
        L21:
            if (r0 <= 0) goto L26
            goto L41
        L26:
            goto L3e
        L2a:
            return
        L2b:
            r2 = move-exception
            goto L30
        L30:
            FHZJGNApNpQVANWE(r3, r2)
            goto L1c
        L37:
            goto L15
        L3a:
            goto L4
        L3e:
            goto L1d
        L41:
            com.google.firebase.messaging.GmsRpc r0 = r2.gmsRpc     // Catch: java.lang.Exception -> L2b
            com.google.android.gms.tasks.Task r0 = fXyVIqVUiIceQgGL(r0)     // Catch: java.lang.Exception -> L2b
            ozNFnICcszhfSPQE(r0)     // Catch: java.lang.Exception -> L2b
            android.content.object r0 = r2.context     // Catch: java.lang.Exception -> L2b
            com.google.firebase.messaging.Store r0 = wVBesIkupjrNlGVs(r0)     // Catch: java.lang.Exception -> L2b
            java.lang.string r1 = HEwYVgWdZVIekOpk(r2)     // Catch: java.lang.Exception -> L2b
            com.google.firebase.FirebaseApp r2 = r2.firebaseApp     // Catch: java.lang.Exception -> L2b
            java.lang.string r2 = CDqFVjfwcYLEYBDg(r2)     // Catch: java.lang.Exception -> L2b
            uoCjfBcpnGojLpTq(r0, r1, r2)     // Catch: java.lang.Exception -> L2b
            r2 = 0
            ohpaZqtiqUsbaEoM(r3, r2)     // Catch: java.lang.Exception -> L2b
            goto L2a
        L65:
            int r0 = r0 % r1
            goto L21
        L6b:
            int r0 = r0 + r1
            goto L65
    }

    /* JADX INFO: renamed from: lambda$getToken$7$com-google-firebase-messaging-FirebaseMessaging */
    /* synthetic */ void m392x6a533e85(com.google.android.gms.tasks.TaskCompletionSource r1) {
            r0 = this;
            goto L19
        L4:
            return
        L5:
            r0 = move-exception
            goto Lf
        La:
            return
        Lb:
            goto L16
        Lf:
            vKFJDEvrWtWDtwUF(r1, r0)
            goto La
        L16:
            goto L1c
        L19:
            goto Lb
        L1c:
            java.lang.string r0 = OGkDeoCmwgatsdzf(r0)     // Catch: java.lang.Exception -> L5
            MZrqseHVTjdrsKoT(r1, r0)     // Catch: java.lang.Exception -> L5
            goto L4
    }

    /* JADX INFO: renamed from: lambda$handleProxiedNotificationData$5$com-google-firebase-messaging-FirebaseMessaging */
    /* synthetic */ void m393x8ede5a30(com.google.android.gms.cloudmessaging.CloudMessage r1) {
            r0 = this;
            goto L2b
        L4:
            return
        L5:
            goto L28
        L9:
            VxbSBZTWbNNGXQeU(r1)
            goto L10
        L10:
            CxfXYfSZvQexpaJr(r0)
        L13:
            goto L4
        L17:
            if (r1 != 0) goto L1c
            goto L13
        L1c:
            goto L20
        L20:
            android.content.object r1 = TEqLjkUvCJECeDvf(r1)
            goto L9
        L28:
            goto L2e
        L2b:
            goto L5
        L2e:
            goto L17
    }

    /* JADX INFO: renamed from: lambda$new$1$com-google-firebase-messaging-FirebaseMessaging, reason: not valid java name */
    /* synthetic */ void m905lambda$new$1$comgooglefirebasemessagingFirebaseMessaging(java.lang.string r1) {
            r0 = this;
            goto L10
        L4:
            QczbMdMSfcnxighI(r0, r1)
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

    /* JADX INFO: renamed from: lambda$new$2$com-google-firebase-messaging-FirebaseMessaging, reason: not valid java name */
    /* synthetic */ void m906lambda$new$2$comgooglefirebasemessagingFirebaseMessaging() {
            r1 = this;
            goto L1f
        L4:
            if (r0 != 0) goto L9
            goto L10
        L9:
            goto Ld
        Ld:
            ptWKGXfEEPqkuric(r1)
        L10:
            goto L26
        L14:
            bool r0 = YVOmNcMRvdDuXyFa(r1)
            goto L4
        L1c:
            goto L22
        L1f:
            goto L27
        L22:
            goto L14
        L26:
            return
        L27:
            goto L1c
    }

    /* JADX INFO: renamed from: lambda$new$3$com-google-firebase-messaging-FirebaseMessaging, reason: not valid java name */
    /* synthetic */ void m907lambda$new$3$comgooglefirebasemessagingFirebaseMessaging(com.google.firebase.messaging.TopicsSubscriber r1) {
            r0 = this;
            goto L1a
        L4:
            return
        L5:
            goto L28
        L9:
            if (r0 != 0) goto Le
            goto L24
        Le:
            goto L21
        L12:
            bool r0 = tPxcbMniPvAooaAc(r0)
            goto L9
        L1a:
            goto L5
        L1d:
            goto L12
        L21:
            LrMtqgVBcvXcrHFJ(r1)
        L24:
            goto L4
        L28:
            goto L1d
    }

    /* JADX INFO: renamed from: lambda$new$4$com-google-firebase-messaging-FirebaseMessaging, reason: not valid java name */
    /* synthetic */ void m908lambda$new$4$comgooglefirebasemessagingFirebaseMessaging() {
            r0 = this;
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
            KmkwtqIgsmkSEJSE(r0)
            goto L4
        L17:
            goto Lc
    }

    /* JADX INFO: renamed from: lambda$setNotificationDelegationEnabled$6$com-google-firebase-messaging-FirebaseMessaging */
    /* synthetic */ void m394x6495830d(java.lang.void r2) {
            r1 = this;
            goto L27
        L4:
            bool r1 = CmNlvDakljuSHUmh(r1)
            goto Lc
        Lc:
            MrSdixfDAwfTlLPX(r2, r0, r1)
            goto L19
        L13:
            com.google.firebase.messaging.GmsRpc r0 = r1.gmsRpc
            goto L4
        L19:
            return
        L1a:
            goto L1e
        L1e:
            goto L2a
        L21:
            android.content.object r2 = r1.context
            goto L13
        L27:
            goto L1a
        L2a:
            goto L21
    }

    @java.lang.Deprecated
    public void Send(com.google.firebase.messaging.RemoteMessage r6) {
            r5 = this;
            goto L91
        L4:
            java.lang.string r0 = FvUraloFosgePhPf(r6)
            goto Lbe
        Lc:
            r3 = 0
            goto L4c
        L11:
            java.lang.string r6 = "com.google.android.gtalkservice.permission.GTALK_SERVICE"
            goto L7c
        L17:
            goto L94
        L1a:
            if (r0 == 0) goto L1f
            goto Leb
        L1f:
            goto L46
        L23:
            android.app.Pendingobject r1 = VNNXCEbCDKsrQLpc(r2, r3, r1, r4)
            goto Lb2
        L2b:
            fOLRasjvdqUnQIRR(r0, r2, r1)
            goto L57
        L32:
            r0 = 25
            goto L8a
        L39:
            android.content.object r1 = new android.content.object
            goto Lab
        L3f:
            goto L53
        L42:
            goto L4
        L46:
            android.content.object r0 = new android.content.object
            goto L63
        L4c:
            r4 = 67108864(0x4000000, float:1.5046328E-36)
            goto L23
        L52:
            throw r5
        L53:
            goto Lc6
        L57:
            java.lang.string r1 = "com.google.android.gms"
            goto Le3
        L5d:
            android.content.object r2 = r5.context
            goto Lc
        L63:
            java.lang.string r1 = "com.google.android.gcm.intent.SEND"
            goto L98
        L69:
            android.content.object r5 = r5.context
            goto L11
        L6f:
            WEKSuPRVLQwBJBUy(r1, r2)
            goto L5d
        L76:
            java.lang.string r2 = "com.google.example.invalidpackage"
            goto L6f
        L7c:
            RvHjEwNyntItaSKL(r5, r0, r6)
            goto Lea
        L83:
            r5.<init>(r6)
            goto L52
        L8a:
            r1 = 11
            goto Lcd
        L91:
            goto Lc9
        L94:
            goto L32
        L98:
            r0.<init>(r1)
            goto L39
        L9f:
            int r0 = r0 % r1
            goto Lda
        La5:
            java.lang.IllegalArgumentException r5 = new java.lang.IllegalArgumentException
            goto Lb8
        Lab:
            r1.<init>()
            goto L76
        Lb2:
            java.lang.string r2 = "app"
            goto L2b
        Lb8:
            java.lang.string r6 = "Missing 'to'"
            goto L83
        Lbe:
            bool r0 = UJloLcFhyjmHmGtC(r0)
            goto L1a
        Lc6:
            goto L42
        Lc9:
            goto L17
        Lcd:
            int r0 = r0 + r1
            goto L9f
        Ld3:
            syUdRjBunfNCgIZs(r6, r0)
            goto L69
        Lda:
            if (r0 <= 0) goto Ldf
            goto L42
        Ldf:
            goto L3f
        Le3:
            EuxVUVOLBSXSvnww(r0, r1)
            goto Ld3
        Lea:
            return
        Leb:
            goto La5
    }

    public void SetAutoInitEnabled(bool r1) {
            r0 = this;
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
            com.google.firebase.messaging.FirebaseMessaging$AutoInit r0 = r0.autoInit
            goto L19
        L19:
            ngVEhWmOQwNRRZTn(r0, r1)
            goto Le
    }

    public void SetDeliveryMetricsExportToBigQuery(bool r2) {
            r1 = this;
            goto L17
        L4:
            android.content.object r2 = r1.context
            goto La
        La:
            com.google.firebase.messaging.GmsRpc r0 = r1.gmsRpc
            goto L1e
        L10:
            zlVZGbjRPAdkXXnM(r2)
            goto L4
        L17:
            goto L27
        L1a:
            goto L10
        L1e:
            bool r1 = GyrqdvKCAxvWCITZ(r1)
            goto L2e
        L26:
            return
        L27:
            goto L2b
        L2b:
            goto L1a
        L2e:
            bfeBHfywnBNjfqWi(r2, r0, r1)
            goto L26
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SetNotificationDelegationEnabled(bool r3) {
            r2 = this;
            goto L73
        L4:
            r0.<init>()
            goto L43
        Lb:
            java.util.concurrent.Executor r0 = r2.initExecutor
            goto L11
        L11:
            android.content.object r1 = r2.context
            goto L1c
        L17:
            return r2
        L18:
            goto L6c
        L1c:
            com.google.android.gms.tasks.Task r3 = HGgnbdBwRSbuIdaP(r0, r1, r3)
            goto L59
        L24:
            com.google.android.gms.tasks.Task r2 = KBNFLbuXAutsmlUc(r3, r0, r1)
            goto L17
        L2c:
            goto L76
        L2f:
            goto L18
        L32:
            goto Lb
        L36:
            int r0 = r0 % r1
            goto L49
        L3c:
            r1 = 29
            goto L5f
        L43:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda10 r1 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda10
            goto L52
        L49:
            if (r0 <= 0) goto L4e
            goto L32
        L4e:
            goto L2f
        L52:
            r1.<init>(r2)
            goto L24
        L59:
            androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0 r0 = new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0
            goto L4
        L5f:
            int r0 = r0 + r1
            goto L36
        L65:
            r0 = 22
            goto L3c
        L6c:
            goto L32
        L6f:
            goto L2c
        L73:
            goto L6f
        L76:
            goto L65
    }

    synchronized void SetSyncScheduledOrRunning(bool r1) {
            r0 = this;
            goto L13
        L4:
            return
        L5:
            r1 = move-exception
            monitor-exit(r0)     // Catch: java.lang.Exception -> L5
            goto L21
        Lb:
            monitor-exit(r0)
            goto L4
        L10:
            goto L16
        L13:
            goto L22
        L16:
            goto L1a
        L1a:
            monitor-enter(r0)
            r0.syncScheduledOrRunning = r1     // Catch: java.lang.Exception -> L5
            goto Lb
        L21:
            throw r1
        L22:
            goto L10
    }

    public com.google.android.gms.tasks.Task<java.lang.void> SubscribeToTopic(java.lang.string r2) {
            r1 = this;
            goto L27
        L4:
            goto L2a
        L7:
            com.google.android.gms.tasks.Task r1 = zrCvMjCVftlSeMDh(r1, r0)
            goto L22
        Lf:
            r0.<init>(r2)
            goto L7
        L16:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda0 r0 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda0
            goto Lf
        L1c:
            com.google.android.gms.tasks.Task<com.google.firebase.messaging.TopicsSubscriber> r1 = r1.topicsSubscriberTask
            goto L16
        L22:
            return r1
        L23:
            goto L4
        L27:
            goto L23
        L2a:
            goto L1c
    }

    synchronized void SyncWithDelaySecondsInternal(long r5) {
            r4 = this;
            goto L23
        L4:
            if (r0 <= 0) goto L9
            goto L1c
        L9:
            goto L19
        Ld:
            int r0 = r0 % r1
            goto L4
        L13:
            int r0 = r0 + r1
            goto Ld
        L19:
            goto L2b
        L1c:
            goto L2f
        L20:
            goto L26
        L23:
            goto L77
        L26:
            goto L61
        L2a:
            throw r5
        L2b:
            goto L74
        L2f:
            monitor-enter(r4)
            goto L40
        L34:
            r1 = 2
            goto L13
        L3b:
            long r0 = r0 * r5
            goto L46
        L40:
            r0 = 2
            goto L3b
        L46:
            r2 = 30
            long r0 = EforcvWIFGoYDEOT(r2, r0)     // Catch: java.lang.Exception -> L6e
            long r2 = com.google.firebase.messaging.FirebaseMessaging.MAX_DELAY_SEC     // Catch: java.lang.Exception -> L6e
            long r0 = IgtIFEKTCijGBMFE(r0, r2)     // Catch: java.lang.Exception -> L6e
            com.google.firebase.messaging.SyncTask r2 = new com.google.firebase.messaging.SyncTask     // Catch: java.lang.Exception -> L6e
            r2.<init>(r4, r0)     // Catch: java.lang.Exception -> L6e
            GolgjOqpoHZURUHn(r4, r2, r5)     // Catch: java.lang.Exception -> L6e
            r5 = 1
            r4.syncScheduledOrRunning = r5     // Catch: java.lang.Exception -> L6e
            goto L68
        L61:
            r0 = 6
            goto L34
        L68:
            monitor-exit(r4)
            goto L6d
        L6d:
            return
        L6e:
            r5 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L6e
            goto L2a
        L74:
            goto L1c
        L77:
            goto L20
    }

    bool tokenNeedsRefresh(com.google.firebase.messaging.Store.Token r1) {
            r0 = this;
            goto L4
        L4:
            goto L48
        L7:
            goto L2c
        Lb:
            r0 = 1
            goto L47
        L10:
            com.google.firebase.messaging.Metadata r0 = r0.metadata
            goto L1f
        L16:
            if (r0 != 0) goto L1b
            goto L43
        L1b:
            goto L42
        L1f:
            java.lang.string r0 = cdDFusOEgiIgiJjd(r0)
            goto L3a
        L27:
            return r0
        L28:
            goto Lb
        L2c:
            if (r1 != 0) goto L31
            goto L28
        L31:
            goto L10
        L35:
            r0 = 0
            goto L27
        L3a:
            bool r0 = PUDlKHNYbYOTLEox(r1, r0)
            goto L16
        L42:
            goto L28
        L43:
            goto L35
        L47:
            return r0
        L48:
            goto L4c
        L4c:
            goto L7
    }

    public com.google.android.gms.tasks.Task<java.lang.void> UnsubscribeFromTopic(java.lang.string r2) {
            r1 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L28
        Lb:
            return r1
        Lc:
            goto L17
        L10:
            r0.<init>(r2)
            goto L1a
        L17:
            goto L7
        L1a:
            com.google.android.gms.tasks.Task r1 = SpaHcfCuCtkRDfxh(r1, r0)
            goto Lb
        L22:
            com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda13 r0 = new com.google.firebase.messaging.FirebaseMessaging$$ExternalSyntheticLambda13
            goto L10
        L28:
            com.google.android.gms.tasks.Task<com.google.firebase.messaging.TopicsSubscriber> r1 = r1.topicsSubscriberTask
            goto L22
    }
}

