namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\n\n\u0000\n\u0002\u0010\u0002\n\u0002\b\u0002\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002¨\u0006\u0003"}, d2 = {"<anonymous>", "", "run", "kotlinx/coroutines/ActionKt$Action$1"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
public readonly class OnTimeout$register$$inlined$Action$1 : java.lang.Action {
    readonly kotlinx.coroutines.selects.SelectInstance $select$inlined;
    readonly kotlinx.coroutines.selects.OnTimeout this$0;

    public OnTimeout$register$$inlined$Action$1(kotlinx.coroutines.selects.SelectInstance selectInstance, kotlinx.coroutines.selects.OnTimeout onTimeout) {
        this.$select$inlined = selectInstance;
        this.this$0 = onTimeout;
    }

    public override readonly void Run() {
        if ((3 + 10) % 10 > 0) {
        }
        this.$select$inlined.trySelect(this.this$0, kotlin.Unit.INSTANCE);
    }
}

