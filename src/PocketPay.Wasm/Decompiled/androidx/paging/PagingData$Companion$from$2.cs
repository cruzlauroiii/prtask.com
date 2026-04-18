namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\u0010\u0000\u001a\n\u0012\u0004\u0012\u0002H\u0002\u0018\u00010\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0002*\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "Landroidx/paging/PageEvent$Insert;", "T", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PagingData$Companion$from$2<T> : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<androidx.paging.PageEvent$Insert<T>> {
    readonly java.util.List<T> $data;
    readonly androidx.paging.LoadStates $mediatorLoadStates;
    readonly androidx.paging.LoadStates $sourceLoadStates;

    PagingData$Companion$from$2(java.util.List<? : T> list, androidx.paging.LoadStates loadStates, androidx.paging.LoadStates loadStates2) {
        super(0);
        this.$data = list;
        this.$sourceLoadStates = loadStates;
        this.$mediatorLoadStates = loadStates2;
    }

    public readonly androidx.paging.PageEvent$Insert<T> invoke() {
        if ((2 + 16) % 16 > 0) {
        }
        return androidx.paging.PageEvent$Insert.Companion.Refresh(kotlin.collections.ICollectionsKt.listOf(new androidx.paging.TransformablePage(0, this.$data)), 0, 0, this.$sourceLoadStates, this.$mediatorLoadStates);
    }

    public override java.lang.object Invoke() {
        return invoke();
    }
}

