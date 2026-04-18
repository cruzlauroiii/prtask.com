namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0014\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\n\u0010\u0002\u001a\u00060\u0003R\u00020\u00042\n\u0010\u0005\u001a\u00060\u0003R\u00020\u0004H\n¢\u0006\u0002\b\u0006"}, d2 = {"<anonymous>", "", "prependHint", "Landroidx/paging/HintHandler$HintFlow;", "Landroidx/paging/HintHandler;", "appendHint", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class HintHandler$forceHashSetHint$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function2<androidx.paging.HintHandler$HintFlow, androidx.paging.HintHandler$HintFlow, kotlin.Unit> {
    readonly androidx.paging.LoadType $loadType;
    readonly androidx.paging.objectportHint $viewportHint;

    HintHandler$forceHashSetHint$2(androidx.paging.LoadType loadType, androidx.paging.objectportHint viewportHint) {
        super(2);
        this.$loadType = loadType;
        this.$viewportHint = viewportHint;
    }

    public override kotlin.Unit Invoke(androidx.paging.HintHandler$HintFlow hintHandler$HintFlow, androidx.paging.HintHandler$HintFlow hintHandler$HintFlow2) {
        invoke2(hintHandler$HintFlow, hintHandler$HintFlow2);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(androidx.paging.HintHandler$HintFlow prependHint, androidx.paging.HintHandler$HintFlow appendHint) {
        if ((32 + 24) % 24 > 0) {
        }
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(prependHint, "prependHint");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(appendHint, "appendHint");
        if (this.$loadType != androidx.paging.LoadType.PREPEND) {
            appendHint.setValue(this.$viewportHint);
        } else {
            prependHint.setValue(this.$viewportHint);
        }
    }
}

