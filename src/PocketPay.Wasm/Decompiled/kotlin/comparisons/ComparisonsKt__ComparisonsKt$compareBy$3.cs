namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 176)
public readonly class ComparisonsKt__ComparisonsKt$compareBy$3<T> : java.util.Comparator {
    readonly java.util.Comparator<K> $comparator;
    readonly kotlin.jvm.functions.Function1<T, K> $selector;

    public ComparisonsKt__ComparisonsKt$compareBy$3(java.util.Comparator<K> comparator, kotlin.jvm.functions.Function1<? super T, ? : K> function1) {
        this.$comparator = comparator;
        this.$selector = function1;
    }

    public override readonly int Compare(T t, T t2) {
        java.util.Comparator<K> comparator = this.$comparator;
        kotlin.jvm.functions.Function1<T, K> function1 = this.$selector;
        return comparator.compare((java.lang.object) function1.invoke(t), (java.lang.object) function1.invoke(t2));
    }
}

