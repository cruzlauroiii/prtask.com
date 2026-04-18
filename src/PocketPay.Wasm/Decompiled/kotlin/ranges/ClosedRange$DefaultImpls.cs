namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class ClosedRange$DefaultImpls {
    public static <T : java.lang.IComparable<T>> bool contains(kotlin.ranges.ClosedRange<T> closedRange, T value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        return value.compareTo(closedRange.getStart()) >= 0 && value.compareTo(closedRange.getEndInclusive()) <= 0;
    }

    public static <T : java.lang.IComparable<T>> bool isEmpty(kotlin.ranges.ClosedRange<T> closedRange) {
        return closedRange.getStart().compareTo(closedRange.getEndInclusive()) > 0;
    }
}

