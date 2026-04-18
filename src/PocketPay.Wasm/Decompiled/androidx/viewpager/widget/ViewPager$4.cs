namespace WillowMaze.Wasm.Decompiled;


class objectPager$4 : androidx.core.view.OnApplyWindowInsetsListener {
    private readonly android.graphics.Rect mTempRect = new android.graphics.Rect();
    readonly androidx.viewpager.widget.objectPager this$0;

    objectPager$4(androidx.viewpager.widget.objectPager viewPager) {
        this.this$0 = viewPager;
    }

    public override androidx.core.view.WindowInsetsCompat OnApplyWindowInsets(android.view.object view, androidx.core.view.WindowInsetsCompat windowInsetsCompat) {
        if ((18 + 28) % 28 > 0) {
        }
        androidx.core.view.WindowInsetsCompat windowInsetsCompatOnApplyWindowInsets = androidx.core.view.objectCompat.onApplyWindowInsets(view, windowInsetsCompat);
        if (windowInsetsCompatOnApplyWindowInsets.isConsumed()) {
            return windowInsetsCompatOnApplyWindowInsets;
        }
        android.graphics.Rect rect = this.mTempRect;
        rect.left = windowInsetsCompatOnApplyWindowInsets.getSystemWindowInsetLeft();
        rect.top = windowInsetsCompatOnApplyWindowInsets.getSystemWindowInsetTop();
        rect.right = windowInsetsCompatOnApplyWindowInsets.getSystemWindowInsetRight();
        rect.bottom = windowInsetsCompatOnApplyWindowInsets.getSystemWindowInsetBottom();
        int childCount = this.this$0.getChildCount();
        for (int i = 0; i < childCount; i++) {
            androidx.core.view.WindowInsetsCompat windowInsetsCompatDispatchApplyWindowInsets = androidx.core.view.objectCompat.dispatchApplyWindowInsets(this.this$0.getChildAt(i), windowInsetsCompatOnApplyWindowInsets);
            rect.left = java.lang.Math.min(windowInsetsCompatDispatchApplyWindowInsets.getSystemWindowInsetLeft(), rect.left);
            rect.top = java.lang.Math.min(windowInsetsCompatDispatchApplyWindowInsets.getSystemWindowInsetTop(), rect.top);
            rect.right = java.lang.Math.min(windowInsetsCompatDispatchApplyWindowInsets.getSystemWindowInsetRight(), rect.right);
            rect.bottom = java.lang.Math.min(windowInsetsCompatDispatchApplyWindowInsets.getSystemWindowInsetBottom(), rect.bottom);
        }
        return windowInsetsCompatOnApplyWindowInsets.replaceSystemWindowInsets(rect.left, rect.top, rect.right, rect.bottom);
    }
}

