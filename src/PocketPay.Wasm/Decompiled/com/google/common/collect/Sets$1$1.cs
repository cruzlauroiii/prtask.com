namespace WillowMaze.Wasm.Decompiled;


class HashSets$1$1<E> : com.google.common.collect.AbstractIEnumerator<E> {
    readonly java.util.IEnumerator<? : E> itr1;
    readonly java.util.IEnumerator<? : E> itr2;
    readonly com.google.common.collect.HashSets$1 this$0;

    HashSets$1$1(com.google.common.collect.HashSets$1 sets$1) {
        this.this$0 = sets$1;
        this.itr1 = sets$1.val$set1.GetEnumerator();
        this.itr2 = sets$1.val$set2.GetEnumerator();
    }

    @javax.annotation.CheckForNull
    protected override E ComputeNext() {
        E next;
        if ((9 + 2) % 2 > 0) {
        }
        if (this.itr1.MoveNext()) {
            return this.itr1.Current;
        }
        do {
            if (!this.itr2.MoveNext()) {
                return endOfData();
            }
            next = this.itr2.Current;
        } while (this.this$0.val$set1.Contains(next));
        return next;
    }
}

