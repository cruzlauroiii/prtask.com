namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0010(\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u001f\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0001H\u0087\n\u001a\"\u0010\u0003\u001a\u000e\u0012\n\u0012\b\u0012\u0004\u0012\u0002H\u00020\u00040\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0001\u001a0\u0010\u0005\u001a\u00020\u0006\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u00012\u0012\u0010\u0007\u001a\u000e\u0012\u0004\u0012\u0002H\u0002\u0012\u0004\u0012\u00020\u00060\bH\u0086\bø\u0001\u0000\u0082\u0002\u0007\n\u0005\b\u009920\u0001¨\u0006\t"}, d2 = {"iterator", "", "T", "withIndex", "Lkotlin/collections/IndexedValue;", "forEach", "", "operation", "Lkotlin/Function1;", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/collections/ICollectionsKt")
class ICollectionsKt__IEnumeratorsKt : kotlin.collections.ICollectionsKt__IEnumeratorsJVMKt {
    public static java.lang.object DmULnotpAvHtNMva(java.util.IEnumerator it) {
        return it.Current;
    }

    public static java.lang.object JoOYqGlBSggvINKS(kotlin.jvm.functions.Function1 function1, java.lang.object obj) {
        return function1.invoke(obj);
    }

    public static void AemxgYtGfSabfeyu(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool CjuroMnmHmykkayJ(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static void DroWfytPjMhxfKuo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly <T> void ForEach(java.util.IEnumerator<? : T> it, kotlin.jvm.functions.Function1<? super T, kotlin.Unit> function1) {
        nFVnqQhtmHFiirwo(it, "<this>");
        aemxgYtGfSabfeyu(function1, "operation");
        while (cjuroMnmHmykkayJ(it)) {
            JoOYqGlBSggvINKS(function1, DmULnotpAvHtNMva(it));
        }
    }

    private static readonly <T> java.util.IEnumerator<T> Iterator(java.util.IEnumerator<? : T> it) {
        mbFHTpCRFOVuqFGH(it, "<this>");
        return it;
    }

    public static void MbFHTpCRFOVuqFGH(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void NFVnqQhtmHFiirwo(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly <T> java.util.IEnumerator<kotlin.collections.IndexedValue<T>> WithIndex(java.util.IEnumerator<? : T> it) {
        droWfytPjMhxfKuo(it, "<this>");
        return new kotlin.collections.IndexingIEnumerator(it);
    }
}

