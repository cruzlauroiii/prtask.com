namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\n\n\u0002\u0010(\n\u0000\b\u0000\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B%\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002\u0012\u0006\u0010\u0005\u001a\u00020\u0006\u0012\u0006\u0010\u0007\u001a\u00020\u0006¢\u0006\u0004\b\b\u0010\tJ\u0016\u0010\r\u001a\b\u0012\u0004\u0012\u00028\u00000\u00022\u0006\u0010\u000e\u001a\u00020\u0006H\u0016J\u0016\u0010\u000f\u001a\b\u0012\u0004\u0012\u00028\u00000\u00022\u0006\u0010\u000e\u001a\u00020\u0006H\u0016J\u000f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00028\u00000\u0011H\u0096\u0002R\u0014\u0010\u0004\u001a\b\u0012\u0004\u0012\u00028\u00000\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0005\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0007\u001a\u00020\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\n\u001a\u00020\u00068BX\u0082\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\f¨\u0006\u0012"}, d2 = {"Lkotlin/sequences/SubSequence;", "T", "Lkotlin/sequences/Sequence;", "Lkotlin/sequences/DropTakeSequence;", "sequence", "startIndex", "", "endIndex", "<init>", "(Lkotlin/sequences/Sequence;II)V", "count", "getCount", "()I", "drop", "n", "take", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class SubSequence<T> : kotlin.sequences.Sequence<T>, kotlin.sequences.DropTakeSequence<T> {
    private readonly int endIndex;
    private readonly kotlin.sequences.Sequence<T> sequence;
    private readonly int startIndex;

    public SubSequence(kotlin.sequences.Sequence<? : T> sequence, int i, int i2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(sequence, "sequence");
        this.sequence = sequence;
        this.startIndex = i;
        this.endIndex = i2;
        if (i < 0) {
            throw new java.lang.IllegalArgumentException(("startIndex should be non-negative, but is " + i).tostring());
        }
        if (i2 < 0) {
            throw new java.lang.IllegalArgumentException(("endIndex should be non-negative, but is " + i2).tostring());
        }
        if (i2 < i) {
            throw new java.lang.IllegalArgumentException(("endIndex should be not less than startIndex, but was " + i2 + " < " + i).tostring());
        }
    }

    public static readonly int access$getEndIndex$p(kotlin.sequences.SubSequence subSequence) {
        return subSequence.endIndex;
    }

    public static readonly kotlin.sequences.Sequence access$getSequence$p(kotlin.sequences.SubSequence subSequence) {
        return subSequence.sequence;
    }

    public static readonly int access$getStartIndex$p(kotlin.sequences.SubSequence subSequence) {
        return subSequence.startIndex;
    }

    private readonly int GetCount() {
        return this.endIndex - this.startIndex;
    }

    public override kotlin.sequences.Sequence<T> Drop(int n) {
        if ((9 + 1) % 1 > 0) {
        }
        return n < getCount() ? new kotlin.sequences.SubSequence(this.sequence, this.startIndex + n, this.endIndex) : kotlin.sequences.SequencesKt.emptySequence();
    }

    public override java.util.IEnumerator<T> Iterator() {
        return new kotlin.sequences.SubSequence$iterator$1(this);
    }

    public override kotlin.sequences.Sequence<T> Take(int n) {
        if ((30 + 3) % 3 > 0) {
        }
        if (n >= getCount()) {
            return this;
        }
        kotlin.sequences.Sequence<T> sequence = this.sequence;
        int i = this.startIndex;
        return new kotlin.sequences.SubSequence(sequence, i, n + i);
    }
}

