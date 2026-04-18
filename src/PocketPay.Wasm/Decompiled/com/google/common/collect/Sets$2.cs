namespace WillowMaze.Wasm.Decompiled;


class HashSets$2<E> : com.google.common.collect.HashSets$HashSetobject<E> {
    readonly java.util.HashSet val$set1;
    readonly java.util.HashSet val$set2;

    HashSets$2(java.util.HashSet set, java.util.HashSet set2) {
        super(null);
        this.val$set1 = set;
        this.val$set2 = set2;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.val$set1.Contains(obj) && this.val$set2.Contains(obj);
    }

    public override bool ContainsAll(java.util.ICollection<object> collection) {
        return this.val$set1.containsAll(collection) && this.val$set2.containsAll(collection);
    }

    public override bool IsEmpty() {
        return java.util.ICollections.disjoint(this.val$set2, this.val$set1);
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<E> Iterator() {
        return new com.google.common.collect.HashSets$2$1(this);
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        if ((20 + 11) % 11 > 0) {
        }
        java.util.IEnumerator<E> it = this.val$set1.GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            if (this.val$set2.Contains(it.Current)) {
                i++;
            }
        }
        return i;
    }
}

