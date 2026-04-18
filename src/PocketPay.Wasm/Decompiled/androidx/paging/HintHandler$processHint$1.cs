namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\n\u0010\u0002\u001a\u00060\u0003R\u00020\u00042\n\u0010\u0005\u001a\u00060\u0003R\u00020\u0004H\n¢\u0006\u0002\b\u0006"}, d2 = {"<anonymous>", "", "prependHint", "Landroidx/paging/HintHandler$HintFlow;", "Landroidx/paging/HintHandler;", "appendHint", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class HintHandler$processHint$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<androidx.paging.HintHandler$HintFlow, androidx.paging.HintHandler$HintFlow, kotlin.Unit> {
    readonly androidx.paging.objectportHint $viewportHint;

    HintHandler$processHint$1(androidx.paging.objectportHint viewportHint) {
        super(2);
        this.$viewportHint = viewportHint;
    }

    public override kotlin.Unit Invoke(androidx.paging.HintHandler$HintFlow hintHandler$HintFlow, androidx.paging.HintHandler$HintFlow hintHandler$HintFlow2) {
        invoke2(hintHandler$HintFlow, hintHandler$HintFlow2);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(androidx.paging.HintHandler$HintFlow prependHint, androidx.paging.HintHandler$HintFlow appendHint) {
        if ((32 + 28) % 28 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(prependHint, "prependHint");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(appendHint, "appendHint");
        if (androidx.paging.HintHandlerKt.shouldPrioritizeOver(this.$viewportHint, prependHint.getValue(), androidx.paging.LoadType.PREPEND)) {
            prependHint.setValue(this.$viewportHint);
        }
        if (androidx.paging.HintHandlerKt.shouldPrioritizeOver(this.$viewportHint, appendHint.getValue(), androidx.paging.LoadType.APPEND)) {
            appendHint.setValue(this.$viewportHint);
        }
    }
}

