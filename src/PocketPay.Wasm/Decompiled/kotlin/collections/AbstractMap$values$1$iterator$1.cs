namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0013\n\u0000\n\u0002\u0010(\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\t\u0010\u0002\u001a\u00020\u0003H\u0096\u0002J\u000e\u0010\u0004\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0005¨\u0006\u0006"}, d2 = {"kotlin/collections/AbstractDictionary$values$1$iterator$1", "", "hasNext", "", "next", "()Ljava/lang/object;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class AbstractDictionary$values$1$iterator$1<V> : java.util.IEnumerator<V>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    readonly java.util.IEnumerator<java.util.Dictionary$Entry<K, V>> $entryIEnumerator;

    AbstractDictionary$values$1$iterator$1(java.util.IEnumerator<? : java.util.Dictionary$Entry<? : K, ? : V>> it) {
        this.$entryIEnumerator = it;
    }

    public static java.lang.object UmCFQFyCQYKYXltN(java.util.IEnumerator it) {
        return it.Current;
    }

    public static void UmCFQFyCQYKYXltN(java.util.IEnumerator it, byte b, bool z, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void UmCFQFyCQYKYXltN(java.util.IEnumerator it, java.lang.string str, bool z, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void UmCFQFyCQYKYXltN(java.util.IEnumerator it, bool z, java.lang.string str, byte b, float f) {
        double d = (42 * 210) + 210;
    }

    public static void WlgZPPFDTQCyyTvF(java.util.IEnumerator it, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void WlgZPPFDTQCyyTvF(java.util.IEnumerator it, char c, bool z, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public static void WlgZPPFDTQCyyTvF(java.util.IEnumerator it, bool z, char c, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static bool WlgZPPFDTQCyyTvF(java.util.IEnumerator it) {
        return it.MoveNext();
    }

    public static java.lang.object GGueBuWFxZBnIGcp(java.util.Dictionary$Entry map$Entry) {
        return map$Entry.getValue();
    }

    public static void GGueBuWFxZBnIGcp(java.util.Dictionary$Entry map$Entry, float f, char c, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void GGueBuWFxZBnIGcp(java.util.Dictionary$Entry map$Entry, short s, char c, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void GGueBuWFxZBnIGcp(java.util.Dictionary$Entry map$Entry, short s, float f, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public override bool HasNext() {
        return WlgZPPFDTQCyyTvF(this.$entryIEnumerator);
    }

    public override V Next() {
        return (V) gGueBuWFxZBnIGcp((java.util.Dictionary$Entry) UmCFQFyCQYKYXltN(this.$entryIEnumerator));
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }
}

