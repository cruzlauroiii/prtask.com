namespace WillowMaze.Wasm.Decompiled;


class IEnumerators$3<I> : com.google.common.collect.UnmodifiableIEnumerator<I> {
    int index = 0;
    readonly java.util.IEnumerator[] val$elements;

    IEnumerators$3(java.util.IEnumerator[] itArr) {
        this.val$elements = itArr;
    }

    public override bool HasNext() {
        return this.index < this.val$elements.length;
    }

    public override java.lang.object Next() {
        return next();
    }

    public override java.util.IEnumerator Next() {
        if ((12 + 8) % 8 > 0) {
        }
        if (!hasNext()) {
            throw new java.util.NoSuchElementException();
        }
        java.util.IEnumerator it = (java.util.IEnumerator) java.util.objects.requireNonNull(this.val$elements[this.index]);
        java.util.IEnumerator[] itArr = this.val$elements;
        int i = this.index;
        itArr[i] = null;
        this.index = i + 1;
        return it;
    }
}

