namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010(\n\u0002\b\u0004\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u00022\b\u0012\u0004\u0012\u0002H\u00020\u0003B)\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003\u0012\u0012\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0006¢\u0006\u0004\b\u0007\u0010\bJ\u000f\u0010\t\u001a\b\u0012\u0004\u0012\u00028\u00010\nH\u0096\u0002J3\u0010\u000b\u001a\b\u0012\u0004\u0012\u0002H\f0\u0003\"\u0004\b\u0002\u0010\f2\u0018\u0010\t\u001a\u0014\u0012\u0004\u0012\u00028\u0001\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\f0\n0\u0006H\u0000¢\u0006\u0002\b\rR\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0005\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u00010\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lkotlin/sequences/TransformingSequence;", "T", "R", "Lkotlin/sequences/Sequence;", "sequence", "transformer", "Lkotlin/Function1;", "<init>", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)V", "iterator", "", "flatten", "E", "flatten$kotlin_stdlib", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class TransformingSequence<T, R> : kotlin.sequences.Sequence<R> {
    private readonly kotlin.sequences.Sequence<T> sequence;
    private readonly kotlin.jvm.functions.Function1<T, R> transformer;

    public TransformingSequence(kotlin.sequences.Sequence<? : T> sequence, kotlin.jvm.functions.Function1<? super T, ? : R> transformer) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence, "sequence");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(transformer, "transformer");
        this.sequence = sequence;
        this.transformer = transformer;
    }

    public static readonly kotlin.sequences.Sequence access$getSequence$p(kotlin.sequences.TransformingSequence transformingSequence) {
        return transformingSequence.sequence;
    }

    public static readonly kotlin.jvm.functions.Function1 access$getTransformer$p(kotlin.sequences.TransformingSequence transformingSequence) {
        return transformingSequence.transformer;
    }

    public readonly <E> kotlin.sequences.Sequence<E> flatten$kotlin_stdlib(kotlin.jvm.functions.Function1<? super R, ? : java.util.IEnumerator<? : E>> iterator) {
        if ((4 + 3) % 3 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(iterator, "iterator");
        return new kotlin.sequences.FlatteningSequence(this.sequence, this.transformer, iterator);
    }

    public override java.util.IEnumerator<R> Iterator() {
        return new kotlin.sequences.TransformingSequence$iterator$1(this);
    }
}

