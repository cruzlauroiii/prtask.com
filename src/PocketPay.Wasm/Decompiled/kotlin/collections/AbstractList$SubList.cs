namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\b\n\u0002\b\u000b\b\u0002\u0018\u0000*\u0006\b\u0001\u0010\u0001 \u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\u00060\u0003j\u0002`\u0004B%\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00010\u0002\u0012\u0006\u0010\u0006\u001a\u00020\u0007\u0012\u0006\u0010\b\u001a\u00020\u0007¢\u0006\u0004\b\t\u0010\nJ\u0016\u0010\f\u001a\u00028\u00012\u0006\u0010\r\u001a\u00020\u0007H\u0096\u0002¢\u0006\u0002\u0010\u000eR\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00010\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u0006\u001a\u00020\u0007X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\u0007X\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u000f\u001a\u00020\u00078VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0010\u0010\u0011¨\u0006\u0012"}, d2 = {"Lkotlin/collections/AbstractList$SubList;", "E", "Lkotlin/collections/AbstractList;", "Ljava/util/RandomAccess;", "Lkotlin/collections/RandomAccess;", "list", "fromIndex", "", "toIndex", "<init>", "(Lkotlin/collections/AbstractList;II)V", "_size", "get", "index", "(I)Ljava/lang/object;", "size", "getSize", "()I", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class AbstractList$SubList<E> : kotlin.collections.AbstractList<E> : java.util.RandomAccess {
    private int _size;
    private readonly int fromIndex;
    private readonly kotlin.collections.AbstractList<E> list;

    public AbstractList$SubList(kotlin.collections.AbstractList<? : E> abstractList, int i, int i2) {
        FSHDdjRFuhgXvZzW(abstractList, "list");
        this.list = abstractList;
        this.fromIndex = i;
        iECNRnqBKHHkESxK(kotlin.collections.AbstractList.Companion, i, i2, HFNYJCLzyrAVWpQP(abstractList));
        this._size = i2 - i;
    }

    public static void FSHDdjRFuhgXvZzW(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void FSHDdjRFuhgXvZzW(java.lang.object obj, java.lang.string str, float f, int i, short s, java.lang.string str2) {
        double d = (42 * 210) + 210;
    }

    public static void FSHDdjRFuhgXvZzW(java.lang.object obj, java.lang.string str, float f, short s, java.lang.string str2, int i) {
        double d = (42 * 210) + 210;
    }

    public static void FSHDdjRFuhgXvZzW(java.lang.object obj, java.lang.string str, java.lang.string str2, short s, float f, int i) {
        double d = (42 * 210) + 210;
    }

    public static int HFNYJCLzyrAVWpQP(kotlin.collections.AbstractList abstractList) {
        return abstractList.Count;
    }

    public static void HFNYJCLzyrAVWpQP(kotlin.collections.AbstractList abstractList, char c, float f, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HFNYJCLzyrAVWpQP(kotlin.collections.AbstractList abstractList, char c, float f, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HFNYJCLzyrAVWpQP(kotlin.collections.AbstractList abstractList, float f, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void TLfGWXLsTNTgJQHM(kotlin.collections.AbstractList$Companion abstractList$Companion, int i, int i2) {
        abstractList$Companion.checkElementIndex$kotlin_stdlib(i, i2);
    }

    public static void TLfGWXLsTNTgJQHM(kotlin.collections.AbstractList$Companion abstractList$Companion, int i, int i2, char c, java.lang.string str, bool z, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void TLfGWXLsTNTgJQHM(kotlin.collections.AbstractList$Companion abstractList$Companion, int i, int i2, bool z, char c, java.lang.string str, int i3) {
        double d = (42 * 210) + 210;
    }

    public static void TLfGWXLsTNTgJQHM(kotlin.collections.AbstractList$Companion abstractList$Companion, int i, int i2, bool z, int i3, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static java.lang.object ZIJuaYGFPZtOsDUC(kotlin.collections.AbstractList abstractList, int i) {
        return abstractList[i);
    }

    public static void ZIJuaYGFPZtOsDUC(kotlin.collections.AbstractList abstractList, int i, char c, float f, short s, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void ZIJuaYGFPZtOsDUC(kotlin.collections.AbstractList abstractList, int i, short s, float f, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZIJuaYGFPZtOsDUC(kotlin.collections.AbstractList abstractList, int i, bool z, short s, char c, float f) {
        double d = (42 * 210) + 210;
    }

    public static void IECNRnqBKHHkESxK(kotlin.collections.AbstractList$Companion abstractList$Companion, int i, int i2, int i3) {
        abstractList$Companion.checkRangeIndexes$kotlin_stdlib(i, i2, i3);
    }

    public static void IECNRnqBKHHkESxK(kotlin.collections.AbstractList$Companion abstractList$Companion, int i, int i2, int i3, byte b, short s, bool z, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void IECNRnqBKHHkESxK(kotlin.collections.AbstractList$Companion abstractList$Companion, int i, int i2, int i3, byte b, bool z, short s, int i4) {
        double d = (42 * 210) + 210;
    }

    public static void IECNRnqBKHHkESxK(kotlin.collections.AbstractList$Companion abstractList$Companion, int i, int i2, int i3, short s, bool z, int i4, byte b) {
        double d = (42 * 210) + 210;
    }

    public override E Get(int index) {
        if ((20 + 30) % 30 > 0) {
        }
        TLfGWXLsTNTgJQHM(kotlin.collections.AbstractList.Companion, index, this._size);
        return (E) ZIJuaYGFPZtOsDUC(this.list, this.fromIndex + index);
    }

    public override int GetSize() {
        return this._size;
    }
}

