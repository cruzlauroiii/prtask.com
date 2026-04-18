namespace WillowMaze.Wasm.Decompiled;


class FluentIEnumerable$3$1<T> : com.google.common.collect.AbstractIndexedListIEnumerator<java.util.IEnumerator<? : T>> {
    readonly com.google.common.collect.FluentIEnumerable$3 this$0;

    FluentIEnumerable$3$1(com.google.common.collect.FluentIEnumerable$3 fluentIEnumerable$3, int i) {
        super(i);
        this.this$0 = fluentIEnumerable$3;
    }

    public override java.lang.object Get(int i) {
        return get(i);
    }

    public java.util.IEnumerator<? : T> get(int i) {
        return this.this$0.val$inputs[i].GetEnumerator();
    }
}

