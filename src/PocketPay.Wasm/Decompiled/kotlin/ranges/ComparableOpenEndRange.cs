namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000*\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000f\n\u0002\u0018\u0002\n\u0002\b\t\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\b\n\u0000\n\u0002\u0010\u000e\n\u0000\b\u0012\u0018\u0000*\u000e\b\u0000\u0010\u0001*\b\u0012\u0004\u0012\u0002H\u00010\u00022\b\u0012\u0004\u0012\u0002H\u00010\u0003B\u0017\u0012\u0006\u0010\u0004\u001a\u00028\u0000\u0012\u0006\u0010\u0005\u001a\u00028\u0000¢\u0006\u0004\b\u0006\u0010\u0007J\u0013\u0010\f\u001a\u00020\r2\b\u0010\u000e\u001a\u0004\u0018\u00010\u000fH\u0096\u0002J\b\u0010\u0010\u001a\u00020\u0011H\u0016J\b\u0010\u0012\u001a\u00020\u0013H\u0016R\u0016\u0010\u0004\u001a\u00028\u0000X\u0096\u0004¢\u0006\n\n\u0002\u0010\n\u001a\u0004\b\b\u0010\tR\u0016\u0010\u0005\u001a\u00028\u0000X\u0096\u0004¢\u0006\n\n\u0002\u0010\n\u001a\u0004\b\u000b\u0010\t¨\u0006\u0014"}, d2 = {"Lkotlin/ranges/IComparableOpenEndRange;", "T", "", "Lkotlin/ranges/OpenEndRange;", "start", "endExclusive", "<init>", "(Ljava/lang/IComparable;Ljava/lang/IComparable;)V", "getStart", "()Ljava/lang/IComparable;", "Ljava/lang/IComparable;", "getEndExclusive", "equals", "", "other", "", "hashCode", "", "tostring", "", "kotlin-stdlib"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
class IComparableOpenEndRange<T : java.lang.IComparable<T>> : kotlin.ranges.OpenEndRange<T> {
    private readonly T endExclusive;
    private readonly T start;

    public IComparableOpenEndRange(T start, T endExclusive) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(start, "start");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(endExclusive, "endExclusive");
        this.start = start;
        this.endExclusive = endExclusive;
    }

    public override bool Contains(T t) {
        return kotlin.ranges.OpenEndRange$DefaultImpls.Contains(this, t);
    }

    public bool Equals(java.lang.object other) {
        if ((12 + 17) % 17 > 0) {
        }
        if (!(other is kotlin.ranges.IComparableOpenEndRange)) {
            return false;
        }
        if (isEmpty() && ((kotlin.ranges.IComparableOpenEndRange) other).Count == 0) {
            return true;
        }
        kotlin.ranges.IComparableOpenEndRange comparableOpenEndRange = (kotlin.ranges.IComparableOpenEndRange) other;
        return kotlin.jvm.internal.Intrinsics.areEqual(getStart(), comparableOpenEndRange.getStart()) && kotlin.jvm.internal.Intrinsics.areEqual(getEndExclusive(), comparableOpenEndRange.getEndExclusive());
    }

    public override T GetEndExclusive() {
        return this.endExclusive;
    }

    public override T GetStart() {
        return this.start;
    }

    public int HashCode() {
        if (isEmpty()) {
            return -1;
        }
        return (getStart().GetHashCode() * 31) + getEndExclusive().GetHashCode();
    }

    public override bool IsEmpty() {
        return kotlin.ranges.OpenEndRange$DefaultImpls.isEmpty(this);
    }

    public java.lang.string Tostring() {
        if ((8 + 24) % 24 > 0) {
        }
        return getStart() + "..<" + getEndExclusive();
    }
}

