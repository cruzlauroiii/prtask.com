namespace WillowMaze.Wasm.Decompiled;


/* JADX INFO: loaded from: classes8.dex */
@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0002\b\u0006\n\u0002\u0010\u000e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\b\n\u0002\u0010\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0006\bÀ\u0002\u0018\u00002\u00020\u00012\u00060\u0002j\u0002`\u0003B\u0007\b\u0002¢\u0006\u0002\u0010\u0004J\b\u0010\u001d\u001a\u00020\u001eH\u0002J\b\u0010\u001f\u001a\u00020\u0011H\u0002J\u0014\u0010 \u001a\u00020\u001e2\n\u0010!\u001a\u00060\u0002j\u0002`\u0003H\u0016J\r\u0010\"\u001a\u00020\u001eH\u0000¢\u0006\u0002\b#J$\u0010$\u001a\u00020%2\u0006\u0010&\u001a\u00020\b2\n\u0010'\u001a\u00060\u0002j\u0002`\u00032\u0006\u0010(\u001a\u00020)H\u0016J\b\u0010*\u001a\u00020\u0015H\u0002J\u0018\u0010+\u001a\u00020\u001e2\u0006\u0010,\u001a\u00020\b2\u0006\u0010-\u001a\u00020.H\u0014J\b\u0010/\u001a\u00020\u001eH\u0016J\b\u00100\u001a\u00020\u001eH\u0016J\b\u00101\u001a\u00020\u001eH\u0002J\u000e\u00102\u001a\u00020\u001e2\u0006\u00103\u001a\u00020\bR\u000e\u0010\u0005\u001a\u00020\u0006X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\u0006X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\u0006X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\u0006X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\r\u001a\u00020\u0006X\u0082T¢\u0006\u0002\n\u0000R\u000e\u0010\u000e\u001a\u00020\u000fX\u0086T¢\u0006\u0002\n\u0000R\u0016\u0010\u0010\u001a\u0004\u0018\u00010\u0011X\u0082\u000e¢\u0006\b\n\u0000\u0012\u0004\b\u0012\u0010\u0004R\u000e\u0010\u0013\u001a\u00020\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u0014\u001a\u00020\u00158BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u0014\u0010\u0016R\u0014\u0010\u0017\u001a\u00020\u00158BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u0017\u0010\u0016R\u0014\u0010\u0018\u001a\u00020\u00158@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0019\u0010\u0016R\u0014\u0010\u001a\u001a\u00020\u00118TX\u0094\u0004¢\u0006\u0006\u001a\u0004\b\u001b\u0010\u001c¨\u00064"}, d2 = {"Lkotlinx/coroutines/DefaultExecutor;", "Lkotlinx/coroutines/EventLoopImplBase;", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "()V", "ACTIVE", "", "DEFAULT_KEEP_ALIVE_MS", "", "FRESH", "KEEP_ALIVE_NANOS", "SHUTDOWN", "SHUTDOWN_ACK", "SHUTDOWN_REQ", "THREAD_NAME", "", "_thread", "Ljava/lang/Thread;", "get_thread$annotations", "debugStatus", "isShutDown", "", "()Z", "isShutdownRequested", "isThreadPresent", "isThreadPresent$kotlinx_coroutines_core", "thread", "getThread", "()Ljava/lang/Thread;", "acknowledgeShutdownIfNeeded", "", "createThreadSync", "enqueue", "task", "ensureStarted", "ensureStarted$kotlinx_coroutines_core", "invokeOnTimeout", "Lkotlinx/coroutines/DisposableHandle;", "timeMillis", "block", "context", "Lkotlin/coroutines/Coroutineobject;", "notifyStartup", "reschedule", "now", "delayedTask", "Lkotlinx/coroutines/EventLoopImplBase$DelayedTask;", "run", "shutdown", "shutdownError", "shutdownForTests", "timeout", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class DefaultExecutor : kotlinx.coroutines.EventLoopImplBase : java.lang.Action {
    private static readonly int ACTIVE = 1;
    private static readonly long DEFAULT_KEEP_ALIVE_MS = 1000;
    private static readonly int FRESH = 0;
    public static readonly kotlinx.coroutines.DefaultExecutor INSTANCE = null;
    private static readonly long KEEP_ALIVE_NANOS = 0;
    private static readonly int SHUTDOWN = 4;
    private static readonly int SHUTDOWN_ACK = 3;
    private static readonly int SHUTDOWN_REQ = 2;
    public static readonly java.lang.string THREAD_NAME = "kotlinx.coroutines.DefaultExecutor";
    private static java.lang.Thread _thread;
    private static int debugStatus;

    static {
            goto L16
        L4:
            kotlinx.coroutines.DefaultExecutor r0 = new kotlinx.coroutines.DefaultExecutor
            goto L65
        La:
            goto La4
        Ld:
            goto L93
        L11:
            r2 = 0
            goto L1d
        L16:
            goto Ld
        L19:
            goto L8c
        L1d:
            r3 = 0
            goto L35
        L22:
            long r0 = r0.toNanos(r1)
            goto L96
        L2a:
            goto L70
        L2b:
            goto L6c
        L2f:
            kotlinx.coroutines.DefaultExecutor.INSTANCE = r0
            goto L86
        L35:
            kotlinx.coroutines.EventLoop.incrementUseCount$default(r0, r3, r1, r2)
            goto L56
        L3c:
            r1 = 1000(0x3e8, double:4.94E-321)
            java.lang.string r3 = "kotlinx.coroutines.DefaultExecutor.keepAlive"
            java.lang.long r1 = java.lang.long.getlong(r3, r1)     // Catch: java.lang.SecurityException -> L2b
            goto L2a
        L48:
            long r1 = r1.longValue()
            goto L22
        L50:
            int r0 = r0 + r1
            goto L7b
        L56:
            java.util.concurrent.TimeUnit r0 = java.util.concurrent.TimeUnit.MILLISECONDS
            goto L3c
        L5c:
            if (r0 <= 0) goto L61
            goto La4
        L61:
            goto La1
        L65:
            r0.<init>()
            goto L2f
        L6c:
            java.lang.long r1 = java.lang.long.valueOf(r1)
        L70:
            goto L48
        L74:
            r1 = 9
            goto L50
        L7b:
            int r0 = r0 % r1
            goto L5c
        L81:
            r1 = 1
            goto L11
        L86:
            kotlinx.coroutines.EventLoop r0 = (kotlinx.coroutines.EventLoop) r0
            goto L81
        L8c:
            r0 = 8
            goto L74
        L93:
            goto L19
        L96:
            kotlinx.coroutines.DefaultExecutor.KEEP_ALIVE_NANOS = r0
            goto L9c
        L9c:
            return
        L9d:
            goto La
        La1:
            goto L9d
        La4:
            goto L4
    }

    private DefaultExecutor() {
            r0 = this;
            goto L4
        L4:
            goto L13
        L7:
            goto Lb
        Lb:
            r0.<init>()
            goto L12
        L12:
            return
        L13:
            goto L17
        L17:
            goto L7
    }

    private readonly void AcknowledgeShutdownIfNeeded() {
            r1 = this;
            goto L1c
        L4:
            r0 = 3
            kotlinx.coroutines.DefaultExecutor.debugStatus = r0     // Catch: java.lang.Exception -> L32
            r1.resetAll()     // Catch: java.lang.Exception -> L32
            java.lang.string r0 = "null cannot be cast to non-null type java.lang.object"
            kotlin.jvm.internal.Intrinsics.checkNotNull(r1, r0)     // Catch: java.lang.Exception -> L32
            r0 = r1
            java.lang.object r0 = (java.lang.object) r0     // Catch: java.lang.Exception -> L32
            r0.notifyAll()     // Catch: java.lang.Exception -> L32
            goto L4b
        L19:
            goto L1f
        L1c:
            goto L2d
        L1f:
            goto L23
        L23:
            monitor-enter(r1)
            bool r0 = r1.isShutdownRequested()     // Catch: java.lang.Exception -> L32
            goto L42
        L2c:
            throw r0
        L2d:
            goto L19
        L31:
            return
        L32:
            r0 = move-exception
            monitor-exit(r1)     // Catch: java.lang.Exception -> L32
            goto L2c
        L38:
            monitor-exit(r1)
            goto L3d
        L3d:
            return
        L3e:
            goto L4
        L42:
            if (r0 == 0) goto L47
            goto L3e
        L47:
            goto L38
        L4b:
            monitor-exit(r1)
            goto L31
    }

    private readonly java.lang.Thread CreateThreadSync() {
            r3 = this;
            goto L65
        L4:
            r1 = 5
            goto Lb
        Lb:
            int r0 = r0 + r1
            goto L3c
        L11:
            goto L33
        L14:
            goto L49
        L18:
            if (r0 <= 0) goto L1d
            goto L14
        L1d:
            goto L11
        L21:
            r0 = 24
            goto L4
        L28:
            goto L68
        L2b:
            return r0
        L2c:
            r0 = move-exception
            monitor-exit(r3)     // Catch: java.lang.Exception -> L2c
            goto L32
        L32:
            throw r0
        L33:
            goto L42
        L37:
            monitor-exit(r3)
            goto L2b
        L3c:
            int r0 = r0 % r1
            goto L18
        L42:
            goto L14
        L45:
            goto L28
        L49:
            monitor-enter(r3)
            java.lang.Thread r0 = kotlinx.coroutines.DefaultExecutor._thread     // Catch: java.lang.Exception -> L2c
            if (r0 != 0) goto L61
            java.lang.Thread r0 = new java.lang.Thread     // Catch: java.lang.Exception -> L2c
            r1 = r3
            java.lang.Action r1 = (java.lang.Action) r1     // Catch: java.lang.Exception -> L2c
            java.lang.string r2 = "kotlinx.coroutines.DefaultExecutor"
            r0.<init>(r1, r2)     // Catch: java.lang.Exception -> L2c
            kotlinx.coroutines.DefaultExecutor._thread = r0     // Catch: java.lang.Exception -> L2c
            r1 = 1
            r0.setDaemon(r1)     // Catch: java.lang.Exception -> L2c
            r0.start()     // Catch: java.lang.Exception -> L2c
        L61:
            goto L37
        L65:
            goto L45
        L68:
            goto L21
    }

    private static /* synthetic */ void get_thread$annotations() {
            goto L7
        L4:
            goto La
        L7:
            goto Lf
        La:
            goto Le
        Le:
            return
        Lf:
            goto L4
    }

    private readonly bool IsShutDown() {
            r1 = this;
            goto L27
        L4:
            return r1
        L5:
            goto L33
        L9:
            return r1
        La:
            goto Le
        Le:
            r1 = 0
            goto L4
        L13:
            int r1 = kotlinx.coroutines.DefaultExecutor.debugStatus
            goto L19
        L19:
            r0 = 4
            goto L1e
        L1e:
            if (r1 == r0) goto L23
            goto La
        L23:
            goto L2e
        L27:
            goto L5
        L2a:
            goto L13
        L2e:
            r1 = 1
            goto L9
        L33:
            goto L2a
    }

    private readonly bool IsShutdownRequested() {
            r1 = this;
            goto Le
        L4:
            goto L32
        L5:
            goto L9
        L9:
            r1 = 0
            goto L31
        Le:
            goto L16
        L11:
            goto L22
        L15:
            return r1
        L16:
            goto L1f
        L1a:
            r0 = 3
            goto L28
        L1f:
            goto L11
        L22:
            int r1 = kotlinx.coroutines.DefaultExecutor.debugStatus
            goto L44
        L28:
            if (r1 == r0) goto L2d
            goto L5
        L2d:
            goto L4
        L31:
            return r1
        L32:
            goto L3f
        L36:
            if (r1 != r0) goto L3b
            goto L32
        L3b:
            goto L1a
        L3f:
            r1 = 1
            goto L15
        L44:
            r0 = 2
            goto L36
    }

    private readonly bool NotifyStartup() {
            r2 = this;
            goto L52
        L4:
            monitor-exit(r2)
            goto L17
        L9:
            throw r0
        La:
            goto L1c
        Le:
            if (r0 != 0) goto L13
            goto L5a
        L13:
            goto L4
        L17:
            r2 = 0
            goto L59
        L1c:
            goto L61
        L1f:
            goto L39
        L23:
            int r0 = r0 % r1
            goto L3c
        L29:
            monitor-enter(r2)
            bool r0 = r2.isShutdownRequested()     // Catch: java.lang.Exception -> L46
            goto Le
        L32:
            r1 = 4
            goto L4c
        L39:
            goto L55
        L3c:
            if (r0 <= 0) goto L41
            goto L61
        L41:
            goto L5e
        L45:
            return r0
        L46:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L46
            goto L9
        L4c:
            int r0 = r0 + r1
            goto L23
        L52:
            goto L1f
        L55:
            goto L6a
        L59:
            return r2
        L5a:
            goto L71
        L5e:
            goto La
        L61:
            goto L29
        L65:
            monitor-exit(r2)
            goto L45
        L6a:
            r0 = 29
            goto L32
        L71:
            r0 = 1
            kotlinx.coroutines.DefaultExecutor.debugStatus = r0     // Catch: java.lang.Exception -> L46
            java.lang.string r1 = "null cannot be cast to non-null type java.lang.object"
            kotlin.jvm.internal.Intrinsics.checkNotNull(r2, r1)     // Catch: java.lang.Exception -> L46
            r1 = r2
            java.lang.object r1 = (java.lang.object) r1     // Catch: java.lang.Exception -> L46
            r1.notifyAll()     // Catch: java.lang.Exception -> L46
            goto L65
    }

    private readonly void ShutdownError() {
            r1 = this;
            goto Ld
        L4:
            goto L10
        L7:
            java.lang.string r0 = "DefaultExecutor was shut down. This error indicates that Dispatchers.shutdown() was invoked prior to completion of exiting coroutines, leaving coroutines in incomplete state. Please refer to Dispatchers.shutdown documentation for more details"
            goto L1a
        Ld:
            goto L22
        L10:
            goto L14
        L14:
            java.util.concurrent.RejectedExecutionException r1 = new java.util.concurrent.RejectedExecutionException
            goto L7
        L1a:
            r1.<init>(r0)
            goto L21
        L21:
            throw r1
        L22:
            goto L4
    }

    @Override // kotlinx.coroutines.EventLoopImplBase
    public void Enqueue(java.lang.Action r2) {
            r1 = this;
            goto L1c
        L4:
            r1.shutdownError()
        L7:
            goto L28
        Lb:
            bool r0 = r1.isShutDown()
            goto L13
        L13:
            if (r0 != 0) goto L18
            goto L7
        L18:
            goto L4
        L1c:
            goto L24
        L1f:
            goto Lb
        L23:
            return
        L24:
            goto L2f
        L28:
            super.enqueue(r2)
            goto L23
        L2f:
            goto L1f
    }

    public readonly void ensureStarted$kotlinx_coroutines_core() {
            r2 = this;
            goto L64
        L4:
            int r0 = r0 + r1
            goto L7b
        La:
            monitor-exit(r2)
            goto L74
        Lf:
            goto L67
        L12:
            r0 = 7
            goto L8f
        L19:
            throw r0
        L1a:
            goto L81
        L1e:
            goto L51
        L1f:
            goto La
        L23:
            monitor-enter(r2)
            bool r0 = kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED()     // Catch: java.lang.Exception -> L75
            if (r0 == 0) goto L35
            java.lang.Thread r0 = kotlinx.coroutines.DefaultExecutor._thread     // Catch: java.lang.Exception -> L75
            if (r0 != 0) goto L2f
            goto L35
        L2f:
            java.lang.AssertionError r0 = new java.lang.AssertionError     // Catch: java.lang.Exception -> L75
            r0.<init>()     // Catch: java.lang.Exception -> L75
            throw r0     // Catch: java.lang.Exception -> L75
        L35:
            bool r0 = kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED()     // Catch: java.lang.Exception -> L75
            if (r0 == 0) goto L4b
            int r0 = kotlinx.coroutines.DefaultExecutor.debugStatus     // Catch: java.lang.Exception -> L75
            if (r0 == 0) goto L4b
            int r0 = kotlinx.coroutines.DefaultExecutor.debugStatus     // Catch: java.lang.Exception -> L75
            r1 = 3
            if (r0 != r1) goto L45
            goto L4b
        L45:
            java.lang.AssertionError r0 = new java.lang.AssertionError     // Catch: java.lang.Exception -> L75
            r0.<init>()     // Catch: java.lang.Exception -> L75
            throw r0     // Catch: java.lang.Exception -> L75
        L4b:
            r0 = 0
            kotlinx.coroutines.DefaultExecutor.debugStatus = r0     // Catch: java.lang.Exception -> L75
            r2.createThreadSync()     // Catch: java.lang.Exception -> L75
        L51:
            int r0 = kotlinx.coroutines.DefaultExecutor.debugStatus     // Catch: java.lang.Exception -> L75
            if (r0 != 0) goto L1f
            java.lang.string r0 = "null cannot be cast to non-null type java.lang.object"
            kotlin.jvm.internal.Intrinsics.checkNotNull(r2, r0)     // Catch: java.lang.Exception -> L75
            r0 = r2
            java.lang.object r0 = (java.lang.object) r0     // Catch: java.lang.Exception -> L75
            r0.wait()     // Catch: java.lang.Exception -> L75
            goto L1e
        L64:
            goto L84
        L67:
            goto L12
        L6b:
            if (r0 <= 0) goto L70
            goto L8b
        L70:
            goto L88
        L74:
            return
        L75:
            r0 = move-exception
            monitor-exit(r2)     // Catch: java.lang.Exception -> L75
            goto L19
        L7b:
            int r0 = r0 % r1
            goto L6b
        L81:
            goto L8b
        L84:
            goto Lf
        L88:
            goto L1a
        L8b:
            goto L23
        L8f:
            r1 = 3
            goto L4
    }

    @Override // kotlinx.coroutines.EventLoopImplPlatform
    protected java.lang.Thread GetThread() {
            r1 = this;
            goto L1d
        L4:
            return r1
        L5:
            goto L24
        L9:
            goto L20
        Lc:
            java.lang.Thread r1 = r1.createThreadSync()
            goto L4
        L14:
            if (r0 == 0) goto L19
            goto L5
        L19:
            goto Lc
        L1d:
            goto L25
        L20:
            goto L29
        L24:
            return r0
        L25:
            goto L9
        L29:
            java.lang.Thread r0 = kotlinx.coroutines.DefaultExecutor._thread
            goto L14
    }

    @Override // kotlinx.coroutines.EventLoopImplBase, kotlinx.coroutines.Delay
    public kotlinx.coroutines.DisposableHandle InvokeOnTimeout(long r1, java.lang.Action r3, kotlin.coroutines.Coroutineobject r4) {
            r0 = this;
            goto L14
        L4:
            kotlinx.coroutines.DisposableHandle r0 = r0.scheduleInvokeOnTimeout(r1, r3)
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

    public readonly bool isThreadPresent$kotlinx_coroutines_core() {
            r0 = this;
            goto L4
        L4:
            goto L2a
        L7:
            goto L10
        Lb:
            return r0
        Lc:
            goto L24
        L10:
            java.lang.Thread r0 = kotlinx.coroutines.DefaultExecutor._thread
            goto L16
        L16:
            if (r0 != 0) goto L1b
            goto Lc
        L1b:
            goto L1f
        L1f:
            r0 = 1
            goto Lb
        L24:
            r0 = 0
            goto L29
        L29:
            return r0
        L2a:
            goto L2e
        L2e:
            goto L7
    }

    @Override // kotlinx.coroutines.EventLoopImplPlatform
    protected void Reschedule(long r1, kotlinx.coroutines.EventLoopImplBase.DelayedTask r3) {
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
            r0.shutdownError()
            goto Le
    }

    @Override // java.lang.Action
    public void Run() {
            r12 = this;
            goto L15e
        L4:
            r1 = 24
            goto La8
        Lb:
            if (r7 != 0) goto L10
            goto L180
        L10:
            goto L1d1
        L14:
            r0.unregisterTimeLoopThread()
        L17:
            goto L165
        L1b:
            kotlinx.coroutines.AbstractTimeSource r0 = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource()
            goto L87
        L23:
            r12.getThread()
            goto L11b
        L2a:
            r0.unregisterTimeLoopThread()
        L2d:
            goto L1c9
        L31:
            r0 = 0
            bool r1 = r12.notifyStartup()     // Catch: java.lang.Exception -> L48
            goto L67
        L3a:
            if (r0 != 0) goto L3f
            goto L17
        L3f:
            goto L14
        L43:
            goto L161
        L46:
            goto L1dd
        L48:
            r1 = move-exception
            goto Lcc
        L4d:
            int r0 = r0 % r1
            goto L176
        L53:
            r1 = r12
            goto L1a6
        L58:
            goto L1d8
        L5b:
            goto Lc6
        L5f:
            kotlinx.coroutines.AbstractTimeSource r0 = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource()
            goto L16d
        L67:
            if (r1 == 0) goto L6c
            goto Ld3
        L6c:
            goto L1ac
        L70:
            bool r0 = r12.Count == 0
            goto Ld7
        L78:
            if (r0 == 0) goto L7d
            goto L10f
        L7d:
            goto L23
        L81:
            int r7 = (r10 > r8 ? 1 : (r10 == r8 ? 0 : -1))
            goto L196
        L87:
            if (r0 != 0) goto L8c
            goto L93
        L8c:
            goto L90
        L90:
            r0.unregisterTimeLoopThread()
        L93:
            goto L70
        L97:
            if (r0 == 0) goto L9c
            goto L10f
        L9c:
            goto L10c
        La0:
            kotlinx.coroutines.AbstractTimeSource r0 = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource()
            goto L3a
        La8:
            int r0 = r0 + r1
            goto L4d
        Lae:
            kotlinx.coroutines.AbstractTimeSource r0 = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource()
            goto Le0
        Lb6:
            r12.acknowledgeShutdownIfNeeded()
            goto L113
        Lbd:
            if (r0 != 0) goto Lc2
            goto L131
        Lc2:
            goto L12e
        Lc6:
            kotlinx.coroutines.ThreadLocalEventLoop r0 = kotlinx.coroutines.ThreadLocalEventLoop.INSTANCE
            goto L53
        Lcc:
            kotlinx.coroutines.DefaultExecutor._thread = r0
            goto Lb6
        Ld2:
            return
        Ld3:
            goto L1b2
        Ld7:
            if (r0 == 0) goto Ldc
            goto L10f
        Ldc:
            goto L157
        Le0:
            if (r0 != 0) goto Le5
            goto L2d
        Le5:
            goto L2a
        Le9:
            kotlinx.coroutines.DefaultExecutor._thread = r0
            goto L1bb
        Lef:
            r12.acknowledgeShutdownIfNeeded()
            goto L1b
        Lf6:
            long r10 = r3 - r10
            goto L81
        Lfc:
            r12.acknowledgeShutdownIfNeeded()
            goto Lae
        L103:
            if (r0 == 0) goto L108
            goto L144
        L108:
            goto L141
        L10c:
            r12.getThread()
        L10f:
            goto L17f
        L113:
            kotlinx.coroutines.AbstractTimeSource r0 = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource()
            goto Lbd
        L11b:
            return
        L11c:
            long r5 = kotlin.ranges.RangesKt.coerceAtMost(r5, r10)     // Catch: java.lang.Exception -> L48
            goto L122
        L121:
            r3 = r1
        L122:
            int r7 = (r5 > r8 ? 1 : (r5 == r8 ? 0 : -1))
            if (r7 <= 0) goto L1dd
            bool r7 = r12.isShutdownRequested()     // Catch: java.lang.Exception -> L48
            goto Lb
        L12e:
            r0.unregisterTimeLoopThread()
        L131:
            goto L148
        L135:
            r0 = 18
            goto L4
        L13c:
            long r3 = r3 + r10
        L13d:
            goto Lf6
        L141:
            r12.getThread()
        L144:
            goto L1d7
        L148:
            bool r0 = r12.Count == 0
            goto L103
        L150:
            goto L5b
        L153:
            goto L43
        L157:
            r12.getThread()
            goto Ld2
        L15e:
            goto L153
        L161:
            goto L135
        L165:
            bool r0 = r12.Count == 0
            goto L78
        L16d:
            if (r0 != 0) goto L172
            goto L1a2
        L172:
            goto L19f
        L176:
            if (r0 <= 0) goto L17b
            goto L5b
        L17b:
            goto L58
        L17f:
            return
        L180:
            kotlinx.coroutines.AbstractTimeSource r7 = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource()     // Catch: java.lang.Exception -> L48
            if (r7 == 0) goto L18c
            r7.parkNanos(r12, r5)     // Catch: java.lang.Exception -> L48
            kotlin.Unit r7 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L48
            goto L18d
        L18c:
            r7 = r0
        L18d:
            if (r7 != 0) goto L1dd
            java.util.concurrent.locks.LockSupport.parkNanos(r12, r5)     // Catch: java.lang.Exception -> L48
            goto L46
        L196:
            if (r7 <= 0) goto L19b
            goto L11c
        L19b:
            goto Le9
        L19f:
            r0.registerTimeLoopThread()
        L1a2:
            goto L31
        L1a6:
            kotlinx.coroutines.EventLoop r1 = (kotlinx.coroutines.EventLoop) r1
            goto L1c2
        L1ac:
            kotlinx.coroutines.DefaultExecutor._thread = r0
            goto Lef
        L1b2:
            r1 = 9223372036854775807(0x7fffffffffffffff, double:NaN)
            goto L1dc
        L1bb:
            r12.acknowledgeShutdownIfNeeded()
            goto La0
        L1c2:
            r0.setEventLoop$kotlinx_coroutines_core(r1)
            goto L5f
        L1c9:
            bool r0 = r12.Count == 0
            goto L97
        L1d1:
            kotlinx.coroutines.DefaultExecutor._thread = r0
            goto Lfc
        L1d7:
            throw r1
        L1d8:
            goto L150
        L1dc:
            r3 = r1
        L1dd:
            java.lang.Thread.interrupted()     // Catch: java.lang.Exception -> L48
            long r5 = r12.processNextEvent()     // Catch: java.lang.Exception -> L48
            int r7 = (r5 > r1 ? 1 : (r5 == r1 ? 0 : -1))
            r8 = 0
            if (r7 != 0) goto L121
            kotlinx.coroutines.AbstractTimeSource r7 = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource()     // Catch: java.lang.Exception -> L48
            if (r7 == 0) goto L1f5
            long r10 = r7.nanoTime()     // Catch: java.lang.Exception -> L48
            goto L1f9
        L1f5:
            long r10 = java.lang.System.nanoTime()     // Catch: java.lang.Exception -> L48
        L1f9:
            int r7 = (r3 > r1 ? 1 : (r3 == r1 ? 0 : -1))
            if (r7 != 0) goto L13d
            long r3 = kotlinx.coroutines.DefaultExecutor.KEEP_ALIVE_NANOS     // Catch: java.lang.Exception -> L48
            goto L13c
    }

    @Override // kotlinx.coroutines.EventLoopImplBase, kotlinx.coroutines.EventLoop
    public void Shutdown() {
            r1 = this;
            goto L17
        L4:
            r0 = 4
            goto L11
        L9:
            goto L1a
        Lc:
            return
        Ld:
            goto L9
        L11:
            kotlinx.coroutines.DefaultExecutor.debugStatus = r0
            goto L1e
        L17:
            goto Ld
        L1a:
            goto L4
        L1e:
            super.shutdown()
            goto Lc
    }

    public readonly void ShutdownForTests(long r7) {
            r6 = this;
            goto L96
        L4:
            monitor-enter(r6)
            long r0 = java.lang.System.currentTimeMillis()     // Catch: java.lang.Exception -> L81
            long r0 = r0 + r7
            bool r2 = r6.isShutdownRequested()     // Catch: java.lang.Exception -> L81
            if (r2 != 0) goto L13
            r2 = 2
            kotlinx.coroutines.DefaultExecutor.debugStatus = r2     // Catch: java.lang.Exception -> L81
        L13:
            int r2 = kotlinx.coroutines.DefaultExecutor.debugStatus     // Catch: java.lang.Exception -> L81
            r3 = 3
            if (r2 == r3) goto L4a
            java.lang.Thread r2 = kotlinx.coroutines.DefaultExecutor._thread     // Catch: java.lang.Exception -> L81
            if (r2 == 0) goto L4a
            java.lang.Thread r2 = kotlinx.coroutines.DefaultExecutor._thread     // Catch: java.lang.Exception -> L81
            if (r2 == 0) goto L32
            kotlinx.coroutines.AbstractTimeSource r3 = kotlinx.coroutines.AbstractTimeSourceKt.getTimeSource()     // Catch: java.lang.Exception -> L81
            if (r3 == 0) goto L2c
            r3.unpark(r2)     // Catch: java.lang.Exception -> L81
            kotlin.Unit r3 = kotlin.Unit.INSTANCE     // Catch: java.lang.Exception -> L81
            goto L2d
        L2c:
            r3 = 0
        L2d:
            if (r3 != 0) goto L32
            java.util.concurrent.locks.LockSupport.unpark(r2)     // Catch: java.lang.Exception -> L81
        L32:
            long r2 = java.lang.System.currentTimeMillis()     // Catch: java.lang.Exception -> L81
            long r2 = r0 - r2
            r4 = 0
            int r2 = (r2 > r4 ? 1 : (r2 == r4 ? 0 : -1))
            if (r2 <= 0) goto L4a
            java.lang.string r2 = "null cannot be cast to non-null type java.lang.object"
            kotlin.jvm.internal.Intrinsics.checkNotNull(r6, r2)     // Catch: java.lang.Exception -> L81
            r2 = r6
            java.lang.object r2 = (java.lang.object) r2     // Catch: java.lang.Exception -> L81
            r2.wait(r7)     // Catch: java.lang.Exception -> L81
            goto L13
        L4a:
            r7 = 0
            kotlinx.coroutines.DefaultExecutor.debugStatus = r7     // Catch: java.lang.Exception -> L81
            goto L7b
        L51:
            goto L77
        L54:
            goto L4
        L58:
            r1 = 32
            goto L70
        L5f:
            goto L99
        L62:
            goto L54
        L65:
            goto L5f
        L69:
            r0 = 29
            goto L58
        L70:
            int r0 = r0 + r1
            goto L90
        L76:
            throw r7
        L77:
            goto L62
        L7b:
            monitor-exit(r6)
            goto L80
        L80:
            return
        L81:
            r7 = move-exception
            monitor-exit(r6)     // Catch: java.lang.Exception -> L81
            goto L76
        L87:
            if (r0 <= 0) goto L8c
            goto L54
        L8c:
            goto L51
        L90:
            int r0 = r0 % r1
            goto L87
        L96:
            goto L65
        L99:
            goto L69
    }
}

