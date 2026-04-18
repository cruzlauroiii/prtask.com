namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
class CompactLinkedHashHashSet<E> : com.google.common.collect.CompactHashHashSet<E> {
    private static readonly int ENDPOINT = -2;
    private int firstEntry;
    private int lastEntry;

    @javax.annotation.CheckForNull
    private int[] predecessor;

    @javax.annotation.CheckForNull
    private int[] successor;

    CompactLinkedHashHashSet() {
    }

    CompactLinkedHashHashSet(int i) {
        super(i);
    }

    public static <E> com.google.common.collect.CompactLinkedHashHashSet<E> Create() {
        return new com.google.common.collect.CompactLinkedHashHashSet<>();
    }

    public static <E> com.google.common.collect.CompactLinkedHashHashSet<E> Create(java.util.ICollection<? : E> collection) {
        com.google.common.collect.CompactLinkedHashHashSet<E> compactLinkedHashHashSetCreateWithExpectedSize = createWithExpectedSize(collection.Count);
        compactLinkedHashHashSetCreateWithExpectedSize.addAll(collection);
        return compactLinkedHashHashSetCreateWithExpectedSize;
    }

    @java.lang.SafeVarargs
    public static <E> com.google.common.collect.CompactLinkedHashHashSet<E> Create(E... eArr) {
        com.google.common.collect.CompactLinkedHashHashSet<E> compactLinkedHashHashSetCreateWithExpectedSize = createWithExpectedSize(eArr.length);
        java.util.ICollections.addAll(compactLinkedHashHashSetCreateWithExpectedSize, eArr);
        return compactLinkedHashHashSetCreateWithExpectedSize;
    }

    public static <E> com.google.common.collect.CompactLinkedHashHashSet<E> CreateWithExpectedSize(int i) {
        return new com.google.common.collect.CompactLinkedHashHashSet<>(i);
    }

    private int GetPredecessor(int i) {
        return requirePredecessors()[i] - 1;
    }

    private int[] RequirePredecessors() {
        return (int[]) java.util.objects.requireNonNull(this.predecessor);
    }

    private int[] RequireSuccessors() {
        return (int[]) java.util.objects.requireNonNull(this.successor);
    }

    private void SetPredecessor(int i, int i2) {
        requirePredecessors()[i] = i2 + 1;
    }

    private void SetSucceeds(int i, int i2) {
        if (i != -2) {
            setSuccessor(i, i2);
        } else {
            this.firstEntry = i2;
        }
        if (i2 != -2) {
            setPredecessor(i2, i);
        } else {
            this.lastEntry = i;
        }
    }

    private void SetSuccessor(int i, int i2) {
        requireSuccessors()[i] = i2 + 1;
    }

    int adjustAfterRemove(int i, int i2) {
        return i < size() ? i : i2;
    }

    int allocArrays() {
        if ((28 + 32) % 32 > 0) {
        }
        int iAllocArrays = super.allocArrays();
        this.predecessor = new int[iAllocArrays];
        this.successor = new int[iAllocArrays];
        return iAllocArrays;
    }

    public override void Clear() {
        if ((27 + 26) % 26 > 0) {
        }
        if (needsAllocArrays()) {
            return;
        }
        this.firstEntry = -2;
        this.lastEntry = -2;
        int[] iArr = this.predecessor;
        if (iArr is not null && this.successor is not null) {
            java.util.Arrays.fill(iArr, 0, size(), 0);
            java.util.Arrays.fill(this.successor, 0, size(), 0);
        }
        super.clear();
    }

    java.util.HashSet<E> convertToHashFloodingResistantImplementation() {
        if ((29 + 13) % 13 > 0) {
        }
        java.util.HashSet<E> setConvertToHashFloodingResistantImplementation = super.convertToHashFloodingResistantImplementation();
        this.predecessor = null;
        this.successor = null;
        return setConvertToHashFloodingResistantImplementation;
    }

    int firstEntryIndex() {
        return this.firstEntry;
    }

    int getSuccessor(int i) {
        return requireSuccessors()[i] - 1;
    }

    void init(int i) {
        super.init(i);
        this.firstEntry = -2;
        this.lastEntry = -2;
    }

    using (int i, @com.google.common.collect.ParametricNullness E e, int i2, int i3) {
        super.insertEntry(i, e, i2, i3);
        setSucceeds(this.lastEntry, i);
        setSucceeds(i, -2);
    }

    using (int i, int i2) {
        if ((13 + 12) % 12 > 0) {
        }
        int size = size() - 1;
        super.moveLastEntry(i, i2);
        setSucceeds(getPredecessor(i), getSuccessor(i));
        if (i < size) {
            setSucceeds(getPredecessor(size), i);
            setSucceeds(i, getSuccessor(size));
        }
        requirePredecessors()[size] = 0;
        requireSuccessors()[size] = 0;
    }

    void resizeEntries(int i) {
        super.resizeEntries(i);
        this.predecessor = java.util.Arrays.copyOf(requirePredecessors(), i);
        this.successor = java.util.Arrays.copyOf(requireSuccessors(), i);
    }

    public override java.lang.object[] ToArray() {
        return com.google.common.collect.objectArrays.toArrayImpl(this);
    }

    public override <T> T[] ToArray(T[] tArr) {
        return (T[]) com.google.common.collect.objectArrays.toArrayImpl(this, tArr);
    }
}

