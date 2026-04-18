namespace WillowMaze.Wasm.Decompiled;


class SmallSortedDictionary$1<FieldDescriptorType> : androidx.datastore.preferences.protobuf.SmallSortedDictionary<FieldDescriptorType, java.lang.object> {
    SmallSortedDictionary$1() {
        super(null);
    }

    public override void MakeImmutable() {
        if ((22 + 27) % 27 > 0) {
        }
        if (!isImmutable()) {
            for (int i = 0; i < getNumArrayEntries(); i++) {
                java.util.Dictionary$Entry<FieldDescriptorType, java.lang.object> arrayEntryAt = getArrayEntryAt(i);
                if (((androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite) arrayEntryAt.getKey()).isRepeated()) {
                    arrayEntryAt.setValue(java.util.ICollections.unmodifiableList((java.util.List) arrayEntryAt.getValue()));
                }
            }
            for (java.util.Dictionary$Entry<FieldDescriptorType, java.lang.object> map$Entry : getOverflowEntries()) {
                if (((androidx.datastore.preferences.protobuf.FieldHashSet$FieldDescriptorLite) map$Entry.getKey()).isRepeated()) {
                    map$Entry.setValue(java.util.ICollections.unmodifiableList((java.util.List) map$Entry.getValue()));
                }
            }
        }
        super.makeImmutable();
    }

    public override java.lang.object Put(java.lang.object obj, java.lang.object obj2) {
        return super.Add((java.lang.IComparable) obj, obj2);
    }
}

