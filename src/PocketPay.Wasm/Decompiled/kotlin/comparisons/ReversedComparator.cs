namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001a\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0007\n\u0002\u0010\b\n\u0002\b\u0005\b\u0002\u0018\u0000*\u0004\b\u0000\u0010\u00012\u0012\u0012\u0004\u0012\u0002H\u00010\u0002j\b\u0012\u0004\u0012\u0002H\u0001`\u0003B\u001f\u0012\u0016\u0010\u0004\u001a\u0012\u0012\u0004\u0012\u00028\u00000\u0002j\b\u0012\u0004\u0012\u00028\u0000`\u0003¢\u0006\u0004\b\u0005\u0010\u0006J\u001d\u0010\n\u001a\u00020\u000b2\u0006\u0010\f\u001a\u00028\u00002\u0006\u0010\r\u001a\u00028\u0000H\u0016¢\u0006\u0002\u0010\u000eJ\u001b\u0010\u000f\u001a\u0012\u0012\u0004\u0012\u00028\u00000\u0002j\b\u0012\u0004\u0012\u00028\u0000`\u0003¢\u0006\u0002\u0010\bR#\u0010\u0004\u001a\u0012\u0012\u0004\u0012\u00028\u00000\u0002j\b\u0012\u0004\u0012\u00028\u0000`\u0003¢\u0006\n\n\u0002\u0010\t\u001a\u0004\b\u0007\u0010\b¨\u0006\u0010"}, d2 = {"Lkotlin/comparisons/ReversedComparator;", "T", "Ljava/util/Comparator;", "Lkotlin/Comparator;", "comparator", "<init>", "(Ljava/util/Comparator;)V", "getComparator", "()Ljava/util/Comparator;", "Ljava/util/Comparator;", "compare", "", "a", "b", "(Ljava/lang/object;Ljava/lang/object;)I", "reversed", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class ReversedComparator<T> : java.util.Comparator<T> {
    private readonly java.util.Comparator<T> comparator;

    public ReversedComparator(java.util.Comparator<T> comparator) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(comparator, "comparator");
        this.comparator = comparator;
    }

    public override int Compare(T a2, T b) {
        return this.comparator.compare(b, a2);
    }

    public readonly java.util.Comparator<T> GetComparator() {
        return this.comparator;
    }

    public override readonly java.util.Comparator<T> Reversed() {
        return this.comparator;
    }
}

