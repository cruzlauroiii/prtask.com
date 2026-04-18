namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0000\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "T", "", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class PagingDataPresenter$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly androidx.paging.PagingDataPresenter<T> this$0;

    PagingDataPresenter$1(androidx.paging.PagingDataPresenter<T> pagingDataPresenter) {
        super(0);
        this.this$0 = pagingDataPresenter;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        androidx.paging.PagingDataPresenter.access$get_onPagesUpdatedFlow$p(this.this$0).tryEmit(kotlin.Unit.INSTANCE);
    }
}

