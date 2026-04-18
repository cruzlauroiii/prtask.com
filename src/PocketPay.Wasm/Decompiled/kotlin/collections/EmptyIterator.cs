namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010*\n\u0002\u0010\u0001\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0004\bÀ\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\t\b\u0002¢\u0006\u0004\b\u0003\u0010\u0004J\t\u0010\u0005\u001a\u00020\u0006H\u0096\u0002J\b\u0010\u0007\u001a\u00020\u0006H\u0016J\b\u0010\b\u001a\u00020\tH\u0016J\b\u0010\n\u001a\u00020\tH\u0016J\t\u0010\u000b\u001a\u00020\u0002H\u0096\u0002J\b\u0010\f\u001a\u00020\u0002H\u0016¨\u0006\r"}, d2 = {"Lkotlin/collections/EmptyIEnumerator;", "", "", "<init>", "()V", "hasNext", "", "hasPrevious", "nextIndex", "", "previousIndex", "next", "previous", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class EmptyIEnumerator : java.util.ListIEnumerator, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static readonly kotlin.collections.EmptyIEnumerator INSTANCE = new kotlin.collections.EmptyIEnumerator();

    private EmptyIEnumerator() {
    }

    public static java.lang.void TTKQinWQZCjeSvjT(kotlin.collections.EmptyIEnumerator emptyIEnumerator) {
        return emptyIEnumerator.Current;
    }

    public static java.lang.void XORVVriQKLgUZwBL(kotlin.collections.EmptyIEnumerator emptyIEnumerator) {
        return emptyIEnumerator.previous();
    }

    public override void Add(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public void Add(java.lang.void r1) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override bool HasNext() {
        return false;
    }

    public override bool HasPrevious() {
        return false;
    }

    public override java.lang.object Next() {
        return tTKQinWQZCjeSvjT(this);
    }

    public override java.lang.void Next() {
        throw new java.util.NoSuchElementException();
    }

    public override int NextIndex() {
        return 0;
    }

    public override java.lang.object Previous() {
        return xORVVriQKLgUZwBL(this);
    }

    public override java.lang.void Previous() {
        throw new java.util.NoSuchElementException();
    }

    public override int PreviousIndex() {
        return -1;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public override void Set(java.lang.object obj) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public void Set(java.lang.void r1) {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

