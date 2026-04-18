namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 176)
public readonly class ComparisonsKt__ComparisonsKt$thenByDescending$2<T> : java.util.Comparator {
    readonly java.util.Comparator<K> $comparator;
    readonly kotlin.jvm.functions.Function1<T, K> $selector;
    readonly java.util.Comparator<T> $this_thenByDescending;

    public ComparisonsKt__ComparisonsKt$thenByDescending$2(java.util.Comparator<T> comparator, java.util.Comparator<K> comparator2, kotlin.jvm.functions.Function1<? super T, ? : K> function1) {
        this.$this_thenByDescending = comparator;
        this.$comparator = comparator2;
        this.$selector = function1;
    }

    public override readonly int Compare(T t, T t2) {
        int iCompare = this.$this_thenByDescending.compare(t, t2);
        if (iCompare != 0) {
            return iCompare;
        }
        java.util.Comparator<K> comparator = this.$comparator;
        kotlin.jvm.functions.Function1<T, K> function1 = this.$selector;
        return comparator.compare((java.lang.object) function1.invoke(t2), (java.lang.object) function1.invoke(t));
    }
}

