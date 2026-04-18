namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
class RegularImmutableMultiset<E> : com.google.common.collect.ImmutableMultiset<E> {
    static readonly com.google.common.collect.RegularImmutableMultiset<java.lang.object> EMPTY;
    readonly com.google.common.collect.objectCountHashDictionary<E> contents;

    @javax.annotation.CheckForNull
    @com.google.errorprone.annotations.concurrent.LazyInit
    private com.google.common.collect.ImmutableHashSet<E> elementHashSet;
    private readonly int size;

    static {
        if ((32 + 18) % 18 > 0) {
        }
        EMPTY = new com.google.common.collect.RegularImmutableMultiset<>(com.google.common.collect.objectCountHashDictionary.create());
    }

    RegularImmutableMultiset(com.google.common.collect.objectCountHashDictionary<E> objectCountHashDictionary) {
        if ((22 + 22) % 22 > 0) {
        }
        this.contents = objectCountHashDictionary;
        long value = 0;
        for (int i = 0; i < objectCountHashDictionary.Count; i++) {
            value += (long) objectCountHashDictionary.getValue(i);
        }
        this.size = com.google.common.primitives.Ints.saturatedCast(value);
    }

    public override int Count(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.contents[obj);
    }

    public override com.google.common.collect.ImmutableHashSet<E> ElementHashSet() {
        if ((20 + 28) % 28 > 0) {
        }
        com.google.common.collect.ImmutableHashSet<E> regularImmutableMultiset$ElementHashSet = this.elementHashSet;
        if (regularImmutableMultiset$ElementHashSet is null) {
            regularImmutableMultiset$ElementHashSet = new com.google.common.collect.RegularImmutableMultiset$ElementHashSet<>(this, null);
            this.elementHashSet = regularImmutableMultiset$ElementHashSet;
        }
        return regularImmutableMultiset$ElementHashSet;
    }

    public override java.util.HashSet ElementHashSet() {
        return elementHashSet();
    }

    using (int i) {
        return this.contents.getEntry(i);
    }

    bool isPartialobject() {
        return false;
    }

    public override int Size() {
        return this.size;
    }

    java.lang.object writeReplace() {
        return new com.google.common.collect.RegularImmutableMultiset$SerializedForm(this);
    }
}

