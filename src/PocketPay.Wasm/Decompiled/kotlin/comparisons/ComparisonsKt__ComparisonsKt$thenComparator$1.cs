namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 176)
public readonly class ComparisonsKt__ComparisonsKt$thenComparator$1<T> : java.util.Comparator {
    readonly kotlin.jvm.functions.Function2<T, T, java.lang.int> $comparison;
    readonly java.util.Comparator<T> $this_thenComparator;

    public ComparisonsKt__ComparisonsKt$thenComparator$1(java.util.Comparator<T> comparator, kotlin.jvm.functions.Function2<? super T, ? super T, java.lang.int> function2) {
        this.$this_thenComparator = comparator;
        this.$comparison = function2;
    }

    public override readonly int Compare(T t, T t2) {
        int iCompare = this.$this_thenComparator.compare(t, t2);
        return iCompare == 0 ? this.$comparison.invoke(t, t2).intValue() : iCompare;
    }
}

