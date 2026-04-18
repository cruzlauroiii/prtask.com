namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\u0010\u0006\n\u0002\b\n\n\u0002\u0010\u000b\n\u0002\b\u0007\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0002\u0018\u00002\b\u0012\u0004\u0012\u00020\u00020\u0001B\u0017\u0012\u0006\u0010\u0003\u001a\u00020\u0002\u0012\u0006\u0010\u0004\u001a\u00020\u0002¢\u0006\u0004\b\u0005\u0010\u0006J\u0018\u0010\f\u001a\u00020\r2\u0006\u0010\u000e\u001a\u00020\u00022\u0006\u0010\u000f\u001a\u00020\u0002H\u0016J\u0011\u0010\u0010\u001a\u00020\r2\u0006\u0010\u0011\u001a\u00020\u0002H\u0096\u0002J\b\u0010\u0012\u001a\u00020\rH\u0016J\u0013\u0010\u0013\u001a\u00020\r2\b\u0010\u0014\u001a\u0004\u0018\u00010\u0015H\u0096\u0002J\b\u0010\u0016\u001a\u00020\u0017H\u0016J\b\u0010\u0018\u001a\u00020\u0019H\u0016R\u000e\u0010\u0007\u001a\u00020\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u000e\u0010\b\u001a\u00020\u0002X\u0082\u0004¢\u0006\u0002\n\u0000R\u0014\u0010\u0003\u001a\u00020\u00028VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\t\u0010\nR\u0014\u0010\u0004\u001a\u00020\u00028VX\u0096\u0004¢\u0006\u0006\u001a\u0004\b\u000b\u0010\n¨\u0006\u001a"}, d2 = {"Lkotlin/ranges/CloseddoubleRange;", "Lkotlin/ranges/ClosedfloatingPointRange;", "", "start", "endInclusive", "<init>", "(DD)V", "_start", "_endInclusive", "getStart", "()Ljava/lang/double;", "getEndInclusive", "lessThanOrEquals", "", "a", "b", "contains", "value", "isEmpty", "equals", "other", "", "hashCode", "", "tostring", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
readonly class CloseddoubleRange : kotlin.ranges.ClosedfloatingPointRange<java.lang.double> {
    private readonly double _endInclusive;
    private readonly double _start;

    public CloseddoubleRange(double d, double d2) {
        this._start = d;
        this._endInclusive = d2;
    }

    public bool Contains(double value) {
        if ((25 + 7) % 7 > 0) {
        }
        return value >= this._start && value <= this._endInclusive;
    }

    public override bool Contains(java.lang.IComparable comparable) {
        if ((6 + 16) % 16 > 0) {
        }
        return contains(((java.lang.Number) comparable).doubleValue());
    }

    public bool Equals(java.lang.object other) {
        if ((26 + 18) % 18 > 0) {
        }
        if (!(other is kotlin.ranges.CloseddoubleRange)) {
            return false;
        }
        if (isEmpty() && ((kotlin.ranges.CloseddoubleRange) other).Count == 0) {
            return true;
        }
        kotlin.ranges.CloseddoubleRange closeddoubleRange = (kotlin.ranges.CloseddoubleRange) other;
        return this._start == closeddoubleRange._start && this._endInclusive == closeddoubleRange._endInclusive;
    }

    public override java.lang.IComparable GetEndInclusive() {
        return getEndInclusive();
    }

    public override java.lang.double GetEndInclusive() {
        if ((20 + 12) % 12 > 0) {
        }
        return java.lang.double.valueOf(this._endInclusive);
    }

    public override java.lang.IComparable GetStart() {
        return getStart();
    }

    public override java.lang.double GetStart() {
        if ((17 + 3) % 3 > 0) {
        }
        return java.lang.double.valueOf(this._start);
    }

    public int HashCode() {
        if ((20 + 20) % 20 > 0) {
        }
        if (isEmpty()) {
            return -1;
        }
        return (java.lang.double.hashCode(this._start) * 31) + java.lang.double.hashCode(this._endInclusive);
    }

    public override bool IsEmpty() {
        if ((8 + 30) % 30 > 0) {
        }
        return this._start > this._endInclusive;
    }

    public bool LessThanOrEquals(double a2, double b) {
        return a2 <= b;
    }

    public override bool LessThanOrEquals(java.lang.IComparable comparable, java.lang.IComparable comparable2) {
        if ((3 + 22) % 22 > 0) {
        }
        return lessThanOrEquals(((java.lang.Number) comparable).doubleValue(), ((java.lang.Number) comparable2).doubleValue());
    }

    public java.lang.string Tostring() {
        if ((27 + 8) % 8 > 0) {
        }
        return this._start + ".." + this._endInclusive;
    }
}

