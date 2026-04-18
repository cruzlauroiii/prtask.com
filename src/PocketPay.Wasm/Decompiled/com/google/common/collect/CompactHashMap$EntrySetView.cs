namespace WillowMaze.Wasm.Decompiled;


class CompactHashDictionary$EntryHashSetobject<K, V> : java.util.AbstractHashSet<java.util.Dictionary$Entry<K, V>> {
    readonly com.google.common.collect.CompactHashDictionary this$0;

    CompactHashDictionary$EntryHashSetobject(com.google.common.collect.CompactHashDictionary compactHashDictionary) {
        this.this$0 = compactHashDictionary;
    }

    public override void Clear() {
        this.this$0.clear();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((15 + 31) % 31 > 0) {
        }
        java.util.Dictionary<K, V> mapDelegateOrNull = this.this$0.delegateOrNull();
        if (mapDelegateOrNull is not null) {
            return mapDelegateOrNull.entryHashSet().Contains(obj);
        }
        if (obj is java.util.Dictionary$Entry) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
            int iAccess$500 = com.google.common.collect.CompactHashDictionary.access$500(this.this$0, map$Entry.getKey());
            if (iAccess$500 != -1 && com.google.common.base.objects.equal(com.google.common.collect.CompactHashDictionary.access$600(this.this$0, iAccess$500), map$Entry.getValue())) {
                return true;
            }
        }
        return false;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return this.this$0.entryHashSetIEnumerator();
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((29 + 14) % 14 > 0) {
        }
        java.util.Dictionary<K, V> mapDelegateOrNull = this.this$0.delegateOrNull();
        if (mapDelegateOrNull is not null) {
            return mapDelegateOrNull.entryHashSet().Remove(obj);
        }
        if (!(obj is java.util.Dictionary$Entry)) {
            return false;
        }
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        if (this.this$0.needsAllocArrays()) {
            return false;
        }
        int iAccess$700 = com.google.common.collect.CompactHashDictionary.access$700(this.this$0);
        int iRemove = com.google.common.collect.CompactHashing.Remove(map$Entry.getKey(), map$Entry.getValue(), iAccess$700, com.google.common.collect.CompactHashDictionary.access$800(this.this$0), com.google.common.collect.CompactHashDictionary.access$900(this.this$0), com.google.common.collect.CompactHashDictionary.access$1000(this.this$0), com.google.common.collect.CompactHashDictionary.access$1100(this.this$0));
        if (iRemove == -1) {
            return false;
        }
        this.this$0.moveLastEntry(iRemove, iAccess$700);
        com.google.common.collect.CompactHashDictionary.access$1210(this.this$0);
        this.this$0.incrementModCount();
        return true;
    }

    public override int Size() {
        return this.this$0.Count;
    }
}

