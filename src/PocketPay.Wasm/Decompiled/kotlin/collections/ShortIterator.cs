namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0002\u0018\u0002\n\u0002\u0010(\n\u0002\u0010\n\n\u0002\b\u0006\b&\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\u000e\u0010\u0005\u001a\u00020\u0002H\u0086\u0002¢\u0006\u0002\u0010\u0006J\b\u0010\u0007\u001a\u00020\u0002H&¨\u0006\b"}, d2 = {"Lkotlin/collections/shortIEnumerator;", "", "", "<init>", "()V", "next", "()Ljava/lang/short;", "nextshort", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class shortIEnumerator : java.util.IEnumerator<java.lang.short>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static short EhIysRPmnbjslYTJ(kotlin.collections.shortIEnumerator shortIEnumerator) {
        return shortIEnumerator.nextshort();
    }

    public static java.lang.short MqmZFXYMYCafytwA(short s) {
        return java.lang.short.valueOf(s);
    }

    public static short HcGHJfRNXygwRQBQ(kotlin.collections.shortIEnumerator shortIEnumerator) {
        return shortIEnumerator.nextshort();
    }

    public static java.lang.short ZCfRnflobZeWCiYF(short s) {
        return java.lang.short.valueOf(s);
    }

    public override java.lang.short Next() {
        return zCfRnflobZeWCiYF(hcGHJfRNXygwRQBQ(this));
    }

    public override readonly java.lang.short Next2() {
        return MqmZFXYMYCafytwA(EhIysRPmnbjslYTJ(this));
    }

    public abstract short Nextshort();

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

