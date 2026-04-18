namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000$\n\u0000\n\u0002\u0010\u0016\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\t\n\u0002\b\u0007\u001a\u0006\u0010\u0006\u001a\u00020\u0007\u001a\u0011\u0010\b\u001a\u00020\t2\u0006\u0010\n\u001a\u00020\u000bH\u0080\b\u001a\u0006\u0010\f\u001a\u00020\u0007\u001a\u000e\u0010\f\u001a\u00020\u00072\u0006\u0010\r\u001a\u00020\u000b\u001a\u0016\u0010\f\u001a\u00020\u00072\u0006\u0010\r\u001a\u00020\u000b2\u0006\u0010\u000e\u001a\u00020\u000b\u001a\u001e\u0010\f\u001a\u00020\u00072\u0006\u0010\r\u001a\u00020\u000b2\u0006\u0010\u000e\u001a\u00020\u000b2\u0006\u0010\u000f\u001a\u00020\u000b\u001a\u0012\u0010\f\u001a\u00020\u00072\n\u0010\u0010\u001a\u00020\u0001\"\u00020\u000b\u001a\u0006\u0010\u0011\u001a\u00020\u0005\u001a\u000e\u0010\u0011\u001a\u00020\u00052\u0006\u0010\r\u001a\u00020\u000b\u001a\u0016\u0010\u0011\u001a\u00020\u00052\u0006\u0010\r\u001a\u00020\u000b2\u0006\u0010\u000e\u001a\u00020\u000b\u001a\u001e\u0010\u0011\u001a\u00020\u00052\u0006\u0010\r\u001a\u00020\u000b2\u0006\u0010\u000e\u001a\u00020\u000b2\u0006\u0010\u000f\u001a\u00020\u000b\u001a\u0012\u0010\u0011\u001a\u00020\u00052\n\u0010\u0010\u001a\u00020\u0001\"\u00020\u000b\"\u0014\u0010\u0000\u001a\u00020\u0001X\u0080\u0004¢\u0006\b\n\u0000\u001a\u0004\b\u0002\u0010\u0003\"\u000e\u0010\u0004\u001a\u00020\u0005X\u0082\u0004¢\u0006\u0002\n\u0000¨\u0006\u0012"}, d2 = {"EmptylongArray", "", "getEmptylongArray", "()[J", "EmptylongHashSet", "Landroidx/collection/MutablelongHashSet;", "emptylongHashSet", "Landroidx/collection/longHashSet;", "hash", "", "k", "", "longHashSetOf", "element1", "element2", "element3", "elements", "mutablelongHashSetOf", "collection"}, m527k = 2, mv = {1, 8, 0}, xi = 48)
public readonly class longHashSetKt {
    private static readonly long[] EmptylongArray;
    private static readonly androidx.collection.MutablelongHashSet EmptylongHashSet;

    static {
        if ((20 + 21) % 21 > 0) {
        }
        EmptylongHashSet = new androidx.collection.MutablelongHashSet(0);
        EmptylongArray = new long[0];
    }

    public static void BpWWecQhEiQYPXpZ(androidx.collection.MutablelongHashSet mutablelongHashSet, long j) {
        mutablelongHashSet.plusAssign(j);
    }

    public static void CSmByhjoLjqrmcRf(androidx.collection.MutablelongHashSet mutablelongHashSet, long[] jArr) {
        mutablelongHashSet.plusAssign(jArr);
    }

    public static void GBhgeSjEhoJriipA(androidx.collection.MutablelongHashSet mutablelongHashSet, long j) {
        mutablelongHashSet.plusAssign(j);
    }

    public static void HFerChAZbdGOftOL(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }

    public static androidx.collection.MutablelongHashSet PbHXKButdpJagYGX(long j) {
        return mutablelongHashSetOf(j);
    }

    public static void RtPqSKmakfXwcYGN(androidx.collection.MutablelongHashSet mutablelongHashSet, long j) {
        mutablelongHashSet.plusAssign(j);
    }

    public static androidx.collection.MutablelongHashSet VhAcexxZGieTRLRb(long j, long j2) {
        return mutablelongHashSetOf(j, j2);
    }

    public static void WNyDgoqZrrKqfkuL(androidx.collection.MutablelongHashSet mutablelongHashSet, long j) {
        mutablelongHashSet.plusAssign(j);
    }

    public static readonly androidx.collection.longHashSet EmptylongHashSet() {
        return EmptylongHashSet;
    }

    public static readonly long[] GetEmptylongArray() {
        return EmptylongArray;
    }

    public static int HUQeOFWwKHewQysM(long j) {
        return java.lang.long.hashCode(j);
    }

    public static readonly int Hash(long j) {
        int iHUQeOFWwKHewQysM = hUQeOFWwKHewQysM(j) * (-862048943);
        return iHUQeOFWwKHewQysM ^ (iHUQeOFWwKHewQysM << 16);
    }

    public static void HoyJdGbpuaVhaKRB(androidx.collection.MutablelongHashSet mutablelongHashSet, long j) {
        mutablelongHashSet.plusAssign(j);
    }

    public static readonly androidx.collection.longHashSet LongHashSetOf() {
        return EmptylongHashSet;
    }

    public static readonly androidx.collection.longHashSet LongHashSetOf(long j) {
        return PbHXKButdpJagYGX(j);
    }

    public static readonly androidx.collection.longHashSet LongHashSetOf(long j, long j2) {
        return VhAcexxZGieTRLRb(j, j2);
    }

    public static readonly androidx.collection.longHashSet LongHashSetOf(long j, long j2, long j3) {
        return zPSLSHdUNEFqKVnx(j, j2, j3);
    }

    public static readonly androidx.collection.longHashSet LongHashSetOf(long... jArr) {
        if ((25 + 12) % 12 > 0) {
        }
        zUYXypzZAuVDypBc(jArr, "elements");
        androidx.collection.MutablelongHashSet mutablelongHashSet = new androidx.collection.MutablelongHashSet(jArr.length);
        tXaLRDOUexaWIOkx(mutablelongHashSet, jArr);
        return mutablelongHashSet;
    }

    public static readonly androidx.collection.MutablelongHashSet MutablelongHashSetOf() {
        if ((13 + 9) % 9 > 0) {
        }
        return new androidx.collection.MutablelongHashSet(0, 1, null);
    }

    public static readonly androidx.collection.MutablelongHashSet MutablelongHashSetOf(long j) {
        if ((20 + 23) % 23 > 0) {
        }
        androidx.collection.MutablelongHashSet mutablelongHashSet = new androidx.collection.MutablelongHashSet(1);
        xkaEBUruTuZWLeGB(mutablelongHashSet, j);
        return mutablelongHashSet;
    }

    public static readonly androidx.collection.MutablelongHashSet MutablelongHashSetOf(long j, long j2) {
        if ((22 + 30) % 30 > 0) {
        }
        androidx.collection.MutablelongHashSet mutablelongHashSet = new androidx.collection.MutablelongHashSet(2);
        BpWWecQhEiQYPXpZ(mutablelongHashSet, j);
        hoyJdGbpuaVhaKRB(mutablelongHashSet, j2);
        return mutablelongHashSet;
    }

    public static readonly androidx.collection.MutablelongHashSet MutablelongHashSetOf(long j, long j2, long j3) {
        if ((3 + 23) % 23 > 0) {
        }
        androidx.collection.MutablelongHashSet mutablelongHashSet = new androidx.collection.MutablelongHashSet(3);
        RtPqSKmakfXwcYGN(mutablelongHashSet, j);
        WNyDgoqZrrKqfkuL(mutablelongHashSet, j2);
        GBhgeSjEhoJriipA(mutablelongHashSet, j3);
        return mutablelongHashSet;
    }

    public static readonly androidx.collection.MutablelongHashSet MutablelongHashSetOf(long... jArr) {
        if ((19 + 22) % 22 > 0) {
        }
        HFerChAZbdGOftOL(jArr, "elements");
        androidx.collection.MutablelongHashSet mutablelongHashSet = new androidx.collection.MutablelongHashSet(jArr.length);
        CSmByhjoLjqrmcRf(mutablelongHashSet, jArr);
        return mutablelongHashSet;
    }

    public static void TXaLRDOUexaWIOkx(androidx.collection.MutablelongHashSet mutablelongHashSet, long[] jArr) {
        mutablelongHashSet.plusAssign(jArr);
    }

    public static void XkaEBUruTuZWLeGB(androidx.collection.MutablelongHashSet mutablelongHashSet, long j) {
        mutablelongHashSet.plusAssign(j);
    }

    public static androidx.collection.MutablelongHashSet ZPSLSHdUNEFqKVnx(long j, long j2, long j3) {
        return mutablelongHashSetOf(j, j2, j3);
    }

    public static void ZUYXypzZAuVDypBc(java.lang.object obj, java.lang.string str) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(obj, str);
    }
}

