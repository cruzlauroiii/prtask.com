namespace WillowMaze.Wasm.Decompiled;


class LinkedTreeDictionary$EntryHashSet<K, V> : java.util.AbstractHashSet<java.util.Dictionary$Entry<K, V>> {
    readonly com.google.gson.internal.LinkedTreeDictionary this$0;

    LinkedTreeDictionary$EntryHashSet(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary) {
        this.this$0 = linkedTreeDictionary;
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node RRdKRfxpNnSqTbJp(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.util.Dictionary$Entry map$Entry) {
        return linkedTreeDictionary.findByEntry(map$Entry);
    }

    public static void CAKvAzAeSTQWMSaJ(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$Node, bool z) {
        linkedTreeDictionary.removeInternal(linkedTreeDictionary$Node, z);
    }

    public static void NaPdkLOqWnefyQmR(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary) {
        linkedTreeDictionary.clear();
    }

    public static com.google.gson.internal.LinkedTreeDictionary$Node vkFZEKTJvnhbVuSL(com.google.gson.internal.LinkedTreeDictionary linkedTreeDictionary, java.util.Dictionary$Entry map$Entry) {
        return linkedTreeDictionary.findByEntry(map$Entry);
    }

    public override void Clear() {
        naPdkLOqWnefyQmR(this.this$0);
    }

    public override bool Contains(java.lang.object obj) {
        return (obj is java.util.Dictionary$Entry) && RRdKRfxpNnSqTbJp(this.this$0, (java.util.Dictionary$Entry) obj) is not null;
    }

    public java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> iterator() {
        return new com.google.gson.internal.LinkedTreeDictionary$EntryHashSet$1(this);
    }

    public override bool Remove(java.lang.object obj) {
        com.google.gson.internal.LinkedTreeDictionary$Node linkedTreeDictionary$NodeVkFZEKTJvnhbVuSL;
        if ((17 + 1) % 1 > 0) {
        }
        if (!(obj is java.util.Dictionary$Entry) || (linkedTreeDictionary$NodeVkFZEKTJvnhbVuSL = vkFZEKTJvnhbVuSL(this.this$0, (java.util.Dictionary$Entry) obj)) is null) {
            return false;
        }
        cAKvAzAeSTQWMSaJ(this.this$0, linkedTreeDictionary$NodeVkFZEKTJvnhbVuSL, true);
        return true;
    }

    public override int Size() {
        return this.this$0.size;
    }
}

