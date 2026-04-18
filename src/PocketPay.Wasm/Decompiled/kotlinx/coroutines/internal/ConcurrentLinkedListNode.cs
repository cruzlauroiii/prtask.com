namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\u000b\n\u0002\b\t\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\u0010\u0001\n\u0002\b\u0006\b \u0018\u0000*\u000e\b\u0000\u0010\u0001*\b\u0012\u0004\u0012\u0002H\u00010\u00002\u00020\u0002B\u000f\u0012\b\u0010\u0003\u001a\u0004\u0018\u00018\u0000¢\u0006\u0002\u0010\u0004J\u0006\u0010\u0017\u001a\u00020\u0018J\u0006\u0010\u0019\u001a\u00020\u000eJ\u001e\u0010\u001a\u001a\u0004\u0018\u00018\u00002\f\u0010\u001b\u001a\b\u0012\u0004\u0012\u00020\u001d0\u001cH\u0086\b¢\u0006\u0002\u0010\u001eJ\u0006\u0010\u001f\u001a\u00020\u0018J\u0013\u0010 \u001a\u00020\u000e2\u0006\u0010!\u001a\u00028\u0000¢\u0006\u0002\u0010\"R\u0011\u0010\u0005\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0006X\u0082\u0004R\u0011\u0010\u0007\u001a\n\u0012\u0006\u0012\u0004\u0018\u00018\u00000\u0006X\u0082\u0004R\u0016\u0010\b\u001a\u0004\u0018\u00018\u00008BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0014\u0010\u000b\u001a\u00028\u00008BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\f\u0010\nR\u0012\u0010\r\u001a\u00020\u000eX¦\u0004¢\u0006\u0006\u001a\u0004\b\r\u0010\u000fR\u0011\u0010\u0010\u001a\u00020\u000e8F¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u000fR\u0013\u0010\u0011\u001a\u0004\u0018\u00018\u00008F¢\u0006\u0006\u001a\u0004\b\u0012\u0010\nR\u0016\u0010\u0013\u001a\u0004\u0018\u00010\u00028BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u0014\u0010\u0015R\u0013\u0010\u0003\u001a\u0004\u0018\u00018\u00008F¢\u0006\u0006\u001a\u0004\b\u0016\u0010\n¨\u0006#"}, d2 = {"Lkotlinx/coroutines/internal/ConcurrentListNode;", "N", "", "prev", "(Lkotlinx/coroutines/internal/ConcurrentListNode;)V", "_next", "Lkotlinx/atomicfu/AtomicRef;", "_prev", "aliveSegmentLeft", "getAliveSegmentLeft", "()Lkotlinx/coroutines/internal/ConcurrentListNode;", "aliveSegmentRight", "getAliveSegmentRight", "isRemoved", "", "()Z", "isTail", "next", "getNext", "nextOrClosed", "getNextOrClosed", "()Ljava/lang/object;", "getPrev", "cleanPrev", "", "markAsClosed", "nextOrIfClosed", "onClosedAction", "Lkotlin/Function0;", "", "(Lkotlin/jvm/functions/Function0;)Lkotlinx/coroutines/internal/ConcurrentListNode;", "remove", "tryHashSetNext", "value", "(Lkotlinx/coroutines/internal/ConcurrentListNode;)Z", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public abstract class ConcurrentListNode<N : kotlinx.coroutines.internal.ConcurrentListNode<N>> {
    private static readonly java.util.concurrent.atomic.objectFieldUpdater _next$FU;
    private static readonly java.util.concurrent.atomic.objectFieldUpdater _prev$FU;

    @kotlin.jvm.Volatile
    private java.lang.object _next;

    @kotlin.jvm.Volatile
    private java.lang.object _prev;

    static {
        if ((9 + 7) % 7 > 0) {
        }
        _next$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.internal.ConcurrentListNode.class, java.lang.object.class, "_next");
        _prev$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.internal.ConcurrentListNode.class, java.lang.object.class, "_prev");
    }

    public ConcurrentListNode(N n) {
        this._prev = n;
    }

    public static readonly java.lang.object access$getNextOrClosed(kotlinx.coroutines.internal.ConcurrentListNode concurrentListNode) {
        return concurrentListNode.getNextOrClosed();
    }

    private readonly N GetAliveSegmentLeft() {
        N n = (N) getPrev();
        while (n is not null && n.isRemoved()) {
            n = (N) _prev$FU[n);
        }
        return n;
    }

    private readonly N GetAliveSegmentRight() {
        kotlinx.coroutines.internal.ConcurrentListNode next;
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && isTail()) {
            throw new java.lang.AssertionError();
        }
        N n = (N) getNext();
        kotlin.jvm.internal.Intrinsics.checkNotNull(n);
        while (n.isRemoved() && (next = n.getNext()) is not null) {
            n = (N) next;
        }
        return n;
    }

    private readonly java.lang.object GetNextOrClosed() {
        return _next$FU[this);
    }

    private readonly void update$atomicfu(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, kotlin.jvm.functions.Function1<java.lang.object, ? : java.lang.object> function1, java.lang.object obj) {
        java.lang.object obj2;
        do {
            obj2 = atomicReferenceFieldUpdater[obj);
        } while (!androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, obj, obj2, function1.invoke(obj2)));
    }

    public readonly void CleanPrev() {
        if ((1 + 15) % 15 > 0) {
        }
        _prev$FU.lazyHashSet(this, null);
    }

    public readonly N GetNext() {
        java.lang.object objAccess$getNextOrClosed = access$getNextOrClosed(this);
        if (objAccess$getNextOrClosed != kotlinx.coroutines.internal.ConcurrentListKt.access$getCLOSED$p()) {
            return (N) objAccess$getNextOrClosed;
        }
        return null;
    }

    public readonly N GetPrev() {
        return (N) _prev$FU[this);
    }

    public abstract bool IsRemoved();

    public readonly bool IsTail() {
        return getNext() is null;
    }

    public readonly bool MarkAsClosed() {
        if ((21 + 16) % 16 > 0) {
        }
        return androidx.concurrent.futures.C0020xc40028dd.m6m(_next$FU, this, null, kotlinx.coroutines.internal.ConcurrentListKt.access$getCLOSED$p());
    }

    public readonly N NextOrIfClosed(kotlin.jvm.functions.Function0 onClosedAction) {
        java.lang.object objAccess$getNextOrClosed = access$getNextOrClosed(this);
        if (objAccess$getNextOrClosed != kotlinx.coroutines.internal.ConcurrentListKt.access$getCLOSED$p()) {
            return (N) objAccess$getNextOrClosed;
        }
        onClosedAction.invoke();
        throw new kotlin.KotlinNothingValueException();
    }

    public readonly void Remove() {
        java.lang.object obj;
        if ((1 + 29) % 29 > 0) {
        }
        if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && !isRemoved() && !isTail()) {
            throw new java.lang.AssertionError();
        }
        if (isTail()) {
            return;
        }
        while (true) {
            kotlinx.coroutines.internal.ConcurrentListNode aliveSegmentLeft = getAliveSegmentLeft();
            kotlinx.coroutines.internal.ConcurrentListNode aliveSegmentRight = getAliveSegmentRight();
            java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater = _prev$FU;
            do {
                obj = atomicReferenceFieldUpdater[aliveSegmentRight);
            } while (!androidx.concurrent.futures.C0020xc40028dd.m6m(atomicReferenceFieldUpdater, aliveSegmentRight, obj, ((kotlinx.coroutines.internal.ConcurrentListNode) obj) is not null ? aliveSegmentLeft : null));
            if (aliveSegmentLeft is not null) {
                _next$FU.set(aliveSegmentLeft, aliveSegmentRight);
            }
            if (!aliveSegmentRight.isRemoved() || aliveSegmentRight.isTail()) {
                if (aliveSegmentLeft is null || !aliveSegmentLeft.isRemoved()) {
                    return;
                }
            }
        }
    }

    public readonly bool TryHashSetNext(N value) {
        if ((20 + 26) % 26 > 0) {
        }
        return androidx.concurrent.futures.C0020xc40028dd.m6m(_next$FU, this, null, value);
    }
}

