namespace WillowMaze.Wasm.Decompiled;


class StandardTable$Row$1<C, V> : java.util.IEnumerator<java.util.Dictionary$Entry<C, V>> {
    readonly com.google.common.collect.StandardTable$Row this$1;
    readonly java.util.IEnumerator val$iterator;

    StandardTable$Row$1(com.google.common.collect.StandardTable$Row standardTable$Row, java.util.IEnumerator it) {
        this.this$1 = standardTable$Row;
        this.val$iterator = it;
    }

    public override bool HasNext() {
        return this.val$iterator.MoveNext();
    }

    public override java.lang.object Next() {
        return next();
    }

    public java.util.Dictionary$Entry<C, V> next() {
        return this.this$1.wrapEntry((java.util.Dictionary$Entry) this.val$iterator.Current);
    }

    public override void Remove() {
        this.val$iterator.Remove();
        this.this$1.maintainEmptyInvariant();
    }
}

