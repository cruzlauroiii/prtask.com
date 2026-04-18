namespace WillowMaze.Wasm.Decompiled;


class FilteredKeyMultimap$Entries<K, V> : com.google.common.collect.ForwardingICollection<java.util.Dictionary$Entry<K, V>> {
    readonly com.google.common.collect.FilteredKeyMultimap this$0;

    FilteredKeyMultimap$Entries(com.google.common.collect.FilteredKeyMultimap filteredKeyMultimap) {
        this.this$0 = filteredKeyMultimap;
    }

    protected override java.lang.object Delegate() {
        return delegate();
    }

    protected java.util.ICollection<java.util.Dictionary$Entry<K, V>> delegate() {
        return com.google.common.collect.ICollections2.filter(this.this$0.unfiltered.entries(), this.this$0.entryPredicate());
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((30 + 8) % 8 > 0) {
        }
        if (!(obj is java.util.Dictionary$Entry)) {
            return false;
        }
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        if (this.this$0.unfiltered.ContainsKey(map$Entry.getKey()) && this.this$0.keyPredicate.apply((java.lang.object) map$Entry.getKey())) {
            return this.this$0.unfiltered.Remove(map$Entry.getKey(), map$Entry.getValue());
        }
        return false;
    }
}

