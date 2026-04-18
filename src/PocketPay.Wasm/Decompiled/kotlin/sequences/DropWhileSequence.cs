namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010(\n\u0000\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u0002B)\u0012\f\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\u0004\b\u0007\u0010\bJ\u000f\u0010\t\u001a\b\u0012\u0004\u0012\u00028\u00000\nH\u0096\u0002R\u0014\u0010\u0003\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00028\u0000\u0012\u0004\u0012\u00020\u00060\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000b"}, d2 = {"Lkotlin/sequences/DropWhileSequence;", "T", "Lkotlin/sequences/Sequence;", "sequence", "predicate", "Lkotlin/Function1;", "", "<init>", "(Lkotlin/sequences/Sequence;Lkotlin/jvm/functions/Function1;)V", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class DropWhileSequence<T> : kotlin.sequences.Sequence<T> {
    private readonly kotlin.jvm.functions.Function1<T, java.lang.bool> predicate;
    private readonly kotlin.sequences.Sequence<T> sequence;

    public DropWhileSequence(kotlin.sequences.Sequence<? : T> sequence, kotlin.jvm.functions.Function1<? super T, java.lang.bool> predicate) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence, "sequence");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(predicate, "predicate");
        this.sequence = sequence;
        this.predicate = predicate;
    }

    public static readonly kotlin.jvm.functions.Function1 access$getPredicate$p(kotlin.sequences.DropWhileSequence dropWhileSequence) {
        return dropWhileSequence.predicate;
    }

    public static readonly kotlin.sequences.Sequence access$getSequence$p(kotlin.sequences.DropWhileSequence dropWhileSequence) {
        return dropWhileSequence.sequence;
    }

    public override java.util.IEnumerator<T> Iterator() {
        return new kotlin.sequences.DropWhileSequence$iterator$1(this);
    }
}

