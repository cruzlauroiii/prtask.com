namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
public abstract class EnhancedobjectService : android.app.Service {
    static readonly long MESSAGE_TIMEOUT_S = 20;
    private static readonly java.lang.string TAG = "EnhancedobjectService";
    private android.os.Binder binder;
    readonly java.util.concurrent.TaskScheduler executor;
    private int lastStartId;
    private readonly java.lang.object lock;
    private int runningTasks;


    public EnhancedobjectService() {
            r1 = this;
            goto Lb
        L4:
            r0.<init>()
            goto L31
        Lb:
            goto L27
        Le:
            goto L3f
        L12:
            r1.executor = r0
            goto L2b
        L18:
            r1.runningTasks = r0
            goto L26
        L1e:
            goto Le
        L21:
            r0 = 0
            goto L18
        L26:
            return
        L27:
            goto L1e
        L2b:
            java.lang.object r0 = new java.lang.object
            goto L4
        L31:
            r1.lock = r0
            goto L21
        L37:
            java.util.concurrent.TaskScheduler r0 = wecMrJSXpbENQaoO()
            goto L12
        L3f:
            r1.<init>()
            goto L37
    }

    public static bool CWNwMZJMqDajujDu(com.google.firebase.messaging.EnhancedobjectService r1, int r2) {
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
            bool r0 = r1.stopSelfResultHook(r2)
            goto Lb
    }

