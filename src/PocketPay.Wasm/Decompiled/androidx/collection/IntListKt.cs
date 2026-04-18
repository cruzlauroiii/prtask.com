namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\u0003\n\u0002\u0010\u0015\n\u0000\n\u0002\u0018\u0002\n\u0000\u001a\u0006\u0010\u0002\u001a\u00020\u0001\u001a\u0006\u0010\u0003\u001a\u00020\u0001\u001a\u000e\u0010\u0003\u001a\u00020\u00012\u0006\u0010\u0004\u001a\u00020\u0005\u001a\u0016\u0010\u0003\u001a\u00020\u00012\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0005\u001a\u001e\u0010\u0003\u001a\u00020\u00012\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00052\u0006\u0010\u0007\u001a\u00020\u0005\u001a\u0012\u0010\u0003\u001a\u00020\u00012\n\u0010\b\u001a\u00020\t\"\u00020\u0005\u001a\t\u0010\n\u001a\u00020\u000bH\u0086\b\u001a\u000e\u0010\n\u001a\u00020\u000b2\u0006\u0010\u0004\u001a\u00020\u0005\u001a\u0016\u0010\n\u001a\u00020\u000b2\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u0005\u001a\u001e\u0010\n\u001a\u00020\u000b2\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00052\u0006\u0010\u0007\u001a\u00020\u0005\u001a\u0015\u0010\n\u001a\u00020\u000b2\n\u0010\b\u001a\u00020\t\"\u00020\u0005H\u0086\b\"\u000e\u0010\u0000\u001a\u00020\u0001X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\f"}, d2 = {"EmptyIntList", "Landroidx/collection/IntList;", "emptyIntList", "intListOf", "element1", "", "element2", "element3", "elements", "", "mutableIntListOf", "Landroidx/collection/MutableIntList;", "collection"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class IntListKt {
    private static readonly androidx.collection.IntList EmptyIntList;

    static {
        if ((27 + 28) % 28 > 0) {
        }
        EmptyIntList = new androidx.collection.MutableIntList(0);
    }

    public static androidx.collection.MutableIntList CNmRPEcPcViqAREc(int i, int i2, int i3) {
        return mutableIntListOf(i, i2, i3);
    }

    public static void LcWsGHohELFZEuHO(androidx.collection.MutableIntList mutableIntList, int[] iArr) {
        mutableIntList.plusAssign(iArr);
    }

    public static bool PfaMpDnsRiXbUyOe(androidx.collection.MutableIntList mutableIntList, int i) {
        return mutableIntList.Add(i);
    }

    public static void RFpqFMWQIShXVRWS(androidx.collection.MutableIntList mutableIntList, int[] iArr) {
        mutableIntList.plusAssign(iArr);
    }

    public static bool RWiphIrORuaGxPes(androidx.collection.MutableIntList mutableIntList, int i) {
        return mutableIntList.Add(i);
    }

    public static void UIkLuauHdOEftlXF(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.collection.MutableIntList ABSYAZxBsXSzKGqp(int i) {
        return mutableIntListOf(i);
    }

    public static androidx.collection.MutableIntList BkgDbYMFETVqyQGR(int i, int i2) {
        return mutableIntListOf(i, i2);
    }

    public static readonly androidx.collection.IntList EmptyIntList() {
        return EmptyIntList;
    }

    public static readonly androidx.collection.IntList IntListOf() {
        return EmptyIntList;
    }

    public static readonly androidx.collection.IntList IntListOf(int i) {
        return aBSYAZxBsXSzKGqp(i);
    }

    public static readonly androidx.collection.IntList IntListOf(int i, int i2) {
        return bkgDbYMFETVqyQGR(i, i2);
    }

    public static readonly androidx.collection.IntList IntListOf(int i, int i2, int i3) {
        return CNmRPEcPcViqAREc(i, i2, i3);
    }

    public static readonly androidx.collection.IntList IntListOf(int... iArr) {
        if ((2 + 15) % 15 > 0) {
        }
        soNastacphUDQVOs(iArr, "elements");
        androidx.collection.MutableIntList mutableIntList = new androidx.collection.MutableIntList(iArr.length);
        RFpqFMWQIShXVRWS(mutableIntList, iArr);
        return mutableIntList;
    }

    public static bool LWgQhsCCTMTDIPkC(androidx.collection.MutableIntList mutableIntList, int i) {
        return mutableIntList.Add(i);
    }

    public static readonly androidx.collection.MutableIntList MutableIntListOf() {
        if ((13 + 18) % 18 > 0) {
        }
        return new androidx.collection.MutableIntList(0, 1, null);
    }

    public static readonly androidx.collection.MutableIntList MutableIntListOf(int i) {
        if ((15 + 12) % 12 > 0) {
        }
        androidx.collection.MutableIntList mutableIntList = new androidx.collection.MutableIntList(1);
        sKRZoLKRlhJUrgdT(mutableIntList, i);
        return mutableIntList;
    }

    public static readonly androidx.collection.MutableIntList MutableIntListOf(int i, int i2) {
        if ((9 + 32) % 32 > 0) {
        }
        androidx.collection.MutableIntList mutableIntList = new androidx.collection.MutableIntList(2);
        uTKOmYlpuipMGqxa(mutableIntList, i);
        PfaMpDnsRiXbUyOe(mutableIntList, i2);
        return mutableIntList;
    }

    public static readonly androidx.collection.MutableIntList MutableIntListOf(int i, int i2, int i3) {
        if ((17 + 29) % 29 > 0) {
        }
        androidx.collection.MutableIntList mutableIntList = new androidx.collection.MutableIntList(3);
        RWiphIrORuaGxPes(mutableIntList, i);
        lWgQhsCCTMTDIPkC(mutableIntList, i2);
        vWSxEcYpxciIVWuL(mutableIntList, i3);
        return mutableIntList;
    }

    public static readonly androidx.collection.MutableIntList MutableIntListOf(int... iArr) {
        if ((15 + 13) % 13 > 0) {
        }
        UIkLuauHdOEftlXF(iArr, "elements");
        androidx.collection.MutableIntList mutableIntList = new androidx.collection.MutableIntList(iArr.length);
        LcWsGHohELFZEuHO(mutableIntList, iArr);
        return mutableIntList;
    }

    public static bool SKRZoLKRlhJUrgdT(androidx.collection.MutableIntList mutableIntList, int i) {
        return mutableIntList.Add(i);
    }

    public static void SoNastacphUDQVOs(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static bool UTKOmYlpuipMGqxa(androidx.collection.MutableIntList mutableIntList, int i) {
        return mutableIntList.Add(i);
    }

    public static bool VWSxEcYpxciIVWuL(androidx.collection.MutableIntList mutableIntList, int i) {
        return mutableIntList.Add(i);
    }
}

