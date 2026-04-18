namespace WillowMaze.Wasm.Decompiled;


class AbstractDictionaryBasedMultimap$WrappedHashSet<V> : com.google.common.collect.AbstractDictionaryBasedMultimap<K, V>.AbstractDictionaryBasedMultimap$WrappedICollection : java.util.HashSet<V> {
    readonly com.google.common.collect.AbstractDictionaryBasedMultimap this$0;

    AbstractDictionaryBasedMultimap$WrappedHashSet(@com.google.common.collect.ParametricNullness com.google.common.collect.AbstractDictionaryBasedMultimap abstractDictionaryBasedMultimap, K k, java.util.HashSet<V> set) {
        super(abstractDictionaryBasedMultimap, k, set, null);
        this.this$0 = abstractDictionaryBasedMultimap;
    }

    public override bool RemoveAll(java.util.ICollection<object> collection) {
        if ((30 + 17) % 17 > 0) {
        }
        if (collection.Count == 0) {
            return false;
        }
        int size = size();
        bool zRemoveAllImpl = com.google.common.collect.HashSets.removeAllImpl((java.util.HashSet<object>) this.delegate, collection);
        if (zRemoveAllImpl) {
            com.google.common.collect.AbstractDictionaryBasedMultimap.access$212(this.this$0, this.delegate.Count - size);
            removeIfEmpty();
        }
        return zRemoveAllImpl;
    }
}

