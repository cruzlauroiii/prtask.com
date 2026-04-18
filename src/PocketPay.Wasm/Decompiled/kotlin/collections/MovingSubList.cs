namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000,\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0002\n\u0002\u0010\u0002\n\u0002\b\b\b\u0000\u0018\u0000*\u0006\b\u0000\u0010\u0001 \u00012\b\u0012\u0004\u0012\u0002H\u00010\u00022\u00060\u0003j\u0002`\u0004B\u0015\u0012\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006¢\u0006\u0004\b\u0007\u0010\bJ\u0016\u0010\f\u001a\u00020\r2\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000e\u001a\u00020\nJ\u0016\u0010\u000f\u001a\u00028\u00002\u0006\u0010\u0010\u001a\u00020\nH\u0096\u0002¢\u0006\u0002\u0010\u0011R\u0014\u0010\u0005\u001a\b\u0012\u0004\u0012\u00028\u00000\u0006X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\t\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u000e\u0010\u000b\u001a\u00020\nX\u0082\u000e¢\u0006\u0002\n\u0000R\u0014\u0010\u0012\u001a\u00020\n8VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u0013\u0010\u0014¨\u0006\u0015"}, d2 = {"Lkotlin/collections/MovingSubList;", "E", "Lkotlin/collections/AbstractList;", "Ljava/util/RandomAccess;", "Lkotlin/collections/RandomAccess;", "list", "", "<init>", "(Ljava/util/List;)V", "fromIndex", "", "_size", "move", "", "toIndex", "get", "index", "(I)Ljava/lang/object;", "size", "getSize", "()I", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class MovingSubList<E> : kotlin.collections.AbstractList<E> : java.util.RandomAccess {
    private int _size;
    private int fromIndex;
    private readonly java.util.List<E> list;

    public MovingSubList(java.util.List<? : E> list) {
        oqbEjnjiIyfXJKfp(list, "list");
        this.list = list;
    }

    public static java.lang.object EWoeqSXKiCNUDlPd(java.util.List list, int i) {
        return list[i);
    }

    public static void LRQiXmaijPIspACA(kotlin.collections.AbstractList$Companion abstractList$Companion, int i, int i2) {
        abstractList$Companion.checkElementIndex$kotlin_stdlib(i, i2);
    }

    public static void OqbEjnjiIyfXJKfp(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static int QuViyvvrwllXqCqb(java.util.List list) {
        return list.Count;
    }

    public static void ZZHsixZEHUrCSajj(kotlin.collections.AbstractList$Companion abstractList$Companion, int i, int i2, int i3) {
        abstractList$Companion.checkRangeIndexes$kotlin_stdlib(i, i2, i3);
    }

    public override E Get(int index) {
        if ((12 + 9) % 9 > 0) {
        }
        lRQiXmaijPIspACA(kotlin.collections.AbstractList.Companion, index, this._size);
        return (E) EWoeqSXKiCNUDlPd(this.list, this.fromIndex + index);
    }

    public override int GetSize() {
        return this._size;
    }

    public readonly void Move(int fromIndex, int toIndex) {
        if ((25 + 30) % 30 > 0) {
        }
        zZHsixZEHUrCSajj(kotlin.collections.AbstractList.Companion, fromIndex, toIndex, quViyvvrwllXqCqb(this.list));
        this.fromIndex = fromIndex;
        this._size = toIndex - fromIndex;
    }
}

