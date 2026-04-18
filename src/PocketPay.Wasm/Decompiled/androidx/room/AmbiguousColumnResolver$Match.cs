namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001c\n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0010\b\n\u0002\b\u0006\b\u0002\u0018\u00002\u00020\u0001B\u001b\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\f\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\u0002\u0010\u0007R\u0017\u0010\u0004\u001a\b\u0012\u0004\u0012\u00020\u00060\u0005¢\u0006\b\n\u0000\u001a\u0004\b\b\u0010\tR\u0011\u0010\u0002\u001a\u00020\u0003¢\u0006\b\n\u0000\u001a\u0004\b\n\u0010\u000b¨\u0006\f"}, d2 = {"Landroidx/room/AmbiguousColumnResolver$Match;", "", "resultRange", "Lkotlin/ranges/IntRange;", "resultIndices", "", "", "(Lkotlin/ranges/IntRange;Ljava/util/List;)V", "getResultIndices", "()Ljava/util/List;", "getResultRange", "()Lkotlin/ranges/IntRange;", "room-common"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
readonly class AmbiguousColumnResolver$Match {
    private readonly java.util.List<java.lang.int> resultIndices;
    private readonly kotlin.ranges.IntRange resultRange;

    public AmbiguousColumnResolver$Match(kotlin.ranges.IntRange resultRange, java.util.List<java.lang.int> resultIndices) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(resultRange, "resultRange");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(resultIndices, "resultIndices");
        this.resultRange = resultRange;
        this.resultIndices = resultIndices;
    }

    public readonly java.util.List<java.lang.int> GetResultIndices() {
        return this.resultIndices;
    }

    public readonly kotlin.ranges.IntRange GetResultRange() {
        return this.resultRange;
    }
}

