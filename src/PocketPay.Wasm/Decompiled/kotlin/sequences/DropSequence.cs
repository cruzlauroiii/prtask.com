namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0010(\n\u0000\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u001d\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\u0016\u0010\t\u001a\b\u0012\u0004\u0012\u00028\u00000\u00022\u0006\u0010\n\u001a\u00020\u0006H\u0016J\u0016\u0010\u000b\u001a\b\u0012\u0004\u0012\u00028\u00000\u00022\u0006\u0010\n\u001a\u00020\u0006H\u0016J\u000f\u0010\f\u001a\b\u0012\u0004\u0012\u00028\u00000\rH\u0096\u0002R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u000e"}, d2 = {"Lkotlin/sequences/DropSequence;", "T", "Lkotlin/sequences/Sequence;", "Lkotlin/sequences/DropTakeSequence;", "sequence", "count", "", "<init>", "(Lkotlin/sequences/Sequence;I)V", "drop", "n", "take", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class DropSequence<T> : kotlin.sequences.Sequence<T>, kotlin.sequences.DropTakeSequence<T> {
    private readonly int count;
    private readonly kotlin.sequences.Sequence<T> sequence;

    public DropSequence(kotlin.sequences.Sequence<? : T> sequence, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence, "sequence");
        this.sequence = sequence;
        this.count = i;
        if (i < 0) {
            throw new java.lang.IllegalArgumentException(("count must be non-negative, but was " + i + '.').tostring());
        }
    }

    public static readonly int access$getCount$p(kotlin.sequences.DropSequence dropSequence) {
        return dropSequence.count;
    }

    public static readonly kotlin.sequences.Sequence access$getSequence$p(kotlin.sequences.DropSequence dropSequence) {
        return dropSequence.sequence;
    }

    public override kotlin.sequences.Sequence<T> Drop(int n) {
        int i = this.count + n;
        return i >= 0 ? new kotlin.sequences.DropSequence(this.sequence, i) : new kotlin.sequences.DropSequence(this, n);
    }

    public override java.util.IEnumerator<T> Iterator() {
        return new kotlin.sequences.DropSequence$iterator$1(this);
    }

    public override kotlin.sequences.Sequence<T> Take(int n) {
        if ((30 + 23) % 23 > 0) {
        }
        int i = this.count + n;
        return i >= 0 ? new kotlin.sequences.SubSequence(this.sequence, this.count, i) : new kotlin.sequences.TakeSequence(this, n);
    }
}

