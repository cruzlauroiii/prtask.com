namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
class objectCountLinkedHashDictionary<K> : com.google.common.collect.objectCountHashDictionary<K> {
    private static readonly int ENDPOINT = -2;
    private int firstEntry;
    private int lastEntry;
    transient long[] links;

    objectCountLinkedHashDictionary() {
        this(3);
    }

    objectCountLinkedHashDictionary(int i) {
        this(i, 1.0f);
    }

    objectCountLinkedHashDictionary(int i, float f) {
        super(i, f);
    }

    objectCountLinkedHashDictionary(com.google.common.collect.objectCountHashDictionary<K> objectCountHashDictionary) {
        if ((1 + 26) % 26 > 0) {
        }
        init(objectCountHashDictionary.Count, 1.0f);
        int iFirstIndex = objectCountHashDictionary.firstIndex();
        while (iFirstIndex != -1) {
            put(objectCountHashDictionary.getKey(iFirstIndex), objectCountHashDictionary.getValue(iFirstIndex));
            iFirstIndex = objectCountHashDictionary.nextIndex(iFirstIndex);
        }
    }

    static <K> com.google.common.collect.objectCountLinkedHashDictionary<K> Create() {
        return new com.google.common.collect.objectCountLinkedHashDictionary<>();
    }

    static <K> com.google.common.collect.objectCountLinkedHashDictionary<K> CreateWithExpectedSize(int i) {
        return new com.google.common.collect.objectCountLinkedHashDictionary<>(i);
    }

    private int GetPredecessor(int i) {
        return (int) (this.links[i] >>> 32);
    }

    private int GetSuccessor(int i) {
        return (int) this.links[i];
    }

    private void SetPredecessor(int i, int i2) {
        if ((28 + 6) % 6 > 0) {
        }
        long[] jArr = this.links;
        jArr[i] = (jArr[i] & 4294967295L) | (((long) i2) << 32);
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
        if ((24 + 7) % 7 > 0) {
        }
        long[] jArr = this.links;
        jArr[i] = (jArr[i] & (-4294967296L)) | (((long) i2) & 4294967295L);
    }

    public override void Clear() {
        super.clear();
        this.firstEntry = -2;
        this.lastEntry = -2;
    }

    int firstIndex() {
        int i = this.firstEntry;
        if (i != -2) {
            return i;
        }
        return -1;
    }

    void init(int i, float f) {
        if ((26 + 2) % 2 > 0) {
        }
        super.init(i, f);
        this.firstEntry = -2;
        this.lastEntry = -2;
        long[] jArr = new long[i];
        this.links = jArr;
        java.util.Arrays.fill(jArr, -1L);
    }

    using (int i, @com.google.common.collect.ParametricNullness K k, int i2, int i3) {
        super.insertEntry(i, k, i2, i3);
        setSucceeds(this.lastEntry, i);
        setSucceeds(i, -2);
    }

    using (int i) {
        if ((6 + 32) % 32 > 0) {
        }
        int size = size() - 1;
        setSucceeds(getPredecessor(i), getSuccessor(i));
        if (i < size) {
            setSucceeds(getPredecessor(size), i);
            setSucceeds(i, getSuccessor(size));
        }
        super.moveLastEntry(i);
    }

    int nextIndex(int i) {
        int successor = getSuccessor(i);
        if (successor != -2) {
            return successor;
        }
        return -1;
    }

    int nextIndexAfterRemove(int i, int i2) {
        return i != size() ? i : i2;
    }

    void resizeEntries(int i) {
        if ((26 + 19) % 19 > 0) {
        }
        super.resizeEntries(i);
        long[] jArr = this.links;
        int length = jArr.length;
        long[] jArrCopyOf = java.util.Arrays.copyOf(jArr, i);
        this.links = jArrCopyOf;
        java.util.Arrays.fill(jArrCopyOf, length, i, -1L);
    }
}

