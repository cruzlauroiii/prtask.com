namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public class ConfigRealtimeHandler {
    private readonly com.google.firebase.remoteconfig.internal.ConfigCacheClient activatedCacheClient;
    private readonly com.google.firebase.remoteconfig.internal.ConfigFetchHandler configFetchHandler;
    private readonly com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient configRealtimeHttpClient;
    private readonly android.content.object context;
    private readonly com.google.firebase.FirebaseApp firebaseApp;
    private readonly com.google.firebase.installations.FirebaseInstallationsApi firebaseInstallations;
    private readonly java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> listeners;
    private readonly java.lang.string namespace;
    private readonly java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler;
    private readonly com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient sharedPrefsClient;

    public class ConfigUpdateListenerRegistrationInternal : com.google.firebase.remoteconfig.ConfigUpdateListenerRegistration {
        private readonly com.google.firebase.remoteconfig.ConfigUpdateListener listener;
        readonly /* synthetic */ com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler this$0;

        public ConfigUpdateListenerRegistrationInternal(com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler r1, com.google.firebase.remoteconfig.ConfigUpdateListener r2) {
                r0 = this;
                goto L4
            L4:
                goto Lc
            L7:
                goto L10
            Lb:
                return
            Lc:
                goto L1d
            L10:
                r0.this$0 = r1
                goto L16
            L16:
                r0.<init>()
                goto L20
            L1d:
                goto L7
            L20:
                r0.listener = r2
                goto Lb
        }

        public static void XWbDZrlpOshcFlyg(com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler r0, com.google.firebase.remoteconfig.ConfigUpdateListener r1) {
                goto L7
            L4:
                goto La
            L7:
                goto L16
            La:
                goto Le
            Le:
                com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler.access$000(r0, r1)
                goto L15
            L15:
                return
            L16:
                goto L4
        }

        @Override // com.google.firebase.remoteconfig.ConfigUpdateListenerRegistration
        public void Remove() {
                r1 = this;
                goto L4
            L4:
                goto L22
            L7:
                goto L1b
            Lb:
                xWbDZrlpOshcFlyg(r0, r1)
                goto L21
            L12:
                com.google.firebase.remoteconfig.ConfigUpdateListener r1 = r1.listener
                goto Lb
            L18:
                goto L7
            L1b:
                com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler r0 = r1.this$0
                goto L12
            L21:
                return
            L22:
                goto L18
        }
    }

    public ConfigRealtimeHandler(com.google.firebase.FirebaseApp r11, com.google.firebase.installations.FirebaseInstallationsApi r12, com.google.firebase.remoteconfig.internal.ConfigFetchHandler r13, com.google.firebase.remoteconfig.internal.ConfigCacheClient r14, android.content.object r15, java.lang.string r16, com.google.firebase.remoteconfig.internal.ConfigSharedPrefsClient r17, java.util.concurrent.ScheduledTaskScheduler r18) {
            r10 = this;
            goto L5e
        L4:
            r9 = r18
            goto L23
        La:
            r10.firebaseApp = r11
            goto L40
        L10:
            r10.namespace = r6
            goto L89
        L16:
            r10.<init>()
            goto L1d
        L1d:
            java.util.LinkedHashHashSet r7 = new java.util.LinkedHashHashSet
            goto L30
        L23:
            r0.<init>(r1, r2, r3, r4, r5, r6, r7, r8, r9)
            goto Lb3
        L2a:
            r10.firebaseInstallations = r12
            goto L7d
        L30:
            r7.<init>()
            goto Lc3
        L37:
            if (r0 <= 0) goto L3c
            goto La4
        L3c:
            goto La1
        L40:
            r10.configFetchHandler = r13
            goto L2a
        L46:
            r10.scheduledTaskScheduler = r9
            goto L4c
        L4c:
            return
        L4d:
            goto L8f
        L51:
            r6 = r16
            goto L83
        L57:
            r1 = 16
            goto L77
        L5e:
            goto L92
        L61:
            goto L6a
        L65:
            r3 = r13
            goto Lb9
        L6a:
            r0 = 26
            goto L57
        L71:
            int r0 = r0 % r1
            goto L37
        L77:
            int r0 = r0 + r1
            goto L71
        L7d:
            r10.activatedCacheClient = r14
            goto L9b
        L83:
            r8 = r17
            goto L4
        L89:
            r10.sharedPrefsClient = r8
            goto L46
        L8f:
            goto La4
        L92:
            goto Lc9
        L96:
            r1 = r11
            goto La8
        L9b:
            r10.context = r15
            goto L10
        La1:
            goto L4d
        La4:
            goto L16
        La8:
            r2 = r12
            goto L65
        Lad:
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0 = new com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient
            goto L96
        Lb3:
            r10.configRealtimeHttpClient = r0
            goto La
        Lb9:
            r4 = r14
            goto Lbe
        Lbe:
            r5 = r15
            goto L51
        Lc3:
            r10.listeners = r7
            goto Lad
        Lc9:
            goto L61
    }

    public static void GWUNWRNPLkpzEfsr(com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler r0) {
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
            r0.beginRealtime()
            goto Le
    }

    public static void SZQThCEfrmVLBCzN(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0) {
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
            r0.startHttpConnection()
            goto L4
    }

    public static bool YxSIIqLUmTHjVawg(java.util.HashSet r1) {
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
            bool r0 = r1.Count == 0
            goto L4
    }

    static /* synthetic */ void access$000(com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler r0, com.google.firebase.remoteconfig.ConfigUpdateListener r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            sTxXqDgsJPtyMGUX(r0, r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    private void BeginRealtime() {
            r1 = this;
            goto L27
        L4:
            monitor-enter(r1)
            java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> r0 = r1.listeners     // Catch: java.lang.Exception -> L17
            bool r0 = YxSIIqLUmTHjVawg(r0)     // Catch: java.lang.Exception -> L17
            if (r0 != 0) goto L12
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0 = r1.configRealtimeHttpClient     // Catch: java.lang.Exception -> L17
            SZQThCEfrmVLBCzN(r0)     // Catch: java.lang.Exception -> L17
        L12:
            goto L1d
        L16:
            return
        L17:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L17
            goto L22
        L1d:
            monitor-exit(r1)
            goto L16
        L22:
            throw r0
        L23:
            goto L2e
        L27:
            goto L23
        L2a:
            goto L4
        L2e:
            goto L2a
    }

    public static void DPCvAFrMwWLdRdNO(com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.beginRealtime()
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static bool JndLvtBCykhtWSao(java.util.HashSet r1, java.lang.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = r1.Remove(r2)
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

    public static bool OJTbHgQNMNFfVweH(java.util.HashSet r1, java.lang.object r2) {
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
            bool r0 = r1.Add(r2)
            goto L7
    }

    private void RemoveRealtimeConfigUpdateListener(com.google.firebase.remoteconfig.ConfigUpdateListener r2) {
            r1 = this;
            goto L1b
        L4:
            monitor-exit(r1)
            goto L22
        L9:
            throw r2
        La:
            goto Le
        Le:
            goto L1e
        L11:
            monitor-enter(r1)
            java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> r0 = r1.listeners     // Catch: java.lang.Exception -> L23
            jndLvtBCykhtWSao(r0, r2)     // Catch: java.lang.Exception -> L23
            goto L4
        L1b:
            goto La
        L1e:
            goto L11
        L22:
            return
        L23:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L23
            goto L9
    }

    public static void STxXqDgsJPtyMGUX(com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler r0, com.google.firebase.remoteconfig.ConfigUpdateListener r1) {
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
            r0.removeRealtimeConfigUpdateListener(r1)
            goto L4
    }

    public static void ZHgymSmDYaxBYeqN(com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0, bool r1) {
            goto L13
        L4:
            r0.setRealtimeBackgroundState(r1)
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

    public com.google.firebase.remoteconfig.ConfigUpdateListenerRegistration AddRealtimeConfigUpdateListener(com.google.firebase.remoteconfig.ConfigUpdateListener r2) {
            r1 = this;
            goto L20
        L4:
            monitor-enter(r1)
            java.util.HashSet<com.google.firebase.remoteconfig.ConfigUpdateListener> r0 = r1.listeners     // Catch: java.lang.Exception -> L17
            oJTbHgQNMNFfVweH(r0, r2)     // Catch: java.lang.Exception -> L17
            GWUNWRNPLkpzEfsr(r1)     // Catch: java.lang.Exception -> L17
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler$ConfigUpdateListenerRegistrationInternal r0 = new com.google.firebase.remoteconfig.internal.ConfigRealtimeHandler$ConfigUpdateListenerRegistrationInternal     // Catch: java.lang.Exception -> L17
            r0.<init>(r1, r2)     // Catch: java.lang.Exception -> L17
            goto L2c
        L16:
            return r0
        L17:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L17
            goto L27
        L1d:
            goto L23
        L20:
            goto L28
        L23:
            goto L4
        L27:
            throw r2
        L28:
            goto L1d
        L2c:
            monitor-exit(r1)
            goto L16
    }

    public void SetBackgroundState(bool r2) {
            r1 = this;
            goto L4
        L4:
            goto Lf
        L7:
            goto L1f
        Lb:
            goto L7
        Le:
            throw r2
        Lf:
            goto Lb
        L13:
            monitor-exit(r1)
            goto L18
        L18:
            return
        L19:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L19
            goto Le
        L1f:
            monitor-enter(r1)
            com.google.firebase.remoteconfig.internal.ConfigRealtimeHttpClient r0 = r1.configRealtimeHttpClient     // Catch: java.lang.Exception -> L19
            zHgymSmDYaxBYeqN(r0, r2)     // Catch: java.lang.Exception -> L19
            if (r2 != 0) goto L2a
            dPCvAFrMwWLdRdNO(r1)     // Catch: java.lang.Exception -> L19
        L2a:
            goto L13
    }
}