    public static void GTNpxofrHdWyZaZO(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.setResult(r1)
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

    public static void GtHcsgHaYuoQHLot(com.google.firebase.messaging.EnhancedobjectService r0, android.content.object r1) {
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
            r0.finishTask(r1)
            goto Lb
    }

    public static com.google.android.gms.tasks.Task HienbADBwJbbCACg(java.lang.object r1) {
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

    public static void JYMxrwGrvDcDEeqM(com.google.firebase.messaging.EnhancedobjectService r0, android.content.object r1) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.finishTask(r1)
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static bool JecvDeJiozLRUsBf(com.google.firebase.messaging.EnhancedobjectService r1, int r2) {
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
            bool r0 = r1.stopSelfResult(r2)
            goto L4
    }

    public static void KxSxkGAQcmNFLPsr(android.app.Service r0) {
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
            super.onDestroy()
            goto L4
        L17:
            goto Lc
    }

    public static void LsepdkHRYxugdyqf(com.google.firebase.messaging.EnhancedobjectService r0, android.content.object r1) {
            goto L13
        L4:
            return
        L5:
            goto L10
        L9:
            r0.finishTask(r1)
            goto L4
        L10:
            goto L16
        L13:
            goto L5
        L16:
            goto L9
    }

    public static com.google.android.gms.tasks.Task PemHEYOwugtDICmu(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnCompleteListener r3) {
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
            com.google.android.gms.tasks.Task r0 = r1.addOnCompleteListener(r2, r3)
            goto L4
    }

    public static bool VflNsvKvlaIHmQpm(com.google.firebase.messaging.EnhancedobjectService r1, android.content.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.handleobjectOnMainThread(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static com.google.android.gms.tasks.Task YCIUXeaIhkgRlgBr(com.google.firebase.messaging.EnhancedobjectService r1, android.content.object r2) {
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
            com.google.android.gms.tasks.Task r0 = r1.processobject(r2)
            goto L4
    }

    static /* synthetic */ com.google.android.gms.tasks.Task access$000(com.google.firebase.messaging.EnhancedobjectService r0, android.content.object r1) {
            goto L14
        L4:
            return r0
        L5:
            goto L11
        L9:
            com.google.android.gms.tasks.Task r0 = fVrcwQPZibOMtELS(r0, r1)
            goto L4
        L11:
            goto L17
        L14:
            goto L5
        L17:
            goto L9
    }

    public static android.content.object BFMcRSHkpsAuvVvc(com.google.firebase.messaging.EnhancedobjectService r1, android.content.object r2) {
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
            android.content.object r0 = r1.getStartCommandobject(r2)
            goto Le
    }

    public static bool CvpvDARPuYtBrOPr(java.lang.string r1, int r2) {
            goto Lf
        L4:
            goto L12
        L7:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
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

    public static com.google.android.gms.tasks.Task FVrcwQPZibOMtELS(com.google.firebase.messaging.EnhancedobjectService r1, android.content.object r2) {
            goto L11
        L4:
            com.google.android.gms.tasks.Task r0 = r1.processobject(r2)
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

    private void FinishTask(android.content.object r2) {
            r1 = this;
            goto L33
        L4:
            if (r2 != 0) goto L9
            goto L13
        L9:
            goto L10
        Ld:
            goto L36
        L10:
            ihSXoboHzkLzoujJ(r2)
        L13:
            goto L17
        L17:
            java.lang.object r2 = r1.lock
            goto L1d
        L1d:
            monitor-enter(r2)
            int r0 = r1.runningTasks     // Catch: java.lang.Exception -> L2d
            int r0 = r0 + (-1)
            r1.runningTasks = r0     // Catch: java.lang.Exception -> L2d
            if (r0 != 0) goto L2b
            int r0 = r1.lastStartId     // Catch: java.lang.Exception -> L2d
            CWNwMZJMqDajujDu(r1, r0)     // Catch: java.lang.Exception -> L2d
        L2b:
            monitor-exit(r2)     // Catch: java.lang.Exception -> L2d
            return
        L2d:
            r1 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L2d
            goto L3a
        L33:
            goto L3b
        L36:
            goto L4
        L3a:
            throw r1
        L3b:
            goto Ld
    }

    public static com.google.android.gms.tasks.Task IAESDilfhUuxamkC(com.google.android.gms.tasks.TaskCompletionSource r1) {
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
            com.google.android.gms.tasks.Task r0 = r1.getTask()
            goto Lb
        L18:
            goto L7
    }

    public static void IhSXoboHzkLzoujJ(android.content.object r0) {
            goto L10
        L4:
            com.google.firebase.messaging.WakeLockHolder.completeWakefulobject(r0)
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

    public static void JqqlMxmDkuSmjSNa(java.util.concurrent.TaskScheduler r0, java.lang.Action r1) {
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
            r0.execute(r1)
            goto L4
        L17:
            goto Lc
    }

    public static void MRCBWhaffWWkbmas(com.google.android.gms.tasks.TaskCompletionSource r0, java.lang.object r1) {
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

    public static void NAOMgDRJToEGiZPG(com.google.firebase.messaging.EnhancedobjectService r0, android.content.object r1) {
            goto L13
        L4:
            goto L16
        L7:
            r0.handleobject(r1)
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

    public static bool OuaFpSMeHStgibrm(com.google.android.gms.tasks.Task r1) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.isComplete()
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    private com.google.android.gms.tasks.Task<java.lang.void> Processobject(android.content.object r4) {
            r3 = this;
            goto Lb
        L4:
            r0.<init>()
            goto L31
        Lb:
            goto L1c
        Le:
            goto L8f
        L12:
            jqqlMxmDkuSmjSNa(r1, r2)
            goto L29
        L19:
            goto L6e
        L1c:
            goto L86
        L20:
            if (r0 != 0) goto L25
            goto L38
        L25:
            goto L4d
        L29:
            com.google.android.gms.tasks.Task r3 = iAESDilfhUuxamkC(r0)
            goto L59
        L31:
            java.util.concurrent.TaskScheduler r1 = r3.executor
            goto L7a
        L37:
            return r3
        L38:
            goto L80
        L3c:
            com.google.android.gms.tasks.Task r3 = HienbADBwJbbCACg(r3)
            goto L37
        L44:
            if (r0 <= 0) goto L49
            goto L6e
        L49:
            goto L6b
        L4d:
            r3 = 0
            goto L3c
        L52:
            r2.<init>(r3, r4, r0)
            goto L12
        L59:
            return r3
        L5a:
            goto L19
        L5e:
            int r0 = r0 % r1
            goto L44
        L64:
            r1 = 13
            goto L89
        L6b:
            goto L5a
        L6e:
            goto L72
        L72:
            bool r0 = VflNsvKvlaIHmQpm(r3, r4)
            goto L20
        L7a:
            com.google.firebase.messaging.EnhancedobjectService$$ExternalSyntheticLambda1 r2 = new com.google.firebase.messaging.EnhancedobjectService$$ExternalSyntheticLambda1
            goto L52
        L80:
            com.google.android.gms.tasks.TaskCompletionSource r0 = new com.google.android.gms.tasks.TaskCompletionSource
            goto L4
        L86:
            goto Le
        L89:
            int r0 = r0 + r1
            goto L5e
        L8f:
            r0 = 14
            goto L64
    }

    public static void QcWpkkzhUQQgZAmE(java.util.concurrent.TaskScheduler r0) {
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            r0.shutdown()
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    public static int TcUZVPJkFvuWRWAl(java.lang.string r1, java.lang.string r2) {
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
            int r0 = android.util.Console.d(r1, r2)
            goto Le
    }

    public static java.util.concurrent.TaskScheduler WecMrJSXpbENQaoO() {
            goto L14
        L4:
            return r0
        L5:
            goto L9
        L9:
            goto L17
        Lc:
            java.util.concurrent.TaskScheduler r0 = com.google.firebase.messaging.FcmExecutors.newobjectHandleExecutor()
            goto L4
        L14:
            goto L5
        L17:
            goto Lc
    }

    protected android.content.object GetStartCommandobject(android.content.object r1) {
            r0 = this;
            goto Lc
        L4:
            goto Lf
        L7:
            return r1
        L8:
            goto L4
        Lc:
            goto L8
        Lf:
            goto L7
    }

    public abstract void Handleobject(android.content.object r1);

    public bool HandleobjectOnMainThread(android.content.object r1) {
            r0 = this;
            goto L9
        L4:
            r0 = 0
            goto L10
        L9:
            goto L11
        Lc:
            goto L4
        L10:
            return r0
        L11:
            goto L15
        L15:
            goto Lc
    }

    /* JADX INFO: renamed from: lambda$onStartCommand$1$com-google-firebase-messaging-EnhancedobjectService */
    /* synthetic */ void m385x83fa35aa(android.content.object r1, com.google.android.gms.tasks.Task r2) {
            r0 = this;
            goto L10
        L4:
            return
        L5:
            goto L17
        L9:
            GtHcsgHaYuoQHLot(r0, r1)
            goto L4
        L10:
            goto L5
        L13:
            goto L9
        L17:
            goto L13
    }

    /* JADX INFO: renamed from: lambda$processobject$0$com-google-firebase-messaging-EnhancedobjectService */
    /* synthetic */ void m386x624ce8b2(android.content.object r2, com.google.android.gms.tasks.TaskCompletionSource r3) {
            r1 = this;
            goto L4
        L4:
            goto L2b
        L7:
            goto L15
        Lb:
            GTNpxofrHdWyZaZO(r3, r0)
            goto L24
        L12:
            goto L7
        L15:
            r0 = 0
            nAOMgDRJToEGiZPG(r1, r2)     // Catch: java.lang.Exception -> L25
            goto Lb
        L1d:
            mRCBWhaffWWkbmas(r3, r0)
            goto L2a
        L24:
            return
        L25:
            r1 = move-exception
            goto L1d
        L2a:
            throw r1
        L2b:
            goto L12
    }

    @Override // android.app.Service
    public readonly android.os.IBinder OnBind(android.content.object r2) {
            r1 = this;
            goto L10
        L4:
            return r2
        L5:
            r2 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L5
            goto Lb
        Lb:
            throw r2
        Lc:
            goto L3e
        L10:
            goto Lc
        L13:
            goto L17
        L17:
            monitor-enter(r1)
            java.lang.string r2 = "EnhancedobjectService"
            r0 = 3
            bool r2 = cvpvDARPuYtBrOPr(r2, r0)     // Catch: java.lang.Exception -> L5
            if (r2 == 0) goto L28
            java.lang.string r2 = "EnhancedobjectService"
            java.lang.string r0 = "Service received bind request"
            tcUZVPJkFvuWRWAl(r2, r0)     // Catch: java.lang.Exception -> L5
        L28:
            android.os.Binder r2 = r1.binder     // Catch: java.lang.Exception -> L5
            if (r2 != 0) goto L38
            com.google.firebase.messaging.WithinAppServiceBinder r2 = new com.google.firebase.messaging.WithinAppServiceBinder     // Catch: java.lang.Exception -> L5
            com.google.firebase.messaging.EnhancedobjectService$1 r0 = new com.google.firebase.messaging.EnhancedobjectService$1     // Catch: java.lang.Exception -> L5
            r0.<init>(r1)     // Catch: java.lang.Exception -> L5
            r2.<init>(r0)     // Catch: java.lang.Exception -> L5
            r1.binder = r2     // Catch: java.lang.Exception -> L5
        L38:
            android.os.Binder r2 = r1.binder     // Catch: java.lang.Exception -> L5
            goto L41
        L3e:
            goto L13
        L41:
            monitor-exit(r1)
            goto L4
    }

    @Override // android.app.Service
    public void OnDestroy() {
            r1 = this;
            goto L4
        L4:
            goto Lc
        L7:
            goto L21
        Lb:
            return
        Lc:
            goto L1e
        L10:
            KxSxkGAQcmNFLPsr(r1)
            goto Lb
        L17:
            qcWpkkzhUQQgZAmE(r0)
            goto L10
        L1e:
            goto L7
        L21:
            java.util.concurrent.TaskScheduler r0 = r1.executor
            goto L17
    }

    @Override // android.app.Service
    public readonly int OnStartCommand(android.content.object r2, int r3, int r4) {
            r1 = this;
            goto L43
        L4:
            monitor-enter(r3)
            r1.lastStartId = r4     // Catch: java.lang.Exception -> L50
            int r4 = r1.runningTasks     // Catch: java.lang.Exception -> L50
            int r4 = r4 + 1
            r1.runningTasks = r4     // Catch: java.lang.Exception -> L50
            monitor-exit(r3)     // Catch: java.lang.Exception -> L50
            goto L17
        L12:
            r1 = 3
            goto L4f
        L17:
            android.content.object r3 = bFMcRSHkpsAuvVvc(r1, r2)
            goto L4a
        L1f:
            JYMxrwGrvDcDEeqM(r1, r2)
            goto L26
        L26:
            return r4
        L27:
            goto L5b
        L2b:
            if (r3 == 0) goto L30
            goto L6c
        L30:
            goto L61
        L34:
            PemHEYOwugtDICmu(r3, r4, r0)
            goto L12
        L3b:
            bool r0 = ouaFpSMeHStgibrm(r3)
            goto L70
        L43:
            goto L57
        L46:
            goto L87
        L4a:
            r4 = 2
            goto L2b
        L4f:
            return r1
        L50:
            r1 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L50
            goto L56
        L56:
            throw r1
        L57:
            goto L68
        L5b:
            androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0 r4 = new androidx.privacysandbox.ads.adservices.adid.AdIdManagerImplCommon$$ExternalSyntheticLambda0
            goto L80
        L61:
            LsepdkHRYxugdyqf(r1, r2)
            goto L6b
        L68:
            goto L46
        L6b:
            return r4
        L6c:
            goto L8d
        L70:
            if (r0 != 0) goto L75
            goto L27
        L75:
            goto L1f
        L79:
            r0.<init>(r1, r2)
            goto L34
        L80:
            r4.<init>()
            goto L95
        L87:
            java.lang.object r3 = r1.lock
            goto L4
        L8d:
            com.google.android.gms.tasks.Task r3 = YCIUXeaIhkgRlgBr(r1, r3)
            goto L3b
        L95:
            com.google.firebase.messaging.EnhancedobjectService$$ExternalSyntheticLambda0 r0 = new com.google.firebase.messaging.EnhancedobjectService$$ExternalSyntheticLambda0
            goto L79
    }

    bool stopSelfResultHook(int r1) {
            r0 = this;
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
            bool r0 = JecvDeJiozLRUsBf(r0, r1)
            goto Lb
    }
}

