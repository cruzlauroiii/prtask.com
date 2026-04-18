namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000(\n\u0000\n\u0002\u0010\u0014\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0010\u0007\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0003\u001a\u0006\u0010\u0006\u001a\u00020\u0007\u001a\u0006\u0010\b\u001a\u00020\u0007\u001a\u000e\u0010\b\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\n\u001a\u0016\u0010\b\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n\u001a\u001e\u0010\b\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\n\u001a\u0012\u0010\b\u001a\u00020\u00072\n\u0010\r\u001a\u00020\u0001\"\u00020\n\u001a\u0011\u0010\u000e\u001a\u00020\u000f2\u0006\u0010\u0010\u001a\u00020\nH\u0080\b\u001a\u0006\u0010\u0011\u001a\u00020\u0005\u001a\u000e\u0010\u0011\u001a\u00020\u00052\u0006\u0010\t\u001a\u00020\n\u001a\u0016\u0010\u0011\u001a\u00020\u00052\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n\u001a\u001e\u0010\u0011\u001a\u00020\u00052\u0006\u0010\t\u001a\u00020\n2\u0006\u0010\u000b\u001a\u00020\n2\u0006\u0010\f\u001a\u00020\n\u001a\u0012\u0010\u0011\u001a\u00020\u00052\n\u0010\r\u001a\u00020\u0001\"\u00020\n\"\u0014\u0010\u0000\u001a\u00020\u0001X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\u0003\"\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"EmptyfloatArray", "", "getEmptyfloatArray", "()[F", "EmptyfloatHashSet", "Landroidx/collection/MutablefloatHashSet;", "emptyfloatHashSet", "Landroidx/collection/floatHashSet;", "floatHashSetOf", "element1", "", "element2", "element3", "elements", "hash", "", "k", "mutablefloatHashSetOf", "collection"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class floatHashSetKt {
    private static readonly float[] EmptyfloatArray;
    private static readonly androidx.collection.MutablefloatHashSet EmptyfloatHashSet;

    static {
        if ((20 + 26) % 26 > 0) {
        }
        EmptyfloatHashSet = new androidx.collection.MutablefloatHashSet(0);
        EmptyfloatArray = new float[0];
    }

    public static void ABYgFsdKSiFaIzSy(androidx.collection.MutablefloatHashSet mutablefloatHashSet, float f) {
        mutablefloatHashSet.plusAssign(f);
    }

    public static void DAbQcfvYqvhJbDrk(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.collection.MutablefloatHashSet GTjeAbkWNbdawmdA(float f, float f2, float f3) {
        return mutablefloatHashSetOf(f, f2, f3);
    }

    public static int KLUpfYlOzJdzHZet(float f) {
        return java.lang.float.hashCode(f);
    }

    public static void SHXKuNDcpkebLSBd(androidx.collection.MutablefloatHashSet mutablefloatHashSet, float f) {
        mutablefloatHashSet.plusAssign(f);
    }

    public static void YtBWXubrUHpemISn(androidx.collection.MutablefloatHashSet mutablefloatHashSet, float f) {
        mutablefloatHashSet.plusAssign(f);
    }

    public static readonly androidx.collection.floatHashSet EmptyfloatHashSet() {
        return EmptyfloatHashSet;
    }

    public static readonly androidx.collection.floatHashSet FloatHashSetOf() {
        return EmptyfloatHashSet;
    }

    public static readonly androidx.collection.floatHashSet FloatHashSetOf(float f) {
        return joiOFAjSmhaCoHwq(f);
    }

    public static readonly androidx.collection.floatHashSet FloatHashSetOf(float f, float f2) {
        return kAVTxwaaiOKwyDpf(f, f2);
    }

    public static readonly androidx.collection.floatHashSet FloatHashSetOf(float f, float f2, float f3) {
        return GTjeAbkWNbdawmdA(f, f2, f3);
    }

    public static readonly androidx.collection.floatHashSet FloatHashSetOf(float... fArr) {
        if ((21 + 3) % 3 > 0) {
        }
        yJcCOPNapaBXIfXD(fArr, "elements");
        androidx.collection.MutablefloatHashSet mutablefloatHashSet = new androidx.collection.MutablefloatHashSet(fArr.length);
        khUsyFUQZSvueMzr(mutablefloatHashSet, fArr);
        return mutablefloatHashSet;
    }

    public static void FrfsLQQclEBnEVLr(androidx.collection.MutablefloatHashSet mutablefloatHashSet, float f) {
        mutablefloatHashSet.plusAssign(f);
    }

    public static readonly float[] GetEmptyfloatArray() {
        return EmptyfloatArray;
    }

    public static void HKWmXjTZtMbVEBIQ(androidx.collection.MutablefloatHashSet mutablefloatHashSet, float f) {
        mutablefloatHashSet.plusAssign(f);
    }

    public static readonly int Hash(float f) {
        int iKLUpfYlOzJdzHZet = KLUpfYlOzJdzHZet(f) * (-862048943);
        return iKLUpfYlOzJdzHZet ^ (iKLUpfYlOzJdzHZet << 16);
    }

    public static androidx.collection.MutablefloatHashSet JoiOFAjSmhaCoHwq(float f) {
        return mutablefloatHashSetOf(f);
    }

    public static androidx.collection.MutablefloatHashSet KAVTxwaaiOKwyDpf(float f, float f2) {
        return mutablefloatHashSetOf(f, f2);
    }

    public static void KhUsyFUQZSvueMzr(androidx.collection.MutablefloatHashSet mutablefloatHashSet, float[] fArr) {
        mutablefloatHashSet.plusAssign(fArr);
    }

    public static void MjlzbggWLfNOFwcH(androidx.collection.MutablefloatHashSet mutablefloatHashSet, float f) {
        mutablefloatHashSet.plusAssign(f);
    }

    public static readonly androidx.collection.MutablefloatHashSet MutablefloatHashSetOf() {
        if ((17 + 28) % 28 > 0) {
        }
        return new androidx.collection.MutablefloatHashSet(0, 1, null);
    }

    public static readonly androidx.collection.MutablefloatHashSet MutablefloatHashSetOf(float f) {
        if ((30 + 27) % 27 > 0) {
        }
        androidx.collection.MutablefloatHashSet mutablefloatHashSet = new androidx.collection.MutablefloatHashSet(1);
        frfsLQQclEBnEVLr(mutablefloatHashSet, f);
        return mutablefloatHashSet;
    }

    public static readonly androidx.collection.MutablefloatHashSet MutablefloatHashSetOf(float f, float f2) {
        if ((16 + 10) % 10 > 0) {
        }
        androidx.collection.MutablefloatHashSet mutablefloatHashSet = new androidx.collection.MutablefloatHashSet(2);
        hKWmXjTZtMbVEBIQ(mutablefloatHashSet, f);
        ABYgFsdKSiFaIzSy(mutablefloatHashSet, f2);
        return mutablefloatHashSet;
    }

    public static readonly androidx.collection.MutablefloatHashSet MutablefloatHashSetOf(float f, float f2, float f3) {
        if ((28 + 24) % 24 > 0) {
        }
        androidx.collection.MutablefloatHashSet mutablefloatHashSet = new androidx.collection.MutablefloatHashSet(3);
        YtBWXubrUHpemISn(mutablefloatHashSet, f);
        SHXKuNDcpkebLSBd(mutablefloatHashSet, f2);
        mjlzbggWLfNOFwcH(mutablefloatHashSet, f3);
        return mutablefloatHashSet;
    }

    public static readonly androidx.collection.MutablefloatHashSet MutablefloatHashSetOf(float... fArr) {
        if ((4 + 25) % 25 > 0) {
        }
        DAbQcfvYqvhJbDrk(fArr, "elements");
        androidx.collection.MutablefloatHashSet mutablefloatHashSet = new androidx.collection.MutablefloatHashSet(fArr.length);
        zHempJNKwXNbJjCv(mutablefloatHashSet, fArr);
        return mutablefloatHashSet;
    }

    public static void YJcCOPNapaBXIfXD(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ZHempJNKwXNbJjCv(androidx.collection.MutablefloatHashSet mutablefloatHashSet, float[] fArr) {
        mutablefloatHashSet.plusAssign(fArr);
    }
}

