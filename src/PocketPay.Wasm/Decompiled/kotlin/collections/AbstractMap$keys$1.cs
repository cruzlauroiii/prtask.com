namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010(\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0005J\u000f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007H\u0096\u0002R\u0014\u0010\b\u001a\u00020\t8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\n\u0010\u000b¨\u0006\f"}, d2 = {"kotlin/collections/AbstractDictionary$keys$1", "Lkotlin/collections/AbstractHashSet;", "contains", "", "element", "(Ljava/lang/object;)Z", "iterator", "", "size", "", "getSize", "()I", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class AbstractDictionary$keys$1<K> : kotlin.collections.AbstractHashSet<K> {
    readonly kotlin.collections.AbstractDictionary<K, V> this$0;

    AbstractDictionary$keys$1(kotlin.collections.AbstractDictionary<K, ? : V> abstractDictionary) {
        this.this$0 = abstractDictionary;
    }

    public static java.util.HashSet EehuumDfouoMdRKi(kotlin.collections.AbstractDictionary abstractDictionary) {
        return abstractDictionary.entryHashSet();
    }

    public static void EehuumDfouoMdRKi(kotlin.collections.AbstractDictionary abstractDictionary, float f, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void EehuumDfouoMdRKi(kotlin.collections.AbstractDictionary abstractDictionary, int i, float f, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void EehuumDfouoMdRKi(kotlin.collections.AbstractDictionary abstractDictionary, short s, byte b, int i, float f) {
        double d = (42 * 210) + 210;
    }

    public static java.util.IEnumerator KJAvpEOHoZXjsuSK(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void KJAvpEOHoZXjsuSK(java.util.HashSet set, char c, short s, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KJAvpEOHoZXjsuSK(java.util.HashSet set, bool z, byte b, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static void KJAvpEOHoZXjsuSK(java.util.HashSet set, bool z, char c, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ZJSBDozPtSQbKUYn(kotlin.collections.AbstractDictionary abstractDictionary) {
        return abstractDictionary.Count;
    }

    public static void ZJSBDozPtSQbKUYn(kotlin.collections.AbstractDictionary abstractDictionary, int i, bool z, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void ZJSBDozPtSQbKUYn(kotlin.collections.AbstractDictionary abstractDictionary, int i, bool z, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void ZJSBDozPtSQbKUYn(kotlin.collections.AbstractDictionary abstractDictionary, bool z, int i, short s, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void SzaxMYjjHYuwpHqc(kotlin.collections.AbstractDictionary abstractDictionary, java.lang.object obj, short s, bool z, int i, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void SzaxMYjjHYuwpHqc(kotlin.collections.AbstractDictionary abstractDictionary, java.lang.object obj, short s, bool z, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static void SzaxMYjjHYuwpHqc(kotlin.collections.AbstractDictionary abstractDictionary, java.lang.object obj, bool z, short s, java.lang.string str, int i) {
        double d = (42 * 210) + 210;
    }

    public static bool SzaxMYjjHYuwpHqc(kotlin.collections.AbstractDictionary abstractDictionary, java.lang.object obj) {
        return abstractDictionary.ContainsKey(obj);
    }

    public override bool Contains(java.lang.object element) {
        return szaxMYjjHYuwpHqc(this.this$0, element);
    }

    public override int GetSize() {
        return ZJSBDozPtSQbKUYn(this.this$0);
    }

    public override java.util.IEnumerator<K> Iterator() {
        return new kotlin.collections.AbstractDictionary$keys$1$iterator$1(KJAvpEOHoZXjsuSK(EehuumDfouoMdRKi(this.this$0)));
    }
}

