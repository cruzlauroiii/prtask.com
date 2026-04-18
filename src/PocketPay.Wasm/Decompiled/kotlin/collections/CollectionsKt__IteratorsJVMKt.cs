namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010(\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u001f\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u0004\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003H\u0086\u0002¨\u0006\u0004"}, d2 = {"iterator", "", "T", "Ljava/util/Enumeration;", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/collections/ICollectionsKt")
class ICollectionsKt__IEnumeratorsJVMKt : kotlin.collections.ICollectionsKt__IEnumerablesKt {
    public static void BiNDNLatnwiNqAAO(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly <T> java.util.IEnumerator<T> Iterator(java.util.Enumeration<T> enumeration) {
        biNDNLatnwiNqAAO(enumeration, "<this>");
        return new kotlin.collections.ICollectionsKt__IEnumeratorsJVMKt$iterator$1(enumeration);
    }
}

