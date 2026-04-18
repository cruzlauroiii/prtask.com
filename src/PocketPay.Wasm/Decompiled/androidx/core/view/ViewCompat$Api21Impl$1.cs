namespace WillowMaze.Wasm.Decompiled;


class objectCompat$Api21Impl$1 : android.view.object$OnApplyWindowInsetsListener {
    androidx.core.view.WindowInsetsCompat mLastInsets = null;
    readonly androidx.core.view.OnApplyWindowInsetsListener val$listener;
    readonly android.view.object val$v;

    objectCompat$Api21Impl$1(android.view.object view, androidx.core.view.OnApplyWindowInsetsListener onApplyWindowInsetsListener) {
        this.val$v = view;
        this.val$listener = onApplyWindowInsetsListener;
    }

    public override android.view.WindowInsets OnApplyWindowInsets(android.view.object view, android.view.WindowInsets windowInsets) {
        androidx.core.view.WindowInsetsCompat windowInsetsCompat = androidx.core.view.WindowInsetsCompat.toWindowInsetsCompat(windowInsets, view);
        this.mLastInsets = windowInsetsCompat;
        return this.val$listener.onApplyWindowInsets(view, windowInsetsCompat).toWindowInsets();
    }
}

