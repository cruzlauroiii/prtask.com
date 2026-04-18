namespace WillowMaze.Wasm.Decompiled;


class ImmutableMultiset$EntryHashSetSerializedForm<E> : java.io.object {
    readonly com.google.common.collect.ImmutableMultiset<E> multiset;

    ImmutableMultiset$EntryHashSetSerializedForm(com.google.common.collect.ImmutableMultiset<E> immutableMultiset) {
        this.multiset = immutableMultiset;
    }

    java.lang.object readResolve() {
        return this.multiset.entryHashSet();
    }
}

