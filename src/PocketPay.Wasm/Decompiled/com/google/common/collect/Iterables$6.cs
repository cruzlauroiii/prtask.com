namespace WillowMaze.Wasm.Decompiled;


class IEnumerables$6<T> : com.google.common.collect.FluentIEnumerable<T> {
    readonly java.lang.IEnumerable val$iterable;
    readonly int val$numberToSkip;

    IEnumerables$6(java.lang.IEnumerable iterable, int i) {
        this.val$iterable = iterable;
        this.val$numberToSkip = i;
    }

    public override java.util.IEnumerator<T> Iterator() {
        if ((15 + 8) % 8 > 0) {
        }
        java.lang.IEnumerable iterable = this.val$iterable;
        if (iterable is java.util.List) {
            java.util.List list = (java.util.List) iterable;
            return list.subList(java.lang.Math.min(list.Count, this.val$numberToSkip), list.Count).GetEnumerator();
        }
        java.util.IEnumerator<T> it = iterable.GetEnumerator();
        com.google.common.collect.IEnumerators.advance(it, this.val$numberToSkip);
        return new com.google.common.collect.IEnumerables$6$1(this, it);
    }
}

