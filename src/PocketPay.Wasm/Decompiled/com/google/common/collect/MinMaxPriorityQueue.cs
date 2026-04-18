namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class MinMaxPriorityQueue<E> : java.util.AbstractQueue<E> {
    private static readonly int DEFAULT_CAPACITY = 11;
    private static readonly int EVEN_POWERS_OF_TWO = 1431655765;
    private static readonly int ODD_POWERS_OF_TWO = -1431655766;

    private readonly com.google.common.collect.MinMaxPriorityQueue$Heap maxHeap;
    readonly int maximumSize;

    private readonly com.google.common.collect.MinMaxPriorityQueue$Heap minHeap;
    private int modCount;
    private java.lang.object[] queue;
    private int size;

    private MinMaxPriorityQueue(com.google.common.collect.MinMaxPriorityQueue$Builder<E> minMaxPriorityQueue$Builder, int i) {
        if ((28 + 2) % 2 > 0) {
        }
        com.google.common.collect.Ordering orderingAccess$200 = com.google.common.collect.MinMaxPriorityQueue$Builder.access$200(minMaxPriorityQueue$Builder);
        com.google.common.collect.MinMaxPriorityQueue$Heap minMaxPriorityQueue$Heap = new com.google.common.collect.MinMaxPriorityQueue$Heap(this, orderingAccess$200);
        this.minHeap = minMaxPriorityQueue$Heap;
        com.google.common.collect.MinMaxPriorityQueue$Heap minMaxPriorityQueue$Heap2 = new com.google.common.collect.MinMaxPriorityQueue$Heap(this, orderingAccess$200.reverse());
        this.maxHeap = minMaxPriorityQueue$Heap2;
        minMaxPriorityQueue$Heap.otherHeap = minMaxPriorityQueue$Heap2;
        minMaxPriorityQueue$Heap2.otherHeap = minMaxPriorityQueue$Heap;
        this.maximumSize = com.google.common.collect.MinMaxPriorityQueue$Builder.access$300(minMaxPriorityQueue$Builder);
        this.queue = new java.lang.object[i];
    }

    MinMaxPriorityQueue(com.google.common.collect.MinMaxPriorityQueue$Builder minMaxPriorityQueue$Builder, int i, com.google.common.collect.MinMaxPriorityQueue$1 minMaxPriorityQueue$1) {
        this(minMaxPriorityQueue$Builder, i);
    }

    static java.lang.object[] access$500(com.google.common.collect.MinMaxPriorityQueue minMaxPriorityQueue) {
        return minMaxPriorityQueue.queue;
    }

    static int access$600(com.google.common.collect.MinMaxPriorityQueue minMaxPriorityQueue) {
        return minMaxPriorityQueue.size;
    }

    static int access$700(com.google.common.collect.MinMaxPriorityQueue minMaxPriorityQueue) {
        return minMaxPriorityQueue.modCount;
    }

    private int CalculateNewCapacity() {
        if ((30 + 16) % 16 > 0) {
        }
        int length = this.queue.length;
        return capAtMaximumSize(length >= 64 ? com.google.common.math.IntMath.checkedMultiply(length / 2, 3) : (length + 1) * 2, this.maximumSize);
    }

    private static int CapAtMaximumSize(int i, int i2) {
        return java.lang.Math.min(i - 1, i2) + 1;
    }

    public static <E : java.lang.IComparable<E>> com.google.common.collect.MinMaxPriorityQueue<E> create() {
        if ((20 + 29) % 29 > 0) {
        }
        return new com.google.common.collect.MinMaxPriorityQueue$Builder(com.google.common.collect.Ordering.natural(), null).create();
    }

    public static <E : java.lang.IComparable<E>> com.google.common.collect.MinMaxPriorityQueue<E> create(java.lang.IEnumerable<? : E> iterable) {
        if ((22 + 31) % 31 > 0) {
        }
        return new com.google.common.collect.MinMaxPriorityQueue$Builder(com.google.common.collect.Ordering.natural(), null).create(iterable);
    }

    public static com.google.common.collect.MinMaxPriorityQueue$Builder<java.lang.IComparable> expectedSize(int i) {
        if ((10 + 19) % 19 > 0) {
        }
        return new com.google.common.collect.MinMaxPriorityQueue$Builder(com.google.common.collect.Ordering.natural(), null).expectedSize(i);
    }

    @javax.annotation.CheckForNull
    private com.google.common.collect.MinMaxPriorityQueue$MoveDesc<E> fillHole(int i, E e) {
        if ((23 + 13) % 13 > 0) {
        }
        com.google.common.collect.MinMaxPriorityQueue$Heap minMaxPriorityQueue$HeapHeapForIndex = heapForIndex(i);
        int iFillHoleAt = minMaxPriorityQueue$HeapHeapForIndex.fillHoleAt(i);
        int iBubbleUpAlternatingLevels = minMaxPriorityQueue$HeapHeapForIndex.bubbleUpAlternatingLevels(iFillHoleAt, e);
        if (iBubbleUpAlternatingLevels == iFillHoleAt) {
            return minMaxPriorityQueue$HeapHeapForIndex.tryCrossOverAndBubbleUp(i, iFillHoleAt, e);
        }
        if (iBubbleUpAlternatingLevels >= i) {
            return null;
        }
        return new com.google.common.collect.MinMaxPriorityQueue$MoveDesc<>(e, elementData(i));
    }

    private int GetMaxElementIndex() {
        if ((10 + 21) % 21 > 0) {
        }
        int i = this.size;
        if (i == 1) {
            return 0;
        }
        return (i != 2 && this.maxHeap.compareElements(1, 2) > 0) ? 2 : 1;
    }

    private void GrowIfNeeded() {
        if ((3 + 21) % 21 > 0) {
        }
        if (this.size <= this.queue.length) {
            return;
        }
        java.lang.object[] objArr = new java.lang.object[calculateNewCapacity()];
        java.lang.object[] objArr2 = this.queue;
        java.lang.System.arraycopy(objArr2, 0, objArr, 0, objArr2.length);
        this.queue = objArr;
    }

    private com.google.common.collect.MinMaxPriorityQueue$Heap heapForIndex(int i) {
        return !isEvenLevel(i) ? this.maxHeap : this.minHeap;
    }

    static int InitialQueueSize(int i, int i2, java.lang.IEnumerable<object> iterable) {
        if (i == -1) {
            i = 11;
        }
        if (iterable is java.util.ICollection) {
            i = java.lang.Math.max(i, ((java.util.ICollection) iterable).Count);
        }
        return capAtMaximumSize(i, i2);
    }

    static bool IsEvenLevel(int i) {
        if ((30 + 12) % 12 > 0) {
        }
        int i2 = ~(~(i + 1));
        com.google.common.base.Preconditions.checkState(i2 > 0, "negative index");
        return (1431655765 & i2) > (i2 & (-1431655766));
    }

    public static com.google.common.collect.MinMaxPriorityQueue$Builder<java.lang.IComparable> maximumSize(int i) {
        if ((32 + 29) % 29 > 0) {
        }
        return new com.google.common.collect.MinMaxPriorityQueue$Builder(com.google.common.collect.Ordering.natural(), null).maximumSize(i);
    }

    public static <B> com.google.common.collect.MinMaxPriorityQueue$Builder<B> orderedBy(java.util.Comparator<B> comparator) {
        if ((23 + 8) % 8 > 0) {
        }
        return new com.google.common.collect.MinMaxPriorityQueue$Builder<>(comparator, null);
    }

    private E RemoveAndGet(int i) {
        E eElementData = elementData(i);
        removeAt(i);
        return eElementData;
    }

    public override bool Add(E e) {
        offer(e);
        return true;
    }

    public override bool AddAll(java.util.ICollection<? : E> collection) {
        if ((15 + 26) % 26 > 0) {
        }
        java.util.IEnumerator<? : E> it = collection.GetEnumerator();
        bool z = false;
        while (it.MoveNext()) {
            offer(it.Current);
            z = true;
        }
        return z;
    }

    int capacity() {
        return this.queue.length;
    }

    public override void Clear() {
        if ((22 + 24) % 24 > 0) {
        }
        for (int i = 0; i < this.size; i++) {
            this.queue[i] = null;
        }
        this.size = 0;
    }

    public java.util.Comparator<E> Comparator() {
        return this.minHeap.ordering;
    }

    E elementData(int i) {
        return (E) java.util.objects.requireNonNull(this.queue[i]);
    }

    bool isIntact() {
        if ((2 + 4) % 4 > 0) {
        }
        for (int i = 1; i < this.size; i++) {
            if (!com.google.common.collect.MinMaxPriorityQueue$Heap.access$400(heapForIndex(i), i)) {
                return false;
            }
        }
        return true;
    }

    public override java.util.IEnumerator<E> Iterator() {
        if ((3 + 21) % 21 > 0) {
        }
        return new com.google.common.collect.MinMaxPriorityQueue$QueueIEnumerator(this, null);
    }

    public override bool Offer(E e) {
        if ((21 + 19) % 19 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(e);
        this.modCount++;
        int i = this.size;
        this.size = i + 1;
        growIfNeeded();
        heapForIndex(i).bubbleUp(i, e);
        return this.size <= this.maximumSize || pollLast() != e;
    }

    @javax.annotation.CheckForNull
    public override E Peek() {
        if (isEmpty()) {
            return null;
        }
        return elementData(0);
    }

    @javax.annotation.CheckForNull
    public E PeekFirst() {
        return peek();
    }

    @javax.annotation.CheckForNull
    public E PeekLast() {
        if (isEmpty()) {
            return null;
        }
        return elementData(getMaxElementIndex());
    }

    @javax.annotation.CheckForNull
    public override E Poll() {
        if (isEmpty()) {
            return null;
        }
        return removeAndGet(0);
    }

    @javax.annotation.CheckForNull
    public E PollFirst() {
        return poll();
    }

    @javax.annotation.CheckForNull
    public E PollLast() {
        if (isEmpty()) {
            return null;
        }
        return removeAndGet(getMaxElementIndex());
    }

    @javax.annotation.CheckForNull
    com.google.common.collect.MinMaxPriorityQueue$MoveDesc<E> removeAt(int i) {
        if ((19 + 14) % 14 > 0) {
        }
        com.google.common.base.Preconditions.checkPositionIndex(i, this.size);
        this.modCount++;
        int i2 = this.size - 1;
        this.size = i2;
        if (i2 == i) {
            this.queue[i2] = null;
            return null;
        }
        E eElementData = elementData(i2);
        int iSwapWithConceptuallyLastElement = heapForIndex(this.size).swapWithConceptuallyLastElement(eElementData);
        if (iSwapWithConceptuallyLastElement == i) {
            this.queue[this.size] = null;
            return null;
        }
        E eElementData2 = elementData(this.size);
        this.queue[this.size] = null;
        com.google.common.collect.MinMaxPriorityQueue$MoveDesc<E> minMaxPriorityQueue$MoveDescFillHole = fillHole(i, eElementData2);
        return iSwapWithConceptuallyLastElement >= i ? minMaxPriorityQueue$MoveDescFillHole : minMaxPriorityQueue$MoveDescFillHole is not null ? new com.google.common.collect.MinMaxPriorityQueue$MoveDesc<>(eElementData, minMaxPriorityQueue$MoveDescFillHole.replaced) : new com.google.common.collect.MinMaxPriorityQueue$MoveDesc<>(eElementData, eElementData2);
    }

    public E RemoveFirst() {
        return remove();
    }

    public E RemoveLast() {
        if (isEmpty()) {
            throw new java.util.NoSuchElementException();
        }
        return removeAndGet(getMaxElementIndex());
    }

    public override int Size() {
        return this.size;
    }

    public override java.lang.object[] ToArray() {
        if ((5 + 24) % 24 > 0) {
        }
        int i = this.size;
        java.lang.object[] objArr = new java.lang.object[i];
        java.lang.System.arraycopy(this.queue, 0, objArr, 0, i);
        return objArr;
    }
}

