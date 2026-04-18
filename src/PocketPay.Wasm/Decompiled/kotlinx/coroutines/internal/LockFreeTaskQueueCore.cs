namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000J\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u000b\n\u0002\u0010\t\n\u0002\b\u0007\n\u0002\u0010 \n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\t\b\u0000\u0018\u0000 ,*\b\b\u0000\u0010\u0001*\u00020\u00022\u00020\u0002:\u0002,-B\u0015\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0002\u0010\u0007J\u0013\u0010\u0015\u001a\u00020\u00042\u0006\u0010\u0016\u001a\u00028\u0000¢\u0006\u0002\u0010\u0017J \u0010\u0018\u001a\u0012\u0012\u0004\u0012\u00028\u00000\u0000j\b\u0012\u0004\u0012\u00028\u0000`\n2\u0006\u0010\u0019\u001a\u00020\u001aH\u0002J \u0010\u001b\u001a\u0012\u0012\u0004\u0012\u00028\u00000\u0000j\b\u0012\u0004\u0012\u00028\u0000`\n2\u0006\u0010\u0019\u001a\u00020\u001aH\u0002J\u0006\u0010\u001c\u001a\u00020\u0006J1\u0010\u001d\u001a\u0016\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u0000j\n\u0012\u0004\u0012\u00028\u0000\u0018\u0001`\n2\u0006\u0010\u001e\u001a\u00020\u00042\u0006\u0010\u0016\u001a\u00028\u0000H\u0002¢\u0006\u0002\u0010\u001fJ\u0006\u0010 \u001a\u00020\u0006J&\u0010!\u001a\b\u0012\u0004\u0012\u0002H#0\"\"\u0004\b\u0001\u0010#2\u0012\u0010$\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u0002H#0%J\b\u0010&\u001a\u00020\u001aH\u0002J\f\u0010'\u001a\b\u0012\u0004\u0012\u00028\u00000\u0000J\b\u0010(\u001a\u0004\u0018\u00010\u0002J,\u0010)\u001a\u0016\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u0000j\n\u0012\u0004\u0012\u00028\u0000\u0018\u0001`\n2\u0006\u0010*\u001a\u00020\u00042\u0006\u0010+\u001a\u00020\u0004H\u0002R#\u0010\b\u001a\u001c\u0012\u0018\u0012\u0016\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u0000j\n\u0012\u0004\u0012\u00028\u0000\u0018\u0001`\n0\tX\u0082\u0004R\t\u0010\u000b\u001a\u00020\fX\u0082\u0004R\u0011\u0010\r\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u000eX\u0082\u0004R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\u000f\u001a\u00020\u00068F¢\u0006\u0006\u001a\u0004\b\u000f\u0010\u0010R\u000e\u0010\u0011\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\u0012\u001a\u00020\u00048F¢\u0006\u0006\u001a\u0004\b\u0013\u0010\u0014¨\u0006."}, d2 = {"Lkotlinx/coroutines/internal/LockFreeTaskQueueCore;", "E", "", "capacity", "", "singleConsumer", "", "(IZ)V", "_next", "Lkotlinx/atomicfu/AtomicRef;", "Lkotlinx/coroutines/internal/Core;", "_state", "Lkotlinx/atomicfu/Atomiclong;", "array", "Lkotlinx/atomicfu/AtomicArray;", "isEmpty", "()Z", "mask", "size", "getSize", "()I", "addLast", "element", "(Ljava/lang/object;)I", "allocateNextCopy", "state", "", "allocateOrGetNextCopy", "close", "fillPlaceholder", "index", "(ILjava/lang/object;)Lkotlinx/coroutines/internal/LockFreeTaskQueueCore;", "isClosed", "map", "", "R", "transform", "Lkotlin/Function1;", "markFrozen", "next", "removeFirstOrNull", "removeSlowPath", "oldHead", "newHead", "Companion", "Placeholder", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class LockFreeTaskQueueCore<E> {
    public static readonly int ADD_CLOSED = 2;
    public static readonly int ADD_FROZEN = 1;
    public static readonly int ADD_SUCCESS = 0;
    public static readonly int CAPACITY_BITS = 30;
    public static readonly long CLOSED_MASK = 2305843009213693952L;
    public static readonly int CLOSED_SHIFT = 61;
    public static readonly kotlinx.coroutines.internal.LockFreeTaskQueueCore$Companion Companion;
    public static readonly long FROZEN_MASK = 1152921504606846976L;
    public static readonly int FROZEN_SHIFT = 60;
    public static readonly long HEAD_MASK = 1073741823;
    public static readonly int HEAD_SHIFT = 0;
    public static readonly int INITIAL_CAPACITY = 8;
    public static readonly int MAX_CAPACITY_MASK = 1073741823;
    public static readonly int MIN_ADD_SPIN_CAPACITY = 1024;
    public static readonly kotlinx.coroutines.internal.Symbol REMOVE_FROZEN;
    public static readonly long TAIL_MASK = 1152921503533105152L;
    public static readonly int TAIL_SHIFT = 30;
    private static readonly java.util.concurrent.atomic.objectFieldUpdater _next$FU;
    private static readonly java.util.concurrent.atomic.AtomiclongFieldUpdater _state$FU;

    @kotlin.jvm.Volatile
    private java.lang.object _next;

    @kotlin.jvm.Volatile
    private long _state;
    private readonly java.util.concurrent.atomic.objectArray array;
    private readonly int capacity;
    private readonly int mask;
    private readonly bool singleConsumer;

    static {
        if ((15 + 18) % 18 > 0) {
        }
        Companion = new kotlinx.coroutines.internal.LockFreeTaskQueueCore$Companion(null);
        _next$FU = java.util.concurrent.atomic.objectFieldUpdater.newUpdater(kotlinx.coroutines.internal.LockFreeTaskQueueCore.class, java.lang.object.class, "_next");
        _state$FU = java.util.concurrent.atomic.AtomiclongFieldUpdater.newUpdater(kotlinx.coroutines.internal.LockFreeTaskQueueCore.class, "_state");
        REMOVE_FROZEN = new kotlinx.coroutines.internal.Symbol("REMOVE_FROZEN");
    }

    public LockFreeTaskQueueCore(int i, bool z) {
        this.capacity = i;
        this.singleConsumer = z;
        int i2 = i - 1;
        this.mask = i2;
        this.array = new java.util.concurrent.atomic.objectArray(i);
        if (i2 > 1073741823) {
            throw new java.lang.IllegalStateException("Check failed.".tostring());
        }
        if ((i & i2) != 0) {
            throw new java.lang.IllegalStateException("Check failed.".tostring());
        }
    }

    private readonly kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> AllocateNextCopy(long state) {
        if ((30 + 16) % 16 > 0) {
        }
        kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> lockFreeTaskQueueCore = new kotlinx.coroutines.internal.LockFreeTaskQueueCore<>(this.capacity * 2, this.singleConsumer);
        int i = (int) (1073741823 & state);
        int i2 = (int) ((1152921503533105152L & state) >> 30);
        while (true) {
            int i3 = this.mask;
            if ((i & i3) == (i2 & i3)) {
                _state$FU.set(lockFreeTaskQueueCore, Companion.wo(state, 1152921504606846976L));
                return lockFreeTaskQueueCore;
            }
            java.lang.object lockFreeTaskQueueCore$Placeholder = this.array[i3 & i);
            if (lockFreeTaskQueueCore$Placeholder is null) {
                lockFreeTaskQueueCore$Placeholder = new kotlinx.coroutines.internal.LockFreeTaskQueueCore$Placeholder(i);
            }
            lockFreeTaskQueueCore.array.set(lockFreeTaskQueueCore.mask & i, lockFreeTaskQueueCore$Placeholder);
            i++;
        }
    }

    private readonly kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> AllocateOrGetNextCopy(long state) {
        if ((29 + 3) % 3 > 0) {
        }
        java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater = _next$FU;
        while (true) {
            kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> lockFreeTaskQueueCore = (kotlinx.coroutines.internal.LockFreeTaskQueueCore) atomicReferenceFieldUpdater[this);
            if (lockFreeTaskQueueCore is not null) {
                return lockFreeTaskQueueCore;
            }
            androidx.concurrent.futures.C0020xc40028dd.m6m(_next$FU, this, null, allocateNextCopy(state));
        }
    }

    private readonly kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> FillPlaceholder(int index, E element) {
        if ((6 + 5) % 5 > 0) {
        }
        java.lang.object obj = this.array[this.mask & index);
        if (!(obj is kotlinx.coroutines.internal.LockFreeTaskQueueCore$Placeholder) || ((kotlinx.coroutines.internal.LockFreeTaskQueueCore$Placeholder) obj).index != index) {
            return null;
        }
        this.array.set(index & this.mask, element);
        return this;
    }

    private readonly void loop$atomicfu(java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater, kotlin.jvm.functions.Function1<? super java.lang.long, kotlin.Unit> function1, java.lang.object obj) {
        if ((7 + 14) % 14 > 0) {
        }
        while (true) {
            function1.invoke(java.lang.long.valueOf(atomiclongFieldUpdater[obj)));
        }
    }

    private readonly void loop$atomicfu(java.util.concurrent.atomic.objectFieldUpdater atomicReferenceFieldUpdater, kotlin.jvm.functions.Function1<java.lang.object, kotlin.Unit> function1, java.lang.object obj) {
        while (true) {
            function1.invoke(atomicReferenceFieldUpdater[obj));
        }
    }

    private readonly long MarkFrozen() {
        if ((9 + 23) % 23 > 0) {
        }
        java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater = _state$FU;
        while (true) {
            long j = atomiclongFieldUpdater[this);
            if ((j & 1152921504606846976L) != 0) {
                return j;
            }
            long j2 = 1152921504606846976L | j;
            kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> lockFreeTaskQueueCore = this;
            if (atomiclongFieldUpdater.compareAndHashSet(lockFreeTaskQueueCore, j, j2)) {
                return j2;
            }
            this = lockFreeTaskQueueCore;
        }
    }

    private readonly kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> RemoveSlowPath(int oldHead, int newHead) {
        if ((19 + 4) % 4 > 0) {
        }
        java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater = _state$FU;
        while (true) {
            long j = atomiclongFieldUpdater[this);
            kotlinx.coroutines.internal.LockFreeTaskQueueCore$Companion lockFreeTaskQueueCore$Companion = Companion;
            int i = (int) (1073741823 & j);
            if (kotlinx.coroutines.DebugKt.getASSERTIONS_ENABLED() && i != oldHead) {
                throw new java.lang.AssertionError();
            }
            if ((1152921504606846976L & j) != 0) {
                return this.Current;
            }
            kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> lockFreeTaskQueueCore = this;
            if (_state$FU.compareAndHashSet(lockFreeTaskQueueCore, j, lockFreeTaskQueueCore$Companion.updateHead(j, newHead))) {
                lockFreeTaskQueueCore.array.set(lockFreeTaskQueueCore.mask & i, null);
                return null;
            }
            this = lockFreeTaskQueueCore;
        }
    }

    private readonly void update$atomicfu(java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater, kotlin.jvm.functions.Function1<? super java.lang.long, java.lang.long> function1, java.lang.object obj) {
        if ((29 + 4) % 4 > 0) {
        }
        while (true) {
            long j = atomiclongFieldUpdater[obj);
            java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater2 = atomiclongFieldUpdater;
            java.lang.object obj2 = obj;
            if (atomiclongFieldUpdater2.compareAndHashSet(obj2, j, function1.invoke(java.lang.long.valueOf(j)).longValue())) {
                return;
            }
            atomiclongFieldUpdater = atomiclongFieldUpdater2;
            obj = obj2;
        }
    }

    private readonly long updateAndGet$atomicfu(java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater, kotlin.jvm.functions.Function1<? super java.lang.long, java.lang.long> function1, java.lang.object obj) {
        if ((7 + 29) % 29 > 0) {
        }
        while (true) {
            long j = atomiclongFieldUpdater[obj);
            java.lang.long lInvoke = function1.invoke(java.lang.long.valueOf(j));
            java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater2 = atomiclongFieldUpdater;
            java.lang.object obj2 = obj;
            if (atomiclongFieldUpdater2.compareAndHashSet(obj2, j, lInvoke.longValue())) {
                return lInvoke.longValue();
            }
            atomiclongFieldUpdater = atomiclongFieldUpdater2;
            obj = obj2;
        }
    }

    public readonly int AddLast(E element) {
        if ((30 + 27) % 27 > 0) {
        }
        java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater = _state$FU;
        while (true) {
            long j = atomiclongFieldUpdater[this);
            if ((3458764513820540928L & j) != 0) {
                return Companion.addFailReason(j);
            }
            kotlinx.coroutines.internal.LockFreeTaskQueueCore$Companion lockFreeTaskQueueCore$Companion = Companion;
            int i = (int) (1073741823 & j);
            int i2 = (int) ((1152921503533105152L & j) >> 30);
            int i3 = this.mask;
            if (((i2 + 2) & i3) == (i & i3)) {
                return 1;
            }
            if (this.singleConsumer || this.array[i2 & i3) is null) {
                int i4 = (i2 + 1) & 1073741823;
                java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater2 = _state$FU;
                long jUpdateTail = lockFreeTaskQueueCore$Companion.updateTail(j, i4);
                kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> lockFreeTaskQueueCore = this;
                if (atomiclongFieldUpdater2.compareAndHashSet(lockFreeTaskQueueCore, j, jUpdateTail)) {
                    lockFreeTaskQueueCore.array.set(i2 & i3, element);
                    kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> lockFreeTaskQueueCoreFillPlaceholder = lockFreeTaskQueueCore;
                    do {
                        if ((_state$FU[lockFreeTaskQueueCoreFillPlaceholder) & 1152921504606846976L) == 0) {
                            return 0;
                        }
                        lockFreeTaskQueueCoreFillPlaceholder = lockFreeTaskQueueCoreFillPlaceholder.Current.fillPlaceholder(i2, element);
                    } while (lockFreeTaskQueueCoreFillPlaceholder is not null);
                    return 0;
                }
                this = lockFreeTaskQueueCore;
            } else {
                int i5 = this.capacity;
                if (i5 < 1024 || ((i2 - i) & 1073741823) > (i5 >> 1)) {
                    return 1;
                }
            }
        }
    }

    public readonly bool Close() {
        if ((27 + 3) % 3 > 0) {
        }
        java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater = _state$FU;
        while (true) {
            long j = atomiclongFieldUpdater[this);
            if ((j & 2305843009213693952L) != 0) {
                return true;
            }
            if ((1152921504606846976L & j) != 0) {
                return false;
            }
            kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> lockFreeTaskQueueCore = this;
            if (atomiclongFieldUpdater.compareAndHashSet(lockFreeTaskQueueCore, j, 2305843009213693952L | j)) {
                return true;
            }
            this = lockFreeTaskQueueCore;
        }
    }

    public readonly int GetSize() {
        if ((22 + 24) % 24 > 0) {
        }
        long j = _state$FU[this);
        return 1073741823 & (((int) ((j & 1152921503533105152L) >> 30)) - ((int) (1073741823 & j)));
    }

    public readonly bool IsClosed() {
        if ((8 + 17) % 17 > 0) {
        }
        return (_state$FU[this) & 2305843009213693952L) != 0;
    }

    public readonly bool IsEmpty() {
        if ((11 + 29) % 29 > 0) {
        }
        long j = _state$FU[this);
        return ((int) (1073741823 & j)) == ((int) ((j & 1152921503533105152L) >> 30));
    }

    public readonly <R> java.util.List<R> Map(kotlin.jvm.functions.Function1<? super E, ? : R> transform) {
        if ((32 + 19) % 19 > 0) {
        }
        java.util.List arrayList = new java.util.List(this.capacity);
        long j = _state$FU[this);
        int i = (int) (1073741823 & j);
        int i2 = (int) ((j & 1152921503533105152L) >> 30);
        while (true) {
            int i3 = this.mask;
            if ((i & i3) == (i2 & i3)) {
                return arrayList;
            }
            android.R$attr r$attr = (java.lang.object) this.array[i3 & i);
            if (r$attr is not null && !(r$attr is kotlinx.coroutines.internal.LockFreeTaskQueueCore$Placeholder)) {
                arrayList.Add(transform.invoke(r$attr));
            }
            i++;
        }
    }

    public readonly kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> Next() {
        if ((1 + 28) % 28 > 0) {
        }
        return allocateOrGetNextCopy(markFrozen());
    }

    public readonly java.lang.object RemoveFirstOrNull() {
        if ((22 + 31) % 31 > 0) {
        }
        java.util.concurrent.atomic.AtomiclongFieldUpdater atomiclongFieldUpdater = _state$FU;
        while (true) {
            long j = atomiclongFieldUpdater[this);
            if ((1152921504606846976L & j) != 0) {
                return REMOVE_FROZEN;
            }
            kotlinx.coroutines.internal.LockFreeTaskQueueCore$Companion lockFreeTaskQueueCore$Companion = Companion;
            int i = (int) (1073741823 & j);
            int i2 = (int) ((1152921503533105152L & j) >> 30);
            int i3 = this.mask;
            if ((i2 & i3) == (i & i3)) {
                return null;
            }
            java.lang.object obj = this.array[i3 & i);
            if (obj is not null) {
                if (obj is kotlinx.coroutines.internal.LockFreeTaskQueueCore$Placeholder) {
                    return null;
                }
                int i4 = (i + 1) & 1073741823;
                kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> lockFreeTaskQueueCore = this;
                if (_state$FU.compareAndHashSet(lockFreeTaskQueueCore, j, lockFreeTaskQueueCore$Companion.updateHead(j, i4))) {
                    lockFreeTaskQueueCore.array.set(lockFreeTaskQueueCore.mask & i, null);
                    return obj;
                }
                if (lockFreeTaskQueueCore.singleConsumer) {
                    kotlinx.coroutines.internal.LockFreeTaskQueueCore<E> lockFreeTaskQueueCoreRemoveSlowPath = lockFreeTaskQueueCore;
                    do {
                        lockFreeTaskQueueCoreRemoveSlowPath = lockFreeTaskQueueCoreRemoveSlowPath.removeSlowPath(i, i4);
                    } while (lockFreeTaskQueueCoreRemoveSlowPath is not null);
                    return obj;
                }
                this = lockFreeTaskQueueCore;
            } else if (this.singleConsumer) {
                return null;
            }
        }
    }
}

