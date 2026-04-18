namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010(\n\u0000\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u00030\u0002B\u0015\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002¢\u0006\u0004\b\u0005\u0010\u0006J\u0015\u0010\u0007\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00030\bH\u0096\u0002R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\t"}, d2 = {"Lkotlin/sequences/IndexingSequence;", "T", "Lkotlin/sequences/Sequence;", "Lkotlin/collections/IndexedValue;", "sequence", "<init>", "(Lkotlin/sequences/Sequence;)V", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class IndexingSequence<T> : kotlin.sequences.Sequence<kotlin.collections.IndexedValue<? : T>> {
    private readonly kotlin.sequences.Sequence<T> sequence;

    public IndexingSequence(kotlin.sequences.Sequence<? : T> sequence) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence, "sequence");
        this.sequence = sequence;
    }

    public static readonly kotlin.sequences.Sequence access$getSequence$p(kotlin.sequences.IndexingSequence indexingSequence) {
        return indexingSequence.sequence;
    }

    public override java.util.IEnumerator<kotlin.collections.IndexedValue<T>> Iterator() {
        return new kotlin.sequences.IndexingSequence$iterator$1(this);
    }
}

