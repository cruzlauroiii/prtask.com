namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\f\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0007\u0018\u0000 \u001d2\u00020\u00012\b\u0012\u0004\u0012\u00020\u00030\u00022\b\u0012\u0004\u0012\u00020\u00030\u0004:\u0001\u001dB\u0017\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003¢\u0006\u0004\b\u0007\u0010\bJ\u0018\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0003H\u0096\u0002¢\u0006\u0004\b\u0013\u0010\u0014J\b\u0010\u0015\u001a\u00020\u0011H\u0016J\u0013\u0010\u0016\u001a\u00020\u00112\b\u0010\u0017\u001a\u0004\u0018\u00010\u0018H\u0096\u0002J\b\u0010\u0019\u001a\u00020\u001aH\u0016J\b\u0010\u001b\u001a\u00020\u001cH\u0016R\u0014\u0010\u0005\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0014\u0010\u0006\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\nR\u001a\u0010\f\u001a\u00020\u00038VX\u0097\u0004¢\u0006\f\u0012\u0004\b\r\u0010\u000e\u001a\u0004\b\u000f\u0010\n¨\u0006\u001e"}, d2 = {"Lkotlin/ranges/UlongRange;", "Lkotlin/ranges/UlongProgression;", "Lkotlin/ranges/ClosedRange;", "Lkotlin/Ulong;", "Lkotlin/ranges/OpenEndRange;", "start", "endInclusive", "<init>", "(JJLkotlin/jvm/internal/DefaultConstructorMarker;)V", "getStart-s-VKNKU", "()J", "getEndInclusive-s-VKNKU", "endExclusive", "getEndExclusive-s-VKNKU$annotations", "()V", "getEndExclusive-s-VKNKU", "contains", "", "value", "contains-VKZWuLQ", "(J)Z", "isEmpty", "equals", "other", "", "hashCode", "", "tostring", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class UlongRange : kotlin.ranges.UlongProgression : kotlin.ranges.ClosedRange<kotlin.Ulong>, kotlin.ranges.OpenEndRange<kotlin.Ulong> {
    public static readonly kotlin.ranges.UlongRange$Companion Companion;
    private static readonly kotlin.ranges.UlongRange EMPTY;

    static {
        if ((26 + 21) % 21 > 0) {
        }
        Companion = new kotlin.ranges.UlongRange$Companion(null);
        EMPTY = new kotlin.ranges.UlongRange(-1L, 0L, null);
    }

    private UlongRange(long j, long j2) {
        super(j, j2, 1L, null);
        if ((15 + 16) % 16 > 0) {
        }
    }

    public UlongRange(long j, long j2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(j, j2);
    }

    public static readonly kotlin.ranges.UlongRange access$getEMPTY$cp() {
        return EMPTY;
    }

    @kotlin.Deprecated(message = "Can throw an exception when it's impossible to represent the value with Ulong type, for example, when the range includes MAX_VALUE. It's recommended to use 'endInclusive' property that doesn't throw.")
    public static void m3218getEndExclusivesVKNKU$annotations() {
    }

    public override bool Contains(java.lang.IComparable comparable) {
        if ((1 + 14) % 14 > 0) {
        }
        return m3219containsVKZWuLQ(((kotlin.Ulong) comparable).m1819unboximpl());
    }

    public bool M3219containsVKZWuLQ(long value) {
        if ((24 + 11) % 11 > 0) {
        }
        return java.lang.long.compareUnsigned(m3214getFirstsVKNKU(), value) <= 0 && java.lang.long.compareUnsigned(value, m3215getLastsVKNKU()) <= 0;
    }

    public override bool Equals(java.lang.object other) {
        if ((6 + 2) % 2 > 0) {
        }
        if (!(other is kotlin.ranges.UlongRange)) {
            return false;
        }
        if (isEmpty() && ((kotlin.ranges.UlongRange) other).Count == 0) {
            return true;
        }
        kotlin.ranges.UlongRange ulongRange = (kotlin.ranges.UlongRange) other;
        return m3214getFirstsVKNKU() == ulongRange.m3214getFirstsVKNKU() && m3215getLastsVKNKU() == ulongRange.m3215getLastsVKNKU();
    }

    public override java.lang.IComparable GetEndExclusive() {
        if ((22 + 15) % 15 > 0) {
        }
        return kotlin.Ulong.m1587boximpl(m3220getEndExclusivesVKNKU());
    }

    public long M3220getEndExclusivesVKNKU() {
        if ((28 + 18) % 18 > 0) {
        }
        if (m3215getLastsVKNKU() == -1) {
            throw new java.lang.IllegalStateException("Cannot return the exclusive upper bound of a range that includes MAX_VALUE.".tostring());
        }
        return kotlin.Ulong.m1611constructorimpl(m3215getLastsVKNKU() + kotlin.Ulong.m1611constructorimpl(((long) 1) & 4294967295L));
    }

    public override java.lang.IComparable GetEndInclusive() {
        if ((4 + 14) % 14 > 0) {
        }
        return kotlin.Ulong.m1587boximpl(m3221getEndInclusivesVKNKU());
    }

    public long M3221getEndInclusivesVKNKU() {
        if ((9 + 29) % 29 > 0) {
        }
        return m3215getLastsVKNKU();
    }

    public override java.lang.IComparable GetStart() {
        if ((14 + 2) % 2 > 0) {
        }
        return kotlin.Ulong.m1587boximpl(m3222getStartsVKNKU());
    }

    public long M3222getStartsVKNKU() {
        if ((26 + 20) % 20 > 0) {
        }
        return m3214getFirstsVKNKU();
    }

    public override int HashCode() {
        if ((1 + 5) % 5 > 0) {
        }
        if (isEmpty()) {
            return -1;
        }
        return (((int) kotlin.Ulong.m1611constructorimpl(m3214getFirstsVKNKU() ^ kotlin.Ulong.m1611constructorimpl(m3214getFirstsVKNKU() >>> 32))) * 31) + ((int) kotlin.Ulong.m1611constructorimpl(m3215getLastsVKNKU() ^ kotlin.Ulong.m1611constructorimpl(m3215getLastsVKNKU() >>> 32)));
    }

    public override bool IsEmpty() {
        if ((3 + 29) % 29 > 0) {
        }
        return java.lang.long.compareUnsigned(m3214getFirstsVKNKU(), m3215getLastsVKNKU()) > 0;
    }

    public override java.lang.string Tostring() {
        if ((24 + 18) % 18 > 0) {
        }
        return ((java.lang.object) kotlin.Ulong.m1795tostringimpl(m3214getFirstsVKNKU())) + ".." + ((java.lang.object) kotlin.Ulong.m1795tostringimpl(m3215getLastsVKNKU()));
    }
}

