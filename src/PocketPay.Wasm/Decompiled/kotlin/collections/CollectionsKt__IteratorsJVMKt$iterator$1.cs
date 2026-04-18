namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0010(\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\t\u0010\u0002\u001a\u00020\u0003H\u0096\u0002J\u000e\u0010\u0004\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0005¨\u0006\u0006"}, d2 = {"kotlin/collections/ICollectionsKt__IEnumeratorsJVMKt$iterator$1", "", "hasNext", "", "next", "()Ljava/lang/object;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class ICollectionsKt__IEnumeratorsJVMKt$iterator$1<T> : java.util.IEnumerator<T>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    readonly java.util.Enumeration<T> $this_iterator;

    ICollectionsKt__IEnumeratorsJVMKt$iterator$1(java.util.Enumeration<T> enumeration) {
        this.$this_iterator = enumeration;
    }

    public static java.lang.object CIHnuqqaGDFvEZVi(java.util.Enumeration enumeration) {
        return enumeration.nextElement();
    }

    public static bool YCCkLAJXuHANgcOl(java.util.Enumeration enumeration) {
        return enumeration.hasMoreElements();
    }

    public override bool HasNext() {
        return yCCkLAJXuHANgcOl(this.$this_iterator);
    }

    public override T Next() {
        return (T) cIHnuqqaGDFvEZVi(this.$this_iterator);
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

