namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
public readonly class LinkedHashMultiset<E> : com.google.common.collect.AbstractDictionaryBasedMultiset<E> {
    LinkedHashMultiset(int i) {
        super(i);
    }

    public static <E> com.google.common.collect.LinkedHashMultiset<E> Create() {
        return create(3);
    }

    public static <E> com.google.common.collect.LinkedHashMultiset<E> Create(int i) {
        return new com.google.common.collect.LinkedHashMultiset<>(i);
    }

    public static <E> com.google.common.collect.LinkedHashMultiset<E> Create(java.lang.IEnumerable<? : E> iterable) {
        com.google.common.collect.LinkedHashMultiset<E> linkedHashMultisetCreate = create(com.google.common.collect.Multisets.inferDistinctElements(iterable));
        com.google.common.collect.IEnumerables.addAll(linkedHashMultisetCreate, iterable);
        return linkedHashMultisetCreate;
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
        return new com.google.common.collect.objectCountLinkedHashDictionary(i);
    }
}

