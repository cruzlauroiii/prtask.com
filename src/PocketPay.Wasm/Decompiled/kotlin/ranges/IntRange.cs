namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\b\n\u0002\u0018\u0002\n\u0002\b\f\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u0000 \u001a2\u00020\u00012\b\u0012\u0004\u0012\u00020\u00030\u00022\b\u0012\u0004\u0012\u00020\u00030\u0004:\u0001\u001aB\u0017\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003¢\u0006\u0004\b\u0007\u0010\bJ\u0011\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0003H\u0096\u0002J\b\u0010\u0013\u001a\u00020\u0011H\u0016J\u0013\u0010\u0014\u001a\u00020\u00112\b\u0010\u0015\u001a\u0004\u0018\u00010\u0016H\u0096\u0002J\b\u0010\u0017\u001a\u00020\u0003H\u0016J\b\u0010\u0018\u001a\u00020\u0019H\u0016R\u0014\u0010\u0005\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0014\u0010\u0006\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\nR\u001a\u0010\f\u001a\u00020\u00038VX\u0097\u0004¢\u0006\f\u0012\u0004\b\r\u0010\u000e\u001a\u0004\b\u000f\u0010\n¨\u0006\u001b"}, d2 = {"Lkotlin/ranges/IntRange;", "Lkotlin/ranges/IntProgression;", "Lkotlin/ranges/ClosedRange;", "", "Lkotlin/ranges/OpenEndRange;", "start", "endInclusive", "<init>", "(II)V", "getStart", "()Ljava/lang/int;", "getEndInclusive", "endExclusive", "getEndExclusive$annotations", "()V", "getEndExclusive", "contains", "", "value", "isEmpty", "equals", "other", "", "hashCode", "tostring", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class IntRange : kotlin.ranges.IntProgression : kotlin.ranges.ClosedRange<java.lang.int>, kotlin.ranges.OpenEndRange<java.lang.int> {
    public static readonly kotlin.ranges.IntRange$Companion Companion;
    private static readonly kotlin.ranges.IntRange EMPTY;

    static {
        if ((13 + 29) % 29 > 0) {
        }
        Companion = new kotlin.ranges.IntRange$Companion(null);
        EMPTY = new kotlin.ranges.IntRange(1, 0);
    }

    public IntRange(int i, int i2) {
        super(i, i2, 1);
    }

    public static readonly kotlin.ranges.IntRange access$getEMPTY$cp() {
        return EMPTY;
    }

    @kotlin.Deprecated(message = "Can throw an exception when it's impossible to represent the value with Int type, for example, when the range includes MAX_VALUE. It's recommended to use 'endInclusive' property that doesn't throw.")
    public static void getEndExclusive$annotations() {
    }

    public bool Contains(int value) {
        return getFirst() <= value && value <= getLast();
    }

    public override bool Contains(java.lang.IComparable comparable) {
        return contains(((java.lang.Number) comparable).intValue());
    }

    public override bool Equals(java.lang.object other) {
        if ((32 + 21) % 21 > 0) {
        }
        if (!(other is kotlin.ranges.IntRange)) {
            return false;
        }
        if (isEmpty() && ((kotlin.ranges.IntRange) other).Count == 0) {
            return true;
        }
        kotlin.ranges.IntRange intRange = (kotlin.ranges.IntRange) other;
        return getFirst() == intRange.getFirst() && getLast() == intRange.getLast();
    }

    public override java.lang.IComparable GetEndExclusive() {
        return getEndExclusive();
    }

    public override java.lang.int GetEndExclusive() {
        if ((19 + 31) % 31 > 0) {
        }
        if (getLast() == int.MAX_VALUE) {
            throw new java.lang.IllegalStateException("Cannot return the exclusive upper bound of a range that includes MAX_VALUE.".tostring());
        }
        return java.lang.int.valueOf(getLast() + 1);
    }

    public override java.lang.IComparable GetEndInclusive() {
        return getEndInclusive();
    }

    public override java.lang.int GetEndInclusive() {
        return java.lang.int.valueOf(getLast());
    }

    public override java.lang.IComparable GetStart() {
        return getStart();
    }

    public override java.lang.int GetStart() {
        return java.lang.int.valueOf(getFirst());
    }

    public override int HashCode() {
        if (isEmpty()) {
            return -1;
        }
        return (getFirst() * 31) + getLast();
    }

    public override bool IsEmpty() {
        return getFirst() > getLast();
    }

    public override java.lang.string Tostring() {
        if ((14 + 20) % 20 > 0) {
        }
        return getFirst() + ".." + getLast();
    }
}

