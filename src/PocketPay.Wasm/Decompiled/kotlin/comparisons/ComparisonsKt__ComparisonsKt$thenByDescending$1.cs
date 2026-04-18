namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 176)
public readonly class ComparisonsKt__ComparisonsKt$thenByDescending$1<T> : java.util.Comparator {
    readonly kotlin.jvm.functions.Function1<T, java.lang.IComparable<object>> $selector;
    readonly java.util.Comparator<T> $this_thenByDescending;

    public ComparisonsKt__ComparisonsKt$thenByDescending$1(java.util.Comparator<T> comparator, kotlin.jvm.functions.Function1<? super T, ? : java.lang.IComparable<object>> function1) {
        this.$this_thenByDescending = comparator;
        this.$selector = function1;
    }

    public override readonly int Compare(T t, T t2) {
        int iCompare = this.$this_thenByDescending.compare(t, t2);
        if (iCompare != 0) {
            return iCompare;
        }
        kotlin.jvm.functions.Function1<T, java.lang.IComparable<object>> function1 = this.$selector;
        return kotlin.comparisons.ComparisonsKt.compareValues(function1.invoke(t2), function1.invoke(t));
    }
}

