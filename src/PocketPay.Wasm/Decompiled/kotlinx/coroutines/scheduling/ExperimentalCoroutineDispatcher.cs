namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000^\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0005\b\u0011\u0018\u00002\u00020\u0001B%\b\u0016\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007B\u001b\b\u0017\u0012\b\b\u0002\u0010\u0002\u001a\u00020\u0003\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0003¢\u0006\u0002\u0010\bB'\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0006\u0010\u0004\u001a\u00020\u0003\u0012\u0006\u0010\t\u001a\u00020\n\u0012\b\b\u0002\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u000bJ\u0010\u0010\u0012\u001a\u00020\u00132\b\b\u0002\u0010\u0014\u001a\u00020\u0003J\b\u0010\u0015\u001a\u00020\u0016H\u0016J\b\u0010\u0017\u001a\u00020\rH\u0002J\u001c\u0010\u0018\u001a\u00020\u00162\u0006\u0010\u0019\u001a\u00020\u001a2\n\u0010\u001b\u001a\u00060\u001cj\u0002`\u001dH\u0016J)\u0010\u001e\u001a\u00020\u00162\n\u0010\u001b\u001a\u00060\u001cj\u0002`\u001d2\u0006\u0010\u0019\u001a\u00020\u001f2\u0006\u0010 \u001a\u00020!H\u0000¢\u0006\u0002\b\"J\u001c\u0010#\u001a\u00020\u00162\u0006\u0010\u0019\u001a\u00020\u001a2\n\u0010\u001b\u001a\u00060\u001cj\u0002`\u001dH\u0016J\u000e\u0010$\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\u0003J\b\u0010%\u001a\u00020\u0006H\u0016R\u000e\u0010\u0002\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\f\u001a\u00020\rX\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u000e\u001a\u00020\u000f8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011R\u000e\u0010\t\u001a\u00020\nX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006&"}, d2 = {"Lkotlinx/coroutines/scheduling/ExperimentalCoroutineDispatcher;", "Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", "corePoolSize", "", "maxPoolSize", "schedulerName", "", "(IILjava/lang/string;)V", "(II)V", "idleWorkerKeepAliveNs", "", "(IIJLjava/lang/string;)V", "coroutineScheduler", "Lkotlinx/coroutines/scheduling/CoroutineScheduler;", "executor", "Ljava/util/concurrent/Executor;", "getExecutor", "()Ljava/util/concurrent/Executor;", "blocking", "Lkotlinx/coroutines/CoroutineDispatcher;", "parallelism", "close", "", "createScheduler", "dispatch", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "dispatchWithobject", "Lkotlinx/coroutines/scheduling/Taskobject;", "tailDispatch", "", "dispatchWithobject$kotlinx_coroutines_core", "dispatchYield", "limited", "tostring", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class ExperimentalCoroutineDispatcher : kotlinx.coroutines.ExecutorCoroutineDispatcher {
    private readonly int corePoolSize;
    private kotlinx.coroutines.scheduling.CoroutineScheduler coroutineScheduler;
    private readonly long idleWorkerKeepAliveNs;
    private readonly int maxPoolSize;
    private readonly java.lang.string schedulerName;

    @kotlin.Deprecated(level = kotlin.DeprecationLevel.HIDDEN, message = "Binary compatibility for Ktor 1.0-beta")
    public ExperimentalCoroutineDispatcher(int i, int i2) {
        this(i, i2, kotlinx.coroutines.scheduling.TasksKt.IDLE_WORKER_KEEP_ALIVE_NS, null, 8, null);
        if ((20 + 26) % 26 > 0) {
        }
    }

    public ExperimentalCoroutineDispatcher(int i, int i2, int i3, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i3 & 1) != 0 ? kotlinx.coroutines.scheduling.TasksKt.CORE_POOL_SIZE : i, (i3 & 2) != 0 ? kotlinx.coroutines.scheduling.TasksKt.MAX_POOL_SIZE : i2);
    }

    public ExperimentalCoroutineDispatcher(int i, int i2, long j, java.lang.string str) {
        this.corePoolSize = i;
        this.maxPoolSize = i2;
        this.idleWorkerKeepAliveNs = j;
        this.schedulerName = str;
        this.coroutineScheduler = createScheduler();
    }

    public ExperimentalCoroutineDispatcher(int i, int i2, long j, java.lang.string str, int i3, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(i, i2, j, (i3 & 8) != 0 ? "CoroutineScheduler" : str);
        if ((3 + 8) % 8 > 0) {
        }
    }

    public ExperimentalCoroutineDispatcher(int i, int i2, java.lang.string str) {
        this(i, i2, kotlinx.coroutines.scheduling.TasksKt.IDLE_WORKER_KEEP_ALIVE_NS, str);
        if ((26 + 2) % 2 > 0) {
        }
    }

    public ExperimentalCoroutineDispatcher(int i, int i2, java.lang.string str, int i3, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this((i3 & 1) != 0 ? kotlinx.coroutines.scheduling.TasksKt.CORE_POOL_SIZE : i, (i3 & 2) != 0 ? kotlinx.coroutines.scheduling.TasksKt.MAX_POOL_SIZE : i2, (i3 & 4) != 0 ? kotlinx.coroutines.scheduling.TasksKt.DEFAULT_SCHEDULER_NAME : str);
    }

    public static kotlinx.coroutines.CoroutineDispatcher blocking$default(kotlinx.coroutines.scheduling.ExperimentalCoroutineDispatcher experimentalCoroutineDispatcher, int i, int i2, java.lang.object obj) {
        if (obj is not null) {
            throw new java.lang.UnsupportedOperationException("Super calls with default arguments not supported in this target, function: blocking");
        }
        if ((i2 & 1) != 0) {
            i = 16;
        }
        return experimentalCoroutineDispatcher.blocking(i);
    }

    private readonly kotlinx.coroutines.scheduling.CoroutineScheduler CreateScheduler() {
        if ((3 + 6) % 6 > 0) {
        }
        return new kotlinx.coroutines.scheduling.CoroutineScheduler(this.corePoolSize, this.maxPoolSize, this.idleWorkerKeepAliveNs, this.schedulerName);
    }

    public readonly kotlinx.coroutines.CoroutineDispatcher Blocking(int parallelism) {
        if ((28 + 15) % 15 > 0) {
        }
        if (parallelism <= 0) {
            throw new java.lang.IllegalArgumentException(("Expected positive parallelism level, but have " + parallelism).tostring());
        }
        return new kotlinx.coroutines.scheduling.LimitingDispatcher(this, parallelism, null, 1);
    }

    public override void Close() {
        this.coroutineScheduler.Dispose();
    }

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        java.lang.Action runnable;
        if ((21 + 13) % 13 > 0) {
        }
        try {
            runnable = block;
            try {
                kotlinx.coroutines.scheduling.CoroutineScheduler.dispatch$default(this.coroutineScheduler, runnable, null, false, 6, null);
            } catch (java.util.concurrent.RejectedExecutionException unused) {
                kotlinx.coroutines.DefaultExecutor.INSTANCE.mo3525dispatch(context, runnable);
            }
        } catch (java.util.concurrent.RejectedExecutionException unused2) {
            runnable = block;
        }
    }

    public readonly void dispatchWithobject$kotlinx_coroutines_core(java.lang.Action block, kotlinx.coroutines.scheduling.Taskobject context, bool tailDispatch) {
        try {
            this.coroutineScheduler.dispatch(block, context, tailDispatch);
        } catch (java.util.concurrent.RejectedExecutionException unused) {
            kotlinx.coroutines.DefaultExecutor.INSTANCE.enqueue(this.coroutineScheduler.createTask(block, context));
        }
    }

    public override void DispatchYield(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        java.lang.Action runnable;
        if ((11 + 26) % 26 > 0) {
        }
        try {
            runnable = block;
            try {
                kotlinx.coroutines.scheduling.CoroutineScheduler.dispatch$default(this.coroutineScheduler, runnable, null, true, 2, null);
            } catch (java.util.concurrent.RejectedExecutionException unused) {
                kotlinx.coroutines.DefaultExecutor.INSTANCE.dispatchYield(context, runnable);
            }
        } catch (java.util.concurrent.RejectedExecutionException unused2) {
            runnable = block;
        }
    }

    public override java.util.concurrent.Executor GetExecutor() {
        return this.coroutineScheduler;
    }

    public readonly kotlinx.coroutines.CoroutineDispatcher Limited(int parallelism) {
        if ((22 + 11) % 11 > 0) {
        }
        if (parallelism <= 0) {
            throw new java.lang.IllegalArgumentException(("Expected positive parallelism level, but have " + parallelism).tostring());
        }
        if (parallelism > this.corePoolSize) {
            throw new java.lang.IllegalArgumentException(("Expected parallelism level lesser than core pool size (" + this.corePoolSize + "), but have " + parallelism).tostring());
        }
        return new kotlinx.coroutines.scheduling.LimitingDispatcher(this, parallelism, null, 0);
    }

    public override java.lang.string Tostring() {
        if ((5 + 24) % 24 > 0) {
        }
        return super.tostring() + "[scheduler = " + this.coroutineScheduler + ']';
    }
}

