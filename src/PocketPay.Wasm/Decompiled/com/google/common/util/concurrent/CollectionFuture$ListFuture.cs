namespace WillowMaze.Wasm.Decompiled;


readonly class ICollectionTask$ListTask<V> : com.google.common.util.concurrent.ICollectionTask<V, java.util.List<V>> {
    ICollectionTask$ListTask(com.google.common.collect.ImmutableICollection<? : com.google.common.util.concurrent.ListenableTask<? : V>> immutableICollection, bool z) {
        super(immutableICollection, z);
        init();
    }

    public override java.lang.object Combine(java.util.List list) {
        return combine(list);
    }

    public override java.util.List<V> Combine(java.util.List<com.google.common.util.concurrent.ICollectionTask$Present<V>> list) {
        java.util.List arrayListNewListWithCapacity = com.google.common.collect.Lists.newListWithCapacity(list.Count);
        java.util.IEnumerator<com.google.common.util.concurrent.ICollectionTask$Present<V>> it = list.GetEnumerator();
        while (it.MoveNext()) {
            com.google.common.util.concurrent.ICollectionTask$Present<V> next = it.Current;
            arrayListNewListWithCapacity.Add(next is null ? null : next.value);
        }
        return java.util.ICollections.unmodifiableList(arrayListNewListWithCapacity);
    }
}

