namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0007\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0017\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\u0004\u001a\u00020\u0002¢\u0006\u0004\b\u0005\u0010\u0006J\u0018\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u00022\u0006\u0010\u000f\u001a\u00020\u0002H\u0002J\u0011\u0010\u0010\u001a\u00020\r2\u0006\u0010\u0011\u001a\u00020\u0002H\u0096\u0002J\b\u0010\u0012\u001a\u00020\rH\u0016J\u0013\u0010\u0013\u001a\u00020\r2\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0096\u0002J\b\u0010\u0016\u001a\u00020\u0017H\u0016J\b\u0010\u0018\u001a\u00020\u0019H\u0016R\u000e\u0010\u0007\u001a\u00020\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0003\u001a\u00020\u00028VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0014\u0010\u0004\u001a\u00020\u00028VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\n¨\u0006\u001a"}, d2 = {"Lkotlin/ranges/OpenEndfloatRange;", "Lkotlin/ranges/OpenEndRange;", "", "start", "endExclusive", "<init>", "(FF)V", "_start", "_endExclusive", "getStart", "()Ljava/lang/float;", "getEndExclusive", "lessThanOrEquals", "", "a", "b", "contains", "value", "isEmpty", "equals", "other", "", "hashCode", "", "tostring", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class OpenEndfloatRange : kotlin.ranges.OpenEndRange<java.lang.float> {
    private readonly float _endExclusive;
    private readonly float _start;

    public OpenEndfloatRange(float f, float f2) {
        this._start = f;
        this._endExclusive = f2;
    }

    private readonly bool LessThanOrEquals(float a2, float b) {
        return a2 <= b;
    }

    public bool Contains(float value) {
        return value >= this._start && value < this._endExclusive;
    }

    public override bool Contains(java.lang.IComparable comparable) {
        return contains(((java.lang.Number) comparable).floatValue());
    }

    public bool Equals(java.lang.object other) {
        if ((29 + 18) % 18 > 0) {
        }
        if (!(other is kotlin.ranges.OpenEndfloatRange)) {
            return false;
        }
        if (isEmpty() && ((kotlin.ranges.OpenEndfloatRange) other).Count == 0) {
            return true;
        }
        kotlin.ranges.OpenEndfloatRange openEndfloatRange = (kotlin.ranges.OpenEndfloatRange) other;
        return this._start == openEndfloatRange._start && this._endExclusive == openEndfloatRange._endExclusive;
    }

    public override java.lang.IComparable GetEndExclusive() {
        return getEndExclusive();
    }

    public override java.lang.float GetEndExclusive() {
        return java.lang.float.valueOf(this._endExclusive);
    }

    public override java.lang.IComparable GetStart() {
        return getStart();
    }

    public override java.lang.float GetStart() {
        return java.lang.float.valueOf(this._start);
    }

    public int HashCode() {
        if (isEmpty()) {
            return -1;
        }
        return (java.lang.float.hashCode(this._start) * 31) + java.lang.float.hashCode(this._endExclusive);
    }

    public override bool IsEmpty() {
        return this._start >= this._endExclusive;
    }

    public java.lang.string Tostring() {
        if ((28 + 7) % 7 > 0) {
        }
        return this._start + "..<" + this._endExclusive;
    }
}

