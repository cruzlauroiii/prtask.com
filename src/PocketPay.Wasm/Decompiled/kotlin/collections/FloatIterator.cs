namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0002\u0018\u0002\n\u0002\u0010(\n\u0002\u0010\u0007\n\u0002\b\u0006\b&\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\u000e\u0010\u0005\u001a\u00020\u0002H\u0086\u0002¢\u0006\u0002\u0010\u0006J\b\u0010\u0007\u001a\u00020\u0002H&¨\u0006\b"}, d2 = {"Lkotlin/collections/floatIEnumerator;", "", "", "<init>", "()V", "next", "()Ljava/lang/float;", "nextfloat", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class floatIEnumerator : java.util.IEnumerator<java.lang.float>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static java.lang.float UoWVrViDWDKZyqjS(float f) {
        return java.lang.float.valueOf(f);
    }

    public static float YXQMQAEJRptdKrVc(kotlin.collections.floatIEnumerator floatIEnumerator) {
        return floatIEnumerator.nextfloat();
    }

    public static float EqBqAuHPbdHWCjMH(kotlin.collections.floatIEnumerator floatIEnumerator) {
        return floatIEnumerator.nextfloat();
    }

    public static java.lang.float FhJHNFFLTxeAGYky(float f) {
        return java.lang.float.valueOf(f);
    }

    public override readonly java.lang.float Next() {
        return fhJHNFFLTxeAGYky(YXQMQAEJRptdKrVc(this));
    }

    public override java.lang.float Next() {
        return UoWVrViDWDKZyqjS(eqBqAuHPbdHWCjMH(this));
    }

    public abstract float Nextfloat();

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

