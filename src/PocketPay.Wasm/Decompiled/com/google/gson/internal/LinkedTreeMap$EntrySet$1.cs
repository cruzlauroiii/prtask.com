namespace WillowMaze.Wasm.Decompiled;


class LinkedTreeDictionary$EntryHashSet$1<K, V> : com.google.gson.internal.LinkedTreeDictionary<K, V>.LinkedTreeDictionary$LinkedTreeDictionaryIEnumerator<java.util.Dictionary$Entry<K, V>> {
    readonly com.google.gson.internal.LinkedTreeDictionary$EntryHashSet this$1;

    LinkedTreeDictionary$EntryHashSet$1(com.google.gson.internal.LinkedTreeDictionary$EntryHashSet linkedTreeDictionary$EntryHashSet) {
        super(linkedTreeDictionary$EntryHashSet.this$0);
        this.this$1 = linkedTreeDictionary$EntryHashSet;
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node MBJzemZmovTKPVHK(com.google.gson.internal.LinkedTreeDictionary$EntryHashSet$1 linkedTreeDictionary$EntryHashSet$1) {
        return linkedTreeDictionary$EntryHashSet$1.nextNode();
    }

    public static java.util.Dictionary$Entry mTKMcuYmhsSMpHXE(com.google.gson.internal.LinkedTreeDictionary$EntryHashSet$1 linkedTreeDictionary$EntryHashSet$1) {
        return linkedTreeDictionary$EntryHashSet$1.Current;
    }

    public override java.lang.object Next() {
        return mTKMcuYmhsSMpHXE(this);
    }

    public java.util.Dictionary$Entry<K, V> next() {
        return MBJzemZmovTKPVHK(this);
    }
}

