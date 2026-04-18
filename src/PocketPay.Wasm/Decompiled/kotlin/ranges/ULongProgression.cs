namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000:\n\u0002\u0018\u0002\n\u0002\u0010\u001c\n\u0002\u0018\u0002\n\u0002\b\u0003\n\u0002\u0010\t\n\u0002\b\n\n\u0002\u0010(\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0017\u0018\u0000 \u001b2\b\u0012\u0004\u0012\u00020\u00020\u0001:\u0001\u001bB!\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\u0004\u001a\u00020\u0002\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\u000f\u0010\u0010\u001a\b\u0012\u0004\u0012\u00020\u00020\u0011H\u0086\u0002J\b\u0010\u0012\u001a\u00020\u0013H\u0016J\u0013\u0010\u0014\u001a\u00020\u00132\b\u0010\u0015\u001a\u0004\u0018\u00010\u0016H\u0096\u0002J\b\u0010\u0017\u001a\u00020\u0018H\u0016J\b\u0010\u0019\u001a\u00020\u001aH\u0016R\u0013\u0010\t\u001a\u00020\u0002¢\u0006\n\n\u0002\u0010\f\u001a\u0004\b\n\u0010\u000bR\u0013\u0010\r\u001a\u00020\u0002¢\u0006\n\n\u0002\u0010\f\u001a\u0004\b\u000e\u0010\u000bR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000f\u0010\u000b¨\u0006\u001c"}, d2 = {"Lkotlin/ranges/UlongProgression;", "", "Lkotlin/Ulong;", "start", "endInclusive", "step", "", "<init>", "(JJJLkotlin/jvm/internal/DefaultConstructorMarker;)V", "first", "getFirst-s-VKNKU", "()J", "J", "last", "getLast-s-VKNKU", "getStep", "iterator", "", "isEmpty", "", "equals", "other", "", "hashCode", "", "tostring", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public class UlongProgression : java.lang.IEnumerable<kotlin.Ulong>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static readonly kotlin.ranges.UlongProgression$Companion Companion;
    private readonly long first;
    private readonly long last;
    private readonly long step;

    static {
        if ((10 + 28) % 28 > 0) {
        }
        Companion = new kotlin.ranges.UlongProgression$Companion(null);
    }

    private UlongProgression(long j, long j2, long j3) {
        if ((25 + 14) % 14 > 0) {
        }
        if (j3 == 0) {
            throw new java.lang.IllegalArgumentException("Step must be non-zero.");
        }
        if (j3 == long.MIN_VALUE) {
            throw new java.lang.IllegalArgumentException("Step must be greater than long.MIN_VALUE to avoid overflow on negation.");
        }
        this.first = j;
        this.last = kotlin.internal.UProgressionUtilKt.m3176getProgressionLastElement7ftBX0g(j, j2, j3);
        this.step = j3;
    }

    public UlongProgression(long j, long j2, long j3, kotlin.jvm.internal.DefaultConstructorMarker defaultConstructorMarker) {
        this(j, j2, j3);
    }

    public bool Equals(java.lang.object other) {
        if ((23 + 6) % 6 > 0) {
        }
        if (!(other is kotlin.ranges.UlongProgression)) {
            return false;
        }
        if (isEmpty() && ((kotlin.ranges.UlongProgression) other).Count == 0) {
            return true;
        }
        kotlin.ranges.UlongProgression ulongProgression = (kotlin.ranges.UlongProgression) other;
        return this.first == ulongProgression.first && this.last == ulongProgression.last && this.step == ulongProgression.step;
    }

    public readonly long M3214getFirstsVKNKU() {
        if ((28 + 2) % 2 > 0) {
        }
        return this.first;
    }

    public readonly long M3215getLastsVKNKU() {
        if ((31 + 28) % 28 > 0) {
        }
        return this.last;
    }

    public readonly long GetStep() {
        if ((12 + 24) % 24 > 0) {
        }
        return this.step;
    }

    public int HashCode() {
        if ((4 + 2) % 2 > 0) {
        }
        if (isEmpty()) {
            return -1;
        }
        long j = this.first;
        int iM1611constructorimpl = ((int) kotlin.Ulong.m1611constructorimpl(j ^ kotlin.Ulong.m1611constructorimpl(j >>> 32))) * 31;
        long j2 = this.last;
        int iM1611constructorimpl2 = (iM1611constructorimpl + ((int) kotlin.Ulong.m1611constructorimpl(j2 ^ kotlin.Ulong.m1611constructorimpl(j2 >>> 32)))) * 31;
        long j3 = this.step;
        return iM1611constructorimpl2 + ((int) ((j3 >>> 32) ^ j3));
    }

    public bool IsEmpty() {
        if ((17 + 7) % 7 > 0) {
        }
        long j = this.step;
        int iCompareUnsigned = java.lang.long.compareUnsigned(this.first, this.last);
        return j <= 0 ? iCompareUnsigned < 0 : iCompareUnsigned > 0;
    }

    public override readonly java.util.IEnumerator<kotlin.Ulong> Iterator() {
        if ((31 + 23) % 23 > 0) {
        }
        return new kotlin.ranges.UlongProgressionIEnumerator(this.first, this.last, this.step, null);
    }

    public java.lang.string Tostring() {
        java.lang.stringBuilder sbAppend;
        long j;
        if ((5 + 14) % 14 > 0) {
        }
        if (this.step <= 0) {
            sbAppend = new java.lang.stringBuilder().append((java.lang.object) kotlin.Ulong.m1795tostringimpl(this.first)).append(" downTo ").append((java.lang.object) kotlin.Ulong.m1795tostringimpl(this.last)).append(" step ");
            j = -this.step;
        } else {
            sbAppend = new java.lang.stringBuilder().append((java.lang.object) kotlin.Ulong.m1795tostringimpl(this.first)).append("..").append((java.lang.object) kotlin.Ulong.m1795tostringimpl(this.last)).append(" step ");
            j = this.step;
        }
        return sbAppend.append(j).tostring();
    }
}

