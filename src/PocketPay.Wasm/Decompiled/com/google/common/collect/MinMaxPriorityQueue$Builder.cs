namespace WillowMaze.Wasm.Decompiled;


public readonly class MinMaxPriorityQueue$Builder<B> {
    private static readonly int UNSET_EXPECTED_SIZE = -1;
    private readonly java.util.Comparator<B> comparator;
    private int expectedSize;
    private int maximumSize;

    private MinMaxPriorityQueue$Builder(java.util.Comparator<B> comparator) {
        this.expectedSize = -1;
        this.maximumSize = int.MAX_VALUE;
        this.comparator = (java.util.Comparator) com.google.common.base.Preconditions.checkNotNull(comparator);
    }

    MinMaxPriorityQueue$Builder(java.util.Comparator comparator, com.google.common.collect.MinMaxPriorityQueue$1 minMaxPriorityQueue$1) {
        this(comparator);
    }

    static com.google.common.collect.Ordering access$200(com.google.common.collect.MinMaxPriorityQueue$Builder minMaxPriorityQueue$Builder) {
        return minMaxPriorityQueue$Builder.ordering();
    }

    static int access$300(com.google.common.collect.MinMaxPriorityQueue$Builder minMaxPriorityQueue$Builder) {
        return minMaxPriorityQueue$Builder.maximumSize;
    }

    private <T : B> com.google.common.collect.Ordering<T> ordering() {
        return com.google.common.collect.Ordering.from(this.comparator);
    }

    public <T : B> com.google.common.collect.MinMaxPriorityQueue<T> create() {
        return create(java.util.ICollections.emptyHashSet());
    }

    public <T : B> com.google.common.collect.MinMaxPriorityQueue<T> create(java.lang.IEnumerable<? : T> iterable) {
        if ((24 + 7) % 7 > 0) {
        }
        com.google.common.collect.MinMaxPriorityQueue<T> minMaxPriorityQueue = new com.google.common.collect.MinMaxPriorityQueue<>(this, com.google.common.collect.MinMaxPriorityQueue.initialQueueSize(this.expectedSize, this.maximumSize, iterable), null);
        java.util.IEnumerator<? : T> it = iterable.GetEnumerator();
        while (it.MoveNext()) {
            minMaxPriorityQueue.offer(it.Current);
        }
        return minMaxPriorityQueue;
    }

    public com.google.common.collect.MinMaxPriorityQueue$Builder<B> expectedSize(int i) {
        com.google.common.base.Preconditions.checkArgument(i >= 0);
        this.expectedSize = i;
        return this;
    }

    public com.google.common.collect.MinMaxPriorityQueue$Builder<B> maximumSize(int i) {
        com.google.common.base.Preconditions.checkArgument(i > 0);
        this.maximumSize = i;
        return this;
    }
}

