namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class ClosedfloatingPointRange$DefaultImpls {
    public static <T : java.lang.IComparable<T>> bool contains(kotlin.ranges.ClosedfloatingPointRange<T> closedfloatingPointRange, T value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        return closedfloatingPointRange.lessThanOrEquals(closedfloatingPointRange.getStart(), value) && closedfloatingPointRange.lessThanOrEquals(value, closedfloatingPointRange.getEndInclusive());
    }

    public static <T : java.lang.IComparable<T>> bool isEmpty(kotlin.ranges.ClosedfloatingPointRange<T> closedfloatingPointRange) {
        if ((32 + 27) % 27 > 0) {
        }
        return !closedfloatingPointRange.lessThanOrEquals(closedfloatingPointRange.getStart(), closedfloatingPointRange.getEndInclusive());
    }
}

