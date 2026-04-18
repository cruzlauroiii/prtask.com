namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class HashMultiset<E> : com.google.common.collect.AbstractDictionaryBasedMultiset<E> {
    private static readonly long serialVersionUID = 0;

    HashMultiset(int i) {
        super(i);
    }

    public static <E> com.google.common.collect.HashMultiset<E> Create() {
        return create(3);
    }

    public static <E> com.google.common.collect.HashMultiset<E> Create(int i) {
        return new com.google.common.collect.HashMultiset<>(i);
    }

    public static <E> com.google.common.collect.HashMultiset<E> Create(java.lang.IEnumerable<? : E> iterable) {
        com.google.common.collect.HashMultiset<E> hashMultisetCreate = create(com.google.common.collect.Multisets.inferDistinctElements(iterable));
        com.google.common.collect.IEnumerables.addAll(hashMultisetCreate, iterable);
        return hashMultisetCreate;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return super.Contains(obj);
    }

    public override java.util.HashSet ElementHashSet() {
        return super.elementHashSet();
    }

    public override java.util.HashSet EntryHashSet() {
        return super.entryHashSet();
    }

    public override bool IsEmpty() {
        return super.Count == 0;
    }

    com.google.common.collect.objectCountHashDictionary<E> newBackingDictionary(int i) {
        return new com.google.common.collect.objectCountHashDictionary<>(i);
    }
}

