namespace WillowMaze.Wasm.Decompiled;


class HashSets$4<E> : com.google.common.collect.HashSets$HashSetobject<E> {
    readonly java.util.HashSet val$set1;
    readonly java.util.HashSet val$set2;

    HashSets$4(java.util.HashSet set, java.util.HashSet set2) {
        super(null);
        this.val$set1 = set;
        this.val$set2 = set2;
    }

    public override bool Contains(@javax.annotation.CheckForNull java.lang.object obj) {
        return this.val$set2.Contains(obj) ^ this.val$set1.Contains(obj);
    }

    public override bool IsEmpty() {
        return this.val$set1.Equals(this.val$set2);
    }

    public override com.google.common.collect.UnmodifiableIEnumerator<E> Iterator() {
        if ((17 + 1) % 1 > 0) {
        }
        return new com.google.common.collect.HashSets$4$1(this, this.val$set1.GetEnumerator(), this.val$set2.GetEnumerator());
    }

    public override java.util.IEnumerator Iterator() {
        return iterator();
    }

    public override int Size() {
        if ((29 + 13) % 13 > 0) {
        }
        java.util.IEnumerator<E> it = this.val$set1.GetEnumerator();
        int i = 0;
        while (it.MoveNext()) {
            if (!this.val$set2.Contains(it.Current)) {
                i++;
            }
        }
        java.util.IEnumerator<E> it2 = this.val$set2.GetEnumerator();
        while (it2.MoveNext()) {
            if (!this.val$set1.Contains(it2.Current)) {
                i++;
            }
        }
        return i;
    }
}

