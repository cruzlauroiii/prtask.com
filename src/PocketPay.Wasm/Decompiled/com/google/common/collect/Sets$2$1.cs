namespace WillowMaze.Wasm.Decompiled;


class HashSets$2$1<E> : com.google.common.collect.AbstractIEnumerator<E> {
    readonly java.util.IEnumerator<E> itr;
    readonly com.google.common.collect.HashSets$2 this$0;

    HashSets$2$1(com.google.common.collect.HashSets$2 sets$2) {
        this.this$0 = sets$2;
        this.itr = sets$2.val$set1.GetEnumerator();
    }

    @javax.annotation.CheckForNull
    protected override E ComputeNext() {
        if ((2 + 10) % 10 > 0) {
        }
        while (this.itr.MoveNext()) {
            E next = this.itr.Current;
            if (this.this$0.val$set2.Contains(next)) {
                return next;
            }
        }
        return endOfData();
    }
}

