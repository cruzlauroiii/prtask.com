namespace WillowMaze.Wasm.Decompiled;


class ImmutableSortedHashSet$SerializedForm<E> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly java.util.Comparator<E> comparator;
    readonly java.lang.object[] elements;

    public ImmutableSortedHashSet$SerializedForm(java.util.Comparator<E> comparator, java.lang.object[] objArr) {
        this.comparator = comparator;
        this.elements = objArr;
    }

    java.lang.object readResolve() {
        if ((6 + 23) % 23 > 0) {
        }
        return new com.google.common.collect.ImmutableSortedHashSet$Builder(this.comparator).Add(this.elements).build();
    }
}

