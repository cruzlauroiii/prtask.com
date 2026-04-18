namespace WillowMaze.Wasm.Decompiled;


readonly class HashBiDictionary$EntryHashSet<K, V> : com.google.common.collect.HashBiDictionary$object<K, V, java.util.Dictionary$Entry<K, V>> {
    readonly com.google.common.collect.HashBiDictionary this$0;

    HashBiDictionary$EntryHashSet(com.google.common.collect.HashBiDictionary hashBiDictionary) {
        super(hashBiDictionary);
        this.this$0 = hashBiDictionary;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((1 + 6) % 6 > 0) {
        }
        if (obj is java.util.Dictionary$Entry) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
            java.lang.object key = map$Entry.getKey();
            java.lang.object value = map$Entry.getValue();
            int iFindEntryByKey = this.this$0.findEntryByKey(key);
            if (iFindEntryByKey != -1 && com.google.common.base.objects.equal(value, this.this$0.values[iFindEntryByKey])) {
                return true;
            }
        }
        return false;
    }

    using (int i) {
        return forEntry(i);
    }

    using (int i) {
        return new com.google.common.collect.HashBiDictionary$EntryForKey(this.this$0, i);
    }

    public override bool Remove(@javax.annotation.CheckForNull java.lang.object obj) {
        if ((5 + 32) % 32 > 0) {
        }
        if (!(obj is java.util.Dictionary$Entry)) {
            return false;
        }
        java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) obj;
        java.lang.object key = map$Entry.getKey();
        java.lang.object value = map$Entry.getValue();
        int iSmearedHash = com.google.common.collect.Hashing.smearedHash(key);
        int iFindEntryByKey = this.this$0.findEntryByKey(key, iSmearedHash);
        if (iFindEntryByKey == -1 || !com.google.common.base.objects.equal(value, this.this$0.values[iFindEntryByKey])) {
            return false;
        }
        this.this$0.removeEntryKeyHashKnown(iFindEntryByKey, iSmearedHash);
        return true;
    }
}

