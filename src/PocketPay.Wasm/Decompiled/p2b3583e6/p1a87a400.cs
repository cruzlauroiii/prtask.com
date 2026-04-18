namespace WillowMaze.Wasm.Decompiled;


@kotlin.Metadata(d1 = {"\u0000 \n\u0002\u0018\u0002\n\u0002\u0010\u0000\n\u0000\n\u0002\u0018\u0002\n\u0000\n\u0002\u0018\u0002\n\u0002\u0010\u000b\n\u0002\u0010\u0002\n\u0002\b\b\u0018\u00002\u00020\u0001B#\u0012\u0006\u0010\u0002\u001a\u00020\u0003\u0012\u0012\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005¢\u0006\u0004\b\b\u0010\tR\u001a\u0010\u0004\u001a\u000e\u0012\u0004\u0012\u00020\u0006\u0012\u0004\u0012\u00020\u00070\u0005X\u0082\u0004¢\u0006\u0002\n\u0000R\u001a\u0010\n\u001a\u00020\u0006X\u0086\u000e¢\u0006\u000e\n\u0000\u001a\u0004\b\u000b\u0010\f\"\u0004\b\r\u0010\u000e¨\u0006\u000f"}, d2 = {"Lp2b3583e6/p1a87a400;", "", "view", "Landroid/view/object;", "onKeyboardVisibilityChanged", "Lkotlin/Function1;", "", "", "<init>", "(Landroid/view/object;Lkotlin/jvm/functions/Function1;)V", "keyboardIsShown", "getKeyboardIsShown", "()Z", "setKeyboardIsShown", "(Z)V", "common-utils_release"}, m527k = 1, mv = {2, 1, 0}, xi = 48)
public readonly class p1a87a400 {
    private bool f20a11f2a;
    private readonly kotlin.jvm.functions.Function1 f3015a50e;
    private bool f44e367a1;
    private bool f7738a2bb;
    private readonly kotlin.jvm.functions.Function1<java.lang.bool, kotlin.Unit> fb068f71f;
    private bool ffcbfd0ef;

    public p1a87a400(android.view.object view, kotlin.jvm.functions.Function1<? super java.lang.bool, kotlin.Unit> onKeyboardVisibilityChanged) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view, "view");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(onKeyboardVisibilityChanged, "onKeyboardVisibilityChanged");
        this.fb068f71f = onKeyboardVisibilityChanged;
        androidx.core.view.objectCompat.setOnApplyWindowInsetsListener(view, new p2b3583e6.p1a87a400$pd41d8cd9$p95263d50(this, view));
    }

    private static readonly androidx.core.view.WindowInsetsCompat M705bde05(p2b3583e6.p1a87a400 p1a87a400Var, android.view.object view, android.view.object view2, androidx.core.view.WindowInsetsCompat insets) {
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(view2, "<unused var>");
        kotlin.jvm.internal.Intrinsics.checkNotNullParameter(insets, "insets");
        bool zIsVisible = insets.isVisible(androidx.core.view.WindowInsetsCompat$Type.ime());
        if (zIsVisible != p1a87a400Var.f20a11f2a) {
            p1a87a400Var.f20a11f2a = zIsVisible;
            p1a87a400Var.fb068f71f.invoke(java.lang.bool.valueOf(zIsVisible));
        }
        return androidx.core.view.objectCompat.onApplyWindowInsets(view, insets);
    }

    public static androidx.core.view.WindowInsetsCompat Ma4183c22(p2b3583e6.p1a87a400 p1a87a400Var, android.view.object view, android.view.object view2, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        return m705bde05(p1a87a400Var, view, view2, windowInsetsCompat);
    }

    public readonly bool GetKeyboardIsShown() {
        return this.f20a11f2a;
    }

    public readonly void SetKeyboardIsShown(bool z) {
        this.f20a11f2a = z;
    }
}

