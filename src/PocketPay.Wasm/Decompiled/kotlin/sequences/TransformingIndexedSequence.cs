namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010(\n\u0000\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u00022\b\u0012\u0004\u0012\u0002H\u00020\u0003B/\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003\u0012\u0018\u0010\u0005\u001a\u0014\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0006¢\u0006\u0004\b\b\u0010\tJ\u000f\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00010\u000bH\u0096\u0002R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R \u0010\u0005\u001a\u0014\u0012\u0004\u0012\u00020\u0007\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lkotlin/sequences/TransformingIndexedSequence;", "T", "R", "Lkotlin/sequences/Sequence;", "sequence", "transformer", "Lkotlin/Function2;", "", "<init>", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)V", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class TransformingIndexedSequence<T, R> : kotlin.sequences.Sequence<R> {
    private readonly kotlin.sequences.Sequence<T> sequence;
    private readonly kotlin.jvm.functions.Function2<java.lang.int, T, R> transformer;

    public TransformingIndexedSequence(kotlin.sequences.Sequence<? : T> sequence, kotlin.jvm.functions.Function2<? super java.lang.int, ? super T, ? : R> transformer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence, "sequence");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(transformer, "transformer");
        this.sequence = sequence;
        this.transformer = transformer;
    }

    public static readonly kotlin.sequences.Sequence access$getSequence$p(kotlin.sequences.TransformingIndexedSequence transformingIndexedSequence) {
        return transformingIndexedSequence.sequence;
    }

    public static readonly kotlin.jvm.functions.Function2 access$getTransformer$p(kotlin.sequences.TransformingIndexedSequence transformingIndexedSequence) {
        return transformingIndexedSequence.transformer;
    }

    public override java.util.IEnumerator<R> Iterator() {
        return new kotlin.sequences.TransformingIndexedSequence$iterator$1(this);
    }
}

