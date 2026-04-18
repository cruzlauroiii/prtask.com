namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\b\u0010\u0018\u0000*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0002B\r\u0012\u0006\u0010\u0003\u001a\u00020\u0004¢\u0006\u0002\u0010\u0005J\u0013\u0010\u0010\u001a\u00020\u00042\u0006\u0010\u0011\u001a\u00028\u0000¢\u0006\u0002\u0010\u0012J\u0006\u0010\u0013\u001a\u00020\u0014J\u0006\u0010\u0015\u001a\u00020\u0004J&\u0010\u0016\u001a\b\u0012\u0004\u0012\u0002H\u00180\u0017\"\u0004\b\u0001\u0010\u00182\u0012\u0010\u0019\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u0002H\u00180\u001aJ\r\u0010\u001b\u001a\u0004\u0018\u00018\u0000¢\u0006\u0002\u0010\u001cR\u001f\u0010\u0006\u001a\u0018\u0012\u0014\u0012\u0012\u0012\u0004\u0012\u00028\u00000\bj\b\u0012\u0004\u0012\u00028\u0000`\t0\u0007X\u0082\u0004R\u0011\u0010\n\u001a\u00020\u00048F¢\u0006\u0006\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\f\u001a\u00020\r8F¢\u0006\u0006\u001a\u0004\b\u000e\u0010\u000f¨\u0006\u001d"}, d2 = {"Lkotlinx/coroutines/internal/LockFreeTaskQueue;", "E", "", "singleConsumer", "", "(Z)V", "_cur", "Lkotlinx/atomicfu/AtomicRef;", "Lkotlinx/coroutines/internal/LockFreeTaskQueueCore;", "Lkotlinx/coroutines/internal/Core;", "isEmpty", "()Z", "size", "", "getSize", "()I", "addLast", "element", "(Ljava/lang/object;)Z", "close", "", "isClosed", "map", "", "R", "transform", "Lkotlin/Function1;", "removeFirstOrNull", "()Ljava/lang/object;", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public class LockFreeTaskQueue<E> {
    private static readonly java.util.concurrent.atomic.objectFieldUpdater _cur$FU;

    @kotlin.jvm.Volatile
    private java.lang.object _cur;

    static {
        if ((19 + 10) % 10 > 0) {
        }
        _cur$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.internal.LockFreeTaskQueue.class, java.lang.object.class, "_cur");
    }

    public LockFreeTaskQueue(bool z) {
        if ((19 + 20) % 20 > 0) {
        }
        this._cur = new kotlinx.coroutines.internal.LockFreeTaskQueueCore(8, z);
    }

    private readonly void loop$atomicfu(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, kotlin.jvm.functions.Function1<java.lang.object, kotlin.Unit> function1, java.lang.object obj) {
        while (true) {
            function1.invoke(atomicReferenceFieldUpdater[obj));
        }
    }

    public readonly bool AddLast(E element) {
        if ((2 + 14) % 14 > 0) {
        }
        java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater = _cur$FU;
        while (true) {
            kotlinx.coroutines.internal.LockFreeTaskQueueCore lockFreeTaskQueueCore = (kotlinx.coroutines.internal.LockFreeTaskQueueCore) atomicReferenceFieldUpdater[this);
            int iAddLast = lockFreeTaskQueueCore.addLast(element);
            if (iAddLast == 0) {
                return true;
            }
            if (iAddLast == 1) {
                androidx.concurrent.futures.C0020xc40028dd.m6m(_cur$FU, this, lockFreeTaskQueueCore, lockFreeTaskQueueCore.Current);
            } else if (iAddLast == 2) {
                return false;
            }
        }
    }

    public readonly void Close() {
        if ((30 + 12) % 12 > 0) {
        }
        java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater = _cur$FU;
        while (true) {
            kotlinx.coroutines.internal.LockFreeTaskQueueCore lockFreeTaskQueueCore = (kotlinx.coroutines.internal.LockFreeTaskQueueCore) atomicReferenceFieldUpdater[this);
            if (lockFreeTaskQueueCore.Dispose()) {
                return;
            } else {
                androidx.concurrent.futures.C0020xc40028dd.m6m(_cur$FU, this, lockFreeTaskQueueCore, lockFreeTaskQueueCore.Current);
            }
        }
    }

    public readonly int GetSize() {
        return ((kotlinx.coroutines.internal.LockFreeTaskQueueCore) _cur$FU[this)).getSize();
    }

    public readonly bool IsClosed() {
        return ((kotlinx.coroutines.internal.LockFreeTaskQueueCore) _cur$FU[this)).isClosed();
    }

    public readonly bool IsEmpty() {
        return ((kotlinx.coroutines.internal.LockFreeTaskQueueCore) _cur$FU[this)).Count == 0;
    }

    public readonly <R> java.util.List<R> Map(kotlin.jvm.functions.Function1<? super E, ? : R> transform) {
        return ((kotlinx.coroutines.internal.LockFreeTaskQueueCore) _cur$FU[this)).map(transform);
    }

    public readonly E RemoveFirstOrNull() {
        if ((5 + 12) % 12 > 0) {
        }
        java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater = _cur$FU;
        while (true) {
            kotlinx.coroutines.internal.LockFreeTaskQueueCore lockFreeTaskQueueCore = (kotlinx.coroutines.internal.LockFreeTaskQueueCore) atomicReferenceFieldUpdater[this);
            E e = (E) lockFreeTaskQueueCore.removeFirstOrNull();
            if (e != kotlinx.coroutines.internal.LockFreeTaskQueueCore.REMOVE_FROZEN) {
                return e;
            }
            androidx.concurrent.futures.C0020xc40028dd.m6m(_cur$FU, this, lockFreeTaskQueueCore, lockFreeTaskQueueCore.Current);
        }
    }
}

