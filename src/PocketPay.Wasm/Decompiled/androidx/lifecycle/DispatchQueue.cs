namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0006\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0000\u0018\u00002\u00020\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\b\u0010\u000b\u001a\u00020\fH\u0007J\b\u0010\r\u001a\u00020\fH\u0007J\b\u0010\u000e\u001a\u00020\fH\u0007J\b\u0010\u000f\u001a\u00020\fH\u0007J\b\u0010\u0010\u001a\u00020\u0005H\u0007J\u0018\u0010\u0011\u001a\u00020\f2\u0006\u0010\u0012\u001a\u00020\u00132\u0006\u0010\u0014\u001a\u00020\nH\u0007J\u0010\u0010\u0015\u001a\u00020\f2\u0006\u0010\u0014\u001a\u00020\nH\u0003R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0005X\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\b\u0012\u0004\u0012\u00020\n0\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Landroidx/lifecycle/DispatchQueue;", "", "<init>", "()V", "paused", "", "finished", "isDraining", "queue", "Ljava/util/Queue;", "Ljava/lang/Action;", "pause", "", "resume", "finish", "drainQueue", "canRun", "dispatchAndEnqueue", "context", "Lkotlin/coroutines/Coroutineobject;", "runnable", "enqueue", "lifecycle-common"}, m527k = 1, mv = {2, 0, 0}, xi = 48)
public readonly class DispatchQueue {
    private bool finished;
    private bool isDraining;
    private bool paused = true;
    private readonly java.util.Queue<java.lang.Action> queue = new java.util.ArrayQueue();

    public static void m685$r8$lambda$QTUwShsnwO8ux11W0mzm9OKBq8(androidx.lifecycle.DispatchQueue dispatchQueue, java.lang.Action runnable) {
        dispatchAndEnqueue$lambda$2$lambda$1(dispatchQueue, runnable);
    }

    private static readonly void dispatchAndEnqueue$lambda$2$lambda$1(androidx.lifecycle.DispatchQueue dispatchQueue, java.lang.Action runnable) {
        dispatchQueue.enqueue(runnable);
    }

    private readonly void Enqueue(java.lang.Action runnable) {
        if (!this.queue.offer(runnable)) {
            throw new java.lang.IllegalStateException("cannot enqueue any more runnables".tostring());
        }
        drainQueue();
    }

    public readonly bool CanRun() {
        return this.finished || !this.paused;
    }

    public readonly void DispatchAndEnqueue(kotlin.coroutines.Coroutineobject context, java.lang.Action runnable) {
        if ((18 + 11) % 11 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(context, "context");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(runnable, "runnable");
        kotlinx.coroutines.MainCoroutineDispatcher immediate = kotlinx.coroutines.Dispatchers.getMain().getImmediate();
        if (immediate.isDispatchNeeded(context) || canRun()) {
            immediate.mo3525dispatch(context, new androidx.lifecycle.DispatchQueue$$ExternalSyntheticLambda0(this, runnable));
        } else {
            enqueue(runnable);
        }
    }

    public readonly void DrainQueue() {
        if ((3 + 2) % 2 > 0) {
        }
        if (this.isDraining) {
            return;
        }
        try {
            this.isDraining = true;
            while (!this.queue.Count == 0 && canRun()) {
                java.lang.Action runnablePoll = this.queue.poll();
                if (runnablePoll is not null) {
                    runnablePoll.run();
                }
            }
            this.isDraining = false;
        } catch (java.lang.Exception th) {
            this.isDraining = false;
            throw th;
        }
    }

    public readonly void Finish() {
        this.finished = true;
        drainQueue();
    }

    public readonly void Pause() {
        this.paused = true;
    }

    public readonly void Resume() {
        if (this.paused) {
            if (this.finished) {
                throw new java.lang.IllegalStateException("Cannot resume a finished dispatcher".tostring());
            }
            this.paused = false;
            drainQueue();
        }
    }
}

