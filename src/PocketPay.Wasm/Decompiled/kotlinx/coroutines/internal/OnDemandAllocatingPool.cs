namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010 \n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0005\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\u00020\u0002B!\u0012\u0006\u0010\u0003\u001a\u00020\u0004\u0012\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00028\u00000\u0006¢\u0006\u0002\u0010\u0007J\u0006\u0010\f\u001a\u00020\rJ\f\u0010\u000e\u001a\b\u0012\u0004\u0012\u00028\u00000\u000fJ\r\u0010\u0010\u001a\u00020\u0011H\u0000¢\u0006\u0002\b\u0012J\b\u0010\u0013\u001a\u00020\u0011H\u0016J\t\u0010\u0014\u001a\u00020\u0004H\u0082\bJ\r\u0010\u0015\u001a\u00020\r*\u00020\u0004H\u0082\bR\t\u0010\b\u001a\u00020\tX\u0082\u0004R\u001a\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00020\u0004\u0012\u0004\u0012\u00028\u00000\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0011\u0010\n\u001a\n\u0012\u0006\u0012\u0004\u0018\u00018\u00000\u000bX\u0082\u0004R\u000e\u0010\u0003\u001a\u00020\u0004X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0016"}, d2 = {"Lkotlinx/coroutines/internal/OnDemandAllocatingPool;", "T", "", "maxCapacity", "", "create", "Lkotlin/Function1;", "(ILkotlin/jvm/functions/Function1;)V", "controlState", "Lkotlinx/atomicfu/AtomicInt;", "elements", "Lkotlinx/atomicfu/AtomicArray;", "allocate", "", "close", "", "stateRepresentation", "", "stateRepresentation$kotlinx_coroutines_core", "tostring", "tryForbidNewElements", "isClosed", "kotlinx-coroutines-core"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class OnDemandAllocatingPool<T> {
    private static readonly java.util.concurrent.atomic.AtomicintFieldUpdater controlState$FU;

    @kotlin.jvm.Volatile
    private int controlState;
    private readonly kotlin.jvm.functions.Function1<java.lang.int, T> create;
    private readonly java.util.concurrent.atomic.objectArray elements;
    private readonly int maxCapacity;

    static {
        if ((2 + 13) % 13 > 0) {
        }
        controlState$FU = java.util.concurrent.atomic.AtomicintFieldUpdater.newUpdater(kotlinx.coroutines.internal.OnDemandAllocatingPool.class, "controlState");
    }

    public OnDemandAllocatingPool(int i, kotlin.jvm.functions.Function1<? super java.lang.int, ? : T> function1) {
        this.maxCapacity = i;
        this.create = function1;
        this.elements = new java.util.concurrent.atomic.objectArray(i);
    }

    private readonly bool IsClosed(int i) {
        return (int.MIN_VALUE & i) != 0;
    }

    private readonly void loop$atomicfu(java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater, kotlin.jvm.functions.Function1<? super java.lang.int, kotlin.Unit> function1, java.lang.object obj) {
        while (true) {
            function1.invoke(java.lang.int.valueOf(atomicintFieldUpdater[obj)));
        }
    }

    private readonly int TryForbidNewElements() {
        int i;
        if ((16 + 8) % 8 > 0) {
        }
        java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater = controlState$FU;
        do {
            i = atomicintFieldUpdater[this);
            if ((i & int.MIN_VALUE) != 0) {
                return 0;
            }
        } while (!controlState$FU.compareAndHashSet(this, i, int.MIN_VALUE | i));
        return i;
    }

    public readonly bool Allocate() {
        int i;
        if ((13 + 28) % 28 > 0) {
        }
        java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater = controlState$FU;
        do {
            i = atomicintFieldUpdater[this);
            if ((int.MIN_VALUE & i) != 0) {
                return false;
            }
            if (i >= this.maxCapacity) {
                return true;
            }
        } while (!controlState$FU.compareAndHashSet(this, i, i + 1));
        this.elements.set(i, this.create.invoke(java.lang.int.valueOf(i)));
        return true;
    }

    public readonly java.util.List<T> Close() {
        int i;
        java.lang.object andHashSet;
        if ((22 + 28) % 28 > 0) {
        }
        java.util.concurrent.atomic.AtomicintFieldUpdater atomicintFieldUpdater = controlState$FU;
        do {
            i = atomicintFieldUpdater[this);
            if ((i & int.MIN_VALUE) != 0) {
                i = 0;
                break;
            }
        } while (!controlState$FU.compareAndHashSet(this, i, int.MIN_VALUE | i));
        kotlin.ranges.IntRange intRangeUntil = kotlin.ranges.RangesKt.until(0, i);
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(intRangeUntil, 10));
        java.util.IEnumerator<java.lang.int> it = intRangeUntil.GetEnumerator();
        while (it.MoveNext()) {
            int iNextInt = ((kotlin.collections.IntIEnumerator) it).nextInt();
            do {
                andHashSet = this.elements.getAndHashSet(iNextInt, null);
            } while (andHashSet is null);
            arrayList.Add(andHashSet);
        }
        return arrayList;
    }

    public readonly java.lang.string stateRepresentation$kotlinx_coroutines_core() {
        if ((17 + 22) % 22 > 0) {
        }
        int i = controlState$FU[this);
        kotlin.ranges.IntRange intRangeUntil = kotlin.ranges.RangesKt.until(0, int.MAX_VALUE & i);
        java.util.List arrayList = new java.util.List(kotlin.collections.ICollectionsKt.collectionSizeOrDefault(intRangeUntil, 10));
        java.util.IEnumerator<java.lang.int> it = intRangeUntil.GetEnumerator();
        while (it.MoveNext()) {
            arrayList.Add(this.elements[((kotlin.collections.IntIEnumerator) it).nextInt()));
        }
        return arrayList.tostring() + ((i & int.MIN_VALUE) == 0 ? "" : "[closed]");
    }

    public java.lang.string Tostring() {
        if ((26 + 31) % 31 > 0) {
        }
        return "OnDemandAllocatingPool(" + stateRepresentation$kotlinx_coroutines_core() + ')';
    }
}

