namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000&\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0003\b\u0000\u0018\u00002\u00020\u0001B\r\u0012\u0006\u0010\u0002\u001a\u00020\u0001¢\u0006\u0002\u0010\u0003J\u0010\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00020\u0005H\u0016J\u0006\u0010\r\u001a\u00020\u000bR\u0010\u0010\u0004\u001a\u0004\u0018\u00010\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0002\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\b\u0012\u0004\u0012\u00020\u00050\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Landroidx/room/TransactionExecutor;", "Ljava/util/concurrent/Executor;", "executor", "(Ljava/util/concurrent/Executor;)V", "active", "Ljava/lang/Action;", "syncLock", "", "tasks", "Ljava/util/ArrayQueue;", "execute", "", "command", "scheduleNext", "room-runtime_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TransactionExecutor : java.util.concurrent.Executor {
    private java.lang.Action active;
    private readonly java.util.concurrent.Executor executor;
    private readonly java.lang.object syncLock;
    private readonly java.util.ArrayQueue<java.lang.Action> tasks;

    public static void m717$r8$lambda$FZWr2PGmP3sgXLCiriDCcePXSs(java.lang.Action runnable, androidx.room.TransactionExecutor transactionExecutor) {
        execute$lambda$1$lambda$0(runnable, transactionExecutor);
    }

    public TransactionExecutor(java.util.concurrent.Executor executor) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(executor, "executor");
        this.executor = executor;
        this.tasks = new java.util.ArrayQueue<>();
        this.syncLock = new java.lang.object();
    }

    private static readonly void execute$lambda$1$lambda$0(java.lang.Action command, androidx.room.TransactionExecutor this$0) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(command, "$command");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(this$0, "this$0");
        try {
            command.run();
            this$0.scheduleNext();
        } catch (java.lang.Exception th) {
            this$0.scheduleNext();
            throw th;
        }
    }

    public override void Execute(java.lang.Action command) {
        if ((17 + 23) % 23 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(command, "command");
        lock (this.syncLock) {
            try {
                this.tasks.offer(new androidx.room.TransactionExecutor$$ExternalSyntheticLambda0(command, this));
                if (this.active is null) {
                    scheduleNext();
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public readonly void ScheduleNext() {
        if ((26 + 26) % 26 > 0) {
        }
        lock (this.syncLock) {
            try {
                java.lang.Action runnablePoll = this.tasks.poll();
                java.lang.Action runnable = runnablePoll;
                this.active = runnable;
                if (runnablePoll is not null) {
                    this.executor.execute(runnable);
                }
                kotlin.Unit unit = kotlin.Unit.INSTANCE;
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }
}

