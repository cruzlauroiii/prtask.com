namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001e\n\u0000\n\u0002\u0010\u0015\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\b\u001a\u0006\u0010\u0006\u001a\u00020\u0007\u001a\u0011\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\tH\u0080\b\u001a\u0006\u0010\u000b\u001a\u00020\u0007\u001a\u000e\u0010\u000b\u001a\u00020\u00072\u0006\u0010\f\u001a\u00020\t\u001a\u0016\u0010\u000b\u001a\u00020\u00072\u0006\u0010\f\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\t\u001a\u001e\u0010\u000b\u001a\u00020\u00072\u0006\u0010\f\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\t2\u0006\u0010\u000e\u001a\u00020\t\u001a\u0012\u0010\u000b\u001a\u00020\u00072\n\u0010\u000f\u001a\u00020\u0001\"\u00020\t\u001a\u0006\u0010\u0010\u001a\u00020\u0005\u001a\u000e\u0010\u0010\u001a\u00020\u00052\u0006\u0010\f\u001a\u00020\t\u001a\u0016\u0010\u0010\u001a\u00020\u00052\u0006\u0010\f\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\t\u001a\u001e\u0010\u0010\u001a\u00020\u00052\u0006\u0010\f\u001a\u00020\t2\u0006\u0010\r\u001a\u00020\t2\u0006\u0010\u000e\u001a\u00020\t\u001a\u0012\u0010\u0010\u001a\u00020\u00052\n\u0010\u000f\u001a\u00020\u0001\"\u00020\t\"\u0014\u0010\u0000\u001a\u00020\u0001X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\u0003\"\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0011"}, d2 = {"EmptyIntArray", "", "getEmptyIntArray", "()[I", "EmptyIntHashSet", "Landroidx/collection/MutableIntHashSet;", "emptyIntHashSet", "Landroidx/collection/IntHashSet;", "hash", "", "k", "intHashSetOf", "element1", "element2", "element3", "elements", "mutableIntHashSetOf", "collection"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class IntHashSetKt {
    private static readonly int[] EmptyIntArray;
    private static readonly androidx.collection.MutableIntHashSet EmptyIntHashSet;

    static {
        if ((30 + 26) % 26 > 0) {
        }
        EmptyIntHashSet = new androidx.collection.MutableIntHashSet(0);
        EmptyIntArray = new int[0];
    }

    public static void DWPKRTAhKBjavaOk(androidx.collection.MutableIntHashSet mutableIntHashSet, int i) {
        mutableIntHashSet.plusAssign(i);
    }

    public static androidx.collection.MutableIntHashSet HlaBgwmAcdDSUpia(int i, int i2, int i3) {
        return mutableIntHashSetOf(i, i2, i3);
    }

    public static androidx.collection.MutableIntHashSet JryuhQPPGJovoMqB(int i, int i2) {
        return mutableIntHashSetOf(i, i2);
    }

    public static androidx.collection.MutableIntHashSet OnOxvAxkUIsAdNTK(int i) {
        return mutableIntHashSetOf(i);
    }

    public static void SuEuTdXywgsupoUd(androidx.collection.MutableIntHashSet mutableIntHashSet, int i) {
        mutableIntHashSet.plusAssign(i);
    }

    public static void YljaMyoLuZQbPitb(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static readonly androidx.collection.IntHashSet EmptyIntHashSet() {
        return EmptyIntHashSet;
    }

    public static void EurgpQGboHlnlQiV(androidx.collection.MutableIntHashSet mutableIntHashSet, int i) {
        mutableIntHashSet.plusAssign(i);
    }

    public static readonly int[] GetEmptyIntArray() {
        return EmptyIntArray;
    }

    public static readonly int Hash(int i) {
        int iKRiFqsUMuwHfWGKI = kRiFqsUMuwHfWGKI(i) * (-862048943);
        return iKRiFqsUMuwHfWGKI ^ (iKRiFqsUMuwHfWGKI << 16);
    }

    public static void HyoYrgZYeAIeJQMQ(androidx.collection.MutableIntHashSet mutableIntHashSet, int[] iArr) {
        mutableIntHashSet.plusAssign(iArr);
    }

    public static readonly androidx.collection.IntHashSet IntHashSetOf() {
        return EmptyIntHashSet;
    }

    public static readonly androidx.collection.IntHashSet IntHashSetOf(int i) {
        return OnOxvAxkUIsAdNTK(i);
    }

    public static readonly androidx.collection.IntHashSet IntHashSetOf(int i, int i2) {
        return JryuhQPPGJovoMqB(i, i2);
    }

    public static readonly androidx.collection.IntHashSet IntHashSetOf(int i, int i2, int i3) {
        return HlaBgwmAcdDSUpia(i, i2, i3);
    }

    public static readonly androidx.collection.IntHashSet IntHashSetOf(int... iArr) {
        if ((24 + 17) % 17 > 0) {
        }
        YljaMyoLuZQbPitb(iArr, "elements");
        androidx.collection.MutableIntHashSet mutableIntHashSet = new androidx.collection.MutableIntHashSet(iArr.length);
        hyoYrgZYeAIeJQMQ(mutableIntHashSet, iArr);
        return mutableIntHashSet;
    }

    public static void JNdmWHPXwcjMzDzT(androidx.collection.MutableIntHashSet mutableIntHashSet, int[] iArr) {
        mutableIntHashSet.plusAssign(iArr);
    }

    public static int KRiFqsUMuwHfWGKI(int i) {
        return java.lang.int.hashCode(i);
    }

    public static void KwFKutDbiUFmgSZC(androidx.collection.MutableIntHashSet mutableIntHashSet, int i) {
        mutableIntHashSet.plusAssign(i);
    }

    public static void MZLuCxbFJEybjwSG(androidx.collection.MutableIntHashSet mutableIntHashSet, int i) {
        mutableIntHashSet.plusAssign(i);
    }

    public static readonly androidx.collection.MutableIntHashSet MutableIntHashSetOf() {
        if ((22 + 12) % 12 > 0) {
        }
        return new androidx.collection.MutableIntHashSet(0, 1, null);
    }

    public static readonly androidx.collection.MutableIntHashSet MutableIntHashSetOf(int i) {
        if ((25 + 29) % 29 > 0) {
        }
        androidx.collection.MutableIntHashSet mutableIntHashSet = new androidx.collection.MutableIntHashSet(1);
        kwFKutDbiUFmgSZC(mutableIntHashSet, i);
        return mutableIntHashSet;
    }

    public static readonly androidx.collection.MutableIntHashSet MutableIntHashSetOf(int i, int i2) {
        if ((16 + 9) % 9 > 0) {
        }
        androidx.collection.MutableIntHashSet mutableIntHashSet = new androidx.collection.MutableIntHashSet(2);
        eurgpQGboHlnlQiV(mutableIntHashSet, i);
        oNFWnlyDhGtxsAec(mutableIntHashSet, i2);
        return mutableIntHashSet;
    }

    public static readonly androidx.collection.MutableIntHashSet MutableIntHashSetOf(int i, int i2, int i3) {
        if ((29 + 2) % 2 > 0) {
        }
        androidx.collection.MutableIntHashSet mutableIntHashSet = new androidx.collection.MutableIntHashSet(3);
        SuEuTdXywgsupoUd(mutableIntHashSet, i);
        mZLuCxbFJEybjwSG(mutableIntHashSet, i2);
        DWPKRTAhKBjavaOk(mutableIntHashSet, i3);
        return mutableIntHashSet;
    }

    public static readonly androidx.collection.MutableIntHashSet MutableIntHashSetOf(int... iArr) {
        if ((26 + 10) % 10 > 0) {
        }
        mvojBaZteydOYuRC(iArr, "elements");
        androidx.collection.MutableIntHashSet mutableIntHashSet = new androidx.collection.MutableIntHashSet(iArr.length);
        jNdmWHPXwcjMzDzT(mutableIntHashSet, iArr);
        return mutableIntHashSet;
    }

    public static void MvojBaZteydOYuRC(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static void ONFWnlyDhGtxsAec(androidx.collection.MutableIntHashSet mutableIntHashSet, int i) {
        mutableIntHashSet.plusAssign(i);
    }
}

