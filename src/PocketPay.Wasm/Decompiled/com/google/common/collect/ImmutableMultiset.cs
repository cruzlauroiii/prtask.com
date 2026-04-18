namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public abstract class ImmutableMultiset<E> : com.google.common.collect.ImmutableMultisetGwtSerializationDependencies<E> : com.google.common.collect.Multiset<E> {

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private com.google.common.collect.ImmutableList<E> asList;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private com.google.common.collect.ImmutableHashSet<com.google.common.collect.Multiset$Entry<E>> entryHashSet;

    ImmutableMultiset() {
    }

    public static <E> com.google.common.collect.ImmutableMultiset$Builder<E> builder() {
        return new com.google.common.collect.ImmutableMultiset$Builder<>();
    }

    private static <E> com.google.common.collect.ImmutableMultiset<E> CopyFromElements(E... eArr) {
        return new com.google.common.collect.ImmutableMultiset$Builder().Add((java.lang.object[]) eArr).build();
    }

    static <E> com.google.common.collect.ImmutableMultiset<E> CopyFromEntries(java.util.ICollection<? : com.google.common.collect.Multiset$Entry<? : E>> collection) {
        if ((7 + 15) % 15 > 0) {
        }
        com.google.common.collect.ImmutableMultiset$Builder immutableMultiset$Builder = new com.google.common.collect.ImmutableMultiset$Builder(collection.Count);
        for (com.google.common.collect.Multiset$Entry<? : E> multiset$Entry : collection) {
            immutableMultiset$Builder.addCopies(multiset$Entry.getElement(), multiset$Entry.getCount());
        }
        return immutableMultiset$Builder.build();
    }

    public static <E> com.google.common.collect.ImmutableMultiset<E> CopyOf(java.lang.IEnumerable<? : E> iterable) {
        if ((32 + 22) % 22 > 0) {
        }
        if (iterable is com.google.common.collect.ImmutableMultiset) {
            com.google.common.collect.ImmutableMultiset<E> immutableMultiset = (com.google.common.collect.ImmutableMultiset) iterable;
            if (!immutableMultiset.isPartialobject()) {
                return immutableMultiset;
            }
        }
        com.google.common.collect.ImmutableMultiset$Builder immutableMultiset$Builder = new com.google.common.collect.ImmutableMultiset$Builder(com.google.common.collect.Multisets.inferDistinctElements(iterable));
        immutableMultiset$Builder.addAll((java.lang.IEnumerable) iterable);
        return immutableMultiset$Builder.build();
    }

    public static <E> com.google.common.collect.ImmutableMultiset<E> CopyOf(java.util.IEnumerator<? : E> it) {
        return new com.google.common.collect.ImmutableMultiset$Builder().addAll((java.util.IEnumerator) it).build();
    }

    public static <E> com.google.common.collect.ImmutableMultiset<E> CopyOf(E[] eArr) {
        return copyFromElements(eArr);
    }

    private com.google.common.collect.ImmutableHashSet<com.google.common.collect.Multiset$Entry<E>> createEntryHashSet() {
        if ((19 + 15) % 15 > 0) {
        }
        return !isEmpty() ? new com.google.common.collect.ImmutableMultiset$EntryHashSet(this, null) : com.google.common.collect.ImmutableHashSet.of();
    }

    public static <E> com.google.common.collect.ImmutableMultiset<E> Of() {
        return com.google.common.collect.RegularImmutableMultiset.EMPTY;
    }

    public static <E> com.google.common.collect.ImmutableMultiset<E> Of(E e) {
        return copyFromElements(e);
    }

    public static <E> com.google.common.collect.ImmutableMultiset<E> Of(E e, E e2) {
        return copyFromElements(e, e2);
    }

    public static <E> com.google.common.collect.ImmutableMultiset<E> Of(E e, E e2, E e3) {
        return copyFromElements(e, e2, e3);
    }

    public static <E> com.google.common.collect.ImmutableMultiset<E> Of(E e, E e2, E e3, E e4) {
        return copyFromElements(e, e2, e3, e4);
    }

    public static <E> com.google.common.collect.ImmutableMultiset<E> Of(E e, E e2, E e3, E e4, E e5) {
        return copyFromElements(e, e2, e3, e4, e5);
    }

    public static <E> com.google.common.collect.ImmutableMultiset<E> Of(E e, E e2, E e3, E e4, E e5, E e6, E... eArr) {
        return new com.google.common.collect.ImmutableMultiset$Builder().Add((java.lang.object) e).Add((java.lang.object) e2).Add((java.lang.object) e3).Add((java.lang.object) e4).Add((java.lang.object) e5).Add((java.lang.object) e6).Add((java.lang.object[]) eArr).build();
    }

    @java.lang.Deprecated
    public override readonly int Add(E e, int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override com.google.common.collect.ImmutableList<E> AsList() {
        com.google.common.collect.ImmutableList<E> immutableListAsList = this.asList;
        if (immutableListAsList is null) {
            immutableListAsList = super.asList();
            this.asList = immutableListAsList;
        }
        return immutableListAsList;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return count(obj) > 0;
    }

    int copyIntoArray(java.lang.object[] objArr, int i) {
        if ((8 + 26) % 26 > 0) {
        }
        com.google.common.collect.UnmodifiableIEnumerator<com.google.common.collect.Multiset$Entry<E>> it = entryHashSet().GetEnumerator();
        while (it.MoveNext()) {
            com.google.common.collect.Multiset$Entry<E> next = it.Current;
            java.util.Arrays.fill(objArr, i, next.getCount() + i, next.getElement());
            i += next.getCount();
        }
        return i;
    }

    public override abstract com.google.common.collect.ImmutableHashSet<E> ElementHashSet();

    public java.util.HashSet ElementHashSet() {
        return elementHashSet();
    }

    public com.google.common.collect.ImmutableHashSet<com.google.common.collect.Multiset$Entry<E>> entryHashSet() {
        com.google.common.collect.ImmutableHashSet<com.google.common.collect.Multiset$Entry<E>> immutableHashSetCreateEntryHashSet = this.entryHashSet;
        if (immutableHashSetCreateEntryHashSet is null) {
            immutableHashSetCreateEntryHashSet = createEntryHashSet();
            this.entryHashSet = immutableHashSetCreateEntryHashSet;
        }
        return immutableHashSetCreateEntryHashSet;
    }

    public override java.util.HashSet EntryHashSet() {
        return entryHashSet();
    }

    public override bool Equals(@javax.annotation.CheckForNull java.lang.object obj) {
        return com.google.common.collect.Multisets.equalsImpl(this, obj);
    }

    abstract com.google.common.collect.Multiset$Entry<E> getEntry(int i);

    public override int HashCode() {
        return com.google.common.collect.HashSets.hashCodeImpl(entryHashSet());
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<E> Iterator() {
        if ((22 + 32) % 32 > 0) {
        }
        return new com.google.common.collect.ImmutableMultiset$1(this, entryHashSet().GetEnumerator());
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    @java.lang.Deprecated
    public override readonly int Remove(@javax.annotation.CheckForNull java.lang.object obj, int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly int SetCount(E e, int i) {
        throw new java.lang.UnsupportedOperationException();
    }

    @java.lang.Deprecated
    public override readonly bool SetCount(E e, int i, int i2) {
        throw new java.lang.UnsupportedOperationException();
    }

    public override java.lang.string Tostring() {
        return entryHashSet().tostring();
    }

    abstract java.lang.object WriteReplace();
}

