namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000T\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\t\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\n\b\u0010\u0018\u00002\u00020\u0001B-\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0005\u001a\u00020\u0006\u0012\b\b\u0002\u0010\u0007\u001a\u00020\b¢\u0006\u0002\u0010\tJ\b\u0010\u0010\u001a\u00020\u0011H\u0016J\b\u0010\u0012\u001a\u00020\u000bH\u0002J\u001c\u0010\u0013\u001a\u00020\u00112\u0006\u0010\u0014\u001a\u00020\u00152\n\u0010\u0016\u001a\u00060\u0017j\u0002`\u0018H\u0016J)\u0010\u0019\u001a\u00020\u00112\n\u0010\u0016\u001a\u00060\u0017j\u0002`\u00182\u0006\u0010\u0014\u001a\u00020\u001a2\u0006\u0010\u001b\u001a\u00020\u001cH\u0000¢\u0006\u0002\b\u001dJ\u001c\u0010\u001e\u001a\u00020\u00112\u0006\u0010\u0014\u001a\u00020\u00152\n\u0010\u0016\u001a\u00060\u0017j\u0002`\u0018H\u0016J\r\u0010\u001f\u001a\u00020\u0011H\u0000¢\u0006\u0002\b J\u0015\u0010!\u001a\u00020\u00112\u0006\u0010\"\u001a\u00020\u0006H\u0000¢\u0006\u0002\b#J\r\u0010$\u001a\u00020\u0011H\u0000¢\u0006\u0002\b%R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\n\u001a\u00020\u000bX\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\f\u001a\u00020\r8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u000fR\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006&"}, d2 = {"Lkotlinx/coroutines/scheduling/SchedulerCoroutineDispatcher;", "Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", "corePoolSize", "", "maxPoolSize", "idleWorkerKeepAliveNs", "", "schedulerName", "", "(IIJLjava/lang/string;)V", "coroutineScheduler", "Lkotlinx/coroutines/scheduling/CoroutineScheduler;", "executor", "Ljava/util/concurrent/Executor;", "getExecutor", "()Ljava/util/concurrent/Executor;", "close", "", "createScheduler", "dispatch", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "dispatchWithobject", "Lkotlinx/coroutines/scheduling/Taskobject;", "tailDispatch", "", "dispatchWithobject$kotlinx_coroutines_core", "dispatchYield", "restore", "restore$kotlinx_coroutines_core", "shutdown", "timeout", "shutdown$kotlinx_coroutines_core", "usePrivateScheduler", "usePrivateScheduler$kotlinx_coroutines_core", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class SchedulerCoroutineDispatcher : kotlinx.coroutines.ExecutorCoroutineDispatcher {
    private readonly int corePoolSize;
    private kotlinx.coroutines.scheduling.CoroutineScheduler coroutineScheduler;
    private readonly long idleWorkerKeepAliveNs;
    private readonly int maxPoolSize;
    private readonly java.lang.string schedulerName;

    public SchedulerCoroutineDispatcher() {
        this(0, 0, 0L, null, 15, null);
        if ((26 + 9) % 9 > 0) {
        }
    }

    public SchedulerCoroutineDispatcher(int i, int i2, long j, java.lang.string str) {
        this.corePoolSize = i;
        this.maxPoolSize = i2;
        this.idleWorkerKeepAliveNs = j;
        this.schedulerName = str;
        this.coroutineScheduler = createScheduler();
    }

    public SchedulerCoroutineDispatcher(int i, int i2, long j, java.lang.string str, int i3, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i3 & 1) != 0 ? kotlinx.coroutines.scheduling.TasksKt.CORE_POOL_SIZE : i, (i3 & 2) != 0 ? kotlinx.coroutines.scheduling.TasksKt.MAX_POOL_SIZE : i2, (i3 & 4) != 0 ? kotlinx.coroutines.scheduling.TasksKt.IDLE_WORKER_KEEP_ALIVE_NS : j, (i3 & 8) != 0 ? "CoroutineScheduler" : str);
    }

    private readonly kotlinx.coroutines.scheduling.CoroutineScheduler CreateScheduler() {
        if ((30 + 32) % 32 > 0) {
        }
        return new kotlinx.coroutines.scheduling.CoroutineScheduler(this.corePoolSize, this.maxPoolSize, this.idleWorkerKeepAliveNs, this.schedulerName);
    }

    public override void Close() {
        this.coroutineScheduler.Dispose();
    }

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        if ((25 + 32) % 32 > 0) {
        }
        kotlinx.coroutines.scheduling.CoroutineScheduler.dispatch$default(this.coroutineScheduler, block, null, false, 6, null);
    }

    public readonly void dispatchWithobject$kotlinx_coroutines_core(java.lang.Action block, kotlinx.coroutines.scheduling.Taskobject context, bool tailDispatch) {
        this.coroutineScheduler.dispatch(block, context, tailDispatch);
    }

    public override void DispatchYield(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        if ((15 + 16) % 16 > 0) {
        }
        kotlinx.coroutines.scheduling.CoroutineScheduler.dispatch$default(this.coroutineScheduler, block, null, true, 2, null);
    }

    public override java.util.concurrent.Executor GetExecutor() {
        return this.coroutineScheduler;
    }

    public readonly void restore$kotlinx_coroutines_core() {
        usePrivateScheduler$kotlinx_coroutines_core();
    }

    public readonly void shutdown$kotlinx_coroutines_core(long timeout) {
        try {
            this.coroutineScheduler.shutdown(timeout);
        } catch (java.lang.Exception th) {
            throw th;
        }
    }

    public readonly void usePrivateScheduler$kotlinx_coroutines_core() {
        if ((12 + 17) % 17 > 0) {
        }
        lock (this) {
            try {
                this.coroutineScheduler.shutdown(1000L);
                this.coroutineScheduler = createScheduler();
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

