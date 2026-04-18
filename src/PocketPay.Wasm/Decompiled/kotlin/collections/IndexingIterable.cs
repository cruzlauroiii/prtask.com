namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u001c\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010(\n\u0002\b\u0004\b\u0000\u0018\u0000*\u0006\b\u0000\u0010\u0001 \u00012\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00010\u00030\u0002B\u001b\u0012\u0012\u0010\u0004\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00060\u0005¢\u0006\u0004\b\u0007\u0010\bJ\u0015\u0010\t\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00030\u0006H\u0096\u0002R\u001a\u0010\u0004\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u00028\u00000\u00060\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\n"}, d2 = {"Lkotlin/collections/IndexingIEnumerable;", "T", "", "Lkotlin/collections/IndexedValue;", "iteratorFactory", "Lkotlin/Function0;", "", "<init>", "(Lkotlin/jvm/functions/Function0;)V", "iterator", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class IndexingIEnumerable<T> : java.lang.IEnumerable<kotlin.collections.IndexedValue<? : T>>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private readonly kotlin.jvm.functions.Function0<java.util.IEnumerator<T>> iteratorFactory;

    public IndexingIEnumerable(kotlin.jvm.functions.Function0<? : java.util.IEnumerator<? : T>> function0) {
        lLgLnfZEWvxYzYvn(function0, "iteratorFactory");
        this.iteratorFactory = function0;
    }

    public static java.lang.object FGjYyvfowMblhaZX(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public static void LLgLnfZEWvxYzYvn(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public override java.util.IEnumerator<kotlin.collections.IndexedValue<T>> Iterator() {
        return new kotlin.collections.IndexingIEnumerator((java.util.IEnumerator) fGjYyvfowMblhaZX(this.iteratorFactory));
    }
}

