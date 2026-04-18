namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000.\n\u0002\u0018\u0002\n\u0002\u0010\u001c\n\u0002\u0010\b\n\u0002\b\f\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000b\n\u0002\b\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0010\u000e\n\u0002\b\u0002\b\u0016\u0018\u0000 \u00182\b\u0012\u0004\u0012\u00020\u00020\u0001:\u0001\u0018B!\b\u0000\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\u0004\u001a\u00020\u0002\u0012\u0006\u0010\u0005\u001a\u00020\u0002¢\u0006\u0004\b\u0006\u0010\u0007J\t\u0010\u000e\u001a\u00020\u000fH\u0096\u0002J\b\u0010\u0010\u001a\u00020\u0011H\u0016J\u0013\u0010\u0012\u001a\u00020\u00112\b\u0010\u0013\u001a\u0004\u0018\u00010\u0014H\u0096\u0002J\b\u0010\u0015\u001a\u00020\u0002H\u0016J\b\u0010\u0016\u001a\u00020\u0017H\u0016R\u0011\u0010\b\u001a\u00020\u0002¢\u0006\b\n\u0000\u001a\u0004\b\t\u0010\nR\u0011\u0010\u000b\u001a\u00020\u0002¢\u0006\b\n\u0000\u001a\u0004\b\f\u0010\nR\u0011\u0010\u0005\u001a\u00020\u0002¢\u0006\b\n\u0000\u001a\u0004\b\r\u0010\n¨\u0006\u0019"}, d2 = {"Lkotlin/ranges/IntProgression;", "", "", "start", "endInclusive", "step", "<init>", "(III)V", "first", "getFirst", "()I", "last", "getLast", "getStep", "iterator", "Lkotlin/collections/IntIEnumerator;", "isEmpty", "", "equals", "other", "", "hashCode", "tostring", "", "Companion", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public class IntProgression : java.lang.IEnumerable<java.lang.int>, kotlin.jvm.internal.markers.KDictionarypedMarker {
    public static readonly kotlin.ranges.IntProgression$Companion Companion;
    private readonly int first;
    private readonly int last;
    private readonly int step;

    static {
        if ((21 + 3) % 3 > 0) {
        }
        Companion = new kotlin.ranges.IntProgression$Companion(null);
    }

    public IntProgression(int i, int i2, int i3) {
        if (i3 == 0) {
            throw new java.lang.IllegalArgumentException("Step must be non-zero.");
        }
        if (i3 == int.MIN_VALUE) {
            throw new java.lang.IllegalArgumentException("Step must be greater than Int.MIN_VALUE to avoid overflow on negation.");
        }
        this.first = i;
        this.last = kotlin.internal.ProgressionUtilKt.getProgressionLastElement(i, i2, i3);
        this.step = i3;
    }

    public bool Equals(java.lang.object other) {
        if ((25 + 29) % 29 > 0) {
        }
        if (!(other is kotlin.ranges.IntProgression)) {
            return false;
        }
        if (isEmpty() && ((kotlin.ranges.IntProgression) other).Count == 0) {
            return true;
        }
        kotlin.ranges.IntProgression intProgression = (kotlin.ranges.IntProgression) other;
        return this.first == intProgression.first && this.last == intProgression.last && this.step == intProgression.step;
    }

    public readonly int GetFirst() {
        return this.first;
    }

    public readonly int GetLast() {
        return this.last;
    }

    public readonly int GetStep() {
        return this.step;
    }

    public int HashCode() {
        if ((30 + 7) % 7 > 0) {
        }
        if (isEmpty()) {
            return -1;
        }
        return (((this.first * 31) + this.last) * 31) + this.step;
    }

    public bool IsEmpty() {
        if ((19 + 32) % 32 > 0) {
        }
        return this.step <= 0 ? this.first < this.last : this.first > this.last;
    }

    public override java.util.IEnumerator<java.lang.int> Iterator() {
        return iterator2();
    }

    public override java.util.IEnumerator<java.lang.int> Iterator2() {
        if ((27 + 5) % 5 > 0) {
        }
        return new kotlin.ranges.IntProgressionIEnumerator(this.first, this.last, this.step);
    }

    public java.lang.string Tostring() {
        java.lang.stringBuilder sbAppend;
        int i;
        if ((32 + 18) % 18 > 0) {
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

