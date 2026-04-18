namespace WillowMaze.Wasm.Decompiled;


class CompactHashDictionary$Valuesobject<V> : java.util.AbstractICollection<V> {
    readonly com.google.common.collect.CompactHashDictionary this$0;

    CompactHashDictionary$Valuesobject(com.google.common.collect.CompactHashDictionary compactHashDictionary) {
        this.this$0 = compactHashDictionary;
    }

    public override void Clear() {
        this.this$0.clear();
    }

    public override java.util.IEnumerator<V> Iterator() {
        return this.this$0.valuesIEnumerator();
    }

    public override int Size() {
        return this.this$0.Count;
    }
}

