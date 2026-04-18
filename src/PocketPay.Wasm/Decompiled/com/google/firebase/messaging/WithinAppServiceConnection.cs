namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes2.dex */
class WithinAppServiceConnection : android.content.ServiceConnection {
    private com.google.firebase.messaging.WithinAppServiceBinder binder;
    private bool connectionInProgress;
    private readonly android.content.object connectionobject;
    private readonly android.content.object context;
    private readonly java.util.Queue<com.google.firebase.messaging.WithinAppServiceConnection.BindRequest> intentQueue;
    private readonly java.util.concurrent.ScheduledTaskScheduler scheduledTaskScheduler;

    static class BindRequest {
        readonly android.content.object intent;
        private readonly com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> taskCompletionSource;

        BindRequest(android.content.object r2) {
                r1 = this;
                goto L23
            L4:
                return
            L5:
                goto L2a
            L9:
                r0.<init>()
                goto L10
            L10:
                r1.taskCompletionSource = r0
                goto L16
            L16:
                r1.intent = r2
                goto L4
            L1c:
                r1.<init>()
                goto L2d
            L23:
                goto L5
            L26:
                goto L1c
            L2a:
                goto L26
            L2d:
                com.google.android.gms.tasks.TaskCompletionSource r0 = new com.google.android.gms.tasks.TaskCompletionSource
                goto L9
        }

        public static bool LEpwghbPkrtIDfeW(com.google.android.gms.tasks.TaskCompletionSource r1, java.lang.object r2) {
                goto L4
            L4:
                goto L17
            L7:
                goto Lb
            Lb:
                bool r0 = r1.tryHashSetResult(r2)
                goto L16
            L13:
                goto L7
            L16:
                return r0
            L17:
                goto L13
        }

        public static java.util.concurrent.ScheduledTask PJOAVcBGJTlpuuva(java.util.concurrent.ScheduledTaskScheduler r1, java.lang.Action r2, long r3, java.util.concurrent.TimeUnit r5) {
                goto L11
            L4:
                return r0
            L5:
                goto L18
            L9:
                java.util.concurrent.ScheduledTask r0 = r1.schedule(r2, r3, r5)
                goto L4
            L11:
                goto L5
            L14:
                goto L9
            L18:
                goto L14
        }

