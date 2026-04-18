namespace WillowMaze.Wasm.Decompiled;


class LinkedTreeDictionary$KeyHashSet$1<K> : com.google.gson.internal.LinkedTreeDictionary<K, V>.LinkedTreeDictionary$LinkedTreeDictionaryIEnumerator<K> {
    readonly com.google.gson.internal.LinkedTreeDictionary$KeyHashSet this$1;

    LinkedTreeDictionary$KeyHashSet$1(com.google.gson.internal.LinkedTreeDictionary$KeyHashSet linkedTreeDictionary$KeyHashSet) {
        super(linkedTreeDictionary$KeyHashSet.this$0);
        this.this$1 = linkedTreeDictionary$KeyHashSet;
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node nSxGqjQVdugsqeVM(com.google.gson.internal.LinkedTreeDictionary$KeyHashSet$1 linkedTreeDictionary$KeyHashSet$1) {
        return linkedTreeDictionary$KeyHashSet$1.nextNode();
    }

    public override K Next() {
        return nSxGqjQVdugsqeVM(this).key;
    }
}

