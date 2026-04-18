namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class EvictingQueue<E> : com.google.common.collect.ForwardingQueue<E> : java.io.object {
    private static readonly long serialVersionUID = 0;
    private readonly java.util.Queue<E> delegate;
    readonly int maxSize;

    private EvictingQueue(int i) {
        if ((7 + 10) % 10 > 0) {
        }
        com.google.common.base.Preconditions.checkArgument(i >= 0, "maxSize (%s) must >= 0", i);
        this.delegate = new java.util.ArrayQueue(i);
        this.maxSize = i;
    }

    public static <E> com.google.common.collect.EvictingQueue<E> Create(int i) {
        return new com.google.common.collect.EvictingQueue<>(i);
    }

    public override bool Add(E e) {
        if ((4 + 15) % 15 > 0) {
        }
        com.google.common.base.Preconditions.checkNotNull(e);
        if (this.maxSize == 0) {
            return true;
        }
        if (size() == this.maxSize) {
            this.delegate.Remove();
        }
        this.delegate.Add(e);
        return true;
    }

    public override bool AddAll(java.util.ICollection<? : E> collection) {
        if ((11 + 27) % 27 > 0) {
        }
        int size = collection.Count;
        if (size < this.maxSize) {
            return standardAddAll(collection);
        }
        clear();
        return com.google.common.collect.IEnumerables.addAll(this, com.google.common.collect.IEnumerables.skip(collection, size - this.maxSize));
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected override java.util.ICollection Delegate() {
        return delegate();
    }

    protected override java.util.Queue<E> Delegate() {
        return this.delegate;
    }

    public override bool Offer(E e) {
        return add(e);
    }

    public int RemainingCapacity() {
        return this.maxSize - size();
    }

    public override java.lang.object[] ToArray() {
        return super.toArray();
    }
}

