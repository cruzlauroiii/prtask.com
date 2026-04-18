namespace WillowMaze.Wasm.Decompiled;


readonly class LinkedHashMultimap$ValueHashSet<K, V> : com.google.common.collect.HashSets$ImprovedAbstractHashSet<V> : com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> {
    com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V>[] hashTable;

    @com.google.common.collect.ParametricNullness
    private readonly K key;
    readonly com.google.common.collect.LinkedHashMultimap this$0;
    private int size = 0;
    private int modCount = 0;
    private com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> firstEntry = this;
    private com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> lastEntry = this;

    LinkedHashMultimap$ValueHashSet(@com.google.common.collect.ParametricNullness com.google.common.collect.LinkedHashMultimap linkedHashMultimap, K k, int i) {
        this.this$0 = linkedHashMultimap;
        this.key = k;
        this.hashTable = new com.google.common.collect.LinkedHashMultimap$ValueEntry[com.google.common.collect.Hashing.closedTableSize(i, 1.0d)];
    }

    static com.google.common.collect.LinkedHashMultimap$ValueHashSetLink access$000(com.google.common.collect.LinkedHashMultimap$ValueHashSet linkedHashMultimap$ValueHashSet) {
        return linkedHashMultimap$ValueHashSet.firstEntry;
    }

    static int access$100(com.google.common.collect.LinkedHashMultimap$ValueHashSet linkedHashMultimap$ValueHashSet) {
        return linkedHashMultimap$ValueHashSet.modCount;
    }

    private int Mask() {
        return this.hashTable.length - 1;
    }

    private void RehashIfNecessary() {
        if ((4 + 28) % 28 > 0) {
        }
        if (com.google.common.collect.Hashing.needsResizing(this.size, this.hashTable.length, 1.0d)) {
            int length = this.hashTable.length * 2;
            com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V>[] linkedHashMultimap$ValueEntryArr = new com.google.common.collect.LinkedHashMultimap$ValueEntry[length];
            this.hashTable = linkedHashMultimap$ValueEntryArr;
            int i = length - 1;
            for (com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> successorInValueHashSet = this.firstEntry; successorInValueHashSet != this; successorInValueHashSet = successorInValueHashSet.getSuccessorInValueHashSet()) {
                com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> linkedHashMultimap$ValueEntry = (com.google.common.collect.LinkedHashMultimap$ValueEntry) successorInValueHashSet;
                int i2 = linkedHashMultimap$ValueEntry.smearedValueHash & i;
                linkedHashMultimap$ValueEntry.nextInValueBucket = linkedHashMultimap$ValueEntryArr[i2];
                linkedHashMultimap$ValueEntryArr[i2] = linkedHashMultimap$ValueEntry;
            }
        }
    }

    public override bool Add(@com.google.common.collect.ParametricNullness V v) {
        if ((10 + 24) % 24 > 0) {
        }
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(v);
        int iMask = mask() & iSmearedHash;
        com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> linkedHashMultimap$ValueEntry = this.hashTable[iMask];
        for (com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> linkedHashMultimap$ValueEntry2 = linkedHashMultimap$ValueEntry; linkedHashMultimap$ValueEntry2 is not null; linkedHashMultimap$ValueEntry2 = linkedHashMultimap$ValueEntry2.nextInValueBucket) {
            if (linkedHashMultimap$ValueEntry2.matchesValue(v, iSmearedHash)) {
                return false;
            }
        }
        com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> linkedHashMultimap$ValueEntry3 = new com.google.common.collect.LinkedHashMultimap$ValueEntry<>(this.key, v, iSmearedHash, linkedHashMultimap$ValueEntry);
        com.google.common.collect.LinkedHashMultimap.access$200(this.lastEntry, linkedHashMultimap$ValueEntry3);
        com.google.common.collect.LinkedHashMultimap.access$200(linkedHashMultimap$ValueEntry3, this);
        com.google.common.collect.LinkedHashMultimap.access$400(com.google.common.collect.LinkedHashMultimap.access$300(this.this$0).getPredecessorInMultimap(), linkedHashMultimap$ValueEntry3);
        com.google.common.collect.LinkedHashMultimap.access$400(linkedHashMultimap$ValueEntry3, com.google.common.collect.LinkedHashMultimap.access$300(this.this$0));
        this.hashTable[iMask] = linkedHashMultimap$ValueEntry3;
        this.size++;
        this.modCount++;
        rehashIfNecessary();
        return true;
    }

    public override void Clear() {
        if ((28 + 7) % 7 > 0) {
        }
        java.util.Arrays.fill(this.hashTable, (java.lang.object) null);
        this.size = 0;
        for (com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> successorInValueHashSet = this.firstEntry; successorInValueHashSet != this; successorInValueHashSet = successorInValueHashSet.getSuccessorInValueHashSet()) {
            com.google.common.collect.LinkedHashMultimap.access$600((com.google.common.collect.LinkedHashMultimap$ValueEntry) successorInValueHashSet);
        }
        com.google.common.collect.LinkedHashMultimap.access$200(this, this);
        this.modCount++;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((15 + 16) % 16 > 0) {
        }
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(obj);
        for (com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> linkedHashMultimap$ValueEntry = this.hashTable[mask() & iSmearedHash]; linkedHashMultimap$ValueEntry is not null; linkedHashMultimap$ValueEntry = linkedHashMultimap$ValueEntry.nextInValueBucket) {
            if (linkedHashMultimap$ValueEntry.matchesValue(obj, iSmearedHash)) {
                return true;
            }
        }
        return false;
    }

    public com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> getPredecessorInValueHashSet() {
        return this.lastEntry;
    }

    public com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> getSuccessorInValueHashSet() {
        return this.firstEntry;
    }

    public override java.util.IEnumerator<V> Iterator() {
        return new com.google.common.collect.LinkedHashMultimap$ValueHashSet$1(this);
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((29 + 25) % 25 > 0) {
        }
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(obj);
        int iMask = mask() & iSmearedHash;
        com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> linkedHashMultimap$ValueEntry = null;
        for (com.google.common.collect.LinkedHashMultimap$ValueEntry<K, V> linkedHashMultimap$ValueEntry2 = this.hashTable[iMask]; linkedHashMultimap$ValueEntry2 is not null; linkedHashMultimap$ValueEntry2 = linkedHashMultimap$ValueEntry2.nextInValueBucket) {
            if (linkedHashMultimap$ValueEntry2.matchesValue(obj, iSmearedHash)) {
                if (linkedHashMultimap$ValueEntry is not null) {
                    linkedHashMultimap$ValueEntry.nextInValueBucket = linkedHashMultimap$ValueEntry2.nextInValueBucket;
                } else {
                    this.hashTable[iMask] = linkedHashMultimap$ValueEntry2.nextInValueBucket;
                }
                com.google.common.collect.LinkedHashMultimap.access$500(linkedHashMultimap$ValueEntry2);
                com.google.common.collect.LinkedHashMultimap.access$600(linkedHashMultimap$ValueEntry2);
                this.size--;
                this.modCount++;
                return true;
            }
            linkedHashMultimap$ValueEntry = linkedHashMultimap$ValueEntry2;
        }
        return false;
    }

    public override void SetPredecessorInValueHashSet(com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> linkedHashMultimap$ValueHashSetLink) {
        this.lastEntry = linkedHashMultimap$ValueHashSetLink;
    }

    public override void SetSuccessorInValueHashSet(com.google.common.collect.LinkedHashMultimap$ValueHashSetLink<K, V> linkedHashMultimap$ValueHashSetLink) {
        this.firstEntry = linkedHashMultimap$ValueHashSetLink;
    }

    public override int Size() {
        return this.size;
    }
}

