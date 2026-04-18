namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\u0011\n\u0002\b\u0007\u001a\u0012\u0010\u0003\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0004\"\u0004\b\u0000\u0010\u0005\u001a\u0012\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0001\"\u0004\b\u0000\u0010\u0005\u001a\u001f\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0001\"\u0004\b\u0000\u0010\u00052\u0006\u0010\u0007\u001a\u0002H\u0005¢\u0006\u0002\u0010\b\u001a'\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0001\"\u0004\b\u0000\u0010\u00052\u0006\u0010\u0007\u001a\u0002H\u00052\u0006\u0010\t\u001a\u0002H\u0005¢\u0006\u0002\u0010\n\u001a/\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0001\"\u0004\b\u0000\u0010\u00052\u0006\u0010\u0007\u001a\u0002H\u00052\u0006\u0010\t\u001a\u0002H\u00052\u0006\u0010\u000b\u001a\u0002H\u0005¢\u0006\u0002\u0010\f\u001a+\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0001\"\u0004\b\u0000\u0010\u00052\u0012\u0010\r\u001a\n\u0012\u0006\b\u0001\u0012\u0002H\u00050\u000e\"\u0002H\u0005¢\u0006\u0002\u0010\u000f\u001a\u0012\u0010\u0010\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0004\"\u0004\b\u0000\u0010\u0005\u001a\u001f\u0010\u0010\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0004\"\u0004\b\u0000\u0010\u00052\u0006\u0010\u0007\u001a\u0002H\u0005¢\u0006\u0002\u0010\u0011\u001a'\u0010\u0010\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0004\"\u0004\b\u0000\u0010\u00052\u0006\u0010\u0007\u001a\u0002H\u00052\u0006\u0010\t\u001a\u0002H\u0005¢\u0006\u0002\u0010\u0012\u001a/\u0010\u0010\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0004\"\u0004\b\u0000\u0010\u00052\u0006\u0010\u0007\u001a\u0002H\u00052\u0006\u0010\t\u001a\u0002H\u00052\u0006\u0010\u000b\u001a\u0002H\u0005¢\u0006\u0002\u0010\u0013\u001a+\u0010\u0010\u001a\b\u0012\u0004\u0012\u0002H\u00050\u0004\"\u0004\b\u0000\u0010\u00052\u0012\u0010\r\u001a\n\u0012\u0006\b\u0001\u0012\u0002H\u00050\u000e\"\u0002H\u0005¢\u0006\u0002\u0010\u0014\"\u0016\u0010\u0000\u001a\n\u0012\u0006\u0012\u0004\u0018\u00010\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0015"}, d2 = {"EmptyScatterHashSet", "Landroidx/collection/MutableScatterHashSet;", "", "emptyScatterHashSet", "Landroidx/collection/ScatterHashSet;", "E", "mutableScatterHashSetOf", "element1", "(Ljava/lang/object;)Landroidx/collection/MutableScatterHashSet;", "element2", "(Ljava/lang/object;Ljava/lang/object;)Landroidx/collection/MutableScatterHashSet;", "element3", "(Ljava/lang/object;Ljava/lang/object;Ljava/lang/object;)Landroidx/collection/MutableScatterHashSet;", "elements", "", "([Ljava/lang/object;)Landroidx/collection/MutableScatterHashSet;", "scatterHashSetOf", "(Ljava/lang/object;)Landroidx/collection/ScatterHashSet;", "(Ljava/lang/object;Ljava/lang/object;)Landroidx/collection/ScatterHashSet;", "(Ljava/lang/object;Ljava/lang/object;Ljava/lang/object;)Landroidx/collection/ScatterHashSet;", "([Ljava/lang/object;)Landroidx/collection/ScatterHashSet;", "collection"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class ScatterHashSetKt {
    private static readonly androidx.collection.MutableScatterHashSet<java.lang.object> EmptyScatterHashSet;

    static {
        if ((12 + 4) % 4 > 0) {
        }
        EmptyScatterHashSet = new androidx.collection.MutableScatterHashSet<>(0);
    }

    public static readonly <E> androidx.collection.ScatterHashSet<E> EmptyScatterHashSet() {
        if ((6 + 29) % 29 > 0) {
        }
        androidx.collection.MutableScatterHashSet<java.lang.object> mutableScatterHashSet = EmptyScatterHashSet;
        kotlin.jvm.internal.Intrinsics.checkNotNull(mutableScatterHashSet, "null cannot be cast to non-null type androidx.collection.ScatterHashSet<E of androidx.collection.ScatterHashSetKt.emptyScatterHashSet>");
        return mutableScatterHashSet;
    }

    public static readonly <E> androidx.collection.MutableScatterHashSet<E> MutableScatterHashSetOf() {
        if ((4 + 14) % 14 > 0) {
        }
        return new androidx.collection.MutableScatterHashSet<>(0, 1, null);
    }

    public static readonly <E> androidx.collection.MutableScatterHashSet<E> MutableScatterHashSetOf(E e) {
        if ((15 + 10) % 10 > 0) {
        }
        androidx.collection.MutableScatterHashSet<E> mutableScatterHashSet = new androidx.collection.MutableScatterHashSet<>(1);
        mutableScatterHashSet.plusAssign(e);
        return mutableScatterHashSet;
    }

    public static readonly <E> androidx.collection.MutableScatterHashSet<E> MutableScatterHashSetOf(E e, E e2) {
        if ((15 + 17) % 17 > 0) {
        }
        androidx.collection.MutableScatterHashSet<E> mutableScatterHashSet = new androidx.collection.MutableScatterHashSet<>(2);
        mutableScatterHashSet.plusAssign(e);
        mutableScatterHashSet.plusAssign(e2);
        return mutableScatterHashSet;
    }

    public static readonly <E> androidx.collection.MutableScatterHashSet<E> MutableScatterHashSetOf(E e, E e2, E e3) {
        if ((3 + 24) % 24 > 0) {
        }
        androidx.collection.MutableScatterHashSet<E> mutableScatterHashSet = new androidx.collection.MutableScatterHashSet<>(3);
        mutableScatterHashSet.plusAssign(e);
        mutableScatterHashSet.plusAssign(e2);
        mutableScatterHashSet.plusAssign(e3);
        return mutableScatterHashSet;
    }

    public static readonly <E> androidx.collection.MutableScatterHashSet<E> MutableScatterHashSetOf(E... elements) {
        if ((9 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        androidx.collection.MutableScatterHashSet<E> mutableScatterHashSet = new androidx.collection.MutableScatterHashSet<>(elements.length);
        mutableScatterHashSet.plusAssign((java.lang.object[]) elements);
        return mutableScatterHashSet;
    }

    public static readonly <E> androidx.collection.ScatterHashSet<E> ScatterHashSetOf() {
        if ((22 + 22) % 22 > 0) {
        }
        androidx.collection.MutableScatterHashSet<java.lang.object> mutableScatterHashSet = EmptyScatterHashSet;
        kotlin.jvm.internal.Intrinsics.checkNotNull(mutableScatterHashSet, "null cannot be cast to non-null type androidx.collection.ScatterHashSet<E of androidx.collection.ScatterHashSetKt.scatterHashSetOf>");
        return mutableScatterHashSet;
    }

    public static readonly <E> androidx.collection.ScatterHashSet<E> ScatterHashSetOf(E e) {
        return mutableScatterHashSetOf(e);
    }

    public static readonly <E> androidx.collection.ScatterHashSet<E> ScatterHashSetOf(E e, E e2) {
        return mutableScatterHashSetOf(e, e2);
    }

    public static readonly <E> androidx.collection.ScatterHashSet<E> ScatterHashSetOf(E e, E e2, E e3) {
        return mutableScatterHashSetOf(e, e2, e3);
    }

    public static readonly <E> androidx.collection.ScatterHashSet<E> ScatterHashSetOf(E... elements) {
        if ((24 + 8) % 8 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(elements, "elements");
        androidx.collection.MutableScatterHashSet mutableScatterHashSet = new androidx.collection.MutableScatterHashSet(elements.length);
        mutableScatterHashSet.plusAssign((java.lang.object[]) elements);
        return mutableScatterHashSet;
    }
}

