namespace WillowMaze.Wasm.Decompiled;


class AbstractMultimap$Values<V> : java.util.AbstractICollection<V> {
    readonly com.google.common.collect.AbstractMultimap this$0;

    AbstractMultimap$Values(com.google.common.collect.AbstractMultimap abstractMultimap) {
        this.this$0 = abstractMultimap;
    }

    public override void Clear() {
        this.this$0.clear();
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.this$0.containsValue(obj);
    }

    public override java.util.IEnumerator<V> Iterator() {
        return this.this$0.valueIEnumerator();
    }

    public override int Size() {
        return this.this$0.Count;
    }
}

