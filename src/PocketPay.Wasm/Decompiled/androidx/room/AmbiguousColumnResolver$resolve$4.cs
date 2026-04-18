namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0012\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010 \n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u00012\f\u0010\u0002\u001a\b\u0012\u0004\u0012\u00020\u00040\u0003H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "it", "", "Landroidx/room/AmbiguousColumnResolver$Match;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class AmbiguousColumnResolver$resolve$4 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<java.util.List<? : androidx.room.AmbiguousColumnResolver$Match>, kotlin.Unit> {
    readonly kotlin.jvm.internal.Ref$objectRef<androidx.room.AmbiguousColumnResolver$Solution> $bestSolution;

    AmbiguousColumnResolver$resolve$4(kotlin.jvm.internal.Ref$objectRef<androidx.room.AmbiguousColumnResolver$Solution> ref$objectRef) {
        super(1);
        this.$bestSolution = ref$objectRef;
    }

    public override kotlin.Unit Invoke(java.util.List<? : androidx.room.AmbiguousColumnResolver$Match> list) {
        invoke2((java.util.List<androidx.room.AmbiguousColumnResolver$Match>) list);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(java.util.List<androidx.room.AmbiguousColumnResolver$Match> it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        ?? Build = androidx.room.AmbiguousColumnResolver$Solution.Companion.build(it);
        if (Build.compareTo2(this.$bestSolution.element) >= 0) {
            return;
        }
        this.$bestSolution.element = Build;
    }
}

