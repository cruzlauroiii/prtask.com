namespace WillowMaze.Wasm.Decompiled;


class FirebaseMessaging$AutoInit {
    private static readonly java.lang.string AUTO_INIT_PREF = "auto_init";
    private static readonly java.lang.string FCM_PREFERENCES = "com.google.firebase.messaging";
    private static readonly java.lang.string MANIFEST_METADATA_AUTO_INIT_ENABLED = "firebase_messaging_auto_init_enabled";
    private java.lang.bool autoInitEnabled;
    private com.google.firebase.events.EventHandler<com.google.firebase.DataICollectionDefaultChange> dataICollectionDefaultChangeEventHandler;
    private bool initialized;
    private readonly com.google.firebase.events.Subscriber subscriber;
    readonly com.google.firebase.messaging.FirebaseMessaging this$0;

    FirebaseMessaging$AutoInit(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging, com.google.firebase.events.Subscriber subscriber) {
        this.this$0 = firebaseMessaging;
        this.subscriber = subscriber;
    }

    public static com.google.firebase.FirebaseApp AqdKEwovEaHqYdtD(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging) {
        return com.google.firebase.messaging.FirebaseMessaging.access$000(firebaseMessaging);
    }

    public static void BhLHCYCdfiLrfGVK(com.google.firebase.events.Subscriber subscriber, java.lang.Class cls, com.google.firebase.events.EventHandler eventHandler) {
        subscriber.subscribe(cls, eventHandler);
    }

