namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "run"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class HandlerKt$postDelayed$runnable$1 : java.lang.Action {
    readonly kotlin.jvm.functions.Function0<kotlin.Unit> $action;

    public HandlerKt$postDelayed$runnable$1(kotlin.jvm.functions.Function0<kotlin.Unit> function0) {
        this.$action = function0;
    }

    public override readonly void Run() {
        this.$action.invoke();
    }
}