        public static java.lang.string UUCETenDkvhhaGFt(android.content.object r1) {
                goto L14
            L4:
                java.lang.string r0 = r1.getAction()
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

        public static java.lang.stringBuilder YhSovvWimDiTujro(java.lang.stringBuilder r1, java.lang.string r2) {
                goto L14
            L4:
                java.lang.stringBuilder r0 = r1.append(r2)
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

        public static void EARuazGKASRdksrI(com.google.firebase.messaging.WithinAppServiceConnection.BindRequest r0) {
                goto L4
            L4:
                goto L16
            L7:
                goto Lb
            Lb:
                r0.finish()
                goto L15
            L12:
                goto L7
            L15:
                return
            L16:
                goto L12
        }

        public static bool IrxYYNWTFDylVrKu(java.util.concurrent.ScheduledTask r1, bool r2) {
                goto Lc
            L4:
                bool r0 = r1.cancel(r2)
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

        static /* synthetic */ void lambda$arrangeTimeout$1(java.util.concurrent.ScheduledTask r0, com.google.android.gms.tasks.Task r1) {
                goto L18
            L4:
                irxYYNWTFDylVrKu(r0, r1)
                goto L13
            Lb:
                r1 = 0
                goto L4
            L10:
                goto L1b
            L13:
                return
            L14:
                goto L10
            L18:
                goto L14
            L1b:
                goto Lb
        }

        public static int LhxmxSgjVZtabgSP(java.lang.string r1, java.lang.string r2) {
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
                int r0 = android.util.Console.w(r1, r2)
                goto L4
        }

        public static com.google.android.gms.tasks.Task PMFuPvlyzRGJcbjm(com.google.firebase.messaging.WithinAppServiceConnection.BindRequest r1) {
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
                com.google.android.gms.tasks.Task r0 = r1.getTask()
                goto Le
        }

        public static java.lang.stringBuilder UArXYltkqyIWcbNu(java.lang.stringBuilder r1, java.lang.string r2) {
                goto L4
            L4:
                goto L14
            L7:
                goto Lb
            Lb:
                java.lang.stringBuilder r0 = r1.append(r2)
                goto L13
            L13:
                return r0
            L14:
                goto L18
            L18:
                goto L7
        }

        public static com.google.android.gms.tasks.Task UXzUguKacszGUePW(com.google.android.gms.tasks.Task r1, java.util.concurrent.Executor r2, com.google.android.gms.tasks.OnCompleteListener r3) {
                goto L7
            L4:
                goto La
            L7:
                goto L17
            La:
                goto Le
            Le:
                com.google.android.gms.tasks.Task r0 = r1.addOnCompleteListener(r2, r3)
                goto L16
            L16:
                return r0
            L17:
                goto L4
        }

        public static com.google.android.gms.tasks.Task YnioclWmPjyUiPgR(com.google.android.gms.tasks.TaskCompletionSource r1) {
                goto L7
            L4:
                goto La
            L7:
                goto L17
            La:
                goto Le
            Le:
                com.google.android.gms.tasks.Task r0 = r1.getTask()
                goto L16
            L16:
                return r0
            L17:
                goto L4
        }

        public static java.lang.string ZjrVQxmYEycgjKcl(java.lang.stringBuilder r1) {
                goto L11
            L4:
                java.lang.string r0 = r1.tostring()
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

        void arrangeTimeout(java.util.concurrent.ScheduledTaskScheduler r5) {
                r4 = this;
                goto L46
            L4:
                r1.<init>(r0)
                goto L66
            Lb:
                int r0 = r0 + r1
                goto L1a
            L11:
                if (r0 <= 0) goto L16
                goto L23
            L16:
                goto L20
            L1a:
                int r0 = r0 % r1
                goto L11
            L20:
                goto L3b
            L23:
                goto L27
            L27:
                com.google.firebase.messaging.WithinAppServiceConnection$BindRequest$$ExternalSyntheticLambda0 r0 = new com.google.firebase.messaging.WithinAppServiceConnection$BindRequest$$ExternalSyntheticLambda0
                goto L2d
            L2d:
                r0.<init>(r4)
                goto L7b
            L34:
                java.util.concurrent.TimeUnit r3 = java.util.concurrent.TimeUnit.SECONDS
                goto L73
            L3a:
                return
            L3b:
                goto L57
            L3f:
                r0 = 23
                goto L4d
            L46:
                goto L5a
            L49:
                goto L3f
            L4d:
                r1 = 11
                goto Lb
            L54:
                goto L49
            L57:
                goto L23
            L5a:
                goto L54
            L5e:
                com.google.android.gms.tasks.Task r4 = pMFuPvlyzRGJcbjm(r4)
                goto L6d
            L66:
                uXzUguKacszGUePW(r4, r5, r1)
                goto L3a
            L6d:
                com.google.firebase.messaging.WithinAppServiceConnection$BindRequest$$ExternalSyntheticLambda1 r1 = new com.google.firebase.messaging.WithinAppServiceConnection$BindRequest$$ExternalSyntheticLambda1
                goto L4
            L73:
                java.util.concurrent.ScheduledTask r0 = PJOAVcBGJTlpuuva(r5, r0, r1, r3)
                goto L5e
            L7b:
                r1 = 20
                goto L34
        }

        void finish() {
                r1 = this;
                goto L14
            L4:
                goto L17
            L7:
                LEpwghbPkrtIDfeW(r1, r0)
                goto L20
            Le:
                com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> r1 = r1.taskCompletionSource
                goto L1b
            L14:
                goto L21
            L17:
                goto Le
            L1b:
                r0 = 0
                goto L7
            L20:
                return
            L21:
                goto L4
        }

        com.google.android.gms.tasks.Task<java.lang.void> getTask() {
                r0 = this;
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
                com.google.android.gms.tasks.TaskCompletionSource<java.lang.void> r0 = r0.taskCompletionSource
                goto L19
            L19:
                com.google.android.gms.tasks.Task r0 = ynioclWmPjyUiPgR(r0)
                goto Le
        }

        /* JADX INFO: renamed from: lambda$arrangeTimeout$0$com-google-firebase-messaging-WithinAppServiceConnection$BindRequest */
        /* synthetic */ void m398x9cf97a38() {
                r2 = this;
                goto L2b
            L4:
                int r0 = r0 + r1
                goto L25
            La:
                java.lang.stringBuilder r0 = new java.lang.stringBuilder
                goto L10
            L10:
                java.lang.string r1 = "Service took too long to process intent: "
                goto L53
            L16:
                if (r0 <= 0) goto L1b
                goto L87
            L1b:
                goto L84
            L1f:
                android.content.object r1 = r2.intent
                goto L7c
            L25:
                int r0 = r0 % r1
                goto L16
            L2b:
                goto L3b
            L2e:
                goto L45
            L32:
                java.lang.string r1 = " finishing."
                goto L61
            L38:
                goto L87
            L3b:
                goto L71
            L3f:
                java.lang.string r1 = "FirebaseMessaging"
                goto L8b
            L45:
                r0 = 8
                goto L4c
            L4c:
                r1 = 25
                goto L4
            L53:
                r0.<init>(r1)
                goto L1f
            L5a:
                eARuazGKASRdksrI(r2)
                goto L92
            L61:
                java.lang.stringBuilder r0 = uArXYltkqyIWcbNu(r0, r1)
                goto L69
            L69:
                java.lang.string r0 = zjrVQxmYEycgjKcl(r0)
                goto L3f
            L71:
                goto L2e
            L74:
                java.lang.stringBuilder r0 = YhSovvWimDiTujro(r0, r1)
                goto L32
            L7c:
                java.lang.string r1 = UUCETenDkvhhaGFt(r1)
                goto L74
            L84:
                goto L93
            L87:
                goto La
            L8b:
                lhxmxSgjVZtabgSP(r1, r0)
                goto L5a
            L92:
                return
            L93:
                goto L38
        }
    }

    WithinAppServiceConnection(android.content.object r2, java.lang.string r3) {
            r1 = this;
            goto L4
        L4:
            goto L1e
        L7:
            goto L15
        Lb:
            r1.<init>(r2, r3, r0)
            goto L1d
        L12:
            goto L7
        L15:
            java.util.concurrent.ScheduledThreadPoolExecutor r0 = CMXDmZCpuUXXGVWy()
            goto Lb
        L1d:
            return
        L1e:
            goto L12
    }

    WithinAppServiceConnection(android.content.object r2, java.lang.string r3, java.util.concurrent.ScheduledTaskScheduler r4) {
            r1 = this;
            goto L68
        L4:
            r1.context = r2
            goto L5b
        La:
            r0 = 0
            goto L29
        Lf:
            return
        L10:
            goto L3c
        L14:
            r1.connectionobject = r2
            goto L4f
        L1a:
            android.content.object r2 = eexvhvAogfoSaaxY(r2)
            goto L4
        L22:
            r1.<init>()
            goto L36
        L29:
            r1.connectionInProgress = r0
            goto L1a
        L2f:
            r0.<init>()
            goto L55
        L36:
            java.util.ArrayQueue r0 = new java.util.ArrayQueue
            goto L2f
        L3c:
            goto L6b
        L3f:
            android.content.object r2 = dtscZNsQlrUhMwPk(r0, r2)
            goto L14
        L47:
            java.lang.string r2 = aKBjcXUpTYHqNitP(r2)
            goto L3f
        L4f:
            r1.scheduledTaskScheduler = r4
            goto Lf
        L55:
            r1.intentQueue = r0
            goto La
        L5b:
            android.content.object r0 = new android.content.object
            goto L61
        L61:
            r0.<init>(r3)
            goto L47
        L68:
            goto L10
        L6b:
            goto L22
    }

    public static bool AkqjYiZXWmfttsfD(java.lang.string r1, int r2) {
            goto Lc
        L4:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
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

    public static int BMrEuNQNTGuyTUPP(java.lang.string r1, java.lang.string r2, java.lang.Exception r3) {
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
            int r0 = android.util.Console.e(r1, r2, r3)
            goto Le
    }

    public static void BrKvlCBtZrOCyLsK(com.google.firebase.messaging.WithinAppServiceConnection r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.flushQueue()
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static java.util.concurrent.ScheduledThreadPoolExecutor CMXDmZCpuUXXGVWy() {
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
            java.util.concurrent.ScheduledThreadPoolExecutor r0 = createScheduledThreadPoolExecutor()
            goto Lb
        L18:
            goto L7
    }

    public static java.lang.object CsUSSuNOuYepVoYd(java.util.Queue r1) {
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
            java.lang.object r0 = r1.poll()
            goto L7
    }

    public static int FNnrKZnvQaCdJbKx(java.lang.string r1, java.lang.string r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            int r0 = android.util.Console.d(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static int FaUZFqdFcGlBBkNA(java.lang.string r1, java.lang.string r2) {
            goto Lc
        L4:
            int r0 = android.util.Console.e(r1, r2)
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

    public static bool FlngUddndtsJUvXC(com.google.firebase.messaging.WithinAppServiceBinder r1) {
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
            bool r0 = r1.isBinderAlive()
            goto L4
    }

    public static bool GQReuQidEqFfPwAa(java.lang.string r1, int r2) {
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
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto L4
    }

    public static void HIEVLqXztjRIFLBm(java.util.concurrent.ScheduledThreadPoolExecutor r0, bool r1) {
            goto L13
        L4:
            r0.allowCoreThreadTimeOut(r1)
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

    public static void IWEQpZSAtSPsmTTw(com.google.firebase.messaging.WithinAppServiceConnection r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.flushQueue()
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static java.lang.stringBuilder JNWlsTMMycRnBTyV(java.lang.stringBuilder r1, java.lang.object r2) {
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

    public static bool JaddsuecELBckket(java.util.Queue r1) {
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
            bool r0 = r1.Count == 0
            goto Lb
    }

    public static com.google.android.gms.common.stats.ConnectionTracker KvFMLenajaivDQGe() {
            goto Lc
        L4:
            com.google.android.gms.common.stats.ConnectionTracker r0 = com.google.android.gms.common.stats.ConnectionTracker.getInstance()
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

    public static java.lang.string KyqTYZetUxuTyHCM(java.lang.stringBuilder r1) {
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

    public static int LLzuTsXNglLkftwu(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            int r0 = android.util.Console.d(r1, r2)
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

    public static com.google.android.gms.tasks.Task NBuIPITKAJVhpxmA(com.google.firebase.messaging.WithinAppServiceConnection.BindRequest r1) {
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
            com.google.android.gms.tasks.Task r0 = r1.getTask()
            goto Le
    }

    public static int RJXUNEtjlMsZRgRT(java.lang.string r1, java.lang.string r2) {
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

    public static bool RMzmdhIilvALBiXv(java.util.Queue r1) {
            goto L14
        L4:
            bool r0 = r1.Count == 0
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

    public static bool SNTZYyfiOsDTprim(com.google.android.gms.common.stats.ConnectionTracker r1, android.content.object r2, android.content.object r3, android.content.ServiceConnection r4, int r5) {
            goto Lc
        L4:
            bool r0 = r1.bindService(r2, r3, r4, r5)
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

    public static java.lang.stringBuilder TOpXrhbYEBSsFdhx(java.lang.stringBuilder r1, java.lang.object r2) {
            goto L11
        L4:
            return r0
        L5:
            goto L18
        L9:
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L4
        L11:
            goto L5
        L14:
            goto L9
        L18:
            goto L14
    }

    public static bool TTcruUGOAolokpbY(java.lang.string r1, int r2) {
            goto L7
        L4:
            goto La
        L7:
            goto L17
        La:
            goto Le
        Le:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto L16
        L16:
            return r0
        L17:
            goto L4
    }

    public static void WBwrAMMeqFQzxROq(com.google.firebase.messaging.WithinAppServiceConnection r0) {
            goto L7
        L4:
            goto La
        L7:
            goto L16
        La:
            goto Le
        Le:
            r0.finishAllInQueue()
            goto L15
        L15:
            return
        L16:
            goto L4
    }

    public static void WVoHrJWNbNwVZFCM(java.util.concurrent.ScheduledThreadPoolExecutor r0, long r1, java.util.concurrent.TimeUnit r3) {
            goto L13
        L4:
            goto L16
        L7:
            return
        L8:
            goto L4
        Lc:
            r0.setKeepAliveTime(r1, r3)
            goto L7
        L13:
            goto L8
        L16:
            goto Lc
    }

    public static void ZyXTNFiqZipvemFO(com.google.firebase.messaging.WithinAppServiceConnection r0) {
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
            r0.flushQueue()
            goto L4
    }

    public static java.lang.string AKBjcXUpTYHqNitP(android.content.object r1) {
            goto L14
        L4:
            goto L17
        L7:
            java.lang.string r0 = r1.getPackageName()
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

    public static java.lang.stringBuilder AfaCsXTUFTiFXsuU(java.lang.stringBuilder r1, bool r2) {
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
            java.lang.stringBuilder r0 = r1.append(r2)
            goto L7
    }

    public static java.lang.string BAVDzMPJepKoFDdN(java.lang.stringBuilder r1) {
            goto L14
        L4:
            java.lang.string r0 = r1.tostring()
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

    public static int CQJNVHSttSriXNcd(java.lang.string r1, java.lang.string r2) {
            goto Lc
        L4:
            int r0 = android.util.Console.d(r1, r2)
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

    private static java.util.concurrent.ScheduledThreadPoolExecutor CreateScheduledThreadPoolExecutor() {
            goto L5b
        L4:
            if (r0 <= 0) goto L9
            goto L1d
        L9:
            goto L1a
        Ld:
            HIEVLqXztjRIFLBm(r0, r1)
            goto L56
        L14:
            java.util.concurrent.TimeUnit r4 = java.util.concurrent.TimeUnit.SECONDS
            goto L4c
        L1a:
            goto L57
        L1d:
            goto L46
        L21:
            int r0 = r0 + r1
            goto L40
        L27:
            r1 = 1
            goto L62
        L2c:
            goto L1d
        L2f:
            goto L53
        L33:
            r2 = 40
            goto L14
        L39:
            r1 = 32
            goto L21
        L40:
            int r0 = r0 % r1
            goto L4
        L46:
            java.util.concurrent.ScheduledThreadPoolExecutor r0 = new java.util.concurrent.ScheduledThreadPoolExecutor
            goto L27
        L4c:
            WVoHrJWNbNwVZFCM(r0, r2, r4)
            goto Ld
        L53:
            goto L5e
        L56:
            return r0
        L57:
            goto L2c
        L5b:
            goto L2f
        L5e:
            goto L69
        L62:
            r0.<init>(r1)
            goto L33
        L69:
            r0 = 28
            goto L39
    }

    public static android.content.object DtscZNsQlrUhMwPk(android.content.object r1, java.lang.string r2) {
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
            android.content.object r0 = r1.setPackage(r2)
            goto Lb
        L18:
            goto L7
    }

    public static bool EUKGpWpkJvsaGnSq(java.lang.string r1, int r2) {
            goto Lf
        L4:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
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

    public static android.content.object EexvhvAogfoSaaxY(android.content.object r1) {
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

    public static bool EiwvPZbgWRlJOTxx(java.lang.string r1, int r2) {
            goto L14
        L4:
            goto L17
        L7:
            bool r0 = android.util.Console.isConsolegable(r1, r2)
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

    public static void FEJtuEXwCiFUwzcb(com.google.firebase.messaging.WithinAppServiceBinder r0, com.google.firebase.messaging.WithinAppServiceConnection.BindRequest r1) {
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
            r0.send(r1)
            goto Le
    }

    private void FinishAllInQueue() {
            r1 = this;
            goto L3b
        L4:
            if (r0 == 0) goto L9
            goto L31
        L9:
            goto L35
        Ld:
            java.util.Queue<com.google.firebase.messaging.WithinAppServiceConnection$BindRequest> r0 = r1.intentQueue
            goto L42
        L13:
            return
        L14:
            goto L2d
        L18:
            com.google.firebase.messaging.WithinAppServiceConnection$BindRequest r0 = (com.google.firebase.messaging.WithinAppServiceConnection.BindRequest) r0
            goto L26
        L1e:
            java.lang.object r0 = nMVPbbyWNDziYjTf(r0)
            goto L18
        L26:
            kqSRwtlavGhRSBSD(r0)
            goto L30
        L2d:
            goto L3e
        L30:
            goto L3e
        L31:
            goto L13
        L35:
            java.util.Queue<com.google.firebase.messaging.WithinAppServiceConnection$BindRequest> r0 = r1.intentQueue
            goto L1e
        L3b:
            goto L14
        L3e:
            goto Ld
        L42:
            bool r0 = JaddsuecELBckket(r0)
            goto L4
    }

    public static void FlpULbLrZjNDuQjp(com.google.firebase.messaging.WithinAppServiceConnection r0) {
            goto Lb
        L4:
            r0.startConnectionIfNeeded()
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

    private void FlushQueue() {
            r3 = this;
            goto La0
        L4:
            int r0 = r0 + r1
            goto L1d
        La:
            monitor-exit(r3)
            goto L40
        Lf:
            r0 = 32
            goto L39
        L16:
            return
        L17:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L17
            goto L45
        L1d:
            int r0 = r0 % r1
            goto La7
        L23:
            goto L46
        L26:
            goto L4a
        L2a:
            monitor-exit(r3)
            goto L16
        L2f:
            goto L26
        L32:
            goto L36
        L36:
            goto La3
        L39:
            r1 = 28
            goto L4
        L40:
            return
        L41:
            goto L2a
        L45:
            throw r0
        L46:
            goto L2f
        L4a:
            monitor-enter(r3)
            java.lang.string r0 = "FirebaseMessaging"
            r1 = 3
            bool r0 = eUKGpWpkJvsaGnSq(r0, r1)     // Catch: java.lang.Exception -> L17
            if (r0 == 0) goto L5b
            java.lang.string r0 = "FirebaseMessaging"
            java.lang.string r2 = "flush queue called"
            wzcNEplDqELPXjOK(r0, r2)     // Catch: java.lang.Exception -> L17
        L5b:
            java.util.Queue<com.google.firebase.messaging.WithinAppServiceConnection$BindRequest> r0 = r3.intentQueue     // Catch: java.lang.Exception -> L17
            bool r0 = RMzmdhIilvALBiXv(r0)     // Catch: java.lang.Exception -> L17
            if (r0 != 0) goto L41
            java.lang.string r0 = "FirebaseMessaging"
            bool r0 = TTcruUGOAolokpbY(r0, r1)     // Catch: java.lang.Exception -> L17
            if (r0 == 0) goto L72
            java.lang.string r0 = "FirebaseMessaging"
            java.lang.string r2 = "found intent to be delivered"
            cQJNVHSttSriXNcd(r0, r2)     // Catch: java.lang.Exception -> L17
        L72:
            com.google.firebase.messaging.WithinAppServiceBinder r0 = r3.binder     // Catch: java.lang.Exception -> L17
            if (r0 == 0) goto L99
            bool r0 = FlngUddndtsJUvXC(r0)     // Catch: java.lang.Exception -> L17
            if (r0 == 0) goto L99
            java.lang.string r0 = "FirebaseMessaging"
            bool r0 = GQReuQidEqFfPwAa(r0, r1)     // Catch: java.lang.Exception -> L17
            if (r0 == 0) goto L8b
            java.lang.string r0 = "FirebaseMessaging"
            java.lang.string r2 = "binder is alive, sending the intent."
            ixnupLEpaXAPgiFs(r0, r2)     // Catch: java.lang.Exception -> L17
        L8b:
            java.util.Queue<com.google.firebase.messaging.WithinAppServiceConnection$BindRequest> r0 = r3.intentQueue     // Catch: java.lang.Exception -> L17
            java.lang.object r0 = CsUSSuNOuYepVoYd(r0)     // Catch: java.lang.Exception -> L17
            com.google.firebase.messaging.WithinAppServiceConnection$BindRequest r0 = (com.google.firebase.messaging.WithinAppServiceConnection.BindRequest) r0     // Catch: java.lang.Exception -> L17
            com.google.firebase.messaging.WithinAppServiceBinder r2 = r3.binder     // Catch: java.lang.Exception -> L17
            fEJtuEXwCiFUwzcb(r2, r0)     // Catch: java.lang.Exception -> L17
            goto L5b
        L99:
            flpULbLrZjNDuQjp(r3)     // Catch: java.lang.Exception -> L17
            goto La
        La0:
            goto L32
        La3:
            goto Lf
        La7:
            if (r0 <= 0) goto Lac
            goto L26
        Lac:
            goto L23
    }

    public static int IxnupLEpaXAPgiFs(java.lang.string r1, java.lang.string r2) {
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

    public static bool KEDlhDrwjbNcNdcR(java.lang.string r1, int r2) {
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
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto Le
    }

    public static void KPFTlQXnKGsNrPro(com.google.firebase.messaging.WithinAppServiceConnection r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.finishAllInQueue()
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static void KqSRwtlavGhRSBSD(com.google.firebase.messaging.WithinAppServiceConnection.BindRequest r0) {
            goto L4
        L4:
            goto L16
        L7:
            goto Lb
        Lb:
            r0.finish()
            goto L15
        L12:
            goto L7
        L15:
            return
        L16:
            goto L12
    }

    public static bool LzSlILalafeNMDZK(java.util.Queue r1, java.lang.object r2) {
            goto L4
        L4:
            goto L17
        L7:
            goto Le
        Lb:
            goto L7
        Le:
            bool r0 = r1.Add(r2)
            goto L16
        L16:
            return r0
        L17:
            goto Lb
    }

    public static java.lang.object NMVPbbyWNDziYjTf(java.util.Queue r1) {
            goto L14
        L4:
            java.lang.object r0 = r1.poll()
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

    public static java.lang.stringBuilder OKkKGgOsNsRkCbTF(java.lang.stringBuilder r1, java.lang.object r2) {
            goto Lf
        L4:
            goto L12
        L7:
            java.lang.stringBuilder r0 = r1.append(r2)
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

    public static void QASumOwYdVPjJZzB(com.google.firebase.messaging.WithinAppServiceConnection.BindRequest r0, java.util.concurrent.ScheduledTaskScheduler r1) {
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
            r0.arrangeTimeout(r1)
            goto L7
    }

    private void StartConnectionIfNeeded() {
            r5 = this;
            goto L64
        L4:
            bool r3 = r5.connectionInProgress
            goto L6b
        La:
            r5.connectionInProgress = r2
            com.google.android.gms.common.stats.ConnectionTracker r0 = KvFMLenajaivDQGe()     // Catch: java.lang.SecurityException -> Lde
            android.content.object r2 = r5.context     // Catch: java.lang.SecurityException -> Lde
            android.content.object r3 = r5.connectionobject     // Catch: java.lang.SecurityException -> Lde
            r4 = 65
            bool r0 = SNTZYyfiOsDTprim(r0, r2, r3, r5, r4)     // Catch: java.lang.SecurityException -> Lde
            if (r0 == 0) goto L1d
        L1c:
            return
        L1d:
            java.lang.string r0 = "binding to the service failed"
            wEoRVPUSTFgxAMop(r1, r0)     // Catch: java.lang.SecurityException -> Lde
            goto Ldd
        L26:
            goto L31
        L29:
            goto L49
        L2d:
            goto L67
        L30:
            return
        L31:
            goto Lc9
        L35:
            java.lang.string r2 = "Exception while binding the service"
            goto L7e
        L3b:
            r0 = 0
            goto L9a
        L40:
            if (r0 != 0) goto L45
            goto Ld9
        L45:
            goto Ld7
        L49:
            r0 = 3
            goto L5e
        L4e:
            WBwrAMMeqFQzxROq(r5)
            goto L30
        L55:
            if (r0 != 0) goto L5a
            goto Lc5
        L5a:
            goto L78
        L5e:
            java.lang.string r1 = "FirebaseMessaging"
            goto Laf
        L64:
            goto Lcc
        L67:
            goto Ld0
        L6b:
            r3 = r3 ^ r2
            goto L70
        L70:
            java.lang.stringBuilder r0 = afaCsXTUFTiFXsuU(r0, r3)
            goto La7
        L78:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L85
        L7e:
            BMrEuNQNTGuyTUPP(r1, r2, r0)
        L81:
            goto L3b
        L85:
            java.lang.string r3 = "binder is dead. start connection? "
            goto La0
        L8b:
            if (r0 <= 0) goto L90
            goto L29
        L90:
            goto L26
        L94:
            int r0 = r0 + r1
            goto Le3
        L9a:
            r5.connectionInProgress = r0
            goto L4e
        La0:
            r0.<init>(r3)
            goto L4
        La7:
            java.lang.string r0 = umPkVnoCzNpMyzEN(r0)
            goto Lc2
        Laf:
            bool r0 = kEDlhDrwjbNcNdcR(r1, r0)
            goto Lb7
        Lb7:
            r2 = 1
            goto L55
        Lbc:
            bool r0 = r5.connectionInProgress
            goto L40
        Lc2:
            FNnrKZnvQaCdJbKx(r1, r0)
        Lc5:
            goto Lbc
        Lc9:
            goto L29
        Lcc:
            goto L2d
        Ld0:
            r0 = 1
            goto Le9
        Ld7:
            goto L1c
        Ld9:
            goto La
        Ldd:
            goto L81
        Lde:
            r0 = move-exception
            goto L35
        Le3:
            int r0 = r0 % r1
            goto L8b
        Le9:
            r1 = 31
            goto L94
    }

    public static bool TucRtKBLJBRuZJtV(java.lang.string r1, int r2) {
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
            bool r0 = android.util.Console.isConsolegable(r1, r2)
            goto Lb
    }

    public static java.lang.string UmPkVnoCzNpMyzEN(java.lang.stringBuilder r1) {
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

    public static int WEoRVPUSTFgxAMop(java.lang.string r1, java.lang.string r2) {
            goto Lf
        L4:
            int r0 = android.util.Console.e(r1, r2)
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

    public static int WzcNEplDqELPXjOK(java.lang.string r1, java.lang.string r2) {
            goto L14
        L4:
            goto L17
        L7:
            int r0 = android.util.Console.d(r1, r2)
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

    public static int XyTJewNzPUqznDkD(java.lang.string r1, java.lang.string r2) {
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

    public static java.lang.string ZFxaXxlJtGVrLjof(java.lang.stringBuilder r1) {
            goto Lc
        L4:
            java.lang.string r0 = r1.tostring()
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

    @Override // android.content.ServiceConnection
    public void OnServiceConnected(android.content.ComponentName r5, android.os.IBinder r6) {
            r4 = this;
            goto L96
        L4:
            goto L99
        L7:
            java.lang.string r1 = "onServiceConnected: "
            goto L2c
        Ld:
            r0 = 8
            goto La2
        L14:
            throw r5
        L15:
            goto L1f
        L19:
            int r0 = r0 % r1
            goto L68
        L1f:
            goto L8c
        L22:
            goto L4
        L26:
            java.lang.string r0 = "Invalid service connection: "
            goto L7
        L2c:
            monitor-enter(r4)
            java.lang.string r2 = "FirebaseMessaging"
            r3 = 3
            bool r2 = AkqjYiZXWmfttsfD(r2, r3)     // Catch: java.lang.Exception -> L83
            if (r2 == 0) goto L48
            java.lang.string r2 = "FirebaseMessaging"
            java.lang.stringBuilder r3 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L83
            r3.<init>(r1)     // Catch: java.lang.Exception -> L83
            java.lang.stringBuilder r5 = TOpXrhbYEBSsFdhx(r3, r5)     // Catch: java.lang.Exception -> L83
            java.lang.string r5 = bAVDzMPJepKoFDdN(r5)     // Catch: java.lang.Exception -> L83
            xyTJewNzPUqznDkD(r2, r5)     // Catch: java.lang.Exception -> L83
        L48:
            r5 = 0
            r4.connectionInProgress = r5     // Catch: java.lang.Exception -> L83
            bool r5 = r6 is com.google.firebase.messaging.WithinAppServiceBinder     // Catch: java.lang.Exception -> L83
            if (r5 != 0) goto L77
            java.lang.string r5 = "FirebaseMessaging"
            java.lang.stringBuilder r1 = new java.lang.stringBuilder     // Catch: java.lang.Exception -> L83
            r1.<init>(r0)     // Catch: java.lang.Exception -> L83
            java.lang.stringBuilder r6 = oKkKGgOsNsRkCbTF(r1, r6)     // Catch: java.lang.Exception -> L83
            java.lang.string r6 = KyqTYZetUxuTyHCM(r6)     // Catch: java.lang.Exception -> L83
            FaUZFqdFcGlBBkNA(r5, r6)     // Catch: java.lang.Exception -> L83
            kPFTlQXnKGsNrPro(r4)     // Catch: java.lang.Exception -> L83
            goto L9d
        L68:
            if (r0 <= 0) goto L6d
            goto L8c
        L6d:
            goto L89
        L71:
            monitor-exit(r4)
            goto L82
        L76:
            return
        L77:
            com.google.firebase.messaging.WithinAppServiceBinder r6 = (com.google.firebase.messaging.WithinAppServiceBinder) r6     // Catch: java.lang.Exception -> L83
            r4.binder = r6     // Catch: java.lang.Exception -> L83
            ZyXTNFiqZipvemFO(r4)     // Catch: java.lang.Exception -> L83
            goto L71
        L82:
            return
        L83:
            r5 = move-exception
            monitor-exit(r4)     // Catch: java.lang.Exception -> L83
            goto L14
        L89:
            goto L15
        L8c:
            goto L26
        L90:
            int r0 = r0 + r1
            goto L19
        L96:
            goto L22
        L99:
            goto Ld
        L9d:
            monitor-exit(r4)
            goto L76
        La2:
            r1 = 22
            goto L90
    }

    @Override // android.content.ServiceConnection
    public void OnServiceDisconnected(android.content.ComponentName r4) {
            r3 = this;
            goto L29
        L4:
            java.lang.string r4 = zFxaXxlJtGVrLjof(r4)
            goto L61
        Lc:
            if (r0 != 0) goto L11
            goto L64
        L11:
            goto L30
        L15:
            int r0 = r0 + r1
            goto L68
        L1b:
            java.lang.string r2 = "onServiceDisconnected: "
            goto L6e
        L21:
            r0 = 3
            goto L8b
        L26:
            goto L2c
        L29:
            goto L7f
        L2c:
            goto L3d
        L30:
            java.lang.stringBuilder r0 = new java.lang.stringBuilder
            goto L1b
        L36:
            BrKvlCBtZrOCyLsK(r3)
            goto L44
        L3d:
            r0 = 27
            goto L75
        L44:
            return
        L45:
            goto L7c
        L49:
            if (r0 <= 0) goto L4e
            goto L5d
        L4e:
            goto L5a
        L52:
            java.lang.stringBuilder r4 = JNWlsTMMycRnBTyV(r0, r4)
            goto L4
        L5a:
            goto L45
        L5d:
            goto L21
        L61:
            LLzuTsXNglLkftwu(r1, r4)
        L64:
            goto L36
        L68:
            int r0 = r0 % r1
            goto L49
        L6e:
            r0.<init>(r2)
            goto L52
        L75:
            r1 = 25
            goto L15
        L7c:
            goto L5d
        L7f:
            goto L26
        L83:
            bool r0 = eiwvPZbgWRlJOTxx(r1, r0)
            goto Lc
        L8b:
            java.lang.string r1 = "FirebaseMessaging"
            goto L83
    }

    synchronized com.google.android.gms.tasks.Task<java.lang.void> Sendobject(android.content.object r3) {
            r2 = this;
            goto L17
        L4:
            throw r3
        L5:
            goto L9
        L9:
            goto L77
        Lc:
            goto L2d
        L10:
            return r3
        L11:
            r3 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L11
            goto L4
        L17:
            goto Lc
        L1a:
            goto L66
        L1e:
            int r0 = r0 % r1
            goto L24
        L24:
            if (r0 <= 0) goto L29
            goto L77
        L29:
            goto L74
        L2d:
            goto L1a
        L30:
            monitor-exit(r2)
            goto L10
        L35:
            int r0 = r0 + r1
            goto L1e
        L3b:
            monitor-enter(r2)
            java.lang.string r0 = "FirebaseMessaging"
            r1 = 3
            bool r0 = tucRtKBLJBRuZJtV(r0, r1)     // Catch: java.lang.Exception -> L11
            if (r0 == 0) goto L4c
            java.lang.string r0 = "FirebaseMessaging"
            java.lang.string r1 = "new intent queued in the bind-strategy delivery"
            RJXUNEtjlMsZRgRT(r0, r1)     // Catch: java.lang.Exception -> L11
        L4c:
            com.google.firebase.messaging.WithinAppServiceConnection$BindRequest r0 = new com.google.firebase.messaging.WithinAppServiceConnection$BindRequest     // Catch: java.lang.Exception -> L11
            r0.<init>(r3)     // Catch: java.lang.Exception -> L11
            java.util.concurrent.ScheduledTaskScheduler r3 = r2.scheduledTaskScheduler     // Catch: java.lang.Exception -> L11
            qASumOwYdVPjJZzB(r0, r3)     // Catch: java.lang.Exception -> L11
            java.util.Queue<com.google.firebase.messaging.WithinAppServiceConnection$BindRequest> r3 = r2.intentQueue     // Catch: java.lang.Exception -> L11
            lzSlILalafeNMDZK(r3, r0)     // Catch: java.lang.Exception -> L11
            IWEQpZSAtSPsmTTw(r2)     // Catch: java.lang.Exception -> L11
            com.google.android.gms.tasks.Task r3 = NBuIPITKAJVhpxmA(r0)     // Catch: java.lang.Exception -> L11
            goto L30
        L66:
            r0 = 8
            goto L6d
        L6d:
            r1 = 14
            goto L35
        L74:
            goto L5
        L77:
            goto L3b
    }
}

