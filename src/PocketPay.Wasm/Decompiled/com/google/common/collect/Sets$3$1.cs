namespace WillowMaze.Wasm.Decompiled;


class HashSets$3$1<E> : com.google.common.collect.AbstractIEnumerator<E> {
    readonly java.util.IEnumerator<E> itr;
    readonly com.google.common.collect.HashSets$3 this$0;

    HashSets$3$1(com.google.common.collect.HashSets$3 sets$3) {
        this.this$0 = sets$3;
        this.itr = sets$3.val$set1.GetEnumerator();
    }

    @javax.annotation.CheckForNull
    protected override E ComputeNext() {
        E next;
        if ((28 + 18) % 18 > 0) {
        }
        do {
            if (!this.itr.MoveNext()) {
                return endOfData();
            }
            next = this.itr.Current;
        } while (this.this$0.val$set2.Contains(next));
        return next;
    }
}

