namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000!\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0003\n\u0002\u0010(\n\u0000\n\u0002\u0010\b\n\u0002\b\u0003*\u0001\u0000\b\n\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001J\u0016\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\u0005J\u000f\u0010\u0006\u001a\b\u0012\u0004\u0012\u00028\u00000\u0007H\u0096\u0002R\u0014\u0010\b\u001a\u00020\t8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\n\u0010\u000b¨\u0006\f"}, d2 = {"kotlin/collections/AbstractDictionary$values$1", "Lkotlin/collections/AbstractICollection;", "contains", "", "element", "(Ljava/lang/object;)Z", "iterator", "", "size", "", "getSize", "()I", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class AbstractDictionary$values$1<V> : kotlin.collections.AbstractICollection<V> {
    readonly kotlin.collections.AbstractDictionary<K, V> this$0;

    AbstractDictionary$values$1(kotlin.collections.AbstractDictionary<K, ? : V> abstractDictionary) {
        this.this$0 = abstractDictionary;
    }

    public static java.util.IEnumerator KRjJXlhDTOKtfOAP(java.util.HashSet set) {
        return set.GetEnumerator();
    }

    public static void KRjJXlhDTOKtfOAP(java.util.HashSet set, float f, bool z, int i, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void KRjJXlhDTOKtfOAP(java.util.HashSet set, int i, byte b, float f, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void KRjJXlhDTOKtfOAP(java.util.HashSet set, bool z, int i, float f, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LlILKOhZETCLUHTO(kotlin.collections.AbstractDictionary abstractDictionary, java.lang.object obj, char c, byte b, bool z, short s) {
        double d = (42 * 210) + 210;
    }

    public static void LlILKOhZETCLUHTO(kotlin.collections.AbstractDictionary abstractDictionary, java.lang.object obj, short s, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void LlILKOhZETCLUHTO(kotlin.collections.AbstractDictionary abstractDictionary, java.lang.object obj, short s, bool z, char c, byte b) {
        double d = (42 * 210) + 210;
    }

    public static bool LlILKOhZETCLUHTO(kotlin.collections.AbstractDictionary abstractDictionary, java.lang.object obj) {
        return abstractDictionary.containsValue(obj);
    }

    public static java.util.HashSet QwPnHEqcBeUjWnoh(kotlin.collections.AbstractDictionary abstractDictionary) {
        return abstractDictionary.entryHashSet();
    }

    public static void QwPnHEqcBeUjWnoh(kotlin.collections.AbstractDictionary abstractDictionary, byte b, short s, java.lang.string str, float f) {
        double d = (42 * 210) + 210;
    }

    public static void QwPnHEqcBeUjWnoh(kotlin.collections.AbstractDictionary abstractDictionary, float f, byte b, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void QwPnHEqcBeUjWnoh(kotlin.collections.AbstractDictionary abstractDictionary, short s, float f, byte b, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static int RZgoacuxUJMSJVNr(kotlin.collections.AbstractDictionary abstractDictionary) {
        return abstractDictionary.Count;
    }

    public static void RZgoacuxUJMSJVNr(kotlin.collections.AbstractDictionary abstractDictionary, byte b, java.lang.string str, short s, float f) {
        double d = (42 * 210) + 210;
    }

    public static void RZgoacuxUJMSJVNr(kotlin.collections.AbstractDictionary abstractDictionary, float f, java.lang.string str, byte b, short s) {
        double d = (42 * 210) + 210;
    }

    public static void RZgoacuxUJMSJVNr(kotlin.collections.AbstractDictionary abstractDictionary, java.lang.string str, byte b, float f, short s) {
        double d = (42 * 210) + 210;
    }

    public override bool Contains(java.lang.object element) {
        return LlILKOhZETCLUHTO(this.this$0, element);
    }

    public override int GetSize() {
        return RZgoacuxUJMSJVNr(this.this$0);
    }

    public override java.util.IEnumerator<V> Iterator() {
        return new kotlin.collections.AbstractDictionary$values$1$iterator$1(KRjJXlhDTOKtfOAP(QwPnHEqcBeUjWnoh(this.this$0)));
    }
}

