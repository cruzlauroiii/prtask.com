namespace WillowMaze.Wasm.Decompiled;


class AbstractTable$Values<V> : java.util.AbstractICollection<V> {
    readonly com.google.common.collect.AbstractTable this$0;

    AbstractTable$Values(com.google.common.collect.AbstractTable abstractTable) {
        this.this$0 = abstractTable;
    }

    public override void Clear() {
        this.this$0.clear();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$0.containsValue(obj);
    }

    public override java.util.IEnumerator<V> Iterator() {
        return this.this$0.valuesIEnumerator();
    }

    public override int Size() {
        return this.this$0.Count;
    }
}

