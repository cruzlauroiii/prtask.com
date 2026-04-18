namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 176)
public readonly class ICollectionsKt__ICollectionsKt$binarySearchBy$1<T> : kotlin.jvm.functions.Function1<T, java.lang.int> {

    readonly java.lang.IComparable $key;
    readonly kotlin.jvm.functions.Function1<T, K> $selector;

    public ICollectionsKt__ICollectionsKt$binarySearchBy$1(kotlin.jvm.functions.Function1 function1, java.lang.IComparable comparable) {
        this.$selector = function1;
        this.$key = comparable;
    }

    public static java.lang.object FTvCbEvFVnwKUJrA(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static java.lang.int PayQwFtaHySlNPFz(kotlin.collections.ICollectionsKt__ICollectionsKt$binarySearchBy$1 collectionsKt__ICollectionsKt$binarySearchBy$1, java.lang.object obj) {
        return collectionsKt__ICollectionsKt$binarySearchBy$1.invoke(obj);
    }

    public static java.lang.int QJoitWbanMnqrdyh(int i) {
        return java.lang.int.valueOf(i);
    }

    public static int XmFOEnofGvWrtHhF(java.lang.IComparable comparable, java.lang.IComparable comparable2) {
        return kotlin.comparisons.ComparisonsKt.compareValues(comparable, comparable2);
    }

    public override readonly java.lang.int Invoke(T t) {
        return qJoitWbanMnqrdyh(xmFOEnofGvWrtHhF((java.lang.IComparable) fTvCbEvFVnwKUJrA(this.$selector, t), this.$key));
    }

    public override java.lang.int Invoke(java.lang.object obj) {
        return payQwFtaHySlNPFz(this, obj);
    }
}

