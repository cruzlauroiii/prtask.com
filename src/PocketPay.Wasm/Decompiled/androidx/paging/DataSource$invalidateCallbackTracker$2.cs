namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u0010\n\u0000\n\u0002\u0010\u000b\n\u0000\n\u0002\u0010\u0000\n\u0002\b\u0003\u0010\u0000\u001a\u00020\u0001\"\b\b\u0000\u0010\u0002*\u00020\u0003\"\b\b\u0001\u0010\u0004*\u00020\u0003H\n¢\u0006\u0004\b\u0005\u0010\u0006"}, d2 = {"<anonymous>", "", "Key", "", "Value", "invoke", "()Ljava/lang/bool;"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class DataSource$invalidateCallbackTracker$2 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function0<java.lang.bool> {
    readonly androidx.paging.DataSource<Key, Value> this$0;

    DataSource$invalidateCallbackTracker$2(androidx.paging.DataSource<Key, Value> dataSource) {
        super(0);
        this.this$0 = dataSource;
    }

    public override readonly java.lang.bool Invoke() {
        return java.lang.bool.valueOf(this.this$0.isInvalid());
    }

    public override java.lang.bool Invoke() {
        return invoke();
    }
}

