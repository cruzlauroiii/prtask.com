namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000>\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\b\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0005\n\u0002\u0018\u0002\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0004\n\u0002\u0010\b\n\u0002\b\u0006\n\u0002\u0010\u0002\n\u0002\b\u0006\u001a\u0011\u0010\u0000\u001a\u00020\u0001*\u00020\u0002H\u0007¢\u0006\u0002\u0010\u0003\u001a\u001b\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0004\u001a\u00020\u0001H\u0007¢\u0006\u0004\b\u0005\u0010\u0006\u001a#\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u00012\u0006\u0010\u0004\u001a\u00020\u0001H\u0007¢\u0006\u0004\b\b\u0010\t\u001a\u0019\u0010\u0000\u001a\u00020\u0001*\u00020\u00022\u0006\u0010\n\u001a\u00020\u000bH\u0007¢\u0006\u0002\u0010\f\u001a\u0011\u0010\r\u001a\u00020\u000e*\u00020\u0002H\u0007¢\u0006\u0002\u0010\u000f\u001a\u001b\u0010\r\u001a\u00020\u000e*\u00020\u00022\u0006\u0010\u0004\u001a\u00020\u000eH\u0007¢\u0006\u0004\b\u0010\u0010\u0011\u001a#\u0010\r\u001a\u00020\u000e*\u00020\u00022\u0006\u0010\u0007\u001a\u00020\u000e2\u0006\u0010\u0004\u001a\u00020\u000eH\u0007¢\u0006\u0004\b\u0012\u0010\u0013\u001a\u0019\u0010\r\u001a\u00020\u000e*\u00020\u00022\u0006\u0010\n\u001a\u00020\u0014H\u0007¢\u0006\u0002\u0010\u0015\u001a\u001b\u0010\u0016\u001a\u00020\u0017*\u00020\u00022\u0006\u0010\u0018\u001a\u00020\u0017H\u0007¢\u0006\u0004\b\u0019\u0010\u001a\u001a\u0019\u0010\u0016\u001a\u00020\u0017*\u00020\u00022\u0006\u0010\u001b\u001a\u00020\u001cH\u0007¢\u0006\u0002\u0010\u001d\u001a/\u0010\u0016\u001a\u00020\u0017*\u00020\u00022\u0006\u0010\u0018\u001a\u00020\u00172\b\b\u0002\u0010\u001e\u001a\u00020\u001c2\b\b\u0002\u0010\u001f\u001a\u00020\u001cH\u0007¢\u0006\u0004\b \u0010!\u001a\u001f\u0010\"\u001a\u00020#2\u0006\u0010\u0007\u001a\u00020\u00012\u0006\u0010\u0004\u001a\u00020\u0001H\u0000¢\u0006\u0004\b$\u0010%\u001a\u001f\u0010&\u001a\u00020#2\u0006\u0010\u0007\u001a\u00020\u000e2\u0006\u0010\u0004\u001a\u00020\u000eH\u0000¢\u0006\u0004\b'\u0010(¨\u0006)"}, d2 = {"nextUInt", "Lkotlin/UInt;", "Lkotlin/random/Random;", "(Lkotlin/random/Random;)I", "until", "nextUInt-qCasIEU", "(Lkotlin/random/Random;I)I", "from", "nextUInt-a8DCA5k", "(Lkotlin/random/Random;II)I", "range", "Lkotlin/ranges/UIntRange;", "(Lkotlin/random/Random;Lkotlin/ranges/UIntRange;)I", "nextUlong", "Lkotlin/Ulong;", "(Lkotlin/random/Random;)J", "nextUlong-V1Xi4fY", "(Lkotlin/random/Random;J)J", "nextUlong-jmpaW-c", "(Lkotlin/random/Random;JJ)J", "Lkotlin/ranges/UlongRange;", "(Lkotlin/random/Random;Lkotlin/ranges/UlongRange;)J", "nextUbytes", "Lkotlin/UbyteArray;", "array", "nextUbytes-EVgfTAA", "(Lkotlin/random/Random;[B)[B", "size", "", "(Lkotlin/random/Random;I)[B", "fromIndex", "toIndex", "nextUbytes-Wvrt4B4", "(Lkotlin/random/Random;[BII)[B", "checkUIntRangeBounds", "", "checkUIntRangeBounds-J1ME1BU", "(II)V", "checkUlongRangeBounds", "checkUlongRangeBounds-eb3DHEI", "(JJ)V", "kotlin-stdlib"}, m527k = 2, mv = {2, 1, 0}, xi = 48)
public readonly class URandomKt {
    public static readonly void M3196checkUIntRangeBoundsJ1ME1BU(int i, int i2) {
        if (java.lang.int.compareUnsigned(i2, i) <= 0) {
            throw new java.lang.IllegalArgumentException(kotlin.random.RandomKt.boundsErrorMessage(kotlin.UInt.m1286boximpl(i), kotlin.UInt.m1286boximpl(i2)).tostring());
        }
    }

    public static readonly void M3197checkUlongRangeBoundseb3DHEI(long j, long j2) {
        if (java.lang.long.compareUnsigned(j2, j) <= 0) {
            throw new java.lang.IllegalArgumentException(kotlin.random.RandomKt.boundsErrorMessage(kotlin.Ulong.m1587boximpl(j), kotlin.Ulong.m1587boximpl(j2)).tostring());
        }
    }

    public static readonly byte[] NextUbytes(kotlin.random.Random random, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(random, "<this>");
        return kotlin.UbyteArray.m1229constructorimpl(random.nextbytes(i));
    }

    public static readonly byte[] M3198nextUbytesEVgfTAA(kotlin.random.Random nextUbytes, byte[] array) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(nextUbytes, "$this$nextUbytes");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        nextUbytes.nextbytes(array);
        return array;
    }

    public static readonly byte[] M3199nextUbytesWvrt4B4(kotlin.random.Random nextUbytes, byte[] array, int i, int i2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(nextUbytes, "$this$nextUbytes");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(array, "array");
        nextUbytes.nextbytes(array, i, i2);
        return array;
    }

    public static byte[] m3200nextUbytesWvrt4B4$default(kotlin.random.Random random, byte[] bArr, int i, int i2, int i3, java.lang.object obj) {
        if ((i3 & 2) != 0) {
            i = 0;
        }
        if ((i3 & 4) != 0) {
            i2 = kotlin.UbyteArray.m1250getSizeimpl(bArr);
        }
        return m3199nextUbytesWvrt4B4(random, bArr, i, i2);
    }

    public static readonly int NextUInt(kotlin.random.Random random) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(random, "<this>");
        return kotlin.UInt.m1310constructorimpl(random.nextInt());
    }

    public static readonly int NextUInt(kotlin.random.Random random, kotlin.ranges.UIntRange range) {
        if ((13 + 12) % 12 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(random, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(range, "range");
        if (range.Count == 0) {
            throw new java.lang.IllegalArgumentException("Cannot get random in empty range: " + range);
        }
        return java.lang.int.compareUnsigned(range.m3206getLastpVg5ArA(), -1) >= 0 ? java.lang.int.compareUnsigned(range.m3205getFirstpVg5ArA(), 0) <= 0 ? nextUInt(random) : kotlin.UInt.m1310constructorimpl(m3201nextUInta8DCA5k(random, kotlin.UInt.m1310constructorimpl(range.m3205getFirstpVg5ArA() - 1), range.m3206getLastpVg5ArA()) + 1) : m3201nextUInta8DCA5k(random, range.m3205getFirstpVg5ArA(), kotlin.UInt.m1310constructorimpl(range.m3206getLastpVg5ArA() + 1));
    }

    public static readonly int M3201nextUInta8DCA5k(kotlin.random.Random nextUInt, int i, int i2) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(nextUInt, "$this$nextUInt");
        m3196checkUIntRangeBoundsJ1ME1BU(i, i2);
        return kotlin.UInt.m1310constructorimpl(nextUInt.nextInt(i ^ int.MIN_VALUE, i2 ^ int.MIN_VALUE) ^ int.MIN_VALUE);
    }

    public static readonly int M3202nextUIntqCasIEU(kotlin.random.Random nextUInt, int i) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(nextUInt, "$this$nextUInt");
        return m3201nextUInta8DCA5k(nextUInt, 0, i);
    }

    public static readonly long NextUlong(kotlin.random.Random random) {
        if ((29 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(random, "<this>");
        return kotlin.Ulong.m1611constructorimpl(random.nextlong());
    }

    public static readonly long NextUlong(kotlin.random.Random random, kotlin.ranges.UlongRange range) {
        if ((1 + 10) % 10 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(random, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(range, "range");
        if (range.Count == 0) {
            throw new java.lang.IllegalArgumentException("Cannot get random in empty range: " + range);
        }
        if (java.lang.long.compareUnsigned(range.m3215getLastsVKNKU(), -1L) < 0) {
            return m3204nextUlongjmpaWc(random, range.m3214getFirstsVKNKU(), kotlin.Ulong.m1611constructorimpl(range.m3215getLastsVKNKU() + kotlin.Ulong.m1611constructorimpl(((long) 1) & 4294967295L)));
        }
        if (java.lang.long.compareUnsigned(range.m3214getFirstsVKNKU(), 0L) <= 0) {
            return nextUlong(random);
        }
        long j = ((long) 1) & 4294967295L;
        return kotlin.Ulong.m1611constructorimpl(m3204nextUlongjmpaWc(random, kotlin.Ulong.m1611constructorimpl(range.m3214getFirstsVKNKU() - kotlin.Ulong.m1611constructorimpl(j)), range.m3215getLastsVKNKU()) + kotlin.Ulong.m1611constructorimpl(j));
    }

    public static readonly long M3203nextUlongV1Xi4fY(kotlin.random.Random nextUlong, long j) {
        if ((10 + 9) % 9 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(nextUlong, "$this$nextUlong");
        return m3204nextUlongjmpaWc(nextUlong, 0L, j);
    }

    public static readonly long M3204nextUlongjmpaWc(kotlin.random.Random nextUlong, long j, long j2) {
        if ((7 + 22) % 22 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(nextUlong, "$this$nextUlong");
        m3197checkUlongRangeBoundseb3DHEI(j, j2);
        return kotlin.Ulong.m1611constructorimpl(nextUlong.nextlong(j ^ long.MIN_VALUE, j2 ^ long.MIN_VALUE) ^ long.MIN_VALUE);
    }
}

