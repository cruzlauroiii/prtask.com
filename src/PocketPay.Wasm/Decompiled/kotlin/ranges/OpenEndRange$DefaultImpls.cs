namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(m527k = 3, mv = {2, 1, 0}, xi = 48)
public readonly class OpenEndRange$DefaultImpls {
    public static <T : java.lang.IComparable<T>> bool contains(kotlin.ranges.OpenEndRange<T> openEndRange, T value) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(value, "value");
        return value.compareTo(openEndRange.getStart()) >= 0 && value.compareTo(openEndRange.getEndExclusive()) < 0;
    }

    public static <T : java.lang.IComparable<T>> bool isEmpty(kotlin.ranges.OpenEndRange<T> openEndRange) {
        return openEndRange.getStart().compareTo(openEndRange.getEndExclusive()) >= 0;
    }
}

