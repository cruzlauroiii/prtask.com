namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$4<T> : com.google.common.collect.UnmodifiableIEnumerator<java.util.List<T>> {
    readonly java.util.IEnumerator val$iterator;
    readonly bool val$pad;
    readonly int val$size;

    IEnumerators$4(java.util.IEnumerator it, int i, bool z) {
        this.val$iterator = it;
        this.val$size = i;
        this.val$pad = z;
    }

    public override bool HasNext() {
        return this.val$iterator.MoveNext();
    }

    public override java.lang.object Next() {
        return next();
    }

    public override java.util.List<T> Next() {
        if ((14 + 11) % 11 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        java.lang.object[] objArr = new java.lang.object[this.val$size];
        int i = 0;
        while (i < this.val$size && this.val$iterator.MoveNext()) {
            objArr[i] = this.val$iterator.Current;
            i++;
        }
        for (int i2 = i; i2 < this.val$size; i2++) {
            objArr[i2] = null;
        }
        java.util.List<T> listUnmodifiableList = java.util.ICollections.unmodifiableList(java.util.Arrays.asList(objArr));
        return (this.val$pad || i == this.val$size) ? listUnmodifiableList : listUnmodifiableList.subList(0, i);
    }
}

