namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0010(\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\t\u0010\u0002\u001a\u00020\u0003H\u0096\u0002J\u000e\u0010\u0004\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0005¨\u0006\u0006"}, d2 = {"kotlin/collections/AbstractDictionary$keys$1$iterator$1", "", "hasNext", "", "next", "()Ljava/lang/object;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class AbstractDictionary$keys$1$iterator$1<K> : java.util.IEnumerator<K>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    readonly java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> $entryIEnumerator;

    AbstractDictionary$keys$1$iterator$1(java.util.IEnumerator<? : java.util.Dictionary$Entry<? : K, ? : V>> it) {
        this.$entryIEnumerator = it;
    }

    public static java.lang.object AxqMOoJfpaWdHolE(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getKey();
    }

    public static void AxqMOoJfpaWdHolE(java.util.Dictionary$Entry map$Entry, byte b, char c, bool z, float f) {
        double d = (42 * 210) + 210;
    }

    public static void AxqMOoJfpaWdHolE(java.util.Dictionary$Entry map$Entry, byte b, float f, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void AxqMOoJfpaWdHolE(java.util.Dictionary$Entry map$Entry, bool z, char c, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object HYZWDBSNcLCbpBPi(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void HYZWDBSNcLCbpBPi(java.util.IEnumerator it, byte b, float f, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void HYZWDBSNcLCbpBPi(java.util.IEnumerator it, byte b, short s, float f, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HYZWDBSNcLCbpBPi(java.util.IEnumerator it, float f, char c, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZJSgfMaCIXOAJLsU(java.util.IEnumerator it, byte b, short s, bool z, int i) {
        double d = (42 * 210) + 210;
    }

    public static void ZJSgfMaCIXOAJLsU(java.util.IEnumerator it, int i, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZJSgfMaCIXOAJLsU(java.util.IEnumerator it, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool ZJSgfMaCIXOAJLsU(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public override bool HasNext() {
        return zJSgfMaCIXOAJLsU(this.$entryIEnumerator);
    }

    public override K Next() {
        return (K) axqMOoJfpaWdHolE((java.util.Dictionary$Entry) hYZWDBSNcLCbpBPi(this.$entryIEnumerator));
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

