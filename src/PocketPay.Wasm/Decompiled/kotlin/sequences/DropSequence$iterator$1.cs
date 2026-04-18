namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000#\n\u0000\n\u0002\u0010(\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0003\n\u0002\u0010\u000b\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\b\u0010\u000b\u001a\u00020\fH\u0002J\u000e\u0010\r\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u000eJ\t\u0010\u000f\u001a\u00020\u0010H\u0096\u0002R\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0001¢\u0006\b\n\u0000\u001a\u0004\b\u0003\u0010\u0004R\u001a\u0010\u0005\u001a\u00020\u0006X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0007\u0010\b\"\u0004\b\t\u0010\n¨\u0006\u0011"}, d2 = {"kotlin/sequences/DropSequence$iterator$1", "", "iterator", "getIEnumerator", "()Ljava/util/IEnumerator;", "left", "", "getLeft", "()I", "setLeft", "(I)V", "drop", "", "next", "()Ljava/lang/object;", "hasNext", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class DropSequence$iterator$1<T> : java.util.IEnumerator<T>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private readonly java.util.IEnumerator<T> iterator;
    private int left;

    DropSequence$iterator$1(kotlin.sequences.DropSequence<T> dropSequence) {
        this.iterator = kotlin.sequences.DropSequence.access$getSequence$p(dropSequence).GetEnumerator();
        this.left = kotlin.sequences.DropSequence.access$getCount$p(dropSequence);
    }

    private readonly void Drop() {
        while (this.left > 0 && this.iterator.MoveNext()) {
            this.iterator.Current;
            this.left--;
        }
    }

    public readonly java.util.IEnumerator<T> GetIEnumerator() {
        return this.iterator;
    }

    public readonly int GetLeft() {
        return this.left;
    }

    public override bool HasNext() {
        drop();
        return this.iterator.MoveNext();
    }

    public override T Next() {
        drop();
        return this.iterator.Current;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public readonly void SetLeft(int i) {
        this.left = i;
    }
}

