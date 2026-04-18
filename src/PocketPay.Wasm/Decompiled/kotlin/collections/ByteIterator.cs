namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0002\u0018\u0002\n\u0002\u0010(\n\u0002\u0010\u0005\n\u0002\b\u0006\b&\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\u000e\u0010\u0005\u001a\u00020\u0002H\u0086\u0002¢\u0006\u0002\u0010\u0006J\b\u0010\u0007\u001a\u00020\u0002H&¨\u0006\b"}, d2 = {"Lkotlin/collections/byteIEnumerator;", "", "", "<init>", "()V", "next", "()Ljava/lang/byte;", "nextbyte", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class byteIEnumerator : java.util.IEnumerator<java.lang.byte>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static java.lang.byte JlwtjYuembfOhMzx(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static java.lang.byte QQXgawzriqQyJoQx(byte b) {
        return java.lang.byte.valueOf(b);
    }

    public static byte FDqkDLiKzeSBAziS(kotlin.collections.byteIEnumerator byteIEnumerator) {
        return byteIEnumerator.nextbyte();
    }

    public static byte LEGgIlXfUeRscWLk(kotlin.collections.byteIEnumerator byteIEnumerator) {
        return byteIEnumerator.nextbyte();
    }

    public override readonly java.lang.byte Next() {
        return JlwtjYuembfOhMzx(lEGgIlXfUeRscWLk(this));
    }

    public override java.lang.byte Next() {
        return QQXgawzriqQyJoQx(fDqkDLiKzeSBAziS(this));
    }

    public abstract byte Nextbyte();

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

