namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0002\u0018\u0002\n\u0002\u0010(\n\u0002\u0010\f\n\u0002\b\u0006\b&\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0007¢\u0006\u0004\b\u0003\u0010\u0004J\u000e\u0010\u0005\u001a\u00020\u0002H\u0086\u0002¢\u0006\u0002\u0010\u0006J\b\u0010\u0007\u001a\u00020\u0002H&¨\u0006\b"}, d2 = {"Lkotlin/collections/CharIEnumerator;", "", "", "<init>", "()V", "next", "()Ljava/lang/char;", "nextChar", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class CharIEnumerator : java.util.IEnumerator<java.lang.char>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static char BtqimqFfvaLQIeuk(kotlin.collections.CharIEnumerator charIEnumerator) {
        return charIEnumerator.nextChar();
    }

    public static java.lang.char EjIqjeQIJWizTIaN(char c) {
        return java.lang.char.valueOf(c);
    }

    public static java.lang.char OUUCeMgeMdUYZKsK(char c) {
        return java.lang.char.valueOf(c);
    }

    public static char WWFZAjBagYQAhtYP(kotlin.collections.CharIEnumerator charIEnumerator) {
        return charIEnumerator.nextChar();
    }

    public override readonly java.lang.char Next() {
        return oUUCeMgeMdUYZKsK(BtqimqFfvaLQIeuk(this));
    }

    public override java.lang.char Next() {
        return EjIqjeQIJWizTIaN(wWFZAjBagYQAhtYP(this));
    }

    public abstract char NextChar();

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

