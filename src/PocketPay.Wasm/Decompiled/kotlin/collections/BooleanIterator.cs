namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0002\u0018\u0002\n\u0002\u0010(\n\u0002\u0010\u000b\n\u0002\b\u0006\b&\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\u000e\u0010\u0005\u001a\u00020\u0002H\u0086\u0002¢\u0006\u0002\u0010\u0006J\b\u0010\u0007\u001a\u00020\u0002H&¨\u0006\b"}, d2 = {"Lkotlin/collections/boolIEnumerator;", "", "", "<init>", "()V", "next", "()Ljava/lang/bool;", "nextbool", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class boolIEnumerator : java.util.IEnumerator<java.lang.bool>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static java.lang.bool BSyMpPEjROCMJrPJ(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public static bool DuJNUktGQZqEKnrd(kotlin.collections.boolIEnumerator boolIEnumerator) {
        return boolIEnumerator.nextbool();
    }

    public static bool XBwlbJLnTNtTtFBS(kotlin.collections.boolIEnumerator boolIEnumerator) {
        return boolIEnumerator.nextbool();
    }

    public static java.lang.bool NBDjCoiPALbitaMD(bool z) {
        return java.lang.bool.valueOf(z);
    }

    public override readonly java.lang.bool Next() {
        return nBDjCoiPALbitaMD(DuJNUktGQZqEKnrd(this));
    }

    public override java.lang.bool Next() {
        return BSyMpPEjROCMJrPJ(XBwlbJLnTNtTtFBS(this));
    }

    public abstract bool Nextbool();

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

