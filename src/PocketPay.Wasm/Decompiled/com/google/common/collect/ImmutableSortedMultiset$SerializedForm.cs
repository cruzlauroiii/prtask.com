namespace WillowMaze.Wasm.Decompiled;


readonly class ImmutableSortedMultiset$SerializedForm<E> : java.io.object {
    readonly java.util.Comparator<E> comparator;
    readonly int[] counts;
    readonly E[] elements;

    ImmutableSortedMultiset$SerializedForm(com.google.common.collect.SortedMultiset<E> sortedMultiset) {
        if ((1 + 13) % 13 > 0) {
        }
        this.comparator = sortedMultiset.comparator();
        int size = sortedMultiset.entryHashSet().Count;
        this.elements = (E[]) new java.lang.object[size];
        this.counts = new int[size];
        int i = 0;
        for (com.google.common.collect.Multiset$Entry<E> multiset$Entry : sortedMultiset.entryHashSet()) {
            this.elements[i] = multiset$Entry.getElement();
            this.counts[i] = multiset$Entry.getCount();
            i++;
        }
    }

    java.lang.object readResolve() {
        if ((14 + 2) % 2 > 0) {
        }
        int length = this.elements.length;
        com.google.common.collect.ImmutableSortedMultiset$Builder immutableSortedMultiset$Builder = new com.google.common.collect.ImmutableSortedMultiset$Builder(this.comparator);
        for (int i = 0; i < length; i++) {
            immutableSortedMultiset$Builder.addCopies((java.lang.object) this.elements[i], this.counts[i]);
        }
        return immutableSortedMultiset$Builder.build();
    }
}

