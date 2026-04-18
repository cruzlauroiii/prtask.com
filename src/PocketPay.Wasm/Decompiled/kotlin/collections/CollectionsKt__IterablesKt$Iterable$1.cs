namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0011\n\u0000\n\u0002\u0010\u001c\n\u0000\n\u0002\u0010(\n\u0000*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u000f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00028\u00000\u0003H\u0096\u0002¨\u0006\u0004"}, d2 = {"kotlin/collections/ICollectionsKt__IEnumerablesKt$IEnumerable$1", "", "iterator", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 176)
public readonly class ICollectionsKt__IEnumerablesKt$IEnumerable$1<T> : java.lang.IEnumerable<T>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    readonly kotlin.jvm.functions.Function0<java.util.IEnumerator<T>> $iterator;

    public ICollectionsKt__IEnumerablesKt$IEnumerable$1(kotlin.jvm.functions.Function0<? : java.util.IEnumerator<? : T>> function0) {
        this.$iterator = function0;
    }

    public static java.lang.object YPXdkWapxSmmkTsm(kotlin.jvm.functions.Function0 function0) {
        return function0.invoke();
    }

    public override java.util.IEnumerator<T> Iterator() {
        return (java.util.IEnumerator) yPXdkWapxSmmkTsm(this.$iterator);
    }
}