    public static android.content.object BzrkdqMVPuRhCydQ(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static android.content.Dictionary<string, object>$Editor CAUxWLmSEvJsUMUw(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor, java.lang.string str, bool z) {
        return sharedPreferences$Editor.putbool(str, z);
    }

    public static bool COkMfxGfmttyIPAe(java.lang.bool bool) {
        return bool.boolValue();
    }

    public static java.lang.bool CYqQlvuegZxUrxSC(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool CiwPYEzVxIZzhOQC(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str) {
        return sharedPreferences.Contains(str);
    }

    public static java.lang.bool FdsIMotHDNlVIfxj(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static android.content.Dictionary<string, object>$Editor FijwAquXlnFlglAN(android.content.Dictionary<string, object> sharedPreferences) {
        return sharedPreferences.edit();
    }

    public static java.lang.bool GPytKAbCkhcmNapp(com.google.firebase.messaging.FirebaseMessaging$AutoInit firebaseMessaging$AutoInit) {
        return firebaseMessaging$AutoInit.readEnabled();
    }

    public static android.content.object MwIPkHCZCrwjblBS(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.getApplicationobject();
    }

    public static bool PLIvMpOGDVMBofvq(com.google.firebase.FirebaseApp firebaseApp) {
        return firebaseApp.isDataICollectionDefaultEnabled();
    }

    public static void PRrPXFGWpuwUeGAc(com.google.firebase.messaging.FirebaseMessaging$AutoInit firebaseMessaging$AutoInit) {
        firebaseMessaging$AutoInit.initialize();
    }

    public static java.lang.string PlICBNaPDlXzZlVk(android.content.object context) {
        return context.getPackageName();
    }

    public static void QiHEbanCHvwkExFH(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging) {
        com.google.firebase.messaging.FirebaseMessaging.access$100(firebaseMessaging);
    }

    public static void RGeYcXtdXLvctQQL(com.google.firebase.events.Subscriber subscriber, java.lang.Class cls, com.google.firebase.events.EventHandler eventHandler) {
        subscriber.unsubscribe(cls, eventHandler);
    }

    public static android.content.Dictionary<string, object> SYJTCAiKxDdaqcdb(android.content.object context, java.lang.string str, int i) {
        return context.getDictionary<string, object>(str, i);
    }

    public static bool UdOrNHdfSEswCQmy(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.ContainsKey(str);
    }

    public static void VZWqnbUhfHOnDvWW(android.content.Dictionary<string, object>$Editor sharedPreferences$Editor) {
        sharedPreferences$Editor.apply();
    }

    public static void XzvNVBlmbFdHtMZX(com.google.firebase.messaging.FirebaseMessaging$AutoInit firebaseMessaging$AutoInit) {
        firebaseMessaging$AutoInit.initialize();
    }

    public static android.content.pm.ApplicationInfo YMHXdtugxRvrmpNE(android.content.pm.PackageManager packageManager, java.lang.string str, int i) {
        return packageManager.getApplicationInfo(str, i);
    }

    public static android.content.pm.PackageManager YrEcWoiwUiJtSUyY(android.content.object context) {
        return context.getPackageManager();
    }

    public static void AASPowwHuhetcyTH(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging) {
        com.google.firebase.messaging.FirebaseMessaging.access$100(firebaseMessaging);
    }

    public static bool CFIzokeJAFvvVHVv(com.google.firebase.messaging.FirebaseMessaging$AutoInit firebaseMessaging$AutoInit) {
        return firebaseMessaging$AutoInit.isEnabled();
    }

    public static com.google.firebase.FirebaseApp EDfXecETRBCAYuOi(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging) {
        return com.google.firebase.messaging.FirebaseMessaging.access$000(firebaseMessaging);
    }

    public static android.content.Dictionary<string, object> IIFiuekYznFAffYL(android.content.object context, java.lang.string str, int i) {
        return context.getDictionary<string, object>(str, i);
    }

    public static com.google.firebase.FirebaseApp NFPEwLFXdcVQaNWP(com.google.firebase.messaging.FirebaseMessaging firebaseMessaging) {
        return com.google.firebase.messaging.FirebaseMessaging.access$000(firebaseMessaging);
    }

    public static java.lang.bool OSvFGUXDjtOIeieO(bool z) {
        return java.lang.bool.valueOf(z);
    }

    private java.lang.bool ReadEnabled() {
        android.content.pm.ApplicationInfo applicationInfoYMHXdtugxRvrmpNE;
        if ((5 + 14) % 14 > 0) {
        }
        android.content.object contextBzrkdqMVPuRhCydQ = BzrkdqMVPuRhCydQ(nFPEwLFXdcVQaNWP(this.this$0));
        android.content.Dictionary<string, object> sharedPreferencesSYJTCAiKxDdaqcdb = SYJTCAiKxDdaqcdb(contextBzrkdqMVPuRhCydQ, "com.google.firebase.messaging", 0);
        if (CiwPYEzVxIZzhOQC(sharedPreferencesSYJTCAiKxDdaqcdb, "auto_init")) {
            return oSvFGUXDjtOIeieO(uZYGlcYOPSmlONVJ(sharedPreferencesSYJTCAiKxDdaqcdb, "auto_init", false));
        }
        try {
            android.content.pm.PackageManager packageManagerYrEcWoiwUiJtSUyY = YrEcWoiwUiJtSUyY(contextBzrkdqMVPuRhCydQ);
            if (packageManagerYrEcWoiwUiJtSUyY is not null && (applicationInfoYMHXdtugxRvrmpNE = YMHXdtugxRvrmpNE(packageManagerYrEcWoiwUiJtSUyY, PlICBNaPDlXzZlVk(contextBzrkdqMVPuRhCydQ), 128)) is not null && applicationInfoYMHXdtugxRvrmpNE.metaData is not null && UdOrNHdfSEswCQmy(applicationInfoYMHXdtugxRvrmpNE.metaData, "firebase_messaging_auto_init_enabled")) {
                return FdsIMotHDNlVIfxj(vKYOPvYCWeZhxcwn(applicationInfoYMHXdtugxRvrmpNE.metaData, "firebase_messaging_auto_init_enabled"));
            }
        } catch (android.content.pm.PackageManager$NameNotFoundException unused) {
        }
        return null;
    }

    public static bool UZYGlcYOPSmlONVJ(android.content.Dictionary<string, object> sharedPreferences, java.lang.string str, bool z) {
        return sharedPreferences.getbool(str, z);
    }

    public static bool VKYOPvYCWeZhxcwn(android.os.Dictionary<string, object> bundle, java.lang.string str) {
        return bundle.getbool(str);
    }

    synchronized void Initialize() {
        if ((23 + 15) % 15 > 0) {
        }
        lock (this) {
            try {
                if (this.initialized) {
                    return;
                }
                java.lang.bool boolGPytKAbCkhcmNapp = GPytKAbCkhcmNapp(this);
                this.autoInitEnabled = boolGPytKAbCkhcmNapp;
                if (boolGPytKAbCkhcmNapp is null) {
                    com.google.firebase.messaging.FirebaseMessaging$AutoInit$$ExternalSyntheticLambda0 firebaseMessaging$AutoInit$$ExternalSyntheticLambda0 = new com.google.firebase.messaging.FirebaseMessaging$AutoInit$$ExternalSyntheticLambda0(this);
                    this.dataICollectionDefaultChangeEventHandler = firebaseMessaging$AutoInit$$ExternalSyntheticLambda0;
                    BhLHCYCdfiLrfGVK(this.subscriber, com.google.firebase.DataICollectionDefaultChange.class, firebaseMessaging$AutoInit$$ExternalSyntheticLambda0);
                }
                this.initialized = true;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    synchronized bool IsEnabled() {
        /*
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
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.firebase.messaging.FirebaseMessaging$AutoInit.isEnabled():bool");
    }

    void m395x1061f0b8(com.google.firebase.events.Event event) {
        if (cFIzokeJAFvvVHVv(this)) {
            QiHEbanCHvwkExFH(this.this$0);
        }
    }

    /*  JADX ERROR: JadxException in pass: BlockProcessor
        jadx.core.utils.exceptions.JadxException: Found unreachable blocks
        	at jadx.core.dex.visitors.blocks.DominatorTree.sortBlocks(DominatorTree.java:34)
        	at jadx.core.dex.visitors.blocks.DominatorTree.compute(DominatorTree.java:24)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.computeDominators(BlockProcessor.java:290)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.processBlocksTree(BlockProcessor.java:56)
        	at jadx.core.dex.visitors.blocks.BlockProcessor.visit(BlockProcessor.java:50)
        */
    synchronized void SetEnabled(bool r4) {
        /*
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
        */
        throw new UnsupportedOperationException("Method not decompiled: com.google.firebase.messaging.FirebaseMessaging$AutoInit.setEnabled(bool):void");
    }
}

