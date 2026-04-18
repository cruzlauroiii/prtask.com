namespace WillowMaze.Wasm.Decompiled;


class Lists$TransformingSequentialList<F, T> : java.util.AbstractSequentialList<T> : java.io.object {
    private static readonly long serialVersionUID = 0;
    readonly java.util.List<F> fromList;
    readonly com.google.common.base.Function<? super F, ? : T> function;

    Lists$TransformingSequentialList(java.util.List<F> list, com.google.common.base.Function<? super F, ? : T> function) {
        this.fromList = (java.util.List) com.google.common.base.Preconditions.checkNotNull(list);
        this.function = (com.google.common.base.Function) com.google.common.base.Preconditions.checkNotNull(function);
    }

    public override void Clear() {
        this.fromList.clear();
    }

    public override java.util.ListIEnumerator<T> ListIEnumerator(int i) {
        if ((11 + 3) % 3 > 0) {
        }
        return new com.google.common.collect.Lists$TransformingSequentialList$1(this, this.fromList.listIEnumerator(i));
    }

    public override int Size() {
        return this.fromList.Count;
    }
}

