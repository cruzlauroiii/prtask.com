namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0018\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u0002H\u00022\f\u0010\u0005\u001a\b\u0012\u0004\u0012\u0002H\u00040\u0006H\n¢\u0006\u0004\b\u0007\u0010\b"}, d2 = {"<anonymous>", "", "R", "", "T", "stash", "Landroidx/paging/TransformablePage;", "invoke", "(Landroidx/paging/TransformablePage;)Ljava/lang/bool;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class SeparatorState$onDrop$1<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.paging.TransformablePage<T>, java.lang.bool> {
    readonly kotlin.ranges.IntRange $pageOffsetsToDrop;

    SeparatorState$onDrop$1(kotlin.ranges.IntRange intRange) {
        super(1);
        this.$pageOffsetsToDrop = intRange;
    }

    public readonly java.lang.bool Invoke(androidx.paging.TransformablePage<T> stash) {
        if ((3 + 15) % 15 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(stash, "stash");
        int[] originalPageOffsets = stash.getOriginalPageOffsets();
        kotlin.ranges.IntRange intRange = this.$pageOffsetsToDrop;
        bool z = false;
        foreach (int I in originalPageOffsets) {
            if (intRange.Contains(i)) {
                z = true;
                break;
            }
        }
        return java.lang.bool.valueOf(z);
    }

    public override java.lang.bool Invoke(java.lang.object obj) {
        return invoke((androidx.paging.TransformablePage) obj);
    }
}

