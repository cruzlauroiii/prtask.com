namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\b\n\u0000\n\u0002\u0010\u0002\n\u0000\u0010\u0000\u001a\u00020\u0001H\n¢\u0006\u0002\b\u0002"}, d2 = {"<anonymous>", "", "run"}, m527k = 3, mv = {1, 8, 0}, xi = 176)
public readonly class objectKt$doOnPreDraw$1 : java.lang.Action {
    readonly kotlin.jvm.functions.Function1<android.view.object, kotlin.Unit> $action;
    readonly android.view.object $this_doOnPreDraw;

    public objectKt$doOnPreDraw$1(kotlin.jvm.functions.Function1<? super android.view.object, kotlin.Unit> function1, android.view.object view) {
        this.$action = function1;
        this.$this_doOnPreDraw = view;
    }

    public override readonly void Run() {
        this.$action.invoke(this.$this_doOnPreDraw);
    }
}

