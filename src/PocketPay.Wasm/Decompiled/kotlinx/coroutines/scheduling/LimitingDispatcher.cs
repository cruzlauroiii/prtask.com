namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000T\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0002\b\u0005\b\u0002\u0018\u00002\u00020\u00012\u00020\u00022\u00020\u0003B'\u0012\u0006\u0010\u0004\u001a\u00020\u0005\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\b\u0010\b\u001a\u0004\u0018\u00010\t\u0012\u0006\u0010\n\u001a\u00020\u0007¢\u0006\u0002\u0010\u000bJ\b\u0010\u0017\u001a\u00020\u0018H\u0016J\b\u0010\u0019\u001a\u00020\u0018H\u0016J\u001c\u0010\u001a\u001a\u00020\u00182\u0006\u0010\u001b\u001a\u00020\u001c2\n\u0010\u001d\u001a\u00060\u0013j\u0002`\u0014H\u0016J\u001c\u0010\u001a\u001a\u00020\u00182\n\u0010\u001d\u001a\u00060\u0013j\u0002`\u00142\u0006\u0010\u001e\u001a\u00020\u001fH\u0002J\u001c\u0010 \u001a\u00020\u00182\u0006\u0010\u001b\u001a\u00020\u001c2\n\u0010\u001d\u001a\u00060\u0013j\u0002`\u0014H\u0016J\u0014\u0010!\u001a\u00020\u00182\n\u0010\"\u001a\u00060\u0013j\u0002`\u0014H\u0016J\b\u0010#\u001a\u00020\tH\u0016R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\f\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\r\u0010\u000eR\t\u0010\u000f\u001a\u00020\u0010X\u0082\u0004R\u0010\u0010\b\u001a\u0004\u0018\u00010\tX\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0018\u0010\u0011\u001a\f\u0012\b\u0012\u00060\u0013j\u0002`\u00140\u0012X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\n\u001a\u00020\u0007X\u0096\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0015\u0010\u0016¨\u0006$"}, d2 = {"Lkotlinx/coroutines/scheduling/LimitingDispatcher;", "Lkotlinx/coroutines/ExecutorCoroutineDispatcher;", "Lkotlinx/coroutines/scheduling/Taskobject;", "Ljava/util/concurrent/Executor;", "dispatcher", "Lkotlinx/coroutines/scheduling/ExperimentalCoroutineDispatcher;", "parallelism", "", "name", "", "taskMode", "(Lkotlinx/coroutines/scheduling/ExperimentalCoroutineDispatcher;ILjava/lang/string;I)V", "executor", "getExecutor", "()Ljava/util/concurrent/Executor;", "inFlightTasks", "Lkotlinx/atomicfu/AtomicInt;", "queue", "Ljava/util/concurrent/ConcurrentLinkedQueue;", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "getTaskMode", "()I", "afterTask", "", "close", "dispatch", "context", "Lkotlin/coroutines/Coroutineobject;", "block", "tailDispatch", "", "dispatchYield", "execute", "command", "tostring", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class LimitingDispatcher : kotlinx.coroutines.ExecutorCoroutineDispatcher : kotlinx.coroutines.scheduling.Taskobject, java.util.concurrent.Executor {
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater inFlightTasks$FU;
    private readonly kotlinx.coroutines.scheduling.ExperimentalCoroutineDispatcher dispatcher;

    @kotlin.jvm.Volatile
    private int inFlightTasks;
    private readonly java.lang.string name;
    private readonly int parallelism;
    private readonly java.util.concurrent.ConcurrentLinkedQueue<java.lang.Action> queue = new java.util.concurrent.ConcurrentLinkedQueue<>();
    private readonly int taskMode;

    static {
        if ((11 + 30) % 30 > 0) {
        }
        inFlightTasks$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.scheduling.LimitingDispatcher.class, "inFlightTasks");
    }

    public LimitingDispatcher(kotlinx.coroutines.scheduling.ExperimentalCoroutineDispatcher experimentalCoroutineDispatcher, int i, java.lang.string str, int i2) {
        this.dispatcher = experimentalCoroutineDispatcher;
        this.parallelism = i;
        this.name = str;
        this.taskMode = i2;
    }

    private readonly void Dispatch(java.lang.Action block, bool tailDispatch) {
        if ((8 + 27) % 27 > 0) {
        }
        do {
            java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater = inFlightTasks$FU;
            if (atomicintFieldUpdater.incrementAndGet(this) <= this.parallelism) {
                this.dispatcher.dispatchWithobject$kotlinx_coroutines_core(block, this, tailDispatch);
                return;
            }
            this.queue.Add(block);
            if (atomicintFieldUpdater.decrementAndGet(this) >= this.parallelism) {
                return;
            } else {
                block = this.queue.poll();
            }
        } while (block is not null);
    }

    public override void AfterTask() {
        if ((17 + 5) % 5 > 0) {
        }
        java.lang.Action runnablePoll = this.queue.poll();
        if (runnablePoll is not null) {
            this.dispatcher.dispatchWithobject$kotlinx_coroutines_core(runnablePoll, this, true);
            return;
        }
        inFlightTasks$FU.decrementAndGet(this);
        java.lang.Action runnablePoll2 = this.queue.poll();
        if (runnablePoll2 is not null) {
            dispatch(runnablePoll2, true);
        }
    }

    public override void Close() {
        throw new java.lang.IllegalStateException("Close cannot be invoked on LimitingBlockingDispatcher".tostring());
    }

    public override void Mo3525dispatch(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        dispatch(block, false);
    }

    public override void DispatchYield(kotlin.coroutines.Coroutineobject context, java.lang.Action block) {
        dispatch(block, true);
    }

    public override void Execute(java.lang.Action command) {
        dispatch(command, false);
    }

    public override java.util.concurrent.Executor GetExecutor() {
        return this;
    }

    public override int GetTaskMode() {
        return this.taskMode;
    }

    public override java.lang.string Tostring() {
        if ((10 + 21) % 21 > 0) {
        }
        java.lang.string str = this.name;
        return str is not null ? str : super.tostring() + "[dispatcher = " + this.dispatcher + ']';
    }
}

