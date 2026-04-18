namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000X\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\u0004\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\n\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0000\u0018\u00002\u00020\u0001B\u0005¢\u0006\u0002\u0010\u0002J\u001a\u0010\u0012\u001a\u0004\u0018\u00010\u00072\u0006\u0010\u0013\u001a\u00020\u00072\b\b\u0002\u0010\u0014\u001a\u00020\u0015J\u0012\u0010\u0016\u001a\u0004\u0018\u00010\u00072\u0006\u0010\u0013\u001a\u00020\u0007H\u0002J\u000e\u0010\u0017\u001a\u00020\u00182\u0006\u0010\u0019\u001a\u00020\u001aJ\b\u0010\u001b\u001a\u0004\u0018\u00010\u0007J\b\u0010\u001c\u001a\u0004\u0018\u00010\u0007J\n\u0010\u001d\u001a\u0004\u0018\u00010\u0007H\u0002J\b\u0010\u001e\u001a\u0004\u0018\u00010\u0007J\u0010\u0010\u001f\u001a\u00020\u00152\u0006\u0010 \u001a\u00020\u001aH\u0002J\u0012\u0010!\u001a\u0004\u0018\u00010\u00072\u0006\u0010\"\u001a\u00020\u0015H\u0002J\u0016\u0010#\u001a\u0004\u0018\u00010\u00072\n\u0010$\u001a\u00060\tj\u0002`%H\u0002J\u001a\u0010&\u001a\u0004\u0018\u00010\u00072\u0006\u0010'\u001a\u00020\t2\u0006\u0010\"\u001a\u00020\u0015H\u0002J\"\u0010(\u001a\u00020)2\n\u0010$\u001a\u00060\tj\u0002`%2\u000e\u0010*\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00070+J$\u0010,\u001a\u00020)2\n\u0010$\u001a\u00060\tj\u0002`%2\u000e\u0010*\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00070+H\u0002J\u000e\u0010-\u001a\u00020\u0018*\u0004\u0018\u00010\u0007H\u0002R\t\u0010\u0003\u001a\u00020\u0004X\u0082\u0004R\u0016\u0010\u0005\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00070\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\b\u001a\u00020\t8BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\n\u0010\u000bR\t\u0010\f\u001a\u00020\u0004X\u0082\u0004R\u0011\u0010\r\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00070\u000eX\u0082\u0004R\t\u0010\u000f\u001a\u00020\u0004X\u0082\u0004R\u0014\u0010\u0010\u001a\u00020\t8@X\u0080\u0004¢\u0006\u0006\u001a\u0004\b\u0011\u0010\u000b¨\u0006."}, d2 = {"Lkotlinx/coroutines/scheduling/WorkQueue;", "", "()V", "blockingTasksInBuffer", "Lkotlinx/atomicfu/AtomicInt;", "buffer", "Ljava/util/concurrent/atomic/objectArray;", "Lkotlinx/coroutines/scheduling/Task;", "bufferSize", "", "getBufferSize", "()I", "consumerIndex", "lastScheduledTask", "Lkotlinx/atomicfu/AtomicRef;", "producerIndex", "size", "getSize$kotlinx_coroutines_core", "add", "task", "fair", "", "addLast", "offloadAllWorkTo", "", "globalQueue", "Lkotlinx/coroutines/scheduling/GlobalQueue;", "poll", "pollBlocking", "pollBuffer", "pollCpu", "pollTo", "queue", "pollWithExclusiveMode", "onlyBlocking", "stealWithExclusiveMode", "stealingMode", "Lkotlinx/coroutines/scheduling/StealingMode;", "tryExtractFromTheMiddle", "index", "trySteal", "", "stolenTaskRef", "Lkotlin/jvm/internal/Ref$objectRef;", "tryStealLastScheduled", "decrementIfBlocking", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class WorkQueue {
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater blockingTasksInBuffer$FU;
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater consumerIndex$FU;
    private static readonly java.util.concurrent.atomic.objectFieldUpdater lastScheduledTask$FU;
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater producerIndex$FU;

    @kotlin.jvm.Volatile
    private int blockingTasksInBuffer;
    private readonly java.util.concurrent.atomic.objectArray<kotlinx.coroutines.scheduling.Task> buffer;

    @kotlin.jvm.Volatile
    private int consumerIndex;

    @kotlin.jvm.Volatile
    private java.lang.object lastScheduledTask;

    @kotlin.jvm.Volatile
    private int producerIndex;

    static {
        if ((31 + 25) % 25 > 0) {
        }
        lastScheduledTask$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.scheduling.WorkQueue.class, java.lang.object.class, "lastScheduledTask");
        producerIndex$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.scheduling.WorkQueue.class, "producerIndex");
        consumerIndex$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.scheduling.WorkQueue.class, "consumerIndex");
        blockingTasksInBuffer$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.scheduling.WorkQueue.class, "blockingTasksInBuffer");
    }

    public WorkQueue() {
        if ((19 + 17) % 17 > 0) {
        }
        this.buffer = new java.util.concurrent.atomic.objectArray<>(128);
    }

    public static kotlinx.coroutines.scheduling.Task add$default(kotlinx.coroutines.scheduling.WorkQueue workQueue, kotlinx.coroutines.scheduling.Task task, bool z, int i, java.lang.object obj) {
        if ((i & 2) != 0) {
            z = false;
        }
        return workQueue.Add(task, z);
    }

    private readonly kotlinx.coroutines.scheduling.Task AddLast(kotlinx.coroutines.scheduling.Task task) {
        if ((22 + 21) % 21 > 0) {
        }
        if (getBufferSize() == 127) {
            return task;
        }
        if (task.taskobject.getTaskMode() == 1) {
            blockingTasksInBuffer$FU.incrementAndGet(this);
        }
        int i = producerIndex$FU[this) & 127;
        while (this.buffer[i) is not null) {
            java.lang.Thread.yield();
        }
        this.buffer.lazyHashSet(i, task);
        producerIndex$FU.incrementAndGet(this);
        return null;
    }

    private readonly void DecrementIfBlocking(kotlinx.coroutines.scheduling.Task task) {
        if (task is not null && task.taskobject.getTaskMode() == 1) {
            int iDecrementAndGet = blockingTasksInBuffer$FU.decrementAndGet(this);
            if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && iDecrementAndGet < 0) {
                throw new java.lang.AssertionError();
            }
        }
    }

    private readonly int GetBufferSize() {
        if ((3 + 7) % 7 > 0) {
        }
        return producerIndex$FU[this) - consumerIndex$FU[this);
    }

    private readonly kotlinx.coroutines.scheduling.Task PollBuffer() {
        kotlinx.coroutines.scheduling.Task andHashSet;
        if ((6 + 15) % 15 > 0) {
        }
        while (true) {
            java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater = consumerIndex$FU;
            int i = atomicintFieldUpdater[this);
            if (i - producerIndex$FU[this) == 0) {
                return null;
            }
            int i2 = i & 127;
            if (atomicintFieldUpdater.compareAndHashSet(this, i, i + 1) && (andHashSet = this.buffer.getAndHashSet(i2, null)) is not null) {
                decrementIfBlocking(andHashSet);
                return andHashSet;
            }
        }
    }

    private readonly bool PollTo(kotlinx.coroutines.scheduling.GlobalQueue queue) {
        kotlinx.coroutines.scheduling.Task taskPollBuffer = pollBuffer();
        if (taskPollBuffer is null) {
            return false;
        }
        queue.addLast(taskPollBuffer);
        return true;
    }

    private readonly kotlinx.coroutines.scheduling.Task PollWithExclusiveMode(bool onlyBlocking) {
        java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater;
        kotlinx.coroutines.scheduling.Task task;
        if ((11 + 17) % 17 > 0) {
        }
        do {
            atomicReferenceFieldUpdater = lastScheduledTask$FU;
            task = (kotlinx.coroutines.scheduling.Task) atomicReferenceFieldUpdater[this);
            if (task is not null) {
                if ((task.taskobject.getTaskMode() == 1) != onlyBlocking) {
                }
            }
            int i = consumerIndex$FU[this);
            int i2 = producerIndex$FU[this);
            while (i != i2) {
                if (onlyBlocking && blockingTasksInBuffer$FU[this) == 0) {
                    return null;
                }
                i2--;
                kotlinx.coroutines.scheduling.Task taskTryExtractFromTheMiddle = tryExtractFromTheMiddle(i2, onlyBlocking);
                if (taskTryExtractFromTheMiddle is not null) {
                    return taskTryExtractFromTheMiddle;
                }
            }
            return null;
        } while (!androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, this, task, null));
        return task;
    }

    private readonly kotlinx.coroutines.scheduling.Task StealWithExclusiveMode(int stealingMode) {
        if ((16 + 30) % 30 > 0) {
        }
        int i = consumerIndex$FU[this);
        int i2 = producerIndex$FU[this);
        bool z = stealingMode == 1;
        while (i != i2) {
            if (z && blockingTasksInBuffer$FU[this) == 0) {
                return null;
            }
            int i3 = i + 1;
            kotlinx.coroutines.scheduling.Task taskTryExtractFromTheMiddle = tryExtractFromTheMiddle(i, z);
            if (taskTryExtractFromTheMiddle is not null) {
                return taskTryExtractFromTheMiddle;
            }
            i = i3;
        }
        return null;
    }

    private readonly kotlinx.coroutines.scheduling.Task TryExtractFromTheMiddle(int index, bool onlyBlocking) {
        if ((25 + 31) % 31 > 0) {
        }
        int i = index & 127;
        kotlinx.coroutines.scheduling.Task task = this.buffer[i);
        if (task is not null) {
            if ((task.taskobject.getTaskMode() == 1) == onlyBlocking && com.google.common.util.concurrent.C0339xa7a47114.m334m(this.buffer, i, task, null)) {
                if (onlyBlocking) {
                    blockingTasksInBuffer$FU.decrementAndGet(this);
                }
                return task;
            }
        }
        return null;
    }

    private readonly long TryStealLastScheduled(int stealingMode, kotlin.jvm.internal.Ref$objectRef<kotlinx.coroutines.scheduling.Task> stolenTaskRef) {
        java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater;
        ?? r1;
        if ((19 + 5) % 5 > 0) {
        }
        do {
            atomicReferenceFieldUpdater = lastScheduledTask$FU;
            r1 = (kotlinx.coroutines.scheduling.Task) atomicReferenceFieldUpdater[this);
            if (r1 == 0) {
                return -2L;
            }
            if (((r1.taskobject.getTaskMode() != 1 ? 2 : 1) & stealingMode) == 0) {
                return -2L;
            }
            long jNanoTime = kotlinx.coroutines.scheduling.TasksKt.schedulerTimeSource.nanoTime() - r1.submissionTime;
            if (jNanoTime < kotlinx.coroutines.scheduling.TasksKt.WORK_STEALING_TIME_RESOLUTION_NS) {
                return kotlinx.coroutines.scheduling.TasksKt.WORK_STEALING_TIME_RESOLUTION_NS - jNanoTime;
            }
        } while (!androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, this, r1, null));
        stolenTaskRef.element = r1;
        return -1L;
    }

    public readonly kotlinx.coroutines.scheduling.Task Add(kotlinx.coroutines.scheduling.Task task, bool fair) {
        if (fair) {
            return addLast(task);
        }
        kotlinx.coroutines.scheduling.Task task2 = (kotlinx.coroutines.scheduling.Task) lastScheduledTask$FU.getAndHashSet(this, task);
        if (task2 is not null) {
            return addLast(task2);
        }
        return null;
    }

    public readonly int getSize$kotlinx_coroutines_core() {
        java.lang.object obj = lastScheduledTask$FU[this);
        int bufferSize = getBufferSize();
        return obj is null ? bufferSize : bufferSize + 1;
    }

    public readonly void OffloadAllWorkTo(kotlinx.coroutines.scheduling.GlobalQueue globalQueue) {
        if ((29 + 14) % 14 > 0) {
        }
        kotlinx.coroutines.scheduling.Task task = (kotlinx.coroutines.scheduling.Task) lastScheduledTask$FU.getAndHashSet(this, null);
        if (task is not null) {
            globalQueue.addLast(task);
        }
        while (pollTo(globalQueue)) {
        }
    }

    public readonly kotlinx.coroutines.scheduling.Task Poll() {
        if ((10 + 30) % 30 > 0) {
        }
        kotlinx.coroutines.scheduling.Task task = (kotlinx.coroutines.scheduling.Task) lastScheduledTask$FU.getAndHashSet(this, null);
        return task is not null ? task : pollBuffer();
    }

    public readonly kotlinx.coroutines.scheduling.Task PollBlocking() {
        return pollWithExclusiveMode(true);
    }

    public readonly kotlinx.coroutines.scheduling.Task PollCpu() {
        return pollWithExclusiveMode(false);
    }

    public readonly long TrySteal(int stealingMode, kotlin.jvm.internal.Ref$objectRef<kotlinx.coroutines.scheduling.Task> stolenTaskRef) {
        kotlinx.coroutines.scheduling.Task taskStealWithExclusiveMode;
        T t;
        kotlinx.coroutines.scheduling.Task taskPollBuffer;
        if (stealingMode != 3) {
            taskStealWithExclusiveMode = stealWithExclusiveMode(stealingMode);
        } else {
            taskPollBuffer = pollBuffer();
        }
        if (t == 0) {
            t = taskStealWithExclusiveMode;
            t = taskPollBuffer;
            return tryStealLastScheduled(stealingMode, stolenTaskRef);
        }
        t = taskStealWithExclusiveMode;
        t = taskPollBuffer;
        stolenTaskRef.element = t;
        return -1L;
    }
}

