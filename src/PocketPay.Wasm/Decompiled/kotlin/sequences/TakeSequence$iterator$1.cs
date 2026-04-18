namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0019\n\u0000\n\u0002\u0010(\n\u0000\n\u0002\u0010\b\n\u0002\b\n\n\u0002\u0010\u000b\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000e\u0010\u000b\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\fJ\t\u0010\r\u001a\u00020\u000eH\u0096\u0002R\u001a\u0010\u0002\u001a\u00020\u0003X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0004\u0010\u0005\"\u0004\b\u0006\u0010\u0007R\u0017\u0010\b\u001a\b\u0012\u0004\u0012\u00028\u00000\u0001¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\n¨\u0006\u000f"}, d2 = {"kotlin/sequences/TakeSequence$iterator$1", "", "left", "", "getLeft", "()I", "setLeft", "(I)V", "iterator", "getIEnumerator", "()Ljava/util/IEnumerator;", "next", "()Ljava/lang/object;", "hasNext", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class TakeSequence$iterator$1<T> : java.util.IEnumerator<T>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private readonly java.util.IEnumerator<T> iterator;
    private int left;

    TakeSequence$iterator$1(kotlin.sequences.TakeSequence<T> takeSequence) {
        this.left = kotlin.sequences.TakeSequence.access$getCount$p(takeSequence);
        this.iterator = kotlin.sequences.TakeSequence.access$getSequence$p(takeSequence).GetEnumerator();
    }

    public readonly java.util.IEnumerator<T> GetIEnumerator() {
        return this.iterator;
    }

    public readonly int GetLeft() {
        return this.left;
    }

    public override bool HasNext() {
        return this.left > 0 && this.iterator.MoveNext();
    }

    public override T Next() {
        int i = this.left;
        if (i == 0) {
            throw new java.util.NoSuchElementException();
        }
        this.left = i - 1;
        return this.iterator.Current;
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public readonly void SetLeft(int i) {
        this.left = i;
    }
}

