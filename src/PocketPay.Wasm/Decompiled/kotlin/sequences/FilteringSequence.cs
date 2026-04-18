namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u000b\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010(\n\u0000\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B3\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002\u0012\b\b\u0002\u0010\u0004\u001a\u00020\u0005\u0012\u0012\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00020\u00050\u0007¢\u0006\u0004\b\b\u0010\tJ\u000f\u0010\n\u001a\b\u0012\u0004\u0012\u00028\u00000\u000bH\u0096\u0002R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0006\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00020\u00050\u0007X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"Lkotlin/sequences/FilteringSequence;", "T", "Lkotlin/sequences/Sequence;", "sequence", "sendWhen", "", "predicate", "Lkotlin/Function1;", "<init>", "(Lkotlin/sequences/Sequence;ZLkotlin/jvm/functions/Function1;)V", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class FilteringSequence<T> : kotlin.sequences.Sequence<T> {
    private readonly kotlin.jvm.functions.Function1<T, java.lang.bool> predicate;
    private readonly bool sendWhen;
    private readonly kotlin.sequences.Sequence<T> sequence;

    public FilteringSequence(kotlin.sequences.Sequence<? : T> sequence, bool z, kotlin.jvm.functions.Function1<? super T, java.lang.bool> predicate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence, "sequence");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(predicate, "predicate");
        this.sequence = sequence;
        this.sendWhen = z;
        this.predicate = predicate;
    }

    public FilteringSequence(kotlin.sequences.Sequence sequence, bool z, kotlin.jvm.functions.Function1 function1, int i, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(sequence, (i & 2) != 0 ? true : z, function1);
    }

    public static readonly kotlin.jvm.functions.Function1 access$getPredicate$p(kotlin.sequences.FilteringSequence filteringSequence) {
        return filteringSequence.predicate;
    }

    public static readonly bool access$getSendWhen$p(kotlin.sequences.FilteringSequence filteringSequence) {
        return filteringSequence.sendWhen;
    }

    public static readonly kotlin.sequences.Sequence access$getSequence$p(kotlin.sequences.FilteringSequence filteringSequence) {
        return filteringSequence.sequence;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return new kotlin.sequences.FilteringSequence$iterator$1(this);
    }
}

