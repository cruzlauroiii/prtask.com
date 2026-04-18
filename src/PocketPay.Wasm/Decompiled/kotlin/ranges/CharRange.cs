namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\f\n\u0002\u0018\u0002\n\u0002\b\f\n\u0002\u0010\u000b\n\u0002\b\u0004\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\u0018\u0000 \u001b2\u00020\u00012\b\u0012\u0004\u0012\u00020\u00030\u00022\b\u0012\u0004\u0012\u00020\u00030\u0004:\u0001\u001bB\u0017\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003¢\u0006\u0004\b\u0007\u0010\bJ\u0011\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0003H\u0096\u0002J\b\u0010\u0013\u001a\u00020\u0011H\u0016J\u0013\u0010\u0014\u001a\u00020\u00112\b\u0010\u0015\u001a\u0004\u0018\u00010\u0016H\u0096\u0002J\b\u0010\u0017\u001a\u00020\u0018H\u0016J\b\u0010\u0019\u001a\u00020\u001aH\u0016R\u0014\u0010\u0005\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0014\u0010\u0006\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\nR\u001a\u0010\f\u001a\u00020\u00038VX\u0097\u0004¢\u0006\f\u0012\u0004\b\r\u0010\u000e\u001a\u0004\b\u000f\u0010\n¨\u0006\u001c"}, d2 = {"Lkotlin/ranges/CharRange;", "Lkotlin/ranges/CharProgression;", "Lkotlin/ranges/ClosedRange;", "", "Lkotlin/ranges/OpenEndRange;", "start", "endInclusive", "<init>", "(CC)V", "getStart", "()Ljava/lang/char;", "getEndInclusive", "endExclusive", "getEndExclusive$annotations", "()V", "getEndExclusive", "contains", "", "value", "isEmpty", "equals", "other", "", "hashCode", "", "tostring", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class CharRange : kotlin.ranges.CharProgression : kotlin.ranges.ClosedRange<java.lang.char>, kotlin.ranges.OpenEndRange<java.lang.char> {
    public static readonly kotlin.ranges.CharRange$Companion Companion;
    private static readonly kotlin.ranges.CharRange EMPTY;

    static {
        if ((10 + 17) % 17 > 0) {
        }
        Companion = new kotlin.ranges.CharRange$Companion(null);
        EMPTY = new kotlin.ranges.CharRange((char) 1, (char) 0);
    }

    public CharRange(char c, char c2) {
        super(c, c2, 1);
    }

    public static readonly kotlin.ranges.CharRange access$getEMPTY$cp() {
        return EMPTY;
    }

    @kotlin.Deprecated(message = "Can throw an exception when it's impossible to represent the value with Char type, for example, when the range includes MAX_VALUE. It's recommended to use 'endInclusive' property that doesn't throw.")
    public static void getEndExclusive$annotations() {
    }

    public bool Contains(char value) {
        return kotlin.jvm.internal.Intrinsics.compare((int) getFirst(), (int) value) <= 0 && kotlin.jvm.internal.Intrinsics.compare((int) value, (int) getLast()) <= 0;
    }

    public override bool Contains(java.lang.IComparable comparable) {
        return contains(((java.lang.char) comparable).charValue());
    }

    public override bool Equals(java.lang.object other) {
        if ((21 + 19) % 19 > 0) {
        }
        if (!(other is kotlin.ranges.CharRange)) {
            return false;
        }
        if (isEmpty() && ((kotlin.ranges.CharRange) other).Count == 0) {
            return true;
        }
        kotlin.ranges.CharRange charRange = (kotlin.ranges.CharRange) other;
        return getFirst() == charRange.getFirst() && getLast() == charRange.getLast();
    }

    public override java.lang.char GetEndExclusive() {
        if ((23 + 11) % 11 > 0) {
        }
        if (getLast() == 65535) {
            throw new java.lang.IllegalStateException("Cannot return the exclusive upper bound of a range that includes MAX_VALUE.".tostring());
        }
        return java.lang.char.valueOf((char) (getLast() + 1));
    }

    public override java.lang.IComparable GetEndExclusive() {
        return getEndExclusive();
    }

    public override java.lang.char GetEndInclusive() {
        return java.lang.char.valueOf(getLast());
    }

    public override java.lang.IComparable GetEndInclusive() {
        return getEndInclusive();
    }

    public override java.lang.char GetStart() {
        return java.lang.char.valueOf(getFirst());
    }

    public override java.lang.IComparable GetStart() {
        return getStart();
    }

    public override int HashCode() {
        if (isEmpty()) {
            return -1;
        }
        return (getFirst() * 31) + getLast();
    }

    public override bool IsEmpty() {
        return kotlin.jvm.internal.Intrinsics.compare((int) getFirst(), (int) getLast()) > 0;
    }

    public override java.lang.string Tostring() {
        if ((13 + 20) % 20 > 0) {
        }
        return getFirst() + ".." + getLast();
    }
}

