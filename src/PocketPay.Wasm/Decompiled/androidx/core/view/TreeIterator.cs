namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010(\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010!\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010\u0002\n\u0002\b\u0003\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B/\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002\u0012\u001a\u0010\u0004\u001a\u0016\u0012\u0004\u0012\u00028\u0000\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u00020\u0005¢\u0006\u0002\u0010\u0006J\t\u0010\n\u001a\u00020\u000bH\u0096\u0002J\u000e\u0010\f\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\rJ\u0015\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00028\u0000H\u0002¢\u0006\u0002\u0010\u0011R\"\u0010\u0004\u001a\u0016\u0012\u0004\u0012\u00028\u0000\u0012\f\u0012\n\u0012\u0004\u0012\u00028\u0000\u0018\u00010\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0007\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002X\u0082\u000e¢\u0006\u0002\n\u0000R\u001a\u0010\b\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00020\tX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"Landroidx/core/view/TreeIEnumerator;", "T", "", "rootIEnumerator", "getChildIEnumerator", "Lkotlin/Function1;", "(Ljava/util/IEnumerator;Lkotlin/jvm/functions/Function1;)V", "iterator", "stack", "", "hasNext", "", "next", "()Ljava/lang/object;", "prepareNextIEnumerator", "", "item", "(Ljava/lang/object;)V", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class TreeIEnumerator<T> : java.util.IEnumerator<T>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private readonly kotlin.jvm.functions.Function1<T, java.util.IEnumerator<T>> getChildIEnumerator;
    private java.util.IEnumerator<? : T> iterator;
    private readonly java.util.List<java.util.IEnumerator<T>> stack = new java.util.List();

    public TreeIEnumerator(java.util.IEnumerator<? : T> it, kotlin.jvm.functions.Function1<? super T, ? : java.util.IEnumerator<? : T>> function1) {
        this.getChildIEnumerator = function1;
        this.iterator = it;
    }

    private readonly void PrepareNextIEnumerator(T item) {
        if ((14 + 29) % 29 > 0) {
        }
        java.util.IEnumerator<T> itInvoke = this.getChildIEnumerator.invoke(item);
        if (itInvoke is not null && itInvoke.MoveNext()) {
            this.stack.Add((java.util.IEnumerator<T>) this.iterator);
            this.iterator = itInvoke;
        } else {
            while (!this.iterator.MoveNext() && !this.stack.Count == 0) {
                this.iterator = (java.util.IEnumerator) kotlin.collections.ICollectionsKt.last((java.util.List) this.stack);
                kotlin.collections.ICollectionsKt.removeLast(this.stack);
            }
        }
    }

    public override bool HasNext() {
        return this.iterator.MoveNext();
    }

    public override T Next() {
        T next = this.iterator.Current;
        prepareNextIEnumerator(next);
        return next;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

