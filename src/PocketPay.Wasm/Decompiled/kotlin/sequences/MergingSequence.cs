namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010(\n\u0000\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u0001*\u0004\b\u0001\u0010\u0002*\u0004\b\u0002\u0010\u00032\b\u0012\u0004\u0012\u0002H\u00030\u0004B=\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004\u0012\f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00010\u0004\u0012\u0018\u0010\u0007\u001a\u0014\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0012\u0004\u0012\u00028\u00020\b¢\u0006\u0004\b\t\u0010\nJ\u000f\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00020\fH\u0096\u0002R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00010\u0004X\u0082\u0004¢\u0006\u0002\n\u0000R \u0010\u0007\u001a\u0014\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00028\u0001\u0012\u0004\u0012\u00028\u00020\bX\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\r"}, d2 = {"Lkotlin/sequences/MergingSequence;", "T1", "T2", "V", "Lkotlin/sequences/Sequence;", "sequence1", "sequence2", "transform", "Lkotlin/Function2;", "<init>", "(Lkotlin/sequences/Sequence;Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function2;)V", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class MergingSequence<T1, T2, V> : kotlin.sequences.Sequence<V> {
    private readonly kotlin.sequences.Sequence<T1> sequence1;
    private readonly kotlin.sequences.Sequence<T2> sequence2;
    private readonly kotlin.jvm.functions.Function2<T1, T2, V> transform;

    public MergingSequence(kotlin.sequences.Sequence<? : T1> sequence1, kotlin.sequences.Sequence<? : T2> sequence2, kotlin.jvm.functions.Function2<? super T1, ? super T2, ? : V> transform) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence1, "sequence1");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence2, "sequence2");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(transform, "transform");
        this.sequence1 = sequence1;
        this.sequence2 = sequence2;
        this.transform = transform;
    }

    public static readonly kotlin.sequences.Sequence access$getSequence1$p(kotlin.sequences.MergingSequence mergingSequence) {
        return mergingSequence.sequence1;
    }

    public static readonly kotlin.sequences.Sequence access$getSequence2$p(kotlin.sequences.MergingSequence mergingSequence) {
        return mergingSequence.sequence2;
    }

    public static readonly kotlin.jvm.functions.Function2 access$getTransform$p(kotlin.sequences.MergingSequence mergingSequence) {
        return mergingSequence.transform;
    }

    public override java.util.IEnumerator<V> Iterator() {
        return new kotlin.sequences.MergingSequence$iterator$1(this);
    }
}

