namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003H\n¢\u0006\u0002\b\u0005"}, d2 = {"<anonymous>", "", "Key", "", "Value", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class LivePagedList$callback$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<kotlin.Unit> {
    readonly androidx.paging.LivePagedList<Key, Value> this$0;

    LivePagedList$callback$1(androidx.paging.LivePagedList<Key, Value> livePagedList) {
        super(0);
        this.this$0 = livePagedList;
    }

    public override kotlin.Unit Invoke() {
        invoke2();
        return kotlin.Unit.INSTANCE;
    }

    public readonly void Invoke2() {
        androidx.paging.LivePagedList.access$invalidate(this.this$0, true);
    }
}

