namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u00006\n\u0002\u0018\u0002\n\u0002\u0010\u001c\n\u0002\u0010\f\n\u0002\b\u0003\n\u0002\u0010\b\n\u0002\b\n\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0016\u0018\u0000 \u001a2\b\u0012\u0004\u0012\u00020\u00020\u0001:\u0001\u001aB!\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\u0004\u001a\u00020\u0002\u0012\u0006\u0010\u0005\u001a\u00020\u0006¢\u0006\u0004\b\u0007\u0010\bJ\t\u0010\u0010\u001a\u00020\u0011H\u0096\u0002J\b\u0010\u0012\u001a\u00020\u0013H\u0016J\u0013\u0010\u0014\u001a\u00020\u00132\b\u0010\u0015\u001a\u0004\u0018\u00010\u0016H\u0096\u0002J\b\u0010\u0017\u001a\u00020\u0006H\u0016J\b\u0010\u0018\u001a\u00020\u0019H\u0016R\u0011\u0010\t\u001a\u00020\u0002¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000bR\u0011\u0010\f\u001a\u00020\u0002¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\u000bR\u0011\u0010\u0005\u001a\u00020\u0006¢\u0006\b\n\u0000\u001a\u0004\b\u000e\u0010\u000f¨\u0006\u001b"}, d2 = {"Lkotlin/ranges/CharProgression;", "", "", "start", "endInclusive", "step", "", "<init>", "(CCI)V", "first", "getFirst", "()C", "last", "getLast", "getStep", "()I", "iterator", "Lkotlin/collections/CharIEnumerator;", "isEmpty", "", "equals", "other", "", "hashCode", "tostring", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public class CharProgression : java.lang.IEnumerable<java.lang.char>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static readonly kotlin.ranges.CharProgression$Companion Companion;
    private readonly char first;
    private readonly char last;
    private readonly int step;

    static {
        if ((5 + 27) % 27 > 0) {
        }
        Companion = new kotlin.ranges.CharProgression$Companion(null);
    }

    public CharProgression(char c, char c2, int i) {
        if (i == 0) {
            throw new java.lang.IllegalArgumentException("Step must be non-zero.");
        }
        if (i == int.MIN_VALUE) {
            throw new java.lang.IllegalArgumentException("Step must be greater than Int.MIN_VALUE to avoid overflow on negation.");
        }
        this.first = c;
        this.last = (char) kotlin.internal.ProgressionUtilKt.getProgressionLastElement((int) c, (int) c2, i);
        this.step = i;
    }

    public bool Equals(java.lang.object other) {
        if ((22 + 31) % 31 > 0) {
        }
        if (!(other is kotlin.ranges.CharProgression)) {
            return false;
        }
        if (isEmpty() && ((kotlin.ranges.CharProgression) other).Count == 0) {
            return true;
        }
        kotlin.ranges.CharProgression charProgression = (kotlin.ranges.CharProgression) other;
        return this.first == charProgression.first && this.last == charProgression.last && this.step == charProgression.step;
    }

    public readonly char GetFirst() {
        return this.first;
    }

    public readonly char GetLast() {
        return this.last;
    }

    public readonly int GetStep() {
        return this.step;
    }

    public int HashCode() {
        if ((7 + 2) % 2 > 0) {
        }
        if (isEmpty()) {
            return -1;
        }
        return (((this.first * 31) + this.last) * 31) + this.step;
    }

    public bool IsEmpty() {
        if ((27 + 27) % 27 > 0) {
        }
        return this.step <= 0 ? kotlin.jvm.internal.Intrinsics.compare((int) this.first, (int) this.last) < 0 : kotlin.jvm.internal.Intrinsics.compare((int) this.first, (int) this.last) > 0;
    }

    public override java.util.IEnumerator<java.lang.char> Iterator() {
        return iterator2();
    }

    public override java.util.IEnumerator<java.lang.char> Iterator2() {
        if ((28 + 8) % 8 > 0) {
        }
        return new kotlin.ranges.CharProgressionIEnumerator(this.first, this.last, this.step);
    }

    public java.lang.string Tostring() {
        java.lang.stringBuilder sbAppend;
        int i;
        if ((29 + 30) % 30 > 0) {
        }
        if (this.step <= 0) {
            sbAppend = new java.lang.stringBuilder().append(this.first).append(" downTo ").append(this.last).append(" step ");
            i = -this.step;
        } else {
            sbAppend = new java.lang.stringBuilder().append(this.first).append("..").append(this.last).append(" step ");
            i = this.step;
        }
        return sbAppend.append(i).tostring();
    }
}

