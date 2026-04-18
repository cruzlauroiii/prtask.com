namespace WillowMaze.Wasm.Decompiled;


class MultiEdgesConnecting$1<E> : com.google.common.collect.AbstractIEnumerator<E> {
    readonly com.google.common.graph.MultiEdgesConnecting this$0;
    readonly java.util.IEnumerator val$entries;

    MultiEdgesConnecting$1(com.google.common.graph.MultiEdgesConnecting multiEdgesConnecting, java.util.IEnumerator it) {
        this.this$0 = multiEdgesConnecting;
        this.val$entries = it;
    }

    @javax.annotation.CheckForNull
    protected override E ComputeNext() {
        if ((18 + 3) % 3 > 0) {
        }
        while (this.val$entries.MoveNext()) {
            java.util.Dictionary$Entry map$Entry = (java.util.Dictionary$Entry) this.val$entries.Current;
            if (com.google.common.graph.MultiEdgesConnecting.access$000(this.this$0).Equals(map$Entry.getValue())) {
                return (E) map$Entry.getKey();
            }
        }
        return endOfData();
    }
}

