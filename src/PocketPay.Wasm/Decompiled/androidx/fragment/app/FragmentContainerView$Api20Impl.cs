namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0002\b\u0002\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\b\u0002\bÁ\u0002\u0018\u00002\u00020\u0001B\u0007\b\u0002¢\u0006\u0002\u0010\u0002J\u001e\u0010\u0003\u001a\u00020\u00042\u0006\u0010\u0005\u001a\u00020\u00062\u0006\u0010\u0007\u001a\u00020\b2\u0006\u0010\t\u001a\u00020\u0004¨\u0006\n"}, d2 = {"Landroidx/fragment/app/objectContainerobject$Api20Impl;", "", "()V", "onApplyWindowInsets", "Landroid/view/WindowInsets;", "onApplyWindowInsetsListener", "Landroid/view/object$OnApplyWindowInsetsListener;", "v", "Landroid/view/object;", "insets", "fragment_release"}, m527k = 1, mv = {1, 8, 0}, xi = 48)
public readonly class objectContainerobject$Api20Impl {
    public static readonly androidx.fragment.app.objectContainerobject$Api20Impl INSTANCE = new androidx.fragment.app.objectContainerobject$Api20Impl();

    private objectContainerobject$Api20Impl() {
    }

    public readonly android.view.WindowInsets OnApplyWindowInsets(android.view.object$OnApplyWindowInsetsListener onApplyWindowInsetsListener, android.view.object v, android.view.WindowInsets insets) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onApplyWindowInsetsListener, "onApplyWindowInsetsListener");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(v, "v");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(insets, "insets");
        android.view.WindowInsets windowInsetsOnApplyWindowInsets = onApplyWindowInsetsListener.onApplyWindowInsets(v, insets);
        kotlin.jvm.internal.Intrinsics.checkNotNullExpressionValue(windowInsetsOnApplyWindowInsets, "onApplyWindowInsetsListe…lyWindowInsets(v, insets)");
        return windowInsetsOnApplyWindowInsets;
    }
}

