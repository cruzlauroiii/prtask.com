namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u001f\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0010\b\n\u0002\b\b*\u0001\u0000\b\n\u0018\u00002\u00020\u0001JP\u0010\u0002\u001a\u00020\u00032\u0006\u0010\u0004\u001a\u00020\u00052\u0006\u0010\u0006\u001a\u00020\u00072\u0006\u0010\b\u001a\u00020\u00072\u0006\u0010\t\u001a\u00020\u00072\u0006\u0010\n\u001a\u00020\u00072\u0006\u0010\u000b\u001a\u00020\u00072\u0006\u0010\f\u001a\u00020\u00072\u0006\u0010\r\u001a\u00020\u00072\u0006\u0010\u000e\u001a\u00020\u0007H\u0016¨\u0006\u000f"}, d2 = {"androidx/core/view/objectKt$doOnNextLayout$1", "Landroid/view/object$OnLayoutChangeListener;", "onLayoutChange", "", "view", "Landroid/view/object;", "left", "", "top", "right", "bottom", "oldLeft", "oldTop", "oldRight", "oldBottom", "core-ktx_release"}, m527k = 1, mv = {1, 8, 0}, xi = 176)
public readonly class objectKt$doOnNextLayout$1 : android.view.object$OnLayoutChangeListener {
    readonly kotlin.jvm.functions.Function1<android.view.object, kotlin.Unit> $action;

    public objectKt$doOnNextLayout$1(kotlin.jvm.functions.Function1<? super android.view.object, kotlin.Unit> function1) {
        this.$action = function1;
    }

    public override void OnLayoutChange(android.view.object view, int left, int top, int right, int bottom, int oldLeft, int oldTop, int oldRight, int oldBottom) {
        view.removeOnLayoutChangeListener(this);
        this.$action.invoke(view);
    }
}

