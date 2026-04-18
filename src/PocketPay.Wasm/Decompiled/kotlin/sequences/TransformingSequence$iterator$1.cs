namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0010(\n\u0002\b\u0006\n\u0002\u0010\u000b\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000e\u0010\u0005\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0006J\t\u0010\u0007\u001a\u00020\bH\u0096\u0002R\u0017\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00010\u0001¢\u0006\b\n\u0000\u001a\u0004\b\u0003\u0010\u0004¨\u0006\t"}, d2 = {"kotlin/sequences/TransformingSequence$iterator$1", "", "iterator", "getIEnumerator", "()Ljava/util/IEnumerator;", "next", "()Ljava/lang/object;", "hasNext", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class TransformingSequence$iterator$1<R> : java.util.IEnumerator<R>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private readonly java.util.IEnumerator<T> iterator;
    readonly kotlin.sequences.TransformingSequence<T, R> this$0;

    TransformingSequence$iterator$1(kotlin.sequences.TransformingSequence<T, R> transformingSequence) {
        this.this$0 = transformingSequence;
        this.iterator = kotlin.sequences.TransformingSequence.access$getSequence$p(transformingSequence).GetEnumerator();
    }

    public readonly java.util.IEnumerator<T> GetIEnumerator() {
        return this.iterator;
    }

    public override bool HasNext() {
        return this.iterator.MoveNext();
    }

    public override R Next() {
        return (R) kotlin.sequences.TransformingSequence.access$getTransformer$p(this.this$0).invoke(this.iterator.Current);
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

