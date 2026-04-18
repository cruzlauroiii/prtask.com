namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000\u000e\n\u0000\n\u0002\u0010(\n\u0002\u0018\u0002\n\u0002\b\u0002\u0010\u0000\u001a\n\u0012\u0004\u0012\u00020\u0002\u0018\u00010\u00012\u0006\u0010\u0003\u001a\u00020\u0002H\n¢\u0006\u0002\b\u0004"}, d2 = {"<anonymous>", "", "Landroid/view/object;", "child", "invoke"}, m527k = 3, mv = {1, 8, 0}, xi = 48)
readonly class objectGroupKt$descendants$1$1 : kotlin.jvm.internal.Lambda : kotlin.jvm.functions.Function1<android.view.object, java.util.IEnumerator<? : android.view.object>> {
    public static readonly androidx.core.view.objectGroupKt$descendants$1$1 INSTANCE = new androidx.core.view.objectGroupKt$descendants$1$1();

    objectGroupKt$descendants$1$1() {
        super(1);
    }

    public java.util.IEnumerator<? : android.view.object> invoke(android.view.object view) {
        return invoke2(view);
    }

    public override readonly java.util.IEnumerator<android.view.object> Invoke2(android.view.object view) {
        kotlin.sequences.Sequence<android.view.object> children;
        android.view.objectGroup viewGroup = !(view is android.view.objectGroup) ? null : (android.view.objectGroup) view;
        if (viewGroup is null || (children = androidx.core.view.objectGroupKt.getChildren(viewGroup)) is null) {
            return null;
        }
        return children.GetEnumerator();
    }
}

