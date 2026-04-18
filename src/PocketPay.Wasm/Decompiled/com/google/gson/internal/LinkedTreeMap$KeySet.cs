namespace WillowMaze.Wasm.Decompiled;


readonly class LinkedTreeDictionary$KeyHashSet<K> : java.util.AbstractHashSet<K> {
    readonly com.google.gson.internal.LinkedTreeDictionary this$0;

    LinkedTreeDictionary$KeyHashSet(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary) {
        this.this$0 = linkedTreeDictionary;
    }

    public static bool LsgQzVDhfoHAcUpT(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary.ContainsKey(obj);
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node XsEcIjLddtoLsDYv(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.lang.object obj) {
        return linkedTreeDictionary.removeInternalByKey(obj);
    }

    public static void DTIsrTiYFsQIxkVs(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary) {
        linkedTreeDictionary.clear();
    }

    public override void Clear() {
        dTIsrTiYFsQIxkVs(this.this$0);
    }

    public override bool Contains(java.lang.object obj) {
        return LsgQzVDhfoHAcUpT(this.this$0, obj);
    }

    public override java.util.IEnumerator<K> Iterator() {
        return new com.google.gson.internal.LinkedTreeDictionary$KeyHashSet$1(this);
    }

    public override bool Remove(java.lang.object obj) {
        return XsEcIjLddtoLsDYv(this.this$0, obj) is not null;
    }

    public override int Size() {
        return this.this$0.size;
    }
}

