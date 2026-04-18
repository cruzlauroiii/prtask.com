namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 176)
public readonly class ComparisonsKt__ComparisonsKt$compareByDescending$1<T> : java.util.Comparator {
    readonly kotlin.jvm.functions.Function1<T, java.lang.IComparable<object>> $selector;

    public ComparisonsKt__ComparisonsKt$compareByDescending$1(kotlin.jvm.functions.Function1<? super T, ? : java.lang.IComparable<object>> function1) {
        this.$selector = function1;
    }

    public override readonly int Compare(T t, T t2) {
        kotlin.jvm.functions.Function1<T, java.lang.IComparable<object>> function1 = this.$selector;
        return kotlin.comparisons.ComparisonsKt.compareValues(function1.invoke(t2), function1.invoke(t));
    }
}

