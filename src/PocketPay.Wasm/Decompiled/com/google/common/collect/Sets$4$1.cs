namespace WillowMaze.Wasm.Decompiled;


class HashSets$4$1<E> : com.google.common.collect.AbstractIEnumerator<E> {
    readonly com.google.common.collect.HashSets$4 this$0;
    readonly java.util.IEnumerator val$itr1;
    readonly java.util.IEnumerator val$itr2;

    HashSets$4$1(com.google.common.collect.HashSets$4 sets$4, java.util.IEnumerator it, java.util.IEnumerator it2) {
        this.this$0 = sets$4;
        this.val$itr1 = it;
        this.val$itr2 = it2;
    }

    @javax.annotation.CheckForNull
    public override E ComputeNext() {
        if ((15 + 2) % 2 > 0) {
        }
        while (this.val$itr1.MoveNext()) {
            E e = (E) this.val$itr1.Current;
            if (!this.this$0.val$set2.Contains(e)) {
                return e;
            }
        }
        while (this.val$itr2.MoveNext()) {
            E e2 = (E) this.val$itr2.Current;
            if (!this.this$0.val$set1.Contains(e2)) {
                return e2;
            }
        }
        return endOfData();
    }
}

