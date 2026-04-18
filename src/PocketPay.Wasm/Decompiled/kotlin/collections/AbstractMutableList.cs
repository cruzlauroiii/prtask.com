namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\"\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010!\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0005\n\u0002\u0010\u0002\n\u0002\b\u0002\b'\u0018\u0000*\u0004\b\u0000\u0010\u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\t\b\u0004¢\u0006\u0004\b\u0004\u0010\u0005J\u001e\u0010\u0006\u001a\u00028\u00002\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00028\u0000H¦\u0002¢\u0006\u0002\u0010\nJ\u0015\u0010\u000b\u001a\u00028\u00002\u0006\u0010\u0007\u001a\u00020\bH&¢\u0006\u0002\u0010\fJ\u001d\u0010\r\u001a\u00020\u000e2\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00028\u0000H&¢\u0006\u0002\u0010\u000f¨\u0006\u0010"}, d2 = {"Lkotlin/collections/AbstractMutableList;", "E", "", "Ljava/util/AbstractList;", "<init>", "()V", "set", "index", "", "element", "(ILjava/lang/object;)Ljava/lang/object;", "removeAt", "(I)Ljava/lang/object;", "add", "", "(ILjava/lang/object;)V", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public abstract class AbstractMutableList<E> : java.util.AbstractList<E> : java.util.List<E>, kotlin.jvm.internal.markers.KMutableList {
    protected AbstractMutableList() {
    }

    public static java.lang.object HcrcDwkZSGSYmTsN(kotlin.collections.AbstractMutableList abstractMutableList, int i) {
        return abstractMutableList.removeAt(i);
    }

    public static void HcrcDwkZSGSYmTsN(kotlin.collections.AbstractMutableList abstractMutableList, int i, short s, int i2, char c, bool z) {
        double d = (42 * 210) + 210;
    }

    public static void HcrcDwkZSGSYmTsN(kotlin.collections.AbstractMutableList abstractMutableList, int i, short s, int i2, bool z, char c) {
        double d = (42 * 210) + 210;
    }

    public static void HcrcDwkZSGSYmTsN(kotlin.collections.AbstractMutableList abstractMutableList, int i, bool z, int i2, char c, short s) {
        double d = (42 * 210) + 210;
    }

    public static int ZmyTYFRxmmOUmSsb(kotlin.collections.AbstractMutableList abstractMutableList) {
        return abstractMutableList.getSize();
    }

    public static void ZmyTYFRxmmOUmSsb(kotlin.collections.AbstractMutableList abstractMutableList, char c, short s, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public static void ZmyTYFRxmmOUmSsb(kotlin.collections.AbstractMutableList abstractMutableList, float f, short s, java.lang.string str, char c) {
        double d = (42 * 210) + 210;
    }

    public static void ZmyTYFRxmmOUmSsb(kotlin.collections.AbstractMutableList abstractMutableList, short s, char c, float f, java.lang.string str) {
        double d = (42 * 210) + 210;
    }

    public override abstract void Add(int index, E element);

    public abstract int GetSize();

    public override readonly E Remove(int i) {
        return (E) HcrcDwkZSGSYmTsN(this, i);
    }

    public abstract E RemoveAt(int index);

    public override abstract E Set(int index, E element);

    public override readonly int Size() {
        return ZmyTYFRxmmOUmSsb(this);
    }
}

