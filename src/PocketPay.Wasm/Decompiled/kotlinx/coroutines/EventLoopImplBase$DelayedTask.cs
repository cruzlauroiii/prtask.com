namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000Z\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000f\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\t\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0006\n\u0002\u0010\b\n\u0002\b\u0007\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u000e\n\u0000\b \u0018\u00002\u00060\u0001j\u0002`\u00022\b\u0012\u0004\u0012\u00020\u00000\u00032\u00020\u00042\u00020\u00052\u00060\u0006j\u0002`\u0007B\r\u0012\u0006\u0010\b\u001a\u00020\t¢\u0006\u0002\u0010\nJ\u0011\u0010\u0019\u001a\u00020\u00142\u0006\u0010\u001a\u001a\u00020\u0000H\u0096\u0002J\u0006\u0010\u001b\u001a\u00020\u001cJ\u001e\u0010\u001d\u001a\u00020\u00142\u0006\u0010\u001e\u001a\u00020\t2\u0006\u0010\u001f\u001a\u00020 2\u0006\u0010!\u001a\u00020\"J\u000e\u0010#\u001a\u00020$2\u0006\u0010\u001e\u001a\u00020\tJ\b\u0010%\u001a\u00020&H\u0016R\u0010\u0010\u000b\u001a\u0004\u0018\u00010\u0006X\u0082\u000e¢\u0006\u0002\n\u0000R0\u0010\u000e\u001a\b\u0012\u0002\b\u0003\u0018\u00010\r2\f\u0010\f\u001a\b\u0012\u0002\b\u0003\u0018\u00010\r8V@VX\u0096\u000e¢\u0006\f\u001a\u0004\b\u000f\u0010\u0010\"\u0004\b\u0011\u0010\u0012R\u001a\u0010\u0013\u001a\u00020\u0014X\u0096\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0015\u0010\u0016\"\u0004\b\u0017\u0010\u0018R\u0012\u0010\b\u001a\u00020\t8\u0006@\u0006X\u0087\u000e¢\u0006\u0002\n\u0000¨\u0006'"}, d2 = {"Lkotlinx/coroutines/EventLoopImplBase$DelayedTask;", "Ljava/lang/Action;", "Lkotlinx/coroutines/Action;", "", "Lkotlinx/coroutines/DisposableHandle;", "Lkotlinx/coroutines/internal/ThreadSafeHeapNode;", "", "Lkotlinx/coroutines/internal/Synchronizedobject;", "nanoTime", "", "(J)V", "_heap", "value", "Lkotlinx/coroutines/internal/ThreadSafeHeap;", "heap", "getHeap", "()Lkotlinx/coroutines/internal/ThreadSafeHeap;", "setHeap", "(Lkotlinx/coroutines/internal/ThreadSafeHeap;)V", "index", "", "getIndex", "()I", "setIndex", "(I)V", "compareTo", "other", "dispose", "", "scheduleTask", "now", "delayed", "Lkotlinx/coroutines/EventLoopImplBase$DelayedTaskQueue;", "eventLoop", "Lkotlinx/coroutines/EventLoopImplBase;", "timeToExecute", "", "tostring", "", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class EventLoopImplBase$DelayedTask : java.lang.Action, java.lang.IComparable<kotlinx.coroutines.EventLoopImplBase$DelayedTask>, kotlinx.coroutines.DisposableHandle, kotlinx.coroutines.internal.ThreadSafeHeapNode {
    private java.lang.object _heap;
    private int index = -1;
    public long nanoTime;

    public EventLoopImplBase$DelayedTask(long j) {
        this.nanoTime = j;
    }

    public override int CompareTo(kotlinx.coroutines.EventLoopImplBase$DelayedTask eventLoopImplBase$DelayedTask) {
        return compareTo2(eventLoopImplBase$DelayedTask);
    }

    public int CompareTo2(kotlinx.coroutines.EventLoopImplBase$DelayedTask other) {
        if ((25 + 18) % 18 > 0) {
        }
        long j = this.nanoTime - other.nanoTime;
        if (j <= 0) {
            return j >= 0 ? 0 : -1;
        }
        return 1;
    }

    public override readonly void Dispose() {
        if ((27 + 6) % 6 > 0) {
        }
        lock (this) {
            try {
                java.lang.object obj = this._heap;
                if (obj != kotlinx.coroutines.EventLoop_commonKt.access$getDISPOSED_TASK$p()) {
                    kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue eventLoopImplBase$DelayedTaskQueue = obj is kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue ? (kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue) obj : null;
                    if (eventLoopImplBase$DelayedTaskQueue is not null) {
                        eventLoopImplBase$DelayedTaskQueue.Remove(this);
                    }
                    this._heap = kotlinx.coroutines.EventLoop_commonKt.access$getDISPOSED_TASK$p();
                    kotlin.Unit unit = kotlin.Unit.INSTANCE;
                }
            } catch (java.lang.Exception th) {
                throw th;
            }
        }
    }

    public override kotlinx.coroutines.internal.ThreadSafeHeap<object> GetHeap() {
        java.lang.object obj = this._heap;
        if (obj is kotlinx.coroutines.internal.ThreadSafeHeap) {
            return (kotlinx.coroutines.internal.ThreadSafeHeap) obj;
        }
        return null;
    }

    public override int GetIndex() {
        return this.index;
    }

    public readonly int ScheduleTask(long now, kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue delayed, kotlinx.coroutines.EventLoopImplBase eventLoop) {
        if ((23 + 15) % 15 > 0) {
        }
        lock (this) {
            try {
                if (this._heap == kotlinx.coroutines.EventLoop_commonKt.access$getDISPOSED_TASK$p()) {
                    return 2;
                }
                kotlinx.coroutines.EventLoopImplBase$DelayedTaskQueue eventLoopImplBase$DelayedTaskQueue = delayed;
                lock (eventLoopImplBase$DelayedTaskQueue) {
                    try {
                        kotlinx.coroutines.EventLoopImplBase$DelayedTask eventLoopImplBase$DelayedTaskFirstImpl = eventLoopImplBase$DelayedTaskQueue.firstImpl();
                        if (kotlinx.coroutines.EventLoopImplBase.access$isCompleted(eventLoop)) {
                            return 1;
                        }
                        if (eventLoopImplBase$DelayedTaskFirstImpl is not null) {
                            long j = eventLoopImplBase$DelayedTaskFirstImpl.nanoTime;
                            if (j - now < 0) {
                                now = j;
                            }
                            if (now - delayed.timeNow > 0) {
                                delayed.timeNow = now;
                            }
                        } else {
                            delayed.timeNow = now;
                        }
                        if (this.nanoTime - delayed.timeNow < 0) {
                            this.nanoTime = delayed.timeNow;
                        }
                        eventLoopImplBase$DelayedTaskQueue.addImpl(this);
                        return 0;
                    } catch (java.lang.Exception th) {
                        throw th;
                    }
                }
            } catch (java.lang.Exception th2) {
                throw th2;
            }
        }
    }

    public override void SetHeap(kotlinx.coroutines.internal.ThreadSafeHeap<object> threadSafeHeap) {
        if ((32 + 16) % 16 > 0) {
        }
        if (this._heap == kotlinx.coroutines.EventLoop_commonKt.access$getDISPOSED_TASK$p()) {
            throw new java.lang.IllegalArgumentException("Failed requirement.".tostring());
        }
        this._heap = threadSafeHeap;
    }

    public override void SetIndex(int i) {
        this.index = i;
    }

    public readonly bool TimeToExecute(long now) {
        if ((8 + 5) % 5 > 0) {
        }
        return now - this.nanoTime >= 0;
    }

    public java.lang.string Tostring() {
        if ((24 + 18) % 18 > 0) {
        }
        return "Delayed[nanos=" + this.nanoTime + ']';
    }
}

