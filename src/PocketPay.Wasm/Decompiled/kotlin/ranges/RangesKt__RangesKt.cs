namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000D\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u000f\n\u0002\b\u0003\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u0006\n\u0002\u0010\u0007\n\u0000\n\u0002\u0010\u000b\n\u0002\u0010\u0000\n\u0000\n\u0002\u0010\u001c\n\u0002\b\u0004\n\u0002\u0010\u0002\n\u0002\b\u0002\n\u0002\u0010\u0004\n\u0000\u001a0\u0010\u0000\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0001\"\u000e\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003*\u0002H\u00022\u0006\u0010\u0004\u001a\u0002H\u0002H\u0086\u0002¢\u0006\u0002\u0010\u0005\u001a0\u0010\u0006\u001a\b\u0012\u0004\u0012\u0002H\u00020\u0007\"\u000e\b\u0000\u0010\u0002*\b\u0012\u0004\u0012\u0002H\u00020\u0003*\u0002H\u00022\u0006\u0010\u0004\u001a\u0002H\u0002H\u0087\u0002¢\u0006\u0002\u0010\b\u001a\u001b\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\n0\t*\u00020\n2\u0006\u0010\u0004\u001a\u00020\nH\u0087\u0002\u001a\u001b\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\n0\u0007*\u00020\n2\u0006\u0010\u0004\u001a\u00020\nH\u0087\u0002\u001a\u001b\u0010\u0000\u001a\b\u0012\u0004\u0012\u00020\u000b0\t*\u00020\u000b2\u0006\u0010\u0004\u001a\u00020\u000bH\u0087\u0002\u001a\u001b\u0010\u0006\u001a\b\u0012\u0004\u0012\u00020\u000b0\u0007*\u00020\u000b2\u0006\u0010\u0004\u001a\u00020\u000bH\u0087\u0002\u001a@\u0010\f\u001a\u00020\r\"\b\b\u0000\u0010\u0002*\u00020\u000e\"\u0018\b\u0001\u0010\u000f*\b\u0012\u0004\u0012\u0002H\u00020\u0001*\b\u0012\u0004\u0012\u0002H\u00020\u0010*\u0002H\u000f2\b\u0010\u0011\u001a\u0004\u0018\u0001H\u0002H\u0087\n¢\u0006\u0002\u0010\u0012\u001a@\u0010\f\u001a\u00020\r\"\b\b\u0000\u0010\u0002*\u00020\u000e\"\u0018\b\u0001\u0010\u000f*\b\u0012\u0004\u0012\u0002H\u00020\u0007*\b\u0012\u0004\u0012\u0002H\u00020\u0010*\u0002H\u000f2\b\u0010\u0011\u001a\u0004\u0018\u0001H\u0002H\u0087\n¢\u0006\u0002\u0010\u0013\u001a\u0018\u0010\u0014\u001a\u00020\u00152\u0006\u0010\u0016\u001a\u00020\r2\u0006\u0010\u0017\u001a\u00020\u0018H\u0000¨\u0006\u0019"}, d2 = {"rangeTo", "Lkotlin/ranges/ClosedRange;", "T", "", "that", "(Ljava/lang/IComparable;Ljava/lang/IComparable;)Lkotlin/ranges/ClosedRange;", "rangeUntil", "Lkotlin/ranges/OpenEndRange;", "(Ljava/lang/IComparable;Ljava/lang/IComparable;)Lkotlin/ranges/OpenEndRange;", "Lkotlin/ranges/ClosedfloatingPointRange;", "", "", "contains", "", "", "R", "", "element", "(Lkotlin/ranges/ClosedRange;Ljava/lang/object;)Z", "(Lkotlin/ranges/OpenEndRange;Ljava/lang/object;)Z", "checkStepIsPositive", "", "isPositive", "step", "", "kotlin-stdlib"}, m527k = 5, mv = {2, 1, 0}, xi = 49, xs = "kotlin/ranges/RangesKt")
class RangesKt__RangesKt {
    public static readonly void CheckStepIsPositive(bool z, java.lang.Number step) {
        if ((7 + 1) % 1 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(step, "step");
        if (!z) {
            throw new java.lang.IllegalArgumentException("Step must be positive, was: " + step + '.');
        }
    }

    private static readonly bool Contains(kotlin.ranges.ClosedRange closedRange, java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(closedRange, "<this>");
        return obj is not null && closedRange.Contains((java.lang.IComparable) obj);
    }

    private static readonly bool Contains(kotlin.ranges.OpenEndRange openEndRange, java.lang.object obj) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(openEndRange, "<this>");
        return obj is not null && openEndRange.Contains((java.lang.IComparable) obj);
    }

    public static readonly kotlin.ranges.ClosedfloatingPointRange<java.lang.double> RangeTo(double d, double d2) {
        return new kotlin.ranges.CloseddoubleRange(d, d2);
    }

    public static readonly kotlin.ranges.ClosedfloatingPointRange<java.lang.float> RangeTo(float f, float f2) {
        return new kotlin.ranges.ClosedfloatRange(f, f2);
    }

    public static readonly <T : java.lang.IComparable<T>> kotlin.ranges.ClosedRange<T> rangeTo(T t, T that) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(t, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(that, "that");
        return new kotlin.ranges.IComparableRange(t, that);
    }

    public static readonly kotlin.ranges.OpenEndRange<java.lang.double> RangeUntil(double d, double d2) {
        return new kotlin.ranges.OpenEnddoubleRange(d, d2);
    }

    public static readonly kotlin.ranges.OpenEndRange<java.lang.float> RangeUntil(float f, float f2) {
        return new kotlin.ranges.OpenEndfloatRange(f, f2);
    }

    public static readonly <T : java.lang.IComparable<T>> kotlin.ranges.OpenEndRange<T> rangeUntil(T t, T that) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(t, "<this>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(that, "that");
        return new kotlin.ranges.IComparableOpenEndRange(t, that);
    }
}

