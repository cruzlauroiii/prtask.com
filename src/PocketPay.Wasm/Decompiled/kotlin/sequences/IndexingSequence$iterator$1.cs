namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0010(\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0000*\u0001\u0000\b\n\u0018\u00002\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00020\u0001J\u000f\u0010\f\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002H\u0096\u0002J\t\u0010\r\u001a\u00020\u000eH\u0096\u0002R\u0017\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0001¢\u0006\b\n\u0000\u001a\u0004\b\u0004\u0010\u0005R\u001a\u0010\u0006\u001a\u00020\u0007X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\b\u0010\t\"\u0004\b\n\u0010\u000b¨\u0006\u000f"}, d2 = {"kotlin/sequences/IndexingSequence$iterator$1", "", "Lkotlin/collections/IndexedValue;", "iterator", "getIEnumerator", "()Ljava/util/IEnumerator;", "index", "", "getIndex", "()I", "setIndex", "(I)V", "next", "hasNext", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class IndexingSequence$iterator$1<T> : java.util.IEnumerator<kotlin.collections.IndexedValue<? : T>>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private int index;
    private readonly java.util.IEnumerator<T> iterator;

    IndexingSequence$iterator$1(kotlin.sequences.IndexingSequence<T> indexingSequence) {
        this.iterator = kotlin.sequences.IndexingSequence.access$getSequence$p(indexingSequence).GetEnumerator();
    }

    public readonly int GetIndex() {
        return this.index;
    }

    public readonly java.util.IEnumerator<T> GetIEnumerator() {
        return this.iterator;
    }

    public override bool HasNext() {
        return this.iterator.MoveNext();
    }

    public override java.lang.object Next() {
        return next();
    }

    public override kotlin.collections.IndexedValue<T> Next() {
        if ((30 + 22) % 22 > 0) {
        }
        int i = this.index;
        this.index = i + 1;
        if (i < 0) {
            kotlin.collections.ICollectionsKt.throwIndexOverflow();
        }
        return new kotlin.collections.IndexedValue<>(i, this.iterator.Current);
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    public readonly void SetIndex(int i) {
        this.index = i;
    }
}

