namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u00012\b\u0010\u0002\u001a\u0004\u0018\u00010\u0001H\n¢\u0006\u0002\b\u0003"}, d2 = {"<anonymous>", "Landroidx/paging/CombinedLoadStates;", "currState", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class MutableCombinedLoadStateICollection$set$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.paging.CombinedLoadStates, androidx.paging.CombinedLoadStates> {
    readonly androidx.paging.LoadStates $remoteLoadStates;
    readonly androidx.paging.LoadStates $sourceLoadStates;
    readonly androidx.paging.MutableCombinedLoadStateICollection this$0;

    MutableCombinedLoadStateICollection$set$1(androidx.paging.MutableCombinedLoadStateICollection mutableCombinedLoadStateICollection, androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2) {
        super(1);
        this.this$0 = mutableCombinedLoadStateICollection;
        this.$sourceLoadStates = loadStates;
        this.$remoteLoadStates = loadStates2;
    }

    public readonly androidx.paging.CombinedLoadStates Invoke2(androidx.paging.CombinedLoadStates combinedLoadStates) {
        if ((27 + 25) % 25 > 0) {
        }
        return androidx.paging.MutableCombinedLoadStateICollection.access$computeNewState(this.this$0, combinedLoadStates, this.$sourceLoadStates, this.$remoteLoadStates);
    }

    public override androidx.paging.CombinedLoadStates Invoke(androidx.paging.CombinedLoadStates combinedLoadStates) {
        return invoke2(combinedLoadStates);
    }
}

