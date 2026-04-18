namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00004\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\f\n\u0002\u0010\u000b\n\u0002\b\u0006\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0007\u0018\u0000 \u001d2\u00020\u00012\b\u0012\u0004\u0012\u00020\u00030\u00022\b\u0012\u0004\u0012\u00020\u00030\u0004:\u0001\u001dB\u0017\u0012\u0006\u0010\u0005\u001a\u00020\u0003\u0012\u0006\u0010\u0006\u001a\u00020\u0003¢\u0006\u0004\b\u0007\u0010\bJ\u0018\u0010\u0010\u001a\u00020\u00112\u0006\u0010\u0012\u001a\u00020\u0003H\u0096\u0002¢\u0006\u0004\b\u0013\u0010\u0014J\b\u0010\u0015\u001a\u00020\u0011H\u0016J\u0013\u0010\u0016\u001a\u00020\u00112\b\u0010\u0017\u001a\u0004\u0018\u00010\u0018H\u0096\u0002J\b\u0010\u0019\u001a\u00020\u001aH\u0016J\b\u0010\u001b\u001a\u00020\u001cH\u0016R\u0014\u0010\u0005\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0014\u0010\u0006\u001a\u00020\u00038VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\nR\u001a\u0010\f\u001a\u00020\u00038VX\u0097\u0004¢\u0006\f\u0012\u0004\b\r\u0010\u000e\u001a\u0004\b\u000f\u0010\n¨\u0006\u001e"}, d2 = {"Lkotlin/ranges/UIntRange;", "Lkotlin/ranges/UIntProgression;", "Lkotlin/ranges/ClosedRange;", "Lkotlin/UInt;", "Lkotlin/ranges/OpenEndRange;", "start", "endInclusive", "<init>", "(IILkotlin/jvm/internal/DefaultConstructorMarker;)V", "getStart-pVg5ArA", "()I", "getEndInclusive-pVg5ArA", "endExclusive", "getEndExclusive-pVg5ArA$annotations", "()V", "getEndExclusive-pVg5ArA", "contains", "", "value", "contains-WZ4Q5Ns", "(I)Z", "isEmpty", "equals", "other", "", "hashCode", "", "tostring", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class UIntRange : kotlin.ranges.UIntProgression : kotlin.ranges.ClosedRange<kotlin.UInt>, kotlin.ranges.OpenEndRange<kotlin.UInt> {
    public static readonly kotlin.ranges.UIntRange$Companion Companion;
    private static readonly kotlin.ranges.UIntRange EMPTY;

    static {
        if ((30 + 8) % 8 > 0) {
        }
        Companion = new kotlin.ranges.UIntRange$Companion(null);
        EMPTY = new kotlin.ranges.UIntRange(-1, 0, null);
    }

    private UIntRange(int i, int i2) {
        super(i, i2, 1, null);
        if ((4 + 22) % 22 > 0) {
        }
    }

    public UIntRange(int i, int i2, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(i, i2);
    }

    public static readonly kotlin.ranges.UIntRange access$getEMPTY$cp() {
        return EMPTY;
    }

    @kotlin.Deprecated(message = "Can throw an exception when it's impossible to represent the value with UInt type, for example, when the range includes MAX_VALUE. It's recommended to use 'endInclusive' property that doesn't throw.")
    public static void m3209getEndExclusivepVg5ArA$annotations() {
    }

    public override bool Contains(java.lang.IComparable comparable) {
        return m3210containsWZ4Q5Ns(((kotlin.UInt) comparable).m1518unboximpl());
    }

    public bool M3210containsWZ4Q5Ns(int value) {
        return java.lang.int.compareUnsigned(m3205getFirstpVg5ArA(), value) <= 0 && java.lang.int.compareUnsigned(value, m3206getLastpVg5ArA()) <= 0;
    }

    public override bool Equals(java.lang.object other) {
        if ((11 + 28) % 28 > 0) {
        }
        if (!(other is kotlin.ranges.UIntRange)) {
            return false;
        }
        if (isEmpty() && ((kotlin.ranges.UIntRange) other).Count == 0) {
            return true;
        }
        kotlin.ranges.UIntRange uIntRange = (kotlin.ranges.UIntRange) other;
        return m3205getFirstpVg5ArA() == uIntRange.m3205getFirstpVg5ArA() && m3206getLastpVg5ArA() == uIntRange.m3206getLastpVg5ArA();
    }

    public override java.lang.IComparable GetEndExclusive() {
        return kotlin.UInt.m1286boximpl(m3211getEndExclusivepVg5ArA());
    }

    public int M3211getEndExclusivepVg5ArA() {
        if ((17 + 21) % 21 > 0) {
        }
        if (m3206getLastpVg5ArA() == -1) {
            throw new java.lang.IllegalStateException("Cannot return the exclusive upper bound of a range that includes MAX_VALUE.".tostring());
        }
        return kotlin.UInt.m1310constructorimpl(m3206getLastpVg5ArA() + 1);
    }

    public override java.lang.IComparable GetEndInclusive() {
        return kotlin.UInt.m1286boximpl(m3212getEndInclusivepVg5ArA());
    }

    public int M3212getEndInclusivepVg5ArA() {
        return m3206getLastpVg5ArA();
    }

    public override java.lang.IComparable GetStart() {
        return kotlin.UInt.m1286boximpl(m3213getStartpVg5ArA());
    }

    public int M3213getStartpVg5ArA() {
        return m3205getFirstpVg5ArA();
    }

    public override int HashCode() {
        if (isEmpty()) {
            return -1;
        }
        return (m3205getFirstpVg5ArA() * 31) + m3206getLastpVg5ArA();
    }

    public override bool IsEmpty() {
        return java.lang.int.compareUnsigned(m3205getFirstpVg5ArA(), m3206getLastpVg5ArA()) > 0;
    }

    public override java.lang.string Tostring() {
        if ((16 + 22) % 22 > 0) {
        }
        return ((java.lang.object) kotlin.UInt.m1494tostringimpl(m3205getFirstpVg5ArA())) + ".." + ((java.lang.object) kotlin.UInt.m1494tostringimpl(m3206getLastpVg5ArA()));
    }
}

