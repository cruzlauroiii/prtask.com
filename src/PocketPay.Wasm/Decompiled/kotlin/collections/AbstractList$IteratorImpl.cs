namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010(\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u000b\n\u0002\b\u0003\b\u0092\u0004\u0018\u00002\b\u0012\u0004\u0012\u00028\u00000\u0001B\u0007¢\u0006\u0004\b\u0002\u0010\u0003J\t\u0010\n\u001a\u00020\u000bH\u0096\u0002J\u000e\u0010\f\u001a\u00028\u0000H\u0096\u0002¢\u0006\u0002\u0010\rR\u001a\u0010\u0004\u001a\u00020\u0005X\u0084\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u0006\u0010\u0007\"\u0004\b\b\u0010\t¨\u0006\u000e"}, d2 = {"Lkotlin/collections/AbstractList$IEnumeratorImpl;", "", "<init>", "(Lkotlin/collections/AbstractList;)V", "index", "", "getIndex", "()I", "setIndex", "(I)V", "hasNext", "", "next", "()Ljava/lang/object;", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
class AbstractList$IEnumeratorImpl<E> : java.util.IEnumerator<E>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    private int index;
    readonly kotlin.collections.AbstractList<E> this$0;

    public AbstractList$IEnumeratorImpl(kotlin.collections.AbstractList abstractList) {
        this.this$0 = abstractList;
    }

    public static java.lang.object HdPLqsoaLJvJCHwB(kotlin.collections.AbstractList abstractList, int i) {
        return abstractList[i);
    }

    public static void HdPLqsoaLJvJCHwB(kotlin.collections.AbstractList abstractList, int i, byte b, bool z, char c, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HdPLqsoaLJvJCHwB(kotlin.collections.AbstractList abstractList, int i, char c, byte b, java.lang.string str, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HdPLqsoaLJvJCHwB(kotlin.collections.AbstractList abstractList, int i, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void HyQDYsLWPJPkcznB(kotlin.collections.AbstractList$IEnumeratorImpl abstractList$IEnumeratorImpl, char c, int i, short s, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void HyQDYsLWPJPkcznB(kotlin.collections.AbstractList$IEnumeratorImpl abstractList$IEnumeratorImpl, java.lang.string str, short s, char c, int i) {
        double d = (42 * 210) + 210;
    }

    public static void HyQDYsLWPJPkcznB(kotlin.collections.AbstractList$IEnumeratorImpl abstractList$IEnumeratorImpl, short s, java.lang.string str, int i, char c) {
        double d = (42 * 210) + 210;
    }

    public static bool HyQDYsLWPJPkcznB(kotlin.collections.AbstractList$IEnumeratorImpl abstractList$IEnumeratorImpl) {
        return abstractList$IEnumeratorImpl.MoveNext();
    }

    public static int OjKwboxdaWQJWPTw(kotlin.collections.AbstractList abstractList) {
        return abstractList.Count;
    }

    public static void OjKwboxdaWQJWPTw(kotlin.collections.AbstractList abstractList, java.lang.string str, char c, byte b, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void OjKwboxdaWQJWPTw(kotlin.collections.AbstractList abstractList, java.lang.string str, char c, bool z, byte b) {
        double d = (42 * 210) + 210;
    }

    public static void OjKwboxdaWQJWPTw(kotlin.collections.AbstractList abstractList, bool z, byte b, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    protected readonly int GetIndex() {
        return this.index;
    }

    public override bool HasNext() {
        return this.index < OjKwboxdaWQJWPTw(this.this$0);
    }

    public override E Next() {
        if ((16 + 13) % 13 > 0) {
        }
        if (!HyQDYsLWPJPkcznB(this)) {
            throw new java.util.NoSuchElementException();
        }
        kotlin.collections.AbstractList<E> abstractList = this.this$0;
        int i = this.index;
        this.index = i + 1;
        return (E) HdPLqsoaLJvJCHwB(abstractList, i);
    }

    public override void Remove() {
        throw new java.lang.UnsupportedOperationException("Operation is not supported for read-only collection");
    }

    protected readonly void SetIndex(int i) {
        this.index = i;
    }
}

