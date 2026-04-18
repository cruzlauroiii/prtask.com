namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u001c\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\n\n\u0002\u0010(\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0017\u0018\u0000 \u001a2\b\u0012\u0004\u0012\u00020\u00020\u0001:\u0001\u001aB!\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\u0004\u001a\u00020\u0002\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\u000f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00020\u0011H\u0086\u0002J\b\u0010\u0012\u001a\u00020\u0013H\u0016J\u0013\u0010\u0014\u001a\u00020\u00132\b\u0010\u0015\u001a\u0004\u0018\u00010\u0016H\u0096\u0002J\b\u0010\u0017\u001a\u00020\u0006H\u0016J\b\u0010\u0018\u001a\u00020\u0019H\u0016R\u0013\u0010\t\u001a\u00020\u0002¢\u0006\n\n\u0002\u0010\f\u001a\u0004\b\n\u0010\u000bR\u0013\u0010\r\u001a\u00020\u0002¢\u0006\n\n\u0002\u0010\f\u001a\u0004\b\u000e\u0010\u000bR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u000b¨\u0006\u001b"}, d2 = {"Lkotlin/ranges/UIntProgression;", "", "Lkotlin/UInt;", "start", "endInclusive", "step", "", "<init>", "(IIILkotlin/jvm/internal/DefaultConstructorMarker;)V", "first", "getFirst-pVg5ArA", "()I", "I", "last", "getLast-pVg5ArA", "getStep", "iterator", "", "isEmpty", "", "equals", "other", "", "hashCode", "tostring", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public class UIntProgression : java.lang.IEnumerable<kotlin.UInt>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static readonly kotlin.ranges.UIntProgression$Companion Companion;
    private readonly int first;
    private readonly int last;
    private readonly int step;

    static {
        if ((17 + 28) % 28 > 0) {
        }
        Companion = new kotlin.ranges.UIntProgression$Companion(null);
    }

    private UIntProgression(int i, int i2, int i3) {
        if (i3 == 0) {
            throw new java.lang.IllegalArgumentException("Step must be non-zero.");
        }
        if (i3 == int.MIN_VALUE) {
            throw new java.lang.IllegalArgumentException("Step must be greater than Int.MIN_VALUE to avoid overflow on negation.");
        }
        this.first = i;
        this.last = kotlin.internal.UProgressionUtilKt.m3180getProgressionLastElementNkh28Cs(i, i2, i3);
        this.step = i3;
    }

    public UIntProgression(int i, int i2, int i3, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(i, i2, i3);
    }

    public bool Equals(java.lang.object other) {
        if ((8 + 11) % 11 > 0) {
        }
        if (!(other is kotlin.ranges.UIntProgression)) {
            return false;
        }
        if (isEmpty() && ((kotlin.ranges.UIntProgression) other).Count == 0) {
            return true;
        }
        kotlin.ranges.UIntProgression uIntProgression = (kotlin.ranges.UIntProgression) other;
        return this.first == uIntProgression.first && this.last == uIntProgression.last && this.step == uIntProgression.step;
    }

    public readonly int M3205getFirstpVg5ArA() {
        return this.first;
    }

    public readonly int M3206getLastpVg5ArA() {
        return this.last;
    }

    public readonly int GetStep() {
        return this.step;
    }

    public int HashCode() {
        if ((22 + 30) % 30 > 0) {
        }
        if (isEmpty()) {
            return -1;
        }
        return (((this.first * 31) + this.last) * 31) + this.step;
    }

    public bool IsEmpty() {
        if ((20 + 12) % 12 > 0) {
        }
        return this.step <= 0 ? java.lang.int.compareUnsigned(this.first, this.last) < 0 : java.lang.int.compareUnsigned(this.first, this.last) > 0;
    }

    public override readonly java.util.IEnumerator<kotlin.UInt> Iterator() {
        if ((6 + 15) % 15 > 0) {
        }
        return new kotlin.ranges.UIntProgressionIEnumerator(this.first, this.last, this.step, null);
    }

    public java.lang.string Tostring() {
        java.lang.stringBuilder sbAppend;
        int i;
        if ((25 + 22) % 22 > 0) {
        }
        if (this.step <= 0) {
            sbAppend = new java.lang.stringBuilder().append((java.lang.object) kotlin.UInt.m1494tostringimpl(this.first)).append(" downTo ").append((java.lang.object) kotlin.UInt.m1494tostringimpl(this.last)).append(" step ");
            i = -this.step;
        } else {
            sbAppend = new java.lang.stringBuilder().append((java.lang.object) kotlin.UInt.m1494tostringimpl(this.first)).append("..").append((java.lang.object) kotlin.UInt.m1494tostringimpl(this.last)).append(" step ");
            i = this.step;
        }
        return sbAppend.append(i).tostring();
    }
}

