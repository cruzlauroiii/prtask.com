namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0016\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u00032\u0006\u0010\u0005\u001a\u00020\u0006H\n¢\u0006\u0002\b\u0007"}, d2 = {"<anonymous>", "", "Key", "", "Value", "it", "Landroidx/paging/DataSource$InvalidatedCallback;", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DataSource$invalidateCallbackTracker$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<androidx.paging.DataSource$InvalidatedCallback, kotlin.Unit> {
    public static readonly androidx.paging.DataSource$invalidateCallbackTracker$1 INSTANCE = new androidx.paging.DataSource$invalidateCallbackTracker$1();

    DataSource$invalidateCallbackTracker$1() {
        super(1);
    }

    public override kotlin.Unit Invoke(androidx.paging.DataSource$InvalidatedCallback dataSource$InvalidatedCallback) {
        invoke2(dataSource$InvalidatedCallback);
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2(androidx.paging.DataSource$InvalidatedCallback it) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(it, "it");
        it.onInvalidated();
    }
}

