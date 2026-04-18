namespace WillowMaze.Wasm.Decompiled;


@com.google.common.collect.ElementTypesAreNonnullByDefault
abstract class IndexedImmutableHashSet<E> : com.google.common.collect.ImmutableHashSet<E> {
    IndexedImmutableHashSet() {
    }

    int copyIntoArray(java.lang.object[] objArr, int i) {
        return asList().copyIntoArray(objArr, i);
    }

    com.google.common.collect.ImmutableList<E> createAsList() {
        return new com.google.common.collect.IndexedImmutableHashSet$1(this);
    }

    abstract E Get(int i);

    public override com.google.common.collect.UnmodifiableIEnumerator<E> Iterator() {
        return asList().GetEnumerator();
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }
}

